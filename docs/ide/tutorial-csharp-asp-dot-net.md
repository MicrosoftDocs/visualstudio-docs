---
title: "Getting started with C# and ASP.NET Core in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "12/15/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-acquisition"
ms.tgt_pltfrm: ""
ms.topic: "tutorial"
ms.devlang: "CSharp"
author: "TerryGLee"
ms.author: "tglee"
manager: ghogen
dev_langs:
  - CSharp
---
# Getting started with C# and ASP.NET in Visual Studio
In this tutorial for C# development for ASP.NET Core using Visual Studio, you'll create a C# ASP.NET Core web app, add code to it, explore some features of the IDE, and run the app.

If you haven't already installed Visual Studio, go to the [Visual Studio Downloads](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocs) page to install it for free.

## Create a project
First, you'll create a ASP.NET Core project. The project type comes with all the template files you'll need, before you've even added anything!

1. Open Visual Studio 2017.

2. From the top menu bar, choose **File** > **New** > **Project...**.

3. In the **New Project** dialog box in the left pane, expand **Visual C#**, and then choose **.NET Core**. In the middle pane, choose **ASP.NET Core Web Application**, and then choose **OK**.

     If you don't see the **.NET Core** project template, cancel out of the **New Project** dialog box and from the top menu bar, choose **Tools** > **Get Tools and Features...**. The Visual Studio Installer launches. Choose the **ASP.NET and web development** workload, and then choose **Modify**.  

     ![ASP.NET and web development workload in the Visual Studio Installer](../ide/media/addthis.png)

4. In the **New ASP.NET Core Web Application** dialog box, select **ASP.NET Core 2.0** from the top drop-down menu. (If you don't see **ASP.NET Core 2.0** in the list, install it by following the **Download** link that should appear in a yellow bar near the top of the dialog box.) Choose **OK**.

   ![New ASP.NET Core Web Application dialogbox](../ide/media/quickstart-aspnet-core20.png)

## Explore the IDE

1. In the **Solution Explorer** toolbar, expand the **Pages** folder, then choose **About.cshtml** to open it in the editor. This file corresponds to a page called **About** in the web application.

2. In the editor, choose `AboutModel` and then press **F12** or choose **Go To Definition** from the context (right-click) menu. This command takes you to the definition of the `AboutModel` C# class.

   ![Go To Definition context menu](../ide/media/quickstart-aspnet-gotodefinition.png)

3. Next we'll clean up the `using` directives at the top of the file by using a simple shortcut. Choose any of the greyed-out "using" directives and a [Quick Actions](../ide/quick-actions.md) light bulb will appear just below the caret or in the left margin. Choose the light bulb, and then choose **Remove Unnecessary Usings**.

## Add code

Add content here

## Run the application

Add content here


Congratulations on completing this tutorial!

## See also   
[Getting started with Razor Pages in ASP.NET Core](/aspnet/core/tutorials/razor-pages/razor-pages-start)
