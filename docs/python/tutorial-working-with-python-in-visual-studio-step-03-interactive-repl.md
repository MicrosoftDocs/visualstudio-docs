---
title: "Tutorial Step 3: Use interactive REPL"
titleSuffix: ""
description: Explore step 3 of a tutorial about Python capabilities in Visual Studio that demonstrates how to work with the Python Interactive REPL window.
ms.date: 07/29/2025
ms.topic: tutorial
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

# CustomerIntent: As a developer, I want to use the Interactive Window for Python in Visual Studio so I can have a robust read-evaluate-print-loop (REPL) experience for developing Python code.
---

# Tutorial: Use the Interactive REPL window in Visual Studio

This article presents Step 3 in the tutorial series _Work with Python in Visual Studio_.

The Visual Studio integrated development environment (IDE) provides various windows that support different development tasks. [Step 1](tutorial-working-with-python-in-visual-studio-step-01-create-project.md) and [Step 2](tutorial-working-with-python-in-visual-studio-step-02-writing-code.md) in the tutorial describe how to manage files in **Solution Explorer** and work with file content in the code editor. In Step 3, you use the Visual Studio **Interactive Window** for Python for a rich read-evaluate-print-loop (REPL) experience that greatly shortens the usual edit-build-debug cycle.

By working in the **Interactive Window** for Python, you gain all the capabilities of the REPL experience of the Python command line. It also makes it easy to exchange code with source files in the Visual Studio editor, which is otherwise cumbersome with the command line.

In Step 3 of the tutorial, you learn how to:

> [!div class="checklist"]
> - Access the Interactive Window for Python and set the Python interpreter
> - Enter and run code in the window, and scroll the command history
> - Insert existing code or code from other sources
> - Copy code and program output from the Interactive Window

## Prerequisites

- A Python application project that has a Python file (_.py_) with code created in [Step 2: Write and run Python code](tutorial-working-with-python-in-visual-studio-step-02-writing-code.md).

