---
title: "Lightweight Solution Load (LSL) | Microsoft Docs"
ms.custom: ""
ms.date: "01/17/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords:
  - "VSPackages, lightweight solution load"
  - "VSPackages, fast solution load"
ms.assetid: 0a71d91e-dc71-4d6b-bbfe-9e4ecd9e5fd1
caps.latest.revision: 1
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
# Lightweight Solution Load (LSL)

## Background information on LSL

Lightweight Solution load is a new feature in VS 2017 which will significantly reduce Solution load time, enabling you to be more productive more quickly. When LSL is enabled, Visual Studio will not fully load projects until you start working with them.

LSL can effect Visual Studio extensions. Extensions whose features depend on a project to be loaded may not work or work incorrectly without following the guidance detailed in this document.

For further background on LSL, use the following links:

* [Lightweight Solution Load Blog](https://blogs.msdn.microsoft.com/visualstudio/2016/10/11/shorter-solution-load-time-in-visual-studio-15)
* Questions? Contact us at [lslsupport@microsoft.com](mailto:lslsupport@microsoft.com)

## Enable the setting to load projects in “deferred” mode

1. Close any currently opened solution.
2. Go to **Tools** > **Option** > **Projects and Solutions** > **General** settings page.
3. Check the **Lightweight Solution load** box to enable the setting.

When a solution is opened with the above setting turned on, the IDE shows a regular view of the projects but the projects are not loaded.

## Differences between deferred load and regular load of projects

With Lightweight Solution load, projects are not loaded when opening a solution. For these "deferred projects", a stub hierarchy is created. The Solution Explorer shows the expected view with icons and names of projects, there is no UI indication that some or all projects are in "deferred mode".

With LSL enabled, extensions can no longer expect that needed project(s) are already fully loaded when an operation is triggered. Callers need to check whether they have a dependency on loaded projects. If an extension requires information from a deferred project, the extension do the following:

1. Load the project(s) as necessary.
2. Use the new **Workspace APIs** to get information from a deferred project without loading it.

The new **Workspace APIs** allow extensions to obtain information, such as the owning project of a source file and all of the source files for a specified project, from a deferred project. In some cases, only a limited set of projects need to be loaded. The right option is a balance between frequency of the operations, ease of alternative approaches and overall user experience.

All project and solution load related events are still fired in the LSL mode. This allows components to get the expected behavior from VS and they behave in the same manner as when projects are loaded. The project load related work done during solution open is drastically reduced though.

## UI requirements and changes

All UI must treat loaded and deferred projects as equal. This means any action that can be performed on a loaded project must be applicable to deferred projects, with some exceptions. To help features accomplish this, there are changes to some existing platform APIs as well as the introduction of new APIs.

### Expectations for UI

1. Features must show no visual differences depending on if projects are loaded or deferred.
2. Any listing or enumeration over the solution's loaded projects must include deferred projects.
3. Any action available against a loaded project should be available against a deferred project.
4. Features must request to load project(s) only when:
  * There is direct user interaction with a feature. Do not preemptively load projects.
  * A "See more results" gesture is made by the user. See below for this UI guideline.
  * Only the fully loaded project can be used to satisfy the action. Use LSL and Open Project APIs whenever possible, and send feature request asks when functionality is missing.

### Changes in platform APIs to help drive UI

1. New APIs are provided to ask the solution if it was opened in Lightweight Solution load mode and how many projects are in a deferred state.
2. New event is provided for when all deferred projects are loaded in the solution.
3. New APIs are provided to ask a project if it is deferred.
4. Existing APIs are updated to include deferred projects when asking for loaded projects.
5. Existing APIs are updated to express the solution is fully loaded after solution is opened.

### A proper way to add "See More Results” for a feature.

Features that perform a query on the contents of projects should consider the impact of deferred projects. In some situations, features can get the results of their query from LSL and Workspace APIs for a deferred project. In other cases, a feature’s limitations require projects to be loaded. Both of these situations should provide a new "See more results" gesture that allows users to fully load projects and re-query. This gesture enables features to give a best approximation when there are deferred projects while giving the user a way to get the perfect result when projects are actually loaded.

The general algorithm for features should be:

### When The Query Is Performed Over a Single Project

```csharp
// IsInDeferredState() and EnsureProjectIsLoadedHelper() in this sample can be found in the "Helpful code snippets" section of this document
public void Query(IVsHierarchy projectToQuery)
{
    // 1. Perform calculation/query
    DoQuery(projectToQuery);

    // 2. Present results to the user
    ShowResults();

    // 3. If the project was deferred, then present a "See more results" UI element
    if (IsInDeferredState(projectToQuery))
    {
        ShowSeeMoreResults();
    }
}

public void OnClick_SeeMoreResults()
{
    // 1. Ask ask for the project to be loaded
    IVsHierarchy projectFromLastQuery = GetProjectFromLastQuery();
    IVsHierarchy loadedProject = EnsureProjectIsLoadedHelper(projectFromLastQuery);

    if (loadedProject != null)
    {
        // 2. Re-run the query on the loaded projects
        Query(loadedProject);
    }
    else
    {
        ShowErrorMessage();
    }
}
```

### When The Query Is Performed Over the Whole Solution

```csharp
//    Requires Microsoft.VisualStudio.Shell.Interop.15.0.DesignTime.dll
public void Query()
{
    // 1. Perform calculation/query
    DoQuery();

    // 2. Present results to the user
    ShowResults();

    // 3. If there were deferred projects, then present a "See more results from all projects" UI element
    var solution = // the solution
    object deferredCount = 0;
    int hr = ((IVsSolution)solution).GetProperty((int)__VSPROPID7.VSPROPID_DeferredProjectCount, out deferredCount);
    if (ErrorHandler.Succeeded(hr) && ((uint)deferredCount > 0))
    {
        ShowSeeMoreResults();
    }
}

public void OnClick_SeeMoreResults()
{
    // 1. Force the solution to load, as requested by the user. This brings up a UI with a 'Cancel' button (unless supppresed with __VSBSLFLAGS.VSBSLFLAGS_NotCancelable)
    var solution = // get IVsSolution4
    int hr = ((IVsSolution4)solution).EnsureSolutionIsLoaded((uint)__VSBSLFLAGS.VSBSLFLAGS_None);
    if (ErrorHandler.Succeeded(hr))
    {
        // 2. Re-run the query
        Query();
    }
    else
    {
        ShowErrorMessage();
    }
}
```

## API changes

### New API

IVsSolution7.IsSolutionLoadDeferred(out bool deferred)

Returns true if the current solution has been loaded in deferred mode. Note that, if the solution was initially loaded in deferred mode, even if all the deferred projects are eventually loaded in the current session (due to explicit user gestures or forced by operations), this property would still return true.

__VSPROPID7.VSPROPID_DeferredProjectCount

Returns the count of projects currently in deferred mode. This property will have a value in the range [0, VSPROPID_ProjectCount].

__VSHPROPID9.VSHPROPID_IsDeferred

Returns true if a project hierarchy is in deferred load state.

__VSENUMPROJFLAGS3 with values EPF_DEFERRED and EPF_NOTDEFERRED

These flags can be passed to [IVsSolution.GetProjectEnum()](https://msdn.microsoft.com/en-us/library/microsoft.visualstudio.shell.interop.ivssolution.getprojectenum.aspx) to iterate over deferred and non-deferred projects.

### New events

IVsSolutionEvents7.OnAfterLoadAllDeferredProjects()

This event is raised after all deferred projects have been loaded. At this point VSPROPID_DeferredProjectCount is equal to 0. Note that this event is not raised as part of solution load, and may not be raised at all in a session. It is only fired if and when all deferred projects are loaded.

### Changes to existing API

* Passing [__VSENUMPROJFLAGS](https://msdn.microsoft.com/en-us/library/microsoft.visualstudio.shell.interop.__vsenumprojflags.aspx).EPF_LOADEDINSOLUTION to [IVsSolution.GetProjectEnum()](https://msdn.microsoft.com/en-us/library/microsoft.visualstudio.shell.interop.ivssolution.getprojectenum.aspx) returns deferred projects.
* Passing [__VSENUMPROJFLAGS](https://msdn.microsoft.com/en-us/library/microsoft.visualstudio.shell.interop.__vsenumprojflags.aspx).EPF_UNLOADEDINSOLUTION does not return deferred projects.
* [KnownUIContexts.SolutionExistsAndFullyLoadedContext](https://msdn.microsoft.com/en-us/library/microsoft.visualstudio.shell.knownuicontexts.solutionexistsandfullyloadedcontext.aspx) is set to true on solution open. Deferred projects are treated as loaded so this context is set much earlier than in non-LSL mode.
* [__VSPROPID](https://msdn.microsoft.com/en-us/library/microsoft.visualstudio.shell.interop.__vspropid.aspx).VSPROPID_ProjectCount returns the sum of loaded and deferred projects.

## Helpful code snippets

### Check if a solution was opened in deferred load mode

```csharp
/// <summary>
/// Checks if the solution was opened in LSL mode.
/// </summary>
/// <returns>True if the solution was opened in LSL mode, false otherwise.</returns> public static bool IsSolutionLoadDeferred()
{
    IVsSolution7 vsSolution = ServiceProvider.GlobalProvider.GetService(typeof(SVsSolution)) as IVsSolution7;
    Assumes.Present(vsSolution);

    return vsSolution.IsSolutionLoadDeferred();
}
```

### Check if a project is deferred

```csharp
/// <summary>
/// Checks to see if a project is deferred.
/// </summary>
/// <param name="projectsToLoad">A set of deferred and/or loaded projects to ensure are loaded.</param>
/// <returns>True if the project is deferred. False if it is any other state, such as loaded, unloaded, or virtual.</returns>
/// <remarks>Requires Microsoft.VisualStudio.Shell.15.0.dll</remarks>
public static bool IsInDeferredState(IVsHierarchy vsHierarchy)
{
    object deferred;
    int hr = vsHierarchy.GetProperty((int)VSConstants.VSITEMID.Root, (uint)__VSHPROPID9.VSHPROPID_IsDeferred, out deferred);

    if (ErrorHandler.Succeeded(hr))
    {
        return (bool)deferred;
    }

    return false;
}
```

### Load a project

```csharp
/// <summary>
/// Ensures a project is fully loaded.
/// </summary> /// <param name="projectToLoad">A deferred or loaded project to ensure is loaded.</param>
/// <remarks>Requires Microsoft.VisualStudio.Shell.15.0.dll and Microsoft.VisualStudio.Shell.Interop.dll</remarks>
public static IVsHierarchy EnsureProjectIsLoadedHelper(IVsHierarchy projectToLoad)
{
    int hr = VSConstants.S_OK;
    var solution = // get the solution

    // 1. Ask the solution to load the required project. To reduce wait time,
    //    we load only the project we need, not the entire solution.
    hr = projectToLoad.GetGuidProperty((uint)VSConstants.VSITEMID.Root, (int)__VSHPROPID.VSHPROPID_ProjectIDGuid, out projectGuid);
    hr = ErrorHandler.ThrowOnFailure(hr);
    hr = ((IVsSolution4)solution).EnsureProjectIsLoaded(projectGuid, (uint)__VSBSLFLAGS.VSBSLFLAGS_None);
    hr = ErrorHandler.ThrowOnFailure(hr);

    // 2. After the project is loaded, grab the latest IVsHierarchy object.
    IVsHierarchy loadedProject = null;
    hr = ((IVsSolution)solution).GetProjectOfGuid(projectGuid, out loadedProject);
    hr = ErrorHandler.ThrowOnFailure(hr);

    return loadedProject;
}
```

### Load a set of projects

```csharp
/// <summary>
/// Ensures a collection of IVsHierarchys are loaded. To be used when deferred projects absolutely cannot be used.
/// </summary>
/// <param name="projectsToLoad">A set of deferred and/or loaded projects to ensure are loaded.</param>
/// <remarks>Requires Microsoft.VisualStudio.Shell.15.0.dll and Microsoft.VisualStudio.Shell.Interop.dll</remarks>
public static IReadOnlyCollection<IVsHierarchy> EnsureProjectsAreLoadedHelper(IReadOnlyCollection<IVsHierarchy> projectsToLoad)
{
    if (projectsToLoad == null || projectsToLoad.Count == 0)
        return projectsToLoad;

    int hr = VSConstants.S_OK;
    List<Guid> projectGuids = new List<Guid>(projectsToLoad.Count);
    List<IVsHierarchy> loadedProjects = new List<IVsHierarchy>(projectsToLoad.Count);
    var solution = // get the solution

    // 1. Collect projects to force load
    foreach (var project in projectsToLoad)
    {
        Guid projectGuid;
        hr = project.GetGuidProperty((uint)VSConstants.VSITEMID.Root, (int)__VSHPROPID.VSHPROPID_ProjectIDGuid, out projectGuid)
        hr = ErrorHandler.ThrowOnFailure(hr);
        projectGuids.Add(projectGuid);
    }

    // 2. Ask the solution to load the required projects. To reduce wait time,
    //    we load only the projects we need, not the entire solution.
    hr = ((IVsSolution4)solution).EnsureProjectsAreLoaded(projectCount, projectGuids.ToArray(), (uint)__VSBSLFLAGS.VSBSLFLAGS_None);
    hr = ErrorHandler.ThrowOnFailure(hr);

    // 3. After the projects are loaded, grab the latest IVsHierarchy objects
    foreach (var projectGuid in projectGuids)
    {
        IVsHierarchy loadedProject = null;
        hr = ((IVsSolution)solution).GetProjectOfGuid(projectGuid, out loadedProject);
        hr = ErrorHandler.ThrowOnFailure(hr);
        loadedProjects.Add(loadedProject);
    }

    return loadedProjects;
}
```

### Checks if the solution has deferred projects

```csharp
/// <summary>
/// Checks if the solution has deferred projects
/// </summary>
/// <returns>True if the solution has deferred projects, false otherwise.</returns>
public static bool SolutionHasDeferredProjects()
{
    IVsSolution vsSolution = ServiceProvider.GlobalProvider.GetService(typeof(SVsSolution)) as IVsSolution;
    Assumes.Present(vsSolution);
    object varHasDeferredProjects;
    if (ErrorHandler.Succeeded(vsSolution.GetProperty(
        (int)__VSPROPID7.VSPROPID_DeferredProjectCount, out varHasDeferredProjects)))
    {
        return (int)varHasDeferredProjects != 0;
    }

    return false;
}
```

## Getting Detailed Information with Workspace APIs

### How to get detailed info on a LSL solution

New Workspace APIs are exposed via IVsSolutionWorkspaceService to help retrieve detailed information about a solution.

These APIs can be used to get the current workspace, the active solution, the managed command line info, as well as the index service for the workspace. These APIs can further leverage the index service to get detailed data, e.g. all source files in a project, the owning project of a source file, all projects contained in the current solution, all P2P references in a project, etc.

The following code snippets demonstrate usage of the APIs.

### Get IVsSolutionWorkspaceService in the first place

>**Note:** Please only get IVsSolutionWorkspaceService in LSL scenarios to avoid load of Workspace API package.

```csharp
private readonly Lazy<IVsSolutionWorkspaceService> _solutionWorkspaceService;

[ImportingConstructor]

public DeferredProjectWorkspaceService(SVsServiceProvider serviceProvider)
{
    _solutionWorkspaceService = new Lazy<IVsSolutionWorkspaceService>(
        () => (IVsSolutionWorkspaceService)serviceProvider.GetService(typeof(SVsSolutionWorkspaceService)));
}
```

>**Note:** The following snippets assume _solutionWorkspaceService is already lazily initialized.

### Get managed command line info for deferred projects for active solution configuration

```csharp
/// <summary>
/// Get the managed command line info for active solution configuration
/// </summary>
/// <param name="cancellationToken"> the cancellation token</param>
/// <returns></returns>
public async Task<IReadOnlyDictionary<string, ManagedCommandLineInfo>> GetManagedCommandLineInfoForConfigurationAsyn(CancellationToken cancellationToken)
{
    var dte = ServiceProvider.GetGlobalService(typeof(EnvDTE.DTE)) as EnvDTE.DTE;
    var solutionConfig = (EnvDTE80.SolutionConfiguration2)dte.Solution.SolutionBuild.ActiveConfiguration;

    // Solution configuration is something like "Debug|Any CPU"
    return await _solutionWorkspaceService.Value.GetManagedCommandLineInfoAsync(
        $"{solutionConfig.Name}|{solutionConfig.PlatformName}", cancellationToken).ConfigureAwait(false);
}
```

### Get the active solution file in LSL

```csharp
/// <summary>
/// Get the active solution file.
/// </summary>
/// <returns>The solution file.</returns>
public string GetActiveSolutionFile()
{
    return _solutionWorkspaceService.Value.SolutionFile;
}
```

### Get the owning project of a source file

```csharp
/// <summary>
/// Get the owning projects of a source file.
/// </summary>
/// <param name="filePath">the source file path.</param>
/// <returns></returns>
public async Task<IEnumerable<string>> GetOwningProjectAsync(string filePath)
{
    var workspace = _solutionWorkspaceService.Value.CurrentWorkspace;
    var indexService = workspace.GetIndexWorkspaceService();
    var result = await indexService.GetFileDependantsAsync(filePath, null, String.Empty, (int)FileReferenceInfoType.Source);
    return result.Select(f => f.Path);
}
```

### Get all source files from a project

```csharp
/// <summary>
/// Get all source files from a project.
/// </summary>
/// <param name="projectFilePath">the project file path.</param>
/// <returns></returns>
public async Task<IEnumerable<string>> GetFileReferenceAsync(string projectFilePath)
{
    var workspace = _solutionWorkspaceService.Value.CurrentWorkspace;
    var indexService = workspace.GetIndexWorkspaceService();
    var fileReferenceResult = await indexService.GetFileReferencesAsync(projectFilePath, referenceTypes: (int)FileReferenceInfoType.Source);
    return fileReferenceResult.Select(f => f.Path);
}
```

### Get the P2P references in a project

```csharp
/// <summary>
/// Get outputs of project.
/// </summary>
/// <param name="projectFilePath">the project file path.</param>
/// <returns></returns>
public async Task<IEnumerable<string>> GetFileReferenceAsync(string projectFilePath)
{
    var workspace = _solutionWorkspaceService.Value.CurrentWorkspace;
    var indexService = workspace.GetIndexWorkspaceService();
    var fileReferenceResult = await indexService.GetFileReferencesAsync(projectFilePath, context: "Debug|AnyCPU", referenceTypes: (int)FileReferenceInfoType.Output);
    return fileReferenceResult.Select(f => f.Path);
}
```

### Get all the projects in a solution

```csharp
/// <summary>
/// Get the projects in a solution.
/// </summary>
/// <param name="solutionFilePath">the solution file path.</param>
/// <returns></returns>
public async Task<IEnumerable<string>> GetProjectsInSolutionAsync(string solutionFilePath)
{
    var workspace = _solutionWorkspaceService.Value.CurrentWorkspace;
    var indexService = workspace.GetIndexWorkspaceService();

    // Passing the configuration|Platform that projects apply to; passing null will return projects with all configurations.
    var result = await indexService.GetFileReferencesAsync(solutionFilePath, context: "Debug|AnyCPU", referenceTypes: (int)FileReferenceInfoType.ProjectReference);
    return result.Select(f => f.Path);
}
```

## Troubleshooting

Due to the nature of LSL, it is intentional that users cannot see a difference between loaded and deferred projects. This can make feature development and testing difficult.

You can enable visual hints in the UI for deferred projects by doing the following:

1. Close Visual Studio
2. Regedit.exe
3. Select HKLM
4. **File** > **Load Hive**
5. %localappdata%\microsoft\visualstudio\15.0_<instance ID>\privateregistry.bin
6. Enter "VisualStudio" as a key name
7. Set HKLM\VisualStudio\Software\Microsoft\VisualStudio\15.0_<instanceID>\FeatureFlags\Solution\Loading\Deferred\Hint\Value=1 (DWORD)
8. Select HKLM\VisualStudio
9. **File** > **Unload Hive**
10. Start Visual Studio

For any further questions, please reach out to [lslsupport@microsoft.com](mailto:lslsupport@microsoft.com).






