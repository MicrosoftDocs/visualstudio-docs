---
title: Add custom controls to the Data Sources window for .NET Framework applications
description: Add custom controls to the Data Sources window with ADO.NET in Visual Studio. Customize the bindable controls list. Add associated controls.
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords:
- vs.datasource.howtoaddcustomcontrol
helpviewer_keywords:
- Data Sources Window, adding controls
- controls [Visual Studio], adding to Data Sources Window
- DefaultBindingPropertyAttribute class, using
- LookupBindingPropertiesAttribute class, using
- ComplexBindingPropertiesAttribute class, using
- Data Sources Window, selecting controls
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Add custom controls to the Data Sources window for .NET Framework applications

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

When you drag an item from the Data Sources window to a design surface to create a data-bound control, you can select the type of control that you create. Each item in the window has a dropdown list that displays the controls that you can choose from. The set of controls associated with each item is determined by the data type of the item. If the control that you want to create does not appear in the list, you can follow the instructions in this topic to add the control to the list.

For more information about selecting data-bound controls to create for items in the Data Sources window, see [Set the control to be created when dragging from the Data Sources window](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md).

## Customize the bindable controls list

To add or remove controls from the list of available controls for items in the Data Sources window that have a specific data type, perform the following steps.

### To select the controls to be listed for a data type

1. Make sure that the WPF Designer or the Windows Forms Designer is open.

2. In the **Data Sources** window, click an item that is part of a data source you added to the window, and then select the dropdown list menu for the item.

   > [!TIP]
   > If the Data Sources window isn't open, open it by selecting **View** > **Other Windows** > **Data Sources**.

3. In the dropdown list menu, click **Customize**. One of the following dialog boxes opens:

    - If the **Windows Forms Designer** is open, the **Data UI Customization** page of the **Options** dialog box opens. For more information, see [Data UI Customization options dialog box](../ide/reference/options-windows-forms-designer-data-ui-customization.md).

    - If the **WPF Designer** is open, the **Customize Control Binding** dialog box opens.

4. In the dialog box, select a data type from the **Data type** dropdown list.

    - To customize the list of controls for a table or object, select **[List]**.

    - To customize the list of controls for a column of a table or a property of an object, select the data type of the column or property in the underlying data store.

    - To customize the list of controls to display data objects that have user-defined shapes, select **[Other]**. For example, select **[Other]** if your application has a custom control that displays data from more than one property of a particular object.

5. In the **Associated controls** box, select each control that you want to be available for the selected data type, or clear the selection of any controls that you want to remove from the list.

    > [!NOTE]
    > If the control that you want to select does not appear in the **Associated controls** box, you must add the control to the list. For more information, see [Add associated controls](#add-associated-controls).

6. Click **OK**.

7. In the **Data Sources** window, click an item of the data type that you just associated one or more controls, and then select the dropdown list menu for the item.

     The controls you selected in the **Associated controls** box now appear in the dropdown list menu for the item.

## Add associated controls

If you want to associate a control with a data type, but the control does not appear in the **Associated controls** box, you must add the control to the list. The control must be located in the current solution or in a referenced assembly. It must also be available in the **Toolbox** and have an attribute that specifies the control's data binding behavior.

To add controls to the list of associated controls:

1. Add the desired control to the **Toolbox** by right-clicking the **Toolbox** and selecting **Choose Items**.

     The control must have one of the following attributes:

    |Attribute|Description|
    |---------------|-----------------|
    |<xref:System.ComponentModel.DefaultBindingPropertyAttribute>|Implement this attribute on simple controls that display a single column (or property) of data, such as a <xref:System.Windows.Forms.TextBox>.|
    |<xref:System.ComponentModel.ComplexBindingPropertiesAttribute>|Implement this attribute on controls that display lists (or tables) of data, such as a <xref:System.Windows.Forms.DataGridView>.|
    |<xref:System.ComponentModel.LookupBindingPropertiesAttribute>|Implement this attribute on controls that display lists (or tables) of data, but also need to present a single column or property, such as a <xref:System.Windows.Forms.ComboBox>.|

2. For Windows Forms, on the **Options** dialog box, open the **Data UI Customization** page. Or, for WPF, open the **Customize Control Binding** dialog box. For more information, see [Customize the list of bindable controls for a data type](#customize-the-bindable-controls-list).

3. In the **Associated controls** box, the control that you just added to the **Toolbox** should now appear.

    > [!NOTE]
    > Only controls that are located within the current solution or in a referenced assembly can be added to the list of associated controls. (The controls must also implement one of the data-binding attributes in the previous table.) To bind data to a custom control that is not available in the Data Sources window, drag the control from the **Toolbox** onto the design surface, and then drag the item to bind to from the **Data Sources** window onto the control.

## Related content

- [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)
- [Data UI Customization options dialog box](../ide/reference/options-windows-forms-designer-data-ui-customization.md)
