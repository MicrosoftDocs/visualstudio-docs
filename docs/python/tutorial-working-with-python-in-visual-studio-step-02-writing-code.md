---
title: Python in Visual Studio tutorial step 2, write and run code
titleSuffix: ""
description: Step 2 of a core walkthrough of Python capabilities in Visual Studio, including editing code and running a project.
ms.date: 01/28/2019
ms.topic: tutorial
author: rjmolyneaux
ms.author: rmolyneaux
manager: jmartens
ms.technology: vs-python

ms.workload:
  - python
  - data-science
---

# Step 2: Write and run code

**Previous step: [Create a new Python project](tutorial-working-with-python-in-visual-studio-step-01-create-project.md)**

Although **Solution Explorer** is where you manage project files, the *editor* window is typically where you work with the *contents* of files, like source code. The editor is contextually aware of the type of file you're editing, including the programming language (based on the file extension), and offers features appropriate to that language such as syntax coloring and auto-completion using IntelliSense.

1. After creating a new "Python Application" project, a default empty file named *PythonApplication1.py* is open in the Visual Studio editor.

1. In the editor, start typing `print("Hello, Visual Studio")` and notice how Visual Studio IntelliSense displays auto-completion options along the way. The outlined option in the drop-down list is the default completion that's used when you press the **Tab** key. Completions are most helpful when longer statements or identifiers are involved.

    ![IntelliSense auto-completion popup](media/vs-getting-started-python-04-IntelliSense1b.png)

1. IntelliSense shows different information depending on the statement you're using, the function you're calling, and so forth. With the `print` function, typing `(` after `print` to indicate a function call displays full usage information for that function. The IntelliSense pop up also shows the current argument in boldface (**value** as shown here):

    ![IntelliSense auto-completion popup for a function](media/vs-getting-started-python-05-IntelliSense2b.png)

1. Complete the statement so it matches the following:

    ```python
    print("Hello, Visual Studio")
    ```

1. Notice the syntax coloration that differentiates the statement `print` from the argument `"Hello Visual Studio"`. Also, temporarily delete the last `"` on the string and notice how Visual Studio shows a red underline for code that contains syntax errors. Then replace the `"` to correct the code.

    ![IntelliSense syntax coloring and error highlighting](media/vs-getting-started-python-06-IntelliSense3b.png)

    > [!Tip]
    > Because one's development environment is a very personal matter, Visual Studio gives you complete control over Visual Studio's appearance and behavior. Select the **Tools** > **Options** menu command and explore the settings under the **Environment** and **Text Editor** tabs. By default you see only a limited number of options; to see every option for every programming language, select **Show all settings** at the bottom of the dialog box.

1. Run the code you've written to this point by pressing **Ctrl**+**F5** or selecting **Debug** > **Start without Debugging** menu item. Visual Studio warns you if you still have errors in your code.

1. When you run the program, a console window appears displaying the results, just as if you'd run a Python interpreter with *PythonApplication1.py* from the command line. Press a key to close the window and return to the Visual Studio editor.

    ![Output for the first run of the program](media/vs-getting-started-python-07-output.png)

1. In addition to completions for statements and functions, IntelliSense provide completions for Python `import` and `from` statements. These completions help you easily discover what modules are available in your environment and the members of those modules. In the editor, delete the `print` line and start typing `import`. A list of modules appears when you type the space:

    ![IntellSense showing available modules for an import statement](media/vs-getting-started-python-08-import1.png)

1. Complete the line by typing or selecting `sys`.

1. On the next line, type `from` to again see a list of modules:

    ![IntellSense showing available modules for a from statement](media/vs-getting-started-python-09-import2.png)

1. Select or type `math`, then continue typing with a space and `import`, which displays the module members:

    ![IntellSense showing module members](media/vs-getting-started-python-10-import3.png)

1. Finish by importing the `sin`, `cos`, and `radians` members, noticing the auto-completions available for each. When you're done, your code should appear as follows:

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
