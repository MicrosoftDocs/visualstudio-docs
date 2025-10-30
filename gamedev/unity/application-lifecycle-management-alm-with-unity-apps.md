---
title: "Application Lifecycle Management (ALM) with Unity Apps"
description: Understand application lifecycle management (ALM) with Unity Apps. Review Agile tools, model, code, build, test, and improve code quality.
ms.date: 08/21/2018
ms.subservice: unity-tools
ms.service: visual-studio
ms.topic: article
author: "conceptdev"
ms.author: "crdun"
manager: crdun
---
# DevOps with Unity apps

Developing apps for modern platforms involves many more activities than just writing code. These activities, referred to as DevOps (development + operations), span the app's complete life cycle and include planning and tracking work, designing and implementing code, managing a source code repository, running builds, managing continuous integrations and deployments, testing (including unit tests and UI tests), running various forms of diagnostics in both development and production environments, and monitoring app performance and user behaviors in real time through telemetry and analytics.

Visual Studio, together with Azure DevOps Services and Team Foundation Server, provides a variety of DevOps capabilities. Many of these are applicable to cross-platform projects, including games and immersive graphical apps created with Unity&mdash;especially when using C# as a scripting language. However, because Unity has its own development environment and runtime engine, a number of DevOps features don't apply as they would to other kinds of projects built in Visual Studio.

The following tables identify how DevOps features in Visual Studio apply or don't apply when working with Unity. Refer to the linked documentation for details on the features themselves.

## Agile tools

Reference link: [About Agile tools and Agile project management](/azure/devops/boards/backlogs/backlogs-overview?view=vsts&preserve-view=true) (using Azure Boards or TFS, including Team Explorer Everywhere)

General Comment: all planning and tracking features are independent of project type and coding languages.

|Feature|Supported with Unity|Additional Comments|
|-------------|--------------------------|-------------------------|
|Manage backlogs and sprints|Yes||
|Work tracking|Yes||
|Team room collaboration|Yes||
|Kanban boards|Yes||
|Report and visualize progress|Yes||

## Modeling

Reference link: **[Analyze and model architecture](/visualstudio/modeling/analyze-and-model-your-architecture)**

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
|[Use Team Foundation Version Control (TFVC)](/azure/devops/repos/tfvc/overview?view=vsts&preserve-view=true) or Azure Repos|Yes|Unity projects are simply a collection of files that can be placed into version control systems like any other project, but there are a few special considerations described after this table.|
|[Getting started with Git in Azure Repos](/azure/devops/repos/git/gitquickstart?view=vsts&preserve-view=true&tabs=visual-studio)|Yes|See notes after the table.|
|[Improve Code Quality](/visualstudio/test/improve-code-quality)|Yes||
|[Find code changes and other history](/visualstudio/ide/find-code-changes-and-other-history-with-codelens)|Yes||
|[Use code maps to debug your applications](/visualstudio/modeling/use-code-maps-to-debug-your-applications)|Yes||

Special considerations for version control with Unity:

