---
title: "Quickstart: Open and run Python code in a folder"
description: Follow guided steps to open and run Python code from a folder in Visual Studio without using a project in Visual Studio 2019 and later.
ms.date: 04/18/2024
ms.topic: quickstart
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python
monikerRange: ">= vs-2019"

# CustomerIntent: As a developer, I want to open and run Python code from a folder in Visual Studio without having to use a project for the code.
---

# Quickstart: Open and run Python code in a folder in Visual Studio

In this quickstart, you follow guided steps to run Python code in Visual Studio 2019 and later without having to create a Visual Studio project. Visual Studio makes it easy to open and run existing Python code from a folder. The same features and commands are available for your Python code development as when you choose to work with a project.

## Prerequisites

- Visual Studio installed with support for Python workloads. For more information, see [Install Python support in Visual Studio](installing-python-support-in-visual-studio.md).

- The instructions in this quickstart apply to any folder with Python code. To follow along with the example described in this article, clone the `gregmalcolm/python_koans` GitHub repository to your computer by using the following command:

   ```console
   git clone https://github.com/gregmalcolm/python_koans
   ```

Visual Studio for Mac isn't supported. For more information, see [What's happening to Visual Studio for Mac?](/visualstudio/mac/what-happened-to-vs-for-mac) Visual Studio Code on Windows, Mac, and Linux [works well with Python through available extensions](https://code.visualstudio.com/docs/languages/python).

## Open the local code folder

Follow these steps to open a local folder with existing Python code in Visual Studio:

1. Launch Visual Studio. In the start window, select **Open a local folder** in the **Get started** column:

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/quickstart-open-folder/vs-2022/open-local-folder.png" alt-text="Screenshot that shows how to select the Open a local folder option when Visual Studio 2022 starts." border="false" lightbox="media/quickstart-open-folder/vs-2022/open-local-folder.png":::

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/quickstart-open-folder/open-local-folder.png" alt-text="Screenshot that shows how to select the Open a local folder option when Visual Studio starts." border="false" lightbox="media/quickstart-open-folder/open-local-folder.png":::

   If you're using the `python_koans` repository example code, make sure to select the _python3_ folder within the clone folder.

   ::: moniker-end

   If Visual Studio is already running, you can select **File** > **Open** > **Folder** instead.

1. Browse to the folder that contains your Python code and choose **Select Folder**:

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/quickstart-open-folder/vs-2022/select-folder.png" alt-text="Screenshot that shows how to select the local folder that has the existing Python code in Visual Studio 2022." lightbox="media/quickstart-open-folder/vs-2022/select-folder.png":::

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/quickstart-open-folder/select-folder.png" alt-text="Screenshot that shows how to select the local folder that has the existing Python code in Visual Studio." lightbox="media/quickstart-open-folder/select-folder.png" :::

   ::: moniker-end

1. Visual Studio displays the files in **Solution Explorer** in the **Folder View**. You can expand and collapse a folder by using the arrow to the left of the folder name:

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/quickstart-open-folder/vs-2022/expand-collapse-folders.png" alt-text="Screenshot that shows the expand and collapse arrows for folders in Solution Explorer in Visual Studio 2022." border="false" lightbox="media/quickstart-open-folder/vs-2022/expand-collapse-folders.png":::

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/quickstart-open-folder/expand-collapse-folders.png" alt-text="Screenshot that shows the expand and collapse arrows for folders in Solution Explorer in Visual Studio." border="false" lightbox="media/quickstart-open-folder/expand-collapse-folders.png":::

   ::: moniker-end

1. When you open a Python folder, Visual Studio creates several hidden folders to manage settings related to the program. To see these folders (and any other hidden files and folders, such as the _.git_ folder), select the **Show All Files** toolbar option:

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/quickstart-open-folder/vs-2022/view-hidden-folders.png" alt-text="Screenshot that shows how to view hidden folders and files in Solution Explorer in Visual Studio 2022." border="false" lightbox="media/quickstart-open-folder/vs-2022/view-hidden-folders.png":::

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/quickstart-open-folder/view-hidden-folders.png" alt-text="Screenshot that shows how to view hidden folders and files in Solution Explorer in Visual Studio." border="false" lightbox="media/quickstart-open-folder/view-hidden-folders.png" :::

   ::: moniker-end

## Run the program

After you open the existing Python code in Visual Studio, you can run the program. To run the code, you need to identify the **Startup File** (Startup Item) or primary program file for Visual Studio to execute the program. In this example, the startup file is _contemplate-koans.py_. 

1. In **Solution Explorer**, right-click the _contemplate-koans.py_ file and select **Set as Startup Item**:

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/quickstart-open-folder/vs-2022/set-as-startup-item.png" alt-text="Screenshot that shows how to set the contemplate koans Python file as the startup item in Solution Explorer in Visual Studio 2022." border="false" lightbox="media/quickstart-open-folder/vs-2022/set-as-startup-item.png":::

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/quickstart-open-folder/set-as-startup-item.png" alt-text="Screenshot that shows how to set the contemplate koans Python file as the startup item in Solution Explorer in Visual Studio." border="false" lightbox="media/quickstart-open-folder/set-as-startup-item.png":::

   ::: moniker-end

   > [!IMPORTANT]
   > If your Startup Item isn't located in the root of the folder you opened, you must also add a line to the launch configuration JSON file as described in [Set working directory](#set-working-directory).

1. Run the code by selecting **Debug** > **Start without Debugging** or use the keyboard shortcut **Ctrl**+**F5**. You can also select the solid play arrow next to the Startup Item name on the Visual Studio toolbar. This option runs the code in the Visual Studio **Debugger**.

   ::: moniker range=">=vs-2022"

   For all of these start methods, Visual Studio detects that your Startup Item is a Python file and automatically runs the code in the default Python environment. The current environment is shown to the right of the Startup Item name on the toolbar. In the following example, the current environment is **Python 3.11 (64-bit)**:

   :::image type="content" source="media/quickstart-open-folder/vs-2022/start-debug-from-toolbar.png" alt-text="Screenshot that shows how to start the program with debugging by using the solid play arrow on the Visual Studio 2022 toolbar." border="false" lightbox="media/quickstart-open-folder/vs-2022/start-debug-from-toolbar.png":::

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   For all of these start methods, Visual Studio detects that your Startup Item is a Python file and automatically runs the code in the default Python environment. The current environment is shown to the right of the Startup Item name on the toolbar. In the following example, the current environment is **Python 3.6 (32-bit)**:

   :::image type="content" source="media/quickstart-open-folder/start-debug-from-toolbar.png" alt-text="Screenshot that shows how to start the program with debugging by using the solid play arrow on the Visual Studio." lightbox="media/quickstart-open-folder/start-debug-from-toolbar.png":::

   ::: moniker-end

   If you don't see the current Python **Environment** on the toolbar, select **View** > **Other windows** > **Python Environments**.

1. When the program runs, Visual Studio opens a command window to display the program output:

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/quickstart-open-folder/vs-2022/program-output-window.png" alt-text="Screenshot of the output window that Visual Studio 2022 opens for program output from the running Python code." lightbox="media/quickstart-open-folder/vs-2022/program-output-window.png":::

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/quickstart-open-folder/program-output-window.png" alt-text="Screenshot of the output window that Visual Studio opens for program output from the running Python code." lightbox="media/quickstart-open-folder/program-output-window.png":::

   ::: moniker-end

   > [!NOTE]
   > If you run the `python-koans` program with debugging, you need to change values in the code for the program to complete execution.

1. You can run the code in a different Python environment:

   1. Expand the current Python **Environment** dropdown list in the Visual Studio toolbar and select the desired environment.
   
   1. Restart your program.

1. When you're ready to close the code folder in Visual Studio, select **File** > **Close folder**.

## Set working directory

By default, Visual Studio runs a Python project opened as a folder in the root of that same folder. However, the code in your project might expect Python to run in a subfolder. When your code expects to find files in different locations than the default configuration recognized by Visual Studio, you can experience errors when you try to run the code.

Suppose you open the root folder of the `python_koans` repository and see a subfolder named _python3_ that contains a Python file named _contemplate-koans.py_. You decide to set the _python3/contemplate-koans.py_ file as the **Startup File**. When you run the code, you see an error that a file named _koans.txt_ can't be found. The error occurs because the _contemplate-koans.py_ file expects Python to run in the _python3_ folder rather than the repository root.

In such cases, you must also add a line to the launch configuration JSON file to specify the working directory:

::: moniker range=">=vs-2022"

1. In **Solution Explorer**, right-click the Python (_.py_) Startup File and select **Add Debug Configuration**:

   :::image type="content" source="media/quickstart-open-folder/vs-2022/add-debug-configuration.png" alt-text="Screenshot that shows how to select the Add Debug Configuration option for a selected file in Solution Explorer in Visual Studio 2022." border="false" lightbox="media/quickstart-open-folder/vs-2022/add-debug-configuration.png":::

1. In the **Select Debugger** dialog, select the **Default** option in the list, and then choose **Select**:

   :::image type="content" source="media/quickstart-open-folder/vs-2022/select-debugger.png" alt-text="Screenshot that shows how to select the Default Debugger in the Select a Debugger dialog in Visual Studio 2022." border="false" lightbox="media/quickstart-open-folder/vs-2022/select-debugger.png":::

   > [!NOTE]
   > If you don't see **Default** as an option, be sure to choose a Python _.py_ file when you select the **Add Debug Configuration** command. Visual Studio uses the file type to determine which debugger options to display.

1. Visual Studio opens a file named _launch.vs.json_, which is located in the hidden _.vs_ folder. This file describes the debugging context for the project. To specify a working directory, add a value for the `"workingDirectory"` property. For the `python-koans` example, you can add the property and value, `"workingDirectory": "python3"`:

   ```json
   {
     "version": "0.2.1",
     "defaults": {},
     "configurations": [
       {
         "type": "python",
         "interpreter": "(default)",
         "interpreterArguments": "",
         "scriptArguments": "",
         "env": {},
         "nativeDebug": false,
         "webBrowserUrl": "",
         "project": "contemplate_koans.py",
         "projectTarget": "",
         "name": "contemplate_koans.py",
         "workingDirectory": "python3"
       }
     ]
   }
   ```

1. Save your changes to the _launch.vs.json_ file.

1. Run your program again. The code execution should now run in the specified folder.

::: moniker-end
::: moniker range="vs-2019"

1. In **Solution Explorer**, right-click the Python (_.py_) Startup File and select **Debug and Launch Settings**:

   :::image type="content" source="media/quickstart-open-folder/debug-launch-settings.png" alt-text="Screenshot that shows how to select the Debug and Launch Settings option for a selected file in Solution Explorer in Visual Studio." border="false" lightbox="media/quickstart-open-folder/debug-launch-settings.png" :::

1. In the **Select Debugger** dialog, select the **Default** option in the list, and then choose **Select**:

   :::image type="content" source="media/quickstart-open-folder/select-debugger.png" alt-text="Screenshot that shows how to select the Default Debugger in the Select a Debugger dialog in Visual Studio." border="false" lightbox="media/quickstart-open-folder/select-debugger.png":::

   > [!NOTE]
   > If you don't see **Default** as an option, be sure to choose a Python _.py_ file when you select the **Debug and Launch Settings** command. Visual Studio uses the file type to determine which debugger options to display.

1. Visual Studio opens a file named _launch.vs.json_, which is located in the hidden _.vs_ folder. This file describes the debugging context for the project. To specify a working directory, add a value for the `"workingDirectory"` property. For the `python-koans` example, you can add the property and value, `"workingDirectory": "python3"`:

   ```json
   {
     "version": "0.2.1",
     "defaults": {},
     "configurations": [
       {
         "type": "python",
         "interpreter": "(default)",
         "interpreterArguments": "",
         "scriptArguments": "",
         "env": {},
         "nativeDebug": false,
         "webBrowserUrl": "",
         "project": "contemplate_koans.py",
         "projectTarget": "",
         "name": "contemplate_koans.py",
         "workingDirectory": "python3"
       }
     ]
   }
   ```

1. Save your changes to the _launch.vs.json_ file.

1. Run your program again. The code execution should now run in the specified folder.

::: moniker-end

## Related content

- [Quickstart: Create Python project from existing code](quickstart-01-python-in-visual-studio-project-from-existing-code.md)
- [Quickstart: Create Python project from a repository](quickstart-03-python-in-visual-studio-project-from-repository.md)
- [Tutorial: Work with Python in Visual Studio](tutorial-working-with-python-in-visual-studio-step-01-create-project.md)
