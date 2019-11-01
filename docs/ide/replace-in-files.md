---
title: Find and replace in files
ms.date: 11/04/2016
ms.topic: conceptual
f1_keywords:
  - "vs.findreplace.replaceinfiles"
  - "vs.replaceinfiles"
helpviewer_keywords:
  - "text searches, replacing text"
  - "find and replace"
  - "replace in files"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Replace in Files

**Replace in Files** allows you to search the code of a specified set of files for a string or expression, and change some or all of the matches found. The matches found and actions taken are listed in the **Find Results** window selected in **Result options**.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in **Help** depending on your active settings or edition. To change your settings, for example to **General** or **Visual C++** settings, choose **Tools** > **Import and Export Settings**, and then choose **Reset all settings**.

You can use any of the following methods to display **Replace in Files** in the **Find and Replace** window.

## To display Replace in Files

1. On the **Edit** menu, expand **Find and Replace**.

2. Choose **Replace in Files**.

   — or —

   If the **Find and Replace** window is already open, on the toolbar, choose **Replace in Files**.

## Find what

To search for a new text string or expression, specify it in the box. To search for any of the 20 strings that you searched for most recently, open the drop-down list and choose the string. Choose the adjacent **Expression Builder** button if you want to use one or more regular expressions in your search string. For more information, see [Use regular expressions in Visual Studio](../ide/using-regular-expressions-in-visual-studio.md).

> [!NOTE]
> The **Expression Builder** button will only be enabled if you have selected **Use Regular Expressions** under **Find options**.

## Replace With

To replace instances of the string in the **Find what** box with another string, enter the replacement string in the **Replace With** box. To delete instances of the string in the **Find what** box, leave this field blank. Open the list to display the 20 strings for which you searched most recently. Choose the adjacent **Expression Builder** button if you want to use one or more regular expressions in your replacement string. For more information, see [Use regular expressions in Visual Studio](../ide/using-regular-expressions-in-visual-studio.md).

## Look in

The option chosen from the **Look in** drop-down list determines whether **Replace in Files** searches only in currently active files or searches all files stored within certain folders. Select a search scope from the list, type a folder path, or click the **Browse (...)** button to display the **Choose Search Folders** dialog box and choose a set of folders to search. You can also type a path directly into the **Look in** box.

> [!NOTE]
> If the **Look in** option selected causes you to search a file that you have checked out from source code control, only the version of that file which has been downloaded to your local machine is searched.

## Find options

You can expand or collapse the **Find options** section. The following options can be selected or cleared:

**Match case**

When selected, the **Find Results** windows will only display instances of the **Find what** string that are matched both by content and by case. For example, a search for "MyObject" with **Match case** selected will return "MyObject" but not "myobject" or "MYOBJECT."

**Match whole word**

When selected, the **Find Results** windows will only display instances of the **Find what** string that are matched in complete words. For example, a search for "MyObject" will return "MyObject" but not "CMyObject" or "MyObjectC."

**Use Regular Expressions**

When this check box is selected, you can use special notations to define patterns of text in the **Find what** or **Replace with** text boxes. For a list of these notations, see [Use regular expressions in Visual Studio](../ide/using-regular-expressions-in-visual-studio.md).

**Look at these file types**

This list indicates the types of files to search through in the **Look in** directories. If this field is left blank, all of the files in the **Look in** directories will be searched. Select any item in the list to enter a preconfigured search string that will find files of those particular types.

## Result options

You can expand or collapse the **Result options** section. The following options can be selected or cleared:

**Find Results 1** window

When selected, the results of the current search will replace the content of the **Find Results 1** window. This window opens automatically to display your search results. To open this window manually, select **Other Windows** from the **View** menu and choose **Find Results 1**.

**Find Results 2** window

When selected, the results of the current search will replace the content of the **Find Results 2** window. This window opens automatically to display your search results. To open this window manually, select **Other Windows** from the **View** menu and choose **Find Results 2**.

**Display file names only**

When this check box is selected, the **Find Results** windows list the full names and paths for all files that contain the search string. However, the results don't include the line of code where the string appears. This check box is available for **Find in Files** only.

**Keep modified files open after Replace All**

When selected, leaves open all files in which replacements have been made, so you can undo or save the changes. Memory constraints might limit the number of files that can remain open after a replace operation.

> [!CAUTION]
> You can use **Undo** only on files that remain open for editing. If this option is not selected, files that were not already open for editing will remain closed, and no **Undo** option will be available in those files.

## See also

- [Find and replace text](../ide/finding-and-replacing-text.md)
- [Find in files](../ide/find-in-files.md)
- [Visual Studio commands](../ide/reference/visual-studio-commands.md)
