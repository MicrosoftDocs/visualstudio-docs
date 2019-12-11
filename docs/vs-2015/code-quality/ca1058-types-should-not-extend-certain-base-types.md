---
title: "CA1058: Types should not extend certain base types | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "TypesShouldNotExtendCertainBaseTypes"
  - "CA1058"
helpviewer_keywords:
  - "CA1058"
  - "TypesShouldNotExtendCertainBaseTypes"
ms.assetid: 8446ee40-beb1-49fa-8733-4d8e813471c0
caps.latest.revision: 26
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1058: Types should not extend certain base types
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|TypesShouldNotExtendCertainBaseTypes|
|CheckId|CA1058|
|Category|Microsoft.Design|
|Breaking Change|Breaking|

## Cause
 An externally visible type extends certain base types. Currently, this rule reports types that derive from the following types:

- <xref:System.ApplicationException?displayProperty=fullName>

- <xref:System.Xml.XmlDocument?displayProperty=fullName>

- <xref:System.Collections.CollectionBase?displayProperty=fullName>

- <xref:System.Collections.DictionaryBase?displayProperty=fullName>

- <xref:System.Collections.Queue?displayProperty=fullName>

- <xref:System.Collections.ReadOnlyCollectionBase?displayProperty=fullName>

- <xref:System.Collections.SortedList?displayProperty=fullName>

- <xref:System.Collections.Stack?displayProperty=fullName>

## Rule Description
 For [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] version 1, it was recommended to derive new exceptions from <xref:System.ApplicationException>. The recommendation has changed and new exceptions should derive from <xref:System.Exception?displayProperty=fullName> or one of its subclasses in the <xref:System> namespace.

 Do not create a subclass of <xref:System.Xml.XmlDocument> if you want to create an XML view of an underlying object model or data source.

### Non-generic Collections
 Use and/or extend generic collections whenever possible. Do not extend non-generic collections in your code, unless you shipped it previously.

 **Examples of Incorrect Usage**

```csharp
public class MyCollection : CollectionBase
{
}

public class MyReadOnlyCollection : ReadOnlyCollectionBase
{
}
```

 **Examples of Correct Usage**

```csharp
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
 Do not suppress a warning from this rule for violations about <xref:System.ApplicationException>. It is safe to suppress a warning from this rule for violations about <xref:System.Xml.XmlDocument>. It is safe to suppress a warning about a non-generic collection if the code was released previously.
