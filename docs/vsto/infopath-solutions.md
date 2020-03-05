---
title: "InfoPath solutions"
ms.date: "08/14/2019"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "solutions [Office development in Visual Studio], InfoPath"
  - "templates [Office development in Visual Studio], InfoPath"
  - "InfoPath [Office development in Visual Studio]"
  - "Office development in Visual Studio, InfoPath solutions"
  - "projects [Office development in Visual Studio], InfoPath"
  - "Office solutions [Office development in Visual Studio], InfoPath"
  - "Office projects [Office development in Visual Studio], InfoPath"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# InfoPath solutions
  Visual Studio provides project templates you can use to create VSTO Add-ins for Microsoft Office InfoPath 2013 and InfoPath 2010. InfoPath is not available in Office 2016.

> [!NOTE]
> You can still create a VSTO Add-in for InfoPath even if you've installed Office 2016. Just install InfoPath 2013 or Office 2013 side-by-side with Office 2016.

 [!INCLUDE[appliesto_infoallapp](../vsto/includes/appliesto-infoallapp-md.md)]

[!include[Add-ins note](includes/addinsnote.md)]

 VSTO Add-ins for InfoPath are similar to VSTO Add-ins for other Microsoft Office applications. These types of solutions consist of an assembly that is loaded by the application. End users can have access to the functionality of this assembly no matter which form or form template is open. For more information about VSTO Add-ins, see [Get started programming VSTO Add-ins](../vsto/getting-started-programming-vsto-add-ins.md) and [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md).

> [!NOTE]
> Visual Studio 2015 does not include the InfoPath form template projects that were provided in previous versions of Visual Studio. You also cannot use Visual Studio 2015 to open or edit an InfoPath form template project that was created in a previous version of Visual Studio. However, you can open and edit an InfoPath form template project by using Visual Studio Tools for Applications. For more information, see [Work with VSTO 2008 projects in InfoPath 2010.](https://blogs.msdn.microsoft.com/infopath/2011/04/14/working-with-vsto-2008-projects-in-infopath-2010/).

## Automate InfoPath by using an add-in
 To access the InfoPath object model from an Office VSTO Add-in created by using Office development tools in Visual Studio, use the `Application` field of the `ThisAddIn` class in your project. The `Application` field returns a <xref:Microsoft.Office.Interop.InfoPath.Application> object that represents the current instance of InfoPath. For more information, see [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md).

 When you call into the InfoPath object model from a VSTO Add-in, you use types that are provided in the primary interop assembly for InfoPath. The primary interop assembly acts as a bridge between the managed code in the VSTO Add-in and the COM object model in InfoPath. All types in the InfoPath primary interop assembly are defined in the <xref:Microsoft.Office.Interop.InfoPath> namespace. For more information about the InfoPath primary interop assembly, see [About the Microsoft Office InfoPath primary interop assembly](https://msdn.microsoft.com/1b3ae03c-6951-49e4-a489-4712d3f7ba72). For more information about primary interop assemblies in general, see [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md) and [Office primary interop assemblies](../vsto/office-primary-interop-assemblies.md).

## Customize the user interface of InfoPath by using an add-in
 When you create a VSTO Add-in for InfoPath, you have several different UI customization options. The following table lists some of these options.

|Task|For more information|
|----------|--------------------------|
|Create a custom task pane.|[Custom task panes](../vsto/custom-task-panes.md)|
|Add custom tabs to the Ribbon in InfoPath.|[Customize a Ribbon for InfoPath](../vsto/customizing-a-ribbon-for-infopath.md)|

 For more information about customizing the UI of InfoPath and other Microsoft Office applications, see [Office UI customization](../vsto/office-ui-customization.md).

## See also
- [About the Microsoft Office InfoPath primary interop assembly](https://msdn.microsoft.com/1b3ae03c-6951-49e4-a489-4712d3f7ba72)
- [Get started programming VSTO Add-ins](../vsto/getting-started-programming-vsto-add-ins.md)
- [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md)
- [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md)
- [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md)
- [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md)
- [Write code in Office solutions](../vsto/writing-code-in-office-solutions.md)
- [Office primary interop assemblies](../vsto/office-primary-interop-assemblies.md)
- [Office UI customization](../vsto/office-ui-customization.md)
- [InfoPath 2010 in Office development](/previous-versions/office/developer/office-2010/ff604966(v=office.14))
