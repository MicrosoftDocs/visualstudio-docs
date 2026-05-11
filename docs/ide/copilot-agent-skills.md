---
title: Use Agent Skills with GitHub Copilot
description: Learn how to define reusable Agent Skills that teach Copilot agents how to perform specific tasks in Visual Studio.
ms.date: 04/27/2026
ms.topic: how-to
author: mikejo5000
ms.author: mikejo
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
ms.custom: awp-ai
ai-usage: ai-assisted
ms.update-cycle: 180-days
monikerRange: '>= visualstudio'
---

# Use Agent Skills with GitHub Copilot

Agent skills are reusable sets of instructions that teach Copilot agents how to perform specific tasks, like running a build pipeline, generating boilerplate, or following your team's coding standards. By defining skills once, you save time and ensure consistent behavior across your workflow.

Skills complement [custom agents](copilot-specialized-agents.md) and [custom instructions](copilot-chat-context.md#use-custom-instructions). While custom agents define a persona and tool set, and custom instructions set general coding preferences, skills provide focused, task-specific guidance that any agent can discover and use automatically.

## Prerequisites

+ [Visual Studio 2026 version 18.5](/visualstudio/releases/2026/release-notes) or later
+ A [GitHub Copilot subscription](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot)

## How Agent Skills work

When you use [agent mode](copilot-agent-mode.md), Copilot automatically discovers skills from your repository and user profile. The agent decides when a skill is relevant to your request and activates it. When a skill is activated, it appears in the chat to let you know it's being applied.

:::image type="content" source="media/visualstudio/agent-skills.png" alt-text="Screenshot that shows a skill being used by the Copilot agent in chat." lightbox="media/visualstudio/agent-skills.png":::

## Skill locations

Skills are picked up from the following locations:

| Skill type | Location |
|---|---|
| Workspace or project skills (stored in your repository) | `.github/skills/`, `.claude/skills/`, `.agents/skills/` |
| Personal skills (stored in your user profile) | `~/.copilot/skills/`, `~/.claude/skills/`, `~/.agents/skills/` |

Workspace skills are shared with your team through source control. Personal skills apply to all your projects and aren't committed to any repository.

## Create a skill

You can create a skill from the skills panel in Visual Studio, or manually in your file system.

You can create a skill manually in your file system.

### Create a skill from the skills panel

1. Select the **Tools** icon in the bottom-right corner of Copilot Chat to open the skills panel.
2. Select the **+** button in the top-right corner of the panel.

   :::image type="content" source="media/visualstudio/skills-create.png" alt-text="Screenshot that shows creating a new skill from the skills panel." lightbox="media/visualstudio/skills-create.png":::

1. Choose a destination (global or solution-level skill) and pick a name.

   :::image type="content" source="media/visualstudio/skills-create-new.png" alt-text="Screenshot that shows naming a new skill." lightbox="media/visualstudio/skills-create-new.png":::

1. Visual Studio generates a skill template for you to fill in. You can use Copilot agent mode to help you complete the template.

### Create a skill manually

Each skill is a directory containing a `SKILL.md` file that follows the [agentskills.io specification](https://agentskills.io/specification).

1. Create a skills directory. For a workspace skill, use `.github/skills/` at the root of your repository. For a personal skill, use `~/.copilot/skills/`.

2. Create a subdirectory for your skill. Each skill should have its own directory (for example, `.github/skills/github-issues/`).

3. Create a `SKILL.md` file in the skill directory. The file contains YAML frontmatter with metadata followed by Markdown instructions.

4. Optionally, add scripts, examples, or other resources to your skill's directory.

### Skill directory structure

```text
your-repo/
└── .github/
    └── skills/
        └── github-issues/
            ├── SKILL.md          # Required: metadata + instructions
            ├── scripts/          # Optional: executable code
            ├── references/       # Optional: documentation
            └── assets/           # Optional: templates, resources
```

### SKILL.md format

The `SKILL.md` file must contain YAML frontmatter followed by Markdown content:

```markdown
---
name: github-issues
description: Creates and manages GitHub issues following team conventions. Use when working with issue tracking, bug reports, or feature requests.
---

When creating GitHub issues:

- Use the standard title format: [Component] Brief description
- Add appropriate labels based on issue type
- Include reproduction steps for bug reports
- Link related issues and PRs
```

#### Frontmatter properties

| Property | Required | Description |
|----------|----------|-------------|
| `name` | Yes | Lowercase letters, numbers, and hyphens only. Must match the parent directory name. Maximum 64 characters. |
| `description` | Yes | Describes what the skill does and when to use it. Maximum 1,024 characters. |
| `license` | No | License name or reference to a bundled license file. |
| `compatibility` | No | Environment requirements, such as intended product or required system packages. |
| `metadata` | No | Arbitrary key-value mapping for additional metadata. |
| `allowed-tools` | No | Space-separated string of pre-approved tools the skill can use. |

### Tips for writing effective skills

- Keep the main `SKILL.md` under 500 lines. Move detailed reference material to separate files in the `references/` directory.
- Write a clear `description` that includes specific keywords to help agents identify when the skill is relevant.
- Include step-by-step instructions, examples, and common edge cases.

## Manage skills from the skills panel
<!-- Skills panel is in GA in 18.6 -->
Select the **Tools** icon in the bottom-right corner of Copilot Chat to open the skills panel, a dedicated view of every discovered skill. The Skills panel is available only in the Visual Studio 2026 Insiders.

:::image type="content" source="media/visualstudio/skills-panel.png" alt-text="Screenshot that shows the skills panel where you can edit and open skills." lightbox="media/visualstudio/skills-panel.png":::

From the panel, you can:

- **Edit**: Open any skill's `SKILL.md` directly in the editor from the **...** menu.
- **Open file location**: Jump to the skill directory on disk.
- **Search**: Filter skills by name or keyword.

The panel also surfaces diagnostics for any skill configuration errors, so you can quickly spot and fix issues.

<!-- Remove for now. Simona would like to see a dedicated article for this subject 
## Skills vs. custom instructions

You might already use [custom instructions](copilot-chat-context.md#use-custom-instructions) (`.github/copilot-instructions.md`) to guide Copilot's behavior. Custom instructions are great for broad, always-on guidance, such as "use tabs, not spaces" or "prefer async/await over callbacks." They're automatically applied to every interaction with Copilot.

Agent skills are different. Skills are task-specific and dynamically loaded. The model decides when a skill is relevant and applies it only in matching contexts.

| Feature | Custom instructions | Agent skills |
|---|---|---|
| Scope | Always applied to every interaction | Applied only when the model determines relevance |
| Purpose | Broad coding standards and preferences | Task-specific workflows and procedures |
| Format | `.github/copilot-instructions.md` | `SKILL.md` in a skill directory |

Use custom instructions for rules that should always apply. Use skills for specialized workflows that only matter in certain contexts.

You can also extend your agent's capabilities through [MCP tools](mcp-servers.md), which let the agent interact with external services and APIs. Skills and MCP tools complement each other — a skill can describe how to handle a task while an MCP tool provides the capability to execute it.
-->

## Community skills

See the [awesome-copilot repository](https://github.com/github/awesome-copilot) for example skills shared by the community.

## Related content

+ [Get started with GitHub Copilot agent mode](copilot-agent-mode.md)
+ [Use custom agents in GitHub Copilot](copilot-specialized-agents.md)
+ [Customize chat responses and set context](copilot-chat-context.md)
+ [Use MCP servers](mcp-servers.md)
