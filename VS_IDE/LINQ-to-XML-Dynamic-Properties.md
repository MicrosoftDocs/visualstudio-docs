---
title: "LINQ to XML Dynamic Properties"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 0455f47c-4a68-4f2e-a3f8-dd1d85b99012
caps.latest.revision: 2
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# LINQ to XML Dynamic Properties
This section provides reference information about the dynamic properties in LINQ to XML. Specifically, these properties are exposed by the <xref:System.Xml.Linq.XAttribute?qualifyHint=False> and <xref:System.Xml.Linq.XElement?qualifyHint=False> classes, which are in the <xref:System.Xml.Linq?qualifyHint=False> namespace.  
  
 As explained in the topic [Overview of WPF Data Binding with LINQ to XML](../VS_IDE/WPF-Data-Binding-with-LINQ-to-XML-Overview.md), each of the dynamic properties is equivalent to a standard public property or method in the same class. These standard members should be used for most purposes; dynamic properties are provided specifically for LINQ to XML data binding scenarios. For more information about the standard members of these classes, see the <xref:System.Xml.Linq.XAttribute?qualifyHint=False> and <xref:System.Xml.Linq.XElement?qualifyHint=False> reference topics.  
  
 With respect to their resolved values, the dynamic properties in this section fall into two categories:  
  
-   Simple ones, such as the `Value` properties in the <xref:System.Xml.Linq.XAttribute?qualifyHint=False> and <xref:System.Xml.Linq.XElement?qualifyHint=False> classes, that resolve to a single value.  
  
-   Indexed values, such as the [Elements](../VS_IDE/Elements--XElement-Dynamic-Property-.md) and [Descendants](../VS_IDE/Descendants--XElement-Dynamic-Property-.md) properties of <xref:System.Xml.Linq.XElement?qualifyHint=False>, that resolve into an indexer type. For indexer types to be resolved to the desired value or collection, an expanded name parameter must be passed to them.  
  
 All the dynamic properties that return an indexed value of type <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False> use deffered execution. For more information about deferred execution, see [Introduction to LINQ Queries (C#)](../Topic/Introduction%20to%20LINQ%20Queries%20\(C%23\).md).  
  
## In This Section  
  
|Topic|Description|  
|-----------|-----------------|  
|[XAttribute Class Dynamic Properties](../VS_IDE/XAttribute-Class-Dynamic-Properties.md)|Provides details about the dynamic properties exposed by the <xref:System.Xml.Linq.XAttribute?qualifyHint=False> class.|  
|[XElement Class Dynamic Properties](../VS_IDE/XElement-Class-Dynamic-Properties.md)|Provides details about the dynamic properties exposed by the <xref:System.Xml.Linq.XElement?qualifyHint=False> class.|  
  
## Reference  
 <xref:System.Xml.Linq?qualifyHint=False>  
  
 <xref:System.Xml.Linq.XElement?qualifyHint=True>  
  
 <xref:System.Xml.Linq.XAttribute?qualifyHint=True>  
  
## See Also  
 [WPF Data Binding with LINQ to XML](../VS_IDE/WPF-Data-Binding-with-LINQ-to-XML.md)   
 [WPF Data Binding with LINQ to XML Overview](../VS_IDE/WPF-Data-Binding-with-LINQ-to-XML-Overview.md)   
 [Introduction to LINQ Queries (C#)](../Topic/Introduction%20to%20LINQ%20Queries%20\(C%23\).md)