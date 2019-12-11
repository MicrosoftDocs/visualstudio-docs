---
title: "CA2205: Use managed equivalents of Win32 API | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "UseManagedEquivalentsOfWin32Api"
  - "CA2205"
helpviewer_keywords:
  - "UseManagedEquivalentsOfWin32Api"
  - "CA2205"
ms.assetid: 1c65ab59-3e50-4488-a727-3969c7f6cbe4
caps.latest.revision: 15
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2205: Use managed equivalents of Win32 API
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|UseManagedEquivalentsOfWin32Api|
|CheckId|CA2205|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 A platform invoke method is defined and a method with the equivalent functionality exists in the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] class library.

## Rule Description
 A platform invoke method is used to call an unmanaged DLL function and is defined using the <xref:System.Runtime.InteropServices.DllImportAttribute?displayProperty=fullName> attribute, or the `Declare` keyword in Visual Basic. An incorrectly defined platform invoke method can lead to runtime exceptions because of issues such as a misnamed function, faulty mapping of parameter and return value data types, and incorrect field specifications, such as the calling convention and character set. If available, it is generally simpler and less error prone to call the equivalent managed method than to define and call the unmanaged method directly. Calling a platform invoke method can also lead to additional security issues that need to be addressed.

## How to Fix Violations
 To fix a violation of this rule, replace the call to the unmanaged function with a call to its managed equivalent.

## When to Suppress Warnings
 Suppress a warning from this rule if the suggested replacement method does not provide the needed functionality.

## Example
 The following example shows a platform invoke method definition that violates the rule. In addition, the calls to the platform invoke method and the equivalent managed method are shown.

 [!code-csharp[FxCop.Usage.ManagedEquivalents#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.ManagedEquivalents/cs/FxCop.Usage.ManagedEquivalents.cs#1)]
 [!code-vb[FxCop.Usage.ManagedEquivalents#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Usage.ManagedEquivalents/vb/FxCop.Usage.ManagedEquivalents.vb#1)]

## Related Rules
 [CA1404: Call GetLastError immediately after P/Invoke](../code-quality/ca1404-call-getlasterror-immediately-after-p-invoke.md)

 [CA1060: Move P/Invokes to NativeMethods class](../code-quality/ca1060-move-p-invokes-to-nativemethods-class.md)

 [CA1400: P/Invoke entry points should exist](../code-quality/ca1400-p-invoke-entry-points-should-exist.md)

 [CA1401: P/Invokes should not be visible](../code-quality/ca1401-p-invokes-should-not-be-visible.md)

 [CA2101: Specify marshaling for P/Invoke string arguments](../code-quality/ca2101-specify-marshaling-for-p-invoke-string-arguments.md)
