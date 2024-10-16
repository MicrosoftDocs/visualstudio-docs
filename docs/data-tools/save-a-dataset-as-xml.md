---
title: Save an ADO.NET dataset as XML (.NET Framework)
description: In .NET Framework application development with Visual Studio, save a ADO.NET dataset as XML. Access the XML data in a dataset by calling the available XML methods on the dataset, such as GetXml or WriteXml.
ms.date: 11/04/2016
ms.topic: how-to
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- XML [Visual Basic], datasets
- data [Visual Studio], saving as XML
- datasets [Visual Basic], saving as XML
- saving data
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Save a dataset as XML in .NET Framework applications

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

Access the XML data in a dataset by calling the available XML methods on the dataset. To save the data in XML format, you can call either the <xref:System.Data.DataSet.GetXml%2A> method or the <xref:System.Data.DataSet.WriteXml%2A> method of a <xref:System.Data.DataSet>.

Calling the <xref:System.Data.DataSet.GetXml%2A> method returns a string that contains the data from all data tables in the dataset that's formatted as XML.

Calling the <xref:System.Data.DataSet.WriteXml%2A> method sends the XML-formatted data to a file that you specify.

## To save the data in a dataset as XML to a variable

- The <xref:System.Data.DataSet.GetXml%2A> method returns a <xref:System.String>. Declare a variable of type <xref:System.String> and assign it the results of the <xref:System.Data.DataSet.GetXml%2A> method.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Class1.cs" id="Snippet12":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Class1.vb" id="Snippet12":::
     ---

## To save the data in a dataset as XML to a file

- The <xref:System.Data.DataSet.WriteXml%2A> method has several overloads. Declare a variable and assign it a valid path to save the file to. The following code shows how to save the data to a file:

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Class1.cs" id="Snippet13":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Class1.vb" id="Snippet13":::
     ---

## Related content

- [Save data back to the database](../data-tools/save-data-back-to-the-database.md)
