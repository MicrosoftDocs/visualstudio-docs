---
title: "CA1400: P-Invoke entry points should exist | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1400"
  - "PInvokeEntryPointsShouldExist"
helpviewer_keywords:
  - "PInvokeEntryPointsShouldExist"
  - "CA1400"
ms.assetid: 1d64e470-7b2f-4cca-8fb0-ac92829e6332
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1400: P/Invoke entry points should exist
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|PInvokeEntryPointsShouldExist|
|CheckId|CA1400|
|Category|Microsoft.Interoperability|
|Breaking Change|Non-breaking|

## Cause
 A public or protected method is marked with the <xref:System.Runtime.InteropServices.DllImportAttribute?displayProperty=fullName>. Either the unmanaged library could not be located or the method could not be matched to a function in the library. If the rule cannot find the method name exactly as it is specified, it looks for ANSI or wide-character versions of the method by suffixing the method name with 'A' or 'W'. If no match is found, the rule attempts to locate a function by using the __stdcall name format (_MyMethod@12, where 12 represents the length of the arguments). If no match is found, and the method name starts with '#', the rule searches for the function as an ordinal reference instead of a name reference.

## Rule Description
 No compile-time check is available to make sure that methods that are marked with <xref:System.Runtime.InteropServices.DllImportAttribute> are located in the referenced unmanaged DLL. If no function that has the specified name is  in the library, or the arguments to the method do not match the function arguments, the common language runtime throws an exception.

## How to Fix Violations
 To fix a violation of this rule, correct the method that has the <xref:System.Runtime.InteropServices.DllImportAttribute> attribute. Make sure that the unmanaged library exists and is in the same directory as the assembly that contains the method. If the library is present and correctly referenced, verify that the method name, return type, and argument signature match the library function.

## When to Suppress Warnings
 Do not suppress a warning from this rule when the unmanaged library is in the same directory as the managed assembly that references it. It might be safe to suppress a warning from this rule in the case where the unmanaged library could not be located.

## Example
 The following example shows a type that violates the rule. No function that is named `DoSomethingUnmanaged` occurs in kernel32.dll.

 [!code-csharp[FxCop.Interoperability.DLLExists#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Interoperability.DLLExists/cs/FxCop.Interoperability.DLLExists.cs#1)]

## See Also
 <xref:System.Runtime.InteropServices.DllImportAttribute?displayProperty=fullName>
