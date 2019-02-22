---
title: "Legacy Interfaces in the Editor | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "editors [Visual Studio SDK], legacy"
ms.assetid: 741d45f5-0ea3-4614-972a-8728fe054e07
author: "gregvanl"
ms.author: "gregvanl"
manager: jillfra
ms.workload:
  - "vssdk"
---
# Legacy interfaces in the editor
You can access the Visual Studio editor from legacy interfaces. The Visual Studio SDK includes adapters known as *shims*, which enable these interfaces to interact with the new editor. Nevertheless, we recommend that you update your legacy code to use the new editor API. Your code will perform better and you can use new technologies such as the Windows Presentation Foundation (WPF) and the Managed Extensibility Framework (MEF).

## Related topics

| Title | Description |
| - | - |
| [Adapt legacy code to the editor](../extensibility/adapting-legacy-code-to-the-editor.md) | Explains how to adapt your code to the new editor. |
| [New or changed behavior with editor adapters](../extensibility/new-or-changed-behavior-with-editor-adapters.md) | Explains how the behavior of the editor adapters differs from that of earlier versions of the editor. |
| [Inside the core editor](../extensibility/inside-the-core-editor.md) | Describes the different components of earlier versions of the editor. |
| [Instantiate the core editor by using the legacy API](../extensibility/instantiating-the-core-editor-by-using-the-legacy-api.md) | Explains how to use the legacy API to instantiate the core editor. |
| [Editor factories](../extensibility/editor-factories.md) | Explains how to use editor factories with the legacy API. |
| [How to: Register editor file types](../extensibility/how-to-register-editor-file-types.md) | Explains how to link a file name extension to your editor. |
| [Walkthrough: Create a core editor and register an editor file type](../extensibility/walkthrough-creating-a-core-editor-and-registering-an-editor-file-type.md) | Explains how to create a core editor and link a file name extension to it. |
| [How to: Provide context for editors](../extensibility/how-to-provide-context-for-editors.md) | Explains how to provide context for your editor. |
| [Language services and the core editor](../extensibility/language-services-and-the-core-editor.md) | Explains the interactions between a language service and an editor. |
| [Access the text buffer by using the legacy API](../extensibility/accessing-the-text-buffer-by-using-the-legacy-api.md) | Explains how to access the text buffer by using the legacy API. |
| [Access theText view by using the legacy API](../extensibility/accessing-thetext-view-by-using-the-legacy-api.md) | Explains how to access the text view by using the legacy API. |
| [Customize code windows by using the legacy API](../extensibility/customizing-code-windows-by-using-the-legacy-api.md) | Explains how to customize code windows by using the legacy API. |
| [Access text layers by using the legacy API](../extensibility/accessing-text-layers-by-using-the-legacy-api.md) | Explains how to access different layers of text by using the legacy API. |
| [Use text markers with the legacy API](../extensibility/using-text-markers-with-the-legacy-api.md) | Explains how to add text markers by using the legacy API. |
| [Customize editor controls and menus by using the legacy API](../extensibility/customizing-editor-controls-and-menus-by-using-the-legacy-api.md) | Explains how to customize editor controls by using the legacy API. |
| [Manage undo and redo by using the legacy API](../extensibility/managing-undo-and-redo-by-using-the-legacy-api.md) | Explains how to manage undo and redo by using the legacy API. |
| [How to: Implement the find and replace mechanism](../extensibility/how-to-implement-the-find-and-replace-mechanism.md) | Explains how to manage find and replace by using the legacy API. |
| [How to: Suppress file change notifications](../extensibility/how-to-suppress-file-change-notifications.md) | Explains how to suppress file change notifications by using the legacy API. |
| [Create custom editors and designers](../extensibility/creating-custom-editors-and-designers.md) | Explains how to create custom editors and designers. |
| [Develop a legacy language service](../extensibility/internals/developing-a-legacy-language-service.md) | Provides links to documents about features that provide customization capabilities to the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] core editor by adding support for a language service. |
| [Use fonts and colors](../extensibility/using-fonts-and-colors.md) | Explains how to use fonts and colors with legacy interfaces. |
