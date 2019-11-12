---
title: "Separate datasets and TableAdapters into different projects | Microsoft Docs"
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
  - "TableAdapters, n-tier applications"
  - "n-tier applications, separating Datasets and TableAdapters"
ms.assetid: f66a3940-6227-46af-a930-9177f425f4fd
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: jillfra
---
# Separate datasets and TableAdapters into different projects
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Typed datasets have been enhanced so that the [TableAdapters](https://msdn.microsoft.com/library/09416de9-134c-4dc7-8262-6c8d81e3f364) and dataset classes can be generated into separate projects. This enables you to quickly separate application layers and generate n-tier data applications.

 The following procedure describes the process of using the Dataset Designer to generate dataset code into a project that is separate from the project that contains the generated `TableAdapter` code.

## Separatedatasets and TableAdapters
 When you separate dataset code from `TableAdapter` code, the project that  contains the dataset code must be located in the current solution. If this project is not located in the current solution, it won't be available in the **DataSet Project** list in the **Properties** window.

 [!INCLUDE[note_settings_general](../includes/note-settings-general-md.md)]

#### To separate the dataset into a different project

1. Open a solution that contains a dataset (.xsd file).

   > [!NOTE]
   > If the solution does not contain the project into which you want to separate your dataset code, create the project, or add an existing project to the solution.

2. Double-click a typed dataset file (an .xsd file) in **Solution Explorer** to open the dataset in the **Dataset Designer**.

3. Select an empty area of the **Dataset Designer**.

4. In the **Properties** window, locate the **DataSet Project** node.

5. In the **DataSet Project** list, select the name of the project into which you want to generate the dataset code.

    After you select the project into which you want to generate the dataset code, the **DataSet File** property is populated with a default file name. You can change this name if necessary. Additionally, if you want to generate the dataset code into a specific directory, you can set the **Project Folder** property to the name of a folder.

   > [!NOTE]
   > When you separate datasets and TableAdapters (by setting the **DataSet Project** property), existing partial dataset classes in the project won't be moved automatically. Existing dataset partial classes must be  moved manually to the dataset project.

6. Save the dataset.

    The dataset code is generated into the selected project  in the **DataSet Project** property, and the **TableAdapter** code is generated into the current project.

   By default, after you separate the dataset and `TableAdapter` code, the result is a discrete class file in each project. The original project has a file  named DatasetName.Designer.vb (or DatasetName.Designer.cs) that contains the `TableAdapter` code. The project that's designated in the **Dataset Project** property has a file named DatasetName.DataSet.Designer.vb (or DatasetName.DataSet.Designer.cs) that contains the dataset code.

> [!NOTE]
> To view the generated class file, select the dataset or `TableAdapter` project. Then, in  **Solution Explorer**, select **Show All Files** .

## See Also
 [N-Tier Data Applications Overview](../data-tools/n-tier-data-applications-overview.md)
 [Walkthrough: Creating an N-Tier Data Application](../data-tools/walkthrough-creating-an-n-tier-data-application.md)
 [Hierarchical update](../data-tools/hierarchical-update.md)
 [Accessing data in Visual Studio](../data-tools/accessing-data-in-visual-studio.md)
 [ADO.NET](https://msdn.microsoft.com/library/5b96ed06-9759-4966-a797-a1d5f6ee50ca)
