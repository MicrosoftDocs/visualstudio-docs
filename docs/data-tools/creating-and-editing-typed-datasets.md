---
title: "Creating and Editing Typed Datasets | Microsoft Docs"
ms.custom: ""
ms.date: "10/19/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "Designer_Microsoft.VSDesigner.DataSource.Designer.DataSourceRootDesigner"
  - "vs.data.adddataset"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
  - "aspx"
helpviewer_keywords: 
  - "datasets [Visual Basic], visual designer"
  - "data [Visual Studio], Dataset Designer"
  - "Dataset Designer"
ms.assetid: cd0dbe93-be9b-41e4-bc39-e9300678c1f2
caps.latest.revision: 26
author: "mikeblome"
ms.author: "mblome"
manager: "ghogen"
robots: noindex,nofollow
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Creating and Editing Typed Datasets
The**Dataset Designer** is a set of visual tools that you can use to create and edit typed datasets and the individual items that they contain.  
  
 The **Dataset Designer** provides visual representations of the objects contained in typed datasets. You create and modify [TableAdapters](../data-tools/tableadapter-overview.md), [TableAdapter Queries](../data-tools/how-to-create-tableadapter-queries.md), <xref:System.Data.DataTable>s, <xref:System.Data.DataColumn>s, and <xref:System.Data.DataRelation>s with the **Dataset Designer**.  
  
 To open the **Dataset Designer**, double-click a dataset in **Solution Explorer**, or right-click a dataset in the **Data Sources** window and click **Edit DataSet with Designer**. For more information, see [How to: Open a Dataset in the Dataset Designer](../Topic/How%20to:%20Open%20a%20Dataset%20in%20the%20Dataset%20Designer.md). Adding a new <xref:System.Data.DataSet> item with the **Add New Item** dialog box will open the **Dataset Designer** with an empty dataset ready for editing.  
  
> [!NOTE]
>  The **Dataset Designer** can be used to extend the functionality of a dataset. Double-click the design surface or right-click and choose **View Code** to create a partial class file where you can add code to the dataset that will not be changed or deleted by the designer. For information on extending the functionality of a TableAdapter, see [Extend the functionality of a TableAdapter](../data-tools/extend-the-functionality-of-a-tableadapter.md).  
  
 The following table lists the common tasks you can accomplish with the **Dataset Designer**.  
  
|To|See|  
|--------|---------|  
|Create a TableAdapter|[Create and configure TableAdapters](../data-tools/create-and-configure-tableadapters.md)|  
|Edit a TableAdapter|[How to: Edit TableAdapters](../Topic/How%20to:%20Edit%20TableAdapters.md)|  
|Create a TableAdapter query|[How to: Create TableAdapter Queries](../data-tools/how-to-create-tableadapter-queries.md)|  
|Edit a TableAdapter query|[How to: Edit TableAdapter Queries](../data-tools/how-to-edit-tableadapter-queries.md)|  
|Create a <xref:System.Data.DataTable>|[How to: Create Data Tables](../data-tools/how-to-create-data-tables.md)|  
|Edit a <xref:System.Data.DataTable>|[Designing DataTables](../data-tools/designing-datatables.md)|  
|Create a <xref:System.Data.DataColumn>|[How to: Add Columns to a DataTable](../Topic/How%20to:%20Add%20Columns%20to%20a%20DataTable.md)|  
|Create a relationship between two <xref:System.Data.DataTable>s|[How to: Create DataRelations with the Dataset Designer](../Topic/How%20to:%20Create%20DataRelations%20with%20the%20Dataset%20Designer.md)|  
|Extend the functionality of the dataset|[How to: Extend the Functionality of a Dataset](../Topic/How%20to:%20Extend%20the%20Functionality%20of%20a%20Dataset.md)|  
|Add validation to a data table's <xref:System.Data.DataTable.ColumnChanging> event|[How to: Validate Data During Column Changes](../Topic/How%20to:%20Validate%20Data%20During%20Column%20Changes.md)|  
|Add validation to a data table's <xref:System.Data.DataTable.RowChanging> event|[How to: Validate Data During Row Changes](../Topic/How%20to:%20Validate%20Data%20During%20Row%20Changes.md)|  
  
