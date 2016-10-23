---
title: "CA1414: Mark boolean P-Invoke arguments with MarshalAs"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
H1: CA1414: Mark boolean P/Invoke arguments with MarshalAs
ms.assetid: c0c84cf5-7701-4897-9114-66fc4b895699
caps.latest.revision: 14
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
# CA1414: Mark boolean P-Invoke arguments with MarshalAs
|||  
|-|-|  
|TypeName|MarkBooleanPInvokeArgumentsWithMarshalAs|  
|CheckId|CA1414|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Breaking|  
  
## Cause  
 A platform invoke method declaration includes a <xref:System.Boolean?qualifyHint=True> parameter or return value but the <xref:System.Runtime.InteropServices.MarshalAsAttribute?qualifyHint=True> attribute is not applied to the parameter or return value.  
  
## Rule Description  
 A platform invoke method accesses unmanaged code and is defined by using the `Declare` keyword in Visual Basic or the <xref:System.Runtime.InteropServices.DllImportAttribute?qualifyHint=True>. <xref:System.Runtime.InteropServices.MarshalAsAttribute?qualifyHint=False> specifies the marshaling behavior that is used to convert data types between managed and unmanaged code. Many simple data types, such as <xref:System.Byte?qualifyHint=True> and <xref:System.Int32?qualifyHint=True>, have a single representation in unmanaged code and do not require specification of their marshaling behavior; the common language runtime automatically supplies the correct behavior.  
  
 The <xref:System.Boolean?qualifyHint=False> data type has multiple representations in unmanaged code. When the <xref:System.Runtime.InteropServices.MarshalAsAttribute?qualifyHint=False> is not specified, the default marshaling behavior for the <xref:System.Boolean?qualifyHint=False> data type is <xref:System.Runtime.InteropServices.UnmanagedType?qualifyHint=True>. This is a 32-bit integer, which is not appropriate in all circumstances. The Boolean representation that is required by the unmanaged method should be determined and matched to the appropriate <xref:System.Runtime.InteropServices.UnmanagedType?qualifyHint=True>. UnmanagedType.Bool is the Win32 BOOL type, which is always 4 bytes. UnmanagedType.U1 should be used for C++ `bool` or other 1-byte types. For more information, see [Default Marshaling for Boolean Types](assetId:///d4c00537-70f7-4ca6-8197-bfc1ec037ff9).  
  
## How to Fix Violations  
 To fix a violation of this rule, apply <xref:System.Runtime.InteropServices.MarshalAsAttribute?qualifyHint=False> to the <xref:System.Boolean?qualifyHint=False> parameter or return value. Set the value of the attribute to the appropriate <xref:System.Runtime.InteropServices.UnmanagedType?qualifyHint=False>.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule. Even if the default marshaling behavior is appropriate, the code is more easily maintained when the behavior is explicitly specified.  
  
## Example  
 The following example shows two platform invoke methods that are marked with the appropriate <xref:System.Runtime.InteropServices.MarshalAsAttribute?qualifyHint=False> attributes.  
  
 [!CODE [FxCop.Interoperability.BoolMarshalAs#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Interoperability.BoolMarshalAs#1)]  
  
## Related Rules  
 [CA1901: P/Invoke declarations should be portable](../VS_IDE/CA1901--P-Invoke-declarations-should-be-portable.md)  
  
 [CA2101: Specify marshaling for P/Invoke string arguments](../VS_IDE/CA2101--Specify-marshaling-for-P-Invoke-string-arguments.md)  
  
## See Also  
 <xref:System.Runtime.InteropServices.UnmanagedType?qualifyHint=True>   
 [Default Marshaling for Boolean Types](assetId:///d4c00537-70f7-4ca6-8197-bfc1ec037ff9)   
 [Interoperating with Unmanaged Code](../Topic/Interoperating%20with%20Unmanaged%20Code.md)