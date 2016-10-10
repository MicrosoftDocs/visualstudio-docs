---
title: "CA1409: Com visible types should be creatable"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9f59569b-de15-4a38-b7cb-cff152972243
caps.latest.revision: 18
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
# CA1409: Com visible types should be creatable
|||  
|-|-|  
|TypeName|ComVisibleTypesShouldBeCreatable|  
|CheckId|CA1409|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A reference type that is specifically marked as visible to Component Object Model (COM) contains a public parameterized constructor but does not contain a public default (parameterless) constructor.  
  
## Rule Description  
 A type without a public default constructor cannot be created by COM clients. However, the type can still be accessed by COM clients if another means is available to create the type and pass it to the client (for example, through the return value of a method call).  
  
 The rule ignores types that are derived from <xref:System.Delegate?qualifyHint=True>.  
  
 By default, the following are visible to COM: assemblies, public types, public instance members in public types, and all members of public value types.  
  
## How to Fix Violations  
 To fix a violation of this rule, add a public default constructor or remove the <xref:System.Runtime.InteropServices.ComVisibleAttribute?qualifyHint=True> from the type.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if other ways are provided to create and pass the object to the COM client.  
  
## Related Rules  
 [CA1017: Mark assemblies with ComVisibleAttribute](../VS_IDE/CA1017--Mark-assemblies-with-ComVisibleAttribute.md)  
  
## See Also  
 [Qualifying .NET Types for Interoperation](../Topic/Qualifying%20.NET%20Types%20for%20Interoperation.md)   
 [Interoperating with Unmanaged Code](../Topic/Interoperating%20with%20Unmanaged%20Code.md)