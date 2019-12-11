---
title: "Managing Project Loading in a Solution | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "solutions, managing project loading"
ms.assetid: 097c89d0-f76a-4aaf-ada9-9a778bd179a0
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# Managing Project Loading in a Solution
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Visual Studio solutions can contain a large number of projects. The default Visual Studio behavior is to load all the projects in a solution at the time the solution is opened, and not to allow the user to access any of the projects until all of them have finished loading. When the process of project loading will last more than two minutes, a progress bar is displayed showing the number of projects loaded and the total number of projects. The user can unload projects while working in a solution with multiple projects, but this procedure has some disadvantages: the unloaded projects are not built as part of a Rebuild Solution command, and IntelliSense descriptions of types and members of closed projects are not displayed.  
  
 Developers can reduce solution load times and manage project loading behavior by creating a solution load manager. The solution load manager can set different project loading priorities for specific projects or project types, make sure that projects are loaded before starting a background build, delay background loading until other background tasks are complete, and perform other project load management tasks.  
  
## Project loading priorities  
 Visual Studio defines four different project loading priorities:  
  
- <xref:Microsoft.VisualStudio.Shell.Interop._VSProjectLoadPriority> (the default): when a solution is opened, projects are loaded asynchronously. If this priority is set on an unloaded project after the solution is already open, the project will be loaded at the next idle point.  
  
- <xref:Microsoft.VisualStudio.Shell.Interop._VSProjectLoadPriority>: when a solution is opened, projects are loaded in the background, allowing the user to access the projects as they are loaded without having to wait until all the projects are loaded.  
  
