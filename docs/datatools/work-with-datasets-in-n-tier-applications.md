---
title: "Work with datasets in n-tier applications"
ms.custom: na
ms.date: "10/14/2016"
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
  - "datasets [Visual Basic], n-tier applications"
  - "multi-tier database applications"
  - "DataSet project [VS n-tier applications]"
  - "distributed applications [VS n-tier applications]"
  - "data [Visual Basic], n-tier applications"
  - "TableAdapters, n-tier applications"
  - "n-tier applications"
  - "tiers, n-tier applications"
  - "typed datasets, n-tier applications"
  - "multiple tier applications"
ms.assetid: f6ae2ee0-ea5f-4a79-8f4b-e21c115afb20
caps.latest.revision: 22
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
# Work with datasets in n-tier applications
*N-tier data applications* are data-centric applications that are separated into multiple logical layers (or *tiers*). In other words, an n-tier data application is an application that is separated into multiple projects, with the data access tier, the business logic tier, and the presentation tier each in its own project. For more information, see [N-Tier Data Applications Overview](../datatools/n-tier-data-applications-overview.md).  
  
 Typed datasets have been enhanced so that the TableAdapters and dataset classes can be generated into discrete projects. This provides the ability to quickly separate application layers and generate n-tier data applications.  
  
 N-tier support in typed datasets enables iterative development of the application architecture to an n-tier design.It also removes the requirement to manually separate the code into more than one project. Start out designing the data layer by using the [Creating and Editing Typed Datasets](../datatools/creating-and-editing-typed-datasets.md). When you're ready to take the application architecture to an n-tiered design, set the **DataSet Project** property of a dataset to generate the dataset class into a separate project.  
  
## In This Section  
 [Separate datasets and TableAdapters into different projects](../datatools/separate-datasets-and-tableadapters-into-different-projects.md)  
 Describes how to move the generated dataset class out of the project that contains the generated TableAdapter classes and into a new project.  
  
 [Add code to TableAdapters in n-tier applications](../datatools/add-code-to-tableadapters-in-n-tier-applications.md)  
 Describes how to generate a partial class in which code can be added for an n-tier TableAdapter.  
  
 [Add code to datasets in n-tier applications](../datatools/add-code-to-datasets-in-n-tier-applications.md)  
 Describes how to generate a partial class in which code can be added for an n-tier dataset.  
  
 [Add validation to an n-tier dataset](../datatools/add-validation-to-an-n-tier-dataset.md)  
 Describes where to add code to perform validation on changing data.  
  
 [Walkthrough: Creating an N-Tier Data Application](../datatools/walkthrough--creating-an-n-tier-data-application.md)  
 Provides step-by-step instructions for creating a typed dataset and separating the TableAdapter and dataset code into multiple projects.  
  
 [Walkthrough: Adding Validation to an N-Tier Data Application](../Topic/Walkthrough:%20Adding%20Validation%20to%20an%20N-Tier%20Data%20Application.md)  
 Provides step-by-step instructions for adding validation to the application that was created in the n-tier data application walkthrough.  
  
## Reference  
 \<xref:System.Data.DataSet>  
  
 \<xref:System.Data.TypedTableBase`1>  
  
## Related Sections  
 [N-Tier Data Applications Overview](../datatools/n-tier-data-applications-overview.md)  
  
 [Hierarchical update](../datatools/hierarchical-update.md)  
  
 [Dataset tools in Visual Studio](../datatools/dataset-tools-in-visual-studio.md)  
  
 [Accessing data in Visual Studio](../datatools/accessing-data-in-visual-studio.md)  
  
 [TableAdapter Overview](../datatools/tableadapter-overview.md)  
  
 [N-Tier and Remote Applications with LINQ to SQL](../Topic/N-Tier%20and%20Remote%20Applications%20with%20LINQ%20to%20SQL.md)