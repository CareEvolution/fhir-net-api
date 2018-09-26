/* 
 * Copyright (c) 2016, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Model;
using Hl7.FhirPath;
using System;

namespace Hl7.Fhir.FhirPath
{
    public class FhirEvaluationContext : EvaluationContext
    {
        [Obsolete("Please use CreateDefault() instead of this member, which may cause raise conditions.")]
        new public static readonly FhirEvaluationContext Default = new FhirEvaluationContext();

        public static new FhirEvaluationContext CreateDefault() => new FhirEvaluationContext();

        public FhirEvaluationContext() : base()
        {
        }

        public FhirEvaluationContext(Resource context) : base(context?.ToTypedElement())
        {
        }

        public FhirEvaluationContext(ITypedElement context) : base(context)
        {
        }

        public Func<string, ITypedElement> ElementResolver { get; set; }
    }
}
