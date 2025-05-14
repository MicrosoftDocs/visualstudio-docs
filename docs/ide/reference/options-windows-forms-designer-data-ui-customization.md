---
title: Options, Windows Forms Designer, Data UI Customization
description: Learn how to use the Data UI Customization page to define which controls appear in the list of available controls for items in the Data Sources window.
ms.date: 08/09/2019
ms.topic: reference
f1_keywords:
- VS.ToolsOptionsPages.WindowsFormsDesigner.Data_UI_Customization
helpviewer_keywords:
- Data UI customization options
- Options dialog box, Windows Forms Designer, Data UI Customization
ms.custom: "ide-ref"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# Options dialog box: Windows Forms Designer > Data UI Customization

This dialog box defines which controls appear in the list of available controls for items in the Data Sources window. To open it, select **Tools** > **Options**, and then select **Windows Forms Designer** > **Data UI Customization**.

You can select a control from an item in the Data Sources window prior to dragging it onto the form in a Windows Forms app. Available controls are determined by the data type of the item. Each data type has a list of valid associated controls as defined in this dialog box, including a default control. When you drag an item from the Data Sources window onto a form without selecting a control, the default control for the data type of the selected item is added to the form.

Customize the list of associated controls by selecting and clearing the check boxes of available controls for each data type. To add a control to the list, add a control that implements either the <xref:System.ComponentModel.DefaultBindingPropertyAttribute> or <xref:System.ComponentModel.ComplexBindingPropertiesAttribute> data-binding attribute to the Toolbox. The control will then appear in the list of controls for the data type. For more information, see [How to: Add Custom Controls to the Data Sources window](../..//data-tools/add-custom-controls-to-the-data-sources-window.md).

## Data type

Displays a list of types with which you associate controls. Tables are represented as the `[List]` data type. Columns are represented as the actual data type of the column in the underlying data store.

## Associated controls

Displays a list of controls that are associated with the selected data type. Select or clear the checkbox next to the control to associate or disassociate it. Selected controls appear in Data Sources window for a database column that's bound to the associated data type.

## Set Default

Assigns the selected control type to be the default for the selected data type. The default control appears as the first selection in the shortcut menu for a database column in the Data Sources window. When you drag an item from the Data Sources window onto a form without selecting a control, the default control for the data type of the selected item is added to the form.

Only one control type can be assigned as the default for a data type.

## Clear Default

Removes the designation of a control as the default for the selected data type. If there is no default for the selected data type, `[None]` appears as the first selection in the shortcut menu for a database column of that type.
