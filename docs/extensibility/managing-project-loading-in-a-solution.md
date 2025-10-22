---
title: Managing Project Loading in a Solution
description: Learn how developers can reduce solution load times and manage project loading behavior by creating a solution load manager.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- solutions, managing project loading
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
monikerRange: "vs-2019"
---
# Manage project loading in a solution

Visual Studio solutions can contain a large number of projects. The default Visual Studio behavior is to load all the projects in a solution at the time the solution is opened, and not to allow the user to access any of the projects until all of them have finished loading. When the process of project loading will last more than two minutes, a progress bar is displayed showing the number of projects loaded and the total number of projects. The user can unload projects while working in a solution with multiple projects, but this procedure has some disadvantages: the unloaded projects are not built as part of a Rebuild Solution command, and IntelliSense descriptions of types and members of closed projects are not displayed.

 Developers can reduce solution load times and manage project loading behavior by creating a solution load manager. The solution load manager can make sure that projects are loaded before starting a background build, delay background loading until other background tasks are complete, and perform other project load management tasks.

## Create a solution load manager
 Developers can create a solution load manager by implementing <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadManager> and advising Visual Studio that the solution load manager is active.

### Activate a solution load manager
 Visual Studio allows only one solution load manager at a given time, so you must advise Visual Studio when you want to activate your solution load manager. If a second solution load manager is activated later on, your solution load manager will be disconnected.

 You must get the <xref:Microsoft.VisualStudio.Shell.Interop.SVsSolution> service and set the [__VSPROPID4.VSPROPID_ActiveSolutionLoadManager](<xref:Microsoft.VisualStudio.Shell.Interop.__VSPROPID4.VSPROPID_ActiveSolutionLoadManager>) property:

```csharp
IVsSolution pSolution = GetService(typeof(SVsSolution)) as IVsSolution;
object objLoadMgr = this;   //the class that implements IVsSolutionManager
pSolution.SetProperty((int)__VSPROPID4.VSPROPID_ActiveSolutionLoadManager, objLoadMgr);
```

 The <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadManager.OnDisconnect%2A> method is called either when Visual Studio is being shut down or when a different package has taken over as the active solution load manager by calling <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution.SetProperty%2A> with the [__VSPROPID4.VSPROPID_ActiveSolutionLoadManager](<xref:Microsoft.VisualStudio.Shell.Interop.__VSPROPID4.VSPROPID_ActiveSolutionLoadManager>) property.

#### Strategies for different kinds of solution load manager
 You can implement solution load managers in different ways, depending on the types of solutions they are meant to manage.

 If the solution load manager is meant to manage solution loading in general, it can be implemented as part of a VSPackage. The package should be set to autoload by adding the <xref:Microsoft.VisualStudio.Shell.ProvideAutoLoadAttribute> on the VSPackage with a value of <xref:Microsoft.VisualStudio.VSConstants.UICONTEXT.SolutionOpening_guid>. The solution load manager can then be activated in the <xref:Microsoft.VisualStudio.Shell.Package.Initialize%2A> method.

> [!NOTE]
> For more information about autoloading packages, see [Loading VSPackages](../extensibility/loading-vspackages.md).

 Since Visual Studio recognizes only the last solution load manager to be activated, general solution load managers should always detect whether there is an existing load manager before activating themselves. If calling `GetProperty()` on the solution service for [__VSPROPID4.VSPROPID_ActiveSolutionLoadManager](<xref:Microsoft.VisualStudio.Shell.Interop.__VSPROPID4.VSPROPID_ActiveSolutionLoadManager>) returns `null`, there is no active solution load manager. If it does not return null, check whether the object is the same as your solution load manager.

 If the solution load manager is meant to manage only a few types of solution, the VSPackage can subscribe to solution load events (by calling <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution.AdviseSolutionEvents%2A>), and use the event handler for <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadEvents.OnBeforeOpenSolution%2A> to activate the solution load manager.

 If the solution load manager is meant to manage only specific solutions, the activation information can be persisted as part of the solution file by calling <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistSolutionProps.WriteSolutionProps%2A> for the pre-solution section.

 Specific solution load managers should deactivate themselves in the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents.OnAfterCloseSolution%2A> event handler, in order not to conflict with other solution load managers.

 If you need a solution load manager only to persist global project load properties (for example, properties set on an Options page), you can activate the solution load manager in the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents3.OnAfterOpenProject%2A> event handler, persist the setting in the solution properties, then deactivate the solution load manager.

