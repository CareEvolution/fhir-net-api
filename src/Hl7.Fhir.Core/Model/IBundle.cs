using System;
using System.Collections.Generic;
using System.Net.Http;
using Hl7.Fhir.Utility;

namespace Hl7.Fhir.Model
{
    public interface IBundle 
    {
        string TypeLiteral { get; }
        int? Total { get; }
        Uri FirstLink { get; }
        Uri PreviousLink { get; }
        Uri NextLink { get; }
        Uri LastLink { get; }
        IEnumerable<IBundleEntry> Entries { get; }
    }

    public interface IBundleEntry : IAnnotated
    {
        string FullUrl { get; }
        IResource Resource { get; }
        IBundleSearch Search { get; }
        IBundleRequest Request { get; }
        IBundleResponse Response { get; }
    }

    public interface IBundleSearch
    {
        string ModeLiteral { get; }
        decimal? Score { get; }
    }

    public interface IBundleRequest
    {
        HttpMethod HttpMethod { get; }
        string Url { get; }
        string IfNoneMatch { get; }
        DateTimeOffset? IfModifiedSince { get; }
        string IfMatch { get; }
        string IfNoneExist { get; }
    }

    public interface IBundleResponse
    {
        string Status { get; }
        string Location { get; }
        string Etag { get; }
        DateTimeOffset? LastModified { get; }
    }

    public interface IOperationOutcome
    {
        IReadOnlyList<IOperationIssue> Issue { get; }
    }

    public interface IOperationIssue
    {
        CommonIssueSeverity? Severity { get; }
        string Diagnostics { get; }
    }

    public enum CommonIssueSeverity
    {
        Fatal,
        Error,
        Warning,
        Information,
    }
}
