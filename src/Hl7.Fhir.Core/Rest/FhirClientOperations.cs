﻿/* 
 * Copyright (c) 2014, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/fhir-net-api/master/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.Model;
using Hl7.Fhir.Support;
using Hl7.Fhir.Utility;

namespace Hl7.Fhir.Rest
{
    /// <summary>
    /// Collection of the valid Operation values supported as const strings
    /// </summary>
    /// <remarks>
    /// This static class is required to keep the operation const values
    /// separate from the methods in the Fhir Client.
    /// Specifically the Meta operation clashes with the META const value.
    /// This would make it un-usable from VB.Net
    /// </remarks>
    public static partial class RestOperation
    {
        /// <summary>
        /// "translate" operation
        /// </summary>
        public const string TRANSLATE = "translate";

        /// <summary>
        /// "validate" operation
        /// </summary>
        public const string VALIDATE_RESOURCE = "validate";

        /// <summary>
        /// "everything" operation
        /// </summary>
        public const string FETCH_PATIENT_RECORD = "everything";

        /// <summary>
        /// "meta" operation
        /// </summary>
        public const string META = "meta";

        /// <summary>
        /// "meta-add" operation
        /// </summary>
        public const string META_ADD = "meta-add";

        /// <summary>
        /// "meta-delete" operation
        /// </summary>
        public const string META_DELETE = "meta-delete";
    }

    public static class FhirClientOperations
    {
        #region Validate (Create/Update/Delete/Resource)

        public static async Task<OperationOutcome> ValidateCreateAsync<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, DomainResource resource, FhirUri profile = null)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            if (resource == null) throw Error.ArgumentNull(nameof(resource));

            var par = new Parameters().Add("resource", resource).Add("mode", new Code("create"));
            if (profile != null) par.Add("profile", profile);

            return OperationResult<OperationOutcome>(await client.TypeOperationAsync(RestOperation.VALIDATE_RESOURCE, resource.TypeName, par).ConfigureAwait(false));
        }

        public static OperationOutcome ValidateCreate<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, DomainResource resource, FhirUri profile = null)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            return ValidateCreateAsync(client, resource, profile).WaitResult();
        }

        public static async Task<OperationOutcome> ValidateUpdateAsync<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, DomainResource resource, string id, FhirUri profile = null)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            if (id == null) throw Error.ArgumentNull(nameof(id));
            if (resource == null) throw Error.ArgumentNull(nameof(resource));

            var par = new Parameters().Add("resource", resource).Add("mode", new Code("update"));
            if (profile != null) par.Add("profile", profile);

            var loc = ResourceIdentity.Build(resource.TypeName, id);
            return OperationResult<OperationOutcome>(await client.InstanceOperationAsync(loc, RestOperation.VALIDATE_RESOURCE, par).ConfigureAwait(false));
        }

        public static OperationOutcome ValidateUpdate<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, DomainResource resource, string id,
            FhirUri profile = null)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            return ValidateUpdateAsync(client, resource, id, profile).WaitResult();
        }

        public static async Task<OperationOutcome> ValidateDeleteAsync<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, ResourceIdentity location)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            if (location == null) throw Error.ArgumentNull(nameof(location));

            var par = new Parameters().Add("mode", new Code("delete"));

            return OperationResult<OperationOutcome>(await client.InstanceOperationAsync(location.WithoutVersion().MakeRelative(), RestOperation.VALIDATE_RESOURCE, par).ConfigureAwait(false));
        }

        public static OperationOutcome ValidateDelete<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, ResourceIdentity location)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            return ValidateDeleteAsync(client,location).WaitResult();
        }

        public static async Task<OperationOutcome> ValidateResourceAsync<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, DomainResource resource, string id = null, FhirUri profile = null)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            if (resource == null) throw Error.ArgumentNull(nameof(resource));

            var par = new Parameters().Add("resource", resource);
            if (profile != null) par.Add("profile", profile);

            if (id == null)
            {
                return OperationResult<OperationOutcome>(await client.TypeOperationAsync(RestOperation.VALIDATE_RESOURCE, resource.TypeName, par).ConfigureAwait(false));
            }
            else
            {
                var loc = ResourceIdentity.Build(resource.TypeName, id);
                return OperationResult<OperationOutcome>(await client.InstanceOperationAsync(loc, RestOperation.VALIDATE_RESOURCE, par).ConfigureAwait(false));
            }
        }

        public static OperationOutcome ValidateResource<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, DomainResource resource,
            string id = null, FhirUri profile = null)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            return ValidateResourceAsync(client, resource, id, profile).WaitResult();
        }

        #endregion

        #region Fetch

        public static async Task<Model.DSTU2.Bundle> FetchPatientRecordAsync(this FhirDstu2Client client, Uri patient = null, FhirDateTime start = null, FhirDateTime end = null)
        {
            var par = new Parameters();

            if (start != null) par.Add("start", start);
            if (end != null) par.Add("end", end);
            
            Resource result;
            if (patient == null)
                result = await client.TypeOperationAsync<Model.DSTU2.Patient>(RestOperation.FETCH_PATIENT_RECORD, par).ConfigureAwait(false);
            else
            {
                var location = new ResourceIdentity(patient);
                result = await client.InstanceOperationAsync(location.WithoutVersion().MakeRelative(), RestOperation.FETCH_PATIENT_RECORD, par).ConfigureAwait(false);
            }

            return OperationResult<Model.DSTU2.Bundle>(result);
        }

        public static Model.DSTU2.Bundle FetchPatientRecord(this FhirDstu2Client client, Uri patient = null, FhirDateTime start = null, FhirDateTime end = null)
        {
            return FetchPatientRecordAsync(client, patient, start, end).WaitResult();
        }

        public static async Task<Model.STU3.Bundle> FetchPatientRecordAsync(this FhirStu3Client client, Uri patient = null, FhirDateTime start = null, FhirDateTime end = null)
        {
            var par = new Parameters();

            if (start != null) par.Add("start", start);
            if (end != null) par.Add("end", end);

            Resource result;
            if (patient == null)
                result = await client.TypeOperationAsync<Model.STU3.Patient>(RestOperation.FETCH_PATIENT_RECORD, par).ConfigureAwait(false);
            else
            {
                var location = new ResourceIdentity(patient);
                result = await client.InstanceOperationAsync(location.WithoutVersion().MakeRelative(), RestOperation.FETCH_PATIENT_RECORD, par).ConfigureAwait(false);
            }

            return OperationResult<Model.STU3.Bundle>(result);
        }

        public static Model.STU3.Bundle FetchPatientRecord(this FhirStu3Client client, Uri patient = null, FhirDateTime start = null, FhirDateTime end = null)
        {
            return FetchPatientRecordAsync(client, patient, start, end).WaitResult();
        }

        public static async Task<Model.R4.Bundle> FetchPatientRecordAsync(this FhirR4Client client, Uri patient = null, FhirDateTime start = null, FhirDateTime end = null)
        {
            var par = new Parameters();

            if (start != null) par.Add("start", start);
            if (end != null) par.Add("end", end);

            Resource result;
            if (patient == null)
                result = await client.TypeOperationAsync<Model.R4.Patient>(RestOperation.FETCH_PATIENT_RECORD, par).ConfigureAwait(false);
            else
            {
                var location = new ResourceIdentity(patient);
                result = await client.InstanceOperationAsync(location.WithoutVersion().MakeRelative(), RestOperation.FETCH_PATIENT_RECORD, par).ConfigureAwait(false);
            }

            return OperationResult<Model.R4.Bundle>(result);
        }

        public static Model.R4.Bundle FetchPatientRecord(this FhirR4Client client, Uri patient = null, FhirDateTime start = null, FhirDateTime end = null)
        {
            return FetchPatientRecordAsync(client, patient, start, end).WaitResult();
        }

        #endregion

        #region Meta

        //[base]/$meta
        public static async Task<Meta> MetaAsync<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            return extractMeta(OperationResult<Parameters>(await client.WholeSystemOperationAsync(RestOperation.META, useGet:true).ConfigureAwait(false)));
        }

        public static Meta Meta<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            return MetaAsync(client).WaitResult();
        }
        
        //[base]/Resource/$meta
        public static async Task<Meta> MetaAsync<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, ResourceType type)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            return extractMeta(OperationResult<Parameters>(await client.TypeOperationAsync(RestOperation.META, type.ToString(), useGet: true).ConfigureAwait(false)));
        }

        public static Meta Meta<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, ResourceType type)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            return MetaAsync(client, type).WaitResult();
        }

        //[base]/Resource/id/$meta/[_history/vid]
        public static async Task<Meta> MetaAsync<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, Uri location)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            Resource result;
            result = await client.InstanceOperationAsync(location, RestOperation.META, useGet: true).ConfigureAwait(false);

            return extractMeta(OperationResult<Parameters>(result));
        }

        public static Meta Meta<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, Uri location)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            return MetaAsync(client, location).WaitResult();
        }

        public static Task<Meta> MetaAsync<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, string location)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            return MetaAsync(client, new Uri(location, UriKind.RelativeOrAbsolute));
        }

        public static Meta Meta<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, string location)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            return MetaAsync(client, location).WaitResult();
        }

        public static async Task<Meta> AddMetaAsync<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, Uri location, Meta meta)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            var par = new Parameters().Add("meta", meta);
            return extractMeta(OperationResult<Parameters>(await client.InstanceOperationAsync(location, RestOperation.META_ADD, par).ConfigureAwait(false)));
        }

        public static Meta AddMeta<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, Uri location, Meta meta)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            return AddMetaAsync(client, location, meta).WaitResult();
        }
        
        public static Task<Meta> AddMetaAsync<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, string location, Meta meta)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            return AddMetaAsync(client, new Uri(location, UriKind.RelativeOrAbsolute), meta);
        }

        public static Meta AddMeta<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, string location, Meta meta)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            return AddMetaAsync(client, location, meta).WaitResult();
        }

        public static async Task<Meta> DeleteMetaAsync<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, Uri location, Meta meta)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            var par = new Parameters().Add("meta", meta);
            return extractMeta(OperationResult<Parameters>(await client.InstanceOperationAsync(location, RestOperation.META_DELETE, par).ConfigureAwait(false)));
        }

        public static Meta DeleteMeta<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, Uri location, Meta meta)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            return DeleteMetaAsync(client, location, meta).WaitResult();
        }

        public static Task<Meta> DeleteMetaAsync<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, string location, Meta meta)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            return DeleteMetaAsync(client, new Uri(location, UriKind.RelativeOrAbsolute), meta);
        }

        public static Meta DeleteMeta<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, string location, Meta meta)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            return DeleteMetaAsync(client, location, meta).WaitResult();
        }

        #endregion   

        #region Translate

        public class TranslateConceptDependency
        {
            public FhirUri Element;

            public CodeableConcept Concept;
        }


        public static async Task<Parameters> TranslateConceptAsync<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, string id, Code code, FhirUri system, FhirString version,
            FhirUri valueSet, Coding coding, CodeableConcept codeableConcept, FhirUri target, IEnumerable<TranslateConceptDependency> dependencies)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            Parameters par = createTranslateConceptParams(code, system, version, valueSet, coding, codeableConcept, target, dependencies);
            var loc = ResourceIdentity.Build("ConceptMap", id);
            return OperationResult<Parameters>(await client.InstanceOperationAsync(loc, RestOperation.TRANSLATE, par).ConfigureAwait(false));
        }

        public static Parameters TranslateConcept<TBundle, TMetadata>(this FhirClient<TBundle, TMetadata> client, string id, Code code, FhirUri system,
            FhirString version,
            FhirUri valueSet, Coding coding, CodeableConcept codeableConcept, FhirUri target,
            IEnumerable<TranslateConceptDependency> dependencies)
            where TBundle : Resource, IBundle
            where TMetadata : Resource, IMetadata
        {
            return TranslateConceptAsync(client, id, code, system, version, valueSet, coding, codeableConcept, target,
                dependencies).WaitResult();
        }

        public static async Task<Parameters> TranslateConceptAsync(this FhirDstu2Client client, Code code, FhirUri system, FhirString version,
            FhirUri valueSet, Coding coding, CodeableConcept codeableConcept, FhirUri target, IEnumerable<TranslateConceptDependency> dependencies )
        {
            Parameters par = createTranslateConceptParams(code, system, version, valueSet, coding, codeableConcept, target, dependencies);

            return OperationResult<Parameters>(await client.TypeOperationAsync<Model.DSTU2.ConceptMap>(RestOperation.TRANSLATE, par).ConfigureAwait(false));
        }

        public static Parameters TranslateConcept(this FhirDstu2Client client, Code code, FhirUri system, FhirString version,
            FhirUri valueSet, Coding coding, CodeableConcept codeableConcept, FhirUri target,
            IEnumerable<TranslateConceptDependency> dependencies)
        {
            return TranslateConceptAsync(client, code, system, version, valueSet, coding, codeableConcept, target,
                dependencies).WaitResult();
        }

        public static async Task<Parameters> TranslateConceptAsync(this FhirStu3Client client, Code code, FhirUri system, FhirString version,
            FhirUri valueSet, Coding coding, CodeableConcept codeableConcept, FhirUri target, IEnumerable<TranslateConceptDependency> dependencies)
        {
            Parameters par = createTranslateConceptParams(code, system, version, valueSet, coding, codeableConcept, target, dependencies);

            return OperationResult<Parameters>(await client.TypeOperationAsync<Model.STU3.ConceptMap>(RestOperation.TRANSLATE, par).ConfigureAwait(false));
        }

        public static Parameters TranslateConcept(this FhirStu3Client client, Code code, FhirUri system, FhirString version,
            FhirUri valueSet, Coding coding, CodeableConcept codeableConcept, FhirUri target,
            IEnumerable<TranslateConceptDependency> dependencies)
        {
            return TranslateConceptAsync(client, code, system, version, valueSet, coding, codeableConcept, target,
                dependencies).WaitResult();
        }

        #endregion

        #region Private
        private static Parameters createTranslateConceptParams(Code code, FhirUri system, FhirString version, FhirUri valueSet, Coding coding, CodeableConcept codeableConcept,
            FhirUri target, IEnumerable<TranslateConceptDependency> dependencies)
        {
            if (target == null) throw new ArgumentNullException("target");

            var par = new Parameters().Add("target", target);

            if (code != null) par.Add("code", code);
            if (system != null) par.Add("system", system);
            if (version != null) par.Add("version", version);
            if (valueSet != null) par.Add("valueSet", valueSet);
            if (coding != null) par.Add("coding", coding);
            if (codeableConcept != null) par.Add("codeableConcept", codeableConcept);

            if (dependencies != null && dependencies.Any())
            {
                foreach (var dependency in dependencies)
                {
                    var dependencyPar = new List<Tuple<string, Base>>();

                    if (dependency.Element != null) dependencyPar.Add(Tuple.Create("element", (Base)dependency.Element));
                    if (dependency.Concept != null) dependencyPar.Add(Tuple.Create("concept", (Base)dependency.Concept));

                    par.Add("dependency", dependencyPar);
                }
            }

            return par;
        }

        internal static T OperationResult<T>(this Resource result) where T : Resource
        {
            if (result == null) return null;

            //If this is immediately what we are expecting, that's fine
            if (result is T) return (T)result;

            // If return value is a Parameters object with a single result of the expected type,
            // return it (it should be called "return", but I don't care).
            if (result is Parameters pars && pars.Parameter.Count == 1 && pars.Parameter[0].Resource is T)
                return (T)pars.Parameter[0].Resource;

            // Else, throw. The return type is unexpected
            throw Error.InvalidOperation($"Operation did not return a {typeof(T).Name} but a {result.GetType().Name}");
        }

        private static Meta extractMeta(Parameters parms)
        {
            if (!parms.Parameter.IsNullOrEmpty())
            {
                var parm = parms.Parameter[0];
                if (parm != null)
                {
                    if (parm.Value is Meta)
                        return (Meta)parm.Value;
                }
            }

            return null;
        }

        #endregion
    }
}
