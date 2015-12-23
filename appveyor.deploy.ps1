# deploy script for AppVeyor CI environmentr

Write-Host "DEPLOYING configuration $env:CONFIGURATION in Branch $env:APPVEYOR_REPO_BRANCH"
Try
{
	# master branch
	if ($env:APPVEYOR_REPO_BRANCH -eq "master")
	{
		Write-Host "MASTER CONFIGURATION DETECTED. DEPLOYING TO NUGET."
		& .\appveyor.deploy.to-nuget.ps1
	}
	
	########
	# handle special deploy stuff
	else
	{
		Write-Host "- no configuration found -"
	}
	
	
	Write-Host "DEPLOYING FINISHED."
}
Catch
{
    exit -1
}