---
title: "CA1058: Types should not extend certain base types"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8446ee40-beb1-49fa-8733-4d8e813471c0
caps.latest.revision: 24
manager: douge
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
# CA1058: Types should not extend certain base types
|||  
|-|-|  
|TypeName|TypesShouldNotExtendCertainBaseTypes|  
|CheckId|CA1058|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 An externally visible type extends certain base types. Currently, this rule reports types that derive from the following types:  
  
-   <xref:System.ApplicationException?qualifyHint=True>  
  
-   <xref:System.Xml.XmlDocument?qualifyHint=True>  
  
-   <xref:System.Collections.CollectionBase?qualifyHint=True>  
  
-   <xref:System.Collections.DictionaryBase?qualifyHint=True>  
  
-   <xref:System.Collections.Queue?qualifyHint=True>  
  
-   <xref:System.Collections.ReadOnlyCollectionBase?qualifyHint=True>  
  
-   <xref:System.Collections.SortedList?qualifyHint=True>  
  
-   <xref:System.Collections.Stack?qualifyHint=True>  
  
## Rule Description  
 For .NET Framework version 1, it was recommended to derive new exceptions from <xref:System.ApplicationException?qualifyHint=False>. The recommendation has changed and new exceptions should derive from <xref:System.Exception?qualifyHint=True> or one of its subclasses in the <xref:System?qualifyHint=False> namespace.  
  
 Do not create a subclass of <xref:System.Xml.XmlDocument?qualifyHint=False> if you want to create an XML view of an underlying object model or data source.  
  
### Non-generic Collections  
 Use and/or extend generic collections whenever possible. Do not extend non-generic collections in your code, unless you shipped it previously.  
  
 **Examples of Incorrect Usage**  
  
```c#  
public class MyCollection : CollectionBase  
{  
}  
  
public class MyReadOnlyCollection : ReadOnlyCollectionBase  
{  
}  
```  
  
 **Examples of Correct Usage**  
  
```c#  
public class MyCollection : Collection<T>  
{  
}  
  
public class MyReadOnlyCollection : ReadOnlyCollection<T>  
{  
}  
```  
  
## How to Fix Violations  
 To fix a violation of this rule, derive the type from a different base type or a generic collection.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule for violations about <xref:System.ApplicationException?qualifyHint=False>. It is safe to suppress a warning from this rule for violations about <xref:System.Xml.XmlDocument?qualifyHint=False>. It is safe to suppress a warning about a non-generic collection if the code was released previously.