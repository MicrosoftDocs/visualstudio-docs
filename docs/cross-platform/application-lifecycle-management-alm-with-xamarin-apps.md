---
title: "Application Lifecycle Management (ALM) with Xamarin apps | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "tgt-pltfrm-cross-plat"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: ff978cc2-5a25-46d6-921b-e51adaa65992
caps.latest.revision: 14
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Application Lifecycle Management (ALM) with Xamarin apps
Xamarin enables you to build cross-platform mobile apps targeting Android, iOS, and Windows using C#, .NET, and Visual Studio. Xamarin allows a large portion of code to be shared between platforms, with only a small percentage needing to be platform-specific. For more information on Xamarin itself, see [Visual Studio and Xamarin](../cross-platform/visual-studio-and-xamarin.md).  
  
 Developing apps for modern platforms involves many more activities than just writing code. These activities, referred to as DevOps (development + operations), span the app’s complete lifecycle and include planning and tracking work, designing and implementing code, managing a source code repository, running builds, managing continuous integrations and deployments, testing (including unit tests and UI tests), running various forms of diagnostics in both development and production environments, and monitoring app performance and user behaviors in real time through telemetry and analytics.  
  
 Visual Studio together with Visual Studio Team Services and Team Foundation Server provide a variety of DevOps capabilities, also referred to as Application Lifecycle Management or ALM. Many of these are wholly applicable to cross-platform projects.  
  
 This is especially true with Xamarin apps because they are built with C# and .NET, around which some ALM tools are built. Other tools, require tight integration with build and runtime environments. Because Xamarin apps run on non-Windows platforms and use the Mono implementation of .NET, Xamarin provides specialized tools for certain needs.  
  
 The tables below identifies which Visual Studio ALM features you can expect to work well with a Xamarin project, and which ones have limitations. Refer to the linked documentation for details on the features themselves.  
  
## Agile tools  
 Reference link: **[Work](../Topic/Track%20work%20using%20VSTS%20or%20TFS.md)** (using Visual Studio Team Services or TFS, including Team Explorer Everywhere)  
  
 General Comment: all planning and tracking features are independent of project type and coding languages.  
  
|Feature|Supported with Xamarin|Additional Comments|  
|-------------|----------------------------|-------------------------|  
|Manage backlogs and sprints|Yes||  
|Work tracking|Yes||  
|Team room collaboration|Yes||  
|Kanban boards|Yes||  
|Report and visualize progress|Yes||  
  
## Modeling  
 Reference link: **[Analyzing and Modeling Architecture](../modeling/analyze-and-model-your-architecture.md)**  
  
 Design features are independent of coding language, or work with .NET languages like C#. See [Roles of Architecture and Modeling Diagrams in Software Development](../modeling/scenario-change-your-design-using-visualization-and-modeling.md#ModelingDiagramsTools) for what aspects are related to code.  
  
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
|[Use Team Foundation Version Control](../Topic/Use%20Team%20Foundation%20Version%20Control.md) or Visual Studio Team Services|Yes||  
|[Getting started with Git in Team Services](../Topic/Use%20Visual%20Studio%20with%20Git.md)|Yes||  
|[Code analysis/Improve code quality (references, suggested changes, etc.)](../Topic/Improve%20Code%20Quality.md)|Yes||  
|[Find code changes and other history](../ide/find-code-changes-and-other-history-with-codelens.md)|Yes|Except across platform-specific boundaries where the implementation isn’t resolved until run time.|  
|[Use code maps to debug your applications](../modeling/use-code-maps-to-debug-your-applications.md)|Yes||  
  
## Build  
 Reference link: **[Build](../Topic/Build%20the%20application.md)**  
  
