---
title: Options, Text Editor, C/C++, Experimental
ms.date: 08/02/2017
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Text_Editor.C/C++.Experimental"
  - "VS.ToolsOptionsPages.Text_Editor.C%2FC%2B%2B.Experimental"
  - "VS.ToolsOptionsPages.Text_Editor.C\\C++.Experimental"
author: mikeblome
ms.author: mblome
manager: markl
ms.workload:
  - "cplusplus"
---
# Options, Text Editor, C/C++, Experimental

By changing these options, you can change the behavior related to IntelliSense and the browsing database when you're programming in C or C++. These features are truly experimental and may be modified or removed from Visual Studio in a future release.

::: moniker range="vs-2017"

This article describes the options in Visual Studio 2017. For Visual Studio 2015, select **2015** in the selector above the table of contents.

::: moniker-end

To access this property page, press **Ctrl**+**Q** to activate the search box and then type **experimental**. Search finds the page after the first few letters. You can also get to it by choosing **Tools** > **Options** and expanding **Text Editor**, then **C/C++**, and then choosing **Experimental**.

These features are available in a Visual Studio installation.

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. See [Personalize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md).

## Enable Predictive IntelliSense

Predictive IntelliSense limits the number of results displayed in the IntelliSense dropdown list so that you see only results that are relevant in the context. For example, if you type `int x =` and invoke the IntelliSense dropdown, you will see only integers or functions that return integers. Predictive IntelliSense is turned off by default.

::: moniker range="vs-2017"

## Enable faster project load

As of Visual Studio 2017 version 15.3, this feature is called **Enable Project Caching** and has moved to the [VC++ Project Settings](vcpp-project-settings-projects-and-solutions-options-dialog-box.md) property page.

This option enables Visual Studio to cache project data so that when you open the project the next time, it can load that cached data rather than re-computing it from the project files. Using cached data can speed up the project load time significantly.

::: moniker-end

## Additional features in the Visual Studio Marketplace

You can browse additional text editor features in the [Visual Studio Marketplace](https://marketplace.visualstudio.com/search?target=VS&category=Tools&vsVersion=&subCategory=All&sortBy=Downloads). An example is [C++ Quick Fixes](https://marketplace.visualstudio.com/items?itemName=VisualCppDevLabs.CQuickFixes2017), which supports the following:

- **Add missing #include** - Suggests relevant #include's for unknown symbols in your code

- **Add using namespace/Fully qualify symbol** - Like the previous item, but for namespaces

- **Add missing semicolon**

- **Online help** - Search online help for your error messages

- And more...

## See also

- [Setting Language-Specific Editor Options](../../ide/reference/setting-language-specific-editor-options.md)
- [Refactoring in C++ (VC Blog)](https://devblogs.microsoft.com/cppblog/all-about-c-refactoring-in-visual-studio-2015-preview/
)
