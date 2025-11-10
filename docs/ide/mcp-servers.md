---
title: Use MCP Servers
description: Learn how to add MCP servers in Visual Studio to extend GitHub Copilot agent capabilities, set up mcp.json, and manage tool permissions.
ms.date: 11/10/2025
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

MCP support in Visual Studio works as follows:

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

    :::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-dropdown.png" alt-text="Screenshot that shows the Copilot agent mode selector." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-dropdown.png":::

5. Select the tools that you want to use; for example, **List issues**.

    :::image type="content" source="media/vs-2022/mcp-servers/model-context-protocol-github-tools-list.png" alt-text="Screenshot that shows MCP GitHub tools." lightbox="media/vs-2022/mcp-servers/model-context-protocol-github-tools-list.png":::

6. Try a sample prompt: **List issues assigned to me on GitHub**.

7. Copilot asks for permission to use a tool that the MCP server made available to it. Select **Allow** with the scope that you want to proceed with.

    :::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-tool-approval.png" alt-text="Screenshot that shows confirmation options for agent tools." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-tool-approval.png":::

## Supported MCP capabilities

Visual Studio supports the following MCP capabilities:

- The options for MCP server transport are local standard input/output (`stdio`), server-sent events (`sse`), and streamable HTTP (`http`).
- Of the [features](https://modelcontextprotocol.io/specification/2025-03-26#features) (tools, prompts, resources, sampling), Visual Studio now supports:
  - **Tools**: Execute actions and operations through Copilot agent mode
  - **Prompts**: Reusable prompt templates that you can invoke with parameters
  - **Resources**: Access external data and context through URI-based resources
  - **Sampling**: Enhanced AI model interactions with your tools and services
- Visual Studio provides servers with the current solution folders by using `roots` ([specification](https://modelcontextprotocol.io/docs/concepts/roots)).
- For [MCP authorization](https://modelcontextprotocol.io/specification/draft/basic/authorization), Visual Studio supports authentication for remote servers with any OAuth provider.

## Finding MCP servers

The [official MCP server repository](https://github.com/modelcontextprotocol/servers) is a great starting point for reference, official, and community-contributed servers that showcase the versatility of MCP. You can explore servers for various functionalities, such as file system operations, database interactions, and web services.

MCP is a relatively new standard, and the ecosystem is rapidly evolving. As more developers adopt MCP, you can expect to see an increasing number of servers and tools available for integration with your projects.

### Try popular MCP servers with one-click installation

Try out some other popular MCP servers in Visual Studio with one-click:

- [![Install in Visual Studio](https://img.shields.io/badge/Install%20in%20Visual%20Studio-blue?logo=visualstudio)](vsweb+mcp:/install) – Discover and install custom prompts and instructions for GitHub Copilot.
- [![Install in Visual Studio](https://img.shields.io/badge/Install%20in%20Visual%20Studio-blue?logo=visualstudio)](vsweb+mcp:/install) – Convert various file formats (PDF, Word, Excel, images, audio) to Markdown.
- [![Install in Visual Studio](https://img.shields.io/badge/Install%20in%20Visual%20Studio-blue?logo=visualstudio)](vsweb+mcp:/install) – Query and analyze data in DuckDB databases locally and in the cloud.
- [![Install in Visual Studio](https://img.shields.io/badge/Install%20in%20Visual%20Studio-blue?logo=visualstudio)](vsweb+mcp:/install) – Database operations and management. Execute queries, manage collections, aggregation pipelines, and document operations.
- [![Install in Visual Studio](https://img.shields.io/badge/Install%20in%20Visual%20Studio-blue?logo=visualstudio)](vsweb+mcp:/install) – Access models, datasets, and Spaces on the Hugging Face Hub.

## Options for adding an MCP server

You have multiple options to add an MCP server in Visual Studio.

### Install from the web

With the latest servicing release of version 17.14, Visual Studio supports direct installation of MCP servers. You can select the **Install** button on an MCP server to automatically add it to your Visual Studio instance.

</br>
<details>
<summary><strong title="To add a one-click install button for any MCP server in Visual Studio:">Add an Install button for an MCP server</strong></summary>

1. Write your MCP server configuration in JSON.

    Here's an HTTP/SSE server example:

    ```json
    {"name":"My Server","type":"http","url":"https://example.com/mcp/"} 
    ```

    Here's a stdio server example:

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

With Visual Studio version 17.14.13 or later, you can add an MCP Server from the chat view in Visual Studio.

To add an MCP server from chat view:

1. Select the green plus (`+`) button in the tool picker in the chat window.

   :::image type="content" source="media/vs-2022/mcp-servers/plus-button-add-mcp.png" alt-text="Screenshot the plus button in tool picker of Visual Studio chat to add MCP server." lightbox="media/vs-2022/mcp-servers/configure-server-visual-studio.png":::

1. Specify the server name and connection details, such as the URL for HTTP servers or the command and arguments for stdio servers.

   :::image type="content" source="media/vs-2022/mcp-servers/configure-server-visual-studio.png" alt-text="Screenshot that shows adding an MCP server from the chat view." lightbox="media/vs-2022/mcp-servers/configure-server-visual-studio.png":::

### Create a file to manage configuration of MCP servers

If you don't already have an `mcp.json` file, create one in any of the supported locations based on your repository, user, or editor requirements.

To add an MCP server, locate the server's JSON configuration online. For example, find it in the GitHub repository for MCP servers. Then paste it into your `mcp.json` file.

## File locations for automatic discovery of MCP configuration

Visual Studio also checks for MCP configurations that other development environments set up. MCP server configurations are read from the following directories, in the following order:

1. `%USERPROFILE%\.mcp.json` </br>
    Serves as a global MCP server configuration for a specific user. Adding an MCP server here makes it load for all Visual Studio solutions.
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
- When the server is successfully enabled, tools become available to the agent. The tools are disabled by default and must be manually enabled.
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

1. Provide credentials for the necessary OAuth provider for that server in the browser pop-up dialog.


## MCP prompts and prompt templates

MCP prompts allow servers to provide structured messages and instructions for interacting with language models. These prompts cater to the use case and content of the server, so you get the best responses for a certain task.

### Use MCP prompts

Visual Studio allows you to discover available prompts, retrieve their contents, and provide arguments to customize them. To reference any prompts that may come from an MCP server:

1. Select the **+ Add Reference** button in chat.
1. Select the **Prompts** option.
1. Choose **MCP prompts** from the flyout.
1. Select the prompt you'd like to use, then select **Insert Prompt** to include the text from this prompt in chat.

### Prompt templates with custom arguments

Some MCP prompts have arguments that you can fill in to customize the prompt for your specific needs. These prompts are known as prompt templates. If you select a prompt in the dialog that contains arguments, you can specify those values before inserting the prompt into chat.

### Example: GitHub integration

Imagine you're working on code reviews and want to leverage GitHub's specialized prompts. With the GitHub MCP server, you can access prompts specifically designed for analyzing pull requests, generating commit messages, or reviewing code changes. These prompts understand GitHub's context and can provide more targeted assistance than generic prompts.

[![Install in Visual Studio](https://img.shields.io/badge/Install%20in%20Visual%20Studio-blue?logo=visualstudio)](vsweb+mcp:/install?%7B%22name%22%3A%22github%22%2C%22url%22%3A%22https%3A%2F%2Fapi.githubcopilot.com%2Fmcp%2F%22%7D)

## MCP resources and resource templates

Model Context Protocol provides a standardized way for servers to expose resources to clients. Resources allow servers to share data that provides context to language models, such as files, database schemas, or application-specific information. Each resource is uniquely identified by a URI, enabling you to pull in context directly in the IDE.

### Use MCP resources

To use any MCP resources available to you, reference them in Copilot chat with a hashtag (`#`) followed by the resource URI.

### Resource templates for dynamic content

MCP resources can have arguments that you fill in to customize the resource for your specific needs. These resources are called resource templates. To configure them:

1. Use the **+ Add Reference** button in chat.
1. Select the **MCP resources** option from the menu.
1. Choose your resource template and fill in any required arguments.
1. Select **Add Resource** to make this MCP resource referenceable in chat.

### Example: Azure DevOps work items

When working with Azure DevOps, you can now reference work items, user stories, and project data directly in your chat conversations. The Azure DevOps MCP server exposes resources like work item templates, sprint information, and team capacity data that Copilot can use to provide more contextual suggestions about your project planning and development tasks.

[![Install in Visual Studio](https://img.shields.io/badge/Install%20in%20Visual%20Studio-blue?logo=visualstudio)](vsweb+mcp:/install?%7B%22name%22%3A%22Azure%20DevOps%22%2C%22type%22%3A%22http%22%2C%22url%22%3A%22https%3A%2F%2Fapi.githubcopilot.com%2Fmcp%2Fazure-devops%22%7D)

### Example: Figma design context

For teams working closely with design systems, the Figma MCP server lets you reference design components, style guides, and design specifications directly in your development conversations. This feature bridges the gap between design and development by making design context readily available to Copilot.

[![Install in Visual Studio](https://img.shields.io/badge/Install%20in%20Visual%20Studio-blue?logo=visualstudio)](vsweb+mcp:/install?%7B%22name%22%3A%22figma%22%2C%22gallery%22%3Atrue%2C%22url%22%3A%22http%3A%2F%2F127.0.0.1%3A3845%2Fmcp%22%7D)

## MCP sampling

Sampling in MCP lets servers implement agentic behaviors by enabling LLM calls to occur nested inside other MCP server features. This powerful feature allows an MCP server to make requests of an LLM, rather than the typical workflow of an LLM requesting content from an MCP server. Visual Studio now supports this advanced capability, allowing your MCP servers to perform more complex, multistep tasks on your behalf.

### How sampling works

You don't need to configure anything to take advantage of sampling. As long as your MCP server supports it, Visual Studio supports it too. When Copilot determines that a request would benefit from a sampling call, you see a dialog containing all details of the request. You confirm the sampling call before anything happens behind the scenes. This process ensures you maintain full control over any automated actions.

### Example: Playwright testing scenarios

The Playwright MCP server can use sampling to automatically generate comprehensive test scenarios based on your application's current state. When you ask for help with testing, it might sample your application's DOM structure, analyze user flows, and then generate targeted test scripts that cover critical user paths - all through intelligent sampling calls that you approve.

[![Install in Visual Studio](https://img.shields.io/badge/Install%20in%20Visual%20Studio-blue?logo=visualstudio)](vsweb+mcp:/install?%7B%22name%22%3A%22playwright%22%2C%22gallery%22%3Atrue%7D)

## Frequently asked questions

### As an administrator, how do I control use of MCP servers in agent mode for Visual Studio users?

The GitHub policy settings on the GitHub Copilot dashboard for administrators govern agent mode and MCP usage in Visual Studio. If the administrator turns off this setting, users under that subscription can't use agent mode or connect to MCP servers in Visual Studio.

For more information, see [Managing policies and features for GitHub Copilot in your enterprise](https://docs.github.com/en/enterprise-cloud@latest/copilot/managing-copilot/managing-copilot-for-your-enterprise/managing-policies-and-features-for-copilot-in-your-enterprise#editor-preview-features).

## Related content

- [GitHub Copilot agent mode](copilot-agent-mode.md)
- [GitHub Copilot Chat experience for Visual Studio](visual-studio-github-copilot-chat.md)
- [GitHub Copilot Free](https://aka.ms/ghdocscopilotfreepage#github-copilot-free)
