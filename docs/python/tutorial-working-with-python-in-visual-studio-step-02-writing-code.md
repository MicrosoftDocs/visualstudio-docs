---
title: "Tutorial Step 2: Write and Run Python Code"
titleSuffix: ""
description: Explore step 2 of a tutorial about Python capabilities in Visual Studio that demonstrates how to edit code and run a project.
ms.date: 07/29/2025
ms.topic: tutorial
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

# CustomerIntent: As a developer, I want to write Python code in Visual Studio so I can access Intellisense features and run my Python projects.
---

# Tutorial: Write and run Python code in Visual Studio

This article presents Step 2 in the tutorial series _Work with Python in Visual Studio_.

The Visual Studio integrated development environment (IDE) provides various windows that support different development tasks. [Step 1 in the tutorial](tutorial-working-with-python-in-visual-studio-step-01-create-project.md) describes how to manage project files in the **Solution Explorer** window. In Step 2, you use the _editor_ window to work with the _contents_ of files, like source code.

The editor is contextually aware of the type of file you're editing. The editor also recognizes the programming language (based on the file extension), and offers features appropriate to that language such as syntax coloring and autocompletion by using IntelliSense.

In Step 2 of the tutorial, you learn how to:

> [!div class="checklist"]
> - Write Python code in the editor
> - Run code (without debugging)
> - Use Intellisense features for writing code

## Prerequisites

- A Python application project with an empty Python file (_.py_) created in [Step 1: Create a new Python project](tutorial-working-with-python-in-visual-studio-step-01-create-project.md).

## Write code in Visual Studio

When you create a new Python project from the **Python Application** template, Visual Studio creates an empty Python file (_.py_) and opens the file in the editor. Visual Studio uses the project name that you specify at creation as the name for the file. The default project name is "Python Application1" and the default file name is _PythonApplication1.py_. In this section, you add code to this empty Python file.

Follow these steps to start writing Python code:

1. Open your empty Python file in the Visual Studio editor.

1. In the editor, start to enter the Python function name `print`.

   As you enter the function name, Visual Studio IntelliSense displays autocompletion options for your code. The default completion option is highlighted:

   :::image type="content" source="media/tutor-python-2-intellisense-print-completion.png" alt-text="Screenshot that shows IntelliSense autocompletion options in the editor in Visual Studio. The default completion option is highlighted." lightbox="media/tutor-python-2-intellisense-print-completion.png":::

   To apply the default completion to your code, select the **Tab** keyboard shortcut.

   Completions are most helpful when you need to add longer statements or identifiers in your code. IntelliSense shows different completion options based on the statement you're using. For example, when you use parenthesis `()` with a function name, Intellisense recognizes the code as a function call.

1. In the editor, start to enter code to call the `print()` function.

   When you enter the open parenthesis `(`, Intellisense shows full usage information for the function. The current argument is in boldface. In this example, the argument is **values: object**:

   :::image type="content" source="media/tutor-python-2-intellisense-argument-completion.png" alt-text="Screenshot that shows IntelliSense autocompletion options for the print function in the editor in Visual Studio." lightbox="media/tutor-python-2-intellisense-argument-completion.png":::

1. In the editor, complete the code statement so it matches the following example:

   ```python
   print("Hello, Visual Studio")
   ```

   Notice how Visual Studio applies different syntax coloration for the `print` function versus the function argument `"Hello, Visual Studio"`. Visual Studio also uses coloring and formatting techniques to help you read your code. For example, Visual Studio uses underlining to draw your attention to issues with your code.

1. Temporarily delete the closing quote mark `"` for the string argument.

   Notice how Visual Studio shows a red underline for code that contains syntax errors.

   :::image type="content" source="media/tutor-python-2-intellisense-colors-highlights.png" alt-text="Screenshot that shows IntelliSense syntax coloring and error highlighting in the editor in Visual Studio." lightbox="media/tutor-python-2-intellisense-colors-highlights.png":::

1. Replace the closing quote mark `"` in your code.

### Configure preferred formatting and behavior

