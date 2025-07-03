---
title: Deploy help locally with Help Viewer
description: Read the Microsoft Help Viewer administrator guide. Deploy local Help content from the internet, or deploy pre-installed local Help content on client computers.
ms.date: 11/01/2017
ms.topic: conceptual
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: help-viewer
---
# Deploy and manage local Help installations for network environments 

You can use Microsoft Help Viewer to install, view, and manage local documentation installs for Microsoft products and technologies on local computers. These technologies include Visual Studio, .NET, language reference, SQL Server, and Windows development. 

In this article, you learn to use the Help Viewer to deploy and manage local Help installations for network environments with or without internet access. Local help content is configured on a per machine basis. By default, users must have administrator rights to update their local Help installation.

If your network environment allows clients to access the internet, you can use the **Help Content Manager** executable to deploy local Help content from the internet. For more information about *HlpCtntMgr.exe* command line syntax, see [Command-line arguments for the Help Content Manager](../help-viewer/command-line-arguments.md).

For information about creating content, creating an intranet service endpoint, and similar types of activities, see the [Help Viewer SDK](/previous-versions/visualstudio/visual-studio-2017/extensibility/internals/microsoft-help-viewer-sdk).

If you do not have internet access in your network environment, Help Viewer can deploy local Help content from the intranet or a network share. You can also disable Visual Studio IDE Help options by using [registry key overrides](../help-viewer/behavior-overrides.md) for functionality such as:

- online versus offline help

- content installation at first launch of the IDE

- specifying an intranet content service

- managing content

## Deploy local Help content from the internet

You can use **Help Content Manager** (*HlpCtntMgr.exe*) to deploy local Help content from the internet to client computers. Use the following syntax:

```cmd
\\%ProgramFiles(x86)%\Microsoft Help Viewer\v2.3\HlpCtntmgr.exe /operation \<*name*> /catalogname \<*catalog name*> /locale \<*locale*>
```

For more information about *HlpCtntMgr.exe* command line syntax, see [Command-line arguments for the Help Content Manager](../help-viewer/command-line-arguments.md).

Requirements:

- Client computers must have access to the internet.

- Users must have administrator rights to update, add, or remove the local Help content after it has been installed.

Caveats:

- The default source for Help will still be online.

### Example

The following example installs English content for Visual Studio to a client computer.

#### To install English content from the internet

1. Choose **Start** and then choose **Run**.

2. Type the following:

     `C:\Program Files (x86)\Microsoft Help Viewer\v2.3\hlpctntmgr.exe /operation install /catalogname VisualStudio15 /locale en-us`

3. Press **Enter**.

## Deploy pre-installed local Help content on client computers

You can install a set of content from online to one computer, and then copy that installed set of content to other computers.

Requirements:

- The computer you install the set of content to must have access to the internet.

- Users must have administrator rights to update, add, or remove the local Help content after it has been installed.

    > [!TIP]
    > If users do not have administrator rights, it is recommended that you disable the **Manage Content** tab in the Help Viewer. For more information, see [Override Help Viewer defaults](../help-viewer/behavior-overrides.md).

Caveats:

- The default source for Help will still be online.

### Create the content set

Before you can create the base content set, you must first uninstall all local Visual Studio content on the target computer.

#### To uninstall local help

1. In the Help Viewer, choose the **Manage Content** tab.

2. Navigate to the Visual Studio document set.

3. Choose **Remove** next to each sub-item.

4. Choose **Update** to uninstall.

5. Browse to *%ProgramData%\Microsoft\HelpLibrary2\Catalogs\VisualStudio15* and verify that the folder only contains the file *catalogType.xml*.

   Once you have removed all previously installed local Visual Studio Help content, you are ready to download the base content set.

#### To download the content

1. In the Help Viewer, choose the **Manage Content** tab.

2. Under **Recommended Documentation** or **Available Documentation**, navigate to the documentation sets you want to download and then choose **Add**.

3. Choose **Update**.

Next, you need to package the content so it can be deployed to client computers.

#### To package the content

1. Create a folder to copy the content to for later deployment. For example: *C:\VSHelp*.

2. Open *cmd.exe* with Administrator permissions.

3. Navigate to the folder you created in step 1.

4. Type the following:

     `Xcopy %ProgramData%\Microsoft\HelpLibrary2 \<*foldername*>\ /y /e /k /o`

     For example: `Xcopy %ProgramData%\Microsoft\HelpLibrary2 c:\VSHelp\ /y /e /k /o`

### Deploy the content

1. Create a network share and copy the help content to that location.

     For example, copy the content in *C:\VSHelp* to *\\\myserver\VSHelp*.

2. Create a *.bat* file to contain the deployment script for the help content. Since the client could possibly have a read lock on any of the files being deleted as part of the push, you should have the client shut down prior to pushing updates. For example:

    ```cmd
    REM - copy pre-ripped content to ProgramData
    Xcopy %~dp0HelpLibrary2 %SYSTEMDRIVE%\ProgramData\Microsoft\HelpLibrary2\ /y /e /k /o
    if ERRORLEVEL 1 ECHO *** ERROR COPYING Help Library files to ProgramData (%ERRORLEVEL%)
    ```

3. Run the *.bat* file on the local machines that you want to install the Help content on.

## Related content

- [Command-line arguments for the Help Content Manager](../help-viewer/command-line-arguments.md)
- [Override Help Viewer defaults](../help-viewer/behavior-overrides.md)
- [Microsoft Help Viewer](../help-viewer/overview.md)
- [Help Viewer SDK](/previous-versions/visualstudio/visual-studio-2017/extensibility/internals/microsoft-help-viewer-sdk)
