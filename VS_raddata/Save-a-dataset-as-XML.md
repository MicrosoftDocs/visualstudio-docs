---
title: "Save a dataset as XML"
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
ms.assetid: 68b8327c-ae05-49ff-b9ba-99183e70b52c
caps.latest.revision: 11
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
# Save a dataset as XML
The XML data in a dataset can be accessed by calling the available XML methods  on the dataset. To save the data in XML format, you can call either the <xref:System.Data.DataSet.GetXml?qualifyHint=False> method or the <xref:System.Data.DataSet.WriteXml?qualifyHint=False> method of a <xref:System.Data.DataSet?qualifyHint=False>.  
  
 Calling the <xref:System.Data.DataSet.GetXml?qualifyHint=False> method returns a string that contains the data from all data tables in the dataset that's formatted as XML.  
  
 Calling the <xref:System.Data.DataSet.WriteXml?qualifyHint=False> method sends the XML-formatted data to a file that  you specify.  
  
### To save the data in a dataset as XML to a variable  
  
-   The <xref:System.Data.DataSet.GetXml?qualifyHint=False> method returns a <xref:System.String?qualifyHint=False>.This means that you declare a variable of type <xref:System.String?qualifyHint=False> and assign it the results of the <xref:System.Data.DataSet.GetXml?qualifyHint=False> method.  
  
     [!CODE [VbRaddataSaving#12](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#12)]  
  
### To save the data in a dataset as XML to a file  
  
-   The <xref:System.Data.DataSet.WriteXml?qualifyHint=False> method has several overloads. The following code shows how to save the data to a file.Declare a variable and assign it a valid path to save the file to.  
  
     [!CODE [VbRaddataSaving#13](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#13)]  
  
## See Also  
 [Save data back to the database](../VS_raddata/Save-data-back-to-the-database.md)