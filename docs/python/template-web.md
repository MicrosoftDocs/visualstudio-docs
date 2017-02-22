---
title: "Web Project Template in the Python Tools for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "2/14/2017"
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

# Python Web Project Template

Python Tools for Visual Studio (PTVS) includes support for developing web projects in frameworks such as Bottle, Django, and Flask. This includes project templates and a debug launcher that can be configured to handle various frameworks. PTVS does not include the frameworks themselves, however, which you must install separately by right-clicking the project and selecting **Python > Install/upgrade framework...**.

For a three minute introduction to Python web projects, see this video:

[![Getting Started Part 6: Web sites](VideoThumbnails/GettingStarted06Small.png)](https://youtu.be/FJx5mutt1uk?list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff)

## Templates

These templates can be found in the New Project dialog.

Each templates is preconfigured to launch as a web server with an randomly selected local port, to open your default browser when debugging, and to allow direct publishing to [Microsoft Azure](http://www.azure.com).
These features are also available in the generic "Web Project" template, which can be used for other frameworks, such as Pyramid.

Other than Web Project (and the Blank templates that are not shown), each template includes a starter site with some pages and static files.
This code is sufficient to run and debug the server locally (where some settings need to be obtained from the environment) and also to deploy to Microsoft Azure (where a [WSGI app](http://www.python.org/dev/peps/pep-3333/) object needs to be provided).

![New Web Project templates](Images/NewProjectWeb.png)


When you create one of these projects, one or more external packages are required.
This dialog will appear to help you install these packages using pip.
We recommend using a [virtual environment](Python-Environments#virtual-environments) for web projects, as this will ensure that the correct dependencies are included when you publish your web site.

When deploying to Microsoft Azure App Service, you will need select a version of Python as a [site extension](https://aka.ms/PythonOnAppService) and manually install packages.
Azure App Service **does not** automatically install packages from a `requirements.txt` file when deployed from Visual Studio.
The page at [aka.ms/PythonOnAppService](https://aka.ms/PythonOnAppService) explains how to configure your web site.
Microsoft Azure Cloud Service does support the `requirements.txt` file.
See the [Cloud Project](Cloud-Project) documentation for more information on publishing to Cloud Service.

![Requirements.txt wizard](Images/RequirementsTxtWizard.png)


Debugging
---------

Web projects can be started for debugging by clicking the Play button on the toolbar

### Configuring local debugging

The Web launcher provides the functionality to start the web server and open your browser.
The generic template is configured to use the Web launcher, but some options are unspecified.

![Web launcher properties](Images/WebLauncherProperties.png)

The first four properties in the **Debug** group are the same as for [normal debugging](Debugging).
"Launch URL" specifies the URL that will be opened in your browser.
If no port number is specified in this URL, the port in "Port Number" will be used.
"Port Number" allow you to override the default value of the `SERVER_PORT` environment variable, which is used by the templates to configure the port the local debug server listens on.
By default, "Launch URL" is `localhost` and "Port Number" is automatically selected on each launch.

The properties in the **Run Server Command** group and **Debug Server Command** group (not shown in the image) determine how the web server is launched.
Since many frameworks require the use of a script outside of the current project, the script can be configured here and the name of the startup module can be passed as a parameter.
"Command" can be a Python script (`*.py` file), a module name (as in, `python.exe -m module_name`), or a single line of code (as in, `python.exe -c "code"`).
The value in the dropdown indicates which of these types is intended.

"Arguments" are passed on the command line following the command.
Any project property or environment variable can be specified with MSBuild syntax, for example: `$(StartupFile) --port $(SERVER_PORT)`.
`$(StartupFile)` is the relative path to the startup file and `{StartupModule}` is the importable name of the startup file.
`$(SERVER_HOST)` and `$(SERVER_PORT)` are normal environment variables that are set by the "Launch URL" and "Port Number" properties, automatically, or by the "Environment" property.

The "Environment" property is a newline-separated list of `NAME=VALUE` pairs specifying environment variables.
These are set after all properties that may modify the environment, such as "Port Number" and search paths, and so may overwrite these values.

The values in the **Debug Server Command** group are used when starting with F5 or the "Start Debug Server" command.
Values in **Run Server Command** are used when starting with Ctrl+F5 or the "Start Server" command.

### Sample Configurations

These are some examples of the configuration settings used for various frameworks.

#### Bottle

When creating a Bottle app from the Bottle Web Project template, boilerplate code is included to avoid needing any configuration.
However, an imported bottle app may not include this code.
These settings will launch the app using the installed `bottle` module.

**Run Server**

* Command: `bottle` (module)
* Arguments: `--bind=%SERVER_HOST%:%SERVER_PORT% {StartupModule}:app`

**Debug Server**

* Command: `bottle` (module)
* Arguments: `--debug --bind=%SERVER_HOST%:%SERVER_PORT% {StartupModule}:app`

(The `--reload` option is not recommended when using PTVS for debugging.)

#### Pyramid

Pyramid apps are currently best created using the `pcreate` command-line tool.
However, once an app has been created, it can be imported using New Project from Existing Code.
Selecting the "Generic Web Project" customization will allow you to configure these options after importing.
Remember that you will likely need to configure the Working Directory property of your project as well, since Pyramid apps are typically one directory level deeper than the top of the source tree.

These settings assume that Pyramid is installed into a virtual environment at "..\env".

**Debug Properties**

* Server Port: 6543 (or whatever is configured in the .ini files)

**Run Server**

* Command: `..\env\scripts\pserve-script.py` (script)
* Arguments: `Production.ini`

**Debug Server**

* Command: `..\env\scripts\pserve-script.py` (script)
* Arguments: `Development.ini`

#### Others

If you have settings for another framework that you would like to share, or if you'd like to request settings for another framework, visit our [issue tracker](https://github.com/Microsoft/PTVS/issues) and start a post.

Publishing to Microsoft Azure App Service
-----------------------------------------

There are two primary ways to publish to Azure App Service.
Deployment from source control can be used in the same way as for other languages.
See the [Azure documentation](http://azure.microsoft.com/en-us/documentation/articles/web-sites-publish-source-control/) for information on source control deployment.

To publish from within Visual Studio, use the Publish command in the project menu:

![Publish command](Images/WebPublishMenu.png)

After selecting the command, a wizard will walk you through creating a web site or importing publish settings, previewing modified files, and publishing to a remote server.

When you create a site on App Service, you will need to install Python and any packages your site depends upon.
You can publish your site first, but it will not run until you have configured Python.

To install Python on App Service, we recommend using the [site extensions](http://www.siteextensions.net/packages?q=Tags%3A%22python%22).
The Python site extensions are copies of the [official releases](https://www.python.org) of Python, optimized and repackaged for Azure App Service.

A site extension can be deployed through the [Azure Portal](https://portal.azure.com/) on the blade for your web app:

![Add Site Extension](Images/SiteExtensions.png)

If you are using JSON deployment templates, you can specify the site extension as a resource of your site:

```json
{
  "resources": [
    {
      "apiVersion": "2015-08-01",
      "name": "[parameters('siteName')]",
      "type": "Microsoft.Web/sites",
      ...
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
```

Finally, you can log in through the [development console](https://github.com/projectkudu/kudu/wiki/Kudu-console) and install a site extension from there.

Currently, the recommended way to install packages is to use the development console after installing the site extension and executing pip directly.
Using the full path to Python is important, or you may execute the wrong one, and there is generally no need to use a virtual environment.

```
D:\home\Python35\python.exe -m pip install -r D:\home\site\wwwroot\requirements.txt
D:\home\Python27\python.exe -m pip install -r D:\home\site\wwwroot\requirements.txt
```

When deployed to Azure App Service, your site will run behind Microsoft IIS.
To enable your site to work with IIS, you will need to add at least a `web.config` file.
There are templates available for some common deployment targets, and these can be easily modified for other uses.
See the [IIS Configuration Reference](https://www.iis.net/configreference) for information about the available configuration setings.

![Azure Item Templates](Images/AzureItemTemplates.png)

* Azure web.config (FastCGI)
 *Adds a `web.config` file for when your app provides a [WSGI](https://wsgi.readthedocs.io/en/latest/) object to handle incoming connections.
* Azure web.config (HttpPlatformHandler)
 * Adds a `web.config` file for when your app listens on a socket for incoming connections.
* Azure Static files web.config
 * When you have one of the above `web.config` files, add this to a subdirectory to exclude it from being handled by your app.
* Azure Remote debugging web.config
 * Adds the files necessary for remote debugging over WebSockets.
* Web Role Support Files
 * Contains the default deployment scripts for Cloud Service web roles.
* Worker Role Support Files
 * Contains the default deployment and launch scripts for Cloud Service worker roles.

If you add the debugging `web.config` template to your project and plan to use Python remote debugging, you will need to publish the site in "Debug" configuration.
This setting is separate from the current active solution configuration, and always defaults to "Release". To change it, open the "Settings" tab, and use the "Configuration" combo box in the publish wizard:

![Changing the publish configuration](Images/WebPublishConfig.png)

See the [documentation on Azure.com](https://azure.microsoft.com/develop/python/) for more information on creating and deploying to Azure Web Apps.

![Convert to Microsoft Azure Cloud Service Project command](Images/WebConvertMenu.png)

The "Convert to Microsoft Azure Cloud Service Project" command will add a Cloud Service project to your solution.
This project includes the deployment settings and configuration for the virtual machines and services to be used.
You should use the Publish command on the cloud project to deploy to Cloud Service; the Publish command on the Python project will still deploy to Web Sites.

See our [Cloud Service Projects](Cloud-Project) page for more information on Microsoft Azure Cloud Service.

### Tutorials

For a walkthrough of creating and deploying a Django website using Visual Studio, see this video.

[![Deep Dive: Creating a Django Website](VideoThumbnails/DjangoAndAzure.png)](https://youtu.be/WG3pGmoo8nE)

See the following tutorials for examples of using Python to create web applications for Microsoft Azure.

 * [Bottle and Azure Table Storage on Azure](Bottle-and-Azure-Table-Storage-on-Azure)
 * [Bottle and MongoDB on Azure](Bottle-and-MongoDB-on-Azure)
 * [Flask and Azure Table Storage on Azure](Flask-and-Azure-Table-Storage-on-Azure)
 * [Flask and MongoDB on Azure](Flask-and-MongoDB-on-Azure)
 * [Django and SQL Database on Azure](Django-and-SQL-Database-on-Azure)
 * [Django and MySQL on Azure](Django-and-MySQL-on-Azure)
