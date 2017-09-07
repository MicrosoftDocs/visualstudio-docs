---
title: "Managing Python on Azure App Service | Microsoft Docs"
ms.custom: ""
ms.date: 9/6/2017
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "devlang-python"
ms.devlang: python
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: e56b5d55-6e6b-48af-af40-5172c768cabc
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
---

# Managing Python on Azure App Service

[Azure App Service](https://azure.microsoft.com/services/app-service/) is a platform-as-a-service offering for web apps, whether they are sites accessed through a browser, REST APIs used by your own clients, or event-triggered processing. App Service fully supports using Python to implement apps.

Python support on Azure App Service is provided as a set of App Service site extensions that each contain a specific version of the Python runtime. The latest Python 3 version is recommended, obviously, but you can choose an older version when necessary. This topic explains how to install and configure a site extension along with any desired packages.

> [!Note]
> The processes described here are subject to change, and especially to improvement. Changes are announced on the [Python Engineering at Microsoft blog](https://blogs.msdn.microsoft.com/pythonengineering/).

## Choosing a Python version through the Azure portal

If your site is already deployed and running on Azure App Service, navigate to your App Service in the Azure portal, scroll to the **Development Tools** section, and select **Extensions > Add**. Scroll through the list to find the specific extensions for the version of Python you want:

![Azure portal showing Python extensions](media/python-on-azure-extensions.png)

## Choosing a Python version through the Azure Resource Manager

If you are deploying your site with an Azure Resource Manager template, add the site extension as a resource. The extension appears as a nested resource of your site with the type `siteextensions` and the name from [siteextensions.net](https://www.siteextensions.net/packages?q=Tags%3A%22python%22).

For example, after adding a reference to `python361x64` (Python 3.6.1 x64), your template may look like the following:

```json
  "resources": [
    {
      "apiVersion": "2015-08-01",
      "name": "[parameters('siteName')]",
      "type": "Microsoft.Web/sites",
      ...
      "resources": [
        {
          "apiVersion": "2015-08-01",
          "name": "python361x64",
          "type": "siteextensions",
          "properties": { },
          "dependsOn": [
            "[resourceId('Microsoft.Web/sites', parameters('siteName'))]"
          ]
        },
      ...
```

## Configuring your site

After installing the site extension (through either the portal or an Azure Resource Manager template), the Python installation path will be something like `d:\home\python361x64\python.exe`. To see the specific path, select the extension in the list shown for your App Service to open its description page containing the path:

![Extension list on Azure App Service](media/python-on-azure-extension-list.png)

![Extension details on Azure App Service](media/python-on-azure-extension-detail.png)

If you have trouble seeing the path for the extension, you can find it manually using the console:

1. In your App Service on the Azure portal, select the **Development Tools > Console**.
2. Enter the command `ls ../home` to see the top-level extensions folders, such as `Python361x64`.
3. Enter a command like `ls ../home/python361x64` using one of the Python folders to verify that it contains `python.exe` and other interpreter files.

Note that the full path to `python.exe` is important in the next step, which is to reference that path in the site's `web.config` file for either the FastCGI and Http Platform request handlers.

### Using the FastCGI handler

FastCGI is an interface that works at the request level. IIS receives incoming connections and forwards each request to a WSGI app running in one or more persistent Python processes. The [wfastcgi package](https://pypi.io/project/wfastcgi) is pre-installed and configured with each Python site extension, so you can easily enable it by including the following code in `web.config`:

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <appSettings>
    <add key="PYTHONPATH" value="D:\home\site\wwwroot"/>
    <add key="WSGI_HANDLER" value="app.wsgi_app"/>
    <add key="WSGI_LOG" value="D:\home\LogFiles\wfastcgi.log"/>
  </appSettings>
  <system.webServer>
    <handlers>
      <add name="PythonHandler" path="*" verb="*" modules="FastCgiModule" scriptProcessor="D:\home\Python361x64\python.exe|D:\home\Python361x64\wfastcgi.py" resourceType="Unspecified" requireAccess="Script"/>
    </handlers>
  </system.webServer>
</configuration>
```

The `<appSettings>` are available to your app as environment variables:
- The value for `PYTHONPATH` may be freely extended but must include the root of your site.
- `WSGI_HANDLER` must point to a WSGI app importable from your site.
- `WSGI_LOG` is optional but recommended for debugging your site. 

Under `<handlers>`, make sure the `scriptProcessor` attribute in the `<add>` element contains the proper paths to your specific installation. The path is again shown on the extension's details.

### Using the Http Platform handler

The HttpPlatform module passes the socket connections directly to a standalone Python process. This pass-through allows you to run any web server you like, but requires a startup script that runs a local web server. You specify the script in the `<httpPlatform>` element of `web.config`, where the `processPath` attribute points to Python and the `arguments` attribute points to your script and any arguments you want to provide:

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <system.webServer>
    <handlers>
      <add name="PythonHandler" path="*" verb="*" modules="httpPlatformHandler" resourceType="Unspecified"/>
    </handlers>
    <httpPlatform processPath="D:\home\Python361x64\python.exe"
                  arguments="D:\home\site\wwwroot\runserver.py --port %HTTP_PLATFORM_PORT%"
                  stdoutLogEnabled="true"
                  stdoutLogFile="D:\home\LogFiles\python.log"
                  startupTimeLimit="60"
                  processesPerApplication="16">
      <environmentVariables>
        <environmentVariable name="SERVER_PORT" value="%HTTP_PLATFORM_PORT%" />
      </environmentVariables>
    </httpPlatform>
  </system.webServer>
</configuration>
```

The path to `python.exe` in your configuration is, of course, specific to the version you installed.

The `HTTP_PLATFORM_PORT` environment variable shown in the code contains the port your local server should listen on for connections from localhost. This example also shows how to create another environment variable, if desired, in this case `SERVER_PORT`.

## Installing packages

The Python interpreter installed through a site extension is only one piece of your Python environment. You likely need to install different packages in that environment as well, which can be done through one of three methods:

- The [Azure App Service Kudu console](#kudu-console).
- The [Kudu REST API](#kudu-rest-api)
- [Copying libraries into app source code](#copying-libraries-into-app-source-code)

### Kudu console

The [Kudu console](https://github.com/projectkudu/kudu/wiki/Kudu-console) gives you direct, elevated command-line access to the App Service server and its file system. In addition to being a valuable debugging tool, it can also be used for CLI-based configurations such as installing packages.

To open Kudu, go to your App Service on the Azure portal, select **Development Tools > Advanced Tools**, then select **Go**. This action navigates to a URL that's the same as your base App Service URL except with `.scm` inserted. For example, if your base URL is `https://vspython-test.azurewebsites.net/` then Kudu is on `https://vspython-test.scm.azurewebsites.net/`:

![The Kudu console for Azure App Service](media/python-on-azure-console01.png)

You can bookmark this URL for future use, fo course.

Select **Debug console > CMD** to open the console, in which you can navigate into your Python installation and see what libraries are already there.

To install a single package:

1. Navigate to the folder of the Python installation where you want to install the package, such as `d:\home\python361x64`.
1. Use `python.exe -m pip install <package_name>` to install a package.

![Example of installing matplotlib through the Kudu console for Azure App Service](media/python-on-azure-console02.png)

If you've deployed a `requirements.txt` for your application to the server already, install all those requirements as follows:

1. Navigate to the folder of the Python installation where you want to install the package, such as `d:\home\python361x64`.
1. Enter the command `python.exe -m pip install --upgrade -r d:\home\site\wwwroot\requirements.txt`.

Using requirements.txt is recommended because it's easy to reproduce your exact package set both locally and on the server. Just remember to visit the console after deploying any changes to `requirements.txt` and run the command again.

> [!Note]
> There's no C compiler on your web server, so you need to install the wheel for any packages with native extension modules. Many popular packages provide their own wheels. For packages that don't, use `pip wheel <package_name>` on your local development computer and then upload the wheel to your site. For an example, see [Managing required packages](python-environments.md#managing-required-packages)

### Kudu REST API

Instead of using the Kudu console through the Azure portal, you can run commands remotely through the Kudu REST API by posting the command to `https://yoursite.scm.azurewebsites.net/api/command`. For example, to install the `matplotlib` package, post the following JSON to `/api/command`:

```json
{
    "command": 'python.exe -m pip install matplotlib',
    "dir": '\home\python361x64'
}
```

For information about commands and authentication, see the [Kudu documentation](https://github.com/projectkudu/kudu/wiki/REST-API). You can also see credentials using the [`az webapp deployment list-publishing-profiles command`](https://docs.microsoft.com/cli/azure/webapp/deployment#list-publishing-profiles) from the Azure CLI. A helper library for posting Kudu commands is also available on GitHub](https://github.com/lmazuel/azure-webapp-publish/blob/master/azure_webapp_publish/kudu.py#L42).


### Copying libraries into app source code

Instead of installing packages directly on the server, you can instead copy libraries into your own source code and deploy them as if they were part of your app. Depending on how many dependencies you have and how frequently you update them, this method may be the easiest way to get a working deployment going.

The caveat is that these libraries must precisely match the version of Python on the server, otherwise you'll see obscure errors after deployment. However, because the versions of Python in the App Service site extensions are exactly the same as those versions released on python.org, you can easily obtain a compatible version for local development.

### Avoiding virtual environments

Although working in a virtual environment locally can help you fully understand the dependencies needed by your site, using virtual environments on App Service is not recommended. Instead, just install libraries into your main Python folder and deploy them with your app to avoid conflicting dependencies.