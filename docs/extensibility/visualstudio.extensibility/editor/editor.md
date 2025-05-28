---
title: Editor Overview
description: An overview of the editor-based extensions for the Visual Studio integrated development environment (IDE).
ms.date: 3/31/2023
ms.topic: conceptual
ms.author: maiak
monikerRange: ">=vs-2022"
author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---

# Extend the Visual Studio editor

The Visual Studio editor supports extensions that add to its capabilities. Examples include extensions that:

- Insert and modify code in an existing language.
- Customize the behavior of certain editor features like CodeLens.

The Visual Studio editor generally refers to the functionality of editing text files, known as documents, of any type. You can open individual files for editing. The open editor window is referred to as a text view.

For more information on the editor object model, see [Editor extensibility concepts](editor-concepts.md).

The following sections summarize the high-level editor extensibility scenarios that `VisualStudio.Extensibility` supports. Each of these scenarios is rich in concepts and APIs. Separate, more detailed sections include links to provide more in-depth explanations of the APIs and how to use them.

## Read text and observe changes in the editor

The most fundamental extensibility point for the Visual Studio editor is to manipulate text, either by reading the text in the editor or editing the text. These scenarios are core to any editor-based extensions. For example, to provide diagnostics information, such as warnings or errors, the extension must read the code in the editor and then interpret it. An extension also needs a way to detect when the text in the editor changed, if a new file opened, or if an open file closed.

For a walkthrough of how to make read-text and track-text changes by using `VisualStudio.Extensibility`, see [Work with text in the editor](./walkthroughs/working-with-text.md).

## Make edits to text in the editor

Any extension that aims to boost editing productivity by autoinserting text (like autogenerating a GUID and inserting it) needs APIs to define where and what to insert. The `VisualStudio.Extensibility` extension model executes code out of process and asynchronously, which requires adherence to specific principles when you develop text-editing extensions.

For a walkthrough of how to edit text by using `VisualStudio.Extensibility`, see [Change text in the editor](./walkthroughs/editing-text.md).

## Extend editor features

Extensions can also plug in to many features in the editor that provide contextual information. The following sections summarize the different features in the editor that you can extend.

### Text view margin

Extensions can contribute new text view margins to the Visual Studio editor. A text view margin is a rectangular UI control attached to a text view on one of its four sides. These UI controls offer more information at a glance, which allows developers to stay productive when they work in the editor. Many of the most popular features in the Visual Studio editor use text view margins, like zoom control, the breakpoint indicator, and the line number indicator.

For a walkthrough of how to customize text view margins with your extension, see [Extend the Visual Studio editor with a new margin](./walkthroughs/textview-margin.md).

### CodeLens

Extensions can contribute new CodeLenses to the Visual Studio editor. A CodeLens is a visual indicator that appears above lines of text to provide actionable contextual information. Examples include the number of references to a code element, results of the last unit test run, or actions to run or debug a unit test. Some common CodeLenses include the code reference CodeLens, which provides information on all the different parts of the code that reference a specific block of code. The code history CodeLens provides information on how a specific block of code changed in source control.

For a walkthrough of how to provide your own CodeLens with your extension, see [Extend the Visual Studio editor with a new CodeLens](./walkthroughs/codelens.md).

### Taggers

Extensions can contribute new taggers to the Visual Studio editor. Taggers are used to associate data with ranges of text. Other Visual Studio features (for example, [CodeLens](./walkthroughs/codelens.md) and [classification](./walkthroughs/classification.md)) consume this data.

For a walkthrough of how to provide your own taggers with your extension, see [Extend the Visual Studio editor with a new tagger](./walkthroughs/taggers.md).

## Related content

- Learn about the editor interfaces and types in [Editor concepts](editor-concepts.md).
- Review sample code for a simple editor-based extension in [DocumentSelectorSample](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/DocumentSelectorSample/).
- Advanced users might want to learn about the [Editor RPC support](editor-rpc.md).
