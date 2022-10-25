---
title: Python in Visual Studio tutorial step 2, write and run code
titleSuffix: ""
description: Step 2 of a core walkthrough of Python capabilities in Visual Studio, including editing code and running a project.
ms.date: 02/04/2022
ms.topic: tutorial
author: cwebster-99
ms.author: cowebster
manager: jmartens
ms.technology: vs-python

ms.workload:
  - python
  - data-science
ms.custom: devdivchpfy22
---
# Step 2: Write and run code

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

**Previous step: [Create a new Python project](tutorial-working-with-python-in-visual-studio-step-01-create-project.md)**

Although **Solution Explorer** is where you manage project files, the *editor* window is typically where you work with the *contents* of files, like source code. The editor is contextually aware of the type of file you're editing. The editor also recognizes the programming language (based on the file extension), and offers features appropriate to that language such as syntax coloring and auto-completion using IntelliSense.

1. When you create a new "Python Application" project, a default empty file named *PythonApplication1.py* is opened in the Visual Studio editor.

1. In the editor, start typing `print("Hello, Visual Studio")` and notice how Visual Studio IntelliSense displays autocompletion options along the way. The outlined option in the drop-down list is the default completion that's used when you press the **Tab** key. Completions are most helpful when longer statements or identifiers are involved.

    ![IntelliSense auto-completion popup](media/vs-getting-started-python-04-IntelliSense1b.png)

1. IntelliSense shows different information based on the statement you're using, the function you're calling, and so on. With the `print` function, typing `(` after `print` to indicate a function call displays full usage information for that function. The IntelliSense pop up also shows the current argument in boldface (**value** as shown here):

    ![IntelliSense auto-completion popup for a function](media/vs-getting-started-python-05-IntelliSense2b.png)

1. Complete the statement so it matches the code below:

    ```python
    print("Hello, Visual Studio")
    ```

1. Notice the syntax coloration that differentiates the statement `print` from the argument `"Hello Visual Studio"`. You can, temporarily delete the last `"` on the string and notice how Visual Studio shows a red underline for code that contains syntax errors. Finally replace the `"` to correct the code.

    ![IntelliSense syntax coloring and error highlighting](media/vs-getting-started-python-06-IntelliSense3b.png)

    > [!Tip]
    > Because one's development environment is a very personal matter, Visual Studio gives you complete control over Visual Studio's appearance and behavior. Select the **Tools** > **Options** menu command and explore the settings under the **Environment** and **Text Editor** tabs. By default you see only a limited number of options; to see every option for every programming language, select **Show all settings** at the bottom of the dialog.

1. Run the code you've written to this point by pressing **Ctrl**+**F5** or selecting **Debug** > **Start without Debugging** menu item. Visual Studio warns you if you still have errors in your code.

1. When you run the program, a console window will display the results. It's similar to running a Python interpreter with *PythonApplication1.py* from the command line. Press any key to close the window and return to the Visual Studio editor.

    ![Output for the first run of the program](media/vs-getting-started-python-07-output.png)

1. In addition to completions for statements and functions, IntelliSense provide completions for Python `import` and `from` statements. These completions help you easily discover what modules are available in your environment and the members of those modules. In the editor, delete the `print` line and start typing `import`. A list of modules appears when you type the space:

    ![IntellSense showing available modules for an import statement](media/vs-getting-started-python-08-import1.png)

1. Complete the line by typing or selecting `sys`.

1. On the next line, type `from` to again see a list of modules:

    ![IntellSense showing available modules for a from statement](media/vs-getting-started-python-09-import2.png)

1. Select or type `math`, then continue typing with a space and `import`, which displays the module members:

    ![IntellSense showing module members](media/vs-getting-started-python-10-import3.png)

1. Finish by importing the `cos` and `radians` members, noticing the autocompletions available for each. When you're done, your code should appear as follows:

    ```python
    import sys
    from math import cos, radians
    ```

    > [!Tip]
    > Completions work with substrings as you type, matching parts of words, letters at the beginning of words, and even skipped characters. See [Edit code - Completions](editing-python-code-in-visual-studio.md#completions) for details.

1. Add a little more code to print the cosine values for 360 degrees:

    ```python
    for i in range(360):
        print(cos(radians(i)))
    ```

1. Run the program again with **Ctrl**+**F5** or **Debug** > **Start without Debugging**. Close the output window when you're done.

## Next step

> [!div class="nextstepaction"]
> [Use the interactive REPL window](tutorial-working-with-python-in-visual-studio-step-03-interactive-repl.md)

## Go deeper

- [Edit code](editing-python-code-in-visual-studio.md)
- [Format code](formatting-python-code.md)
- [Refactor code](refactoring-python-code.md)
- [Use PyLint](linting-python-code.md)
