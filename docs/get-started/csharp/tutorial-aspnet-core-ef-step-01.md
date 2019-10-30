---
title: "ASP.NET Core web app with Entity Framework & Visual Studio 2019"
titleSuffix: ""
description: "As the first step prior to creating an ASP.NET Core web app, learn how to install Visual Studio 2019 with this video tutorial and step-by-step instructions."
ms.custom: "get-started"
ms.date: 03/31/2019
ms.technology: vs-ide-general
ms.prod: visual-studio-windows
monikerRange: vs-2019
ms.topic: tutorial
ms.devlang: CSharp
author: ardalis
ms.author: tglee
manager: jillfra
dev_langs:
  - CSharp
ms.workload:
  - "aspnet"
  - "dotnetcore"
---
# Tutorial: Create your first ASP.NET Core App using Entity Framework with Visual Studio 2019

In this tutorial, you'll create an ASP.NET Core web app that uses data, and deploy it to Azure. This tutorial consists of the following steps:

- [Step 1: Install Visual Studio 2019](#step-1-install-visual-studio-2019)
- [Step 2: Create your first ASP.NET Core web app](tutorial-aspnet-core-ef-step-02.md)
- [Step 3: Work with data using Entity Framework](tutorial-aspnet-core-ef-step-03.md)
- [Step 4: Expose a web API from your ASP.NET Core app](tutorial-aspnet-core-ef-step-04.md)
- [Step 5: Deploy your ASP.NET Core app to Azure](tutorial-aspnet-core-ef-step-05.md)

## Step 1: Install Visual Studio 2019

Learn how to install Visual Studio 2019 with this video tutorial and step-by-step instructions. If you have already installed Visual Studio, skip ahead to [Step 2: Create your first ASP.NET Core web app](tutorial-aspnet-core-ef-step-02.md).

_Watch this video and follow along to install Visual Studio and create your first ASP.NET Core app._

> [!VIDEO https://www.youtube.com/embed/Fz_HAqQGLtY]

## Download the Installer

Go to [visualstudio.com](https://visualstudio.com) to find the installer. Locate the Visual Studio 2019 link, and click it to start the download. For a free version of Visual Studio, choose Visual Studio Community.

## Start the Installer

Once the download has completed, click **Run** to start the installer.

![Visual Studio 2019 Installer](media/vs-2019/vs2019-installer.png)

## Choose workloads

Visual Studio can be used for many different kinds of development, and workloads make it easy for you to download everything you need for the kind of apps you want to build. Choose **ASP.NET and Web Development** and **.NET Core cross-platform development** workloads for now. You can always relaunch the installer later to install additional workloads and components.

![Visual Studio 2019 Choose Workloads](media/vs-2019/vs2019-choose-workloads.png)

## Install

Click **Install** and let the installer download and install Visual Studio.

## Run Visual Studio for the first time

Visual Studio should launch automatically when the installer finishes. You may be prompted to sign in, which has some nice features associated with it, but for now you can choose to do so later. Next you can choose your theme and development settings. Once you've made these choices, you'll be ready to start your first project. Click **Create a new project** and then choose **ASP.NET Core Web Application**.

![Visual Studio 2019 Create New ASP.NET Core Web Application Project](media/vs-2019/vs2019-create-new-project.png)

## Explore ASP.NET Core project types

You can choose your project name and location, then pick **Create**. Now choose which template to use for your ASP.NET Core application. You can choose from the following options:

- Empty. An empty project template that lets you start from scratch.
- API. Best for web APIs.
- Web Application. A standard ASP.NET Core web application built with Razor Pages.
- Web Application (Model-View-Controller). A standard ASP.NET Core web application using the Model-View-Controller pattern.
- Angular.
- React.js.
- React.js / Redux.
- Razor Class Library. Used to share Razor assets between projects.

Note that for most of the project templates you can also choose to enable Docker support by checking a box. You can also add Authentication support by clicking the change Authentication button. From there you can choose from:

- No Authentication.
- Individual User Accounts. These are stored in a local or Azure-based database.
- Work or School Accounts. This option uses Active Directory, Azure AD, or Office 365 for authentication.
- Windows Authentication. Suitable for intranet applications.

Select the standard Web Application template with No Authentication and click **Create**.

![Visual Studio 2019 Choose ASP.NET Core Project Options](media/vs-2019/vs2019-choose-aspnetcore-project.png)

## Next steps

In the next video, you'll learn more about your first ASP.NET Core project.

[Tutorial: Creating Your First ASP.NET Core Web App](tutorial-aspnet-core-ef-step-02.md)

## See also

- [Tutorial: Get started with C# and ASP.NET Core](tutorial-aspnet-core.md) A more detailed tutorial without a video walkthrough
