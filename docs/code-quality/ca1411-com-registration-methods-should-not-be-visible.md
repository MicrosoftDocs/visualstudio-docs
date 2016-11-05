---
title: "CA1411: COM registration methods should not be visible | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "CA1411"
  - "ComRegistrationMethodsShouldNotBeVisible"
helpviewer_keywords: 
  - "ComRegistrationMethodsShouldNotBeVisible"
  - "CA1411"
ms.assetid: a59f96f1-1f38-4596-b656-947df5c55311
caps.latest.revision: 13
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# CA1411: COM registration methods should not be visible
|||  
|-|-|  
|TypeName|ComRegistrationMethodsShouldNotBeVisible|  
|CheckId|CA1411|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Breaking|  
  
## Cause  
 A method that is marked with the <xref:System.Runtime.InteropServices.ComRegisterFunctionAttribute?displayProperty=fullName> or the <xref:System.Runtime.InteropServices.ComUnregisterFunctionAttribute?displayProperty=fullName> attribute is externally visible.  
  
## Rule Description  
 When an assembly is registered with Component Object Model (COM), entries are added to the registry for each COM-visible type in the assembly. Methods that are marked with the <xref:System.Runtime.InteropServices.ComRegisterFunctionAttribute> and <xref:System.Runtime.InteropServices.ComUnregisterFunctionAttribute> attributes are called during the registration and unregistration processes, respectively, to run user code that is specific to the registration/unregistration of these types. This code should not be called outside these processes.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the accessibility of the method to `private` or `internal` (`Friend` in [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)]).  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows two methods that violate the rule.  
  
 [!code-cs[FxCop.Interoperability.ComRegistration2#1](../code-quality/codesnippet/CSharp/ca1411-com-registration-methods-should-not-be-visible_1.cs)]
 [!code-vb[FxCop.Interoperability.ComRegistration2#1](../code-quality/codesnippet/VisualBasic/ca1411-com-registration-methods-should-not-be-visible_1.vb)]  
  
## Related Rules  
 [CA1410: COM registration methods should be matched](../code-quality/ca1410-com-registration-methods-should-be-matched.md)  
  
## See Also  
 <xref:System.Runtime.InteropServices.RegistrationServices?displayProperty=fullName>   
 [Registering Assemblies with COM](../Topic/Registering%20Assemblies%20with%20COM.md)   
 [Regasm.exe (Assembly Registration Tool)](../Topic/Regasm.exe%20\(Assembly%20Registration%20Tool\).md)