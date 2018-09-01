﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using Hl7.Fhir.Validation.R4;
using Hl7.Fhir.Utility;
using Hl7.Fhir.Specification;

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

#pragma warning disable 1591 // suppress XML summary warnings

//
// Generated for FHIR v3.5.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// A set of rules about how FHIR is used
    /// </summary>
    [FhirType("ImplementationGuide", IsResource=true)]
    [DataContract]
    public partial class ImplementationGuide : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ImplementationGuide; } }
        [NotMapped]
        public override string TypeName { get { return "ImplementationGuide"; } }

        /// <summary>
        /// The license that applies to an Implementation Guide (using an SPDX license Identifiers, or 'not-open-source'). The binding is required but new SPDX license Identifiers are allowed to be used (https://spdx.org/licenses/).
        /// (url: http://hl7.org/fhir/ValueSet/spdx-license)
        /// </summary>
        [FhirEnumeration("SPDXLicense")]
        public enum SPDXLicense
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("not-open-source", "http://hl7.org/fhir/spdx-license"), Description("Not open source")]
            NotOpenSource,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("0BSD", "http://hl7.org/fhir/spdx-license"), Description("BSD Zero Clause License")]
            ZeroBSD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("AAL", "http://hl7.org/fhir/spdx-license"), Description("Attribution Assurance License")]
            AAL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Abstyles", "http://hl7.org/fhir/spdx-license"), Description("Abstyles License")]
            Abstyles,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Adobe-2006", "http://hl7.org/fhir/spdx-license"), Description("Adobe Systems Incorporated Source Code License Agreement")]
            Adobe2006,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Adobe-Glyph", "http://hl7.org/fhir/spdx-license"), Description("Adobe Glyph List License")]
            AdobeGlyph,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("ADSL", "http://hl7.org/fhir/spdx-license"), Description("Amazon Digital Services License")]
            ADSL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("AFL-1.1", "http://hl7.org/fhir/spdx-license"), Description("Academic Free License v1.1")]
            AFL11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("AFL-1.2", "http://hl7.org/fhir/spdx-license"), Description("Academic Free License v1.2")]
            AFL12,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("AFL-2.0", "http://hl7.org/fhir/spdx-license"), Description("Academic Free License v2.0")]
            AFL20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("AFL-2.1", "http://hl7.org/fhir/spdx-license"), Description("Academic Free License v2.1")]
            AFL21,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("AFL-3.0", "http://hl7.org/fhir/spdx-license"), Description("Academic Free License v3.0")]
            AFL30,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Afmparse", "http://hl7.org/fhir/spdx-license"), Description("Afmparse License")]
            Afmparse,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("AGPL-1.0-only", "http://hl7.org/fhir/spdx-license"), Description("Affero General Public License v1.0 only")]
            AGPL10Only,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("AGPL-1.0-or-later", "http://hl7.org/fhir/spdx-license"), Description("Affero General Public License v1.0 or later")]
            AGPL10OrLater,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("AGPL-3.0-only", "http://hl7.org/fhir/spdx-license"), Description("GNU Affero General Public License v3.0 only")]
            AGPL30Only,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("AGPL-3.0-or-later", "http://hl7.org/fhir/spdx-license"), Description("GNU Affero General Public License v3.0 or later")]
            AGPL30OrLater,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Aladdin", "http://hl7.org/fhir/spdx-license"), Description("Aladdin Free Public License")]
            Aladdin,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("AMDPLPA", "http://hl7.org/fhir/spdx-license"), Description("AMD's plpa_map.c License")]
            AMDPLPA,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("AML", "http://hl7.org/fhir/spdx-license"), Description("Apple MIT License")]
            AML,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("AMPAS", "http://hl7.org/fhir/spdx-license"), Description("Academy of Motion Picture Arts and Sciences BSD")]
            AMPAS,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("ANTLR-PD", "http://hl7.org/fhir/spdx-license"), Description("ANTLR Software Rights Notice")]
            ANTLRPD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Apache-1.0", "http://hl7.org/fhir/spdx-license"), Description("Apache License 1.0")]
            Apache10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Apache-1.1", "http://hl7.org/fhir/spdx-license"), Description("Apache License 1.1")]
            Apache11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Apache-2.0", "http://hl7.org/fhir/spdx-license"), Description("Apache License 2.0")]
            Apache20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("APAFML", "http://hl7.org/fhir/spdx-license"), Description("Adobe Postscript AFM License")]
            APAFML,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("APL-1.0", "http://hl7.org/fhir/spdx-license"), Description("Adaptive Public License 1.0")]
            APL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("APSL-1.0", "http://hl7.org/fhir/spdx-license"), Description("Apple Public Source License 1.0")]
            APSL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("APSL-1.1", "http://hl7.org/fhir/spdx-license"), Description("Apple Public Source License 1.1")]
            APSL11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("APSL-1.2", "http://hl7.org/fhir/spdx-license"), Description("Apple Public Source License 1.2")]
            APSL12,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("APSL-2.0", "http://hl7.org/fhir/spdx-license"), Description("Apple Public Source License 2.0")]
            APSL20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Artistic-1.0-cl8", "http://hl7.org/fhir/spdx-license"), Description("Artistic License 1.0 w/clause 8")]
            Artistic10Cl8,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Artistic-1.0-Perl", "http://hl7.org/fhir/spdx-license"), Description("Artistic License 1.0 (Perl)")]
            Artistic10Perl,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Artistic-1.0", "http://hl7.org/fhir/spdx-license"), Description("Artistic License 1.0")]
            Artistic10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Artistic-2.0", "http://hl7.org/fhir/spdx-license"), Description("Artistic License 2.0")]
            Artistic20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Bahyph", "http://hl7.org/fhir/spdx-license"), Description("Bahyph License")]
            Bahyph,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Barr", "http://hl7.org/fhir/spdx-license"), Description("Barr License")]
            Barr,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Beerware", "http://hl7.org/fhir/spdx-license"), Description("Beerware License")]
            Beerware,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("BitTorrent-1.0", "http://hl7.org/fhir/spdx-license"), Description("BitTorrent Open Source License v1.0")]
            BitTorrent10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("BitTorrent-1.1", "http://hl7.org/fhir/spdx-license"), Description("BitTorrent Open Source License v1.1")]
            BitTorrent11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Borceux", "http://hl7.org/fhir/spdx-license"), Description("Borceux license")]
            Borceux,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("BSD-1-Clause", "http://hl7.org/fhir/spdx-license"), Description("BSD 1-Clause License")]
            BSD1Clause,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("BSD-2-Clause-FreeBSD", "http://hl7.org/fhir/spdx-license"), Description("BSD 2-Clause FreeBSD License")]
            BSD2ClauseFreeBSD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("BSD-2-Clause-NetBSD", "http://hl7.org/fhir/spdx-license"), Description("BSD 2-Clause NetBSD License")]
            BSD2ClauseNetBSD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("BSD-2-Clause-Patent", "http://hl7.org/fhir/spdx-license"), Description("BSD-2-Clause Plus Patent License")]
            BSD2ClausePatent,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("BSD-2-Clause", "http://hl7.org/fhir/spdx-license"), Description("BSD 2-Clause \"Simplified\" License")]
            BSD2Clause,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("BSD-3-Clause-Attribution", "http://hl7.org/fhir/spdx-license"), Description("BSD with attribution")]
            BSD3ClauseAttribution,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("BSD-3-Clause-Clear", "http://hl7.org/fhir/spdx-license"), Description("BSD 3-Clause Clear License")]
            BSD3ClauseClear,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("BSD-3-Clause-LBNL", "http://hl7.org/fhir/spdx-license"), Description("Lawrence Berkeley National Labs BSD variant license")]
            BSD3ClauseLBNL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("BSD-3-Clause-No-Nuclear-License-2014", "http://hl7.org/fhir/spdx-license"), Description("BSD 3-Clause No Nuclear License 2014")]
            BSD3ClauseNoNuclearLicense2014,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("BSD-3-Clause-No-Nuclear-License", "http://hl7.org/fhir/spdx-license"), Description("BSD 3-Clause No Nuclear License")]
            BSD3ClauseNoNuclearLicense,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("BSD-3-Clause-No-Nuclear-Warranty", "http://hl7.org/fhir/spdx-license"), Description("BSD 3-Clause No Nuclear Warranty")]
            BSD3ClauseNoNuclearWarranty,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("BSD-3-Clause", "http://hl7.org/fhir/spdx-license"), Description("BSD 3-Clause \"New\" or \"Revised\" License")]
            BSD3Clause,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("BSD-4-Clause-UC", "http://hl7.org/fhir/spdx-license"), Description("BSD-4-Clause (University of California-Specific)")]
            BSD4ClauseUC,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("BSD-4-Clause", "http://hl7.org/fhir/spdx-license"), Description("BSD 4-Clause \"Original\" or \"Old\" License")]
            BSD4Clause,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("BSD-Protection", "http://hl7.org/fhir/spdx-license"), Description("BSD Protection License")]
            BSDProtection,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("BSD-Source-Code", "http://hl7.org/fhir/spdx-license"), Description("BSD Source Code Attribution")]
            BSDSourceCode,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("BSL-1.0", "http://hl7.org/fhir/spdx-license"), Description("Boost Software License 1.0")]
            BSL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("bzip2-1.0.5", "http://hl7.org/fhir/spdx-license"), Description("bzip2 and libbzip2 License v1.0.5")]
            Bzip2105,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("bzip2-1.0.6", "http://hl7.org/fhir/spdx-license"), Description("bzip2 and libbzip2 License v1.0.6")]
            Bzip2106,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Caldera", "http://hl7.org/fhir/spdx-license"), Description("Caldera License")]
            Caldera,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CATOSL-1.1", "http://hl7.org/fhir/spdx-license"), Description("Computer Associates Trusted Open Source License 1.1")]
            CATOSL11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-1.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution 1.0 Generic")]
            CCBY10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-2.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution 2.0 Generic")]
            CCBY20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-2.5", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution 2.5 Generic")]
            CCBY25,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-3.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution 3.0 Unported")]
            CCBY30,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-4.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution 4.0 International")]
            CCBY40,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-NC-1.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution Non Commercial 1.0 Generic")]
            CCBYNC10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-NC-2.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution Non Commercial 2.0 Generic")]
            CCBYNC20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-NC-2.5", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution Non Commercial 2.5 Generic")]
            CCBYNC25,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-NC-3.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution Non Commercial 3.0 Unported")]
            CCBYNC30,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-NC-4.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution Non Commercial 4.0 International")]
            CCBYNC40,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-NC-ND-1.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution Non Commercial No Derivatives 1.0 Generic")]
            CCBYNCND10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-NC-ND-2.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution Non Commercial No Derivatives 2.0 Generic")]
            CCBYNCND20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-NC-ND-2.5", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution Non Commercial No Derivatives 2.5 Generic")]
            CCBYNCND25,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-NC-ND-3.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution Non Commercial No Derivatives 3.0 Unported")]
            CCBYNCND30,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-NC-ND-4.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution Non Commercial No Derivatives 4.0 International")]
            CCBYNCND40,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-NC-SA-1.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution Non Commercial Share Alike 1.0 Generic")]
            CCBYNCSA10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-NC-SA-2.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution Non Commercial Share Alike 2.0 Generic")]
            CCBYNCSA20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-NC-SA-2.5", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution Non Commercial Share Alike 2.5 Generic")]
            CCBYNCSA25,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-NC-SA-3.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution Non Commercial Share Alike 3.0 Unported")]
            CCBYNCSA30,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-NC-SA-4.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution Non Commercial Share Alike 4.0 International")]
            CCBYNCSA40,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-ND-1.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution No Derivatives 1.0 Generic")]
            CCBYND10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-ND-2.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution No Derivatives 2.0 Generic")]
            CCBYND20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-ND-2.5", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution No Derivatives 2.5 Generic")]
            CCBYND25,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-ND-3.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution No Derivatives 3.0 Unported")]
            CCBYND30,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-ND-4.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution No Derivatives 4.0 International")]
            CCBYND40,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-SA-1.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution Share Alike 1.0 Generic")]
            CCBYSA10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-SA-2.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution Share Alike 2.0 Generic")]
            CCBYSA20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-SA-2.5", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution Share Alike 2.5 Generic")]
            CCBYSA25,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-SA-3.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution Share Alike 3.0 Unported")]
            CCBYSA30,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC-BY-SA-4.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Attribution Share Alike 4.0 International")]
            CCBYSA40,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CC0-1.0", "http://hl7.org/fhir/spdx-license"), Description("Creative Commons Zero v1.0 Universal")]
            CC010,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CDDL-1.0", "http://hl7.org/fhir/spdx-license"), Description("Common Development and Distribution License 1.0")]
            CDDL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CDDL-1.1", "http://hl7.org/fhir/spdx-license"), Description("Common Development and Distribution License 1.1")]
            CDDL11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CDLA-Permissive-1.0", "http://hl7.org/fhir/spdx-license"), Description("Community Data License Agreement Permissive 1.0")]
            CDLAPermissive10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CDLA-Sharing-1.0", "http://hl7.org/fhir/spdx-license"), Description("Community Data License Agreement Sharing 1.0")]
            CDLASharing10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CECILL-1.0", "http://hl7.org/fhir/spdx-license"), Description("CeCILL Free Software License Agreement v1.0")]
            CECILL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CECILL-1.1", "http://hl7.org/fhir/spdx-license"), Description("CeCILL Free Software License Agreement v1.1")]
            CECILL11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CECILL-2.0", "http://hl7.org/fhir/spdx-license"), Description("CeCILL Free Software License Agreement v2.0")]
            CECILL20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CECILL-2.1", "http://hl7.org/fhir/spdx-license"), Description("CeCILL Free Software License Agreement v2.1")]
            CECILL21,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CECILL-B", "http://hl7.org/fhir/spdx-license"), Description("CeCILL-B Free Software License Agreement")]
            CECILLB,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CECILL-C", "http://hl7.org/fhir/spdx-license"), Description("CeCILL-C Free Software License Agreement")]
            CECILLC,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("ClArtistic", "http://hl7.org/fhir/spdx-license"), Description("Clarified Artistic License")]
            ClArtistic,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CNRI-Jython", "http://hl7.org/fhir/spdx-license"), Description("CNRI Jython License")]
            CNRIJython,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CNRI-Python-GPL-Compatible", "http://hl7.org/fhir/spdx-license"), Description("CNRI Python Open Source GPL Compatible License Agreement")]
            CNRIPythonGPLCompatible,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CNRI-Python", "http://hl7.org/fhir/spdx-license"), Description("CNRI Python License")]
            CNRIPython,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Condor-1.1", "http://hl7.org/fhir/spdx-license"), Description("Condor Public License v1.1")]
            Condor11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CPAL-1.0", "http://hl7.org/fhir/spdx-license"), Description("Common Public Attribution License 1.0")]
            CPAL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CPL-1.0", "http://hl7.org/fhir/spdx-license"), Description("Common Public License 1.0")]
            CPL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CPOL-1.02", "http://hl7.org/fhir/spdx-license"), Description("Code Project Open License 1.02")]
            CPOL102,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Crossword", "http://hl7.org/fhir/spdx-license"), Description("Crossword License")]
            Crossword,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CrystalStacker", "http://hl7.org/fhir/spdx-license"), Description("CrystalStacker License")]
            CrystalStacker,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("CUA-OPL-1.0", "http://hl7.org/fhir/spdx-license"), Description("CUA Office Public License v1.0")]
            CUAOPL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Cube", "http://hl7.org/fhir/spdx-license"), Description("Cube License")]
            Cube,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("curl", "http://hl7.org/fhir/spdx-license"), Description("curl License")]
            Curl,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("D-FSL-1.0", "http://hl7.org/fhir/spdx-license"), Description("Deutsche Freie Software Lizenz")]
            DFSL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("diffmark", "http://hl7.org/fhir/spdx-license"), Description("diffmark license")]
            Diffmark,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("DOC", "http://hl7.org/fhir/spdx-license"), Description("DOC License")]
            DOC,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Dotseqn", "http://hl7.org/fhir/spdx-license"), Description("Dotseqn License")]
            Dotseqn,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("DSDP", "http://hl7.org/fhir/spdx-license"), Description("DSDP License")]
            DSDP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("dvipdfm", "http://hl7.org/fhir/spdx-license"), Description("dvipdfm License")]
            Dvipdfm,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("ECL-1.0", "http://hl7.org/fhir/spdx-license"), Description("Educational Community License v1.0")]
            ECL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("ECL-2.0", "http://hl7.org/fhir/spdx-license"), Description("Educational Community License v2.0")]
            ECL20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("EFL-1.0", "http://hl7.org/fhir/spdx-license"), Description("Eiffel Forum License v1.0")]
            EFL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("EFL-2.0", "http://hl7.org/fhir/spdx-license"), Description("Eiffel Forum License v2.0")]
            EFL20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("eGenix", "http://hl7.org/fhir/spdx-license"), Description("eGenix.com Public License 1.1.0")]
            EGenix,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Entessa", "http://hl7.org/fhir/spdx-license"), Description("Entessa Public License v1.0")]
            Entessa,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("EPL-1.0", "http://hl7.org/fhir/spdx-license"), Description("Eclipse Public License 1.0")]
            EPL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("EPL-2.0", "http://hl7.org/fhir/spdx-license"), Description("Eclipse Public License 2.0")]
            EPL20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("ErlPL-1.1", "http://hl7.org/fhir/spdx-license"), Description("Erlang Public License v1.1")]
            ErlPL11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("EUDatagrid", "http://hl7.org/fhir/spdx-license"), Description("EU DataGrid Software License")]
            EUDatagrid,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("EUPL-1.0", "http://hl7.org/fhir/spdx-license"), Description("European Union Public License 1.0")]
            EUPL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("EUPL-1.1", "http://hl7.org/fhir/spdx-license"), Description("European Union Public License 1.1")]
            EUPL11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("EUPL-1.2", "http://hl7.org/fhir/spdx-license"), Description("European Union Public License 1.2")]
            EUPL12,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Eurosym", "http://hl7.org/fhir/spdx-license"), Description("Eurosym License")]
            Eurosym,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Fair", "http://hl7.org/fhir/spdx-license"), Description("Fair License")]
            Fair,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Frameworx-1.0", "http://hl7.org/fhir/spdx-license"), Description("Frameworx Open License 1.0")]
            Frameworx10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("FreeImage", "http://hl7.org/fhir/spdx-license"), Description("FreeImage Public License v1.0")]
            FreeImage,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("FSFAP", "http://hl7.org/fhir/spdx-license"), Description("FSF All Permissive License")]
            FSFAP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("FSFUL", "http://hl7.org/fhir/spdx-license"), Description("FSF Unlimited License")]
            FSFUL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("FSFULLR", "http://hl7.org/fhir/spdx-license"), Description("FSF Unlimited License (with License Retention)")]
            FSFULLR,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("FTL", "http://hl7.org/fhir/spdx-license"), Description("Freetype Project License")]
            FTL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("GFDL-1.1-only", "http://hl7.org/fhir/spdx-license"), Description("GNU Free Documentation License v1.1 only")]
            GFDL11Only,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("GFDL-1.1-or-later", "http://hl7.org/fhir/spdx-license"), Description("GNU Free Documentation License v1.1 or later")]
            GFDL11OrLater,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("GFDL-1.2-only", "http://hl7.org/fhir/spdx-license"), Description("GNU Free Documentation License v1.2 only")]
            GFDL12Only,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("GFDL-1.2-or-later", "http://hl7.org/fhir/spdx-license"), Description("GNU Free Documentation License v1.2 or later")]
            GFDL12OrLater,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("GFDL-1.3-only", "http://hl7.org/fhir/spdx-license"), Description("GNU Free Documentation License v1.3 only")]
            GFDL13Only,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("GFDL-1.3-or-later", "http://hl7.org/fhir/spdx-license"), Description("GNU Free Documentation License v1.3 or later")]
            GFDL13OrLater,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Giftware", "http://hl7.org/fhir/spdx-license"), Description("Giftware License")]
            Giftware,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("GL2PS", "http://hl7.org/fhir/spdx-license"), Description("GL2PS License")]
            GL2PS,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Glide", "http://hl7.org/fhir/spdx-license"), Description("3dfx Glide License")]
            Glide,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Glulxe", "http://hl7.org/fhir/spdx-license"), Description("Glulxe License")]
            Glulxe,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("gnuplot", "http://hl7.org/fhir/spdx-license"), Description("gnuplot License")]
            Gnuplot,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("GPL-1.0-only", "http://hl7.org/fhir/spdx-license"), Description("GNU General Public License v1.0 only")]
            GPL10Only,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("GPL-1.0-or-later", "http://hl7.org/fhir/spdx-license"), Description("GNU General Public License v1.0 or later")]
            GPL10OrLater,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("GPL-2.0-only", "http://hl7.org/fhir/spdx-license"), Description("GNU General Public License v2.0 only")]
            GPL20Only,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("GPL-2.0-or-later", "http://hl7.org/fhir/spdx-license"), Description("GNU General Public License v2.0 or later")]
            GPL20OrLater,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("GPL-3.0-only", "http://hl7.org/fhir/spdx-license"), Description("GNU General Public License v3.0 only")]
            GPL30Only,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("GPL-3.0-or-later", "http://hl7.org/fhir/spdx-license"), Description("GNU General Public License v3.0 or later")]
            GPL30OrLater,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("gSOAP-1.3b", "http://hl7.org/fhir/spdx-license"), Description("gSOAP Public License v1.3b")]
            GSOAP13b,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("HaskellReport", "http://hl7.org/fhir/spdx-license"), Description("Haskell Language Report License")]
            HaskellReport,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("HPND", "http://hl7.org/fhir/spdx-license"), Description("Historical Permission Notice and Disclaimer")]
            HPND,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("IBM-pibs", "http://hl7.org/fhir/spdx-license"), Description("IBM PowerPC Initialization and Boot Software")]
            IBMPibs,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("ICU", "http://hl7.org/fhir/spdx-license"), Description("ICU License")]
            ICU,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("IJG", "http://hl7.org/fhir/spdx-license"), Description("Independent JPEG Group License")]
            IJG,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("ImageMagick", "http://hl7.org/fhir/spdx-license"), Description("ImageMagick License")]
            ImageMagick,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("iMatix", "http://hl7.org/fhir/spdx-license"), Description("iMatix Standard Function Library Agreement")]
            IMatix,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Imlib2", "http://hl7.org/fhir/spdx-license"), Description("Imlib2 License")]
            Imlib2,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Info-ZIP", "http://hl7.org/fhir/spdx-license"), Description("Info-ZIP License")]
            InfoZIP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Intel-ACPI", "http://hl7.org/fhir/spdx-license"), Description("Intel ACPI Software License Agreement")]
            IntelACPI,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Intel", "http://hl7.org/fhir/spdx-license"), Description("Intel Open Source License")]
            Intel,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Interbase-1.0", "http://hl7.org/fhir/spdx-license"), Description("Interbase Public License v1.0")]
            Interbase10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("IPA", "http://hl7.org/fhir/spdx-license"), Description("IPA Font License")]
            IPA,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("IPL-1.0", "http://hl7.org/fhir/spdx-license"), Description("IBM Public License v1.0")]
            IPL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("ISC", "http://hl7.org/fhir/spdx-license"), Description("ISC License")]
            ISC,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("JasPer-2.0", "http://hl7.org/fhir/spdx-license"), Description("JasPer License")]
            JasPer20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("JSON", "http://hl7.org/fhir/spdx-license"), Description("JSON License")]
            JSON,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("LAL-1.2", "http://hl7.org/fhir/spdx-license"), Description("Licence Art Libre 1.2")]
            LAL12,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("LAL-1.3", "http://hl7.org/fhir/spdx-license"), Description("Licence Art Libre 1.3")]
            LAL13,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Latex2e", "http://hl7.org/fhir/spdx-license"), Description("Latex2e License")]
            Latex2e,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Leptonica", "http://hl7.org/fhir/spdx-license"), Description("Leptonica License")]
            Leptonica,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("LGPL-2.0-only", "http://hl7.org/fhir/spdx-license"), Description("GNU Library General Public License v2 only")]
            LGPL20Only,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("LGPL-2.0-or-later", "http://hl7.org/fhir/spdx-license"), Description("GNU Library General Public License v2 or later")]
            LGPL20OrLater,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("LGPL-2.1-only", "http://hl7.org/fhir/spdx-license"), Description("GNU Lesser General Public License v2.1 only")]
            LGPL21Only,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("LGPL-2.1-or-later", "http://hl7.org/fhir/spdx-license"), Description("GNU Lesser General Public License v2.1 or later")]
            LGPL21OrLater,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("LGPL-3.0-only", "http://hl7.org/fhir/spdx-license"), Description("GNU Lesser General Public License v3.0 only")]
            LGPL30Only,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("LGPL-3.0-or-later", "http://hl7.org/fhir/spdx-license"), Description("GNU Lesser General Public License v3.0 or later")]
            LGPL30OrLater,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("LGPLLR", "http://hl7.org/fhir/spdx-license"), Description("Lesser General Public License For Linguistic Resources")]
            LGPLLR,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Libpng", "http://hl7.org/fhir/spdx-license"), Description("libpng License")]
            Libpng,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("libtiff", "http://hl7.org/fhir/spdx-license"), Description("libtiff License")]
            Libtiff,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("LiLiQ-P-1.1", "http://hl7.org/fhir/spdx-license"), Description("Licence Libre du Québec – Permissive version 1.1")]
            LiLiQP11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("LiLiQ-R-1.1", "http://hl7.org/fhir/spdx-license"), Description("Licence Libre du Québec – Réciprocité version 1.1")]
            LiLiQR11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("LiLiQ-Rplus-1.1", "http://hl7.org/fhir/spdx-license"), Description("Licence Libre du Québec – Réciprocité forte version 1.1")]
            LiLiQRplus11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Linux-OpenIB", "http://hl7.org/fhir/spdx-license"), Description("Linux Kernel Variant of OpenIB.org license")]
            LinuxOpenIB,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("LPL-1.0", "http://hl7.org/fhir/spdx-license"), Description("Lucent Public License Version 1.0")]
            LPL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("LPL-1.02", "http://hl7.org/fhir/spdx-license"), Description("Lucent Public License v1.02")]
            LPL102,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("LPPL-1.0", "http://hl7.org/fhir/spdx-license"), Description("LaTeX Project Public License v1.0")]
            LPPL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("LPPL-1.1", "http://hl7.org/fhir/spdx-license"), Description("LaTeX Project Public License v1.1")]
            LPPL11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("LPPL-1.2", "http://hl7.org/fhir/spdx-license"), Description("LaTeX Project Public License v1.2")]
            LPPL12,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("LPPL-1.3a", "http://hl7.org/fhir/spdx-license"), Description("LaTeX Project Public License v1.3a")]
            LPPL13a,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("LPPL-1.3c", "http://hl7.org/fhir/spdx-license"), Description("LaTeX Project Public License v1.3c")]
            LPPL13c,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("MakeIndex", "http://hl7.org/fhir/spdx-license"), Description("MakeIndex License")]
            MakeIndex,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("MirOS", "http://hl7.org/fhir/spdx-license"), Description("MirOS License")]
            MirOS,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("MIT-0", "http://hl7.org/fhir/spdx-license"), Description("MIT No Attribution")]
            MIT0,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("MIT-advertising", "http://hl7.org/fhir/spdx-license"), Description("Enlightenment License (e16)")]
            MITAdvertising,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("MIT-CMU", "http://hl7.org/fhir/spdx-license"), Description("CMU License")]
            MITCMU,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("MIT-enna", "http://hl7.org/fhir/spdx-license"), Description("enna License")]
            MITEnna,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("MIT-feh", "http://hl7.org/fhir/spdx-license"), Description("feh License")]
            MITFeh,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("MIT", "http://hl7.org/fhir/spdx-license"), Description("MIT License")]
            MIT,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("MITNFA", "http://hl7.org/fhir/spdx-license"), Description("MIT +no-false-attribs license")]
            MITNFA,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Motosoto", "http://hl7.org/fhir/spdx-license"), Description("Motosoto License")]
            Motosoto,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("mpich2", "http://hl7.org/fhir/spdx-license"), Description("mpich2 License")]
            Mpich2,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("MPL-1.0", "http://hl7.org/fhir/spdx-license"), Description("Mozilla Public License 1.0")]
            MPL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("MPL-1.1", "http://hl7.org/fhir/spdx-license"), Description("Mozilla Public License 1.1")]
            MPL11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("MPL-2.0-no-copyleft-exception", "http://hl7.org/fhir/spdx-license"), Description("Mozilla Public License 2.0 (no copyleft exception)")]
            MPL20NoCopyleftException,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("MPL-2.0", "http://hl7.org/fhir/spdx-license"), Description("Mozilla Public License 2.0")]
            MPL20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("MS-PL", "http://hl7.org/fhir/spdx-license"), Description("Microsoft Public License")]
            MSPL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("MS-RL", "http://hl7.org/fhir/spdx-license"), Description("Microsoft Reciprocal License")]
            MSRL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("MTLL", "http://hl7.org/fhir/spdx-license"), Description("Matrix Template Library License")]
            MTLL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Multics", "http://hl7.org/fhir/spdx-license"), Description("Multics License")]
            Multics,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Mup", "http://hl7.org/fhir/spdx-license"), Description("Mup License")]
            Mup,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("NASA-1.3", "http://hl7.org/fhir/spdx-license"), Description("NASA Open Source Agreement 1.3")]
            NASA13,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Naumen", "http://hl7.org/fhir/spdx-license"), Description("Naumen Public License")]
            Naumen,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("NBPL-1.0", "http://hl7.org/fhir/spdx-license"), Description("Net Boolean Public License v1")]
            NBPL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("NCSA", "http://hl7.org/fhir/spdx-license"), Description("University of Illinois/NCSA Open Source License")]
            NCSA,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Net-SNMP", "http://hl7.org/fhir/spdx-license"), Description("Net-SNMP License")]
            NetSNMP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("NetCDF", "http://hl7.org/fhir/spdx-license"), Description("NetCDF license")]
            NetCDF,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Newsletr", "http://hl7.org/fhir/spdx-license"), Description("Newsletr License")]
            Newsletr,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("NGPL", "http://hl7.org/fhir/spdx-license"), Description("Nethack General Public License")]
            NGPL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("NLOD-1.0", "http://hl7.org/fhir/spdx-license"), Description("Norwegian Licence for Open Government Data")]
            NLOD10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("NLPL", "http://hl7.org/fhir/spdx-license"), Description("No Limit Public License")]
            NLPL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Nokia", "http://hl7.org/fhir/spdx-license"), Description("Nokia Open Source License")]
            Nokia,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("NOSL", "http://hl7.org/fhir/spdx-license"), Description("Netizen Open Source License")]
            NOSL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Noweb", "http://hl7.org/fhir/spdx-license"), Description("Noweb License")]
            Noweb,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("NPL-1.0", "http://hl7.org/fhir/spdx-license"), Description("Netscape Public License v1.0")]
            NPL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("NPL-1.1", "http://hl7.org/fhir/spdx-license"), Description("Netscape Public License v1.1")]
            NPL11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("NPOSL-3.0", "http://hl7.org/fhir/spdx-license"), Description("Non-Profit Open Software License 3.0")]
            NPOSL30,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("NRL", "http://hl7.org/fhir/spdx-license"), Description("NRL License")]
            NRL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("NTP", "http://hl7.org/fhir/spdx-license"), Description("NTP License")]
            NTP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OCCT-PL", "http://hl7.org/fhir/spdx-license"), Description("Open CASCADE Technology Public License")]
            OCCTPL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OCLC-2.0", "http://hl7.org/fhir/spdx-license"), Description("OCLC Research Public License 2.0")]
            OCLC20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("ODbL-1.0", "http://hl7.org/fhir/spdx-license"), Description("ODC Open Database License v1.0")]
            ODbL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OFL-1.0", "http://hl7.org/fhir/spdx-license"), Description("SIL Open Font License 1.0")]
            OFL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OFL-1.1", "http://hl7.org/fhir/spdx-license"), Description("SIL Open Font License 1.1")]
            OFL11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OGTSL", "http://hl7.org/fhir/spdx-license"), Description("Open Group Test Suite License")]
            OGTSL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OLDAP-1.1", "http://hl7.org/fhir/spdx-license"), Description("Open LDAP Public License v1.1")]
            OLDAP11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OLDAP-1.2", "http://hl7.org/fhir/spdx-license"), Description("Open LDAP Public License v1.2")]
            OLDAP12,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OLDAP-1.3", "http://hl7.org/fhir/spdx-license"), Description("Open LDAP Public License v1.3")]
            OLDAP13,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OLDAP-1.4", "http://hl7.org/fhir/spdx-license"), Description("Open LDAP Public License v1.4")]
            OLDAP14,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OLDAP-2.0.1", "http://hl7.org/fhir/spdx-license"), Description("Open LDAP Public License v2.0.1")]
            OLDAP201,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OLDAP-2.0", "http://hl7.org/fhir/spdx-license"), Description("Open LDAP Public License v2.0 (or possibly 2.0A and 2.0B)")]
            OLDAP20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OLDAP-2.1", "http://hl7.org/fhir/spdx-license"), Description("Open LDAP Public License v2.1")]
            OLDAP21,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OLDAP-2.2.1", "http://hl7.org/fhir/spdx-license"), Description("Open LDAP Public License v2.2.1")]
            OLDAP221,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OLDAP-2.2.2", "http://hl7.org/fhir/spdx-license"), Description("Open LDAP Public License 2.2.2")]
            OLDAP222,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OLDAP-2.2", "http://hl7.org/fhir/spdx-license"), Description("Open LDAP Public License v2.2")]
            OLDAP22,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OLDAP-2.3", "http://hl7.org/fhir/spdx-license"), Description("Open LDAP Public License v2.3")]
            OLDAP23,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OLDAP-2.4", "http://hl7.org/fhir/spdx-license"), Description("Open LDAP Public License v2.4")]
            OLDAP24,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OLDAP-2.5", "http://hl7.org/fhir/spdx-license"), Description("Open LDAP Public License v2.5")]
            OLDAP25,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OLDAP-2.6", "http://hl7.org/fhir/spdx-license"), Description("Open LDAP Public License v2.6")]
            OLDAP26,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OLDAP-2.7", "http://hl7.org/fhir/spdx-license"), Description("Open LDAP Public License v2.7")]
            OLDAP27,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OLDAP-2.8", "http://hl7.org/fhir/spdx-license"), Description("Open LDAP Public License v2.8")]
            OLDAP28,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OML", "http://hl7.org/fhir/spdx-license"), Description("Open Market License")]
            OML,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OpenSSL", "http://hl7.org/fhir/spdx-license"), Description("OpenSSL License")]
            OpenSSL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OPL-1.0", "http://hl7.org/fhir/spdx-license"), Description("Open Public License v1.0")]
            OPL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OSET-PL-2.1", "http://hl7.org/fhir/spdx-license"), Description("OSET Public License version 2.1")]
            OSETPL21,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OSL-1.0", "http://hl7.org/fhir/spdx-license"), Description("Open Software License 1.0")]
            OSL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OSL-1.1", "http://hl7.org/fhir/spdx-license"), Description("Open Software License 1.1")]
            OSL11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OSL-2.0", "http://hl7.org/fhir/spdx-license"), Description("Open Software License 2.0")]
            OSL20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OSL-2.1", "http://hl7.org/fhir/spdx-license"), Description("Open Software License 2.1")]
            OSL21,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("OSL-3.0", "http://hl7.org/fhir/spdx-license"), Description("Open Software License 3.0")]
            OSL30,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("PDDL-1.0", "http://hl7.org/fhir/spdx-license"), Description("ODC Public Domain Dedication & License 1.0")]
            PDDL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("PHP-3.0", "http://hl7.org/fhir/spdx-license"), Description("PHP License v3.0")]
            PHP30,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("PHP-3.01", "http://hl7.org/fhir/spdx-license"), Description("PHP License v3.01")]
            PHP301,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Plexus", "http://hl7.org/fhir/spdx-license"), Description("Plexus Classworlds License")]
            Plexus,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("PostgreSQL", "http://hl7.org/fhir/spdx-license"), Description("PostgreSQL License")]
            PostgreSQL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("psfrag", "http://hl7.org/fhir/spdx-license"), Description("psfrag License")]
            Psfrag,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("psutils", "http://hl7.org/fhir/spdx-license"), Description("psutils License")]
            Psutils,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Python-2.0", "http://hl7.org/fhir/spdx-license"), Description("Python License 2.0")]
            Python20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Qhull", "http://hl7.org/fhir/spdx-license"), Description("Qhull License")]
            Qhull,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("QPL-1.0", "http://hl7.org/fhir/spdx-license"), Description("Q Public License 1.0")]
            QPL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Rdisc", "http://hl7.org/fhir/spdx-license"), Description("Rdisc License")]
            Rdisc,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("RHeCos-1.1", "http://hl7.org/fhir/spdx-license"), Description("Red Hat eCos Public License v1.1")]
            RHeCos11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("RPL-1.1", "http://hl7.org/fhir/spdx-license"), Description("Reciprocal Public License 1.1")]
            RPL11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("RPL-1.5", "http://hl7.org/fhir/spdx-license"), Description("Reciprocal Public License 1.5")]
            RPL15,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("RPSL-1.0", "http://hl7.org/fhir/spdx-license"), Description("RealNetworks Public Source License v1.0")]
            RPSL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("RSA-MD", "http://hl7.org/fhir/spdx-license"), Description("RSA Message-Digest License")]
            RSAMD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("RSCPL", "http://hl7.org/fhir/spdx-license"), Description("Ricoh Source Code Public License")]
            RSCPL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Ruby", "http://hl7.org/fhir/spdx-license"), Description("Ruby License")]
            Ruby,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("SAX-PD", "http://hl7.org/fhir/spdx-license"), Description("Sax Public Domain Notice")]
            SAXPD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Saxpath", "http://hl7.org/fhir/spdx-license"), Description("Saxpath License")]
            Saxpath,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("SCEA", "http://hl7.org/fhir/spdx-license"), Description("SCEA Shared Source License")]
            SCEA,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Sendmail", "http://hl7.org/fhir/spdx-license"), Description("Sendmail License")]
            Sendmail,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("SGI-B-1.0", "http://hl7.org/fhir/spdx-license"), Description("SGI Free Software License B v1.0")]
            SGIB10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("SGI-B-1.1", "http://hl7.org/fhir/spdx-license"), Description("SGI Free Software License B v1.1")]
            SGIB11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("SGI-B-2.0", "http://hl7.org/fhir/spdx-license"), Description("SGI Free Software License B v2.0")]
            SGIB20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("SimPL-2.0", "http://hl7.org/fhir/spdx-license"), Description("Simple Public License 2.0")]
            SimPL20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("SISSL-1.2", "http://hl7.org/fhir/spdx-license"), Description("Sun Industry Standards Source License v1.2")]
            SISSL12,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("SISSL", "http://hl7.org/fhir/spdx-license"), Description("Sun Industry Standards Source License v1.1")]
            SISSL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Sleepycat", "http://hl7.org/fhir/spdx-license"), Description("Sleepycat License")]
            Sleepycat,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("SMLNJ", "http://hl7.org/fhir/spdx-license"), Description("Standard ML of New Jersey License")]
            SMLNJ,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("SMPPL", "http://hl7.org/fhir/spdx-license"), Description("Secure Messaging Protocol Public License")]
            SMPPL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("SNIA", "http://hl7.org/fhir/spdx-license"), Description("SNIA Public License 1.1")]
            SNIA,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Spencer-86", "http://hl7.org/fhir/spdx-license"), Description("Spencer License 86")]
            Spencer86,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Spencer-94", "http://hl7.org/fhir/spdx-license"), Description("Spencer License 94")]
            Spencer94,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Spencer-99", "http://hl7.org/fhir/spdx-license"), Description("Spencer License 99")]
            Spencer99,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("SPL-1.0", "http://hl7.org/fhir/spdx-license"), Description("Sun Public License v1.0")]
            SPL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("SugarCRM-1.1.3", "http://hl7.org/fhir/spdx-license"), Description("SugarCRM Public License v1.1.3")]
            SugarCRM113,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("SWL", "http://hl7.org/fhir/spdx-license"), Description("Scheme Widget Library (SWL) Software License Agreement")]
            SWL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("TCL", "http://hl7.org/fhir/spdx-license"), Description("TCL/TK License")]
            TCL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("TCP-wrappers", "http://hl7.org/fhir/spdx-license"), Description("TCP Wrappers License")]
            TCPWrappers,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("TMate", "http://hl7.org/fhir/spdx-license"), Description("TMate Open Source License")]
            TMate,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("TORQUE-1.1", "http://hl7.org/fhir/spdx-license"), Description("TORQUE v2.5+ Software License v1.1")]
            TORQUE11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("TOSL", "http://hl7.org/fhir/spdx-license"), Description("Trusster Open Source License")]
            TOSL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Unicode-DFS-2015", "http://hl7.org/fhir/spdx-license"), Description("Unicode License Agreement - Data Files and Software (2015)")]
            UnicodeDFS2015,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Unicode-DFS-2016", "http://hl7.org/fhir/spdx-license"), Description("Unicode License Agreement - Data Files and Software (2016)")]
            UnicodeDFS2016,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Unicode-TOU", "http://hl7.org/fhir/spdx-license"), Description("Unicode Terms of Use")]
            UnicodeTOU,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Unlicense", "http://hl7.org/fhir/spdx-license"), Description("The Unlicense")]
            Unlicense,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("UPL-1.0", "http://hl7.org/fhir/spdx-license"), Description("Universal Permissive License v1.0")]
            UPL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Vim", "http://hl7.org/fhir/spdx-license"), Description("Vim License")]
            Vim,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("VOSTROM", "http://hl7.org/fhir/spdx-license"), Description("VOSTROM Public License for Open Source")]
            VOSTROM,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("VSL-1.0", "http://hl7.org/fhir/spdx-license"), Description("Vovida Software License v1.0")]
            VSL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("W3C-19980720", "http://hl7.org/fhir/spdx-license"), Description("W3C Software Notice and License (1998-07-20)")]
            W3C19980720,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("W3C-20150513", "http://hl7.org/fhir/spdx-license"), Description("W3C Software Notice and Document License (2015-05-13)")]
            W3C20150513,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("W3C", "http://hl7.org/fhir/spdx-license"), Description("W3C Software Notice and License (2002-12-31)")]
            W3C,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Watcom-1.0", "http://hl7.org/fhir/spdx-license"), Description("Sybase Open Watcom Public License 1.0")]
            Watcom10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Wsuipa", "http://hl7.org/fhir/spdx-license"), Description("Wsuipa License")]
            Wsuipa,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("WTFPL", "http://hl7.org/fhir/spdx-license"), Description("Do What The F*ck You Want To Public License")]
            WTFPL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("X11", "http://hl7.org/fhir/spdx-license"), Description("X11 License")]
            X11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Xerox", "http://hl7.org/fhir/spdx-license"), Description("Xerox License")]
            Xerox,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("XFree86-1.1", "http://hl7.org/fhir/spdx-license"), Description("XFree86 License 1.1")]
            XFree8611,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("xinetd", "http://hl7.org/fhir/spdx-license"), Description("xinetd License")]
            Xinetd,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Xnet", "http://hl7.org/fhir/spdx-license"), Description("X.Net License")]
            Xnet,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("xpp", "http://hl7.org/fhir/spdx-license"), Description("XPP License")]
            Xpp,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("XSkat", "http://hl7.org/fhir/spdx-license"), Description("XSkat License")]
            XSkat,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("YPL-1.0", "http://hl7.org/fhir/spdx-license"), Description("Yahoo! Public License v1.0")]
            YPL10,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("YPL-1.1", "http://hl7.org/fhir/spdx-license"), Description("Yahoo! Public License v1.1")]
            YPL11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Zed", "http://hl7.org/fhir/spdx-license"), Description("Zed License")]
            Zed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Zend-2.0", "http://hl7.org/fhir/spdx-license"), Description("Zend License v2.0")]
            Zend20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Zimbra-1.3", "http://hl7.org/fhir/spdx-license"), Description("Zimbra Public License v1.3")]
            Zimbra13,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Zimbra-1.4", "http://hl7.org/fhir/spdx-license"), Description("Zimbra Public License v1.4")]
            Zimbra14,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("zlib-acknowledgement", "http://hl7.org/fhir/spdx-license"), Description("zlib/libpng License with Acknowledgement")]
            ZlibAcknowledgement,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("Zlib", "http://hl7.org/fhir/spdx-license"), Description("zlib License")]
            Zlib,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("ZPL-1.1", "http://hl7.org/fhir/spdx-license"), Description("Zope Public License 1.1")]
            ZPL11,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("ZPL-2.0", "http://hl7.org/fhir/spdx-license"), Description("Zope Public License 2.0")]
            ZPL20,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/spdx-license)
            /// </summary>
            [EnumLiteral("ZPL-2.1", "http://hl7.org/fhir/spdx-license"), Description("Zope Public License 2.1")]
            ZPL21,
        }

        /// <summary>
        /// A code that indicates how the page is generated.
        /// (url: http://hl7.org/fhir/ValueSet/guide-page-generation)
        /// </summary>
        [FhirEnumeration("GuidePageGeneration")]
        public enum GuidePageGeneration
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-page-generation)
            /// </summary>
            [EnumLiteral("html", "http://hl7.org/fhir/guide-page-generation"), Description("HTML")]
            Html,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-page-generation)
            /// </summary>
            [EnumLiteral("markdown", "http://hl7.org/fhir/guide-page-generation"), Description("Markdown")]
            Markdown,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-page-generation)
            /// </summary>
            [EnumLiteral("xml", "http://hl7.org/fhir/guide-page-generation"), Description("XML")]
            Xml,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-page-generation)
            /// </summary>
            [EnumLiteral("generated", "http://hl7.org/fhir/guide-page-generation"), Description("Generated")]
            Generated,
        }

        /// <summary>
        /// Code of parameter that is input to the guide.
        /// (url: http://hl7.org/fhir/ValueSet/guide-parameter-code)
        /// </summary>
        [FhirEnumeration("GuideParameterCode")]
        public enum GuideParameterCode
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-parameter-code)
            /// </summary>
            [EnumLiteral("apply-business-version", "http://hl7.org/fhir/guide-parameter-code"), Description("Apply Business Version")]
            ApplyBusinessVersion,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-parameter-code)
            /// </summary>
            [EnumLiteral("apply-jurisdiction", "http://hl7.org/fhir/guide-parameter-code"), Description("Apply Jurisdiction")]
            ApplyJurisdiction,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-parameter-code)
            /// </summary>
            [EnumLiteral("path-resource", "http://hl7.org/fhir/guide-parameter-code"), Description("Resource Path")]
            PathResource,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-parameter-code)
            /// </summary>
            [EnumLiteral("path-pages", "http://hl7.org/fhir/guide-parameter-code"), Description("Pages Path")]
            PathPages,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-parameter-code)
            /// </summary>
            [EnumLiteral("path-tx-cache", "http://hl7.org/fhir/guide-parameter-code"), Description("Terminology Cache Path")]
            PathTxCache,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-parameter-code)
            /// </summary>
            [EnumLiteral("expansion-parameter", "http://hl7.org/fhir/guide-parameter-code"), Description("Expansion Profile")]
            ExpansionParameter,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-parameter-code)
            /// </summary>
            [EnumLiteral("rule-broken-links", "http://hl7.org/fhir/guide-parameter-code"), Description("Broken Links Rule")]
            RuleBrokenLinks,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-parameter-code)
            /// </summary>
            [EnumLiteral("generate-xml", "http://hl7.org/fhir/guide-parameter-code"), Description("Generate XML")]
            GenerateXml,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-parameter-code)
            /// </summary>
            [EnumLiteral("generate-json", "http://hl7.org/fhir/guide-parameter-code"), Description("Generate JSON")]
            GenerateJson,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-parameter-code)
            /// </summary>
            [EnumLiteral("generate-turtle", "http://hl7.org/fhir/guide-parameter-code"), Description("Generate Turtle")]
            GenerateTurtle,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-parameter-code)
            /// </summary>
            [EnumLiteral("html-template", "http://hl7.org/fhir/guide-parameter-code"), Description("HTML Template")]
            HtmlTemplate,
        }


        [FhirType("DependsOnComponent")]
        [DataContract]
        public partial class DependsOnComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DependsOnComponent"; } }

            /// <summary>
            /// Identity of the IG that this depends on
            /// </summary>
            [FhirElement("uri", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Canonical UriElement
            {
                get { return _uriElement; }
                set { _uriElement = value; OnPropertyChanged("UriElement"); }
            }

            private Canonical _uriElement;

            /// <summary>
            /// Identity of the IG that this depends on
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Uri
            {
                get { return UriElement != null ? UriElement.Value : null; }
                set
                {
                    if (value == null)
                        UriElement = null;
                    else
                        UriElement = new Canonical(value);
                    OnPropertyChanged("Uri");
                }
            }

            /// <summary>
            /// NPM Package name for IG this depends on
            /// </summary>
            [FhirElement("packageId", InSummary=true, Order=50)]
            [DataMember]
            public Id PackageIdElement
            {
                get { return _packageIdElement; }
                set { _packageIdElement = value; OnPropertyChanged("PackageIdElement"); }
            }

            private Id _packageIdElement;

            /// <summary>
            /// NPM Package name for IG this depends on
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string PackageId
            {
                get { return PackageIdElement != null ? PackageIdElement.Value : null; }
                set
                {
                    if (value == null)
                        PackageIdElement = null;
                    else
                        PackageIdElement = new Id(value);
                    OnPropertyChanged("PackageId");
                }
            }

            /// <summary>
            /// Version of the IG
            /// </summary>
            [FhirElement("version", InSummary=true, Order=60)]
            [DataMember]
            public FhirString VersionElement
            {
                get { return _versionElement; }
                set { _versionElement = value; OnPropertyChanged("VersionElement"); }
            }

            private FhirString _versionElement;

            /// <summary>
            /// Version of the IG
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Version
            {
                get { return VersionElement != null ? VersionElement.Value : null; }
                set
                {
                    if (value == null)
                        VersionElement = null;
                    else
                        VersionElement = new FhirString(value);
                    OnPropertyChanged("Version");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DependsOnComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (UriElement != null) dest.UriElement = (Canonical)UriElement.DeepCopy();
                    if (PackageIdElement != null) dest.PackageIdElement = (Id)PackageIdElement.DeepCopy();
                    if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DependsOnComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DependsOnComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(UriElement, otherT.UriElement)) return false;
                if (!DeepComparable.Matches(PackageIdElement, otherT.PackageIdElement)) return false;
                if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DependsOnComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(UriElement, otherT.UriElement)) return false;
                if (!DeepComparable.IsExactly(PackageIdElement, otherT.PackageIdElement)) return false;
                if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (UriElement != null) yield return UriElement;
                    if (PackageIdElement != null) yield return PackageIdElement;
                    if (VersionElement != null) yield return VersionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (UriElement != null) yield return new ElementValue("uri", UriElement);
                    if (PackageIdElement != null) yield return new ElementValue("packageId", PackageIdElement);
                    if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                }
            }


        }


        [FhirType("GlobalComponent")]
        [DataContract]
        public partial class GlobalComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "GlobalComponent"; } }

            /// <summary>
            /// Type this profile applies to
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ResourceType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<ResourceType> _typeElement;

            /// <summary>
            /// Type this profile applies to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ResourceType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<ResourceType>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// Profile that all resources must conform to
            /// </summary>
            [FhirElement("profile", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Canonical ProfileElement
            {
                get { return _profileElement; }
                set { _profileElement = value; OnPropertyChanged("ProfileElement"); }
            }

            private Canonical _profileElement;

            /// <summary>
            /// Profile that all resources must conform to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Profile
            {
                get { return ProfileElement != null ? ProfileElement.Value : null; }
                set
                {
                    if (value == null)
                        ProfileElement = null;
                    else
                        ProfileElement = new Canonical(value);
                    OnPropertyChanged("Profile");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as GlobalComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TypeElement != null) dest.TypeElement = (Code<ResourceType>)TypeElement.DeepCopy();
                    if (ProfileElement != null) dest.ProfileElement = (Canonical)ProfileElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new GlobalComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as GlobalComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(ProfileElement, otherT.ProfileElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as GlobalComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(ProfileElement, otherT.ProfileElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (ProfileElement != null) yield return ProfileElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (ProfileElement != null) yield return new ElementValue("profile", ProfileElement);
                }
            }


        }


        [FhirType("DefinitionComponent")]
        [DataContract]
        public partial class DefinitionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DefinitionComponent"; } }

            /// <summary>
            /// Grouping used to present related resources in the IG
            /// </summary>
            [FhirElement("package", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PackageComponent> Package
            {
                get { if (_package==null) _package = new List<PackageComponent>(); return _package; }
                set { _package = value; OnPropertyChanged("Package"); }
            }

            private List<PackageComponent> _package;

            /// <summary>
            /// Resource in the implementation guide
            /// </summary>
            [FhirElement("resource", Order=50)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<ResourceComponent> Resource
            {
                get { if (_resource==null) _resource = new List<ResourceComponent>(); return _resource; }
                set { _resource = value; OnPropertyChanged("Resource"); }
            }

            private List<ResourceComponent> _resource;

            /// <summary>
            /// Page/Section in the Guide
            /// </summary>
            [FhirElement("page", Order=60)]
            [DataMember]
            public PageComponent Page
            {
                get { return _page; }
                set { _page = value; OnPropertyChanged("Page"); }
            }

            private PageComponent _page;

            /// <summary>
            /// Defines how IG is built by tools
            /// </summary>
            [FhirElement("parameter", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ParameterComponent> Parameter
            {
                get { if (_parameter==null) _parameter = new List<ParameterComponent>(); return _parameter; }
                set { _parameter = value; OnPropertyChanged("Parameter"); }
            }

            private List<ParameterComponent> _parameter;

            /// <summary>
            /// A template for building resources
            /// </summary>
            [FhirElement("template", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<TemplateComponent> Template
            {
                get { if (_template==null) _template = new List<TemplateComponent>(); return _template; }
                set { _template = value; OnPropertyChanged("Template"); }
            }

            private List<TemplateComponent> _template;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DefinitionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Package != null) dest.Package = new List<PackageComponent>(Package.DeepCopy());
                    if (Resource != null) dest.Resource = new List<ResourceComponent>(Resource.DeepCopy());
                    if (Page != null) dest.Page = (PageComponent)Page.DeepCopy();
                    if (Parameter != null) dest.Parameter = new List<ParameterComponent>(Parameter.DeepCopy());
                    if (Template != null) dest.Template = new List<TemplateComponent>(Template.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DefinitionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DefinitionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(Package, otherT.Package)) return false;
                if ( !DeepComparable.Matches(Resource, otherT.Resource)) return false;
                if (!DeepComparable.Matches(Page, otherT.Page)) return false;
                if ( !DeepComparable.Matches(Parameter, otherT.Parameter)) return false;
                if ( !DeepComparable.Matches(Template, otherT.Template)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DefinitionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Package, otherT.Package)) return false;
                if (!DeepComparable.IsExactly(Resource, otherT.Resource)) return false;
                if (!DeepComparable.IsExactly(Page, otherT.Page)) return false;
                if (!DeepComparable.IsExactly(Parameter, otherT.Parameter)) return false;
                if (!DeepComparable.IsExactly(Template, otherT.Template)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Package) { if (elem != null) yield return elem; }
                    foreach (var elem in Resource) { if (elem != null) yield return elem; }
                    if (Page != null) yield return Page;
                    foreach (var elem in Parameter) { if (elem != null) yield return elem; }
                    foreach (var elem in Template) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Package) { if (elem != null) yield return new ElementValue("package", elem); }
                    foreach (var elem in Resource) { if (elem != null) yield return new ElementValue("resource", elem); }
                    if (Page != null) yield return new ElementValue("page", Page);
                    foreach (var elem in Parameter) { if (elem != null) yield return new ElementValue("parameter", elem); }
                    foreach (var elem in Template) { if (elem != null) yield return new ElementValue("template", elem); }
                }
            }


        }


        [FhirType("PackageComponent")]
        [DataContract]
        public partial class PackageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PackageComponent"; } }

            /// <summary>
            /// Descriptive name for the package
            /// </summary>
            [FhirElement("name", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Descriptive name for the package
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if (value == null)
                        NameElement = null;
                    else
                        NameElement = new FhirString(value);
                    OnPropertyChanged("Name");
                }
            }

            /// <summary>
            /// Human readable text describing the package
            /// </summary>
            [FhirElement("description", Order=50)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Human readable text describing the package
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Description
            {
                get { return DescriptionElement != null ? DescriptionElement.Value : null; }
                set
                {
                    if (value == null)
                        DescriptionElement = null;
                    else
                        DescriptionElement = new FhirString(value);
                    OnPropertyChanged("Description");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PackageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PackageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PackageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PackageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                }
            }


        }


        [FhirType("ResourceComponent")]
        [DataContract]
        public partial class ResourceComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ResourceComponent"; } }

            /// <summary>
            /// Location of the resource
            /// </summary>
            [FhirElement("reference", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Reference
            {
                get { return _reference; }
                set { _reference = value; OnPropertyChanged("Reference"); }
            }

            private ResourceReference _reference;

            /// <summary>
            /// Human Name for the resource
            /// </summary>
            [FhirElement("name", Order=50)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Human Name for the resource
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if (value == null)
                        NameElement = null;
                    else
                        NameElement = new FhirString(value);
                    OnPropertyChanged("Name");
                }
            }

            /// <summary>
            /// Reason why included in guide
            /// </summary>
            [FhirElement("description", Order=60)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Reason why included in guide
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Description
            {
                get { return DescriptionElement != null ? DescriptionElement.Value : null; }
                set
                {
                    if (value == null)
                        DescriptionElement = null;
                    else
                        DescriptionElement = new FhirString(value);
                    OnPropertyChanged("Description");
                }
            }

            /// <summary>
            /// Is an example/What is this an example of?
            /// </summary>
            [FhirElement("example", Order=70, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirBoolean),typeof(Canonical))]
            [DataMember]
            public Element Example
            {
                get { return _example; }
                set { _example = value; OnPropertyChanged("Example"); }
            }

            private Element _example;

            /// <summary>
            /// Pack this is part of
            /// </summary>
            [FhirElement("package", Order=80)]
            [DataMember]
            public Id PackageElement
            {
                get { return _packageElement; }
                set { _packageElement = value; OnPropertyChanged("PackageElement"); }
            }

            private Id _packageElement;

            /// <summary>
            /// Pack this is part of
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Package
            {
                get { return PackageElement != null ? PackageElement.Value : null; }
                set
                {
                    if (value == null)
                        PackageElement = null;
                    else
                        PackageElement = new Id(value);
                    OnPropertyChanged("Package");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ResourceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Reference != null) dest.Reference = (ResourceReference)Reference.DeepCopy();
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (Example != null) dest.Example = (Element)Example.DeepCopy();
                    if (PackageElement != null) dest.PackageElement = (Id)PackageElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ResourceComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ResourceComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Reference, otherT.Reference)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(Example, otherT.Example)) return false;
                if (!DeepComparable.Matches(PackageElement, otherT.PackageElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ResourceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Reference, otherT.Reference)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(Example, otherT.Example)) return false;
                if (!DeepComparable.IsExactly(PackageElement, otherT.PackageElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Reference != null) yield return Reference;
                    if (NameElement != null) yield return NameElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (Example != null) yield return Example;
                    if (PackageElement != null) yield return PackageElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Reference != null) yield return new ElementValue("reference", Reference);
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (Example != null) yield return new ElementValue("example", Example);
                    if (PackageElement != null) yield return new ElementValue("package", PackageElement);
                }
            }


        }


        [FhirType("PageComponent")]
        [DataContract]
        public partial class PageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PageComponent"; } }

            /// <summary>
            /// Where to find that page
            /// </summary>
            [FhirElement("name", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirUrl),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Name
            {
                get { return _name; }
                set { _name = value; OnPropertyChanged("Name"); }
            }

            private Element _name;

            /// <summary>
            /// Short title shown for navigational assistance
            /// </summary>
            [FhirElement("title", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString TitleElement
            {
                get { return _titleElement; }
                set { _titleElement = value; OnPropertyChanged("TitleElement"); }
            }

            private FhirString _titleElement;

            /// <summary>
            /// Short title shown for navigational assistance
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Title
            {
                get { return TitleElement != null ? TitleElement.Value : null; }
                set
                {
                    if (value == null)
                        TitleElement = null;
                    else
                        TitleElement = new FhirString(value);
                    OnPropertyChanged("Title");
                }
            }

            /// <summary>
            /// html | markdown | xml | generated
            /// </summary>
            [FhirElement("generation", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<GuidePageGeneration> GenerationElement
            {
                get { return _generationElement; }
                set { _generationElement = value; OnPropertyChanged("GenerationElement"); }
            }

            private Code<GuidePageGeneration> _generationElement;

            /// <summary>
            /// html | markdown | xml | generated
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public GuidePageGeneration? Generation
            {
                get { return GenerationElement != null ? GenerationElement.Value : null; }
                set
                {
                    if (value == null)
                        GenerationElement = null;
                    else
                        GenerationElement = new Code<GuidePageGeneration>(value);
                    OnPropertyChanged("Generation");
                }
            }

            /// <summary>
            /// Nested Pages / Sections
            /// </summary>
            [FhirElement("page", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PageComponent> Page
            {
                get { if (_page==null) _page = new List<PageComponent>(); return _page; }
                set { _page = value; OnPropertyChanged("Page"); }
            }

            private List<PageComponent> _page;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Name != null) dest.Name = (Element)Name.DeepCopy();
                    if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                    if (GenerationElement != null) dest.GenerationElement = (Code<GuidePageGeneration>)GenerationElement.DeepCopy();
                    if (Page != null) dest.Page = new List<PageComponent>(Page.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Name, otherT.Name)) return false;
                if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
                if (!DeepComparable.Matches(GenerationElement, otherT.GenerationElement)) return false;
                if ( !DeepComparable.Matches(Page, otherT.Page)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Name, otherT.Name)) return false;
                if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
                if (!DeepComparable.IsExactly(GenerationElement, otherT.GenerationElement)) return false;
                if (!DeepComparable.IsExactly(Page, otherT.Page)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Name != null) yield return Name;
                    if (TitleElement != null) yield return TitleElement;
                    if (GenerationElement != null) yield return GenerationElement;
                    foreach (var elem in Page) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Name != null) yield return new ElementValue("name", Name);
                    if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                    if (GenerationElement != null) yield return new ElementValue("generation", GenerationElement);
                    foreach (var elem in Page) { if (elem != null) yield return new ElementValue("page", elem); }
                }
            }


        }


        [FhirType("ParameterComponent")]
        [DataContract]
        public partial class ParameterComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ParameterComponent"; } }

            /// <summary>
            /// apply-business-version | apply-jurisdiction | path-resource | path-pages | path-tx-cache | expansion-parameter | rule-broken-links | generate-xml | generate-json | generate-turtle | html-template
            /// </summary>
            [FhirElement("code", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<GuideParameterCode> CodeElement
            {
                get { return _codeElement; }
                set { _codeElement = value; OnPropertyChanged("CodeElement"); }
            }

            private Code<GuideParameterCode> _codeElement;

            /// <summary>
            /// apply-business-version | apply-jurisdiction | path-resource | path-pages | path-tx-cache | expansion-parameter | rule-broken-links | generate-xml | generate-json | generate-turtle | html-template
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public GuideParameterCode? Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if (value == null)
                        CodeElement = null;
                    else
                        CodeElement = new Code<GuideParameterCode>(value);
                    OnPropertyChanged("Code");
                }
            }

            /// <summary>
            /// Value for named type
            /// </summary>
            [FhirElement("value", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private FhirString _valueElement;

            /// <summary>
            /// Value for named type
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (value == null)
                        ValueElement = null;
                    else
                        ValueElement = new FhirString(value);
                    OnPropertyChanged("Value");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ParameterComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CodeElement != null) dest.CodeElement = (Code<GuideParameterCode>)CodeElement.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirString)ValueElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ParameterComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ParameterComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParameterComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CodeElement != null) yield return CodeElement;
                    if (ValueElement != null) yield return ValueElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                }
            }


        }


        [FhirType("TemplateComponent")]
        [DataContract]
        public partial class TemplateComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TemplateComponent"; } }

            /// <summary>
            /// Type of template specified
            /// </summary>
            [FhirElement("code", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code CodeElement
            {
                get { return _codeElement; }
                set { _codeElement = value; OnPropertyChanged("CodeElement"); }
            }

            private Code _codeElement;

            /// <summary>
            /// Type of template specified
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if (value == null)
                        CodeElement = null;
                    else
                        CodeElement = new Code(value);
                    OnPropertyChanged("Code");
                }
            }

            /// <summary>
            /// The source location for the template
            /// </summary>
            [FhirElement("source", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString SourceElement
            {
                get { return _sourceElement; }
                set { _sourceElement = value; OnPropertyChanged("SourceElement"); }
            }

            private FhirString _sourceElement;

            /// <summary>
            /// The source location for the template
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Source
            {
                get { return SourceElement != null ? SourceElement.Value : null; }
                set
                {
                    if (value == null)
                        SourceElement = null;
                    else
                        SourceElement = new FhirString(value);
                    OnPropertyChanged("Source");
                }
            }

            /// <summary>
            /// The scope in which the template applies
            /// </summary>
            [FhirElement("scope", Order=60)]
            [DataMember]
            public FhirString ScopeElement
            {
                get { return _scopeElement; }
                set { _scopeElement = value; OnPropertyChanged("ScopeElement"); }
            }

            private FhirString _scopeElement;

            /// <summary>
            /// The scope in which the template applies
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Scope
            {
                get { return ScopeElement != null ? ScopeElement.Value : null; }
                set
                {
                    if (value == null)
                        ScopeElement = null;
                    else
                        ScopeElement = new FhirString(value);
                    OnPropertyChanged("Scope");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TemplateComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CodeElement != null) dest.CodeElement = (Code)CodeElement.DeepCopy();
                    if (SourceElement != null) dest.SourceElement = (FhirString)SourceElement.DeepCopy();
                    if (ScopeElement != null) dest.ScopeElement = (FhirString)ScopeElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TemplateComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TemplateComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.Matches(SourceElement, otherT.SourceElement)) return false;
                if (!DeepComparable.Matches(ScopeElement, otherT.ScopeElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TemplateComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.IsExactly(SourceElement, otherT.SourceElement)) return false;
                if (!DeepComparable.IsExactly(ScopeElement, otherT.ScopeElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CodeElement != null) yield return CodeElement;
                    if (SourceElement != null) yield return SourceElement;
                    if (ScopeElement != null) yield return ScopeElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                    if (SourceElement != null) yield return new ElementValue("source", SourceElement);
                    if (ScopeElement != null) yield return new ElementValue("scope", ScopeElement);
                }
            }


        }


        [FhirType("ManifestComponent")]
        [DataContract]
        public partial class ManifestComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ManifestComponent"; } }

            /// <summary>
            /// Location of rendered implementation guide
            /// </summary>
            [FhirElement("rendering", InSummary=true, Order=40)]
            [DataMember]
            public FhirUrl RenderingElement
            {
                get { return _renderingElement; }
                set { _renderingElement = value; OnPropertyChanged("RenderingElement"); }
            }

            private FhirUrl _renderingElement;

            /// <summary>
            /// Location of rendered implementation guide
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Rendering
            {
                get { return RenderingElement != null ? RenderingElement.Value : null; }
                set
                {
                    if (value == null)
                        RenderingElement = null;
                    else
                        RenderingElement = new FhirUrl(value);
                    OnPropertyChanged("Rendering");
                }
            }

            /// <summary>
            /// Resource in the implementation guide
            /// </summary>
            [FhirElement("resource", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<ManifestResourceComponent> Resource
            {
                get { if (_resource==null) _resource = new List<ManifestResourceComponent>(); return _resource; }
                set { _resource = value; OnPropertyChanged("Resource"); }
            }

            private List<ManifestResourceComponent> _resource;

            /// <summary>
            /// HTML page within the parent IG
            /// </summary>
            [FhirElement("page", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ManifestPageComponent> Page
            {
                get { if (_page==null) _page = new List<ManifestPageComponent>(); return _page; }
                set { _page = value; OnPropertyChanged("Page"); }
            }

            private List<ManifestPageComponent> _page;

            /// <summary>
            /// Image within the IG
            /// </summary>
            [FhirElement("image", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> ImageElement
            {
                get { if (_imageElement==null) _imageElement = new List<FhirString>(); return _imageElement; }
                set { _imageElement = value; OnPropertyChanged("ImageElement"); }
            }

            private List<FhirString> _imageElement;

            /// <summary>
            /// Image within the IG
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> Image
            {
                get { return ImageElement != null ? ImageElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ImageElement = null;
                    else
                        ImageElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("Image");
                }
            }

            /// <summary>
            /// Additional linkable file in IG
            /// </summary>
            [FhirElement("other", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> OtherElement
            {
                get { if (_otherElement==null) _otherElement = new List<FhirString>(); return _otherElement; }
                set { _otherElement = value; OnPropertyChanged("OtherElement"); }
            }

            private List<FhirString> _otherElement;

            /// <summary>
            /// Additional linkable file in IG
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> Other
            {
                get { return OtherElement != null ? OtherElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        OtherElement = null;
                    else
                        OtherElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("Other");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ManifestComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (RenderingElement != null) dest.RenderingElement = (FhirUrl)RenderingElement.DeepCopy();
                    if (Resource != null) dest.Resource = new List<ManifestResourceComponent>(Resource.DeepCopy());
                    if (Page != null) dest.Page = new List<ManifestPageComponent>(Page.DeepCopy());
                    if (ImageElement != null) dest.ImageElement = new List<FhirString>(ImageElement.DeepCopy());
                    if (OtherElement != null) dest.OtherElement = new List<FhirString>(OtherElement.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ManifestComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ManifestComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(RenderingElement, otherT.RenderingElement)) return false;
                if ( !DeepComparable.Matches(Resource, otherT.Resource)) return false;
                if ( !DeepComparable.Matches(Page, otherT.Page)) return false;
                if ( !DeepComparable.Matches(ImageElement, otherT.ImageElement)) return false;
                if ( !DeepComparable.Matches(OtherElement, otherT.OtherElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ManifestComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(RenderingElement, otherT.RenderingElement)) return false;
                if (!DeepComparable.IsExactly(Resource, otherT.Resource)) return false;
                if (!DeepComparable.IsExactly(Page, otherT.Page)) return false;
                if (!DeepComparable.IsExactly(ImageElement, otherT.ImageElement)) return false;
                if (!DeepComparable.IsExactly(OtherElement, otherT.OtherElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (RenderingElement != null) yield return RenderingElement;
                    foreach (var elem in Resource) { if (elem != null) yield return elem; }
                    foreach (var elem in Page) { if (elem != null) yield return elem; }
                    foreach (var elem in ImageElement) { if (elem != null) yield return elem; }
                    foreach (var elem in OtherElement) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (RenderingElement != null) yield return new ElementValue("rendering", RenderingElement);
                    foreach (var elem in Resource) { if (elem != null) yield return new ElementValue("resource", elem); }
                    foreach (var elem in Page) { if (elem != null) yield return new ElementValue("page", elem); }
                    foreach (var elem in ImageElement) { if (elem != null) yield return new ElementValue("image", elem); }
                    foreach (var elem in OtherElement) { if (elem != null) yield return new ElementValue("other", elem); }
                }
            }


        }


        [FhirType("ManifestResourceComponent")]
        [DataContract]
        public partial class ManifestResourceComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ManifestResourceComponent"; } }

            /// <summary>
            /// Location of the resource
            /// </summary>
            [FhirElement("reference", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Reference
            {
                get { return _reference; }
                set { _reference = value; OnPropertyChanged("Reference"); }
            }

            private ResourceReference _reference;

            /// <summary>
            /// Is an example/What is this an example of?
            /// </summary>
            [FhirElement("example", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirBoolean),typeof(Canonical))]
            [DataMember]
            public Element Example
            {
                get { return _example; }
                set { _example = value; OnPropertyChanged("Example"); }
            }

            private Element _example;

            /// <summary>
            /// Relative path for page in IG
            /// </summary>
            [FhirElement("relativePath", Order=60)]
            [DataMember]
            public FhirUrl RelativePathElement
            {
                get { return _relativePathElement; }
                set { _relativePathElement = value; OnPropertyChanged("RelativePathElement"); }
            }

            private FhirUrl _relativePathElement;

            /// <summary>
            /// Relative path for page in IG
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string RelativePath
            {
                get { return RelativePathElement != null ? RelativePathElement.Value : null; }
                set
                {
                    if (value == null)
                        RelativePathElement = null;
                    else
                        RelativePathElement = new FhirUrl(value);
                    OnPropertyChanged("RelativePath");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ManifestResourceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Reference != null) dest.Reference = (ResourceReference)Reference.DeepCopy();
                    if (Example != null) dest.Example = (Element)Example.DeepCopy();
                    if (RelativePathElement != null) dest.RelativePathElement = (FhirUrl)RelativePathElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ManifestResourceComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ManifestResourceComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Reference, otherT.Reference)) return false;
                if (!DeepComparable.Matches(Example, otherT.Example)) return false;
                if (!DeepComparable.Matches(RelativePathElement, otherT.RelativePathElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ManifestResourceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Reference, otherT.Reference)) return false;
                if (!DeepComparable.IsExactly(Example, otherT.Example)) return false;
                if (!DeepComparable.IsExactly(RelativePathElement, otherT.RelativePathElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Reference != null) yield return Reference;
                    if (Example != null) yield return Example;
                    if (RelativePathElement != null) yield return RelativePathElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Reference != null) yield return new ElementValue("reference", Reference);
                    if (Example != null) yield return new ElementValue("example", Example);
                    if (RelativePathElement != null) yield return new ElementValue("relativePath", RelativePathElement);
                }
            }


        }


        [FhirType("ManifestPageComponent")]
        [DataContract]
        public partial class ManifestPageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ManifestPageComponent"; } }

            /// <summary>
            /// HTML page name
            /// </summary>
            [FhirElement("name", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// HTML page name
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if (value == null)
                        NameElement = null;
                    else
                        NameElement = new FhirString(value);
                    OnPropertyChanged("Name");
                }
            }

            /// <summary>
            /// Title of the page, for references
            /// </summary>
            [FhirElement("title", Order=50)]
            [DataMember]
            public FhirString TitleElement
            {
                get { return _titleElement; }
                set { _titleElement = value; OnPropertyChanged("TitleElement"); }
            }

            private FhirString _titleElement;

            /// <summary>
            /// Title of the page, for references
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Title
            {
                get { return TitleElement != null ? TitleElement.Value : null; }
                set
                {
                    if (value == null)
                        TitleElement = null;
                    else
                        TitleElement = new FhirString(value);
                    OnPropertyChanged("Title");
                }
            }

            /// <summary>
            /// Anchor available on the page
            /// </summary>
            [FhirElement("anchor", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> AnchorElement
            {
                get { if (_anchorElement==null) _anchorElement = new List<FhirString>(); return _anchorElement; }
                set { _anchorElement = value; OnPropertyChanged("AnchorElement"); }
            }

            private List<FhirString> _anchorElement;

            /// <summary>
            /// Anchor available on the page
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> Anchor
            {
                get { return AnchorElement != null ? AnchorElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        AnchorElement = null;
                    else
                        AnchorElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("Anchor");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ManifestPageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                    if (AnchorElement != null) dest.AnchorElement = new List<FhirString>(AnchorElement.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ManifestPageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ManifestPageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
                if ( !DeepComparable.Matches(AnchorElement, otherT.AnchorElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ManifestPageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
                if (!DeepComparable.IsExactly(AnchorElement, otherT.AnchorElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (TitleElement != null) yield return TitleElement;
                    foreach (var elem in AnchorElement) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                    foreach (var elem in AnchorElement) { if (elem != null) yield return new ElementValue("anchor", elem); }
                }
            }


        }


        /// <summary>
        /// Canonical identifier for this implementation guide, represented as a URI (globally unique)
        /// </summary>
        [FhirElement("url", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirUri UrlElement
        {
            get { return _urlElement; }
            set { _urlElement = value; OnPropertyChanged("UrlElement"); }
        }

        private FhirUri _urlElement;

        /// <summary>
        /// Canonical identifier for this implementation guide, represented as a URI (globally unique)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Url
        {
            get { return UrlElement != null ? UrlElement.Value : null; }
            set
            {
                if (value == null)
                    UrlElement = null;
                else
                    UrlElement = new FhirUri(value);
                OnPropertyChanged("Url");
            }
        }

        /// <summary>
        /// Business version of the implementation guide
        /// </summary>
        [FhirElement("version", InSummary=true, Order=100)]
        [DataMember]
        public FhirString VersionElement
        {
            get { return _versionElement; }
            set { _versionElement = value; OnPropertyChanged("VersionElement"); }
        }

        private FhirString _versionElement;

        /// <summary>
        /// Business version of the implementation guide
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Version
        {
            get { return VersionElement != null ? VersionElement.Value : null; }
            set
            {
                if (value == null)
                    VersionElement = null;
                else
                    VersionElement = new FhirString(value);
                OnPropertyChanged("Version");
            }
        }

        /// <summary>
        /// Name for this implementation guide (computer friendly)
        /// </summary>
        [FhirElement("name", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// Name for this implementation guide (computer friendly)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Name
        {
            get { return NameElement != null ? NameElement.Value : null; }
            set
            {
                if (value == null)
                    NameElement = null;
                else
                    NameElement = new FhirString(value);
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Name for this implementation guide (human friendly)
        /// </summary>
        [FhirElement("title", InSummary=true, Order=120)]
        [DataMember]
        public FhirString TitleElement
        {
            get { return _titleElement; }
            set { _titleElement = value; OnPropertyChanged("TitleElement"); }
        }

        private FhirString _titleElement;

        /// <summary>
        /// Name for this implementation guide (human friendly)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Title
        {
            get { return TitleElement != null ? TitleElement.Value : null; }
            set
            {
                if (value == null)
                    TitleElement = null;
                else
                    TitleElement = new FhirString(value);
                OnPropertyChanged("Title");
            }
        }

        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=130)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<PublicationStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<PublicationStatus> _statusElement;

        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public PublicationStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<PublicationStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// For testing purposes, not real usage
        /// </summary>
        [FhirElement("experimental", InSummary=true, Order=140)]
        [DataMember]
        public FhirBoolean ExperimentalElement
        {
            get { return _experimentalElement; }
            set { _experimentalElement = value; OnPropertyChanged("ExperimentalElement"); }
        }

        private FhirBoolean _experimentalElement;

        /// <summary>
        /// For testing purposes, not real usage
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Experimental
        {
            get { return ExperimentalElement != null ? ExperimentalElement.Value : null; }
            set
            {
                if (value == null)
                    ExperimentalElement = null;
                else
                    ExperimentalElement = new FhirBoolean(value);
                OnPropertyChanged("Experimental");
            }
        }

        /// <summary>
        /// Date last changed
        /// </summary>
        [FhirElement("date", InSummary=true, Order=150)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// Date last changed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if (value == null)
                    DateElement = null;
                else
                    DateElement = new FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }

        /// <summary>
        /// Name of the publisher (organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary=true, Order=160)]
        [DataMember]
        public FhirString PublisherElement
        {
            get { return _publisherElement; }
            set { _publisherElement = value; OnPropertyChanged("PublisherElement"); }
        }

        private FhirString _publisherElement;

        /// <summary>
        /// Name of the publisher (organization or individual)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Publisher
        {
            get { return PublisherElement != null ? PublisherElement.Value : null; }
            set
            {
                if (value == null)
                    PublisherElement = null;
                else
                    PublisherElement = new FhirString(value);
                OnPropertyChanged("Publisher");
            }
        }

        /// <summary>
        /// Contact details for the publisher
        /// </summary>
        [FhirElement("contact", InSummary=true, Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Contact
        {
            get { if (_contact==null) _contact = new List<ContactDetail>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactDetail> _contact;

        /// <summary>
        /// Natural language description of the implementation guide
        /// </summary>
        [FhirElement("description", Order=180)]
        [DataMember]
        public Markdown DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private Markdown _descriptionElement;

        /// <summary>
        /// Natural language description of the implementation guide
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if (value == null)
                    DescriptionElement = null;
                else
                    DescriptionElement = new Markdown(value);
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// The context that the content is intended to support
        /// </summary>
        [FhirElement("useContext", InSummary=true, Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<UsageContext> UseContext
        {
            get { if (_useContext==null) _useContext = new List<UsageContext>(); return _useContext; }
            set { _useContext = value; OnPropertyChanged("UseContext"); }
        }

        private List<UsageContext> _useContext;

        /// <summary>
        /// Intended jurisdiction for implementation guide (if applicable)
        /// </summary>
        [FhirElement("jurisdiction", InSummary=true, Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Jurisdiction
        {
            get { if (_jurisdiction==null) _jurisdiction = new List<CodeableConcept>(); return _jurisdiction; }
            set { _jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
        }

        private List<CodeableConcept> _jurisdiction;

        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        [FhirElement("copyright", Order=210)]
        [DataMember]
        public Markdown CopyrightElement
        {
            get { return _copyrightElement; }
            set { _copyrightElement = value; OnPropertyChanged("CopyrightElement"); }
        }

        private Markdown _copyrightElement;

        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Copyright
        {
            get { return CopyrightElement != null ? CopyrightElement.Value : null; }
            set
            {
                if (value == null)
                    CopyrightElement = null;
                else
                    CopyrightElement = new Markdown(value);
                OnPropertyChanged("Copyright");
            }
        }

        /// <summary>
        /// NPM Package name for IG
        /// </summary>
        [FhirElement("packageId", InSummary=true, Order=220)]
        [DataMember]
        public Id PackageIdElement
        {
            get { return _packageIdElement; }
            set { _packageIdElement = value; OnPropertyChanged("PackageIdElement"); }
        }

        private Id _packageIdElement;

        /// <summary>
        /// NPM Package name for IG
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string PackageId
        {
            get { return PackageIdElement != null ? PackageIdElement.Value : null; }
            set
            {
                if (value == null)
                    PackageIdElement = null;
                else
                    PackageIdElement = new Id(value);
                OnPropertyChanged("PackageId");
            }
        }

        /// <summary>
        /// SPDX license code for this IG (or not-open-source)
        /// </summary>
        [FhirElement("license", InSummary=true, Order=230)]
        [DataMember]
        public Code<SPDXLicense> LicenseElement
        {
            get { return _licenseElement; }
            set { _licenseElement = value; OnPropertyChanged("LicenseElement"); }
        }

        private Code<SPDXLicense> _licenseElement;

        /// <summary>
        /// SPDX license code for this IG (or not-open-source)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public SPDXLicense? License
        {
            get { return LicenseElement != null ? LicenseElement.Value : null; }
            set
            {
                if (value == null)
                    LicenseElement = null;
                else
                    LicenseElement = new Code<SPDXLicense>(value);
                OnPropertyChanged("License");
            }
        }

        /// <summary>
        /// FHIR Version this Implementation Guide targets
        /// </summary>
        [FhirElement("fhirVersion", InSummary=true, Order=240)]
        [DataMember]
        public Id FhirVersionElement
        {
            get { return _fhirVersionElement; }
            set { _fhirVersionElement = value; OnPropertyChanged("FhirVersionElement"); }
        }

        private Id _fhirVersionElement;

        /// <summary>
        /// FHIR Version this Implementation Guide targets
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string FhirVersion
        {
            get { return FhirVersionElement != null ? FhirVersionElement.Value : null; }
            set
            {
                if (value == null)
                    FhirVersionElement = null;
                else
                    FhirVersionElement = new Id(value);
                OnPropertyChanged("FhirVersion");
            }
        }

        /// <summary>
        /// Another Implementation guide this depends on
        /// </summary>
        [FhirElement("dependsOn", InSummary=true, Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DependsOnComponent> DependsOn
        {
            get { if (_dependsOn==null) _dependsOn = new List<DependsOnComponent>(); return _dependsOn; }
            set { _dependsOn = value; OnPropertyChanged("DependsOn"); }
        }

        private List<DependsOnComponent> _dependsOn;

        /// <summary>
        /// Profiles that apply globally
        /// </summary>
        [FhirElement("global", InSummary=true, Order=260)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<GlobalComponent> Global
        {
            get { if (_global==null) _global = new List<GlobalComponent>(); return _global; }
            set { _global = value; OnPropertyChanged("Global"); }
        }

        private List<GlobalComponent> _global;

        /// <summary>
        /// Information needed to build the IG
        /// </summary>
        [FhirElement("definition", Order=270)]
        [DataMember]
        public DefinitionComponent Definition
        {
            get { return _definition; }
            set { _definition = value; OnPropertyChanged("Definition"); }
        }

        private DefinitionComponent _definition;

        /// <summary>
        /// Information about an assembled IG
        /// </summary>
        [FhirElement("manifest", Order=280)]
        [DataMember]
        public ManifestComponent Manifest
        {
            get { return _manifest; }
            set { _manifest = value; OnPropertyChanged("Manifest"); }
        }

        private ManifestComponent _manifest;


        public static ElementDefinition.ConstraintComponent ImplementationGuide_IG_0 = new ElementDefinition.ConstraintComponent
        {
            Expression = "name.matches('[A-Z]([A-Za-z0-9_]){0,254}')",
            Key = "ig-0",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Name should be usable as an identifier for the module by machine processing applications such as code generation",
            Xpath = "not(exists(f:name/@value)) or matches(f:name/@value, '[A-Z]([A-Za-z0-9_]){0,254}')"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(ImplementationGuide_IG_0);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ImplementationGuide;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<PublicationStatus>)StatusElement.DeepCopy();
                if (ExperimentalElement != null) dest.ExperimentalElement = (FhirBoolean)ExperimentalElement.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (PublisherElement != null) dest.PublisherElement = (FhirString)PublisherElement.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactDetail>(Contact.DeepCopy());
                if (DescriptionElement != null) dest.DescriptionElement = (Markdown)DescriptionElement.DeepCopy();
                if (UseContext != null) dest.UseContext = new List<UsageContext>(UseContext.DeepCopy());
                if (Jurisdiction != null) dest.Jurisdiction = new List<CodeableConcept>(Jurisdiction.DeepCopy());
                if (CopyrightElement != null) dest.CopyrightElement = (Markdown)CopyrightElement.DeepCopy();
                if (PackageIdElement != null) dest.PackageIdElement = (Id)PackageIdElement.DeepCopy();
                if (LicenseElement != null) dest.LicenseElement = (Code<SPDXLicense>)LicenseElement.DeepCopy();
                if (FhirVersionElement != null) dest.FhirVersionElement = (Id)FhirVersionElement.DeepCopy();
                if (DependsOn != null) dest.DependsOn = new List<DependsOnComponent>(DependsOn.DeepCopy());
                if (Global != null) dest.Global = new List<GlobalComponent>(Global.DeepCopy());
                if (Definition != null) dest.Definition = (DefinitionComponent)Definition.DeepCopy();
                if (Manifest != null) dest.Manifest = (ManifestComponent)Manifest.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ImplementationGuide());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ImplementationGuide;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if ( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if ( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.Matches(CopyrightElement, otherT.CopyrightElement)) return false;
            if (!DeepComparable.Matches(PackageIdElement, otherT.PackageIdElement)) return false;
            if (!DeepComparable.Matches(LicenseElement, otherT.LicenseElement)) return false;
            if (!DeepComparable.Matches(FhirVersionElement, otherT.FhirVersionElement)) return false;
            if ( !DeepComparable.Matches(DependsOn, otherT.DependsOn)) return false;
            if ( !DeepComparable.Matches(Global, otherT.Global)) return false;
            if (!DeepComparable.Matches(Definition, otherT.Definition)) return false;
            if (!DeepComparable.Matches(Manifest, otherT.Manifest)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ImplementationGuide;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.IsExactly(CopyrightElement, otherT.CopyrightElement)) return false;
            if (!DeepComparable.IsExactly(PackageIdElement, otherT.PackageIdElement)) return false;
            if (!DeepComparable.IsExactly(LicenseElement, otherT.LicenseElement)) return false;
            if (!DeepComparable.IsExactly(FhirVersionElement, otherT.FhirVersionElement)) return false;
            if (!DeepComparable.IsExactly(DependsOn, otherT.DependsOn)) return false;
            if (!DeepComparable.IsExactly(Global, otherT.Global)) return false;
            if (!DeepComparable.IsExactly(Definition, otherT.Definition)) return false;
            if (!DeepComparable.IsExactly(Manifest, otherT.Manifest)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (UrlElement != null) yield return UrlElement;
                if (VersionElement != null) yield return VersionElement;
                if (NameElement != null) yield return NameElement;
                if (TitleElement != null) yield return TitleElement;
                if (StatusElement != null) yield return StatusElement;
                if (ExperimentalElement != null) yield return ExperimentalElement;
                if (DateElement != null) yield return DateElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                if (CopyrightElement != null) yield return CopyrightElement;
                if (PackageIdElement != null) yield return PackageIdElement;
                if (LicenseElement != null) yield return LicenseElement;
                if (FhirVersionElement != null) yield return FhirVersionElement;
                foreach (var elem in DependsOn) { if (elem != null) yield return elem; }
                foreach (var elem in Global) { if (elem != null) yield return elem; }
                if (Definition != null) yield return Definition;
                if (Manifest != null) yield return Manifest;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                if (CopyrightElement != null) yield return new ElementValue("copyright", CopyrightElement);
                if (PackageIdElement != null) yield return new ElementValue("packageId", PackageIdElement);
                if (LicenseElement != null) yield return new ElementValue("license", LicenseElement);
                if (FhirVersionElement != null) yield return new ElementValue("fhirVersion", FhirVersionElement);
                foreach (var elem in DependsOn) { if (elem != null) yield return new ElementValue("dependsOn", elem); }
                foreach (var elem in Global) { if (elem != null) yield return new ElementValue("global", elem); }
                if (Definition != null) yield return new ElementValue("definition", Definition);
                if (Manifest != null) yield return new ElementValue("manifest", Manifest);
            }
        }

    }

}
