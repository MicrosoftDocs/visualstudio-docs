---
title: 'Debug an extension created with VisualStudio.Extensibility'
description: Learn how to debug an out-of-process extension in the Visual Studio Experimental instance.
ms.topic: how-to
ms.date: 04/01/2026
ms.author: madsk
monikerRange: ">=vs-2022"
author: madskristensen

ms.subservice: extensibility-integration
ms.update-cycle: 365-days
---

# Debug a Visual Studio extension

When you debug a Visual Studio extension, a special instance of Visual Studio called the Experimental Instance is used to host your extension while you run the debugger in main Visual Studio IDE. The two instances run independently side by side. This article describes how to debug extensions created with the VisualStudio.Extensibility SDK when they're running in the experimental instance of the Visual Studio IDE.

## Extension processes

The debugging process differs slightly depending on whether your extension runs in-process or out-of-process. See [Create your first VSSDK-compatible VisualStudio.Extensibility extension](../how-it-works/models/in-proc-extensions.md). With an out-of-process extension, your extension runs in a separate process outside of `devenv.exe`. When you start an extension by using **F5**, Visual Studio launches the Visual Studio Experimental Instance and connects to the process that hosts your extension. You usually don't need to be concerned about the exact process, because when you launch the debugger from an extension project by pressing `F5` in the Visual Studio IDE, Visual Studio locates the right process to connect the debugger to.

When you start a debug session, your extension assembly and its symbols are not immediately loaded. Before your extension loads, Visual Studio keeps track of the places where the extension could be activated. This information is managed in an internal instance of [`VisualStudioContribution` ↗](/dotnet/api/microsoft.visualstudio.extensibility.visualstudiocontributionattribute). Even before your extension loads, Visual Studio has information about where it might be activated, such as when the user chooses a particular menu item, presses a toolbar button, or loads a file of a certain type into the editor.  Your extension's assembly won't load until it's activated in the IDE. So, when debugging, the first thing you need to do is take action in the Visual Studio IDE to trigger the extension to load. For example, you might need to select your extension's menu item or toolbar button. At that point, your extension assembly is loaded, the initialization code is executed, and you can hit breakpoints and step through code. The first code to run in your extension is the [`InitializeAsync` ↗](/dotnet/api/microsoft.visualstudio.extensibility.extensionpart.initializeasync) method on the [`Extension` ↗](/dotnet/api/microsoft.visualstudio.extensibility.extension) class, and the next method is [`InitializeServices` ↗](/dotnet/api/microsoft.visualstudio.extensibility.extension.initializeservices).

## Processes and call stacks

If your extension is in-process, the call stack includes Visual Studio stack frames as well as your extension's stack frames. Symbols are normally not available for Visual Studio, but you can see the calls where Visual Studio calls your extension.

With an out-of-process extension, you only see your extension's call stack; Visual Studio stack frames are in a separate process. Visual Studio calls into your extension through JsonRpc-compatible interfaces, the ServiceHub host routes the call, and then execution in your process begins in the callback. Control returns to Visual Studio when your callback returns.

State is passed to your extension in various methods as needed and wrapped by an [`IClientContext` ↗](/dotnet/api/microsoft.visualstudio.extensibility.iclientcontext) instance for easy usage, but it's important to consider that it is a snapshot of the state, which could change between the time of the snapshot and the time when you're reading it from extension code or viewing it in the debugger.

There is some internal code in the ServiceHub host process that handles the [RPC (Remote Procedure Call) ↗](/windows/win32/rpc/rpc-start-page) brokering. If a failure occurs in this layer, it is not visible to you. Such errors should be reported as product issues.

## Debug the extension in the experimental instance of Visual Studio

1. Open the extension project.
1. Set up a breakpoint, for example, in your extension's [`InitializeServices` ↗](/dotnet/api/microsoft.visualstudio.extensibility.extension.initializeservices) method on the main class derived from [`Extension` ↗](/dotnet/api/microsoft.visualstudio.extensibility.extension). To set a breakpoint on a line of code, click on the line, and press `F9`.
1. From the main menu, choose **Debug > Start Debugging** or press `F5`. Visual Studio Experimental Instance is launched; at the same time, the ServiceHub host process starts.
1. Execute the steps in the experimental instance of Visual Studio that cause your extension to activate or to reproduce the scenario you're intending to debug.
1. Visual Studio stops at a breakpoint.

   :::image type="content" source="./media/debug-experimental-instance.png" alt-text="Screenshot showing Visual Studio debugging an extension." lightbox="./media/debug-experimental-instance.png":::

> [!TIP]
> It can be convenient to have multiple monitors, so you can see both the debugger and the experimental instance at the same time on two different monitors. You might want to change the theme in the Experimental Instance to make it more obvious which IDE you're working with at any given time. See [Change fonts, colors, and themes in Visual Studio ↗](../../../ide/how-to-change-fonts-and-colors-in-visual-studio.md).


:::moniker range="visualstudio"
## Start or reset the experimental instance

You can reset or start the experimental instance by using the shortcuts `ResetExperimental` and `StartExperimental` in the VSSDK folder (under your Visual Studio installation folder).

In Visual Studio 2026 and later, you can also use commands on the **Extensions** > **Extension Development** menu to start or reset the experimental instance.

:::image type="content" source="../../media/visualstudio/start-reset-experimental-instance.png" alt-text="Menu commands to reset or start the experimental instance of Visual Studio.":::

:::moniker-end

## Troubleshooting

When starting the debugger, if you see the error **This extension is not supported on the current product**, open the `.vsixmanifest` file, and check the `InstallationTarget` element. The installation target `Microsoft.VisualStudio.IntegratedShell` is not supported; use `Microsoft.VisualStudio.Community` instead. See [VSIX Extension Schema 2.0 Reference ↗](../../vsix-extension-schema-2-0-reference.md#installation-element).

## Use the Diagnostics Explorer

Starting with Visual Studio 18.9, the VisualStudio.Extensibility Diagnostics Explorer is a built-in Visual Studio feature (replacing the earlier standalone diagnostic extension). Enable it via **Tools > Options > Environment > Preview Features** by searching for `VisualStudio.Extensibility Diagnostics`.

The Diagnostics Explorer shows real-time information about loaded extensions: status, communication channels, error logs, and service availability. This is useful for troubleshooting extension loading issues and debugging communication problems in out-of-process extensions.

> [!NOTE]
> The standalone VisualStudio.Extensibility Diagnostics extension is no longer supported after 18.9. Use the built-in feature instead.

## Related content

- [Learn more about debugging ↗](/visualstudio/debugger/debugger-feature-tour)
- [Learn more about extensions](../overview/what-is-vs-extensibility.md)
