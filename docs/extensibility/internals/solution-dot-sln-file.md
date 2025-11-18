---
title: Project Solution (.sln) file
description: Explore the project solution (.sln) file, which is one of the files that maintains state information for a project in Visual Studio.
ms.date: 02/02/2022
ms.topic: how-to
helpviewer_keywords:
- sln files, VSPackages
- solutions, .sln files
- .sln files, VSPackages
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Solution (.sln) file

A solution is a structure for organizing projects in Visual Studio. The solution maintains the state information for projects in two files:

- `.sln` file (text-based, shared)

- `.suo` file (binary, user-specific solution options)

For more information about .suo files, see [Solution User Options (.suo) File](../../extensibility/internals/solution-user-options-dot-suo-file.md).

If your VSPackage is loaded because of being referenced in the `.sln` file, the environment calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistSolutionProps.ReadSolutionProps%2A> to read in the `.sln` file.

The `.sln` file contains text-based information the environment uses to find and load the name-value parameters for the persisted data and the project VSPackages it references. When a user opens a solution, the environment cycles through the `preSolution`, `Project`, and `postSolution` information in the `.sln` file to load the solution, projects within the solution, and any persisted information attached to the solution.

Each project's file contains additional information read by the environment to populate the hierarchy with that project's items. The hierarchy data persistence is controlled by the project. The data isn't normally stored in the `.sln` file, although you can intentionally write project information to the `.sln` file if you choose to do so. For more information about persistence, see [Project Persistence](../../extensibility/internals/project-persistence.md) and [Opening and Saving Project Items](../../extensibility/internals/opening-and-saving-project-items.md).

## File header

The header of an `.sln` file looks like this:

::: moniker range="=vs-2019"

```
Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 16
VisualStudioVersion = 16.0.28701.123
MinimumVisualStudioVersion = 10.0.40219.1
```

::: moniker-end

::: moniker range=">=vs-2022"

```
Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 17
VisualStudioVersion = 17.2.32505.173
MinimumVisualStudioVersion = 10.0.40219.1
```

::: moniker-end

### Definitions

::: moniker range="=vs-2019"

`Microsoft Visual Studio Solution File, Format Version 12.00`\
Standard header that defines the file format version.

`# Visual Studio Version 16`\
The major version of Visual Studio that (most recently) saved this solution file. This information controls the version number in the solution icon.

`VisualStudioVersion = 16.0.28701.123`\
The full version of Visual Studio that (most recently) saved the solution file. If the solution file is saved by a newer version of Visual Studio that has the same major version, this value isn't updated so as to lessen churn in the file.

`MinimumVisualStudioVersion = 10.0.40219.1`\
The minimum (oldest) version of Visual Studio that can open this solution file.

::: moniker-end

::: moniker range=">=vs-2022"

`Microsoft Visual Studio Solution File, Format Version 12.00`\
Standard header that defines the file format version.

`# Visual Studio Version 17`\
The major version of Visual Studio that (most recently) saved this solution file. This information controls the version number in the solution icon.

`VisualStudioVersion = 17.2.32505.173`\
The full version of Visual Studio that (most recently) saved the solution file. If the solution file is saved by a newer version of Visual Studio that has the same major version. This value isn't updated so as to lessen churn in the file.

`MinimumVisualStudioVersion = 10.0.40219.1`\
The minimum (oldest) version of Visual Studio that can open this solution file.

::: moniker-end

## File body

The body of an `.sln` file consists of several sections labeled `GlobalSection`, like this:

```
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "Project1", "Project1.vbproj", "{8CDD8387-B905-44A8-B5D5-07BB50E05BEA}"
EndProject
Global
  GlobalSection(SolutionNotes) = postSolution
  EndGlobalSection
  GlobalSection(SolutionConfiguration) = preSolution
       ConfigName.0 = Debug
       ConfigName.1 = Release
  EndGlobalSection
  GlobalSection(ProjectDependencies) = postSolution
  EndGlobalSection
  GlobalSection(ProjectConfiguration) = postSolution
   {8CDD8387-B905-44A8-B5D5-07BB50E05BEA}.Debug.ActiveCfg = Debug|x86
   {8CDD8387-B905-44A8-B5D5-07BB50E05BEA}.Debug.Build.0 = Debug|x86
   {8CDD8387-B905-44A8-B5D5-07BB50E05BEA}.Release.ActiveCfg = Release|x86
   {8CDD8387-B905-44A8-B5D5-07BB50E05BEA}.Release.Build.0 = Release|x86
  EndGlobalSection
  GlobalSection(ExtensibilityGlobals) = postSolution
  EndGlobalSection
  GlobalSection(ExtensibilityAddIns) = postSolution
  EndGlobalSection
EndGlobal
```