Your development environment preferences are a personal matter. Visual Studio gives you complete control over the IDE appearance and interactive behavior. In addition to showing/hiding windows and setting up your preferred window layout, you can choose colors and other formatting options for menus, window content, and the editor.

Follow these steps to explore configuration options for your environment:

1. Select **Tools** > **Options** on the toolbar.

1. Explore the configuration settings under the **Environment** and **Text Editor** tabs.

   Each tab lists settings by area, such as **General**, **Fonts and Colors**, **Advanced**, and so on.
   
1. Explore options specific to working with Python in Visual Studio:

   - **Tools** > **Options** > **Python**
   - **Tools** > **Options** > **Text Editor** > **Python**

1. To see options that apply to all supported programming languages, select **Tools** > **Options** > **Text Editor** > **All Languages**.

## Run code in Visual Studio

After you have some code in place, you're ready to try running your program. You can choose to run the application with or without debugging.

1. To run the code without debugging, select **Debug** > **Start without Debugging** on the toolbar, or use the **Ctrl**+**F5** keyboard shortcut.

   Visual Studio warns you if you still have errors in your code.

1. When you run the program, a console window opens to show the results. This window is similar to what you see when you run a Python interpreter with the Python file (_PythonApplication1.py_) from the command line.

   :::image type="content" source="media/tutor-python-2-first-run-program-output.png" alt-text="Screenshot that shows the console window with output for the running program in Visual Studio." lightbox="media/tutor-python-2-first-run-program-output.png":::

1. To close the console window, select any key. You return to the Visual Studio editor.

## Explore Intellisense completions

In addition to completions for statements and functions, IntelliSense provides completions for Python `import` and `from` statements. These completions help you easily discover what modules are available in your environment and the members of those modules.

Follow these steps to explore more Intellisense completion features:

1. In the editor, delete the `print` statement from your code.

1. Start to enter the `import sys` statement. When you start to enter `sys`, Visual Studio shows a list of possible modules for the `import` function:

   :::image type="content" source="media/tutor-python-2-intellisense-import-sys-completion.png" alt-text="Screenshot that shows how IntelliSense displays the available modules for an import statement in the editor in Visual Studio." lightbox="media/tutor-python-2-intellisense-import-sys-completion.png":::

   You can scroll through the list to see the full set of available modules.

1. To complete the statement, enter `sys` or select the `sys` completion option in the Intellisense dialog.

1. Move to the next line in your code file, and start to enter the `from math` statement. Visual Studio shows the list of possible modules for the function:

   :::image type="content" source="media/tutor-python-2-intellisense-from-math-completion.png" alt-text="Screenshot that shows how IntelliSense displays the available modules for the 'from' statement in the editor in Visual Studio." border="false" lightbox="media/tutor-python-2-intellisense-from-math-completion.png":::

1. Complete the `math` library name or select the `math` completion option from the Intellisense dialog.

1. Continue the statement by adding a space followed by the `import` function name. Visual Studio shows the list of possible module members for this use of the `import` function:

   :::image type="content" source="media/tutor-python-2-intellisense-import-members-completion.png" alt-text="Screenshot that shows how IntelliSense displays the available module members for the import function in the editor in Visual Studio." lightbox="media/tutor-python-2-intellisense-import-members-completion.png":::

1. Finish the statement by using the Intellisense completion options to add the `cos` and `radians` members.

   Here's what your completed code should look like:

   ```python
   import sys
   from math import cos, radians
   ```

   > [!TIP]
   > Completions work with substrings as you type, matching parts of words, letters at the beginning of words, and even skipped characters.

1. Add a little more code to your Python file and print the cosine values for 360 degrees:

   ```python
   for i in range(360):
       print(cos(radians(i)))
   ```

1. Run your program again. You can try the **Ctrl**+**F5** keyboard shortcut.

   Close the program output window when you're done.

## Next step

> [!div class="nextstepaction"]
> [Step 3: Use the interactive REPL window](tutorial-working-with-python-in-visual-studio-step-03-interactive-repl.md)
