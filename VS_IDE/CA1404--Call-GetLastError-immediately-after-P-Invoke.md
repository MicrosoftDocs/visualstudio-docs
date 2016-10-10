---
title: "CA1404: Call GetLastError immediately after P-Invoke"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
H1: CA1404: Call GetLastError immediately after P/Invoke
ms.assetid: 52ae9eff-50f9-4b2f-8039-ca7e49fba88e
caps.latest.revision: 18
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
# CA1404: Call GetLastError immediately after P-Invoke
|||  
|-|-|  
|TypeName|CallGetLastErrorImmediatelyAfterPInvoke|  
|CheckId|CA1404|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A call is made to the <xref:System.Runtime.InteropServices.Marshal.GetLastWin32Error?qualifyHint=True> method or the equivalent Win32 `GetLastError` function, and the call that comes immediately before is not to a platform invoke method.  
  
## Rule Description  
 A platform invoke method accesses unmanaged code and is defined by using the `Declare` keyword in Visual Basic or the <xref:System.Runtime.InteropServices.DllImportAttribute?qualifyHint=True> attribute. Generally, upon failure, unmanaged functions call the Win32 `SetLastError` function to set an error code that is associated with the failure. The caller of the failed function calls the Win32 `GetLastError` function to retrieve the error code and determine the cause of the failure. The error code is maintained on a per-thread basis and is overwritten by the next call to `SetLastError`. After a call to a failed platform invoke method, managed code can retrieve the error code by calling the <xref:System.Runtime.InteropServices.Marshal.GetLastWin32Error?qualifyHint=False> method. Because the error code can be overwritten by internal calls from other managed class library methods, the `GetLastError` or <xref:System.Runtime.InteropServices.Marshal.GetLastWin32Error?qualifyHint=False> method should be called immediately after the platform invoke method call.  
  
 The rule ignores calls to the following managed members when they occur between the call to the platform invoke method and the call to <xref:System.Runtime.InteropServices.Marshal.GetLastWin32Error?qualifyHint=False>. These members do not change the error code and are useful for determining the success of some platform invoke method calls.  
  
-   <xref:System.IntPtr.Zero?qualifyHint=True>  
  
-   <xref:System.IntPtr.op_Equality?qualifyHint=True>  
  
-   <xref:System.IntPtr.op_Inequality?qualifyHint=True>  
  
-   <xref:System.Runtime.InteropServices.SafeHandle.IsInvalid?qualifyHint=True>  
  
## How to Fix Violations  
 To fix a violation of this rule, move the call to <xref:System.Runtime.InteropServices.Marshal.GetLastWin32Error?qualifyHint=False> so that it immediately follows the call to the platform invoke method.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the code between the platform invoke method call and the <xref:System.Runtime.InteropServices.Marshal.GetLastWin32Error?qualifyHint=False> method call cannot explicitly or implicitly cause the error code to change.  
  
## Example  
 The following example shows a method that violates the rule and a method that satisfies the rule.  
  
 [!CODE [FxCop.Interoperability.LastErrorPInvoke#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Interoperability.LastErrorPInvoke#1)]  
  
## Related Rules  
 [CA1060: Move P/Invokes to NativeMethods class](../VS_IDE/CA1060--Move-P-Invokes-to-NativeMethods-class.md)  
  
 [CA1400: P/Invoke entry points should exist](../VS_IDE/CA1400--P-Invoke-entry-points-should-exist.md)  
  
 [CA1401: P/Invokes should not be visible](../VS_IDE/CA1401--P-Invokes-should-not-be-visible.md)  
  
 [CA2101: Specify marshaling for P/Invoke string arguments](../VS_IDE/CA2101--Specify-marshaling-for-P-Invoke-string-arguments.md)  
  
 [CA2205: Use managed equivalents of Win32 API](../VS_IDE/CA2205--Use-managed-equivalents-of-Win32-API.md)