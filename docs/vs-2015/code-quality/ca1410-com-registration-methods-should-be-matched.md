---
title: "CA1410: COM registration methods should be matched | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1410"
  - "ComRegistrationMethodsShouldBeMatched"
helpviewer_keywords:
  - "CA1410"
  - "ComRegistrationMethodsShouldBeMatched"
ms.assetid: f3b2e62d-fd66-4093-9f0c-dba01ad995fd
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1410: COM registration methods should be matched
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|ComRegistrationMethodsShouldBeMatched|
|CheckId|CA1410|
|Category|Microsoft.Interoperability|
|Breaking Change|Non-breaking|

## Cause
 A type declares a method that is marked with the <xref:System.Runtime.InteropServices.ComRegisterFunctionAttribute?displayProperty=fullName> attribute but does not declare a method that is marked with the <xref:System.Runtime.InteropServices.ComUnregisterFunctionAttribute?displayProperty=fullName> attribute, or vice versa.

## Rule Description
 For Component Object Model (COM) clients to create a [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] type, the type must first be registered. If it is available, a method that is marked with the <xref:System.Runtime.InteropServices.ComRegisterFunctionAttribute> attribute is called during the registration process to run user-specified code. A corresponding method that is marked with the <xref:System.Runtime.InteropServices.ComUnregisterFunctionAttribute> attribute is called during the unregistration process to reverse the operations of the registration method.

## How to Fix Violations
 To fix a violation of this rule, add the corresponding registration or unregistration method.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Example
 The following example shows a type that violates the rule. The commented code shows the fix for the violation.

 [!code-csharp[FxCop.Interoperability.ComRegistration#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Interoperability.ComRegistration/cs/FxCop.Interoperability.ComRegistration.cs#1)]
 [!code-vb[FxCop.Interoperability.ComRegistration#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Interoperability.ComRegistration/vb/FxCop.Interoperability.ComRegistration.vb#1)]

## Related Rules
 [CA1411: COM registration methods should not be visible](../code-quality/ca1411-com-registration-methods-should-not-be-visible.md)

## See Also
 <xref:System.Runtime.InteropServices.RegistrationServices?displayProperty=fullName>
 [Registering Assemblies with COM](https://msdn.microsoft.com/library/87925795-a3ae-4833-b138-125413478551)
 [Regasm.exe (Assembly Registration Tool)](https://msdn.microsoft.com/library/e190e342-36ef-4651-a0b4-0e8c2c0281cb)
