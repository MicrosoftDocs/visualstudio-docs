---
title: Visual Studio Container Tools launch settings
author: ghogen
description: Learn about the launch settings for Container Tools that are related to how Visual Studio handles containerized apps.
ms.author: ghogen
ms.date: 08/15/2019
ms.subservice: container-tools
ms.topic: reference
---

# Container Tools launch settings

In the *Properties* folder in an ASP.NET Core project, you can find the `launchSettings.json` file, which contains settings that control how your web app is started on your development machine. For detailed information on how this file is used in ASP.NET development, see [Use multiple environments in ASP.NET Core](/aspnet/core/fundamentals/environments?view=aspnetcore-2.2&preserve-view=true).

You can edit this file directly, but in Visual Studio IDE, you can also edit the properties in this file through the UI. Choose the dropdown list next to the launch option (for example, `Docker` or `.NET SDK`), and then choose **Debug Properties**.

In *launchSettings.json*, the settings in the **Docker** section are related to how Visual Studio handles containerized apps.

```json
    "Docker": {
      "commandName": "Docker",
      "launchBrowser": true,
      "launchUrl": "{Scheme}://{ServiceHost}:{ServicePort}",
      "DockerfileRunArguments": "-l mylabel=value",
      "environmentVariables": {
        "ASPNETCORE_URLS": "https://+:443;http://+:80",
        "ASPNETCORE_HTTPS_PORT": "44360"
      },
      "httpPort": 51803,
      "useSSL": true,
      "sslPort": 44360
    }
```

The commandName setting identifies that this section applies to Container Tools.

:::moniker range=">=vs-2022"
Most of the settings in `launchSettings.json` are available and applicable whether you're using a Dockerfile, or using the .NET SDK's built-in container build support (available for .NET 7 and later).
:::moniker-end

The following table shows the properties that can be set in this section:

::: moniker range="vs-2019"

| Setting name         | Example                                               | Description                                                                                                             |
| -------------------- | ----------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- |
| commandLineArgs      | `"commandLineArgs": "--mysetting myvalue"`              | These command-line arguments for starting your app are used when launching your project in the container.                                     |
|DockerfileRunArguments|`"dockerfileRunArguments": "-l mylabel=value"`|Additional arguments to pass to the [`docker run`](https://docs.docker.com/engine/reference/commandline/run/) command.|
| environmentVariables | `"environmentVariables":` `{`<br/>   `"ASPNETCORE_URLS": "https://+:443;http://+:80"``, <br/>   `"ASPNETCORE_HTTPS_PORT": "44381"`` <br/> `}`                    | These environment variable values are passed to the process when it's launched in the container.                       |
| httpPort             | `"httpPort": 24051`                                     | This port on the host is mapped to the container's port 80 when launching the container. |
| launchBrowser        | `"launchBrowser": true`                                 | Indicates whether to launch the browser after successfully launching the project.                                       |
| launchBrowserTimeout | `"launchBrowserTimeout": 1`                             | The maximum amount of time (in seconds) to wait for the app to be ready before launching the browser. |
| launchUrl            | `"launchUrl": "{Scheme}://{ServiceHost}:{ServicePort}"` | This URL is used when launching the browser. Supported replacement tokens for this string are: <br/><br/> - `{Scheme}` - Replaced with either `http` or `https` depending on whether SSL is used. <br/><br/> - `{ServiceHost}` - Usually replaced with `localhost`. <br/> When you're targeting Windows containers on Windows 10 RS3 or older, though, it's replaced with the container's IP. <br/><br/> - `{ServicePort}` - Usually replaced with either `sslPort` or `httpPort`, depending on whether SSL is used. <br/> When you're targeting Windows containers on Windows 10 RS3 or older, though, it's replaced with either `443` or `80`, depending on whether SSL is used. |
| sslPort              | `"sslPort": 44381`                                      | This port on the host is mapped to the container's port 443 when launching the container. |
| useSSL               | `"useSSL": true`                                        | Indicates whether to use SSL when launching the project. If `useSSL` isn't specified, then SSL is used when `sslPort > 0`. |

> [!NOTE]
> If the same settings, for example, `DockerfileRunArguments`, is found in both the project file and in the launch settings file, the value in the launch settings file takes precedence.

::: moniker-end

::: moniker range=">=vs-2022"

| Setting name         | Example                                               | Description                                                                                                             |
| -------------------- | ----------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- |
| commandLineArgs      | `"commandLineArgs": "--mysetting myvalue"`              | These command-line arguments for starting your app are used when launching your project in the container.                                     |
| containerRunArguments|`"containerRunArguments": "-l mylabel=value"`|Like `dockerfileRunArguments`, but for use with the .NET SDK container build type. |
|DockerfileRunArguments|`dockerfileRunArguments": "-l mylabel=value"`|Additional arguments to pass to the [`docker run`](https://docs.docker.com/engine/reference/commandline/run/) command. <br>/<br/> This setting only applies to projects that use the Dockerfile container build type. <br/><br/> In Visual Studio 17.3 and later, you can use the following replacement tokens added:<br/><br/> - `{ProjectDir}` - Full path to the project directory. <br/><br/> - `{OutDir}` - The value of the MSBuild property OutDir.|
| environmentVariables | `"environmentVariables":` {<br/>   `"ASPNETCORE_URLS": "https://+:443;http://+:80"`, <br/>   `"ASPNETCORE_HTTPS_PORT": "44381"` <br/> }                    | These environment variable values are passed to the process when it's launched in the container.                       |
| httpPort             | `"httpPort": 24051`                                     | This port on the host is mapped to the container's port 80 when launching the container. |
| launchBrowser        | `"launchBrowser": true`                                 | Indicates whether to launch the browser after successfully launching the project.                                       |
| launchBrowserTimeout | `"launchBrowserTimeout": 1`                            | The maximum amount of time (in seconds) to wait for the app to be ready before launching the browser. |
| launchUrl            | `"launchUrl": "{Scheme}://{ServiceHost}:{ServicePort}"` | This URL is used when launching the browser. Supported replacement tokens for this string are: <br/><br/> - `{Scheme}` - Replaced with either `http` or `https`, depending on whether SSL is used. <br/><br/> - `{ServiceHost}` - Usually replaced with `localhost`. <br/> When you're targeting Windows containers on Windows 10 RS3 or older, though, it's replaced with the container's IP. <br/><br/> - `{ServicePort}` - Usually replaced with either sslPort or httpPort, depending on whether SSL is used. <br/> When you're targeting Windows containers on Windows 10 RS3 or older, though, it's replaced with either `443` or `80`, depending on whether SSL is used. |
| publishAllPorts      | `"publishAllPorts": true`                                 | If true, pass `-P` to `docker run`, which publishes all exposed ports to a random port. See [Docker documentation](https://docs.docker.com/engine/reference/commandline/run/). However, when you specify `sslPort`, Visual Studio still passes `-p 5002:443`, so your service should still be listening on port 5002.|
| sslPort              | `"sslPort": 44381`                                      | This port on the host is mapped to the container's port 443 when launching the container. |
| useSSL               | `"useSSL": true`                                        | Indicates whether to use SSL when launching the project. If `useSSL` isn't specified, then SSL is used when `sslPort > 0`. |

> [!NOTE]
> If the same settings, for example, `DockerfileRunArguments`, is found in both the project file and in the launch settings file, the value in the launch settings file takes precedence.

::: moniker-end

## Next steps

Configure your project by setting the [Container Tools build properties](container-msbuild-properties.md).

## See also

- [Docker Compose build properties](docker-compose-properties.md)
- [Manage launch profiles for Docker Compose](launch-profiles.md)
