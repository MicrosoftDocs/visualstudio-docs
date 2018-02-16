---
title: "Customize your codebase in Visual Studio with tasks.vs.json, launch.vs.json, and vsworkspacesettings.json | Microsoft Docs"
ms.date: 02/14/2018
ms.reviewer: ""
ms.technology: vs-ide-general
ms.topic: "article"
helpviewer_keywords:
  - customize codebases [Visual Studio]
  - tasks file [Visual Studio]
  - launch file [Visual Studio]
  - vsworkspacesettings file [Visual Studio]
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload:
  - "multiple"
---
# Customize your codebase

Visual Studio knows how to run many different languages, but it doesn't know how to run everything. If Visual Studio knows how to run your language, you can run the code right away. If you try to run your code but Visual Studio doesn't know how to run it, an information bar prompts you to designate a file in your codebase to act as the startup item.

If the codebase uses custom build tools that Visual Studio doesn't recognize, though, then you will likely not be able to run and debug the code in Visual Studio until you complete some additional steps. You must specify a valid executable file type, such as a compiler, along with any custom parameters and arguments required by the language. To enable this, Visual Studio provides *build tasks*. You can create a build task to specify all the items a language needs to build and run its code. You can also create more targeted custom build tasks that do things such as compile and build your project using specific arguments.

You can also create arbitrary tasks that can do nearly anything you want. For example, you can create a task to list the contents of a folder or rename a file.

You can customize your project-less codebase by using three JSON files:

|File name|Purpose|
|-|-|
|tasks.vs.json]|Specify custom build commands and compiler switches, and arbitrary (non-build related) tasks.<br>Accessed via the **Solution Explorer** context menu item **Configure Tasks**.|
|launch.vs.json|Specify command line arguments for debugging.<br>Accessed via the **Solution Explorer** context menu item **Debug and Launch Settings**.|
|VSWorkspaceSettings.json|Generic settings that may impact tasks and launch. For example, defining `envVars` in VSWorkspaceSettings.json adds the specified environment variables to externally run commands.<br>You create this file manually.|

The JSON files are located in a hidden folder called `.vs` in your root project folder. The **tasks** and **launch** files are created by Visual Studio on an as-needed basis when you choose either **Configure Tasks** or **Debug and Launch Settings** from the Solution Explorer context menu. These .json files are hidden because most users generally don't want to check them into source control. However, if you want to be able to check them into source control, drag the files into the root of your project where they will be visible.

> [!TIP]
> To view hidden files in Visual Studio, choose the **Show All Files** button on the Solution Explorer toolbar.

## Define tasks with tasks.vs.json

You can automate build scripts or any other external operations on the files you have in your current workspace by running them as tasks directly in the IDE. You can configure a new task by right-clicking on a file or folder and selecting **Configure Tasks**.

![Open Folder Configure Tasks](../ide/media/configure_tasks.png)

This creates (or opens) the `tasks.vs.json` file in the .vs folder. You can define a build task or arbitrary task in this file, and then invoke it using the name you gave it from the **Solution Explorer** context menu.

### Define custom build tasks in tasks.vs.json

If your codebase uses custom build tools that Visual Studio doesn't recognize, then you will likely not be able to run and debug the code in Visual Studio until you complete some additional steps. You must specify a valid executable file type, such as a compiler, along with any custom parameters and arguments required by the language. To enable this, Visual Studio provides *build tasks*. In this procedure, we will add two custom build tasks that use nMake to build and clean your code.

1. Choose a file in Solution Explorer that you want to designate later as the startup item. On the file's context (right-click) menu, choose **Configure Tasks**.

  ![Custom build task command](./media/VSIDE_Code_Tasks_CustTask1.png)

   The tasks.vs.json file opens in the editor.

