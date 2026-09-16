---
title: Use GitHub Copilot agents in Visual Studio
description: Learn how to access and use GitHub Copilot agents for debugging, profiling, testing, modernization, and other development tasks.
ms.date: 09/16/2026
ms.topic: how-to
author: RoseHJM
ms.author: rosemalcolm
ms.service: visual-studio-windows
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
ms.custom: awp, doc-kit-assisted
ai-usage: ai-assisted
ms.update-cycle: 180-days
monikerRange: '>= vs-2022'
---

# Use GitHub Copilot agents in Visual Studio

Visual Studio includes built-in GitHub Copilot agents for development tasks such as debugging, profiling, and testing. This article explains how to access and use the agents available in your version of Visual Studio.

## Prerequisites

+ A [GitHub Copilot subscription](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot)

:::moniker range="visualstudio"

## Access agents in Copilot Chat

To open Copilot Chat, select the **GitHub Copilot** badge in the upper-right corner of Visual Studio, and then select **Open Chat**.

Access agents in two ways:

+ **Agent picker**: In the Copilot Chat window, select the agent picker drop-down to see available agents.
+ **@ syntax**: Type `@` followed by the agent name in the chat input (for example, `@debugger`).

## Use built-in agents

Each built-in agent focuses on a specific developer workflow. These agents integrate with Visual Studio's native tooling in ways that a generic assistant can't.

| Agent | Description |
| ----- | ----------- |
| **@debugger** | Goes beyond reading error messages. Uses your call stacks, variable state, and diagnostic tools to walk through error diagnosis systematically across your solution. |
| **@git** | Reviews your local uncommitted changes and surfaces feedback as inline comments in the editor and in the Git Changes experience. |
| **@profiler** | Connects to Visual Studio's profiling infrastructure to identify bottlenecks and suggest targeted optimizations grounded in your codebase, not generic advice. |
| **@test** | Generates unit tests tuned to your project's framework and patterns, not boilerplate that your CI rejects. |
| **@modernize** | (.NET and C++ only) Handles framework and dependency upgrades with awareness of your actual project graph. Flags breaking changes, generates migration code, and follows your existing patterns. |
| **Plan agent** | Creates and refines implementation plans before code changes begin by exploring your codebase with read-only tools, then hands the plan off to agent mode with **Implement plan**. |

### Use the @debugger agent

