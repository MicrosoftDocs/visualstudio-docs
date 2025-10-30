---
title: Feedback to the User
description: Learn how to provide visual feedback to the user about available functionality in the Visual Studio integrated development environment (IDE).
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- user model feedback
- environment, context
- IDE, context
- IDE, user feedback
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Feedback to the user

In the Visual Studio integrated development environment (IDE), visual feedback regarding available functionality is based on the user's current selection and global selection context. The following table lists the functionality that is available in different selection contexts.

|Selection context|Available functionality|
|-----------------------|-----------------------------|
|IDE|Global|
|Current product set|Product specific|
|Active hierarchy|Hierarchy type specific|
|Active hierarchy item|Hierarchy item type specific|
|Active document|Document type specific|
|Topmost multiple-document interface (MDI) window|Window type specific|
|Current selection context|Selection context specific|

 If you only surface the functionality users need and continually provide consistent selection and environment context feedback, you reduce the complexity in the IDE. The following rules apply whenever a window is opened in the IDE:

- If the window changes its selection context, selection feedback is clearly indicated in the window, and the **Dynamic Help** window, if shown, is updated to reflect the current context.

- If the window changes global selection context, all context-specific menus, the active hierarchy window, and the application title bar are updated to reflect the current context.

- The window should surface properties for the current selection in the **Properties** window and optionally, if shown, the **Property Pages** dialog box.

- If the window does not surface properties or change global selection context, selection feedback should not remain in the window when it is no longer the active window in the IDE.

- All document-specific tool windows should continually reflect the active document.

- Menus, toolbars, and the application title bar should reflect the topmost multiple-document interface (MDI) client window.

  For example, when the HTML view of a **Web Form** inside a Visual Basic Web Application project is opened and the user selects a `<td>` tag, feedback is provided in the following manner:

- Selection is indicated in the active window and reflected in the **Properties** window.

- The document-specific **Toolbox** is updated to reflect the active document.

- The **Editor** toolbar and **Table** menu are displayed and the title bar updates to reflect the Web Form window.

- The active hierarchy window, which is typically **Solution Explorer**, and its title bar update to reflect the current context and the context-sensitive **Project** menu commands now apply to the active Web Application project.

## Related content
- [Selection and currency in the IDE](../../extensibility/internals/selection-and-currency-in-the-ide.md)
- [Selection context objects](../../extensibility/internals/selection-context-objects.md)
- [Hierarchies in Visual Studio](../../extensibility/internals/hierarchies-in-visual-studio.md)
