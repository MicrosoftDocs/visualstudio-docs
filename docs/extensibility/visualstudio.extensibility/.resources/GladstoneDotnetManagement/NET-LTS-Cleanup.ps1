### Thist must be run as `ADMIN` in order to copy files to the Program Files directory
param(
    [Parameter(Mandatory=$true)]
    [string]$VsInstanceRootPath
)

$dotnetInstallLocation = [System.IO.Path]::Combine($VsInstanceRootPath, "dotnet", "net9.0", "runtime");
$net9ExtensibilityHostsDirectory = [System.IO.Path]::Combine($VsInstanceRootPath, "Common7", "ServiceHub", "Hosts", "ServiceHub.Host.Extensibility.net9.amd64")

if (Test-Path -Path $dotnetInstallLocation) {
    Remove-Item -Path $dotnetInstallLocation -Recurse -Force
}

if (Test-Path -Path $net9ExtensibilityHostsDirectory) {
    Remove-Item -Path $net9ExtensibilityHostsDirectory -Recurse -Force
}

Write-Host "Cleanup complete. Removed .NET 9.0 and ServiceHub hosts for .NET 9.0"