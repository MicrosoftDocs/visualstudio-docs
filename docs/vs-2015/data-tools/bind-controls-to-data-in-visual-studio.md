---
title: "Bind controls to data"
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
  - "data, displaying"
  - "data sources, displaying data"
  - "Data Sources window"
  - "displaying data"
ms.assetid: be8b6623-86a6-493e-ab7a-050de4661fd6
caps.latest.revision: 42
author: jillre
ms.author: jillfra
manager: jillfra
---
# Bind controls to data in Visual Studio
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can display data to users of your application by binding data to controls. You can create these data-bound controls by dragging items from the **Data Sources** window onto a design surface or controls on a surface  in Visual Studio.

 This topic describes the data sources you can use to create data-bound controls. It also describes some of the general tasks involved in data binding. For more specific details about how to create data-bound controls, see [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md) and [Bind WPF controls to data in Visual Studio](../data-tools/bind-wpf-controls-to-data-in-visual-studio1.md).

## Data sources
 In the context of data binding, a data source represents the data in memory that can be bound to your user interface. In practical terms, a data source can be an Entity Framework class, a dataset, a service endpoint that is encapsulated in a .NET proxy object, a LINQ to SQL class, or any .NET object or collection. Some data sources enable you to create data-bound controls by dragging items from the **Data Sources** window, while other data sources do not. The following table shows which data sources are supported.

|Data source|Drag-and-drop support in **the Windows Forms Designer**|Drag-and-drop support in **the WPF Designer**|Drag-and-drop support in **the Silverlight Designer**|
|-----------------|---------------------------------------------------------------|-----------------------------------------------------|-------------------------------------------------------------|
|Dataset|Yes|Yes|No|
|Entity Data Model|Yes<sup>1</sup>|Yes|Yes|
|LINQ to SQL classes|No<sup>2</sup>|No<sup>2</sup>|No<sup>2</sup>|
|Services (including [!INCLUDE[ssAstoria](../includes/ssastoria-md.md)], WCF services, and web services)|Yes|Yes|Yes|
|Object|Yes|Yes|Yes|
|SharePoint|Yes|Yes|Yes|

 1. Generate the model using the **Entity Data Model** wizard, then drag those objects to the designer.

 2. LINQ to SQL classes do not appear in the **Data Sources** window. However, you can add a new object data source that is based on LINQ to SQL classes, and then drag those objects to the designer to create data-bound controls. For more information, see [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](https://msdn.microsoft.com/library/35aad4a4-2e8a-46e2-ae09-5fbfd333c233).

## Data Sources window
 Data sources are available to your project as items in the **Data Sources** window. This window is visible, or is accessible from the **View** menu, when a form design surface is the active window in your project. You can drag items from this window to create controls that are bound to the underlying data, and you can also configure the data sources by right-clicking.

 ![Data Sources window](../data-tools/media/raddata-data-sources-window.png "raddata Data Sources window")

 For each data type that appears in the **Data Sources** window, a default control is created when you drag the item to the designer. Before you drag an item from the **Data Sources** window, you can change the control that will be created. For more information, see [Set the control to be created when dragging from the Data Sources window](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md).

## Tasks involved in binding controls to data
 The following table lists some of the most common tasks you perform to bind controls to data.

|Task|More information|
|----------|----------------------|
|Open the **Data Sources** window.|Open a design surface in the editor and choose **View** > **Data Sources**.|
|Add a data source to your project.|[Add new data sources](../data-tools/add-new-data-sources.md)|
|Set the control that is created when you drag an item from the **Data Sources** window to the designer.|[Set the control to be created when dragging from the Data Sources window](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md)|
|Modify the list of controls that are associated with items in the **Data Sources** window.|[Add custom controls to the Data Sources window](../data-tools/add-custom-controls-to-the-data-sources-window.md)|
|Create data-bound controls.|[Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)<br /><br /> [Bind WPF controls to data in Visual Studio](../data-tools/bind-wpf-controls-to-data-in-visual-studio1.md)|
|Bind to an object or collection.|[Bind objects in Visual Studio](../data-tools/bind-objects-in-visual-studio.md)|
|Filter data that appears in the UI.|[Filter and sort data in a Windows Forms application](../data-tools/filter-and-sort-data-in-a-windows-forms-application.md)|
|Customize captions for controls.|[Customize how Visual Studio creates captions for data-bound controls](../data-tools/customize-how-visual-studio-creates-captions-for-data-bound-controls.md)|

## See Also
 [Visual Studio data tools for .NET](../data-tools/visual-studio-data-tools-for-dotnet.md)
 [Windows Forms Data Binding](https://msdn.microsoft.com/library/c3826d8e-ea25-4ad4-a669-45bfb19192aa)
