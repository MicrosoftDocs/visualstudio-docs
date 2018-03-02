---
title: "Project Solutions | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "projects [Office development in Visual Studio], Project"
  - "Office solutions [Office development in Visual Studio], Project"
  - "Project [Office development in Visual Studio]"
  - "templates [Office development in Visual Studio], Project"
  - "Office projects [Office development in Visual Studio], Project"
  - "solutions [Office development in Visual Studio], Project"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Project Solutions
  [!INCLUDE[vs_dev12](../vsto/includes/vs-dev12-md.md)] provides project templates you can use to create VSTO Add-ins for Microsoft Office Project. You can use VSTO Add-ins to automate Project, extend Project features, or customize the Project user interface (UI).  
  
 For more information about VSTO Add-ins, see [Getting Started Programming VSTO Add-ins](../vsto/getting-started-programming-vsto-add-ins.md) and [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md). If you are new to programming with Microsoft Office, see [Getting Started &#40;Office Development in Visual Studio&#41;](../vsto/getting-started-office-development-in-visual-studio.md).  
  
 [!INCLUDE[appliesto_projallapp](../vsto/includes/appliesto-projallapp-md.md)]  
  
> [!NOTE]  
>  Interested in developing solutions that extend the Office experience across [multiple platforms](https://dev.office.com/add-in-availability)? Check out the new [Office Add-ins model](https://dev.office.com/docs/add-ins/overview/office-add-ins). Office Add-ins have a small footprint compared to VSTO add-ins and solutions, and you can build them by using almost any web programming technology, such as HTML5, JavaScript, CSS3, and XML.  
  
## Automating Project by Using the Project Object Model  
 The Project object model exposes many types that you can use to automate Project. These types enable you to write code to accomplish common tasks such as programmatically creating and modifying tasks in a project.  
  
 To access the Project object model from an VSTO Add-in, use the `Application` field of the `ThisAddIn` class in your project. The `Application` field returns a Microsoft.Office.Interop.MsProject.Application object that represents the current instance of Project. For more information, see [Programming VSTO Add-Ins](../vsto/programming-vsto-add-ins.md).  
  
 When you call into the Project object model, you use types that are provided in the primary interop assembly for Project. The primary interop assembly acts as a bridge between the managed code in the VSTO Add-in and the COM object model in Project. All types in the Project primary interop assembly are defined in the Microsoft.Office.Interop.MSProject namespace. For more information about primary interop assemblies, see [Office Solutions Development Overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md) and [Office Primary Interop Assemblies](../vsto/office-primary-interop-assemblies.md).  
  
## Using the Project Object Model Documentation  
 For complete information about the Project object model, you can refer to the Project VBA object model reference. The VBA object model reference documents the Project object model as it is exposed to Visual Basic for Applications (VBA) code. For more information, see [Project 2010 Object Model Reference](http://go.microsoft.com/fwlink/?LinkId=199771).  
  
 All of the objects and members in the VBA object model reference correspond to types and members in the Project primary interop assembly (PIA). For example, the Calendar object in the VBA object model reference corresponds to the Microsoft.Office.Interop.MSProject.Calendar type in the Project PIA. Although the VBA object model reference provides code examples for most properties, methods, and events, you must translate the VBA code in this reference to Visual Basic or Visual C# if you want to use them in an Project VSTO Add-in project that you create by using Visual Studio.  
  
> [!NOTE]  
>  At this time, there is no reference documentation for the Project primary interop assembly.  
  
### Infrastructure Types in the Project Primary Interop Assembly  
 As you write code that uses the Project PIA, you might notice many types that are not described in the VBA reference. These additional types help translate objects in the COM-based object model of Project to managed code, are not intended to be used directly in your code.  
  
 For more information, see[Overview of Classes and Interfaces in the Office Primary Interop Assemblies](http://go.microsoft.com/fwlink/?LinkId=189592).  
  
## Customizing the User Interface of Project  
 You can customize the Project UI in the following ways.  
  
|Task|For more information|  
|----------|--------------------------|  
|Add custom tabs to the Ribbon in Project|[Ribbon Overview](../vsto/ribbon-overview.md)|  
  
 For more information about customizing the UI of Project and other Microsoft Office applications, see [Office UI Customization](../vsto/office-ui-customization.md).  
  
## See Also  
 [Walkthrough: Creating Your First VSTO Add-in for Project](../vsto/walkthrough-creating-your-first-vsto-add-in-for-project.md)   
 [Getting Started Programming VSTO Add-ins](../vsto/getting-started-programming-vsto-add-ins.md)   
 [Office Solutions Development Overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md)   
 [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md)   
 [How to: Create Office Projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md)   
 [Programming VSTO Add-Ins](../vsto/programming-vsto-add-ins.md)   
 [Writing Code in Office Solutions](../vsto/writing-code-in-office-solutions.md)   
 [Office Primary Interop Assemblies](../vsto/office-primary-interop-assemblies.md)   
 [Office UI Customization](../vsto/office-ui-customization.md)   
 [Project 2010 and Project Server 2010 in Office Development](http://go.microsoft.com/fwlink/?LinkId=199016)  
  
  