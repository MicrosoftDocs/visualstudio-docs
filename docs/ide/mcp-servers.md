---
title: 'Use MCP servers (Preview)'
description: Adding MCP servers in Visual Studio to extend GitHub Copilot agent capabilities, setting up mcp.json and managing tool permissions.
ms.date: 5/13/2025
ms.topic: overview
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= vs-2022'
---
# What is MCP?

Model Context Protocol (MCP) is an open standard that enables AI models to interact with external tools and services through a unified interface. In Visual Studio, MCP support enhances GitHub Copilot's agent mode by allowing you to connect any MCP-compatible server to your agentic coding workflow. This article guides you through setting up MCP servers and using tools with agent mode in Visual Studio.

## Prerequisites
+ [Visual Studio 2022 version 17.14](/visualstudio/releases/2022/release-history) and later include Copilot Agent.
    + Set **Enable agent mode in the chat pane** in **Tools** > **Options** > **GitHub** > **Copilot**.
+ [Sign in to Visual Studio using a GitHub account](work-with-github-accounts.md) with [Copilot access](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot). <br/>
    + You can use [GitHub Copilot for Free](copilot-free-plan.md). Sign up and leverage AI to code faster and more efficiently.

## How do MCP and Visual Studio extend GitHub Copilot's agent?

* MCP clients, such as Visual Studio connect to MCP servers and request actions on behalf of the AI model
* MCP servers provide one or more tools that expose specific functionalities through a well-defined interface.
* The Model Context Protocol (MCP) defines the message format for communication between clients and servers, including tool discovery, invocation, and response handling