## Handle solution load events
 To subscribe to solution load events, call <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution.AdviseSolutionEvents%2A> when you activate your solution load manager. If you implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadEvents>, you can respond to events that relate to different project loading properties.

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadEvents.OnBeforeOpenSolution%2A>: This event is fired before a solution is opened.

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadEvents.OnBeforeBackgroundSolutionLoadBegins%2A>: This event is fired after the solution is completely loaded, but before background project loading begins again.

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadEvents.OnAfterBackgroundSolutionLoadComplete%2A>: This event is fired after a solution is initially fully loaded, whether or not there is a solution load manager. It is also fired after background load or demand load whenever the solution becomes fully loaded. At the same time, <xref:Microsoft.VisualStudio.VSConstants.UICONTEXT.SolutionExistsAndFullyLoaded_guid> is reactivated.

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadEvents.OnQueryBackgroundLoadProjectBatch%2A>: This event is fired before the loading of a project (or projects). To ensure that other background processes are completed before the projects are loaded, set `pfShouldDelayLoadToNextIdle` to **true**.

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadEvents.OnBeforeLoadProjectBatch%2A>: This event is fired when a batch of projects is about to be loaded. If `fIsBackgroundIdleBatch` is true, the projects are to be loaded in the background; if `fIsBackgroundIdleBatch` is false, the projects are to be loaded synchronously as a result of a user request, for example if the user expands a pending project in Solution Explorer. You can handle this event to do expensive work that otherwise would need to be done in <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents3.OnAfterOpenProject%2A>.

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadEvents.OnAfterLoadProjectBatch%2A>: This event is fired after a batch of projects has been loaded.

## Detect and manage solution and project loading
 In order to detect the load state of projects and solutions, call <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution.GetProperty%2A> with the following values:

- [__VSPROPID4.VSPROPID_IsSolutionFullyLoaded](<xref:Microsoft.VisualStudio.Shell.Interop.__VSPROPID4.VSPROPID_IsSolutionFullyLoaded>): `var` returns `true` if the solution and all its projects are loaded, otherwise `false`.

- [__VSPROPID4.VSPROPID_IsInBackgroundIdleLoadProjectBatch](<xref:Microsoft.VisualStudio.Shell.Interop.__VSPROPID4.VSPROPID_IsInBackgroundIdleLoadProjectBatch>): `var` returns `true` if a batch of projects is currently being loaded in the background, otherwise `false`.

- [__VSPROPID4.VSPROPID_IsInSyncDemandLoadProjectBatch](<xref:Microsoft.VisualStudio.Shell.Interop.__VSPROPID4.VSPROPID_IsInSyncDemandLoadProjectBatch>): `var` returns `true` if a batch of projects is currently being loaded synchronously as a result of a user command or other explicit load, otherwise `false`.

- [__VSPROPID2.VSPROPID_IsSolutionClosing](<xref:Microsoft.VisualStudio.Shell.Interop.__VSPROPID2.VSPROPID_IsSolutionClosing>): `var` returns `true` if the solution is currently being closed, otherwise `false`.

- [__VSPROPID.VSPROPID_IsSolutionOpening](<xref:Microsoft.VisualStudio.Shell.Interop.__VSPROPID.VSPROPID_IsSolutionOpening>): `var` returns `true` if a solution is currently being opened, otherwise `false`.

You can also ensure that projects and solutions are loaded by calling one of the following methods:

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution4.EnsureSolutionIsLoaded%2A>: calling this method forces the projects in a solution to load before the method returns.

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution4.EnsureProjectIsLoaded%2A>: calling this method forces the projects in `guidProject` to load before the method returns.

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution4.EnsureProjectsAreLoaded%2A>: calling this method forces the project in `guidProjectID` to load before the method returns.
