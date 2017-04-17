---
title: "Options, Text Editor, C/C++, Experimental | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VS.ToolsOptionsPages.Text_Editor.C/C++.Experimental"
  - "VS.ToolsOptionsPages.Text_Editor.C%2FC%2B%2B.Experimental"
  - "VS.ToolsOptionsPages.Text_Editor.C\\C++.Experimental"
ms.assetid: b9e9dda2-350c-460d-b368-37d6c5342eee
caps.latest.revision: 10
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Options, Text Editor, C/C++, Experimental
By changing these options, you can change the behavior related to IntelliSense and the browsing database when you're programming in C or C++. These features are truly experimental, and may be modified or removed from Visual Studio in a future release. This topic describes the options in Visual Studio 2017. For Visual Studio 2015, see [Options, Text Editor, C/C++, Experimental](https://msdn.microsoft.com/library/mt591979.aspx) 
  
 To access this property page, press **Control + Q** to activate `Quick Launch` and then type "experimental". Quick Launch will find the page after the first few letters. You can also get to it by choosing **Tools | Options** and expanding **Text Editor**, then **C/C++**, and then choosing **Experimental**.  

 These features are available in a Visual Studio 2017 installation.  
  
> [!NOTE]
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. See [Customizing Development Settings in Visual Studio](http://msdn.microsoft.com/en-us/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
## Enable Predictive Intellisense
Predictive IntelliSense limits the number of results displayed in the IntelliSense dropdown list so that you see only results that are relevant in the context. For example, if you type <code>int x =</code> and invoke the IntelliSense dropdown, you will see only integers or functions that return integers. Predictive IntelliSense is turned off by default.

## Enable Faster Project Load
This option enables Visual Studio to cache project data so that when you open the project the next time, it can load that cached data rather than re-computing it from the project files. Using cached data can speed up the project load time significantly.  

## Additional Features in the Visual Studio Gallery
For additional text editor features in the Visual Studio Gallery, see the list [here](http://go.microsoft.com/fwlink/?LinkId=692016). An example is [C++ Quick Fixes](https://visualstudiogallery.msdn.microsoft.com/be91feef-8dc3-4f7a-ac9f-f34e7ca5918f), which supports the following:  
  
-   **Add missing #include** - Suggests relevant #include's for unknown symbols in your code  
  
-   **Add using namespace/Fully qualify symbol** - Like the previous item, but for namespaces  
  
-   **Add missing semicolon**  
  
-   **MSDN Help** - Search MSDN for your error messages  
  
 You can either hover over a squiggle to get a light bulb, or use the default keyboard shortcut Ctrl+Dot (Ctrl+.). Note that for the keyboard shortcut, your caret doesn't need to be positioned on the specific error or token; you can simply be on the same line as the error to invoke suggestions for anything on that line.  
  
## See Also  
 [Setting Language-Specific Editor Options](../../ide/reference/setting-language-specific-editor-options.md)   
 [Refactoring in C++ (VC Blog)](http://blogs.msdn.com/b/vcblog/archive/2014/11/14/all-about-c-refactoring-in-visual-studio-2015-preview.aspx)
