---
title: "Refresh a UWP app | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "JavaScript debugging, refreshing pages [UWP apps]"
  - "debugging, refreshing pages [UWP apps]"
  - "DOM Explorer, Refresh [UWP apps]"
  - "Refresh [UWP apps]"
ms.assetid: fd99ee60-fa94-46df-8b17-369f60bfd908
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: vs-2017
ms.workload:
  - "uwp"
---
# Refresh a UWP app in Visual Studio

 You can make changes to your code while you're debugging, and then refresh a UWP app using JavaScript by choosing the **Refresh Windows app** button on the **Debug** toolbar. Choosing this button reloads the app without stopping and restarting the debugger. The Refresh feature enables you to modify HTML, CSS, and JavaScript code and quickly see the result. This feature is supported for UWP apps.

 Refresh doesn't maintain your app state or reflect the following changes to your app:

- Package manifest file changes, including changes to images specified in the package manifest.

- Reference changes, such as adding or removing an SDK reference, or changes to Windows Runtime Components (.winmd files).

- Resource changes, such as changes to strings in .resjson files.

- Project file changes that result in path name changes, new project files, or deleted files.

- Project and item property changes, such as changes to the selected debugging device, or changes to the package action for a file (in the Properties window).

> [!IMPORTANT]
> When you change references, change the package manifest, or make other changes specified in the preceding list, you have to stop and restart the debugger to update HTML, CSS, and JavaScript source files.

### To refresh an app

1. With your UWP project open in Visual Studio, select **Local Machine** as the debug target.

     ![Select debug target list](../debugger/media/js_select_target.png "JS_Select_Target")

3. Press F5 to run the app in debug mode.

4. Switch to Visual Studio.

5. In the home page of your UWP app, edit some of the HTML.

7. Click the **Refresh Windows app** button, which looks like this: ![Refresh Windows app button](../debugger/media/js_refresh.png "JS_Refresh"). (Or press F4.)

8. Switch to the app. The app is reloaded and the updated HTML is used to render the app.

## See also
- [Quickstart: Debug HTML and CSS](../debugger/quickstart-debug-html-and-css.md)