1. Add the following build tasks to tasks.vs.json. For this example, we'll add two tasks: one called "makefile-build" which uses the nMake command to build the project, the other called "makefile-clean" which calls the nMake command with the "clean" argument. These tasks should be added within the existing "tasks" array. (Note that these are only example build tasks. For them to actually work, you need to have the Visual Studio workload that contains [nMake](/cpp/build/nmake-reference) installed on your system.)

  ```json
  {
    "taskName": "makefile-build",
    "appliesTo": "makefile",
    "type": "command",
    "contextType": "build",
    "command": "nmake"
  },
  {
    "taskName": "makefile-clean",
    "appliesTo": "makefile",
    "type": "command",
    "contextType": "clean",
    "command": "nmake",
    "args": [
      "clean"
    ]
  },
  ```
  The complete custom build task should look like this.

  ![Custom build task](./media/VSIDE_Code_Tasks_CustTask2.png)

1. Save the file.

1. Open the context menu for the selected file. The new custom build tasks should appear in the middle of the context menu.

  ![Custom build task command](./media/VSIDE_Code_Tasks_CustTask3.png)

  > [!NOTE]
  > The commands appear under the **Configure Tasks** command due to their `contextType` settings; "build" and "clean" are build commands, so they appear in the build section in the middle of the context menu.

1. Now that you have associated custom build commands with the file, you can designate the file as the startup item. On the file's context menu, choose **Set as Startup Item**.

  ![Custom build task command](./media/VSIDE_Code_Tasks_CustTask4.png)

1. On the toolbar, choose the dropdown arrow next to the Start button. The startup item now appears as an option.

  ![Custom build task command](./media/VSIDE_Code_Tasks_CustTask5.png)

You can now choose the **Start** button or the **F5** key to run your code. You can edit and debug your code in Visual Studio even though Visual Studio doesn't recognize the build tools of the codebase. Output from the build task appears in the **Output** window, and build errors appear in the **Error List**. The tasks.vs.json build task file couples the Visual Studio inner development loop to the custom build tools used by your codebase.

Custom build tasks can be added to individual files or to all files of a specific type. For instance, NuGet package files can be configured to have a "Restore Packages" task, or all source files can be configured to have a static analysis task, such as a linter for all .js files.

### Define arbitrary tasks in tasks.vs.json

The following example shows a tasks.vs.json file that defines a single task. When invoked, the task displays the filename of the currently selected .js file. `taskName` defines the name that appears in the context menu. `appliesTo` defines which files the command can be performed on. The `command` property refers to the COMSPEC environment variable, which identifies the path for the console (cmd.exe on Windows). The `args` property specifies the command line to be invoked. The `${file}` macro retrieves the selected file in **Solution Explorer**.

```json
{
  "version": "0.2.1",
  "tasks": [
    {
      "taskName": "Echo filename",
      "appliesTo": "*.js",
      "type": "default",
      "command": "${env.COMSPEC}",
      "args": ["echo ${file}"]
    }
  ]
}
```

After saving tasks.vs.json, you can right-click any .js file in the folder, choose **Echo filename** from the context menu, and see the file name displayed in the **Output** window.

#### To create an arbitrary task

1. Choose the file or folder of the project in Solution explorer where you want the task, and on the file or folder's context (right-click) menu, choose **Configure Tasks**.

  ![Configure tasks](./media/VSIDE_Code_Config_Task.png)

  Choosing **Configure Tasks** opens a file called tasks.vs.json. If this file doesn't exist, it is created. This file contains tasks for the selected file or folder.

  ![Tasks.vs.json file](./media/VSIDE_Code_Tasks_JSON.png)

1. Add the following task to the tasks.vs.json file. For this example, we'll add a simple task called "List outputs" that lists files and subfolders of the selected folder in the **Output** window. (The new task should be added within the existing `tasks` array.)

   ```json
   {
      "taskName": "List outputs",
      "appliesTo": "*",
      "type": "command",
      "command": "${env.COMSPEC}",
      "args": [ "dir ${outDir}" ]
   },
   ```

  The complete task should look like this.

  ![Arbitrary task](./media/VSIDE_Code_Tasks_ArbTask.png)

1. Save the project.

1. Open the context menu for the selected folder. You should see the new arbitrary task appear at the bottom of the context menu.

1. Choose the **F5** key to begin debugging.
2. 
3. 

### Properties for tasks.vs.json

This section describes some of the properties you can specify in tasks.vs.json.

#### appliesTo

