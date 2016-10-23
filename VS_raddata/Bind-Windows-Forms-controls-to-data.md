---
title: "Bind Windows Forms controls to data"
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
ms.assetid: 0163a34a-38cb-40b9-8f38-3058a90caf21
caps.latest.revision: 28
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
# Bind Windows Forms controls to data
You can bind data sources to controls by dragging objects from the **Data Sources** window onto a Windows Form or onto an existing control on a form. Before you drag items, you can set the type of control you want to bind to. Different values appear depending on whether you choose the table itself, or an individual column.  You can also set custom values. For a table, "Details" means that each column is bound to a separate control.  
  
 ![Bind data source to DataGridView](../VS_raddata/media/raddata-Bind-data-source-to-DataGridView.png "raddata Bind data source to DataGridView")  
  
 > [!NOTE]
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalizing the  IDE](../VS_IDE/Personalizing-the-Visual-Studio-IDE.md).  
  
## Bind to  data in a DataGridView control  
 For DataGridView, the entire table is bound to that single control. When you drag a DataGridView to the form, a tool strip for navigating records (<xref:System.Windows.Forms.BindingNavigator?qualifyHint=False>) also appears. A [DataSet](../VS_raddata/Dataset-tools-in-Visual-Studio.md), [TableAdapter](../VS_raddata/TableAdapter-Overview.md), <xref:System.Windows.Forms.BindingSource?qualifyHint=False>, and <xref:System.Windows.Forms.BindingNavigator?qualifyHint=False> appear in the component tray. In the following illustration, a TableAdapterManager is also added because the Customers table has a relation to the Orders table. These variables are all declared in the auto-generated code as private members in the form class. The auto-generated code for filling the DataGridView is located in the form_load event handler. The code for saving the data to update the database is located in the Save event handler for the BindingNavigator. You can move or modify this code as needed.  
  
 ![GridView with BindingNavigator](../VS_raddata/media/raddata-GridView-with-BindingNavigator.png "raddata GridView with BindingNavigator")  
  
 You can customize the behavior of the DataGridView and the BindingNavigator by clicking on the smart tag in the upper right corner of each:  
  
 ![DataGridView and Binding Navigator smart tags](../VS_raddata/media/raddata-DataGridView-and-Binding-Navigator-smart-tags.png "raddata DataGridView and Binding Navigator smart tags")  
  
 If the controls your application needs are not available from within the **Data Sources** window, you can add controls. For more information, see [Add custom controls to the Data Sources window](../VS_raddata/Add-custom-controls-to-the-Data-Sources-window.md).  
  
 You can also drag items from the **Data Sources** window onto controls already on a form to bind the control to data. A control that is already bound to data has its data bindings reset to the item most recently dragged onto it. To be valid drop targets, controls must be capable of displaying the underlying data type of the item dragged onto it from the **Data Sources** window. For example, it's not valid to drag an item that has a data type of <xref:System.DateTime?qualifyHint=False> onto a <xref:System.Windows.Forms.CheckBox?qualifyHint=False>, because the <xref:System.Windows.Forms.CheckBox?qualifyHint=False> is not capable of displaying a date.  
  
## Bind to  data in individual controls  
 When you bind a data source to "Details," each column in the dataset is bound to a separate control.  
  
 ![Bind data source to details](../VS_raddata/media/raddata-Bind-data-source-to-details.png "raddata Bind data source to details")  
  
> [!IMPORTANT]
>  Note that in the previous  illustration, you drag from the Orders property of the Customers table, not from the Orders table. By binding to the Customer.Orders property, navigation commands made in the DataGridView are reflected immediately in the details controls. If you dragged from the Orders table, the controls would still be bound to the dataset, but not they would not be synchronized with the DataGridView.  
  
 The following illustration shows the default data-bound controls that are added to the form after the Orders property in the Customers table is bound to "Details" in the **Data Sources** window.  
  
 ![Orders table bound to details](../VS_raddata/media/raddata-Orders-table-bound-to-details.png "raddata Orders table bound to details")  
  
 Note also that each control has a smart tag. This tag enables customizations that apply to that control only.  
  
## See Also  
 [Bind Windows Forms controls to data in Visual Studio](../VS_raddata/Bind-Windows-Forms-controls-to-data-in-Visual-Studio.md)