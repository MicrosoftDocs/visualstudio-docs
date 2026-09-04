---
title: 'Customize chat responses'
description: Use custom instructions and prompt files to customize responses and use slash commands to set quick context for common tasks.
ms.date: 09/04/2026
ms.update-cycle: 180-days
ms.topic: how-to 
author: RoseHJM
ms.author: rosemalcolm
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot 
helpviewer_keywords: 
  - copilot chat context
  - context, copilot chat
ms.custom: "awp-ai, sfi-image-nochange"
ms.ai-usage: ai-assisted
---
# Customize chat responses and set context

You can ask [**GitHub Copilot Chat**](visual-studio-github-copilot-chat.md) to give you code suggestions, explain code, generate unit tests, and suggest code fixes. Chat in Visual Studio can give you responses and generate code that matches your coding practices and project requirements, if you give it the right context. Instead of repeatedly adding this information in every chat prompt, you can store this context in files and automatically include it in every chat request.

To provide relevant context and tailor Copilot Chat responses, you can do the following tasks:

:::moniker range="visualstudio"

+ Use [slash commands](#slash-commands) to quickly specify common tasks like `/savePrompt`, or [invoke your custom prompts](#invoke-custom-prompts-with-slash-commands) directly
+ Use the [guided chat experience](#prompting-guidance) to refine context
+ Use [custom instructions](#use-custom-instructions) and [prompt files](#use-prompt-files) to customize responses

:::moniker-end

:::moniker range="<=vs-2022"

+ Use [slash commands](#slash-commands) to quickly specify common tasks like `/explain` to get code explanations
+ Use the [guided chat experience](#prompting-guidance) to refine context
+ Use [custom instructions](#use-custom-instructions) and [prompt files](#use-prompt-files) to customize responses

:::moniker-end

Learn more about [AI-assisted development in Visual Studio](../ide/ai-assisted-development-visual-studio.md) and how to [use Copilot Chat in Visual Studio](../ide/visual-studio-github-copilot-chat.md#use-copilot-chat-in-visual-studio).

## Prerequisites

Before you begin, ensure you meet the following prerequisites.

| Prerequisite | Details |
| --- | --- |
| Visual Studio | Visual Studio 2022 [version 17.10](/visualstudio/releases/2022/release-history) or later. |
| GitHub account | [Sign in to Visual Studio using a GitHub account](work-with-github-accounts.md) with [Copilot access](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot). You can sign up for [GitHub Copilot Free](copilot-free-plan.md). |


[!INCLUDE [copilot-trials-paused-notice](../includes/copilot-trials-paused-notice.md)]


For GitHub Copilot Chat support, contact GitHub at https://support.github.com.

## Prompting guidance

The guided chat experience in Visual Studio 17.12 and later helps refine your prompts to clarify context for better answers. GitHub Copilot Chat now guides you with clarifying questions when context is unclear.

:::moniker range="visualstudio"

:::image type="content" source="media/visualstudio/copilot-chat-context/copilot-chat-guided-chat.png" alt-text="Screenshot of guided chat experience with GitHub Copilot Chat.":::

:::moniker-end

:::moniker range="<=vs-2022"

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-guided-chat.png" alt-text="Screenshot of guided chat experience with GitHub Copilot Chat.":::

:::moniker-end

## Use custom instructions

By using the custom instructions feature, you can automatically add prespecified contextual details to your chat questions. Copilot Chat uses these instructions to generate responses that reflect your specific context, such as the way your team works, the tools you use, or the specifics of your project.

:::moniker range="visualstudio"

:::image type="content" source="media/visualstudio/copilot-chat-context/custom-instruction-files.png" alt-text="Screenshot of the References list showing custom instruction files that Copilot uses.":::

:::moniker-end

:::moniker range="<=vs-2022"

:::image type="content" source="media/vs-2022/copilot-chat-context/custom-instruction-files.png" alt-text="Screenshot of the References list showing custom instruction files that Copilot uses.":::

:::moniker-end

### Use a .github/copilot-instructions.md file

To use a `.github/copilot-instructions.md` file:

1. [Create or add](https://docs.github.com/en/enterprise-cloud@latest/copilot/customizing-copilot/adding-custom-instructions-for-github-copilot) a custom instructions file `.github/copilot-instructions.md` in the root of your repository.

:::moniker range="visualstudio"

2. Enable the feature in Visual Studio from the **Tools** > **Options** pane. Expand the **All Settings** > **GitHub** > **Copilot** > **Copilot Chat** section and select the **Enable custom instructions to be loaded from .github/copilot-instructions.md files and added to requests** checkbox.

:::moniker-end
:::moniker range="vs-2022"

2. Enable the feature in Visual Studio from the **Tools** > **Options** dialog. Expand the **GitHub** > **Copilot** section and select the **Enable custom instructions to be loaded from .github/copilot-instructions.md files and added to requests** checkbox in the **Copilot Chat** group.

:::moniker-end

The contents of custom instructions don't appear in the Chat view or inline chat. However, when Copilot uses the `.github/copilot-instructions.md` file, it lists the file in the **References** list for the response.

[Copilot memories](copilot-context-overview.md#copilot-memories) can automatically detect your preferences during chat and add them to your instruction files, so you don't have to write them manually.

:::moniker range="visualstudio"

### Use organization-level custom instructions

With organization-level custom instructions, GitHub organization owners can provide shared guidance that tailors Copilot responses across repositories in the organization. Teams can use these instructions to establish common preferences and working conventions.

> [!NOTE]
> Organization-level custom instructions apply only to repositories that belong to a GitHub organization. These instructions express preferences and don't enforce organizational policies.

#### Add organization-level custom instructions

Organization owners can [add organization custom instructions](https://docs.github.com/en/enterprise-cloud@latest/copilot/how-tos/copilot-on-github/customize-copilot/add-custom-instructions/add-organization-instructions#adding-organization-custom-instructions) in GitHub.

#### Review applied instructions

When you work in a repository that belongs to your organization, Copilot automatically applies the organization's custom instructions. Applied instructions appear in the **References** list during Copilot interactions. Select the reference to open the complete instructions.

#### Disable organization-level custom instructions

Disable organization-level instructions if you don't want to use them or if they conflict with your user-level preferences:

1. Select **Tools** > **Options** > **GitHub** > **Copilot** > **Copilot Chat**.
1. Clear **Enable organization-level custom instructions**.

### Use user-level preferences

In addition to repo-level custom instructions, you can define user-level preferences that apply to all your Copilot sessions across projects. The `%USERPROFILE%/copilot-instructions.md` file stores these preferences.

Use user-level preferences for personal coding standards, preferred patterns, or workflow conventions that you want Copilot to follow regardless of the repository you're working in. Repo-level instructions in `.github/copilot-instructions.md` still apply alongside your user-level preferences, so Copilot also respects your team's shared standards.

You can add preferences to this file manually, or let [Copilot memories](copilot-context-overview.md#copilot-memories) detect and save them automatically as you chat.

:::moniker-end

### Use .instructions.md files

Instead of using a single instructions file that applies to all chat requests, you can create multiple  `*.instructions.md` files that apply to specific file types or tasks. For example, you can create instructions files for different programming languages, frameworks, or project types.

To use a `.github/instructions/*.instructions.md` file:

1. Create the `.github/instructions` directory if it does not already exist.

1. Add one or more `.github/instructions/*.instructions.md` files.

1. Add the `applyTo` property in the frontmatter section of the instructions file. Use glob syntax to specify what files or folders the instructions apply to.

1. Enable the feature in Visual Studio.

   :::moniker range="visualstudio"

   In the **Tools** > **Options** pane, expand the **All Settings** > **GitHub** > **Copilot** > **Copilot Chat** section and select the **Enable custom instructions to be loaded from .github/copilot-instructions.md files and added to requests** checkbox.

   :::moniker-end
   :::moniker range="vs-2022"

   In the **Tools** > **Options** dialog, expand the **GitHub** > **Copilot** section. In the **Copilot Chat** group, select the **Enable custom instructions to be loaded from .github/copilot-instructions.md files and added to requests** checkbox.

   :::moniker-end

#### Instructions file format

Targeted instruction files use the `.instructions.md` extension and have this structure:

* **Header** (optional): YAML frontmatter
  - `description`: Description that appears when you hover over the file in Chat view
  - `applyTo`: Glob pattern that matches the files or folders you want the instructions to apply to
* **Body**: Instructions in Markdown format

### Example

Here's an example C# custom instruction:

```markdown
## C# Instructions
---
applyTo: `**/*.cs`
---

- Write clear and concise comments for each function.
- Use PascalCase for component names, method names, and public members.
- Use camelCase for private fields and local variables.
- Add a newline before the opening curly brace of any code block  
  (such as after `if`, `for`, `while`, `foreach`, `using`, `try`, etc.).
- Ensure that the final `return` statement of a method is on its own line.
```

Copy these instructions into your `.github/instructions/*.instructions.md` file to use and automatically apply to Copilot behavior.

For more examples of custom instructions, see the list of [instruction samples on GitHub](https://github.com/github/awesome-copilot/blob/main/README.md).

### How instruction files work 

When you start working with Copilot, it automatically detects which instruction files are relevant to your current context and attaches them as references. This feature ensures Copilot’s suggestions always align with your project’s rules, no matter where you’re working in your codebase.

Copilot lists the instruction files it uses in the References list of the response.

## Use prompt files

You can now create reusable prompt files in your repository to run or share your frequently used prompts.

To create a prompt file:
1. Write your prompts as you normally would in the prompt box, using `#` references to include specific information from your solution, such as methods, classes, and files. You can even reference other prompt files for shared instructions.
1. Copy the prompt into a markdown file, and save it with the `.prompt.md` extension in the `.github/prompts` folder at the root of your repository.

To use a prompt file:
1. Type `#prompt:` in chat input to reference any prompt files from your `.github/prompts` folder, or select the **➕** icon in the chat input to add it as context.
1. Add any extra details, or simply enter the prompt as is.

:::image type="content" source="media/vs-2022/copilot-chat-context/prompt-files.png" alt-text="Screenshot of using prompt files in GitHub Copilot Chat.":::

:::moniker range="visualstudio"

Once you create prompt files, you can quickly invoke them by typing `/` in the chat input.

## Invoke custom prompts with slash commands

You can quickly invoke your favorite custom prompts directly from the chat input box by using slash commands.

### Access custom prompts with /

Type `/` in the chat input to see your custom prompts at the top of the IntelliSense list.

- **Custom prompts** appear at the top of the list with a bookmark icon.
- **System commands** (like `/help`, `/savePrompt`) appear below without an icon.

:::image type="content" source="media/visualstudio/copilot-chat-context/slash-commands.png" alt-text="Screenshot of IntelliSense list showing custom prompts with bookmark icons at the top after typing slash.":::

### Create custom instructions with /generateInstructions

Use the `/generateInstructions` command to automatically generate repository-level custom instructions for your project. This command analyzes your project structure and coding patterns to create a repository-specific `copilot-instructions.md` file.

**To use `/generateInstructions`:**

1. Open Copilot Chat in Visual Studio.
1. Type `/generateInstructions` in the chat input and press **Enter**.
1. Copilot analyzes your project structure and coding patterns.
1. Copilot generates a `copilot-instructions.md` file in your `.github` folder.

This command leverages project smarts to detect coding styles and preferences, making it easy to set up custom instructions without manually authoring the file.

### Save prompts with /savePrompt

Use the `/savePrompt` command to extract a reusable prompt from your current conversation and save it for future use.

**To use `/savePrompt`:**

1. Type a prompt in Copilot Chat that you want to reuse.
1. After Copilot responds, type `/savePrompt` in the chat input and select **Enter**.
1. Choose a name for the prompt file.
1. `/savePrompt` saves the prompt to `.github/prompts/[name].prompt.md`.

You can then quickly access the prompt by typing `/` and selecting it from the IntelliSense list.

:::moniker-end

## <a name="slash-commands"></a>Use slash commands to set context for common tasks

Slash commands in Copilot Chat help you set the intent quickly for common development tasks. By using specific slash commands to form your question, you can get better answers without having to write out long questions. 

You can use slash commands in a [chat window](visual-studio-github-copilot-chat.md#ask-questions-in-the-chat-window), or directly inline in the code that you're looking to modify, using [inline code assistance](visual-studio-github-copilot-chat.md#ask-questions-in-the-inline-chat-view). Commands that help modify or add to the code file you have open in the editor work both in the inline code assistant and the chat windows whereas commands for more general coding questions work only in the chat pane.

:::moniker range="visualstudio"

| **Command** | **Usage** | **Chat window** | **Inline chat** |
|---------------------------|--------------------|:----------:|:----------:|
| /doc| Add comments for specified or selected code. <br>  Examples: <br>- `/doc DeleteBasketAsync method in BasketService.cs`</br>- select desired code and enter `/doc`| Yes | Yes |
| /explain | Get code explanations. <br><br>  Examples: <br> - `/explain the AddItemToBasket method in BasketService.cs`</br>- select desired code and enter `/explain`| Yes | Yes |
| /fix | Propose a fix for problems in the selected code. <br>  Examples: <br> - `/fix the SetQuantities method in BasketService.cs`</br>- select desired code and enter `/fix`| Yes | Yes |
| /generate | Generate code to answer specified question. <br> Example: `/generate code to add two numbers in Calculator.cs`| Yes | Yes | 
| /generateInstructions | Generate repository-level custom instructions (`copilot-instructions.md`) that reflect your project's coding patterns and structure. | Yes | No |
| /help | Get help on using Copilot Chat. <br> Example: `/help`| Yes | Yes | 
| /optimize | Analyze and improve running time of the selected code. <br> Examples:<br> - `/optimize the AddItemToBasket method in BasketService.cs`</br>- select desired code and enter `/optimize`| Yes | Yes |
| /savePrompt | Save a reusable prompt from the current conversation thread to a `.prompt.md` file in your `.github/prompts` folder. | Yes | No |
| /tests| Create unit tests for the selected code.<br>  Example: select desired code and enter `/tests using XUnit Framework`<br>For .NET, we recommend [GitHub Copilot Testing for .NET](../test/github-copilot-test-dotnet-overview.md)| Yes | Yes |

:::image type="content" source="media/visualstudio/copilot-chat-context/copilot-chat-context-slash-commands.png" alt-text="Screenshot of slash commands in inline chat view and chat windows.":::

:::moniker-end

:::moniker range="<=vs-2022"

| **Command** | **Usage** | **Chat window** | **Inline chat** |
|---------------------------|--------------------|:----------:|:----------:|
| /doc| Add comments for specified or selected code. <br>  Examples: <br>- `/doc DeleteBasketAsync method in BasketService.cs`</br>- select desired code and enter `/doc`| Yes | Yes |
| /explain | Get code explanations. <br><br>  Examples: <br> - `/explain the AddItemToBasket method in BasketService.cs`</br>- select desired code and enter `/explain`| Yes | Yes |
| /fix | Propose a fix for problems in the selected code. <br>  Examples: <br> - `/fix the SetQuantities method in BasketService.cs`</br>- select desired code and enter `/fix`| Yes | Yes |
| /generate | Generate code to answer specified question. <br> Example: `/generate code to add two numbers in Calculator.cs`| Yes | Yes | 
| /help | Get help on using Copilot Chat. <br> Example: `/help`| Yes | Yes | 
| /optimize | Analyze and improve running time of the selected code. <br> Examples:<br> - `/optimize the AddItemToBasket method in BasketService.cs`</br>- select desired code and enter `/optimize`| Yes | Yes |
| /tests| Create unit tests for the selected code.<br>  Example: select desired code and enter `/tests using XUnit Framework`<br>For .NET, we recommend [GitHub Copilot Testing for .NET](../test/github-copilot-test-dotnet-overview.md)| Yes | Yes |

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-context-slash-commands.png" alt-text="Screenshot of slash commands in inline chat view and chat windows.":::

:::moniker-end

With Visual Studio 2022 version 17.13, as the user types a slash command, the command expands out the prompt in natural language to display the context for the command.

::: moniker range="visualstudio"

## Use Copilot actions

Use Copilot actions from the context menu to quickly access preconfigured prompts and slash commands for common development tasks.

:::image type="content" source="media/visualstudio/copilot-chat-context/copilot-actions.png" alt-text="Screenshot of Copilot actions in the context menu.":::

The behavior of each action depends on whether you select code when you open the context menu: 

| **Action** | **With code selected** | **Without code selected** |
|---------------------------|--------------------|:----------:|:----------:|
| Explain| Explains the selected code | Explains the code near the cursor position |
| Review Selection | Reviews the selected code and adds inline comments | Not applicable |
| Optimize Selection | Optimizes the selected code for performance, maintainability, reliability, and architecture | Not applicable |
| Generate Comments | Generates comments for the selected code | Generate comments for code near the cursor position |
| Generate Tests | Generates tests for the selected code | Generate tests for code near the cursor position |
| Add to Chat | Adds the selected code to Chat as a reference | Add the entire file to Chat as reference |

When you select any action except **Review Selection** or **Optimize Selection**, the chat window opens automatically and sends a [slash command](#slash-commands) to Copilot with the appropriate scoped context. You can then review and interact with Copilot's response in the chat window.

### Review selected code

Use **Review Selection** when you want targeted code review feedback on a specific block of code. In the editor, select the code, right-click the selection, and then select **Copilot Actions** > **Review Selection**.

Copilot adds review comments inline to the selected code. Review each comment and choose whether to update the code. To apply a suggested fix, select the sparkle icon on the comment. If the comment doesn't include a suggestion, Copilot generates one.

**Review Selection** uses [GitHub Copilot code review](https://docs.github.com/copilot/how-tos/use-copilot-agents/request-a-code-review/use-code-review?tool=visualstudio). To review all uncommitted local changes, see [Review local changes with Copilot Chat](../version-control/git-make-commit.md#review-local-changes-with-copilot-chat). To review changes in one commit or between two commits, see [Review commits with GitHub Copilot](../version-control/git-browse-repository.md#review-commits-with-github-copilot).

### Use Optimize Selection option for better code 

Select a specific section of code and choose **Optimize Selection** to have Copilot analyze and improve just that section, rather than an entire file.

Copilot examines the selected code and its surrounding context to provide meaningful, context-aware suggestions. The optimization preserves your existing code style, structure, and functionality, keeping your codebase organized and consistent. Unlike other actions that use the chat panel, **Optimize Selection** presents suggestions as an inline diff that you can directly review, accept, or reject.

Copilot provides optimization suggestions across these areas: 
- **Performance:** Faster algorithms, reduced memory usage, async patterns
- **Maintainability:** Simplified logic, clearer structure, better naming 
- **Reliability:** Error handling, resource cleanup, thread safety 
- **Architecture:** Dependency injection, better interfaces, modular design 

::: moniker-end

::: moniker range="<=vs-2022"

## Use Copilot actions

Use Copilot actions from the context menu to quickly access preconfigured prompts and slash commands for common development tasks.

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-actions.png" alt-text="Screenshot of Copilot actions in the context menu.":::

The behavior of each action depends on whether you select code when you open the context menu: 

| **Action** | **With code selected** | **Without code selected** |
|---------------------------|--------------------|:----------:|:----------:|
| Explain| Explains the selected code | Explains the code near the cursor position |
| Optimize Selection | Optimizes the selected code for performance, maintainability, reliability, and architecture | Not applicable |
| Generate Comments | Generates comments for the selected code | Generate comments for code near the cursor position |
| Generate Tests | Generates tests for the selected code | Generate tests for code near the cursor position |
| Add to Chat | Adds the selected code to Chat as a reference | Add the entire file to Chat as reference |

When you select any action except *Optimize Selection*, the chat window opens automatically and sends a [slash command](#slash-commands) to Copilot with the appropriate scoped context. You can then review and interact with Copilot's response in the chat window.

### Use Optimize Selection option for better code 

Select a specific section of code and choose **Optimize Selection** to have Copilot analyze and improve just that section, rather than an entire file.

Copilot examines the selected code and its surrounding context to provide meaningful, context-aware suggestions. The optimization preserves your existing code style, structure, and functionality, keeping your codebase organized and consistent. Unlike other actions that use the chat panel, **Optimize Selection** presents suggestions as an inline diff that you can directly review, accept, or reject.

Copilot provides optimization suggestions across these areas: 
- **Performance:** Faster algorithms, reduced memory usage, async patterns
- **Maintainability:** Simplified logic, clearer structure, better naming 
- **Reliability:** Error handling, resource cleanup, thread safety 
- **Architecture:** Dependency injection, better interfaces, modular design 

::: moniker-end

## Next steps

- [GitHub Copilot experience for Visual Studio](visual-studio-github-copilot-extension.md)
- [GitHub Copilot Chat experience for Visual Studio](visual-studio-github-copilot-chat.md)
- [GitHub Copilot Trust Center](https://resources.github.com/copilot-trust-center/)
- [Send us suggestions, feedback, and issues](how-to-report-a-problem-with-visual-studio.md)
- [Support for GitHub Copilot Chat](https://support.github.com)
- [How to use GitHub Copilot: Prompts, tips, and use cases](https://github.blog/developer-skills/github/how-to-write-better-prompts-for-github-copilot/)
