---
title: "Bind WPF controls to data in Visual Studio2"
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
H1: Bind WPF controls to data in Visual Studio
ms.assetid: 00dd5147-db0b-4b59-8d6c-8229b09ca9dd
caps.latest.revision: 26
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
# Bind WPF controls to data in Visual Studio2
You can create data-bound WPF controls by using the **Data Sources** window. First, add a data source to the **Data Sources** window. Then, drag items from the **Data Sources** window to the**WPF Designer**.  
  
##  <a name="adding"></a> Add a data source to the Data Sources window  
 Before you can create data-bound controls, you must first add a data source to the **Data Sources** window.  
  
#### To add a data source to the Data Sources window  
  
1.  On the **View** menu, point to **Other Windows**, and then click **Data Sources**.  
  
2.  Click **Add New Data Source**, and complete the **Data Source Configuration** wizard.  
  
3.  Perform one of the following tasks to create data-bound controls:  
  
    -   [Creating a control that is bound to a single field of data](#simple).  
  
    -   [Creating a control that is bound to multiple fields of data](#complex).  
  
    -   [Creating a set of controls that are bound to multiple fields of data](#details).  
  
    -   [Binding data to existing controls in the designer](#existing).  
  
##  <a name="simple"></a> Create a control that is bound to a single field of data  
 After you add a data source to the **Data Sources** window, you can create a new data-bound control that displays a single field of data, such as a <xref:System.Windows.Controls.ComboBox?qualifyHint=False> or <xref:System.Windows.Controls.TextBox?qualifyHint=False>.  
  
#### To create a control that is bound to a single field of data  
  
1.  In the **Data Sources** window, expand an item that represents a table or an object. Locate the child item that represents the column or property that you want to bind to. For a visual example, see [Data Sources Window](../Topic/Data%20Sources%20Window.md).  
  
2.  Optionally, select the control to create. Each item in the **Data Sources** window has a default control that is created when you drag the item to the designer. The default control depends on the underlying data type of the item.  
  
     To choose a different control, click the drop-down arrow next to the item and select a control. For more information, see [Set the control to be created when dragging from the Data Sources window](../VS_raddata/Set-the-control-to-be-created-when-dragging-from-the-Data-Sources-window.md).  
  
3.  Drag the item to a valid container in the designer. For more information about valid containers, see [Bind WPF controls to data in Visual Studio](../VS_raddata/Bind-WPF-controls-to-data-in-Visual-Studio1.md).  
  
     Visual Studio creates the new data-bound control and an appropriately titled <xref:System.Windows.Controls.Label?qualifyHint=False> in the container. Visual Studio also generates XAML and code to bind the control to the data. For more information, see [Bind WPF controls to data in Visual Studio](../VS_raddata/Bind-WPF-controls-to-data-in-Visual-Studio1.md).  
  
##  <a name="complex"></a> Create a control that is bound to multiple fields of data  
 After you add a data source to the **Data Sources** window, you can create a new data-bound control that displays multiple fields of data, such as a <xref:System.Windows.Controls.DataGrid?qualifyHint=False> or <xref:System.Windows.Controls.ListView?qualifyHint=False>.  
  
#### To create a control that is bound to multiple fields of data  
  
1.  In the **Data Sources** window, select an item that represents a table or object. For a visual example, see [Data Sources Window](../Topic/Data%20Sources%20Window.md).  
  
2.  Optionally, select the control to create. By default, each item in the **Data Sources** window that represents a data table or object is set to create a <xref:System.Windows.Controls.DataGrid?qualifyHint=False> (if your project targets .NET Framework 4) or <xref:System.Windows.Controls.ListView?qualifyHint=False> (for earlier versions of the .NET Framework).  
  
     To select a different control, click the drop-down arrow next to the item and select a control. For more information, see [Set the control to be created when dragging from the Data Sources window](../VS_raddata/Set-the-control-to-be-created-when-dragging-from-the-Data-Sources-window.md).  
  
    > [!NOTE]
    >  If you do not want to display a specific column or property, expand the item to display its children. Click the drop-down arrow next to the column or property that you do not want to display, and then click **None**.  
  
3.  Drag the item to a valid container in the designer, such as a <xref:System.Windows.Controls.Grid?qualifyHint=False>. For more information about valid containers, see [Bind WPF controls to data in Visual Studio](../VS_raddata/Bind-WPF-controls-to-data-in-Visual-Studio1.md).  
  
     Visual Studio creates the new data-bound control in the container. Visual Studio also generates XAML and code to bind the control to the data. For more information, see [Bind WPF controls to data in Visual Studio](../VS_raddata/Bind-WPF-controls-to-data-in-Visual-Studio1.md).  
  
##  <a name="details"></a> Create a set of controls that are bound to multiple fields of data  
 After you add a data source to the **Data Sources** window, you can bind a data table or object to a set of controls. A different control is created for each column or property in the table or object.  
  
#### To create a set of controls that are bound to multiple fields of data  
  
1.  In the **Data Sources** window, select an item that represents a table or object. For a visual example, see [Data Sources Window](../Topic/Data%20Sources%20Window.md).  
  
2.  Click the drop-down arrow next to the item and select **Details**.  
  
    > [!NOTE]
    >  If you do not want to display a specific column or property, expand the item to display its children. Click the drop-down arrow next to the column or property that you do not want to display, and then click **None**.  
  
3.  Drag the item to a valid container in the designer, such as a <xref:System.Windows.Controls.Grid?qualifyHint=False>. For more information about valid containers, see [Bind WPF controls to data in Visual Studio](../VS_raddata/Bind-WPF-controls-to-data-in-Visual-Studio1.md).  
  
     Visual Studio creates the new data-bound controls in the container. Each control is bound to a different column or property, and each control is accompanied by an appropriately titled <xref:System.Windows.Controls.Label?qualifyHint=False> control. Visual Studio also generates XAML and code to bind the controls to the data. For more information, see [Bind WPF controls to data in Visual Studio](../VS_raddata/Bind-WPF-controls-to-data-in-Visual-Studio1.md).  
  
##  <a name="existing"></a> Binddata to existing controls in the designer  
 After you add a data source to the **Data Sources** window, you can add a data binding to an existing control in the designer.  
  
#### To bind data to an existing control in the designer  
  
1.  In the **Data Sources** window, use one of the following procedures:  
  
    -   To add a data binding to an existing control that displays multiple fields of data, such as a <xref:System.Windows.Controls.DataGrid?qualifyHint=False> or <xref:System.Windows.Controls.ListView?qualifyHint=False>, select the item that represents the table or object that you want to bind to the control.  
  
    -   To add a data binding to an existing control that displays a single field of data, such as a <xref:System.Windows.Controls.ComboBox?qualifyHint=False> or <xref:System.Windows.Controls.TextBox?qualifyHint=False>, expand the item that represents the table or object that contains the data, and then select the item that represents the data that you want to bind to the control.  
  
2.  Drag the selected item from the **Data Sources** window onto an existing control in the designer. The control must be a valid drop target. For more information, see [Bind WPF controls to data in Visual Studio](../VS_raddata/Bind-WPF-controls-to-data-in-Visual-Studio1.md).  
  
     Visual Studio generates XAML and code to bind the control to the data. For more information, see [Bind WPF controls to data in Visual Studio](../VS_raddata/Bind-WPF-controls-to-data-in-Visual-Studio1.md).  
  
    > [!NOTE]
    >  If the control is already bound to data, the data binding for the control is reset to the item that was dragged onto the control most recently.  
  
## See Also  
 [Bind WPF controls to data in Visual Studio](../VS_raddata/Bind-WPF-controls-to-data-in-Visual-Studio1.md)   
 [Create lookup tables in WPF applications](../VS_raddata/Create-lookup-tables-in-WPF-applications.md)   
 [Display related data in WPF applications](../VS_raddata/Display-related-data-in-WPF-applications.md)   
 [Bind WPF controls to a dataset](../VS_raddata/Bind-WPF-controls-to-a-dataset.md)   
 [Bind WPF controls to a WCF data service](../VS_raddata/Bind-WPF-controls-to-a-WCF-data-service.md)   
 [Walkthrough: Displaying Related Data in a WPF Application](../VS_raddata/Walkthrough--Displaying-Related-Data-in-a-WPF-Application.md)