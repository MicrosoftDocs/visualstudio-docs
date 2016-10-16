---
title: "CA1019: Define accessors for attribute arguments"
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
  - "CA1019"
  - "DefineAccessorsForAttributeArguments"
helpviewer_keywords: 
  - "CA1019"
  - "DefineAccessorsForAttributeArguments"
ms.assetid: 197f2378-3c43-427e-80de-9ec25006c05c
caps.latest.revision: 19
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
# CA1019: Define accessors for attribute arguments
|||  
|-|-|  
|TypeName|DefineAccessorsForAttributeArguments|  
|CheckId|CA1019|  
|Category|Microsoft.Design|  
|Breaking Change|Non-breaking|  
  
## Cause  
 In its constructor, an attribute defines arguments that do not have corresponding properties.  
  
## Rule Description  
 Attributes can define mandatory arguments that must be specified when you apply the attribute to a target. These are also known as positional arguments because they are supplied to attribute constructors as positional parameters. For every mandatory argument, the attribute should also provide a corresponding read-only property so that the value of the argument can be retrieved at execution time. This rule checks that for each constructor parameter, you have defined the corresponding property.  
  
 Attributes can also define optional arguments, which are also known as named arguments. These arguments are supplied to attribute constructors by name and should have a corresponding read/write property.  
  
 For mandatory and optional arguments, the corresponding properties and constructor parameters should use the same name but different casing. Properties use Pascal casing, and parameters use camel casing.  
  
## How to Fix Violations  
 To fix a violation of this rule, add a read-only property for each constructor parameter that does not have one.  
  
## When to Suppress Warnings  
 Suppress a warning from this rule if you do not want the value of the mandatory argument to be retrievable.  
  
## Custom Attributes Example  
  
### Description  
 The following example shows two attributes that define a mandatory (positional) parameter. The first implementation of the attribute is incorrectly defined. The second implementation is correct.  
  
### Code  
 [!code[FxCop.Design.AttributeAccessors#1](../codequality/codesnippet/CSharp/ca1019--define-accessors-for-attribute-arguments_1.cs)]
[!code[FxCop.Design.AttributeAccessors#1](../codequality/codesnippet/VisualBasic/ca1019--define-accessors-for-attribute-arguments_1.vb)]  
  
## Positional and Named Arguments  
  
### Description  
 Positional and named arguments make to clear to consumers of your library which arguments are mandatory for the attribute and which arguments are optional.  
  
 The following example shows an implementation of an attribute that has both positional and named arguments.  
  
### Code  
 [!code[FxCop.Design.AttributeAccessorsNamed#1](../codequality/codesnippet/CSharp/ca1019--define-accessors-for-attribute-arguments_2.cs)]  
  
### Comments  
 The following example shows how to apply the custom attribute to two properties.  
  
### Code  
 [!code[FxCop.Design.AttributeAccessorsNamedApplied#1](../codequality/codesnippet/CSharp/ca1019--define-accessors-for-attribute-arguments_3.cs)]  
  
## Related Rules  
 [CA1813: Avoid unsealed attributes](../codequality/ca1813--avoid-unsealed-attributes.md)  
  
## See Also  
 [Attributes](../Topic/Attributes1.md)