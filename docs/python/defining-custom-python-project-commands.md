---
title: Define custom commands for Python projects
description: Add custom commands to the Python project menu in Visual Studio and invoke executable programs, scripts, modules, inline code snippets, and pip.
ms.date: 04/18/2024
ms.topic: how-to
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

# CustomerIntent: As a developer, I want to define custom commands for Python projects in Visual Studio so I can quickly run scripts, modules, inline code snippets, and more.
---

# Define custom commands for Python projects in Visual Studio

As you develop your Python projects, you might find yourself switching to a command window to run specific scripts or modules, run pip commands, or use other tools with your code. To improve your workflow, you can add custom commands to the **Python** project menu in Visual Studio. The custom Python commands can run in a console window or in the Visual Studio **Output** window. You can also use regular expressions to instruct Visual Studio how to parse errors and warnings from the command output.

## Prerequisites 

- Visual Studio on Windows installed with support for Python workloads. For more information, see [Install Python support in Visual Studio](installing-python-support-in-visual-studio.md).

Visual Studio for Mac isn't supported. For more information, see [What's happening to Visual Studio for Mac?](/visualstudio/mac/what-happened-to-vs-for-mac) Visual Studio Code on Windows, Mac, and Linux [works well with Python through available extensions](https://code.visualstudio.com/docs/languages/python).

## Explore custom commands

By default, the **Python** project menu contains two commands, **Run PyLint** and **Run Mypy**:

::: moniker range=">=vs-2022"

:::image type="content" source="media/vs-2022/custom-commands-default-menu.png" alt-text="Screenshot that shows the default commands on the Python project menu in Visual Studio 2022." border="false" lightbox="media/vs-2022/custom-commands-default-menu.png":::

::: moniker-end
::: moniker range="<=vs-2019"

:::image type="content" source="media/custom-commands-default-menu.png" alt-text="Screenshot that shows the default commands on the Python project menu in Visual Studio." border="false" lightbox="media/custom-commands-default-menu.png":::

::: moniker-end

Any custom Python commands that you define appear in this same menu. A custom command can refer to a Python file, a Python module, inline Python code, an arbitrary executable, or a pip command. You can also specify how and where the command runs.

You can add custom commands in several ways:

- Define custom commands in a Python project file (_.pyproj_) directly. These commands apply to that specific project.
- Define custom commands in a targets file (_.targets_). You can easily import the commands in this file to use them with multiple projects.
- Create a Python project from a project template in Visual Studio that defines custom Python commands.

   Certain Python project templates in Visual Studio add custom commands by using a targets file. The Bottle Web Project and Flask Web Project templates add two commands, **Start server** and **Start debug server**. The Django Web Project template adds these commands and several more:

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/custom-commands-django-menu.png" alt-text="Screenshot that shows the custom commands added for a Django project to the Python project menu in Visual Studio 2022." border="false" lightbox="media/vs-2022/custom-commands-django-menu.png":::

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/custom-commands-django-menu.png" alt-text="Screenshot that shows the custom commands added for a Django project to the Python project menu in Visual Studio." border="false" lightbox="media/custom-commands-django-menu.png":::

   ::: moniker-end

### Reload project to access custom commands

When a project is open in Visual Studio, if you make changes to the corresponding project file in an editor, you must reload the project to apply the changes. In a similar manner, after you define custom Python commands in a Python project file, you need to reload the Python project for the commands to appear on the **Python** project menu. When you modify custom commands defined in a targets file, you need to rebuild the full Visual Studio solution for any project that imports that targets file.

A common approach is to make the changes to the Python project file directly in Visual Studio:

1. Open your Python project in Visual Studio. (When you open a project in Visual Studio, the project is _loaded_ by default.)

1. In **Solution Explorer**, right-click the Python project and select **Unload Project**.

   Visual Studio unloads the project and opens the corresponding Python project file (_.pyproj_) in the editor.

   If the project file doesn't open, right-click the Python project again and select **Edit Project File**:

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/custom-commands-edit-unloaded-project.png" alt-text="Screenshot that shows how to edit an unloaded project file to add custom commands in Visual Studio." border="false" lightbox="media/vs-2022/custom-commands-edit-unloaded-project.png":::

   ::: moniker-end

1. Make your changes to the project file in the Visual Studio editor and save your work.

1. In **Solution Explorer**, right-click the unloaded project and select **Reload Project**. If you try to reload the project without saving your changes to the project file, Visual Studio prompts you to complete the action.

The unload-edit-save-reload process can become tedious when you're developing custom commands. A more efficient workflow involves simultaneously loading the project in Visual Studio and opening the Python project file in a separate editor. You can use any editor, such as another instance of Visual Studio, Visual Studio Code, Notepad, and so on. After you save your changes in the editor and switch back to Visual Studio, Visual Studio detects the project file changes for the open project and prompts you to take action:

::: moniker range=">=vs-2022"

:::image type="content" source="media/vs-2022/custom-commands-reload-project-prompt.png" alt-text="Screenshot that shows the Visual Studio prompt after it detects changes to the project file for an open project." border="false" lightbox="media/vs-2022/custom-commands-reload-project-prompt.png":::

::: moniker-end

Select **Reload** or **Reload All** and Visual Studio immediately applies your project file changes to the open project.

## Add custom commands with project file

The following procedure shows how to create a custom command by adding the definition in the Python project file (_.pyproj_) and reloading your project in Visual Studio. The custom command runs a project's startup file directly by using the `python.exe` command, which is basically the same as using the **Debug** > **Start without Debugging** option on the main Visual Studio toolbar.

1. In Visual Studio, create a new Python project named _Python-CustomCommands_ by using the **Python Application** template. For instructions, see [Quickstart: Create a Python project from a template](quickstart-02-python-in-visual-studio-project-from-template.md).

   Visual Studio creates the Python project and loads it into your session. You can configure the project through the project file (_.pyproj_). This file is only visible in Visual Studio when the project is open, but _unloaded_. The project also has a Python file (_.py_) for the application code.

1. Open the _Python\_CustomCommands.py_ application file in the editor and add the following code:

   ```python
   print("Hello custom commands")
   ```

1. In **Solution Explorer**, right-click the Python project, select **Python**, and notice the commands on the context menu. Currently, the only commands on the context menu are **Run PyLint** and **Run Mypy**. When you define custom commands, they also appear on this menu.

1. Launch a separate editor outside of your Visual Studio session, and open the Python project file (_Python-CustomCommands.pyproj_) in the editor. (Be sure to open the project file (_.pyproj_) and not the Python application file (_.py_).)

1. In the project file, locate the closing `</Project>` element at the end of the file, and add the following XML immediately before the closing element: 

   <a name="property-group-python-commands"></a>

   ```xml
   <PropertyGroup>
     <PythonCommands>
       $(PythonCommands);
     </PythonCommands>
   </PropertyGroup>
   ```

1. Save your project file changes, and switch back to Visual Studio. Visual Studio detects your project file changes and prompts you to take action. At the prompt, select **Reload** to update your open project with the project file changes.

1. In **Solution Explorer**, right-click the Python project, select **Python**, and check the commands on the context menu. 

   The context menu still shows only the **Run PyLint** and **Run Mypy** commands. The code you just added to the project file simply replicates the default `<PythonCommands>` property group that contains the **PyLint** command. In the next step, you add more code for the custom command.

1. Switch to the editor where you're updating the project file. Add the following `<Target>` element definition within the `<Project>` element. You can position the `<Target>` definition before or after the `<PropertyGroup>` definition described earlier.

   <a name="target-execute-in"></a>

   This `<Target>` element defines a custom command to run the startup file for the project (identified by the **StartupFile** property) by using the `python.exe` command in a console window. The attribute definition `ExecuteIn="consolepause"` uses a console that waits for you to select a key to close the console window.

   ```xml
   <Target Name="Example_RunStartupFile" Label="Run startup file" Returns="@(Commands)">
     <CreatePythonCommandItem
       TargetType="script"
       Target="$(StartupFile)"
       Arguments=""
       WorkingDirectory="$(MSBuildProjectDirectory)"
       ExecuteIn="consolepause">
       <Output TaskParameter="Command" ItemName="Commands" />
     </CreatePythonCommandItem>
   </Target>
   ```

1. Replace the `<PythonCommands>` property group (added in [step 5](#property-group-python-commands)) with the following XML. This syntax defines the `Name` attribute for the `<Target>` element, which adds the custom command to the **Python** context menu. The command has the menu label **Run startup file**.

   <a name="python-command-run-startup-file"></a>

   ```xml
     <PythonCommands>
       $(PythonCommands);
       Example_RunStartupFile
     </PythonCommands>
   ```

   > [!TIP]
   > If you want your custom command to appear on the context menu before the default commands defined in the `$(PythonCommands)` token, position the `<Target>` syntax for your command before that token.

1. Save your project file changes, and switch back to Visual Studio. At the prompt, reload your project.

1. In **Solution Explorer**, right-click the Python project, select **Python**, and recheck the commands on the context menu. 

   Now the custom **Run startup file** command is on the menu. If you don't see the custom command, confirm you added the `Name` attribute value for the `<Target>` element to the `<PythonCommands>` element as described in [step 9](#python-command-run-startup-file). Also review the considerations listed in the [Troubleshooting](#troubleshoot-custom-commands) section later in this article.

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/custom-commands-run-startup-file.png" alt-text="Screenshot that shows the Run startup file custom command on the Python context menu in Visual Studio 2022." border="false" lightbox="media/vs-2022/custom-commands-run-startup-file.png":::

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/custom-commands-walkthrough-menu-item.png" alt-text="Screenshot that shows the Run startup file custom command on the Python context menu in Visual Studio." border="false" lightbox="media/custom-commands-walkthrough-menu-item.png":::

   ::: moniker-end

1. Select the **Run startup file** command. A console window opens and displays the text **Hello custom commands** followed by **Press any key to continue**. Confirm the output and close the console window.

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/custom-commands-walkthrough-console.png" alt-text="Screenshot that shows the custom command output in a console window in Visual Studio." border="false" lightbox="media/custom-commands-walkthrough-console.png":::

   ::: moniker-end

   > [!NOTE]
   > The custom command script runs in the activated environment for your Python project.

1. Switch to the editor with the project file. In the `<Target>` element definition (added in [step 8](#target-execute-in)), change the value of the `ExecuteIn` attribute to `output`.

   ```xml
     <CreatePythonCommandItem
       ...
       ExecuteIn="output">
       ...
     </CreatePythonCommandItem>
   ```
   
1. Save your changes, switch back to Visual Studio, and reload your project.

1. Select the **Run startup file** custom command again from the **Python** context menu. Now the program output appears in the Visual Studio **Output** window rather than a console window:

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/custom-commands-output-window.png" alt-text="Screenshot that shows the custom command output displayed in the Visual Studio 2022 Output window." border="false" lightbox="media/vs-2022/custom-commands-output-window.png":::

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/custom-commands-walkthrough-output-window.png" alt-text="Screenshot that shows the custom command output displayed in the Visual Studio Output window." border="false" lightbox="media/custom-commands-walkthrough-output-window.png":::

   ::: moniker-end

1. To add more custom commands, follow this same process:

   1. Define a suitable `<Target>` element for the custom command in the project file.
   
   1. Add the `Name` attribute value for the `<Target>` element into the `<PythonCommands>` property group.
   
   1. Save your changes to the project file.
   
   1. Reload your project in Visual Studio.

### Use project properties

To refer to project properties or environment variables in `<Target>` element attribute values, use the property name within a `$()` token, such as `$(StartupFile)` and `$(MSBuildProjectDirectory)`. For more information, see [MSBuild properties](../msbuild/msbuild-properties.md).

If you invoke a command like `($StartupFile)` that uses project properties like the **StartupFile** property, and the command fails because the token is undefined, Visual Studio disables the command until you reload the project. If you make changes to the project that modify the property definition, your changes don't refresh the state of the related command. In this case, you still need to reload the project.

## Understand \<Target> element structure

You define the details for a custom command by using the `<Target>` element. The general form of the `<Target>` element is shown in the following pseudo-code:

```xml
<Target Name="Name1" Label="Display Name" Returns="@(Commands)">
    <CreatePythonCommandItem Target="filename, module name, or code"
        TargetType="executable/script/module/code/pip"
        Arguments="..."
        ExecuteIn="console/consolepause/output/repl[:Display name]/none"
        WorkingDirectory="..."
        ErrorRegex="..."
        WarningRegex="..."
        RequiredPackages="...;..."
        Environment="...">

      <!-- Output always appears in this form, with these exact attributes -->
      <Output TaskParameter="Command" ItemName="Commands" />
    </CreatePythonCommandItem>
  </Target>
```

### Target attributes

The following table lists the `<Target>` element attributes.

| Attribute | Required | Description |
| --- | --- | --- |
| `Name`      | Yes      | The identifier for the command within the Visual Studio project. This name must be added to the `<PythonCommands>` property group for the command to appear on the **Python** context  menu. |
| `Label`     | Yes      | The UI display name that appears in the **Python** context menu. |
| `Returns`   | Yes      | The information returned, which must contain the `@(Commands)` token, which identifies the target as a command. |

### CreatePythonCommandItem attributes

The `<Target>` element contains `<CreatePythonCommandItem>` and `<Output>` elements, which define the detailed behavior for the custom command. The following table lists the available `<CreatePythonCommandItem>` element attributes. All attribute values are case-insensitive.

| `Attribute`                  | Required | Description |
| --- | --- | --- |
| `TargetType`                 | Yes      | Specifies what the `Target` attribute contains and how the value is used along with the `Arguments` attribute: <br> - `executable`: Run the executable named in the `Target` attribute, appending the value in the `Arguments` attribute, as if entered directly on the command line. The value must contain only a program name without arguments. <br> - `script`: Run the `python.exe` command with the filename in the `Target` attribute, followed by the value in the `Arguments` attribute. <br> - `module`: Run the `python -m` command followed by the module name in the `Target` attribute, followed by the value in the `Arguments` attribute. <br> - `code`: Run the inline code contained in the `Target` attribute. Ignore the `Arguments` attribute value. <br> - `pip`: Run pip with the command in the `Target` attribute, followed by the value in the `Arguments` attribute. If the `ExecuteIn` attribute is set to `output`, pip assumes the request is to run the `install` command and uses the `Target` attribute as the package name. |
| `Target`                     | Yes      | Specifies the filename, module name, code, or pip command to use, depending on the value of the `TargetType` attribute. |
| `Arguments`                  | Optional | Provides a string of arguments (if any) to use with the `Target` attribute. <br> - When the `TargetType` attribute value is `script`, the `Arguments` value is supplied to the Python program rather than the `python.exe` command. <br> - When the `TargetType` attribute value is `code`, the `Arguments` value is ignored. |
| `ExecuteIn`                  | Yes      | Specifies the environment in which to run the command: <br> - `console`: (Default) Runs the `Target` attribute with the `Arguments` value as if they're entered directly on the command line. While the `Target` attribute is running, a command window appears and closes automatically. <br> - `consolepause`: Same behavior as `console`, but waits for a key press before closing the window. <br> - `output`: Runs the `Target` attribute and displays the results in the Visual Studio **Output** window. If the `TargetType` attribute is `pip`, Visual Studio uses the `Target` attribute as the package name and appends the `Arguments` attribute value. <br> - `repl`: Runs the `Target` attribute in the [Python Interactive Window](python-interactive-repl-in-visual-studio.md). The optional display name is used for the title of the window. <br> - `none`: Same behavior as `console`. |
| `WorkingDirectory`           | Optional | Identifies the folder in which to run the command. |
| `ErrorRegex` <br> `WarningRegEx` | Optional | Used only when the `ExecuteIn` attribute is set to `output`. Both attribute values specify a regular expression that Visual Studio uses to parse command output and show errors and warnings in the **Error List** window. If these attributes aren't specified, the command doesn't affect the **Error List** window. For more information on what Visual Studio expects, see [Named capture groups](#named-capture-groups-for-regular-expressions). |
| `RequiredPackages`           | Optional | Provides a list of package requirements for the command by using the same format as the [requirements.txt](https://pip.pypa.io/en/stable/user_guide/#requirements-files) file (pip.readthedocs.io). For example, the **Run PyLint** command specifies the format `pylint>=1.0.0`. Before you run the command, Visual Studio confirms all packages in the list are installed. Visual Studio uses pip to install any missing packages. |
| `Environment`                | Optional | Identifies a string of environment variables to define before running the command. Each variable uses the form `\<NAME>=\<VALUE>` with multiple variables separated by semicolons. A variable with multiple values must be contained in single or double quotes, as in `'NAME=VALUE1;VALUE2'`. |

#### Named capture groups for regular expressions

When Visual Studio parses errors and warnings from custom command output, it expects regular expressions in the `ErrorRegex` and `WarningRegex` attribute values to use the following named groups:

- `(?<message>...)`: Text of the error.
- `(?<code>...)`: Error code value.
- `(?<filename>...)`: Name of the file for which the error is reported.
- `(?<line>...)`: Line number of the location in the file for which the error is reported.
- `(?<column>...)`: Column number of the location in the file for which the error is reported.

For example, PyLint produces warnings of the following form:

```output
************* Module hello
C:  1, 0: Missing module docstring (missing-docstring)
```

To allow Visual Studio to extract the right information from these warnings and show them in the **Error List** window, the `WarningRegex` attribute value for the **Run Pylint** command is as follows:

```XML
^(?<filename>.+?)\((?<line>\d+),(?<column>\d+)\): warning (?<msg_id>.+?): (?<message>.+?)$]]
```

> [!NOTE]
> The `msg_id` syntax in the `WarningRegex` attribute value should actually be `code`, as described in [Issue 3680](https://github.com/Microsoft/PTVS/issues/3680).

## Import custom commands with targets file

If you define custom commands in a Python project file, the commands are available only to that specific project. When you want to create custom commands and use them in multiple projects, you can define the `<PythonCommands>` property group with all your `<Target>` elements in a targets file (_.targets_) and then import that file into your Python projects.

- The targets file uses the same format and syntax to define custom commands as described for the Python project file (_.pyproj_). The common elements to configure include `<PythonCommands>`, `<Target>`, `<CreatePythonCommandItem>`, and `<Output>`:

   ```xml
   <Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
     <PropertyGroup>
       <PythonCommands>
         $(PythonCommands);
         <!-- Additional command names -->
       </PythonCommands>
     </PropertyGroup>

     <Target Name="..." Label="..." Returns="@(Commands)">
       <!-- CreatePythonCommandItem and Output elements... -->
     </Target>

     <!-- Any number of additional Target elements-->
   </Project>
   ```

- To import a targets file into your project, add an `<Import Project="(path)">` element anywhere within the `<Project>` element in your project file.

   For example, if you have a project file named _CustomCommands.targets_ in a _targets_ folder within your Python project, add the following code to your project file:

   ```xml
   <Import Project="targets/CustomCommands.targets"/>
   ```

- If your project file imports a targets file, and you make changes to the targets file while your project is open in Visual Studio, you need to **Rebuild** the Visual Studio **solution** that contains your project, and not only your project.

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/custom-commands-rebuild-solution.png" alt-text="Screenshot that shows how to Rebuild the solution that contains the updated project in Visual Studio." border="false" lightbox="media/vs-2022/custom-commands-rebuild-solution.png":::

   ::: moniker-end

## Example commands

The following sections provide example code that you can use to define custom commands for your Python projects.

### Run PyLint (module target)

The following code appears in the _Microsoft.PythonTools.targets_ file:

```xml
<PropertyGroup>
  <PythonCommands>$(PythonCommands);PythonRunPyLintCommand</PythonCommands>
  <PyLintWarningRegex>
    <![CDATA[^(?<filename>.+?)\((?<line>\d+),(?<column>\d+)\): warning (?<msg_id>.+?): (?<message>.+?)$]]>
  </PyLintWarningRegex>
</PropertyGroup>

<Target Name="PythonRunPyLintCommand"
        Label="resource:Microsoft.PythonTools.Common;Microsoft.PythonTools.Common.Strings;RunPyLintLabel"
        Returns="@(Commands)">
  <CreatePythonCommandItem Target="pylint.lint"
                           TargetType="module"
                           Arguments="&quot;--msg-template={abspath}({line},{column}): warning {msg_id}: {msg} [{C}:{symbol}]&quot; -r n @(Compile, ' ')"
                           WorkingDirectory="$(MSBuildProjectDirectory)"
                           ExecuteIn="output"
                           RequiredPackages="pylint&gt;=1.0.0"
                           WarningRegex="$(PyLintWarningRegex)">
    <Output TaskParameter="Command" ItemName="Commands" />
  </CreatePythonCommandItem>
</Target>
```

### Run pip install with specific package (pip target)

The following command runs the `pip install my-package` command in the Visual Studio **Output** window. You might use a command like this when you develop a package and test its installation. The `<Target>` element contains the package name rather than the `install` command, which is assumed when you use the `ExecuteIn="output"` attribute definition.

```xml
<PropertyGroup>
  <PythonCommands>$(PythonCommands);InstallMyPackage</PythonCommands>
</PropertyGroup>

<Target Name="InstallMyPackage" Label="pip install my-package" Returns="@(Commands)">
  <CreatePythonCommandItem Target="my-package" TargetType="pip" Arguments=""
    WorkingDirectory="$(MSBuildProjectDirectory)" ExecuteIn="output">
    <Output TaskParameter="Command" ItemName="Commands" />
  </CreatePythonCommandItem>
</Target>
```

### Show outdated pip packages (pip target)

The following command runs pip with the `list` function to identify outdated pip packages:

```xml
<PropertyGroup>
  <PythonCommands>$(PythonCommands);ShowOutdatedPackages</PythonCommands>
</PropertyGroup>

<Target Name="ShowOutdatedPackages" Label="Show outdated pip packages" Returns="@(Commands)">
  <CreatePythonCommandItem Target="list" TargetType="pip" Arguments="-o --format columns"
    WorkingDirectory="$(MSBuildProjectDirectory)" ExecuteIn="consolepause">
    <Output TaskParameter="Command" ItemName="Commands" />
  </CreatePythonCommandItem>
</Target>
```

### Run executable with consolepause

The following command runs the `where` function to show the location of Python files starting from the project folder:

```xml
<PropertyGroup>
  <PythonCommands>$(PythonCommands);ShowAllPythonFilesInProject</PythonCommands>
</PropertyGroup>

<Target Name="ShowAllPythonFilesInProject" Label="Show Python files in project" Returns="@(Commands)">
  <CreatePythonCommandItem Target="where" TargetType="executable" Arguments="/r . *.py"
    WorkingDirectory="$(MSBuildProjectDirectory)" ExecuteIn="output">
    <Output TaskParameter="Command" ItemName="Commands" />
  </CreatePythonCommandItem>
</Target>
```

### Run server and run debug server commands

To explore how the **Start server** and **Start debug server** commands for web projects are defined, examine the [Microsoft.PythonTools.Web.targets](https://github.com/Microsoft/PTVS/blob/main/Python/Product/BuildTasks/Microsoft.PythonTools.Web.targets) repository on GitHub.

### Install package for development

The following code runs pip to install packages:

```xml
<PropertyGroup>
  <PythonCommands>PipInstallDevCommand;$(PythonCommands);</PythonCommands>
</PropertyGroup>

<Target Name="PipInstallDevCommand" Label="Install package for development" Returns="@(Commands)">
    <CreatePythonCommandItem Target="pip" TargetType="module" Arguments="install --editable $(ProjectDir)"
        WorkingDirectory="$(WorkingDirectory)" ExecuteIn="Repl:Install package for development">
      <Output TaskParameter="Command" ItemName="Commands" />
    </CreatePythonCommandItem>
  </Target>
```

*From [fxthomas/Example.pyproj.xml](https://gist.github.com/fxthomas/5c601e3e0c1a091bcf56aed0f2960cfa) (GitHub), used with permission.*

### Generate Windows installer

The following script generates a Windows installer:

```xml
<PropertyGroup>
  <PythonCommands>$(PythonCommands);BdistWinInstCommand;</PythonCommands>
</PropertyGroup>

<Target Name="BdistWinInstCommand" Label="Generate Windows Installer" Returns="@(Commands)">
    <CreatePythonCommandItem Target="$(ProjectDir)setup.py" TargetType="script"
        Arguments="bdist_wininst --user-access-control=force --title &quot;$(InstallerTitle)&quot; --dist-dir=&quot;$(DistributionOutputDir)&quot;"
        WorkingDirectory="$(WorkingDirectory)" RequiredPackages="setuptools"
        ExecuteIn="Repl:Generate Windows Installer">
      <Output TaskParameter="Command" ItemName="Commands" />
    </CreatePythonCommandItem>
  </Target>
```

*From [fxthomas/Example.pyproj.xml](https://gist.github.com/fxthomas/5c601e3e0c1a091bcf56aed0f2960cfa) (GitHub), used with permission.*

### Generate Python wheel package

The following script generates a [Python wheel](https://pythonwheels.com/) package:

```xml
<PropertyGroup>
  <PythonCommands>$(PythonCommands);BdistWheelCommand;</PythonCommands>
</PropertyGroup>

<Target Name="BdistWheelCommand" Label="Generate Wheel Package" Returns="@(Commands)">

  <CreatePythonCommandItem Target="$(ProjectDir)setup.py" TargetType="script"
      Arguments="bdist_wheel --dist-dir=&quot;$(DistributionOutputDir)&quot;"
      WorkingDirectory="$(WorkingDirectory)" RequiredPackages="wheel;setuptools"
      ExecuteIn="Repl:Generate Wheel Package">
    <Output TaskParameter="Command" ItemName="Commands" />
  </CreatePythonCommandItem>
</Target>
```

*From [fxthomas/Example.pyproj.xml](https://gist.github.com/fxthomas/5c601e3e0c1a091bcf56aed0f2960cfa) (GitHub), used with permission.* 

## Troubleshoot custom commands

Review the following sections for possible issues related to working with custom commands.

### Project file not loaded

This error message indicates that you have syntax errors in the project file. The message includes the specific error with a line number and character position.

### Console window closes after command runs

If the console window closes immediately after the command is run, use the `ExecuteIn="consolepause"` attribute definition instead of `ExecuteIn="console"`.

### Command missing from menu

If you don't see the custom command on the **Python** context menu, check the following items:

- Confirm the command is included in the `<PythonCommands>` property group.
- Verify that the command name as defined the command list matches the name specified in the `<Target>` element.

Here's an example. In the following XML snippet, the `Example` name in the `<PythonCommands>` property group doesn't match the `ExampleCommand` name in the `<Target>` element definition. Visual Studio doesn't find a command named `Example`, so no command appears. Either use `ExampleCommand` in the command list, or change the name of the target to be only `Example`.

```xml
  <PropertyGroup>
    <PythonCommands>$(PythonCommands);Example</PythonCommands>
  </PropertyGroup>
  <Target Name="ExampleCommand" Label="Example Command" Returns="@(Commands)">
    <!-- ... -->
  </Target>
```

### Error while running command, failed to get command target

This error message indicates that the contents of the `<Target>` or `<CreatePythonCommandItem>` elements are incorrect.

Here are some possible reasons for this error:

- The required `<Target>` element attribute is empty.
- The required `TargetType` attribute is empty or contains an unrecognized value.
- The required `ExecuteIn` attribute is empty or contains an unrecognized value.
- The `ErrorRegex` or `WarningRegex` attribute is specified without setting the `ExecuteIn="output"` attribute definition.
- Unrecognized attributes exist in the element. For example, the attribute reference might be misspelled as `Argumnets` rather than `Arguments`.

Attribute values can be empty if you refer to a property that's undefined. If you use the token `$(StartupFile)` but no startup file is defined in the project, the token resolves to an empty string. In such cases, you might want to define a default value. For example, the **Run server** and **Run debug server** commands defined in the Bottle, Flask, and Django project templates use the _manage.py_ file by default (if a server startup file isn't specified in the project properties).

### Visual Studio stops responding, crashes

If Visual Studio stops responding and crashes when you run the custom command, you're probably trying to run a console command with the `ExecuteIn="output"` attribute definition. In such cases, Visual Studio might crash when it tries to parse the output. To avoid this condition, use the `ExecuteIn="console"` attribute definition instead. For more information, see [Issue 3681](https://github.com/Microsoft/PTVS/issues/3682).

### Command not recognized as operable program or batch file

When you set the `TargetType="executable"` attribute definition, the value in the `Target` attribute must be *only* the program name without any arguments, such as `python` or `python.exe` only. In this case, move any arguments to the `Arguments` attribute.
