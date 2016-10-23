---
title: "CA1410: COM registration methods should be matched"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: f3b2e62d-fd66-4093-9f0c-dba01ad995fd
caps.latest.revision: 16
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
# CA1410: COM registration methods should be matched
|||  
|-|-|  
|TypeName|ComRegistrationMethodsShouldBeMatched|  
|CheckId|CA1410|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A type declares a method that is marked with the <xref:System.Runtime.InteropServices.ComRegisterFunctionAttribute?qualifyHint=True> attribute but does not declare a method that is marked with the <xref:System.Runtime.InteropServices.ComUnregisterFunctionAttribute?qualifyHint=True> attribute, or vice versa.  
  
## Rule Description  
 For Component Object Model (COM) clients to create a .NET Framework type, the type must first be registered. If it is available, a method that is marked with the <xref:System.Runtime.InteropServices.ComRegisterFunctionAttribute?qualifyHint=False> attribute is called during the registration process to run user-specified code. A corresponding method that is marked with the <xref:System.Runtime.InteropServices.ComUnregisterFunctionAttribute?qualifyHint=False> attribute is called during the unregistration process to reverse the operations of the registration method.  
  
## How to Fix Violations  
 To fix a violation of this rule, add the corresponding registration or unregistration method.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows a type that violates the rule. The commented code shows the fix for the violation.  
  
 [!CODE [FxCop.Interoperability.ComRegistration#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Interoperability.ComRegistration#1)]  
  
## Related Rules  
 [CA1411: COM registration methods should not be visible](../VS_IDE/CA1411--COM-registration-methods-should-not-be-visible.md)  
  
## See Also  
 <xref:System.Runtime.InteropServices.RegistrationServices?qualifyHint=True>   
 [Registering Assemblies with COM](../Topic/Registering%20Assemblies%20with%20COM.md)   
 [Regasm.exe (Assembly Registration Tool)](../Topic/Regasm.exe%20\(Assembly%20Registration%20Tool\).md)