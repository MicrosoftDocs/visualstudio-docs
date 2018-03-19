---
title: "Visio Solutions | Microsoft Docs"
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
  - "Office projects [Office development in Visual Studio], Visio"
  - "solutions [Office development in Visual Studio], Visio"
  - "Visio [Office development in Visual Studio]"
  - "templates [Office development in Visual Studio], Visio"
  - "projects [Office development in Visual Studio], Visio"
  - "Office solutions [Office development in Visual Studio], Visio"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Visio Solutions
  Visual Studio provides project templates you can use to create VSTO Add-ins for Microsoft Office Visio. You can use VSTO Add-ins to automate Visio, extend Visio features, or customize the Visio user interface (UI).  
  
 For more information about VSTO Add-ins, see [Getting Started Programming VSTO Add-ins](../vsto/getting-started-programming-vsto-add-ins.md) and [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md). If you are new to programming with Microsoft Office, see [Getting Started &#40;Office Development in Visual Studio&#41;](../vsto/getting-started-office-development-in-visual-studio.md).  
  
 **Applies to:** The information in this topic applies to VSTO Add-in projects for Visio 2010. For more information, see [Features Available by Office Application and Project Type](../vsto/features-available-by-office-application-and-project-type.md).  
  
> [!NOTE]  
>  Interested in developing solutions that extend the Office experience across [multiple platforms](https://dev.office.com/add-in-availability)? Check out the new [Office Add-ins model](https://dev.office.com/docs/add-ins/overview/office-add-ins). Office Add-ins have a small footprint compared to VSTO add-ins and solutions, and you can build them by using almost any web programming technology, such as HTML5, JavaScript, CSS3, and XML.  
  
## Automating Visio by Using the Visio Object Model  
 The Visio object model exposes many classes that you can use to automate Visio to create diagrams for organizational charts, flowcharts, project timelines, network diagrams, office spaces, and more. The API enables you to write code to accomplish common tasks:  
  
-   Construct and position shapes and text in diagrams.  
  
-   Manage shape behavior based on business logic and user input.  
  
-   Control diagram visualization such as panning and zooming.  
  
-   Customize the application UI.  
  
-   Import external data into Visio, link it to shapes, and display it graphically on a page.  
  
 You can view step-by-step procedures and code examples for using the object model of Visio to work with documents and shapes in [Working with Visio Documents](../vsto/working-with-visio-documents.md) and [Working with Visio Shapes](../vsto/working-with-visio-shapes.md).  
  
 To access the Visio object model from a VSTO Add-in, use the `Application` field of the `ThisAddIn` class in your project. The `Application` field returns a Microsoft.Office.Interop.Visio.Application object that represents the current instance of Visio. For more information, see [Programming VSTO Add-Ins](../vsto/programming-vsto-add-ins.md).  
  
 When you call into the Visio object model, you use types that are provided in the primary interop assembly (PIA) for Visio. The PIA acts as a bridge between the managed code in the VSTO Add-in and the COM object model in Visio. All types in the Visio PIA are defined in the Microsoft.Office.Interop.Visio namespace. For more information about primary interop assemblies, see [Office Solutions Development Overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md) and [Office Primary Interop Assemblies](../vsto/office-primary-interop-assemblies.md).  
  
## Visio Object Model Overview  
 You can find an overview of the Visio object model at [Visio Object Model Overview](../vsto/visio-object-model-overview.md), which includes links to the Visio object model reference and the SDKs.  
  
## Customizing the User Interface of Visio  
 The Visio UI has the following customization options.  
  
|Task|For more information|  
|----------|--------------------------|  
|Customize the ribbon.|[Ribbon Overview](../vsto/ribbon-overview.md)|  
  
 For information about customizing the UI of Visio, see the VBA reference documentation for the [Visio.UIObject](https://msdn.microsoft.com/library/office/ff765763.aspx) class.  
  
## See Also  
 [Getting Started Programming VSTO Add-ins](../vsto/getting-started-programming-vsto-add-ins.md)   
 [Office Solutions Development Overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md)   
 [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md)   
 [How to: Create Office Projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md)   
 [Programming VSTO Add-Ins](../vsto/programming-vsto-add-ins.md)   
 [Writing Code in Office Solutions](../vsto/writing-code-in-office-solutions.md)   
 [Office Primary Interop Assemblies](../vsto/office-primary-interop-assemblies.md)   
 [Office UI Customization](../vsto/office-ui-customization.md)   
 [Visio Object Model Overview](../vsto/visio-object-model-overview.md)   
 [Visio 2010 in Office Development](http://go.microsoft.com/fwlink/?LinkId=199017)  
  
  