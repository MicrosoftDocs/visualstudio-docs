---
title: Save and open files with encoding
description: Learn how to save and open files with specific encoding in Visual Studio, and ensure files open correctly in subsequent use.
ms.date: 01/13/2025
ms.topic: how-to
helpviewer_keywords:
- Unicode, bidirectional language support
- files, encoding
- bidirectional language support, encoded files
- file encoding, bidirectional languages
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide

#customer intent: As a developer, I want to save and open files with specific encoding in Visual Studio, so I can ensure my files open correctly.
---

# Save and open files with encoding

You can save files with specific character encoding in Visual Studio to support bidirectional languages. You can also specify an encoding when you open a file to ensure Visual Studio displays the file correctly.

## Prerequisites

- Visual Studio. If you don't have Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) page to install it for free.

## Save file with encoding

Follow these steps to save your file with encoding:

1. In Visual Studio, select **File** > **Save <Filename\> As** for the file you want to save.

1. In the **Save File As** dialog, expand the **Save** dropdown menu and select **Save with Encoding**:

   :::image type="content" source="./media/save-with-encoding.png" border="false" alt-text="Screenshot that shows how to select the option to save a file with encoding in Visual Studio.":::

1. In the **Advanced Save Options** dialog, use the **Encoding** dropdown list to select the desired encoding for the file.

1. (Optional) Use the **Line endings** dropdown list to select the desired format for end-of-line characters.

   This option is useful if you intend to exchange the file with users of a different operating system.

   If you want to work with a file with a specific encoding, you can instruct Visual Studio to use that encoding when it opens the file. The method you use depends on whether the file is part of your project.

1. To save the file, select **OK**.

> [!NOTE]
> To save the project file with encoding, first unload the project. The **Save File As** option isn't enabled until you unload the project.

::: moniker range=">= vs-2022"
## Set the default encoding

Starting in Visual Studio 2022 version 17.13 Preview 1, you can set the default encoding for saving files.

To set the default, choose **Tools** > **Options** > **Environment**, **Documents**. Next, select **Save files with a specific encoding**, and then select the encoding you want as the default.
::: moniker-end

## Open encoded file with project

To open an encoded file located within a project, follow these steps:

1. In Visual Studio **Solution Explorer**, right-click the file and select **Open With**.

1. In the **Open With** dialog, select the program to open the file, and select **OK**.

   Many Visual Studio editors, such as the forms editor, can autodetect the encoding and open the file appropriately.
   
   If you choose an editor that allows you to specify an encoding, the **Encoding** dialog opens:

   - In the **Encoding** dialog, select the encoding for the editor to use, and select **OK**.

Visual Studio opens your file.

## Open encoded file without project

To open an encoded file *not* located within a project, follow these steps:

1. In Visual Studio, select **File** > **Open**, and then select **File**.

1. In the **Open File** dialog, browse to the file to open, and select the file.

1. Expand the **Open** dropdown menu and select **Open With**.

1. To complete this process, follow Step 2 in the [previous procedure](#open-encoded-file-with-project).

## Related content

- [Encoding and line breaks](encodings-and-line-breaks.md)
- [Encoding and Windows Forms globalization](/previous-versions/visualstudio/visual-studio-2010/401dkz3c(v=vs.100))
- [Globalize and localize applications](../ide/globalizing-and-localizing-applications.md)
