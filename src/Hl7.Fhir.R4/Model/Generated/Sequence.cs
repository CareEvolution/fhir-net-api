using System;
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
    /// Information about a biological sequence
    /// </summary>
    [FhirType("Sequence", IsResource=true)]
    [DataContract]
    public partial class Sequence : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Sequence; } }
        [NotMapped]
        public override string TypeName { get { return "Sequence"; } }

        /// <summary>
        /// Type if a sequence -- DNA, RNA, or amino acid sequence.
        /// (url: http://hl7.org/fhir/ValueSet/sequence-type)
        /// </summary>
        [FhirEnumeration("sequenceType")]
        public enum sequenceType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/sequence-type)
            /// </summary>
            [EnumLiteral("aa", "http://hl7.org/fhir/sequence-type"), Description("AA Sequence")]
            Aa,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/sequence-type)
            /// </summary>
            [EnumLiteral("dna", "http://hl7.org/fhir/sequence-type"), Description("DNA Sequence")]
            Dna,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/sequence-type)
            /// </summary>
            [EnumLiteral("rna", "http://hl7.org/fhir/sequence-type"), Description("RNA Sequence")]
            Rna,
        }

        /// <summary>
        /// Type for orientation.
        /// (url: http://hl7.org/fhir/ValueSet/orientation-type)
        /// </summary>
        [FhirEnumeration("orientationType")]
        public enum orientationType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/orientation-type)
            /// </summary>
            [EnumLiteral("sense", "http://hl7.org/fhir/orientation-type"), Description("Sense orientation of referenceSeq")]
            Sense,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/orientation-type)
            /// </summary>
            [EnumLiteral("antisense", "http://hl7.org/fhir/orientation-type"), Description("Antisense orientation of referenceSeq")]
            Antisense,
        }

        /// <summary>
        /// Type for strand.
        /// (url: http://hl7.org/fhir/ValueSet/strand-type)
        /// </summary>
        [FhirEnumeration("strandType")]
        public enum strandType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/strand-type)
            /// </summary>
            [EnumLiteral("watson", "http://hl7.org/fhir/strand-type"), Description("Watson strand of referenceSeq")]
            Watson,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/strand-type)
            /// </summary>
            [EnumLiteral("crick", "http://hl7.org/fhir/strand-type"), Description("Crick strand of referenceSeq")]
            Crick,
        }

        /// <summary>
        /// Type for quality report.
        /// (url: http://hl7.org/fhir/ValueSet/quality-type)
        /// </summary>
        [FhirEnumeration("qualityType")]
        public enum qualityType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/quality-type)
            /// </summary>
            [EnumLiteral("indel", "http://hl7.org/fhir/quality-type"), Description("INDEL Comparison")]
            Indel,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/quality-type)
            /// </summary>
            [EnumLiteral("snp", "http://hl7.org/fhir/quality-type"), Description("SNP Comparison")]
            Snp,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/quality-type)
            /// </summary>
            [EnumLiteral("unknown", "http://hl7.org/fhir/quality-type"), Description("UNKNOWN Comparison")]
            Unknown,
        }

        /// <summary>
        /// Type for access of external URI.
        /// (url: http://hl7.org/fhir/ValueSet/repository-type)
        /// </summary>
        [FhirEnumeration("repositoryType")]
        public enum repositoryType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/repository-type)
            /// </summary>
            [EnumLiteral("directlink", "http://hl7.org/fhir/repository-type"), Description("Click and see")]
            Directlink,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/repository-type)
            /// </summary>
            [EnumLiteral("openapi", "http://hl7.org/fhir/repository-type"), Description("The URL is the RESTful or other kind of API that can access to the result.")]
            Openapi,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/repository-type)
            /// </summary>
            [EnumLiteral("login", "http://hl7.org/fhir/repository-type"), Description("Result cannot be access unless an account is logged in")]
            Login,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/repository-type)
            /// </summary>
            [EnumLiteral("oauth", "http://hl7.org/fhir/repository-type"), Description("Result need to be fetched with API and need LOGIN( or cookies are required when visiting the link of resource)")]
            Oauth,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/repository-type)
            /// </summary>
            [EnumLiteral("other", "http://hl7.org/fhir/repository-type"), Description("Some other complicated or particular way to get resource from URL.")]
            Other,
        }


        [FhirType("ReferenceSeqComponent")]
        [DataContract]
        public partial class ReferenceSeqComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ReferenceSeqComponent"; } }

            /// <summary>
            /// Chromosome containing genetic finding
            /// </summary>
            [FhirElement("chromosome", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept Chromosome
            {
                get { return _chromosome; }
                set { _chromosome = value; OnPropertyChanged("Chromosome"); }
            }

            private CodeableConcept _chromosome;

            /// <summary>
            /// The Genome Build used for reference, following GRCh build versions e.g. 'GRCh 37'
            /// </summary>
            [FhirElement("genomeBuild", InSummary=true, Order=50)]
            [DataMember]
            public FhirString GenomeBuildElement
            {
                get { return _genomeBuildElement; }
                set { _genomeBuildElement = value; OnPropertyChanged("GenomeBuildElement"); }
            }

            private FhirString _genomeBuildElement;

            /// <summary>
            /// The Genome Build used for reference, following GRCh build versions e.g. 'GRCh 37'
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string GenomeBuild
            {
                get { return GenomeBuildElement != null ? GenomeBuildElement.Value : null; }
                set
                {
                    if (value == null)
                        GenomeBuildElement = null;
                    else
                        GenomeBuildElement = new FhirString(value);
                    OnPropertyChanged("GenomeBuild");
                }
            }

            /// <summary>
            /// sense | antisense
            /// </summary>
            [FhirElement("orientation", InSummary=true, Order=60)]
            [DataMember]
            public Code<orientationType> OrientationElement
            {
                get { return _orientationElement; }
                set { _orientationElement = value; OnPropertyChanged("OrientationElement"); }
            }

            private Code<orientationType> _orientationElement;

            /// <summary>
            /// sense | antisense
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public orientationType? Orientation
            {
                get { return OrientationElement != null ? OrientationElement.Value : null; }
                set
                {
                    if (value == null)
                        OrientationElement = null;
                    else
                        OrientationElement = new Code<orientationType>(value);
                    OnPropertyChanged("Orientation");
                }
            }

            /// <summary>
            /// Reference identifier
            /// </summary>
            [FhirElement("referenceSeqId", InSummary=true, Order=70)]
            [DataMember]
            public CodeableConcept ReferenceSeqId
            {
                get { return _referenceSeqId; }
                set { _referenceSeqId = value; OnPropertyChanged("ReferenceSeqId"); }
            }

            private CodeableConcept _referenceSeqId;

            /// <summary>
            /// A Pointer to another Sequence entity as reference sequence
            /// </summary>
            [FhirElement("referenceSeqPointer", InSummary=true, Order=80)]
            [References("Sequence")]
            [DataMember]
            public ResourceReference ReferenceSeqPointer
            {
                get { return _referenceSeqPointer; }
                set { _referenceSeqPointer = value; OnPropertyChanged("ReferenceSeqPointer"); }
            }

            private ResourceReference _referenceSeqPointer;

            /// <summary>
            /// A string to represent reference sequence
            /// </summary>
            [FhirElement("referenceSeqString", InSummary=true, Order=90)]
            [DataMember]
            public FhirString ReferenceSeqStringElement
            {
                get { return _referenceSeqStringElement; }
                set { _referenceSeqStringElement = value; OnPropertyChanged("ReferenceSeqStringElement"); }
            }

            private FhirString _referenceSeqStringElement;

            /// <summary>
            /// A string to represent reference sequence
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ReferenceSeqString
            {
                get { return ReferenceSeqStringElement != null ? ReferenceSeqStringElement.Value : null; }
                set
                {
                    if (value == null)
                        ReferenceSeqStringElement = null;
                    else
                        ReferenceSeqStringElement = new FhirString(value);
                    OnPropertyChanged("ReferenceSeqString");
                }
            }

            /// <summary>
            /// watson | crick
            /// </summary>
            [FhirElement("strand", InSummary=true, Order=100)]
            [DataMember]
            public Code<strandType> StrandElement
            {
                get { return _strandElement; }
                set { _strandElement = value; OnPropertyChanged("StrandElement"); }
            }

            private Code<strandType> _strandElement;

            /// <summary>
            /// watson | crick
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public strandType? Strand
            {
                get { return StrandElement != null ? StrandElement.Value : null; }
                set
                {
                    if (value == null)
                        StrandElement = null;
                    else
                        StrandElement = new Code<strandType>(value);
                    OnPropertyChanged("Strand");
                }
            }

            /// <summary>
            /// Start position of the window on the  reference sequence
            /// </summary>
            [FhirElement("windowStart", InSummary=true, Order=110)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Integer WindowStartElement
            {
                get { return _windowStartElement; }
                set { _windowStartElement = value; OnPropertyChanged("WindowStartElement"); }
            }

            private Integer _windowStartElement;

            /// <summary>
            /// Start position of the window on the  reference sequence
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? WindowStart
            {
                get { return WindowStartElement != null ? WindowStartElement.Value : null; }
                set
                {
                    if (value == null)
                        WindowStartElement = null;
                    else
                        WindowStartElement = new Integer(value);
                    OnPropertyChanged("WindowStart");
                }
            }

            /// <summary>
            /// End position of the window on the reference sequence
            /// </summary>
            [FhirElement("windowEnd", InSummary=true, Order=120)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Integer WindowEndElement
            {
                get { return _windowEndElement; }
                set { _windowEndElement = value; OnPropertyChanged("WindowEndElement"); }
            }

            private Integer _windowEndElement;

            /// <summary>
            /// End position of the window on the reference sequence
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? WindowEnd
            {
                get { return WindowEndElement != null ? WindowEndElement.Value : null; }
                set
                {
                    if (value == null)
                        WindowEndElement = null;
                    else
                        WindowEndElement = new Integer(value);
                    OnPropertyChanged("WindowEnd");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ReferenceSeqComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Chromosome != null) dest.Chromosome = (CodeableConcept)Chromosome.DeepCopy();
                    if (GenomeBuildElement != null) dest.GenomeBuildElement = (FhirString)GenomeBuildElement.DeepCopy();
                    if (OrientationElement != null) dest.OrientationElement = (Code<orientationType>)OrientationElement.DeepCopy();
                    if (ReferenceSeqId != null) dest.ReferenceSeqId = (CodeableConcept)ReferenceSeqId.DeepCopy();
                    if (ReferenceSeqPointer != null) dest.ReferenceSeqPointer = (ResourceReference)ReferenceSeqPointer.DeepCopy();
                    if (ReferenceSeqStringElement != null) dest.ReferenceSeqStringElement = (FhirString)ReferenceSeqStringElement.DeepCopy();
                    if (StrandElement != null) dest.StrandElement = (Code<strandType>)StrandElement.DeepCopy();
                    if (WindowStartElement != null) dest.WindowStartElement = (Integer)WindowStartElement.DeepCopy();
                    if (WindowEndElement != null) dest.WindowEndElement = (Integer)WindowEndElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ReferenceSeqComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ReferenceSeqComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Chromosome, otherT.Chromosome)) return false;
                if (!DeepComparable.Matches(GenomeBuildElement, otherT.GenomeBuildElement)) return false;
                if (!DeepComparable.Matches(OrientationElement, otherT.OrientationElement)) return false;
                if (!DeepComparable.Matches(ReferenceSeqId, otherT.ReferenceSeqId)) return false;
                if (!DeepComparable.Matches(ReferenceSeqPointer, otherT.ReferenceSeqPointer)) return false;
                if (!DeepComparable.Matches(ReferenceSeqStringElement, otherT.ReferenceSeqStringElement)) return false;
                if (!DeepComparable.Matches(StrandElement, otherT.StrandElement)) return false;
                if (!DeepComparable.Matches(WindowStartElement, otherT.WindowStartElement)) return false;
                if (!DeepComparable.Matches(WindowEndElement, otherT.WindowEndElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ReferenceSeqComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Chromosome, otherT.Chromosome)) return false;
                if (!DeepComparable.IsExactly(GenomeBuildElement, otherT.GenomeBuildElement)) return false;
                if (!DeepComparable.IsExactly(OrientationElement, otherT.OrientationElement)) return false;
                if (!DeepComparable.IsExactly(ReferenceSeqId, otherT.ReferenceSeqId)) return false;
                if (!DeepComparable.IsExactly(ReferenceSeqPointer, otherT.ReferenceSeqPointer)) return false;
                if (!DeepComparable.IsExactly(ReferenceSeqStringElement, otherT.ReferenceSeqStringElement)) return false;
                if (!DeepComparable.IsExactly(StrandElement, otherT.StrandElement)) return false;
                if (!DeepComparable.IsExactly(WindowStartElement, otherT.WindowStartElement)) return false;
                if (!DeepComparable.IsExactly(WindowEndElement, otherT.WindowEndElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Chromosome != null) yield return Chromosome;
                    if (GenomeBuildElement != null) yield return GenomeBuildElement;
                    if (OrientationElement != null) yield return OrientationElement;
                    if (ReferenceSeqId != null) yield return ReferenceSeqId;
                    if (ReferenceSeqPointer != null) yield return ReferenceSeqPointer;
                    if (ReferenceSeqStringElement != null) yield return ReferenceSeqStringElement;
                    if (StrandElement != null) yield return StrandElement;
                    if (WindowStartElement != null) yield return WindowStartElement;
                    if (WindowEndElement != null) yield return WindowEndElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Chromosome != null) yield return new ElementValue("chromosome", Chromosome);
                    if (GenomeBuildElement != null) yield return new ElementValue("genomeBuild", GenomeBuildElement);
                    if (OrientationElement != null) yield return new ElementValue("orientation", OrientationElement);
                    if (ReferenceSeqId != null) yield return new ElementValue("referenceSeqId", ReferenceSeqId);
                    if (ReferenceSeqPointer != null) yield return new ElementValue("referenceSeqPointer", ReferenceSeqPointer);
                    if (ReferenceSeqStringElement != null) yield return new ElementValue("referenceSeqString", ReferenceSeqStringElement);
                    if (StrandElement != null) yield return new ElementValue("strand", StrandElement);
                    if (WindowStartElement != null) yield return new ElementValue("windowStart", WindowStartElement);
                    if (WindowEndElement != null) yield return new ElementValue("windowEnd", WindowEndElement);
                }
            }


        }


        [FhirType("VariantComponent")]
        [DataContract]
        public partial class VariantComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "VariantComponent"; } }

            /// <summary>
            /// Start position of the variant on the  reference sequence
            /// </summary>
            [FhirElement("start", InSummary=true, Order=40)]
            [DataMember]
            public Integer StartElement
            {
                get { return _startElement; }
                set { _startElement = value; OnPropertyChanged("StartElement"); }
            }

            private Integer _startElement;

            /// <summary>
            /// Start position of the variant on the  reference sequence
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Start
            {
                get { return StartElement != null ? StartElement.Value : null; }
                set
                {
                    if (value == null)
                        StartElement = null;
                    else
                        StartElement = new Integer(value);
                    OnPropertyChanged("Start");
                }
            }

            /// <summary>
            /// End position of the variant on the reference sequence
            /// </summary>
            [FhirElement("end", InSummary=true, Order=50)]
            [DataMember]
            public Integer EndElement
            {
                get { return _endElement; }
                set { _endElement = value; OnPropertyChanged("EndElement"); }
            }

            private Integer _endElement;

            /// <summary>
            /// End position of the variant on the reference sequence
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? End
            {
                get { return EndElement != null ? EndElement.Value : null; }
                set
                {
                    if (value == null)
                        EndElement = null;
                    else
                        EndElement = new Integer(value);
                    OnPropertyChanged("End");
                }
            }

            /// <summary>
            /// Allele that was observed
            /// </summary>
            [FhirElement("observedAllele", InSummary=true, Order=60)]
            [DataMember]
            public FhirString ObservedAlleleElement
            {
                get { return _observedAlleleElement; }
                set { _observedAlleleElement = value; OnPropertyChanged("ObservedAlleleElement"); }
            }

            private FhirString _observedAlleleElement;

            /// <summary>
            /// Allele that was observed
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ObservedAllele
            {
                get { return ObservedAlleleElement != null ? ObservedAlleleElement.Value : null; }
                set
                {
                    if (value == null)
                        ObservedAlleleElement = null;
                    else
                        ObservedAlleleElement = new FhirString(value);
                    OnPropertyChanged("ObservedAllele");
                }
            }

            /// <summary>
            /// Allele in the reference sequence
            /// </summary>
            [FhirElement("referenceAllele", InSummary=true, Order=70)]
            [DataMember]
            public FhirString ReferenceAlleleElement
            {
                get { return _referenceAlleleElement; }
                set { _referenceAlleleElement = value; OnPropertyChanged("ReferenceAlleleElement"); }
            }

            private FhirString _referenceAlleleElement;

            /// <summary>
            /// Allele in the reference sequence
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ReferenceAllele
            {
                get { return ReferenceAlleleElement != null ? ReferenceAlleleElement.Value : null; }
                set
                {
                    if (value == null)
                        ReferenceAlleleElement = null;
                    else
                        ReferenceAlleleElement = new FhirString(value);
                    OnPropertyChanged("ReferenceAllele");
                }
            }

            /// <summary>
            /// Extended CIGAR string for aligning the sequence with reference bases
            /// </summary>
            [FhirElement("cigar", InSummary=true, Order=80)]
            [DataMember]
            public FhirString CigarElement
            {
                get { return _cigarElement; }
                set { _cigarElement = value; OnPropertyChanged("CigarElement"); }
            }

            private FhirString _cigarElement;

            /// <summary>
            /// Extended CIGAR string for aligning the sequence with reference bases
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Cigar
            {
                get { return CigarElement != null ? CigarElement.Value : null; }
                set
                {
                    if (value == null)
                        CigarElement = null;
                    else
                        CigarElement = new FhirString(value);
                    OnPropertyChanged("Cigar");
                }
            }

            /// <summary>
            /// Pointer to observed variant information
            /// </summary>
            [FhirElement("variantPointer", InSummary=true, Order=90)]
            [References("Observation")]
            [DataMember]
            public ResourceReference VariantPointer
            {
                get { return _variantPointer; }
                set { _variantPointer = value; OnPropertyChanged("VariantPointer"); }
            }

            private ResourceReference _variantPointer;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as VariantComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (StartElement != null) dest.StartElement = (Integer)StartElement.DeepCopy();
                    if (EndElement != null) dest.EndElement = (Integer)EndElement.DeepCopy();
                    if (ObservedAlleleElement != null) dest.ObservedAlleleElement = (FhirString)ObservedAlleleElement.DeepCopy();
                    if (ReferenceAlleleElement != null) dest.ReferenceAlleleElement = (FhirString)ReferenceAlleleElement.DeepCopy();
                    if (CigarElement != null) dest.CigarElement = (FhirString)CigarElement.DeepCopy();
                    if (VariantPointer != null) dest.VariantPointer = (ResourceReference)VariantPointer.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new VariantComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as VariantComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(StartElement, otherT.StartElement)) return false;
                if (!DeepComparable.Matches(EndElement, otherT.EndElement)) return false;
                if (!DeepComparable.Matches(ObservedAlleleElement, otherT.ObservedAlleleElement)) return false;
                if (!DeepComparable.Matches(ReferenceAlleleElement, otherT.ReferenceAlleleElement)) return false;
                if (!DeepComparable.Matches(CigarElement, otherT.CigarElement)) return false;
                if (!DeepComparable.Matches(VariantPointer, otherT.VariantPointer)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as VariantComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(StartElement, otherT.StartElement)) return false;
                if (!DeepComparable.IsExactly(EndElement, otherT.EndElement)) return false;
                if (!DeepComparable.IsExactly(ObservedAlleleElement, otherT.ObservedAlleleElement)) return false;
                if (!DeepComparable.IsExactly(ReferenceAlleleElement, otherT.ReferenceAlleleElement)) return false;
                if (!DeepComparable.IsExactly(CigarElement, otherT.CigarElement)) return false;
                if (!DeepComparable.IsExactly(VariantPointer, otherT.VariantPointer)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (StartElement != null) yield return StartElement;
                    if (EndElement != null) yield return EndElement;
                    if (ObservedAlleleElement != null) yield return ObservedAlleleElement;
                    if (ReferenceAlleleElement != null) yield return ReferenceAlleleElement;
                    if (CigarElement != null) yield return CigarElement;
                    if (VariantPointer != null) yield return VariantPointer;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (StartElement != null) yield return new ElementValue("start", StartElement);
                    if (EndElement != null) yield return new ElementValue("end", EndElement);
                    if (ObservedAlleleElement != null) yield return new ElementValue("observedAllele", ObservedAlleleElement);
                    if (ReferenceAlleleElement != null) yield return new ElementValue("referenceAllele", ReferenceAlleleElement);
                    if (CigarElement != null) yield return new ElementValue("cigar", CigarElement);
                    if (VariantPointer != null) yield return new ElementValue("variantPointer", VariantPointer);
                }
            }


        }


        [FhirType("QualityComponent")]
        [DataContract]
        public partial class QualityComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "QualityComponent"; } }

            /// <summary>
            /// indel | snp | unknown
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<qualityType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<qualityType> _typeElement;

            /// <summary>
            /// indel | snp | unknown
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public qualityType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<qualityType>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// Standard sequence for comparison
            /// </summary>
            [FhirElement("standardSequence", InSummary=true, Order=50)]
            [DataMember]
            public CodeableConcept StandardSequence
            {
                get { return _standardSequence; }
                set { _standardSequence = value; OnPropertyChanged("StandardSequence"); }
            }

            private CodeableConcept _standardSequence;

            /// <summary>
            /// Start position of the sequence
            /// </summary>
            [FhirElement("start", InSummary=true, Order=60)]
            [DataMember]
            public Integer StartElement
            {
                get { return _startElement; }
                set { _startElement = value; OnPropertyChanged("StartElement"); }
            }

            private Integer _startElement;

            /// <summary>
            /// Start position of the sequence
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Start
            {
                get { return StartElement != null ? StartElement.Value : null; }
                set
                {
                    if (value == null)
                        StartElement = null;
                    else
                        StartElement = new Integer(value);
                    OnPropertyChanged("Start");
                }
            }

            /// <summary>
            /// End position of the sequence
            /// </summary>
            [FhirElement("end", InSummary=true, Order=70)]
            [DataMember]
            public Integer EndElement
            {
                get { return _endElement; }
                set { _endElement = value; OnPropertyChanged("EndElement"); }
            }

            private Integer _endElement;

            /// <summary>
            /// End position of the sequence
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? End
            {
                get { return EndElement != null ? EndElement.Value : null; }
                set
                {
                    if (value == null)
                        EndElement = null;
                    else
                        EndElement = new Integer(value);
                    OnPropertyChanged("End");
                }
            }

            /// <summary>
            /// Quality score for the comparison
            /// </summary>
            [FhirElement("score", InSummary=true, Order=80)]
            [DataMember]
            public Quantity Score
            {
                get { return _score; }
                set { _score = value; OnPropertyChanged("Score"); }
            }

            private Quantity _score;

            /// <summary>
            /// Method to get quality
            /// </summary>
            [FhirElement("method", InSummary=true, Order=90)]
            [DataMember]
            public CodeableConcept Method
            {
                get { return _method; }
                set { _method = value; OnPropertyChanged("Method"); }
            }

            private CodeableConcept _method;

            /// <summary>
            /// True positives from the perspective of the truth data
            /// </summary>
            [FhirElement("truthTP", InSummary=true, Order=100)]
            [DataMember]
            public FhirDecimal TruthTPElement
            {
                get { return _truthTPElement; }
                set { _truthTPElement = value; OnPropertyChanged("TruthTPElement"); }
            }

            private FhirDecimal _truthTPElement;

            /// <summary>
            /// True positives from the perspective of the truth data
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? TruthTP
            {
                get { return TruthTPElement != null ? TruthTPElement.Value : null; }
                set
                {
                    if (value == null)
                        TruthTPElement = null;
                    else
                        TruthTPElement = new FhirDecimal(value);
                    OnPropertyChanged("TruthTP");
                }
            }

            /// <summary>
            /// True positives from the perspective of the query data
            /// </summary>
            [FhirElement("queryTP", InSummary=true, Order=110)]
            [DataMember]
            public FhirDecimal QueryTPElement
            {
                get { return _queryTPElement; }
                set { _queryTPElement = value; OnPropertyChanged("QueryTPElement"); }
            }

            private FhirDecimal _queryTPElement;

            /// <summary>
            /// True positives from the perspective of the query data
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? QueryTP
            {
                get { return QueryTPElement != null ? QueryTPElement.Value : null; }
                set
                {
                    if (value == null)
                        QueryTPElement = null;
                    else
                        QueryTPElement = new FhirDecimal(value);
                    OnPropertyChanged("QueryTP");
                }
            }

            /// <summary>
            /// False negatives
            /// </summary>
            [FhirElement("truthFN", InSummary=true, Order=120)]
            [DataMember]
            public FhirDecimal TruthFNElement
            {
                get { return _truthFNElement; }
                set { _truthFNElement = value; OnPropertyChanged("TruthFNElement"); }
            }

            private FhirDecimal _truthFNElement;

            /// <summary>
            /// False negatives
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? TruthFN
            {
                get { return TruthFNElement != null ? TruthFNElement.Value : null; }
                set
                {
                    if (value == null)
                        TruthFNElement = null;
                    else
                        TruthFNElement = new FhirDecimal(value);
                    OnPropertyChanged("TruthFN");
                }
            }

            /// <summary>
            /// False positives
            /// </summary>
            [FhirElement("queryFP", InSummary=true, Order=130)]
            [DataMember]
            public FhirDecimal QueryFPElement
            {
                get { return _queryFPElement; }
                set { _queryFPElement = value; OnPropertyChanged("QueryFPElement"); }
            }

            private FhirDecimal _queryFPElement;

            /// <summary>
            /// False positives
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? QueryFP
            {
                get { return QueryFPElement != null ? QueryFPElement.Value : null; }
                set
                {
                    if (value == null)
                        QueryFPElement = null;
                    else
                        QueryFPElement = new FhirDecimal(value);
                    OnPropertyChanged("QueryFP");
                }
            }

            /// <summary>
            /// False positives where the non-REF alleles in the Truth and Query Call Sets match
            /// </summary>
            [FhirElement("gtFP", InSummary=true, Order=140)]
            [DataMember]
            public FhirDecimal GtFPElement
            {
                get { return _gtFPElement; }
                set { _gtFPElement = value; OnPropertyChanged("GtFPElement"); }
            }

            private FhirDecimal _gtFPElement;

            /// <summary>
            /// False positives where the non-REF alleles in the Truth and Query Call Sets match
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? GtFP
            {
                get { return GtFPElement != null ? GtFPElement.Value : null; }
                set
                {
                    if (value == null)
                        GtFPElement = null;
                    else
                        GtFPElement = new FhirDecimal(value);
                    OnPropertyChanged("GtFP");
                }
            }

            /// <summary>
            /// Precision of comparison
            /// </summary>
            [FhirElement("precision", InSummary=true, Order=150)]
            [DataMember]
            public FhirDecimal PrecisionElement
            {
                get { return _precisionElement; }
                set { _precisionElement = value; OnPropertyChanged("PrecisionElement"); }
            }

            private FhirDecimal _precisionElement;

            /// <summary>
            /// Precision of comparison
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Precision
            {
                get { return PrecisionElement != null ? PrecisionElement.Value : null; }
                set
                {
                    if (value == null)
                        PrecisionElement = null;
                    else
                        PrecisionElement = new FhirDecimal(value);
                    OnPropertyChanged("Precision");
                }
            }

            /// <summary>
            /// Recall of comparison
            /// </summary>
            [FhirElement("recall", InSummary=true, Order=160)]
            [DataMember]
            public FhirDecimal RecallElement
            {
                get { return _recallElement; }
                set { _recallElement = value; OnPropertyChanged("RecallElement"); }
            }

            private FhirDecimal _recallElement;

            /// <summary>
            /// Recall of comparison
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Recall
            {
                get { return RecallElement != null ? RecallElement.Value : null; }
                set
                {
                    if (value == null)
                        RecallElement = null;
                    else
                        RecallElement = new FhirDecimal(value);
                    OnPropertyChanged("Recall");
                }
            }

            /// <summary>
            /// F-score
            /// </summary>
            [FhirElement("fScore", InSummary=true, Order=170)]
            [DataMember]
            public FhirDecimal FScoreElement
            {
                get { return _fScoreElement; }
                set { _fScoreElement = value; OnPropertyChanged("FScoreElement"); }
            }

            private FhirDecimal _fScoreElement;

            /// <summary>
            /// F-score
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? FScore
            {
                get { return FScoreElement != null ? FScoreElement.Value : null; }
                set
                {
                    if (value == null)
                        FScoreElement = null;
                    else
                        FScoreElement = new FhirDecimal(value);
                    OnPropertyChanged("FScore");
                }
            }

            /// <summary>
            /// Receiver Operator Characteristic (ROC) Curve
            /// </summary>
            [FhirElement("roc", InSummary=true, Order=180)]
            [DataMember]
            public RocComponent Roc
            {
                get { return _roc; }
                set { _roc = value; OnPropertyChanged("Roc"); }
            }

            private RocComponent _roc;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as QualityComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TypeElement != null) dest.TypeElement = (Code<qualityType>)TypeElement.DeepCopy();
                    if (StandardSequence != null) dest.StandardSequence = (CodeableConcept)StandardSequence.DeepCopy();
                    if (StartElement != null) dest.StartElement = (Integer)StartElement.DeepCopy();
                    if (EndElement != null) dest.EndElement = (Integer)EndElement.DeepCopy();
                    if (Score != null) dest.Score = (Quantity)Score.DeepCopy();
                    if (Method != null) dest.Method = (CodeableConcept)Method.DeepCopy();
                    if (TruthTPElement != null) dest.TruthTPElement = (FhirDecimal)TruthTPElement.DeepCopy();
                    if (QueryTPElement != null) dest.QueryTPElement = (FhirDecimal)QueryTPElement.DeepCopy();
                    if (TruthFNElement != null) dest.TruthFNElement = (FhirDecimal)TruthFNElement.DeepCopy();
                    if (QueryFPElement != null) dest.QueryFPElement = (FhirDecimal)QueryFPElement.DeepCopy();
                    if (GtFPElement != null) dest.GtFPElement = (FhirDecimal)GtFPElement.DeepCopy();
                    if (PrecisionElement != null) dest.PrecisionElement = (FhirDecimal)PrecisionElement.DeepCopy();
                    if (RecallElement != null) dest.RecallElement = (FhirDecimal)RecallElement.DeepCopy();
                    if (FScoreElement != null) dest.FScoreElement = (FhirDecimal)FScoreElement.DeepCopy();
                    if (Roc != null) dest.Roc = (RocComponent)Roc.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new QualityComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as QualityComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(StandardSequence, otherT.StandardSequence)) return false;
                if (!DeepComparable.Matches(StartElement, otherT.StartElement)) return false;
                if (!DeepComparable.Matches(EndElement, otherT.EndElement)) return false;
                if (!DeepComparable.Matches(Score, otherT.Score)) return false;
                if (!DeepComparable.Matches(Method, otherT.Method)) return false;
                if (!DeepComparable.Matches(TruthTPElement, otherT.TruthTPElement)) return false;
                if (!DeepComparable.Matches(QueryTPElement, otherT.QueryTPElement)) return false;
                if (!DeepComparable.Matches(TruthFNElement, otherT.TruthFNElement)) return false;
                if (!DeepComparable.Matches(QueryFPElement, otherT.QueryFPElement)) return false;
                if (!DeepComparable.Matches(GtFPElement, otherT.GtFPElement)) return false;
                if (!DeepComparable.Matches(PrecisionElement, otherT.PrecisionElement)) return false;
                if (!DeepComparable.Matches(RecallElement, otherT.RecallElement)) return false;
                if (!DeepComparable.Matches(FScoreElement, otherT.FScoreElement)) return false;
                if (!DeepComparable.Matches(Roc, otherT.Roc)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as QualityComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(StandardSequence, otherT.StandardSequence)) return false;
                if (!DeepComparable.IsExactly(StartElement, otherT.StartElement)) return false;
                if (!DeepComparable.IsExactly(EndElement, otherT.EndElement)) return false;
                if (!DeepComparable.IsExactly(Score, otherT.Score)) return false;
                if (!DeepComparable.IsExactly(Method, otherT.Method)) return false;
                if (!DeepComparable.IsExactly(TruthTPElement, otherT.TruthTPElement)) return false;
                if (!DeepComparable.IsExactly(QueryTPElement, otherT.QueryTPElement)) return false;
                if (!DeepComparable.IsExactly(TruthFNElement, otherT.TruthFNElement)) return false;
                if (!DeepComparable.IsExactly(QueryFPElement, otherT.QueryFPElement)) return false;
                if (!DeepComparable.IsExactly(GtFPElement, otherT.GtFPElement)) return false;
                if (!DeepComparable.IsExactly(PrecisionElement, otherT.PrecisionElement)) return false;
                if (!DeepComparable.IsExactly(RecallElement, otherT.RecallElement)) return false;
                if (!DeepComparable.IsExactly(FScoreElement, otherT.FScoreElement)) return false;
                if (!DeepComparable.IsExactly(Roc, otherT.Roc)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (StandardSequence != null) yield return StandardSequence;
                    if (StartElement != null) yield return StartElement;
                    if (EndElement != null) yield return EndElement;
                    if (Score != null) yield return Score;
                    if (Method != null) yield return Method;
                    if (TruthTPElement != null) yield return TruthTPElement;
                    if (QueryTPElement != null) yield return QueryTPElement;
                    if (TruthFNElement != null) yield return TruthFNElement;
                    if (QueryFPElement != null) yield return QueryFPElement;
                    if (GtFPElement != null) yield return GtFPElement;
                    if (PrecisionElement != null) yield return PrecisionElement;
                    if (RecallElement != null) yield return RecallElement;
                    if (FScoreElement != null) yield return FScoreElement;
                    if (Roc != null) yield return Roc;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (StandardSequence != null) yield return new ElementValue("standardSequence", StandardSequence);
                    if (StartElement != null) yield return new ElementValue("start", StartElement);
                    if (EndElement != null) yield return new ElementValue("end", EndElement);
                    if (Score != null) yield return new ElementValue("score", Score);
                    if (Method != null) yield return new ElementValue("method", Method);
                    if (TruthTPElement != null) yield return new ElementValue("truthTP", TruthTPElement);
                    if (QueryTPElement != null) yield return new ElementValue("queryTP", QueryTPElement);
                    if (TruthFNElement != null) yield return new ElementValue("truthFN", TruthFNElement);
                    if (QueryFPElement != null) yield return new ElementValue("queryFP", QueryFPElement);
                    if (GtFPElement != null) yield return new ElementValue("gtFP", GtFPElement);
                    if (PrecisionElement != null) yield return new ElementValue("precision", PrecisionElement);
                    if (RecallElement != null) yield return new ElementValue("recall", RecallElement);
                    if (FScoreElement != null) yield return new ElementValue("fScore", FScoreElement);
                    if (Roc != null) yield return new ElementValue("roc", Roc);
                }
            }


        }


        [FhirType("RocComponent")]
        [DataContract]
        public partial class RocComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RocComponent"; } }

            /// <summary>
            /// Genotype quality score
            /// </summary>
            [FhirElement("score", InSummary=true, Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Integer> ScoreElement
            {
                get { if (_scoreElement==null) _scoreElement = new List<Integer>(); return _scoreElement; }
                set { _scoreElement = value; OnPropertyChanged("ScoreElement"); }
            }

            private List<Integer> _scoreElement;

            /// <summary>
            /// Genotype quality score
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> Score
            {
                get { return ScoreElement != null ? ScoreElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ScoreElement = null;
                    else
                        ScoreElement = new List<Integer>(value.Select(elem=>new Integer(elem)));
                    OnPropertyChanged("Score");
                }
            }

            /// <summary>
            /// Roc score true positive numbers
            /// </summary>
            [FhirElement("numTP", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Integer> NumTPElement
            {
                get { if (_numTPElement==null) _numTPElement = new List<Integer>(); return _numTPElement; }
                set { _numTPElement = value; OnPropertyChanged("NumTPElement"); }
            }

            private List<Integer> _numTPElement;

            /// <summary>
            /// Roc score true positive numbers
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> NumTP
            {
                get { return NumTPElement != null ? NumTPElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        NumTPElement = null;
                    else
                        NumTPElement = new List<Integer>(value.Select(elem=>new Integer(elem)));
                    OnPropertyChanged("NumTP");
                }
            }

            /// <summary>
            /// Roc score false positive numbers
            /// </summary>
            [FhirElement("numFP", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Integer> NumFPElement
            {
                get { if (_numFPElement==null) _numFPElement = new List<Integer>(); return _numFPElement; }
                set { _numFPElement = value; OnPropertyChanged("NumFPElement"); }
            }

            private List<Integer> _numFPElement;

            /// <summary>
            /// Roc score false positive numbers
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> NumFP
            {
                get { return NumFPElement != null ? NumFPElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        NumFPElement = null;
                    else
                        NumFPElement = new List<Integer>(value.Select(elem=>new Integer(elem)));
                    OnPropertyChanged("NumFP");
                }
            }

            /// <summary>
            /// Roc score false negative numbers
            /// </summary>
            [FhirElement("numFN", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Integer> NumFNElement
            {
                get { if (_numFNElement==null) _numFNElement = new List<Integer>(); return _numFNElement; }
                set { _numFNElement = value; OnPropertyChanged("NumFNElement"); }
            }

            private List<Integer> _numFNElement;

            /// <summary>
            /// Roc score false negative numbers
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> NumFN
            {
                get { return NumFNElement != null ? NumFNElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        NumFNElement = null;
                    else
                        NumFNElement = new List<Integer>(value.Select(elem=>new Integer(elem)));
                    OnPropertyChanged("NumFN");
                }
            }

            /// <summary>
            /// Precision of the GQ score
            /// </summary>
            [FhirElement("precision", InSummary=true, Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirDecimal> PrecisionElement
            {
                get { if (_precisionElement==null) _precisionElement = new List<FhirDecimal>(); return _precisionElement; }
                set { _precisionElement = value; OnPropertyChanged("PrecisionElement"); }
            }

            private List<FhirDecimal> _precisionElement;

            /// <summary>
            /// Precision of the GQ score
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<decimal?> Precision
            {
                get { return PrecisionElement != null ? PrecisionElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        PrecisionElement = null;
                    else
                        PrecisionElement = new List<FhirDecimal>(value.Select(elem=>new FhirDecimal(elem)));
                    OnPropertyChanged("Precision");
                }
            }

            /// <summary>
            /// Sensitivity of the GQ score
            /// </summary>
            [FhirElement("sensitivity", InSummary=true, Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirDecimal> SensitivityElement
            {
                get { if (_sensitivityElement==null) _sensitivityElement = new List<FhirDecimal>(); return _sensitivityElement; }
                set { _sensitivityElement = value; OnPropertyChanged("SensitivityElement"); }
            }

            private List<FhirDecimal> _sensitivityElement;

            /// <summary>
            /// Sensitivity of the GQ score
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<decimal?> Sensitivity
            {
                get { return SensitivityElement != null ? SensitivityElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        SensitivityElement = null;
                    else
                        SensitivityElement = new List<FhirDecimal>(value.Select(elem=>new FhirDecimal(elem)));
                    OnPropertyChanged("Sensitivity");
                }
            }

            /// <summary>
            /// FScore of the GQ score
            /// </summary>
            [FhirElement("fMeasure", InSummary=true, Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirDecimal> FMeasureElement
            {
                get { if (_fMeasureElement==null) _fMeasureElement = new List<FhirDecimal>(); return _fMeasureElement; }
                set { _fMeasureElement = value; OnPropertyChanged("FMeasureElement"); }
            }

            private List<FhirDecimal> _fMeasureElement;

            /// <summary>
            /// FScore of the GQ score
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<decimal?> FMeasure
            {
                get { return FMeasureElement != null ? FMeasureElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        FMeasureElement = null;
                    else
                        FMeasureElement = new List<FhirDecimal>(value.Select(elem=>new FhirDecimal(elem)));
                    OnPropertyChanged("FMeasure");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RocComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ScoreElement != null) dest.ScoreElement = new List<Integer>(ScoreElement.DeepCopy());
                    if (NumTPElement != null) dest.NumTPElement = new List<Integer>(NumTPElement.DeepCopy());
                    if (NumFPElement != null) dest.NumFPElement = new List<Integer>(NumFPElement.DeepCopy());
                    if (NumFNElement != null) dest.NumFNElement = new List<Integer>(NumFNElement.DeepCopy());
                    if (PrecisionElement != null) dest.PrecisionElement = new List<FhirDecimal>(PrecisionElement.DeepCopy());
                    if (SensitivityElement != null) dest.SensitivityElement = new List<FhirDecimal>(SensitivityElement.DeepCopy());
                    if (FMeasureElement != null) dest.FMeasureElement = new List<FhirDecimal>(FMeasureElement.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RocComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RocComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(ScoreElement, otherT.ScoreElement)) return false;
                if ( !DeepComparable.Matches(NumTPElement, otherT.NumTPElement)) return false;
                if ( !DeepComparable.Matches(NumFPElement, otherT.NumFPElement)) return false;
                if ( !DeepComparable.Matches(NumFNElement, otherT.NumFNElement)) return false;
                if ( !DeepComparable.Matches(PrecisionElement, otherT.PrecisionElement)) return false;
                if ( !DeepComparable.Matches(SensitivityElement, otherT.SensitivityElement)) return false;
                if ( !DeepComparable.Matches(FMeasureElement, otherT.FMeasureElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RocComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ScoreElement, otherT.ScoreElement)) return false;
                if (!DeepComparable.IsExactly(NumTPElement, otherT.NumTPElement)) return false;
                if (!DeepComparable.IsExactly(NumFPElement, otherT.NumFPElement)) return false;
                if (!DeepComparable.IsExactly(NumFNElement, otherT.NumFNElement)) return false;
                if (!DeepComparable.IsExactly(PrecisionElement, otherT.PrecisionElement)) return false;
                if (!DeepComparable.IsExactly(SensitivityElement, otherT.SensitivityElement)) return false;
                if (!DeepComparable.IsExactly(FMeasureElement, otherT.FMeasureElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in ScoreElement) { if (elem != null) yield return elem; }
                    foreach (var elem in NumTPElement) { if (elem != null) yield return elem; }
                    foreach (var elem in NumFPElement) { if (elem != null) yield return elem; }
                    foreach (var elem in NumFNElement) { if (elem != null) yield return elem; }
                    foreach (var elem in PrecisionElement) { if (elem != null) yield return elem; }
                    foreach (var elem in SensitivityElement) { if (elem != null) yield return elem; }
                    foreach (var elem in FMeasureElement) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in ScoreElement) { if (elem != null) yield return new ElementValue("score", elem); }
                    foreach (var elem in NumTPElement) { if (elem != null) yield return new ElementValue("numTP", elem); }
                    foreach (var elem in NumFPElement) { if (elem != null) yield return new ElementValue("numFP", elem); }
                    foreach (var elem in NumFNElement) { if (elem != null) yield return new ElementValue("numFN", elem); }
                    foreach (var elem in PrecisionElement) { if (elem != null) yield return new ElementValue("precision", elem); }
                    foreach (var elem in SensitivityElement) { if (elem != null) yield return new ElementValue("sensitivity", elem); }
                    foreach (var elem in FMeasureElement) { if (elem != null) yield return new ElementValue("fMeasure", elem); }
                }
            }


        }


        [FhirType("RepositoryComponent")]
        [DataContract]
        public partial class RepositoryComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RepositoryComponent"; } }

            /// <summary>
            /// directlink | openapi | login | oauth | other
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<repositoryType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<repositoryType> _typeElement;

            /// <summary>
            /// directlink | openapi | login | oauth | other
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public repositoryType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<repositoryType>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// URI of the repository
            /// </summary>
            [FhirElement("url", InSummary=true, Order=50)]
            [DataMember]
            public FhirUri UrlElement
            {
                get { return _urlElement; }
                set { _urlElement = value; OnPropertyChanged("UrlElement"); }
            }

            private FhirUri _urlElement;

            /// <summary>
            /// URI of the repository
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
            /// Repository's name
            /// </summary>
            [FhirElement("name", InSummary=true, Order=60)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Repository's name
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
            /// Id of the dataset that used to call for dataset in repository
            /// </summary>
            [FhirElement("datasetId", InSummary=true, Order=70)]
            [DataMember]
            public FhirString DatasetIdElement
            {
                get { return _datasetIdElement; }
                set { _datasetIdElement = value; OnPropertyChanged("DatasetIdElement"); }
            }

            private FhirString _datasetIdElement;

            /// <summary>
            /// Id of the dataset that used to call for dataset in repository
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string DatasetId
            {
                get { return DatasetIdElement != null ? DatasetIdElement.Value : null; }
                set
                {
                    if (value == null)
                        DatasetIdElement = null;
                    else
                        DatasetIdElement = new FhirString(value);
                    OnPropertyChanged("DatasetId");
                }
            }

            /// <summary>
            /// Id of the variantset that used to call for variantset in repository
            /// </summary>
            [FhirElement("variantsetId", InSummary=true, Order=80)]
            [DataMember]
            public FhirString VariantsetIdElement
            {
                get { return _variantsetIdElement; }
                set { _variantsetIdElement = value; OnPropertyChanged("VariantsetIdElement"); }
            }

            private FhirString _variantsetIdElement;

            /// <summary>
            /// Id of the variantset that used to call for variantset in repository
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string VariantsetId
            {
                get { return VariantsetIdElement != null ? VariantsetIdElement.Value : null; }
                set
                {
                    if (value == null)
                        VariantsetIdElement = null;
                    else
                        VariantsetIdElement = new FhirString(value);
                    OnPropertyChanged("VariantsetId");
                }
            }

            /// <summary>
            /// Id of the read
            /// </summary>
            [FhirElement("readsetId", InSummary=true, Order=90)]
            [DataMember]
            public FhirString ReadsetIdElement
            {
                get { return _readsetIdElement; }
                set { _readsetIdElement = value; OnPropertyChanged("ReadsetIdElement"); }
            }

            private FhirString _readsetIdElement;

            /// <summary>
            /// Id of the read
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ReadsetId
            {
                get { return ReadsetIdElement != null ? ReadsetIdElement.Value : null; }
                set
                {
                    if (value == null)
                        ReadsetIdElement = null;
                    else
                        ReadsetIdElement = new FhirString(value);
                    OnPropertyChanged("ReadsetId");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RepositoryComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TypeElement != null) dest.TypeElement = (Code<repositoryType>)TypeElement.DeepCopy();
                    if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (DatasetIdElement != null) dest.DatasetIdElement = (FhirString)DatasetIdElement.DeepCopy();
                    if (VariantsetIdElement != null) dest.VariantsetIdElement = (FhirString)VariantsetIdElement.DeepCopy();
                    if (ReadsetIdElement != null) dest.ReadsetIdElement = (FhirString)ReadsetIdElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RepositoryComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RepositoryComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(DatasetIdElement, otherT.DatasetIdElement)) return false;
                if (!DeepComparable.Matches(VariantsetIdElement, otherT.VariantsetIdElement)) return false;
                if (!DeepComparable.Matches(ReadsetIdElement, otherT.ReadsetIdElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RepositoryComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(DatasetIdElement, otherT.DatasetIdElement)) return false;
                if (!DeepComparable.IsExactly(VariantsetIdElement, otherT.VariantsetIdElement)) return false;
                if (!DeepComparable.IsExactly(ReadsetIdElement, otherT.ReadsetIdElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (UrlElement != null) yield return UrlElement;
                    if (NameElement != null) yield return NameElement;
                    if (DatasetIdElement != null) yield return DatasetIdElement;
                    if (VariantsetIdElement != null) yield return VariantsetIdElement;
                    if (ReadsetIdElement != null) yield return ReadsetIdElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (DatasetIdElement != null) yield return new ElementValue("datasetId", DatasetIdElement);
                    if (VariantsetIdElement != null) yield return new ElementValue("variantsetId", VariantsetIdElement);
                    if (ReadsetIdElement != null) yield return new ElementValue("readsetId", ReadsetIdElement);
                }
            }


        }


        [FhirType("StructureVariantComponent")]
        [DataContract]
        public partial class StructureVariantComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "StructureVariantComponent"; } }

            /// <summary>
            /// Precision of boundaries
            /// </summary>
            [FhirElement("precision", InSummary=true, Order=40)]
            [DataMember]
            public FhirString PrecisionElement
            {
                get { return _precisionElement; }
                set { _precisionElement = value; OnPropertyChanged("PrecisionElement"); }
            }

            private FhirString _precisionElement;

            /// <summary>
            /// Precision of boundaries
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Precision
            {
                get { return PrecisionElement != null ? PrecisionElement.Value : null; }
                set
                {
                    if (value == null)
                        PrecisionElement = null;
                    else
                        PrecisionElement = new FhirString(value);
                    OnPropertyChanged("Precision");
                }
            }

            /// <summary>
            /// Structural Variant reported aCGH ratio
            /// </summary>
            [FhirElement("reportedaCGHRatio", InSummary=true, Order=50)]
            [DataMember]
            public FhirDecimal ReportedaCGHRatioElement
            {
                get { return _reportedaCGHRatioElement; }
                set { _reportedaCGHRatioElement = value; OnPropertyChanged("ReportedaCGHRatioElement"); }
            }

            private FhirDecimal _reportedaCGHRatioElement;

            /// <summary>
            /// Structural Variant reported aCGH ratio
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? ReportedaCGHRatio
            {
                get { return ReportedaCGHRatioElement != null ? ReportedaCGHRatioElement.Value : null; }
                set
                {
                    if (value == null)
                        ReportedaCGHRatioElement = null;
                    else
                        ReportedaCGHRatioElement = new FhirDecimal(value);
                    OnPropertyChanged("ReportedaCGHRatio");
                }
            }

            /// <summary>
            /// Structural Variant Length
            /// </summary>
            [FhirElement("length", InSummary=true, Order=60)]
            [DataMember]
            public Integer LengthElement
            {
                get { return _lengthElement; }
                set { _lengthElement = value; OnPropertyChanged("LengthElement"); }
            }

            private Integer _lengthElement;

            /// <summary>
            /// Structural Variant Length
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Length
            {
                get { return LengthElement != null ? LengthElement.Value : null; }
                set
                {
                    if (value == null)
                        LengthElement = null;
                    else
                        LengthElement = new Integer(value);
                    OnPropertyChanged("Length");
                }
            }

            /// <summary>
            /// Structural variant outer
            /// </summary>
            [FhirElement("outer", InSummary=true, Order=70)]
            [DataMember]
            public OuterComponent Outer
            {
                get { return _outer; }
                set { _outer = value; OnPropertyChanged("Outer"); }
            }

            private OuterComponent _outer;

            /// <summary>
            /// Structural variant inner
            /// </summary>
            [FhirElement("inner", InSummary=true, Order=80)]
            [DataMember]
            public InnerComponent Inner
            {
                get { return _inner; }
                set { _inner = value; OnPropertyChanged("Inner"); }
            }

            private InnerComponent _inner;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StructureVariantComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (PrecisionElement != null) dest.PrecisionElement = (FhirString)PrecisionElement.DeepCopy();
                    if (ReportedaCGHRatioElement != null) dest.ReportedaCGHRatioElement = (FhirDecimal)ReportedaCGHRatioElement.DeepCopy();
                    if (LengthElement != null) dest.LengthElement = (Integer)LengthElement.DeepCopy();
                    if (Outer != null) dest.Outer = (OuterComponent)Outer.DeepCopy();
                    if (Inner != null) dest.Inner = (InnerComponent)Inner.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new StructureVariantComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as StructureVariantComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(PrecisionElement, otherT.PrecisionElement)) return false;
                if (!DeepComparable.Matches(ReportedaCGHRatioElement, otherT.ReportedaCGHRatioElement)) return false;
                if (!DeepComparable.Matches(LengthElement, otherT.LengthElement)) return false;
                if (!DeepComparable.Matches(Outer, otherT.Outer)) return false;
                if (!DeepComparable.Matches(Inner, otherT.Inner)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StructureVariantComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(PrecisionElement, otherT.PrecisionElement)) return false;
                if (!DeepComparable.IsExactly(ReportedaCGHRatioElement, otherT.ReportedaCGHRatioElement)) return false;
                if (!DeepComparable.IsExactly(LengthElement, otherT.LengthElement)) return false;
                if (!DeepComparable.IsExactly(Outer, otherT.Outer)) return false;
                if (!DeepComparable.IsExactly(Inner, otherT.Inner)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (PrecisionElement != null) yield return PrecisionElement;
                    if (ReportedaCGHRatioElement != null) yield return ReportedaCGHRatioElement;
                    if (LengthElement != null) yield return LengthElement;
                    if (Outer != null) yield return Outer;
                    if (Inner != null) yield return Inner;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (PrecisionElement != null) yield return new ElementValue("precision", PrecisionElement);
                    if (ReportedaCGHRatioElement != null) yield return new ElementValue("reportedaCGHRatio", ReportedaCGHRatioElement);
                    if (LengthElement != null) yield return new ElementValue("length", LengthElement);
                    if (Outer != null) yield return new ElementValue("outer", Outer);
                    if (Inner != null) yield return new ElementValue("inner", Inner);
                }
            }


        }


        [FhirType("OuterComponent")]
        [DataContract]
        public partial class OuterComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "OuterComponent"; } }

            /// <summary>
            /// Structural Variant Outer Start
            /// </summary>
            [FhirElement("start", InSummary=true, Order=40)]
            [DataMember]
            public Integer StartElement
            {
                get { return _startElement; }
                set { _startElement = value; OnPropertyChanged("StartElement"); }
            }

            private Integer _startElement;

            /// <summary>
            /// Structural Variant Outer Start
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Start
            {
                get { return StartElement != null ? StartElement.Value : null; }
                set
                {
                    if (value == null)
                        StartElement = null;
                    else
                        StartElement = new Integer(value);
                    OnPropertyChanged("Start");
                }
            }

            /// <summary>
            /// Structural Variant Outer End
            /// </summary>
            [FhirElement("end", InSummary=true, Order=50)]
            [DataMember]
            public Integer EndElement
            {
                get { return _endElement; }
                set { _endElement = value; OnPropertyChanged("EndElement"); }
            }

            private Integer _endElement;

            /// <summary>
            /// Structural Variant Outer End
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? End
            {
                get { return EndElement != null ? EndElement.Value : null; }
                set
                {
                    if (value == null)
                        EndElement = null;
                    else
                        EndElement = new Integer(value);
                    OnPropertyChanged("End");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OuterComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (StartElement != null) dest.StartElement = (Integer)StartElement.DeepCopy();
                    if (EndElement != null) dest.EndElement = (Integer)EndElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new OuterComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as OuterComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(StartElement, otherT.StartElement)) return false;
                if (!DeepComparable.Matches(EndElement, otherT.EndElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OuterComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(StartElement, otherT.StartElement)) return false;
                if (!DeepComparable.IsExactly(EndElement, otherT.EndElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (StartElement != null) yield return StartElement;
                    if (EndElement != null) yield return EndElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (StartElement != null) yield return new ElementValue("start", StartElement);
                    if (EndElement != null) yield return new ElementValue("end", EndElement);
                }
            }


        }


        [FhirType("InnerComponent")]
        [DataContract]
        public partial class InnerComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "InnerComponent"; } }

            /// <summary>
            /// Structural Variant Inner Start
            /// </summary>
            [FhirElement("start", InSummary=true, Order=40)]
            [DataMember]
            public Integer StartElement
            {
                get { return _startElement; }
                set { _startElement = value; OnPropertyChanged("StartElement"); }
            }

            private Integer _startElement;

            /// <summary>
            /// Structural Variant Inner Start
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Start
            {
                get { return StartElement != null ? StartElement.Value : null; }
                set
                {
                    if (value == null)
                        StartElement = null;
                    else
                        StartElement = new Integer(value);
                    OnPropertyChanged("Start");
                }
            }

            /// <summary>
            /// Structural Variant Inner End
            /// </summary>
            [FhirElement("end", InSummary=true, Order=50)]
            [DataMember]
            public Integer EndElement
            {
                get { return _endElement; }
                set { _endElement = value; OnPropertyChanged("EndElement"); }
            }

            private Integer _endElement;

            /// <summary>
            /// Structural Variant Inner End
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? End
            {
                get { return EndElement != null ? EndElement.Value : null; }
                set
                {
                    if (value == null)
                        EndElement = null;
                    else
                        EndElement = new Integer(value);
                    OnPropertyChanged("End");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as InnerComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (StartElement != null) dest.StartElement = (Integer)StartElement.DeepCopy();
                    if (EndElement != null) dest.EndElement = (Integer)EndElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new InnerComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as InnerComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(StartElement, otherT.StartElement)) return false;
                if (!DeepComparable.Matches(EndElement, otherT.EndElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as InnerComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(StartElement, otherT.StartElement)) return false;
                if (!DeepComparable.IsExactly(EndElement, otherT.EndElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (StartElement != null) yield return StartElement;
                    if (EndElement != null) yield return EndElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (StartElement != null) yield return new ElementValue("start", StartElement);
                    if (EndElement != null) yield return new ElementValue("end", EndElement);
                }
            }


        }


        /// <summary>
        /// Unique ID for this particular sequence. This is a FHIR-defined id
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier==null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// aa | dna | rna
        /// </summary>
        [FhirElement("type", InSummary=true, Order=100)]
        [DataMember]
        public Code TypeElement
        {
            get { return _typeElement; }
            set { _typeElement = value; OnPropertyChanged("TypeElement"); }
        }

        private Code _typeElement;

        /// <summary>
        /// aa | dna | rna
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if (value == null)
                    TypeElement = null;
                else
                    TypeElement = new Code(value);
                OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// Base number of coordinate system (0 for 0-based numbering or coordinates, inclusive start, exclusive end, 1 for 1-based numbering, inclusive start, inclusive end)
        /// </summary>
        [FhirElement("coordinateSystem", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Integer CoordinateSystemElement
        {
            get { return _coordinateSystemElement; }
            set { _coordinateSystemElement = value; OnPropertyChanged("CoordinateSystemElement"); }
        }

        private Integer _coordinateSystemElement;

        /// <summary>
        /// Base number of coordinate system (0 for 0-based numbering or coordinates, inclusive start, exclusive end, 1 for 1-based numbering, inclusive start, inclusive end)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? CoordinateSystem
        {
            get { return CoordinateSystemElement != null ? CoordinateSystemElement.Value : null; }
            set
            {
                if (value == null)
                    CoordinateSystemElement = null;
                else
                    CoordinateSystemElement = new Integer(value);
                OnPropertyChanged("CoordinateSystem");
            }
        }

        /// <summary>
        /// Who and/or what this is about
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=120)]
        [References("Patient")]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Specimen used for sequencing
        /// </summary>
        [FhirElement("specimen", InSummary=true, Order=130)]
        [References("Specimen")]
        [DataMember]
        public ResourceReference Specimen
        {
            get { return _specimen; }
            set { _specimen = value; OnPropertyChanged("Specimen"); }
        }

        private ResourceReference _specimen;

        /// <summary>
        /// The method for sequencing
        /// </summary>
        [FhirElement("device", InSummary=true, Order=140)]
        [References("Device")]
        [DataMember]
        public ResourceReference Device
        {
            get { return _device; }
            set { _device = value; OnPropertyChanged("Device"); }
        }

        private ResourceReference _device;

        /// <summary>
        /// Who should be responsible for test result
        /// </summary>
        [FhirElement("performer", InSummary=true, Order=150)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Performer
        {
            get { return _performer; }
            set { _performer = value; OnPropertyChanged("Performer"); }
        }

        private ResourceReference _performer;

        /// <summary>
        /// The number of copies of the seqeunce of interest.  (RNASeq)
        /// </summary>
        [FhirElement("quantity", InSummary=true, Order=160)]
        [DataMember]
        public Quantity Quantity
        {
            get { return _quantity; }
            set { _quantity = value; OnPropertyChanged("Quantity"); }
        }

        private Quantity _quantity;

        /// <summary>
        /// A sequence used as reference
        /// </summary>
        [FhirElement("referenceSeq", InSummary=true, Order=170)]
        [DataMember]
        public ReferenceSeqComponent ReferenceSeq
        {
            get { return _referenceSeq; }
            set { _referenceSeq = value; OnPropertyChanged("ReferenceSeq"); }
        }

        private ReferenceSeqComponent _referenceSeq;

        /// <summary>
        /// Variant in sequence
        /// </summary>
        [FhirElement("variant", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<VariantComponent> Variant
        {
            get { if (_variant==null) _variant = new List<VariantComponent>(); return _variant; }
            set { _variant = value; OnPropertyChanged("Variant"); }
        }

        private List<VariantComponent> _variant;

        /// <summary>
        /// Sequence that was observed
        /// </summary>
        [FhirElement("observedSeq", InSummary=true, Order=190)]
        [DataMember]
        public FhirString ObservedSeqElement
        {
            get { return _observedSeqElement; }
            set { _observedSeqElement = value; OnPropertyChanged("ObservedSeqElement"); }
        }

        private FhirString _observedSeqElement;

        /// <summary>
        /// Sequence that was observed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string ObservedSeq
        {
            get { return ObservedSeqElement != null ? ObservedSeqElement.Value : null; }
            set
            {
                if (value == null)
                    ObservedSeqElement = null;
                else
                    ObservedSeqElement = new FhirString(value);
                OnPropertyChanged("ObservedSeq");
            }
        }

        /// <summary>
        /// An set of value as quality of sequence
        /// </summary>
        [FhirElement("quality", InSummary=true, Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<QualityComponent> Quality
        {
            get { if (_quality==null) _quality = new List<QualityComponent>(); return _quality; }
            set { _quality = value; OnPropertyChanged("Quality"); }
        }

        private List<QualityComponent> _quality;

        /// <summary>
        /// Average number of reads representing a given nucleotide in the reconstructed sequence
        /// </summary>
        [FhirElement("readCoverage", InSummary=true, Order=210)]
        [DataMember]
        public Integer ReadCoverageElement
        {
            get { return _readCoverageElement; }
            set { _readCoverageElement = value; OnPropertyChanged("ReadCoverageElement"); }
        }

        private Integer _readCoverageElement;

        /// <summary>
        /// Average number of reads representing a given nucleotide in the reconstructed sequence
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? ReadCoverage
        {
            get { return ReadCoverageElement != null ? ReadCoverageElement.Value : null; }
            set
            {
                if (value == null)
                    ReadCoverageElement = null;
                else
                    ReadCoverageElement = new Integer(value);
                OnPropertyChanged("ReadCoverage");
            }
        }

        /// <summary>
        /// External repository which contains detailed report related with observedSeq in this resource
        /// </summary>
        [FhirElement("repository", InSummary=true, Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<RepositoryComponent> Repository
        {
            get { if (_repository==null) _repository = new List<RepositoryComponent>(); return _repository; }
            set { _repository = value; OnPropertyChanged("Repository"); }
        }

        private List<RepositoryComponent> _repository;

        /// <summary>
        /// Pointer to next atomic sequence
        /// </summary>
        [FhirElement("pointer", InSummary=true, Order=230)]
        [References("Sequence")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Pointer
        {
            get { if (_pointer==null) _pointer = new List<ResourceReference>(); return _pointer; }
            set { _pointer = value; OnPropertyChanged("Pointer"); }
        }

        private List<ResourceReference> _pointer;

        /// <summary>
        /// Structural variant
        /// </summary>
        [FhirElement("structureVariant", InSummary=true, Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<StructureVariantComponent> StructureVariant
        {
            get { if (_structureVariant==null) _structureVariant = new List<StructureVariantComponent>(); return _structureVariant; }
            set { _structureVariant = value; OnPropertyChanged("StructureVariant"); }
        }

        private List<StructureVariantComponent> _structureVariant;


        public static ElementDefinition.ConstraintComponent Sequence_SEQ_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "coordinateSystem = 1 or coordinateSystem = 0",
            Key = "seq-3",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Only 0 and 1 are valid for coordinateSystem",
            Xpath = "count(f:coordinateSystem[@value=0 and @value=1]) = 1"
        };

        public static ElementDefinition.ConstraintComponent Sequence_SEQ_5 = new ElementDefinition.ConstraintComponent
        {
            Expression = "referenceSeq.all((chromosome.empty() and genomeBuild.empty()) or (chromosome.exists() and genomeBuild.exists()))",
            Key = "seq-5",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "GenomeBuild and chromosome must be both contained if either one of them is contained",
            Xpath = "(exists(f:chromosome) and exists(f:genomeBuild)) or (not(exists(f:chromosome)) and not(exists(f:genomeBuild)))"
        };

        public static ElementDefinition.ConstraintComponent Sequence_SEQ_6 = new ElementDefinition.ConstraintComponent
        {
            Expression = "referenceSeq.all((genomeBuild.count()+referenceSeqId.count()+ referenceSeqPointer.count()+ referenceSeqString.count()) = 1)",
            Key = "seq-6",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Have and only have one of the following elements in referenceSeq : 1. genomeBuild ; 2 referenceSeqId; 3. referenceSeqPointer;  4. referenceSeqString;",
            Xpath = "count(f:genomeBuild)+count(f:referenceSeqId)+count(f:referenceSeqPointer)+count(f:referenceSeqString)=1"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Sequence_SEQ_3);
            InvariantConstraints.Add(Sequence_SEQ_5);
            InvariantConstraints.Add(Sequence_SEQ_6);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Sequence;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (TypeElement != null) dest.TypeElement = (Code)TypeElement.DeepCopy();
                if (CoordinateSystemElement != null) dest.CoordinateSystemElement = (Integer)CoordinateSystemElement.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Specimen != null) dest.Specimen = (ResourceReference)Specimen.DeepCopy();
                if (Device != null) dest.Device = (ResourceReference)Device.DeepCopy();
                if (Performer != null) dest.Performer = (ResourceReference)Performer.DeepCopy();
                if (Quantity != null) dest.Quantity = (Quantity)Quantity.DeepCopy();
                if (ReferenceSeq != null) dest.ReferenceSeq = (ReferenceSeqComponent)ReferenceSeq.DeepCopy();
                if (Variant != null) dest.Variant = new List<VariantComponent>(Variant.DeepCopy());
                if (ObservedSeqElement != null) dest.ObservedSeqElement = (FhirString)ObservedSeqElement.DeepCopy();
                if (Quality != null) dest.Quality = new List<QualityComponent>(Quality.DeepCopy());
                if (ReadCoverageElement != null) dest.ReadCoverageElement = (Integer)ReadCoverageElement.DeepCopy();
                if (Repository != null) dest.Repository = new List<RepositoryComponent>(Repository.DeepCopy());
                if (Pointer != null) dest.Pointer = new List<ResourceReference>(Pointer.DeepCopy());
                if (StructureVariant != null) dest.StructureVariant = new List<StructureVariantComponent>(StructureVariant.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Sequence());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Sequence;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.Matches(CoordinateSystemElement, otherT.CoordinateSystemElement)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Specimen, otherT.Specimen)) return false;
            if (!DeepComparable.Matches(Device, otherT.Device)) return false;
            if (!DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
            if (!DeepComparable.Matches(ReferenceSeq, otherT.ReferenceSeq)) return false;
            if ( !DeepComparable.Matches(Variant, otherT.Variant)) return false;
            if (!DeepComparable.Matches(ObservedSeqElement, otherT.ObservedSeqElement)) return false;
            if ( !DeepComparable.Matches(Quality, otherT.Quality)) return false;
            if (!DeepComparable.Matches(ReadCoverageElement, otherT.ReadCoverageElement)) return false;
            if ( !DeepComparable.Matches(Repository, otherT.Repository)) return false;
            if ( !DeepComparable.Matches(Pointer, otherT.Pointer)) return false;
            if ( !DeepComparable.Matches(StructureVariant, otherT.StructureVariant)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Sequence;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.IsExactly(CoordinateSystemElement, otherT.CoordinateSystemElement)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Specimen, otherT.Specimen)) return false;
            if (!DeepComparable.IsExactly(Device, otherT.Device)) return false;
            if (!DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
            if (!DeepComparable.IsExactly(ReferenceSeq, otherT.ReferenceSeq)) return false;
            if (!DeepComparable.IsExactly(Variant, otherT.Variant)) return false;
            if (!DeepComparable.IsExactly(ObservedSeqElement, otherT.ObservedSeqElement)) return false;
            if (!DeepComparable.IsExactly(Quality, otherT.Quality)) return false;
            if (!DeepComparable.IsExactly(ReadCoverageElement, otherT.ReadCoverageElement)) return false;
            if (!DeepComparable.IsExactly(Repository, otherT.Repository)) return false;
            if (!DeepComparable.IsExactly(Pointer, otherT.Pointer)) return false;
            if (!DeepComparable.IsExactly(StructureVariant, otherT.StructureVariant)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (TypeElement != null) yield return TypeElement;
                if (CoordinateSystemElement != null) yield return CoordinateSystemElement;
                if (Patient != null) yield return Patient;
                if (Specimen != null) yield return Specimen;
                if (Device != null) yield return Device;
                if (Performer != null) yield return Performer;
                if (Quantity != null) yield return Quantity;
                if (ReferenceSeq != null) yield return ReferenceSeq;
                foreach (var elem in Variant) { if (elem != null) yield return elem; }
                if (ObservedSeqElement != null) yield return ObservedSeqElement;
                foreach (var elem in Quality) { if (elem != null) yield return elem; }
                if (ReadCoverageElement != null) yield return ReadCoverageElement;
                foreach (var elem in Repository) { if (elem != null) yield return elem; }
                foreach (var elem in Pointer) { if (elem != null) yield return elem; }
                foreach (var elem in StructureVariant) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                if (CoordinateSystemElement != null) yield return new ElementValue("coordinateSystem", CoordinateSystemElement);
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Specimen != null) yield return new ElementValue("specimen", Specimen);
                if (Device != null) yield return new ElementValue("device", Device);
                if (Performer != null) yield return new ElementValue("performer", Performer);
                if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                if (ReferenceSeq != null) yield return new ElementValue("referenceSeq", ReferenceSeq);
                foreach (var elem in Variant) { if (elem != null) yield return new ElementValue("variant", elem); }
                if (ObservedSeqElement != null) yield return new ElementValue("observedSeq", ObservedSeqElement);
                foreach (var elem in Quality) { if (elem != null) yield return new ElementValue("quality", elem); }
                if (ReadCoverageElement != null) yield return new ElementValue("readCoverage", ReadCoverageElement);
                foreach (var elem in Repository) { if (elem != null) yield return new ElementValue("repository", elem); }
                foreach (var elem in Pointer) { if (elem != null) yield return new ElementValue("pointer", elem); }
                foreach (var elem in StructureVariant) { if (elem != null) yield return new ElementValue("structureVariant", elem); }
            }
        }

    }

}
