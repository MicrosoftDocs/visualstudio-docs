---
title: "Project settings for a C++ debug config"
description: Configure C and C++ debugging in Property Pages. This article describes the settings and tells you their category.
ms.date: "08/19/2022"
ms.topic: "ui-reference"
f1_keywords:
  - "VC.Project.VCDebugSettings.WebBrowser.DebuggerType"
  - "VC.Project.IVCGPUDebugPageObject.EnvironmentMerge"
  - "VC.Project.VCDebugSettings.SymbolPath"
  - "VC.Project.IVCClusterDebugPageObject.ApplicationCommand"
  - "VC.Project.IVCRemoteDebugPageObject.WorkingDirectory"
  - "VC.Project.VCDebugSettings.DebuggerType"
  - "VC.Project.IVCLocalDebugPageObject.GPUDebuggerTargetType"
  - "VC.Project.IVCRemoteDebugPageObject.SQLDebugging"
  - "VC.Project.IVCRemoteDebugPageObject.Remote"
  - "VC.Project.IVCGPUDebugPageObject.CommandArguments"
  - "VC.Project.VCDebugSettings.CommandArguments"
  - "VC.Project.IVCClusterDebugPageObject.MPIRunWorkingDirectory"
  - "VC.Project.IVCLocalDebugPageObject.SQLDebugging"
  - "VC.Project.IVCWebSvcDebugPageObject.HttpUrl"
  - "VC.Project.IVCLocalDebugPageObject.WorkingDirectory"
  - "VC.Project.IVCLocalDebugPageObject.CommandArguments"
  - "VC.Project.IVCClusterDebugPageObject.MPIRunCommand"
  - "VC.Project.IVCGPUDebugPageObject.WorkingDirectory"
  - "VC.Project.IVCWebSvcDebugPageObject.DebuggerType"
  - "VC.Project.IVCRemoteDebugPageObject.CommandArguments"
  - "VC.Project.IVCRemoteDebugPageObject.DebuggerType"
  - "VC.Project.IVCLocalDebugPageObject.GPUBreakOnAllThreads"
  - "VC.Project.IVCRemoteDebugPageObject.RemoteMachine"
  - "VC.Project.IVCClusterDebugPageObject.MPIRunArguments"
  - "VC.Project.IVCClusterDebugPageObject.MPIAcceptFilter"
  - "VC.Project.IVCGPUDebugPageObject.RemoteConnection"
  - "VC.Project.VCDebugSettings.PDBPath"
  - "VC.Project.IVCRemoteDebugPageObject.DeploymentDirectory"
  - "VC.Project.VCDebugSettings.SQLDebugging"
  - "VC.Project.VCDebugSettings.RemoteCommand"
  - "VC.Project.IVCClusterDebugPageObject.ShimCommand"
  - "VC.Project.IVCLocalDebugPageObject.Command"
  - "VC.Project.IVCRemoteDebugPageObject.GPUBreakOnAllThreads"
  - "VC.Project.IVCLocalDebugPageObject.Attach"
  - "VC.Project.VCDebugSettings.Command"
  - "VC.Project.IVCRemoteDebugPageObject.GPUDebuggerTargetType"
  - "VC.Project.IVCRemoteDebugPageObject.RemoteCommand"
  - "VC.Project.IVCClusterDebugPageObject.ApplicationArguments"
  - "VC.Project.IVCLocalDebugPageObject.Environment"
  - "VC.Project.IVCGPUDebugPageObject.DeploymentDirectory"
  - "VC.Project.IVCLocalDebugPageObject.EnvironmentMerge"
  - "VC.Project.VCDebugSettings.Environment"
  - "VC.Project.IVCGPUDebugPageObject.BreakpointBehavior"
  - "VC.Project.IVCLocalDebugPageObject.DebuggerType"
  - "VC.Project.VCDebugSettings.WebBrowser.WebBrowserDebuggerHttpUrl"
  - "VC.Project.IVCWebSvcDebugPageObject.SQLDebugging"
  - "VC.Project.IVCGPUDebugPageObject.AcceleratorType"
  - "VC.Project.IVCGPUDebugPageObject.Environment"
  - "VC.Project.VCDebugSettings.RemoteMachine"
  - "VC.Project.IVCGPUDebugPageObject.AdditionalFilesToDeploy"
  - "VC.Project.VCDebugSettings.WorkingDirectory"
  - "VC.Project.VCDebugSettings.Attach"
  - "VC.Project.VCDebugSettings.HttpUrl"
  - "VC.Project.IVCClusterDebugPageObject.MPIAcceptMode"
  - "VC.Project.IVCGPUDebugPageObject.Attach"
  - "VC.Project.IVCRemoteDebugPageObject.AdditionalFiles"
  - "VC.Project.IVCGPUDebugPageObject.Command"
  - "VC.Project.VCDebugSettings.Remote"
  - "VC.Project.IVCRemoteDebugPageObject.Attach"
  - "VC.Project.VCDebugSettings.EnvironmentMerge"
  - "VC.Project.IVCGPUDebugPageObject.MachineName"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "DEBUG linker option"
  - "-PDB linker option"
  - "-Zl compiler option [C++]"
  - "/DEBUG linker option"
  - "/PDBSTRIPPED linker option"
  - "/MAPINFO linker option"
  - "-Zd compiler option [C++]"
  - "-DEBUG linker option"
  - "MAPINFO linker option"
  - "/ZI compiler option [C++]"
  - "ZI compiler option [C++]"
  - "Z7 compiler option [C++]"
  - "debugging [C++], debugger settings"
  - "project settings [Visual Studio], debug configurations"
  - "mapfiles, project settings"
  - "debug configurations, C++"
  - "project settings [Visual Studio]"
  - "/PDB linker option"
  - "-PDBSTRIPPED linker option"
  - "debug builds, project settings"
  - "PDB linker option"
  - "projects [Visual Studio], debug configurations"
  - "project configurations, debug"
  - "Zd compiler option [C++]"
  - "MAP linker option"
  - "/Z7 compiler option [C++]"
  - ".pdb files, debug build project settings"
  - "-MAP linker option"
  - "-MAPINFO linker option"
  - "/Zd compiler option [C++]"
  - "PDBSTRIPPED linker option"
  - "-Z7 compiler option [C++]"
  - "pdb files, debug build project settings"
  - "/MAP linker option"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Project settings for a C++ debug configuration

