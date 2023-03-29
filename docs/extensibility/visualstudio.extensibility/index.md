---
title: VisualStudio.Extensibility
description: Welcome to the Visual Studio Extensibility model
date: 2021-8-19
---

# Welcome to VisualStudio.Extensibility

VisualStudio.Extensibility is a new framework for developing Visual Studio extensions. The new framework focuses primarily on extensions that run out-of-process from the IDE for improved performance and reliability, and it features a modern, asynchronous API that has been streamlined and carefully engineered to maximize developer productivity. VisualStudio.Extensibility is in active development and is available as a preview.

**Download the [current preview version here](https://marketplace.visualstudio.com/items?itemName=vsext.gladstone) to get started!**

With the current preview, you can develop a wide range of extensions to Visual Studio, including creating commands, working with code or text in the editor, displaying prompts or dialogs to the user, creating debugger visualizers, and more!

VisualStudio.Extensibility aims to address many of the problems developers experience when using and writing extensions in Visual Studio:

* Visual Studio remains responsive and won't crash if an extension crashes or hangs
* Simplified architecture, consistent APIs, and clear documentation
* Extensions can be installed without restarting Visual Studio

Eventually, the VisualStudio.Extensibility SDK will ultimately allow you to write any extension you could write using the VSSDK. However, until that time, you might encounter situations where the functionality you need in your extension is not yet available in VisualStudio.Extensibility. In that case, you can develop an in-process extension by leveraging the new VisualStudio.Extensibility APIs while relying on VSSDK to cover any feature gap. To learn more, see [In-proc extensions](new-extensibility-model/getting-started/in-proc-extensions.md).

This site is your hub for all documentation for the VisualStudio.Extensibility SDK. Documentation is currently available for the following:

* VisualStudio.Extensibility SDK (see the following sections)
* [Extensions to Language Server Protocol (LSP)](lsp/lsp-extensions-specifications.md)

## Navigate the documentation

| Article | Description|
|-|-|
| [Get started](#get-started) | Never developed an extension before? Start with beginner quickstarts and introductory tutorials. |
| [Concepts](#concepts) | Build your mental model of how the SDK and extensions work. |
| [Overviews](#overviews) | Learn more by reading overviews of each major area of functionality. |
| [Samples](#samples-and-tutorials) | Explore sample code demonstrating major features. |
| [API reference](#api-docs) | Browse the VisualStudio.Extensibility API documentation. |
| [Advanced topics](#advanced-topics) | Learn implementation details of the VisualStudio.Extensibility SDK. |

## Get Started

The following articles will help you get oriented and started.

* [Create your first extension](new-extensibility-model/getting-started/create-your-first-extension.md) shows how to create the equivalent of "Hello, world" as an extension.
* Next, follow a tutorial and create a more interesting extension that adds a GUID to the editor window. See [Create a simple extension](new-extensibility-model/getting-started/tutorial-create-simple-extension.md).

To understand how to work with VisualStudio.Extensibility, we recommend a thorough understanding of [asynchronous programming with async and await](https://learn.microsoft.com/dotnet/csharp/programming-guide/concepts/async/) and [dependency injection](https://learn.microsoft.com/dotnet/core/extensions/dependency-injection). In addition, UI in VisualStudio.Extensibility is based on Windows Presentation Foundation (WPF), so you might want to review the [WPF documentation](/dotnet/desktop/wpf/).

## Concepts

If you're familiar with the Visual Studio SDK, see [Introduction to VisualStudio.Extensibility for VSSDK users](new-extensibility-model/getting-started/oop-extensibility-model-overview.md).

Build your mental model of how Visual Studio extensions work. See [Parts of a new Visual Studio extension](new-extensibility-model/inside-the-sdk/extension-anatomy.md).

Learn what's in the SDK at [Functional areas of the SDK](new-extensibility-model/inside-the-sdk/inside-the-sdk.md).

When and where should your extension appear in the IDE? Visual Studio extensions surface in the IDE when certain conditions are met. To control how and when your extension appears in the IDE, see [Rule-based activation constraints](new-extensibility-model/inside-the-sdk/activation-constraints.md).

Visual Studio extensions make their features available to Visual Studio through [Contributions](new-extensibility-model/inside-the-sdk/contributions-and-configurations.md)

Learn about the [Remote UI](new-extensibility-model/inside-the-sdk/remote-ui.md) model used in the VisualStudio.Extensibility.

## Overviews

Read an overview of the areas of the SDK that you might need for your extension development projects:

* To learn how to create commands and expose them to users in the IDE, see [Commands](new-extensibility-model/extension-guides/command/command.md).
* To learn how to work with contents of files and documents, see [Editor extensions](new-extensibility-model/extension-guides/editor/editor.md).
* To learn how to work with the in-memory representations of those files and documents themselves, see [Documents](new-extensibility-model/extension-guides/documents/documents.md)
* To learn how to use the output window in an extension, see [Output window](new-extensibility-model/extension-guides/outputWindow/outputWindow.md).
* To learn how to work with tool windows, dockable windows hosted within the Visual Studio IDE, see [Tool windows](new-extensibility-model/extension-guides/toolWindow/toolWindow.md).
* To learn how to use prompts with customizable buttons to interact with the user, see [User prompts](new-extensibility-model/extension-guides/userPrompts/userPrompts.md).
* To learn how to use dialogs with custom UI to interact with the user, see [Dialogs](new-extensibility-model/extension-guides/dialog/dialog.md)
* To learn how to create custom data visualizations when debugging, see [Debugger Visualizers](new-extensibility-model/extension-guides/debuggerVisualizers/debuggerVisualizers.md)

## Samples and tutorials

A Visual Studio solution containing all samples can be found at [Samples.sln](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/Samples.sln).

| Sample | Description|
|-|-|
| [Simple command handler]([new-extensibility-model/getting-started/create-your-first-extension.md](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/SimpleRemoteCommandSample)) | Demonstrates the basics of working with commands. See also the [Create your first extension](new-extensibility-model/getting-started/create-your-first-extension.md) tutorial.|
| [Insert guid extension](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/InsertGuidExtension) | Shows how to insert text or code in the code editor. See also the [tutorial](new-extensibility-model/getting-started/tutorial-create-simple-extension.md). |
| [Command configuration](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/CommandRegistrationsSample) | Shows how to configure a command with specific activation conditions. This command also uses a resource file for localization. |
| [Command parenting](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/Command-Parenting-Sample) | Shows how to author a command that can be parented to different aspects of the IDE. |
| [Document selector](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/DocumentSelectorSample) | Shows how to create an editor extension that is only applicable to files matching a file path pattern. |
| [Output window](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/OutputWindowSample) | Shows the most basic use of the [Output Window API](./new-extensibility-model/extension-guides/outputWindow/outputWindow.md)|
| [Tool window](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/ToolWindowExtension) | Shows how to create a tool window and populate it with content. |
| [User prompt](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/UserPromptSample) | Shows how to display a prompt to the user. |
| [Dialog](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/DialogSample) | Shows how to display a dialog with custom UI to the user. |
| [Word count margin](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/WordCountMargin) | Shows how to create an editor margin extension that displays the word count in a document. |
| [Markdown linter](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/MarkdownLinter) | A complete extension with many moving parts interacting to provide an enhanced experience in the editor for a certain file type. |
| [Project Query](https://github.com/microsoft/VSExtensibility/tree/preview/New_Extensibility_Model/Samples/VSProjectQueryAPISample) | Shows several different kinds of project system queries you can make. |
| [Comment remover](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/CommentRemover) | Shows how to consume [Visual Studio SDK](https://www.nuget.org/packages/Microsoft.VisualStudio.SDK) services through .NET dependency injection and use VisualStudio.Extensibility APIs for commands, prompts and progress report. |

## Advanced Topics

| Article | Description|
|-|-|
| [Advanced Remote UI](new-extensibility-model/inside-the-sdk/advanced-remote-ui.md) | In-depth information on the remote UI model. |
| [In-proc extensions](new-extensibility-model/getting-started/in-proc-extensions.md) | Learn how to make extension that run in-process. |

## API Docs

* [Microsoft.VisualStudio.Extensibility](new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.md)
* [Microsoft.VisualStudio.Extensibility.Editor](new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.Editor.md)
* [Microsoft.VisualStudio.ProjectSystem.Query](new-extensibility-model/api/Microsoft.VisualStudio.ProjectSystem.Query.md)

## Send feedback

We're actively seeking feedback and engagement. The preview phase is a great time to get community input to help us identify issues and opportunities. You can provide feedback and report bugs in our [issues tracker](https://github.com/microsoft/VSExtensibility/issues).

For future updates please bookmark our [announcements](announcements.md) page.

## Contributing

This project welcomes contributions and suggestions.  Most contributions require you to agree to a Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us the rights to use your contribution. For details, visit https://cla.opensource.microsoft.com.

When you submit a pull request, a CLA bot will automatically determine whether you need to provide a CLA and decorate the PR appropriately (e.g., status check, comment). Simply follow the instructions provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## Trademarks

This project may contain trademarks or logos for projects, products, or services. Authorized use of Microsoft trademarks or logos is subject to and must follow [Microsoft's Trademark & Brand Guidelines](https://www.microsoft.com/legal/intellectualproperty/trademarks/usage/general).
Use of Microsoft trademarks or logos in modified versions of this project must not cause confusion or imply Microsoft sponsorship.
Any use of third-party trademarks or logos are subject to those third-party's policies.
