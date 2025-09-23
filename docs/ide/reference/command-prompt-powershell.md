---
title: Command-Line Shells & Prompt For Developers
description: Learn about the two command-line shells for developers in Visual Studio, the Developer Command Prompt and the Developer PowerShell.
author: Mikejo5000
ms.author: mikejo
ms.date: 09/23/2025
ms.topic: conceptual
helpviewer_keywords:
  - "Visual Studio command prompt"
  - "command prompt, Visual Studio"
  - "Developer Command Prompt"
  - "Developer PowerShell"
  - "Visual Studio terminal"
no-loc: cmdlet
monikerRange: ">=vs-2019"
ms.subservice: general-ide
---
# Visual Studio Developer Command Prompt and Developer PowerShell

Visual Studio includes two command-line shells for developers, a command prompt and an instance of PowerShell, as follows:

- **Visual Studio Developer Command Prompt**: A standard command prompt with certain environment variables set to make using command-line developer tools easier.

    ::: moniker range="vs-2019"
    :::image type="content" source="media/developer-command-prompt-for-vs/command-prompt.png" alt-text="Screenshot of the Developer Command Prompt for Visual Studio 2019.":::
    ::: moniker-end

    ::: moniker range=">=vs-2022"
    :::image type="content" source="media/developer-command-prompt-for-vs/developer-command-prompt-visual-studio-2022.png" alt-text="Screenshot of the Developer Command Prompt for Visual Studio.":::
    ::: moniker-end

- **Visual Studio Developer PowerShell**: More powerful than a command prompt. For example, you can pass the output of one command, known as a *cmdlet*, to another cmdlet. This shell has the same environment variables set as Developer Command Prompt. Available since Visual Studio 2019.

    ::: moniker range=">=vs-2022"
    :::image type="content" source="media/developer-command-prompt-for-vs/developer-powershell-visual-studio-2022.png" alt-text="Screenshot of the Developer PowerShell tool in Visual Studio 2022 and later.":::
    ::: moniker-end

