---
title: Visual Studio Container Tools launch settings
author: ghogen
description: Overview of the Container Tools build process
ms.author: ghogen
ms.date: 08/13/2019
ms.technology: vs-azure
ms.topic: conceptual
---
# Container Tools launch settings

In the *Properties* folder in an ASP.NET Core project, you can find the launchSettings.json file, which contains settings that control how your web app is started on your development machine. For detailed information on how this file is used in ASP.NET development, see [Use multiple environments in ASP.NET Core](/aspnet/core/fundamentals/environments?view=aspnetcore-2.2). Some of the settings in *launchSettings.json* are related to how Visual Studio handles containerized apps. In *launchSettings.json*, Container Tools settings are in the **Docker** section, with `commandName` set to **Docker**:

::: moniker range="vs-2017"
```json
    "Docker": {
      "commandName": "Docker",
      "launchBrowser": true,
      "launchUrl": "{Scheme}://{ServiceHost}:{ServicePort}"
    }
```

::: moniker-end
::: moniker range=">=vs-2019"

```json
    "Docker": {
      "commandName": "Docker",
      "launchBrowser": true,
      "launchUrl": "{Scheme}://{ServiceHost}:{ServicePort}",
      "environmentVariables": {
        "ASPNETCORE_URLS": "https://+:443;http://+:80",
        "ASPNETCORE_HTTPS_PORT": "44360"
      },
      "httpPort": 51803,
      "useSSL": true,
      "sslPort": 44360
    }
```

::: moniker-end

The following table shows the properties that can be set in this file:

|Setting name|Example|Description|
|------------|---------|---------------|
|launchBrowser|"launchBrowser": true|Indicates whether to launch the browser after successfully launching the project.|
|launchUrl|"launchUrl": "{Scheme}://{ServiceHost}:{ServicePort}"|This URL is used when launching the browser.  Supported replacement tokens for this string are:<br>
{Scheme} - Replaced with either "http" or "https" depending on whether SSL is used.<br>
{ServiceHost} - Usually replaced with "localhost". When targeting Windows containers on Windows 10 RS3 or older, though, it is replaced with the container's IP.<br>
{ServicePort} - Usually replaced with either sslPort or httpPort, depending on whether SSL is used.  When targeting Windows containers on Windows 10 RS3 or older, though, it is replaced with either "443" or "80", depending on whether SSL is used.<br>
|environmentVariables|"environmentVariables": {<br>
    "ASPNETCORE_URLS": "https://+:443;http://+:80",<br>
    "ASPNETCORE_HTTPS_PORT": "44381"<br>
}|These environment variable values are passed to the process when it is launched in the container.|
|httpPort|"httpPort": 24051|This port on the host is mapped to the container's port 80 when launching the container.  If unspecified, the value is taken from the iisSettings value.|
|sslPort|"sslPort": 44381|This port on the host is mapped to the container's port 443 when launching the container.  If unspecified, the value is taken from the iisSettings value.|
|useSSL|"useSSL": true|Indicates whether to use SSL when launching the project.  If useSSL is not specified, then SSL is used when sslPort > 0.
|commandLineArgs|"commandLineArgs": "--mysetting myvalue"|These command-line arguments are used when launching your project in the container.|

## Next steps

Configure your project by setting the [Container Tools build properties](container-msbuild-properties.md).

## See also

[Docker Compose build properties](docker-compose-properties.md)
