---
title: Edit Python code and use Intellisense
description: Develop Python applications in Visual Studio and access rich IntelliSense, code snippets, and navigation features. Apply formatting, linting, and refactoring to clean and maintain your code.
ms.date: 04/18/2024
ms.topic: how-to
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

# CustomerIntent: As a developer, I want to build Python applications in Visual Studio so that I can access rich features to help me write and maintain my code.
---

# Edit Python code and use Intellisense

Because you spend much of your development time in the code editor, [Python support in Visual Studio](installing-python-support-in-visual-studio.md) provides functionality to help you be more productive. Features include IntelliSense syntax highlighting, autocompletion, signature help, method overrides, search, and navigation.

The code editor is integrated with the **Interactive** window in Visual Studio. As you work, it's easy to exchange code between the two windows. For more information, see [Tutorial Step 3: Use the Interactive REPL window](tutorial-working-with-python-in-visual-studio-step-03-interactive-repl.md) and [Use the Interactive window - Send to Interactive command](python-interactive-repl-in-visual-studio.md#send-code-to-interactive-window).

[Outlining](../ide/outlining.md) helps you stay focused on particular sections of your code. For general documentation on editing code in Visual Studio, see [Features of the code editor](../ide/writing-code-in-the-code-and-text-editor.md). 

The Visual Studio **Object Browser** lets you inspect Python classes defined in each module and the functions defined in those classes. You can access this feature on the **View** menu or by using the keyboard shortcut **Ctrl**+**Alt**+**J**.

## Use IntelliSense features

