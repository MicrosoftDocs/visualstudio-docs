---
title: Create a multiple-computer build environment
description: Create a build environment in your organization by installing Visual Studio on a host computer and then copying various files and settings to another computer.
ms.date: 11/04/2016
ms.subservice: compile-build
ms.topic: conceptual
helpviewer_keywords:
  - "MSBuild, building on multiple computers"
  - "build environment, MSBuild"
author: ghogen
ms.author: ghogen
manager: mijacobs
---
# Walkthrough: Create a multiple-computer build environment

You can create a build environment within your organization by installing Visual Studio on a host computer and then copying various files and settings to another computer so that it can participate in builds. You don't have to install Visual Studio on the other computer.

This document does not confer rights to redistribute the software externally or to provide build environments to third parties.

> Disclaimer<br /><br /> This document is provided on an "as-is" basis. While we have tested the steps outlined, we are not able to exhaustively test every configuration. We will attempt to keep the document current with any additional information learned. Information and views expressed in this document, including URL and other Internet website references, may change without notice. Microsoft makes no warranties, express or implied, with respect to the information provided here. You bear the risk of using it.<br /><br /> This document does not provide you with any legal rights to any intellectual property in any Microsoft product. You may copy and use this document for your internal, reference purposes.<br /><br /> You have no obligation to give Microsoft any suggestions, comments or other feedback ("Feedback") relating to this document. However, any Feedback you voluntarily provide may be used in Microsoft Products and related specifications or other documentation (collectively, "Microsoft Offerings") which in turn may be relied upon by other third parties to develop their own products. Accordingly, if you do give Microsoft Feedback on any version of this document or the Microsoft Offerings to which they apply, you agree: (a) Microsoft may freely use, reproduce, license, distribute, and otherwise commercialize your Feedback in any Microsoft Offering; (b) You also grant third parties, without charge, only those patent rights necessary to enable other products to use or interface with any specific parts of a Microsoft Product that incorporate Your Feedback; and (c) You will not give Microsoft any Feedback (i) that you have reason to believe is subject to any patent, copyright or other intellectual property claim or right of any third party; or (ii) subject to license terms which seek to require any Microsoft Offering incorporating or derived from such Feedback, or other Microsoft intellectual property, to be licensed to or otherwise shared with any third party.

This walkthrough has been validated against the following operating systems:

- Windows 8 (x86 and x64)
- Windows 7 Ultimate
- Windows Server 2008 R2 Standard

After you complete the steps in this walkthrough, you can use the multiple-computer environment to build these kinds of apps:

- C++ desktop apps that use the Windows 8 SDK
- Visual Basic or C# desktop apps that target the .NET Framework 4.5

The multiple-computer environment can't be used to build these kinds of apps:

- UWP apps. To build UWP apps, you must install Visual Studio on the build computer.
- Desktop apps that target the .NET Framework 4 or earlier. To build these kinds of apps, you must install either Visual Studio or the .NET Reference Assemblies and Tools (from the Windows 7.1 SDK) on the build computer.

## Prerequisites

Visual Studio with the **.NET desktop development** workload installed.

## Install software on the computers

First, set up the host computer, and then set up the build computer.

By installing Visual Studio on the host computer, you create the files and settings that you will copy to the build computer later. You can install Visual Studio on an x86 or an x64 computer, but the architecture of the build computer must match the architecture of the host computer.

1. On the host computer, install Visual Studio.

2. On the build computer, install the .NET Framework 4.5 or later. To verify that it's installed, check that the **Version** entry in the registry subkey **HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full** has a value of **4.5** or higher.

## Copy files from the host computer to the build computer

This section covers the copying of specific files, compilers, build tools, MSBuild assets, and registry settings from the host computer to the build computer. These instructions assume that you've installed Visual Studio in the default location on the host computer; if you installed in another location, adjust the steps accordingly.

