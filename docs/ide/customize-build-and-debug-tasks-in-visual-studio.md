---
title: Create build and debug tasks with JSON files
description: Create build and debug tasks with JSON files to instruct Visual Studio how to process code that it doesn't recognize.
ms.date: 08/13/2024
ms.topic: how-to
helpviewer_keywords:
- NMAKE [Visual Studio]
- makefiles [Visual Studio]
- customize codebases [Visual Studio]
- tasks.vs.json file [Visual Studio]
- launch.vs.json file [Visual Studio]
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide

#customer intent: As a developer, I want to define build and debug tasks with JSON files in Visual Studio so I can quickly run and debug unrecognized codebases.
---

# Create build and debug tasks for "Open Folder" development

Visual Studio can automatically run many different programming languages and codebases. The [**Open Folder**](../ide/develop-code-in-visual-studio-without-projects-or-solutions.md) option lets you immediately run code for a recognized codebase without special instructions and without creating a project. Developers commonly use this approach for quick testing.

Some codebases require custom build tools that Visual Studio doesn't recognize or can't immediately process with the **Open Folder** option. For these scenarios, you can define *build tasks* to instruct Visual Studio how to build and debug the code. The build tasks specify all the items a language needs to build and run the code, and can be used to complete nearly any required operation.

This article describes how to define build tasks to configure build and debug settings for an unrecognized, project-less code base in Visual Studio.

## Explore JSON configuration files

To customize a project-less codebase, Visual Studio provides two JSON (*.json*) files for configuration settings: *tasks* and *launch*. Visual Studio creates (or opens) these files on an as-needed basis, when you select specific options in Visual Studio **Solution Explorer**.

The following table describes the JSON files and how to create them in **Solution Explorer**.

| JSON file | Configuration purpose | File access |
| --- | --- | --- |
| *tasks.vs.json* | Define custom build commands, custom compiler switches, and arbitrary (nonbuild related) tasks. | In **Solution Explorer**, right-click a file or folder to open the context menu, and select **Configure Tasks**. |
| *launch.vs.json* | Specify command-line arguments for debugging. | In **Solution Explorer**, right-click a file or folder to open the context menu, and select **Add Debug Configuration**. |

### Add JSON files to source control

By default, the *tasks* and *launch* JSON files aren't visible in **Solution Explorer**. The files are located in a hidden folder named *.vs* in the root (\\) folder of your codebase. The files are hidden because they aren't commonly added to source control. You can view hidden files in Visual Studio by selecting the **Show All Files** option in **Solution Explorer**.

If you want to add the JSON files to source control, drag the files to the root (\\) folder of your codebase in your file system. The files become visible in **Solution Explorer** and available to source control.

## Define tasks with tasks.vs.json

You can automate build scripts and external operations on files in your current workspace by running the actions as tasks directly in Visual Studio. To configure a new task, right-click a file or folder in **Solution Explorer** and select **Configure Tasks**:

:::image type="content" source="../ide/media/customize-configure-tasks-menu.png" border="false" alt-text="Screenshot that shows how you can configure tasks to automate build scripts and external operations on files in Solution Explorer." lightbox="../ide/media/customize-configure-tasks-menu.png":::

This action creates (or opens) the *tasks.vs.json* file in the *.vs* folder. You define a build task or arbitrary task in this file, and Visual Studio adds the name of the task as a command to the **Solution Explorer** right-click menu. You can invoke the task by selecting the corresponding command in **Solution Explorer**.

Custom tasks can be added to individual files, or to all files of a specific type. For instance, NuGet package files can be configured to have a "Restore Packages" task, or all source files can be configured to have a static analysis task, such as a linter for all JavaScript (*.js*) files.

### Create tasks for unrecognized tools

If your codebase uses custom build tools that are unrecognized by Visual Studio, you can't run and debug the code in Visual Studio until you complete extra configuration steps.

You can define *build tasks* to instruct Visual Studio how to build, rebuild, and clean your code. The *tasks.vs.json* file combines the Visual Studio inner development loop with the custom build tools you define for your codebase.

Suppose your codebase has a single C# file named *hello.cs*. The *makefile* for such a codebase might look like this example:

