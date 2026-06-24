---
title: Use MCP Servers to Extend GitHub Copilot
description: Learn how to add MCP servers in Visual Studio, configure mcp.json, and manage tool permissions to extend GitHub Copilot agents. Get started.
ms.date: 05/26/2026
ms.update-cycle: 180-days
ms.topic: get-started
author: RoseHJM
ms.author: rosemalcolm
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
ms.custom: awp-ai
ai-usage: ai-assisted

---

# Use MCP servers in Visual Studio

MCP servers use the open Model Context Protocol (MCP) to let GitHub Copilot use tools and services outside the IDE. In Visual Studio, you can add MCP servers to extend agent capabilities for tasks such as file access, repo management, and pull request creation.

MCP support enhances GitHub Copilot agent mode by allowing you to connect any MCP-compatible server to your agentic coding workflow. MCP support in Visual Studio works as follows:

- MCP clients, such as Visual Studio, connect to MCP servers and request actions on behalf of the AI model.
- MCP servers provide one or more tools that expose specific functionalities through a well-defined interface.
- The protocol defines the message format for communication between clients and servers, including tool discovery, invocation, and response handling.

For example, with the GitHub MCP server enabled, you can have copilot create and manage PRs or let you know if there are PRs that need your review. With the Azure DevOps MCP server enabled, you can have Copilot create and manage work items. 

This article guides you through setting up MCP servers and using tools with agent mode in Visual Studio.

## Prerequisites

[Visual Studio 2026](/visualstudio/releases/2026/release-notes)
Or
[Visual Studio 2022](/visualstudio/releases/2022/release-history) version 17.14 (with the latest servicing release recommended for the most up-to-date MCP features)

## Find MCP servers

