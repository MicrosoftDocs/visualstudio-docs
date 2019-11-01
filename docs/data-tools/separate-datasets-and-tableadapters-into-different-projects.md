---
title: Separate datasets and TableAdapters into different projects
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
  - "TableAdapters, n-tier applications"
  - "n-tier applications, separating Datasets and TableAdapters"
ms.assetid: f66a3940-6227-46af-a930-9177f425f4fd
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "data-storage"
---
# Separate datasets and TableAdapters into different projects
Typed datasets have been enhanced so that the [TableAdapters](create-and-configure-tableadapters.md) and dataset classes can be generated into separate projects. This enables you to quickly separate application layers and generate n-tier data applications.

The following procedure describes the process of using the **Dataset Designer** to generate dataset code into a project that is separate from the project that contains the generated TableAdapter code.

## Separate datasets and TableAdapters
When you separate dataset code from TableAdapter code, the project that contains the dataset code must be located in the current solution. If this project is not located in the current solution, it won't be available in the **DataSet Project** list in the **Properties** window.

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

#### To separate the dataset into a different project

1. Open a solution that contains a dataset (*.xsd* file).

    > [!NOTE]
    > If the solution does not contain the project into which you want to separate your dataset code, create the project, or add an existing project to the solution.

2. Double-click a typed dataset file (an *.xsd* file) in **Solution Explorer** to open the dataset in the **Dataset Designer**.

3. Select an empty area of the **Dataset Designer**.

4. In the **Properties** window, locate the **DataSet Project** node.

5. In the **DataSet Project** list, select the name of the project into which you want to generate the dataset code.

     After you select the project into which you want to generate the dataset code, the **DataSet File** property is populated with a default file name. You can change this name if necessary. Additionally, if you want to generate the dataset code into a specific directory, you can set the **Project Folder** property to the name of a folder.

    > [!NOTE]
    > When you separate datasets and TableAdapters (by setting the **DataSet Project** property), existing partial dataset classes in the project won't be moved automatically. Existing partial dataset classes must be  moved manually to the dataset project.

6. Save the dataset.

     The dataset code is generated into the selected project in the **DataSet Project** property, and the **TableAdapter** code is generated into the current project.

By default, after you separate the dataset and TableAdapter code, the result is a discrete class file in each project. The original project has a file named *DatasetName.Designer.vb* (or *DatasetName.Designer.cs*) that contains the TableAdapter code. The project that's designated in the **Dataset Project** property has a file named *DatasetName.DataSet.Designer.vb* (or *DatasetName.DataSet.Designer.cs*) that contains the dataset code.

> [!NOTE]
> To view the generated class file, select the dataset or TableAdapter project. Then, in **Solution Explorer**, select **Show All Files**.

## See also

- [N-tier data applications overview](../data-tools/n-tier-data-applications-overview.md)
- [Walkthrough: Creating an N-tier data application](../data-tools/walkthrough-creating-an-n-tier-data-application.md)
- [Hierarchical update](../data-tools/hierarchical-update.md)
- [Accessing data in Visual Studio](../data-tools/accessing-data-in-visual-studio.md)
- [ADO.NET](/dotnet/framework/data/adonet/index)