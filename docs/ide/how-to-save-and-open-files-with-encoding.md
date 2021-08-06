---
title: 'How to: Save and open files with encoding'
description: Learn how to save and open files with specific encoding so, when you open the file, Visual Studio displays the file correctly.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- Unicode, bidirectional language support
- files, encoding
- bidirectional language support, encoded files
- file encoding, bidirectional languages
ms.assetid: cb52b732-b395-4ba1-a3ef-104b3942a12a
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# How to: Save and open files with encoding

You can save files with specific character encoding to support bidirectional languages. You can also specify an encoding when opening a file, so that Visual Studio displays the file correctly.

## To save a file with encoding

1. From the **File** menu, choose **Save File As**, and then click the drop-down button next to the **Save** button.

     The **Advanced Save Options** dialog box is displayed.

2. Under **Encoding**, select the encoding to use for the file.

3. Optionally, under **Line endings**, select the format for end-of-line characters.

     This option is useful if you intend to exchange the file with users of a different operating system.

     If you want to work with a file that you know is encoded in a specific way, you can tell Visual Studio to use that encoding when opening the file. The method you use depends on whether the file is part of your project.

> [!NOTE]
> If you want to save the project file with encoding, the **Save File As** option is not enabled until you unload the project.

## To open an encoded file that is part of a project

1. In **Solution Explorer**, right-click the file and choose **Open With**.

2. In the **Open With** dialog box, choose the editor to open the file with.

     Many Visual Studio editors, such as the forms editor, will auto-detect the encoding and open the file appropriately. If you choose an editor that allows you to choose an encoding, the **Encoding** dialog box is displayed.

3. In the **Encoding** dialog box, select the encoding that the editor should use.

## To open an encoded file that is not part of a project

1. On the **File** menu, point to **Open**, choose **File** or **File From Web**, and then select the file to open.

2. Click the drop-down button next to the **Open** button and choose **Open With**.

3. Follow Steps 2 and 3 from the preceding procedure.

## See also

- [Encoding and line breaks](encodings-and-line-breaks.md)
- [Encoding and Windows Forms globalization](/dotnet/framework/winforms/advanced/encoding-and-windows-forms-globalization)
- [Globalize and localize applications](../ide/globalizing-and-localizing-applications.md)
