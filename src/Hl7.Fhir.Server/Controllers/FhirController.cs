using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hl7.Fhir.Rest;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hl7.Fhir.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
           
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    //public interface IFhirServerFactory
    //{
    //    IFhirServer GetServer(string routePrefix);
    //}

    //public interface IFhirController
    //{
    //    void OnUnhandledException(HttpActionExecutedContext context);
    //    void OnAuthorization(HttpActionContext actionContext);
    //}

    //[RoutePrefix(FhirHost.RoutePrefix)]
    //[EnableCors("*", "*", "*", "*")]
    //[FhirController()]
    //[FhirExceptionFilter()]
    //[FhirAuthorizationFilter]
    //[RouteDataValuesOnly]
    public class FhirController : ControllerBase
    {
        public FhirController(IFhirServerFactory serverFactory, IAuthorizer authorizer, IExceptionLogger exceptionLogger)
        {
            _serverFactory = serverFactory ?? throw new ArgumentNullException(nameof(serverFactory));
            _authorizer = authorizer ?? throw new ArgumentNullException(nameof(authorizer));
            _exceptionLogger = exceptionLogger;
        }

        // ============= Instance Level Interactions

        [HttpGet, Route("{type}/{id}")]
        public IActionResult Read(string type, string id)
        {
            var parameters = Request.Query;
            if (parameters != null &&
                parameters.Any(parameter => parameter.Key == SearchParams.SEARCH_PARAM_SUMMARY && parameter.Value != "false"))
            {
                throw new FhirNotSupportedModifierException(SearchParams.SEARCH_PARAM_SUMMARY);
            }

            var requestArgs = GetRequestArguments(2);
            var entry = requestArgs.Server.Read(requestArgs.Context, type, id);
            return Request.CreateFhirResourceResponse(requestArgs.Version, entry);
        }

        [HttpGet, Route("{type}/{id}/_history/{vid}")]
        public IActionResult VRead(string type, string id, string vid)
        {
            return StatusCode(StatusCodes.Status501NotImplemented);
        }

        [HttpPut, Route("{type}/{id}")]
        public HttpResponseMessage Update(string type, string id, HttpRequestMessage request)
        {
            return Upsert(GetRequestArguments(2), type, id, request);
        }

        [HttpPost, Route("{type}")]
        public HttpResponseMessage Create(string type, HttpRequestMessage request)
        {
            return Upsert(GetRequestArguments(1), type, null, request);
        }

        [HttpDelete, Route("{type}/{id}")]
        public HttpResponseMessage Delete(string type, string id)
        {
            var requestArgs = GetRequestArguments(2);
            requestArgs.Server.Delete(requestArgs.Context, type, id);
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }

        [HttpGet, Route("{type}/{id}/_history")]
        public HttpResponseMessage History(string type, string id)
        {
            throw new FhirVersioningNotImplementedException();
        }

        [HttpGet, Route("{compartmentName}/{compartmentID}/{type}")]
        public HttpResponseMessage CompartmentSearch(string compartmentName, string compartmentID, string type)
        {
            var parameters = Request.GetSearchParams();
            var requestArgs = GetRequestArguments(3);
            var result = requestArgs.Server.Search(requestArgs.Context, compartmentName, compartmentID, type, parameters);
            return Request.CreateFhirResponse(requestArgs.Version, result);
        }

        [HttpGet, Route("{type}/{id}/${operation}")]
        public HttpResponseMessage InstanceOperation(string type, string id, string operation)
        {
            return Operation(GetRequestArguments(3), operation, type, id);
        }

        [HttpPost, Route("{type}/{id}/${operation}")]
        public HttpResponseMessage InstanceOperation(string type, string id, string operation, HttpRequestMessage request)
        {
            return Operation(GetRequestArguments(3), operation, type, id, request);
        }

        [HttpGet, Route("{type}/{id}/_history/{vid}/${operation}")]
        public HttpResponseMessage VersionOperation(string type, string id, string vid, string operation)
        {
            throw new FhirVersioningNotImplementedException();
        }

        [HttpPost, Route("{type}/{id}/_history/{vid}/${operation}")]
        public HttpResponseMessage VersionOperation(string type, string id, string vid, string operation, HttpRequestMessage request)
        {
            throw new FhirVersioningNotImplementedException();
        }

        // ============= Type Level Interactions

        [HttpGet, Route("{type}")]
        public HttpResponseMessage Search(string type)
        {
            var parameters = Request.GetSearchParams();
            var requestArgs = GetRequestArguments(1);
            var result = requestArgs.Server.Search(requestArgs.Context, null, null, type, parameters);
            return Request.CreateFhirResponse(requestArgs.Version, result);
        }

        [HttpPost, Route("{type}/_search")]
        public HttpResponseMessage SearchWithPost(string type, IFormCollection requestData)
        {
            var parameters = HttpRequestExtensions.GetSearchParams(requestData);
            var requestArgs = GetRequestArguments(2);
            var result = requestArgs.Server.Search(requestArgs.Context, null, null, type, parameters);
            return Request.CreateFhirResponse(requestArgs.Version, result);
        }

        [HttpGet, Route("{type}/_history")]
        public HttpResponseMessage History(string type)
        {
            throw new FhirVersioningNotImplementedException();
        }

        [HttpGet, Route("{type}/${operation}")]
        public HttpResponseMessage TypeOperation(string type, string operation)
        {
            return Operation(GetRequestArguments(2), operation, type, null);
        }

        [HttpPost, Route("{type}/${operation}")]
        public HttpResponseMessage TypeOperation(string type, string operation, HttpRequestMessage request)
        {
            return Operation(GetRequestArguments(2), operation, type, null, request);
        }

        // ============= Whole System Interactions

        [HttpGet, AllowAnonymous, Route("metadata")]
        public HttpResponseMessage Metadata()
        {
            var requestArgs = GetRequestArguments(1);
            var result = requestArgs.Server.Metadata(requestArgs.Context);
            return Request.CreateFhirResponse(requestArgs.Version, result);
        }

        [HttpOptions, AllowAnonymous, Route("")]
        public HttpResponseMessage Options()
        {
            var requestArgs = GetRequestArguments(0);
            var result = requestArgs.Server.Metadata(requestArgs.Context);
            return Request.CreateFhirResponse(requestArgs.Version, result);
        }

        [HttpGet, Route("")]
        public HttpResponseMessage SystemSearch()
        {
            var requestArgs = GetRequestArguments(0);
            throw new FhirNotImplementedException(
                string.Format(
                    "This is the FHIR server base URL. Unable to handle this request, as it does not contain a resource type or operation name. Use {0}/metadata to get the conformance statement, {0}/Patient to search Patients.",
                    requestArgs.Context.EndPoint
                )
            );
        }

        [HttpPost, Route("")]
        public HttpResponseMessage Transaction(HttpRequestMessage request)
        {
            var requestArgs = GetRequestArguments(0);
            var resource = Request.GetFhirResource(requestArgs.Version);
            var result = requestArgs.Server.Transaction(requestArgs.Context, resource);
            return Request.CreateFhirResponse(requestArgs.Version, result);
        }

        [HttpGet, Route("_history")]
        public HttpResponseMessage History()
        {
            throw new FhirVersioningNotImplementedException();
        }

        [HttpGet, Route("${operation}")]
        public HttpResponseMessage SystemOperation(string operation)
        {
            return Operation(GetRequestArguments(1), operation, null, null);
        }

        [HttpPost, Route("${operation}")]
        public HttpResponseMessage SystemOperation(string operation, HttpRequestMessage request)
        {
            return Operation(GetRequestArguments(1), operation, null, null, request);
        }

        public void OnAuthorization(HttpActionContext actionContext)
        {
            _authorizer.Authorize(actionContext);
        }

        public void OnUnhandledException(HttpActionExecutedContext context)
        {
            if (_exceptionLogger != null)
            {
                _exceptionLogger.Log(context);
            }
        }

        private HttpResponseMessage Operation(RequestArguments requestArgs, string operation, string type, string id)
        {
            var result = requestArgs.Server.Operation(requestArgs.Context, operation, type, id, Request.GetQueryNameValueTuples());
            return Request.CreateFhirResponse(requestArgs.Version, result);
        }

        private HttpResponseMessage Operation(RequestArguments requestArgs, string operation, string type, string id, HttpRequestMessage request)
        {
            var resource = Request.GetFhirResource(requestArgs.Version);
            var parametersResource = resource as FhirModel.Parameters;
            if (parametersResource == null)
            {
                throw new FhirUnexpectedResourceTypeException(
                    MappingHelper.GetResourceType<FhirModel.Parameters>(),
                    resource?.TypeName ?? "<None>"
                );
            }
            var result = requestArgs.Server.Operation(requestArgs.Context, operation, type, id, parametersResource);
            return Request.CreateFhirResponse(requestArgs.Version, result);
        }

        private HttpResponseMessage Upsert(RequestArguments requestArgs, string type, string id, HttpRequestMessage request)
        {
            var resource = Request.GetFhirResource(requestArgs.Version);
            var createdAndSelfLink = requestArgs.Server.CreateOrUpdate(requestArgs.Context, type, id ?? resource.Id, resource);
            var msg = Request.CreateResponse(
                createdAndSelfLink.Item1 ? HttpStatusCode.Created : HttpStatusCode.OK
            );
            msg.Headers.Location = createdAndSelfLink.Item2;
            return msg;
        }

        private RequestArguments GetRequestArguments(int variableSegments)
        {
            string routePrefix;
            var requestEndPoint = UriHelper.GetRequestEndPoint(Request.RequestUri, variableSegments, out routePrefix);

            var server = _serverFactory.GetServer(routePrefix);
            if (server == null)
            {
                throw new InvalidOperationException(
                    string.Format("Unexpected request URI '{0}': unknown route prefix '{1}'", Request.RequestUri, routePrefix)
                );
            }

            return new RequestArguments(server, requestEndPoint, LogInfoBuilder.GetFrom(Request));
        }

        private class RequestArguments
        {
            public RequestArguments(IFhirServer server, string endPoint, LogInfoBuilder logInfoBuilder)
            {
                Server = server ?? throw new ArgumentNullException(nameof(server));
                Context = new RequestContext(endPoint, logInfoBuilder);
            }

            public IFhirServer Server { get; }

            public RequestContext Context { get; }

            public FhirModel.Version Version
            {
                get { return Server.Version; }
            }
        }

        private readonly IFhirServerFactory _serverFactory;
        private readonly IAuthorizer _authorizer;
        private readonly IExceptionLogger _exceptionLogger;
    }

    public interface IAuthorizer
    {
        void Authorize(HttpActionContext actionContext);
    }

    /// <summary>
    /// 'Dummy' authorizer that acts as a specific user setting directly the current principal
    /// </summary>
    public class ActingAsAuthorizer : IAuthorizer
    {
        private ActingAsAuthorizer(Guid userID, string userName, short applicationID)
        {
            UserID = userID;
            _userName = userName;
            _applicationID = applicationID;
        }

        public void Authorize(HttpActionContext actionContext)
        {
            var identity = new ClaimsIdentity(AuthenticationMethod.Password.ToString());
            identity.AddClaim(new Claim(UserClaimTypes.UserID, UserID.ToString()));
            identity.AddClaim(new Claim(ClaimTypes.Name, _userName));
            identity.AddClaim(new Claim(UserClaimTypes.ApplicationID, _applicationID.ToString()));
            var principal = new ClaimsPrincipal(new[] { identity });
            Thread.CurrentPrincipal = principal;
            actionContext.RequestContext.Principal = principal;
        }

        public Guid UserID { get; }

        public static ActingAsAuthorizer Create(Adapter.Primitives.ILocalData localData, string userName, short applicationID)
        {
            if (localData == null) throw new ArgumentNullException(nameof(localData));
            if (string.IsNullOrEmpty(userName)) throw new ArgumentNullException(nameof(userName));

            var userInfo = localData.GetUserInfoByUserName(userName);
            if (userInfo == null)
            {
                throw new ArgumentException($"There is no user '{userName}'");
            }
            return new ActingAsAuthorizer(userInfo.ID, userName, applicationID);
        }

        private readonly string _userName;
        private readonly short _applicationID;
    }

    public interface ISimpleExceptionLogger
    {
        void Log(Exception exception);
    }

    public interface IExceptionLogger
    {
        void Log(HttpActionExecutedContext context);
    }
}

