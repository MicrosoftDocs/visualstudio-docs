---
title: "How to: Save and Open Files with Encoding | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "Unicode, bi-directional language support"
  - "files, encoding"
  - "bi-directional language support, encoded files"
  - "file encoding, bi-directional languages"
ms.assetid: cb52b732-b395-4ba1-a3ef-104b3942a12a
caps.latest.revision: 9
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Save and Open Files with Encoding
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can save files with specific character encoding to support bi-directional languages. You can also specify an encoding when opening a file, so that Visual Studio displays the file correctly.

### To save a file with encoding

1. From the **File** menu, choose **Save File As**, and then click the drop-down button next to the **Save** button.

     The **Advanced Save Options** dialog box is displayed.

2. Under **Encoding**, select the encoding to use for the file.

3. Optionally, under **Line endings**, select the format for end-of-line characters.

     This option is useful if you intend to exchange the file with users of a different operating system.

     If you want to work with a file that you know is encoded in a specific way, you can tell Visual Studio to use that encoding when opening the file. The method you use depends on whether the file is part of your project.

### To open an encoded file that is part of a project

1. In **Solution Explorer**, right-click the file and choose **Open With**.

2. In the **Open With** dialog box, choose the editor to open the file with.

     Many Visual Studio editors, such as the forms editor, will auto-detect the encoding and open the file appropriately. If you choose an editor that allows you to choose an encoding, the **Encoding** dialog box is displayed.

3. In the **Encoding** dialog box, select the encoding that the editor should use.

### To open an encoded file that is not part of a project

1. On the **File** menu, point to **Open**, choose **File** or **File From Web**, and then select the file to open.

2. Click the drop-down button next to the **Open** button and choose **Open With**.

3. Follow Steps 2 and 3 from the preceding procedure.

## See Also
 [Encoding and Windows Forms Globalization](https://msdn.microsoft.com/library/22e8965d-a712-42b3-8167-3ee346bd70f9)
 [Globalizing and Localizing Applications](../ide/globalizing-and-localizing-applications.md)
