---
title: "Legacy Interfaces in the Editor | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy"
ms.assetid: 741d45f5-0ea3-4614-972a-8728fe054e07
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# Legacy Interfaces in the Editor
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can access the Visual Studio editor from legacy interfaces. The Visual Studio SDK includes adapters known as *shims*, which enable these interfaces to interact with the new editor. Nevertheless, we recommend that you update your legacy code to use the new editor API. Your code will perform better and you can use new technologies such as the Windows Presentation Foundation (WPF) and the Managed Extensibility Framework (MEF).  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Adapting Legacy Code to the Editor](../extensibility/adapting-legacy-code-to-the-editor.md)|Explains how to adapt your code to the new editor.|  
|[New or Changed Behavior with Editor Adapters](../extensibility/new-or-changed-behavior-with-editor-adapters.md)|Explains how the behavior of the editor adapters differs from that of earlier versions of the editor.|  
|[Inside the Core Editor](../extensibility/inside-the-core-editor.md)|Describes the different components of earlier versions of the editor.|  
|[Instantiating the Core Editor By Using the Legacy API](../extensibility/instantiating-the-core-editor-by-using-the-legacy-api.md)|Explains how to use the legacy API to instantiate the core editor.|  
|[Editor Factories](../extensibility/editor-factories.md)|Explains how to use editor factories with the legacy API.|  
|[How to: Register Editor File Types](../extensibility/how-to-register-editor-file-types.md)|Explains how to link a file name extension to your editor.|  
|[Walkthrough: Creating a Core Editor and Registering an Editor File Type](../extensibility/walkthrough-creating-a-core-editor-and-registering-an-editor-file-type.md)|Explains how to create a core editor and link a file name extension to it.|  
|[How to: Provide Context for Editors](../extensibility/how-to-provide-context-for-editors.md)|Explains how to provide context for your editor.|  
|[Language Services and the Core Editor](../extensibility/language-services-and-the-core-editor.md)|Explains the interactions between a language service and an editor.|  
|[Accessing the Text Buffer by Using the Legacy API](../extensibility/accessing-the-text-buffer-by-using-the-legacy-api.md)|Explains how to access the text buffer by using the legacy API.|  
|[Accessing theText View by Using the Legacy API](../extensibility/accessing-thetext-view-by-using-the-legacy-api.md)|Explains how to access the text view by using the legacy API.|  
|[Customizing Code Windows by Using the Legacy API](../extensibility/customizing-code-windows-by-using-the-legacy-api.md)|Explains how to customize code windows by using the legacy API.|  
|[Accessing Text Layers by Using the Legacy API](../extensibility/accessing-text-layers-by-using-the-legacy-api.md)|Explains how to access different layers of text by using the legacy API.|  
|[Using Text Markers with the Legacy API](../extensibility/using-text-markers-with-the-legacy-api.md)|Explains how to add text markers by using the legacy API.|  
|[Customizing Editor Controls and Menus by Using the Legacy API](../extensibility/customizing-editor-controls-and-menus-by-using-the-legacy-api.md)|Explains how to customize editor controls by using the legacy API.|  
|[Managing Undo and Redo by Using the Legacy API](../extensibility/managing-undo-and-redo-by-using-the-legacy-api.md)|Explains how to manage undo and redo by using the legacy API.|  
|[How to: Implement the Find and Replace Mechanism](../extensibility/how-to-implement-the-find-and-replace-mechanism.md)|Explains how to manage find and replace by using the legacy API.|  
|[How to: Suppress File Change Notifications](../extensibility/how-to-suppress-file-change-notifications.md)|Explains how to suppress file change notifications by using the legacy API.|  
|[Creating Custom Editors and Designers](../extensibility/creating-custom-editors-and-designers.md)|Explains how to create custom editors and designers.|  
|[Developing a Legacy Language Service](../extensibility/internals/developing-a-legacy-language-service.md)|Provides links to documents about features that provide customization capabilities to the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] core editor by adding support for a language service.|  
|[Using Fonts and Colors](../extensibility/using-fonts-and-colors.md)|Explains how to use fonts and colors with legacy interfaces.|
