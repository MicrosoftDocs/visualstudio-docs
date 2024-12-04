---
title: "Pass command-line arguments while debugging (C++)"
description: Learn how to send command-line argument to a debuggee using the new command line arguments dropdown.
ms.date: 11/6/2024
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "command-line argument [C++]"
  - "debugging [C++], enabling debug features"
author: "TylerMSFT"
ms.author: "TWhitney"
manager: coxford
ms.subservice: debug-diagnostics
---
# Pass command-line arguments while debugging (C++)

In Visual C++, use the command-line arguments dropdown to quickly specify or reuse command-line arguments while debugging.

## Prerequisites

- Visual Studio 2022 version 17.12 preview 5 or later.
- Visual Studio Tools for Unreal Engine. See [Install Visual Studio Tools for Unreal Engine](/visualstudio/gamedev/unreal/get-started/vs-tools-unreal-install)) for installation instructions.

## Specify command-line arguments

The command-line arguments dropdown is available in the **Standard** toolbar. If the **Standard** toolbar isn't visible, from the Visual Studio main menu choose **Tools** > **Customize**. In the **Customize** dialog, choose **Toolbars**. Then select **Standard**.

:::image type="complex" source="./media/select-standard-toolbar.png" alt-text="A screenshot of the Customize dialog.":::
The Toolbars tab is selected in the Customize dialog. The entry for Standard, meaning the standard toolbar, is selected.
:::image-end:::

The command-line arguments dropdown follows the **Solutions Platforms** dropdown on the **Standard** toolbar. If no arguments have been specified, the dropdown is empty and the tooltip displays "empty".

:::image type="complex" source="./media/command-line-argument-dropdown-empty.png" alt-text="A screenshot of the command-line arguments dropdown.":::
The command-line arg dropdown is shown following the Solutions Platforms dropdown on the Standard toolbar. The dropdown is empty. A tooltip reads, "empty".
:::image-end:::

When you add command-line arguments, the tooltip shows the selected argument list so that you can see all of the arguments.

To add command-line arguments, type them in the dropdown and press **Enter**. The arguments are saved in the order that you enter them and appear in the dropdown for future use. There's a limit of five command lines that you can add before the oldest one is removed to make room for a new one.

In this example, the command-line argument `-arg1` is added to the dropdown:

:::image type="content" source="./media/command-line-argument-dropdown-arg1.png" alt-text="A screenshot of the command-line args dropdown. It contains the value -arg1.":::

Adding another argument, `-arg2`, results in:

:::image type="content" source="./media/command-line-argument-dropdown-arg1-arg2.png" alt-text="A screenshot of the command-line args dropdown. It contains the value -arg1 -arg2.":::

You can use the dropdown to select previously specified command-line arguments to pass to the app you're debugging. Consider the following code:

```cpp
#include <iostream>

int main(int argc, char* argv[]) 
{
    for (int i = 1; i < argc; ++i) // argv[0] is the path of the running program
    {
        std::cout << "Argument " << i << ": " << argv[i] << std::endl;
    }
    return 0;
}
```

In this example, the `-arg1 -arg2` arguments are selected in the command-line arguments dropdown:

:::image type="content" source="./media/command-line-argument-dropdown-selected-args.png" alt-text="A screenshot of the command-line args dropdown. The entry for `-arg1 -arg2` is selected.":::

Which results in this output when the app is run:

```output
Argument 1: -arg1
Argument 2: -arg2
```

The command-line arguments dropdown is a convenient way to specify and reuse command-line arguments. Particularly when you need to quickly switch between different arguments for different scenarios you're testing.

You can also click in the command-line arguments dropdown and press **Ctrl+C** to copy the highlighted command-line to the clipboard.

## Relationship to project settings

Another way to specify command-line arguments is in project settings.

If you right-click the project in the **Solution Explorer** and choose **Properties**, you can specify command-line arguments in **Debugging** > **Command Arguments**.

:::image type="complex" source="./media/debugging-property-page-command-args.png" alt-text="A screenshot of the project property pages debugging options.":::
The Command Arguments entry is shown and it has the same arguments as the command-line arguments dropdown: -arg1 -arg2.
:::image-end:::

Command-line arguments specified in the project settings are added to the command-line arguments dropdown. Conversely, if you select arguments in the command-line arguments dropdown, they replace the arguments specified in the project settings. Either way you specify the arguments, they're kept in sync. Both are saved with the project settings, so they're available when you reopen the project.

## Related content

- [Project Settings for a C++ Debug Configuration](../debugger/project-settings-for-a-cpp-debug-configuration.md)