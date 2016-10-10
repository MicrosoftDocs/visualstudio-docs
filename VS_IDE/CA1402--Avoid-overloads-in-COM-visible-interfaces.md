---
title: "CA1402: Avoid overloads in COM visible interfaces"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 2724c1f9-d5d3-4704-b124-21c4d398e5df
caps.latest.revision: 17
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
# CA1402: Avoid overloads in COM visible interfaces
|||  
|-|-|  
|TypeName|AvoidOverloadsInComVisibleInterfaces|  
|CheckId|CA1402|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Breaking|  
  
## Cause  
 A Component Object Model (COM) visible interface declares overloaded methods.  
  
## Rule Description  
 When overloaded methods are exposed to COM clients, only the first method overload retains its name. Subsequent overloads are uniquely renamed by appending to the name an underscore character '_' and an integer that corresponds to the order of declaration of the overload. For example, consider the following methods.  
  
```  
void SomeMethod(int valueOne);  
void SomeMethod(int valueOne, int valueTwo, int valueThree);  
void SomeMethod(int valueOne, int valueTwo);  
```  
  
 These methods are exposed to COM clients as the following.  
  
```  
void SomeMethod(int valueOne);  
void SomeMethod_2(int valueOne, int valueTwo, int valueThree);  
void SomeMethod_3(int valueOne, int valueTwo);  
```  
  
 Visual Basic 6 COM clients cannot implement interface methods by using an underscore in the name.  
  
## How to Fix Violations  
 To fix a violation of this rule, rename the overloaded methods so that the names are unique. Alternatively, make the interface invisible to COM by changing the accessibility to `internal` (`Friend` in Visual Basic) or by applying the <xref:System.Runtime.InteropServices.ComVisibleAttribute?qualifyHint=True> attribute set to `false`.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows an interface that violates the rule and an interface that satisfies the rule.  
  
 [!CODE [FxCop.Interoperability.OverloadsInterface#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Interoperability.OverloadsInterface#1)]  
  
## Related Rules  
 [CA1413: Avoid non-public fields in COM visible value types](../VS_IDE/CA1413--Avoid-non-public-fields-in-COM-visible-value-types.md)  
  
 [CA1407: Avoid static members in COM visible types](../VS_IDE/CA1407--Avoid-static-members-in-COM-visible-types.md)  
  
 [CA1017: Mark assemblies with ComVisibleAttribute](../VS_IDE/CA1017--Mark-assemblies-with-ComVisibleAttribute.md)  
  
## See Also  
 [Interoperating with Unmanaged Code](../Topic/Interoperating%20with%20Unmanaged%20Code.md)   
 [Long Data Type](../Topic/Long%20Data%20Type%20\(Visual%20Basic\).md)