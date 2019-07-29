---
title: "Refresh an app (JavaScript) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "JavaScript debugging, refreshing pages [Windows Store apps]"
  - "debugging, refreshing pages [Windows Store apps]"
  - "DOM Explorer, Refresh [Windows Store apps]"
  - "Refresh [Windows Store apps]"
ms.assetid: fd99ee60-fa94-46df-8b17-369f60bfd908
caps.latest.revision: 23
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Refresh an app (JavaScript)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Applies to Windows and Windows Phone](../Image/windows_and_phone_content.png "windows_and_phone_content")  
  
 You can make changes to your code while you're debugging, and then refresh a Store app using JavaScript by choosing the **Refresh Windows app** button on the **Debug** toolbar. Choosing this button reloads the app without stopping and restarting the debugger. The Refresh feature enables you to modify HTML, CSS, and JavaScript code and quickly see the result. This feature is supported for both Windows Store and Windows Phone Store apps.  
  
 Refresh doesn't maintain your app state or reflect the following changes to your app:  
  
- Package manifest file changes, including changes to images specified in the package manifest.  
  
- Reference changes, such as adding or removing an SDK reference, or changes to Windows Runtime Components (.winmd files).  
  
- Resource changes, such as changes to strings in .resjson files.  
  
- Project file changes that result in path name changes, new project files, or deleted files.  
  
- Project and item property changes, such as changes to the selected debugging device, or changes to the package action for a file (in the Properties window).  
  
> [!IMPORTANT]
> When you change references, change the package manifest, or make other changes specified in the preceding list, you have to stop and restart the debugger to update HTML, CSS, and JavaScript source files.  
  
### To refresh an app  
  
1. In Visual Studio, create a new project by using the Navigation App project template.  
  
     This can be Windows Store app, Windows Phone Store app, or a universal app.  
  
2. With the template open in Visual Studio, select a debug target.  
  
     If a Windows Phone project is your current startup project, select a Windows Phone emulator for the debug target. Otherwise, select **Simulator** or **Local Machine**.  
  
     ![Select debug target list](../debugger/media/js-select-target.png "JS_Select_Target")  
  
3. Press F5 to run the app in debug mode.  
  
4. Switch to Visual Studio. (Press F12.)  
  
5. In **Solution Explorer**, in the **pages** > **home** folder, open home.html.  
  
6. Change the page title text from  
  
    ```html  
    Welcome to yourAppName!  
    ```  
  
     to something else, like this:  
  
    ```html  
    Hello!  
    ```  
  
7. Click the **Refresh Windows app** button, which looks like this: ![Refresh Windows app button](../debugger/media/js-refresh.png "JS_Refresh"). (Or press F4.)  
  
8. Switch to the app. The app is reloaded without the debugger restarting, and the new page title appears.  
  
## See Also  
 [Quickstart: Debug HTML and CSS](../debugger/quickstart-debug-html-and-css.md)
