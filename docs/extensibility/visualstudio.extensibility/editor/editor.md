---
title: Editor overview
description: An overview of the editor-based extensions for the Visual Studio IDE
ms.date: 3/31/2023
ms.topic: conceptual
ms.author: maiak
monikerRange: ">=vs-2022"
author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---

# Extending the Visual Studio editor

The Visual Studio editor supports extensions that add to its capabilities. Examples include extensions that insert and modify code in an existing language, or customizing the behavior of certain editor features like CodeLens.

The Visual Studio editor generally refers to the functionality of editing text files, known as documents, of any type. Individual files may be opened for editing, and the open editor window is referred to as a `TextView`.

The editor object model is described at [Editor concepts](editor-concepts.md).

The following sections summarize the high level editor extensibility scenarios that VisualStudio.Extensibility supports. However, because each of these scenarios are rich in concepts and APIs, a separate, more detailed section will be linked to provide a more in-depth explanation of the APIs and how to use them.

## Reading text and observing changes in the editor
The most fundamental extensibility point for the Visual Studio editor is to manipulate text, either reading the text in the editor, or editing the text. These scenarios are core to any editor based extensions. For example, in order to provide diagnostics information such as warnings or errors, the extension has to read the code that's in the editor, and then interpret it. An extension also needs a way to detect when the text in the editor is being changed, or if there's a new file being opened, or an open file is being closed. 

For detailed walkthrough of how to do read text and track text changes using VisualStudio.Extensibility, refer to [Working with text in the editor](./walkthroughs/working-with-text.md)

## Making edits to text in the editor
Any extension that aims to boost editing productivity by auto inserting text (like auto-generating a GUID and inserting it) needs APIs to define where and what to insert. However, the VisualStudio.Extensibility extension model executes code out of process and asynchronously, requiring adherence to specific principles when developing text-editing extensions.

For detailed walkthrough of how to edit text using VisualStudio.Extensibility, refer to [Changing text in the editor](./walkthroughs/editing-text.md)

## Extending editor features
Besides manipulating text, extensions can also plugin into many features in the editor that provide contextual information. The following sections summarize the different features in the editor that can be extended. 

### Text view margin
Extensions can contribute new text view margins to the Visual Studio editor. A text view margin is a rectangular UI control attached to a text view on one of its four sides. These UI controls offer additional information at a glance, which allows developers to stay productive working in the editor. Many of the most popular features in the Visual Studio editor utilize text view margins, like the zoom control, breakpoint indicator, line number indicator, and many more.

For detailed walkthough of how to customize text view margin with your extension, refer to [Extending Visual Studio editor with a new margin](./walkthroughs/textview-margin.md)

### CodeLens
Extensions can contribute new CodeLenses to the Visual Studio editor. A CodeLens is a visual indicator displayed above lines of text providing actionable contextual information such as number of references to a code element, results of the last unit test run or actions to run/debug a unit test. Some common CodeLenses include code reference CodeLens, which provide information on all the different parts of the code that reference a particular block of code, or the code history CodeLens, which provide information on how the particular block of code has been changed in source control.

For detailed walkthrough of how to provide your own CodeLens with your extension, refer to [Extending Visual Studio editor with a new CodeLens](./walkthroughs/codelens.md)

### Taggers
Extensions can contribute new taggers to the Visual Studio editor. Taggers are used to associate data with spans of text, such data is consumed by other Visual Studio features (E.g., CodeLens).

For detailed walkthrough of how to provide your own taggers with your extension, refer to [Extending Visual Studio editor with a new tagger](./walkthroughs/taggers.md)

## Related content

Learn about the editor interfaces and types at [Editor concepts](editor-concepts.md).

Review sample code for a simple editor-based extension:

- [DocumentSelectorSample](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/DocumentSelectorSample/)

Advanced users might wish to learn about the [Editor RPC support](editor-rpc.md).
