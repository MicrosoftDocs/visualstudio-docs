---
title: "Sample Coded UI Test Extension for Excel"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 451e4d14-7fac-42f9-af56-2bdc8414c6c7
caps.latest.revision: 13
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Sample Coded UI Test Extension for Excel
The extension component of the sample runs in the Visual Studio Coded UI Test process and is somewhat hierarchical with the `ExtensionPackage` class at the base. The `TechnologyManager`, `ActionFilter`, and `PropertyProvider` classes are at the next level, with the control elements at the top level.  
  
 ![Excel Test Extension Architecture](../VS_IDE/media/Excel_ExtArch.png "Excel_ExtArch")  
Excel Extension Architecture  
  
## Extension Points  
 These classes represent the extension points that are implemented in the sample to enable coded UI testing for Microsoft Excel.  
  
### ExtensionPackage  
 Inherited from the <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITestExtensionPackage?qualifyHint=False> class, this is the entry point for the coded UI testing extension. Implementing this abstract class gives the coded UI testing framework internal access to your custom UI test technology manager, UI test property provider, and UI test action filter for testing the new UI. For more information, see [ExtensionPackage Class](../VS_IDE/Sample-Excel-Extension--ExtensionPackage-Class.md).  
  
### TechnologyManager  
 Inherited from the <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyManager?qualifyHint=False> class, this class provides a technology manager for test recording and playback. For more information, see [TechnologyManager Class](../VS_IDE/Sample-Excel-Extension--TechnologyManager-Class.md).  
  
### ActionFilter  
 Inherited from the <xref:Microsoft.VisualStudio.TestTools.UITest.Common.UITestActionFilter?qualifyHint=False> class, this class provides a base class for aggregating similar test action results into a single test result. For more information, see [ActionFilter Class](../VS_IDE/Sample-Excel-Extension--ActionFilter-Class.md).  
  
### Technology Elements  
 A base class inherited from the <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement?qualifyHint=False> class provides the foundation for the technology elements in your UI tests that can be recorded and played back. For more information, see [Element Classes](../VS_IDE/Sample-Excel-Extension--Element-Classes.md).  
  
### PropertyProvider  
 Inherited from the <xref:Microsoft.VisualStudio.TestTools.UITesting.UITestPropertyProvider?qualifyHint=False> class, this class provides a base class for supporting the properties of UI elements for test recording and playback. For more information, see [PropertyProvider Class](../VS_IDE/Sample-Excel-Extension--PropertyProvider-Class.md).  
  
## See Also  
 <xref:Microsoft.VisualStudio.TestTools.UITesting.UITestPropertyProvider?qualifyHint=False>   
 <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement?qualifyHint=False>   
 <xref:Microsoft.VisualStudio.TestTools.UITest.Common.UITestActionFilter?qualifyHint=False>   
 <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITestExtensionPackage?qualifyHint=False>   
 [ExtensionPackage Class](../VS_IDE/Sample-Excel-Extension--ExtensionPackage-Class.md)   
 [TechnologyManager Class](../VS_IDE/Sample-Excel-Extension--TechnologyManager-Class.md)   
 [ActionFilter Class](../VS_IDE/Sample-Excel-Extension--ActionFilter-Class.md)   
 [Element Classes](../VS_IDE/Sample-Excel-Extension--Element-Classes.md)   
 [PropertyProvider Class](../VS_IDE/Sample-Excel-Extension--PropertyProvider-Class.md)