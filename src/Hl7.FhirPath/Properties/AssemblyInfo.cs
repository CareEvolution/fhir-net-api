using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#if DEBUG
[assembly: InternalsVisibleTo("Hl7.FhirPath.Tests")]
[assembly: InternalsVisibleTo("Hl7.Fhir.Core.Tests")]
#endif