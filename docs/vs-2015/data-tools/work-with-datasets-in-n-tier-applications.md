---
title: "Work with datasets in n-tier applications | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
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
caps.latest.revision: 25
author: jillre
ms.author: jillfra
manager: jillfra
---
# Work with datasets in n-tier applications
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

N-tier data applications* are data-centric applications that are separated into multiple logical layers (or *tiers*). In other words, an n-tier data application is an application that is separated into multiple projects, with the data access tier, the business logic tier, and the presentation tier each in its own project. For more information, see [N-Tier Data Applications Overview](../data-tools/n-tier-data-applications-overview.md).

 Typed datasets have been enhanced so that the TableAdapters and dataset classes can be generated into discrete projects. This provides the ability to quickly separate application layers and generate n-tier data applications.

 N-tier support in typed datasets enables iterative development of the application architecture to an n-tier design.It also removes the requirement to manually separate the code into more than one project. Start out designing the data layer by using the Dataset Designer. When you're ready to take the application architecture to an n-tiered design, set the **DataSet Project** property of a dataset to generate the dataset class into a separate project.

## In This Section
 [Separate datasets and TableAdapters into different projects](../data-tools/separate-datasets-and-tableadapters-into-different-projects.md)
 Describes how to move the generated dataset class out of the project that contains the generated TableAdapter classes and into a new project.

 [Add code to TableAdapters in n-tier applications](../data-tools/add-code-to-tableadapters-in-n-tier-applications.md)
 Describes how to generate a partial class in which code can be added for an n-tier TableAdapter.

 [Add code to datasets in n-tier applications](../data-tools/add-code-to-datasets-in-n-tier-applications.md)
 Describes how to generate a partial class in which code can be added for an n-tier dataset.

 [Add validation to an n-tier dataset](../data-tools/add-validation-to-an-n-tier-dataset.md)
 Describes where to add code to perform validation on changing data.

 [Walkthrough: Creating an N-Tier Data Application](../data-tools/walkthrough-creating-an-n-tier-data-application.md)
 Provides step-by-step instructions for creating a typed dataset and separating the TableAdapter and dataset code into multiple projects.

 [Walkthrough: Adding Validation to an N-Tier Data Application](https://msdn.microsoft.com/library/b35d072c-31f0-49ba-a225-69177592c265)
 Provides step-by-step instructions for adding validation to the application that was created in the n-tier data application walkthrough.

## Reference
 <xref:System.Data.DataSet>

 <xref:System.Data.TypedTableBase%601>

## Related Sections

- [N-Tier Data Applications Overview](../data-tools/n-tier-data-applications-overview.md)
- [Hierarchical update](../data-tools/hierarchical-update.md)
- [Dataset tools in Visual Studio](../data-tools/dataset-tools-in-visual-studio.md)
- [Accessing data in Visual Studio](../data-tools/accessing-data-in-visual-studio.md)
- [N-Tier and Remote Applications with LINQ to SQL](https://msdn.microsoft.com/library/854a1cdd-53cb-45f5-83ca-63962a9b3598)