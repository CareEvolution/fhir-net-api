using System;
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Hl7.Fhir.DSTU2")]

#if DEBUG
[assembly: InternalsVisibleTo("Hl7.Fhir.DSTU2.Tests")]
#endif
