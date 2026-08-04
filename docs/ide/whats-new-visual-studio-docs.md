---
title: "What's new in Visual Studio docs"
description: Discover recent changes in the Visual Studio documentation, including updated articles about getting started, the IDE, and deployment.
ms.date: 08/03/2026
helpviewer_keywords:
  - "Visual Studio, what's new, docs"
  - "what's new [Visual Studio]"
author: nitinme
ms.author: nitinme

ms.subservice: general-ide
ms.topic: whats-new
---
# What's new in Visual Studio docs

Welcome to what's new in Visual Studio docs. The following sections provide details on the previous three months of new and updated content.

## July 2026

### Debugger

**New articles**

- [Debug with Copilot Prompts](../debugger/debug-with-copilot-prompts.md) - Add prompt techniques for reproducing, diagnosing, instrumenting, and verifying bugs with Debugger Agent

### IDE

**Updated articles**

- Show and hide symbol nodes beneath files in Solution Explorer
  - [Customize Visual Studio for working with projects and solutions](../ide/projects-and-solutions-options-dialog-box.md)
  - [Learn about Solution Explorer](../ide/use-solution-explorer.md)
- [Configure IntelliSense Options for C and C++](../ide/configure-languages-c-cpp-intellisense.md) - Add EditorConfig controls for C++ include completion and refresh IntelliSense guidance
- Improve custom-agent tool-group reset guidance, workarounds, diagnostics, and contextual links
  - [Use Agent Mode](../ide/copilot-agent-mode.md)
  - [Use custom agents in GitHub Copilot](../ide/copilot-specialized-agents.md)
  - [Use MCP Servers to Extend GitHub Copilot](../ide/mcp-servers.md)
  - [Troubleshoot GitHub Copilot state](../ide/visual-studio-github-copilot-troubleshoot.md)
- [Developer Community data privacy](../ide/developer-community-privacy.md) - Disclose that MIEngine logs might be collected with a Visual Studio problem report
- [Use Agent Skills with GitHub Copilot](../ide/copilot-agent-skills.md) - Add Insiders-only skill creation, workspace and personal scopes, and specification-based generation
- [Copilot Next Edit Suggestions](../ide/copilot-next-edit-suggestions.md) - Clarify settings paths, nearby and extended-range suggestions, and display controls

### MSBuild

**Updated articles**

- [Obtaining Build Logs with MSBuild](../msbuild/obtaining-build-logs-with-msbuild.md) - Explain binary-log contents and potential performance overhead

### Testing

**Updated articles**

- [Configure unit tests with a .runsettings file](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md) - Add command-line run-setting overrides
- [VSTest.Console.exe command-line options](../test/vstest-console-options.md) - Modernize options, diagnostics, exit codes, filtering, and environment guidance

### Community contributors

