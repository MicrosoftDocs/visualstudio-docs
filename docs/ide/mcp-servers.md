---
title: Use MCP Servers
description: Learn how to add MCP servers in Visual Studio to extend GitHub Copilot agent capabilities, set up mcp.json, and manage tool permissions.
ms.date: 8/19/2025
ms.update-cycle: 180-days
ms.topic: get-started
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= vs-2022'
---
# Use MCP servers

Model Context Protocol (MCP) is an open standard that enables AI models to interact with external tools and services through a unified interface. In Visual Studio, MCP support enhances GitHub Copilot agent mode by allowing you to connect any MCP-compatible server to your agentic coding workflow.

This article guides you through setting up MCP servers and using tools with agent mode in Visual Studio.

## Prerequisites

- [Visual Studio 2022 version 17.14](/visualstudio/releases/2022/release-history) or later. We highly recommend the latest servicing release of 17.14 because each release adds MCP features.

## How MCP and Visual Studio extend the GitHub Copilot agent

- MCP clients, such as Visual Studio, connect to MCP servers and request actions on behalf of the AI model.
- MCP servers provide one or more tools that expose specific functionalities through a well-defined interface.
- The protocol defines the message format for communication between clients and servers, including tool discovery, invocation, and response handling.

For example, an MCP server for a file system might provide tools for reading, writing, or searching files and directories. [The official GitHub MCP server](https://github.com/github/github-mcp-server) offers tools to list repositories, create pull requests, or manage issues. MCP servers can run locally on your machine or be hosted remotely. Visual Studio supports both configurations.

By standardizing this interaction, MCP eliminates the need for custom integrations between each AI model and each tool. You can then extend your AI assistant's capabilities by simply adding new MCP servers to your workspace. [Learn more about the MCP specification](https://modelcontextprotocol.io/specification/draft).

## Configuration example with a GitHub MCP server

The following walkthrough requires version 17.14.9 or later.

1. Create a new file: `<SOLUTIONDIR>\.mcp.json` or `%USERPROFILE%\.mcp.json`. We recommend that you use Visual Studio to edit this file so that its JSON schema is automatically applied.

2. Paste the following contents into the `.mcp.json` file:

    ```json
    {
      "servers": {
        "github": {
          "url": "https://api.githubcopilot.com/mcp/"
        }
      }
    }
    ```

3. Save the file. Then activate the CodeLens information that appears over the new server to authenticate to this server through a GitHub account.

4. In Visual Studio, select the **Ask** arrow in the GitHub Copilot Chat window, and then select **Agent**.

    :::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-dropdown.png" alt-text="Screenshot that shows Copilot agent mode selector." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-dropdown.png":::

5. Select the tools that you want to use; for example, **List issues**.

    :::image type="content" source="media/vs-2022/mcp-servers/model-context-protocol-github-tools-list.png" alt-text="Screenshot that shows MCP GitHub tools." lightbox="media/vs-2022/mcp-servers/model-context-protocol-github-tools-list.png":::

6. Try a sample prompt: **List issues assigned to me on GitHub**.

7. Copilot asks for permission to use a tool that the MCP server made available to it. Select **Allow** with the scope that you want to proceed with.

    :::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-tool-approval.png" alt-text="Screenshot that shows confirmation options for agent tools." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-tool-approval.png":::

## Supported MCP capabilities

Visual Studio supports the following MCP capabilities:

- The options for MCP server transport are local standard input/output (`stdio`), server-sent events (`sse`), and streamable HTTP (`http`).
- Currently, of the three [primitives](https://modelcontextprotocol.io/specification/2025-03-26#features) (tools, prompts, resources), servers can provide tools only to Copilot agent mode. You can dynamically update the list and the descriptions of tools by using list-changed events.
- Visual Studio provides servers with the current solution folders by using `roots` ([specification](https://modelcontextprotocol.io/docs/concepts/roots)).
- For [MCP authorization](https://modelcontextprotocol.io/specification/draft/basic/authorization), Visual Studio supports authentication for remote servers with any OAuth provider.

## Finding MCP servers

MCP's [official server repository](https://github.com/modelcontextprotocol/servers) is a great starting point for reference, official, and community-contributed servers that showcase the versatility of MCP. You can explore servers for various functionalities, such as file system operations, database interactions, and web services.

MCP is a relatively new standard, and the ecosystem is rapidly evolving. As more developers adopt MCP, you can expect to see an increasing number of servers and tools available for integration with your projects.

## Options for adding an MCP server

You have multiple options to add an MCP server in Visual Studio.

### Install from the web

With the latest servicing release of version 17.14, Visual Studio supports direct installation of MCP servers. You can select the **Install** button on an MCP server to automatically add it to your Visual Studio instance.

</br>
<details>
<summary><strong title="To add a one-click install button for any MCP server in Visual Studio:">Add an Install button for MCP server</strong></summary>

1. Write your MCP server configuration in JSON.

    Here's an HTTP/SSE server example:

    ```json
    {"name":"My Server","type":"http","url":"https://example.com/mcp/"} 
    ```

    Here's an stdio server example:

    ```json
    {"name":"My Server","type":"stdio","command":"python","args":["-m","my_mcp.server"]}
    ```

    Required fields are:

    | Field | Description |
    |-----------|---------------|
    | `name` | Friendly name for your server |
    | `type` | Server connection type, such as `http` or `stdio` |
    | `url` | URL of the server, required for `http`|
    | `command` | Command to start the server executable, required for `stdio` |
    | `args` |Array of arguments passed to the command, required for `stdio` |

2. URL-encode the JSON. You can use an online encoder or your browser console.

   Here's a browser console example:

   ```js
   encodeURIComponent('{"name":"My Server","type":"http","url":"https://example.com/mcp/"}')
   ```

3. Insert the URL-encoded JSON into the MCP URI format to form a Visual Studio installation link. Use this format:

    ```bash
    vsweb+mcp:/install?<ENCODED_JSON>
    ```

4. Add the Markdown badge to your GitHub repository or documents. For example:

    ```markdown
    [![Install MCP Server in Visual Studio](https://img.shields.io/badge/Install%20in%20Visual%20Studio-blue?logo=visualstudio)](vsweb+mcp:/install?<ENCODED_JSON>)
    ```

When a user selects the badge, Visual Studio opens (or prompts you to open it). The MCP installation dialog appears, prefilled with your server details.

<br />
</details>

### Add from chat view

To add an MCP server in Visual Studio:

1. In the chat window, select the green plus (**+**) button in the tool picker.

1. Specify the server name and connection details, such as the URL for HTTP servers or the command and arguments for stdio servers.

  :::image type="content" source="media/vs-2022/mcp-servers/configure-server-visual-studio.png" alt-text="Screenshot that shows adding an MCP server from chat view." lightbox="media/vs-2022/mcp-servers/configure-server-visual-studio.png":::

### Create a file to manage configuration of MCP servers

If you don't already have an `mcp.json` file, create one in any of the supported locations based on your repository, user, or editor requirements.

To add an MCP server, locate the server's JSON configuration online. For example, find it in the GitHub repository for MCP servers. Then paste it into your `mcp.json` file.

## File locations for automatic discovery of MCP configuration

Visual Studio also checks for MCP configurations that other development environments set up. MCP server configurations are read from the following directories, in the following order:

1. `%USERPROFILE%\.mcp.json` </br>
    Serves as a global MCP server configuration for a specific user. Adding an MCP server here would make it load for all Visual Studio solutions.
2. `<SOLUTIONDIR>\.vs\mcp.json` </br>
    Specific to Visual Studio and loads the specified MCP servers only for a specific user, for the specified solution.
3. `<SOLUTIONDIR>\.mcp.json` </br>
    Works well if you're looking for an MCP configuration that you can track in source control for a repository.
4. `<SOLUTIONDIR>\.vscode\mcp.json` </br>
    Scoped to the repository/solution and typically not source controlled.
5. `<SOLUTIONDIR>\.cursor\mcp.json` </br>
    Scoped to the repository/solution and typically not source controlled.

Some of these locations require `.mcp.json`, whereas others require `mcp.json`.

## MCP configuration format

You can define both *remote* (URL and credentials) and *local* (command-line invocation) servers.

It's common to invoke tools via package managers; for example, `npx -y @azure/mcp@latest` or `docker run ... mcp/github`. Visual Studio respects whatever command you specify, so you can pin versions or pass flags as needed.

The format must follow the MCP specification. For example, it must include an array of server objects, each with `name`, `command` or `url`, and `transport`.

### Editing MCP configuration

With an existing `mcp.json` file, add the file location to **Solution Items** in Solution Explorer, if you're checking the file into your version control system.

When the file is saved with valid syntax, the GitHub Copilot agent restarts and reloads the configured servers.

:::image type="content" source="media/vs-2022/mcp-servers/model-context-protocol-add-solution-item.png" alt-text="Screenshot that shows adding the MCP configuration file location to Solution Items." lightbox="media/vs-2022/mcp-servers/model-context-protocol-add-solution-item.png":::

### Tool lifecycle

As soon as a server is discovered or added:

- Visual Studio initializes the server by performing a handshake and querying the tool list.
- Visual Studio subscribes to the MCP event `notifications/tools/list_changed`.
- When that event fires, Visual Studio resets any prior acceptances or permissions on tools (to prevent *rug-pull* attacks), re-fetches the tool list, and updates the count/UI live.
- When the server is successfully enabled, tools are made available to the agent. The tools are disabled by default and must be manually enabled.
- If a server is removed, Visual Studio immediately stops its process and withdraws all its tools from the UI.
- If you edit a server definition, Visual Studio terminates and restarts it, and then re-queries.

### Management of tool approvals

When a tool is invoked, Copilot requests confirmation to run the tool. The reason is that tools might run locally on your machine and perform actions that modify files or data.

After a tool invocation, on the chat pane, use the **Allow** dropdown options. You can automatically confirm the specific tool for the current session, the current solution, or all future invocations.

:::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-tool-approval.png" alt-text="Screenshot that shows managing agent tool approvals." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-tool-approval.png":::

You can reset tool confirmation selections in **Tools** > **Options** > **GitHub** > **Copilot** > **Tools**.

:::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-tool-config.png" alt-text="Screenshot that shows tool configuration settings." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-tool-config.png":::

## Manage authorization

Visual Studio now supports authentication for remote servers with any OAuth provider, in accordance with the [MCP authorization specification](https://modelcontextprotocol.io/specification/draft/basic/authorization). This support is in addition to integration with the Visual Studio keychain.

To manage authentication for an MCP server:

1. In the `.mcp.json` file, select **Manage Authentication** for that server from CodeLens.

1. Provide credentials for the necessary OAuth provider for that server in the browser pop-up.

## Frequently asked questions

### As an administrator, how do I control use of MCP servers in agent mode for Visual Studio users?

The GitHub policy settings on the GitHub Copilot dashboard for administrators govern agent mode and MCP usage in Visual Studio. If the administrator turns off this setting, users under that subscription can't use agent mode or connect to MCP servers in Visual Studio.

For more information, see [Managing policies and features for GitHub Copilot in your enterprise](https://docs.github.com/en/enterprise-cloud@latest/copilot/managing-copilot/managing-copilot-for-your-enterprise/managing-policies-and-features-for-copilot-in-your-enterprise#editor-preview-features).

## Related content

- [Use Copilot agent mode](copilot-agent-mode.md)
- [What is the GitHub Copilot Chat experience for Visual Studio?](visual-studio-github-copilot-chat.md)
- [GitHub Copilot Free](https://aka.ms/ghdocscopilotfreepage#github-copilot-free)
