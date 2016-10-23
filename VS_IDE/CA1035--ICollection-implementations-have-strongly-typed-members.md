---
title: "CA1035: ICollection implementations have strongly typed members"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ad404eb5-cf6a-44b7-b78a-8ebfb654bc7f
caps.latest.revision: 16
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
# CA1035: ICollection implementations have strongly typed members
|||  
|-|-|  
|TypeName|ICollectionImplementationsHaveStronglyTypedMembers|  
|CheckId|CA1035|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 A public or protected type implements <xref:System.Collections.ICollection?qualifyHint=True> but does not provide a strongly typed method for <xref:System.Collections.ICollection.CopyTo?qualifyHint=True>. The strongly typed version of <xref:System.Collections.ICollection.CopyTo?qualifyHint=False> must accept two parameters and cannot have a <xref:System.Array?qualifyHint=True> or an array of <xref:System.Object?qualifyHint=True> as its first parameter.  
  
## Rule Description  
 This rule requires <xref:System.Collections.ICollection?qualifyHint=False> implementations to provide strongly typed members so that users are not required to cast arguments to the <xref:System.Object?qualifyHint=False> type when they use the functionality that is provided by the interface. This rule assumes that the type that implements <xref:System.Collections.ICollection?qualifyHint=False> does so to manage a collection of instances of a type that is stronger than <xref:System.Object?qualifyHint=False>.  
  
 <xref:System.Collections.ICollection?qualifyHint=False> implements the <xref:System.Collections.IEnumerable?qualifyHint=True> interface. If the objects in the collection extend <xref:System.ValueType?qualifyHint=True>, you must provide a strongly typed member for <xref:System.Collections.IEnumerable.GetEnumerator?qualifyHint=False> to avoid the decrease in performance that is caused by boxing. This is not required when the objects of the collection are a reference type.  
  
 To implement a strongly typed version of an interface member, implement the interface members explicitly by using names in the form `InterfaceName.InterfaceMemberName`, such as <xref:System.Collections.ICollection.CopyTo?qualifyHint=False>. The explicit interface members use the data types that are declared by the interface. Implement the strongly typed members by using the interface member name, such as <xref:System.Collections.ICollection.CopyTo?qualifyHint=False>. Declare the strongly typed members as public, and declare parameters and return values to be of the strong type that is managed by the collection. The strong types replace weaker types such as <xref:System.Object?qualifyHint=False> and <xref:System.Array?qualifyHint=False> that are declared by the interface.  
  
## How to Fix Violations  
 To fix a violation of this rule, implement the interface member explicitly (declare it as <xref:System.Collections.ICollection.CopyTo?qualifyHint=False>). Add the public strongly typed member, declared as `CopyTo`, and have it take a strongly typed array as its first parameter.  
  
## When to Suppress Warnings  
 Suppress a warning from this rule if you implement a new object-based collection, such as a binary tree, where types that extend the new collection determine the strong type. These types should comply with this rule and expose strongly typed members.  
  
## Example  
 The following example demonstrates the correct way to implement <xref:System.Collections.ICollection?qualifyHint=False>.  
  
 [!CODE [FxCop.Design.ICollectionStrongTypes#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.ICollectionStrongTypes#1)]  
  
## Related Rules  
 [CA1038: Enumerators should be strongly typed](../VS_IDE/CA1038--Enumerators-should-be-strongly-typed.md)  
  
 [CA1039: Lists are strongly typed](../VS_IDE/CA1039--Lists-are-strongly-typed.md)  
  
## See Also  
 <xref:System.Array?qualifyHint=True>   
 <xref:System.Collections.IEnumerable?qualifyHint=True>   
 <xref:System.Collections.ICollection?qualifyHint=True>   
 <xref:System.Object?qualifyHint=True>