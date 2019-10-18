---
title: "Add custom controls to the Data Sources window | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
f1_keywords:
  - "vs.datasource.howtoaddcustomcontrol"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords:
  - "Data Sources Window, adding controls"
  - "controls [Visual Studio], adding to Data Sources Window"
  - "DefaultBindingPropertyAttribute class, using"
  - "LookupBindingPropertiesAttribute class, using"
  - "ComplexBindingPropertiesAttribute class, using"
  - "Data Sources Window, selecting controls"
ms.assetid: 8c43e7d2-ba94-4d9b-96de-3aa971955afd
caps.latest.revision: 45
author: jillre
ms.author: jillfra
manager: jillfra
---
# Add custom controls to the Data Sources window
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When you drag an item from the **Data Sources** window to a design surface to create a data-bound control, you can select the type of control that you create. Each item in the window has a drop-down list that displays the controls that you can choose from. The set of controls associated with each item is determined by the data type of the item. If the control that you want to create does not appear in the list, you can follow the instructions in this topic to add the control to the list.

 For more information about selecting data-bound controls to create for items in the **Data Sources** window, see [Set the control to be created when dragging from the Data Sources window](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md).

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help, depending on your active settings or edition. To change your settings, on the **Tools** menu, select **Import and Export Settings**. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).

## <a name="customizinglist"></a> Customize the list of bindable controls for a data type
 To add or remove controls from the list of available controls for items in the **Data Sources** window that have a specific data type, perform the following steps.

#### To select the controls to be listed for a data type

1. Make sure that the WPF Designer or the Windows Forms Designer is open.

2. In the **Data Sources** window, click an item that is part of a data source you added to the window, and then click the drop-down menu for the item.

3. In the drop-down menu, click **Customize**. One of the following dialog boxes opens:

    - If the Windows Forms Designer is open, the **Data UI Customization** page of the **Options** dialog box opens.

    - If the WPF Designer is open, the **Customize Control Binding** dialog box opens.

4. In the dialog box, select a data type from the **Data type** drop-down list.

    - To customize the list of controls for a table or object, select **[List]**.

    - To customize the list of controls for a column of a table or a property of an object, select the data type of the column or property in the underlying data store.

    - To customize the list of controls to display data objects that have user-defined shapes, select **[Other]**. For example, select **[Other]** if your application has a custom control that displays data from more than one property of a particular object.

5. In the **Associated controls** box, select each control that you want to be available for the selected data type, or clear the selection of any controls that you want to remove from the list.

    > [!NOTE]
    > If the control that you want to select does not appear in the **Associated controls** box, you must add the control to the list. For more information, see [Adding Controls to the List of Associated Controls for a Data Type](#addingcontrols).

6. Click **OK**.

7. In the **Data Sources** window, click an item of the data type that you just associated one or more controls, and then click the drop-down menu for the item.

     The controls you selected in the **Associated controls** box now appear in the drop-down menu for the item.

## <a name="addingcontrols"></a> Addcontrols to the list of associated controls for a data type
 If you want to associate a control with a data type, but the control does not appear in the **Associated controls** box, you must add the control to the list. The control must be located in the current solution or in a referenced assembly. It must also be available in the **Toolbox**, and have an attribute that specifies the control's data binding behavior.

#### To add controls to the list of associated controls

1. Add the desired control to the **Toolbox** by right-clicking the **Toolbox** and selecting **Choose Items**.

     The control must have one of the following attributes.

    |Attribute|Description|
    |---------------|-----------------|
    |<xref:System.ComponentModel.DefaultBindingPropertyAttribute>|Implement this attribute on simple controls that display a single column (or property) of data, such as a <xref:System.Windows.Forms.TextBox>.|
    |<xref:System.ComponentModel.ComplexBindingPropertiesAttribute>|Implement this attribute on controls that display lists (or tables) of data, such as a <xref:System.Windows.Forms.DataGridView>.|
    |<xref:System.ComponentModel.LookupBindingPropertiesAttribute>|Implement this attribute on controls that display lists (or tables) of data, but also need to present a single column or property, such as a <xref:System.Windows.Forms.ComboBox>.|

2. For Windows Forms, on the      **Options** dialog box, open the **Data UI Customization** page. Or, for WPF, open the **Customize Control Binding** dialog box. For more information, see [Customizing the List of Bindable Controls for a Data Type](#customizinglist).

3. In the **Associated controls** box, the control that you just added to the **Toolbox** should now appear.

    > [!NOTE]
    > Only controls that are located within the current solution or in a referenced assembly can be added to the list of associated controls. (The controls must also implement one of the data-binding attributes in the previous table.) To bind data to a custom control that is not available in the **Data Sources** window, drag the control from the **Toolbox** onto the design surface, and then drag the item to bind to from the **Data Sources** window onto the control.

## See Also
 [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)