IntelliSense provides [completions](#completions), [signature help](#signature-help), [quick info](#quick-info), and [code coloring](#code-coloring). Visual Studio 2017 versions 15.7 and later also support [type hints](#type-hints).

To improve performance, IntelliSense in Visual Studio 2017 version 15.5 and earlier depends on a completion database generated for each Python environment in your project. You might need to refresh your database if you add, remove, or update packages. Database status is shown in the **Python Environments** window (a companion of **Solution Explorer**) on the **IntelliSense** tab. For more information, see [Environments window reference](python-environments-window-tab-reference.md).

Visual Studio 2017 version 15.6 and later uses a different means to provide IntelliSense completions that aren't dependent on the database.

### Completions

Completions appear as statements, identifiers, and other words that can be appropriately entered at the current location in the editor. Intellisense populates the list of options based on context and filters incorrect or distracting items. Completions are often triggered by entering different statements (such as `import`) and operators (including a period), but they can appear at anytime by selecting the keyboard shortcut **Ctrl**+**J** +**Space**.

:::image type="content" source="media/code-editing-completions-simple.png" alt-text="Screenshot that shows member completion through Intellisense in the Visual Studio editor." border="false":::

When a completion list is open, you can search for the completion you want by using the arrow keys, the mouse, or by continuing to type. As you type more letters, the list is further filtered to show likely completions. You can also use shortcuts such as:

- Type letters that aren't at the start of the name, such as 'parse' to find 'argparse'
- Type only letters that are at the start of words, such as 'abc' to find 'AbstractBaseClass' or 'air' to find 'as_integer_ratio'
- Skip letters, such as 'b64' to find 'base64'

Here are some examples:

:::image type="content" source="media/code-editing-completion-filtering.png" alt-text="Screenshot that shows member completion with filtering in the Visual Studio editor." border="false":::

Member completions appear automatically when you type a period after a variable or value, along with the methods and attributes of the potential types. If a variable can be more than one type, the list includes all possibilities from all types. Extra information is shown to indicate which types support each completion. When all possible types support a completion, no annotation is shown.

:::image type="content" source="media/code-editing-completion-types.png" alt-text="Screenshot that shows member completion on multiple types in the Visual Studio editor." border="false":::

By default, "dunder" members (members beginning and ending with a double underscore) aren't shown. In general, such members shouldn't be accessed directly. If you need to use a dunder, type the leading double underscore to add these completions to the list:

:::image type="content" source="media/code-editing-completion-dunder.png" alt-text="Screenshot that shows private dunder member completion types in the Visual Studio editor." border="false":::

The `import` and `from ... import` statements display a list of modules that can be imported. The `from ... import` statement produces a list that includes members that can be imported from the specified module.

:::image type="content" source="media/code-editing-completion-import.png" alt-text="Screenshot that shows import and from import completion in the Visual Studio editor." border="false":::

The `raise` and `except` statements display lists of classes likely to be error types. The list might not include all user-defined exceptions, but it helps you find suitable built-in exceptions quickly:

:::image type="content" source="media/code-editing-completion-exception.png" alt-text="Screenshot that shows exception completion in the Visual Studio editor." border="false":::

Selecting **@** symbol (at) starts a decorator and shows potential decorators. Many of these items aren't usable as decorators. Check the library documentation to determine which decorator to use.

:::image type="content" source="media/code-editing-completion-decorator.png" alt-text="Screenshot that shows decorator completion in the Visual Studio editor." border="false":::

For more information, see [Options - completion results](python-support-options-and-settings-in-visual-studio.md#completion-results).

### Type hints

Type hints are available in Visual Studio 2017 version 15.7 and later.

"Type hints" in Python 3.5+ ([PEP 484](https://www.python.org/dev/peps/pep-0484/) (python.org) is an annotation syntax for functions and classes that indicate the types of arguments, return values, and class attributes. IntelliSense displays type hints when you hover over functions calls, arguments, and variables that have those annotations.

In the following example, the `Vector` class is declared as the type `List[float]`, and the `scale` function contains type hints for both its arguments and return value. Hovering over a call to that function shows the type hints:

:::image type="content" source="media/code-editing-type-hints1.png" alt-text="Screenshot that shows how hovering over a function call to reveal type hints." border="false":::

In the next example, you can see how the annotated attributes of the `Employee` class appear in the IntelliSense completion popup for an attribute:

:::image type="content" source="media/code-editing-type-hints1.png" alt-text="Screenshot that shows IntelliSense completion for a class with type hints." border="false":::

It's also helpful to validate type hints throughout your project because errors don't normally appear until run time. For this purpose, Visual Studio integrates the industry standard Mypy tool through the context menu command **Python** > **Run Mypy** in **Solution Explorer**:

:::image type="content" source="media/python-linting-command.png" alt-text="Screenshot that shows the available linting commands for Python projects in Solution Explorer." border="false":::

Running the command prompts you to install the Mypy package, if needed. Visual Studio then runs Mypy to validate type hints in every Python file in the project. Errors appear in the Visual Studio **Error List** window. Selecting an item in the window navigates to the appropriate line in your code.

As a simple example, the following function definition contains a type hint to indicate that the `input` argument is type `str`, whereas the call to that function attempts to pass an integer:

```python
def commas_to_colons(input: str):
    items = input.split(',')
    items = [x.strip() for x in items]
    return ':'.join(items)

commas_to_colons(1)
```

Using the **Run Mypy** command on this code generates the following error:

:::image type="content" source="media/code-editing-type-hints-validation-error.png" alt-text="Screenshot that shows the example result of Mypy validating type hints." border="false" lightbox="media/code-editing-type-hints-validation-error.png":::

> [!NOTE]
> For versions of Python before 3.5, Visual Studio also displays type hints that you supply through Typeshed *stub files* (*.pyi*). You can use stub files when you don't want to include type hints directly in your code or to create type hints for a library that doesn't use them directly. For more information, see [Create stubs for Python modules](https://github.com/python/mypy/wiki/Creating-Stubs-For-Python-Modules) in the Mypy project wiki.
>
> Visual Studio doesn't currently support type hints in comments.

### Signature help

When writing code that calls a function, signature help appears when you type the opening parenthesis `(`. It displays available documentation and parameter information. You can access signature help with the keyboard shortcut **Ctrl**+**Shift**+**Space** inside a function call. The information displayed depends on the documentation strings in the function's source code, but includes any default values.

:::image type="content" source="media/code-editing-signature-help.png" alt-text="Screenshot that shows signature help in the Visual Studio editor." border="false":::

> [!TIP]
> To disable signature help, go to **Tools** > **Options** > **Text Editor** > **Python** > **General**. Clear the **Statement completion** > **Parameter information** checkbox.

### Quick info

Hovering the mouse pointer over an identifier displays a Quick Info tooltip. Depending on the identifier, Quick Info might display the potential values or types, any available documentation, return types, and definition locations:

:::image type="content" source="media/code-editing-quick-info.png" alt-text="Screenshot that shows Quick Info display information in the Visual Studio editor." border="false":::

### Code coloring

Code coloring uses information from code analysis to color variables, statements, and other parts of your code. Variables that refer to modules or classes might be shown in a different color than functions or other values. Parameter names might appear in a different color than local or global variables. By default, functions aren't shown in bold.

:::image type="content" source="media/code-editing-code-coloring.png" alt-text="Screenshot that shows code and syntax coloring in the Visual Studio editor." border="false":::

::: moniker range="<=vs-2019"
To customize the colors, go to **Tools** > **Options** > **Environment** > **Fonts and Colors**. In the **Display items** list, modify the desired **Python** entries:

:::image type="content" source="media/code-editing-customize-colors.png" alt-text="Screenshot that shows the Fonts and Colors options in Visual Studio." border="false":::
::: moniker-end
## Insert code snippets

Code snippets are fragments of code that can be inserted into your files by using a keyboard shortcut and selecting **Tab**. You can also use the **Edit** > **IntelliSense** > **Insert Snippet** and **Surround With** commands, select **Python**, and then select the desired snippet.

For example, `class` is a shortcut for a code snippet that inserts a class definition. You see the snippet appear in the autocompletion list when you type `class`:

:::image type="content" source="media/code-editing-code-snippet-class.png" alt-text="Screenshot that shows a code snippet for the class shortcut.":::

Selecting **Tab** generates the rest of the class. You can then type over the name and bases list, move between the highlighted fields with **Tab**, and select **Enter** to begin typing the body.

:::image type="content" source="media/code-editing-code-snippets.png" alt-text="Screenshot that shows highlights on areas of a code snippet for you to complete." border="false":::

### Menu commands

When you use the **Edit** > **IntelliSense** > **Insert Code Snippet** menu command, you first select **Python**, and then select the desired snippet:

:::image type="content" source="media/code-editing-code-snippet-insert.png" alt-text="Screenshot that shows how to select a code snippet through the Insert Code Snippet command." border="false":::

The **Edit** > **IntelliSense** > **Surround With** command places the current selection in the text editor inside a chosen structural element. Suppose you had a piece of code like the following example:

```python
sum = 0
for x in range(1, 100):
    sum = sum + x
```

Selecting this code and choosing the **Surround With** command displays a list of available snippets. Choosing **def** from the snippet list places the selected code within a function definition. You can use the **Tab** key to navigate between the highlighted function name and arguments:

:::image type="content" source="media/code-editing-code-snippet-surround-with.png" alt-text="Screenshot that shows how to use the Surround With command for code snippets." border="false":::

### Examine available snippets

You can see the available code snippets in the **Code Snippets Manager**. Access this feature from **Tools** > **Code Snippets Manager** and select **Python** as the language:

:::image type="content" source="media/code-editing-code-snippets-manager.png" alt-text="Screenshot that shows the Code Snippets Manager in Visual Studio." border="false":::

To create your own snippets, see [Walkthrough: Create a code snippet](../ide/walkthrough-creating-a-code-snippet.md).

If you write a great code snippet that you'd like to share, feel free to post it in a gist and [let us know](https://github.com/Microsoft/PTVS/issues). We might be able to include it in a future release of Visual Studio.

## Navigate your code

Python support in Visual Studio provides several ways to quickly navigate within your code, including libraries for which the source code is available. You can find libraries with source code for the [navigation bar](#navigation-bar), [**Go To Definition**](#go-to-definition), [**Go To**](#go-to), and [**Find All References**](#find-all-references) commands. You can also use the Visual Studio [**Object Browser**](../ide/viewing-the-structure-of-code.md#BKMK_ObjectBrowser).

### Navigation bar

The navigation bar is displayed at the top of each editor window and includes a two-level list of definitions. The left dropdown contains top-level class and function definitions in the current file. The right dropdown displays a list of definitions within the scope shown in the left. As you move around in the editor, the lists update to show your current context, and you can also select an entry from these lists to jump directly to.

:::image type="content" source="media/code-editing-navigation-bar.png" alt-text="screenshot that shows the Navigation Bar in the Visual Studio editor." border="false":::

> [!TIP]
> To hide the navigation bar, go to **Tools** > **Options** > **Text Editor** > **Python** > **General** and clear **Settings** > **Navigation bar**.

### Go To Definition

The **Go To Definition** command quickly jumps from the use of an identifier (such as a function name, class, or variable), to the location of the source code definition. To invoke the command, right-click an identifier and select **Go To Definition** or place the caret in the identifier and select **F12**. The command works across your code and external libraries where the source code is available. If library source code isn't available, **Go To Definition** jumps to the relevant `import` statement for a module reference or displays an error.

:::image type="content" source="media/code-editing-go-to-definition.png" alt-text="Screenshot that shows the Go To Definition command in Visual Studio." border="false":::

### Go To

The **Edit** > **Go To** command (**Ctrl**+**,**) displays a search box in the editor where you can type any string and see possible matches in your code that defines a function, class, or variable containing that string. This feature provides a similar capability as **Go To Definition** but without having to locate a use of an identifier.

To navigate to the definition of that identifier, double-click any name or select the name with arrow keys followed by **Enter**.

:::image type="content" source="media/code-editing-navigate-to.png" alt-text="Screenshot that shows the Go To command in Visual Studio." border="false":::

### Find All References

The **Find All References** feature is a helpful way of discovering where any given identifier is both defined and used, including imports and assignments. To invoke the command, right-click an identifier and select **Find All References**, or place the caret in the identifier and select **Shift**+**F12**. Double-clicking an item in the list navigates to its location.

:::image type="content" source="media/code-editing-find-all-references.png" alt-text="Screenshot that shows the Find All References results in Visual Studio." border="false":::

## Related content

- [Format Python code](formatting-python-code.md)
- [Refactor Python code](refactoring-python-code.md)
- [Use a linter](linting-python-code.md)