- On an x86 computer, the default location is *C:\Program Files\Microsoft Visual Studio*
- On an x64 computer, the default location is *C:\Program Files (x86)\Microsoft Visual Studio*

Notice that the name of the *Program Files* folder depends on the operating system that's installed. On an x86 computer, the name is *Program Files*; on an x64 computer, the name is *Program Files (x86)*. Irrespective of the system architecture, this walkthrough refers to the *Program Files* folder as *%ProgramFiles%*.

> [!NOTE]
> On the build computer, all of the relevant files must be on the same drive. However, the drive letter for that drive can be different than the drive letter for the drive where Visual Studio is installed on the host computer. In any case, you must account for the location of files when you create registry entries as described later in this document.

### Copy the Windows SDK files to the build computer

1. If you have only the Windows SDK for Windows 8 installed, copy these folders recursively from the host computer to the build computer:

   - %ProgramFiles%\Windows Kits\8.0\bin\

   - %ProgramFiles%\Windows Kits\8.0\Catalogs\

   - %ProgramFiles%\Windows Kits\8.0\DesignTime\

   - %ProgramFiles%\Windows Kits\8.0\include\

   - %ProgramFiles%\Windows Kits\8.0\Lib\

   - %ProgramFiles%\Windows Kits\8.0\Redist\

   - %ProgramFiles%\Windows Kits\8.0\References\

   If you also have these other Windows 8 kits...

   - Microsoft Windows Assessment and Deployment Kit

   - Microsoft Windows Driver Kit

   - Microsoft Windows Hardware Certification Kit

   ...they might have installed files into the *%ProgramFiles%\Windows Kits\8.0* folders that are listed in the previous step, and their license terms might not allow build-server rights for those files. Check the license terms for every installed Windows kit to verify whether files may be copied to your build computer. If the license terms don't allow build-server rights, then remove the files from the build computer.

2. Copy the following folders recursively from the host computer to the build computer:

    - %ProgramFiles%\Microsoft SDKs\Windows\v8.0A\bin\NETFX 4.0 Tools\

    - %ProgramFiles%\Common Files\Merge Modules\

    - %ProgramFiles%\Microsoft Visual Studio\\\<version>\\\<edition>\VC\

    - %ProgramFiles%\Microsoft Visual Studio\\\<version>\\\<edition>\Common7\Tools\ProjectComponents\

    - %ProgramFiles%\MSBuild\Microsoft.Cpp\v4.0\v110\

    - %ProgramFiles%\Reference Assemblies\Microsoft\Framework\\.NETCore\v4.5\

    - %ProgramFiles%\Reference Assemblies\Microsoft\Framework\\.NETFramework\v4.5\

3. Copy these files from the host computer to the build computer:

    - %ProgramFiles%\Microsoft Visual Studio\\\<version>\\\<edition>\Common7\IDE\msobj110.dll

    - %ProgramFiles%\Microsoft Visual Studio\\\<version>\\\<edition>\Common7\IDE\mspdb110.dll

    - %ProgramFiles%\Microsoft Visual Studio\\\<version>\\\<edition>\Common7\IDE\mspdbcore.dll

    - %ProgramFiles%\Microsoft Visual Studio\\\<version>\\\<edition>\Common7\IDE\mspdbsrv.exe

    - %ProgramFiles%\Microsoft Visual Studio\\\<version>\\\<edition>\Common7\IDE\msvcdis110.dll

    - %ProgramFiles%\Microsoft Visual Studio\\\<version>\\\<edition>\Common7\Tools\makehm.exe

    - %ProgramFiles%\Microsoft Visual Studio\\\<version>\\\<edition>\Common7\Tools\VCVarsQueryRegistry.bat

    - %ProgramFiles%\Microsoft Visual Studio\\\<version>\\\<edition>\Common7\Tools\vsvars32.bat

