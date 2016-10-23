---
title: "Sample Excel Extension: PropertyProvider Class"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 075d9b8d-8658-4fca-8711-08304dbac1c5
caps.latest.revision: 9
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
# Sample Excel Extension: PropertyProvider Class
This internal class extends the <xref:Microsoft.VisualStudio.TestTools.UITesting.UITestPropertyProvider?qualifyHint=False> class and provides property services for Microsoft Excel elements to record and play back user interface (UI) tests.  
  
## GetControlSupportLevel Method  
 The <xref:Microsoft.VisualStudio.TestTools.UITesting.UITestPropertyProvider.GetControlSupportLevel?qualifyHint=False> method returns a number that indicates the level of support that the property provider can offer for the provided control. The higher the returned value, the more the property provider can support the control. In this case, the method checks the value of the <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.IUITechnologyElement.TechnologyName?qualifyHint=False> property of the provided control. If the value is "Excel" and if the <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.IUITechnologyElement.ControlTypeName?qualifyHint=False> indicates it is a `CellElement`, the method returns the highest value; otherwise, it returns zero, which indicates that no support is provided.  
  
## GetPropertyNames Method  
 Returns a dictionary of property names and property descriptors for the supported properties of an Excel Cell control.  
  
## GetPropertyDescriptor Method  
 This method is called by the testing framework to get the predefined property descriptor for the provided property name.  
  
## GetPropertyValue and SetPropertyValue Methods  
 The `GetPropertyValue` method uses the `Communicator` class of this extension to return the property value from Excel. The `SetPropertyValue` method uses the <xref:Microsoft.VisualStudio.TestTools.UITesting.Keyboard?qualifyHint=False> class and the `Communicator` component to set the property value. These methods are called by the testing framework.  
  
## Code Generation Customization Methods  
 These methods are not implemented for this extension. Therefore, they either return `null` or throw the <xref:System.NotImplementedException?qualifyHint=False>.  
  
## See Also  
 <xref:Microsoft.VisualStudio.TestTools.UITesting.UITestPropertyProvider?qualifyHint=False>   
 <xref:Microsoft.VisualStudio.TestTools.UITesting.Keyboard?qualifyHint=False>   
 [Extending Coded UI Tests and Action Recordings to Support Microsoft Excel](../VS_IDE/Extending-Coded-UI-Tests-and-Action-Recordings-to-Support-Microsoft-Excel.md)