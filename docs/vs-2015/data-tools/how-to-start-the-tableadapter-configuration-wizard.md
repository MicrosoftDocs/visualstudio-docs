---
title: "How to: Start the TableAdapter Configuration Wizard | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
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
  - "TableAdapters, Configuration Wizard"
  - "TableAdapter Configuration Wizard"
ms.assetid: 301f2dcd-ed72-4229-80ef-3b59cb062d5d
caps.latest.revision: 11
author: gewarren
ms.author: gewarren
manager: "ghogen"
robots: noindex,nofollow
---
# How to: Start the TableAdapter Configuration Wizard
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The **TableAdapter Configuration Wizard** creates and edits TableAdapters in strongly typed datasets. The wizard creates TableAdapters based on SQL statements you enter into the wizard or on existing stored procedures in the database. The wizard can also create new stored procedures in the database based on SQL statements you enter into the wizard.  
  
### To start the TableAdapter Configuration wizard to create a new TableAdapter  
  
1.  Open your dataset in the **Dataset Designer**. For more information, see [How to: Open a Dataset in the Dataset Designer](http://msdn.microsoft.com/library/36fc266f-365b-42cb-aebb-c993dc2c47c3).  
  
    > [!NOTE]
    >  If you do not have a dataset in your project, see [Create and configure datasets](../data-tools/create-and-configure-datasets-in-visual-studio.md).  
  
2.  If you are creating a new TableAdapter, drag a **TableAdapter** object from the **DataSet** tab of the **Toolbox** onto the **Dataset Designer**.  
  
3.  On the **Choose Your Data Connection** page, select a data connection from the list of currently available connections, or select **New Connection** to create a new connection.  
  
### To start the TableAdapter Configuration wizard to edit an existing TableAdapter  
  
1.  Open your dataset in the **Dataset Designer**. For more information, see [How to: Open a Dataset in the Dataset Designer](http://msdn.microsoft.com/library/36fc266f-365b-42cb-aebb-c993dc2c47c3).  
  
2.  Right-click the TableAdapter in the **Dataset Designer** and choose **Configure**. The wizard opens to the **Generate the SQL statements** page or the **Bind Commands to Existing Stored Procedures** page, depending on how the TableAdapter was originally configured.  
  
3.  Complete the wizard.  
  
## See Also  
 [Data Walkthroughs](http://msdn.microsoft.com/library/15a88fb8-3bee-4962-914d-7a1f8bd40ec4)   
 [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)   
 [TableAdapter Overview](../data-tools/tableadapter-overview.md)   
 [Creating and Editing Typed Datasets](../data-tools/creating-and-editing-typed-datasets.md)   
 [Add new data sources](../data-tools/add-new-data-sources.md)   
 [How to: Connect to Data in a Database](../data-tools/how-to-connect-to-data-in-a-database.md)   
 [Validating Data](http://msdn.microsoft.com/library/b3a9ee4e-5d4d-4411-9c56-c811f2b4ee7e)   
 [How to: Sort and Filter ADO.NET Data with the Windows Forms BindingSource Component](http://msdn.microsoft.com/library/6c206daf-d706-4602-9dbe-435343052063)   
 [How to: Create a Lookup Table with the Windows Forms BindingSource Component](http://msdn.microsoft.com/library/622fce80-879d-44be-abbf-8350ec22ca2b)   
 [Walkthrough: Displaying Data on a Windows Form](../data-tools/walkthrough-displaying-data-on-a-windows-form.md)