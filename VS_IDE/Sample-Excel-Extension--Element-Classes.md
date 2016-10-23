---
title: "Sample Excel Extension: Element Classes"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7c251098-00aa-49cf-9e37-5717c0c6b3f1
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
# Sample Excel Extension: Element Classes
The extension uses classes that are derived from <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement?qualifyHint=False> and represent the Worksheet control and Cell control in Microsoft Excel.  
  
 The base element for this extension is the `ExcelElement`. The `ExcelWorksheetElement` class and the `ExcelCellElement` class inherit from that element  
  
## Element and ElementInformation Classes  
 The `Element` is the base class for all user interface elements for the Excel extension, and it inherits from the <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement?qualifyHint=False> class. `ElementInformation` is the base class for the element information classes in the sample, and it has no members.  
  
#### Simple Properties and Methods  
 These members return simple values, such as the value of the `Name` property or the value of the `ClassName` property, and the code is clear and easy to read. Some values are returned by using the `Utility` class, which is discussed later. Others return `null` because they are not relevant in this sample extension. Two members are more interesting than the others: the <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement.QueryId?qualifyHint=False> property and the <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement.CacheProperties?qualifyHint=False> method.  
  
#### QueryId Property  
 This property returns a condition that is made of property name-value pairs that uniquely identify the control during playback. For each derived control class, the developer must override this property to return an <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.IQueryElement?qualifyHint=False> object that the framework can use to find the control in the UI.  
  
#### CacheProperties Method  
 This method is called by the testing framework during the recording process to tell the element to save a snapshot of important properties. This keeps the properties available even when the actual UI control is no longer on the screen.  
  
## WorksheetElement and WorksheetInformation Classes  
 The `WorksheetElement` class represents an Excel Worksheet in the testing framework, and inherits from the `Element` base class. Three properties are overridden to provide specific information about the Excel Worksheet object: <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement.ClassName?qualifyHint=False>, <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement.ControlTypeName?qualifyHint=False>, and <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement.Name?qualifyHint=False>.  
  
 The <xref:System.Runtime.InteropServices.ComVisibleAttribute?qualifyHint=False> is also applied to this class to make it visible to COM.  
  
 The `WorksheetInformation` class represents information about an Excel Worksheet. It has only one member, the `SheetName` property, which is sufficient for this sample.  
  
## CellElement and CellInformation Classes  
 The `CellElement` class represents an Excel Cell, and inherits from the `Element` base class. The only overridden member is the <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement.QueryId?qualifyHint=False> property, which returns an <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.IQueryElement?qualifyHint=False> that uses the `RowIndex` and `ColumnIndex` properties to identify the cell.  
  
## Utilities and ExcelUtilities Classes  
 The internal `ExcelUtilities` class provides some constant values, such as the technology name, and a method that determines if the provided window handle represents an Excel worksheet.  
  
 The `Utilities` class has helper methods that return a variety of information about the UI. Some methods use direct calls into external system DLLs, such as **USER32.DLL** and **OLEACC.DLL**, to get window handles from the UI**.**  
  
## See Also  
 <xref:System.Runtime.InteropServices.ComVisibleAttribute?qualifyHint=False>   
 <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.IQueryElement?qualifyHint=False>   
 [Extending Coded UI Tests and Action Recordings to Support Microsoft Excel](../VS_IDE/Extending-Coded-UI-Tests-and-Action-Recordings-to-Support-Microsoft-Excel.md)