<!-- markdownlint-disable MD010 -->
```makefile
build: directory hello.exe

hello.exe: hello.cs
    csc -debug hello.cs /out:bin\hello.exe

clean:
    del bin\hello.exe bin\hello.pdb

rebuild: clean build

directory: bin

bin:
    md bin
```
<!-- markdownlint-enable MD010 -->

For a similar *makefile* that contains build, clean, and rebuild targets, you can use the **Configure Tasks** option for the *makefile* and define the following *tasks.vs.json* file. The JSON file defines tasks to build, rebuild, and clean the codebase by using NMAKE as the build tool:

```json
{
  "version": "0.2.1",
  "outDir": "\"${workspaceRoot}\\bin\"",
  "tasks": [
    {
      "taskName": "makefile-build",
      "appliesTo": "makefile",
      "type": "launch",
      "contextType": "build",
      "command": "nmake",
      "args": [ "build" ],
      "envVars": {
        "VSCMD_START_DIR": "\"${workspaceRoot}\""
      }
    },
    {
      "taskName": "makefile-clean",
      "appliesTo": "makefile",
      "type": "launch",
      "contextType": "clean",
      "command": "nmake",
      "args": [ "clean" ],
      "envVars": {
        "VSCMD_START_DIR": "\"${workspaceRoot}\""
      }
    },
    {
      "taskName": "makefile-rebuild",
      "appliesTo": "makefile",
      "type": "launch",
      "contextType": "rebuild",
      "command": "nmake",
      "args": [ "rebuild" ],
      "envVars": {
        "VSCMD_START_DIR": "\"${workspaceRoot}\""
      }
    }
  ]
}
```

After you define build tasks in the *tasks.vs.json* file, Visual Studio adds the corresponding task commands to the right-click menu in **Solution Explorer**. In this example, the **Build**, **Rebuild**, and **Clean** options are added to the right-click menu for instances of *makefile* in the codebase:

:::image type="content" source="media/customize-build-rebuild-clean.png" border="false" alt-text="Screenshot that shows the Build, Rebuild, and Clean tasks for a makefile added to the right-click menu in Solution Explorer." lightbox="media/customize-build-rebuild-clean.png":::

Visual Studio lists the new commands on the right-click menu after the **Configure Tasks** command according to their `contextType` settings. "build", "rebuild", and "clean" are **Build** commands and are listed within the "Build" section of the right-click menu.

When you select a custom task command on the right-click menu, the operation executes. Visual Studio shows command output in the **Output** window and any build errors in the **Error List**.

### Create tasks for arbitrary operations

You can define custom tasks in the *tasks.vs.json* file for any arbitrary operation. You might define a task to display the name of the currently selected file in the **Output** window or list the files in a specified folder.

#### Example: Display name of currently selected file

The following example shows a *tasks.vs.json* file that defines a single arbitrary task. When you invoke this task, the operation displays the filename of the currently selected JavaScript (*.js*) file.

```json
{
  "version": "0.2.1",
  "tasks": [
    {
      "taskName": "Echo filename",
      "appliesTo": "*.js",
      "type": "default",
      "command": "${env.COMSPEC}",
      "args": [ "echo ${file}" ]
    }
  ]
}
```

The code for this task defines the following properties:

- `taskName`: The task command name for Visual Studio to display in the right-click menu. In this case, **Echo filename**.
- `appliesTo`: The files for the task command to act upon. In this case, JavaScript (*.js*) files.
- `command`: The command to invoke. This task uses the `COMSPEC` environment variable to identify the command line interpreter (typically *cmd.exe*).
- `args`: Any arguments to pass when Visual Studio invokes the command.
- `${file}`: The arguments for this task include a macro that retrieves the file currently selected in **Solution Explorer**.

After you save the *tasks.vs.json* file, you can right-click any JavaScript (*.js*) file in the folder and select **Echo filename**. Visual Studio displays the selected file name in the **Output** window.

#### Example: List files and subfolders

The following example shows a *tasks.vs.json* file that defines a task to list the files and subfolders of the *bin* folder:

```json
{
  "version": "0.2.1",
  "outDir": "\"${workspaceRoot}\\bin\"",
  "tasks": [
    {
      "taskName": "List Outputs",
      "appliesTo": "*",
      "type": "default",
      "command": "${env.COMSPEC}",
      "args": [ "dir ${outDir}" ]
    }
  ]
}
```

The code for this task defines the following properties:

