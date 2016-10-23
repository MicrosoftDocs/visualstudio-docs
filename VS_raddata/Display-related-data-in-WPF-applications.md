---
title: "Display related data in WPF applications"
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
ms.assetid: 3aa80194-0191-474d-9d28-5ec05654b426
caps.latest.revision: 16
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
# Display related data in WPF applications
In some applications, you might want to work with data that comes from multiple tables or entities that are related to each other in a parent-child relationship. For example, you might want to display a grid that displays customers from a `Customers` table. When the user selects a specific customer, another grid displays the orders for that customer from a related `Orders` table.  
  
 You can create data-bound controls that display related data by dragging items from the **Data Sources** window to the WPF Designer.  
  
## To create controls that display related records  
  
1.  On the **Data** menu, click **Show Data Sources** to open the **Data Sources** window.  
  
2.  Click **Add New Data Source**, and complete the **Data Source Configuration** wizard.  
  
3.  Open the WPF designer, and make sure that the designer contains a container that is a valid drop target for the items in the **Data Sources** window.  
  
     For more information about valid drop targets, see [Bind WPF controls to data in Visual Studio](../VS_raddata/Bind-WPF-controls-to-data-in-Visual-Studio1.md).  
  
4.  In the **Data Sources** window, expand the node that represents the parent table or object in the relationship. The parent table or object is on the "one" side of a one-to-many relationship.  
  
5.  Drag the parent node (or any individual items in the parent node) from the **Data Sources** window onto a valid drop target in the designer.  
  
     Visual Studio generates XAML that creates new data-bound controls for each item that you drag. The XAML also adds a new <xref:System.Windows.Data.CollectionViewSource?qualifyHint=False> for the parent table or object to the resources of the drop target. For some data sources, Visual Studio also generates code to load the data into the parent table or object. For more information, see [Bind WPF controls to data in Visual Studio](../VS_raddata/Bind-WPF-controls-to-data-in-Visual-Studio1.md).  
  
6.  In the **Data Sources** window, locate the related child table or object. Related child tables and objects appear as expandable nodes at the bottom of the parent node's list of data.  
  
7.  Drag the child node (or any individual items in the child node) from the **Data Sources** window onto a valid drop target in the designer.  
  
     Visual Studio generates XAML that creates new data-bound controls for each of the items you drag. The XAML also adds a new <xref:System.Windows.Data.CollectionViewSource?qualifyHint=False> for the child table or object to the resources of the drop target. This new <xref:System.Windows.Data.CollectionViewSource?qualifyHint=False> is bound to the property of the parent table or object that you just dragged to the designer. For some data sources, Visual Studio also generates code to load the data into the child table or object.  
  
     The following figure demonstrates the related **Orders** table of the **Customers** table in a dataset in the **Data Sources** window.  
  
     ![Data Sources Window showing relation](../VS_raddata/media/DataSources2.gif "DataSources2")  
  
## See Also  
 [Bind WPF controls to data in Visual Studio](../VS_raddata/Bind-WPF-controls-to-data-in-Visual-Studio1.md)   
 [Bind WPF controls to data in Visual Studio](../VS_raddata/Bind-WPF-controls-to-data-in-Visual-Studio2.md)   
 [Create lookup tables in WPF applications](../VS_raddata/Create-lookup-tables-in-WPF-applications.md)   
 [Walkthrough: Displaying Related Data in a WPF Application](../VS_raddata/Walkthrough--Displaying-Related-Data-in-a-WPF-Application.md)