---
title: "Installing the Visual Studio SDK | Microsoft Docs"
ms.custom: ""
ms.date: "07/12/2018"
ms.technology: vs-ide-sdk
ms.topic: "conceptual"
ms.assetid: c730edb6-5099-4c16-85a8-08def09f1455
author: "gregvanl"
ms.author: "gregvanl"
manager: douge
ms.workload: 
  - "vssdk"
---
# Installing the Visual Studio SDK

The Visual Studio SDK is an optional feature in Visual Studio setup. You can also install the VS SDK later on.  
  
## Installing the Visual Studio SDK as part of a Visual Studio installation

If you'd like to include the VS SDK in your Visual Studio installation, you should install the **Visual Studio extension development** workload under **Other Toolsets**. This will install the Visual Studio SDK as well as the necessary prerequisites. You can further tune the installation by selecting or unselecting Components from the Summary view. 
  
## Installing the Visual Studio SDK after installing Visual Studio

If you decide to install the Visual Studio SDK after completing your Visual Studio installation, rerun the Visual Studio installer and select the **Visual Studio extension development** workload.  
  
## Installing the Visual Studio SDK from a Solution

If you open a solution with an extensibility project without first installing the VSSDK, you will be prompted by a **Install Missing Feature** dialog to install the **Visual Studio extension development** workload:

![Install extension development](../extensibility/media/install-extension-development.png "Install extension development")  
  
## Installing the Visual Studio SDK from the command line

As with any Visual Studio workload or component, you can also install the **Visual Studio extension development** workload (ID: Microsoft.VisualStudio.Workload.VisualStudioExtension) from the command line. See [Use command-line parameters to install Visual Studio](../install/use-command-line-parameters-to-install-visual-studio.md) for details on the appropriate command line switches and general instructions on determining workload or component identifiers.
  
 Note that you must use the Visual Studio installer that matches your installed version of Visual Studio. For example, if you have Visual Studio Enterprise installed on your computer, you must run the Visual Studio Enterprise installer (vs_enterprise.exe).