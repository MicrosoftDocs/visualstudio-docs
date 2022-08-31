---
title: "Tutorial: Create a C# ASP.NET Core web app in Visual Studio"
description: In this tutorial, create a web app in Visual Studio with C# and ASP.NET Core.
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.technology: vs-ide-general
ms.topic: tutorial
ms.date: 02/16/2022
ms.prod: visual-studio-windows
ms.workload:
  - "aspnet"
  - "dotnetcore"
dev_langs:
  - CSharp
ms.devlang: CSharp
ms.custom: "vs-acquistion, get-started"
---
# Tutorial: Get started with C# and ASP.NET Core in Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

In this tutorial for C# development with ASP.NET Core, you'll create a C# ASP.NET Core web app in Visual Studio.

This tutorial will show you how to:

> [!div class="checklist"]
>
> - Create a Visual Studio project
> - Create a C# ASP.NET Core web app
> - Make changes to the web app
> - Explore IDE features
> - Run the web app

## Prerequisites


   You need Visual Studio to complete this tutorial.
   Visit the [Visual Studio downloads page](https://visualstudio.microsoft.com/vs) for a free version.


- For more information about upgrading to the latest Visual Studio release, see [Visual Studio updates](../../install/update-visual-studio.md).

- To customize your Visual Studio experience, see [personalize the Visual Studio IDE and Editor](../../ide/quickstart-personalize-the-ide.md).

## Create a project

First, you'll create an ASP.NET Core project. The project type comes with all the template files you'll need to build a fully functional website.


::: moniker range="vs-2019"

1. On the start window, select **Create a new project**.

   :::image type="content" source="../../get-started/media/vs-2019/create-new-project-dark-theme.png" alt-text="Screenshot shows the start window for Visual Studio. Create a new project option is highlighted.":::

1. In the **Create a new project** window, select **C#** from the Language list. Next, select **Windows** from the platform list, and **Web** from the project types list.

      After you apply the language, platform, and project type filters, select the **ASP.NET Core Web App** template, and then select **Next**.

   :::image type="content" source="./media/vs-2019/csharp-create-new-project-aspnet-core.png" alt-text="Screenshot shows the ASP.NET Core Web App project template highlighted in the New Project dialog box.":::

   > [!NOTE]
   > If you don't see the **ASP.NET Core Web App** template, you can install it from the **Create a new project** window. In the **Not finding what you're looking for?** message, found at the bottom of the list of templates, select the **Install more tools and features** link.
   >
   > ![Screenshot shows the Install more tools and features link that is part of the Not finding what you're looking for message.](../../get-started/media/vs-2019/not-finding-what-looking-for.png)
   >
   > Next, in the Visual Studio Installer, select **ASP.NET and web development**.
   >
   > ![Screenshot shows the dot NET Core cross-platform development workload in the Visual Studio Installer.](../../get-started/media/aspnet-core-web-dev-workload.png)
   >
   > Select **Modify** in the Visual Studio Installer. You might be prompted to save your work. Next, select **Continue** to install the workload.

1. In the **Configure your new project** window, enter **MyCoreApp** in the **Project name** field. Then, select **Next**.

   :::image type="content" source="./media/vs-2019/csharp-name-your-aspnet-app.png" alt-text="Screenshot shows the Configure your new project window with MyCoreApp entered in the Project name field.":::

1. In the **Additional information** window, verify that **.NET Core 3.1** appears in the **Target Framework** field. From this window, you can enable Docker support and add authentication support. The drop-down menu for **Authentication Type** has the following four options:
    - **None**. No authentication.
    - **Individual accounts**. These authentications are stored in a local or Azure-based database.
    - **Microsoft identity platform**. This option uses Active Directory, Azure AD, or Microsoft 365 for authentication.
    - **Windows**. Suitable for intranet applications.

    Leave the **Enable Docker** box unchecked, and select **None** for Authentication Type. Next, select **Create**.

   :::image type="content" source="./media/vs-2019/aspnet-core-additional-information.png" alt-text="Screenshot shows the default settings in the Additional information window. The Framework value is .NET Core 3.1.":::

   Visual Studio will open up your new project.

::: moniker-end

::: moniker range=">=vs-2022"

1. On the start window, select **Create a new project**.

   :::image type="content" source="media/vs-2022/start-window-create-new-project.png" border="false" alt-text="Screenshot shows the start window for Visual Studio. Create a new project option is highlighted.":::

1. In the **Create a new project** window, select **C#** from the Language list. Next, select **Windows** from the platform list, and **Web** from the project types list.

      After you apply the language, platform, and project type filters, select the **ASP.NET Core Web App** template, and then select **Next**.

   :::image type="content" source="media/vs-2022/csharp-create-new-project-aspnet-core.png" border="false" alt-text="Screenshot shows the ASP.NET Core Web App project template selected and highlighted on the Create a new project page.":::

   > [!NOTE]
   > If you don't see the **ASP.NET Core Web App** template, you can install it from the **Create a new project** window. In the **Not finding what you're looking for?** message, found at the bottom of the list of templates,  select the **Install more tools and features** link.
   >
   > :::image type="content" source="media/vs-2022/not-finding-what-looking-for.png" alt-text="Screenshot shows the Install more tools and features link that is part of the Not finding what you're looking for message.":::
   >
   > Then, in the Visual Studio Installer, select the **ASP.NET and web development** workload.
   >
   > :::image type="content" source="media/vs-2022/aspnet-core-web-dev-workload.png" alt-text="Screenshot shows the ASP.NET and web development workload in the Visual Studio Installer.":::
   >
   > Select **Modify** in the Visual Studio Installer. You might be prompted to save your work. Next, select **Continue** to install the workload.

1. In the **Configure your new project** window, enter **MyCoreApp** in the **Project name** field. Then, select **Next**.

   :::image type="content" source="media/vs-2022/csharp-name-your-aspnet-app.png" border="false" alt-text="Screenshot shows the Configure your new project window with MyCoreApp entered in the Project name field.":::

1. In the **Additional information** window, verify that **.NET 6.0** appears in the **Target Framework** field. From this window, you can enable Docker support and add authentication support. The drop-down menu for **Authentication Type** has the following four options:
    - **None**. No authentication.
    - **Individual accounts**. These authentications are stored in a local or Azure-based database.
    - **Microsoft identity platform**. This option uses Active Directory, Azure AD, or Microsoft 365 for authentication.
    - **Windows**. Suitable for intranet applications.

    Leave the **Enable Docker** box unchecked, and select **None** for Authentication Type. Next, select **Create**.

   :::image type="content" source="media/vs-2022/aspnet-core-additional-information.png" border="false" alt-text="Screenshot shows the default settings in the Additional information window. The Framework value is .NET 6.0.":::

   Visual Studio will open up your new project.

::: moniker-end

### About your solution

This solution follows the **Razor Page** design pattern. It's different than the [Model-View-Controller (MVC)](/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-2.1&tabs=aspnetcore2x&preserve-view=true) design pattern in that it's streamlined to include the model and controller code within the Razor Page itself.


::: moniker range="=vs-2019"

## Tour your solution

 1. The project template creates a solution with a single ASP.NET Core project that is named **MyCoreApp**. Select the **Solution Explorer** tab to view its contents.

    ![Screenshot shows the MyCoreApp project selected in the Solution Explorer in Visual Studio.](media/csharp-aspnet-razor-solution-explorer-mycoreapp.png)

 1. Expand the **Pages** folder.

     ![Screenshot shows the contents of the Pages folder in the the Solution Explorer in Visual Studio..](media/vs-2019/csharp-aspnet-solution-explorer-pages.png)

 1. Select the **Index.cshtml** file, and view in the code editor.

     ![Screenshot shows the Index dot c s h t m l file open in the Visual Studio code editor.](media/vs-2019/csharp-aspnet-index-cshtml.png)

 1. Each .cshtml file has an associated code file. To open the code file in the editor, expand the **Index.cshtml** node in Solution Explorer, and select the **Index.cshtml.cs** file.

     ![Screenshot shows Index dot c s h t m l file selected in the Solution Explorer in Visual Studio.](media/vs-2019/csharp-aspnet-choose-index-cshtml.png)

 1. View the **Index.cshtml.cs** file in the code editor.

     ![Screenshot shows the Index dot c s h t m l dot c s file open in the Visual Studio code editor.](media/vs-2019/csharp-aspnet-index-cshtml-editing.png)

 1. The project contains a **wwwroot** folder that is the root for your website. Expand the folder to view its contents.

     ![Screenshot shows the w w w root folder selected in the Solution Explorer in Visual Studio.](media/csharp-aspnet-razor-solution-explorer-wwwroot.png)

    You can put static site content&mdash;such as CSS, images, and JavaScript libraries&mdash;directly in the paths where you want them.

 1. The project also contains configuration files that manage the web app at run time. The default application [configuration](/aspnet/core/fundamentals/configuration) is stored in **appsettings.json**. However, you can override these settings by using **appsettings.Development.json**. Expand the **appsettings.json** file to view the **appsettings.Development.json** file.

     ![Screenshot shows appsettings dot j son selected and expanded in the Solution Explorer in Visual Studio.](media/csharp-aspnet-razor-solution-explorer-appsettingsjson.png)

## Run, debug, and make changes

1. Select the **IIS Express** button in the toolbar, to build and run the app in debug mode. Alternatively, press **F5**, or go to **Debug** > **Start Debugging** from the menu bar.

     ![Screenshot shows the I I S Express button highlighted in the toolbar in Visual Studio.](media/csharp-aspnet-razor-iisexpress.png)

     > [!NOTE]
     > If you get an error message that says **Unable to connect to web server 'IIS Express'**, close Visual Studio and then relaunch the program as an administrator. You can do this by right-clicking the Visual Studio icon from the Start Menu, and then selecting the **Run as administrator** option from the context menu.
     >
     > You might also get a message that asks if you want to accept an IIS SSL Express certificate. To view the code in a web browser, select **Yes**, and then select **Yes** if you receive a follow-up security warning message.

1. Visual Studio launches a browser window. You should then see **Home** and **Privacy** pages in the menu bar.

1. Select **Privacy** from the menu bar. The **Privacy** page in the browser renders the text that is set in the **Privacy.cshtml** file.

   ![Screenshot shows the MyCoreApp Privacy page with the following text: Use this page to detail your site's privacy policy.](media/vs-2019/csharp-aspnet-browser-page-privacy.png)

1. Return to Visual Studio, and then press **Shift+F5** to stop debugging. This action closes the project in the browser window.

1. In Visual Studio, open **Privacy.cshtml** for editing. Next, delete the sentence, _Use this page to detail your site's privacy policy_ and replace it with _This page is under construction as of @ViewData["TimeStamp"]_.

    ![Screenshot shows the Privacy dot c s h t m l file open in the Visual Studio code editor with the updated text.](media/vs-2019/csharp-aspnet-privacy-cshtml-code-changed.png)

1. Now, let's make a code change. Select **Privacy.cshtml.cs**. Next, clean up the `using` directives at the top of the file by using the following shortcut:

   Mouseover or select a greyed out `using` directive. A [Quick Actions](../../ide/quick-actions.md) light bulb will appear just below the caret or in the left margin. Select the light bulb, and then select **Remove unnecessary usings**.

   ![Screenshot shows the Privacy dot c s h t m l file in the Visual Studio code editor with the Quick Actions tooltip exposed for a greyed out using directive.](media/vs-2019/csharp-aspnet-remove-unnecessary-usings.png)

   Now select **Preview changes** to see what will change.

   ![Screenshot shows the Preview Changes dialog box. The dialog box shows the directive being removed, and previews the code change after the removal.](media/vs-2019/csharp-aspnet-preview-changes.png)

   Select **Apply**. Visual Studio deletes the unnecessary `using` directives from the file.

1. Next, in the `OnGet()` method, change the body to the following code:

     ```csharp
     public void OnGet()
     {
        string dateTime = DateTime.Now.ToShortDateString();
        ViewData["TimeStamp"] = dateTime;
     }
    ```

1. Notice a wavy underline appears under **DateTime**. The wavy underline appears because this type isn't in scope.

   ![Screenshot shows an error mark, in the form of a wavy underline, for DateTime in the Visual Studio code editor.](media/vs-2019/csharp-aspnet-add-new-onget-method.png)

    Open the **Error List** toolbar to see the same errors listed there. If you don't see the **Error List** toolbar, go to **View** > **Error List** from the top menu bar.

   ![Screenshot shows the Error List toolbar in Visual Studio with DateTime listed.](media/vs-2019/csharp-aspnet-error-list.png)

1. Let's fix this error. In the code editor, place your cursor on the line that contains the error, and then select the Quick Actions light bulb in the left margin. Then, from the drop-down menu, select **using System;** to add this directive to the top of your file and resolve the errors.

   ![Screenshot shows the Quick Actions options from its drop-down menu with a mouseover on using System.](media/vs-2019/csharp-aspnet-add-usings.png)

1. Press **F5** to open your project in the web browser.

1. At the top of the web site, select **Privacy** to view your changes.

   ![Screenshot showing the updated Privacy page that includes the changes you made.](media/vs-2019/csharp-aspnet-browser-page-privacy-changed.png)

1. Close the web browser, press **Shift**+**F5** to stop debugging.

## Change your Home page

1. In the **Solution Explorer**, expand the **Pages** folder, and then select **Index.cshtml**.

   ![Screenshot shows Index dot c s h t m l selected under the Pages node in the Solution Explorer.](media/vs-2019/csharp-aspnet-index-page-cshtml-file.png)

   The **Index.cshtml** file corresponds with your **Home** page in the web app, which runs in a web browser.

   ![ Screenshot shows the Home page for the web app in the browser window.](media/vs-2019/csharp-aspnet-index-page.png)

   In the code editor, you'll see HTML code for the text that appears on the **Home** page.

   ![Screenshot shows the Index dot c s h t m l file for the Home page in the Visual Studio code editor.](media/vs-2019/csharp-aspnet-index-cshtml-page.png)

1. Replace the _Welcome_ text with _Hello World!_

   ![Screenshot shows the Index dot c s h t m l file in the Visual Studio code editor with the Welcome text changed to Hello World!.](media/vs-2019/csharp-aspnet-index-cshtml-page-hello-world.png)
    
1. Select **IIS Express** or press **Ctrl**+**F5** to run the app and open it in a web browser.

   ![Screenshot shows the IIS Express button highlighted in the toolbar for Visual Studio.](media/vs-2019/csharp-aspnet-generic-iis-button.png)

1. In the web browser, you'll see your new changes on the **Home** page.

   ![Screenshot shows the Home page for the web app in the browser window. The updated text says Hello World!](media/vs-2019/csharp-aspnet-index-page-hello-world.png)

1. Close the web browser, press **Shift**+**F5** to stop debugging, and save your project. You can now close Visual Studio.

::: moniker-end

::: moniker range=">=vs-2022"

## Tour your solution

 1. The project template creates a solution with a single ASP.NET Core project that is named **MyCoreApp**. Select the **Solution Explorer** tab to view its contents.

     :::image type="content" source="media/vs-2022/csharp-aspnet-razor-solution-explorer-mycoreapp.png" alt-text="Screenshot shows the MyCoreApp project selected and its content in the Solution Explorer in Visual Studio.":::

 1. Expand the **Pages** folder.

     :::image type="content" source="media/vs-2022/csharp-aspnet-solution-explorer-pages.png" alt-text="Screenshot shows the contents of the Pages folder in the Solution Explorer.":::

 1. Select the **Index.cshtml** file, and view in the code editor.

     :::image type="content" source="media/vs-2022/csharp-aspnet-index-cshtml.png" alt-text="Screenshot shows the Index.cshtml file open in the Visual Studio code editor.":::

 1. Each .cshtml file has an associated code file. To open the code file in the editor, expand the **Index.cshtml** node in Solution Explorer, and select the **Index.cshtml.cs** file.

     :::image type="content" source="media/vs-2022/csharp-aspnet-choose-index-cshtml.png" alt-text="Screenshot shows Index.cshtml file selected in the Solution Explorer in Visual Studio.":::

 1. View the **Index.cshtml.cs** file in the code editor.

     :::image type="content" source="media/vs-2022/csharp-aspnet-index-cshtml-editing.png" alt-text="Screenshot shows the Index.cshtml.cs file open in the Visual Studio code editor.":::

 1. The project contains a **wwwroot** folder that is the root for your website. Expand the folder to view its contents.

     :::image type="content" source="media/vs-2022/csharp-aspnet-razor-solution-explorer-wwwroot.png" alt-text="Screenshot shows the w w w root folder selected in the Solution Explorer in Visual Studio.":::

    You can put static site content&mdash;such as CSS, images, and JavaScript libraries&mdash;directly in the paths where you want them.

 1. The project also contains configuration files that manage the web app at run time. The default application [configuration](/aspnet/core/fundamentals/configuration) is stored in **appsettings.json**. However, you can override these settings by using **appsettings.Development.json**. Expand the **appsettings.json** file to view the **appsettings.Development.json** file.

     :::image type="content" source="media/vs-2022/csharp-aspnet-razor-solution-explorer-appsettingsjson.png" alt-text="Screenshot shows appsettings.json selected and expanded, which exposes appsettings.Development.json, in the Solution Explorer in Visual Studio.":::

## Run, debug, and make changes

1. Select the **IIS Express** button in toolbar, to build and run the app in debug mode. Alternatively, press **F5**, or go to **Debug** > **Start Debugging** from the menu bar.

     :::image type="content" source="media/vs-2022/csharp-aspnet-razor-iis-express.png" alt-text="Screenshot shows the I I S Express button highlighted in the toolbar in Visual Studio.":::

     > [!NOTE]
     > If you get an error message that says **Unable to connect to web server 'IIS Express'**, close Visual Studio and then relaunch the program as an administrator. You can do this by right-clicking the Visual Studio icon from the Start Menu, and then selecting the **Run as administrator** option from the context menu.
     >
     > You might also get a message that asks if you want to accept an IIS SSL Express certificate. To view the code in a web browser, select **Yes**, and then select **Yes** if you receive a follow-up security warning message.

1. Visual Studio launches a browser window. You should then see **Home** and **Privacy** pages in the menu bar.

1. Select **Privacy** from the menu bar. The **Privacy** page in the browser renders the text that is set in the **Privacy.cshtml** file.

   :::image type="content" source="media/vs-2022/csharp-aspnet-browser-page-privacy.png" alt-text="Screenshot shows the MyCoreApp Privacy page with the following text: Use this page to detail your site's privacy policy.":::

1. Return to Visual Studio, and then press **Shift+F5** to stop debugging. This action closes the project in the browser window.

1. In Visual Studio, open **Privacy.cshtml** for editing. Next, delete the sentence, _Use this page to detail your site's privacy policy_ and replace it with _This page is under construction as of @ViewData["TimeStamp"]_.

   :::image type="content" source="media/vs-2022/csharp-aspnet-privacy-cshtml-code-changed.png" alt-text="Screenshot shows the Privacy.cshtml file open in the Visual Studio code editor with the updated text.":::

1. Now, let's make a code change. Select **Privacy.cshtml.cs**. Then, clean up the `using` directives at the top of the file by selecting the following shortcut:

   Mouseover or select a greyed out `using` directive. A [Quick Actions](../../ide/quick-actions.md) light bulb will appear just below the caret or in the left margin. Select the light bulb, and then select **Remove unnecessary usings**.

   :::image type="content" source="media/vs-2022/csharp-aspnet-remove-unnecessary-usings.png" alt-text="Screenshot shows the Privacy.cshtml file in the Visual Studio code editor with the Quick Actions tooltip open and Preview changes highlighted.":::

   Now select **Preview changes** to see what will change.

   :::image type="content" source="media/vs-2022/csharp-aspnet-preview-changes.png" border="false" alt-text="Screenshot shows the Preview Changes dialog box. The dialog box shows the directive being removed, and previews the code change after the removal.":::

   Select **Apply**. Visual Studio deletes the unnecessary `using` directives from the file.

1. Next, create a string for the current date that is formatted for your culture or region by using the [DateTime.ToString](xref:System.DateTime.ToString%2A) method.

   - The first argument for the method specifies how the date should be displayed. This example uses the format specifier (`d`) which indicates the short date format.
   - The second argument is the [CultureInfo](/dotnet/api/system.globalization.cultureinfo) object that specifies the culture or region for the date. The second argument determines, among other things, the language of any words in the date, and the type of separators used.

Change the body of the `OnGet()` method to the following code:

   ```csharp
   public void OnGet()
   {
      string dateTime = DateTime.Now.ToString("d", new CultureInfo("en-US"));
      ViewData["TimeStamp"] = dateTime;
   }
   ```

1. Notice that a wavy underline appears under **CultureInfo**. The wavy underline appears because this type isn't in scope.

   :::image type="content" source="media/vs-2022/csharp-aspnet-add-new-onget-method.png" alt-text="Screenshot shows an error mark, in the form of a wavy underline, for CultureInfo in the Visual Studio code editor.":::

    Open the **Error List** toolbar to see the same error listed there. If you don't see the **Error List** toolbar, go to **View** > **Error List** from the top menu bar.

   :::image type="content" source="media/vs-2022/csharp-aspnet-error-list.png" alt-text="Screenshot shows the Error List toolbar in Visual Studio with CultureInfo listed, and is missing a using directive.":::

1. Let's fix this error. In the code editor, place your cursor on the line that contains the error, and then select the Quick Actions light bulb in the left margin. Then, from the drop-down menu, select **using System.Globalization;** to add this directive to the top of your file and resolve the errors.

   :::image type="content" source="media/vs-2022/csharp-aspnet-add-usings.png" alt-text="Screenshot shows the Quick Actions options from its drop-down menu with a mouseover on System.Globalization directive.":::

1. Press **F5** to open your project in the web browser.

1. At the top of the web site, select **Privacy** to view your changes.

   :::image type="content" source="media/vs-2022/csharp-aspnet-browser-page-privacy-changed.png" alt-text="Screenshot showing the Privacy page of the MyCoreApp that includes the changes made to add the date.":::

1. Close the web browser, press **Shift**+**F5** to stop debugging.

## Change your Home page

1. In the **Solution Explorer**, expand the **Pages** folder, and then select **Index.cshtml**.

   :::image type="content" source="media/vs-2022/csharp-aspnet-index-page-cshtml-file.png" alt-text="Screenshot shows Index.cshtml selected under the Pages node in the Solution Explorer.":::

   The **Index.cshtml** file corresponds with your **Home** page in the web app, which runs in a web browser.

   :::image type="content" source="media/vs-2022/csharp-aspnet-index-page.png" alt-text="Screenshot shows the Home page for the web app in the browser window.":::

   In the code editor, you'll see HTML code for the text that appears on the **Home** page.

   :::image type="content" source="media/vs-2022/csharp-aspnet-index-cshtml-hello.png" alt-text="Screenshot shows the Index.cshtml file for the Home page in the Visual Studio code editor.":::

1. Replace the _Welcome_ text with _Hello World!_

   :::image type="content" source="media/vs-2022/csharp-aspnet-index-cshtml-page-hello-world.png" alt-text="Screenshot shows the Index.cshtml file in the Visual Studio code editor with the 'Welcome' text changed to 'Hello World!'.":::
    
1. Select **IIS Express** or press **Ctrl**+**F5** to run the app and open it in a web browser.

   :::image type="content" source="media/vs-2022/csharp-aspnet-generic-iis-button.png" alt-text="Screenshot shows the IIS Express button highlighted in the toolbar for Visual Studio.":::

1. In the web browser, you'll see your new changes on the **Home** page.

   :::image type="content" source="media/vs-2022/csharp-aspnet-index-page-hello-world.png" alt-text="Screenshot shows the Home page for the web app in the browser window. The updated text says 'Hello World!'":::

1. Close the web browser, press **Shift**+**F5** to stop debugging, and save your project. You can now close Visual Studio.

::: moniker-end

## Next steps

Congratulations on completing this tutorial! We hope you enjoyed learning about C#, ASP.NET Core, and the Visual Studio IDE. To learn more about creating a web app or website with C# and ASP.NET, continue with the following tutorial:

> [!div class="nextstepaction"]
> [Create a Razor Pages web app with ASP.NET Core](/aspnet/core/tutorials/razor-pages/?view=aspnetcore-2.1&preserve-view=true)

Or, learn how to containerize your web app with Docker:

> [!div class="nextstepaction"]
> [Container Tools in Visual Studio](../../containers/overview.md)

## See also

[Publish your web app to Azure App Service by using Visual Studio](../../deployment/quickstart-deploy-aspnet-web-app.md)
