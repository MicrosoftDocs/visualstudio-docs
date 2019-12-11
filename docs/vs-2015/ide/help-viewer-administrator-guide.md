---
title: "Help Viewer Administrator Guide | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-help-viewer
ms.topic: conceptual
ms.assetid: 4340c69f-b96b-4932-bb82-38b16a5ab149
caps.latest.revision: 15
author: jillre
ms.author: jillfra
manager: jillfra
---
# Help Viewer Administrator Guide
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Help Viewer allows you to manage local Help installations for network environments with or without internet access. Local help content is configured on a per machine basis. By default, users must have administrator rights to update their local Help installation.

 If your network environment allows clients to access the internet, the Help Viewer allows you to use command line scripts to deploy local Help content from the internet.

 If your network environment does not allow clients to access the internet, the Help Viewer can deploy local Help content from the intranet or a network share. You can also disable Visual Studio IDE Help options, such as online/offline help, content installation at first launch of the IDE, specifying an intranet content service, and managing content, using registry key overrides.

 The basic syntax is as follows:

 \<*path to*>\HlpCtntmgr.exe /operation \<*argument*> /catalogname \<*name*> /locale \<*locale*> /sourceuri \<*.msha path or URL*>

 For more information about HlpCtntMgr.exe command line syntax, see [Command-Line Arguments for the Help Content Manager](../ide/command-line-arguments-for-the-help-content-manager.md).

 For more information about creating content, creating an intranet service endpoint, and similar types of activities, see the Help Viewer SDK.

## Deploying Local Help Content from the Internet
 You can use the MSDN Content Package service to deploy local Help content from the Internet to client computers. Use the following syntax:

 \\<*path to*>\v2.2\HlpCtntmgr.exe /operation \<*name*> /catalogname \<*catalog name*> /locale \<*locale*>

 For more information about HlpCtntMgr.exe command line syntax, see [Command-Line Arguments for the Help Content Manager](../ide/command-line-arguments-for-the-help-content-manager.md).

 Requirements:

- Client computers must have access to the Internet.

- Users must have administrator rights to update, add, or remove the local Help content after it has been installed.

  Caveats:

- The default source for Help will still be Online.

  > [!TIP]
  > You can change the default source for Help by modifying the HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\14.0\help\UseOnlineHelp registry key. For more information, see [Help Content Manager Overrides](../ide/help-content-manager-overrides.md).

- Clients will still be prompted to install the basic Help content on the first launch of Visual Studio. You can disable this prompt by modifying the HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\VisualStudio\14.0\Help\DisableFirstRunHelpSelection registry key.

### Example
 The following example installs English content for Visual Studio to a client computer.

##### To install English content from the Internet

1. Choose **Start** and then choose **Run**.

2. Type the following:

     C:\Program Files (x86)\Microsoft Help Viewer\v2.2\hlpctntmgr.exe /operation install /catalogname VisualStudio14 /locale en-us

3. Press ENTER.

## Deploying Pre-Installed Local Help Content on Client Computers
 You can install a set of content from online to one computer, and then copy that installed set of content to other computers.

 Requirements:

- The computer you install the set of content to must have access to the Internet.

- Users must have administrator rights to update, add, or remove the local Help content after it has been installed.

  > [!TIP]
  > If users do not have administrator rights, it is recommended that you disable the Manage Content tab in the Help Viewer. For more information, see [Help Content Manager Overrides](../ide/help-content-manager-overrides.md).

  Caveats:

- If users do not have administrator rights, it is recommended that you disable the Manage Content tab in the Help Viewer. For more information, see [Help Content Manager Overrides](../ide/help-content-manager-overrides.md).

- The default source for Help will still be Online.

- Clients will still be prompted to install the basic Help content on the first launch of Visual Studio. For more information, see [Help Content Manager Overrides](../ide/help-content-manager-overrides.md).

### Create the content set
 Before you can create the base content set, you must first uninstall all local Visual Studio content on the target computer.

##### To uninstall local help

1. In the Help Viewer, choose the **Manage Content** tab.

2. Under **Available Documentation**, navigate to the Visual Studio document set.

3. Choose **Remove** next to each sub-item.

4. Choose **Start** to uninstall

5. Browse to *n*:\ProgramData\Microsoft\HelpLibrary2\Catalogs\VisualStudio12 and verify that the folder only contains the file catalogType.xml.

   Once you have removed all previously installed local Visual Studio Help content, you are ready to download the base content set.

##### To download the content

1. In the Help Viewer, choose the **Manage Content** tab.

2. Under **Available Documentation**, navigate to the documentation sets you want to download and then choose **Add**.

3. Choose **Start**.

   Next, you need to package the content so it can be deployed to client computers.

##### To package the content