For example, a file system MCP server might provide tools for reading, writing, or searching files and directories. [GitHub's official MCP server](https://github.com/github/github-mcp-server) offers tools to list repositories, create pull requests, or manage issues. MCP servers can run locally on your machine or be hosted remotely, and Visual Studio supports both configurations.

By standardizing this interaction, MCP eliminates the need for custom integrations between each AI model and each tool. This allows you to extend your AI assistant's capabilities by simply adding new MCP servers to your workspace. Learn more about the Model Context Protocol specification.

# Quick Start
## Configuration example with GitHub MCP server

1. Create a new file: `<SOLUTIONDIR>\mcp.json`. Using Visual Studio to edit this file is recommended so its JSON schema is automatically applied.
2. Paste the following contents into the `.mcp.json` file

```json
{
  "inputs": [
    {
      "id": "github_pat",
      "description": "GitHub personal access token",
      "type": "promptString",
      "password": true
    }
  ],
  "servers": {
    "github": {
      "type": "stdio",
      "command": "docker",
      "args": [
        "run",
        "-i",
        "--rm",
        "-e",
        "GITHUB_PERSONAL_ACCESS_TOKEN",
        "ghcr.io/github/github-mcp-server"
      ],
      "env": {
        "GITHUB_PERSONAL_ACCESS_TOKEN": "${input:github_pat}"
      }
    }
  }
}
```

3. Get a Personal Access Token for your [GitHub Account](https://github.com/settings/personal-access-tokens)
4. Launch Visual Studio, open the GitHub Copilot window, then click the dropdown that says `Ask`, then select `Agent`.

  ![Copilot Agent Mode Selector](/media/vs-2022/copilot-agent/copilotagent-dropdown.png)
5. When prompted, paste your personal access token into the dialogue.

  ![Personal Access Token Dialogue](/media/vs-2022/copilot-agent-mcp/mcp-PAT.png)

6. Select the tools you'd like to use: for example, `list_issues`

  ![Personal Access Token Dialogue](/media/vs-2022/copilot-agent-mcp/mcp-github-tools.png)

7. Try a sample prompt: `list issues assigned to me on GitHub`
8. Copilot will ask for permission to use a tool made available to it by the MCP server, click "Allow" with the scope you wish to proceed with.

  ![Personal Access Token Dialogue](/media/vs-2022/copilot-agent/copilot-agent-tool-approval.png)

# Additional details

## Supported MCP capabilities

Visual Studio supports local standard input/output (`stdio`), server-sent events (`sse`), and streamable HTTP (`http`) for MCP server transport. Currently of the three [primitives](https://modelcontextprotocol.io/specification/2025-03-26#features) (tools, prompts, resources), servers can only provide tools to Copilot's agent mode. The list and descriptions of tools can be updated dynamically using list changed events. Visual Studio provides servers with the current solution folders using `roots` [(spec)](https://modelcontextprotocol.io/docs/concepts/roots).

## Finding MCP servers

MCP's [official server repository](https://github.com/modelcontextprotocol/servers) is a great starting point for reference, official, and community-contributed servers that showcase MCP's versatility. You can explore servers for various functionalities, such as file system operations, database interactions, and web services.

MCP is still a relatively new standard, and the ecosystem is rapidly evolving. As more developers adopt MCP, you can expect to see an increasing number of servers and tools available for integration with your projects.

## Adding an MCP server

### Create a file to manage configuration of MCP servers

If you do not already have an `mcp.json` file, you can create it in various locations depending on the repos, users, and IDEs you would like the servers to be available/used for.

### File locations for automatic discovery of MCP configuration

Visual Studio looks for MCP server configurations in the following directories, in the following order:

1.  `%USERPROFILE%\.mcp.json` serves as a global MCP server configuration for a specific user. Adding an MCP server here would make it load for all Visual Studio solutions. 
2.  `<SOLUTIONDIR>\.vs\mcp.json` is specific to Visual Studio and only loads the specified MCP servers for a specific user, for the specified solution.

If you are looking for an MCP configuration that you can track in source control for a repo, this option would work well:

3.  `<SOLUTIONDIR>\.mcp.json`

Visual Studio will also check for MCP configurations set up by other development environments. These are scoped to the repository/solution and are typically not source controlled.

4.  `<SOLUTIONDIR>\.vscode\mcp.json`
5.  `<SOLUTIONDIR>\.cursor\mcp.json`

Note that some of these locations require `.mcp.json` while others require `mcp.json`.

### MCP configuration format

You may define both **remote** (URL + credentials) and **local** (command-line invocation).

It’s common to invoke tools via package managers (e.g. `pip install … && mcp-server or npx @cursor/mcp`) - Visual Studio will respect whatever command you specify so you can pin versions or flags.

Format must follow the MCP spec (e.g. array of server objects, each with `name`, `command` or `url`, `transport`, etc.).

### Editing MCP configuration

With an existing `mcp.json` file, add the file location to the Solution Items in Solution Explorer, if you'll be checking the file into your version control system.

When the file is saved with valid syntax, GitHub Copilot's agent will restart and reload the configured servers.

![Copilot Agent Settings](/media/vs-2022/copilot-agent-mcp/mcp-add-solution-item.png)

### Tool Lifecycle

As soon as a server is discovered or added, Visual Studio initializes it (handshake + tool list).

Visual Studio subscribes to the MCP event `notifications/tools/list_changed`.

When that event fires, Visual Studio resets any prior acceptances/permissions on tools (to prevent “rug-pull” attacks), re-fetches the tool list, and updates the count/UI live.

When the server is successfully enabled, tools are made available to the Agent. The tools are disabled by default and must be manually enabled.

If a server is removed, Visual Studio immediately kills its process and withdraws all its tools from the UI.

If you edit a server definition, VS will terminate and relaunch it, then re-query.

### Manage tool approvals

When a tool is invoked, Copilot requests confirmation to run the tool. This is because tools might run locally on your machine and perform actions that modify files or data.

![Personal Access Token Dialogue](/media/vs-2022/copilot-agent/copilot-agent-tool-approval.png)

In the Chat view, after a tool invocation, use the Allow button dropdown options to automatically confirm the specific tool for the current session, solution, or all future invocations.

You can reset tool confirmation selections in Tools > Options > GitHub > Copilot > Tools.

![Copilot Agent Command Approval](/media/vs-2022/copilot-agent/copilot-agent-tool-config.png)

## Frequently Asked Questions

### As an administrator, how do I control use of MCP servers in Agent mode for Visual Studio users?

Agent mode and MCP usage in Visual Studio 2022 is governed by the "Editor preview features" flag in the GitHub Copilot dashboard for administrator.

If this setting is disabled by the GitHub Copilot subscription administrator, Copilot users under the subscription will not have access to Agent mode nor MCP servers in Visual Studio.

## Related content

- [GitHub Copilot agent mode](copilot-agent-mode.md)
- [GitHub Copilot Chat experience for Visual Studio](visual-studio-github-copilot-chat.md)
- [About GitHub Copilot Free](https://aka.ms/ghdocscopilotfreepage)
