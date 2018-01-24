---
title: "Options, Text Editor, C/C++, Experimental | Microsoft Docs"
ms.custom: ""
ms.date: "08/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VS.ToolsOptionsPages.Text_Editor.C/C++.Experimental"
  - "VS.ToolsOptionsPages.Text_Editor.C%2FC%2B%2B.Experimental"
  - "VS.ToolsOptionsPages.Text_Editor.C\\C++.Experimental"
caps.latest.revision: 10
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.technology: 
  - "vs-ide-general"
ms.workload: 
  - "cplusplus"
---
# Options, Text Editor, C/C++, Experimental

By changing these options, you can change the behavior related to IntelliSense and the browsing database when you're programming in C or C++. These features are truly experimental, and may be modified or removed from Visual Studio in a future release. This topic describes the options in Visual Studio 2017. For Visual Studio 2015, see [Options, Text Editor, C/C++, Experimental](https://msdn.microsoft.com/library/mt591979.aspx)

To access this property page, press **Control + Q** to activate `Quick Launch` and then type "experimental". Quick Launch will find the page after the first few letters. You can also get to it by choosing **Tools | Options** and expanding **Text Editor**, then **C/C++**, and then choosing **Experimental**.

These features are available in a Visual Studio 2017 installation.

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. See [Personalize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md).

## Enable Predictive Intellisense

Predictive IntelliSense limits the number of results displayed in the IntelliSense dropdown list so that you see only results that are relevant in the context. For example, if you type <code>int x =</code> and invoke the IntelliSense dropdown, you will see only integers or functions that return integers. Predictive IntelliSense is turned off by default.

## Enable Faster Project Load

**Visual Studio 2017 version 15.3 and later**: This feature is now called **Enable Project Caching** and has moved to the [VC++ Project Settings](vcpp-project-settings-projects-and-solutions-options-dialog-box.md) property page.
This option enables Visual Studio to cache project data so that when you open the project the next time, it can load that cached data rather than re-computing it from the project files. Using cached data can speed up the project load time significantly.

## Additional Features in the Visual Studio Marketplace

You can browse additional text editor features in the [Visual Studio Marketplace](https://marketplace.visualstudio.com/search?target=VS&category=Tools&vsVersion=&subCategory=All&sortBy=Downloads). An example is [C++ Quick Fixes](https://marketplace.visualstudio.com/items?itemName=VisualCPPTeam.CQuickFixes2017), which supports the following:

- **Add missing #include** - Suggests relevant #include's for unknown symbols in your code

- **Add using namespace/Fully qualify symbol** - Like the previous item, but for namespaces

- **Add missing semicolon**

- **Online help** - Search online help for your error messages

- And more...

## See also

[Setting Language-Specific Editor Options](../../ide/reference/setting-language-specific-editor-options.md)  
[Refactoring in C++ (VC Blog)](http://blogs.msdn.com/b/vcblog/archive/2014/11/14/all-about-c-refactoring-in-visual-studio-2015-preview.aspx)