The [official MCP server repository](https://github.com/modelcontextprotocol/servers) is a great starting point for reference, official, and community-contributed servers that showcase the versatility of MCP. You can explore servers for various functionalities, such as file system operations, database interactions, and web services.

MCP is a relatively new standard, and the ecosystem is rapidly evolving. As more developers adopt MCP, you can expect to see an increasing number of servers and tools available for integration with your projects.

## Add an MCP server

You have multiple options to add an MCP server in Visual Studio.

### Add an MCP server directly from the web

Starting with the latest servicing release of version 17.14, you can add an MCP server by installing it directly from the web. Select the **Install** button on an MCP server to automatically install it and add it to your Visual Studio instance.

**Example MCP servers**

Try out some popular MCP servers in Visual Studio with one-click:

- [![Install Awesome MCP in Visual Studio](https://img.shields.io/badge/Visual_Studio-Install_Awesome_MCP-purple?style=flat-square&logo=visualstudio&logoColor=white)](https://vs-open.link/mcp-install?%7B%22name%22%3A%22Awesome%20Copilot%22%2C%22type%22%3A%22stdio%22%2C%22command%22%3A%22docker%22%2C%22args%22%3A%5B%22run%22%2C%22-i%22%2C%22--rm%22%2C%22ghcr.io%2Fmicrosoft%2Fmcp-dotnet-samples%2Fawesome-copilot%3Alatest%22%5D%7D) – Discover and install custom prompts and instructions for GitHub Copilot.
- [![Install MarkItDown MCP in Visual Studio](https://img.shields.io/badge/Visual_Studio-Install_MarkItDown_MCP-purple?style=flat-square&logo=visualstudio&logoColor=white)](https://vs-open.link/mcp-install?%7B%22name%22%3A%22markitdown%22%2C%22gallery%22%3Atrue%2C%22command%22%3A%22uvx%22%2C%22args%22%3A%5B%22markitdown-mcp%22%5D%7D) – Convert various file formats (PDF, Word, Excel, images, audio) to Markdown.
- [![Install DuckDB Server in Visual Studio](https://img.shields.io/badge/Visual_Studio-Install_DuckDB_Server-purple?style=flat-square&logo=visualstudio&logoColor=white)](https://vs-open.link/mcp-install?%7B%22name%22%3A%22duckdb%22%2C%22gallery%22%3Atrue%2C%22inputs%22%3A%5B%7B%22id%22%3A%22duckdb_db_path%22%2C%22type%22%3A%22promptString%22%2C%22description%22%3A%22Path%20to%20the%20DuckDB%20database%20file%20(e.g.%2C%20%2Fpath%2Fto%2Fdatabase.duckdb)%22%2C%22password%22%3Afalse%7D%5D%2C%22command%22%3A%22uvx%22%2C%22args%22%3A%5B%22mcp-server-duckdb%22%2C%22--db-path%22%2C%22%24%7Binput%3Aduckdb_db_path%7D%22%5D%7D) – Query and analyze data in DuckDB databases locally and in the cloud.
- [![Install MongoDB MCP in Visual Studio](https://img.shields.io/badge/Visual_Studio-Install_MongoDB_MCP-purple?style=flat-square&logo=visualstudio&logoColor=white)](https://vs-open.link/mcp-install?%7B%22name%22%3A%22mongodb%22%2C%22gallery%22%3Atrue%2C%22command%22%3A%22npx%22%2C%22args%22%3A%5B%22-y%22%2C%22mongodb-mcp-server%22%5D%7D) – Database operations and management. Execute queries, manage collections, aggregation pipelines, and document operations.
- [![Install HuggingFace MCP in Visual Studio](https://img.shields.io/badge/Visual_Studio-Install_HuggingFace_MCP-purple?style=flat-square&logo=visualstudio&logoColor=white)](https://vs-open.link/mcp-install?%7B%22name%22%3A%22huggingface%22%2C%22gallery%22%3Atrue%2C%22url%22%3A%22https%3A%2F%2Fhf.co%2Fmcp%22%7D) – Access models, datasets, and Spaces on the Hugging Face Hub.

### Add an MCP server from chat

To add an MCP server from chat view:

1. In the chat pane, switch to **Agent** mode from the mode selector at the bottom of the pane.

1. Select **Tools** to open the tool picker.

1. In the tool picker, select the plus (`+`) button.

   :::image type="content" source="media/vs-2022/mcp-servers/plus-button-add-mcp.png" alt-text="Screenshot of the plus button in the Visual Studio chat tool picker for adding an MCP server." lightbox="media/vs-2022/mcp-servers/configure-server-visual-studio.png":::

:::moniker range="visualstudio"

4. On the menu that appears, select **Add custom MCP server**.

:::moniker-end

:::moniker range="<=vs-2022"

4. The **Add MCP server** dialog opens.

:::moniker-end

5. In the **Add MCP server** dialog, enter the server name and connection details, such as the URL for HTTP servers or the command and arguments for stdio servers.

   :::image type="content" source="media/vs-2022/mcp-servers/configure-server-visual-studio.png" alt-text="Screenshot of the chat view for adding an MCP server in Visual Studio." lightbox="media/vs-2022/mcp-servers/configure-server-visual-studio.png":::

### Add an MCP server from the GitHub MCP server registry

You can install an MCP server directly from the GitHub MCP server registry via **Extensions** in Visual Studio.

1. From the Visual Studio menu, select **Extensions** > **MCP Registries...** to open the **MCP Server Manager**.

    :::image type="content" source="media/vs-2022/mcp-servers/model-context-protocol-registry.png" alt-text="Screenshot of the Extensions menu option for MCP Registries in Visual Studio." lightbox="media/vs-2022/mcp-servers/model-context-protocol-registry.png":::
       
1. Select the server you want, and then select **Install** for your Visual Studio instance.

    :::image type="content" source="media/vs-2022/mcp-servers/model-context-protocol-server-manager.png" alt-text="Screenshot of the MCP Server Manager for installing an MCP server." lightbox="media/vs-2022/mcp-servers/model-context-protocol-server-manager.png":::

### Add an MCP server to the `.mcp.json` file

The following steps walk you through a configuration example with the GitHub MCP server:

1. Create a new file: `<SOLUTIONDIR>\.mcp.json` or `%USERPROFILE%\.mcp.json`. 
   Use Visual Studio to edit this file so that its JSON schema is automatically applied.

1. Paste the following contents into the `.mcp.json` file:

    ```json
    {
      "servers": {
        "github": {
          "url": "https://api.githubcopilot.com/mcp/"
        }
      }
    }
    ```

1. Save the file.

1. In the file, select **Authentication Required** from the CodeLens that appears to authenticate to the server through a GitHub account.
   Select **Authenticate** on the pop-up dialog to authenticate with your GitHub account.

    :::image type="content" source="media/vs-2022/mcp-servers/codelens-authentication.png" alt-text="Screenshot of the CodeLens prompt for MCP server authentication." lightbox="media/vs-2022/mcp-servers/codelens-authentication.png":::

    If you don't see the CodeLens, ensure it's enabled in **Tools** > **Options** > **Text Editor** > **CodeLens**.

1. At the bottom of the chat panel, select **Agent** from the mode dropdown.

    :::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-dropdown.png" alt-text="Screenshot of the GitHub Copilot agent mode selector in the chat pane." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-dropdown.png":::

1. Select the tools that you want to use, for example, **List issues**.

    :::image type="content" source="media/vs-2022/mcp-servers/model-context-protocol-github-tools-list.png" alt-text="Screenshot of GitHub MCP tools available in the Visual Studio chat pane." lightbox="media/vs-2022/mcp-servers/model-context-protocol-github-tools-list.png":::

   Try a sample prompt: **List issues assigned to me on GitHub**.

1. Copilot asks for permission to use a tool that the MCP server made available to it. Select **Allow** with the scope that you want to proceed with.

    :::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-tool-approval.png" alt-text="Screenshot of confirmation options for GitHub Copilot agent tools." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-tool-approval.png":::

## Manage configuration of MCP servers

Visual Studio supports the use of `mcp.json` files to store configuration information for MCP servers. `mcp.json` files store each server's name, transport type (for example, stdio or SSE), the command to
launch it, any arguments, and optional environment variables needed to connect to that server.

If you don't already have an `mcp.json` file, create one in any of the supported locations based on your repository, user, or editor requirements.

To add an MCP server, locate the server's JSON configuration online. For example, find it in the GitHub repository for MCP servers. Then paste it into your `mcp.json` file.

### File locations for automatic discovery of MCP configuration

Visual Studio also checks for MCP configurations that other development environments set up. It reads MCP server configurations from the following directories, in the following order:

1. `%USERPROFILE%\.mcp.json` </br>
    Serves as a global MCP server configuration for a specific user. Adding an MCP server here makes it load for all Visual Studio solutions.
1. `<SOLUTIONDIR>\.vs\mcp.json` </br>
    Specific to Visual Studio and loads the specified MCP servers only for a specific user, for the specified solution.
1. `<SOLUTIONDIR>\.mcp.json` </br>
    Works well if you're looking for an MCP configuration that you can track in source control for a repository.
1. `<SOLUTIONDIR>\.vscode\mcp.json` </br>
    Scoped to the repository/solution and typically not source controlled.
1. `<SOLUTIONDIR>\.cursor\mcp.json` </br>
    Scoped to the repository/solution and typically not source controlled.

Some of these locations require `.mcp.json`, whereas others require `mcp.json`.

## MCP configuration format

You can define both *remote* (URL and credentials) and *local* (command-line invocation) servers.

It's common to invoke tools through package managers. For example, use `npx -y @azure/mcp@latest` or `docker run ... mcp/github`. Visual Studio respects whatever command you specify, so you can pin versions or pass flags as needed.

The format must follow the MCP specification. For example, it must include an array of server objects, each with `name`, `command` or `url`, and `transport`.

### Edit MCP configuration

If you have an existing `mcp.json` file and you check the file into your version control system, add the file location to **Solution Items** in Solution Explorer.

When you save the file with valid syntax, the GitHub Copilot agent restarts and reloads the configured servers.

:::moniker range="visualstudio"

:::image type="content" source="media/visualstudio/model-context-protocol-add-solution-item.png" alt-text="Screenshot of adding the MCP configuration file location to Solution Items." lightbox="media/visualstudio/model-context-protocol-add-solution-item.png":::

:::moniker-end

:::moniker range="<=vs-2022"

:::image type="content" source="media/vs-2022/mcp-servers/model-context-protocol-add-solution-item.png" alt-text="Screenshot of the MCP configuration file location added to Solution Items." lightbox="media/vs-2022/mcp-servers/model-context-protocol-add-solution-item.png":::

:::moniker-end

### Tool lifecycle

As soon as Visual Studio discovers or adds a server:

- It initializes the server by performing a handshake and querying the tool list.
- It subscribes to the MCP event `notifications/tools/list_changed`.
- When that event fires, Visual Studio resets any prior acceptances or permissions on tools (to prevent *rug-pull* attacks), refetches the tool list, and updates the count and UI live.
- When Visual Studio successfully enables the server, the agent makes the tools available. The tools are disabled by default and you must manually enable them.
- If you remove a server, Visual Studio immediately stops its process and withdraws all its tools from the UI.
- If you edit a server definition, Visual Studio terminates and restarts it, and then re-queries.

:::moniker range="visualstudio"

## MCP server trust dialog

> [!NOTE]
> MCP server trust is available in Visual Studio 2026 version 18.7 and later.

Visual Studio asks you to trust an MCP server again when the server has changed since the last time you used it. This prompt helps you decide whether to run the updated server. 

### What to do when you're prompted

When the trust dialog appears, review the change and choose the action that matches your intent:

- **Accept** to run this updated version now.
- **Always Trust** to stop future trust prompts for this server.
- **Reject** to stop startup because you don't want to run the updated server.

If you choose **Reject**, Visual Studio doesn't start the server and asks again the next time you try to activate it.

### When you'll see the trust dialog

You'll be prompted when Visual Studio detects changes to either of these:

- Server configuration details, such as transport type, URL, command, or arguments.
- Server capabilities, such as tools, prompts, resources, resource templates, or instructions.

### When you won't see the trust dialog

Visual Studio skips the prompt when:

- The server is built in and shipped with the extension.
- Organization policy is set to `RegistryOnly`.
- You already selected **Always Trust** for that server.
- It's the first time the server is seen. Visual Studio saves an initial trust baseline automatically.

### Turn trust prompts on or off for updated MCP servers

To control whether Visual Studio prompts before running tools from an updated MCP server, go to **Tools** > **Options** > **GitHub** > **Copilot** and in **Copilot Chat** select or clear **Show trust dialog before running tools from an updated MCP server**.

If you don't see this setting, update to Visual Studio 2026 version 18.7 or later.

:::moniker-end

## Management of tool approvals

When you invoke a tool, Copilot requests confirmation to run the tool. The reason is that tools might run locally on your machine and perform actions that modify files or data.

:::moniker range="visualstudio"

After a tool invocation, on the chat pane, use the **Confirm** dropdown options. You can automatically confirm the specific tool for the current session, the current solution, or all future invocations.

:::image type="content" source="media/visualstudio/copilot-agent-tool-approval.png" alt-text="Screenshot of the chat pane options for managing agent tool approvals." lightbox="media/visualstudio/copilot-agent-tool-approval.png":::

:::moniker-end

:::moniker range="<=vs-2022"

After a tool invocation, on the chat pane, use the **Allow** dropdown options. You can automatically confirm the specific tool for the current session, the current solution, or all future invocations.

:::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-tool-approval.png" alt-text="Screenshot of agent tool approval options in the Visual Studio chat pane." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-tool-approval.png":::

:::moniker-end

:::moniker range="visualstudio"

You can reset tool confirmation selections in the **Tools** > **Options** dialog, in the **All Settings** > **GitHub** > **Copilot** > **Tools** section.

:::image type="content" source="media/visualstudio/copilot-agent-tool-config.png" alt-text="Screenshot of GitHub Copilot tool configuration settings in Visual Studio." lightbox="media/visualstudio/copilot-agent-tool-config.png":::

:::moniker-end

:::moniker range="<=vs-2022"

You can reset tool confirmation selections in the **Tools** > **Options** dialog, under the **GitHub** > **Copilot** section in the **Tools** group.

:::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-tool-config.png" alt-text="Screenshot of tool configuration settings for GitHub Copilot in Visual Studio." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-tool-config.png":::

:::moniker-end

## Manage authorization

Visual Studio now supports authentication for remote servers by using any OAuth provider, in accordance with the [MCP authorization specification](https://modelcontextprotocol.io/specification/draft/basic/authorization). This support is in addition to integration with the Visual Studio keychain.

To manage authentication for an MCP server:

1. In the `.mcp.json` file, select **Manage Authentication** for that server from CodeLens.

1. Provide credentials for the necessary OAuth provider for that server in the browser pop-up dialog.

:::moniker range="visualstudio"

## MCP server allow list policies

MCP server usage in Visual Studio respects allow list policies set by organization administrators through GitHub. When an allow list is configured for your organization, you can only connect to approved MCP servers.

If you try to connect to an MCP server that isn't on the allow list, Visual Studio displays an error message indicating that the server isn't allowed by your organization's policy. Contact your organization administrator to request access to the server or to verify which servers are approved.

This feature helps organizations:

- Control which MCP servers can process sensitive data
- Maintain compliance with security policies
- Centrally manage MCP server access across development teams

For information on configuring MCP server allow lists as an administrator, see [Configure MCP server allow list](visual-studio-github-copilot-admin.md#configure-mcp-server-allowlist).

:::moniker-end

## MCP prompts and prompt templates

MCP servers can provide reusable prompt templates that help you interact more effectively with language models. These prompts are tailored to specific tasks and can include customizable arguments.

### Use MCP prompts

To reference prompts from an MCP server:

1. Select the **+ Add Reference** in chat.
1. Select **Prompts** > **MCP prompts**.
1. Choose a prompt and select **Insert Prompt**.

Some prompts include arguments that you can customize before inserting them into chat. These prompts are called prompt templates.

**Example:** The GitHub MCP server provides prompts for analyzing pull requests, generating commit messages, and reviewing code changes.

[![Install GitHub MCP in Visual Studio](https://img.shields.io/badge/Visual_Studio-Install_GitHub_MCP-purple?style=flat-square&logo=visualstudio&logoColor=white)](https://vs-open.link/mcp-install?%7B%22name%22%3A%22github%22%2C%22url%22%3A%22https%3A%2F%2Fapi.githubcopilot.com%2Fmcp%2F%22%7D)

## MCP resources and resource templates

MCP resources provide context to language models, such as files, database schemas, or application-specific data. Each resource has a unique URI that you can reference in chat.

### Use MCP resources

Reference MCP resources in Copilot chat by using a hashtag (`#`) followed by the resource URI.

For resources with arguments (resource templates):
1. Select **+ Add Reference** in chat.
1. Select **MCP resources**.
1. Choose your resource, fill in any required arguments, and select **Add Resource**.

**Example:** The Azure DevOps MCP server exposes work items resources, sprint information, and team capacity data for project planning tasks.

[![Install in Azure DevOps MCP Visual Studio](https://img.shields.io/badge/Visual_Studio-Install_Azure_DevOps_MCP-purple?style=flat-square&logo=visualstudio&logoColor=white)](https://vs-open.link/mcp-install?%7B%22name%22%3A%22Azure%20DevOps%22%2C%22type%22%3A%22http%22%2C%22url%22%3A%22https%3A%2F%2Fapi.githubcopilot.com%2Fmcp%2Fazure-devops%22%7D)

**Example:** The Figma MCP server provides access to design component resources, style guides, and design specifications.

[![Install Figma MCP in Visual Studio](https://img.shields.io/badge/Visual_Studio-Install_Figma_MCP-purple?style=flat-square&logo=visualstudio&logoColor=white)](https://vs-open.link/mcp-install?%7B%22name%22%3A%22figma%22%2C%22gallery%22%3Atrue%2C%22url%22%3A%22http%3A%2F%2F127.0.0.1%3A3845%2Fmcp%22%7D)

## MCP sampling

By using sampling, MCP servers can make LLM calls for you, enabling more complex, multistep operations. Visual Studio automatically supports sampling if your MCP server provides it.

When Copilot needs to make a sampling call, you see a confirmation dialog. Review the details and approve before the action proceeds, ensuring you maintain control over automated operations.

**Example:** The Playwright MCP server uses sampling to generate test scenarios based on your application's DOM structure and user flows.

[![Install Playwright MCP in Visual Studio](https://img.shields.io/badge/Visual_Studio-Install_Playwright_MCP-purple?style=flat-square&logo=visualstudio&logoColor=white)](https://vs-open.link/mcp-install?%7B%22name%22%3A%22playwright%22%2C%22gallery%22%3Atrue%7D)

## Frequently asked questions

### As an administrator, how do I control use of MCP servers in agent mode for Visual Studio users?

The GitHub policy settings on the GitHub Copilot dashboard for administrators govern agent mode and MCP usage in Visual Studio. If the administrator turns off this setting, users under that subscription can't use agent mode or connect to MCP servers in Visual Studio.

:::moniker range="visualstudio"

Additionally, administrators can configure an MCP server allow list to control exactly which MCP servers are permitted within their organization. For more information, see [Configure MCP server allow list](visual-studio-github-copilot-admin.md#configure-mcp-server-allowlist).

:::moniker-end

For more information, see [Managing policies and features for GitHub Copilot in your enterprise](https://docs.github.com/en/enterprise-cloud@latest/copilot/managing-copilot/managing-copilot-for-your-enterprise/managing-policies-and-features-for-copilot-in-your-enterprise#editor-preview-features).

## Related content

- [GitHub Copilot agent mode](copilot-agent-mode.md)
- [GitHub Copilot Chat experience for Visual Studio](visual-studio-github-copilot-chat.md)
- [Admin controls for GitHub Copilot](visual-studio-github-copilot-admin.md)
- [GitHub Copilot Free](https://aka.ms/ghdocscopilotfreepage#github-copilot-free)
