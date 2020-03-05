---
title: "Application Lifecycle Management (ALM) with Unity Apps | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-unity-tools
ms.topic: conceptual
ms.assetid: 2dc61e63-9ba2-4c16-b1ad-f46249e576b6
caps.latest.revision: 14
author: conceptdev
ms.author: crdun
manager: jillfra
---
# Application Lifecycle Management (ALM) with Unity Apps
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Developing apps for modern platforms involves many more activities than just writing code. These activities, referred to as DevOps (development + operations) span the app’s complete lifecycle and include planning and tracking work, designing and implementing code, managing a source code repository, running builds, managing continuous integrations and deployments, testing (including unit tests and UI tests), running various forms of diagnostics in both development and production environments, and monitoring app performance and user behaviors in real time through telemetry and analytics.  
  
 Visual Studio together with Visual Studio Team Services and Team Foundation Server provide a variety of DevOps capabilities, also referred to as Application Lifecycle Management or ALM. Many of these are applicable to cross-platform projects, including games and immersive graphical apps created with Unity—especially when using C# as a scripting language. However, because Unity has its own development environment and runtime engine, a number of ALM features don't apply as they would to other kinds of projects built in Visual Studio.  
  
 The tables below identifies how Visual Studio ALM features apply or don’t apply when working with Unity. Refer to the linked documentation for details on the features themselves.  
  