1. Unity tracks metadata about game assets in a single, opaque library that is hidden by default. To keep files and metadata in sync, it is necessary to make the metadata visible and to store it in more-manageable chunks. For details, refer to [Using External Version Control Systems with Unity](https://docs.unity3d.com/2020.1/Documentation/Manual/ExternalVersionControlSystemSupport.html) (Unity documentation).

2. Not all files and folders in a Unity project are appropriate for source control, as is also described in the link above. The Assets and ProjectSettings folders should be added, but the Library and Temp folders should not. For an additional list of generated files that would not go into source control, see the discussion [How to use Git for Unity3D source control?](https://stackoverflow.com/questions/18225126/how-to-use-git-for-unity3d-source-control) on Stack Overflow. Many developers have also blogged on this subject independently.

3. Binary assets in a Unity project—such as textures or audio files—can take up a large amount of storage. Various source control systems like Git store a unique copy of a file for every change that is made, even if the change affects only a small portion of the file. This can cause the Git repository to become bloated. To address this, Unity developers often elect to add only final assets to their repository, and use a different means of keeping a working history of their assets, such as OneDrive, DropBox, or git-annex. This approach works because such assets typically don't need to be versioned along with source code changes. Developers also typically set the project editor's Asset Serialization Mode to Force Text to store scene files in text rather than binary format, which allows for merges in source control. For details, see [Editor Settings](https://docs.unity3d.com/Manual/class-EditorManager.html) (Unity documentation).

## Build

Reference link: **[Azure Pipelines](/azure/devops/pipelines/index?view=vsts&preserve-view=true)**

|Feature|Supported with Unity|Additional Comments|
|-------------|--------------------------|-------------------------|
|On-premises Team Foundation Server (TFS)|Possible|Unity projects are built through the Unity environment and not through the Visual Studio build system (building within the Visual Studio Tools for Unity will compile the scripts but not produce an executable). It is possible to [build Unity projects from the command line](https://docs.unity3d.com/Manual/CommandLineArguments.html) (Unity documentation), so it possible to configure an MSBuild process on a TFS server to execute the appropriate Unity commands, provided that Unity itself is installed on that computer.<br /><br /> Unity also offers [Unity Cloud Build](https://build.cloud.unity3d.com/landing/), which monitors a Git or SVN repository and runs periodic builds. At present it does not work with TFVC or Azure DevOps Services.|
|On-premises build server linked to Azure DevOps Services|Possible|Given the same conditions as above, it is further possible to direct builds triggered through Azure DevOps Services to use an on-premises TFS computer. See [Build and release agents](/azure/devops/pipelines/agents/agents?view=vsts&preserve-view=true) for instructions.|
|Hosted controller service of Azure DevOps Services|No|Unity builds are not presently supported.|
|Build definitions with pre- and post-scripts|Yes|A custom build definition that uses the Unity command line to run a build can also be configured for pre- and post-build scripts.|
|Continuous integration including gated check-ins|Yes|Gated check-ins for TFVC only as Git works on a pull-request model rather than check-ins.|

## Test

|Feature|Supported with Unity|Additional Comments|
|-------------|--------------------------|-------------------------|
|Planning tests, creating test cases and organizing test suites|Yes||
|Manual testing|Yes||
|Test Manager (record and playback tests)|Windows devices and Android emulators only||
|Code coverage|n/a|Not applicable as unit testing happens within Unity and not Visual Studio, see below.|
|[Unit test your code](/visualstudio/test/unit-test-your-code)|Within Unity, but not Visual Studio|Unity provides its own unit test framework as part of [Unity test tools](https://assetstore.unity.com/packages/tools/utilities/unity-test-tools-13802) (Unity Asset Store). Unit test results are reported within Unity and will not be surfaced within Visual Studio.|
|[Use UI automation to test your code](/visualstudio/test/use-ui-automation-to-test-your-code)|No|Coded UI tests rely on readable controls in the app's UI; Unity apps are graphical in nature and so content isn't readable by the Coded UI test tools.|

## Improve code quality

Reference link: **[Improve code quality](/visualstudio/test/improve-code-quality)**

|Feature|Supported with Unity|Additional Comments|
|-------------|--------------------------|-------------------------|
|[Analyze managed code quality](/visualstudio/code-quality/code-analysis-for-managed-code-overview)|Yes|Can analyze the C# script code within Visual Studio.|
|[Find duplicate code by using code clone detection](https://msdn.microsoft.com/library/hh205279.aspx)|Yes|Can analyze the C# script code within Visual Studio.|
|[Measure complexity and maintainability of managed code](/visualstudio/code-quality/code-metrics-values)|Yes|Can analyze the C# script code within Visual Studio.|
|[Performance tools](/visualstudio/profiling/performance-explorer)|No|Use the [Unity Profiler](https://docs.unity3d.com/Manual/Profiler.html) (Unity website).|
|Analyze .NET Framework memory issues|No|Visual Studio tools do not have hooks into the Mono framework (as used by Unity) for profiling. Use the [Unity Profiler](http://docs.unity3d.com/Manual/Profiler.html) (Unity documentation).|

## Release management

Reference link: [Build and release in Azure Pipelines and TFS](/azure/devops/pipelines/overview?view=vsts&preserve-view=true)

|Feature|Supported with Unity|Additional Comments|
|-------------|--------------------------|-------------------------|
|Manage release processes|Yes||
|Deployment to servers for side-loading via scripts|Yes||
|Upload to app store|Partial|Extensions are available that can automate this process for some app stores. See [Extensions for Azure DevOps Services](https://marketplace.visualstudio.com/VSTS); for example, the [extension for Google Play](https://marketplace.visualstudio.com/items?itemName=ms-vsclient.google-play).|

## Monitor with HockeyApp

Reference link: **[Monitor with HockeyApp](https://marketplace.visualstudio.com/items?itemName=ms.hockeyapp)**

|Feature|Supported with Unity|Additional Comments|
|-------------|--------------------------|-------------------------|
|Crash analytics, telemetry, and beta distribution|Yes|HockeyApp is primarily useful for handling beta distribution and obtaining crash reports.<br /><br /> For telemetry from C# scripts, it is possible to use any analytics framework provided that it runs on the version of .NET that is used by Unity. However, this allows for analytics only within game scripts and not more deeply inside the Unity engine. At present there is no plugin for Application Insights, but plugins are available for other analytics solutions such as [Unity Analytics](https://assetstore.unity.com/packages/add-ons/services/analytics/unity-analytics-28120) and [Google Analytics](https://github.com/googleanalytics/google-analytics-plugin-for-unity). Services like Unity Analytics that understand the nature of a Unity project will, of course, provide much more meaningful analysis than generic frameworks.|
