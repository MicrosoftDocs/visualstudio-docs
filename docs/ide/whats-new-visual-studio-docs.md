---
title: "What's new in Visual Studio docs"
description: "What's new in the Visual Studio docs"
ms.date: 01/05/2023
helpviewer_keywords:
  - "Visual Studio, what's new, docs"
  - "what's new [Visual Studio]"
ms.assetid: 89844796-621B-4EF5-9D76-197084B011CB
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.prod: visual-studio-windows
ms.topic: conceptual
ms.workload:
  - "multiple"
---
# What's new in Visual Studio docs

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Welcome to what's new in Visual Studio docs. The following sections provide details on the previous three months of new and updated content.

## December 2022

### Containers

**New articles**

- [Deploy an app into a container in Azure (Preview)](../containers/deploy-containerized.md)

### Debugger

**New articles**

- [Remote Debug ASP.NET Core on Azure App Service](../debugger/remote-debugging-azure-app-service.md)

**Updated articles**

- Refactor properties reference docs for Spy++:
  - [Messages View](../debugger/messages-view.md)
  - [Processes View](../debugger/processes-view.md)
  - [Threads View](../debugger/threads-view.md)
  - [Windows View](../debugger/windows-view.md)
- [Error: Unable to Start Debugging on the Web Server](../debugger/error-unable-to-start-debugging-on-the-web-server.md) - Update remote debugger errors for WebPI deprecation
- [Find memory leaks with the CRT library](../debugger/finding-memory-leaks-using-the-crt-library.md) - Add example showing memory leak for malloc

### Deployment

**New articles**

- [Tutorial: Deploy an ASP.NET Core app and Database to Azure Container Apps using GitHub Actions](../deployment/end-to-end-deployment-entity-framework-core-github-actions.md)

### Get started

**Updated articles**

