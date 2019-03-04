/* 
 * Copyright (c) 2018, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/fhir-net-api/master/LICENSE
 */

using System;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Model;
using Hl7.Fhir.Specification;

namespace Hl7.Fhir.Serialization
{
    public class BaseFhirParser
    {
        protected readonly IModelInfo _modelInfo;
        protected readonly ParserSettings _parserSettings;

        public BaseFhirParser(IModelInfo modelInfo, ParserSettings settings = null)
        {
            _parserSettings = settings ?? new ParserSettings();
            _modelInfo = modelInfo;
        }

        private PocoBuilderSettings buildPocoBuilderSettings(ParserSettings ps) =>
            new PocoBuilderSettings
            {
                AllowUnrecognizedEnums = ps.AllowUnrecognizedEnums,
                IgnoreUnknownMembers = ps.AcceptUnknownMembers
            };

        public Base Parse(ITypedElement element) => element.ToPoco(_modelInfo, buildPocoBuilderSettings(_parserSettings));

        public T Parse<T>(ITypedElement element) where T : Base => element.ToPoco<T>(_modelInfo, buildPocoBuilderSettings(_parserSettings));

        public Base Parse(ISourceNode node, Type type = null) => node.ToPoco(_modelInfo, type, buildPocoBuilderSettings(_parserSettings));

        public T Parse<T>(ISourceNode node) where T : Base => node.ToPoco<T>(_modelInfo, buildPocoBuilderSettings(_parserSettings));
    }
}
