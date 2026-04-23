---
title: Overview of dataset tools for .NET Framework apps
description: Explore ADO.NET dataset tools for .NET Framework applications in Visual Studio, including dataset workflows, N-tier architectures, and XML.
ms.date: 11/21/2018
ms.topic: concept-article
f1_keywords:
- vs.data.DataSet
helpviewer_keywords:
- untyped datasets
- datasets [Visual Basic], extended properties
- typed datasets
- current record in dataset
- XML [Visual Basic], datasets
- DataSet class, about datasets
- unique constraints (datasets)
- data relationships
- parent records in datasets
- extended properties, in typed datasets
- datasets [Visual Basic]
- schemas [Visual Basic], datasets
- datasets [Visual Basic], msprop
- master-detail tables, datasets
- databases [Visual Basic], updating
- msprop
- foreign keys, datasets
- DataSet class
- datasets [Visual Basic], filling
- case sensitivity, datasets
- constraints [Visual Basic], datasets
- child records
- related tables, datasets
- updating datasets, about dataset updates
- data caching, datasets
- DataRelation object, datasets
- untyped datasets, compared to typed datasets
- cache [Visual Studio], datasets
- datasets [Visual Basic], relationships
- related tables
- XML schemas, about XML schemas and datasets
- relationships, datasets
- typed datasets, compared to untyped datasets
- datasets [Visual Basic], populating
- datasets [Visual Basic], namespace
- data adapters, populating datasets
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Visual Studio dataset tools for developing .NET Framework applications

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

A `DataSet` object is an in-memory object that is essentially a mini-database. It contains `DataTable`, `DataColumn`, and `DataRow` objects in which you can store and modify data from one or more databases without having to maintain an open connection. The dataset maintains information about changes to its data, so updates can be tracked and sent back to the database when your application becomes reconnected.

Datasets and related classes are defined in the <xref:System.Data?displayProperty=fullName> namespace in the .NET API. You can create and modify datasets dynamically in code using ADO.NET. The documentation in this section shows how to work with datasets by using Visual Studio designers. Datasets that are created through designers use **TableAdapter** objects to interact with the database. Datasets that are created programmatically use **DataAdapter** objects. For information about creating datasets programmatically, see [DataAdapters and DataReaders](/dotnet/framework/data/adonet/dataadapters-and-datareaders).

If your application needs to only read data from a database, and not perform updates, adds, or deletes, you can usually get better performance by using a `DataReader` object to retrieve data into a generic `List` object or another collection object. If you are displaying the data, you can data-bind the user interface to the collection.

## Dataset workflow

Visual Studio provides tooling to simplify working with datasets. The basic end-to-end workflow is:

- Use the [Data Sources window](add-new-data-sources.md#work-with-data-sources-and-windows-forms) to create a new dataset from one or more data sources. Use the **Dataset Designer** to configure the dataset and set its properties. For example, you need to specify which tables from the data source to include, and which columns from each table. Choose carefully to conserve the amount of memory that the dataset requires. For more information, see [Create and configure datasets](../data-tools/create-and-configure-datasets-in-visual-studio.md).

- Specify the relationships between the tables so that foreign keys are handled correctly. For more information, see [Fill datasets by using TableAdapters](../data-tools/fill-datasets-by-using-tableadapters.md).

- Use the **TableAdapter Configuration Wizard** to specify the query or stored procedure that populates the dataset, and what database operations (update, delete, and so on) to implement. For more information, see these topics:

  - [Fill datasets by using TableAdapters](../data-tools/fill-datasets-by-using-tableadapters.md)

  - [Edit data in datasets](../data-tools/edit-data-in-datasets.md)

  - [Validate data in datasets](../data-tools/validate-data-in-datasets.md)

  - [Save data back to the database](../data-tools/save-data-back-to-the-database.md)

- Query and search the data in the dataset. For more information, see [Query datasets](../data-tools/query-datasets.md). LINQ to DataSet enables [LINQ (Language Integrated Query)](/dotnet/csharp/linq/) over data in a <xref:System.Data.DataSet> object. For more information, see [LINQ to DataSet](/dotnet/framework/data/adonet/linq-to-dataset).

- Use the **Data Sources** window to bind user interface controls to the dataset or its individual columns, and to specify which columns are user-editable. For more information, see [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md).

## Datasets and N-tier architecture

For information about datasets in N-tier applications, see [Work with datasets in n-tier applications](../data-tools/work-with-datasets-in-n-tier-applications.md).

## Datasets and XML

For information about converting datasets to and from XML, see [Read XML data into a dataset](../data-tools/read-xml-data-into-a-dataset.md) and [Save a dataset as XML](../data-tools/save-a-dataset-as-xml.md).

## Related content

- [Visual Studio data tools for .NET](../data-tools/visual-studio-data-tools-for-dotnet.md)
