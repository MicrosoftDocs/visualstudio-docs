---
title: Options, Text Editor, F#, Code Fixes
description: Learn how to use the Code Fixes page in the F# section to specify the settings that can help identify code errors and offer solutions.
ms.date: 01/16/2019
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Text_Editor.F%2523.Code_Fixes"
ms.custom: "ide-ref"
author:anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Options: Text Editor > F# > Code Fixes

Use the Code Fixes options page to specify the settings that can help identify code errors and offer solutions. To access this options page, choose **Tools** > **Options**, and then choose **Text Editor** > **F#** > **Code Fixes**.

## Code Fixes

- **Simplify names (remove unnecessary qualifiers)**

  If this check box is selected, fully qualified names are simplified when the qualifications aren't necessary, such as for a member of a frequently used namespace.

- **Always place open statements at the top level**

  If this check box is selected and you type an `open` statement in the code, it's put at the top level.

- **Remove unused open statements**

  If this check box is selected, documents are analyzed for unused `open` statements, and a [Quick Action](../quick-actions.md) light bulb appears with an action to remove all unused `open` statements.

- **Analyze and suggest fixes for unused values**

  If this check box is selected, the tool recognizes a value that isn't being used in the code. Then, if you hover over the unused value, it recommends ways in which you can use the value.

## See also

- [General, Environment, Options Dialog Box](../../ide/reference/general-environment-options-dialog-box.md)
- [Find code changes and other history with CodeLens](../../ide/find-code-changes-and-other-history-with-codelens.md)
