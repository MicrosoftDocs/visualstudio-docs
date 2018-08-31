---
title: "Application Lifecycle Management (ALM) with Xamarin apps | Microsoft Docs"
ms.date: 08/21/2018
ms.technology: vs-ide-mobile
ms.topic: "conceptual"
ms.assetid: ff978cc2-5a25-46d6-921b-e51adaa65992
author: conceptdev
ms.author: crdun
manager: crdun
ms.workload:
  - "xamarin"
---
# DevOps with Xamarin apps

Xamarin enables you to build cross-platform mobile apps targeting Android, iOS, and Windows using C#, .NET, and Visual Studio. Xamarin allows a large portion of code to be shared between platforms, with only a small percentage needing to be platform-specific. For more information on Xamarin itself, see [Visual Studio and Xamarin](../cross-platform/visual-studio-and-xamarin.md).

Developing apps for modern platforms involves many more activities than just writing code. These activities, referred to as DevOps (development + operations), span the app's complete life cycle and include planning and tracking work, designing and implementing code, managing a source code repository, running builds, managing continuous integrations and deployments, testing (including unit tests and UI tests), running various forms of diagnostics in both development and production environments, and monitoring app performance and user behaviors in real time through telemetry and analytics.

Visual Studio, together with Azure DevOps Services and Team Foundation Server, provides a variety of DevOps capabilities. Many of these are wholly applicable to cross-platform projects. This is especially true with Xamarin apps, because they're built with C# and .NET, around which some DevOps tools are built. Other tools require tight integration with build and runtime environments. Because Xamarin apps run on non-Windows platforms and use the Mono implementation of .NET, Xamarin provides specialized tools for certain needs.

The following tables identify which DevOps features in Visual Studio you can expect to work well with a Xamarin project, and which ones have limitations. Refer to the linked documentation for details on the features themselves.

## Agile tools

Reference link: **[About Agile tools and Agile project management](/azure/devops/boards/backlogs/overview?view=vsts)**

General Comment: all planning and tracking features are independent of project type and coding languages.

|Feature|Supported with Xamarin|Additional Comments|
|-------------|----------------------------|-------------------------|
|Manage backlogs and sprints|Yes||
|Work tracking|Yes||
|Team room collaboration|Yes||
|Kanban boards|Yes||
|Report and visualize progress|Yes||

## Modeling

Reference link: **[Analyze and model architecture](../modeling/analyze-and-model-your-architecture.md)**

Design features are independent of coding language, or work with .NET languages like C#. See [Roles of architecture and modeling diagrams in software development](../modeling/scenario-change-your-design-using-visualization-and-modeling.md#ModelingDiagramsTools) for what aspects are related to code.

|Feature|Supported with Xamarin|Additional Comments|
|-------------|----------------------------|-------------------------|
|Sequence diagrams|Yes||
|Dependency graphs|Yes||
|Call hierarchy|Yes||
|Class designer|Yes||
|Architecture explorer|Yes||
|UML diagrams (use case, activity, class, component, sequence, and DSL)|Yes||
|Layer diagrams|Yes||
|Layer validation|Yes||

## Code

|Feature|Supported with Xamarin|Additional Comments|
|-------------|----------------------------|-------------------------|
|[Use Team Foundation Version Control (TFVC)](/vsts/tfvc/overview?view=vsts) or Azure Repos|Yes||
|[Getting started with Git in Azure Repos](/vsts/git/gitquickstart?view=vsts&tabs=visual-studio)|Yes||
|[Improve Code Quality](../test/improve-code-quality.md)|Yes||
|[Find code changes and other history](../ide/find-code-changes-and-other-history-with-codelens.md)|Yes|Except across platform-specific boundaries where the implementation isn't resolved until run time.|
|[Use code maps to debug your applications](../modeling/use-code-maps-to-debug-your-applications.md)|Yes||

## Build

Reference link: **[Build and release](/vsts/pipelines/index?view=vsts)**

|Feature|Supported with Xamarin|Additional Comments|
|-------------|----------------------------|-------------------------|
|On-premises TFS server|Yes|Build machines must have Xamarin installed and can be linked to an OSX computer to build for iOS. See [Use TFVC](/vsts/tfvc/overview?view=vsts)|
|On-premises build server linked to Azure Pipelines|Yes|See [Build and release agents](/vsts/pipelines/agents/agents?view=vsts) for instructions.|
|Hosted controller service of Azure Pipelines|Yes|See [Build your Xamarin app](/vsts/pipelines/apps/mobile/xamarin?view=vsts&tabs=vsts).|
|Build definitions with pre- and post-scripts|Yes||
|Continuous integration including gated check-ins|Yes|Gated check-ins for TFVC only as Git works on a pull-request model rather than check-ins.|

## Test

|Feature|Supported with Xamarin|Additional Comments|
|-------------|----------------------------|-------------------------|
|Planning tests, creating test cases and organizing test suites|Yes||
|Manual testing|Yes||
|Test Manager (record and playback tests)|Yes|Windows devices and Android emulators only from Visual Studio. Recording for all devices is possible with [Xamarin Test Recorder](/appcenter/test-cloud/uitest/).|
|Code coverage|n/a||
|[Unit test your code](../test/unit-test-your-code.md)|Yes|For Windows and Android targets, the built-in MSTest tools can be used. To run unit tests on Windows, Android, and iOS, Xamarin recommends NUnit. See [Use TFVC](/vsts/tfvc/overview?view=vsts).|
|[Use UI automation to test your code](../test/use-ui-automation-to-test-your-code.md)|Windows only|Visual Studio's UI test recorder is Windows only. For all platforms, see [Xamarin.UITest](/appcenter/test-cloud/uitest/).|

## Improve code quality

Reference link: **[Improve Code Quality](../test/improve-code-quality.md)**

|Feature|Supported with Xamarin|Additional Comments|
|-------------|----------------------------|-------------------------|
|[Analyze managed code quality](../code-quality/analyzing-managed-code-quality-by-using-code-analysis.md)|Yes||
|[Find duplicate code by using code clone detection](https://msdn.microsoft.com/library/hh205279.aspx)|Yes||
|[Measure complexity and maintainability of managed code](../code-quality/measuring-complexity-and-maintainability-of-managed-code.md)|Yes||
|[Performance Explorer](../profiling/performance-explorer.md)|No|Use the [Xamarin Profiler](/xamarin/cross-platform/deploy-test/) through Xamarin Studio instead. Note that the Xamarin Profiler is currently in preview and does not yet work for Windows targets.|
|[Analyze .NET Framework memory issues](https://msdn.microsoft.com/library/dn342825.aspx)|No|Visual Studio tools do not have hooks into the Mono framework for profiling.|

## Release management

Reference link: **[Build and release in Azure Pipelines and TFS](/vsts/pipelines/overview?view=vsts)**

|Feature|Supported with Xamarin|Additional Comments|
|-------------|----------------------------|-------------------------|
|Manage release processes|Yes||
|Deployment to servers for side-loading via scripts|Yes||
|Upload to app store|Partial|Extensions are available that can automate this process for some app stores.  See [Extensions for Azure DevOps Services](https://marketplace.visualstudio.com/VSTS); for example, the [extension for Google Play](https://marketplace.visualstudio.com/items?itemName=ms-vsclient.google-play).|

## Monitor with HockeyApp

Reference link: **[Monitor with HockeyApp](https://www.hockeyapp.net/features/)**

|Feature|Supported with Xamarin|Additional Comments|
|-------------|----------------------------|-------------------------|
|Crash analytics, telemetry, and beta distribution|Yes||
