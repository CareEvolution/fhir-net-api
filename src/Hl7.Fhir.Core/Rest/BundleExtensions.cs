/* 
 * Copyright (c) 2014, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using System;
using System.Threading.Tasks;
using Hl7.Fhir.Model.DSTU2;
using Hl7.Fhir.Utility;

namespace Hl7.Fhir.Rest.DSTU2
{
    public static class BundleExtensions
    {
        public static async Task<Bundle> RefreshBundleAsync(this FhirClient client, Bundle bundle)
        {
            if (bundle == null) throw Error.ArgumentNull(nameof(bundle));

            if (bundle.Type != Bundle.BundleType.Searchset)
                throw Error.Argument("Refresh is only applicable to bundles of type 'searchset'");

            // Clone old bundle, without the entries (so, just the header)
            Bundle result = (Bundle)bundle.DeepCopy();

            result.Id = "urn:uuid:" + Guid.NewGuid().ToString("n");
            result.Meta = new Meta();
            result.Meta.LastUpdated = DateTimeOffset.Now;

            foreach (var entry in result.Entry)
            {
                if (entry.Resource != null)
                {
                    entry.Resource = await client.ReadAsync<Resource>(entry.FullUrl).ConfigureAwait(false);
                }
            }

            return result;
        }

        public static Bundle RefreshBundle(this FhirClient client, Bundle bundle)
        {
            return RefreshBundleAsync(client, bundle).WaitResult();
        }
    }
}
