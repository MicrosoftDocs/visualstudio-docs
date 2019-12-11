---
title: Save a dataset as XML
ms.date: 11/04/2016
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "XML [Visual Basic], datasets"
  - "data [Visual Studio], saving as XML"
  - "datasets [Visual Basic], saving as XML"
  - "saving data"
ms.assetid: 68b8327c-ae05-49ff-b9ba-99183e70b52c
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "data-storage"
---
# Save a dataset as XML

Access the XML data in a dataset by calling the available XML methods on the dataset. To save the data in XML format, you can call either the <xref:System.Data.DataSet.GetXml%2A> method or the <xref:System.Data.DataSet.WriteXml%2A> method of a <xref:System.Data.DataSet>.

Calling the <xref:System.Data.DataSet.GetXml%2A> method returns a string that contains the data from all data tables in the dataset that's formatted as XML.

Calling the <xref:System.Data.DataSet.WriteXml%2A> method sends the XML-formatted data to a file that you specify.

## To save the data in a dataset as XML to a variable

- The <xref:System.Data.DataSet.GetXml%2A> method returns a <xref:System.String>. Declare a variable of type <xref:System.String> and assign it the results of the <xref:System.Data.DataSet.GetXml%2A> method.

     [!code-vb[VbRaddataSaving#12](../data-tools/codesnippet/VisualBasic/save-a-dataset-as-xml_1.vb)]
     [!code-csharp[VbRaddataSaving#12](../data-tools/codesnippet/CSharp/save-a-dataset-as-xml_1.cs)]

## To save the data in a dataset as XML to a file

- The <xref:System.Data.DataSet.WriteXml%2A> method has several overloads. Declare a variable and assign it a valid path to save the file to. The following code shows how to save the data to a file:

     [!code-vb[VbRaddataSaving#13](../data-tools/codesnippet/VisualBasic/save-a-dataset-as-xml_2.vb)]
     [!code-csharp[VbRaddataSaving#13](../data-tools/codesnippet/CSharp/save-a-dataset-as-xml_2.cs)]

## See also

- [Save data back to the database](../data-tools/save-data-back-to-the-database.md)