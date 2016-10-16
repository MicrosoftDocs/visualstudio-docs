---
title: "How to: Start the TableAdapter Configuration Wizard"
ms.custom: na
ms.date: "09/20/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
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
ms.author: "mblome"
manager: "ghogen"
robots: noindex,nofollow
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
# How to: Start the TableAdapter Configuration Wizard
The **TableAdapter Configuration Wizard** creates and edits TableAdapters in strongly typed datasets. The wizard creates TableAdapters based on SQL statements you enter into the wizard or on existing stored procedures in the database. The wizard can also create new stored procedures in the database based on SQL statements you enter into the wizard.  
  
### To start the TableAdapter Configuration wizard to create a new TableAdapter  
  
1.  Open your dataset in the **Dataset Designer**. For more information, see [How to: Open a Dataset in the Dataset Designer](../Topic/How%20to:%20Open%20a%20Dataset%20in%20the%20Dataset%20Designer.md).  
  
    > [!NOTE]
    >  If you do not have a dataset in your project, see [Create and configure datasets](../datatools/create-and-configure-datasets-in-visual-studio.md).  
  
2.  If you are creating a new TableAdapter, drag a **TableAdapter** object from the **DataSet** tab of the **Toolbox** onto the **Dataset Designer**.  
  
3.  On the **Choose Your Data Connection** page, select a data connection from the list of currently available connections, or select **New Connection** to create a new connection.  
  
### To start the TableAdapter Configuration wizard to edit an existing TableAdapter  
  
1.  Open your dataset in the **Dataset Designer**. For more information, see [How to: Open a Dataset in the Dataset Designer](../Topic/How%20to:%20Open%20a%20Dataset%20in%20the%20Dataset%20Designer.md).  
  
2.  Right-click the TableAdapter in the **Dataset Designer** and choose **Configure**. The wizard opens to the **Generate the SQL statements** page or the **Bind Commands to Existing Stored Procedures** page, depending on how the TableAdapter was originally configured.  
  
3.  Complete the wizard.  
  
## See Also  
 [Data Walkthroughs](../Topic/Data%20Walkthroughs.md)   
 [Bind Windows Forms controls to data in Visual Studio](../datatools/bind-windows-forms-controls-to-data-in-visual-studio.md)   
 [TableAdapter Overview](../datatools/tableadapter-overview.md)   
 [Creating and Editing Typed Datasets](../datatools/creating-and-editing-typed-datasets.md)   
 [Add new data sources](../datatools/add-new-data-sources.md)   
 [How to: Connect to Data in a Database](../datatools/how-to--connect-to-data-in-a-database.md)   
 [Validating Data](../Topic/Validating%20Data.md)   
 [How to: Sort and Filter ADO.NET Data with the Windows Forms BindingSource Component](../Topic/How%20to:%20Sort%20and%20Filter%20ADO.NET%20Data%20with%20the%20Windows%20Forms%20BindingSource%20Component.md)   
 [How to: Create a Lookup Table with the Windows Forms BindingSource Component](../Topic/How%20to:%20Create%20a%20Lookup%20Table%20with%20the%20Windows%20Forms%20BindingSource%20Component.md)   
 [Walkthrough: Displaying Data on a Windows Form](../datatools/walkthrough--displaying-data-on-a-windows-form.md)