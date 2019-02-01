﻿using System;
using System.Net;
using System.Threading.Tasks;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace Hl7.Fhir.Rest
{
    public interface IFhirClient<TResourceBase,TBundle,TConformance>
        where TBundle : TResourceBase
        where TConformance : TResourceBase
    {
#if !NETSTANDARD1_1
        bool PreferCompressedResponses { get; set; }
        bool CompressRequestBody { get; set; }
#endif
        Uri Endpoint { get; }
        ParserSettings ParserSettings { get; set; }
        ResourceFormat PreferredFormat { get; set; }
        bool ReturnFullResource { get; set; }
        int Timeout { get; set; }
        bool UseFormatParam { get; set; }
        bool VerifyFhirVersion { get; set; }

        TConformance Conformance(SummaryType? summary = default(SummaryType?));
        Task<TConformance> ConformanceAsync(SummaryType? summary = default(SummaryType?));
        TBundle Continue(TBundle current, PageDirection direction = PageDirection.Next);
        Task<TBundle> ContinueAsync(TBundle current, PageDirection direction = PageDirection.Next);
        TResource Create<TResource>(TResource resource) where TResource : TResourceBase;
        TResource Create<TResource>(TResource resource, SearchParams condition) where TResource : TResourceBase;
        Task<TResource> CreateAsync<TResource>(TResource resource) where TResource : TResourceBase;
        Task<TResource> CreateAsync<TResource>(TResource resource, SearchParams condition) where TResource : TResourceBase;
        void Delete(TResourceBase resource);
        void Delete(string location);
        void Delete(string resourceType, SearchParams condition);
        void Delete(Uri location);
        Task DeleteAsync(TResourceBase resource);
        Task DeleteAsync(string location);
        Task DeleteAsync(string resourceType, SearchParams condition);
        Task DeleteAsync(Uri location);
        Task<TResource> executeAsync<TResource>(TBundle tx, HttpStatusCode expect) where TResource : TResourceBase;
        TResourceBase Get(string url);
        TResourceBase Get(Uri url);
        Task<TResourceBase> GetAsync(string url);
        Task<TResourceBase> GetAsync(Uri url);
        TBundle History(string location, DateTimeOffset? since = default(DateTimeOffset?), int? pageSize = default(int?), SummaryType summary = SummaryType.False);
        TBundle History(Uri location, DateTimeOffset? since = default(DateTimeOffset?), int? pageSize = default(int?), SummaryType summary = SummaryType.False);
        Task<TBundle> HistoryAsync(string location, DateTimeOffset? since = default(DateTimeOffset?), int? pageSize = default(int?), SummaryType summary = SummaryType.False);
        Task<TBundle> HistoryAsync(Uri location, DateTimeOffset? since = default(DateTimeOffset?), int? pageSize = default(int?), SummaryType summary = SummaryType.False);
        TResourceBase InstanceOperation(Uri location, string operationName, IParameters parameters = null, bool useGet = false);
        Task<TResourceBase> InstanceOperationAsync(Uri location, string operationName, IParameters parameters = null, bool useGet = false);
        TResourceBase Operation(Uri operation, IParameters parameters = null, bool useGet = false);
        TResourceBase Operation(Uri location, string operationName, IParameters parameters = null, bool useGet = false);
        Task<TResourceBase> OperationAsync(Uri operation, IParameters parameters = null, bool useGet = false);
        Task<TResourceBase> OperationAsync(Uri location, string operationName, IParameters parameters = null, bool useGet = false);
        TResource Read<TResource>(string location, string ifNoneMatch = null, DateTimeOffset? ifModifiedSince = default(DateTimeOffset?)) where TResource : TResourceBase;
        TResource Read<TResource>(Uri location, string ifNoneMatch = null, DateTimeOffset? ifModifiedSince = default(DateTimeOffset?)) where TResource : TResourceBase;
        Task<TResource> ReadAsync<TResource>(string location, string ifNoneMatch = null, DateTimeOffset? ifModifiedSince = default(DateTimeOffset?)) where TResource : TResourceBase;
        Task<TResource> ReadAsync<TResource>(Uri location, string ifNoneMatch = null, DateTimeOffset? ifModifiedSince = default(DateTimeOffset?)) where TResource : TResourceBase;
        TResource Refresh<TResource>(TResource current) where TResource : TResourceBase;
        Task<TResource> RefreshAsync<TResource>(TResource current) where TResource : TResourceBase;
        TBundle Search(SearchParams q, string resourceType = null);
        TBundle Search(string resource, string[] criteria = null, string[] includes = null, int? pageSize = default(int?), SummaryType? summary = default(SummaryType?), string[] revIncludes = null);
        TBundle Search<TResource>(string[] criteria = null, string[] includes = null, int? pageSize = default(int?), SummaryType? summary = default(SummaryType?), string[] revIncludes = null) where TResource : TResourceBase, new();
        TBundle Search<TResource>(SearchParams q) where TResource : TResourceBase;
        Task<TBundle> SearchAsync(SearchParams q, string resourceType = null);
        Task<TBundle> SearchAsync(string resource, string[] criteria = null, string[] includes = null, int? pageSize = default(int?), SummaryType? summary = default(SummaryType?), string[] revIncludes = null);
        Task<TBundle> SearchAsync<TResource>(string[] criteria = null, string[] includes = null, int? pageSize = default(int?), SummaryType? summary = default(SummaryType?), string[] revIncludes = null) where TResource : TResourceBase, new();
        Task<TBundle> SearchAsync<TResource>(SearchParams q) where TResource : TResourceBase;


        TBundle SearchUsingPost(SearchParams q, string resourceType = null);
        TBundle SearchUsingPost<TResource>(SearchParams q) where TResource : TResourceBase;
        Task<TBundle> SearchUsingPostAsync(SearchParams q, string resourceType = null);
        Task<TBundle> SearchUsingPostAsync<TResource>(SearchParams q) where TResource : TResourceBase;
        Task<TBundle> SearchUsingPostAsync<TResource>(string[] criteria = null, string[] includes = null, int? pageSize = null, SummaryType? summary = null, string[] revIncludes = null) where TResource : TResourceBase, new();
        TBundle SearchUsingPost<TResource>(string[] criteria = null, string[] includes = null, int? pageSize = null, SummaryType? summary = null, string[] revIncludes = null) where TResource : TResourceBase, new();
        Task<TBundle> SearchUsingPostAsync(string resource, string[] criteria = null, string[] includes = null, int? pageSize = null, SummaryType? summary = null, string[] revIncludes = null);
        TBundle SearchUsingPost(string resource, string[] criteria = null, string[] includes = null, int? pageSize = null, SummaryType? summary = null, string[] revIncludes = null);

        TBundle SearchById(string resource, string id, string[] includes = null, int? pageSize = default(int?), string[] revIncludes = null);
        TBundle SearchById<TResource>(string id, string[] includes = null, int? pageSize = default(int?), string[] revIncludes = null) where TResource : TResourceBase, new();
        Task<TBundle> SearchByIdAsync(string resource, string id, string[] includes = null, int? pageSize = default(int?), string[] revIncludes = null);
        Task<TBundle> SearchByIdAsync<TResource>(string id, string[] includes = null, int? pageSize = default(int?), string[] revIncludes = null) where TResource : TResourceBase, new();

        TBundle SearchByIdUsingPost(string resource, string id, string[] includes = null, int? pageSize = null, string[] revIncludes = null);
        TBundle SearchByIdUsingPost<TResource>(string id, string[] includes = null, int? pageSize = null, string[] revIncludes = null) where TResource : TResourceBase, new();
        Task<TBundle> SearchByIdUsingPostAsync(string resource, string id, string[] includes = null, int? pageSize = null, string[] revIncludes = null);
        Task<TBundle> SearchByIdUsingPostAsync<TResource>(string id, string[] includes = null, int? pageSize = null, string[] revIncludes = null) where TResource : TResourceBase, new();

        TBundle Transaction(TBundle bundle);
        Task<TBundle> TransactionAsync(TBundle bundle);
        TBundle TypeHistory(string resourceType, DateTimeOffset? since = default(DateTimeOffset?), int? pageSize = default(int?), SummaryType summary = SummaryType.False);
        TBundle TypeHistory<TResource>(DateTimeOffset? since = default(DateTimeOffset?), int? pageSize = default(int?), SummaryType summary = SummaryType.False) where TResource : TResourceBase, new();
        Task<TBundle> TypeHistoryAsync(string resourceType, DateTimeOffset? since = default(DateTimeOffset?), int? pageSize = default(int?), SummaryType summary = SummaryType.False);
        Task<TBundle> TypeHistoryAsync<TResource>(DateTimeOffset? since = default(DateTimeOffset?), int? pageSize = default(int?), SummaryType summary = SummaryType.False) where TResource : TResourceBase, new();
        TResourceBase TypeOperation(string operationName, string typeName, IParameters parameters = null, bool useGet = false);
        TResourceBase TypeOperation<TResource>(string operationName, IParameters parameters = null, bool useGet = false) where TResource : TResourceBase;
        Task<TResourceBase> TypeOperationAsync(string operationName, string typeName, IParameters parameters = null, bool useGet = false);
        Task<TResourceBase> TypeOperationAsync<TResource>(string operationName, IParameters parameters = null, bool useGet = false) where TResource : TResourceBase;
        TResource Update<TResource>(TResource resource, bool versionAware = false) where TResource : TResourceBase;
        TResource Update<TResource>(TResource resource, SearchParams condition, bool versionAware = false) where TResource : TResourceBase;
        Task<TResource> UpdateAsync<TResource>(TResource resource, bool versionAware = false) where TResource : TResourceBase;
        Task<TResource> UpdateAsync<TResource>(TResource resource, SearchParams condition, bool versionAware = false) where TResource : TResourceBase;
        TBundle WholeSystemHistory(DateTimeOffset? since = default(DateTimeOffset?), int? pageSize = default(int?), SummaryType summary = SummaryType.False);
        Task<TBundle> WholeSystemHistoryAsync(DateTimeOffset? since = default(DateTimeOffset?), int? pageSize = default(int?), SummaryType summary = SummaryType.False);
        TResourceBase WholeSystemOperation(string operationName, IParameters parameters = null, bool useGet = false);
        Task<TResourceBase> WholeSystemOperationAsync(string operationName, IParameters parameters = null, bool useGet = false);
        TBundle WholeSystemSearch(string[] criteria = null, string[] includes = null, int? pageSize = default(int?), SummaryType? summary = default(SummaryType?), string[] revIncludes = null);
        Task<TBundle> WholeSystemSearchAsync(string[] criteria = null, string[] includes = null, int? pageSize = default(int?), SummaryType? summary = default(SummaryType?), string[] revIncludes = null);

        Task<TBundle> WholeSystemSearchUsingPostAsync(string[] criteria = null, string[] includes = null, int? pageSize = null, SummaryType? summary = null, string[] revIncludes = null);
        TBundle WholeSystemSearchUsingPost(string[] criteria = null, string[] includes = null, int? pageSize = null, SummaryType? summary = null, string[] revIncludes = null);
    }
}