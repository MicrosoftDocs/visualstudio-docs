---
title: "Work with datasets in n-tier applications"
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
ms.assetid: f6ae2ee0-ea5f-4a79-8f4b-e21c115afb20
caps.latest.revision: 22
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
# Work with datasets in n-tier applications
*N-tier data applications* are data-centric applications that are separated into multiple logical layers (or *tiers*). In other words, an n-tier data application is an application that is separated into multiple projects, with the data access tier, the business logic tier, and the presentation tier each in its own project. For more information, see [N-Tier Data Applications Overview](../VS_raddata/N-Tier-Data-Applications-Overview.md).  
  
 Typed datasets have been enhanced so that the TableAdapters and dataset classes can be generated into discrete projects. This provides the ability to quickly separate application layers and generate n-tier data applications.  
  
 N-tier support in typed datasets enables iterative development of the application architecture to an n-tier design.It also removes the requirement to manually separate the code into more than one project. Start out designing the data layer by using the [Creating and Editing Typed Datasets](../VS_raddata/Creating-and-Editing-Typed-Datasets.md). When you're ready to take the application architecture to an n-tiered design, set the **DataSet Project** property of a dataset to generate the dataset class into a separate project.  
  
## In This Section  
 [Separate datasets and TableAdapters into different projects](../VS_raddata/Separate-datasets-and-TableAdapters-into-different-projects.md)  
 Describes how to move the generated dataset class out of the project that contains the generated TableAdapter classes and into a new project.  
  
 [Add code to TableAdapters in n-tier applications](../VS_raddata/Add-code-to-TableAdapters-in-n-tier-applications.md)  
 Describes how to generate a partial class in which code can be added for an n-tier TableAdapter.  
  
 [Add code to datasets in n-tier applications](../VS_raddata/Add-code-to-datasets-in-n-tier-applications.md)  
 Describes how to generate a partial class in which code can be added for an n-tier dataset.  
  
 [Add validation to an n-tier dataset](../VS_raddata/Add-validation-to-an-n-tier-dataset.md)  
 Describes where to add code to perform validation on changing data.  
  
 [Walkthrough: Creating an N-Tier Data Application](../VS_raddata/Walkthrough--Creating-an-N-Tier-Data-Application.md)  
 Provides step-by-step instructions for creating a typed dataset and separating the TableAdapter and dataset code into multiple projects.  
  
 [Walkthrough: Adding Validation to an N-Tier Data Application](../Topic/Walkthrough:%20Adding%20Validation%20to%20an%20N-Tier%20Data%20Application.md)  
 Provides step-by-step instructions for adding validation to the application that was created in the n-tier data application walkthrough.  
  
## Reference  
 <xref:System.Data.DataSet?qualifyHint=False>  
  
 <xref:System.Data.TypedTableBase`1?qualifyHint=False>  
  
## Related Sections  
 [N-Tier Data Applications Overview](../VS_raddata/N-Tier-Data-Applications-Overview.md)  
  
 [Hierarchical update](../VS_raddata/Hierarchical-update.md)  
  
 [Dataset tools in Visual Studio](../VS_raddata/Dataset-tools-in-Visual-Studio.md)  
  
 [Accessing data in Visual Studio](../VS_raddata/Accessing-data-in-Visual-Studio.md)  
  
 [TableAdapter Overview](../VS_raddata/TableAdapter-Overview.md)  
  
 [N-Tier and Remote Applications with LINQ to SQL](../Topic/N-Tier%20and%20Remote%20Applications%20with%20LINQ%20to%20SQL.md)