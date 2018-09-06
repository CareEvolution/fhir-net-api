using System;
using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.ElementModel;
using Hl7.FhirPath.Functions;

namespace Hl7.FhirPath
{
    public class EvaluationContext
    {
        public static readonly EvaluationContext Default = new EvaluationContext();

        public EvaluationContext()
        {
            // no defaults yet
        }

        public EvaluationContext(IElementNavigator container)
        {
            Container = container;
        }

        public IElementNavigator Container { get; set; }
    }



    public delegate IEnumerable<IElementNavigator> CompiledExpression(IElementNavigator root, EvaluationContext ctx);

    public static class CompiledExpressionExtensions
    {
        [Obsolete("Replace with the overload taking an EvaluationContext, initialized with the resource parameter")]
        public static object Scalar(this CompiledExpression evaluator, IElementNavigator input, IElementNavigator container)
        {
            return Scalar(evaluator, input, new EvaluationContext(container));
        }

        public static object Scalar(this CompiledExpression evaluator, IElementNavigator input, EvaluationContext ctx)
        {
            var result = evaluator(input, ctx);
            if (result.Any())
                return evaluator(input, ctx).Single().Value;
            else
                return null;
        }


        [Obsolete("Replace with the overload taking an EvaluationContext, initialized with the resource parameter")]
        public static bool Predicate(this CompiledExpression evaluator, IElementNavigator input, IElementNavigator container)
        {
            return Predicate(evaluator, input, new EvaluationContext(container));
        }

        public static bool Predicate(this CompiledExpression evaluator, ITypedElement input, EvaluationContext ctx)
            => Predicate(evaluator, input.ToElementNavigator(), ctx);

        // For predicates, Empty is considered true
        public static bool Predicate(this CompiledExpression evaluator, IElementNavigator input, EvaluationContext ctx)
        {
            var result = evaluator(input, ctx).BooleanEval();

            if (result == null)
                return true;
            else
                return result.Value;
        }

        [Obsolete("Replace with the overload taking an EvaluationContext, initialized with the resource parameter")]
        public static bool IsBoolean(this CompiledExpression evaluator, bool value, IElementNavigator input, IElementNavigator container)
        {
            return IsBoolean(evaluator, value, input, new EvaluationContext(container));
        }

        public static bool IsBoolean(this CompiledExpression evaluator, bool value, IElementNavigator input, EvaluationContext ctx)
        {
            var result = evaluator(input, ctx).BooleanEval();

            if (result == null)
                return false;
            else
                return result.Value == value;
        }
    }


}