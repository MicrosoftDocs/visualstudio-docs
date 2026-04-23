---
applyTo: '**'
---

# Visual Studio Product Context — Override Instructions

When working in this repository, apply the following Visual Studio–specific
overrides to any doc-kit agent, skill, or prompt. These rules take precedence
over Foundry-specific defaults shipped with doc-kit.

---

## 1. Product Identity

| Default (Foundry)                  | Override (Visual Studio)                          |
|------------------------------------|---------------------------------------------------|
| Product name: "Azure AI Foundry"   | **Visual Studio**                             |
| Docs base URL                      | `https://learn.microsoft.com/visualstudio/`        |
| Release-notes URL                  | `https://learn.microsoft.com/visualstudio/releases/2026/release-notes` |
| Download page                      | `https://visualstudio.microsoft.com/downloads/`    |
| Feedback mechanism                 | Developer Community (`developercommunity.visualstudio.com`) |
| Product hub                        | `https://aka.ms/vshub`                             |
| `ms.service`                       | `visual-studio-windows`                            |
| `ms.subservice` values             | {FILL: e.g., `ide`, `debugger`, `install`, `test`, `extensibility`, `copilot`} |
| Moniker / version selector         | `visualstudio` (current), `vs-2022` (previous)          |

## 2. Repository & Content Structure

| Aspect               | Value                                                              |
|-----------------------|--------------------------------------------------------------------|
| Docs repo             | `MicrosoftDocs/visualstudio-docs`                                  |
| Docs repo path        | `docs/`                                                            |
| Media folder          | `docs/ide/media/`, `docs/debugger/media/`, etc.                    |
| TOC files             | One `TOC.yml` per feature area under `docs/`                       |
| Breadcrumb file       | `docs/_breadcrumb/toc.yml`                                               |
| Includes folder       | `docs/includes/`                                                   |

## 3. Versioning & Moniker Rules

- Visual Studio docs use **moniker-based versioning**: `visualstudio`, `vs-2022`, `vs-2019`.
- The current GA version is referred to as **Visual Studio** (versionless), even though the underlying version increments monthly (18.0, 18.1, etc.)
- When writing content, target `visualstudio` unless explicitly asked for an older version.
- Use `:::moniker range="visualstudio"` / `:::moniker-end` fences for version-specific content.
- Do NOT mix moniker-fenced blocks with un-fenced content in the same section.

## 4. Metadata Defaults

Every Markdown article must include this YAML front matter (adjust values per article):

```yaml
---
title: "{Article Title}"
description: "{140-character max description}"
ms.date: {MM/DD/YYYY}
ms.topic: {how-to | conceptual | overview | reference | quickstart | tutorial}
author: {GitHub-username}
ms.author: {Microsoft-alias}
---
```

## 5. Key Technology Areas

Visual Studio 2026 documentation covers these primary areas:

| Area                     | Path prefix          | Notes                                              |
|--------------------------|----------------------|----------------------------------------------------|
| IDE & Editor             | `docs/ide/`          | Core editing, settings, themes, project system      |
| Debugging & Diagnostics  | `docs/debugger/`     | Breakpoints, profiling, diagnostics, visualizers    |
| Testing                  | `docs/test/`         | Unit testing, Live Unit Testing, IntelliTest        |
| Deployment               | `docs/deployment/`   | ClickOnce, installers, containers                   |
| Extensibility            | `docs/extensibility/`| VisualStudio.Extensibility (new model), VSSDK (legacy) |
| .NET / C#                | Cross-references to `learn.microsoft.com/dotnet/` |                           |
| Git tooling              | `docs/version-control/` | PR reviews, inline comments, Git integration     |
| Cloud                    | `docs/azure/`        | Azure integration, Container Tools, Service Fabric  |
| Install & Update         | `docs/install/`      | Workloads, offline install, admin layouts            |

## 6. Terminology & Style

