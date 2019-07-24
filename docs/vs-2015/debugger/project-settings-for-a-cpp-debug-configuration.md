---
title: "Project Settings for a C++ Debug Configuration | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
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
  - "vs.debug.builds"
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
  - "FSharp"
  - "VB"
  - "CSharp"
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
ms.assetid: 860c7f13-a108-4fe5-8fca-d235cd3ca1cb
caps.latest.revision: 52
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Project Settings for a C++ Debug Configuration
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can change the project settings for a C or Visual C++ debug configuration in the **Property Pages** dialog box, as discussed in [How to: Set Debug and Release Configurations](../debugger/how-to-set-debug-and-release-configurations.md). The following tables show where to find debugger-related settings in the **Property Pages** dialog box.  
  
> [!WARNING]
> The debug project settings in the **Configuration Properties/Debugging** category for Windows Store apps and components that are written in C++ are different. See [Start a debug session (VB, C#, C++ and XAML)](../debugger/start-a-debugging-session-for-a-store-app-in-visual-studio-vb-csharp-cpp-and-xaml.md) in the Windows Development Center.  
  
 Specify which debugger to use in the **Debugger to launch** list box. Your choice will affect which properties are visible.  
  
 Each debug property setting is automatically written and saved to the "per-user" file (.vcxproj.user) for your solution whenever you save your solution.  
  
### Configuration Properties folder (Debugging category)  
  
|**Setting**|**Description**|  
|-----------------|---------------------|  
|**Debugger to launch**|Specifies the debugger to run, with the following choices:<br /><br /> -   **Local Windows Debugger**<br />-   **Remote Windows Debugger**<br />-   **Web Browser Debugger**<br />-   **Web Service Debugger**|  
|**Command** (Local Windows Debugger)|Specifies the command for starting the program that you are debugging on the local computer.|  
|**Remote Command** (Remote Windows Debugger)|The path for the .exe on the remote computer. Enter the path just as you would enter it on the remote machine.|  
|**Command Arguments** (Local Windows Debugger and Remote Windows Debugger)|-   Specifies arguments for the command specified earlier.<br /><br /> You can use the following redirection operators in this box:<br /><br /> < `file`<br /> Reads stdin from file.<br /><br /> > `file`<br /> Writes stdout to file.<br /><br /> >> `file`<br /> Appends stdout to file.<br /><br /> 2> `file`<br /> Writes stderr to file.<br /><br /> 2>> `file`<br /> Appends stderr to file.<br /><br /> 2> &1<br /> Sends stderr (2) output to same location as stdout (1).<br /><br /> 1> &2<br /> Sends stdout (1) output to same location as stderr (2).<br /><br /> In most cases, these operators are applicable only to console applications.|  
|**Working Directory**|Specifies the working directory of the program being debugged, relative to the project directory where your EXE is located. If you leave this blank, the working directory is the project directory. For remote debugging, the project directory will be on the remote server.|  
|**Attach** (Local Windows Debugger and Remote Windows Debugger)|Specifies whether to start or attach to the application. Default setting is No.|  
|**Remote Server Name** (Remote Windows Debugger)|Specifies the name of a computer (other than yours) on which you want to debug an application.<br /><br /> The RemoteMachine Build macro is set to the value of this property; for more information, see [Macros for Build Commands and Properties](https://msdn.microsoft.com/library/239bd708-2ea9-4687-b264-043f1febf98b).|  
|**Connection** (Remote Windows Debugger)|Allows you to switch between standard and no-authentication connection types for remote debugging. Specify a remote computer name in the **Remote Server Name** box. Connection types include the following:<br /><br /> -   **Remote with Windows Authentication**<br />-   **Remote with No Authentication (Native Only)**<br /><br /> **Note** Remote debugging with No Authentication may leave the remote computer vulnerable to security violations. Windows Authentication mode is more secure.<br /><br /> For more information, see [Remote Debugging Setup](../debugger/remote-debugging.md).|  
|**HTTP URL** (Web Service Debugger and Web Browser Debugger)|Specifies the URL where the project you are debugging is located.|  
|**Debugger Type**|Specifies the type of debugger to be used: **Native Only**, **Managed Only**, **GPU Only**, **Mixed**, **Auto** (default), or **Script**.<br /><br /> -   **Native Only** is for unmanaged C++ code.<br />-   **Managed Only** is for code that runs under the common language runtime (managed code).<br />-   **Mixed** invokes debuggers for both managed and unmanaged code.<br />-   **Auto** determines the debugger type based on compiler and EXE information.<br />-   **Script** invokes a debugger for scripts.<br />-   **GPU Only** is for C++ AMP code that runs on a GPU device or on the DirectX reference rasterizer. See [Debugging GPU Code](../debugger/debugging-gpu-code.md).|  
|**Environment** (Local Windows Debugger)|Specifies environment variables for the program that you are debugging. Use standard environment variable syntax (for example, `PATH="%SystemRoot%\..."`). These variables override the system environment or are merged with the system environment, depending on the **Merge Environment** setting. When you click in the settings column, an "Edit…" appears. Click that link to edit environment variables.|  
|**Merge Environment** (Local Windows Debugger)|Determines whether the variables that are specified in the **Environment** box will be merged with the environment that is defined by the operating system. Default setting is Yes.|  
|**SQL Debugging** (all but MPI Cluster Debugger)|Enables debugging of SQL procedures from your [!INCLUDE[vcprvc](../includes/vcprvc-md.md)] application. Default setting is No.|  
|**Debugging Accelerator Type** (GPU debugging only)|Specifies the GPU device to use for debugging. Installing device drivers for compatible GPU devices will add additional options. The default setting is "GPU - Software Emulator."|  
|**GPU Default Breakpoint Behavior** (GPU debugging only)|Specifies whether a breakpoint event should be raised for each thread in a SIMD warp. The default setting is to raise the breakpoint event only once per warp.|  
|**Amp Default Accelerator** (GPU debugging only)|Specifies the default AMP accelerator when debugging GPU code. Choose **WARP software accelerator** to investigate if an issue is caused by the hardware or a driver instead of your code.|  
|**Deployment Directory** (Remote Windows Debugger)|Specifies the path on the remote computer where the project output will be copied prior to launch. The path can be a network share on the remote computer, or it can be a path to a folder on the remote computer. The default setting is empty, which means the project output is not copied to a network share. To enable deployment of the files, you must also select the **Deploy** check box in the Configuration Manager dialog box. For more information, see [How to: Create and Edit Configurations](../ide/how-to-create-and-edit-configurations.md).|  
|**Additional Files to Deploy** (Remote Windows Debugger)|If the Deployment Directory property is set, this is a semi-colon delimited list of additional files to copy to the deployment directory. The default setting is empty, which means that no additional files are copied to the deployment directory. To enable deployment of the files, you must also select the **Deploy** check box in the Configuration Manager dialog box. For more information, see [How to: Create and Edit Configurations](../ide/how-to-create-and-edit-configurations.md).|  
|**Deploy Visual C++ Debug Runtime Libraries** (Remote Windows Debugger)|If the Deployment Directory property is set, this specifies whether the Visual C++ debug runtime libraries for the current platform should be copied to the network share. The default setting is Yes.|  
  
### C/C++ folder (General category)  
  
|Setting|Description|  
|-------------|-----------------|  
|**Debug Information Format** ([/Z7, /Zd, Zi, /ZI](https://msdn.microsoft.com/library/ce9fa7e1-0c9b-47e3-98ea-26d1a16257c8))|Specifies the type of debug information to be created for the project.<br /><br /> The default option (/ZI) creates a program database (PDB) in Edit and Continue compatible format. For more information, see [/Z7, /Zd, /Zi, /ZI (Debug Information Format)](https://msdn.microsoft.com/library/ce9fa7e1-0c9b-47e3-98ea-26d1a16257c8).|  
  
### C/C++ folder (Optimization category)  
  
|Setting|Description|  
|-------------|-----------------|  
|**Optimization**|Specifies whether the compiler should optimize the code it produces. Optimization changes the code that is executed. Optimized code no longer matches the source code. Therefore, debugging is difficult.<br /><br /> The default option (**Disabled (/0d**) suppresses optimization. You can develop with optimization suppressed, and then turn it on when you create the production version of your code.|  
  
### Linker folder (Debugging category)  
  
|Setting|Description|  
|-------------|-----------------|  
|**Generate Debug Info** ([/DEBUG](https://msdn.microsoft.com/library/1af389ae-3f8b-4d76-a087-1cdf861e9103))|Tells the linker to include debug information, which will have the format specified by /Z7, /Zd, Zi, or /ZI.|  
|**Generate Program Database File** ([/PDB:name](https://msdn.microsoft.com/library/d23db0ce-10cb-427a-bc60-d6b2a852723d))|Specify the name of a PDB file in this box. You must select ZI or /Zi for Debug Information Format.|  
|**Strip Private Symbols** ([/PDBSTRIPPED:filename](https://msdn.microsoft.com/library/9b9e0070-6a13-4142-8180-19c003fbbd55))|Specify the name of a PDB file in this box if you do not want to include private symbols in the PDB file. This option creates a second program database (PDB) file when you build your program image with any of the compiler or linker options that generate a PDB file, such as /DEBUG, /Z7, /Zd. Or /Zi. This second PDB file omits symbols that you would not want to ship to your customers. For more information, see [/PDBSTRIPPED (Strip Private Symbols)](https://msdn.microsoft.com/library/9b9e0070-6a13-4142-8180-19c003fbbd55).|  
|**Generate Map File** ([/MAP](https://msdn.microsoft.com/library/9ccce53d-4e36-43da-87b0-7603ddfdea63))|Tells the linker to generate a map file during linking. Default setting is No. For more information, see [/MAP (Generate Mapfile)](https://msdn.microsoft.com/library/9ccce53d-4e36-43da-87b0-7603ddfdea63).|  
|**Map File Name** ([/MAP:](https://msdn.microsoft.com/library/9ccce53d-4e36-43da-87b0-7603ddfdea63)*name*)|If you choose Generate Map File, you can specify the map file in this box. For more information, see [/MAP (Generate Mapfile)](https://msdn.microsoft.com/library/9ccce53d-4e36-43da-87b0-7603ddfdea63).|  
|**Map Exports** ([/MAPINFO:EXPORTS](https://msdn.microsoft.com/library/533d2bce-f9b7-4fea-ae1c-0b4864c9d10b))|Includes exported functions in the map file. Default setting is No. For more information, see [/MAPINFO (Include Information in Mapfile)](https://msdn.microsoft.com/library/533d2bce-f9b7-4fea-ae1c-0b4864c9d10b).|  
|**Debuggable Assembly** ([/ASSEMBLYDEBUG](https://msdn.microsoft.com/library/533d2bce-f9b7-4fea-ae1c-0b4864c9d10b))|Specifies settings for the Linker /ASSEMBLYDEBUG option. Possible values are as follows:<br /><br /> -   **No debuggable attribute emitted**.<br />-   **Runtime tracking and disable optimizations (/ASSEMBLYDEBUG)**. This is the default setting,<br />-   **No runtime tracking and enable optimizations(/ASSEMBLYDEBUG:DISABLE)**.<br />-   **\<inherit from parent or project defaults>**.<br />-   For more information, see [/ASSEMBLYDEBUG (Add DebuggableAttribute)](https://msdn.microsoft.com/library/94443af3-470c-41d7-83a0-7434563d7982).|  
  
 You can change these settings in the Configuration Properties folder (Debug category) programmatically by using the Microsoft.VisualStudio.VCProjectEngine.VCDebugSettings interface. For more information, see <xref:Microsoft.VisualStudio.VCProjectEngine.VCDebugSettings>.  
  
## See Also  
 [Debugging Native Code](../debugger/debugging-native-code.md)   
 [Debugger Settings and Preparation](../debugger/debugger-settings-and-preparation.md)   
 [Creating and Managing Visual C++ Projects](https://msdn.microsoft.com/library/11003cd8-9046-4630-a189-a32bf3b88047)   
 [/ASSEMBLYDEBUG (Add DebuggableAttribute)](https://msdn.microsoft.com/library/94443af3-470c-41d7-83a0-7434563d7982)   
 [Common Macros for Build Commands and Properties](https://msdn.microsoft.com/library/239bd708-2ea9-4687-b264-043f1febf98b)
