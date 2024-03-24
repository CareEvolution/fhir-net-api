/* 
 * Copyright (c) 2018, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/fhir-net-api/master/LICENSE
 */

using Hl7.Fhir.Utility;

namespace Hl7.Fhir.Serialization
{
    public class BaseFhirSerializer
    {
        public readonly SerializerSettings Settings;

        public BaseFhirSerializer(Model.Version version)
        {
            Settings = new SerializerSettings(version);
        }

        public BaseFhirSerializer(SerializerSettings settings)
        {
            if (settings == null) throw Error.ArgumentNull(nameof(settings));

            Settings = settings.Clone();
        }
    }
}
