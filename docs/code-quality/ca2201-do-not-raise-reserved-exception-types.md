---
title: "CA2201: Do not raise reserved exception types | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "DoNotRaiseReservedExceptionTypes"
  - "CA2201"
helpviewer_keywords: 
  - "CA2201"
  - "DoNotRaiseReservedExceptionTypes"
ms.assetid: dd14ef5c-80e6-41a5-834e-eba8e2eae75e
caps.latest.revision: 16
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# CA2201: Do not raise reserved exception types
|||  
|-|-|  
|TypeName|DoNotRaiseReservedExceptionTypes|  
|CheckId|CA2201|  
|Category|Microsoft.Usage|  
|Breaking Change|Breaking|  
  
## Cause  
 A method raises an exception type that is too general or that is reserved by the runtime.  
  
## Rule Description  
 The following exception types are too general to provide sufficient information to the user:  
  
-   <xref:System.Exception?displayProperty=fullName>  
  
-   <xref:System.ApplicationException?displayProperty=fullName>  
  
-   <xref:System.SystemException?displayProperty=fullName>  
  
 The following exception types are reserved and should be thrown only by the common language runtime:  
  
-   <xref:System.ExecutionEngineException?displayProperty=fullName>  
  
-   <xref:System.IndexOutOfRangeException?displayProperty=fullName>  
  
-   <xref:System.NullReferenceException?displayProperty=fullName>  
  
-   <xref:System.OutOfMemoryException?displayProperty=fullName>  
  
 **Do Not Throw General Exceptions**  
  
 If you throw a general exception type, such as <xref:System.Exception> or <xref:System.SystemException> in a library or framework, it forces consumers to catch all exceptions, including unknown exceptions that they do not know how to handle.  
  
 Instead, either throw a more derived type that already exists in the framework, or create your own type that derives from <xref:System.Exception>.  
  
 **Throw Specific Exceptions**  
  
 The following table shows parameters and which exceptions to throw when you validate the parameter, including the value parameter in the set accessor of a property:  
  
|Parameter Description|Exception|  
|---------------------------|---------------|  
|`null` reference|<xref:System.ArgumentNullException?displayProperty=fullName>|  
|Outside the allowed range of values (such as an index for a collection or list)|<xref:System.ArgumentOutOfRangeException?displayProperty=fullName>|  
|Invalid `enum` value|<xref:System.ComponentModel.InvalidEnumArgumentException?displayProperty=fullName>|  
|Contains a format that does not meet the parameter specifications of a method (such as the format string for `ToString(String)`)|<xref:System.FormatException?displayProperty=fullName>|  
|Otherwise invalid|<xref:System.ArgumentException?displayProperty=fullName>|  
  
 When an operation is invalid for the current state of an object    throw <xref:System.InvalidOperationException?displayProperty=fullName>  
  
 When an operation is performed on an object that has been disposed    throw <xref:System.ObjectDisposedException?displayProperty=fullName>  
  
 When an operation is not supported (such as in an overridden **Stream.Write** in a Stream opened for reading)    throw <xref:System.NotSupportedException?displayProperty=fullName>  
  
 When a conversion would result in an overflow (such as in a explicit cast operator overload)    throw <xref:System.OverflowException?displayProperty=fullName>  
  
 For all other situations, consider creating your own type that derives from <xref:System.Exception> and throw that.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the type of the thrown exception to a specific type that is not one of the reserved types.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Related Rules  
 [CA1031: Do not catch general exception types](../code-quality/ca1031-do-not-catch-general-exception-types.md)