| Instead of …                            | Use …                                          |
|-----------------------------------------|------------------------------------------------|
| "project" (AI/ML context)              | "solution" or "project" (VS solution/project)  |
| "deployment" (model deployment)        | "deployment" (app publish/deploy)              |
| "agent" (AI agent)                     | "agent" (Copilot agent, or avoid ambiguity)    |
| "playground"                           | Not applicable — omit                          |
| "hub" / "project" (Foundry hierarchy)  | Not applicable — omit                          |
| "SDK" (Azure AI SDK)                   | "Visual Studio SDK"  |
| "endpoint"                             | "endpoint" (debugging/web) — context-dependent |

- Follow the [Microsoft Writing Style Guide](https://learn.microsoft.com/style-guide/welcome/).
- Use **sentence-case** for headings.
- Use **bold** for UI elements: **Solution Explorer**, **Debug > Start Debugging**.
- Refer to menu paths with `>`: **Tools > Options > Environment**.

## 7. Competitive & Adjacent Products

When reviewing or comparing, these are the primary competitors/alternatives:

- JetBrains Rider (C#/.NET)
- JetBrains CLion (C++)
- Eclipse / Eclipse CDT
- VS Code (lightweight editor, sibling product)
- Xcode (macOS/iOS development)

Do NOT position VS Code as a competitor; position it as a complementary tool.

---

## 8. Visual Studio 2026 Release Notes — Grounding Data

**Source:** <https://learn.microsoft.com/visualstudio/releases/2026/release-notes>

Use this section as grounding when writing about new features, updating what's-new
pages, or answering questions about current capabilities in Visual Studio 2026.

#### IDE
- Perform certificate revocation checks
- Compact spacing in Solution Explorer
- M365 Agents Toolkit

#### Productivity
- Fast scrolling
- Hide symbols under files
- New markdown preview features
- Insignificant line compression
- Middle-click scroll
- Slimmer left margin in editor

#### GitHub Copilot
- NuGet MCP Server
- Preview markdown from Copilot Chat
- Click to accept code completions
- Colorized code completions
- Copilot memories updates
- Access custom prompts via slash commands

#### Debugging & Diagnostics
- DataTips in the IEnumerable Visualizer
- Analyze your call stack
- Profiler agent with Unit Test support

#### Desktop
- WinForms Expert agent

#### .NET
- NuGet audit sources
- Web Live Preview deprecation
- Hot Reload improvements
- Razor editor improvements
- Smarter .NET test generation

#### C++
- App modernization for C++
- Code editing tools for agent mode
- Build performance for Windows

#### Extensibility
- Experimental Instance relocated

### Version 18.2.2

Released February 10, 2026. Security and servicing update.

- Fixed MSVC optimizer bad assembly code generation
- CVE-2026-21256: GitHub Copilot and Visual Studio Remote Code Execution Vulnerability
- CVE-2026-21257: GitHub Copilot and Visual Studio Security Feature Bypass Vulnerability
- CVE-2026-21218: .NET Security Feature Bypass Vulnerability

### Version 18.2.1

Released January 20, 2026. Servicing update.

- Fixed: VS2026 missing `Microsoft.VCRedistVersion.v143.default.props`
- Fixed: Fatal error C1001 internal compiler error

### Version 18.2.0 (January Update)

Released January 13, 2026.

#### GitHub Copilot
- NuGet MCP Server

#### .NET
- GitHub Copilot app modernization

#### C++
- MSVC versions from Visual Studio 2022

### Version 18.1.1

Released December 16, 2025. Servicing update.

- Fixed: Internal compiler error in MSVC 14.50.35717
- Fixed: Missing option to install LTSC C++ tools
- Fixed: ReSharper longer startup times compared to VS 2022
- Fixed: Search broken in MCP Registries window
- Fixed: ARM64 Enclave VCRuntime linking
- Updated Windows SDK to 10.0.26100.7175

### Version 18.1.0 (December Update)

Released December 9, 2025.

#### IDE
- MCP Authentication Management
- MCP Server Instructions
- MCP Elicitations and sampling
- MCP Server Management

#### GitHub Copilot
- GitHub Cloud Agent preview

#### Debugging & Diagnostics
- Smarter breakpoint troubleshooting
- Debugger Copilot uses Output Window
- .NET counters for profiler agent
- Exception analysis with GitHub repo context

#### Desktop
- WinForms Expert agent

### Version 18.0.0 (November Update — GA Release)

Released November 11, 2025. **First GA release of versionless Visual Studio.** The underlying version of this first GA release was 18.0, but this not used in user-facing documentation.

#### IDE
- "Did you mean?" search
- Code coverage
- New look and feel
- Modern settings experience
- M365 Agents Toolkit updates
- Setup Assistant

#### Productivity
- Adaptive paste
- Code actions at your fingertips
- Mermaid chart rendering
- Enhanced editor controls
- File exclusions in search
- Familiar keyboard shortcuts

#### GitHub Copilot
- Copilot URL context
- Better Copilot responses

#### Debugging & Diagnostics
- Debugger Agent for unit tests
- Enhanced exception analysis
- Inline if-statement / variables / parameters / post-return values
- Performance improvements for F5
- Search in Text Visualizer
- Profiler Copilot Agent
- CodeLens with Optimize Allocations
- Profiler Agent thread summarization
- BenchmarkDotNet project template
- CMake diagnostics
- New Profiler launch experience
- Optimize zero-length arrays

#### Git Tooling
- Inline pull request comments
- Better code reviews
- Git context in Copilot Chat
- Easier comment navigation in local code review
- Apply PR comment suggestions
- Team Explorer Work Items deprecation

#### Cloud
- Cloud Services (extended support) deprecation
- Service Fabric tools update
- Podman support in Container Tools

#### .NET
- .NET 10 and C# 14

#### C++
- MSVC Build Tools Version 14.50
- MSVC Build Tools Windows support
- C++ feature deprecations and removals
- C++ STL updates
- Class View improvement
- Project template updates
- Syntax highlighting for attributes
- clang-tidy improvements
- C++ Linux workload rename
- Debugger command line arguments
- Generated preprocessed output
- IncrediBase support
- CMake support for VS 2026 Generator
- AddressSanitizer support for ARM64

---

## 9. Extensibility Model Reference

Visual Studio supports **two extensibility models**. Always clarify which
model applies when writing extensibility content.

### VisualStudio.Extensibility (New, out-of-process)
- NuGet package: `Microsoft.VisualStudio.Extensibility`
- Runs out-of-process for stability
- Preferred for all new extensions
- Docs: `docs/extensibility/visualstudio.extensibility/`

### VSSDK (Legacy, in-process)
- NuGet package: `Microsoft.VisualStudio.SDK`
- Runs in-process (can crash VS)
- Maintenance-only; no new feature investment
- Docs: `docs/extensibility/`

When writing tutorials or how-to guides, default to the **new model** unless the
user or article explicitly targets VSSDK.

---

## 10. Common Doc Patterns for Visual Studio

### Prerequisites block
```markdown
## Prerequisites

- [Visual Studio](https://aka.ms/vs/download/?cid=learn-onpage-download-install-visual-studio-page-cta) with
  the **{workload name}** workload installed.
- {Any additional SDKs, tools, or accounts}
```

### UI procedure steps
Use **bold** for UI elements and `>` for menu traversal:
```markdown
1. Open Visual Studio and select **File > New > Project**.
2. In the **Create a new project** dialog, search for **Console App**.
3. Select **Console App** and select **Next**.
4. Enter a project name and select **Create**.
```

### Screenshot conventions
- File format: PNG
- Max width: 750 px
- Alt text: Describe the action, not the image ("Screenshot showing the Debug menu with Start Debugging highlighted.")
- Path: `media/{article-name}/` subfolder

### See also section
End every article with a **See also** section linking to 2–5 related articles.

---

## 11. How to Keep This File Current

1. **After each VS release:** Update Section 8 with new release-notes entries from
   <https://learn.microsoft.com/visualstudio/releases/2026/release-notes>.
2. **When repos change:** Update Section 2 paths, TOC references, or samples repo.
3. **When metadata rules change:** Update Section 4 front-matter template.
4. **Target size:** If this file exceeds ~600 lines, consider migrating grounding
   sections into a dedicated `.github/skills/vs-product-context/` skill with
   separate `references/*.md` files (Option B from the multi-product analysis).
