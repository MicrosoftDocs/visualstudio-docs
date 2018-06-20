---
title: Deploy to a local folder
ms.custom: ""
ms.date: "06/20/2018"
ms.technology: vs-ide-deployment
ms.topic: "quickstart"
helpviewer_keywords: 
  - "deployment, local folder"
ms.assetid: adb461c4-812a-4b8c-b2ab-96002379f6a9
author: mikejo5000
ms.author: mikejo
manager: douge
ms.workload: 
  - "multiple"
---
# Deploy an app to a local folder using Visual Studio

You can use the **Publish** tool to publish ASP.NET, ASP.NET Core, .NET Core, and Python apps to a local folder from Visual Studio. For Node.js, the steps are supported but the user interface is different.

[!INCLUDE [quickstart-prereqs](includes/quickstart-prereqs.md)]

## Deploy to a local folder

1. In Solution Explorer, right-click the project and choose **Publish** (or use the **Build** > **Publish** menu item).

    ![Choose Publish](../deployment/media/quickstart-publish.png "Choose Publish")

1. If you have previously configured any publishing profiles, the **Publish** pane appears. Select **Create new profile**.

1. In the **Pick a publish target** dialog box, choose **Folder**.

    ![Choose Folder](../deployment/media/quickstart-publish-folder.png "Choose Folder")

1. Enter a path or select **Browse** to specify a local folder.

1. Select **Publish**. Visual Studio builds the project and publishes it to the specified folder. The Publish pane shows a profile summary, including a link to the deployment folder. You can navigate to the folder with **Ctrl**+click.

1. To configure deployment settings, click **Settings** in the profile summary.

    ![Profile settings](../deployment/media/quickstart-profile-settings.png "Profile settings") 

1. Configure options such as whether to deploy a Debug or Release configuration, and then click **Save**.

1. To republish, select **Publish**.

Deploy the published files in any way you like. For example, you can package them in a Zip file, use a simple copy command, or deploy them with any installation package of your choice.

## Next steps

- [Deploy a .NET Core Application with the Publish tool](/dotnet/core/deploying/deploy-with-vs?toc=/visualstudio/deployment/toc.json&bc=/visualstudio/deployment/_breadcrumb/toc.json)
- [Package a desktop app for Microsoft Store (Desktop Bridge)](/windows/uwp/porting/desktop-to-uwp-packaging-dot-net?toc=/visualstudio/deployment/toc.json&bc=/visualstudio/deployment/_breadcrumb/toc.json)
- (.NET) [Deploy the .NET Framework and applications](/dotnet/framework/deployment/)
