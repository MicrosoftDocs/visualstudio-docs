---
title: "Visual Studio Isolated Shell | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "Shell [Visual Studio], shell-based applications%2C isolated mode"
  - "Visual Studio shell, isolated mode"
  - "isolated shell-based applications [Visual Studio]"
  - "Visual Studio shell, shell-based applications%2C isolated mode"
  - "Shell [Visual Studio], isolated mode"
ms.assetid: d2620e71-be9e-44c9-b5b7-03a4c8d9cf0b
caps.latest.revision: 36
ms.author: gregvanl
manager: jillfra
---
# Visual Studio Isolated Shell
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Visual Studio isolated shell allows you to create stand-alone applications that can run side-by-side with other versions of Visual Studio. It is used primarily to host specialized tools that can use Visual Studio services but also have a customized appearance and branding. Visual Studio features and menu command groups can be easily turned on and off. Application titles, application icons, and splash screens are fully customizable. For a list of customizable features, see [Customizing the Isolated Shell](../extensibility/customizing-the-isolated-shell.md).  
  
 To work with an isolated shell project, you must install the Visual Studio SDK. Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).  
  
 To create an isolated shell application, start with a Visual Studio Shell Isolated project. This project contains everything that you need to develop and test your own isolated shell application. When you are ready to write the setup program that deploys your application, you must get the isolated shell redistributable package from [Microsoft Visual Studio Shell (Isolated) Redistributable Package](https://go.microsoft.com/fwlink/?LinkId=616022).  
  
> [!NOTE]
> Before you can access the isolated shell redistributable package, you will be asked to fill out a brief customer survey.  After filling out the survey, you’ll be directed to a Visual Studio Connect page with redistributable package download links.  You can find the download links on subsequent visits to the Visual Studio Connect site under the **PROGRAMS &#124; VISUAL STUDIO 2015 INTEGRATED AND ISOLATED SHELL** tab.  
  
> [!NOTE]
> For more information about how to deploy an isolated shell-based application, see [Walkthrough: Creating a Basic Isolated Shell Application](../extensibility/walkthrough-creating-a-basic-isolated-shell-application.md).  
  
## Working with the isolated shell  
 A Visual Studio isolated shell application has full access to Visual Studio services and supports special customization and branding. There are several ways you can customize an isolated shell application:  
  
- You can use VSPackages and Managed Extensibility Framework (MEF) component parts to extend an isolated shell application just as you would use them in any other Visual Studio extension. For more information, see [Extending the Isolated Shell](../extensibility/extending-the-isolated-shell.md).  
  
- To make Visual Studio features and menu command groups available or unavailable, update the .vsct file in the user interface (UI) project of the application.  
  
- To remove **Options** pages or other Visual Studio shell components from the application, update the .pkgundef file of the application.  
  
- To modify other aspects of the appearance or behavior of the shell, update the .pkgdef file of the application.  
  
- Some aspects of the shell can also be specified when the application is started. To do this, update the parameters in the call to the Start entry point of the appenvstub.dll.  
  
  For more information about the different elements that you can customize, see [Elements of the Isolated Shell](../extensibility/elements-of-the-isolated-shell.md).  
  
## Standard Features of the Isolated Shell  
 The following features are standard to all editions of Visual Studio.  
  
|Feature Category|Feature|  
|----------------------|-------------|  
|IDE Features|Import/Export Settings<br /><br /> Toolbox Control Installer<br /><br /> Task List & Error List<br /><br /> Output Window<br /><br /> Start Page<br /><br /> Properties Window<br /><br /> Toolbox<br /><br /> Solution Explorer<br /><br /> Bookmark Window<br /><br /> Class View<br /><br /> Object Browser<br /><br /> Command Window<br /><br /> Document Outline<br /><br /> Resource View<br /><br /> External Tool<br /><br /> Windows Communication Foundation (WCF) Add Service Reference<br /><br /> Language Integrated Query (LINQ) Support|  
|Editor/Designer|Code browsing tools (unified find, source definition, inheritance)<br /><br /> IntelliSense<br /><br /> SmartTags<br /><br /> Code Snippets Manager<br /><br /> Code Snippets<br /><br /> Refactoring<br /><br /> Pretty listing<br /><br /> IntelliSense Filtering<br /><br /> Code Definition Window<br /><br /> Application Designer<br /><br /> Windows Forms Designer<br /><br /> Windows Presentation Foundation (WPF) Designer|  
|Debugging|C# Expression Evaluator<br /><br /> Local debugging<br /><br /> Managed debugging<br /><br /> Edit and Continue<br /><br /> Cross-thread debugging<br /><br /> Visualizations<br /><br /> DataTips<br /><br /> Native debugging<br /><br /> Script debugging<br /><br /> Interop debugging<br /><br /> Just-in-time (JIT) debugging<br /><br /> Multi-process debugging<br /><br /> XSLT debugging<br /><br /> Attach to local process<br /><br /> Trace Points<br /><br /> Breakpoint Constraints|  
|Data|Server Explorer (Simplified - Data Only)<br /><br /> Data bind to local data (.MDF or .MDB)<br /><br /> Data bind to object<br /><br /> Data bind to Web service<br /><br /> Full set of data controls<br /><br /> XML editor<br /><br /> Data bind to local database server<br /><br /> Data Sources window|  
|Web|HTML Editor<br /><br /> Web Browser<br /><br /> Web Forms Designer<br /><br /> Web Site Project<br /><br /> Web Application Project|  
|Extensibility|Consumes VSPackages and MEF components|  
  
## See Also  
 [Shell (Isolated or Integrated)](../extensibility/shell-isolated-or-integrated.md)
