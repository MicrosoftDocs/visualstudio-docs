---
title: "CA1404: Call GetLastError immediately after P-Invoke | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CallGetLastErrorImmediatelyAfterPInvoke"
  - "CA1404"
helpviewer_keywords:
  - "CallGetLastErrorImmediatelyAfterPInvoke"
  - "CA1404"
ms.assetid: 52ae9eff-50f9-4b2f-8039-ca7e49fba88e
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1404: Call GetLastError immediately after P/Invoke
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|CallGetLastErrorImmediatelyAfterPInvoke|
|CheckId|CA1404|
|Category|Microsoft.Interoperability|
|Breaking Change|Non-breaking|

## Cause
 A call is made to the <xref:System.Runtime.InteropServices.Marshal.GetLastWin32Error%2A?displayProperty=fullName> method or the equivalent Win32 `GetLastError` function, and the call that comes immediately before is not to a platform invoke method.

## Rule Description
 A platform invoke method accesses unmanaged code and is defined by using the `Declare` keyword in [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] or the <xref:System.Runtime.InteropServices.DllImportAttribute?displayProperty=fullName> attribute. Generally, upon failure, unmanaged functions call the Win32 `SetLastError` function to set an error code that is associated with the failure. The caller of the failed function calls the Win32 `GetLastError` function to retrieve the error code and determine the cause of the failure. The error code is maintained on a per-thread basis and is overwritten by the next call to `SetLastError`. After a call to a failed platform invoke method, managed code can retrieve the error code by calling the <xref:System.Runtime.InteropServices.Marshal.GetLastWin32Error%2A> method. Because the error code can be overwritten by internal calls from other managed class library methods, the `GetLastError` or <xref:System.Runtime.InteropServices.Marshal.GetLastWin32Error%2A> method should be called immediately after the platform invoke method call.

 The rule ignores calls to the following managed members when they occur between the call to the platform invoke method and the call to <xref:System.Runtime.InteropServices.Marshal.GetLastWin32Error%2A>. These members do not change the error code and are useful for determining the success of some platform invoke method calls.

- <xref:System.IntPtr.Zero?displayProperty=fullName>

- <xref:System.IntPtr.op_Equality%2A?displayProperty=fullName>

- <xref:System.IntPtr.op_Inequality%2A?displayProperty=fullName>

- <xref:System.Runtime.InteropServices.SafeHandle.IsInvalid%2A?displayProperty=fullName>

## How to Fix Violations
 To fix a violation of this rule, move the call to <xref:System.Runtime.InteropServices.Marshal.GetLastWin32Error%2A> so that it immediately follows the call to the platform invoke method.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule if the code between the platform invoke method call and the <xref:System.Runtime.InteropServices.Marshal.GetLastWin32Error%2A> method call cannot explicitly or implicitly cause the error code to change.

## Example
 The following example shows a method that violates the rule and a method that satisfies the rule.

 [!code-csharp[FxCop.Interoperability.LastErrorPInvoke#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Interoperability.LastErrorPInvoke/cs/FxCop.Interoperability.LastErrorPInvoke.cs#1)]
 [!code-vb[FxCop.Interoperability.LastErrorPInvoke#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Interoperability.LastErrorPInvoke/vb/FxCop.Interoperability.LastErrorPInvoke.vb#1)]

## Related Rules
 [CA1060: Move P/Invokes to NativeMethods class](../code-quality/ca1060-move-p-invokes-to-nativemethods-class.md)

 [CA1400: P/Invoke entry points should exist](../code-quality/ca1400-p-invoke-entry-points-should-exist.md)

 [CA1401: P/Invokes should not be visible](../code-quality/ca1401-p-invokes-should-not-be-visible.md)

 [CA2101: Specify marshaling for P/Invoke string arguments](../code-quality/ca2101-specify-marshaling-for-p-invoke-string-arguments.md)

 [CA2205: Use managed equivalents of Win32 API](../code-quality/ca2205-use-managed-equivalents-of-win32-api.md)
