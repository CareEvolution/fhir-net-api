﻿/* 
 * Copyright (c) 2016, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.ElementModel.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Model.R4;
using Hl7.FhirPath;
using Hl7.FhirPath.Expressions;

namespace Hl7.Fhir.FhirPath.R4
{
    public static class ElementNavFhirExtensions
    {
        internal static bool _fhirSymbolTableExtensionsAdded = false;
        public static void PrepareFhirSymbolTableFunctions()
        {
            if (!_fhirSymbolTableExtensionsAdded)
            {
                _fhirSymbolTableExtensionsAdded = true;
                Hl7.FhirPath.FhirPathCompiler.DefaultSymbolTable.AddFhirExtensions();
            }
        }

        public static Func<string, ITypedElement> ToFhirPathResolver(this Func<string, Resource> resolver)
        {
            return navResolver;

            ITypedElement navResolver(string url)
            {
                var resource = resolver(url);
                return resource?.ToTypedElement();
            }
        }

        public static SymbolTable AddFhirExtensions(this SymbolTable t)
        {
            t.Add("hasValue", (ITypedElement f) => f.HasValue(), doNullProp: false);
            t.Add("resolve", (ITypedElement f, EvaluationContext ctx) => resolver(f, ctx), doNullProp: false);
            t.Add("htmlchecks", (ITypedElement f) => f.HtmlChecks(), doNullProp: false);

            return t;

            ITypedElement resolver(ITypedElement f, EvaluationContext ctx)
            {
                if (ctx is FhirEvaluationContext fctx)
                    return f.Resolve(fctx.ElementResolver);
                else
                    return f.Resolve();
            }
        }

        /// <summary>
        /// Check if the node has a value, and not just extensions.
        /// </summary>
        /// <param name="focus"></param>
        /// <returns></returns>
        public static bool HasValue(this ITypedElement focus)
        {
            if (focus == null)
                return false;
            if (focus.Value == null)
                return false;
            return true;
        }

        /// <summary>
        /// Check if the node has a value, and not just extensions.
        /// </summary>
        /// <param name="focus"></param>
        /// <returns></returns>
        public static bool HtmlChecks(this ITypedElement focus)
        {
            if (focus == null)
                return false;
            if (focus.Value == null)
                return false;
            // Perform the checking of the content for valid html content
            var html = focus.Value.ToString();
            // TODO: Perform the checking
            return true;
        }


        public static IEnumerable<Base> ToFhirValues(this IEnumerable<ITypedElement> results)
        {
            return results.Select(r =>
            {
                if (r == null)
                    return null;

                if (r is PocoNavigator pnav && pnav.FhirValue != null)
                {
                    return pnav.FhirValue;
                }

                object result;

                if (r.Value is Hl7.FhirPath.ConstantValue)
                {
                    result = (r.Value as Hl7.FhirPath.ConstantValue).Value;
                }
                else
                {
                    result = r.Value;
                }

                if (result is bool)
                {
                    return new FhirBoolean((bool)result);
                }
                if (result is long)
                {
                    return new Integer((int)(long)result);
                }
                if (result is decimal)
                {
                    return new FhirDecimal((decimal)result);
                }
                if (result is string)
                {
                    return new FhirString((string)result);
                }
                if (result is Model.Primitives.PartialDateTime dt)
                {
                    return new FhirDateTime(dt.ToUniversalTime());
                }
                else
                {
                    // This will throw an exception if the type isn't one of the FHIR types!
                    return (Base)result;
                }
            });
        }

        public static IEnumerable<Base> Select(this Base input, string expression, FhirEvaluationContext ctx = null)
        {
            var inputNav = input.ToTypedElement();
            var result = inputNav.Select(expression, ctx ?? FhirEvaluationContext.CreateDefault());
            return result.ToFhirValues();
        }

        public static object Scalar(this Base input, string expression, FhirEvaluationContext ctx = null)
        {
            var inputNav = input.ToTypedElement();
            return inputNav.Scalar(expression, ctx ?? FhirEvaluationContext.CreateDefault());
        }

        public static bool Predicate(this Base input, string expression, FhirEvaluationContext ctx = null)
        {
            var inputNav = input.ToTypedElement();
            return inputNav.Predicate(expression, ctx ?? FhirEvaluationContext.CreateDefault());
        }

        public static bool IsBoolean(this Base input, string expression, bool value, FhirEvaluationContext ctx = null)
        {
            var inputNav = input.ToTypedElement();
            return inputNav.IsBoolean(expression, value, ctx ?? FhirEvaluationContext.CreateDefault());
        }
    }
}
