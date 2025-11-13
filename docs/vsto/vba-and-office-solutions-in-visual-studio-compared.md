---
title: VBA and Office solutions in Visual Studio compared
description: Explore the differences between Microsoft Visual Basic for Applications (VBA) and Microsoft Office solutions in Visual Studio.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "VBA code, managed code extensions"
  - "managed code extensions [Office development in Visual Studio], VBA compared to"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# VBA and Office solutions in Visual Studio compared

  Microsoft Visual Basic for Applications (VBA) uses unmanaged code that is tightly integrated with Office applications. Microsoft Office projects created by using Visual Studio enable you to take advantage of the .NET Framework and Visual Studio design tools.

 For information about the types of Office solutions you can create by using Visual Studio, see [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md).

## Comparison
 The following table provides a basic comparison between VBA solutions and Office solutions in Visual Studio.

|VBA solutions|Office solutions in Visual Studio|
|-------------------|---------------------------------------|
|Uses code that is connected to and persisted with a specific document.|Uses code that is stored separately from the document (for document-level customizations), or in an assembly that is loaded by the application (for VSTO Add-ins).|
|Works with the Office object models and VBA APIs.|Provides access to both the Office object models and the .NET Framework APIs.|
|Designed for macro recording and a simplified developer experience.|Designed for security, easier code maintenance, and the ability to use the full Visual Studio integrated development environment (IDE).|
|Works well for solutions that benefit from a tight integration with Office applications.|Works well for solutions that benefit from the full resources of Visual Studio and the .NET Framework.|
|Has limitations for the enterprise, especially in the areas of security and deployment.|Designed for use in the enterprise.|

 Some things are still easier to do quickly using VBA. Specifically, you might want to continue using VBA for:

- Custom worksheet functions.

- Macro recording.

## Combine VBA solutions and Office solutions created by using Visual Studio
 You can call VBA code from Office solutions created by using Visual Studio, and you can also call code in Office solutions created by using Visual Studio from VBA. The specific technique differs depending on whether your Office solution is a VSTO Add-in or a document-level customization. For more information, see [Call code in VSTO Add-ins from other Office solutions](../vsto/calling-code-in-vsto-add-ins-from-other-office-solutions.md) and [Combine VBA and document-level customizations](../vsto/combining-vba-and-document-level-customizations.md).

## Related content
- [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md)
- [Call code in VSTO Add-ins from other Office solutions](../vsto/calling-code-in-vsto-add-ins-from-other-office-solutions.md)
- [Combine VBA and document-level customizations](../vsto/combining-vba-and-document-level-customizations.md)
- [Architecture of document-level customizations](../vsto/architecture-of-document-level-customizations.md)
- [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md)
- [Secure Office solutions](../vsto/securing-office-solutions.md)
- [Get started &#40;Office development in Visual Studio&#41;](../vsto/getting-started-office-development-in-visual-studio.md)
