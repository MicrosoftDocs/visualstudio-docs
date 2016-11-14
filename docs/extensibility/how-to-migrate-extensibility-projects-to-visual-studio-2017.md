---
title: "How to: Migrate Extensibility Projects to Visual Studio 2017| Microsoft Docs"
ms.custom: ""
ms.date: "11/09/2016"
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 8ca07b00-a3ff-40ab-b647-c0a93b55e86a
caps.latest.revision: 1
author: "gregvanl"
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
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
# How to: Migrate Extensibility Projects to Visual Studio 2017

>**Note:** This documentation is preliminary and based on the Visual Studio 2017 RC release.

This document explains how to upgrade extensibility projects to Visual Studio 2017. In addition to describing how to update the project files, it also describes how to upgrade from extension manifest version 2 (VSIX v2) to the new version 3 VSIX manifest format (VSIX v3).

## Install Visual Studio 2017 RC with required workloads

Make sure your installation includes the following workloads:

* .NET desktop development
* Visual Studio extension development

## Open VSIX Solution in Visual Studio 2017

All VSIX projects will require a major version one-way upgrade to Visual Studio 2017.

The project file (for example *.csproj) will be updated:

* MinimumVisualStudioVersion - now set to 15.0
* OldToolsVersion (if previously exists) - now set to 14.0

## Update the Microsoft.VSSDK.BuildTools NuGet package

>**Note:** If your solution does not reference the Microsoft.VSSDK.BuildTools NuGet package, you can skip this step.

In order to build your extension in the new VSIX v3 (version 3) format, your solution will need to be built with the new VSSDK Build Tools. This will be installed with Visual Studio 2017 RC, but your VSIX v2 extension might be holding a reference to an older version via NuGet. If so, you will need to manually install an update of the Microsoft.VSSDK.BuildTools NuGet package for your solution. At the time of the RC release, this package will be in "Prerelease" state.

To update the NuGet references to Microsoft.VSSDK.BuildTools:

* Right-click on the Solution and choose **Manage NuGet Packages for Solution…**
* Navigate to the **Updates** tab.
* Check the box to **Include Prerelease**.
* Select Microsoft.VSSDK.BuildTools (latest version).
* Press **Update**.

![VSSDK build tools](media/vssdk-build-tools.png)

>**Note:** The screenshot shows a different version of the BuildTools. Please select the RC version.

## Make changes to the VSIX extension manifest

To ensure that the user's installation of Visual Studio has all the assemblies required to run the extension, specify all the prerequisite components or packages in the extension manifest file. When a user attempts to install the extension, the VSIXInstaller will check to see if all the prerequisites are installed. If some are missing, the user will be prompted to install the missing components as part of the extension installation process.

