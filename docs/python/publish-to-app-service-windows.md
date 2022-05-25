---
title: Publish a Python app to Azure App Service on Windows
description: How to publish a Python web application directly to Azure App Service on Windows from Visual Studio, including the necessary content for the web.config file.
ms.date: 05/25/2022
ms.topic: how-to
author: rjmolyneaux
ms.author: rmolyneaux
manager: jmartens
ms.technology: vs-python
ms.custom: devdivchpfy22

ms.workload:
  - python
  - data-science
  - azure
---
# Publishing to Azure App Service on Windows

Visual Studio provides the capability to publish a Python web app directly to Azure App Service on Windows. Publishing to Azure App Service on Windows means to copy the necessary files to the server and setting up an appropriate `web.config` file that instructs the web server how to launch your app.
[!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

The publishing process differs between Visual Studio 2015 and later. Specifically, Visual Studio 2015 automates some of the steps, including the creation of `web.config`, but this automation limits long-term flexibility and control. Visual Studio 2017 and later requires more manual steps but provides more exact control over your Python environment. Both options are described here.

> [!Note]
> For background on the changes between Visual Studio 2015 and Visual Studio 2017 and later, see the blog post, [Publish to Azure in Visual Studio 2017](https://devblogs.microsoft.com/python/publish-to-azure-in-vs-2017/).

## Prerequisites

For this walkthrough, you need a web app project based on the Bottle, Flask, or Django frameworks. If you don't yet have a project and would like to try the publishing process, create a simple test project as follows:

1. In Visual Studio, select **File > New > Project**, search for "Bottle", select the **Bottle Web Project**, specify and name and a path for the project, select **OK**. (The Bottle template is included with the Python development workload; see [Installation](installing-python-support-in-visual-studio.md).)

1. Follow the prompts to install external packages, selecting **Install into a virtual environment** and your preferred base interpreter for the virtual environment. You typically match this choice with the version of Python installed on App Service.

1. Test the project locally by pressing F5 or selecting **Debug > Start Debugging**.

## Create an Azure App Service using a subscription

Publishing to Azure requires a target App Service. For this purpose you can create an App Service using an Azure subscription, or you can use a temporary site.

If you don't already have a subscription, start with a [free full Azure account](https://azure.microsoft.com/free/), which includes generous credits for Azure services. Also consider signing up for [Visual Studio Dev Essentials](https://azure.microsoft.com/pricing/member-offers/vs-dev-essentials/), which gives you $200 credit and you’ll have 30 days to use it.

> [!Tip]
> Although Azure asks for a credit card to verify your account, the card is not charged. You can also set a [spending limit](/azure/billing/billing-spending-limit) equal to your free credits to guarantee that no extra charges  occur. In addition, Azure provides a free App Service plan tier that's ideal for simple test apps as described in the next section.

With an active Azure subscription, create an App Service with an empty Web App as follows:

1. Sign in at [portal.azure.com](https://portal.azure.com).
1. Select **+Create a resource**, then select **Web** followed by **Web App**.
1. Specify a name for the web app, leave **Resource Group** to "Create New", and choose **Windows** as the operating system.
1. Select **App service plan/location**, select **Create new**, and specify a name and location. Then select **Pricing tier**, scroll down to and select the **F1 Free** plan, press **Select**, followed by **OK** and then **Create**.
1. (Optional) Once the App Service has been created, navigate to it, select **Get publish profile**, and save the file locally.

## Configure Python on Azure App Service

Once you have an App Service with an empty Web App running (either in your subscription or on a free site), install a chosen version of Python as described [Managing Python on Azure App Service](managing-python-on-azure-app-service.md). For publishing from Visual Studio 2017 and later, record the exact path to the Python interpreter installed with the site extension as described in that article.

If desired, you can also install the `bottle` package using the process in those instructions, as that package is installed as part of other steps in this walkthrough.

## Publish to App Service

Publishing to Azure App Service from Visual Studio 2017 and later copies only the files in your project to the server. It's necessary, therefore, to create the necessary files to configure the server environment.

::: moniker range="<=vs-2019"

1. In Visual Studio **Solution Explorer**, right-click the project and select **Add > New Item...**. In the dialog that appears, selecting the "Azure web.config (Fast CGI)" template and select OK. This creates a `web.config` file in your project root.

1. Modify the `PythonHandler` entry in `web.config` so that the path matches the Python installation on the server (see [IIS Configuration Reference](https://www.iis.net/configreference) (iis.net) for exact details). For example, for Python 3.6.1 x64 the entry should appear as follows:

    ```xml
    <system.webServer>
      <handlers>
        <add name="PythonHandler" path="*" verb="*" modules="FastCgiModule"
            scriptProcessor="D:\home\Python361x64\python.exe|D:\home\Python361x64\wfastcgi.py"
            resourceType="Unspecified" requireAccess="Script"/>
      </handlers>
    </system.webServer>
    ```

1. Set the `WSGI_HANDLER` entry in `web.config` as appropriate for the framework you're using:

    - **Bottle**: add parentheses after `app.wsgi_app` as shown below. This is necessary because that object is a function (see `app.py`) rather than a variable:

        ```xml
        <!-- Bottle apps only -->
        <add key="WSGI_HANDLER" value="app.wsgi_app()"/>
        ```

    - **Flask**: Change the `WSGI_HANDLER` value to `<project_name>.app` where `<project_name>` matches the name of your project. You can find the exact identifer by looking at the `from <project_name> import app` statement in the `runserver.py`. For example, if the project is named "FlaskAzurePublishExample", the entry would appear as follows:

        ```xml
        <!-- Flask apps only: change the project name to match your app -->
        <add key="WSGI_HANDLER" value="FlaskAzurePublishExample.app"/>
        ```

    - **Django**: Two changes are needed to `web.config` for Django projects. First, change the `WSGI_HANDLER` value to `django.core.wsgi.get_wsgi_application()` (the object is in the `wsgi.py` file):

        ```xml
        <!-- Django apps only -->
        <add key="WSGI_HANDLER" value="django.core.wsgi.get_wsgi_application()"/>
        ```

        Second, add the following entry below the one for `WSGI_HANDLER`, replacing `DjangoAzurePublishExample` with the name of your project:

        ```xml
        <add key="DJANGO_SETTINGS_MODULE" value="DjangoAzurePublishExample.settings" />
        ```

1. **Django apps only**: In the Django project's `settings.py` file, add your site URL domain to `ALLOWED_HOSTS` as shown below, replacing 'vspython-test-02.azurewebsites.net' with your URL, of course:

    ```python
    # Change the URL to your specific site
    ALLOWED_HOSTS = ['vspython-test-02.azurewebsites.net']
    ```

    > [!Note]
    >Failure to add your URL to the array results in the error "DisallowedHost at / Invalid HTTP_HOST header: '\<site URL\>'. You may need to add '\<site URL\>' to ALLOWED_HOSTS."

    > [!Note]
    > When the array is empty, Django automatically allows 'localhost', but adding your production URL removes that capabilities. For this reason you might want to maintain separate development and production copies of `settings.py`, or use environment variables to control the run time values.

1. In **Solution Explorer**, expand the folder named the same as your project, right-click the `static` folder, select **Add > New Item...**, select the "Azure static files web.config" template, and select **OK**. This action creates another `web.config` in the `static` folder that disables Python processing for that folder. This configuration sends requests for static files to the default web server rather than using the Python application.

1. Save your project, then in Visual Studio **Solution Explorer**, right-click the project and select **Publish**.
:::image type="content" source="media/template-web-publish-command.png" alt-text="Screenshot showing Publish command on a project's context menu.":::

1. In the **Publish** tab that appears, select the publishing target. Your own Azure subscription: select **Microsoft Azure App Service**, then **Select Existing** followed by **Publish**. A dialog appears in which you can select the appropriate subscription and app service. If the App Service doesn't appear, use the downloaded publishing profile as described next for a temporary App Service.
:::image type="content" source="media/tutorials-common-publish-1a-2017.png" alt-text="Screenshot of Publish to Azure step 1, Visual Studio 2017 and later, existing subscriptions.":::

1. Visual Studio displays publishing status in a "Web Publish Activity" window and the Publish window. Once publishing is complete, the default browser opens on the site URL. The URL is also shown in the Publish window.

1. When the browser opens, you may see the message, "The page cannot be displayed because an internal server error has occurred." This message indicates that your Python environment on the server isn't fully configured, in which case do the following steps:

    a. Refer again to [Managing Python on Azure App Service](managing-python-on-azure-app-service.md), making sure that you have an appropriate Python site extension installed.

    b. Double-check the path to the Python interpreter in your `web.config` file. The path must exactly match the install location of your chosen site extension.

    c. Use the Kudu console to upgrade any packages listed in your app's `requirements.txt` file: navigate to the same Python folder that's used in `web.config`, such as `/home/python361x64`, and run the following command as described in the [Kudu console](managing-python-on-azure-app-service.md#azure-app-service-kudu-console) section:

    ```command
    python -m pip install --upgrade -r /home/site/wwwroot/requirements.txt
    ```

    > [!Tip]
    >If you see permission errors when running this command, double-check that you're running the command in your site extension folder and *not* in the folder of one of App Service's default Python installations. Because you can't modify those default environments, attempting to install packages certainly fails.

    d. For detailed error output, add the following line to `web.config` within the `<system.webServer>` node, which provides more detailed error output:

    ```xml
    <httpErrors errorMode="Detailed"></httpErrors>
    ```

    e. Try restarting the App Service after installing new packages. A restart is not necessary when changing `web.config`, as App Service does an automatic restart whenever `web.config` changes.

    > [!Tip]
    > If you make any changes to your app's `requirements.txt` file, be sure to again use the Kudu console to install any packages that are now listed in that file.

1. Once you've fully configured the server environment, refresh the page in the browser and the web app should appear.
:::image type="content" source="media/azure-publish-results.png" alt-text="Screenshot of Results of publishing Bottle, Flask, and Django apps to App Service.":::
::: moniker-end
::: moniker range=">=vs-2022"

1. In Visual Studio **Solution Explorer**, right-click the project and select **Add > New Item...**. In the dialog that appears, selecting the "Azure web.config (Fast CGI)" template and select OK. This creates a `web.config` file in your project root.

1. Modify the `PythonHandler` entry in `web.config` so that the path matches the Python installation on the server (see [IIS Configuration Reference](https://www.iis.net/configreference) (iis.net) for exact details). For example, for Python 3.6.1 x64 the entry should appear as follows:

    ```xml
    <system.webServer>
      <handlers>
        <add name="PythonHandler" path="*" verb="*" modules="FastCgiModule"
            scriptProcessor="D:\home\Python361x64\python.exe|D:\home\Python361x64\wfastcgi.py"
            resourceType="Unspecified" requireAccess="Script"/>
      </handlers>
    </system.webServer>
    ```

1. Set the `WSGI_HANDLER` entry in `web.config` as appropriate for the framework you're using:

    - **Bottle**: add parentheses after `app.wsgi_app` as shown below. This is necessary because that object is a function (see `app.py`) rather than a variable:

        ```xml
        <!-- Bottle apps only -->
        <add key="WSGI_HANDLER" value="app.wsgi_app()"/>
        ```

    - **Flask**: Change the `WSGI_HANDLER` value to `<project_name>.app` where `<project_name>` matches the name of your project. You can find the exact identifer by looking at the `from <project_name> import app` statement in the `runserver.py`. For example, if the project is named "FlaskAzurePublishExample", the entry would appear as follows:

        ```xml
        <!-- Flask apps only: change the project name to match your app -->
        <add key="WSGI_HANDLER" value="FlaskAzurePublishExample.app"/>
        ```

    - **Django**: Two changes are needed to `web.config` for Django projects. First, change the `WSGI_HANDLER` value to `django.core.wsgi.get_wsgi_application()` (the object is in the `wsgi.py` file):

        ```xml
        <!-- Django apps only -->
        <add key="WSGI_HANDLER" value="django.core.wsgi.get_wsgi_application()"/>
        ```

        Second, add the following entry below the one for `WSGI_HANDLER`, replacing `DjangoAzurePublishExample` with the name of your project:

        ```xml
        <add key="DJANGO_SETTINGS_MODULE" value="DjangoAzurePublishExample.settings" />
        ```

1. **Django apps only**: In the Django project's `settings.py` file, add your site URL domain to `ALLOWED_HOSTS` as shown below, replacing 'vspython-test-02.azurewebsites.net' with your URL, of course:

    ```python
    # Change the URL to your specific site
    ALLOWED_HOSTS = ['vspython-test-02.azurewebsites.net']
    ```

    > [!Note]
    >Failure to add your URL to the array results in the error "DisallowedHost at / Invalid HTTP_HOST header: '\<site URL\>'. You may need to add '\<site URL\>' to ALLOWED_HOSTS."

    > [!Note]
    > Note that when the array is empty, Django automatically allows 'localhost', but adding your production URL removes that capabilities. For this reason you might want to maintain separate development and production copies of `settings.py`, or use environment variables to control the run time values.

1. In **Solution Explorer**, expand the folder named the same as your project, right-click the `static` folder, select **Add > New Item...**, select the "Azure static files web.config" template, and select **OK**. This action creates another `web.config` in the `static` folder that disables Python processing for that folder. This configuration sends requests for static files to the default web server rather than using the Python application.

1. Save your project, then in Visual Studio **Solution Explorer**, right-click the project and select **Publish**.
:::image type="content" source="media/template-web-publish-command.png" alt-text="Screenshot showing Publish command on a project's context menu.":::

1. In the **Publish** tab that appears, select the publishing target. Publish starts a configuration dialog, select **Azure** as Publish Target, then select **Next** followed by Specific Target configuration as **Azure App Services**. A dialog appears in which you can select the appropriate subscription and app service. Select **Publish** to start the Web publishing activity.
:::image type="content" source="media/vs-2022/tutorials-common-publish-2022.png" alt-text="Screenshot of Publish to Azure, Visual Studio 2022.":::

1. Visual Studio displays publishing status in a "Web Publish Activity" window and the Publish window. Once publishing is complete, the default browser opens on the site URL. The URL is also shown in the Publish window.

1. When the browser opens, you may see the message, "The page cannot be displayed because an internal server error has occurred." This message indicates that your Python environment on the server isn't fully configured, in which case do the following steps:

    a. Refer again to [Managing Python on Azure App Service](managing-python-on-azure-app-service.md), making sure that you have an appropriate Python site extension installed.

    b. Double-check the path to the Python interpreter in your `web.config` file. The path must exactly match the install location of your chosen site extension.

    c. Use the Kudu console to upgrade any packages listed in your app's `requirements.txt` file: navigate to the same Python folder that's used in `web.config`, such as `/home/python361x64`, and run the following command as described in the [Kudu console](managing-python-on-azure-app-service.md#azure-app-service-kudu-console) section:

    ```command
    python -m pip install --upgrade -r /home/site/wwwroot/requirements.txt
    ```

    > [!Tip]
    >If you see permission errors when running this command, double-check that you're running the command in your site extension folder and *not* in the folder of one of App Service's default Python installations. Because you can't modify those default environments, attempting to install packages certainly fails.

    d. For detailed error output, add the following line to `web.config` within the `<system.webServer>` node, which provides more detailed error output:

    ```xml
    <httpErrors errorMode="Detailed"></httpErrors>
    ```

    e. Try restarting the App Service after installing new packages. A restart is not necessary when changing `web.config`, as App Service does an automatic restart whenever `web.config` changes.

    > [!Tip]
    > If you make any changes to your app's `requirements.txt` file, be sure to again use the Kudu console to install any packages that are now listed in that file.

1. Once you've fully configured the server environment, refresh the page in the browser and the web app should appear.
:::image type="content" source="media/azure-publish-results.png" alt-text="Screenshot of Results of publishing Bottle, Flask, and Django apps to App Service.":::
::: moniker-end

As part of this process, Visual Studio also does the following steps:

- Create a `web.config` file on the server that contains appropriate pointers to the app's `wsgi_app` function and to App Service's default Python 3.9 interpreter.
- Turn off processing for files in the project's `static` folder (rules for this are in `web.config`).
- Publish the virtual environment to the server.
- Add a `web.debug.config` file and the debugging tools to enable remote debugging. For Visual Studio 2019 version 16.4 and earlier, the debugging tools are ptvsd. For Visual Studio 2019 version 16.5 and later, the debugging tools are debugpy.

As noted earlier, these automatic steps simplify the publishing process but make it more difficult to control the Python environment. For example, the `web.config` file is created only on the server but not added to your project. The publishing process also takes longer because it's copying the whole virtual environment from your development computer rather than relying on the server configuration.

Eventually you may want to maintain your own `web.config` file and use `requirements.txt` to maintain packages on the server directly. Using `requirements.txt`, in particular, guarantees that your development and server environments always match.
