---
title: "Send command-line arguments while debugging (C++)"
description: Learn how to send command-line argument to a debuggee using the new command line arguments dropdown.
ms.date: "10/25/2024"
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

In Visual C++, you can use the command-line arguments dropdown to quickly specify or use previously specified command-line arguments to pass to the app you are debugging. This feature is available in Visual Studio 2022 version 17.12 and later.

## Prerequisites

- Visual Studio 2022 version 17.12 or later.
- Visual Studio Tools for Unreal Engine. See [Install Visual Studio Tools for Unreal Engine](../../gamedev/unreal/get-started/vs-tools-unreal-install.md#install-visual-studio-tools-for-unreal-engine-1) for installation instructions.

## Specify command-line arguments

The command-line arguments dropdown is available in the **Standard** toolbar. If the **Standard** toolbar isn't visible, from the Visual Studio main menu choose **Tools** > **Customize**. In the **Customize** dialog, choose **Toolbars** and then select **Standard**.

:::image type="complex" source="../media/select-standard-toolbar.png" alt-text="A screenshot of the Customize dialog.":::
The Toolbars tab is selected in the Customize dialog. The entry for Standard, meaning the standard toolbar, is selected.
:::image-end:::

The command-line arguments dropdown is shown following the Solutions Platforms dropdown on the Standard toolbar. The dropdown is empty. A tooltip reads, "empty".

:::image type="complex" source="../media/command-line-argument-dropdown-empty.png" alt-text="A screenshot of the command-line arguments dropdown.":::
The command-line arg dropdown is shown following the Solutions Platforms dropdown on the Standard toolbar. The dropdown is empty. A tooltip reads, "empty".
:::image-end:::

It is currently empty. The tooltip reads, "empty", but when you add command-line arguments, the tooltip will show the selected argument list and expand it so that you can see all of the arguments.

To add command-line arguments, type them in the dropdown and press Enter. The arguments will be saved in the order that you enter them and appear in the dropdown for future use. There is a limit of 5 arguments lists that you can add before the oldest one is removed and the new one added.

In this example, the command-line argument `-arg1` is added to the dropdown:

:::image type="content" source="../media/command-line-argument-dropdown-arg1.png" alt-text="A screenshot of the command-line args dropdown. It contains the value -arg1.":::

Adding another argument, `-arg2`, results in the following:

::image type="content" source="../media/command-line-argument-dropdown-arg1-arg2.png" alt-text="A screenshot of the command-line args dropdown. It contains the value -arg1 -arg2.":::

You can use the dropdown to select previously specified command-line arguments to pass to the app you are debugging. Consider the following code:

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

In this example, the `-arg1 -arg2` arguments are selected:

:::image type="content" source="../media/command-line-argument-dropdown-selected-args.png" alt-text="A screenshot of the command-line args dropdown. The entry for `-arg1 -arg2` is selected.":::

Which results in this output when the app is run:

```output
Argument 1: -arg1
Argument 2: -arg2
```

The command-line arguments dropdown is a convenient way to specify and reuse command-line arguments while debugging your app, particularly when you rotate between different sets of arguments depending on the scenario you are testing.

Another useful feature is that you can click in the command-line arguments dropdown and press Ctrl+C to select the command-line that is currently selected so that you can copy them to the clipboard if desired.

## Relationship to project settings

The other way to specify command-line arguments is through the project settings. If you right-click the project in the **Solution Explorer** and choose **Properties**, you can specify command-line arguments in the **Debugging** > **Command Arguments** section.

:::image type="complex" source="../media/debugging-property-page-command-args.png" alt-text="A screenshot of the project property pages debugging options.":::
The Command Arguments entry is shown and it has the same arguments as the command-line arguments dropdown: -arg1 -arg2.
:::image-end:::

Command-line arguments specified in the project settings override the command-line arguments specified in the command-line arguments dropdown. If you make a change here, they are added to the top of the list of command-line arguments specified in the dropdown.

Conversely, if you select arguments in the command-line arguments dropdown, they will become the arguments specified in the project settings. Either way you specify the arguments, they are kept in sync. And both are saved with the project settings, so they are available when you reopen the project.

## Related content

- [Project Settings for a C++ Debug Configuration](../debugger/project-settings-for-a-cpp-debug-configuration.md)