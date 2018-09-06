using System;
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Hl7.Fhir.DSTU2")]
[assembly: InternalsVisibleTo("Hl7.Fhir.STU3")]
[assembly: InternalsVisibleTo("Hl7.Fhir.R4")]

#if DEBUG
[assembly: InternalsVisibleTo("Hl7.Fhir.DSTU2.Tests")]
[assembly: InternalsVisibleTo("Hl7.Fhir.STU3.Tests")]
[assembly: InternalsVisibleTo("Hl7.Fhir.R4.Tests")]
#endif
