---
title: "First look at deployment"
description: Explore application deployment options in Visual Studio, including Azure, the web, network shares, devices, Microsoft Store, and Windows desktop installer packages.
ms.date: 11/14/2024
ms.topic: conceptual
dev_langs:
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - ".NET applications, deploying"
  - "components [Visual Studio], deploying"
  - "installers"
  - "publishing"
  - "deploying applications [Visual Studio]"
  - "deploying applications [Visual Studio], about deploying applications"
  - "components [.NET Framework], deploying"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: deployment
ms.custom: peer-review-program
---
# First look at deployment in Visual Studio

By deploying an application, service, or component, you distribute it for installation on other computers, devices, or servers, or in the cloud. You choose the appropriate method in Visual Studio for the type of deployment that you need. (Many app types support other deployment tools, such as command-line deployment or NuGet, that aren't described here.)

See the quickstarts and tutorials for step-by-step deployment instructions. For an overview of deployment options, see [What publishing options are right for me?](deploying-applications-services-and-components-resources.md#what-publishing-options-are-right-for-me).

## Deploy to a local folder

Deployment to a local folder is typically used for testing or to begin a staged deployment in which another tool is used for final deployment.

- **ASP.NET**, **ASP.NET Core**, **Node.js**, **Python**, **.NET Core**, and **.NET 5 and later**: Use the **Publish** tool to deploy to a local folder. The exact options available depend on your app type. In Solution Explorer, right-click your project and select **Publish**. (If you haven't previously configured any publishing profiles, you must then select **Create new profile**.) Next, select **Folder**. For more information, see [Publish an ASP.NET app](quickstart-deploy-aspnet-web-app.md?tabs=folder).

    ![Screenshot that shows selecting Publish.](../deployment/media/quickstart-publish.png)

- **Windows desktop**: You can publish a Windows desktop application to a folder by using ClickOnce deployment. Users can then install the application with a single click. For more information, see the following articles:

  - [Deploy a .NET Windows desktop app using ClickOnce](quickstart-deploy-using-clickonce-folder.md)
  - [Deploy a .NET Framework Windows desktop app using ClickOnce](how-to-publish-a-clickonce-application-using-the-publish-wizard.md).
  - (C++/CLR) [Deploy a C++/CLR app using ClickOnce](/cpp/windows/clickonce-deployment-for-visual-cpp-applications)
  - (C/C++) [Deploy a native app using a Setup project](/cpp/windows/walkthrough-deploying-a-visual-cpp-application-by-using-a-setup-project)

## Publish to Azure

- **ASP.NET**, **ASP.NET Core**, **Python**, and **Node.js**: Publish to Azure App Service or Azure App Service on Linux by using one of the following methods:

  - For continuous (or automated) deployment of apps, use Azure DevOps with [Azure Pipelines](/azure/devops/pipelines/tasks/build/visual-studio-build).
  - For one-time (or manual) deployment of apps, use the [Publish](publish-overview.md) tool in Visual Studio. See [Deploy an ASP.NET Web app](/azure/app-service/quickstart-dotnetcore).
  - To create GitHub Actions workflows for ASP.NET and Azure Function projects hosted on GitHub.com, see [Deploy to Azure using GitHub Actions](/visualstudio/azure/azure-deployment-using-github-actions).
  - For deployment using Git, see [Continuous deployment of ASP.NET Core to Azure with Git](/azure/app-service/deploy-continuous-deployment).

  To use the **Publish** tool, right-click the project in Solution Explorer and select **Publish**. (If you've previously configured any publishing profiles, you must then select **Create new profile**.) In the **Publish** dialog box, choose **Azure**, and then choose the desired Azure service to continue.

  ![Screenshot that shows selecting Azure App Service.](../deployment/media/quickstart-publish-azure-new.png "Choose Azure App Service")

  > [!NOTE]
  > If you don't already have an Azure account, you can [sign up here](https://azure.microsoft.com/pricing/purchase-options/azure-account?cid=msft_learn).

## Publish to the web or deploy to a network share

- **ASP.NET**, **ASP.NET Core**, **Node.js**, and **Python**: You can use the **Publish** tool to deploy to a website by using FTP or Web Deploy. For more information, see [Publish an ASP.NET app](quickstart-deploy-aspnet-web-app.md?tabs=folder.md?tabs=web-server).

    In Solution Explorer, right-click the project and select **Publish**. (If you've previously configured any publishing profiles, you must then select **Create new profile**.) In the **Publish** tool, select the option you want and follow the configuration steps.

    ![Screenshot that shows selecting IIS.](../deployment/media/quickstart-publish-iis.png)

    For information on importing a publish profile in Visual Studio, see [Import publish settings and deploy to IIS](../deployment/tutorial-import-publish-settings-iis.md).

    You can also deploy ASP.NET applications and services in a number of other ways. For more information, see [Deploying ASP.NET web applications and services](/aspnet/web-forms/overview/deployment/visual-studio-web-deployment/).

- **Windows desktop**: You can publish a Windows desktop application to a web server or a network file share by using ClickOnce deployment. Users can then install the application with a single click. For more information, see the following articles:

  - [Deploy a .NET Framework Windows desktop app using ClickOnce](how-to-publish-a-clickonce-application-using-the-publish-wizard.md)
  - [Deploy a .NET Windows desktop app using ClickOnce](quickstart-deploy-using-clickonce-folder.md)
  - [Deploy a C++/CLR app using ClickOnce](/cpp/windows/clickonce-deployment-for-visual-cpp-applications)

:::moniker range="<=vs-2019"
## Create an installer package (Windows desktop)

If you require a more complex installation of a desktop application than ClickOnce can provide, you can create a Windows Installer package (MSI or EXE installation file) or a custom bootstrapper.

- An MSI-based installer package can be created by using the [WiX Toolset Visual Studio 2019 Extension](https://marketplace.visualstudio.com/items?itemName=WixToolset.WixToolsetVisualStudio2019Extension). This is a command-line toolset.

- An MSI or EXE installer package can be created by using a Setup project (vdproj). To use this option, see [Visual Studio Installer Projects Extension and .NET 6.0](../deployment/installer-projects-net-core.md) or, go directly to the [Visual Studio Installer Projects extension](https://marketplace.visualstudio.com/items?itemName=VisualStudioProductTeam.MicrosoftVisualStudio2017InstallerProjects#overview).

- An MSI or EXE installer package can be created by using [InstallShield](https://www.revenera.com/install/products/installshield/installshield-requirements) from Revenera Software. InstallShield may be used with Visual Studio 2017 and later versions. Community Edition isn't supported.

  > [!NOTE]
  > InstallShield Limited Edition is no longer included with Visual Studio and isn't supported in Visual Studio 2017 and later versions. Check with Revenera Software about future availability.

- You can also install prerequisite components for desktop applications by configuring a generic installer package, which is known as a bootstrapper. For more information, see [Application deployment prerequisites](../deployment/application-deployment-prerequisites.md).
:::moniker-end
:::moniker range=">=vs-2022"
## Create an installer package (Windows desktop)

If you require a more complex installation of a desktop application than ClickOnce can provide, you can create a Windows Installer package (MSI or EXE installation file) or a custom bootstrapper.

- An MSI-based installer package can be created by using the [WiX Toolset Visual Studio 2022 Extension](https://marketplace.visualstudio.com/items?itemName=WixToolset.WixToolsetVisualStudio2022Extension). This is a command-line toolset.

- An MSI or EXE installer package can be created by using a Setup project (vdproj). To use this option, see [Visual Studio Installer Projects Extension and .NET 6.0](../deployment/installer-projects-net-core.md) or, go directly to the [Visual Studio Installer Projects extension](https://marketplace.visualstudio.com/items?itemName=VisualStudioClient.MicrosoftVisualStudio2022InstallerProjects).

- An MSI or EXE installer package can be created by using [InstallShield](https://www.revenera.com/install/products/installshield/installshield-requirements) from Revenera Software. InstallShield may be used with Visual Studio 2017 and later versions. Community Edition isn't supported.

  > [!NOTE]
  > InstallShield Limited Edition is no longer included with Visual Studio and isn't supported in Visual Studio 2017 and later versions. Check with Revenera Software about future availability.

- You can also install prerequisite components for desktop applications by configuring a generic installer package, which is known as a bootstrapper. For more information, see [Application deployment prerequisites](../deployment/application-deployment-prerequisites.md).
:::moniker-end
## Publish to Microsoft Store

From Visual Studio, you can create app packages for deployment to Microsoft Store.

- **UWP**: You can package your app and deploy it by using menu items. For more information, see [Package a UWP app by using Visual Studio](/windows/uwp/packaging/packaging-uwp-apps).

    ![Screenshot that shows creating an app package.](../deployment/media/feature-tour-create-app-package.png)

- **Windows desktop**: You can deploy to Microsoft Store starting in Visual Studio 2017 version 15.4. To do this, start by creating a Windows Application Packaging Project. For more information, see [Package a desktop app for Microsoft Store](/windows/uwp/porting/desktop-to-uwp-packaging-dot-net).

    ![Screenshot that shows selecting Windows Application Packaging Project.](../deployment/media/feature-tour-desktop-bridge.png)

## Deploy as a Windows app 

To package a project as a Windows app that can receive servicing updates, you can create an app installer. See [Create an App Installer file with Visual Studio](/windows/msix/app-installer/create-appinstallerfile-vs).

## Deploy to a device (UWP)

If you're deploying a UWP app for testing on a device, see [Run UWP apps on a remote machine in Visual Studio](../debugger/run-windows-store-apps-on-a-remote-machine.md).

## Deploy to a test lab

You can enable more sophisticated development and testing by deploying your applications into virtual environments. For more information, see [Azure DevTest Labs](/azure/devtest-labs/devtest-lab-overview).

## Continuous deployment

You can use Azure Pipelines to enable continuous deployment of your app. For more information, see [Azure Pipelines](/azure/devops/pipelines/index?view=vsts&preserve-view=true) and [Deploy to Azure](/azure/devops/pipelines/overview-azure).

## Deploy a SQL database

- [Change target platform and publish a database project (SQL Server Data Tools (SSDT))](/sql/ssdt/how-to-change-target-platform-and-publish-a-database-project)
- [Deploy an Analysis Services Project (SSAS)](/sql/analysis-services/multidimensional-tutorial/lesson-2-5-deploying-an-analysis-services-project)
- [Deploy Integration Services (SSIS) projects and packages](/sql/integration-services/packages/deploy-integration-services-ssis-projects-and-packages)
- [Build and deploy to a local database](/sql/ssdt/how-to-build-and-deploy-to-a-local-database)
