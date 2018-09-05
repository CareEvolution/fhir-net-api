# ---------------------------------------------------------------------------
# Download the published content from the FHIR specification
# ---------------------------------------------------------------------------
# cls

# Script to be run from 'build' directory

$server = "http://hl7.org/fhir/";
$baseDir = Resolve-Path ..
$srcdir = "$baseDir\src";

# Apply this transform to remove all the Meta sections from the profiles (to remove the LastUpdated tags) 
# this makes it easier to see the actual changes between versions
$xslt = New-Object System.Xml.Xsl.XslCompiledTransform;
$xslt.Load("$baseDir\Build\StripLastModified.xslt");

# These are all files from the spec that we need. Last modified dates are stripped after download
$allFiles = @("conceptmaps.xml", "dataelements.xml", "expansions.xml", "extension-definitions.xml", "namingsystem-registry.xml",
				"profiles-others.xml", "profiles-resources.xml", "profiles-types.xml", "search-parameters.xml", "v2-tables.xml",
				"v3-codesystems.xml", "valuesets.xml");

function New-TemporaryDirectory {
    $parent = [System.IO.Path]::GetTempPath()
    $name = [System.IO.Path]::GetRandomFileName()
	$fullpath = Join-Path $parent $name
    New-Item -ItemType Directory -Path $fullpath
}

$tempDir = New-TemporaryDirectory


# Download a file from a URL and place it at the specified target path.
# This also has some basic capabilities to go through proxies without any additional configuration.
function PowerCurl($targetPath, $sourceUrl)
{
	Try
	{
		Write-Host -ForegroundColor White "downloading $sourceUrl to $targetPath ..."
        $webclient = New-Object System.Net.WebClient
        $webclient.DownloadFile($sourceUrl,$targetPath)
	} Catch
	{
		Write-Host -ForegroundColor Red "$_ occurred while downloading $sourceUrl to $targetPath"
		$_ | Format-List * -Force
	}
}

function GetSpecFile($version, $name)
{
	$targetPath = Join-Path $tempDir $name
	$sourceUrl = "$server$version/$name"
	Write-Host $sourceUrl
	PowerCurl $targetPath $sourceUrl
}


function TransformSpecfile($name)
{
	Write-Host -ForegroundColor White "transforming $name..."
	$transformPath = Join-Path $tempDir $name
	$tempTransformPath = $transformPath + "-temp"

	$xslt.Transform($transformPath, $tempTransformPath);
	Remove-Item $transformPath
	Move-Item $tempTransformPath $transformPath
}

function CopySpecFile($name, $destDir)
{
	$sourcePath = Join-Path $tempDir $name
	$destPath = Join-Path $destDir $name
	Copy-Item $sourcePath $destPath
}

foreach($file in $allFiles)			
{
	GetSpecFile "DSTU2" $file
	TransformSpecfile $file
}

Write-Host -ForegroundColor White "Copy files to project..."

# Copy the files necessary for code generation
# CopySpecFile "expansions.xml" "$srcdir\Hl7.Fhir.DSTU2\Model\Source-DSTU2"
# CopySpecFile "profiles-resources.xml" "$srcdir\Hl7.Fhir.DSTU2\Model\Source-DSTU2"
# CopySpecFile "profiles-types.xml" "$srcdir\Hl7.Fhir.DSTU2\Model\Source-DSTU2"
# CopySpecFile "profiles-others.xml" "$srcdir\Hl7.Fhir.DSTU2\Model\Source-DSTU2"
# CopySpecFile "search-parameters.xml" "$srcdir\Hl7.Fhir.DSTU2\Model\Source-DSTU2"

# Copy the files necessary for the specification library (specification.zip / data)
# CopySpecFile "conceptmaps.xml" "$srcdir\Hl7.Fhir.Specification.DSTU2\data"
# CopySpecFile "dataelements.xml" "$srcdir\Hl7.Fhir.Specification.DSTU2\data"
#CopySpecFile "expansions.xml" "$srcdir\Hl7.Fhir.Specification\data"
# CopySpecFile "extension-definitions.xml" "$srcdir\Hl7.Fhir.Specification.DSTU2\data"
# CopySpecFile "namingsystem-registry.xml" "$srcdir\Hl7.Fhir.Specification.DSTU2\data"
# CopySpecFile "profiles-others.xml" "$srcdir\Hl7.Fhir.Specification.DSTU2\data"
# CopySpecFile "profiles-resources.xml" "$srcdir\Hl7.Fhir.Specification.DSTU2\data"
# CopySpecFile "profiles-types.xml" "$srcdir\Hl7.Fhir.Specification.DSTU2\data"
# CopySpecFile "search-parameters.xml" "$srcdir\Hl7.Fhir.Specification.DSTU2\data"
# CopySpecFile "v2-tables.xml" "$srcdir\Hl7.Fhir.Specification.DSTU2\data"
# CopySpecFile "v3-codesystems.xml" "$srcdir\Hl7.Fhir.Specification.DSTU2\data"
# CopySpecFile "valuesets.xml" "$srcdir\Hl7.Fhir.Specification.DSTU2\data"

# Add example files used for testing
PowerCurl "$srcdir\Hl7.Fhir.DSTU2.Tests\TestData\careplan-example-f201-renal.xml" "$server/DSTU2/careplan-example-f201-renal.xml"
PowerCurl "$srcdir\Hl7.Fhir.DSTU2.Tests\TestData\testscript-example(example).xml" "$server/DSTU2/testscript-example.xml"
#PowerCurl "$srcdir\Hl7.Fhir.DSTU2.Tests\TestData\valueset-v2-0717.json" "$server/DSTU2/v2/0717/v2-0717.vs.json"
PowerCurl "$srcdir\Hl7.Fhir.DSTU2.Tests\TestData\examples.zip" "$server/DSTU2/examples.zip"
PowerCurl "$srcdir\Hl7.Fhir.DSTU2.Tests\TestData\examples-json.zip" "$server/DSTU2/examples-json.zip"
PowerCurl "$srcdir\Hl7.Fhir.DSTU2.Tests\TestData\json-edge-cases.json" "$server/DSTU2/json-edge-cases.json"

# Still need to add:
# extract schemas and xsd from fhir-all.zip -> data
