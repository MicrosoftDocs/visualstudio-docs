---
title: Extending the Editor and Language Services
description: You can add language service features to an editor and extend features of the Visual Studio code editor. Learn about the Managed Extensibility Framework.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- editors [Visual Studio SDK], new -
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Extend the editor and language services

You can add language service features (such as IntelliSense) to your own editor, and extend most features of the Visual Studio code editor.  For a full list of what you can extend, see [Language service and editor extension points](../extensibility/language-service-and-editor-extension-points.md).

 You extend most editor features by using the Managed Extensibility Framework (MEF). For example, if the editor feature you want to extend is syntax coloring, you can write a MEF *component part* that defines the classifications for which you want different coloring and how you want them handled. The editor also supports multiple extensions of the same feature.

 The editor presentation layer is based the Windows Presentation Framework (WPF). WPF provides a graphics library for flexible text formatting, and also provides visualizations such as graphics and animations.

 The Visual Studio SDK provides adapters known as *shims* to support VSPackages that were written for earlier versions. Nevertheless, if you have an existing VSPackage, we recommend that you update it to the new technology to obtain better performance and reliability.

## Related Topics

|Title|Description|
|-----------|-----------------|
|[Get started with language service and editor extensions](../extensibility/getting-started-with-language-service-and-editor-extensions.md)|Explains how to create an extension to the editor.|
|[Inside the editor](../extensibility/inside-the-editor.md)|Describes the general structure of the editor, and lists some of its features.|
|[Managed Extensibility Framework in the editor](../extensibility/managed-extensibility-framework-in-the-editor.md)|Explains how to use the Managed Extensibility Framework (MEF) with the editor.|
|[Language service and editor extension points](../extensibility/language-service-and-editor-extension-points.md)|Lists the extension points of the editor. Extension points represent the editor features that can be extended.|
|[Walkthrough: Create a view adornment, commands, and settings (column guides)](../extensibility/walkthrough-creating-a-view-adornment-commands-and-settings-column-guides.md)|Walks through and explains building a view adornment that draws column guide lines to help you keep code to a certain display width.  Also shows reading and writing settings as well as declaring and implementing commands that you can invoke from the Command Window.|
|[Editor imports](../extensibility/editor-imports.md)|Lists the services that an extension can import.|
|[Adapt legacy code to the editor](/previous-versions/visualstudio/visual-studio-2015/extensibility/adapting-legacy-code-to-the-editor?preserve-view=true&view=vs-2015)|Explains different ways to adapt legacy code (pre-Visual Studio 2010) to extend the editor.|
|[Migrate a legacy language service](/previous-versions/visualstudio/visual-studio-2017/extensibility/internals/migrating-a-legacy-language-service)|Explains how to migrate a VSPackage based language service.|
|[Walkthrough: Link a content type to a file name extension](../extensibility/walkthrough-linking-a-content-type-to-a-file-name-extension.md)|Shows how to link a content type to a file name extension.|
|[Walkthrough: Create a margin glyph](../extensibility/walkthrough-creating-a-margin-glyph.md)|Shows how to add an icon to a margin.|
|[Walkthrough: Highlight text](../extensibility/walkthrough-highlighting-text.md)|Shows how to use *tags* to highlight text.|
|[Walkthrough: Add outlining](../extensibility/walkthrough-outlining.md)|Shows how to add outlining for specific kinds of braces.|
|[Walkthrough: Display matching braces](../extensibility/walkthrough-displaying-matching-braces.md)|Shows how to highlight matching braces.|
|[Walkthrough: Display QuickInfo tooltips](../extensibility/walkthrough-displaying-quickinfo-tooltips.md)|Shows how to display QuickInfo popups that describe elements of code such as properties, methods, and events.|
|[Walkthrough: Display signature help](../extensibility/walkthrough-displaying-signature-help.md)|Shows how to display popups that give information about the number and types of parameters in a signature.|
|[Walkthrough: Display statement completion](../extensibility/walkthrough-displaying-statement-completion.md)|Shows how to implement statement completion.|
|[Walkthrough: Implement code snippets](../extensibility/walkthrough-implementing-code-snippets.md)|Shows how to implement code-snippet expansion.|
|[Walkthrough: Display light bulb suggestions](../extensibility/walkthrough-displaying-light-bulb-suggestions.md)|Shows how to display light bulbs for code suggestions.|
|[Walkthrough: Use a shell command with an editor extension](../extensibility/walkthrough-using-a-shell-command-with-an-editor-extension.md)|Shows how to associate a menu command in a VSPackage with a MEF component.|
|[Walkthrough: Use a shortcut key with an editor extension](../extensibility/walkthrough-using-a-shortcut-key-with-an-editor-extension.md)|Shows how to associate a menu shortcut in a VSPackage with a MEF component.|
|[Managed Extensibility Framework (MEF)](/dotnet/framework/mef/index)|Provides information about the Managed Extensibility Framework (MEF).|
|[Windows Presentation Foundation](/dotnet/framework/wpf/index)|Provides information about the Windows Presentation Foundation (WPF).|

## Reference
 The Visual Studio editor includes the following namespaces.

 <xref:Microsoft.VisualStudio.Language.Intellisense>

 <xref:Microsoft.VisualStudio.Language.StandardClassification>

 <xref:Microsoft.VisualStudio.Editor>

 <xref:Microsoft.VisualStudio.Text>

 <xref:Microsoft.VisualStudio.Text.Adornments>

 <xref:Microsoft.VisualStudio.Text.Classification>

 <xref:Microsoft.VisualStudio.Text.Differencing>

 <xref:Microsoft.VisualStudio.Text.Document>

 <xref:Microsoft.VisualStudio.Text.Editor>

 <xref:Microsoft.VisualStudio.Text.Editor.OptionsExtensionMethods>

 <xref:Microsoft.VisualStudio.Text.Formatting>

 <xref:Microsoft.VisualStudio.Text.IncrementalSearch>

 <xref:Microsoft.VisualStudio.Text.Operations>

 <xref:Microsoft.VisualStudio.Text.Outlining>

 <xref:Microsoft.VisualStudio.Text.Projection>

 <xref:Microsoft.VisualStudio.Text.Tagging>

 <xref:Microsoft.VisualStudio.Utilities>