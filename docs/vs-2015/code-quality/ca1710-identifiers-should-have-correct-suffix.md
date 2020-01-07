---
title: "CA1710: Identifiers should have correct suffix | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1710"
  - "IdentifiersShouldHaveCorrectSuffix"
helpviewer_keywords:
  - "IdentifiersShouldHaveCorrectSuffix"
  - "CA1710"
ms.assetid: 2b8e6dce-b4e8-4a66-ba9a-6b79be5bfe8c
caps.latest.revision: 22
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1710: Identifiers should have correct suffix
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

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
|<xref:System.Attribute?displayProperty=fullName>|Attribute|
|<xref:System.EventArgs?displayProperty=fullName>|EventArgs|
|<xref:System.Exception?displayProperty=fullName>|Exception|
|<xref:System.Collections.ICollection?displayProperty=fullName>|Collection|
|<xref:System.Collections.IDictionary?displayProperty=fullName>|Dictionary|
|<xref:System.Collections.IEnumerable?displayProperty=fullName>|Collection|
|<xref:System.Collections.Queue?displayProperty=fullName>|Collection or Queue|
|<xref:System.Collections.Stack?displayProperty=fullName>|Collection or Stack|
|<xref:System.Collections.Generic.ICollection%601?displayProperty=fullName>|Collection|
|<xref:System.Collections.Generic.IDictionary%602?displayProperty=fullName>|Dictionary|
|<xref:System.Data.DataSet?displayProperty=fullName>|DataSet|
|<xref:System.Data.DataTable?displayProperty=fullName>|Collection or DataTable|
|<xref:System.IO.Stream?displayProperty=fullName>|Stream|
|<xref:System.Security.IPermission?displayProperty=fullName>|Permission|
|<xref:System.Security.Policy.IMembershipCondition?displayProperty=fullName>|Condition|
|An event-handler delegate.|EventHandler|

 Types that implement <xref:System.Collections.ICollection> and are a generalized type of data structure, such as a dictionary, stack, or queue, are allowed names that provide meaningful information about the intended usage of the type.

 Types that implement <xref:System.Collections.ICollection> and are a collection of specific items have names that end with the word 'Collection'. For example, a collection of <xref:System.Collections.Queue> objects would have the name 'QueueCollection'. The 'Collection' suffix signifies that the members of the collection can be enumerated by using the `foreach` (`For Each` in [!INCLUDE[vbprvb](../includes/vbprvb-md.md)]) statement.

 Types that implement <xref:System.Collections.IDictionary> have names that end with the word 'Dictionary' even if the type also implements <xref:System.Collections.IEnumerable> or <xref:System.Collections.ICollection>. The 'Collection' and 'Dictionary' suffix naming conventions enable users to distinguish between the following two enumeration patterns.

 Types with the 'Collection' suffix follow this enumeration pattern.

```
foreach(SomeType x in SomeCollection) { }
```

 Types with the 'Dictionary' suffix follow this enumeration pattern.

```
foreach(SomeType x in SomeDictionary.Values) { }
```

 A <xref:System.Data.DataSet> object consists of a collection of <xref:System.Data.DataTable> objects, which consist of collections of <xref:System.Data.DataColumn?displayProperty=fullName> and <xref:System.Data.DataRow?displayProperty=fullName> objects, among others. These collections implement <xref:System.Collections.ICollection> through the base <xref:System.Data.InternalDataCollectionBase?displayProperty=fullName> class.

## How to Fix Violations
 Rename the type so that it is suffixed with the correct term.

## When to Suppress Warnings
 It is safe to suppress a warning to use the 'Collection' suffix if the type is a generalized data structure that might be extended or that will hold an arbitrary set of diverse items. In this case, a name that provides meaningful information about the implementation, performance, or other characteristics of the data structure might make sense (for example, BinaryTree). In cases where the type represents a collection of a specific type (for example, StringCollection), do not suppress a warning from this rule because the suffix indicates that the type can be enumerated by using a `foreach` statement.

 For other suffixes, do not suppress a warning from this rule. The suffix allows the intended usage to be evident from the type name.

## Related Rules
 [CA1711: Identifiers should not have incorrect suffix](../code-quality/ca1711-identifiers-should-not-have-incorrect-suffix.md)

## See Also
 [Attributes](https://msdn.microsoft.com/library/ee0038ef-b247-4747-a650-3c5c5cd58d8b)
 [NIB: Events and Delegates](https://msdn.microsoft.com/d98fd58b-fa4f-4598-8378-addf4355a115)
