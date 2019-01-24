using Hl7.Fhir.ElementModel;
using System;
using System.Collections.Generic;

namespace Hl7.FhirPath
{
    public class EvaluationContext
    {
        public static EvaluationContext CreateDefault() => new EvaluationContext();

        public EvaluationContext()
        {
            // no defaults yet
        }

        public EvaluationContext(ITypedElement container)
        {
            Container = container;
        }

        public ITypedElement Container { get; set; }

        public Action<string, IEnumerable<ITypedElement>> Tracer { get; set; }
    }
}