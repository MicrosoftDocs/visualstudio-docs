---
title: Configure Python Web Apps for IIS
description: Configure Python web apps to run with Internet Information Services (IIS) from a Windows virtual machine by specifying settings in their web.config files. 
ms.date: 07/28/2025
ms.topic: how-to
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

#customer intent: As a developer, I want to use web.config file settings so that I can configure Python web apps in Visual Studio to run with IIS from a Windows virtual machine.
---

# Configure Python web apps for IIS

When you use Internet Information Services (IIS) as a web server on a Windows computer (including [Windows virtual machines on Azure](/azure/architecture/reference-architectures/n-tier/windows-vm)), you need to configure the Python web application to enable IIS to properly process Python code. The configuration is accomplished through settings in the *web.config* file for the Python web app. This article describes how to configure the necessary settings.

## Prerequisites

- Python on Windows installed. To run a web app, first install your required version of Python directly on the Windows host machine as described in [Install Python interpreters](installing-python-interpreters.md).

  - Identify the location of the *python.exe* interpreter. For convenience, you can add that location to your PATH environment variable.

- Required packages installed. For a dedicated host, you can use the global Python environment to run your app rather than a virtual environment. Accordingly, you can install all of your app's requirements into the global environment by running the `pip install -r requirements.txt` command.

## Set web.config to point to the Python interpreter

The *web.config* file for your Python application instructs the IIS web server (version 7 or later) running on Windows about how it should handle Python requests through HttpPlatformHandler (recommended) or FastCGI. Visual Studio versions 2015 and earlier make these modifications automatically. For Visual Studio 2017 and later, you must modify the *web.config* file manually.

If your project doesn't already contain a *web.config* file, you can add one by right-clicking the project directory, selecting **Add > New Item** and searching for *web.config* or creating a blank *web.config* XML file.

### Option 1: Configure the HttpPlatformHandler

The HttpPlatform module passes socket connections directly to a standalone Python process. This pass-through allows you to run any web server you like, but it requires a startup script that runs a local web server. This approach is commonly done by using a Python web framework, such as Flask or Django. You specify the script in the `<httpPlatform>` element of the *web.config* file. The `processPath` attribute points to the site extension's Python interpreter. The `arguments` attribute points to your startup script that runs a local web server, in this case *runserver.py*, and any arguments you want to provide:

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

In this example, the `HTTP_PLATFORM_PORT` environment variable contains the port that your local server should listen on for connections from `localhost`. This example also shows how to create another environment variable, `SERVER_PORT`. You can create and assign environment variables as needed.

### Option 2: Configure the FastCGI handler

Alternatively, you can use FastCGI to configure your apps. FastCGI is an interface that works at the request level. IIS receives incoming connections and forwards each request to a Web Server Gateway Interface (WSGI) app running in one or more persistent Python processes.

