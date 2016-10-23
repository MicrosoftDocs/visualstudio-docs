---
title: "CA2201: Do not raise reserved exception types"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: dd14ef5c-80e6-41a5-834e-eba8e2eae75e
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
  
-   <xref:System.Exception?qualifyHint=True>  
  
-   <xref:System.ApplicationException?qualifyHint=True>  
  
-   <xref:System.SystemException?qualifyHint=True>  
  
 The following exception types are reserved and should be thrown only by the common language runtime:  
  
-   <xref:System.ExecutionEngineException?qualifyHint=True>  
  
-   <xref:System.IndexOutOfRangeException?qualifyHint=True>  
  
-   <xref:System.NullReferenceException?qualifyHint=True>  
  
-   <xref:System.OutOfMemoryException?qualifyHint=True>  
  
 **Do Not Throw General Exceptions**  
  
 If you throw a general exception type, such as <xref:System.Exception?qualifyHint=False> or <xref:System.SystemException?qualifyHint=False> in a library or framework, it forces consumers to catch all exceptions, including unknown exceptions that they do not know how to handle.  
  
 Instead, either throw a more derived type that already exists in the framework, or create your own type that derives from <xref:System.Exception?qualifyHint=False>.  
  
 **Throw Specific Exceptions**  
  
 The following table shows parameters and which exceptions to throw when you validate the parameter, including the value parameter in the set accessor of a property:  
  
|Parameter Description|Exception|  
|---------------------------|---------------|  
|`null` reference|<xref:System.ArgumentNullException?qualifyHint=True>|  
|Outside the allowed range of values (such as an index for a collection or list)|<xref:System.ArgumentOutOfRangeException?qualifyHint=True>|  
|Invalid `enum` value|<xref:System.ComponentModel.InvalidEnumArgumentException?qualifyHint=True>|  
|Contains a format that does not meet the parameter specifications of a method (such as the format string for `ToString(String)`)|<xref:System.FormatException?qualifyHint=True>|  
|Otherwise invalid|<xref:System.ArgumentException?qualifyHint=True>|  
  
 When an operation is invalid for the current state of an object    throw <xref:System.InvalidOperationException?qualifyHint=True>  
  
 When an operation is performed on an object that has been disposed    throw <xref:System.ObjectDisposedException?qualifyHint=True>  
  
 When an operation is not supported (such as in an overridden **Stream.Write** in a Stream opened for reading)    throw <xref:System.NotSupportedException?qualifyHint=True>  
  
 When a conversion would result in an overflow (such as in a explicit cast operator overload)    throw <xref:System.OverflowException?qualifyHint=True>  
  
 For all other situations, consider creating your own type that derives from <xref:System.Exception?qualifyHint=False> and throw that.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the type of the thrown exception to a specific type that is not one of the reserved types.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Related Rules  
 [CA1031: Do not catch general exception types](../VS_IDE/CA1031--Do-not-catch-general-exception-types.md)