You can create tasks for any file or folder by specifying its name in the `appliesTo` field, for example `"appliesTo" : "hello.js"`. The following file masks can be used as values:
|||
|-|-|
|`"*"`| task is available to all files and folders in the workspace|
|`"*/"`| task is available to all folders in the workspace|
|`"*.js"`| task is available to all files with the extension .js in the workspace|
|`"/*.js"`| task is available to all files with the extension .js in the root of the workspace|
|`"src/*/"`| task is available to all subfolders of the "src" folder|
|`"makefile"`| task is available to all makefile files in the workspace|
|`"/makefile"`| task is available only to the makefile in the root of the workspace|

#### output

If your project needs to be compiled, you can add an additional property called `output` to the tasks.vs.json file. Here is an example:

```json
  "output": "${workspaceRoot}\\bin\\hellomake.exe"
```

Specifying the output location tells Visual Studio where to find the project's build output when you press **F5**.

#### Macros for tasks.vs.json

|||
|-|-|
|`${env.<VARIABLE>}`| Specifies any environment variable (for example,  ${env.PATH}, ${env.COMSPEC} and so on) that is set for the developer command prompt. For more information, see [Developer Command Prompt for Visual Studio](/dotnet/framework/tools/developer-command-prompt-for-vs).|
|`${workspaceRoot}`| The full path to the workspace folder (for example, "C:\sources\hello")|
|`${file}`| The full path of the file or folder selected to run this task against (for example, "C:\sources\hello\src\hello.js")|
|`${relativeFile}`| The relative path to the file or folder (for example, "src\hello.js")|
|`${fileBasename}`| The name of the file without path or extension (for example, "hello")|
|`${fileDirname}`| The full path to the file, excluding the filename (for example, "C:\sources\hello\src")|
|`${fileExtname}`| The extension of the selected file (for example,  ".js")|

#### Custom macros

To define a custom macro in tasks.vs.json, add a name:value pair prior to the task blocks. The following example defines a macro named `outDir` which is consumed in the `args` property:

```json
{
"version": "0.2.1",
  "outDir": "${workspaceRoot}\\bin",
  "tasks": [
    {
      "taskName": "List outputs",
      "*",
      "type": "command",
      "command": "${env.COMSPEC}",
      "args": [
        "dir ${outDir}"
      ]
    }
  ]
```

## Configure debugging arguments with launch.vs.json

To customize your program’s command line arguments for debugging, right-click on the executable in **Solution Explorer** and select **Debug and Launch Settings**. If a file named `launch.vs.json` already exists, it is opened. Otherwise, Visual Studio creates a new `launch.vs.json` file that is pre-populated with information about the program you have selected.

To specify additional command line arguments, add them in the `args` array as shown in the following example:

```json
{
  "version": "0.2.1",
  "defaults": {},
  "configurations": [
    {
      "type": "default",
      "project": "7zip\\Bundles\\Alone\\O\\7za.exe",
      "name": "7za.exe list content of helloworld.zip",
      "args": [ "l", "d:\\sources\\helloworld.zip" ]
    }
  ]
}
```

When you save this file, the new configuration appears in the debug target drop-down list, and you can select it to start the debugger. You can create as many debug configurations as you like, for any number of executables. If you press **F5**, the debugger launches and hits any breakpoint you may have already set. All the familiar debugger windows are available and functional.

> [!NOTE]
> The`configuration` array property in launch.vs.json is unioned for two file locations&mdash;the root directory for the codebase, and the **.vs** directory. In case of a conflict, priority is given to the value in **.vs\launch.vs.json**.

## Define workspace settings in VSWorkspaceSettings.json


## Scope of settings

Visual Studio uses a concept of *scopes* that enable settings to be aggregated or overridden throughout the codebase. sMultiple  **tasks.vs.json** files can exist at the root and subdirectories of a folder, but their content is only applied in their directory and its subdirectories. If there are overlapping “cones” of settings, then priority is given to the file that is deepest n the directory structure.

## See also

- [Develop code without projects or solutions](../ide/develop-code-in-visual-studio-without-projects-or-solutions.md)
- [Open Folder projects for C++](/cpp/ide/non-msbuild-projects)
- [CMake projects in C++](/cpp/ide/cmake-tools-for-visual-cpp)
- [Writing code in the code and text editor](../ide/writing-code-in-the-code-and-text-editor.md)