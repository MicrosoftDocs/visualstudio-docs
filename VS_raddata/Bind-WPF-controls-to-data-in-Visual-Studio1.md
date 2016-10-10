---
title: "Bind WPF controls to data in Visual Studio1"
ms.custom: na
ms.date: 10/10/2016
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
ms.assetid: e05a1e0c-5082-479d-bbc9-d395b0bc6580
caps.latest.revision: 36
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
# Bind WPF controls to data in Visual Studio1
You can display data to users of your application by binding data to WPF controls. To create these data-bound controls, you can drag items from the **Data Sources** window onto the WPF Designer in Visual Studio. This topic describes some of the most common tasks, tools, and classes that you can use to create data-bound WPF applications.  
  
 For general information about how to create data-bound controls in Visual Studio, see [Bind controls to data in Visual Studio](../VS_raddata/Bind-controls-to-data-in-Visual-Studio.md). For more information about WPF data binding, see [Data Binding Overview](../Topic/Data%20Binding%20Overview.md).  
  
## Tasks involved in binding WPF controls to data  
 The following table lists the tasks that can be accomplished by dragging items from the **Data Sources** window to the WPF Designer.  
  
|Task|More information|  
|----------|----------------------|  
|Create new data-bound controls.<br /><br /> Bind existing controls to data.|[Bind WPF controls to data in Visual Studio](../VS_raddata/Bind-WPF-controls-to-data-in-Visual-Studio2.md) [Bind WPF controls to a dataset](../VS_raddata/Bind-WPF-controls-to-a-dataset.md)|  
|Create controls that display related data in a parent-child relationship: when the user selects a parent data record in one control, another control displays related child data for the selected record.|[Display related data in WPF applications](../VS_raddata/Display-related-data-in-WPF-applications.md)|  
|Create a *lookup table* that displays information from one table based on the value of a foreign-key field in another table.|[Create lookup tables in WPF applications](../VS_raddata/Create-lookup-tables-in-WPF-applications.md)|  
|Bind a control to an image in a database.|[Bind controls to pictures from a database](../VS_raddata/Bind-controls-to-pictures-from-a-database.md)|  
  
## Valid drop targets  
 You can drag items in the **Data Sources** window only to valid drop targets in the WPF Designer. There are two main kinds of valid drop targets: containers and controls. A container is a user interface element that typically contains controls. For example, a grid is a container, and so is a window.  
  
## Generated XAML and code  
 When you drag an item from the **Data Sources** window to the WPF Designer, Visual Studio generates XAML that defines a new data-bound control (or binds an existing control to the data source). For some data sources, Visual Studio also generates code in the code-behind file that fills the data source with data.  
  
 The following table lists the XAML and code that Visual Studio generates for each type of data source in the **Data Sources** window.  
  
|Data source|Generate XAML that binds a control to the data source|Generate code that fills the data source with data|  
|-----------------|-----------------------------------------------------------|--------------------------------------------------------|  
|Dataset|Yes|Yes|  
|Entity Data Model|Yes|Yes|  
|Service|Yes|No|  
|Object|Yes|No|  
  
### Datasets  
 When you drag a table or column from the **Data Sources** window to the designer, Visual Studio generates XAML that does the following:  
  
-   Adds the dataset and a new <xref:System.Windows.Data.CollectionViewSource?qualifyHint=False> to the resources of the container you dragged the item to. The <xref:System.Windows.Data.CollectionViewSource?qualifyHint=False> is an object that can be used to navigate and display the data in the dataset.  
  
-   Creates a data binding for a control. If you drag the item to an existing control in the designer, the XAML binds the control to the item. If you drag the item to a container, the XAML creates the control that was selected for the dragged item, and it binds the control to the item. The control is created inside a new <xref:System.Windows.Controls.Grid?qualifyHint=False>.  
  
 Visual Studio also makes the following changes to the code-behind file:  
  
