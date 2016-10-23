---
title: "CA1411: COM registration methods should not be visible"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a59f96f1-1f38-4596-b656-947df5c55311
caps.latest.revision: 13
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
# CA1411: COM registration methods should not be visible
|||  
|-|-|  
|TypeName|ComRegistrationMethodsShouldNotBeVisible|  
|CheckId|CA1411|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Breaking|  
  
## Cause  
 A method that is marked with the <xref:System.Runtime.InteropServices.ComRegisterFunctionAttribute?qualifyHint=True> or the <xref:System.Runtime.InteropServices.ComUnregisterFunctionAttribute?qualifyHint=True> attribute is externally visible.  
  
## Rule Description  
 When an assembly is registered with Component Object Model (COM), entries are added to the registry for each COM-visible type in the assembly. Methods that are marked with the <xref:System.Runtime.InteropServices.ComRegisterFunctionAttribute?qualifyHint=False> and <xref:System.Runtime.InteropServices.ComUnregisterFunctionAttribute?qualifyHint=False> attributes are called during the registration and unregistration processes, respectively, to run user code that is specific to the registration/unregistration of these types. This code should not be called outside these processes.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the accessibility of the method to `private` or `internal` (`Friend` in Visual Basic).  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows two methods that violate the rule.  
  
 [!CODE [FxCop.Interoperability.ComRegistration2#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Interoperability.ComRegistration2#1)]  
  
## Related Rules  
 [CA1410: COM registration methods should be matched](../VS_IDE/CA1410--COM-registration-methods-should-be-matched.md)  
  
## See Also  
 <xref:System.Runtime.InteropServices.RegistrationServices?qualifyHint=True>   
 [Registering Assemblies with COM](../Topic/Registering%20Assemblies%20with%20COM.md)   
 [Regasm.exe (Assembly Registration Tool)](../Topic/Regasm.exe%20\(Assembly%20Registration%20Tool\).md)