Starting in Visual Studio 2019, Visual Studio includes an [integrated terminal](https://devblogs.microsoft.com/visualstudio/say-hello-to-the-new-visual-studio-terminal/) that can host either of these command-line shells. You can also open multiple tabs of each shell. The Visual Studio terminal is built on top of [Windows Terminal](/windows/terminal/). To open the terminal in Visual Studio, select **View** > **Terminal**.

::: moniker range=">=vs-2022"
:::image type="content" source="media/developer-command-prompt-for-vs/visual-studio-2022-terminal-window.png" alt-text="Screenshot of the Visual Studio terminal pane that shows multiple tabs.":::
::: moniker-end

::: moniker range="vs-2019"
:::image type="content" source="media/developer-command-prompt-for-vs/vs-terminal.png" alt-text="Screenshot of the Visual Studio terminal showing multiple tabs.":::
::: moniker-end

> [!TIP]
> This page describes how to use the command-line shells in [Visual Studio](https://visualstudio.microsoft.com/#vs-section). If you're looking for the equivalent in [Visual Studio Code](https://visualstudio.microsoft.com/#vscode-section)&mdash;also known as **VS Code**&mdash;see [Command Line Interface (CLI)](https://code.visualstudio.com/docs/editor/command-line) and [Terminal Basics](https://code.visualstudio.com/docs/terminal/basics).

When you open one of the developer shells from Visual Studio, either as a separate app or in the Terminal window, it opens to the directory of your current solution (if you have a solution loaded). This behavior makes it convenient to run commands against the solution or its projects.

Both shells have specific environment variables that enable you to use command-line developer tools more easily. After opening one of these shells, you can enter the commands for different utilities without having to know where they're located.

|Popular commands|Description|
|--|--|
|[`MSBuild`](../../msbuild/msbuild-command-line-reference.md)|Build a project or solution|
|[`dotnet`](/dotnet/core/tools/dotnet)|A [.NET CLI command](/dotnet/core/tools/index)|
|[`dotnet run`](/dotnet/core/tools/dotnet-run)|A [.NET CLI command](/dotnet/core/tools/index)|
|[`clrver`](/dotnet/framework/tools/clrver-exe-clr-version-tool)| A [.NET Framework tool](/dotnet/framework/tools/index) for CLR|
|[`ildasm`](/dotnet/framework/tools/ildasm-exe-il-disassembler)|A [.NET Framework tool](/dotnet/framework/tools/index) for disassembler|
|[`CL`](/cpp/build/reference/compiler-command-line-syntax)|C/C++ compile tool|
|[`NMAKE`](/cpp/build/reference/running-nmake)|C/C++ compile tool|
|[`LIB`](/cpp/build/reference/lib-reference)| C/C++ build tool|
|[`DUMPBIN`](/cpp/build/reference/dumpbin-reference)| C/C++ build tool|

## Start in Visual Studio

Follow these steps to open Developer Command Prompt or Developer PowerShell from within Visual Studio:

1. Open Visual Studio.

1. On the menu bar, select **Tools** > **Command Line** > **Developer Command Prompt** or **Developer PowerShell**.

    ::: moniker range=">=vs-2022"
    :::image type="content" source="media/developer-command-prompt-for-vs/visual-studio-2022-command-line-menu.png" alt-text="Screenshot of the Command Line menu in Visual Studio.":::
    ::: moniker-end

    ::: moniker range="vs-2019" 
    :::image type="content" source="media/developer-command-prompt-for-vs/vs-menu.png" alt-text="Screenshot of the Command Line menu in Visual Studio 2019.":::
    ::: moniker-end

## Start from Windows menu

Another way to start the shells is from the Start menu. You could have multiple command prompts, depending on the version of Visual Studio and any other SDKs and workloads you've installed.

### Windows 11

1. Select **Start**, and then in the **Type here to search** dialog box, enter either `developer command prompt` or `developer powershell`.

1. Select the App result that's associated with your search text.

### Windows 10

1. Select **Start**, and then scroll to the letter **V**.

1. Expand the **Visual Studio 2019** or **Visual Studio 2022** folder.

1. If you're running Visual Studio 2019, select either **Developer Command Prompt for VS 2019** or **Developer PowerShell for VS 2019**. If you're running Visual Studio 2022, select either **Developer Command Prompt for VS 2022** or **Developer PowerShell for VS 2022**.

   Alternatively, you can start typing the name of the shell in the search box on the taskbar, and select the result you want as the result list starts to display the search matches.

   :::image type="content" source="media/developer-command-prompt-for-vs/windows-10-search.gif" alt-text="Animation that shows the search behavior in Windows 10.":::

## Start from file browser

Usually, the shortcuts for the shells you installed are placed in the **Start Menu** folder for Visual Studio, such as in *%ProgramData%\Microsoft\Windows\Start Menu\Programs\Visual Studio 2019\Visual Studio Tools*. But if searching for the command prompt doesn't produce the expected results, you can try to manually locate the files on your machine.

### Developer Command Prompt

Search for the name of the command prompt file, which is *VsDevCmd.bat*, or go to the Tools folder for Visual Studio, such as *%ProgramFiles%\Microsoft Visual Studio\2022\Community\Common7\Tools* (the path changes according to your Visual Studio version, edition, and installation location).

After you locate the command prompt file, open it by entering the following command in a regular command prompt window:

::: moniker range="vs-2022"

```cmd
"%ProgramFiles%\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"
```

Or enter the following command in the Windows **Run** dialog box:

```cmd
%comspec% /k "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"
```

::: moniker-end

::: moniker range="vs-2019"

```cmd
"%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Community\Common7\Tools\VsDevCmd.bat"
```

Or enter the following command in the Windows **Run** dialog box:

```cmd
%comspec% /k "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\Tools\VsDevCmd.bat"
```

::: moniker-end  

Since Visual Studio 2015, the Developer Command Prompt sets the `VSCMD_VER` environment variable, which contains the version information for Visual Studio (for example: 17.14.8). If you need to detect whether the Developer Command Prompt was already run in your console, it's recommended to check whether `VSCMD_VER` has been defined or not.

> [!TIP]
> Make sure to edit the path to match the version or edition of Visual Studio that you're using.

### Developer PowerShell

Search for a PowerShell script file named *Launch-VsDevShell.ps1*, or go to the Tools folder for Visual Studio, such as *%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Community\Common7\Tools*. The path changes according to your Visual Studio version, edition, and installation location. After you locate the PowerShell file, run it by entering the following command at a Windows PowerShell or PowerShell 6 prompt.

::: moniker range="visualstudio"
For Visual Studio 2022:

```powershell
& 'C:\Program Files\Microsoft Visual Studio\18\Community\Common7\Tools\Launch-VsDevShell.ps1'
```

::: moniker-end

::: moniker range="vs-2022"
For Visual Studio 2022:

```powershell
& 'C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\Launch-VsDevShell.ps1'
```

::: moniker-end

For Visual Studio 2019:

```powershell
& 'C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\Tools\Launch-VsDevShell.ps1'
```

By default, the Developer PowerShell that launches is configured for the Visual Studio installation whose install path the *Launch-VsDevShell.ps1* file is located in.

> [!TIP]
> The [execution policy](/powershell/module/microsoft.powershell.core/about/about_execution_policies) must be set in order for the cmdlet to run.

The *Launch-VsDevShell.ps1* script works by locating the *Microsoft.VisualStudio.DevShell.dll* PowerShell module in the Visual Studio installation path, loading it, and then invoking the `Enter-VsDevShell` cmdlet. Installed shortcuts, like those in the Start menu, load the module and invoke the cmdlet directly. *Launch-VsDevShell.ps1* is the recommended way to initialize Developer PowerShell interactively or for scripting build automation.

## Command-line arguments

You can use command-line arguments for either of the shells: Developer Command Prompt or Developer PowerShell.

### Target Architecture and Host Architecture

For build tools, like the C++ compiler, that create outputs targeting specific CPU architectures, the developer shells can be configured using the appropriate command-line argument. The architecture of the build tool binaries can also be configured by using command-line arguments. This is useful when the build machine is a different architecture than the target architecture.

> [!TIP]
> Beginning with Visual Studio 2022, `msbuild` defaults to a 64-bit *msbuild.exe* binary, regardless of the Host Architecture.

|Shell|Argument|
|--|--|
|Developer Command Prompt|-arch=&lt;Target Architecture&gt;|
|Developer Command Prompt|-host_arch=&lt;Host Architecture&gt;|
|Developer PowerShell|-Arch &lt;Target Architecture&gt;|
|Developer PowerShell|-HostArch &lt;Host Architecture&gt;|

> [!IMPORTANT]
> Developer PowerShell arguments `-Arch` and `-HostArch` are only available beginning with [Visual Studio 2022 version 17.1](/visualstudio/releases/2022/release-notes#1710--visual-studio-2022-version-171-newreleasebutton).

The following table lists which architectures are supported, and whether they can be used for Target Architecture or Host Architecture arguments.

|Architecture|Target Architecture|Host Architecture|
|--|--|--|
|x86|Default|Default|
|amd64|Yes|Yes|
|arm|Yes|No|
|arm64|Yes|No|

> [!TIP]
> If you set only Target Architecture, the shells attempt to make the Host Architecture match. This can result in errors when only the Target Architecture is set to a value that's not also supported by Host Architecture.

#### Examples

Start the Developer Command Prompt for Visual Studio 2019 Community Edition on a 64-bit machine, creating build outputs that target *64-bit*:

```cmd
"%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Community\Common7\Tools\VsDevCmd.bat" -arch=amd64
```

Start the Developer Command Prompt for Visual Studio 2019 Community Edition on a 64-bit machine, creating build outputs that target *ARM*:

```cmd
"%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Community\Common7\Tools\VsDevCmd.bat" -arch=arm -host_arch=amd64
```

Start the Developer PowerShell for the Community Edition of [Visual Studio 2022 version 17.1](/visualstudio/releases/2022/release-notes#1710--visual-studio-2022-version-171-newreleasebutton) or later on a 64-bit machine, creating build outputs that target *ARM64*:

```powershell
& 'C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\Launch-VsDevShell.ps1' -Arch arm64 -HostArch amd64
```

### SkipAutomaticLocation

For Developer PowerShell, the starting directory of the shell is the Visual Studio Project Location. This default locale overrides any other paths, such as working directory. This behavior can be turned off by using the command-line argument `-SkipAutomaticLocation`. This can be useful if you want the shell to stay in the current directory after initialization.

::: moniker range="vs-2019"
The Project Location can be adjusted in **Tools** > **Options** > **Projects &amp; Solutions** > **Project Location**.
::: moniker-end

::: moniker range=">=vs-2022"
The Project Location can be adjusted in **Tools** > **Options** > **Projects &amp; Solutions** > **Locations**.
::: moniker-end

> [!TIP]
> The command-line arguments `-Arch`, `-HostArch`, and `-SkipAutomaticLocation` are supported by both the `Launch-VsDevShell.ps1` script and the `Enter-VsDevShell` cmdlet.

## Related content

- [What is Windows Terminal?](/windows/terminal/)
- [.NET Framework tools](/dotnet/framework/tools/index)
- [Use the Microsoft C++ toolset from the command line](/cpp/build/building-on-the-command-line)
