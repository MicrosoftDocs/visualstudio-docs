---
title: "Installing the Visual Studio SDK | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "visual-studio-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: c730edb6-5099-4c16-85a8-08def09f1455
caps.latest.revision: 3
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# Installing the Visual Studio SDK
The Visual Studio SDK is an optional feature in Visual Studio setup. You can also install the VS SDK later on.  
  
## Installing the Visual Studio SDK as Part of a Visual Studio Installation  
 If you'd like to include the VSSDK in your Visual Studio installation, you should install the **Visual Studio extension development** Workload under **Other Toolsets**. This will install the Visual Studio SDK as well as the necessary prerequisites. You can further tune the installation by selecting or unselecting Components from the Summary view. 
  
## Installing the Visual Studio SDK after Installing Visual Studio  
 If you decide to install the Visual Studio SDK after completing your Visual Studio installation, rerun the Visual Studio installer and select the **Visual Studio extension development** Workload.  
  
## Installing the Visual Studio SDK from a Solution  
 If you open a solution with an extensibility project without first installing the VSSDK, you will be prompted by a highlighted information bar above the Solution Explorer. It should look something like the following:  
  
 ![SolutionExplorerInstall](../extensibility/media/solutionexplorerinstall.png "SolutionExplorerInstall")  
  
## Installing the Visual Studio SDK from the Command Line  
As with any Visual Studio Workload or Component, you can also install the item from the command line. See [Use command-line parameters to install Visual Studio](../install/use-command-line-parameters-to-install-visual-studio.md) for details on the appropriate command line switches and how to determine the Workload or Component identifiers.
  
 Note that you must use the Visual Studio installer that matches your installed version of Visual Studio. For example, if you have Visual Studio Enterprise installed on your computer, you must run the Visual Studio Enterprise installer (vs_enterprise.exe).