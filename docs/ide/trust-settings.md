---
# required/recommended metadata

title: Trust Settings for Files and Folders
description: Learn how to change trust settings for files and folders to keep Visual Studio secure.
author: abuchholtzau
ms.author: allisb
ms.date: 08/23/2018
ms.topic: reference
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
helpviewer_keywords: 
    - VS.ToolsOptionsPages.Environment.PathTrustOptions
    - "file security"
    - "folder security"
    - "mark of the web"
    - "trusted files"
    - "trusted folders"

# optional metadata

#ROBOTS:
#keywords:
#ms.devlang: [LANGUAGES]
#manager: [MICROSOFT ALIAS]

---
# Configure trust settings for files and folders

In previous versions of Visual Studio, projects with the Mark of the Web were blocked from opening until the user explicitly apporved them. To help you keep your Visual Studio secure, we've extended this type of check to include the opening of files and folders.

These additional checks are disabled by default.

> [!WARNING]
> You should still ensure any files, folders or solutions come from a trusted person or a trusted location before approving them. 

## Configure your trust settings
To change your trust settings, follow these steps:

1. Open **Tools** > **Options** > **Trust Settings** and click on the _Configure Trust Settings_ link in the pane.
2. Choose what level of checks you'd like for files and folders. You can have different checks for each one. Your options are:
    1. No verification: Visual Studio will not perform any checks.
    2. Verify mark of the web attribute: Visual Studio will block and ask for permission to open if the file or folder has the mark of the web attribute.
    3. Verify path is trusted: Visual Studio will block and ask for permission to open if the file or folder path is not part of the Trusted Paths list.

![Trust verification options](../media/trustsettings-verification.png)

## Add trusted paths
To add trusted paths, follow these steps:

1.  Open **Tools** > **Options** > **Trust Settings** and click on the _Configure Trust Settings_ link in the pane.
2.  Click **Add** in the Trust Settings dialog and select **File** or **Folder**.
3.  Navigate to and select the file or folder you'd like to add to the trusted list using the File/Folder Explorer.
4.  Your path will now appear in the Trusted Paths list.

![Added trusted paths](../media/trustsettings.png)

## Remove trusted paths
To remove trusted paths, follow these steps:
1.  Open **Tools** > **Options** > **Trust Settings** and click on the _Configure Trust Settings_ link in the pane.
2.  Select the path you'd like to remove in the Trusted Paths list and click **Remove** in the Trust Settings dialog.
    * To select multiple entries, hold down **Shift** as you click on the paths.
3.  The selected path(s) will disappear from the Trusted Paths list. 
