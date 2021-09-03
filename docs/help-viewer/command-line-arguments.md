---
title: Command-line arguments for the Help Content Manager
description: Use command-line arguments for the Help Content Manager (HlpCtntMgr.exe) to specify how to deploy and manage local Help content.
ms.date: 11/01/2017
ms.topic: reference
ms.assetid: 3aa9890a-1147-42ba-adea-17935d184038
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-help-viewer
ms.workload:
  - "multiple"
---
# Command-line arguments for the Help Content Manager

You can specify how to deploy and manage local Help content by using command-line arguments for Help Content Manager (*HlpCtntMgr.exe*). You must run scripts for this command-line tool with administrator permissions, and you can't run these scripts as a service. You can perform the following tasks by using this tool:

- Add or update local Help content from a disk or the cloud.

- Remove local Help content.

- Move the local Help content store.

- Add, update, remove, or move local Help content silently.

Syntax:

```cmd
HlpCtntmgr.exe /operation Value /catalogname CatalogName /locale Locale /sourceuri InstallationPoint
```

For example:

```cmd
hlpctntmgr.exe /operation install /catalogname VisualStudio15 /locale en-us /sourceuri d:\productDocumentation\HelpContentSetup.msha
```

>[!NOTE]
> The catalog name is VisualStudio15 for both Visual Studio 2017 and Visual Studio 2019. This might be unexpected, but this is because the same Help Viewer is used for both Visual Studio versions.

## Switches and arguments

The following table defines the switches and arguments that you can use for the command-line tool for Help Content Manager:

|Switch|Required?|Arguments|
|------------|---------------|---------------|
|/operation|Yes|-   **Install**--Adds books from the specified installation source to the local content store.<br />     This switch requires the /booklist argument, the /sourceURI argument, or both. If you don't specify the /sourceURI argument, the default Visual Studio URI is used as the installation source. If you don't specify the /booklist argument, all books on the /sourceUri are installed.<br />-   **Uninstall**--Removes the books that you specify from the local content store.<br />     This switch requires the /booklist argument or the /sourceURI argument.  If you specify the /sourceURI argument, all books are removed, and the /booklist argument is ignored.<br />-   **Move**--Moves the local store to the path that you specify. The default local store path is set as a directory under *%ProgramData%*<br />     This switch requires the /locationPath and /catalogName arguments. Error messages will be logged in the event log if you specify a path that isn't valid or if the drive doesn't contain enough free space to hold the content.<br />-   **Refresh**--Updates topics that have  changed since they were installed or most recently updated.<br />     This switch requires the /sourceURI argument.|
|/catalogName|Yes|Specifies the name of the content catalog. For Visual Studio 2017 and Visual Studio 2019, this is VisualStudio15.|
|/locale|No|Specifies the product locale that's used to view and manage content for the current instance of the Help viewer. For example, you specify `EN-US` for English-United States.<br /><br /> If you don't specify a locale, the locale of the operating system is used. If that locale can't be determined, `EN-US` is used.<br /><br /> If you specify a locale that isn't valid, an error message is logged in the event log.|
|/e|No|Elevates the Help Content Manager to Administrative privileges if the current user has administrative credentials.|
|/sourceURI|No|Specifies the URL from which content is installed (Service API) or the path to the content installation file (*.msha*). The URL can point to the Product Group (top-level node) or to the Product Books (leaf-level node) in a Visual Studio 2010 style endpoint. You don't need to include a slash (/) at the end of the URL. If you do include a trailing slash, it will be handled appropriately.<br /><br /> An error message is logged in the event log if you specify a file that isn't found, isn't valid, or isn't accessible or if a connection to the internet isn't available or is interrupted while content is being managed.|
|/vendor|No|Specifies the vendor for the product content that will be removed (for example, `Microsoft`). The default argument for this switch is Microsoft.|
|/productName|No|Specifies the product name for the books that will be removed. The product name is identified in the *helpcontentsetup.msha* or *books.html* files that shipped with the content. You can remove books from only one product at a time. To remove books from multiple products, you must perform multiple installations.|
|/booklist|No|Specifies the names of the books to be managed, separated by spaces. Values must match the book names as listed on the installation media.<br /><br /> If you don't specify this argument, all recommended books for the specified product in the /sourceURI are installed.<br /><br /> If the name of a book contains one or more spaces, surround it with double quotes (") so that the list is delimited appropriately.<br /><br /> Error messages will be logged if you specify a /sourceURI that isn't valid or isn't reachable.|
|/skuId|No|Specifies the stock keeping unit (SKU) of the product from the installation source, and filters books that the /SourceURI switch identifies.|
|/membership|No|-   **Minimum**-- Installs a minimum set of Help content based on the SKU that you specify by using the /skuId switch. The mapping between the SKU and the content set is exposed in the Service API.<br />-   **Recommended**—Installs a set of recommended books for the SKU that you specify by using the /skuId argument. The Installation source is the service API or *.MSHA*.<br />-   **Full**-- Installs the entire set of books for the SKU that you specify by using the /skuId argument. The Installation source is the service API or *.MSHA*.|
|/locationpath|No|Specifies the default folder for local Help content. You must use this switch only to install or move content. If you specify this switch, you must also specify the /silent switch.|
|/silent|No|Installs or removes Help content without prompting the user or displaying any UI, including the icon in the status notification area. Output is logged to a file in the *%Temp%* directory. **Important:**  To install content silently, you must use digitally signed *.cab* files, not *.mshc* files.|
|/launchingApp|No|Defines the application and catalog context when the Help viewer is launched without the parent application. The arguments for this switch are *CompanyName*, *ProductName*, and *VersionNumber* (for example, `/launchingApp Microsoft,VisualStudio,16.0`).<br /><br /> This is required for installing content with the /silent parameter.|
|/wait *Seconds*|No|Pauses install, uninstall, and refresh operations. If an operation is already in progress for the catalog, the process will wait up to the given number of seconds to continue. Use 0 to wait indefinitely.|
|/?|No|Lists the switches and their descriptions for the command-line tool for Help Content Manager.|

### Exit codes

When you run the command-line tool for the Help Content Manager in silent mode, it returns the following exit codes:

```
Success = 0,

FailureToElevate = 100
InvalidCmdArgs = 101,
FailOnFetchingOnlineContent = 110,
FailOnFetchingContentFromDisk = 120,
FailOnFetchingInstalledBooks = 130,
NoBooksToUninstall = 200,
NoBooksToInstall = 300,
FailOnUninstall = 400,
FailOnInstall = 500,
FailOnMove = 600,
FailOnUpdate = 700,
FailOnRefresh = 800,
Cancelled = 900,
Others = 999,
ContentManagementDisabled = 1200,
OnlineHelpPreferenceDisabled = 1201
UpdateAlreadyRunning = 1300 - (Signals that the update didn't run because another was in progress.)
```

## See also

- [Help Viewer administrator guide](../help-viewer/administrator-guide.md)
- [Help Content Manager overrides](../help-viewer/behavior-overrides.md)
- [Microsoft Help Viewer](../help-viewer/overview.md)