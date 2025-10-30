---
title: Display WPF trace Information for data binding
description: Visual Studio can receive debug trace information for data binding from WPF applications and display it in the Output window. Learn how to manage and customize WPF tracing. 
ms.date: 10/30/2025
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - WPF, debugging
  - debugging, WPF
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Display WPF trace information for data binding

Visual Studio can receive debug trace information for data binding from WPF applications and display that information in the **Output** window. To display debug trace information, WPF tracing must be enabled.

You can enable WPF tracing in your App.Config file or programmatically by using the <xref:System.Diagnostics.PresentationTraceSources> class. An easier way to enable WPF tracing is by using the **Options** window. WPF tracing for web applications isn't supported.

## Enable or customize WPF trace information

:::moniker range="visualstudio"

1. Open the **Tools** > **Options** pane and expand the **All Settings** > **Debugging** > **Output Window** > **WPF Trace Settings** section.

1. In the dropdown list for the **Data Binding** option, select the level of trace information for Data Binding in WPF.

:::moniker-end
:::moniker range="<=vs-2022"

1. Open the **Tools** > **Options** dialog and expand the **Debugging** > **Output Window** section.

1. Under **General Output Settings**, select the **All debug output** option.

1. In the box on the right, open the **WPF Trace Settings** node.

1. Under **WPF Trace Settings**, select **Data Binding**. A dropdown list appears in the **Settings** column.

1. In the dropdown list for the **Data Binding** option, and select the level of trace information for Data Binding in WPF, and then select **OK**.

:::moniker-end

   - **Critical**: Trace Critical events only.
   
   - **Error**: Trace Critical and Error events.
   
   - **Warning**: Trace Critical, Error, and Warning events
   
   - **Information**: Trace Critical, Error, Warning, and Information events.
   
   - **Verbose**: Trace Critical, Error, Warning, Information, and Verbose events.
   
   - **ActivityTracing**: Trace Stop, Start, Suspend, Transfer, and Resume events.

:::moniker range="visualstudio"

   - **All**: Trace all available trace information.

:::moniker-end

For more information about the trace levels, see <xref:System.Diagnostics.SourceLevels>.


## Related content

- [Debugging WPF](../debugger/debugging-wpf.md)