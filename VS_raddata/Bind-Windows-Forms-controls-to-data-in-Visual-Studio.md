---
title: "Bind Windows Forms controls to data in Visual Studio"
ms.custom: na
ms.date: 10/07/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
  - aspx
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 243338ef-41af-4cc5-aff7-1e830236f0ec
caps.latest.revision: 37
manager: ghogen
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
# Bind Windows Forms controls to data in Visual Studio
You can display data to users of your application by binding data to Windows Forms. To create these data-bound controls, you can drag items from the **Data Sources** window onto the Windows Forms Designer in Visual Studio. This topic describes some of the most common tasks, tools, and classes involved in creating data-bound Windows Forms applications.  
  
 ![Data Source drag operation](../VS_raddata/media/raddata-Data-Source-drag-operation.png "raddata Data Source drag operation")  
  
 For general information about how to create data-bound controls in Visual Studio, see [Bind controls to data in Visual Studio](../VS_raddata/Bind-controls-to-data-in-Visual-Studio.md). For more information about data binding in Windows Forms, see [Windows Forms Data Binding](../Topic/Windows%20Forms%20Data%20Binding.md).  
  
## In this section  
  
-   [Bind Windows Forms controls to data](../VS_raddata/Bind-Windows-Forms-controls-to-data.md)  
  
-   [Commit in-process edits on data-bound controls before saving data](../VS_raddata/Commit-in-process-edits-on-data-bound-controls-before-saving-data.md)  
  
-   [Create lookup tables in Windows Forms applications](../VS_raddata/Create-lookup-tables-in-Windows-Forms-applications.md)  
  
-   [Create a Windows Form to search data](../VS_raddata/Create-a-Windows-Form-to-search-data.md)  
  
-   [Create a Windows Forms user control that supports simple data binding](../VS_raddata/Create-a-Windows-Forms-user-control-that-supports-simple-data-binding.md)  
  
-   [Create a Windows Forms user control that supports complex data binding](../VS_raddata/Create-a-Windows-Forms-user-control-that-supports-complex-data-binding.md)  
  
-   [Create a Windows Forms user control that supports lookup data binding](../VS_raddata/Create-a-Windows-Forms-user-control-that-supports-lookup-data-binding.md)  
  
-   [Pass data between forms](../VS_raddata/Pass-data-between-forms.md)  
  
## BindingSource component  
 The <xref:System.Windows.Forms.BindingSource?qualifyHint=False> component serves two purposes. First, it provides a layer of abstraction when binding the controls on your form to data. Controls on the form are bound to the <xref:System.Windows.Forms.BindingSource?qualifyHint=False> component (instead of being bound directly to a data source).  
  
 Second, it can manage a collection of objects. Adding a type to the <xref:System.Windows.Forms.BindingSource?qualifyHint=False> creates a list of that type.  
  
 For more information about the <xref:System.Windows.Forms.BindingSource?qualifyHint=False> component, see:  
  
-   [BindingSource Component](../Topic/BindingSource%20Component.md)  
  
-   [BindingSource Component Overview](../Topic/BindingSource%20Component%20Overview.md)  
  
-   [BindingSource Component Architecture](../Topic/BindingSource%20Component%20Architecture.md)  
  
## BindingNavigator control  
 This component provides a user interface for navigating through data displayed by a Windows application. For more information, see [BindingNavigator Control](../Topic/BindingNavigator%20Control%20\(Windows%20Forms\).md).  
  
## DataGridView control  
 To display and edit tabular data from many different kinds of data sources, use the <xref:System.Windows.Forms.DataGridView?qualifyHint=False> control. You can bind data to a <xref:System.Windows.Forms.DataGridView?qualifyHint=False> by using the <xref:System.Windows.Forms.DataGridView.DataSource?qualifyHint=False> property. For more information, see [DataGridView Control Overview](../Topic/DataGridView%20Control%20Overview%20\(Windows%20Forms\).md).  
  
## See Also  
 [Bind controls to data in Visual Studio](../VS_raddata/Bind-controls-to-data-in-Visual-Studio.md)