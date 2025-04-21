---
title: Options, Text Editor, JavaScript, Project
description: Learn how to use the Project page of the Options dialog box to specify JavaScript and TypeScript project options in the Code Editor.
ms.date: 06/19/2020
ms.subservice: javascript-typescript
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Text_Editor.JavaScript.Project.General"
  - "VS.ToolsOptionsPages.Text_Editor.JavaScript.Project"
  - "VS.ToolsOptionsPages.Text_Editor.TypeScript.Project.General"
  - "VS.ToolsOptionsPages.Text_Editor.TypeScript.Project"
ms.custom: "ide-ref"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
---
# Options, Text Editor, JavaScript, Project

Use the **Project** page of the **Options** dialog box to specify JavaScript and TypeScript project options in the Code Editor. To access this page, on the menu bar, choose **Tools** > **Options**, and then expand **Text Editor** > **JavaScript/TypeScript** > **Project**.

## Project Analysis Options

These options determine how the editor analyzes projects, reports diagnostics, and suggests improvements. Select or clear the options to specify how the editor handles these situations.

### UIElement list

- **Only analyze projects which contain files opened in the editor**
- **Only report diagnostics for files opened in the editor**
- **Suggest possible improvements that are not corrections**

## Virtual Projects in Solution Explorer

These options let you choose whether to display Virtual Projects when a Solution is either loaded or not loaded.

## Compile on Save

These options determine whether TypeScript files that aren't part of the project are automatically compiled. Visual Studio compiles using the latest version of TypeScript installed in *C:\Program Files (x86)\Microsoft SDKs\TypeScript*.

Select the check box and then choose the type of code generation to use.

### UIElement list

- **Use AMD code generation for modules that are not part of a project**
- **Use CommonJS code generation for modules that are not part of a project**
- **Use UMD code generation for modules that are not part of a project**
- **Use System code generation for modules that are not part of a project**
- **Use ES2015 code generation for modules that are not part of a project**

## ECMAScript version for files that are not part of a project

These options lets you select the ECMAScript version for files that aren't part of a project. You can choose between **ECMAScript 3**, **ECMAScript 5**, or **ECMAScript 6**.

## JSX Emit for TSX files that are not part of a project

These options determine how the editor treats TypeScript files that aren't part of a project.

### UIElement list

|Option|Description|
|------------|-----------------|
|**React Framework**|When this option is selected, the Code Editor emits a *.js* file extension.|
|**Preserve**|When this option is selected, the Code Editor keeps the JSX as part of the output and emits a *.jsx* file extension.|

## See also

- [General, Environment, Options Dialog Box](../../ide/reference/general-environment-options-dialog-box.md)