- [Tutorial: Extend C# console app and debug in Visual Studio (part 2 of 2)](../get-started/csharp/tutorial-console-part-2.md) - Review and refresh tutorial

### IDE

**Updated articles**

- Update text, links, and screenshots:
  - [Use the Task List](../ide/using-the-task-list.md)
  - [Code snippets](../ide/code-snippets.md)
  - [Environment settings for Visual Studio](../ide/environment-settings.md)
  - [Identify and customize keyboard shortcuts in Visual Studio](../ide/identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md)
- [Visual Studio Developer Command Prompt and Developer PowerShell](../ide/reference/command-prompt-powershell.md) - Update version location for VsDevCmd.bat
- [Accessibility tips and tricks for Visual Studio](../ide/reference/accessibility-tips-and-tricks.md) - Add git shortcuts

### Profiling

**Updated articles**

- Update to match the current user interface:
  - [Measure application performance by analyzing CPU usage (C#, Visual Basic, C++, F#)](../profiling/beginners-guide-to-performance-profiling.md)
  - [Analyze CPU usage without debugging in the Performance Profiler (C#, Visual Basic, C++, F#)](../profiling/cpu-usage.md)
- Fix links:
  - [How to: Instrument a stand-alone .NET Framework component and collect timing data with the profiler from the command line](../profiling/instrument-dotnet-framework-component-and-collect-timing-data.md)
  - [How to: Instrument a native stand-alone component and collect timing data with the profiler from the command line](../profiling/instrument-native-component-and-collect-timing-data.md)
  - [VSPerfCmd](../profiling/vsperfcmd.md)

### Python

**Updated articles**

- [Step 4: Use the full Django Web Project template](../python/learn-django-in-visual-studio-step-04-full-django-project-template.md) - Add Python updates

### Test

**Updated articles**

- [Use the MSTest framework in unit tests](../test/using-microsoft-visualstudio-testtools-unittesting-members-in-unit-tests.md) - Add DataRowAttribute documentation
- [Remote Testing (experimental preview)](../test/remote-testing.md) - Improve code formatting

### Community contributors

The following people contributed to Visual Studio content in November. Thank you! To learn more about how you can help too, see the [Microsoft Docs contributor guide](/contribute/).

- [simon6502](https://github.com/simon6502) (2)
- [sid2934](https://github.com/sid2934) - Austin (1)
- [spottedmahn](https://github.com/spottedmahn) - Michael DePouw (1)

## November 2022

### Azure

**Updated articles**

- [Browse and manage storage resources by using Server Explorer](../azure/vs-azure-tools-storage-resources-server-explorer-browse-manage.md) - Add note for Visual Studio 2022 Cloud Explorer deprecation

### Deployment

**New articles**

- [Access ClickOnce deployment properties for .NET on Windows](../deployment/access-clickonce-deployment-properties-dotnet.md)

### Get started

**Updated articles**

- [Tutorial: Create a simple WPF application with C\#](../get-started/csharp/tutorial-wpf.md) - Integrate 'What Is WPF' article info into tutorial

### IDE

**Updated articles**

- [User permissions and Visual Studio](../ide/user-permissions-and-visual-studio.md) - Update links and add Windows 11 info
- [How to: Locate and organize project and item templates](../ide/how-to-locate-and-organize-project-and-item-templates.md) - Add SDK template info
- [How to: Distribute code snippets](../ide/how-to-distribute-code-snippets.md) - Add snippet
- [Accessibility tips and tricks for Visual Studio](../ide/reference/accessibility-tips-and-tricks.md) - Add new 'Audio Cues in Visual Studio' info
- [Options dialog box: Text Editor \> General](../ide/reference/options-text-editor-general.md) - Update to include Enable Audio Cues and other new options
- [Options, Text Editor, C#, Advanced](../ide/reference/options-text-editor-csharp-advanced.md) - Add description for the "Don't put ref or out on custom struct" C# option
- [Developer Community data privacy](../ide/developer-community-privacy.md) - Update instructions

### Install

**New articles**

- [Administrative Templates (ADMX)](../install/administrative-templates.md)
- [Visual Studio out-of-support components](../install/out-of-support-components.md)

**Updated articles**

- For 17.4 GA - Update info for removeOos, ADMX, and Arm for layouts; remove svc baseline page and add more command-line parameters:
  - [Applying administrator updates that use Microsoft Endpoint Manager (SCCM or Intune)](../install/applying-administrator-updates.md)
  - [Enabling administrator updates to Visual Studio with Microsoft Endpoint Configuration Manager](../install/enabling-administrator-updates.md)
  - [Configure policies for enterprise deployments of Visual Studio](../install/set-defaults-for-enterprise-deployments.md)
  - [Update Visual Studio](../install/update-visual-studio.md)
  - [Repair Visual Studio](../install/repair-visual-studio.md)
  - [Visual Studio on Arm-powered devices](../install/visual-studio-on-arm-devices.md)
  - [Create, maintain, and deploy a network installation of Visual Studio](../install/create-a-network-installation-of-visual-studio.md)
  - [Troubleshoot Visual Studio installation and upgrade issues](../install/troubleshooting-installation-issues.md)
  - [Visual Studio administrator guide](../install/visual-studio-administrator-guide.md)
  - [Use command-line parameters to install, update, and manage Visual Studio](../install/use-command-line-parameters-to-install-visual-studio.md)
  - [Command-line parameter examples for Visual Studio installation](../install/command-line-parameter-examples.md)

### JavaScript

**Updated articles**

- Update publish code for ASP.NET Core Angular and React:
  - [Tutorial: Create an ASP.NET Core app with Angular in Visual Studio](../javascript/tutorial-asp-net-core-with-angular.md)
  - [Tutorial: Create an ASP.NET Core app with React in Visual Studio](../javascript/tutorial-asp-net-core-with-react.md)

### MSBuild

**Updated articles**

- [MSBuild conditions](../msbuild/msbuild-conditions.md) - Explain evaluation of syntax for properties, item lists, and metadata in MSBuild condition expressions
- [Csc task](../msbuild/csc-task.md) - Add undocumented parameters
- [How to: View, save, and configure build log files](../ide/how-to-view-save-and-configure-build-log-files.md) - Add compiler command-line info

### Profiling

**New articles**

- [Collect detailed timing data for a stand-alone application by using the profiler command line](../profiling/collecting-detailed-timing-data-for-a-stand-alone-application.md)
- [How to: Instrument a stand-alone .NET Framework component and collect timing data with the profiler from the command line](../profiling/instrument-dotnet-framework-component-and-collect-timing-data.md)
- [How to: Instrument a native stand-alone component and collect timing data with the profiler from the command line](../profiling/instrument-native-component-and-collect-timing-data.md)
- [Instrumentation in Visual Studio (C#, Visual Basic, C++, F#)](../profiling/instrumentation-overview.md)
- [Instrument your .NET applications in Visual Studio (C#, Visual Basic, F#)](../profiling/instrumentation.md)
- [VSInstr](../profiling/vsinstr.md)
- [VSPerfCmd](../profiling/vsperfcmd.md)
- [Troubleshoot profiling errors and fix issues](../profiling/troubleshoot-profiler-errors.md)

**Updated articles**

- [First look at profiling tools (C#, Visual Basic, C++, F#)](../profiling/profiling-feature-tour.md):
  - Update profiling fundamentals
  - Update command-line profiling

### SharePoint

**Updated articles**

- [Troubleshoot SharePoint solutions](../sharepoint/troubleshooting-sharepoint-solutions.md) - Add App Pool error

### Version control

**New articles**

- [Work with multiple repos](../version-control/git-multi-repository-support.md)

## October 2022

### Data tools

**Updated articles**

- Update for Visual Studio 2022:
  - [How to: Save and edit connection strings](../data-tools/how-to-save-and-edit-connection-strings.md)
  - [How to: Create and configure datasets in Visual Studio](../data-tools/create-and-configure-datasets-in-visual-studio.md)

### Designers

**Updated articles**

- [Disable DPI-awareness to fix HDPI / scaling issues with Windows Forms Designer in Visual Studio](../designers/disable-dpi-awareness.md) - Remove the Registry Entry section

### Extensibility

**Updated articles**

- [Create an options page](../extensibility/creating-an-options-page.md) - Add step to open custom options page

### IDE

**Updated articles**

- [Project migration and upgrade reference for Visual Studio](../porting/port-migrate-and-upgrade-visual-studio-projects.md) - Refresh text and links
- [Use regular expressions in Visual Studio](../ide/using-regular-expressions-in-visual-studio.md) - Refresh text, links, and screenshots

### JavaScript

**Updated articles**

- [Tutorial: Create an ASP.NET Core app with Vue in Visual Studio](../javascript/tutorial-asp-net-core-with-vue.md) - Update publishing steps for article on ASP.NET Core and Vue.js

### MSBuild

**New articles**

- [Find and use a version of MSBuild](../msbuild/find-and-use-msbuild-versions.md)
- [MSBuild Server](../msbuild/msbuild-server.md)

**Updated articles**

- [MSBuild](../msbuild/msbuild.md) - Review and update text and screenshots
- [Walkthrough: Use MSBuild](../msbuild/walkthrough-using-msbuild.md) - Review and update text and screenshots
- [MSBuild reserved and well-known properties](../msbuild/msbuild-reserved-and-well-known-properties.md) - Add undocumented MSBuild properties

### Profiling

**New articles**

- [Identify hot paths with a visualized call tree](../profiling/flame-graph.md)

### Test

**Updated articles**

- [Use the MSTest framework in unit tests](../test/using-microsoft-visualstudio-testtools-unittesting-members-in-unit-tests.md) - Refresh and complete MSTest documentation
- [How to: Create a data-driven unit test](../test/how-to-create-a-data-driven-unit-test.md) - Update doc for MSTest data-driven tests