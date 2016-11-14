---
title: "Bind WPF controls to data in Visual Studio1 | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords: 
  - "data [WPF], displaying"
  - "WPF, data binding in Visual Studio"
  - "WPF data binding [Visual Studio]"
  - "displaying data, WPF"
  - "WPF [WPF], data"
  - "WPF Designer, data binding"
  - "data binding, WPF"
ms.assetid: e05a1e0c-5082-479d-bbc9-d395b0bc6580
caps.latest.revision: 36
author: "mikeblome"
ms.author: "mblome"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Bind WPF controls to data in Visual Studio
You can display data to users of your application by binding data to [!INCLUDE[TLA#tla_titlewinclient](../data-tools/includes/tlasharptla_titlewinclient_md.md)] controls. To create these data-bound controls, you can drag items from the **Data Sources** window onto the [!INCLUDE[wpfdesigner_current_short](../data-tools/includes/wpfdesigner_current_short_md.md)] in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. This topic describes some of the most common tasks, tools, and classes that you can use to create data-bound [!INCLUDE[TLA#tla_titlewinclient](../data-tools/includes/tlasharptla_titlewinclient_md.md)] applications.  
  
 For general information about how to create data-bound controls in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], see [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md). For more information about [!INCLUDE[TLA#tla_titlewinclient](../data-tools/includes/tlasharptla_titlewinclient_md.md)] data binding, see [Data Binding Overview](../Topic/Data%20Binding%20Overview.md).  
  
## Tasks involved in binding WPF controls to data  
 The following table lists the tasks that can be accomplished by dragging items from the **Data Sources** window to the [!INCLUDE[wpfdesigner_current_short](../data-tools/includes/wpfdesigner_current_short_md.md)].  
  
|Task|More information|  
|----------|----------------------|  
|Create new data-bound controls.<br /><br /> Bind existing controls to data.|[Bind WPF controls to data in Visual Studio](../data-tools/bind-wpf-controls-to-data-in-visual-studio2.md) [Bind WPF controls to a dataset](../data-tools/bind-wpf-controls-to-a-dataset.md)|  
|Create controls that display related data in a parent-child relationship: when the user selects a parent data record in one control, another control displays related child data for the selected record.|[Display related data in WPF applications](../data-tools/display-related-data-in-wpf-applications.md)|  
|Create a *lookup table* that displays information from one table based on the value of a foreign-key field in another table.|[Create lookup tables in WPF applications](../data-tools/create-lookup-tables-in-wpf-applications.md)|  
|Bind a control to an image in a database.|[Bind controls to pictures from a database](../data-tools/bind-controls-to-pictures-from-a-database.md)|  
  
## Valid drop targets  
 You can drag items in the **Data Sources** window only to valid drop targets in the [!INCLUDE[wpfdesigner_current_short](../data-tools/includes/wpfdesigner_current_short_md.md)]. There are two main kinds of valid drop targets: containers and controls. A container is a user interface element that typically contains controls. For example, a grid is a container, and so is a window.  
  
## Generated XAML and code  
 When you drag an item from the **Data Sources** window to the [!INCLUDE[wpfdesigner_current_short](../data-tools/includes/wpfdesigner_current_short_md.md)], [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] generates [!INCLUDE[TLA#tla_titlexaml](../data-tools/includes/tlasharptla_titlexaml_md.md)] that defines a new data-bound control (or binds an existing control to the data source). For some data sources, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] also generates code in the code-behind file that fills the data source with data.  
  
 The following table lists the [!INCLUDE[TLA#tla_titlexaml](../data-tools/includes/tlasharptla_titlexaml_md.md)] and code that [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] generates for each type of data source in the **Data Sources** window.  
  
|Data source|Generate XAML that binds a control to the data source|Generate code that fills the data source with data|  
|-----------------|-----------------------------------------------------------|--------------------------------------------------------|  
|Dataset|Yes|Yes|  
|[!INCLUDE[adonet_edm](../data-tools/includes/adonet_edm_md.md)]|Yes|Yes|  
|Service|Yes|No|  
|Object|Yes|No|  
  
### Datasets  
 When you drag a table or column from the **Data Sources** window to the designer, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] generates [!INCLUDE[TLA#tla_titlexaml](../data-tools/includes/tlasharptla_titlexaml_md.md)] that does the following:  
  
-   Adds the dataset and a new <xref:System.Windows.Data.CollectionViewSource> to the resources of the container you dragged the item to. The <xref:System.Windows.Data.CollectionViewSource> is an object that can be used to navigate and display the data in the dataset.  
  
-   Creates a data binding for a control. If you drag the item to an existing control in the designer, the XAML binds the control to the item. If you drag the item to a container, the XAML creates the control that was selected for the dragged item, and it binds the control to the item. The control is created inside a new <xref:System.Windows.Controls.Grid>.  
  
 [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] also makes the following changes to the code-behind file:  
  
-   Creates a <xref:System.Windows.FrameworkElement.Loaded> event handler for the [!INCLUDE[TLA2#tla_ui](../data-tools/includes/tla2sharptla_ui_md.md)] element that contains the control. The event handler fills the table with data, retrieves the <xref:System.Windows.Data.CollectionViewSource> from the container's resources, and then makes the first data item the current item. If a <xref:System.Windows.FrameworkElement.Loaded> event handler already exists, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] adds this code to the existing event handler.  
  
### Entity data models  
 When you drag an entity or an entity property from the **Data Sources** window to the designer, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] generates [!INCLUDE[TLA#tla_titlexaml](../data-tools/includes/tlasharptla_titlexaml_md.md)] that does the following:  
  
-   Adds a new <xref:System.Windows.Data.CollectionViewSource> to the resources of the container you dragged the item to. The <xref:System.Windows.Data.CollectionViewSource> is an object that can be used to navigate and display the data in the entity.  
  
-   Creates a data binding for a control. If you drag the item to an existing control in the designer, the [!INCLUDE[TLA#tla_titlexaml](../data-tools/includes/tlasharptla_titlexaml_md.md)] binds the control to the item. If you drag the item to a container, the [!INCLUDE[TLA#tla_titlexaml](../data-tools/includes/tlasharptla_titlexaml_md.md)] creates the control that was selected for the dragged item, and it binds the control to the item. The control is created inside a new <xref:System.Windows.Controls.Grid>.  
  
 Visual Studio also makes the following changes to the code-behind file:  
  
-   Adds a new method that returns a query for the entity that you dragged to the designer (or the entity that contains the property that you dragged to the designer). The new method has the name Get*EntityName*Query, where *EntityName* is the name of the entity.  
  
-   Creates a <xref:System.Windows.FrameworkElement.Loaded> event handler for the [!INCLUDE[TLA2#tla_ui](../data-tools/includes/tla2sharptla_ui_md.md)] element that contains the control. The event handler calls the Get*EntityName*Query method to fill the entity with data, retrieves the <xref:System.Windows.Data.CollectionViewSource> from the container's resources, and then makes the first data item the current item. If a <xref:System.Windows.FrameworkElement.Loaded> event handler already exists, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] adds this code to the existing event handler.  
  
### Services  
 When you drag a service object or property from the **Data Sources** window to the designer, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] generates [!INCLUDE[TLA#tla_titlexaml](../data-tools/includes/tlasharptla_titlexaml_md.md)] that creates a data-bound control (or binds an existing control to the object or property). However, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] does not generate code that fills the proxy service object with data. You must write this code yourself. For an example that demonstrates how to do this, see [Bind WPF controls to a WCF data service](../data-tools/bind-wpf-controls-to-a-wcf-data-service.md).  
  
 Visual Studio generates XAML that does the following:  
  
-   Adds a new <xref:System.Windows.Data.CollectionViewSource> to the resources of the container that you dragged the item to. The <xref:System.Windows.Data.CollectionViewSource> is an object that can be used to navigate and display the data in the object that is returned by the service.  
  
-   Creates a data binding for a control. If you drag the item to an existing control in the designer, the [!INCLUDE[TLA#tla_titlexaml](../data-tools/includes/tlasharptla_titlexaml_md.md)] binds the control to the item. If you drag the item to a container, the [!INCLUDE[TLA#tla_titlexaml](../data-tools/includes/tlasharptla_titlexaml_md.md)] creates the control that was selected for the dragged item, and it binds the control to the item. The control is created inside a new <xref:System.Windows.Controls.Grid>.  
  
### Objects  
 When you drag an object or property from the **Data Sources** window to the designer, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] generates [!INCLUDE[TLA#tla_titlexaml](../data-tools/includes/tlasharptla_titlexaml_md.md)] that creates a data-bound control (or binds an existing control to the object or property). However, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] does not generate code to fill the object with data. You must write this code yourself.  
  
> [!NOTE]
>  Custom classes must be public and, by default,  have a constructor without parameters. They can'tbe nested classes that have a "dot" in their syntax. For more information, see [XAML and Custom Classes for WPF](../Topic/XAML%20and%20Custom%20Classes%20for%20WPF.md).  
  
 [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] generates [!INCLUDE[TLA#tla_titlexaml](../data-tools/includes/tlasharptla_titlexaml_md.md)] that does the following:  
  
-   Adds a new <xref:System.Windows.Data.CollectionViewSource> to the resources of the container that you dragged the item to. The <xref:System.Windows.Data.CollectionViewSource> is an object that can be used to navigate and display the data in the object.  
  
-   Creates a data binding for a control. If you drag the item to an existing control in the designer, the XAML binds the control to the item. If you drag the item to a container, the XAML creates the control that was selected for the dragged item, and it binds the control to the item. The control is created inside a new <xref:System.Windows.Controls.Grid>.  
  
## See Also  
 [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)