## Creating Objects on the Design Surface  
 You can create datasets by adding and editing the individual objects that make up a dataset. The following table provides an explanation of the different objects in the **DataSet** tab on the **Toolbox** that can be dragged onto the design surface:  
  
|Object|Description|  
|------------|-----------------|  
|TableAdapter|Contains a collection of data commands and a data connection that are used to communicate with the underlying database and populate a data table. For more information, see [TableAdapter Overview](../data-tools/tableadapter-overview.md) and [Create and configure TableAdapters](../data-tools/create-and-configure-tableadapters.md).|  
|Query|TableAdapter queries are strongly typed methods that execute SQL statements and stored procedures. Running a TableAdapter query populates a data table with data or performs other database tasks. For more information, see [How to: Create TableAdapter Queries](../data-tools/how-to-create-tableadapter-queries.md). Dragging a query onto a table adds the query to that table, whereas dragging a query onto an empty area of the **Dataset Designer** creates a global query. For more information, see [How to: Add Global Queries to a TableAdapter](../data-tools/how-to-add-global-queries-to-a-tableadapter.md).|  
|<xref:System.Data.DataTable>|Represents an in-memory collection of the rows returned from a database.|  
|Relation (<xref:System.Data.DataRelation>)|Represents a parent-child relationship between two <xref:System.Data.DataTable>s. For more information, see [Introduction to DataRelation Objects](../Topic/Introduction%20to%20DataRelation%20Objects.md) and [Walkthrough: Creating a Relationship between Data Tables](../Topic/Walkthrough:%20Creating%20a%20Relationship%20between%20Data%20Tables.md).|  
  
> [!NOTE]
>  The **Dataset Designer** connects to an underlying database only when a dataset is created; the designer doesn't automatically detect subsequent changes to the database. To refresh an existing .xsd, re-run the **Configuration Wizard**. If the table relations have changed, remove and re-add the relevant tables to the .xsd.  
  
## LINQ to Dataset  
 [!INCLUDE[linq_dataset](../data-tools/includes/linq_dataset_md.md)] enables [LINQ (Language-Integrated Query)](../Topic/LINQ%20\(Language-Integrated%20Query\).md) over data in a <xref:System.Data.DataSet> object. For more information, see [LINQ to DataSet](../Topic/LINQ%20to%20DataSet.md).  
  
## See Also  
 [Walkthrough: Creating a Dataset with the Dataset Designer](../data-tools/walkthrough-creating-a-dataset-with-the-dataset-designer.md)   
 [Walkthrough: Creating a TableAdapter with Multiple Queries](../data-tools/walkthrough-creating-a-tableadapter-with-multiple-queries.md)   
 [Walkthrough: Creating a DataTable in the Dataset Designer](../data-tools/walkthrough-creating-a-datatable-in-the-dataset-designer.md)   
 [Walkthrough: Creating a Relationship between Data Tables](../Topic/Walkthrough:%20Creating%20a%20Relationship%20between%20Data%20Tables.md)   
 [Walkthrough: Displaying Data on a Windows Form](../data-tools/walkthrough-displaying-data-on-a-windows-form.md)   
 [Data Sources Window](../Topic/Data%20Sources%20Window.md)   
 [Dataset tools in Visual Studio](../data-tools/dataset-tools-in-visual-studio.md)   
 [Preparing Your Application to Receive Data](../Topic/Preparing%20Your%20Application%20to%20Receive%20Data.md)   
 [Fetching Data into Your Application](../data-tools/fetching-data-into-your-application.md)   
 [Editing Data in Your Application](../data-tools/editing-data-in-your-application.md)   
 [Validating Data](../Topic/Validating%20Data.md)   
 [Saving Data](../data-tools/saving-data.md)