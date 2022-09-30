---
title: Options, Text Editor, JavaScript, Linting
description: Learn how to use the Linting page of the Options dialog box to set options for analyzing code in the Code Editor.
ms.custom: SEO-VS-2020
ms.date: 30/9/2022
ms.technology: vs-javascript
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Text_Editor.JavaScript.Linting.General"
  - "VS.ToolsOptionsPages.Text_Editor.JavaScript.Linting"
  - "VS.ToolsOptionsPages.Text_Editor.TypeScript.Linting.General"
  - "VS.ToolsOptionsPages.Text_Editor.TypeScript.Linting"
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.workload:
  - "multiple"
---
# Options dialog box: Text Editor \> JavaScript/TypeScript \> Linting

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Use the **Linting** page of the **Options** dialog box to set options for analyzing code in the Code Editor (note that you can override these options in some project types, like the [standalone React project templates](../../javascript/tutorial-create-react-app.md)). To access this page, on the menu bar, choose **Tools** > **Options**, and then expand **Text Editor** > **JavaScript/TypeScript** > **Linting**.

## ESLint Settings

These options let you enable static JavaScript and TypeSCript code analysis, and choose which files are analyzed. For more information about ESLint, see [ESLint.org](https://eslint.org/).

### UIElement list

|Option|Description|
|------------|-----------------|
|**Enable ESLint**|When this option is selected, the Code Editor allows for static analysis on the code.|
|**Lint *file extension* files**|These options allow you to configure which file extensions should be linted. For example, if "Lint TypeScript files" is selected, then documents with a *.ts* file extension will be linted.|

## See also

- [Linting JavaScript in Visual Studio](../../javascript/linting-javascript.md)
- [General, Environment, Options Dialog Box](../../ide/reference/general-environment-options-dialog-box.md)
