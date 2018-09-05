using System;
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Hl7.Fhir.DSTU2")]
[assembly: InternalsVisibleTo("Hl7.Fhir.STU3")]

#if DEBUG
[assembly: InternalsVisibleTo("Hl7.Fhir.DSTU2.Tests")]
[assembly: InternalsVisibleTo("Hl7.Fhir.STU3.Tests")]
#endif