You can change the project settings for a C or C++ debug configuration in the **Property Pages** dialog box, as discussed in [How to: Set debug and release configurations](../debugger/how-to-set-debug-and-release-configurations.md). The following tables show where to find debugger-related settings in the **Property Pages** dialog box.

> [!NOTE]
> The debug project settings in the **Configuration Properties/Debugging** category are different for UWP apps and for components that are written in C++. See [Start a debug session (VB, C#, C++ and XAML)](/windows/uwp/debug-test-perf/deploying-and-debugging-uwp-apps).

 Each debug property setting is automatically written and saved to the "per-user" file (.vcxproj.user) for your solution when you save your solution.

 Specify which debugger to use in the **Debugger to launch** list box, as described in the following table. Your choice affects which properties are visible.

## Configuration Properties folder (Debugging category)

| **Setting** | **Description** |
| - | - |
| **Debugger to launch** | Specifies the debugger to run, with the following choices:<br /><br /> -   **Local Windows Debugger**<br />-   **Remote Windows Debugger**<br />-   **Web Browser Debugger**<br />-   **Web Service Debugger** |
| **Command** (Local Windows Debugger) | Specifies the command for starting the program that you're debugging on the local computer. |
| **Remote Command** (Remote Windows Debugger) | The path for the .exe on the remote computer. Enter the path just as you would enter it on the remote machine. |
| **Command Arguments** (Local Windows Debugger)<br /><br /> **Remote Command Arguments** (Remote Windows Debugger) | -   Specifies arguments for the program you're debugging. For more information about ways to set command line args, see [Send command-line arguments to a debugee (C++)](/visualstudio/debugger/project-settings-for-a-cpp-debug-configuration) and [Pass command-line arguments](getting-started-with-the-debugger-cpp.md#pass-command-line-arguments).<br /><br /> You can use the following redirection operators in this box:<br /><br /> < `file`<br /> Reads stdin from file.<br /><br /> > `file`<br /> Writes stdout to file.<br /><br /> >> `file`<br /> Appends stdout to file.<br /><br /> 2> `file`<br /> Writes stderr to file.<br /><br /> 2>> `file`<br /> Appends stderr to file.<br /><br /> 2> &1<br /> Sends stderr (2) output to same location as stdout (1).<br /><br /> 1> &2<br /> Sends stdout (1) output to same location as stderr (2).<br /><br /> In most cases, these operators are applicable only to console applications. <br /><br />If you need to escape characters in the command, you can use ASCII values, such as %25 to replace %. If you use the **Start Debugging** command, double quotes escape the preceding commands, such as "<" to replace <.|
| **Working Directory** | Specifies the working directory of the program being debugged, relative to the project directory where your EXE is located. If you leave this blank, the working directory is the project directory. For remote debugging, the project directory is on the remote server. |
| **Attach** (Local Windows Debugger and Remote Windows Debugger) | Specifies whether to start or attach to the application. Default setting is No. |
| **Remote Server Name** (Remote Windows Debugger) | Specifies the name of a computer (other than yours) on which you want to debug an application.<br /><br /> The RemoteMachine Build macro is set to the value of this property; for more information, see [Macros for build commands and properties](/cpp/build/reference/common-macros-for-build-commands-and-properties). |
| **Connection** (Remote Windows Debugger) | Allows you to switch between standard and no-authentication connection types for remote debugging. Specify a remote computer name in the **Remote Server Name** box. Connection types include the following:<br /><br /> -   **Remote with Windows Authentication**<br />-   **Remote with No Authentication**<br /><br /> **Note** Remote debugging with No Authentication may leave the remote computer vulnerable to security violations. Windows Authentication mode is more secure.<br /><br /> For more information, see [Remote debugging setup](../debugger/remote-debugging.md). |
| **HTTP URL** (Web Service Debugger and Web Browser Debugger) | Specifies the URL where the project you're debugging is located. |
| **Debugger Type** | Specifies the type of debugger to be used: **Native Only**, **Managed Only**, **GPU Only**, **Mixed**, **Auto** (default), or **Script**.<br /><br /> -   **Native Only** is for unmanaged C++ code.<br />-   **Managed Only** is for code that runs under the common language runtime (managed code).<br />-   **Mixed** invokes debuggers for both managed and unmanaged code.<br />-   **Auto** determines the debugger type based on compiler and EXE information.<br />-   **Script** invokes a debugger for scripts.<br />-   **GPU Only** is for C++ AMP code that runs on a GPU device or on the DirectX reference rasterizer. See [Debugging GPU code](../debugger/debugging-gpu-code.md). |
| **Environment** (Local Windows Debugger and Remote Windows Debugger) | Specifies environment variables for the program that you're debugging. Use standard environment variable syntax (for example, `PATH="%SystemRoot%\..."`). These variables override the system environment or are merged with the system environment, depending on the **Merge Environment** setting. When you click in the right column, an "Edit..." appears. Select that link to open the Property Editor and edit environment variables. To add multiple environment variables, use the [Property Editor](/cpp/build/working-with-project-properties#property_editor) and add one variable per line. |
| **Merge Environment** (Local Windows Debugger) | Determines whether the variables that are specified in the **Environment** box are merged with the environment that is defined by the operating system. Default setting is Yes. |
| **SQL Debugging** (all but MPI Cluster Debugger) | Enables debugging of SQL procedures from your Visual C++ application. Default setting is No. |
| **Debugging Accelerator Type** (GPU debugging only) | Specifies the GPU device to use for debugging. Installing device drivers for compatible GPU devices add additional options. The default setting is **GPU - Software Emulator**. |
| **GPU Default Breakpoint Behavior** (GPU debugging only) | Specifies whether a breakpoint event should be raised for each thread in a SIMD warp. The default setting is to raise the breakpoint event only once per warp. |
| **Amp Default Accelerator** | Specifies the default AMP accelerator when debugging GPU code. Choose **WARP software accelerator** to investigate if an issue is caused by the hardware or a driver instead of your code. |
| **Deployment Directory** (Remote Windows Debugger) | Specifies the path on the remote computer where the project output is copied prior to launch. The path can be a network share on the remote computer, or it can be a path to a folder on the remote computer. The default setting is empty, which means the project output isn't copied to a network share. To enable deployment of the files, you must also select the **Deploy** check box in the Configuration Manager dialog box. For more information, see [How to: Create and edit configurations](../ide/how-to-create-and-edit-configurations.md). |
| **Additional Files to Deploy** (Remote Windows Debugger) | If the Deployment Directory property is set, this is a semicolon-delimited list of additional folders or files to copy to the deployment directory. The default setting is empty, which means that no additional folders or files are copied to the deployment directory. To copy the contents of a folder to the same folder in the Deployment Directory, specify a folder name. To enable deployment of the files, you must also select the **Deploy** check box in the Configuration Manager dialog box. For more information, see [How to: Create and edit configurations](../ide/how-to-create-and-edit-configurations.md). |
| **Deploy Visual C++ Debug Runtime Libraries** (Remote Windows Debugger) | If the Deployment Directory property is set, this specifies whether the Visual C++ debug runtime libraries for the current platform should be copied to the network share. The default setting is Yes. |

## C/C++ folder (General category)

|Setting|Description|
|-------------|-----------------|
|**Debug Information Format** ([/Z7, /Zd, Zi, /ZI](/cpp/build/reference/z7-zi-zi-debug-information-format))|Specifies the type of debug information to be created for the project.<br /><br /> The default option (/ZI) creates a program database (PDB) in Edit and Continue compatible format. For more information, see [/Z7, /Zd, /Zi, /ZI (Debug information format)](/cpp/build/reference/z7-zi-zi-debug-information-format).|

## C/C++ folder (Optimization category)

|Setting|Description|
|-------------|-----------------|
|**Optimization**|Specifies whether the compiler should optimize the code it produces. Optimization changes the code that is executed. Optimized code no longer matches the source code, which makes debugging more difficult.<br /><br /> The default option (**Disabled (/0d)**) suppresses optimization. You can develop with optimization suppressed, and then turn it on when you create the production version of your code.|

## Linker folder (Debugging category)

|Setting|Description|
|-------------|-----------------|
|**Generate Debug Info** ([/DEBUG](/cpp/build/reference/debug-generate-debug-info))|Tells the linker to include debug information, which has the format specified by [/Z7, /Zd, Zi, or /ZI](/cpp/build/reference/z7-zi-zi-debug-information-format).|
|**Generate Program Database File** ([/PDB:name](/cpp/build/reference/pdb-use-program-database))|Specify the name of a program database (PDB) file in this box. You must select ZI or /Zi for Debug Information Format.|
|**Strip Private Symbols** ([/PDBSTRIPPED:filename](/cpp/build/reference/pdbstripped-strip-private-symbols))|Specify the name of a PDB file in this box if you don't want to include private symbols in the PDB file. This option creates a second PDB file when you build your program image with any of the compiler or linker options that generate a PDB file, such as /DEBUG, /Z7, /Zd. Or /Zi. This second PDB file omits symbols that you don't want to ship to your customers. For more information, see [/PDBSTRIPPED (Strip private symbols)](/cpp/build/reference/pdbstripped-strip-private-symbols).|
|**Generate Map File** ([/MAP](/cpp/build/reference/map-generate-mapfile))|Tells the linker to generate a map file during linking. Default setting is No. For more information, see [/MAP (Generate Mapfile)](/cpp/build/reference/map-generate-mapfile).|
|**Map File Name** ([/MAP:](/cpp/build/reference/map-generate-mapfile)*name*)|If you choose Generate Map File, you can specify the map file in this box. For more information, see [/MAP (Generate Mapfile)](/cpp/build/reference/map-generate-mapfile).|
|**Map Exports** ([/MAPINFO:EXPORTS](/cpp/build/reference/mapinfo-include-information-in-mapfile))|Includes exported functions in the map file. Default setting is No. For more information, see [/MAPINFO (Include Information in Mapfile)](/cpp/build/reference/mapinfo-include-information-in-mapfile).|
|**Debuggable Assembly** ([/ASSEMBLYDEBUG](/cpp/build/reference/mapinfo-include-information-in-mapfile))|Specifies settings for the Linker /ASSEMBLYDEBUG option. Possible values are:<br /><br /> -   **No debuggable attribute emitted**.<br />-   **Runtime tracking and disable optimizations (/ASSEMBLYDEBUG)**. This is the default setting,<br />-   **No runtime tracking and enable optimizations(/ASSEMBLYDEBUG:DISABLE)**.<br />-   **\<inherit from parent or project defaults>**.<br />-   For more information, see [/ASSEMBLYDEBUG (Add DebuggableAttribute)](/cpp/build/reference/assemblydebug-add-debuggableattribute).|

 You can change these settings in the Configuration Properties folder (Debug category) programmatically by using the Microsoft.VisualStudio.VCProjectEngine.VCDebugSettings interface. For more information, see <xref:Microsoft.VisualStudio.VCProjectEngine.VCDebugSettings>.

## Other project settings

To debug project types such as static libraries and DLLs, your Visual Studio project must be able to find the correct files. When source code is available, you can add static libraries and DLLs as separate projects to the same solution, to make debugging easier. For information on creating these project types, see [Creating and using a Dynamic Link Library (DLL)](/cpp/build/walkthrough-creating-and-using-a-dynamic-link-library-cpp) and [Creating a using a static library](/cpp/windows/walkthrough-creating-and-using-a-static-library-cpp). With source code available, you can also create a new Visual Studio project by choosing **File** > **New** > **Project From Existing Code**.

To debug DLLs that are external to your project, see [Debugging DLL projects](../debugger/debugging-dll-projects.md#vxtskdebuggingdllprojectsexternal). If you need to debug your own DLL project, but don't have access to the project for the calling application, see [How to debug from a DLL project](../debugger/how-to-debug-from-a-dll-project.md).

## See also
- [Debugging native code](../debugger/debugging-native-code.md)
- [Debugger settings and preparation](../debugger/debugger-settings-and-preparation.md)
- [Create and manage C++ projects](/cpp/ide/creating-and-managing-visual-cpp-projects)
- [/ASSEMBLYDEBUG (Add DebuggableAttribute)](/cpp/build/reference/assemblydebug-add-debuggableattribute)
- [Common macros for build commands and properties](/cpp/ide/common-macros-for-build-commands-and-properties)