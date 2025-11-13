---
title: Automate Microsoft Visio actions & extend features
description: Use VSTO add-ins to automate Microsoft Visio actions, extend Visio features, or customize the Visio user interface (UI).
ms.date: "08/14/2019"
ms.topic: article
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
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Visio solutions

  Visual Studio provides project templates you can use to create VSTO Add-ins for Microsoft Office Visio. You can use VSTO Add-ins to automate Visio, extend Visio features, or customize the Visio user interface (UI).

 For more information about VSTO Add-ins, see [Get started programming VSTO Add-ins](../vsto/getting-started-programming-vsto-add-ins.md) and [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md). If you are new to programming with Microsoft Office, see [Get started &#40;Office development in Visual Studio&#41;](../vsto/getting-started-office-development-in-visual-studio.md).

 **Applies to:** The information in this topic applies to VSTO Add-in projects for Visio 2010. For more information, see [Features Available by Office Application and Project Type](../vsto/features-available-by-office-application-and-project-type.md).

[!include[Add-ins note](includes/addinsnote.md)]

## Automate Visio by using the Visio object model
 The Visio object model exposes many classes that you can use to automate Visio to create diagrams for organizational charts, flowcharts, project timelines, network diagrams, office spaces, and more. The API enables you to write code to accomplish common tasks:

- Construct and position shapes and text in diagrams.

- Manage shape behavior based on business logic and user input.

- Control diagram visualization such as panning and zooming.

- Customize the application UI.

- Import external data into Visio, link it to shapes, and display it graphically on a page.

  You can view step-by-step procedures and code examples for using the object model of Visio to work with documents and shapes in [Work with Visio documents](../vsto/working-with-visio-documents.md) and [Work with Visio shapes](../vsto/working-with-visio-shapes.md).

  To access the Visio object model from a VSTO Add-in, use the `Application` field of the `ThisAddIn` class in your project. The `Application` field returns a `Microsoft.Office.Interop.Visio.Application` object that represents the current instance of Visio. For more information, see [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md).

  When you call into the Visio object model, you use types that are provided in the primary interop assembly (PIA) for Visio. The PIA acts as a bridge between the managed code in the VSTO Add-in and the COM object model in Visio. All types in the Visio PIA are defined in the `Microsoft.Office.Interop.Visio` namespace. For more information about primary interop assemblies, see [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md) and [Office primary interop assemblies](../vsto/office-primary-interop-assemblies.md).

## Visio object model overview
 You can find an overview of the Visio object model at [Visio object model overview](../vsto/visio-object-model-overview.md), which includes links to the Visio object model reference and the SDKs.

## Customize the user interface of Visio
 The Visio UI has the following customization options.

|Task|For more information|
|----------|--------------------------|
|Customize the ribbon.|[Ribbon Overview](../vsto/ribbon-overview.md)|

 For information about customizing the UI of Visio, see the VBA reference documentation for the [Visio.UIObject](/office/vba/api/Visio.UIObject) class.

## Related content
- [Get started programming VSTO Add-ins](../vsto/getting-started-programming-vsto-add-ins.md)
- [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md)
- [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md)
- [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md)
- [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md)
- [Write code in Office solutions](../vsto/writing-code-in-office-solutions.md)
- [Office primary interop assemblies](../vsto/office-primary-interop-assemblies.md)
- [Office UI customization](../vsto/office-ui-customization.md)
- [Visio object model overview](../vsto/visio-object-model-overview.md)
- [Visio 2010 in Office development](/previous-versions/office/developer/office-2010/ff604964(v=office.14))
