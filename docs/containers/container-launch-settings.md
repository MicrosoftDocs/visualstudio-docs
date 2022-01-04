---
title: Visual Studio Container Tools launch settings
author: ghogen
description: Learn about the launch settings for Container Tools that are related to how Visual Studio handles containerized apps.
ms.author: ghogen
ms.date: 08/15/2019
ms.technology: vs-container-tools
ms.topic: reference
---
# Container Tools launch settings

In the *Properties* folder in an ASP.NET Core project, you can find the launchSettings.json file, which contains settings that control how your web app is started on your development machine. For detailed information on how this file is used in ASP.NET development, see [Use multiple environments in ASP.NET Core](/aspnet/core/fundamentals/environments?view=aspnetcore-2.2&preserve-view=true). In *launchSettings.json*, the settings in the **Docker** section are related to how Visual Studio handles containerized apps.

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

The commandName setting identifies that this section applies to Container Tools. The following table shows the properties that can be set in this section:

::: moniker range="vs-2017"

|Setting name|Version|Example|Description|
|------------|-------|-------|---------------|
|dockerRunArguments|Visual Studio 2017|"dockerRunArguments": "-v $(pwd)/host-folder:/container-folder:ro"|Additional arguments to pass to the [docker run](https://docs.docker.com/engine/reference/commandline/run/) command.|
|launchBrowser|Visual Studio 2017|"launchBrowser": true|Indicates whether to launch the browser after successfully launching the project.|
|launchUrl|Visual Studio 2017|"launchUrl": "{Scheme}://{ServiceHost}:{ServicePort}"|This URL is used when launching the browser.  Supported replacement tokens for this string are:<br/><br/>   - {Scheme} - Replaced with either "http" or "https" depending on whether SSL is used.<br/><br/>   - {ServiceHost} - Usually replaced with "localhost". When targeting Windows containers on Windows 10 RS3 or older, though, it is replaced with the container's IP.<br/><br/>   {ServicePort} - Usually replaced with either sslPort or httpPort, depending on whether SSL is used.  When targeting Windows containers on Windows 10 RS3 or older, though, it is replaced with either "443" or "80", depending on whether SSL is used.|

::: moniker-end

::: moniker range=">=vs-2019"

| Setting name         | Example                                               | Description                                                                                                             |
| -------------------- | ----------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- |
| commandLineArgs      | "commandLineArgs": "--mysetting myvalue"              | These command-line arguments for starting your app are used when launching your project in the container.                                     |
|dockerRunArguments|"dockerRunArguments": "-v $(pwd)/host-folder:/container-folder:ro"|Additional arguments to pass to the [docker run](https://docs.docker.com/engine/reference/commandline/run/) command.|
| environmentVariables | "environmentVariables": {<br/>   "ASPNETCORE_URLS": "https://+:443;http://+:80", <br/>   "ASPNETCORE_HTTPS_PORT": "44381" <br/> }                    | These environment variable values are passed to the process when it is launched in the container.                       |
| httpPort             | "httpPort": 24051                                     | This port on the host is mapped to the container's port 80 when launching the container. |
| launchBrowser        | "launchBrowser": true                                 | Indicates whether to launch the browser after successfully launching the project.                                       |
| launchUrl            | "launchUrl": "{Scheme}://{ServiceHost}:{ServicePort}" | This URL is used when launching the browser. Supported replacement tokens for this string are: <br/><br/> - {Scheme} - Replaced with either "http" or "https" depending on whether SSL is used. <br/><br/> - {ServiceHost} - Usually replaced with "localhost". <br/> When targeting Windows containers on Windows 10 RS3 or older, though, it is replaced with the container's IP. <br/><br/> - {ServicePort} - Usually replaced with either sslPort or httpPort, depending on whether SSL is used. <br/> When targeting Windows containers on Windows 10 RS3 or older, though, it is replaced with either "443" or "80", depending on whether SSL is used. |
| sslPort              | "sslPort": 44381                                      | This port on the host is mapped to the container's port 443 when launching the container. |
| useSSL               | "useSSL": true                                        | Indicates whether to use SSL when launching the project. If useSSL is not specified, then SSL is used when sslPort > 0. |

::: moniker-end

## Next steps

Configure your project by setting the [Container Tools build properties](container-msbuild-properties.md).

## See also

- [Docker Compose build properties](docker-compose-properties.md)
- [Manage launch profiles for Docker Compose](launch-profiles.md)
