---
title: "PowerPoint solutions"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office solutions [Office development in Visual Studio], PowerPoint"
  - "templates [Office development in Visual Studio], PowerPoint"
  - "solutions [Office development in Visual Studio], PowerPoint"
  - "projects [Office development in Visual Studio], PowerPoint"
  - "PowerPoint [Office development in Visual Studio]"
  - "Office projects [Office development in Visual Studio], PowerPoint"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# PowerPoint solutions
  Visual Studio provides project templates you can use to create VSTO Add-ins for Microsoft Office PowerPoint. You can use VSTO Add-ins to automate PowerPoint, extend PowerPoint features, or customize the PowerPoint user interface (UI).

 For more information about VSTO Add-ins, see [Get started programming VSTO Add-ins](../vsto/getting-started-programming-vsto-add-ins.md) and [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md). If you are new to programming with Microsoft Office, see [Get started &#40;Office development in Visual Studio&#41;](../vsto/getting-started-office-development-in-visual-studio.md).

 [!INCLUDE[appliesto_pptallapp](../vsto/includes/appliesto-pptallapp-md.md)]

> [!NOTE]
> Interested in developing solutions that extend the Office experience across [multiple platforms](https://dev.office.com/add-in-availability)? Check out the new [Office Add-ins model](https://dev.office.com/docs/add-ins/overview/office-add-ins). Office Add-ins have a small footprint compared to VSTO add-ins and solutions, and you can build them by using almost any web programming technology, such as HTML5, JavaScript, CSS3, and XML.

 ![link to video](../vsto/media/playvideo.gif "link to video") For a related video demonstration, see [How do I: Create an Add-in for Microsoft PowerPoint?](http://go.microsoft.com/fwlink/?LinkId=132767).

## Automate PowerPoint by using the PowerPoint object model
 The PowerPoint object model exposes many types that you can use to automate PowerPoint. These types enable you to write code to accomplish common tasks:

- Programmatically create and format presentations.

- Add or remove slides from presentations.

- Add or change shapes on a slide.

  To access the PowerPoint object model from a VSTO Add-in, use the `Application` field of the `ThisAddIn` class in your project. The `Application` field returns a <xref:Microsoft.Office.Interop.PowerPoint.Application> object that represents the current instance of PowerPoint. For more information, see [Program VSTO Add-Ins](../vsto/programming-vsto-add-ins.md).

  When you call into the PowerPoint object model, you use types that are provided in the primary interop assembly for PowerPoint. The primary interop assembly acts as a bridge between the managed code in the VSTO Add-in and the COM object model in PowerPoint. All types in the PowerPoint primary interop assembly are defined in the <xref:Microsoft.Office.Interop.PowerPoint> namespace. For more information about primary interop assemblies, see [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md) and [Office primary interop assemblies](../vsto/office-primary-interop-assemblies.md).

## <a name="WordOMDocumentation"></a> Use the PowerPoint object model documentation
 For complete information about the PowerPoint object model, you can refer to the PowerPoint primary interop assembly (PIA) reference and the VBA object model reference.

### Primary interop assembly reference
 The PowerPoint PIA reference documentation describes the types in the primary interop assembly for PowerPoint. This documentation is available from the following location: [PowerPoint 2010 primary interop assembly reference](http://go.microsoft.com/fwlink/?LinkId=189588).

 For more information about the design of the PowerPoint PIA, such as the differences between classes and interfaces in the PIA and how events in the PIA are implemented, see [Overview of classes and interfaces in the Office primary interop assemblies](http://go.microsoft.com/fwlink/?LinkId=199885).

### VBA object model reference
 The VBA object model reference documents the PowerPoint object model as it is exposed to Visual Basic for Applications (VBA) code. For more information, see [PowerPoint 2010 object model reference](http://go.microsoft.com/fwlink/?LinkId=199770)

 All of the objects and members in the VBA object model reference correspond to types and members in the PowerPoint primary interop assembly (PIA). For example, the Presentation object in the VBA object model reference corresponds to the <xref:Microsoft.Office.Interop.PowerPoint.Presentation> type in the PowerPoint PIA. Although the VBA object model reference provides code examples for most properties, methods, and events, you must translate the VBA code in this reference to Visual Basic or Visual C# if you want to use them in a PowerPoint VSTO Add-in project that you create by using Visual Studio.

## Customize the user interface of PowerPoint
 You can modify the UI of PowerPoint in the following ways.

|Task|For more information|
|----------|--------------------------|
|Create a custom task pane.|[Custom task panes](../vsto/custom-task-panes.md)|
|Add custom tabs to the Ribbon.|[Ribbon overview](../vsto/ribbon-overview.md)|
|Add custom groups to a built-in tab on the Ribbon.|[How to: Customize a built-in tab](../vsto/how-to-customize-a-built-in-tab.md)|

 For more information about customizing the UI of PowerPoint and other Microsoft Office applications, see [Office UI customization](../vsto/office-ui-customization.md).

## See also
- [Walkthrough: Create your first VSTO Add-in for PowerPoint](../vsto/walkthrough-creating-your-first-vsto-add-in-for-powerpoint.md)
- [Get started programming VSTO Add-ins](../vsto/getting-started-programming-vsto-add-ins.md)
- [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md)
- [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md)
- [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md)
- [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md)
- [Write code in Office solutions](../vsto/writing-code-in-office-solutions.md)
- [Office primary interop assemblies](../vsto/office-primary-interop-assemblies.md)
- [Office UI customization](../vsto/office-ui-customization.md)
- [PowerPoint 2010 in Office development](http://go.microsoft.com/fwlink/?LinkId=199015)
