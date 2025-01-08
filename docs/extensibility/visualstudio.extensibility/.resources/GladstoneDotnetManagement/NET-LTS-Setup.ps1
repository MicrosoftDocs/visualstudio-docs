### Thist must be run as `ADMIN` in order to copy files to the Program Files directory
param(
    [Parameter(Mandatory=$true)]
    [string]$VsInstanceRootPath
)


$dotnetInstallScriptName = "dotnet-install.ps1"
$dotnetInstallUrl = "https://dot.net/v1/dotnet-install.ps1";

$netVersion = "9.0.101";
$hostFiles = @("dotnetExtensibility-net9.servicehub.host.json", "dotnetExtensibility-net9.x64.servicehub.host.json")
$dotnetInstallLocation = [System.IO.Path]::Combine($VsInstanceRootPath, "dotnet", "net9.0", "runtime");
$hostConfigsPath = [System.IO.Path]::Combine($VsInstanceRootPath, "Common7", "ServiceHub", "Hosts")
$extensibilityHostsDirectory = [System.IO.Path]::Combine($hostConfigsPath, "ServiceHub.Host.Extensibility.amd64")
$net9ExtensibilityHostsDirectory = [System.IO.Path]::Combine($hostConfigsPath, "ServiceHub.Host.Extensibility.net9.amd64")
$hostConfigTemplate = @"
{
  "`$schema": "../../../schemas/servicehub.host.schema.json",
  "hostExecutable": "./ServiceHub.Host.Extensibility.x64.exe",
  "hostArgs": [ "`$HOSTID", "`$PIPE", "`$TELEMETRYSESSION", "`$HostRemoteBrokerPipeName" ],
  "additionalEnvironmentVariables": {
    "DOTNET_ROOT": "$($dotnetInstallLocation -replace '\\', '\\')"
  }
}
"@

if (-not (Test-Path -Path $VsInstanceRootPath)) {
    Write-Error "Visual Studio instance root path does not exist: $VsInstanceRootPath"
    exit 1
}

# Install .NET 9 if needed
if (-not (Test-Path -Path $dotnetInstallLocation)) {
    # Create .NET 9 install directory
    New-Item -ItemType Directory -Path $dotnetInstallLocation > $null

    # Install .NET installer script
    try {
        $dotnetInstallScriptPath = [System.IO.Path]::Combine([System.Environment]::CurrentDirectory, $dotnetInstallScriptName)
        if (Test-Path -Path $dotnetInstallScriptPath) {
            Remove-Item -Path $dotnetInstallScriptPath -Force
        }
        Invoke-WebRequest -Uri $dotnetInstallUrl -OutFile $dotnetInstallScriptPath
    } catch {
        Write-Error "Failed to download installer."
        exit 1
    }

    # Verify .NET installer script exists
    if (-not (Test-Path -Path $dotnetInstallScriptPath)) {
        Write-Error "Cannot locate .NET installer script"
        exit 1
    }

    # Download .NET 9 to target location and remove installer script
    try {
        & $dotnetInstallScriptPath -Version $netVersion -InstallDir $dotnetInstallLocation -NoPath
        Remove-Item -Path $dotnetInstallScriptPath -Force
    } catch {
        Write-Error "Failed to install .NET 9"
        exit 1
    }

    Write-Host ".NET 9 installed successfully to $dotnetInstallLocation"
}

# Update service hub host configs and copy to VS directory
if (Test-Path -Path $net9ExtensibilityHostsDirectory) {
    Remove-Item $net9ExtensibilityHostsDirectory -Force -Recurse
}
Copy-Item -Path $extensibilityHostsDirectory -Destination $net9ExtensibilityHostsDirectory -Force -Recurse
Get-ChildItem -Path $net9ExtensibilityHostsDirectory -Filter "*.servicehub.host.json" -File | Remove-Item -Force
foreach ($file in $hostFiles) {
    $hostConfigPath = [System.IO.Path]::Combine($net9ExtensibilityHostsDirectory, $file)
    New-Item $hostConfigPath -ItemType File -Value $hostConfigTemplate > $null
}
Write-Host "Service hub host configs updated for .NET 9 at $net9ExtensibilityHostsDirectory"
