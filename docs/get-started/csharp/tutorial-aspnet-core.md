---
title: "Tutorial: Get started with C# and ASP.NET Core"
titleSuffix: ""
description: "Learn how to create an ASP.NET Core web app in Visual Studio with C#, step-by-step."
ms.custom: "vs-acquisition, get-started"
ms.date: 09/14/2021
ms.technology: vs-ide-general
ms.prod: visual-studio-windows
ms.topic: tutorial
ms.devlang: CSharp
author: anandmeg
ms.author: meghaanand
manager: jmartens
dev_langs:
  - CSharp
ms.workload:
  - "aspnet"
  - "dotnetcore"
---
# Tutorial: Get started with C# and ASP.NET Core in Visual Studio

In this tutorial for C# development with ASP.NET Core using Visual Studio, you'll create a C# ASP.NET Core web app, make changes to it, explore some features of the IDE, and then run the app.

## Prerequisites

1. Install Visual Studio
   ::: moniker range="vs-2017"
   
   If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/vs/older-downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=vs+2017+download) page to install it for free.
   
   ::: moniker-end
   
   ::: moniker range=">=vs-2019"
   
   If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads) page to install it for free.
   
   ::: moniker-end

1. Update Visual Studio - If you've already installed Visual Studio, make sure that you're running the most recent release. For more information about how to update your installation, see the [Update Visual Studio to the most recent release](../../install/update-visual-studio.md) page.

1. Choose your theme (optional) - This tutorial includes screenshots that use the dark theme. You can [Personalize the Visual Studio IDE and Editor](../../ide/quickstart-personalize-the-ide.md) page to learn how.

## Create a project

First, you'll create a ASP.NET Core project. The project type comes with all the template files you'll need for a fully functional website, before you've even added anything!

::: moniker range="vs-2017"

1. Open Visual Studio 2017.

2. From the top menu bar, choose **File** > **New** > **Project**.

3. In the **New Project** dialog box in the left pane, expand **Visual C#**, expand **Web**, and then choose **.NET Core**. In the middle pane, choose **ASP.NET Core Web Application**. Then, name the file *MyCoreApp* and choose **OK**.

   ![ASP.NET Core Web Application project template in the New Project dialog box in the Visual Studio IDE](media/csharp-aspnet-choose-template-name-razor-mycoreapp-file.png)

### Add a workload (optional)

If you don't see the **ASP.NET Core Web Application** project template, you can get it by adding the **ASP.NET and web development** workload. You can add this workload in one of the two following ways, depending on which Visual Studio 2017 updates are installed on your machine.

#### Option 1: Use the New Project dialog box

1. Select the **Open Visual Studio Installer** link in the left pane of the **New Project** dialog box. (Depending on your display settings, you might have to scroll to see it.)

   ![Select the Open Visual Studio Installer link from the New Project dialog box](../media/open-visual-studio-installer-mycoreapp.png)

1. The Visual Studio Installer launches. Choose the **ASP.NET and web development** workload, and then choose **Modify**.

   ![.NET Core cross-platform development workload in the Visual Studio Installer](../media/tutorial-aspnet-workload.png)

   (You might have to close Visual Studio before you can continue installing the new workload.)

#### Option 2: Use the Tools menu bar

1. Cancel out of the **New Project** dialog box. Then, from the top menu bar, choose **Tools** > **Get Tools and Features**.

1. The Visual Studio Installer launches. Choose the **ASP.NET and web development** workload, and then choose **Modify**.

   (You might have to close Visual Studio before you can continue installing the new workload.)

### Add a project template

1. In the **New ASP.NET Core Web Application** dialog box, choose the **Web Application** project template.

1. Verify that **ASP.NET Core 2.1** appears in the top drop-down menu. Then, choose **OK**.

   ![New ASP.NET Core Web Application dialog box](media/new-project-csharp-aspnet-razor-web-app.png)

   > [!NOTE]
   > If you don't see **ASP.NET Core 2.1** from the top drop-down menu, make sure that you are running the most recent release of Visual Studio. For more information about how to update your installation, see the [Update Visual Studio to the most recent release](../../install/update-visual-studio.md) page.

