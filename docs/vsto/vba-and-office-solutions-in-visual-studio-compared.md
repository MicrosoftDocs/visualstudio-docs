---
title: "VBA and Office Solutions in Visual Studio Compared | Microsoft Docs"
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
  - "VBA code, managed code extensions"
  - "managed code extensions [Office development in Visual Studio], VBA compared to"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# VBA and Office Solutions in Visual Studio Compared
  Microsoft Visual Basic for Applications (VBA) uses unmanaged code that is tightly integrated with Office applications. Microsoft Office projects created by using Visual Studio enable you to take advantage of the .NET Framework and Visual Studio design tools.  
  
 For information about the types of Office solutions you can create by using Visual Studio, see [Office Solutions Development Overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md).  
  
## Comparison  
 The following table provides a basic comparison between VBA solutions and Office solutions in Visual Studio.  
  
|VBA solutions|Office solutions in Visual Studio|  
|-------------------|---------------------------------------|  
|Uses code that is connected to and persisted with a specific document.|Uses code that is stored separately from the document (for document-level customizations), or in an assembly that is loaded by the application (for VSTO VSTO Add-ins).|  
|Works with the Office object models and VBA APIs.|Provides access to both the Office object models and the [!INCLUDE[dnprdnshort](../sharepoint/includes/dnprdnshort-md.md)] APIs.|  
|Designed for macro recording and a simplified developer experience.|Designed for security, easier code maintenance, and the ability to use the full Visual Studio integrated development environment (IDE).|  
|Works well for solutions that benefit from a very tight integration with Office applications.|Works well for solutions that benefit from the full resources of Visual Studio and the [!INCLUDE[dnprdnshort](../sharepoint/includes/dnprdnshort-md.md)].|  
|Has limitations for the enterprise, especially in the areas of security and deployment.|Designed for use in the enterprise.|  
  
 Some things are still easier to do quickly using VBA. Specifically, you might want to continue using VBA for:  
  
-   Custom worksheet functions.  
  
-   Macro recording.  
  
## Combining VBA Solutions and Office Solutions Created by Using Visual Studio  
 You can call VBA code from Office solutions created by using Visual Studio, and you can also call code in Office solutions created by using Visual Studio from VBA. The specific technique differs depending on whether your Office solution is a VSTO Add-in or a document-level customization. For more information, see [Calling Code in VSTO Add-ins from Other Office Solutions](../vsto/calling-code-in-vsto-add-ins-from-other-office-solutions.md) and [Combining VBA and Document-Level Customizations](../vsto/combining-vba-and-document-level-customizations.md).  
  
## See Also  
 [Office Solutions Development Overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md)   
 [Calling Code in VSTO Add-ins from Other Office Solutions](../vsto/calling-code-in-vsto-add-ins-from-other-office-solutions.md)   
 [Combining VBA and Document-Level Customizations](../vsto/combining-vba-and-document-level-customizations.md)   
 [Architecture of Document-Level Customizations](../vsto/architecture-of-document-level-customizations.md)   
 [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md)   
 [Securing Office Solutions](../vsto/securing-office-solutions.md)   
 [Getting Started &#40;Office Development in Visual Studio&#41;](../vsto/getting-started-office-development-in-visual-studio.md)  
  
  