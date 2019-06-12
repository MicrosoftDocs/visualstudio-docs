---
title: "Create custom views of objects | Microsoft Docs"
ms.date: "01/08/2019"
ms.topic: "conceptual"
f1_keywords:
  - "vs.debug.data.elements"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "data types, custom"
  - "custom data types"
  - "managed code, custom data types"
  - "autoexp.dat file"
  - "mcee_cs.dat file"
  - "debugger, expanding data types"
  - "mcee_mc.dat file"
ms.assetid: 9969e9b2-9008-4729-8a14-0d6deaa61576
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "dotnet"
---
# Create custom views of objects (C#, Visual Basic, C++)
You can customize the way Visual Studio displays data types in debugger variable windows.

## Native Code

For C++ code, you can add custom data type expansions using the Natvis framework, as described in [Create custom views of C++ objects in the debugger](/visualstudio/debugger/create-custom-views-of-native-objects). For C++/CLI code, you also can use attributes, described here in this article.

## Attributes

In C#, Visual Basic, and C++ (C++/CLI code only), you can add expansions for custom data using <xref:System.Diagnostics.DebuggerTypeProxyAttribute>, <xref:System.Diagnostics.DebuggerDisplayAttribute>, and <xref:System.Diagnostics.DebuggerBrowsableAttribute>.

In .NET Framework 2.0 code, Visual Basic does not support the DebuggerBrowsable attribute. This limitation is removed in more recent versions of the .NET Framework.

## Visualizers

You can write a visualizer to display any managed data type. For more information, see [How to: Write a Visualizer](/visualstudio/debugger/create-custom-visualizers-of-data).

## See Also

- [Tell the debugger what to show using the DebuggerDisplay Attribute](../debugger/using-the-debuggerdisplay-attribute.md)
- [Tell the debugger what type to show using DebuggerTypeProxy Attribute](../debugger/using-debuggertypeproxy-attribute.md)
- [Watch and QuickWatch Windows](../debugger/watch-and-quickwatch-windows.md)
- [Enhancing Debugging with the Debugger Display Attributes](/dotnet/framework/debug-trace-profile/enhancing-debugging-with-the-debugger-display-attributes)