---
title: Display custom type using DebuggerTypeProxy | Microsoft Docs
description: Use an instance of DebuggerTypeProxyAttribute to specify a proxy (stand-in) for a type, to change how the type is displayed in debugger windows.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - attributes [C#], debugger
  - DebuggerTypeProxyAttribute class
  - DebuggerTypeProxy attribute
ms.assetid: 943f3bb1-993e-4800-a47e-0af78b063014
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# Tell the debugger what type to show using DebuggerTypeProxy Attribute (C#, Visual Basic, C++/CLI)

<xref:System.Diagnostics.DebuggerTypeProxyAttribute> specifies a proxy, or stand-in, for a type and changes the way the type is displayed in debugger windows. When you view a variable that has a proxy, the proxy stands in for the original type in the **display**. The debugger variable window displays only the public members of the proxy type. Private members are not displayed.

This attribute can be applied to:

- Structures
- Classes
- Assemblies

> [!NOTE]
> For native code, this attribute is supported only in C++/CLI code.

A type proxy class must have a constructor that takes an argument of the type that the proxy will replace. The debugger creates a new instance of the type proxy class every time it needs to display a variable of the target type. This can have performance implications. As a result, you should not do any more work in the constructor than absolutely necessary.

To minimize performance penalties, the expression evaluator does not examine the attributes on the display proxy of the type unless the type is expanded by the user clicking the + symbol in the debugger window or by the use of <xref:System.Diagnostics.DebuggerBrowsableAttribute>. Therefore, you should not place attributes on the display type itself. Attributes can and should be used in the body of the display type.

It is a good idea for the type proxy to be a private nested class within the class that the attribute targets. This allows it to access internal members easily.

<xref:System.Diagnostics.DebuggerTypeProxyAttribute> can be inherited, so if a type proxy is specified on a base class it will apply to any derived classes, unless those derived classes specify their own type proxy.

If <xref:System.Diagnostics.DebuggerTypeProxyAttribute> is used at the assembly level, the `Target` parameter specifies the type which the proxy will replace.

For an example of how to use this attribute along with <xref:System.Diagnostics.DebuggerDisplayAttribute> and <xref:System.Diagnostics.DebuggerTypeProxyAttribute>, see [Using the DebuggerDisplay Attribute](../debugger/using-the-debuggerdisplay-attribute.md).

## Using Generics with DebuggerTypeProxy

Support for generics is limited. For C#, `DebuggerTypeProxy` supports only open types. An open type, also called an unconstructed type, is a generic type that has not been instantiated with arguments for its type parameters. Closed types, also called constructed types, are not supported.

The syntax for an open type looks like this:

`Namespace.TypeName<,>`

If you use a generic type as a target in `DebuggerTypeProxy`, you must use this syntax. The `DebuggerTypeProxy` mechanism infers the type parameters for you.

For more information on open and closed types in C# see the [C# Language Specification](/dotnet/csharp/language-reference/language-specification), section 20.5.2 Open and closed types.

Visual Basic does not have open type syntax, so you cannot do the same thing in Visual Basic. Instead, you must use a string representation of the open type name.

`"Namespace.TypeName'2"`

## See also

- [Using the DebuggerDisplay Attribute](../debugger/using-the-debuggerdisplay-attribute.md)
- [Create custom views of managed objects](../debugger/create-custom-views-of-managed-objects.md)
- [Enhancing Debugging with the Debugger Display Attributes](/dotnet/framework/debug-trace-profile/enhancing-debugging-with-the-debugger-display-attributes)
