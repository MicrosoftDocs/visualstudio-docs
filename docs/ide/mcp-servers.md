---
title: 'Use MCP servers (Preview)'
description: Adding MCP servers in Visual Studio to extend GitHub Copilot agent capabilities, setting up mcp.json and managing tool permissions.
ms.date: 6/18/2025
ms.topic: get-started
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= vs-2022'
---
# Use MCP servers (Preview)

Model Context Protocol (MCP) is an open standard that enables AI models to interact with external tools and services through a unified interface. In Visual Studio, MCP support enhances GitHub Copilot's agent mode by allowing you to connect any MCP-compatible server to your agentic coding workflow. This article guides you through setting up MCP servers and using tools with agent mode in Visual Studio.

## Prerequisites
+ [Visual Studio 2022 version 17.14](/visualstudio/releases/2022/release-history) or later. The latest servicing release of 17.14 is highly recommended as MCP features are actively being added with each release.

## How do MCP and Visual Studio extend GitHub Copilot's agent?

* MCP clients, such as Visual Studio connect to MCP servers and request actions on behalf of the AI model
* MCP servers provide one or more tools that expose specific functionalities through a well-defined interface.
* The Model Context Protocol (MCP) defines the message format for communication between clients and servers, including tool discovery, invocation, and response handling