1. Create a folder to copy the content to for later deployment.

     For example: c:\VS12Help.

2. Open cmd.exe with Administrator permissions.

3. Navigate to the folder you created in step 1.

4. Type the following:

     Xcopy %SYSTEMDRIVE%\ProgramData\Microsoft\HelpLibrary2 \<*foldername*>\ /y /e /k /o

     For example: `Xcopy %SYSTEMDRIVE%\ProgramData\Microsoft\HelpLibrary2 c:\VS12Help\ /y /e /k /o`

### Deploying the content

##### To deploy the content

1. Create a network share and copy theee help content to that location.

     For example, copy the content in c:\VS12Help to \\\myserver\VS12Help.

2. Create a .bat file to contain the deployment script for the help content. Since the client could possibly have a read lock on any of the files being deleted as part of the push, you should have the client shut down prior to pushing updates.

     For example:

    ```
    REM - copy pre-ripped content to ProgramData
    Xcopy %~dp0HelpLibrary2 %SYSTEMDRIVE%\ProgramData\Microsoft\HelpLibrary2\ /y /e /k /o
    if ERRORLEVEL 1 ECHO *** ERROR COPYING Help Library files to Programdata (%ERRORLEVEL%)

    REM - get processor type and create/run registry update file
    IF "%PROCESSOR_ARCHITECTURE%"=="AMD64" GOTO AMD64

    @echo Architecture type is x86

    ECHO Windows Registry Editor Version 5.00 > x86.reg

    ECHO [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Help\v2.2\Catalogs] >> x86.reg
    ECHO "ContentStore"="%SYSTEMDRIVE%\\ProgramData\\Microsoft\\HelpLibrary2\\Catalogs\\" >> x86.reg

    ECHO [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Help\v2.2\Catalogs\VisualStudio12] >> x86.reg
    ECHO "LocationPath"="%SYSTEMDRIVE%\\ProgramData\\Microsoft\\HelpLibrary2\\Catalogs\\VisualStudio12\\"  >> x86.reg
    ECHO "FirstTimeRun"="False"  >> x86.reg

    ECHO [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Help\v2.2\Catalogs\VisualStudio12\en-US]  >> x86.reg
    ECHO "ContentStore"="%SYSTEMDRIVE%\\ProgramData\\Microsoft\\HelpLibrary2\\Catalogs\\VisualStudio12\\"  >> x86.reg
    ECHO "catalogName"="Visual Studio version Help Documentation"  >> x86.reg

    ECHO [HKEY_LOCAL_MACHINE\Software\Microsoft\VSWinExpress\14.0\help]  >> x86.reg
    ECHO "UseOnlineHelp"=dword:00000000  >> x86.reg

    regedit.exe /s x86.reg
    if ERRORLEVEL 1 ECHO *** ERROR inserting the x86 reg (%ERRORLEVEL%)

    GOTO CONTINUE

    :AMD64
    @echo Architecture type is AMD64

    ECHO Windows Registry Editor Version 5.00 > x64.reg

    ECHO [HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Help\v2.2\Catalogs] >> x64.reg
    ECHO "ContentStore"="%SYSTEMDRIVE%\\ProgramData\\Microsoft\\HelpLibrary2\\Catalogs\\" >> x64.reg

    ECHO [HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Help\v2.2\Catalogs\VisualStudio14] >> x64.reg
    ECHO "LocationPath"="%SYSTEMDRIVE%\\ProgramData\\Microsoft\\HelpLibrary2\\Catalogs\\VisualStudio14\\"  >> x64.reg
    ECHO "FirstTimeRun"="False"  >> x64.reg

    ECHO [HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Help\v2.2\Catalogs\VisualStudio14\en-US]  >> x64.reg
    ECHO "ContentStore"="%SYSTEMDRIVE%\\ProgramData\\Microsoft\\HelpLibrary2\\Catalogs\\VisualStudio12\\en-US\\"  >> x64.reg
    ECHO "catalogName"="Visual Studio version Help Documentation"  >> x64.reg

    ECHO [HKEY_LOCAL_MACHINE\Software\Wow6432Node\Microsoft\VSWinExpress\14.0\help]  >> x64.reg
    ECHO "UseOnlineHelp"=dword:00000000  >> x64.reg

    regedit.exe /s x64.reg
    if ERRORLEVEL 1 ECHO *** ERROR inserting the x64 reg (%ERRORLEVEL%)

    :CONTINUE
    ```

3. Run the bat file on the local machines that the Help content is to be installed onto.

## See Also
 [Command-Line Arguments for the Help Content Manager](../ide/command-line-arguments-for-the-help-content-manager.md)
 [Help Content Manager Overrides](../ide/help-content-manager-overrides.md)
