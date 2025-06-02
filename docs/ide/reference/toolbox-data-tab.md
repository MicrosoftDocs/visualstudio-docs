---
title: Toolbox, Data Tab
description: Learn about the data objects you'll find in the Data tab of the Toolbox window.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- Toolbox, Data tab
- Data tab, Toolbox
- data [Visual Studio], Toolbox
ms.custom: "ide-ref"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# Toolbox, Data tab

Displays data objects you can add to a forms and components. The **Data** tab of the **Toolbox** appears when you create a project that has an associated designer. The **Toolbox** appears by default in the Visual Studio integrated development environment; if you need to display the **Toolbox**, select **Toolbox** from the **View** menu.

> [!TIP]
> Running the Data Source Configuration Wizard automatically creates and configures most data items. For more information, see [Add new data sources](../../data-tools/add-new-data-sources.md).

## UI Element list

To go directly to the .NET reference page for a component, press **F1** on the item in the **Toolbox** or on the component item in the tray of the designer.

|Name|Description|
|----------|-----------------|
|<xref:System.Data.DataSet>|Adds an instance of a typed or untyped dataset to the form or component. When you drag this object onto a designer, it displays a dialog box that allows you to select an existing typed dataset class or specify that you want to create a new, blank, untyped dataset. **Note:**  You do not use the <xref:System.Data.DataSet> object on the **Toolbox** to create a new typed dataset schema and class. For more information, see [Create and configure datasets](../../data-tools/create-and-configure-datasets-in-visual-studio.md).|
|<xref:System.Windows.Forms.DataGridView>|Provides a powerful and flexible way to display data in a tabular format.|
|<xref:System.Windows.Forms.BindingSource>|Simplifies the process of binding controls to an underlying data source.|
|<xref:System.Windows.Forms.BindingNavigator>|Represents the navigation and manipulation user interface (UI) for controls on a form that are bound to data.|

## See also

- [Access Data in Visual Studio](../../data-tools/accessing-data-in-visual-studio.md)
- [Visual Studio data tools for .NET](../../data-tools/visual-studio-data-tools-for-dotnet.md)
- [Dataset tools in Visual Studio](../../data-tools/dataset-tools-in-visual-studio.md)
- [Bind controls to data in Visual Studio](../../data-tools/bind-controls-to-data-in-visual-studio.md)
- [Bind Windows Forms controls to data in Visual Studio](../../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)
- [Edit data in datasets](../../data-tools/edit-data-in-datasets.md)
- [Validate data in datasets](../../data-tools/validate-data-in-datasets.md)
