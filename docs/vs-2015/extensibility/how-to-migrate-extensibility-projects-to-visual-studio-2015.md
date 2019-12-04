---
title: "How to: Migrate Extensibility Projects to Visual Studio 2015 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "Visual Studio SDK, upgrading"
ms.assetid: 22491cdc-8f04-4e1c-8eb4-ff33798ec792
caps.latest.revision: 26
ms.author: gregvanl
manager: jillfra
---
# How to: Migrate Extensibility Projects to Visual Studio 2015
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Here’s how to upgrade your extension.  
  
> [!IMPORTANT]
> If you intend to maintain a version of your extension solution for an earlier version of Visual Studio, be sure to make a copy before you upgrade it. It may be difficult to return the upgraded version to its previous state.  
  
#### To upgrade an extensibility solution  
  
1. Using the copy you want to upgrade, open it in the new version. You will be advised that the upgrade is not reversible.  
  
2. After the upgrade completes, change the path of the external program to the new version of devenv.exe. Right-click the project node in the **Solution Explorer**, then choose **Properties**. In the **Debug** tab, find the textbox by **Start external program** and change the path of devenv.exe to the Visual Studio 2015 path, which should look something like this:  
  
     **%ProgramFiles%\Microsoft Visual Studio 14.0\Common7\IDE\devenv.exe**  
  
3. Add a reference to Microsoft.VisualStudio.Shell.14.0.dll. (Right-click the project node in the **Solution Explorer** and then choose **Add / Reference**. Select the **Extensions** tab and then check **Microsoft.VisualStudio.Shell.14.0**.)  
  
4. Build the solution. The built files are deployed to:  
  
     **%LOCALAPPDATA%\Microsoft\VisualStudio.14.0Exp\Extensions\\<Author Name\>\\<Project Name\>\\<Project Version\>\\**.  
  
#### To update an extensibility project to NuGet VS SDK reference assemblies  
  
1. Determine the VS SDK reference assemblies your project needs.  In **Solution Explorer**, expand the project’s **References** node and review the list of project references.  VS SDK references assemblies will have the prefix **Microsoft.VisualStudio** in the name (for example: Microsoft.VisualStudio.Shell.14.0).  
  
2. Remove the VS SDK reference assemblies from the project by selecting them, right click and **Remove**.  
  
3. Add the NuGet versions of the VS SDK reference assemblies.  While still in the **Solution Explorer References** node, open the **Manage NuGet Packages…** dialog.  If you want to learn more about this dialog, see [Manage NuGet Packages Using the Dialog](https://docs.microsoft.com/nuget/consume-packages/install-use-packages-visual-studio). The VS SDK reference assemblies are published on [nuget.org](https://www.nuget.org/) by [VisualStudioExtensibility](https://www.nuget.org/profiles/VisualStudioExtensibility).  
  
4. Using **nuget.org** as your **Package Source**, search for the NuGet package name which matches the desired reference assembly (for example: Microsoft.VisualStudio.Shell.14.0) and install it in your project.  NuGet may add multiple reference assemblies in order to satisfy the initial assembly’s dependencies.  
  
     If you prefer, you can add all the VS SDK reference assemblies at once by installing the VS SDK [Meta package](https://www.nuget.org/packages/VSSDK_Reference_Assemblies).  
  
5. You can also switch to using the NuGet version of the VS SDK build tools. This NuGet package is [Microsoft.VSSDK.BuildTools](https://www.nuget.org/packages/Microsoft.VSSDK.BuildTools) and once added to your project will include the necessary tools and target files to let you build your extensibility project on a computer without the VS SDK installed.  
  
> [!NOTE]
> It is not required that you update your existing extensibility projects to use NuGet reference assemblies and tools.  They can continue to build using reference assemblies and tools installed with the VS SDK.