4. The following Microsoft Visual C++ Runtime libraries are required only if you run build outputs on the build computer—for example, as part of automated testing. The files are typically located in subfolders under the *%ProgramFiles%\Microsoft Visual Studio\\\<version>\\\<edition>\VC\redist\x86* or *%ProgramFiles%\Microsoft Visual Studio\\\<version>\\\<edition>\VC\redist\x64* folder, depending on the system architecture. On x86 systems, copy the x86 binaries to the *Windows\System32* folder. On x64 systems, copy the x86 binaries to the *Windows\SysWOW64* folder, and the x64 binaries to the *Windows\System32* folder.

    - \Microsoft.VC110.ATL\atl110.dll

    - \Microsoft.VC110.CRT\msvcp110.dll

    - \Microsoft.VC110.CRT\msvcr110.dll

    - \Microsoft.VC110.CXXAMP\vcamp110.dll

    - \Microsoft.VC110.MFC\mfc110.dll

    - \Microsoft.VC110.MFC\mfc110u.dll

    - \Microsoft.VC110.MFC\mfcm110.dll

    - \Microsoft.VC110.MFC\mfcm110u.dll

    - \Microsoft.VC110.MFCLOC\mfc110chs.dll

    - \Microsoft.VC110.MFCLOC\mfc110cht.dll

    - \Microsoft.VC110.MFCLOC\mfc110deu.dll

    - \Microsoft.VC110.MFCLOC\mfc110enu.dll

    - \Microsoft.VC110.MFCLOC\mfc110esn.dll

    - \Microsoft.VC110.MFCLOC\mfc110fra.dll

    - \Microsoft.VC110.MFCLOC\mfc110ita.dll

    - \Microsoft.VC110.MFCLOC\mfc110jpn.dll

    - \Microsoft.VC110.MFCLOC\mfc110kor.dll

    - \Microsoft.VC110.MFCLOC\mfc110rus.dll

    - \Microsoft.VC110.OPENMP\vcomp110.dll

5. Copy only the following files from the *Debug_NonRedist\x86* or *Debug_NonRedist\x64* folder to the build computer, as described in [Prepare a test machine to run a debug executable](/cpp/windows/preparing-a-test-machine-to-run-a-debug-executable). No other files may be copied.

    - \Microsoft.VC110.DebugCRT\msvcp110d.dll

    - \Microsoft.VC110.DebugCRT\msvcr110d.dll

    - \Microsoft.VC110.DebugCXXAMP\vcamp110d.dll

    - \Microsoft.VC110.DebugMFC\mfc110d.dll

    - \Microsoft.VC110.DebugMFC\mfc110ud.dll

    - \Microsoft.VC110.DebugMFC\mfcm110d.dll

    - \Microsoft.VC110.DebugMFC\mfcm110ud.dll

    - \Microsoft.VC110.DebugOpenMP\vcomp110d.dll

## Create registry settings

You must create registry entries to configure settings for MSBuild.

1. Identify the parent folder for registry entries. All of the registry entries are created under the same parent key. On an x86 computer, the parent key is **HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft**. On an x64 computer, the parent key is **HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft**. Irrespective of the system architecture, this walkthrough refers to the parent key as %RegistryRoot%.

    > [!NOTE]
    > If the architecture of your host computer differs from that of your build computer, make sure to use the appropriate parent key on each computer. This is especially important if you're automating the export process.
    >
    > Also, if you're using a different drive letter on the build computer than the one that you're using on the host computer, make sure to change the values of the registry entries to match.

