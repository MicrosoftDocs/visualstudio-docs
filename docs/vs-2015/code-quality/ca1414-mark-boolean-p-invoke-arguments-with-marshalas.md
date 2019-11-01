---
title: "CA1414: Mark boolean P-Invoke arguments with MarshalAs | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1414"
  - "MarkBooleanPInvokeArgumentsWithMarshalAs"
helpviewer_keywords:
  - "CA1414"
  - "MarkBooleanPInvokeArgumentsWithMarshalAs"
ms.assetid: c0c84cf5-7701-4897-9114-66fc4b895699
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1414: Mark boolean P/Invoke arguments with MarshalAs
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|MarkBooleanPInvokeArgumentsWithMarshalAs|
|CheckId|CA1414|
|Category|Microsoft.Interoperability|
|Breaking Change|Breaking|

## Cause
 A platform invoke method declaration includes a <xref:System.Boolean?displayProperty=fullName> parameter or return value but the <xref:System.Runtime.InteropServices.MarshalAsAttribute?displayProperty=fullName> attribute is not applied to the parameter or return value.

## Rule Description
 A platform invoke method accesses unmanaged code and is defined by using the `Declare` keyword in [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] or the <xref:System.Runtime.InteropServices.DllImportAttribute?displayProperty=fullName>. <xref:System.Runtime.InteropServices.MarshalAsAttribute> specifies the marshaling behavior that is used to convert data types between managed and unmanaged code. Many simple data types, such as <xref:System.Byte?displayProperty=fullName> and <xref:System.Int32?displayProperty=fullName>, have a single representation in unmanaged code and do not require specification of their marshaling behavior; the common language runtime automatically supplies the correct behavior.

 The <xref:System.Boolean> data type has multiple representations in unmanaged code. When the <xref:System.Runtime.InteropServices.MarshalAsAttribute> is not specified, the default marshaling behavior for the <xref:System.Boolean> data type is <xref:System.Runtime.InteropServices.UnmanagedType?displayProperty=fullName>. This is a 32-bit integer, which is not appropriate in all circumstances. The Boolean representation that is required by the unmanaged method should be determined and matched to the appropriate <xref:System.Runtime.InteropServices.UnmanagedType?displayProperty=fullName>. UnmanagedType.Bool is the Win32 BOOL type, which is always 4 bytes. UnmanagedType.U1 should be used for C++ `bool` or other 1-byte types. For more information, see [Default Marshaling for Boolean Types](https://msdn.microsoft.com/d4c00537-70f7-4ca6-8197-bfc1ec037ff9).

## How to Fix Violations
 To fix a violation of this rule, apply <xref:System.Runtime.InteropServices.MarshalAsAttribute> to the <xref:System.Boolean> parameter or return value. Set the value of the attribute to the appropriate <xref:System.Runtime.InteropServices.UnmanagedType>.

## When to Suppress Warnings
 Do not suppress a warning from this rule. Even if the default marshaling behavior is appropriate, the code is more easily maintained when the behavior is explicitly specified.

## Example
 The following example shows two platform invoke methods that are marked with the appropriate <xref:System.Runtime.InteropServices.MarshalAsAttribute> attributes.

 [!code-cpp[FxCop.Interoperability.BoolMarshalAs#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Interoperability.BoolMarshalAs/cpp/FxCop.Interoperability.BoolMarshalAs.cpp#1)]
 [!code-csharp[FxCop.Interoperability.BoolMarshalAs#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Interoperability.BoolMarshalAs/cs/FxCop.Interoperability.BoolMarshalAs.cs#1)]
 [!code-vb[FxCop.Interoperability.BoolMarshalAs#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Interoperability.BoolMarshalAs/vb/FxCop.Interoperability.BoolMarshalAs.vb#1)]

## Related Rules
 [CA1901: P/Invoke declarations should be portable](../code-quality/ca1901-p-invoke-declarations-should-be-portable.md)

 [CA2101: Specify marshaling for P/Invoke string arguments](../code-quality/ca2101-specify-marshaling-for-p-invoke-string-arguments.md)

## See Also
 <xref:System.Runtime.InteropServices.UnmanagedType?displayProperty=fullName>
 [Default Marshaling for Boolean Types](https://msdn.microsoft.com/d4c00537-70f7-4ca6-8197-bfc1ec037ff9)
 [Interoperating with Unmanaged Code](https://msdn.microsoft.com/library/ccb68ce7-b0e9-4ffb-839d-03b1cd2c1258)
