---
title: Set control to create when dragging
description: Discover how to set the control to be created when you drag from the Data Sources window onto the WPF designer or Windows Forms designer when developing .NET Framework applications in Visual Studio.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- Data Sources Window, select controls
- Windows Forms, displaying data
- data [Visual Studio], displaying on Windows Forms
- data [Visual Studio], Data Sources window
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Set the control to be created when dragging from the Data Sources window

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

You can create data-bound controls by dragging items from the **Data Sources** window onto the WPF designer or Windows Forms designer. Each item in the **Data Sources** window has a default control that is created when you drag it to the designer. However, you can choose to create a different control.

## Set the controls to be created for data tables or objects

Before you drag items that represent data tables or objects from the **Data Sources** window, you can choose to display all the data in one control, or to display each column or property in a separate control.

In this context, the term *object* refers to a custom business object, an entity (in an Entity Data Model), or an object returned by a service.

### To set the controls to be created for data tables or objects

1. Be sure the **WPF** designer or the **Windows Forms** designer is open.

2. In the **Data Sources** window, select the item that represents the data table or object you want to set.

   > [!TIP]
   > If the **Data Sources** window is not open, you can open it by selecting **View** > **Other Windows** > **Data Sources**.

3. Click the dropdown list menu for the item, and then select one of the following items in the menu:

    - To display each data field in a separate control, click **Details**. When you drag the data item to the designer, this action will create a different data-bound control for each column or property of the parent data table or object, along with labels for each control.

    - To display all of the data in a single control, select a different control in the list, such as **DataGrid** or **List** in a WPF application, or **DataGridView** in a Windows Forms application.

    The list of available controls depends on which designer you have open, which version of .NET your project targets, and whether you have added custom controls that support data binding to the **Toolbox**. If the control you want to create is not in the list of available controls, you can add the control to the list. For more information, see [Add custom controls to the Data Sources window](../data-tools/add-custom-controls-to-the-data-sources-window.md).

    To learn how to create a custom Windows Forms control that can be added to the list of controls for data tables or objects in the **Data Sources** window, see [Create a Windows Forms user control that supports complex data binding](../data-tools/create-a-windows-forms-user-control-that-supports-complex-data-binding.md).

## Set the controls to be created for data columns or properties

Before you drag an item that represents a column or a property of an object from the **Data Sources** window to the designer, you can set the control to be created.

### To set the controls to be created for columns or properties

1. Be sure the **WPF** designer or the **Windows Forms** designer is open.

2. In the **Data Sources** window, expand the desired table or object to display its columns or properties.

3. Select each column or property for which you want to set the control to be created.

4. Click the dropdown list menu for the column or property, and then select the control you want to create when the item is dragged to the designer.

     The list of available controls depends on which designer you have open, which version of .NET your project targets, and which custom controls that support data binding you have added to the **Toolbox**. If the control you want to create is in the list of available controls, you can add the control to the list. For more information, see [Add custom controls to the Data Sources window](../data-tools/add-custom-controls-to-the-data-sources-window.md).

     To learn how to create a custom control that can be added to the list of controls for data columns or properties in the **Data Sources** window, see [Create a Windows Forms user control that supports simple data binding](../data-tools/create-a-windows-forms-user-control-that-supports-simple-data-binding.md).

     If you don't want to create a control for the column or property, select **None** in the dropdown list menu. This is useful if you want to drag the parent table or object to the designer, but you do not want to include the specific column or property.

## Related content

- [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)