2. Create the following registry entries on the build computer. All of these entries are strings (Type == "REG_SZ" in the registry). Set the values of these entries the same as the values of the comparable entries on the host computer.

   - **%RegistryRoot%\\.NETFramework\v4.0.30319\AssemblyFoldersEx\VCMSBuild Public Assemblies@(Default)**

   - <strong>%RegistryRoot%\Microsoft SDKs\Windows\v8.0@InstallationFolder</strong>

   - <strong>%RegistryRoot%\Microsoft SDKs\Windows\v8.0A@InstallationFolder</strong>

   - <strong>%RegistryRoot%\Microsoft SDKs\Windows\v8.0A\WinSDK-NetFx40Tools@InstallationFolder</strong>

   - <strong>%RegistryRoot%\Microsoft SDKs\Windows\v8.0A\WinSDK-NetFx40Tools-x86@InstallationFolder</strong>

   - **%RegistryRoot%\VisualStudio\11.0@Source Directories**

   - <strong>%RegistryRoot%\VisualStudio\11.0\Setup\VC@ProductDir</strong>

   - <strong>%RegistryRoot%\VisualStudio\SxS\VC7@FrameworkDir32</strong>

   - <strong>%RegistryRoot%\VisualStudio\SxS\VC7@FrameworkDir64</strong>

   - <strong>%RegistryRoot%\VisualStudio\SxS\VC7@FrameworkVer32</strong>

   - <strong>%RegistryRoot%\VisualStudio\SxS\VC7@FrameworkVer64</strong>

   - **%RegistryRoot%\VisualStudio\SxS\VC7@11.0**

   - **%RegistryRoot%\VisualStudio\SxS\VS7@11.0**

   - <strong>%RegistryRoot%\Windows Kits\Installed Roots@KitsRoot</strong>

   - <strong>%RegistryRoot%\MSBuild\ToolsVersions\4.0\11.0@VCTargetsPath</strong>

   - <strong>%RegistryRoot%\MSBuild\ToolsVersions\4.0\11.0@VCTargetsPath10</strong>

   - <strong>%RegistryRoot%\MSBuild\ToolsVersions\4.0\11.0@VCTargetsPath11</strong>

   On an x64 build computer, also create the following registry entry and refer to the host computer to determine how to set it.

   - <strong>%RegistryRoot%\Microsoft SDKs\Windows\v8.0A\WinSDK-NetFx40Tools-x64@InstallationFolder</strong>

   If your build computer is x64 and you want to use the 64-bit version of MSBuild, or if you're using Team Foundation Server Build Service on an x64 computer, create the following registry entries in the native 64-bit registry. Refer to the host computer to determine how to set these entries.

   - <strong>HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\11.0\Setup\VS@ProductDir</strong>

   - <strong>HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSBuild\ToolsVersions\4.0\11.0@VCTargetsPath</strong>

   - <strong>HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSBuild\ToolsVersions\4.0\11.0@VCTargetsPath10</strong>

   - <strong>HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSBuild\ToolsVersions\4.0\11.0@VCTargetsPath11</strong>

## Set environment variables on the build computer

To use MSBuild on the build computer, you must set the PATH environment variables. You can use *vcvarsall.bat* to set the variables, or you can manually configure them.

### Use vcvarsall.bat to set environment variables

Open a **Command Prompt** window on the build computer and run *%Program Files%\Microsoft Visual Studio\\\<version>\\\<edition>\VC\vcvarsall.bat*. You can use a command-line argument to specify the toolset you want to use—x86, native x64, or x64 cross-compiler. If you don't specify a command-line argument, the x86 toolset is used.

This table describes the supported arguments for *vcvarsall.bat*:

|Vcvarsall.bat argument|Compiler|Build computer architecture|Build output architecture|
| - |--------------| - | - |
|x86 (default)|32-bit Native|x86, x64|x86|
|x86_amd64|x64 Cross|x86, x64|x64|
|amd64|x64 Native|x64|x64|