* Edit the extension manifest file (usually called source.extension.vsixmanifest).
* Ensure `InstallationTarget` includes 15.0.
* Add required installation prerequisites (as shown in the example below).
  * We recommend you specify only Component IDs for installation prerequisites.
  * The DisplayName attribute is optional.
  * See the section at the end of this document for [instructions on identifying Component IDs](#finding-component-ids).

Example:

```xml
<PackageManifest>
 ...
    <Prerequisites>
        <Prerequisite Id="Microsoft.VisualStudio.Component.CoreEditor" Version="[15.0,16.0)" DisplayName="Visual Studio core editor" />
        <Prerequisite Id="Microsoft.VisualStudio.Component.DiagnosticTools" Version="[15.0.25814.0,16.0)" DisplayName="Profiling tools" />
        <Prerequisite Id="Microsoft.VisualStudio.Shell.12.0" Version="[12.0]" />
    </Prerequisites>
 ...
</PackageManifest>
```

### Option: Use the designer to make changes to the VSIX extension manifest

Instead of directly editing the manifest XML, you can use the new **Prerequisites** tab in the Manifest Designer to select the prerequisites and the XML will be updated for you.

>**Note:** The Manifest Designer will only allow you to select Components (not Workloads or Packages) that are installed on the current Visual Studio instance. If you need to add a prerequisite for a workload, package, or component that is not currently installed, edit the manifest XML directly.

* Open source.extension.vsixmanifest [Design] file.
* Select **Prerequisites** tab and press **New** button.

  ![VSIX manifest designer](media/vsix-manifest-designer.png)

* The **Add New Prerequisite** window will open.

  ![add vsix prerequisite](media/add-vsix-prerequisite.png)

* Click on the dropdown for **Name** and select the desired prerequisite.
* Update the version if required.

  >Note: The version field will be pre-populated with the version of the currently installed component, with a range spanning up to (but not including) the next major version of the component.

  ![add roslyn prerequisite](media/add-roslyn-prerequisite.png)

* Press **OK**.

## If migrating from Preview 4 or Preview 5

* Replace `SetupDependencies` with `Prerequisites` and move the elements out of the `Installer` element. `Prerequisites` now sits directly inside the `PackageManifest` element.
* [Optional] Remove the `GenerateVsixV3` element. (This was required in Preview 5 only.) The `GenerateVsixV3` element will be ignored in versions beyond Preview 5.

## Update Debug settings for project

If you wish to debug your extension in an experimental instance of Visual Studio, make sure that the project settings for **Debug** > **Start action** has the **Start external program:** value set to the devenv.exe file of your Visual Studio 2017 installation.

It might look like:

```
C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\devenv.exe
```

![start external program](media/start-external-program.png)

>**Note:** The Debug Start Action is typically stored in the .csproj.user file. This file is usually included in the .gitignore file and, hence, is not normally saved with other project files when committed to source control. As such, if you have pulled your solution fresh from source control it is likely the project will have no values set for Start Action. New VSIX projects created with Visual Studio 2017 will have a .csproj.user file created with defaults pointing to the current Visual Studio install directory. However if you are migrating a VSIX v2 extension, it is likely that the .csproj.user file will contain references to the previous Visual Studio version’s install directory. Setting the value for **Debug** > **Start action** will allow the correct Visual Studio experimental instance to launch when you try to debug your extension.

## Check that the extension builds correctly (as a VSIX v3)

* Build the VSIX project.
* Unzip the generated VSIX.
  * By default, the VSIX file lives inside bin/Debug or bin/Release as [YourCustomExtension].vsix.
  * Rename .vsix to .zip to easily view the contents.
* Check for the existence of three files:
  * extension.vsixmanifest
  * manifest.json
  * catalog.json

## Check when all required prerequisites are installed

Test that the VSIX installs successfully on a machine with all required prerequisites installed.

>**Note:** Before installing any extension, please shut down all instances of Visual Studio.

Attempt to install the extension:

* On Visual Studio 2017 RC

![VSIX installer on Visual Studio 2017](media/vsixinstaller-vs-2017.png)

* Optional: Check on previous versions of Visual Studio.
  * Proves backward compatibility.
  * Should work for Visual Studio 2012, Visual Studio 2013, Visual Studio 2015.
* Optional: Check that VSIX Installer Version Checker offers a choice of versions.
  * Includes previous versions of Visual Studio (if installed).
  * Includes Visual Studio 2017 RC.

If Visual Studio was recently opened, you might see a dialog box like this:

![vs running processes](media/vs-running-processes.png)

Wait for the processes to shut down, or manually end the tasks. You can find the processes by the listed name, or with the PID listed in parenthesis.

>**Note:** These processes will not automatically shut down while an instance of Visual Studio is running. Ensure that you’ve shut down all instances of Visual Studio on the machine – including those from other users, then continue to retry.

## Check when missing the required prerequisites

* Attempt to install the extension on a machine with Visual Studio 2017 RC that DOES NOT CONTAIN all the components defined in the Prerequisites (above).
* Check that the installation identifies the missing component/s and lists them as a prerequisite in the VSIXInstaller.
* Note: Elevation will be required if any prerequisites need to be installed with the extension.

![vsixinstaller missing prerequisite](media/vsixinstaller-missing-prerequisite.png)

## Finding Component IDs

The list of Components can be found in the ComponentIDs folder of this [documentation ZIP file](https://aka.ms/vs2017componentIDs). Use these Component IDs for your Prerequisite IDs in your manifest.

We have provided two options for looking up the components:

### Dependencies.xlsx

There are three columns in the excel sheet: ComponentIds, Version, Dependency.  You can use the filters to search and find specific components and dependencies.

Examples:

* If you know that your project has a reference to VSDebugEng.dll and VSDebug.dll, you can add a filter on the Dependency column and find components that contain those two references.
* If you know that your project deals with debugger elements, you can search on "debugger" in the filter search box to see what components contain debugger in its name.

### PackageDetails folder

In this folder, each component is a separate file.  You can search through the folder to find a component by the file name or find a dependency by the contents of the file.

Examples:

* If you know that your project has a reference to VSDebugEng.dll, you can search "VSDebugEng.dll" in the File Explorer search box to see all files that contain that reference as a dependency.
* If you know that your project deals with debugger elements, you can search for "debugger" in the File Explorer search box to see what components contain debugger in its name.
