using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.ElementModel;

namespace Hl7.Fhir.Model.DSTU2
{
    partial class QuestionnaireResponse
    {
        public partial class GroupComponent : ICustomCollectionPath
        {
            public string GetCollectionPath()
            {
                return string.IsNullOrEmpty(LinkId) ? string.Empty : $".where(linkId='{LinkId}')";
            }
        }

        public partial class QuestionComponent : ICustomCollectionPath
        {
            public string GetCollectionPath()
            {
                return string.IsNullOrEmpty(LinkId) ? string.Empty : $".where(linkId='{LinkId}')";
            }
        }
    }
}