|Feature|Supported with Xamarin|Additional Comments|  
|-------------|----------------------------|-------------------------|  
|On-premises TFS server|Yes|Build machines must have Xamarin installed and can be linked to an OSX computer to build for iOS. See [Configuring TFS for Xamarin](http://developer.xamarin.com/guides/cross-platform/ci/configuring_tfs/) (Xamarin website)|  
|On-premises build server linked to Visual Studio Team Services|Yes|See [Build server](../Topic/Deploy%20and%20configure%20a%20build%20server.md) for instructions.|  
|Hosted controller service of Visual Studio Team Services|Yes|See [Build your Xamarin app](https://www.visualstudio.com/en-us/docs/build/apps/mobile/xamarin).|  
|Build definitions with pre- and post-scripts|Yes||  
|Continuous integration including gated check-ins|Yes|Gated check-ins for TFVC only as Git works on a pull-request model rather than check-ins.|  
  
## Testing  
 Reference link: **[Testing the application](/devops-test-docs/test/test-apps-early-and-often)**  
  
|Feature|Supported with Xamarin|Additional Comments|  
|-------------|----------------------------|-------------------------|  
|Planning tests, creating test cases and organizing test suites|Yes||  
|Manual testing|Yes||  
|Test Manager (record and playback tests)|Yes|Windows devices and Android emulators only from Visual Studio. Recording for all devices is possible with [Xamarin Test Recorder](https://www.xamarin.com/test-cloud/recorder).|  
|Code coverage|n/a||  
|[Unit Test Your Code](../test/unit-test-your-code.md)|Yes|For Windows and Android targets, the built-in MSTest tools can be used. To run unit tests on Windows, Android, and iOS, Xamarin recommends NUnit. See [Configuring TFS for Xamarin](http://developer.xamarin.com/guides/cross-platform/ci/configuring_tfs/) (Xamarin website).|  
|[Use UI Automation To Test Your Code](../test/use-ui-automation-to-test-your-code.md)|Windows only|Visual Studio's UI test recorder is Windows only. For all platforms, see [Xamarin Test Recorder](https://www.xamarin.com/test-cloud/recorder).|  
  
## Improve code quality  
 Reference link: **[Improve Code Quality](../Topic/Improve%20Code%20Quality.md)**  
  
|Feature|Supported with Xamarin|Additional Comments|  
|-------------|----------------------------|-------------------------|  
|[Analyzing Managed Code Quality](../code-quality/analyzing-managed-code-quality-by-using-code-analysis.md)|Yes||  
|[Finding Duplicate Code by using Code Clone Detection](../Topic/Finding%20Duplicate%20Code%20by%20using%20Code%20Clone%20Detection.md)|Yes||  
|[Measuring Complexity and Maintainability of Managed Code](../code-quality/measuring-complexity-and-maintainability-of-managed-code.md)|Yes||  
|[Performance Explorer](../profiling/performance-explorer.md)|No|Use the [Xamarin Profiler](http://developer.xamarin.com/guides/cross-platform/deployment,_testing,_and_metrics/) through Xamarin Studio instead. Note that the Xamarin Profiler is currently in preview and does not yet work for Windows targets.|  
|[Analyze .NET Framework memory issues](../misc/analyze-dotnet-framework-memory-issues.md)|No|Visual Studio tools do not have hooks into the Mono framework for profiling.|  
  
## Release management  
 Reference link: **[Automate deployments with Release Management](https://msdn.microsoft.com/library/vs/alm/release/overview)**  
  
|Feature|Supported with Xamarin|Additional Comments|  
|-------------|----------------------------|-------------------------|  
|Manage release processes|Yes||  
|Deployment to servers for side-loading via scripts|Yes||  
|Upload to app store|Partial|Extensions are available that can automate this process for some app stores.  See [Extensions for Visual Studio Team Services](https://marketplace.visualstudio.com/VSTS); for example, the [extension for Google Play](https://marketplace.visualstudio.com/items?itemName=ms-vsclient.google-play).|  
  
## Monitor with HockeyApp  
 Reference link: **[Monitor with HockeyApp](https://www.hockeyapp.net/features/)**  
  
|Feature|Supported with Xamarin|Additional Comments|  
|-------------|----------------------------|-------------------------|  
|Crash analytics, telemetry, and beta distribution|Yes||