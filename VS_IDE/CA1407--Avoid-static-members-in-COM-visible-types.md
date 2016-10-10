---
title: "CA1407: Avoid static members in COM visible types"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: bebd0776-ad04-453c-bca8-8c124c2d7840
caps.latest.revision: 23
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
# CA1407: Avoid static members in COM visible types
|||  
|-|-|  
|TypeName|AvoidStaticMembersInComVisibleTypes|  
|CheckId|CA1407|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A type that is specifically marked as visible to Component Object Model (COM) contains a `public``static` method.  
  
## Rule Description  
 COM does not support `static` methods.  
  
 This rule ignores property and event accessors, operator overloading methods, or methods that are marked by using either the <xref:System.Runtime.InteropServices.ComRegisterFunctionAttribute?qualifyHint=True> attribute or the <xref:System.Runtime.InteropServices.ComUnregisterFunctionAttribute?qualifyHint=True> attribute.  
  
 By default, the following are visible to COM: assemblies, public types, public instance members in public types, and all members of public value types.  
  
 For this rule to occur, an assembly-level <xref:System.Runtime.InteropServices.ComVisibleAttribute?qualifyHint=False> must be set to `false` and the class- <xref:System.Runtime.InteropServices.ComVisibleAttribute?qualifyHint=False> must be set to `true`, as the following code shows.  
  
```c#  
using System;  
using System.Runtime.InteropServices;   
  
[assembly: ComVisible(false)]   
namespace Samples  
{      
    [ComVisible(true)]  
    public class MyClass  
    {  
        public static void DoSomething()  
        {  
        }  
    }  
}  
```  
  
## How to Fix Violations  
 To fix a violation of this rule, change the design to use an instance method that provides the same functionality as the `static` method.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if a COM client does not require access to the functionality that is provided by the `static` method.  
  
## Example Violation  
  
### Description  
 The following example shows a `static` method that violates this rule.  
  
### Code  
 [!CODE [FxCop.Interoperability.ComVisibleStaticMembersViolation#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Interoperability.ComVisibleStaticMembersViolation#1)]  
  
### Comments  
 In this example, the **Book.FromPages** method cannot be called from COM.  
  
## Example Fix  
  
### Description  
 To fix the violation in the previous example, you could change the method to an instance method, but that does not make sense in this instance. A better solution is to explicitly apply `ComVisible(false)` to the method to make it clear to other developers that the method cannot be seen from COM.  
  
 The following example applies <xref:System.Runtime.InteropServices.ComRegisterFunctionAttribute?qualifyHint=False> to the method.  
  
### Code  
 [!CODE [FxCop.Interoperability.ComVisibleStaticMembersFixed#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Interoperability.ComVisibleStaticMembersFixed#1)]  
  
## Related Rules  
 [CA1017: Mark assemblies with ComVisibleAttribute](../VS_IDE/CA1017--Mark-assemblies-with-ComVisibleAttribute.md)  
  
 [CA1406: Avoid Int64 arguments for Visual Basic 6 clients](../VS_IDE/CA1406--Avoid-Int64-arguments-for-Visual-Basic-6-clients.md)  
  
 [CA1413: Avoid non-public fields in COM visible value types](../VS_IDE/CA1413--Avoid-non-public-fields-in-COM-visible-value-types.md)  
  
## See Also  
 [Interoperating with Unmanaged Code](../Topic/Interoperating%20with%20Unmanaged%20Code.md)