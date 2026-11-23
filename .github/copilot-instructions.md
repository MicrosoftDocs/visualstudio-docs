# Copilot Instructions for Microsoft Learn

These instructions define a unified style and process standard for authoring and maintaining learn.microsoft.com documentation with GitHub Copilot or other AI assistance.

## Learn-wide Instructions

Below are instructions that apply to all Microsoft Learn documentation authored with AI assistance. Learn product team will update this periodically as needed. Each repository SHOULD NOT update this to avoid being overwritten, but update the repository-specific instructions below as needed.

### AI Usage & Disclosure
All Markdown content created or substantially modified with AI assistance must include an `ai-usage` front matter entry:
- `ai-usage: ai-generated` – AI produced the initial draft with minimal human authorship
- `ai-usage: ai-assisted` – Human-directed, reviewed, and edited with AI support
- Omit only for purely human-authored legacy content

If missing, **add it**. However, do not add or update the ai-usage tag if the changes proposed are confined solely to:
- Links (link text and/or URLs)
- Single words or short phrases, such as entries in table cells
- Less than 5% of the article's word count

### Writing Style

Follow [Microsoft Writing Style Guide](https://learn.microsoft.com/style-guide/welcome/) with these specifics:

#### Voice and Tone

- Active voice, second person addressing reader directly
- Conversational tone with contractions
- Present tense for instructions/descriptions
- Imperative mood for instructions ("Call the method" not "You should call the method")
- Use "might" instead of "may" for possibility
- Avoid "we"/"our" referring to documentation authors

#### Structure and Format

- Sentence case headings (no gerunds in titles)
- Be concise, break up long sentences
- Oxford comma in lists
- Number all ordered list items as "1." (not sequential numbering like "1.", "2.", "3.", etc.)
- Complete sentences with proper punctuation in all list items
- Avoid "etc." or "and so on" - provide complete lists or use "for example"
- No consecutive headings without content between them

#### Formatting Conventions

- **Bold** for UI elements
- `Code style` for file names, folders, custom types, non-localizable text
- Raw URLs in angle brackets
- Use relative links for files in this repo
- Remove `https://learn.microsoft.com/en-us` from learn.microsoft.com links

## Repository-Specific Instructions

Below are instructions specific to this repository. These may be updated by repository maintainers as needed.

<!--- Add additional repository level instructions below. Do NOT update this line or above. --->

When working in this repository, apply the following Visual Studio-specific overrides to any doc-kit agent, skill, or prompt. These rules take precedence over Foundry-specific defaults shipped with doc-kit, but don't replace the Learn-wide instructions above.

### Product identity

| Default (Foundry) | Override (Visual Studio) |
|------------------|-------------------------|
| Product name: "Azure AI Foundry" | **Visual Studio** |
| Docs base URL | `https://learn.microsoft.com/visualstudio/` |
| Release-notes URL | `https://learn.microsoft.com/visualstudio/releases/2026/release-notes` |
| Download page | `https://visualstudio.microsoft.com/downloads/` |
| Feedback mechanism | Developer Community (`developercommunity.visualstudio.com`) |
| Product hub | `https://aka.ms/vshub` |
| `ms.service` | `visual-studio-windows` |
| `ms.subservice` values | {FILL: e.g., `ide`, `debugger`, `install`, `test`, `extensibility`, `copilot`} |
| Moniker / version selector | `visualstudio` (current), `vs-2022` (previous) |

### Repository and content structure

| Aspect | Value |
|--------|-------|
| Docs repo | `MicrosoftDocs/visualstudio-docs` |
| Docs repo path | `docs/` |
| Media folder | For example, `docs/ide/media/` and `docs/debugger/media/`. |
| TOC files | One `TOC.yml` per feature area under `docs/`. |
| Breadcrumb file | `docs/_breadcrumb/toc.yml` |
| Includes folder | `docs/includes/` |

### Versioning and moniker rules

- Visual Studio docs use **moniker-based versioning**: `visualstudio`, `vs-2022`, `vs-2019`.
- Refer to the current GA version as **Visual Studio** (versionless), even though the underlying version increments monthly (for example, 18.0 and 18.1).
- When writing content, target `visualstudio` unless explicitly asked for an older version.
- Use `:::moniker range="visualstudio"` / `:::moniker-end` fences for version-specific content.
- Don't mix moniker-fenced blocks with unfenced content in the same section.

### Metadata defaults

Every Markdown article must include this YAML front matter (adjust values per article).
Apply the Learn-wide AI disclosure rules and exceptions above: this example uses
`ai-assisted`; use `ai-generated` when AI produces the initial draft with minimal
human authorship.

```yaml
---
title: "{Article Title}"
description: "{140-character max description}"
ms.date: {MM/DD/YYYY}
ms.topic: {how-to | conceptual | overview | reference | quickstart | tutorial}
author: {GitHub-username}
ms.author: {Microsoft-alias}
ai-usage: ai-assisted
---
```

### Key technology areas

Visual Studio 2026 documentation covers these primary areas:

| Area | Path prefix | Notes |
|------|-------------|-------|
| IDE and editor | `docs/ide/` | Core editing, settings, themes, project system. |
| Debugging and diagnostics | `docs/debugger/` | Breakpoints, profiling, diagnostics, visualizers. |
| Testing | `docs/test/` | Unit testing, Live Unit Testing, IntelliTest. |
| Deployment | `docs/deployment/` | ClickOnce, installers, containers. |
| Extensibility | `docs/extensibility/` | VisualStudio.Extensibility (new model), VSSDK (legacy). |
| .NET / C# | Cross-references to `learn.microsoft.com/dotnet/`. | |
| Git tooling | `docs/version-control/` | PR reviews, inline comments, Git integration. |
| Cloud | `docs/azure/` | Azure integration, Container Tools, Service Fabric. |
| Install and update | `docs/install/` | Workloads, offline install, admin layouts. |

### Terminology and menu paths

| Instead of | Use |
|------------|-----|
| "project" (AI/ML context) | "solution" or "project" (VS solution/project) |
| "deployment" (model deployment) | "deployment" (app publish/deploy) |
| "agent" (AI agent) | "agent" (Copilot agent, or avoid ambiguity) |
| "playground" | Not applicable - omit. |
| "hub" / "project" (Foundry hierarchy) | Not applicable - omit. |
| "SDK" (Azure AI SDK) | "Visual Studio SDK" |
| "endpoint" | "endpoint" (debugging/web) - context-dependent. |

Refer to menu paths with `>`: **Tools > Options > Environment**.

### Competitive and adjacent products

When reviewing or comparing, these are the primary competitors and alternatives:

- JetBrains Rider (C#/.NET).
- JetBrains CLion (C++).
- Eclipse / Eclipse CDT.
- VS Code (lightweight editor, sibling product).
- Xcode (macOS/iOS development).

Don't position VS Code as a competitor; position it as a complementary tool.

### Visual Studio 2026 release notes - grounding data

**Source:** <https://learn.microsoft.com/visualstudio/releases/2026/release-notes>

Use this section as grounding when writing about new features, updating what's-new pages, or answering questions about current capabilities in Visual Studio 2026.

#### Feature highlights

The source includes the following feature highlights.

##### IDE
- Perform certificate revocation checks.
- Compact spacing in Solution Explorer.
- M365 Agents Toolkit.

##### Productivity
- Fast scrolling.
- Hide symbols under files.
- New markdown preview features.
- Insignificant line compression.
- Middle-click scroll.
- Slimmer left margin in editor.

##### GitHub Copilot
- NuGet MCP Server.
- Preview markdown from Copilot Chat.
- Click to accept code completions.
- Colorized code completions.
- Copilot memories updates.
- Access custom prompts via slash commands.

##### Debugging and diagnostics
- DataTips in the IEnumerable Visualizer.
- Analyze your call stack.
- Profiler agent with Unit Test support.

##### Desktop
- WinForms Expert agent.

##### .NET
- NuGet audit sources.
- Web Live Preview deprecation.
- Hot Reload improvements.
- Razor editor improvements.
- Smarter .NET test generation.

##### C++
- App modernization for C++.
- Code editing tools for agent mode.
- Build performance for Windows.

##### Extensibility
- Experimental Instance relocated.

#### Version 18.2.2

Released February 10, 2026. Security and servicing update.

- Fixed MSVC optimizer bad assembly code generation.
- CVE-2026-21256: GitHub Copilot and Visual Studio Remote Code Execution Vulnerability.
- CVE-2026-21257: GitHub Copilot and Visual Studio Security Feature Bypass Vulnerability.
- CVE-2026-21218: .NET Security Feature Bypass Vulnerability.

#### Version 18.2.1

Released January 20, 2026. Servicing update.

- Fixed: VS2026 missing `Microsoft.VCRedistVersion.v143.default.props`.
- Fixed: Fatal error C1001 internal compiler error.

#### Version 18.2.0 (January update)

Released January 13, 2026.

##### GitHub Copilot
- NuGet MCP Server.

##### .NET
- GitHub Copilot app modernization.

##### C++
- MSVC versions from Visual Studio 2022.

#### Version 18.1.1

Released December 16, 2025. Servicing update.

- Fixed: Internal compiler error in MSVC 14.50.35717.
- Fixed: Missing option to install LTSC C++ tools.
- Fixed: ReSharper longer startup times compared to VS 2022.
- Fixed: Search broken in MCP Registries window.
- Fixed: ARM64 Enclave VCRuntime linking.
- Updated Windows SDK to 10.0.26100.7175.

#### Version 18.1.0 (December update)

Released December 9, 2025.

##### IDE
- MCP Authentication Management.
- MCP Server Instructions.
- MCP Elicitations and sampling.
- MCP Server Management.

##### GitHub Copilot
- GitHub Cloud Agent preview.

##### Debugging and diagnostics
- Smarter breakpoint troubleshooting.
- Debugger Copilot uses Output Window.
- .NET counters for profiler agent.
- Exception analysis with GitHub repo context.

##### Desktop
- WinForms Expert agent.

#### Version 18.0.0 (November update - GA release)

Released November 11, 2025. **First GA release of versionless Visual Studio.** The underlying version of this first GA release was 18.0, but this isn't used in user-facing documentation.

##### IDE
- "Did you mean?" search.
- Code coverage.
- New look and feel.
- Modern settings experience.
- M365 Agents Toolkit updates.
- Setup Assistant.

##### Productivity
- Adaptive paste.
- Code actions at your fingertips.
- Mermaid chart rendering.
- Enhanced editor controls.
- File exclusions in search.
- Familiar keyboard shortcuts.

##### GitHub Copilot
- Copilot URL context.
- Better Copilot responses.

##### Debugging and diagnostics
- Debugger Agent for unit tests.
- Enhanced exception analysis.
- Inline if-statement / variables / parameters / post-return values.
- Performance improvements for F5.
- Search in Text Visualizer.
- Profiler Copilot Agent.
- CodeLens with Optimize Allocations.
- Profiler Agent thread summarization.
- BenchmarkDotNet project template.
- CMake diagnostics.
- New Profiler launch experience.
- Optimize zero-length arrays.

##### Git tooling
- Inline pull request comments.
- Better code reviews.
- Git context in Copilot Chat.
- Easier comment navigation in local code review.
- Apply PR comment suggestions.
- Team Explorer Work Items deprecation.

##### Cloud
- Cloud Services (extended support) deprecation.
- Service Fabric tools update.
- Podman support in Container Tools.

##### .NET
- .NET 10 and C# 14.

##### C++
- MSVC Build Tools Version 14.50.
- MSVC Build Tools Windows support.
- C++ feature deprecations and removals.
- C++ STL updates.
- Class View improvement.
- Project template updates.
- Syntax highlighting for attributes.
- clang-tidy improvements.
- C++ Linux workload rename.
- Debugger command line arguments.
- Generated preprocessed output.
- IncrediBase support.
- CMake support for VS 2026 Generator.
- AddressSanitizer support for ARM64.

### Extensibility model reference

Visual Studio supports **two extensibility models**. Always clarify which model applies when writing extensibility content.

#### VisualStudio.Extensibility (new, out-of-process)

- NuGet package: `Microsoft.VisualStudio.Extensibility`.
- Runs out-of-process for stability.
- Preferred for all new extensions.
- Docs: `docs/extensibility/visualstudio-extensibility/`.

#### VSSDK (legacy, in-process)

- NuGet package: `Microsoft.VisualStudio.SDK`.
- Runs in-process (can crash VS).
- Maintenance-only; no new feature investment.
- Docs: `docs/extensibility/`.

When writing tutorials or how-to guides, default to the **new model** unless the user or article explicitly targets VSSDK.

### Common doc patterns for Visual Studio

Use the following patterns for Visual Studio articles.

#### Prerequisites block

```markdown
## Prerequisites

- [Visual Studio](https://aka.ms/vs/download/?cid=learn-onpage-download-install-visual-studio-page-cta) with
  the **{workload name}** workload installed.
- {Any additional SDKs, tools, or accounts}.
```

#### UI procedure steps

Use this procedure format for menu navigation:

```markdown
1. Open Visual Studio and select **File > New > Project**.
1. In the **Create a new project** dialog, search for **Console App**.
1. Select **Console App** and select **Next**.
1. Enter a project name and select **Create**.
```

#### Screenshot conventions

- File format: PNG.
- Max width: 750 px.
- Alt text: Describe the action, not the image ("Screenshot showing the Debug menu with Start Debugging highlighted.").
- Path: `media/{article-name}/` subfolder.

#### See also section

End every article with a **See also** section linking to 2–5 related articles.

### Keep these instructions current

1. **After each VS release:** Update the "Visual Studio 2026 release notes - grounding data" section with new release-notes entries from <https://learn.microsoft.com/visualstudio/releases/2026/release-notes>.
1. **When repos change:** Update the "Repository and content structure" section with paths, TOC references, or the samples repo.
1. **When metadata rules change:** Update the "Metadata defaults" section's front-matter template.
1. **Target size:** If this file exceeds about 600 lines, consider migrating grounding sections into a dedicated `.github/skills/vs-product-context/` skill with separate `references/*.md` files.