---
title: "Save a dataset as XML | Microsoft Docs"
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
  - "XML [Visual Basic], datasets"
  - "data [Visual Studio], saving as XML"
  - "datasets [Visual Basic], saving as XML"
  - "saving data"
ms.assetid: 68b8327c-ae05-49ff-b9ba-99183e70b52c
caps.latest.revision: 14
author: jillre
ms.author: jillfra
manager: jillfra
---
# Save a dataset as XML
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The XML data in a dataset can be accessed by calling the available XML methods  on the dataset. To save the data in XML format, you can call either the <xref:System.Data.DataSet.GetXml%2A> method or the <xref:System.Data.DataSet.WriteXml%2A> method of a <xref:System.Data.DataSet>.

 Calling the <xref:System.Data.DataSet.GetXml%2A> method returns a string that contains the data from all data tables in the dataset that's formatted as XML.

 Calling the <xref:System.Data.DataSet.WriteXml%2A> method sends the XML-formatted data to a file that  you specify.

### To save the data in a dataset as XML to a variable

- The <xref:System.Data.DataSet.GetXml%2A> method returns a <xref:System.String>.This means that you declare a variable of type <xref:System.String> and assign it the results of the <xref:System.Data.DataSet.GetXml%2A> method.

     [!code-csharp[VbRaddataSaving#12](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Class1.cs#12)]
     [!code-vb[VbRaddataSaving#12](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Class1.vb#12)]

### To save the data in a dataset as XML to a file

- The <xref:System.Data.DataSet.WriteXml%2A> method has several overloads. The following code shows how to save the data to a file.Declare a variable and assign it a valid path to save the file to.

     [!code-csharp[VbRaddataSaving#13](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Class1.cs#13)]
     [!code-vb[VbRaddataSaving#13](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Class1.vb#13)]

## See Also
 [Save data back to the database](../data-tools/save-data-back-to-the-database.md)
