---
title: Install local help documentation
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords:
  - "hv_manage"
helpviewer_keywords:
  - "changing content installation source [Help Viewer]"
  - "updating local content [Help Viewer]"
  - "Help Viewer, content installation source"
  - "Help Viewer, updating local content"
  - "Help Viewer, changing content installation source"
  - "installing local content [Help Viewer]"
  - "content installation source [Help Viewer]"
  - "downloading content [Help Viewer]"
  - "removing local content [Help Viewer]"
  - "Help Viewer, removing local content"
  - "Help Viewer, installing local content"
  - "Help Viewer, downloading content"
ms.assetid: efd9df4c-2e69-4c50-992c-9678a8d8cf19
author: ghogen
ms.author: ghogen
manager: jillfra
ms.workload:
  - "multiple"
---
# Install and manage local content

By using the Microsoft Help Viewer, you can add, remove, update, and move the Help content that is installed on your computer to fit your software development needs.

To manage content on your local computer, you must log on with an account that has administrator permissions. In addition, you might not be able to manage local content if you work in an enterprise environment, because system administrators might make those decisions for your organization. For more information, see the [Help Viewer administrator guide](../help-viewer/administrator-guide.md).

## Change the content installation source

By default, Help Viewer installs content by using a Microsoft online service as the source. You generally shouldn't change your content source unless you work in an enterprise environment for which a system administrator has already installed content in another location.

### To change the content installation source

1. On the **Manage Content** tab, choose the **Disk** option button.

    > [!NOTE]
    > The **Disk** option isn't available if your administrator has prevented you from modifying the content installation source. For more information, see the [Help Viewer administrator guide](../help-viewer/administrator-guide.md).

2. Perform one of the following steps:

    - Enter the path of an *.msha* file or the URL of a service endpoint.

    - Choose the Browse (**...**) button to navigate to an *.msha* file.

    - In the list, choose the entry that was used most recently.

## Download and install content locally

If you download and install content on your local computer, you can view topics when you don't have an internet connection.

> [!IMPORTANT]
> To install content, you must log on with an account that has administrative permissions.

> [!NOTE]
> If the Visual Studio IDE is set to a language other than English, you can install English content, localized content, or both. However, no content appears if you install only the English version and the **Include English content in all navigation tabs and F1 requests** check box in the **Viewer Options** dialog box is cleared.

### To download and install content

1. Choose the **Manage Content** tab.

2. In the content list, choose the **Add** link next to the book or books that you want to download and install.

     The book is added to the **Pending changes** list, and the estimated size of the book or books that you specified appears below that list. Because some books share topics, the total download size of multiple books might be smaller than the result of adding together the sizes of every book that you specified.

3. Choose the **Update** button.

     The book or books that you specified are installed along with any updates for books that you already have on your computer. Installation times vary, but you can view the progress in the status bar.

## Remove local content

You can save disk space by removing unwanted content from your computer.

> [!IMPORTANT]
> You must have administrative permissions to remove content.

> [!NOTE]
> No content appears if the Visual Studio IDE is set to a language other than English, you remove localized content, and the **Include English content in all navigation tab and F1 requests** check box in the **Viewer Options** dialog box is cleared.

### To remove content

1. Choose the **Manage Content** tab.

2. In the content list, choose the **Remove** link next to the book or books that you want to remove.

     The book is added to the **Pending changes** list.

3. Choose the **Update** button.

     The book or books that you specified are removed from your computer.

## Update local content

The status bar indicates when updates to your installed content are available.

> [!IMPORTANT]
> If you want the **Help Viewer** to automatically check for online updates, you must open the **Viewer Options** dialog box and then select the **Go online to check for content updates** check box.

### To update local content

- In the lower-right corner of the status bar, choose the **Click here to download now** link.

Update times can vary, but you can view the update progress in the status bar.

## Move local content

You can save disk space by moving installed content from your local computer to a network share or to another partition on your local computer.

> [!IMPORTANT]
> To move content, you must log on with an account that has administrative permissions.

### To move local content

1. On the **Manage Content** tab, choose the **Move** button under **Local Store Path**.

     The **Move Content** dialog box opens.

2. In the **To** text box, enter a different location for the content, and then choose the **OK** button.

3. Choose the **Close** button when the content has been moved.

## See also

- [Microsoft Help Viewer](../help-viewer/overview.md)