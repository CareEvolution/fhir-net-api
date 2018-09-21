/* 
 * Copyright (c) 2016, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Hl7.Fhir.ElementModel.Adapters;
using Hl7.Fhir.Model;
using Hl7.Fhir.Specification.DSTU2;
using Hl7.Fhir.Utility;

namespace Hl7.Fhir.ElementModel.DSTU2
{
    // http://blogs.msdn.com/b/jaredpar/archive/2011/03/18/debuggerdisplay-attribute-best-practices.aspx
    [DebuggerDisplay(@"\{{ShortPath,nq}}")]
    public class PocoNavigator : BaseNodeToNavAdapter
    {
        [Obsolete("This class has been deprecated. Do not use this class directly, instead call " +
            "ToElementNavigator() (for backwards compatibility) or the new ToTypedElement() on any resource or datatype")]
        public PocoNavigator(Base model)
        {
            if (model == null) throw Error.ArgumentNull(nameof(model));

            Initialize(
                new PocoElementNode(model, new PocoStructureDefinitionSummaryProvider()));
        }

        private PocoNavigator()     // for clone
        {
        }

        public bool IsCollection => Current.Definition.IsCollection;

        public Base FhirValue => ((PocoElementNode)Current).Current as Base;

        /// <summary>
        /// The ShortPath is almost the same as the Path except that
        /// where the item is not an array, the array signature is not included.
        /// </summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public string ShortPath => ((PocoElementNode)Current).ShortPath;

       

        protected override IList<ITypedElement> GetChildren() =>
            Current.Children().ToList();

        public override bool MoveToFirstChild(string nameFilter = null)
        {
            if (!base.MoveToFirstChild(nameFilter)) return false;
            return true;
        }

        public override bool MoveToNext(string nameFilter = null) => base.MoveToNext(nameFilter);

        protected override BaseNodeToNavAdapter NewClone() =>
            new PocoNavigator()
            {
            };
    }


    public static class PocoNavigatorExtensions
    {
#pragma warning disable 612, 618
        public static IElementNavigator ToElementNavigator(this Base @base) =>
            new PocoNavigator(@base);

        public static ITypedElement ToTypedElement(this Base @base, string rootName = null) =>
            new PocoElementNode(@base, new PocoStructureDefinitionSummaryProvider(), rootName);

#pragma warning restore 612, 618
    }
}