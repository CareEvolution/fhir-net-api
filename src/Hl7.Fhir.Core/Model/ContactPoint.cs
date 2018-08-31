/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/
using System;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hl7.Fhir.Model.DSTU2
{
    /// <summary>
    /// Details of a Technology mediated contact point (phone, fax, email, etc)
    /// </summary>
    [System.Diagnostics.DebuggerDisplay(@"\{{DebuggerDisplay,nq}}")] // http://blogs.msdn.com/b/jaredpar/archive/2011/03/18/debuggerdisplay-attribute-best-practices.aspx
    public partial class ContactPoint
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [NotMapped]
        private string DebuggerDisplay
        {
            get
            {
                string result = null;

                if (this._systemElement != null && this._systemElement.Value != null && this._systemElement.Value.HasValue)
                    result = this._systemElement.Value.ToString();
                else
                    result = "(null)";

                if (this._useElement != null && this._useElement.Value != null && this._useElement.Value.HasValue)
                    result += String.Format(" ({0})", this._useElement.Value.ToString());
                result += ": ";

                if (this._valueElement != null && this._valueElement.Value != null)
                    result += String.Format("\"{0}\"", this._valueElement.Value);
                else
                    result += "(null)";

                return result;
            }
        }
    }
    
}
