---
title: "Web Project Template in Python Tools for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "3/7/2017"
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "devlang-python"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 401e7725-8be5-4e67-862c-bf0690a529e3
caps.latest.revision: 11
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
translation.priority.ht:
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---

# Python Web Project Templates

Python Tools for Visual Studio (PTVS) includes support for developing web projects in frameworks such as Bottle, Django, and Flask. This includes project templates and a debug launcher that can be configured to handle various frameworks. PTVS does not include the frameworks themselves, however, which you must install separately by right-clicking the project and selecting **Python > Install/upgrade framework...**.

Each template (as accessed through **File > New > Project...**) launches a web server with an randomly selected local port, opens your default browser when debugging, and allows direct publishing to [Microsoft Azure](http://www.azure.com). Templates are provided for the Bottle, Flask, and Django, and you can use the generic "Web Project" template for other frameworks such as Pyramid.

![New Web Project templates](media/template-web-new-project.png)

The Bottle, Flask, and Django templates each include a starter site with some pages and static files. This code is sufficient to run and debug the server locally (where some settings need to be obtained from the environment) and to deploy to Microsoft Azure (where a [WSGI app](http://www.python.org/dev/peps/pep-3333/) object needs to be provided).

When creating a project from a framework-specific template, a dialog will appear to help you install the necessary packages using pip. We also recommend using a [virtual environment](python-environments.md#virtual-environments) for web projects so that the correct dependencies are included when you publish your web site:

![Dialog that installs needed packages for a project template](media/template-web-requirements-txt-wizard.png)

When deploying to Microsoft Azure App Service, you'll need to select a version of Python as a [site extension](https://aka.ms/PythonOnAppService) and manually install packages. Also, because Azure App Service does **not** automatically install packages from a `requirements.txt` file when deployed from Visual Studio, follow the configuration details on [aka.ms/PythonOnAppService](https://aka.ms/PythonOnAppService).

Microsoft Azure Cloud Service, on the other hand, does support the `requirements.txt` file. [Azure Cloud Service Projects](template-azure-cloud-service.md) for details.

For an introduction to Python web projects, see [Getting Started with PTVS, Part 6: Web sites](https://youtu.be/FJx5mutt1uk?list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff) (youtube.com, 3m10s).

> [!VIDEO https://www.youtube.com/embed/FJx5mutt1uk]

## Debugging

When a web project is started for debugging, PTVS will start the web server locally and open your default browser to that address and port. TO specify additional options, right-click the project, select **Properties**, and select the **Web Launcher** tab:

  ![Web launcher properties for the generic web template](media/template-web-launcher-properties.png)

In the **Debug** group:

- **Search Paths**, **Script Arguments**, **Interpreter Arguments**, and **Interpreter Path**: these are the same as for [normal debugging](debugging.md)
- **Launch URL**: specifies the URL that will be opened in your browser. It defaults to `localhost`.
- **Port Number**: the port to use if none is specified in the URL (PTVS selects one automatically by default). This allows you to override the default value of the `SERVER_PORT` environment variable, which is used by the templates to configure the port the local debug server listens on.

The properties in the **Run Server Command** and **Debug Server Command** groups (the latter is below what's show in the image) determine how the web server is launched. Because many frameworks require the use of a script outside of the current project, the script can be configured here and the name of the startup module can be passed as a parameter.

- **Command**: can be a Python script (`*.py` file), a module name (as in, `python.exe -m module_name`), or a single line of code (as in, `python.exe -c "code"`). The value in the dropdown indicates which of these types is intended.
- **Arguments**: these are passed on the command line following the command.
- **Environment**: a newline-separated list of `NAME=VALUE` pairs specifying environment variables. These are set after all properties that may modify the environment, such as the port number and search paths, and so may overwrite these values.

Any project property or environment variable can be specified with MSBuild syntax, for example: `$(StartupFile) --port $(SERVER_PORT)`.
`$(StartupFile)` is the relative path to the startup file and `{StartupModule}` is the importable name of the startup file. `$(SERVER_HOST)` and `$(SERVER_PORT)` are normal environment variables that are set by the **Launch URL** and **Port Number** properties, automatically, or by the **Environment** property.

> [!Note]
> Values in **Run Server Command** are used with the **Debug > Start Server** command or Ctrl-F5; values in the **Debug Server Command** group are used with the **Debug > Start Debug Server** command or F5.


### Sample Bottle configuration

The Bottle Web Project template includes boilerplate code that does the necessary configuration. An imported bottle app may not include this code, however, in which case the following settings launch the app using the installed `bottle` module:

- **Run Server Command** group:
    - **Command**: `bottle` (module)
    - **Arguments**: `--bind=%SERVER_HOST%:%SERVER_PORT% {StartupModule}:app`

- **Debug Server Command** group:
    - **Command**: `bottle` (module)
    - **Arguments** `--debug --bind=%SERVER_HOST%:%SERVER_PORT% {StartupModule}:app`

The `--reload` option is not recommended when using PTVS for debugging.

### Sample Pyramid configuration

Pyramid apps are currently best created using the `pcreate` command-line tool. Once an app has been created, it can be imported using the [From Existing Python Code](python-projects.md#creating-a-project-from-existing-files) template. After this, select the **Generic Web Project** customization to configure the options. These settings assume that Pyramid is installed into a virtual environment at `..\env`.

- **Debug** group:
    - **Server Port**: 6543 (or whatever is configured in the .ini files)

- **Run Server Command** group:
    - Command: `..\env\scripts\pserve-script.py` (script)
    - Arguments: `Production.ini`

- **Debug Server Command** group:
    - Command: `..\env\scripts\pserve-script.py` (script)
    - Arguments: `Development.ini`

> [!Tip]
> You'll likely need to configure the **Working Directory** property of your project because Pyramid apps are typically one directory level deeper than the top of the source tree.


### Other configurations

If you have settings for another framework that you would like to share, or if you'd like to request settings for another framework, please open an [issue on GitHub](https://github.com/Microsoft/PTVS/issues).

## Publishing to Azure App Service

There are two primary ways to publish to Azure App Service. First, deployment from source control can be used in the same way as for other languages, as described in the [Azure documentation](http://azure.microsoft.com/en-us/documentation/articles/web-sites-publish-source-control/). To publish direct from Visual Studio, right-click the project and select **Publish**:

![Publish command on a project's context menu](media/template-web-publish-command.png)

After selecting the command, a wizard walks you through creating a web site or importing publish settings, previewing modified files, and publishing to a remote server.

When you create a site on App Service, you will need to install Python and any packages your site depends upon. You can publish your site first, but it will not run until you have configured Python.

To install Python on App Service, we recommend using the [site extensions](http://www.siteextensions.net/packages?q=Tags%3A%22python%22) (siteextensions.net). These are copies of the [official releases](https://www.python.org) of Python, optimized and repackaged for Azure App Service.

A site extension can be deployed through the [Azure Portal](https://portal.azure.com/) using the **Development Tools > Extensions** blade for your App Service, selecting **Add**, and scrolling the list to find those for Python:

![Add Site Extension on the Azure portal](media/template-web-site-extensions.png)

If you are using JSON deployment templates, you can specify the site extension as a resource of your site:

```json
{
    "resources": [
    {
        "apiVersion": "2015-08-01",
        "name": "[parameters('siteName')]",
        "type": "Microsoft.Web/sites",
        ...
    },
    "resources": [
    {
        "apiVersion": "2015-08-01",
        "name": "python352x64",
        "type": "siteextensions",
        "properties": { },
        "dependsOn": [
            "[resourceId('Microsoft.Web/sites', parameters('siteName'))]"
        ]
    },
    ...
}
```

Finally, you can log in through the [development console](https://github.com/projectkudu/kudu/wiki/Kudu-console) and install a site extension from there.

Currently, the recommended way to install packages is to use the development console after installing the site extension and executing pip directly. Using the full path to Python is important, or you may execute the wrong one, and there is generally no need to use a virtual environment. For example:

```
c:\Python35\python.exe -m pip install -r D:\home\site\wwwroot\requirements.txt

c:\Python27\python.exe -m pip install -r D:\home\site\wwwroot\requirements.txt
```

When deployed to Azure App Service, your site will run behind Microsoft IIS. To enable your site to work with IIS, you will need to add at least a `web.config` file. There are templates available for some common deployment targets available by right-clicking the project and selecting **Add > New Item..." (see dialog below), and these can be easily modified for other uses. See the [IIS Configuration Reference](https://www.iis.net/configreference) for information about the available configuration setings.

![Azure Item Templates](media/template-web-azure-items.png)

The available items include:

- Azure web.config (FastCGI): adds a `web.config` file for when your app provides a [WSGI](https://wsgi.readthedocs.io/en/latest/) object to handle incoming connections.
- Azure web.config (HttpPlatformHandler): adds a `web.config` file for when your app listens on a socket for incoming connections.
- Azure Static files web.config: when you have one of the above `web.config` files, add this to a subdirectory to exclude it from being handled by your app.
- Azure Remote debugging web.config: adds the files necessary for remote debugging over WebSockets.
- Web Role Support Files: contains the default deployment scripts for Cloud Service web roles.
- Worker Role Support Files: contains the default deployment and launch scripts for Cloud Service worker roles.

If you add the debugging `web.config` template to your project and plan to use Python remote debugging, you will need to publish the site in "Debug" configuration. This setting is separate from the current active solution configuration and always defaults to "Release". To change it, open the **Settings** tab and use the **Configuration** combo box in the publish wizard (see the [Azure documentation](https://azure.microsoft.com/develop/python/) for more information on creating and deploying to Azure Web Apps):

![Changing the publish configuration](media/template-web-publish-config.png)

The **Convert to Microsoft Azure Cloud Service Project** command (image below) will add a Cloud Service project to your solution. This project includes the deployment settings and configuration for the virtual machines and services to be used. You should use the **Publish** command on the cloud project to deploy to Cloud Service; the **Publish** command on the Python project will still deploy to Web Sites. See [Azure Cloud Service Projects](template-azure-cloud-service.md) for more details.

![Convert to Microsoft Azure Cloud Service Project command](media/template-web-convert-menu.png)