## Agile tools  
 Reference link: **[Work](https://msdn.microsoft.com/library/52aa8bc9-fc7e-4fae-9946-2ab255ca7503)** (using Visual Studio Team Services or TFS, including Team Explorer Everywhere)  
  
 General Comment: all planning and tracking features are independent of project type and coding languages.  
  
|Feature|Supported with Unity|Additional Comments|  
|-------------|--------------------------|-------------------------|  
|Manage backlogs and sprints|Yes||  
|Work tracking|Yes||  
|Team room collaboration|Yes||  
|Kanban boards|Yes||  
|Report and visualize progress|Yes||  
  
## Modeling  
 Reference link: **[Analyzing and Modeling Architecture](../modeling/analyze-and-model-your-architecture.md)**  
  
 General Comment: Although these design features are either independent of coding language, or work with .NET languages like C#, they operate on a traditional application paradigm with object hierarchies and class relationships. Designing a game within Unity involves a different paradigm altogether, namely the relationships of graphical objects, sounds, shaders, scripts, and so forth. For this reason, the Visual Studio modeling diagram tools are not particularly relevant to the whole of a Unity project. They could possibly be used to manage relationships within C# scripts, but that is only one part of the whole.  
  
|Feature|Supported with Unity|Additional Comments|  
|-------------|--------------------------|-------------------------|  
|Sequence diagrams|No||  
|Dependency graphs|No||  
|Call hierarchy|No||  
|Class designer|No||  
|Architecture explorer|No||  
|UML diagrams (use case, activity, class, component, sequence, and DSL)|No||  
|Layer diagrams|No||  
|Layer validation|No||  
  
## Code  
  
|Feature|Supported with Unity|Additional Comments|  
|-------------|--------------------------|-------------------------|  
|[Use Team Foundation Version Control](https://msdn.microsoft.com/library/1d629052-c65d-4c5d-81eb-eaa4413fe285) or Visual Studio Team Services|Yes|Unity projects are simply a collection of files that can be placed into version control systems like any other project, but there are a few special considerations described after this table.|  
|[Getting started with Git in Team Services](https://msdn.microsoft.com/library/32f46ecd-1b03-4ef0-a9c4-8a120da2b03f)|Yes|See notes after the table.|  
|[Code analysis/Improve code quality (references, suggested changes, etc.)](https://msdn.microsoft.com/library/73baa961-c21f-43fe-bb92-3f59ae9b5945)|Yes||  
|[Find code changes and other history](../ide/find-code-changes-and-other-history-with-codelens.md)|Yes||  
|[Use code maps to debug your applications](../modeling/use-code-maps-to-debug-your-applications.md)|Yes||  
  
 Special considerations for version control with Unity:  
  
1. Unity tracks metadata about game assets in a single, opaque library that is hidden by default. To keep files and metadata in sync, it is necessary to make the metadata visible and to store it in more-manageable chunks. For details, refer to [Using External Version Control Systems with Unity](https://docs.unity3d.com/Manual/ExternalVersionControlSystemSupport.html) (Unity documentation).  
  
2. Not all files and folders in a Unity project are appropriate for source control, as is also described in the link above. The Assets and ProjectSettings folders should be added, but the Library and Temp folders should not. For an additional list of generated files that would not go into source control, see the discussion [How to use Git for Unity3D source control?](https://stackoverflow.com/questions/18225126/how-to-use-git-for-unity3d-source-control) on StackOverflow. Many developers have also blogged on this subject independently.  
  
3. Binary assets in a Unity project—such as textures or audio files—can take up a large amount of storage. Various source control systems like Git store a unique copy of a file for every change that is made, even if the change affects only a small portion of the file. This can cause the Git repository to become bloated. To address this, Unity developers often elect to add only final assets to their repository, and use a different means of keeping a working history of their assets, such as OneDrive, DropBox, or git-annex. This approach works because such assets typically don’t need to be versioned along with source code changes. Developers also typically set the project editor’s Asset Serialization Mode to Force Text to store scene files in text rather than binary format, which allows for merges in source control. For details, see [Editor Settings](https://docs.unity3d.com/Manual/class-EditorManager.html) (Unity documentation).  
  
## Build  
 Reference link: **[Build](/azure/devops/pipelines/index)**  
  
|Feature|Supported with Unity|Additional Comments|  
|-------------|--------------------------|-------------------------|  
|On-premises TFS server|Possible|Unity projects are built through the Unity environment and not through the Visual Studio build system (building within the Visual Studio Tools for Unity will compile the scripts but not produce an executable). It is possible to [build Unity projects from the command line](https://docs.unity3d.com/Manual/CommandLineArguments.html) (Unity documentation), so it possible to configure an MSBuild process on a TFS server to execute the appropriate Unity commands, provided that Unity itself is installed on that computer.<br /><br /> Unity also offers [Unity Cloud Build](https://build.cloud.unity3d.com/landing/), which monitors a Git or SVN repository and runs periodic builds. At present it does not work with Team Foundation Version Control or Visual Studio Team Services.|  
|On-premises build server linked to Visual Studio Team Services|Possible|Given the same conditions as above, it is further possible to direct builds triggered through Visual Studio Team Services to use an on-premises TFS computer.  See [Build server](https://msdn.microsoft.com/library/2d258a0a-f178-4e93-9da1-eba61151af3c) for instructions.|  
|Hosted controller service of Visual Studio Team Services|No|Unity builds are not presently supported.|  
|Build definitions with pre- and post-scripts|Yes|A custom build definition that uses the Unity command line to run a build can also be configured for pre- and post-build scripts.|  
|Continuous integration including gated check-ins|Yes|Gated check-ins for TFVC only as Git works on a pull-request model rather than check-ins.|  
  
## Testing  
 Reference link: **[Testing the application](https://msdn.microsoft.com/library/796b7d6d-ad45-4772-9719-55eaf5490dac)**  
  
|Feature|Supported with Unity|Additional Comments|  
|-------------|--------------------------|-------------------------|  
|Planning tests, creating test cases and organizing test suites|Yes||  
|Manual testing|Yes||  
|Test Manager (record and playback tests)|Windows devices and Android emulators only||  
|Code coverage|n/a|Not applicable as unit testing happens within Unity and not Visual Studio, see below.|  
|[Unit Test Your Code](../test/unit-test-your-code.md)|Within Unity, but not Visual Studio|Unity provides its own unit test framework as part of [Unity Test Tools](https://www.assetstore.unity3d.com/en/#!/content/13802) (Unity Asset Store). Unit test results are reported within Unity and will not be surfaced within Visual Studio.|  
|[Use UI Automation To Test Your Code](../test/use-ui-automation-to-test-your-code.md)|No|Coded UI tests rely on readable controls in the app’s UI; Unity apps are graphical in nature and so content isn’t readable by the Coded UI test tools.|  
  
## Improve code quality  
 Reference link: **[Improve Code Quality](https://msdn.microsoft.com/library/73baa961-c21f-43fe-bb92-3f59ae9b5945)**  
  
|Feature|Supported with Unity|Additional Comments|  
|-------------|--------------------------|-------------------------|  
|[Analyzing Managed Code Quality](../code-quality/analyzing-managed-code-quality-by-using-code-analysis.md)|Yes|Can analyze the C# script code within Visual Studio.|  
|[Finding Duplicate Code by using Code Clone Detection](https://msdn.microsoft.com/library/a97cd5a6-5ffa-4104-9627-8e59e513654d)|Yes|Can analyze the C# script code within Visual Studio.|  
|[Measuring Complexity and Maintainability of Managed Code](../code-quality/measuring-complexity-and-maintainability-of-managed-code.md)|Yes|Can analyze the C# script code within Visual Studio.|  
|[Performance Explorer](../profiling/performance-explorer.md)|No|Use the [Unity Profiler](https://docs.unity3d.com/Manual/Profiler.html) (Unity website).|  
|[Analyze .NET Framework memory issues](../misc/analyze-dotnet-framework-memory-issues.md)|No|Visual Studio tools do not have hooks into the Mono framework (as used by Unity) for profiling. Use the [Unity Profiler](https://docs.unity3d.com/Manual/Profiler.html) (Unity documentation).|  
  
## Release management  
 Reference link: **[Automate deployments with Release Management](https://msdn.microsoft.com/library/vs/alm/release/overview)**  
  
|Feature|Supported with Unity|Additional Comments|  
|-------------|--------------------------|-------------------------|  
|Manage release processes|Yes||  
|Deployment to servers for side-loading via scripts|Yes||  
|Upload to app store|Partial|Extensions are available that can automate this process for some app stores.  See [Extensions for Visual Studio Team Services](https://marketplace.visualstudio.com/VSTS); for example, the [extension for Google Play](https://marketplace.visualstudio.com/items?itemName=ms-vsclient.google-play).|  
  
## Monitor with HockeyApp  
 Reference link: **[Monitor with HockeyApp](https://www.hockeyapp.net/features/)**  
  
|Feature|Supported with Unity|Additional Comments|  
|-------------|--------------------------|-------------------------|  
|Crash analytics, telemetry, and beta distribution|Yes|HockeyApp is primarily useful for handling beta distribution and obtaining crash reports.<br /><br /> For telemetry from C# scripts, it is possible to use any analytics framework provided that it runs on the version of .NET that is used by Unity. However, this allows for analytics only within game scripts and not more deeply inside the Unity engine. At present there is no plugin for Application Insights, but plugins are available for other analytics solutions such as [Unity Analytics](https://www.assetstore.unity3d.com/en/#!/content/28120) and [Google Analytics](https://github.com/googleanalytics/google-analytics-plugin-for-unity). Services like Unity Analytics that understand the nature of a Unity project will, of course, provide much more meaningful analysis than generic frameworks.|
