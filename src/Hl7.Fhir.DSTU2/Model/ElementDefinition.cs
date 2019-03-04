/* 
 * Copyright (c) 2016, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/fhir-net-api/master/LICENSE
 */


using System.Diagnostics;
using System.Text;
using Hl7.Fhir.Introspection;

namespace Hl7.Fhir.Model.DSTU2
{
    // http://blogs.msdn.com/b/jaredpar/archive/2011/03/18/debuggerdisplay-attribute-best-practices.aspx
    [DebuggerDisplay(@"\{{DebuggerDisplay,nq}}")]
    public partial class ElementDefinition
    {
        public ElementDefinition()
        {

        }

        public ElementDefinition(string path)
        {
            Path = path;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [NotMapped]
        string DebuggerDisplay
        {
            get
            {
                StringBuilder sb = new StringBuilder(128);
                // sb.AppendFormat("Path='{0}'", Path);
                // if (Name != null) { sb.AppendFormat(" Name='{0}'", Name); }
                sb.Append(Path);
                if (Name != null)
                {
                    sb.Append(":");
                    sb.Append(Name);
                }
                return sb.ToString();
            }
        }

        partial class ConstraintComponent
        {
            [NotMapped]
            public string Expression
            {
                get
                {
                    return this.GetStringExtension("http://hl7.org/fhir/StructureDefinition/structuredefinition-expression");
                }
                set
                {
                    this.SetStringExtension("http://hl7.org/fhir/StructureDefinition/structuredefinition-expression", value);
                }
            }
        }
    }


}
