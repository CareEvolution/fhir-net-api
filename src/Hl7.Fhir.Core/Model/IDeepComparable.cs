/*
  Copyright (c) 2011-2012, HL7, Inc
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

using System.Collections.Generic;

namespace Hl7.Fhir.Model
{
    public interface IDeepComparable
    {
        bool IsExactly(IDeepComparable other);
        bool Matches(IDeepComparable pattern);
    }

    public static class DeepComparable
    {
        public static bool IsExactly(IDeepComparable a, IDeepComparable b)
        {
            if (a == null && b == null) return true;

            if (a != null && b != null)
            {
                return a.IsExactly(b);
            }

            return false;
        }

        public static bool Matches(IDeepComparable a, IDeepComparable b)
        {
            if (b == null) return true;

            return a != null && a.Matches(b);
        }

        public static bool IsExactly<T>(this List<T> source, List<T> other)
            where T : IDeepComparable
        {
            if (other == null) return false;

            if (source.Count != other.Count) return false;
            for (var i = 0; i < source.Count; i++)
            {
                if (!IsExactly(source[i], other[i])) return false;
            }
            return true;
        }

        public static bool Matches<T>(this List<T> source, List<T> pattern)
            where T : IDeepComparable
        {
            if (pattern == null) return true;       // if not present in the pattern, there's a match

            for (var i = 0; i < source.Count; i++)
            {
                var srcItem = source[i];
                var matched = false;
                for (var j = 0; j < pattern.Count; j++)
                {
                    if (Matches(srcItem, pattern[j]))
                    {
                        matched = true;
                        break;
                    }
                }

                if (!matched) return false;
            }

            return true;
        }
    }
}
