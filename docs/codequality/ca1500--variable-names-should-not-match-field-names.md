---
title: "CA1500: Variable names should not match field names"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "VariableNamesShouldNotMatchFieldNames"
  - "CA1500"
helpviewer_keywords: 
  - "VariableNamesShouldNotMatchFieldNames"
  - "CA1500"
ms.assetid: fa0e5029-79e9-4a33-8576-787ac3c26c39
caps.latest.revision: 24
ms.author: "douge"
manager: "douge"
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
# CA1500: Variable names should not match field names
|||  
|-|-|  
|TypeName|VariableNamesShouldNotMatchFieldNames|  
|CheckId|CA1500|  
|Category|Microsoft.Maintainability|  
|Breaking Change|When fired on a parameter that has the same name as a field:<br /><br /> -   Non-breaking - If both the field and method that declares the parameter cannot be seen outside the assembly, regardless of the change you make.<br />-   Breaking - If you change the name of the field and can be seen outside the assembly.<br />-   Breaking - If you change the name of the parameter and the method that declares it can be seen outside the assembly.<br /><br /> When fired on a local variable that has the same name as a field:<br /><br /> -   Non-breaking - If the field cannot be seen outside the assembly, regardless of the change you make.<br />-   Non-breaking - If you change the name of the local variable and do not change the name of the field.<br />-   Breaking - If you change the name of the field and it can be seen outside the assembly.|  
  
## Cause  
 An instance method declares a parameter or a local variable whose name matches an instance field of the declaring type. To catch local variables that violate the rule, the tested assembly must be built by using debugging information and the associated program database (.pdb) file must be available.  
  
## Rule Description  
 When the name of an instance field matches a parameter or a local variable name, the instance field is accessed by using the `this` (`Me` in [!INCLUDE[vbprvb](../codequality/includes/vbprvb_md.md)]) keyword when inside the method body. When maintaining code, it is easy to forget this difference and assume that the parameter/local variable refers to the instance field, which leads to errors. This is true especially for lengthy method bodies.  
  
## How to Fix Violations  
 To fix a violation of this rule, rename either the parameter/variable or the field.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows two violations of the rule.  
  
 [!code[FxCop.Maintainability.VarMatchesField#1](../codequality/codesnippet/VisualBasic/ca1500--variable-names-should-not-match-field-names_1.vb)]
[!code[FxCop.Maintainability.VarMatchesField#1](../codequality/codesnippet/CSharp/ca1500--variable-names-should-not-match-field-names_1.cs)]