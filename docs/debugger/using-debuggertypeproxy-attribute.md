---
title: "Using DebuggerTypeProxy Attribute | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "attributes [C#], debugger"
  - "DebuggerTypeProxyAttribute class"
  - "DebuggerTypeProxy attribute"
ms.assetid: 943f3bb1-993e-4800-a47e-0af78b063014
caps.latest.revision: 24
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
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
# Using DebuggerTypeProxy Attribute
<xref:System.Diagnostics.DebuggerTypeProxyAttribute> specifies a proxy, or stand-in, for a type and changes the way the type is displayed in debugger windows. When you view a variable that has a proxy, the proxy stands in for the original type in the **display**. The debugger variable window displays only the public members of the proxy type. Private members are not displayed.  
  
 This attribute can be applied to:  
  
-   Structures  
  
-   Classes  
  
-   Assemblies  
  
 A type proxy class must have a constructor that takes an argument of the type that the proxy will replace. The debugger creates a new instance of the type proxy class every time it needs to display a variable of the target type. This can have performance implications. As a result, you should not do any more work in the constructor than absolutely necessary.  
  
 To minimize performance penalties, the expression evaluator does not examine the attributes on the display proxy of the type unless the type is expanded by the user clicking the + symbol in the debugger window or by the use of <xref:System.Diagnostics.DebuggerBrowsableAttribute>. Therefore, you should not place attributes on the display type itself. Attributes can and should be used in the body of the display type.  
  
 It is a good idea for the type proxy to be a private nested class within the class that the attribute targets. This allows it to access internal members easily.  
  
 If <xref:System.Diagnostics.DebuggerTypeProxyAttribute> is used at the assembly level, the `Target` parameter specifies the type which the proxy will replace.  
  
 For an example of how to use this attribute along with <xref:System.Diagnostics.DebuggerDisplayAttribute> and <xref:System.Diagnostics.DebuggerTypeProxyAttribute>, see[Using the DebuggerDisplay Attribute](../debugger/using-the-debuggerdisplay-attribute.md).  
  
## Using Generics with DebuggerTypeProxy  
 Support for generics is limited. For C#, `DebuggerTypeProxy` supports only open types. An open type, also called an unconstructed type, is a generic type that has not been instantiated with arguments for its type parameters. Closed types, also called constructed types, are not supported.  
  
 The syntax for an open type looks like this:  
  
 `Namespace.TypeName<,>`  
  
 If you use a generic type as a target in `DebuggerTypeProxy`, you must use this syntax. The `DebuggerTypeProxy` mechanism infers the type parameters for you.  
  
 For more information on open and closed types in C# see the [C# Language Specification](/dotnet/csharp/language-reference/language-specification), section 20.5.2 Open and closed types.  
  
 Visual Basic does not have open type syntax, so you cannot do the same thing in Visual Basic. Instead, you must use a string representation of the open type name.  
  
 `"Namespace.TypeName'2"`  
  
## See Also  
 [Using the DebuggerDisplay Attribute](../debugger/using-the-debuggerdisplay-attribute.md)   
 [Create custom views of .managed objects](../debugger/create-custom-views-of-dot-managed-objects.md)   
 [Enhancing Debugging with the Debugger Display Attributes](../Topic/Enhancing%20Debugging%20with%20the%20Debugger%20Display%20Attributes.md)