---
title: Configure Python web apps for IIS
description: How to configure Python web apps to run with Internet Information Services from a Windows virtual machine.
ms.date: 05/09/2022
ms.topic: how-to
author: rjmolyneaux
ms.author: rmolyneaux
manager: jmartens
ms.technology: vs-python

ms.workload:
  - python
  - data-science
  - azure
---
# Configure Python web apps for IIS

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

When using Internet Information Services (IIS) as a web server on a Windows computer (including [Windows virtual machines on Azure](/azure/architecture/reference-architectures/n-tier/windows-vm)), Python apps must include specific settings in their *web.config* files so that IIS can properly process Python code. The computer itself must also have Python installed along with any packages the web app requires.

> [!Note]
> The previous article, is still available on [Managing App Service on Windows with the Python extensions](managing-python-on-azure-app-service.md).

## Install Python on Windows

To run a web app, first install your required version of Python directly on the Windows host machine as described on [Install Python interpreters](installing-python-interpreters.md).

Record the location of the `python.exe` interpreter for later steps. For convenience, you can add that location to your PATH environment variable.

## Install packages

When using a dedicated host, you can use the global Python environment to run your app rather than a virtual environment. Accordingly, you can install all of your app's requirements into the global environment simply by running `pip install -r requirements.txt` at a command prompt.

## Set web.config to point to the Python interpreter

Your app's *web.config* file instructs the IIS (7+) web server running on Windows about how it should handle Python requests through either HttpPlatform (recommended) or FastCGI. Visual Studio versions 2015 and earlier make these modifications automatically. When using Visual Studio 2017 and later, you must modify *web.config* manually.

### Configure the HttpPlatform handler

The HttpPlatform module passes socket connections directly to a standalone Python process. This pass-through allows you to run any web server you like, but requires a startup script that runs a local web server. You specify the script in the `<httpPlatform>` element of *web.config*, where the `processPath` attribute points to the site extension's Python interpreter and the `arguments` attribute points to your script and any arguments you want to provide:

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <system.webServer>
    <handlers>
      <add name="PythonHandler" path="*" verb="*" modules="httpPlatformHandler" resourceType="Unspecified"/>
    </handlers>
    <httpPlatform processPath="c:\python36-32\python.exe"
                  arguments="c:\home\site\wwwroot\runserver.py --port %HTTP_PLATFORM_PORT%"
                  stdoutLogEnabled="true"
                  stdoutLogFile="c:\home\LogFiles\python.log"
                  startupTimeLimit="60"
                  processesPerApplication="16">
      <environmentVariables>
        <environmentVariable name="SERVER_PORT" value="%HTTP_PLATFORM_PORT%" />
      </environmentVariables>
    </httpPlatform>
  </system.webServer>
</configuration>
```

The `HTTP_PLATFORM_PORT` environment variable shown here contains the port that your local server should listen on for connections from localhost. This example also shows how to create another environment variable, if desired, in this case `SERVER_PORT`.

## Deploy to IIS or a Windows VM

With the correct *web.config* file in your project, you can publish to the computer running IIS by using the **Publish** command on the project's context menu in **Solution Explorer**, and selecting the option, **IIS, FTP, etc.**. In this case, Visual Studio simply copies the project files to the server; you're responsible for all server-side configuration.