- <xref:Microsoft.VisualStudio.Shell.Interop._VSProjectLoadPriority>: projects are loaded when they are accessed. A project is accessed when the user expands the project node in the Solution Explorer, when a file belonging to the project is opened when the solution opens because it is in the open document list (persisted in the solution's user options file), or when another project that is being loaded has a dependency on the project. This type of project is not automatically loaded before starting a build process; the Solution Load Manager is responsible for ensuring that all the necessary projects are loaded. These projects should also be loaded before starting a Find/Replace in Files across the entire solution.  
  
- <xref:Microsoft.VisualStudio.Shell.Interop._VSProjectLoadPriority>: projects are not to be loaded unless the user explicitly requests it. This is the case when projects are explicitly unloaded.  
  
## Creating a solution load manager  
 Developers can create a solution load manager by implementing <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadManager> and advising Visual Studio that the solution load manager is active.  
  
#### Activating a solution load manager  
 Visual Studio allows only one solution load manager at a given time, so you must advise Visual Studio when you want to activate your solution load manager. If a second solution load manager is activated later on, your solution load manager will be disconnected.  
  
 You must get the <xref:Microsoft.VisualStudio.Shell.Interop.SVsSolution> service  and set the <xref:Microsoft.VisualStudio.Shell.Interop.__VSPROPID4> property:  
  
```csharp  
IVsSolution pSolution = GetService(typeof(SVsSolution)) as IVsSolution;  
object objLoadMgr = this;   //the class that implements IVsSolutionManager  
pSolution.SetProperty((int)__VSPROPID4.VSPROPID_ActiveSolutionLoadManager, objLoadMgr);  
```  
  
#### Implementing IVsSolutionLoadManager  
 The <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadManager.OnBeforeOpenProject%2A> method is called during the process of opening the solution. To implement this method, you use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadManagerSupport> service to set the load priority for the type of project you wish to manage. For example, the following code sets C# project types to load in the background:  
  
```csharp  
Guid guidCSProjectType = new Guid("{FAE04EC0-301F-11d3-BF4B-00C04F79EFBC}");  
pSLMgrSupport.SetProjectLoadPriority(guidProjectID, (uint)_VSProjectLoadPriority.PLP_BackgroundLoad);  
```  
  
 The <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadManager.OnDisconnect%2A> method is called either when Visual Studio is being shut down or when a different package has taken over as the active solution load manager by calling <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution.SetProperty%2A> with the <xref:Microsoft.VisualStudio.Shell.Interop.__VSPROPID4> property.  
  
#### Strategies for different kinds of solution load manager  
 You can implement solution load managers in different ways, depending on the types of solutions they are meant to manage.  
  
 If the solution load manager is meant to manage solution loading in general, it can be implemented as part of a VSPackage. The package should be set to autoload by adding the <xref:Microsoft.VisualStudio.Shell.ProvideAutoLoadAttribute> on the VSPackage with a value of <xref:Microsoft.VisualStudio.VSConstants.UICONTEXT.SolutionOpening_guid>. The solution load manager can then be activated in the <xref:Microsoft.VisualStudio.Shell.Package.Initialize%2A> method.  
  
> [!NOTE]
> For more information about autoloading packages, see [Loading VSPackages](../extensibility/loading-vspackages.md).  
  
 Since Visual Studio recognizes only the last solution load manager to be activated, general solution load managers should always detect whether there is an existing load manager before activating themselves. If calling GetProperty() on the solution service for <xref:Microsoft.VisualStudio.Shell.Interop.__VSPROPID4> returns `null`, there is no active solution load manager. If it does not return null, check whether the object is the same as your solution load manager.  
  
 If the solution load manager is meant to manage only a few types of solution, the VSPackage can subscribe to solution load events (by calling <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution.AdviseSolutionEvents%2A>), and use the event handler for <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadEvents.OnBeforeOpenSolution%2A> to activate the solution load manager.  
  
 If the solution load manager is meant to manage only specific solutions, the activation information can be persisted as part of the solution file. To do this, call <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistSolutionProps.WriteSolutionProps%2A> for the pre-solution section.  
  
 Specific solution load managers should deactivate themselves in the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents.OnAfterCloseSolution%2A> event handler, in order not to conflict with other solution load managers.  
  
 If you need a solution load manager only to persist global project load priorities (for example, properties set on an Options page), you can activate the solution load manager in the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents2.OnAfterOpenProject%2A> event handler, persist the setting in the solution properties, then deactivate the solution load manager.  
  
## Handling solution load events  
 To subscribe to solution load events, call <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution.AdviseSolutionEvents%2A> when you activate your solution load manager. If you implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadEvents>, you can respond to events that relate to different project loading priorities.  
  
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadEvents.OnBeforeOpenSolution%2A>: This is fired before a solution is opened. You can use it to change the project loading priority for the projects in the solution.  
  
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadEvents.OnBeforeBackgroundSolutionLoadBegins%2A>: This is fired after the solution is completely loaded, but before background project loading begins again. For example, a user might have accessed a project whose load priority is LoadIfNeeded, or the solution load manager might have changed a project load priority to BackgroundLoad, which would start a background load of that project.  
  
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadEvents.OnAfterBackgroundSolutionLoadComplete%2A>: This is fired after a solution is initially fully loaded, whether or not there is a solution load manager. It is also fired after background load or demand load whenever the solution becomes fully loaded. At the same time, <xref:Microsoft.VisualStudio.VSConstants.UICONTEXT.SolutionExistsAndFullyLoaded_guid> is reactivated.  
  
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadEvents.OnQueryBackgroundLoadProjectBatch%2A>: This is fired before the loading of a project (or projects). To ensure that other background processes are completed before the projects are loaded, set `pfShouldDelayLoadToNextIdle` to **true**.  
  
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadEvents.OnBeforeLoadProjectBatch%2A>: This is fired when a batch of projects is about to be loaded. If `fIsBackgroundIdleBatch` is true, the projects are to be loaded in the background; if `fIsBackgroundIdleBatch` is false, the projects are to be loaded synchronously as a result of a user request, for example if the user expands a pending project in Solution Explorer. You can implement this to do expensive work that otherwise would need to be done in <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents3.OnAfterOpenProject%2A>.  
  
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadEvents.OnAfterLoadProjectBatch%2A>: This is fired after a batch of projects has been loaded.  
  
## Detecting and managing solution and project loading  
 In order to detect the load state of projects and solutions, call <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution.GetProperty%2A> with the following values:  
  
- <xref:Microsoft.VisualStudio.Shell.Interop.__VSPROPID4>: `var` returns `true` if the solution and all its projects are loaded, otherwise `false`.  
  
- <xref:Microsoft.VisualStudio.Shell.Interop.__VSPROPID4>: `var` returns `true` if a batch of projects are currently being loaded in the background, otherwise `false`.  
  
- <xref:Microsoft.VisualStudio.Shell.Interop.__VSPROPID4>: `var` returns `true` if a batch of projects are currently being loaded synchronously as a result of a user command or other explicit load, otherwise `false`.  
  
- <xref:Microsoft.VisualStudio.Shell.Interop.__VSPROPID2>: `var` returns `true` if the solution is currently being closed, otherwise `false`.  
  
- <xref:Microsoft.VisualStudio.Shell.Interop.__VSPROPID>: `var` returns `true` if a solution is currently being opened, otherwise `false`.  
  
  You can also ensure that projects and solutions are loaded (no matter what the project load priorities are) by calling one of the following methods:  
  
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution4.EnsureSolutionIsLoaded%2A>: calling this method forces the projects in a solution to load before the method returns.  
  
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution4.EnsureProjectIsLoaded%2A>: calling this method forces the projects in `guidProject` to load before the method returns.  
  
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution4.EnsureProjectsAreLoaded%2A>: calling this method forces the project in `guidProjectID` to load before the method returns.  
  
> [!NOTE]
> . By default only the projects that have the demand load and background load priorities are loaded, but if the <xref:Microsoft.VisualStudio.Shell.Interop.__VSBSLFLAGS> flag is passed in to the method, all projects will be loaded except for the ones that are marked to load explicitly.