::: moniker-end

::: moniker range="vs-2019"

1. In the start window, choose **Create a new project**.

   :::image type="content" source="../../get-started/media/vs-2019/create-new-project-dark-theme.png" alt-text="Screenshot showing the Visual Studio start window with the 'Create a new project' option highlighted.":::

1. In the **Create a new project** window, choose **C#** from the Language list. Next, choose **Windows** from the Platform list, and **Web** from the project types list.

      After you apply the language, platform, and project type filters, choose the **ASP.NET Core Web App** template, and then choose **Next**.

   :::image type="content" source="./media/vs-2019/csharp-create-new-project-aspnet-core.png" alt-text="Screenshot showing the ASP.NET Core Web App project template highlighted in the New Project dialog box.":::

   > [!NOTE]
   > If you don't see the **ASP.NET Core Web App** template, you can install it from the **Create a new project** window. In the **Not finding what you're looking for?** message, choose the **Install more tools and features** link.
   >
   > ![Screenshot showing the 'Install more tools and features' link that is part of the 'Not finding what you're looking for' message.](../../get-started/media/vs-2019/not-finding-what-looking-for.png)
   >
   > Then, in the Visual Studio Installer, choose the **ASP.NET and web development** workload.
   >
   > ![Screenshot showing the .NET Core cross-platform development workload in the Visual Studio Installer.](../../get-started/media/aspnet-core-web-dev-workload.png)
   >
   > After that, choose the **Modify** button in the Visual Studio Installer. If you're prompted to save your work, do so. Next, choose **Continue** to install the workload. Then, return to step 2 in this "[Create a project](#create-a-project)" procedure.

1. In the **Configure your new project** window, type or enter *MyCoreApp* in the **Project name** box. Then, choose **Next**.

   :::image type="content" source="./media/vs-2019/csharp-name-your-aspnet-app.png" alt-text="Screenshot showing the 'Configure your new project' window with 'MyCoreApp' entered in the Project name field.":::

1. In the **Additional information** window, verify that **.NET Core 3.1** appears in the top drop-down menu. Note that you can choose to enable Docker support by checking the box. You can also add authentication support by clicking the change Authentication button. From there you can choose from:
    - None: no authentication.
    - Individual accounts: these are stored in a local or Azure-based database.
    - Microsoft identity platform: this option uses Active Directory, Azure AD, or Microsoft 365 for authentication.
    - Windows: suitable for intranet applications.
    
    Leave the **Enable Docker** box unchecked, and select **None** for Authentication Type. Then, select **Create**.

   :::image type="content" source="./media/vs-2019/aspnet-core-additional-information.png" alt-text="Screenshot showing the default settings in the 'Additional information' window. The Framework value is '.NET Core 3.1'.":::

   Visual Studio will open up your new project.

::: moniker-end

::: moniker range=">=vs-2022"

1. In the start window, choose **Create a new project**.

   :::image type="content" source="media/vs-2022/start-window-create-new-project.png" alt-text="Screenshot showing the Visual Studio start window with the 'Create a new project' option highlighted.":::

1. In the **Create a new project** window, choose **C#** from the Language list. Next, choose **Windows** from the Platform list, and **Web** from the project types list.

      After you apply the language, platform, and project type filters, choose the **ASP.NET Core Web App** template, and then choose **Next**.

   :::image type="content" source="media/vs-2022/csharp-create-new-project-aspnet-core.png" alt-text="Screenshot showing the ASP.NET Core Web App project template highlighted in the New Project dialog box.":::

   > [!NOTE]
   > If you don't see the **ASP.NET Core Web App** template, you can install it from the **Create a new project** window. In the **Not finding what you're looking for?** message, choose the **Install more tools and features** link.
   >
   > :::image type="content" source="media/vs-2022/not-finding-what-looking-for.png" alt-text="Screenshot showing the 'Install more tools and features' link that is part of the 'Not finding what you're looking for' message.":::
   >
   > Then, in the Visual Studio Installer, choose the **ASP.NET and web development** workload.
   >
   > :::image type="content" source="media/vs-2022/aspnet-core-web-dev-workload.png" alt-text="Screenshot showing the ASP.NET and web development workload in the Visual Studio Installer.":::
   >
   > After that, choose the **Modify** button in the Visual Studio Installer. If you're prompted to save your work, do so. Next, choose **Continue** to install the workload. Then, return to step 2 in this "[Create a project](#create-a-project)" procedure.

1. In the **Configure your new project** window, type or enter *MyCoreApp* in the **Project name** box. Then, choose **Next**.

   :::image type="content" source="media/vs-2022/csharp-name-your-aspnet-app.png" alt-text="Screenshot showing the 'Configure your new project' window with 'MyCoreApp' entered in the Project name field.":::

1. In the **Additional information** window, verify that **.NET 6.0** appears in the **Framework** field. In this window, you can choose to enable Docker support by checking the box. You can also add authentication support by selecting a value from the **Authentication type** drop-down list. From there you can choose from:

    - None: no authentication.
    - Individual accounts: authentications that are stored in a local or Azure-based database.
    - Microsoft identity platform: this option uses Active Directory, Azure AD, or Microsoft 365 for authentication.
    - Windows: suitable for intranet applications.
    
    Leave the **Enable Docker** box unchecked, and select **None** for Authentication type. Then, select **Create**.

   :::image type="content" source="media/vs-2022/aspnet-core-additional-information.png" alt-text="Screenshot showing the default settings in the 'Additional information' window. The Framework value is '.NET 6.0'.":::

   Visual Studio will open up your new project.

::: moniker-end

### About your solution

This solution follows the **Razor Page** design pattern. It's different than the [Model-View-Controller (MVC)](/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-2.1&tabs=aspnetcore2x&preserve-view=true) design pattern in that it's streamlined to include the model and controller code within the Razor Page itself.

::: moniker range="vs-2017"
## Tour your solution

 1. The project template creates a solution with a single ASP.NET Core project that is named _MyCoreApp_. Choose the **Solution Explorer** tab to view its contents.

    ![ASP.NET Solution Explorer in Visual Studio for Razor Pages solution that is named MyCoreApp](media/csharp-aspnet-razor-solution-explorer-mycoreapp.png)

 1. Expand the **Pages** folder, and then expand *About.cshtml*.

     ![The About.cshtml file in the Solution Explorer in Visual Studio](media/csharp-aspnet-razor-solution-explorer-aboutcshtml.png)

 1. View the **About.cshtml** file in the code editor.

     ![Screenshot showing the first ten lines of the About.cshtml file in the Visual Studio code editor.](media/csharp-aspnet-razor-aboutcshtml-mycoreapp-code.png)

 1. Choose the **About.cshtml.cs** file.

     ![Choose the About.cshtml.cs file in the Visual Studio code editor](media/csharp-aspnet-razor-solution-explorer-aboutcshtmlcs.png)

 1. View the **About.cshtml.cs** file in the code editor.

     ![Screenshot showing the first 18 lines of the About.cshtml.cs file in the Visual Studio code editor. ](media/csharp-aspnet-razor-aboutcshtmlcs-mycoreapp-code.png)

 1. The project contains a **wwwroot** folder that is the root for your website. Expand the folder to view its contents.

     ![wwwroot folder in the Solution Explorer in Visual Studio](media/csharp-aspnet-razor-solution-explorer-wwwroot.png)

    You can put static site content&mdash;such as CSS, images, and JavaScript libraries&mdash;directly in the paths where you want them.

 1. The project also contains configuration files that manage the web app at run time. The default application [configuration](/aspnet/core/fundamentals/configuration) is stored in *appsettings.json*. However, you can override these settings by using *appsettings.Development.json*. Expand the **appsettings.json** file to view the **appsettings.Development.json** file.

     ![Configuration files in the Solution Explorer in Visual Studio](media/csharp-aspnet-razor-solution-explorer-appsettingsjson.png)

## Run, debug, and make changes

1. Choose the **IIS Express** button in the IDE to build and run the app in Debug mode. (Alternatively, press **F5**, or choose **Debug** > **Start Debugging** from the menu bar.)

     ![Select the IIS Express button in Visual Studio](media/csharp-aspnet-razor-iisexpress.png)

     > [!NOTE]
     > If you get an error message that says **Unable to connect to web server 'IIS Express'**, close Visual Studio and then open it by using the **Run as administrator** option from the right-click or context menu. Then, run the application again.
     >
     > You might also get a message that asks if you want to accept an IIS SSL Express certificate. To view the code in a web browser, choose **Yes**, and then choose **Yes** if you receive a follow-up security warning message.

1. Visual Studio launches a browser window. You should then see **Home**, **About**, and **Contact** pages in the menu bar. (If you don't, choose the "hamburger" menu item to view them.)

    ![Select the "hamburger" menu item from the menu bar in your web app](media/csharp-aspnet-razor-browser-page.png)

1. Choose **About** from the menu bar.

   ![Select About in the browser window's menu bar for your app](media/csharp-aspnet-razor-browser-page-about-menu.png)

   Among other things, the **About** page in the browser renders the text that is set in the *About.cshtml* file.

   ![View the text on the About page](media/csharp-aspnet-razor-browser-page-about.png)

1. Return to Visual Studio, and then press **Shift+F5** to stop Debug mode. This also closes the project in the browser window.

1. In Visual Studio, choose **About.cshtml**. Then, delete the word _another_ and in its place, add the words _file and directory_.

    ![Change the text in the About.cshtml file](media/csharp-aspnet-razor-aboutcshtml-mycoreapp-code-changed.png)

1. Choose **About.cshtml.cs**. Then, clean up the `using` directives at the top of the file by using the following shortcut:

   Choose any of the grayed-out `using` directives and a [Quick Actions](../../ide/quick-actions.md) light bulb will appear just below the caret or in the left margin. Choose the light bulb, and then choose **Remove Unnecessary Usings**.

   ![Remove unnecessary Usings in the About.cshtml.cs file](media/csharp-aspnet-razor-remove-unnecessary-usings.png)

     Visual Studio deletes the unnecessary `using` directives from the file.

1. Next, in the `OnGet()` method, change the body to the following code:

     ```csharp
     public void OnGet()
     {
         string directory = Environment.CurrentDirectory;
         Message = String.Format("Your directory is {0}.", directory);
     }
    ```

1. Notice that two wavy underlines appear under **Environment** and **String**. The wavy underlines appear because these types aren't in scope.

   ![Errors marked with wavy underlines in OnGet method](media/csharp-aspnet-razor-add-new-on-get-method.png)

    Open the **Error List** toolbar to see the same errors listed there. (If you don't see the **Error List** toolbar, choose **View** > **Error List** from the top menu bar.)

   ![Error List in Visual Studio](media/csharp-aspnet-razor-error-list.png)

1. Let's fix this. In the code editor, place your cursor on either line that contains the error, and then choose the Quick Actions light bulb in the left margin. Then, from the drop-down menu, choose **using System;** to add this directive to the top of your file and resolve the errors.

   ![Add the "using System;" directive](media/csharp-aspnet-razor-add-usings.png)

1. Press **Ctrl**+**S** to save your changes, and then press **F5** to open your project in the web browser.

1. At the top of the web site, choose **About** to view your changes.

   ![View the updated About page that includes the changes you made](media/csharp-aspnet-razor-browser-page-about-changed.png)

1. Close the web browser, press **Shift**+**F5** to stop Debug mode, and then close Visual Studio.

::: moniker-end

::: moniker range="=vs-2019"

## Tour your solution

 1. The project template creates a solution with a single ASP.NET Core project that is named _MyCoreApp_. Choose the **Solution Explorer** tab to view its contents.

    ![Screenshot of the Solution Explorer in Visual Studio showing the contents of the ASP.NET core project named 'MyCoreApp'.](media/csharp-aspnet-razor-solution-explorer-mycoreapp.png)

 1. Expand the **Pages** folder.

     ![Screenshot of the Solution Explorer in Visual Studio showing the contents of the Pages folder for 'MyCoreApp'.](media/vs-2019/csharp-aspnet-solution-explorer-pages.png)

 1. View the **Index.cshtml** file in the code editor.

     ![Screenshot showing the Index.cshtml file open in the Visual Studio code editor.](media/vs-2019/csharp-aspnet-index-cshtml.png)

 1. Each .cshtml file has an associated code file. To open the code file in the editor, expand the **Index.cshtml** node in Solution Explorer, and choose the **Index.cshtml.cs** file.

     ![Screenshot of the Solution Explorer in Visual Studio  showing the Index.cshtml.cs file selected.](media/vs-2019/csharp-aspnet-choose-index-cshtml.png)

 1. View the **Index.cshtml.cs** file in the code editor.

     ![Screenshot showing the Index.cshtml.cs file open in the Visual Studio code editor.](media/vs-2019/csharp-aspnet-index-cshtml-editing.png)

 1. The project contains a **wwwroot** folder that is the root for your website. Expand the folder to view its contents.

     ![Screenshot of the Solution Explorer in Visual Studio showing the contents of the 'wwwroot' folder.](media/csharp-aspnet-razor-solution-explorer-wwwroot.png)

    You can put static site content&mdash;such as CSS, images, and JavaScript libraries&mdash;directly in the paths where you want them.

 1. The project also contains configuration files that manage the web app at run time. The default application [configuration](/aspnet/core/fundamentals/configuration) is stored in *appsettings.json*. However, you can override these settings by using *appsettings.Development.json*. Expand the **appsettings.json** file to view the **appsettings.Development.json** file.

     ![Screenshot of the Solution Explorer in Visual Studio showing the appsettings.json file selected and expanded to show the appsettings.Development.json file.](media/csharp-aspnet-razor-solution-explorer-appsettingsjson.png)

## Run, debug, and make changes

1. Choose the **IIS Express** button in the IDE to build and run the app in Debug mode. (Alternatively, press **F5**, or choose **Debug** > **Start Debugging** from the menu bar.)

     ![Screenshot showing the IIS Express button highlighted in the Visual Studio IDE.](media/csharp-aspnet-razor-iisexpress.png)

     > [!NOTE]
     > If you get an error message that says **Unable to connect to web server 'IIS Express'**, close Visual Studio and then open it by using the **Run as administrator** option from the right-click or context menu. Then, run the application again.
     >
     > You might also get a message that asks if you want to accept an IIS SSL Express certificate. To view the code in a web browser, choose **Yes**, and then choose **Yes** if you receive a follow-up security warning message.

1. Visual Studio launches a browser window. You should then see **Home**, and **Privacy** pages in the menu bar.

1. Choose **Privacy** from the menu bar.

   The **Privacy** page in the browser renders the text that is set in the *Privacy.cshtml* file.

   ![Screenshot showing the MyCoreApp Privacy page with the  text 'Use this page to detail your site's privacy policy.'.](media/vs-2019/csharp-aspnet-browser-page-privacy.png)

1. Return to Visual Studio, and then press **Shift+F5** to stop Debug mode. This also closes the project in the browser window.

1. In Visual Studio, open **Privacy.cshtml** for editing. Then, delete the words _Use this page to detail your site's privacy policy_ and in its place, add the words _This page is under construction as of @ViewData["TimeStamp"]_.

    ![Screenshot showing the Privacy.cshtml file open in the Visual Studio code editor with the updated text.](media/vs-2019/csharp-aspnet-privacy-cshtml-code-changed.png)

1. Now, let's make a code change. Choose **Privacy.cshtml.cs**. Then, clean up the `using` directives at the top of the file by using the following shortcut:

   Choose any of the grayed-out `using` directives and a [Quick Actions](../../ide/quick-actions.md) light bulb will appear just below the caret or in the left margin. Choose the light bulb, and then hover over **Remove unnecessary usings**.

   ![Screenshot showing the Privacy.cshtml file in the Visual Studio code editor with the dialog for 'Remove Unnecessary Usings' open.](media/vs-2019/csharp-aspnet-remove-unnecessary-usings.png)

   Now choose **Preview changes** to see what will change.

   ![Screenshot showing the Preview Changes dialog that shows the new list of 'Usings' and the code in the Privacy.cshtml file.](media/vs-2019/csharp-aspnet-preview-changes.png)

   Choose **Apply**. Visual Studio deletes the unnecessary `using` directives from the file.

1. Next, in the `OnGet()` method, change the body to the following code:

     ```csharp
     public void OnGet()
     {
        string dateTime = DateTime.Now.ToShortDateString();
        ViewData["TimeStamp"] = dateTime;
     }
    ```

1. Notice that two wavy underlines appear under **DateTime**. The wavy underlines appear because this type isn't in scope.

   ![Screenshot showing errors marked with wavy underlines in the OnGet method.](media/vs-2019/csharp-aspnet-add-new-onget-method.png)

    Open the **Error List** toolbar to see the same errors listed there. (If you don't see the **Error List** toolbar, choose **View** > **Error List** from the top menu bar.)

   ![Error List in Visual Studio](media/vs-2019/csharp-aspnet-error-list.png)

1. Let's fix this. In the code editor, place your cursor on either line that contains the error, and then choose the Quick Actions light bulb in the left margin. Then, from the drop-down menu, choose **using System;** to add this directive to the top of your file and resolve the errors.

   ![Screenshot showing the Quick Actions menu with a suggestion to add the 'using System' directive.](media/vs-2019/csharp-aspnet-add-usings.png)

1. Press **F5** to open your project in the web browser.

1. At the top of the web site, choose **Privacy** to view your changes.

   ![Screenshot showing the updated Privacy page that includes the changes you made.](media/vs-2019/csharp-aspnet-browser-page-privacy-changed.png)

1. Close the web browser, press **Shift**+**F5** to stop Debug mode, and then close Visual Studio.
::: moniker-end

::: moniker range=">=vs-2022"

## Tour your solution

 1. The project template creates a solution with a single ASP.NET Core project that is named *MyCoreApp*. Choose the **Solution Explorer** tab to view its contents.

     :::image type="content" source="media/vs-2022/csharp-aspnet-razor-solution-explorer-mycoreapp.png" alt-text="Screenshot of the Solution Explorer in Visual Studio showing the contents of the ASP.NET core project named 'MyCoreApp'.":::

 1. Expand the **Pages** folder.

     :::image type="content" source="media/vs-2022/csharp-aspnet-solution-explorer-pages.png" alt-text="Screenshot of the Solution Explorer in Visual Studio showing the contents of the Pages folder for 'MyCoreApp'.":::

 1. View the **Index.cshtml** file in the code editor.

     :::image type="content" source="media/vs-2022/csharp-aspnet-index-cshtml.png" alt-text="Screenshot showing the Index.cshtml file open in the Visual Studio code editor.":::

 1. Each .cshtml file has an associated code file. To open the code file in the editor, expand the **Index.cshtml** node in Solution Explorer, and choose the **Index.cshtml.cs** file.

     :::image type="content" source="media/vs-2022/csharp-aspnet-choose-index-cshtml.png" alt-text="Screenshot of the Solution Explorer in Visual Studio  showing the Index.cshtml.cs file selected.":::

 1. View the **Index.cshtml.cs** file in the code editor.

     :::image type="content" source="media/vs-2022/csharp-aspnet-index-cshtml-editing.png" alt-text="Screenshot showing the Index.cshtml.cs file open in the Visual Studio code editor.":::

 1. The project contains a **wwwroot** folder that is the root for your website. Expand the folder to view its contents.

     :::image type="content" source="media/vs-2022/csharp-aspnet-razor-solution-explorer-wwwroot.png" alt-text="Screenshot of the Solution Explorer in Visual Studio showing the contents of the 'wwwroot' folder.":::

    You can put static site content&mdash;such as CSS, images, and JavaScript libraries&mdash;directly in the paths where you want them.

 1. The project also contains configuration files that manage the web app at run time. The default application [configuration](/aspnet/core/fundamentals/configuration) is stored in *appsettings.json*. However, you can override these settings by using *appsettings.Development.json*. Expand the **appsettings.json** file to view the **appsettings.Development.json** file.

     :::image type="content" source="media/vs-2022/csharp-aspnet-razor-solution-explorer-appsettingsjson.png" alt-text="Screenshot of the Solution Explorer in Visual Studio showing the appsettings.json file selected and expanded to show the appsettings.Development.json file.":::

## Run, debug, and make changes

1. Select the **IIS Express** button in the IDE to build and run the app in Debug mode. (Alternatively, press **F5**, or choose **Debug** > **Start Debugging** from the menu bar.)

     :::image type="content" source="media/vs-2022/csharp-aspnet-razor-iisexpress.png" alt-text="Screenshot showing the IIS Express button highlighted in the Visual Studio IDE.":::

     > [!NOTE]
     > If you get an error message that says **Unable to connect to web server 'IIS Express'**, close Visual Studio and then open it by using the **Run as administrator** option from the right-click or context menu. Then, run the application again.
     >
     > You might also get a message that asks if you want to accept an IIS SSL Express certificate. To view the code in a web browser, choose **Yes**, and then choose **Yes** if you receive a follow-up security warning message.

1. Visual Studio launches a browser window. You should then see **Home**, and **Privacy** pages in the menu bar.

1. Choose **Privacy** from the menu bar.

   The **Privacy** page in the browser renders the text that is set in the *Privacy.cshtml* file.

   :::image type="content" source="media/vs-2022/csharp-aspnet-browser-page-privacy.png" alt-text="Screenshot showing the MyCoreApp Privacy page with the text 'Use this page to detail your site's privacy policy.'.":::

1. Return to Visual Studio, and then press **Shift+F5** to stop Debug mode. This also closes the project in the browser window.

1. In Visual Studio, open **Privacy.cshtml** for editing. Then, delete the words *Use this page to detail your site's privacy policy* and in its place, add the words *This page is under construction as of @ViewData["TimeStamp"]*.

   :::image type="content" source="media/vs-2022/csharp-aspnet-privacy-cshtml-code-changed.png" alt-text="Screenshot showing the Privacy.cshtml file open in the Visual Studio code editor with the updated text.":::

1. Now, let's make a code change. Choose **Privacy.cshtml.cs**. Then, clean up the `using` directives at the top of the file by selecting the following shortcut:

   Choose any of the grayed-out `using` directives and a [Quick Actions](../../ide/quick-actions.md) light bulb will appear just below the caret or in the left margin. Choose the light bulb, and then hover over **Remove unnecessary usings**.

   :::image type="content" source="media/vs-2022/csharp-aspnet-remove-unnecessary-usings.png" alt-text="Screenshot showing the Privacy.cshtml file in the Visual Studio code editor with the dialog for 'Remove Unnecessary Usings' open.":::

   Now choose **Preview changes** to see what will change.

   :::image type="content" source="media/vs-2022/csharp-aspnet-preview-changes.png" alt-text="Screenshot showing the Preview Changes dialog with the new list of 'Usings' and the code in the Privacy.cshtml file.":::

   Choose **Apply**. Visual Studio deletes the unnecessary `using` directives from the file.

1. Next, create a string for the current date that is formatted for your culture or region by using the [DateTime.ToString](xref:System.DateTime.ToString%2A) method.

   - The first argument for the method specifies how the the date should be displayed. This example uses the format specifier (`d`) which indicates the short date format. 
   - The second argument is the [CultureInfo](/dotnet/api/system.globalization.cultureinfo) object that specifies the culture or region for the date. This argument determines, among other things, the language of any words in the date, and the type of separators used.
 
Change the body of the `OnGet()` method to the following code:

   ```csharp
   public void OnGet()
   {
      string dateTime = DateTime.Now.ToString("d", new CultureInfo("en-US"));
      ViewData["TimeStamp"] = dateTime;
   }
   ```

1. Notice that two wavy underlines appear under **CultureInfo**. The wavy underlines appear because this type isn't in scope.

   :::image type="content" source="media/vs-2022/csharp-aspnet-add-new-onget-method.png" alt-text="Screenshot showing the OnGet method in the code editor with a wavy underline below the CultureInfo object.":::

    Open the **Error List** toolbar to see the same errors listed there. (If you don't see the **Error List** toolbar, choose **View** > **Error List** from the top menu bar.)

   :::image type="content" source="media/vs-2022/csharp-aspnet-error-list.png" alt-text="Screenshot showing the Error List window in Visual Studio. The type 'CultureInfo' is missing a using directive.":::

1. Let's fix this. In the code editor, place your cursor on either line that contains the error, and then choose the Quick Actions light bulb in the left margin. Then, from the drop-down menu, choose **using System.Globalization;** to add the directive to the top of your file and resolve the errors.

   :::image type="content" source="media/vs-2022/csharp-aspnet-add-usings.png" alt-text="Screenshot showing the Quick Actions menu with a suggestion to add the 'using System.Globalization' directive.":::

1. Press **F5** to open your project in the web browser.

1. At the top of the web site, choose **Privacy** to view your changes.

   :::image type="content" source="media/vs-2022/csharp-aspnet-browser-page-privacy-changed.png" alt-text="Screenshot showing the Privacy page of the MyCoreApp that includes the changes made to add the date.":::

1. Close the web browser, press **Shift**+**F5** to stop Debug mode, and then close Visual Studio.

::: moniker-end

## Quick answers FAQ

Here's a quick FAQ to highlight some key concepts.

### What is C#?

[C#](/dotnet/csharp/tour-of-csharp/) is a type-safe and object-oriented programming language that's designed to be both robust and easy to learn.

### What is ASP.NET Core?

ASP.NET Core is an open-source and cross-platform framework for building internet-connected applications, such as web apps and services. ASP.NET Core apps can run on either .NET Core or the .NET Framework. You can develop and run your ASP.NET Core apps cross-platform on Windows, Mac, and Linux. ASP.NET Core is open source at [GitHub](https://github.com/aspnet/home).

### What is Visual Studio?

Visual Studio is an integrated development suite of productivity tools for developers. Think of it as a program you can use to create programs and applications.

## Next steps

Congratulations on completing this tutorial! We hope you learned a little bit about C#, ASP.NET Core, and the Visual Studio IDE. To learn more about creating a web app or website with C# and ASP.NET, continue with the following tutorial:

> [!div class="nextstepaction"]
> [Create a Razor Pages web app with ASP.NET Core](/aspnet/core/tutorials/razor-pages/?view=aspnetcore-2.1&preserve-view=true)

Or, learn how to containerize your web app with Docker:

> [!div class="nextstepaction"]
> [Container Tools in Visual Studio](../../containers/overview.md)

## See also

[Publish your web app to Azure App Service by using Visual Studio](../../deployment/quickstart-deploy-to-azure.md)