-   Creates a <xref:System.Windows.FrameworkElement.Loaded?qualifyHint=False> event handler for the UI element that contains the control. The event handler fills the table with data, retrieves the <xref:System.Windows.Data.CollectionViewSource?qualifyHint=False> from the container's resources, and then makes the first data item the current item. If a <xref:System.Windows.FrameworkElement.Loaded?qualifyHint=False> event handler already exists, Visual Studio adds this code to the existing event handler.  
  
### Entity data models  
 When you drag an entity or an entity property from the **Data Sources** window to the designer, Visual Studio generates XAML that does the following:  
  
-   Adds a new <xref:System.Windows.Data.CollectionViewSource?qualifyHint=False> to the resources of the container you dragged the item to. The <xref:System.Windows.Data.CollectionViewSource?qualifyHint=False> is an object that can be used to navigate and display the data in the entity.  
  
-   Creates a data binding for a control. If you drag the item to an existing control in the designer, the XAML binds the control to the item. If you drag the item to a container, the XAML creates the control that was selected for the dragged item, and it binds the control to the item. The control is created inside a new <xref:System.Windows.Controls.Grid?qualifyHint=False>.  
  
 Visual Studio also makes the following changes to the code-behind file:  
  
-   Adds a new method that returns a query for the entity that you dragged to the designer (or the entity that contains the property that you dragged to the designer). The new method has the name Get*EntityName*Query, where *EntityName* is the name of the entity.  
  
-   Creates a <xref:System.Windows.FrameworkElement.Loaded?qualifyHint=False> event handler for the UI element that contains the control. The event handler calls the Get*EntityName*Query method to fill the entity with data, retrieves the <xref:System.Windows.Data.CollectionViewSource?qualifyHint=False> from the container's resources, and then makes the first data item the current item. If a <xref:System.Windows.FrameworkElement.Loaded?qualifyHint=False> event handler already exists, Visual Studio adds this code to the existing event handler.  
  
### Services  
 When you drag a service object or property from the **Data Sources** window to the designer, Visual Studio generates XAML that creates a data-bound control (or binds an existing control to the object or property). However, Visual Studio does not generate code that fills the proxy service object with data. You must write this code yourself. For an example that demonstrates how to do this, see [Bind WPF controls to a WCF data service](../VS_raddata/Bind-WPF-controls-to-a-WCF-data-service.md).  
  
 Visual Studio generates XAML that does the following:  
  
-   Adds a new <xref:System.Windows.Data.CollectionViewSource?qualifyHint=False> to the resources of the container that you dragged the item to. The <xref:System.Windows.Data.CollectionViewSource?qualifyHint=False> is an object that can be used to navigate and display the data in the object that is returned by the service.  
  
-   Creates a data binding for a control. If you drag the item to an existing control in the designer, the XAML binds the control to the item. If you drag the item to a container, the XAML creates the control that was selected for the dragged item, and it binds the control to the item. The control is created inside a new <xref:System.Windows.Controls.Grid?qualifyHint=False>.  
  
### Objects  
 When you drag an object or property from the **Data Sources** window to the designer, Visual Studio generates XAML that creates a data-bound control (or binds an existing control to the object or property). However, Visual Studio does not generate code to fill the object with data. You must write this code yourself.  
  
> [!NOTE]
>  Custom classes must be public and, by default,  have a constructor without parameters. They can'tbe nested classes that have a "dot" in their syntax. For more information, see [XAML and Custom Classes for WPF](../Topic/XAML%20and%20Custom%20Classes%20for%20WPF.md).  
  
 Visual Studio generates XAML that does the following:  
  
-   Adds a new <xref:System.Windows.Data.CollectionViewSource?qualifyHint=False> to the resources of the container that you dragged the item to. The <xref:System.Windows.Data.CollectionViewSource?qualifyHint=False> is an object that can be used to navigate and display the data in the object.  
  
-   Creates a data binding for a control. If you drag the item to an existing control in the designer, the XAML binds the control to the item. If you drag the item to a container, the XAML creates the control that was selected for the dragged item, and it binds the control to the item. The control is created inside a new <xref:System.Windows.Controls.Grid?qualifyHint=False>.  
  
## See Also  
 [Bind controls to data in Visual Studio](../VS_raddata/Bind-controls-to-data-in-Visual-Studio.md)