To load a solution, the environment does the following sequence of tasks:

1. The environment reads the Global section of the `.sln` file and processes all sections marked `preSolution`. In this example file, there's one such statement:

   ```
   GlobalSection(SolutionConfiguration) = preSolution
        ConfigName.0 = Debug
        ConfigName.1 = Release
   ```

   When the environment reads the `GlobalSection('name')` tag, it maps the name to a VSPackage using the registry. The key name should exist in the registry under `[HKLM\\<Application ID Registry Root\>\SolutionPersistence\AggregateGUIDs]`. The keys' default value is the Package GUID (REG_SZ) of the VSPackage that wrote the entries.

1. The environment loads the VSPackage, calls `QueryInterface` on the VSPackage for the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistSolutionProps> interface, and calls the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistSolutionProps.ReadSolutionProps%2A> method with the data in the section so the VSPackage can store the data. The environment repeats this process for each `preSolution` section.

1. The environment iterates through the project persistence blocks. In this case, there's one project.

   ```
   Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "Project1",
   "Project1.vbproj", "{8CDD8387-B905-44A8-B5D5-07BB50E05BEA}"
   EndProject
   ```

   This statement contains the unique project GUID and the project type GUID. This information is used by the environment to find the project file or files belonging to the solution, and the VSPackage required for each project. The project GUID is passed to <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectFactory> to load the specific VSPackage related to the project, then the project is loaded by the VSPackage. In this case, the VSPackage that is loaded for this project is Visual Basic.

   Each project can persist a unique project instance ID so that it can be accessed as needed by other projects in the solution. Ideally, if the solution and projects are under source code control, the path to the project should be relative to the path of the solution. When the solution is first loaded, the project files can't be on the user's machine. By having the project file that is stored on the server relative to the solution file, it is simpler for the project file to be found and copied to the user's machine. It then copies and loads the rest of the files needed for the project.

1. Based on the information contained in the project section of the `.sln` file, the environment loads each project file. The project itself is then responsible for populating the project hierarchy and loading any nested projects.

1. After all sections of the `.sln` file are processed, the solution is displayed in Solution Explorer and is ready for modification by the user.

If any project in the solution that implements VSPackage fails to load, the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistSolutionProps.OnProjectLoadFailure%2A> method is called and all the projects in the solution ignore changes it might have made during loading. For any parsing errors, as much information as possible is preserved with the solution files. The environment displays a dialog box warning the user that the solution is corrupted.

When the solution is saved or closed, the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistSolutionProps.QuerySaveSolutionProps%2A> method is called. It's passed to the hierarchy to see if changes have been made to the solution that need to be entered into the `.sln` file. A null value, passed in to `QuerySaveSolutionProps` in <xref:Microsoft.VisualStudio.Shell.Interop.VSQUERYSAVESLNPROPS>, indicates that information is being persisted for the solution. If the value isn't null, the persisted information is for a specific project, determined by the pointer to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> interface.

If there's information to be saved, the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionPersistence> interface is called with a pointer to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistSolutionProps.SaveSolutionProps%2A> method. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistSolutionProps.WriteSolutionProps%2A> method is then called by the environment to retrieve the name-value pairs from `IPropertyBag` interface and write the information to the `.sln` file.

`SaveSolutionProps` and `WriteSolutionProps` objects are called recursively by the environment to retrieve information to be saved from the `IPropertyBag` interface until all changes have been entered into the `.sln` file. In this way, you can ensure that the information will be persisted with the solution and available next time the solution is opened.

Every loaded VSPackage is enumerated to see if it has anything to save to `.sln` file. It's only at load time that the registry keys are queried. The environment knows about all of the loaded packages because they are in memory at the time the solution is saved.

Only the `.sln` file contains entries in the `preSolution` and `postSolution` sections. There are no similar sections in the .suo file since the solution needs this information to load properly. The `.suo` file contains user-specific options such as private notes that aren't intended to be shared or placed under source code control.

## Related content

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistSolutionProps>
- [Solution User Options (.suo) File](../../extensibility/internals/solution-user-options-dot-suo-file.md)
- [Solutions](../../extensibility/internals/solutions-overview.md)
