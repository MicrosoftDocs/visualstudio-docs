---
title: "Bind Windows Forms controls to data"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords:
  - "data [Windows Forms], data sources"
  - "Windows Forms, data binding"
  - "Windows Forms, displaying data"
  - "displaying data on forms"
  - "forms, displaying data"
  - "data sources, displaying data"
  - "displaying data, Windows Forms"
  - "data [Windows Forms], displaying"
ms.assetid: 243338ef-41af-4cc5-aff7-1e830236f0ec
caps.latest.revision: 40
author: jillre
ms.author: jillfra
manager: jillfra
---
# Bind Windows Forms controls to data in Visual Studio
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can display data to users of your application by binding data to Windows Forms. To create these data-bound controls, you can drag items from the **Data Sources** window onto the Windows Forms Designer in Visual Studio. This topic describes some of the most common tasks, tools, and classes involved in creating data-bound Windows Forms applications.

 ![Data Source drag operation](../data-tools/media/raddata-data-source-drag-operation.png "raddata Data Source drag operation")

 For general information about how to create data-bound controls in Visual Studio, see [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md). For more information about data binding in Windows Forms, see [Windows Forms Data Binding](https://msdn.microsoft.com/library/c3826d8e-ea25-4ad4-a669-45bfb19192aa).

## In this section

- [Bind Windows Forms controls to data](../data-tools/bind-windows-forms-controls-to-data.md)

- [Commit in-process edits on data-bound controls before saving data](../data-tools/commit-in-process-edits-on-data-bound-controls-before-saving-data.md)

- [Create lookup tables in Windows Forms applications](../data-tools/create-lookup-tables-in-windows-forms-applications.md)

- [Create a Windows Form to search data](../data-tools/create-a-windows-form-to-search-data.md)

- [Create a Windows Forms user control that supports simple data binding](../data-tools/create-a-windows-forms-user-control-that-supports-simple-data-binding.md)

- [Create a Windows Forms user control that supports complex data binding](../data-tools/create-a-windows-forms-user-control-that-supports-complex-data-binding.md)

- [Create a Windows Forms user control that supports lookup data binding](../data-tools/create-a-windows-forms-user-control-that-supports-lookup-data-binding.md)

- [Pass data between forms](../data-tools/pass-data-between-forms.md)

## BindingSource component
 The <xref:System.Windows.Forms.BindingSource> component serves two purposes. First, it provides a layer of abstraction when binding the controls on your form to data. Controls on the form are bound to the <xref:System.Windows.Forms.BindingSource> component (instead of being bound directly to a data source).

 Second, it can manage a collection of objects. Adding a type to the <xref:System.Windows.Forms.BindingSource> creates a list of that type.

 For more information about the <xref:System.Windows.Forms.BindingSource> component, see:

- [BindingSource Component](https://msdn.microsoft.com/library/3e2faf4c-f5b8-4fa6-9fbc-f59c37ec2fb9)

- [BindingSource Component Overview](https://msdn.microsoft.com/library/be838caf-fcb0-4b68-827f-58b2c04b747f)

- [BindingSource Component Architecture](https://msdn.microsoft.com/library/7bc69c90-8a11-48b1-9336-3adab5b41591)

## BindingNavigator control
 This component provides a user interface for navigating through data displayed by a Windows application. For more information, see [BindingNavigator Control](https://msdn.microsoft.com/library/18c1e2a5-9834-40d3-9b2e-2b545e4e769e).

## DataGridView control
 To display and edit tabular data from many different kinds of data sources, use the <xref:System.Windows.Forms.DataGridView> control. You can bind data to a <xref:System.Windows.Forms.DataGridView> by using the <xref:System.Windows.Forms.DataGridView.DataSource%2A> property. For more information, see [DataGridView Control Overview](https://msdn.microsoft.com/library/0a45c661-89dc-4390-9cc6-c47eee501488).

## See Also
 [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)