> [!NOTE]
> Although you can set up your project using FastCGI, we recommend using **HttpPlatformHandler** to configure your apps because the [WFastCGI](https://pypi.org/project/wfastcgi/) project is no longer maintained and might result in bugs. 

To use FastCGI, first install and configure the wfastcgi package as described in [pypi.org/project/wfastcgi/](https://pypi.io/project/wfastcgi).

Next, modify your application's *web.config* file to include the full paths to the *python.exe* executable and the *wfastcgi.py* file in the `PythonHandler` key. The following steps assume Python is installed in the *c:\python36-32* folder and the app code is in the *c:\home\site\wwwroot* folder. Adjust these values for your paths accordingly.

1. Modify the `PythonHandler` entry in the *web.config* file so the path matches the Python install location. For more information, see [IIS Configuration Reference on iis.net](https://www.iis.net/configreference).

   ```xml
   <system.webServer>
      <handlers>
        <add name="PythonHandler" path="*" verb="*" modules="FastCgiModule"
            scriptProcessor="c:\python36-32\python.exe|c:\python36-32\wfastcgi.py"
            resourceType="Unspecified" requireAccess="Script"/>
      </handlers>
   </system.webServer>
   ```

1. Within the `<appSettings>` section of the *web.config* file, add keys for `WSGI_HANDLER`, `WSGI_LOG` (optional), and `PYTHONPATH`:

   ```xml
   <appSettings>
      <add key="PYTHONPATH" value="c:\home\site\wwwroot"/>
      <!-- The handler here is specific to Bottle; see the next section. -->
      <add key="WSGI_HANDLER" value="app.wsgi_app()"/>
      <add key="WSGI_LOG" value="c:\home\LogFiles\wfastcgi.log"/>
   </appSettings>
   ```

   These `<appSettings>` values are available to your app as environment variables:

   - The value for the `PYTHONPATH` key can be freely extended, but it must include the root of your app.
   - The `WSGI_HANDLER` key must point to a WSGI app importable from your app.
   - The `WSGI_LOG` key is optional, but the key is recommended for debugging your app.

1. Set the `WSGI_HANDLER` entry in the *web.config* file as appropriate for the framework you're using:

   - **Bottle**: Add parentheses after the `app.wsgi_app` value as shown in this example. The parentheses are necessary because the object is a function rather than a variable. You can see the syntax in the *app.py* file.

     ```xml
     <!-- Bottle apps only -->
     <add key="WSGI_HANDLER" value="app.wsgi_app()"/>
     ```

   - **Flask**: Change the `WSGI_HANDLER` value to `<project_name>.app` where `<project_name>` matches the name of your project. You can find the exact identifier by looking at the `from <project_name> import app` statement in the *runserver.py* file. For example, if the project is named *FlaskAzurePublishExample*, the entry appears as follows:

      ```xml
      <!-- Flask apps only: Change the project name to match your app -->
      <add key="WSGI_HANDLER" value="FlaskAzurePublishExample.app"/>
      ```

   - **Django**: Two changes are needed to the *web.config* file for Django projects.

      - Change the `WSGI_HANDLER` value to `django.core.wsgi.get_wsgi_application()`. The object is in the *wsgi.py* file.

         ```xml
         <!-- Django apps only -->
         <add key="WSGI_HANDLER" value="django.core.wsgi.get_wsgi_application()"/>
         ```

      - Add the following entry immediately after the entry for the `WSGI_HANDLER` key. Replace the value `DjangoAzurePublishExample` with the name of your project:

         ```xml
         <add key="DJANGO_SETTINGS_MODULE" value="django_iis_example.settings" />
         ```

1. **Django apps only**: In the Django project's *settings.py* file, add your site URL domain or IP address to the `ALLOWED_HOSTS` entry. Replace '1.2.3.4' with your URL or IP address:

   ```python
   # Change the URL or IP address to your specific site
   ALLOWED_HOSTS = ['1.2.3.4']
   ```

   If you don't add your URL to the array results, you see the following error:

   ```output
   DisallowedHost at / Invalid HTTP_HOST header: '<site URL>'. You might need to add '<site URL>' to ALLOWED_HOSTS.
   ```

  When the array is empty, Django automatically allows `'localhost'` and `'127.0.0.1'` as hosts. If you add your production URL, these host sites aren't automatically allowed. For this reason, you might want to maintain separate development and production copies of the *settings.py* file, or use environment variables to control the runtime values.

## Deploy to IIS or a Windows virtual machine

When you have the correct *web.config* file in your project, you can publish to the computer that's running IIS from **Solution Explorer**. Right-click the project, select **Publish**, and then select **IIS, FTP, etc.**. In this situation, Visual Studio copies only the project files to the server. You're responsible for all server-side configuration.

## Related content

- [IIS Configuration Reference on iis.net](https://www.iis.net/configreference)
- [Install Python interpreters](installing-python-interpreters.md)
- [Run a Windows virtual machine on Azure](/azure/architecture/reference-architectures/n-tier/windows-vm)