- `taskName`: The task command name for the right-click menu, **List Outputs**. 
- `appliesTo`: This task acts on all items in the specified folder, as indicated by the use of the wildcard (\*).
- `command`: Similar to the previous example, the task uses the `COMSPEC` environment variable to identify the command line interpreter (*cmd.exe*).
- `args`: When Visual Studio invokes the task, it passes a call to the `dir` command, which lists the directory (folder) items.
- `${outDir}`: The `{outDir}` macro is defined before the `tasks` block. It identifies the *bin* folder as the directory to act on.

This task applies to all files in the codebase. When Visual Studio adds the command name for an arbitrary task to the right-click menu, it prefixes the command with **Run**, as in **Run List Outputs**.

If you open the right-click menu for any file in **Solution Explorer**, the task command **Run List Outputs** appears as the last command in the "Build" section of the menu. When you select **Run List Outputs**, Visual Studio lists the contents of the *bin* folder for the codebase in the **Output** window:

:::image type="content" source="../ide/media/customize-arbitrary-task-menu.png" border="false" alt-text="Screenshot that shows an arbitrary task added to the right-click menu in Visual Studio Solution Explorer." lightbox="../ide/media/customize-arbitrary-task-menu.png":::

### Use multiple task.vs.json files 

You can have multiple *tasks.vs.json* files at the root (\\) folder and subfolders of your codebase. This approach gives you flexibility to define different behavior for specific subfolders or files in your codebase.

Visual Studio aggregates or overrides settings throughout the codebase and prioritizes files in the following order:

1. Settings files in the *.vs* folder in the root (\\) folder.
1. The folder where a setting is computed.
1. The parent folder of the current folder, up to and including the root (\\) folder.
1. Settings files in the root (\\) folder.

These aggregation rules apply only to instances of the *tasks.vs.json* file.

### Examine properties for tasks.vs.json

The following sections describe some of the properties you can specify in a *tasks.vs.json* file.

#### Set the appliesTo property

You can create tasks for any file or folder by specifying the file or folder name with the `appliesTo` property, such as `"appliesTo": "hello.js"`.

The following table summarizes the file mask values you can use with the `appliesTo` property to produce specific task behavior:

| Value (file mask) | Task applies to |
| --- | --- |
| `"*"`         | All files and folders in the workspace |
| `"*/"`        | All folders in the workspace |
| `"*.js"`      | All files with the JavaScript (*.js*) extension in the workspace  |
| `"/*.js"`     | All files with the JavaScript (*.js*) extension in the root (\\) folder of the workspace  |
| `"src/*/"`    | All subfolders of the *src* folder |
| `"makefile"`  | All files named *makefile* in the workspace  |
| `"/makefile"` | Only the file named *makefile* in the root (\\) folder of the workspace |

#### Use macros in task arguments

You can pass macros as arguments for a task to augment the task behavior when Visual Studio invokes the command.

The following table lists some macro examples:

| Macro | Description | Examples |
| --- | --- | --- |
| `${env.<VARIABLE>}` | Specifies any environment variable usable in the developer command prompt. For more information, see [Developer Command Prompt and Developer PowerShell](../ide/reference/command-prompt-powershell.md). | `${env.PATH}`, `${env.COMSPEC}` |
| `${workspaceRoot}`  | Provides the full path to the workspace folder. | `C:\sources\hello`, `C:\sources\hello\bin` |
| `${file}`           | Provides the full path to the file or folder. | `C:\sources\hello\src\hello.js*`, `C:\sources\hello\src\test.js*` |
| `${relativeFile}`   | Provides the relative path to the file or folder. | `src\hello.js*`, `bin\hello.exe` |
| `${fileBasename}`   | Provides the name of the file, excluding the path or extension. | `hello`, `test` |
| `${fileDirname}`    | Provides the full path to the file, excluding the filename. | `C:\sources\hello\src*`, `C:\sources\hello\bin\test\*` |
| `${fileExtname}`    | Provides the extension of the selected file. | `.js`, `.cs`, `.exe` |

## Configure debugging with launch.vs.json

Visual Studio provides a *launch.vs.json* file that you can use to configure debugging for your codebase.

> [!NOTE]
> To configure CMake projects for debugging, see [Configure CMake debugging sessions](/cpp/build/configure-cmake-debugging-sessions).

