/* 
 * Copyright (c) 2014, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using Hl7.Fhir.Rest.STU3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Fhir.Tests.Rest
{
    [TestClass]
    public class UtilityTests
    {
        [TestMethod]
        public void GetResourceFormatSupportsCharset()
        {
            Assert.AreEqual(ContentType.GetResourceFormatFromContentType("text/xml;charset=ISO-8859-1"), ResourceFormat.Xml);
            Assert.AreEqual(ContentType.GetResourceFormatFromContentType("text/xml"), ResourceFormat.Xml);
        }
    }
}