For example, a file system MCP server might provide tools for reading, writing, or searching files and directories. [GitHub's official MCP server](https://github.com/github/github-mcp-server) offers tools to list repositories, create pull requests, or manage issues. MCP servers can run locally on your machine or be hosted remotely, and Visual Studio supports both configurations.

By standardizing this interaction, MCP eliminates the need for custom integrations between each AI model and each tool. This allows you to extend your AI assistant's capabilities by simply adding new MCP servers to your workspace. Learn more about the Model Context Protocol specification.

## Configuration example with GitHub MCP server

The following walkthrough requires 17.14.9 or later.

1. Create a new file: `<SOLUTIONDIR>\.mcp.json` or `%USERPROFILE%\.mcp.json`. Using Visual Studio to edit this file is recommended so its JSON schema is automatically applied.
2. Paste the following contents into the `.mcp.json` file

  ```json
  {
    "servers": {
      "github": {
        "url": "https://api.githubcopilot.com/mcp/"
      }
    }
  }
  ```

3. Save the file, then activate the CodeLens that appears over the new server to authenticate to this server using a GitHub account.

5. In Visual Studio, click the `Ask` dropdown in the GitHub Copilot Chat window, and then select `Agent`.

    :::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-dropdown.png" alt-text="Screenshot that shows Copilot agent mode selector." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-dropdown.png":::

7. Select the tools you'd like to use, for example, `list_issues`

    :::image type="content" source="media/vs-2022/mcp-servers/model-context-protocol-github-tools-list.png" alt-text="Screenshot that shows MCP GitHub tools." lightbox="media/vs-2022/mcp-servers/model-context-protocol-github-tools-list.png":::

8. Try a sample prompt: `list issues assigned to me on GitHub`
9. Copilot asks for permission to use a tool made available to it by the MCP server, select **Allow** with the scope you wish to proceed with.

    :::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-tool-approval.png" alt-text="Screenshot that shows the agent tools confirmation options." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-tool-approval.png":::

## Supported MCP capabilities

Visual Studio supports local standard input/output (`stdio`), server-sent events (`sse`), and streamable HTTP (`http`) for MCP server transport. Currently of the three [primitives](https://modelcontextprotocol.io/specification/2025-03-26#features) (tools, prompts, resources), servers can only provide tools to Copilot's agent mode. The list and descriptions of tools can be updated dynamically using list changed events. Visual Studio provides servers with the current solution folders using `roots` [(spec)](https://modelcontextprotocol.io/docs/concepts/roots).

## Finding MCP servers

MCP's [official server repository](https://github.com/modelcontextprotocol/servers) is a great starting point for reference, official, and community-contributed servers that showcase MCP's versatility. You can explore servers for various functionalities, such as file system operations, database interactions, and web services.

MCP is still a relatively new standard, and the ecosystem is rapidly evolving. As more developers adopt MCP, you can expect to see an increasing number of servers and tools available for integration with your projects.

## Adding an MCP server

### Create a file to manage configuration of MCP servers

If you do not already have an `mcp.json` file, you can create it in various locations depending on the repos, users, and IDEs you would like the servers to be available/used for.

### File locations for automatic discovery of MCP configuration

Visual Studio also checks for MCP configurations set up by other development environments.
MCP server configurations are read from the following directories, in the following order:

1.  `%USERPROFILE%\.mcp.json` </br>
    Serves as a global MCP server configuration for a specific user. Adding an MCP server here would make it load for all Visual Studio solutions. 
2.  `<SOLUTIONDIR>\.vs\mcp.json` </br>
    Specific to Visual Studio and only loads the specified MCP servers for a specific user, for the specified solution.
3.  `<SOLUTIONDIR>\.mcp.json` </br>
    Works well if you're looking for an MCP configuration that you can track in source control for a repo.
4.  `<SOLUTIONDIR>\.vscode\mcp.json` </br>
    Scoped to the repository/solution and typically not source controlled.
5.  `<SOLUTIONDIR>\.cursor\mcp.json` </br>
    Scoped to the repository/solution and typically not source controlled.

Some of these locations require `.mcp.json` while others require `mcp.json`.

### MCP configuration format

You may define both **remote** (URL and credentials) and **local** (command-line invocation) servers.

It’s common to invoke tools via package managers. For example, `npx -y @azure/mcp@latest` or `docker run ... mcp/github`. Visual Studio respects whatever command you specify, allowing you to pin versions or pass flags as needed.

Format must follow the MCP specification, for example, an array of server objects, each with `name`, `command` or `url`, `transport`, etc.

### Editing MCP configuration

With an existing `mcp.json` file, add the file location to **Solution Items** in Solution Explorer, if you're checking the file into your version control system.

When the file is saved with valid syntax, GitHub Copilot's agent restarts and reloads the configured servers.

:::image type="content" source="media/vs-2022/mcp-servers/model-context-protocol-add-solution-item.png" alt-text="Screenshot that shows adding the MCP configuration file location to Solution Items." lightbox="media/vs-2022/mcp-servers/model-context-protocol-add-solution-item.png":::

### Tool Lifecycle

As soon as a server is discovered or added:

* Visual Studio initializes the server (performs a handshake and queries the tool list).
* Visual Studio subscribes to the MCP event `notifications/tools/list_changed`.
* When that event fires, Visual Studio resets any prior acceptances or permissions on tools (to prevent *rug-pull* attacks), re-fetches the tool list, and updates the count/UI live.
* When the server is successfully enabled, tools are made available to the Agent. The tools are disabled by default and must be manually enabled.
* If a server is removed, Visual Studio immediately kills its process and withdraws all its tools from the UI.
* If you edit a server definition, Visual Studio terminates and relaunches it, and then re-queries.

### Manage tool approvals

When a tool is invoked, Copilot requests confirmation to run the tool. This is because tools might run locally on your machine and perform actions that modify files or data.

In the chat pane, after a tool invocation, use the **Allow** dropdown options to automatically confirm the specific tool for the current session, solution, or all future invocations.

:::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-tool-approval.png" alt-text="Screenshot that shows managing agent tool approvals." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-tool-approval.png":::

You can reset tool confirmation selections in **Tools** > **Options** > **GitHub** > **Copilot** > **Tools**.

:::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-tool-config.png" alt-text="Screenshot that shows the tools configuration setting." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-tool-config.png":::

## Frequently asked questions

#### As an administrator, how do I control use of MCP servers in agent mode for Visual Studio users?

Agent mode and MCP usage in Visual Studio are governed by the **Editor preview features** flag in the GitHub Copilot dashboard for administrators.
If the administrator turns off this setting, users under that subscription won’t be able to use agent mode or connect to MCP servers in Visual Studio.

For more information, see [managing policies and features for copilot in your enterprise](https://docs.github.com/en/enterprise-cloud@latest/copilot/managing-copilot/managing-copilot-for-your-enterprise/managing-policies-and-features-for-copilot-in-your-enterprise#editor-preview-features).

## Related content

- [GitHub Copilot agent mode](copilot-agent-mode.md)
- [GitHub Copilot Chat experience for Visual Studio](visual-studio-github-copilot-chat.md)
- [About GitHub Copilot Free](https://aka.ms/ghdocscopilotfreepage)
