---
title: Use solution configurations for Start (F5) & Build
description: Implement the solution configurations supported by your project type, which direct the behavior of the Start (F5) key and Build commands.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- solution configurations
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Solution Configuration

Solution configurations store solution-level properties. They direct the behavior of the **Start** (F5) key and **Build** commands. By default, these commands build and start the debug configuration. Both commands execute in the context of a solution configuration. This means that the user can expect F5 to start and build whatever the active solution is configured through the settings. The environment is designed to optimize for solutions rather than projects when it comes to building and running.

 The standard Visual Studio toolbar contains a Start button and a solution configuration drop-down to the right of the Start button. This list allows users to choose the configuration to be started when F5 is pressed, create their own solution configurations, or edit an existing configuration.

> [!NOTE]
> There are no extensibility interfaces to create or edit the solution configurations. You must use `DTE.SolutionBuild`. However, there are extensibility APIs for managing the solution build. For more information, see <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionBuildManager2>.

 Here is how you can implement the solution configurations supported by your project type:

- Project

   Displays the names of projects found in the current solution.

- Configuration

   To provide the list of configurations supported by your project type and displayed in the property pages, implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsCfgProvider2>.

   The Configuration column displays the name of the project configuration to build in this solution configuration, and lists all of the project configurations when you click the arrow button. The environment calls the <xref:Microsoft.VisualStudio.Shell.Interop.IVsCfgProvider2.GetCfgNames%2A> method to fill out this list. If the <xref:Microsoft.VisualStudio.Shell.Interop.IVsCfgProvider2.GetCfgProviderProperty%2A> method indicates that the project supports configuration editing, New or Edit selections are also displayed under the Configuration heading. Each of these selections launch dialog boxes that call methods of the `IVsCfgProvider2` interface to edit the project's configurations.

   If a project does not support configurations, the Configuration column displays None and is disabled.

- Platform

   Displays the platform the selected project configuration builds for, and lists all of the available platforms for the project when you click the arrow button. The environment calls the <xref:Microsoft.VisualStudio.Shell.Interop.IVsCfgProvider2.GetPlatformNames%2A> method to fill out this list. If the <xref:Microsoft.VisualStudio.Shell.Interop.IVsCfgProvider2.GetCfgProviderProperty%2A> method indicates that the project supports platform editing, New or Edit selections are also displayed under the Platform heading. Each of these selections launch dialog boxes that call `IVsCfgProvider2` methods to edit the project's available platforms.

   If a project does not support platforms, the platform column for that project displays None and is disabled.

- Build

   Specifies whether or not the project is built by the current solution configuration. Unselected projects are not built when the solution-level build commands are invoked despite any project dependencies they contain. Projects not selected to be built are still included in debugging, running, packaging, and deployment of the solution.

- Deploy

   Specifies whether or not the project will be deployed when the Start or Deploy commands are used with the selected solution build configuration. The check box for this field will be available if the project supports deploying by implementing the <xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg> interface on its <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectCfg2> object.

  Once a new solution configuration is added, the user can select it from the Solution Configuration drop-down list box on the standard toolbar to build and/or start that configuration.

## Related content
- [Managing Configuration Options](../../extensibility/internals/managing-configuration-options.md)
- [Project Configuration for Building](../../extensibility/internals/project-configuration-for-building.md)
- [Project Configuration Object](../../extensibility/internals/project-configuration-object.md)