- To best support the REPL experience, install the `ipython` and `ipykernel` packages. For more information, see [Python environments packages tab](./python-environments-window-tab-reference.md#packages-tab).

## Open the Interactive Window for Python

Follow these steps to open the **Interactive Window** and start working with code:

1. Use one of the following methods to open the **Interactive Window** for Python:

   - In **Solution Explorer**, right-click your project node and select **Open Interactive Window**.
   - In **Solution Explorer**, under the **Python Environments** node for your project, right-click the Python environment for your project and select **Open Interactive Window**. An example of a Python environment is **Python 3.11 (64-bit)**.
   - On the toolbar, select **View** > **Other Windows** > **Python Interactive Windows** or use the keyboard shortcut **Alt**+**I**.

   Visual Studio opens the **Interactive Window** for Python under the editor window. The window has the standard **>>>** Python REPL prompt:

   :::image type="content" source="media/tutor-python-3-open-interactive-window.png" alt-text="Screenshot that shows the Interactive Window for Python open underneath the code editor in Visual Studio." lightbox="media/tutor-python-3-open-interactive-window.png":::

1. In the **Interactive Window**, you can use the **Environment** dropdown list to select a specific Python interpreter to work with:

   :::image type="content" source="media/tutor-python-3-select-environment-interpreter.png" alt-text="Screenshot that shows how to select the Python interpreter from the Environment dropdown list in the Interactive Window in Visual Studio." lightbox="media/tutor-python-3-select-environment-interpreter.png":::

1. You can make the **Interactive Window** larger by moving the separator between the window and the code editor:

   :::image type="content" source="media/tutor-python-3-resize-interactive-window.png" alt-text="Screenshot that shows how to move the separator to increase the size of the Interactive Window in Visual Studio." lightbox="media/tutor-python-3-resize-interactive-window.png":::

   > [!TIP]
   > You can resize any window in Visual Studio by moving the separators between the window and surrounding windows. You can also move windows out of the Visual Studio frame, and rearrange windows within the frame.

1. In the **Interactive Window**, enter a statement like `print("Hello, Visual Studio")` and a calculation expression like `123/456`. Visual Studio displays immediate results for your code:

   :::image type="content" source="media/tutor-python-3-add-statements-expressions.png" alt-text="Screenshot that shows how the Interactive Window displays immediate results for code you enter in Visual Studio." lightbox="media/tutor-python-3-add-statements-expressions.png":::

1. Next, enter a multiline statement like the function definition shown in the following example.

   As you enter the code, the **Interactive Window** shows the Python continuation prompt (**...** ). Unlike the command-line REPL experience, the **Interactive Window** provides automatic indentation as you enter code:

   :::image type="content" source="media/tutor-python-3-add-multiline-statement.png" alt-text="Screenshot that shows the Interactive Window displays the Python continuation prompt for multiline code statements in Visual Studio." lightbox="media/tutor-python-3-add-multiline-statement.png":::

   To add a new line in your code, select **Shift**+**Enter**.

1. Scroll through the list of commands you entered so far by using the **Up** or **Down** arrow keys.

   The **Interactive Window** provides a full history of everything you enter, and improves upon the command-line REPL experience with multiline history items. You can quickly recall the entire definition of a function as a single unit and change the function name or adjust other statements. This approach is easier than re-creating the function line by line.

## Reuse and modify existing code

Visual Studio provides different ways to use existing Python code in the **Interactive Window**, such as copy and paste, and accessing previously entered code as described earlier. Another method is to send multiple lines of code from an editor window to the **Interactive Window**. This capability allows you to maintain code in a source file and easily send the chosen fragments to the **Interactive Window**. You can then work with the code fragments in the rapid REPL environment rather than having to run the whole program.

Try these features by completing the following steps:

1. Open your Python project file (_.py_) in the editor. (Tutorial Step 2 explains how to create this file, where the default file name is _PythonApplication1.py_.)

1. Replace the `for` loop statement in the file with the following code:

   ```python
   # Create a string with spaces proportional to a cosine of x in degrees
   def make_dot_string(x):
       return ' ' * int(20 * cos(radians(x)) + 20) + 'o'
   ```

1. Right-click the `import` statement in the file and select **Send to Interactive** (or the keyboard shortcut **Ctrl**+**E**). Repeat this process for the `from` statement.

   :::image type="content" source="media/tutor-python-3-send-statements.png" alt-text="Screenshot that shows how to send code for the import and from statements to the Interactive Window in Visual Studio." lightbox="media/tutor-python-3-send-statements.png":::

   When you select the **Send to Interactive** command, the selected code fragment is immediately pasted into the **Interactive Window** and run. In this case, Visual Studio imports the `cos` and `radians` routines from the `math` library, and also the `sys` library.

1. Repeat the process again for the `make_dot_string` function. Be sure to send both lines of the function. After you send the complete code for the function, enter a new line in the **Interactive Window**.

   Because this code defines a function, you can quickly test it by calling the function a few times, as shown in the following example:

   :::image type="content" source="media/tutor-python-3-send-function-test.png" alt-text="Screenshot that shows how to run a test of the function code sent to the Interactive Window in Visual Studio." lightbox="media/tutor-python-3-send-function-test.png":::

   > [!TIP]
   > You can use the keyboard shortcut **Ctrl**+**Enter** to run the current line of code in the **Interactive Window**. After the code runs, the caret prompt moves to the next line. Select **Ctrl**+**Enter** repeatedly for a convenient way to step through your code, which isn't possible in the Python command-line experience. You can also use this approach to step through your code without running the debugger and without necessarily starting your program from the beginning.

1. Try the process again, but this time copy and paste multiple lines of code into the **Interactive Window** from any source. You can use the following code snippet:

   ```python
   for i in range(360):
       s = make_dot_string(i)
       print(s)
   ```

   The multiline paste action is difficult to do in the Python command-line REPL experience. After your paste the code, the **Interactive Window** runs the code as if you entered it directly in the window:

   :::image type="content" source="media/tutor-python-3-copy-paste-code.png" alt-text="Screenshot that shows how to paste multiple lines of code into the Interactive Window in Visual Studio." lightbox="media/tutor-python-3-copy-paste-code.png":::

   The current code works, but the output isn't inspiring. A different step value in the `for` loop can show more of the cosine wave. The code the `for` loop is available in the REPL history as a single unit. You can locate the code and make whatever changes you want and test the function again.

1. Scroll through your command history by using the **Up** arrow key and stop at the `for` loop code.

1. Use the **Left** or **Right** arrow keys to move into the code for the `for` loop statement. When you reach the beginning of a line, select the **Left** arrow key to move to the end of the previous line.

1. In the `for` loop statement, go to the `range` definition and change the statement to `range(0, 360, 12)`.

1. Select **Ctrl**+**Enter** anywhere in the `for` loop statement to run the function again:  

   :::image type="content" source="media/tutor-python-3-run-statement-again.png" alt-text="Screenshot that shows how to edit a previous statement in the Interactive Window in Visual Studio." lightbox="media/tutor-python-3-run-statement-again.png":::

1. Repeat the process to experiment with different step settings until you find a value you like. You can also make the wave repeat by lengthening the range, for example, `range(0, 1800, 12)`.

## Copy your code and program output

Visual Studio lets you copy any code that you write in the **Interactive Window**, and also any output from running your code.

Follow these steps to copy code from the **Interactive Window** to the editor:

1. In the **Interactive Window**, select the code you want to copy.

1. Right-click the selected code and choose **Copy Code** or use the keyboard shortcut **Ctrl**+**Shift**+**C**.

   :::image type="content" source="media/tutor-python-3-copy-save-code.png" alt-text="Screenshot that shows the Interactive Window copy code command on a selection that includes prompts and output in Visual Studio." lightbox="media/tutor-python-3-copy-save-code.png":::

1. Paste the copied code into the editor. This special feature of Visual Studio automatically omits any output, along with the `>>>` and `...` prompts, in the selection.

   When you paste into the editor, you get only the code:

   ```python
   for i in range(0, 1800, 12):
       s = make_dot_string(i)
       print(s)
   ```

1. To copy the exact contents of the **Interactive Window**, including prompts and any program output, use the standard **Copy** command.

In these steps, you used the rapid REPL environment of the **Interactive Window** to work out the details for a small piece of Python code and conveniently added the code to your project's source file. When you rerun your code with **Ctrl**+**F5** or **Debug** > **Start without Debugging**, you see the exact results you wanted.

## Next step

> [!div class="nextstepaction"]
> [Step 4: Run code in the debugger](tutorial-working-with-python-in-visual-studio-step-04-debugging.md)
