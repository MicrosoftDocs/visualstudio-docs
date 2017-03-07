---
title: "Refactoring Code in Python Tools for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "3/7/2017"
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "devlang-python"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 76ebcb29-72d1-4958-9a63-8984c03d5c22
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
translation.priority.ht:
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---

# Refactoring Python code

Python Tools for Visual Studio (PTVS) provides several commands for automatically transforming and cleaning up your source code:

- [Rename](#rename) renames a selected class, method, or variable name
- [Extract method](#extract-method) creates a new method from the selected code
- [Add import](#add-import) provides a smart tag to add a missing import
- [Remove unused imports](#remove-imports) removes unused imports

<a name="rename-variable"</a>
## Rename

1. Right-click the identifier you wish to rename and select **Rename**, or place the caret in that identifier and select the **Edit > Refactor > Rename...** menu command or press F2.
1. In the **Rename** dialog that appears, enter the new name for the identifier and select **OK**:

  ![Rename prompt for new identifer name](media/code-refactor-rename-1.png)

1. In the next dialog, select the files and instances in your code to which to apply the renaming; select any individual instance to preview the specific change:

  ![Rename dialog to select where to apply the changes](media/code-refactor-rename-2.png)

1. Select **Apply** to make the changes to your source code files. This is an undoable action.

## Extract method

1. Select the lines of code or the expression to extract to a separate method.
1. Select the **Edit > Refactor > Extract method...** menu command or type Ctrl-R,M.
1. In the dialog that appears, enter a new method name, indicate where to extract it to, and select any closure variables. Variables not selected for closure are turned into method arguments:

  ![Extract method dialog](media/code-refactor-extract-method-1.png)

1. Select **OK** and the code is modified accordingly:

  ![Effect of extracting a method](media/code-refactor-extract-method-2.png)

## Add import

When your place the caret on an identifier that lacks type information, PTVS provides a smart tag (the lightbulb icon to the left of the code) whose commands will add the necessary `import` or `from ... import` statement:

![Add import smart tag](media/code-refactor-add-import-1.png)

`import` completions are offered for top-level packages and modules in the current project and the standard library; `from ... import` completions will be offered for sub-modules and sub-packages as well as module members. This includes functions, classes, or exported data. Selecting either option adds the statement to at the top of the file after other imports, or into an existing `from ... import` statement if the same module is already imported.

![Result of adding an import](media/code-refactor-add-import-2.png)

PTVS attempts to filter out members that aren't really defined in a module, such as modules that are imported into another but aren't children of the module doing the importing. For example, many modules use `import sys` rather than `from xyz import sys`, so PTVS doesn't offer a completion for importing `sys` from other modules even if the modules are missing an `__all__` member that excludes `sys`.

Similarly, PTVS filters functions that are imported from other modules or from the built-in namespace. For example if a module imports the `settrace` function from the `sys` module, then in theory you could import it from that module. But it's best to use `import settrace from sys` directly, and so PTVS offers that statement specifically.

Finally if something would be excluded due to the rules above but has other values that would be included (because the name was assigned a value in the module, for example), PTVS still excludes the import. This assumes that the value shouldn't be exported because it is defined in another module, and thus the additional assignment is likely to be a dummy value which is also not exported.

<a name="remove-imports"</a>
## Remove unused imports

When writing code, it's easy to end up with `import` statements for modules that aren't being used at all. Because PTVS analyzes your code, it can automatically determine whether an `import` statement is needed by looking at whether the imported name is used within the scope below where the statement occurs.

Right-click anywhere in the editor and select **Remove Imports**, which gives you options to remove from **All Scopes** or just the **Current Scope**:

![Remove imports menu](media/code-refactor-remove-imports-1.png)

PTVS will then make the appropriate changes to the code:

![Effect of removing imports](media/code-refactor-remove-imports-2.png)

Note that PTVS does not account for control flow; using a name before an `import` statement will be treated as if the name was in fact used. PTVS also ignores all `from __future__` imports, imports that are performed inside of a class definition, as well from `from ... import *` statements.