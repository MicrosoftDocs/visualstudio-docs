---
title: "Project solutions"
description: Learn how you can use VSTO Add-ins to automate Project, extend Project features, or customize the Project user interface (UI).
ms.date: "08/14/2019"
ms.topic: article
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
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Project solutions

  Visual Studio 2013 provides project templates you can use to create VSTO Add-ins for Microsoft Office Project. You can use VSTO Add-ins to automate Project, extend Project features, or customize the Project user interface (UI).

 For more information about VSTO Add-ins, see [Get started programming VSTO Add-ins](../vsto/getting-started-programming-vsto-add-ins.md) and [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md). If you are new to programming with Microsoft Office, see [Get started &#40;Office development in Visual Studio&#41;](../vsto/getting-started-office-development-in-visual-studio.md).

 [!INCLUDE[appliesto_projallapp](../vsto/includes/appliesto-projallapp-md.md)]

[!include[Add-ins note](includes/addinsnote.md)]

## Automate project by using the project object model
 The Project object model exposes many types that you can use to automate Project. These types enable you to write code to accomplish common tasks such as programmatically creating and modifying tasks in a project.

 To access the Project object model from a VSTO Add-in, use the `Application` field of the `ThisAddIn` class in your project. The `Application` field returns a `Microsoft.Office.Interop.MsProject.Application` object that represents the current instance of Project. For more information, see [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md).

 When you call into the Project object model, you use types that are provided in the primary interop assembly for Project. The primary interop assembly acts as a bridge between the managed code in the VSTO Add-in and the COM object model in Project. All types in the Project primary interop assembly are defined in the `Microsoft.Office.Interop.MSProject` namespace. For more information about primary interop assemblies, see [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md) and [Office primary interop assemblies](../vsto/office-primary-interop-assemblies.md).

## Use the project object model documentation
 For complete information about the Project object model, you can refer to the Project VBA object model reference. The VBA object model reference documents the Project object model as it is exposed to Visual Basic for Applications (VBA) code. For more information, see [Project object model reference](/office/vba/api/project.object).

 All of the objects and members in the VBA object model reference correspond to types and members in the Project primary interop assembly (PIA). For example, the Calendar object in the VBA object model reference corresponds to the `Microsoft.Office.Interop.MSProject.Calendar` type in the Project PIA. Although the VBA object model reference provides code examples for most properties, methods, and events, you must translate the VBA code in this reference to Visual Basic or Visual C# if you want to use them in a Project VSTO Add-in project that you create by using Visual Studio.

> [!NOTE]
> At this time, there is no reference documentation for the Project primary interop assembly.

### Infrastructure types in the project primary interop assembly
 As you write code that uses the Project PIA, you might notice many types that are not described in the VBA reference. These additional types help translate objects in the COM-based object model of Project to managed code, are not intended to be used directly in your code.

 For more information, see [Overview of classes and interfaces in the Office primary interop assemblies](/previous-versions/office/office-12/ms247299(v=office.12)).

## Customize the user interface of project
 You can customize the Project UI in the following ways.

|Task|For more information|
|----------|--------------------------|
|Add custom tabs to the Ribbon in Project|[Ribbon overview](../vsto/ribbon-overview.md)|

 For more information about customizing the UI of Project and other Microsoft Office applications, see [Office UI customization](../vsto/office-ui-customization.md).

## Related content
- [Walkthrough: Create your first VSTO Add-in for project](../vsto/walkthrough-creating-your-first-vsto-add-in-for-project.md)
- [Get started programming VSTO Add-ins](../vsto/getting-started-programming-vsto-add-ins.md)
- [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md)
- [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md)
- [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md)
- [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md)
- [Write code in Office solutions](../vsto/writing-code-in-office-solutions.md)
- [Office primary interop assemblies](../vsto/office-primary-interop-assemblies.md)
- [Office UI customization](../vsto/office-ui-customization.md)
- [Project 2010 and Project Server 2010 in Office development](/previous-versions/office/developer/office-2010/ee758031(v=office.14))
