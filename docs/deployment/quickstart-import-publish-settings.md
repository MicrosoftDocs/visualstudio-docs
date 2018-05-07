---
title: "Publish by importing publish settings"
ms.custom: "Create an import a publishing profile to deploy an application from Visual Studio"
ms.date: "05/03/2018"
ms.technology: vs-ide-deployment
ms.topic: "quickstart"
helpviewer_keywords: 
  - "deployment, publish settings"
author: mikejo5000
ms.author: mikejo
manager: douge
ms.workload: 
  - "multiple"
---
# Publish an application by importing publish settings in Visual Studio

You can use the **Publish** tool to create publish settings, import publish settings, and then deploy your app. In this article, we use a Web Deploy profile, but you can use the same steps for any type of publishing profile created in Visual Studio, such as a profile for deployment to a folder or to Azure App Service.

These steps apply to ASP.NET, ASP.NET Core, .NET Core, and Python apps in Visual Studio. For Node.js, the steps are supported but the user interface is different.

## Prerequisites

Follow the steps in [Publish a web app or a .NET Core app to a web site](../deployment/quickstart-deploy-to-a-website.md) to first create a publishing profile.

## Create a new project 

1. In Visual Studio, choose **File > New Project**.

1. Under **Visual C#** or **Visual Basic**, choose **Web**, and then in the middle pane choose either **ASP.NET Web Application (.NET Framework)** or (C# only) **ASP.NET Core Web Application**, and then click **OK**.

1. Choose **MVC**, make sure that **No Authentication** is selected, and then click **OK**.

1. Type a name like **MyWebApp** and click **OK**.

    Visual Studio creates the project.

1. Choose **Build > Build Solution** to build the project.

## Import the publish settings and deploy

1. In Solution Explorer, right-click the project and choose **Publish**.

    ![Choose Publish](../deployment/media/quickstart-publish-aspnet.png "Choose Publish")

1. In the **Pick a publish target** dialog box, click **Import Profile**.

    > [!NOTE]
    > If you have previously configured any publishing profiles, the **Publish** pane appears instead. In this scenario, click **New Profile**, then click **Import Profile** in the dialog box.

1. Navigate to the location of the publishing profile you created in the article, [Publish a web app or a .NET Core app to a web site](../deployment/quickstart-deploy-to-a-website.md).

    By default, you can find the publishing profile, *<profilename>.pubxml*, in the *\<projectname>\Properties\PublishProfiles* folder for managed project types. For websites, look under the *\App_Data* folder. The publishing profiles are MSBuild xml files.

1. In the **Import Publish Settings File** dialog box, switch the file types to open from **Profile Settings Files (.publishsettings)** to **All Files**.

1. Select the profile you previously created, and click **Open**.

1. Click **Publish**.

    The profile publish settings dialog box opens.

    ![Choose Folder](../deployment/media/quickstart-publish-settings-web.png "Choose Folder")

1. To publish, click **Publish**.

    The Output window shows deployment progress and results.

For more information on ASP.NET publish profiles for Visual Studio see [Visual Studio publish profiles for ASP.NET Core app deployment](/aspnet/core/host-and-deploy/visual-studio-publish-profiles).

## Next steps

- [First look at deployment](../deployment/deploying-applications-services-and-components.md)