The following people contributed to the Visual Studio docs during this period. Thank you! Learn how to contribute by following the links under "Get involved" in the [what's new landing page](index.yml).

- [LLLichlet](https://github.com/LLLichlet) - LLLichlet ![1 pull requests.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)
- [raadisi](https://github.com/raadisi) - raadisi ![1 pull requests.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)

## June 2026

### Debugger

**Updated articles**

- [Supported Code Changes (C# and Visual Basic)](../debugger/supported-code-changes-csharp.md) - Clarify Hot Reload support

### IDE

**Updated articles**

- [Keyboard shortcuts](../ide/default-keyboard-shortcuts-in-visual-studio.md) - Add Git Blame and search updates
- [Visual Studio search](../ide/visual-studio-search.md) - Enhance search documentation
- [Use MCP Servers](../ide/mcp-servers.md) - Clarify MCP server chat setup steps

### Install

**Updated articles**

- [Applying administrator updates](../install/applying-administrator-updates.md) - Clarify .vsconfig install guidance
- [Installing Visual Studio](../install/install-visual-studio.md) - Clarify settings sharing in side-by-side installations

### JavaScript

**Updated articles**

- [Develop JavaScript code without solutions or projects](../javascript/develop-javascript-code-without-solutions-projects.md) - Update project opening guidance.
- [Unit testing JavaScript and TypeScript](../javascript/unit-testing-javascript-with-visual-studio.md) - Updates for TypeScript 7 SDK

### MSBuild

**Updated articles**

- [General MSBuild project properties](../msbuild/common-msbuild-project-properties.md) - Clarify MSB3821 messaging

### Testing

**Updated articles**

- Add color emoji documentation support
  - [Unit testing in Visual Studio](../test/unit-test-your-code.md)

### Community contributors

The following people contributed to the Visual Studio docs during this period. Thank you! Learn how to contribute by following the links under "Get involved" in the [what's new landing page](index.yml).

- [JohanSmarius](https://github.com/JohanSmarius) - JohanSmarius ![1 pull requests.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)

## May 2026

### Code quality

**Updated articles**

- [Install External Analyzers](../code-quality/install-roslyn-analyzers.md) - Review and update screenshots

### Containers

**Updated articles**

- Review and update links and text quality
  - [Add support for containers](../containers/add-container-support.md)
  - [Visual Studio Container Tools on Windows](../containers/overview.md)
  - [Error codes for Visual Studio Container Tools](../containers/container-tools-error-messages.md)
- [Deploy ASP.NET container app to Container Registry](../containers/hosting-web-apps-in-docker.md) - Review and update screenshots

### Data tools

**Updated articles**

- [Add, update, or remove WCF data service reference](../data-tools/how-to-add-update-or-remove-a-wcf-data-service-reference.md) - Review and update screenshots

### Debugger

**Updated articles**

- Add source checksum algorithm details
  - [CV_SourceChksum_t](../debugger/debug-interface-access/cv-sourcechksum-t.md)
- Fix DIA SDK links and references
  - [IDiaDataSource::loadDataFromIStream](../debugger/debug-interface-access/idiadatasource-loaddatafromistream.md)
  - [IDiaDataSourceEx::loadDataFromIStreamEx](../debugger/debug-interface-access/idiadatasourceex-loaddatafromistreamex.md)
- [Tips and Tricks in the Debugger](../debugger/debugger-tips-and-tricks.md) - Review and update screenshots
- [Configure Hot Reload](../debugger/how-to-enable-and-disable-edit-and-continue.md) - Clarify configuration guidance
- [Debug ASP.NET Core in the Visual Studio Debugger](../debugger/quickstart-debug-aspnet.md) - Review and update
- Review and update
  - [Debug C++ Code, Set Breakpoints, Inspect Variables](../debugger/quickstart-debug-with-cplusplus.md)
  - [Debug Managed Code in the Visual Studio Debugger](../debugger/quickstart-debug-with-managed.md)
- Review and update
  - [Start the Spy++ Tool to Debug a Solution](../debugger/how-to-start-spy-increment.md)
  - [Protected mode for dump debugging](../debugger/protected-mode-dump-debugging.md)
  - [Using the IntelliTrace stand-alone collector](../debugger/using-the-intellitrace-stand-alone-collector.md)
  - [Debugging Techniques and Tools](../debugger/write-better-code-with-visual-studio.md)

### Extensibility

**New articles**

- [Visual Studio Theme Color Tokens](../extensibility/ux-guidelines/theme-color-token-reference.md)

**Updated articles**

- Set moniker range for UX color guidance
  - [Color Value Reference](../extensibility/ux-guidelines/color-value-reference-for-visual-studio.md)
  - [Shared Colors for Visual Studio](../extensibility/ux-guidelines/shared-colors-for-visual-studio.md)
- [Create Your First Extension Reference](../extensibility/visualstudio.extensibility/get-started/create-your-first-extension.md) - Review and update screenshots

### Get started

**Updated articles**

- [Tutorial: Create a simple C# console app](../get-started/csharp/tutorial-console.md) - Fix input validation pattern
- [Tutorial: Add Icons to the Matching Game](../get-started/csharp/tutorial-windows-forms-match-game-icons.md) - Review and update screenshots

### IDE

**New articles**

- [Use the GitHub Copilot plan agent](../ide/copilot-plan-agent.md)
- [Razor editor code actions](../ide/reference/razor-editor-code-actions.md)

**Updated articles**

- Add and refine Copilot plan agent and cloud workflow guidance
  - [Use Agent Mode](../ide/copilot-agent-mode.md)
  - [Use custom agents in GitHub Copilot](../ide/copilot-specialized-agents.md)
  - [Get Started with GitHub Copilot](../ide/visual-studio-github-copilot-get-started.md)
- Add Chat History panel and Git context updates
  - [Manage chat context in GitHub Copilot Chat](../ide/copilot-chat-context-references.md)
  - [About GitHub Copilot Chat in Visual Studio](../ide/visual-studio-github-copilot-chat.md)
- Update Copilot billing and plan information
  - [AI-assistance for developers in Visual Studio](../ide/ai-assisted-development-visual-studio.md)
  - [Customize chat responses](../ide/copilot-chat-context.md)
  - [GitHub Copilot Free in Visual Studio](../ide/copilot-free-plan.md)
  - [GitHub Copilot usage and models](../ide/copilot-usage-and-models.md)
  - [Manage GitHub Copilot installation and state](../ide/visual-studio-github-copilot-install-and-states.md)
- Add Razor Quick Actions references
  - [Common Quick Actions](../ide/common-quick-actions.md)
  - [Generate a method](../ide/reference/generate-method.md)
  - [Code cleanup refactorings](../ide/reference/refactoring-code-cleanup.md)
- Add system theme automatic change feature
  - [Configure Visual Experience Options](../ide/configure-visual-experience-options.md)
  - [Change Themes, Fonts, Text, Accessibility Options](../ide/how-to-change-fonts-and-colors-in-visual-studio.md)
  - [Visual Studio Color Themes](../ide/visual-studio-color-themes.md)
- [Use IntelliSense for quick information & completion](../ide/using-intellisense.md) - Clarify IntelliSense and Copilot priority
- [Copilot Completions](../ide/visual-studio-github-copilot-extension.md) - Clarify IntelliSense and Copilot priority
- Update Team Explorer work items deprecation notes
  - [Keyboard shortcuts](../ide/default-keyboard-shortcuts-in-visual-studio.md)
  - [Develop code without projects or solutions](../ide/develop-code-in-visual-studio-without-projects-or-solutions.md)
- Review and update screenshots and make other updates
  - [Explore advanced features for developers](../ide/advanced-feature-overview.md)
  - [Customize and Save Layouts of Windows and Tabs](../ide/customizing-window-layouts-in-visual-studio.md)
  - [Identify and customize keyboard shortcuts](../ide/identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md)
  - [Manage application settings (.NET Framework)](../ide/managing-application-settings-dotnet.md)
  - [Use MCP Servers](../ide/mcp-servers.md)
  - [Multifactor authentication with Visual Studio sign-ins](../ide/work-with-multi-factor-authentication.md)
  - [Explore code editor features](../ide/writing-code-in-the-code-and-text-editor.md)
  - [GitHub Copilot Edits in Visual Studio](../ide/copilot-edits.md)

### Install

**Updated articles**

- [Using Visual Studio on an Azure Virtual Machine](../install/using-visual-studio-vm.md) - Refresh links

### JavaScript

**Updated articles**

- Review and update screenshots and freshness
  - [Compile and build TypeScript code using NuGet](../javascript/compile-typescript-code-nuget.md)
  - [Explore the Visual Studio IDE for JavaScript](../javascript/quickstart-ide-orientation-js.md)
  - [Create a Vue.js Project in Visual Studio](../javascript/tutorial-create-vue-app.md)
- [Unit testing JavaScript and TypeScript](../javascript/unit-testing-javascript-with-visual-studio.md) - Clarify limitations and remove outdated links

### Modeling

**Updated articles**

- [Use the Modeling SDK for Visual Studio](../modeling/modeling-sdk-for-visual-studio-domain-specific-languages.md) - Review and update

### MSBuild

**Updated articles**

- [Change waves](../msbuild/change-waves.md) - Sync with current MSBuild change waves
- [Update an MSBuild custom task for multithreaded builds](../msbuild/update-task-multithreaded.md) - Improve thread safety and experimental-status guidance

### Profiling

**Updated articles**

- Review and update screenshots
  - [Visualize dotnet counters](../profiling/dotnet-counters-tool.md)
  - [Identify hot paths with the Flame Graph](../profiling/flame-graph.md)

### Python

**Updated articles**

- Apply moniker profiling updates for Visual Studio 2022 content
  - [Python Support in Visual Studio on Windows](../python/overview-of-python-tools-for-visual-studio.md)
  - [Run profiler to measure Python code performance](../python/profiling-python-code-in-visual-studio.md)

### Test

**Updated articles**

- Review and update
  - [Isolating Code Under Test with Microsoft Fakes](../test/isolating-code-under-test-with-microsoft-fakes.md)
  - [Isolate Your App with Shims (Unit Testing)](../test/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md)

### Version control

**Updated articles**

- Add and refine multiline diff support and review flows
  - [Browse repos, compare branches & commits](../version-control/git-browse-repository.md)
  - [Create a pull request in Visual Studio](../version-control/git-create-pull-request.md)
  - [Make a Git commit in Visual Studio](../version-control/git-make-commit.md)
- [Manage Git repos in Visual Studio](../version-control/git-manage-repository.md) - Add commit-to-chat context guidance

### XML tools

**Updated articles**

- [Work with the XML Schema Explorer](../xml-tools/xml-schema-explorer.md) - Review and update screenshots

### Community contributors

The following people contributed to the Visual Studio docs during this period. Thank you! Learn how to contribute by following the links under "Get involved" in the [what's new landing page](index.yml).

- [jingeno](https://github.com/jingeno) - jingeno ![1 pull requests.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)
- [lvyijie](https://github.com/lvyijie) - lvyijie ![1 pull requests.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)