1. In **Solution Explorer**, right-click an executable (*.exe*) file and select **Add Debug Configuration**:

   :::image type="content" source="media/customize-debug-launch-menu.png" border="false" alt-text="Screenshot that shows how to select the 'Add Debug Configuration' option on the right-click menu in Solution Explorer.":::

1. In the **Select a Debugger** dialog, select a debug configuration option from the list, and then choose **Select**:

   :::image type="content" source="media/customize-select-a-debugger.png" border="false" alt-text="Screenshot that shows how to select a debugger for the launch configuration in Solution Explorer.":::

   If the *launch.vs.json* file doesn't already exist, Visual Studio creates the file. Here's an example of the file created for the *hello.exe* executable:

   ```json
   {
     "version": "0.2.1",
     "defaults": {},
     "configurations": [
       {
         "type": "default",
         "project": "bin\\hello.exe",
         "projectTarget": "",
         "name": "hello.exe"
       }
     ]
   }
   ```

1. After you have a *launch* file, right-click the executable file for your codebase in **Solution Explorer**, and select **Set as Startup Item**.

   The executable is designated as the startup item for your codebase, and Visual Studio sets the label for the debugging **Start** button to reflect the name of your executable:

   :::image type="content" source="media/customize-start-button.png" border="false" alt-text="Screenshot that shows a custom label for the Startup action in Visual Studio." lightbox="media/customize-start-button.png":::

   When you start the debugger with **F5**, Visual Studio starts debugging your code and stops at any set breakpoint. All the familiar debugger windows are available and functional.

   For more information about custom build and debug tasks in C++ open folder projects, see [Open Folder support for C++ build systems in Visual Studio](/cpp/build/open-folder-projects-cpp).

### Specify arguments for debugging

You can specify command-line arguments to pass in to the debugger in the *launch.vs.json* file. Add the arguments in the `args` array, as shown in the following example:

```json
{
  "version": "0.2.1",
  "defaults": {},
  "configurations": [
    {
      "type": "default",
      "project": "bin\\hello.exe",
      "name": "hello.exe"
    },
    {
      "type": "default",
      "project": "bin\\hello.exe",
      "name": "hello.exe a1",
      "args": [ "a1" ]
    }
  ]
}
```

### Launch a debug configuration

You can create as many debug configurations as you like. When you save the *launch* file, the configuration names are added to the debug target dropdown list. You can select a specific target to start the debugger:

:::image type="content" source="media/customize-debug-configurations.png" border="false" alt-text="Screenshot that shows available configurations in the Debug target dropdown list in Visual Studio Solution Explorer.":::

If you don't see the extra targets on the menu, select the **Show/Hide Debug Targets** and configure the visible targets.

### Understand precedence for configurations

Visual Studio scans two locations for the items specified in the `configurations` array property in *launch.vs.json* files:

- The root (\\) folder for the codebase
- The *.vs* folder

If you have *launch.vs.json* files in both locations, and there's a conflict in the definition for a configuration, the value in the *.vs\launch.vs.json* file takes precedence.

## Use other settings files

In addition to the *task* and *launch* JSON files, Visual Studio reads settings from other configuration files defined in your codebase. Two commonly used files include *settings.json* and *.gitignore*.

### Define code settings with .vscode\settings.json

Visual Studio reads limited settings from a file named *settings.json*, when the file is located in a folder named *.vscode*.

This functionality is provided for codebases previously developed in Visual Studio Code. Currently, the only setting read from the *.vscode\settings.json* file is `files.exclude`. This setting is used to filter files visually in **Solution Explorer** and from some search tools.

You can have multiple *.vscode\settings.json* files in your codebase. Settings read from this file are applied to the parent folder of *.vscode* and all of its subfolders.

### Configure Git files with .gitignore

You can use a *.gitignore* file to let Git know which files to ignore when applying source control. The *.gitignore* files are commonly included as part of a codebase so the settings can be shared with all developers of the codebase. Visual Studio reads patterns in *.gitignore* files to filter items visually and from some search tools.

Settings read from the *.gitignore* file are applied to its parent folder and all subfolders.

## Related content

- [Develop code without projects or solutions](../ide/develop-code-in-visual-studio-without-projects-or-solutions.md)
- [Open Folder projects for C++](/cpp/build/open-folder-projects-cpp)
- [Explore code editor features](../ide/writing-code-in-the-code-and-text-editor.md)
