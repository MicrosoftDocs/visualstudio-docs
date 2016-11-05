---
title: "Save a dataset as XML | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
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
caps.latest.revision: 11
author: "mikeblome"
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
# Save a dataset as XML
The XML data in a dataset can be accessed by calling the available XML methods  on the dataset. To save the data in XML format, you can call either the <xref:System.Data.DataSet.GetXml%2A> method or the <xref:System.Data.DataSet.WriteXml%2A> method of a <xref:System.Data.DataSet>.  
  
 Calling the <xref:System.Data.DataSet.GetXml%2A> method returns a string that contains the data from all data tables in the dataset that's formatted as XML.  
  
 Calling the <xref:System.Data.DataSet.WriteXml%2A> method sends the XML-formatted data to a file that  you specify.  
  
### To save the data in a dataset as XML to a variable  
  
-   The <xref:System.Data.DataSet.GetXml%2A> method returns a <xref:System.String>.This means that you declare a variable of type <xref:System.String> and assign it the results of the <xref:System.Data.DataSet.GetXml%2A> method.  
  
     [!code-vb[VbRaddataSaving#12](../data-tools/codesnippet/VisualBasic/save-a-dataset-as-xml_1.vb)]
     [!code-cs[VbRaddataSaving#12](../data-tools/codesnippet/CSharp/save-a-dataset-as-xml_1.cs)]  
  
### To save the data in a dataset as XML to a file  
  
-   The <xref:System.Data.DataSet.WriteXml%2A> method has several overloads. The following code shows how to save the data to a file.Declare a variable and assign it a valid path to save the file to.  
  
     [!code-vb[VbRaddataSaving#13](../data-tools/codesnippet/VisualBasic/save-a-dataset-as-xml_2.vb)]
     [!code-cs[VbRaddataSaving#13](../data-tools/codesnippet/CSharp/save-a-dataset-as-xml_2.cs)]  
  
## See Also  
 [Save data back to the database](../data-tools/save-data-back-to-the-database.md)