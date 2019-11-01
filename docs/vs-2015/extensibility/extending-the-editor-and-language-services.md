---
title: "Extending the Editor and Language Services | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], new -"
ms.assetid: 8d04f8db-eda7-4b3e-b6eb-c06df104502a
caps.latest.revision: 23
ms.author: gregvanl
manager: jillfra
---
# Extending the Editor and Language Services
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can add language service features (such as IntelliSense) to your own editor, and extend most features of the Visual Studio code editor.  For a full list of what you can extend, see [Language Service and Editor Extension Points](../extensibility/language-service-and-editor-extension-points.md).  
  
 You extend most editor features by using the Managed Extensibility Framework (MEF). For example, if the editor feature you want to extend is syntax coloring, you can write a MEF *component part* that defines the classifications for which you want different coloring and how you want them handled. The editor also supports multiple extensions of the same feature.  
  
 The editor presentation layer is based the Windows Presentation Framework (WPF). WPF provides a graphics library for flexible text formatting, and also provides visualizations such as graphics and animations.  
  
 The Visual Studio SDK provides adapters known as *shims* to support VSPackages that were written for earlier versions. Nevertheless, if you have an existing VSPackage, we recommend that you update it to the new technology to obtain better performance and reliability.  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Getting Started with Language Service and Editor Extensions](../extensibility/getting-started-with-language-service-and-editor-extensions.md)|Explains how to create an extension to the editor.|  
|[Inside the Editor](../extensibility/inside-the-editor.md)|Describes the general structure of the editor, and lists some of its features.|  
|[Managed Extensibility Framework in the Editor](../extensibility/managed-extensibility-framework-in-the-editor.md)|Explains how to use the Managed Extensibility Framework (MEF) with the editor.|  
|[Language Service and Editor Extension Points](../extensibility/language-service-and-editor-extension-points.md)|Lists the extension points of the editor. Extension points represent the editor features that can be extended.|  
|[Walkthrough: Creating a View Adornment, Commands, and Settings (Column Guides)](../extensibility/walkthrough-creating-a-view-adornment-commands-and-settings-column-guides.md)|Walks through and explains building a view adornment that draws column gudie lines to help you keep code to a certain display width.  Also shows reading and writing settings as well as declaring and implementing commands that you can invoke from the Command Window.|  
|[Editor Imports](../extensibility/editor-imports.md)|Lists the services that an extension can import.|  
|[Adapting Legacy Code to the Editor](../extensibility/adapting-legacy-code-to-the-editor.md)|Explains different ways to adapt legacy code (pre-Visual Studio 2010) to extend the editor.|  
|[Migrating a Legacy Language Service](../extensibility/internals/migrating-a-legacy-language-service.md)|Explains how to migrate a VSPackage based language service.|  
|[Walkthrough: Linking a Content Type to a File Name Extension](../extensibility/walkthrough-linking-a-content-type-to-a-file-name-extension.md)|Shows how to link a content type to a file name extension.|  
|[Walkthrough: Creating a Margin Glyph](../extensibility/walkthrough-creating-a-margin-glyph.md)|Shows how to add an icon to a margin.|  
|[Walkthrough: Highlighting Text](../extensibility/walkthrough-highlighting-text.md)|Shows how to use *tags* to highlight text.|  
|[Walkthrough: Outlining](../extensibility/walkthrough-outlining.md)|Shows how to add outlining for specific kinds of braces.|  
|[Walkthrough: Displaying Matching Braces](../extensibility/walkthrough-displaying-matching-braces.md)|Shows how to highlight matching braces.|  
|[Walkthrough: Displaying QuickInfo Tooltips](../extensibility/walkthrough-displaying-quickinfo-tooltips.md)|Shows how to display QuickInfo popups that describe elements of code such as properties, methods, and events.|  
|[Walkthrough: Displaying Signature Help](../extensibility/walkthrough-displaying-signature-help.md)|Shows how to display popups that give information about the number and types of parameters in a signature.|  
|[Walkthrough: Displaying Statement Completion](../extensibility/walkthrough-displaying-statement-completion.md)|Shows how to implement statement completion.|  
|[Walkthrough: Implementing Code Snippets](../extensibility/walkthrough-implementing-code-snippets.md)|Shows how to implement code-snippet expansion.|  
|[Walkthrough: Displaying Light Bulb Suggestions](../extensibility/walkthrough-displaying-light-bulb-suggestions.md)|Shows how to display light bulbs for code suggestions.|  
|[Walkthrough: Using a Shell Command with an Editor Extension](../extensibility/walkthrough-using-a-shell-command-with-an-editor-extension.md)|Shows how to associate a menu command in a VSPackage with a MEF component.|  
|[Walkthrough: Using a Shortcut Key with an Editor Extension](../extensibility/walkthrough-using-a-shortcut-key-with-an-editor-extension.md)|Shows how to associate a menu shortcut in a VSPackage with a MEF component.|  
|[Managed Extensibility Framework (MEF)](https://msdn.microsoft.com/library/6c61b4ec-c6df-4651-80f1-4854f8b14dde)|Provides information about the Managed Extensibility Framework (MEF).|  
|[Windows Presentation Foundation](https://msdn.microsoft.com/library/f667bd15-2134-41e9-b4af-5ced6fafab5d)|Provides information about the Windows Presentation Foundation (WPF).|  
  
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
