---
title: Typed vs. untyped datasets
ms.date: 11/04/2016
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
ms.assetid: c83ba0bb-5425-4d47-8891-6b4dbf937701
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "data-storage"
---
# Typed vs. untyped datasets
A typed dataset is a dataset that is first derived from the base <xref:System.Data.DataSet> class and then uses information from the **Dataset Designer**, which is stored in an .xsd file, to generate a new, strongly typed dataset class. Information from the schema (tables, columns, and so on) is generated and compiled into this new dataset class as a set of first-class objects and properties. Because a typed dataset inherits from the base <xref:System.Data.DataSet> class, the typed class assumes all of the functionality of the <xref:System.Data.DataSet> class and can be used with methods that take an instance of a <xref:System.Data.DataSet> class as a parameter.

An untyped dataset, in contrast, has no corresponding built-in schema. As in a typed dataset, an untyped dataset contains tables, columns, and so on—but those are exposed only as collections. (However, after you manually create the tables and other data elements in an untyped dataset, you can export the dataset's structure as a schema by using the dataset's <xref:System.Data.DataSet.WriteXmlSchema%2A> method.)

## Contrast data access in typed and untyped datasets
The class for a typed dataset has an object model in which its properties take on the actual names of the tables and columns. For example, if you are working with a typed dataset, you can reference a column by using code such as the following:

[!code-csharp[VbRaddataDatasets#4](../data-tools/codesnippet/CSharp/typed-vs-untyped-datasets_1.cs)]
[!code-vb[VbRaddataDatasets#4](../data-tools/codesnippet/VisualBasic/typed-vs-untyped-datasets_1.vb)]

In contrast, if you are working with an untyped dataset, the equivalent code is:

[!code-csharp[VbRaddataDatasets#5](../data-tools/codesnippet/CSharp/typed-vs-untyped-datasets_2.cs)]
[!code-vb[VbRaddataDatasets#5](../data-tools/codesnippet/VisualBasic/typed-vs-untyped-datasets_2.vb)]

Typed access is not only easier to read, but also fully supported by IntelliSense in the Visual Studio **Code Editor**. In addition to being easier to work with, the syntax for the typed dataset provides type checking at compile time, greatly reducing the possibility of errors in assigning values to dataset members. If you change the name of a column in your <xref:System.Data.DataSet> class and then compile your application, you receive a build error. By double-clicking the build error in the **Task List**, you can go directly to the line or lines of code that reference the old column name. Access to tables and columns in a typed dataset is also slightly faster at run time because access is determined at compile time, not through collections at run time.

Even though typed datasets have many advantages, an untyped dataset is useful in a variety of circumstances. The most obvious scenario is when no schema is available for the dataset. This might occur, for example, if your application is interacting with a component that returns a dataset, but you do not know in advance what its structure is. Similarly, there are times when you are working with data that does not have a static, predictable structure. In that case, it is impractical to use a typed dataset, because you would have to regenerate the typed dataset class with each change in the data structure.

More generally, there are many times when you might create a dataset dynamically without having a schema available. In that case, the dataset is simply a convenient structure in which you can keep information, as long as the data can be represented in a relational way. At the same time, you can take advantage of the dataset's capabilities, such as the ability to serialize the information to pass to another process, or to write out an XML file.

## See also

- [Dataset tools](../data-tools/dataset-tools-in-visual-studio.md)