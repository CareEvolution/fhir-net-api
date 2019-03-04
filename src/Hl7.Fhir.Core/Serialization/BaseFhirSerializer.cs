/* 
 * Copyright (c) 2018, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/fhir-net-api/master/LICENSE
 */

using Hl7.Fhir.Specification;

namespace Hl7.Fhir.Serialization
{
    public class BaseFhirSerializer
    {
        public readonly SerializerSettings Settings;
        protected readonly IModelInfo _modelInfo;

        public BaseFhirSerializer(IModelInfo modelInfo, SerializerSettings settings)
        {
            Settings = settings?.Clone() ?? new SerializerSettings();
            _modelInfo = modelInfo;
        }
    }
}
