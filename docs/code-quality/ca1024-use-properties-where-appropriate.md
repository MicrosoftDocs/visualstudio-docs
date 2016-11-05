---
title: "CA1024: Use properties where appropriate | Microsoft Docs"
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
  - "UsePropertiesWhereAppropriate"
  - "CA1024"
helpviewer_keywords: 
  - "CA1024"
  - "UsePropertiesWhereAppropriate"
ms.assetid: 3a04f765-af7c-4872-87ad-9cc29e8e657f
caps.latest.revision: 21
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# CA1024: Use properties where appropriate
|||  
|-|-|  
|TypeName|UsePropertiesWhereAppropriate|  
|CheckId|CA1024|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 A public or protected method has a name that starts with `Get`, takes no parameters, and returns a value that is not an array.  
  
## Rule Description  
 In most cases, properties represent data and methods perform actions. Properties are accessed like fields, which makes them easier to use. A method is a good candidate to become a property if one of these conditions is present:  
  
-   Takes no arguments and returns the state information of an object.  
  
-   Accepts a single argument to set some part of the state of an object.  
  
 Properties should behave as if they are fields; if the method cannot, it should not be changed to a property. Methods are better than properties in the following situations:  
  
-   The method performs a time-consuming operation. The method is perceivably slower than the time that is required to set or get the value of a field.  
  
-   The method performs a conversion. Accessing a field does not return a converted version of the data that it stores.  
  
-   The Get method has an observable side effect. Retrieving the value of a field does not produce any side effects.  
  
-   The order of execution is important. Setting the value of a field does not rely on the occurrence of other operations.  
  
-   Calling the method two times in succession creates different results.  
  
-   The method is static but returns an object that can be changed by the caller. Retrieving the value of a field does not allow the caller to change the data that is stored by the field.  
  
-   The method returns an array.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the method to a property.  
  
## When to Suppress Warnings  
 Suppress a warning from this rule if the method meets at least one of the previously listed criteria.  
  
## Controlling Property Expansion in the Debugger  
 One reason programmers avoid using a property is because they do not want the debugger to auto-expand it. For example, the property might involve allocating a large object or calling a P/Invoke, but it might not actually have any observable side effects.  
  
 You can prevent the debugger from auto-expanding properties by applying <xref:System.Diagnostics.DebuggerBrowsableAttribute?displayProperty=fullName>. The following example shows this attribute being applied to an instance property.  
  
```vb  
Imports System   
Imports System.Diagnostics   
  
Namespace Microsoft.Samples   
  
    Public Class TestClass   
  
        ' [...]   
  
        <DebuggerBrowsable(DebuggerBrowsableState.Never)> _   
        Public ReadOnly Property LargeObject() As LargeObject   
            Get   
                ' Allocate large object   
                ' [...]   
            End Get   
        End Property   
  
    End Class   
  
End Namespace  
```  
  
```c#  
  
      using System;   
using System.Diagnostics;   
  
namespace Microsoft.Samples   
{   
    publicclass TestClass   
    {   
        // [...]   
  
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]   
        public LargeObject LargeObject   
        {   
            get   
            {   
                // Allocate large object   
                // [...]   
  
        }  
    }  
}  
```  
  
## Example  
 The following example contains several methods that should be converted to properties, and several that should not because they do not behave like fields.  
  
 [!code-cs[FxCop.Design.MethodsProperties#1](../code-quality/codesnippet/CSharp/ca1024-use-properties-where-appropriate_1.cs)]