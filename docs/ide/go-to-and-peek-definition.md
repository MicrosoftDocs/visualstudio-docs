---
title: View type definitions with Go To and Peek features
description: Explore the Go To Definition and Peek Definition features that enable you to easily view the definition of a type or member in Visual Studio.
ms.date: 08/21/2024
ms.topic: concept-article
helpviewer_keywords:
- code editor, view definition
- go to definition
- peek definition
- type definition [Visual Studio]
- member definition [Visual Studio]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide

#customer intent: As a developer, I want to use the Go To and Peek features in Visual Studio, so I can easily view type and member source definitions for my code.
---

# View type and member definitions

Developers often need to view the source code definitions for types or class members they use in their code. In Visual Studio, the **Go To Definition** and **Peek Definition** features let you easily view the definition of a type or member. If the source code isn't available, Visual Studio shows the metadata instead.

## Go to a definition

When you use the **Go To Definition** feature, Visual Studio locates the source code for the selected type or member. If the source code is in a different file, the file opens in a new window. Visual Studio changes the current focus to highlight the relevant entry.

:::image type="content" source="./media/go-to-definition-new-window.png" border="false" alt-text="Screenshot that shows how Go To Definition opens the source file for the selected symbol in a new window." lightbox="./media/go-to-definition-new-window.png":::

There are several ways you can access **Go To Definition**:

- Position the cursor inside the symbol name and use the **F12** function key

- Right-click the symbol name and select **Go To Definition**

- Use the **Ctrl**+**Click** keyboard/mouse shortcut on the symbol name

### Change action shortcut

You can enable or disable the **Ctrl**+**Click** shortcut for **Go To Definition** with the **Enable mouse click to perform Go To Definition** option under **Tools** > **Options** > **Text Editor** > **General**.

To change the modifier key for the shortcut, expand the **Use modifier key** dropdown list and select **Ctrl** (default), **Alt**, or **Ctrl**+**Alt**:

:::image type="content" source="./media/editor-options-go-to-definition.png" border="false" alt-text="Screenshot of the Text Editor options for the Go To Definition feature, including the 'Use modifier key' setting.":::

## Peek at a definition

The **Peek Definition** feature lets you preview the definition of a type without changing the focus from your current file in the editor. Visual Studio opens a condensed **Peek** view window for the source file in place with your current file. You can change the size of the **Peek** view window to see more of the source definition:

:::image type="content" source="./media/peek-definition-view-window.png" border="false" alt-text="Screenshot that shows how Peek Definition opens the source for the selected symbol in a peek view window within the current view." lightbox="./media/peek-definition-view-window.png":::

When you close the **Peek** view window, your current code file remains open in the editor.

There are several ways you can access **Peek Definition**:

- Position the cursor inside the symbol name and select **Alt**+**F12** function key

- Right-click the symbol name and select **Peek Definition**

- Use the **Ctrl**+**Click** keyboard/mouse shortcut on the symbol name

### Change action shortcut

You can configure the **Ctrl**+**Click** keyboard/mouse shortcut for **Go To Definition** to open the source code file in **Peek** view. Use the **Open definition in peek view** option under **Tools** > **Options** > **Text Editor** > **General**.

:::image type="content" source="./media/editor-options-peek-view.png" border="false" alt-text="Screenshot of the Text Editor options for the Peek Definition feature.":::

### Use breadcrumb path for multiple files

If you peek another definition from the open **Peek** view window, you start a breadcrumb path. You can peek forward and backward along the path by using the circles and arrows above the **Peek** view window:

:::image type="content" source="./media/peek-backward-breadcrumb.png" border="false" alt-text="Screenshot that shows the breadcrumb path of open source files for Peek Definition and the option to peek backward." lightbox="./media/peek-backward-breadcrumb.png":::

When you close the **Peek** view window, Visual Studio closes all open files in the breadcrumb path. For more information, see [View and edit code by using Peek Definition (Alt+F12)](how-to-view-and-edit-code-by-using-peek-definition-alt-plus-f12.md).

## View metadata as source code (C#)

When you try to look at the definition for a C# type or member and the source code isn't available, Visual Studio shows metadata for the symbol instead. You can see the declarations of the types and members, but not their implementations. The tab label for the window includes the symbol name followed by **[from metadata]**:

:::image type="content" source="./media/view-source-metadata.png" border="false" alt-text="Screenshot that shows how Visual Studio displays metadata only when the source code for the selected symbol isn't available." lightbox="./media/view-source-metadata.png":::

> [!NOTE]
> If you try to look at the definition for an *internal* type or member, Visual Studio doesn't display the metadata as source code, regardless of whether the referencing assembly is a *friend*. For more information, see [Friend assemblies](/dotnet/standard/assembly/friend).

### View decompiled source definitions (C#)

When the source code for the selected C# symbol isn't unavailable, you can set an option to see decompiled source definitions rather than metadata. Use the **Enable navigation to decompiled sources** option under **Tools** > **Options** > **Text Editor** > **C#** > **Advanced**.

:::image type="content" source="./media/view-source-decompiled.png" border="false" alt-text="Screenshot that shows how Visual Studio displays decompiled source code when the definition for the selected symbol isn't available." lightbox="./media/view-source-decompiled.png":::

> [!NOTE]
> Visual Studio reconstructs method bodies by using [ILSpy](https://github.com/icsharpcode/ILSpy) decompilation. The first time you access this feature, you must agree to a legal disclaimer regarding software licensing and copyright and trademark laws.

## Related content

- [Navigate your code in Visual Studio](../ide/navigating-code.md)
- [View and edit code by using Peek Definition (Alt+F12)](how-to-view-and-edit-code-by-using-peek-definition-alt-plus-f12.md)
