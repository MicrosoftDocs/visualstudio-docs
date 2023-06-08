---
title: VisualStudio.Extensibility overview
description: Learn about the Visual Studio Extensibility model for adding custom functionality to Visual Studio.
ms.topic: overview
ms.date: 3/31/2023
ms.author: maiak
monikerRange: ">=vs-2022"
author: maiak
manager: jmartens
ms.technology: vs-ide-sdk
---

# About VisualStudio.Extensibility (Preview)

VisualStudio.Extensibility is a new framework for developing Visual Studio extensions. The new framework focuses primarily on extensions that run out-of-process from the IDE for improved performance and reliability, and it features a modern, asynchronous API that has been streamlined and carefully engineered to maximize developer productivity. VisualStudio.Extensibility is in active development and is available as a preview.

 > [!div class="button"]
 > [Download VisualStudio.Extensibility preview](https://marketplace.visualstudio.com/items?itemName=vsext.gladstone)

With the current preview, you can develop a wide range of extensions to Visual Studio, including creating commands, working with code or text in the editor, displaying prompts or dialogs to the user, creating debugger visualizers, and more!

VisualStudio.Extensibility aims to address many of the problems developers experience when using and writing extensions in Visual Studio:

* Visual Studio remains responsive and won't crash if an extension crashes or hangs
* Simplified architecture, consistent APIs, and clear documentation
* Extensions can be installed without restarting Visual Studio

Eventually, you will be able to use the VisualStudio.Extensibility SDK to write any extension you could write using the VS SDK. However, until that time, you might encounter situations where the functionality you need in your extension isn't yet available in VisualStudio.Extensibility. In that case, you can develop an in-process extension by leveraging the new VisualStudio.Extensibility APIs while relying on VS SDK to cover any feature gap. To learn more, see [In-proc extensions](./get-started/in-proc-extensions.md).

The latest information on VisualStudio.Extensibility may be found in the VSExtensibility GitHub repo at [announcements](https://github.com/microsoft/VSExtensibility/blob/main/docs/announcements.md).

## Navigate the documentation

| Article | Description|
|-|-|
| [Install VisualStudio.Extensibility](#install-visualstudioextensibility) | Download and install the latest preview of VisualStudio.Extensibility. |
| [Get started](#get-started) | Never developed an extension before? Start with beginner quickstarts and introductory tutorials. |
| [Concepts](#concepts) | Build your mental model of how the SDK and extensions work. |
| [Overviews](#overviews) | Learn more by reading overviews of each major area of functionality. |
| [Samples](#samples-and-tutorials) | Explore sample code demonstrating major features. |
| [API reference](#api-docs) | Browse the VisualStudio.Extensibility API documentation. |
| [Advanced topics](#advanced-topics) | Learn implementation details of the VisualStudio.Extensibility SDK. |

## Install VisualStudio.Extensibility

The current VisualStudio.Extensibility preview works with Visual Studio 2022 version 17.6 Preview 1 or higher with the `.Net desktop development` workload to be installed.

Install the [VisualStudio.Extensibility Project System](https://marketplace.visualstudio.com/items?itemName=vsext.gladstone) extension. This extension contains project and item templates, and so you can debug extension projects using `F5`.

## Get started

The following articles help you get oriented and started.

* [Create your first extension](./get-started/create-your-first-extension.md) shows how to create the equivalent of "Hello, world" as an extension.
* Next, follow a tutorial and create a more interesting extension that adds a GUID to the editor window. See [Create a simple extension](./get-started/tutorial-create-simple-extension.md).

To understand how to work with VisualStudio.Extensibility, we recommend a thorough understanding of [asynchronous programming with async and await](/dotnet/csharp/programming-guide/concepts/async/) and [dependency injection](/dotnet/core/extensions/dependency-injection). In addition, UI in VisualStudio.Extensibility is based on Windows Presentation Foundation (WPF), so you might want to review the [WPF documentation](/dotnet/desktop/wpf/).

## Concepts

If you're familiar with the Visual Studio SDK, see [Introduction to VisualStudio.Extensibility for VSSDK users](./get-started/oop-extensibility-model-overview.md).

Build your mental model of how Visual Studio extensions work. See [Parts of a new Visual Studio extension](./inside-the-sdk/extension-anatomy.md).

Learn what's in the SDK at [Functional areas of the SDK](./inside-the-sdk/inside-the-sdk.md).

When and where should your extension appear in the IDE? Visual Studio extensions surface in the IDE when certain conditions are met. To control how and when your extension appears in the IDE, see [Rule-based activation constraints](./inside-the-sdk/activation-constraints.md).

Visual Studio extensions make their features available to Visual Studio through [Contributions](./inside-the-sdk/contributions-and-configurations.md)

Learn about the [Remote UI](./inside-the-sdk/remote-ui.md) model used in the VisualStudio.Extensibility.

## Overviews

Read an overview of the areas of the SDK that you might need for your extension development projects.

* Create commands and expose them to users in the IDE, see [Commands](./command/command.md).
* Work with contents of files and documents, see [Editor extensions](./editor/editor.md).
* Work with the in-memory representation of those documents themselves, see [Documents](./document/documents.md)
* Use the output window in an extension, see [Output window](./output-window/output-window.md).
* Work with tool windows, dockable windows within the Visual Studio IDE, see [Tool windows](./tool-window/tool-window.md).
* Use prompts with customizable buttons to interact with the user, see [User prompts](./user-prompt/user-prompts.md).
* Use dialogs with custom UI to interact with the user, see [Dialogs](./dialog/dialog.md)
* Create custom data visualizations when debugging, see [Debugger Visualizers](./debugger-visualizer/debugger-visualizers.md)
* Query or modify information about project sand solutions, see [Project Query](./project/project.md)

## Samples and tutorials

A Visual Studio solution containing all samples can be found at [Samples.sln](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/Samples.sln).

| Sample | Description|
|-|-|
| [Simple command handler](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/SimpleRemoteCommandSample) | Demonstrates the basics of working with commands. See also the [Create your first extension](./get-started/create-your-first-extension.md) tutorial.|
| [Insert guid extension](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/InsertGuidExtension) | Shows how to insert text or code in the code editor. See also the [tutorial](./get-started/tutorial-create-simple-extension.md). |
| [Command configuration](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/CommandRegistrationsSample) | Shows how to configure a command with specific activation conditions. This command also uses a resource file for localization. |
| [Command parenting](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/Command-Parenting-Sample) | Shows how to author a command that can be parented to different aspects of the IDE. |
| [Document selector](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/DocumentSelectorSample) | Shows how to create an editor extension that is only applicable to files matching a file path pattern. |
| [Output window](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/OutputWindowSample) | Shows the most basic use of the [Output Window API](./output-window/output-window.md)|
| [Tool window](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/ToolWindowSample) | Shows how to create a tool window and populate it with content. |
| [User prompt](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/UserPromptSample) | Shows how to display a prompt to the user. |
| [Dialog](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/DialogSample) | Shows how to display a dialog with custom UI to the user. |
| [Word count margin](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/WordCountMargin) | Shows how to create an editor margin extension that displays the word count in a document. |
| [Markdown linter](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/MarkdownLinter) | A complete extension with many moving parts interacting to provide an enhanced experience in the editor for a certain file type. |
| [Project Query](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/VSProjectQueryAPISample) | Shows several different kinds of project system queries you can make. |
| [Comment remover](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/CommentRemover) | Shows how to consume [Visual Studio SDK](https://www.nuget.org/packages/Microsoft.VisualStudio.SDK) services through .NET dependency injection and use VisualStudio.Extensibility APIs for commands, prompts and progress report. |

## Advanced topics

| Article | Description|
|-|-|
| [Advanced Remote UI](./inside-the-sdk/advanced-remote-ui.md) | In-depth information on the remote UI model. |
| [In-proc extensions](./get-started/in-proc-extensions.md) | Learn how to make extension that run in-process. |

## API Docs

* [Microsoft.VisualStudio.Extensibility](https://github.com/microsoft/VSExtensibility/tree/main/docs/new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.md)
* [Microsoft.VisualStudio.Extensibility.Editor](https://github.com/microsoft/VSExtensibility/tree/main/docs/new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.Editor.md)
* [Microsoft.VisualStudio.ProjectSystem.Query](https://github.com/microsoft/VSExtensibility/tree/main/docs/new-extensibility-model/api/Microsoft.VisualStudio.ProjectSystem.Query.md)

## Send feedback

We're actively seeking feedback and engagement. The preview phase is a great time to get community input to help us identify issues and opportunities. You can provide feedback and report bugs in our [issues tracker](https://github.com/microsoft/VSExtensibility/issues).
