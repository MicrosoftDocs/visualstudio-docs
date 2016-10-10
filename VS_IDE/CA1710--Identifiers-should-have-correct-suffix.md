---
title: "CA1710: Identifiers should have correct suffix"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 2b8e6dce-b4e8-4a66-ba9a-6b79be5bfe8c
caps.latest.revision: 20
manager: douge
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
# CA1710: Identifiers should have correct suffix
|||  
|-|-|  
|TypeName|IdentifiersShouldHaveCorrectSuffix|  
|CheckId|CA1710|  
|Category|Microsoft.Naming|  
|Breaking Change|Breaking|  
  
## Cause  
 An identifier does not have the correct suffix.  
  
## Rule Description  
 By convention, the names of types that extend certain base types or that implement certain interfaces, or types derived from these types, have a suffix that is associated with the base type or interface.  
  
 Naming conventions provide a common look for libraries that target the common language runtime. This reduces the learning curve that is required for new software libraries, and increases customer confidence that the library was developed by someone who has expertise in developing managed code.  
  
 The following table lists the base types and interfaces that have associated suffixes.  
  
|Base type/Interface|Suffix|  
|--------------------------|------------|  
|<xref:System.Attribute?qualifyHint=True>|Attribute|  
|<xref:System.EventArgs?qualifyHint=True>|EventArgs|  
|<xref:System.Exception?qualifyHint=True>|Exception|  
|<xref:System.Collections.ICollection?qualifyHint=True>|Collection|  
|<xref:System.Collections.IDictionary?qualifyHint=True>|Dictionary|  
|<xref:System.Collections.IEnumerable?qualifyHint=True>|Collection|  
|<xref:System.Collections.Queue?qualifyHint=True>|Collection or Queue|  
|<xref:System.Collections.Stack?qualifyHint=True>|Collection or Stack|  
|<xref:System.Collections.Generic.ICollection`1?qualifyHint=True>|Collection|  
|<xref:System.Collections.Generic.IDictionary`2?qualifyHint=True>|Dictionary|  
|<xref:System.Data.DataSet?qualifyHint=True>|DataSet|  
|<xref:System.Data.DataTable?qualifyHint=True>|Collection or DataTable|  
|<xref:System.IO.Stream?qualifyHint=True>|Stream|  
|<xref:System.Security.IPermission?qualifyHint=True>|Permission|  
|<xref:System.Security.Policy.IMembershipCondition?qualifyHint=True>|Condition|  
|An event-handler delegate.|EventHandler|  
  
 Types that implement <xref:System.Collections.ICollection?qualifyHint=False> and are a generalized type of data structure, such as a dictionary, stack, or queue, are allowed names that provide meaningful information about the intended usage of the type.  
  
 Types that implement <xref:System.Collections.ICollection?qualifyHint=False> and are a collection of specific items have names that end with the word 'Collection'. For example, a collection of <xref:System.Collections.Queue?qualifyHint=False> objects would have the name 'QueueCollection'. The 'Collection' suffix signifies that the members of the collection can be enumerated by using the `foreach` (`For Each` in Visual Basic) statement.  
  
 Types that implement <xref:System.Collections.IDictionary?qualifyHint=False> have names that end with the word 'Dictionary' even if the type also implements <xref:System.Collections.IEnumerable?qualifyHint=False> or <xref:System.Collections.ICollection?qualifyHint=False>. The 'Collection' and 'Dictionary' suffix naming conventions enable users to distinguish between the following two enumeration patterns.  
  
 Types with the 'Collection' suffix follow this enumeration pattern.  
  
```  
foreach(SomeType x in SomeCollection) { }  
```  
  
 Types with the 'Dictionary' suffix follow this enumeration pattern.  
  
```  
foreach(SomeType x in SomeDictionary.Values) { }  
```  
  
 A <xref:System.Data.DataSet?qualifyHint=False> object consists of a collection of <xref:System.Data.DataTable?qualifyHint=False> objects, which consist of collections of <xref:System.Data.DataColumn?qualifyHint=True> and <xref:System.Data.DataRow?qualifyHint=True> objects, among others. These collections implement <xref:System.Collections.ICollection?qualifyHint=False> through the base <xref:System.Data.InternalDataCollectionBase?qualifyHint=True> class.  
  
## How to Fix Violations  
 Rename the type so that it is suffixed with the correct term.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning to use the 'Collection' suffix if the type is a generalized data structure that might be extended or that will hold an arbitrary set of diverse items. In this case, a name that provides meaningful information about the implementation, performance, or other characteristics of the data structure might make sense (for example, BinaryTree). In cases where the type represents a collection of a specific type (for example, StringCollection), do not suppress a warning from this rule because the suffix indicates that the type can be enumerated by using a `foreach` statement.  
  
 For other suffixes, do not suppress a warning from this rule. The suffix allows the intended usage to be evident from the type name.  
  
## Related Rules  
 [CA1711: Identifiers should not have incorrect suffix](../VS_IDE/CA1711--Identifiers-should-not-have-incorrect-suffix.md)  
  
## See Also  
 [Attributes](../Topic/Attributes1.md)   
 [NIB: Events and Delegates](assetId:///d98fd58b-fa4f-4598-8378-addf4355a115)