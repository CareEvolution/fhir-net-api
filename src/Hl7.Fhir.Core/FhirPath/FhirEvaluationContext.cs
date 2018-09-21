/* 
 * Copyright (c) 2016, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using System;
using Hl7.Fhir.ElementModel;
using Hl7.FhirPath;

namespace Hl7.Fhir.FhirPath
{
    public class FhirEvaluationContext : EvaluationContext
    {
        public new static FhirEvaluationContext CreateDefault() => new FhirEvaluationContext();

        public FhirEvaluationContext() : base()
        {
        }

        public FhirEvaluationContext(ITypedElement context) : base(context)
        {
        }

        public Func<string, ITypedElement> ElementResolver { get; set; }
    }
}
