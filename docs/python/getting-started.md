---
title: "Start Working with Python in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "3/7/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-python"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: a9087b19-275b-4cc1-8d0c-f9c4356c9ce8
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

# Getting Started with Python in Visual Studio

Once you have Visual Studio installed with the Python workload (Visual Studio 2017), or with the Python Tools for Visual Studio (Visual Studio 2015 and earlier), you're ready to explore the Python development experience.

In this walkthrough you'll create a new empty Python application, choose a Python environment to work with, and then start writing some code to see IntelliSense at work. You'll then work with the interactive REPL window for a short time to create more code, then complete the program and run it both by itself and in the debugger.

> [!Note]
> This walkthrough explores the Python experience in Visual Studio 2017; other versions will be similar but may differ in the details.

## Create a new Python project

Python support in Visual Studio includes a number of [project templates](python-projects.md) to get you started with different types of projects, including web applications using the Bottle, Flask, and Django frameworks along with Azure Cloud Services. For the purposes of this walkthrough, however, we'll start with an empty project.

1. In Visual Studio, select **File > New Project**, which brings up the **New Project** dialog. This is where you can browse and select a template and specify the folder in which to create the project.

1. Python templates can be found under the **Templates > Other Languages > Python** on the left, or by simply searching on "Python":

    ![New project dialog with Python projects shown](media/getting-started-new-project.png)

1. Select the "Python Application" template, specify a folder for the project, and select **OK**. (If you want to create a local repository for your project right away, also select the **Add to source control** option).

    > [!Tip]
    > The "From exiting Python Code" template lets you quickly create a Visual Studio project from a folder that already contains Python code, rather than creating a new empty project and importing existing code into it.

1. After a few moments, you'll see the project open in the Visual Studio Solution Explorer window. Here you can browse the files and folders in your project, as well as manage environments.

    ![Solution Explorer with a Python project](media/getting-started-solution-explorer-1.png)

1. Expand the **Python Environments** node and you'll see which Python interpreter is the current default for this project. If you also expand that interpreter node, you'll see a list of libraries available in that environment:

    ![Solution Explorer showing the Python environment](media/getting-started-solution-explorer-2.png)