The @debugger agent helps you diagnose errors systematically by analyzing your debugging context. It also supports an end-to-end agentic workflow that reproduces bugs, instruments your app with tracepoints and conditional breakpoints, and validates fixes using live runtime data. For more information, see [Agentic bug resolution with the Debugger Agent](../debugger/debug-with-copilot.md#agentic-bug-resolution-with-the-debugger-agent).

**Example prompts**:

+ `@debugger Why is this exception being thrown?`
+ `@debugger Analyze the current call stack and explain what went wrong`
+ `@debugger What's causing the null reference in this method?`

### Use the @git agent

Use the @git agent to review local uncommitted changes without leaving Copilot Chat.

**Example prompts**:

+ `@git Review my changes`
+ `@git Explain this review comment and suggest a fix`

:::image type="content" source="../version-control/media/visualstudio/git-agent-code-review-icebreaker.png" alt-text="Screenshot of Visual Studio Copilot Chat with the Git agent and Review changes option highlighted.":::

For the full local review workflow, see [Review local changes with Copilot Chat](../version-control/git-make-commit.md#review-local-changes-with-copilot-chat).

**Review Selection** requires Visual Studio version 18.8 or later. To review only selected code, select the code in the editor, right-click the selection, and then select **Copilot Actions** > **Review Selection**. Copilot adds inline comments and can apply or generate suggestions. This command uses the same GitHub Copilot code-review experience as the Git Changes workflow. For more information, see [Review selected code](copilot-chat-context.md#review-selected-code).

### Use the @profiler agent

The @profiler agent connects to Visual Studio's profiling tools to help identify and fix performance issues.

**Example prompts**:

+ `@profiler Find the performance bottlenecks in my application`
+ `@profiler Why is this method taking so long to execute?`
+ `@profiler Suggest optimizations for the hot path`

### Use the @test agent

The @test agent generates unit tests that match your project's testing framework and conventions.

**Example prompts**:

+ `@test Generate unit tests for the selected method`
+ `@test Create tests that cover edge cases for this class`
+ `@test Write integration tests for this API endpoint`

For more comprehensive .NET testing support, see [GitHub Copilot testing for .NET](../test/github-copilot-test-dotnet-overview.md).

### Use the @modernize agent

The @modernize agent helps with framework migrations and dependency upgrades for .NET and C++ projects.

For .NET modernization workflows, the agent supports a three-stage process:

+ **Assessment**: Reviews package versions, target framework options, project inventory, and API compatibility risks.
+ **Plan**: Generates a migration plan that aligns with the current assessment and update priorities.
+ **Task execution**: Works through modernization tasks with an editable dynamic task file as the work progresses.

**Example prompts**:

+ `@modernize Upgrade this project to .NET 8`
+ `@modernize What breaking changes should I expect when migrating?`
+ `@modernize Update deprecated API calls in this file`
+ `@modernize Assess this solution, generate a migration plan, and create execution tasks`

For end-to-end guidance on GitHub Copilot app modernization for .NET, see [GitHub Copilot app modernization overview](/dotnet/core/porting/github-copilot-app-modernization/overview).

## Use cloud agents

In Visual Studio version 18.1 or later, start GitHub Cloud Agent sessions from the agent picker in Copilot Chat. To connect a repository, open a local solution from a GitHub repository and sign in to GitHub in Visual Studio. The GitHub Copilot coding agent powers these remote sessions. It can create repository issues and pull requests in that repository.

Cloud agents work only with repositories the GitHub Copilot coding agent can access. If the repository isn't already available to the coding agent, grant it access in GitHub. Visual Studio might prompt you to grant repository permissions the first time you start a cloud session or when the session requires more permissions. Review the requested permissions before you approve them.

## Create and use custom agents

Custom agents require Visual Studio version 18.4 or later.

The built-in agents cover common workflows, but your team knows its workflow best. Custom agents provide a foundation for agents tailored to your team's workflow: workspace awareness, code understanding, your preferred AI model, and your own tools.

Custom agents are especially powerful when combined with [MCP (Model Context Protocol)](mcp-servers.md). Connect agents to external knowledge sources such as internal documentation, design systems, APIs, and databases so the agent isn't limited to what's in your repository.

Define reusable [Agent Skills](copilot-agent-skills.md) that any agent can discover and use automatically. While agents define a persona and tool set, skills provide focused, task-specific instructions.

In the agent picker, callout 1 highlights the **+** button for creating an agent, and callout 2 highlights a custom agent named **my-agent**.

:::image type="content" source="media/visualstudio/copilot-chat-agent-picker.png" alt-text="Screenshot of the Visual Studio Copilot Chat agent picker with callout 1 on the create-agent button and callout 2 on the my-agent custom agent.":::

Built-in .NET and Azure skills require Visual Studio version 18.8 or later. Visual Studio provides these skills when you install the corresponding workloads. Unlike built-in agents or the Agent Skills you author, these workload-specific skills appear in the **Built-in** category on the **Skills** tab and are off by default. Review and enable only the skills that apply to your tasks. For more information, see [Use built-in .NET and Azure skills](copilot-agent-skills.md#use-built-in-net-and-azure-skills).

:::image type="content" source="media/visualstudio/copilot-chat-skills.png" alt-text="Screenshot of Visual Studio Copilot Chat with the Skills tab showing a workspace skill enabled and built-in skills turned off.":::

### Create a custom agent

Repository-level custom agents apply only to the repository where you store them. To create one manually:

1. At the repository root, create a `.github/agents/` folder if it doesn't already exist.
1. In that folder, create a file whose name ends in `.agent.md`, such as `code-reviewer.agent.md`.
1. Add YAML front matter and Markdown instructions by using the format described in [Agent file format](#agent-file-format).
1. Save the file.

The resulting folder structure looks like this:

```text
your-repo/
└── .github/
    └── agents/
        └── code-reviewer.agent.md
```

In Visual Studio version 18.5 or later, select the **+** button in the **agent picker** and follow the prompts to create a custom agent.

To create a user-level agent that applies across all your projects, store its `.agent.md` file in `%USERPROFILE%\.github\agents` by default. Change this location in **Tools > Options > GitHub > Copilot**.

### Select and verify a custom agent

After you create a custom agent:

1. Open **Copilot Chat**.
1. Open the **agent picker** and confirm that the agent appears with the name and description from its definition.
1. Select the agent, or invoke it by entering `@` followed by the agent name in the **chat input**.
1. Enter a prompt that tests one of the agent's instructions.
1. Verify that the response follows the agent's role and instructions. If the definition specifies tools, open the **Tools** panel and verify that the expected tools are available.

### Use organization-level custom agents

Organization-level custom agents require Visual Studio version 18.9 or later and a repository that belongs to a GitHub organization.

GitHub organization and enterprise owners can publish custom agents for members to use across repositories in an organization. When you open a repository in the organization, Visual Studio automatically detects these agents and adds them to the agent picker.

To inspect an organization-level custom agent before you use it:

1. Open **Copilot Chat** and select the **agent picker**.
1. Hover over the agent to view its description and source organization.
1. Select the **definition button** to open the agent definition file.

:::image type="content" source="media/visualstudio/org-level-agent.png" alt-text="Screenshot of the Visual Studio agent picker showing organization agents, their source organizations, and buttons that open agent definitions." lightbox="media/visualstudio/org-level-agent.png":::

Organization and enterprise owners configure these agents in GitHub. For setup guidance, see [Prepare to use custom agents in your organization](https://docs.github.com/copilot/how-tos/administer-copilot/manage-for-organization/prepare-for-custom-agents) or [Prepare to use custom agents in your enterprise](https://docs.github.com/copilot/how-tos/administer-copilot/manage-for-enterprise/manage-agents/prepare-for-custom-agents).

Organization-level custom instructions require Visual Studio version 18.8 or later. They're separate from custom agents. Organization owners use custom instructions to define preferences that Visual Studio automatically applies when you work in an organization repository. Applied instructions appear in **References**. Disable them in Visual Studio settings. For more information, see [Use organization-level custom instructions](copilot-chat-context.md#use-organization-level-custom-instructions).

### Agent file format

Each agent file uses YAML front matter followed by Markdown instructions:

```markdown
---
name: Code Reviewer
description: Reviews PRs against our team's coding standards
tools: ["code_search", "readfile", "find_references"]
---

You are a code reviewer for our team. When reviewing changes, check for:

- Naming conventions: PascalCase for public methods, camelCase for private
- Error handling: all async calls must have try/catch with structured logging
- Test coverage: every public method needs at least one unit test

Flag violations clearly and suggest fixes inline.
```

Available models vary by Visual Studio version and by the models available to your Copilot plan. The `model` property is optional, so omit it to use the model selected in the model picker. If you include the property, choose a model that's available in your version of Visual Studio.

#### Front matter properties

| Property | Required | Description |
| -------- | -------- | ----------- |
| `name` | No | Display name for the agent in the agent picker. If you don't specify this property, the agent name comes from the filename (for example, `code-reviewer.agent.md` becomes `code-reviewer`). |
| `description` | Yes | Brief description shown when hovering over the agent |
| `model` | No | AI model to use. If you don't specify this property, the model selected in the model picker is used. |
| `tools` | No | Array of tool names the agent can use. If you don't specify this property, all available tools are enabled. |

> [!NOTE]
> For some custom agents, tool groups appear disabled after you select the agent, even when you don't specify the `tools` property. In some sessions, tool selections reset after each follow-up message in the same chat thread. If this condition occurs, manually re-enable required tools in the **Tools** panel. For steps and reporting guidance, see [Custom agent tool groups start disabled or reset between turns](visual-studio-github-copilot-troubleshoot.md#custom-agent-tool-groups-start-disabled-or-reset-between-turns).

### Specify tools

Tools extend what your custom agent can do. Specify which tools the agent should use in the `tools` array.

> [!IMPORTANT]
> Tool names vary across GitHub Copilot platforms. Check the tools available in Visual Studio specifically to make sure your agent works as expected. Select the **Tools** icon in the chat window to see available tool names.

### Language-specific tools for C++

Agent mode generally includes C++ code editing tools. If you install the C++ workload, your custom agent can use these Visual Studio-specific tool names in its `tools` array:

- `get_symbol_call_hierarchy` for call hierarchy navigation
- `get_symbol_class_hierarchy` for class and type hierarchy navigation

These tools give agents language-aware navigation for C++ and help improve precision when analyzing and editing C++ code.

### Connect to external sources with MCP

By using [MCP servers](mcp-servers.md), your custom agents can access external knowledge sources such as:

+ Internal documentation and wikis
+ Design systems and component libraries
+ APIs and databases
+ Style guides and ADR repositories

For example, a code review agent can check PRs against your actual conventions by connecting to your style guide through MCP.

### Example custom agents

#### Code review agent

```markdown
---
name: Code Reviewer
description: Reviews code against our team's coding standards
tools: ["code_search", "readfile"]
---

You are a code reviewer for our team. Review changes for:

1. **Naming conventions**: PascalCase for public methods, camelCase for private fields
2. **Error handling**: All async calls must have try/catch with structured logging
3. **Test coverage**: Every public method needs at least one unit test
4. **Documentation**: Public APIs must have XML documentation comments

Flag violations clearly and suggest fixes inline.
```

#### Feature planning agent example

Use a custom feature-planning agent when you want a team-specific planning workflow or extra tools beyond the built-in plan agent.

```markdown
---
name: Feature Planner
description: Helps plan features before writing code
tools: ["code_search", "readfile", "find_references"]
---

You are a feature planning assistant. When asked about a feature:
1. Gather requirements by asking clarifying questions
2. Identify affected files and components in the codebase
3. Break down the work into discrete tasks
4. Flag potential risks or dependencies
5. Create a structured plan that can be handed off for implementation

Focus on understanding scope before suggesting solutions.
```

#### Design system agent

```markdown
---
name: Design System
description: Enforces UI design patterns and component usage
tools: ["code_search", "readfile"]
---

You are a design system expert. When reviewing UI code:

1. Check that standard components are used instead of custom implementations
2. Verify spacing and layout follow the design token system
3. Ensure accessibility requirements are met (ARIA labels, keyboard navigation)
4. Flag any UI drift from established patterns

Reference the component library documentation when suggesting fixes.
```

#### Full-stack development agent with Visual Studio tools

The following example uses Visual Studio-specific tool names:

```markdown
---
name: Full Stack Dev
description: Full-stack development assistant with search, file editing, and terminal access
tools: ["code_search", "readfile", "editfiles", "find_references", "runcommandinterminal", "getwebpages"]
---

You are a full-stack development assistant. Help with:

1. Searching the codebase to understand existing patterns
2. Reading and editing files to implement changes
3. Running build and test commands to verify your work
4. Looking up documentation when needed

Always check existing code conventions before making changes.
```

> [!TIP]
> Select the **Tools** icon in the Copilot Chat window to see all available tool names in your version of Visual Studio.

### .NET development agents

The .NET team maintains curated custom agents for C# and Windows Forms development in the [awesome-copilot](https://github.com/github/awesome-copilot) repository. To get started:

1. Download [CSharpExpert.agent.md](https://github.com/github/awesome-copilot/blob/main/agents/CSharpExpert.agent.md) and [WinFormsExpert.agent.md](https://github.com/github/awesome-copilot/blob/main/agents/WinFormsExpert.agent.md).
1. Add the files to your repository's `.github/agents/` folder.
1. Open **Copilot Chat** in agent mode and select the agent from the agent picker.

> [!TIP]
> Select **Tools** > **Options** > **GitHub** > **Copilot**, and then enable **Enable project specific .NET instructions such as Windows Forms development when applicable** to automatically add the appropriate custom agent for your code base.

#### C# Expert

The C# Expert agent applies modern C# conventions to Copilot's code generation:

+ **Syntax and performance**: Follows current best practices while matching your repository's existing conventions.
+ **Minimal changes**: Generates only the code needed, using async/await with proper cancellation and exception handling. Avoids unused interfaces, methods, or parameters.
+ **Testing**: Supports behavior-driven unit testing, integration testing, and TDD workflows.

#### WinForms Expert

The WinForms Expert agent targets Windows Forms development on .NET 8 through .NET 10:

+ **Designer code protection**: Prevents `.Designer.cs` corruption so the [Windows Forms Designer](../designers/windows-forms-designer-overview.md) keeps working after Copilot edits.
+ **UI design patterns**: MVVM and MVP patterns, including Community Toolkit data binding.
+ **Modern .NET**: Correct `InvokeAsync` overloads, dark mode, high-DPI awareness, and nullable reference types.
+ **Layout**: `TableLayoutPanel` and `FlowLayoutPanel` for responsive, DPI-aware layouts.
+ **CodeDOM serialization**: `[DefaultValue]` attributes and `ShouldSerialize*()` methods for proper designer property handling.
+ **Exception handling**: Async event handler patterns and application-level exception handling.

### Community configurations

The [awesome-copilot repository](https://github.com/github/awesome-copilot) offers community-contributed agent configurations as starting points. When you use configurations from this repository, verify tool names work in Visual Studio before deploying to your team.

### Limitations and notes

+ If you don't specify a model, the agent uses whatever model is selected in the model picker.
+ Tool names vary across GitHub Copilot platforms. Verify tool names work in Visual Studio before deploying to your team.

### Share feedback

Share your custom agent configurations in the [awesome-copilot repository](https://github.com/github/awesome-copilot) or file feedback through [Visual Studio Developer Community](https://developercommunity.visualstudio.com/). Your workflows help shape future features.

## Related content

+ [Get started with GitHub Copilot agent mode](copilot-agent-mode.md)
+ [Use Agent Skills](copilot-agent-skills.md)
+ [Use MCP servers](mcp-servers.md)
+ [GitHub Copilot testing for .NET](../test/github-copilot-test-dotnet-overview.md)
+ [Visual Studio July Update: Meet the New Agent, Powered by the GitHub Copilot SDK](https://devblogs.microsoft.com/visualstudio/visual-studio-july-update-meet-the-new-agent-powered-by-copilot-sdk/)

:::moniker-end

:::moniker range="vs-2022"

## Use built-in agents in Visual Studio 2022

You need Visual Studio 2022 version 17.14 or later.

To open Copilot Chat, select the **GitHub Copilot** badge in the upper-right corner of Visual Studio, and then select **Open Chat Window**.

Access built-in agents in two ways:

+ **Agent picker**: In the Copilot Chat window, select the agent picker drop-down to see the available built-in agents.
+ **@ syntax**: Enter `@` followed by the agent name in the chat input (for example, `@profiler`).

The agent picker can include the following built-in agents. Availability can vary by your Visual Studio 2022 version and installed workloads.

| Agent | Description |
| ----- | ----------- |
| **Context** | Context analysis agent |
| **GitHub** | Chat with GitHub |
| **Profiler** | Optimize your code |
| **VS** | Ask questions about Visual Studio |
| **Workspace** | Ask about your workspace |

:::image type="content" source="media/vs-2022/copilot-chat-2022-agent-picker.png" alt-text="Screenshot of the Visual Studio 2022 Copilot Chat agent picker showing Context, GitHub, Profiler, VS, and Workspace.":::

## Use the @context agent

The @context agent analyzes the context for your request to help you understand the code you're working with.

**Example prompts**:

+ `@context Explain the code in the current file`
+ `@context What code is relevant to this method?`
+ `@context Summarize the context for the selected code`

## Use the @profiler agent

The @profiler agent connects to Visual Studio's profiling tools to help identify and fix performance issues.

**Example prompts**:

+ `@profiler Find the performance bottlenecks in my application`
+ `@profiler Why is this method taking so long to execute?`
+ `@profiler Suggest optimizations for the hot path`

## Related content

+ [Get started with GitHub Copilot agent mode](copilot-agent-mode.md)
+ [Customize chat responses and set context](copilot-chat-context.md)
+ [Use GitHub Copilot Chat in Visual Studio](visual-studio-github-copilot-chat.md)

:::moniker-end
