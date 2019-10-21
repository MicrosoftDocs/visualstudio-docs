---
title: "Options, Text Editor, JavaScript, IntelliSense | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Text_Editor.JavaScript.Intellisense.References"
  - "VS.ToolsOptionsPages.Text_Editor.JavaScript.Intellisense.General"
ms.assetid: b4a9816d-cf87-4dc6-a8d4-1591d6a48103
caps.latest.revision: 24
author: jillre
ms.author: jillfra
manager: jillfra
---
# Options, Text Editor, JavaScript, IntelliSense
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Use the **IntelliSense** page of the **Options** dialog box to modify settings that affect the behavior of IntelliSense for JavaScript. You can access the **IntelliSense** page by choosing **Tools**, **Options** on the  menu bar, and then expanding **Text Editor**, **JavaScript**, **IntelliSense.**

 [!INCLUDE[note_settings_general](../../includes/note-settings-general-md.md)]

 The **IntelliSense** page contains the following sections:

## Validation
 You can use these options to set preferences for how the JavaScript editor validates syntax in your document.

## UIElement List
 **Show syntax errors**
 When this check box is not selected, the JavaScript code editor does not show syntax errors. This is useful if you are working with code that you didn't write and you don't intend to fix syntax errors.

 When this check box is selected, you have the option to select the **Show errors as warning** check box.

 **Show errors as warnings**
 When this check box is selected, JavaScript errors are shown as warnings instead of errors in the error list.

 **Download remote references (e.g. http://) for files in the miscellaneous files project**
 When this check box is selected, and if you have a JavaScript file opened outside the context of a project, Visual Studio will download remote JavaScript files referenced in the file for the purpose of providing IntelliSense information. If this option is selected, files will download when you include them as a reference in your JavaScript file.

> [!NOTE]
> For Web projects, remote files referenced in your project are downloaded by default.

## Statement Completion
 You can use these options to change the behavior of IntelliSense statement completion.

## UIElement List
 **Only use tab or enter to commit**
 When this check box is selected, the JavaScript code editor appends statements with items selected in the completion list only after you choose the Tab or Enter key. When this check box is not selected, other characters, such as a period, comma, colon, open parenthesis, and open brace ({), can also append statements with the selected items.

## References
 You can use these options to specify the types of IntelliSense .js files that are in scope for different JavaScript project types. The IntelliSense references are typically used to provide IntelliSense support for global objects. You can also use this page to set the loading order for scripts that must be loaded at run time, and to add IntelliSense extension files.

## UIElement List
 **Reference groups**
 This option specifies the reference group type. Three reference groups are supported:

 You can use pre-defined reference groups to specify that particular IntelliSense .js files are in scope for different JavaScript projects. Four reference groups are available:

- Implicit (Windows *version*), for [!INCLUDE[win8_appname_long](../../includes/win8-appname-long-md.md)] apps using JavaScript. Files included in this group are in scope for every .js file opened in the Code Editor for [!INCLUDE[win8_appname_long](../../includes/win8-appname-long-md.md)] apps using JavaScript.

- Implicit (Web), for HTML5 projects. Files included in this group are in scope for every .js file opened in the Code Editor for these project types.

- Dedicated worker reference groups, for HTML5 Web Workers. Files specified in this group are in scope for .js files that have an explicit reference to a dedicated worker reference group.

- Generic, for other JavaScript project types.

  **Included files**
  This option specifies the order in which files are loaded into the context of the language service. You can configure the order by using the **Remove**, **Move Up**, and **Move Down** buttons. For IntelliSense to work correctly, a file that is dependent on another must be loaded after the other file.

> [!CAUTION]
> If an object is defined unconditionally in two or more implicit references, the last reference in this list will be used to define the object.

 **Add a reference to the group**
 This option provides a way to add additional IntelliSense .js files by browsing to the appropriate files.

## See Also
 [JavaScript IntelliSense](../../ide/javascript-intellisense.md)