1. If you're using Visual Studio 2015 or earlier, you won't have a Python interpreter installed by default. Refer to [selecting and installing a Python interpreter](python-environments.md#selecting-and-installing-python-interpreters) for this process.

### Going deeper

- [Python Projects in Visual Studio](python-projects.md).
- [Web Project Templates](template-web.md)
- [Django Web Project Template](template-django.md)
- [Azure Cloud Service Template](template-azure-cloud-service.md)

## Writing and running code

1. After creating a new "Python Application" project, a default empty file named `PythonApplication1.py` is open in the Visual Studio editor. To rename it, right-click the file in Solution Explorer and select **Rename**, and change the name to `hello.py`.

1. Start typing `print("Hello world")` and notice how Visual Studio IntelliSense displays auto-completion options along the way. The outlined option in the drop-down list is the default completion that's used when you press the Tab key. This can be very helpful when longer statements or identifiers are involved.

    ![IntelliSense auto-completion popup](media/getting-started-coding-1.png)

1. IntelliSense shows different information depending on the statement you're using, the function you're calling, and so forth. With the `print` function, typing `(` to make the call pops up full usage information for that function and even bolds the current argument that you need to provide (**value** as shown here):

    ![IntelliSense auto-completion popup for a function](media/getting-started-coding-2.png)

1. Complete the statement so it matches the following:

  ```python
  print("Hello world")
  ```

1. To run the code, select the **Start** button on the toolbar shown below, press F5, or select **Debug > Start Debugging** menu item.

    ![Start button on the debug toolbar](media/getting-started-coding-3.png)

    > [!Note]
    > If you see a message in Visual Studio 2015 or earlier that there aren't any interpreters, see [selecting and installing a Python interpreter](python-environments.md#selecting-and-installing-python-interpreters) as one is not installed by default.

1. Visual Studio will run the code using the default environment in the project and show the results in a command window. Press a key to close that window and end the debugging session.

    ![Start button on the debug toolbar](media/getting-started-coding-4.png)

1. In addition to statements, and functions, IntelliSense provide completions for `import` statements. This helps you easily discover what modules are available in your environment, and the members available in that module. In the editor, delete the `print` line and start typing `import`. You'll see a list of modules appear:

    ![IntellSense showing available modules for an import statement](media/getting-started-coding-5.png)

1. Complete the line by typing or selecting `sys`.

1. On the next line, type `from` to again see a list of modules:

    ![IntellSense showing available modules for a from statement](media/getting-started-coding-6.png)

1. Select or type `math`, then continue typing with a space and `import`, which displays the module members:

    ![IntellSense showing module members](media/getting-started-coding-7.png)

1. Finish by importing the `sin`, `cos`, and `radians` members, noticing the auto-completions available for each. When you're done, your code should appear as follows:

  ```python
  import sys  
  from math import sin, cos, radians          
  ```

> [!Tip]
> Completions work with substrings as you type, matching parts of words, letters at the beginning of words, and even skipped characters. See [Editing Code - Completions](code-editing.md#completions) for details.

In the next step we'll work with the interactive REPL window to write some code that we can test immediately without running the debugger.

### Going deeper

- [Editing Code](code-editing.md)
- [Formatting Code](code-formatting.md)
- [Refactoring Code](code-refactoring.md)
- [Using PyLint](code-pylint.md)


## Using the interactive REPL window

The Visual Studio interactive window for Python provides a rich read-evaluate-print-loop experience that greatly shortens the usual edit-build-debug cycle. It is similar to the REPL experience of the Python command line, but provides a few additional features as you'll see here.

1. Open the interactive window by selecting **View > Other Windows > Python Interactive Windows** from the main Visual Studio menu. The window opens with the usual >>> Python REPL prompt. Note that you can use the drop-down menu on the toolbar to change the environment at any time:

    ![Python interactive window](media/getting-started-interactive-1.png)

1. Enter a few statements (like `print("hello")`) and expressions (like `123/567`) to see immediate results:

    ![Python interactive window immediate results](media/getting-started-interactive-2.png)

1. When you start writing a multiline statement, like a function definition, the interactive window shows the ... prompt for continuing lines, which, unlike the command-line REPL, provides automatic indentation:

    ![Python interactive window with statement continuation](media/getting-started-interactive-3.png)

1. The interactive window provides a full history of everything you've entered, and improves upo the command-line REPL with multiline history items. For example, you can easily recall the entire definition of the `f` function above as a single unit and easily change the name to `make_double`, rather than re-creating the function line by line.

1. Another very helpful feature is the ability to quickly send multiple lines of code from an editor window to the interactive window, where you can work with it in the rapid REPL environment rather than writing other code to run in the debugger. To see this, start by adding the following code to your hello.py file that's open in the editor:

  ```python
  def make_dot_string(x):  
      return ' ' * int(10 * cos(radians(x)) + 10) + 'o'
  ```

1. Select all the code in hello.py (including the `import` statements), right-click, and select **Send to Interactive** (Ctrl+Enter). The code is immediately pasted into the interactive window and run. Because the code defines a function, you can quickly test that function by calling it a few times:

    ![Sending code to the interactive window](media/getting-started-interactive-4.png)

1. **Send to Interactive** effectively allows you to paste multiple lines of code (such as something you find online) into the interactive window, which can't be done directly. For example, copy the code below and try pasting (Ctrl+V) into the interactive window and you'll see that nothing happens. But you can paste it into the editor, select it, and used the **Send to Interactive** command to watch it run.

  ```python
  for i in range(360):
      s = make_dot_string(i)  
      print(s) 
  ```

    ![Pasting multiple lines of code using Sending Interactive](media/getting-started-interactive-5.png)

1. Because the function definition is again in the REPL history as a single unit, it's easy to go back and make whatever changes you want and then test the function again.

1. When you're satisfied with code you're written, you can select it in the interactive window, right-click and select **Copy Code**, and then paste into the editor. The special feature of the **Copy Code** command is that it automatically omits any output as well as the >>> and ... prompt text. For example, using the command with the selection show below:

  ![Interactive window copy code command](media/getting-started-interactive-6.png)

  will paste in only the following:

  ```python
  make_dot_string(180)
  make_dot_string(135)
  for i in range(360):
      s = make_dot_string(i)  
      print(s) 
  ```

1. Finally, the interactive window provides a number of meta-commands that allow you to load files, reset the environment without losing the history, and inserting comments as you go along. See [Interactive Windows - meta-commands](interactive-repl.md#meta-commands) for details.

### Going deeper

- [Using the Interactive window](interactive-repl.md)
- [Using IPython REPL](interactive-repl-ipython.md)

## Running code in the debugger

In addition to managing projects, providing a rich editing experience, and the interactive window, Visual Studio provides its full-featured debugging support for Python code.

1. Edit the code in your hello.py file to match the following:

  ```python  
  from math import sin, cos, radians  
  import sys  
    
  def make_dot_string(x):  
      return ' ' * int(10 * cos(radians(x)) + 10) + 'o'  
    
  def main():  
      for i in range(360 * 5):
          s = make_dot_string(i)  
          print(s)  
            
  main()
  ```  

1. Check that the code works properly by selecting **Start** on the toolbar, pressing F5, or selecting the **Debug > Start Debugging** menu command. This runs the code in the debugger, but because we don't have any breakpoints set you'll simply see it print a wave pattern for a few iterations. Pressing any key will close the output window at this point.

    > [!Tip]
    > To close the output window automatically when the program completes, replace the `main()` call with the following code:
    >
    > ```python    
    > if __name__ == "__main__":  
    >     sys.exit(int(main() or 0))      
    > ```

1. Set a breakpoint on the first line of the `main` function by clicking in the left-hand gray margin by that line, or by placing the caret in that line and using the *Debug > Toggle Breakpoint** command (F9). A red dot will appear in the gray margin to indicate the breakpoint (as noted by the blue arrow below):

    ![Setting a breakpoint](media/getting-started-debugging-1.png)

1. Start the debugger again and you'll see that running the code stops on the line with that breakpoint. Here you can see the call stack and examine local variables in the Locals window:

    ![Breakpoint UI experience for Python](media/getting-started-debugging-2.png)

1. Step through a few iterations of the `for` loop line-by-line using F10, the **Debug > Step Over** command, or the Step Over toolbar button. This means that the debugger will run each call to `make_dot_string`, but will not go stop inside that function (unless you set a breakpoint).

1. In the toolbar, the three stepping buttons show below are, going left-to-right: Step Into, Step Over, and Step Out:

    ![Stepping toolbar buttons](media/getting-started-debugging-3.png)

1. Step into `make_dot_string` now by using the Step Into command (F11). You'll see that you'll step from the `for` loop into that function. Stepping again will return to the `for` loop, but if there were additional lines in the function, you'd step through them one at a time. If you're in a function and want to run the remainder of its lines and return to the calling code, use Step Out (Shift+F11).

1. To continue running the code until the next breakpoint is reached (or the program ends) press F5 again or select the **Continue** toolbar button or **Debug > Continue**. Because you have a breakpoint in the `for` loop, you'll break on the next iteration.

1. Stepping through hundreds of iterations of a loop can be tedious, so you can add a condition to the breakpoint set earlier to break only when the value of `i` exceeds a certain value, say 1600. To do this, right-click the red breakpoint dot and select **Condition...**. In the Breakpoint Settings window that appears, enter `i > 1600` as the expression and select **Close**. Now press F5 to continue and you'll see the program run for a while before it breaks again. 

    ![Setting a breakpoint condition](media/getting-started-debugging-4.png)

1. To complete the program, you can toggle the breakpoint again and press F5. Visual Studio returns to its editing mode when debugging is complete.

### Going deeper

- [Debugging](debugging.md).
- Also see [Debugging in Visual Studio](../debugger/debugging-in-visual-studio.md) for full documentation of Visual Studio's debugging features.

## Next steps

In addition to the "Going deeper" links provided earlier, the following topics cover additional features of the Python experience in Visual Studio:

- To see how Visual Studio connects to an Azure App Service, see [Publishing a Python web application to Azure](publishing-to-azure.md)
- To explore how to manage different environments both globally and for individual projects, including virtual environments, see [Python Environments](python-environments.md).
- Visual Studio provides the ability to debug your application on remote servers, as explained on [Cross-platform Remote Debugging](debugging-cross-platform-remote.md) and [Azure Remote Debugging](debugging-azure-remote.md).
- You can evaluate the performance of your Python code by using [Visual Studio Profiling](profiling.md).
- Unit tests written in Python integrate directly with the Visual Studio Test Explorer, as discussed on [Unit Testing](unit-testing.md).