If *vcvarsall.bat* runs successfully—that is, no error message is displayed—you can skip the next step and continue at the [Install MSBuild assemblies to the Global Assembly Cache (GAC) on the build computer](#install-msbuild-to-gac) section of this document.

### Manually set environment variables

1. To manually configure the command-line environment, add this path to the PATH environment variable:

    - %Program Files%\Microsoft Visual Studio\\\<version>\\\<edition>\Common7\IDE

2. Optionally, you can also add the following paths to the PATH variable to make it easier to use MSBuild to build your solutions.

   If you want to use the native 32-bit MSBuild, add these paths to the PATH variable:

   - %Program Files%\Microsoft SDKs\Windows\v8.0A\bin\NETFX 4.0 Tools

   - %windir%\Microsoft.NET\Framework\v4.0.30319

   If you want to use the native 64-bit MSBuild, add these paths to the PATH variable:

   - %Program Files%\Microsoft SDKs\Windows\v8.0A\bin\NETFX 4.0 Tools\x64

   - %windir%\Microsoft.NET\Framework64\v4.0.30319

## <a name="install-msbuild-to-gac"></a> Install MSBuild assemblies to the Global Assembly Cache (GAC) on the build computer

MSBuild requires some additional assemblies to be installed to the GAC on the build computer.

1. Copy the following assemblies from the host computer to the build computer. Because they will be installed to the GAC, it doesn't matter where you put them on the build computer.

    - %ProgramFiles%\MSBuild\Microsoft.Cpp\v4.0\v110\Microsoft.Build.CPPTasks.Common.v110.dll

    - %ProgramFiles%\Microsoft Visual Studio\\\<version>\\\<edition>\Common7\IDE\CommonExtensions\Microsoft\VC\Project\Microsoft.VisualStudio.Project.VisualC.VCProjectEngine.dll

    - %ProgramFiles%\Microsoft Visual Studio\\\<version>\\\<edition>\Common7\IDE\PublicAssemblies\Microsoft.VisualStudio.VCProjectEngine.dll

2. To install the assemblies to the GAC, locate *gacutil.exe* on the build computer—typically, it's in %ProgramFiles%\Microsoft SDKs\Windows\v8.0A\bin\NETFX 4.0 Tools\\. If you can't locate this folder, repeat the steps in the [Copy files from the host computer to the build computer](../ide/walkthrough-creating-a-multiple-computer-build-environment.md#copy-files-from-the-host-computer-to-the-build-computer) section of this walkthrough.

     Open a **Command Prompt** window that has administrative rights and run this command for each file:

     **gacutil -i \<file>**

    > [!NOTE]
    > A reboot may be required for an assembly to fully install into the GAC.

## Build projects

You can use Azure Pipelines to build Visual Studio projects and solutions, or you can build them on the command line. When you use Azure Pipelines to build projects, it invokes the MSBuild executable that corresponds to the system architecture. On the command line, you can use either 32-bit MSBuild or 64-bit MSBuild, and you can choose the architecture of MSBuild by setting the PATH environment variable or by directly invoking the architecture-specific MSBuild executable.

To use *msbuild.exe* at the command prompt, run the following command, in which *solution.sln* is a placeholder for the name of your solution.

**msbuild** *solution.sln*

For more information about how to use MSBuild on the command line, see [Command-line reference](../msbuild/msbuild-command-line-reference.md).

## Create the build environment so that it can be checked into source control

You can create a build environment that can be deployed to various computers and doesn't require "GAC"-ing files or modifying registry settings. The following steps are just one way to accomplish this. Adapt these steps to the unique characteristics of your build environment.

> [!NOTE]
> You must disable incremental building so that *tracker.exe* will not throw an error during a build. To disable incremental building, set this build parameter:
>
> **msbuild** *solution.sln* **/p:TrackFileAccess=false**

1. Create a *Depot* directory on the host computer.

     These steps refer to the directory as %Depot%.

2. Copy the directories and files as described in the [Copy files from the host computer to the build computer](../ide/walkthrough-creating-a-multiple-computer-build-environment.md#copy-files-from-the-host-computer-to-the-build-computer) section of this walkthrough, except paste them under the *%Depot%* directory that you just created. For example, copy from *%ProgramFiles%\Windows Kits\8.0\bin* to *%Depot%\Windows Kits\8.0\bin*.

3. When the files are pasted in *%Depot%*, make these changes:

    - In %Depot%\MSBuild\Microsoft.Cpp\v4.0\v110\Microsoft.CPP.Targets, \Microsoft.Cpp.InvalidPlatforms.targets\\, \Microsoft.cppbuild.targets\\, and \Microsoft.CppCommon.targets\\, change every instance of

         AssemblyName="Microsoft.Build.CppTasks.Common.v110, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"

         to

         AssemblyFile="$(VCTargetsPath11)Microsoft.Build.CppTasks.Common.v110.dll".

         The former naming relies on the assembly being GAC'ed.

    - In %Depot% \MSBuild\Microsoft.Cpp\v4.0\v110\Microsoft.CPPClean.Targets, change every instance of

         AssemblyName="Microsoft.Build.CppTasks.Common.v110, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"

         to

         AssemblyFile="$(VCTargetsPath11)Microsoft.Build.CppTasks.Common.v110.dll".

4. Create a *.props* file—for example, *Partner.AutoImports.props*—and put it at the root of the folder that contains your projects. This file is used to set variables that are used by MSBuild to find various resources. If the variables are not set by this file, they are set by other *.props* files and *.targets* files that rely on registry values. Because we aren't setting any registry values, these variables would be empty and the build would fail. Instead, add this to *Partner.AutoImports.props*:

    ```xml
    <?xml version="1.0" encoding="utf-8"?>
    <!-- This file must be imported by all project files at the top of the project file. -->
    <Project ToolsVersion="4.0"
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
    <PropertyGroup>
    <VCTargetsPath>$(DepotRoot)MSBuild\Microsoft.Cpp\v4.0\v110\</VCTargetsPath>
    <VCTargetsPath11>$(DepotRoot)MSBuild\Microsoft.Cpp\v4.0\v110\</VCTargetsPath11>
    <MSBuildExtensionsPath>$(DepotRoot)MSBuild</MSBuildExtensionsPath>
    <MSBuildExtensionsPath32>$(DepotRoot)MSBuild</MSBuildExtensionsPath32>
    <VCInstallDir_110>$(DepotRoot)Microsoft Visual Studio\2017\Enterprise\VC\</VCInstallDir_110>
    <VCInstallDir>$(VCInstallDir_110)</VCInstallDir>
    <WindowsKitRoot>$(DepotRoot)Windows Kits\</WindowsKitRoot>
    <WindowsSDK80Path>$(WindowsKitRoot)</WindowsSDK80Path>
    <WindowsSdkDir_80>$(WindowsKitRoot)8.0\</WindowsSdkDir_80>
    <WindowsSdkDir>$(WindowsSDKDir_80)</WindowsSdkDir>
    <WindowsSdkDir_80A>$(DepotRoot)Microsoft SDKs\Windows\v8.0A\</WindowsSdkDir_80A>
    </PropertyGroup>
    </Project>
    ```

5. In each of your project files, add the following line at the top, after the `<Project Default Targets...>` line.

    ```xml
    <Import Project="$([MSBuild]::GetDirectoryNameOfFileAbove($(MSBuildThisFileDirectory), Partner.AutoImports.props))\Partner.AutoImports.props"/>
    ```

6. Change the command-line environment as follows:

    - Set Depot=*location of the Depot directory that you created in step 1*

    - Set path=%path%;*location of MSBuild on the computer*;%Depot%\Windows\System32;%Depot%\Windows\SysWOW64;%Depot%\Microsoft Visual Studio 16.0\Common7\IDE\

       For native 64-bit building, point to the 64-bit version of MSBuild.

## Related content

- [Prepare a test machine to run a debug executable](/cpp/windows/preparing-a-test-machine-to-run-a-debug-executable)
- [Command-line reference](../msbuild/msbuild-command-line-reference.md)