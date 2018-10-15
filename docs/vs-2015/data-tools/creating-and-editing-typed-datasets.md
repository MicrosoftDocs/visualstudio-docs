---
title: "Creating and Editing Typed Datasets | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
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
author: gewarren
ms.author: gewarren
manager: "ghogen"
robots: noindex,nofollow
---
# Creating and Editing Typed Datasets
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The**Dataset Designer** is a set of visual tools that you can use to create and edit typed datasets and the individual items that they contain.  
  
 The **Dataset Designer** provides visual representations of the objects contained in typed datasets. You create and modify [TableAdapters](../data-tools/tableadapter-overview.md), [TableAdapter Queries](../data-tools/how-to-create-tableadapter-queries.md), <xref:System.Data.DataTable>s, <xref:System.Data.DataColumn>s, and <xref:System.Data.DataRelation>s with the **Dataset Designer**.  
  
 To open the **Dataset Designer**, double-click a dataset in **Solution Explorer**, or right-click a dataset in the **Data Sources** window and click **Edit DataSet with Designer**. For more information, see [How to: Open a Dataset in the Dataset Designer](http://msdn.microsoft.com/library/36fc266f-365b-42cb-aebb-c993dc2c47c3). Adding a new <xref:System.Data.DataSet> item with the **Add New Item** dialog box will open the **Dataset Designer** with an empty dataset ready for editing.  
  
> [!NOTE]
>  The **Dataset Designer** can be used to extend the functionality of a dataset. Double-click the design surface or right-click and choose **View Code** to create a partial class file where you can add code to the dataset that will not be changed or deleted by the designer. For information on extending the functionality of a TableAdapter, see [Extend the functionality of a TableAdapter](../data-tools/extend-the-functionality-of-a-tableadapter.md).  
  
 The following table lists the common tasks you can accomplish with the **Dataset Designer**.  
  
|To|See|  
|--------|---------|  
|Create a TableAdapter|[Create and configure TableAdapters](../data-tools/create-and-configure-tableadapters.md)|  
|Edit a TableAdapter|[How to: Edit TableAdapters](http://msdn.microsoft.com/library/ca178745-e35a-45f1-a395-23cddfd8f855)|  
|Create a TableAdapter query|[How to: Create TableAdapter Queries](../data-tools/how-to-create-tableadapter-queries.md)|  
|Edit a TableAdapter query|[How to: Edit TableAdapter Queries](../data-tools/how-to-edit-tableadapter-queries.md)|  
|Create a <xref:System.Data.DataTable>|[How to: Create Data Tables](../data-tools/how-to-create-data-tables.md)|  
|Edit a <xref:System.Data.DataTable>|[Designing DataTables](../data-tools/designing-datatables.md)|  
|Create a <xref:System.Data.DataColumn>|[How to: Add Columns to a DataTable](http://msdn.microsoft.com/library/8ca21f77-b99a-47a7-a656-7cfd7a1bd9df)|  
|Create a relationship between two <xref:System.Data.DataTable>s|[How to: Create DataRelations with the Dataset Designer](http://msdn.microsoft.com/library/a3ab4803-0b50-4b74-9920-ab20bfbf1aa2)|  
|Extend the functionality of the dataset|[How to: Extend the Functionality of a Dataset](http://msdn.microsoft.com/library/dfbc21eb-7ea2-4942-addd-49677f5493be)|  
|Add validation to a data table's <xref:System.Data.DataTable.ColumnChanging> event|[How to: Validate Data During Column Changes](http://msdn.microsoft.com/library/a2680600-67b6-4a40-a77e-b5bc638281c5)|  
|Add validation to a data table's <xref:System.Data.DataTable.RowChanging> event|[How to: Validate Data During Row Changes](http://msdn.microsoft.com/library/afc03c77-dfed-4302-9376-929400468ecc)|  
  
## Creating Objects on the Design Surface  
 You can create datasets by adding and editing the individual objects that make up a dataset. The following table provides an explanation of the different objects in the **DataSet** tab on the **Toolbox** that can be dragged onto the design surface:  
  
|Object|Description|  
|------------|-----------------|  
|TableAdapter|Contains a collection of data commands and a data connection that are used to communicate with the underlying database and populate a data table. For more information, see [TableAdapter Overview](../data-tools/tableadapter-overview.md) and [Create and configure TableAdapters](../data-tools/create-and-configure-tableadapters.md).|  
|Query|TableAdapter queries are strongly typed methods that execute SQL statements and stored procedures. Running a TableAdapter query populates a data table with data or performs other database tasks. For more information, see [How to: Create TableAdapter Queries](../data-tools/how-to-create-tableadapter-queries.md). Dragging a query onto a table adds the query to that table, whereas dragging a query onto an empty area of the **Dataset Designer** creates a global query. For more information, see [How to: Add Global Queries to a TableAdapter](../data-tools/how-to-add-global-queries-to-a-tableadapter.md).|  
|<xref:System.Data.DataTable>|Represents an in-memory collection of the rows returned from a database.|  
|Relation (<xref:System.Data.DataRelation>)|Represents a parent-child relationship between two <xref:System.Data.DataTable>s. For more information, see [Introduction to DataRelation Objects](http://msdn.microsoft.com/library/89d8a881-8265-41f2-a88b-61311ab06192) and [Walkthrough: Creating a Relationship between Data Tables](http://msdn.microsoft.com/library/9b3f1c87-7098-4ed4-a710-cde8f8059f82).|  
  
> [!NOTE]
>  The **Dataset Designer** connects to an underlying database only when a dataset is created; the designer doesn't automatically detect subsequent changes to the database. To refresh an existing .xsd, re-run the **Configuration Wizard**. If the table relations have changed, remove and re-add the relevant tables to the .xsd.  
  
## LINQ to Dataset  
 [!INCLUDE[linq_dataset](../includes/linq-dataset-md.md)] enables [LINQ (Language-Integrated Query)](http://msdn.microsoft.com/library/a73c4aec-5d15-4e98-b962-1274021ea93d) over data in a <xref:System.Data.DataSet> object. For more information, see [LINQ to DataSet](http://msdn.microsoft.com/library/743e3755-3ecb-45a2-8d9b-9ed41f0dcf17).  
  
## See Also  
 [Walkthrough: Creating a Dataset with the Dataset Designer](../data-tools/walkthrough-creating-a-dataset-with-the-dataset-designer.md)   
 [Walkthrough: Creating a TableAdapter with Multiple Queries](../data-tools/walkthrough-creating-a-tableadapter-with-multiple-queries.md)   
 [Walkthrough: Creating a DataTable in the Dataset Designer](../data-tools/walkthrough-creating-a-datatable-in-the-dataset-designer.md)   
 [Walkthrough: Creating a Relationship between Data Tables](http://msdn.microsoft.com/library/9b3f1c87-7098-4ed4-a710-cde8f8059f82)   
 [Walkthrough: Displaying Data on a Windows Form](../data-tools/walkthrough-displaying-data-on-a-windows-form.md)   
 [Data Sources Window](http://msdn.microsoft.com/library/0d20f699-cc95-45b3-8ecb-c7edf1f67992)   
 [Dataset tools in Visual Studio](../data-tools/dataset-tools-in-visual-studio.md)   
 [Preparing Your Application to Receive Data](http://msdn.microsoft.com/library/c17bdb7e-c234-4f2f-9582-5e55c27356ad)   
 [Fetching Data into Your Application](../data-tools/fetching-data-into-your-application.md)   
 [Editing Data in Your Application](../data-tools/editing-data-in-your-application.md)   
 [Validating Data](http://msdn.microsoft.com/library/b3a9ee4e-5d4d-4411-9c56-c811f2b4ee7e)   
 [Saving Data](../data-tools/saving-data.md)