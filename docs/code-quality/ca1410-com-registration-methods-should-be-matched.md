---
title: "CA1410: COM registration methods should be matched | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-code-analysis"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "CA1410"
  - "ComRegistrationMethodsShouldBeMatched"
helpviewer_keywords: 
  - "CA1410"
  - "ComRegistrationMethodsShouldBeMatched"
ms.assetid: f3b2e62d-fd66-4093-9f0c-dba01ad995fd
caps.latest.revision: 16
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# CA1410: COM registration methods should be matched
|||  
|-|-|  
|TypeName|ComRegistrationMethodsShouldBeMatched|  
|CheckId|CA1410|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A type declares a method that is marked with the <xref:System.Runtime.InteropServices.ComRegisterFunctionAttribute?displayProperty=fullName> attribute but does not declare a method that is marked with the <xref:System.Runtime.InteropServices.ComUnregisterFunctionAttribute?displayProperty=fullName> attribute, or vice versa.  
  
## Rule Description  
 For Component Object Model (COM) clients to create a [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] type, the type must first be registered. If it is available, a method that is marked with the <xref:System.Runtime.InteropServices.ComRegisterFunctionAttribute> attribute is called during the registration process to run user-specified code. A corresponding method that is marked with the <xref:System.Runtime.InteropServices.ComUnregisterFunctionAttribute> attribute is called during the unregistration process to reverse the operations of the registration method.  
  
## How to Fix Violations  
 To fix a violation of this rule, add the corresponding registration or unregistration method.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows a type that violates the rule. The commented code shows the fix for the violation.  
  
 [!code-csharp[FxCop.Interoperability.ComRegistration#1](../code-quality/codesnippet/CSharp/ca1410-com-registration-methods-should-be-matched_1.cs)]
 [!code-vb[FxCop.Interoperability.ComRegistration#1](../code-quality/codesnippet/VisualBasic/ca1410-com-registration-methods-should-be-matched_1.vb)]  
  
## Related Rules  
 [CA1411: COM registration methods should not be visible](../code-quality/ca1411-com-registration-methods-should-not-be-visible.md)  
  
## See Also  
 <xref:System.Runtime.InteropServices.RegistrationServices?displayProperty=fullName>   
 [Registering Assemblies with COM](/dotnet/framework/interop/registering-assemblies-with-com)   
 [Regasm.exe (Assembly Registration Tool)](/dotnet/framework/tools/regasm-exe-assembly-registration-tool)