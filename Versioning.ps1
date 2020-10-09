Param(
  [string]$pathToSearch = $env:TF_BUILD_SOURCESDIRECTORY,
  [string]$buildNumber = $env:TF_BUILD_BUILDNUMBER,
  [string]$searchFilter = "AssemblyInfo.*",
  [regex]$pattern = "[\d]+\.[\d]+\.[\d]+\.[\d]+"
)
 
try
{
    if ($buildNumber -match $pattern -ne $true) 
	{
        Write-Host "Could not extract a version from [$buildNumber] using pattern [$pattern]"
        exit 1
    } 
	else 
	{

		$extractedBuildNumber = $Matches[0]
        Write-Host "Using version $extractedBuildNumber"
 	    Get-ChildItem -Path $pathToSearch -Filter $searchFilter -Recurse | % {
            Write-Host "  -> Updating $($_.FullName)"
            # remove the read-only bit on the file
            Set-ItemProperty $_.FullName IsReadOnly $false
			
            # run the regex replace
            (Get-Content $_.FullName) | % { $_ -replace $pattern, $extractedBuildNumber } | Set-Content $_.FullName
       }
 
        Write-Host "Done!"
    }
}
catch {
    Write-Host $_
    exit 1
}