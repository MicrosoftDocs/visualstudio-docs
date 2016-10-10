---
title: "CA1408: Do not use AutoDual ClassInterfaceType"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 60ca5e02-3c51-42dd-942b-4f950eecfa0f
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
# CA1408: Do not use AutoDual ClassInterfaceType
|||  
|-|-|  
|TypeName|DoNotUseAutoDualClassInterfaceType|  
|CheckId|CA1408|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Breaking|  
  
## Cause  
 A Component Object Model (COM) visible type is marked with the <xref:System.Runtime.InteropServices.ClassInterfaceAttribute?qualifyHint=False> attribute set to the `AutoDual` value of <xref:System.Runtime.InteropServices.ClassInterfaceType?qualifyHint=False>.  
  
## Rule Description  
 Types that use a dual interface enable clients to bind to a specific interface layout. Any changes in a future version to the layout of the type or any base types will break COM clients that bind to the interface. By default, if the <xref:System.Runtime.InteropServices.ClassInterfaceAttribute?qualifyHint=False> attribute is not specified, a dispatch-only interface is used.  
  
 Unless marked otherwise, all public nongeneric types are visible to COM; all nonpublic and generic types are invisible to COM.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the value of the <xref:System.Runtime.InteropServices.ClassInterfaceAttribute?qualifyHint=False> attribute to the `None` value of <xref:System.Runtime.InteropServices.ClassInterfaceType?qualifyHint=False> and explicitly define the interface.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule unless it is certain that the layout of the type and its base types will not change in a future version.  
  
## Example  
 The following example shows a class that violates the rule and a re-declaration of the class to use an explicit interface.  
  
 [!CODE [FxCop.Interoperability.AutoDual#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Interoperability.AutoDual#1)]  
  
## Related Rules  
 [CA1403: Auto layout types should not be COM visible](../VS_IDE/CA1403--Auto-layout-types-should-not-be-COM-visible.md)  
  
 [CA1412: Mark ComSource Interfaces as IDispatch](../VS_IDE/CA1412--Mark-ComSource-Interfaces-as-IDispatch.md)  
  
## See Also  
 [Introducing the Class Interface](assetId:///733c0dd2-12e5-46e6-8de1-39d5b25df024)   
 [Qualifying .NET Types for Interoperation](../Topic/Qualifying%20.NET%20Types%20for%20Interoperation.md)   
 [Interoperating with Unmanaged Code](../Topic/Interoperating%20with%20Unmanaged%20Code.md)