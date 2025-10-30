---
title: Override Help Viewer defaults
description: Learn about Help Content Manager overrides, which change the default behavior of Help Viewer and help-related features in the Visual Studio IDE.
ms.date: 05/17/2022
ms.topic: how-to
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: help-viewer
---
# Override Help Viewer defaults

You can change the default behavior of Microsoft Help Viewer and help-related features in the Visual Studio IDE.

Help Content Manager is a tool that you can use to deploy and manage local Help Viewer content. To change Help Viewer behavior, you can override default settings of the Help Content Manager executable program, HlpCtntMgr.exe.

There are different ways to set Help Content Manager options:

- Create a [.pkgdef file](https://devblogs.microsoft.com/visualstudio/whats-a-pkgdef-and-why/) to set registry key values.
- Set options directly in the registry.

## Use a .pkgdef file to change Help Viewer behavior

A .pkgdef file stores configuration information that Help Viewer uses. You can use a .pkgdef file to adjust the registry key values that the following table lists:

|Registry key value|Type|Data|Description|
|------------------|----|----|-----------|
|NewContentAndUpdateService|string|\<service endpoint URL\>|Define a unique service endpoint|
|UseOnlineHelp|dword|`0` to specify local Help, `1` to specify online Help|Define online or offline Help default|
|OnlineBaseUrl|string|\<service endpoint URL\>|Define a unique F1 endpoint|
|OnlineHelpPreferenceDisabled|dword|`0` to enable or `1` to disable online Help preference option|Disable online Help preference option|
|DisableManageContent|dword|`0` to enable or `1` to disable the **Manage Content** tab in Help Viewer|Disable the **Manage Content** tab|
|DisableFirstRunHelpSelection|dword|`0` to enable or `1` to disable help features that are configured the first time that Visual Studio starts|Disable installation of content at first launch of Visual Studio|

To set registry key values in a .pkgdef file, follow these steps:

1. Create a new file, and give it the extension *.pkgdef*.

1. Add the following text to the file's first line:

   `[$RootKey$\Help]`

1. On separate lines, add any of the registry key values that the previous table describes. For instance, you might add this line to configure the `UseOnlineHelp` value:

   `"UseOnlineHelp"=dword:00000001`

1. Copy the file to the *CommonExtensions* folder of your installation of Visual Studio. For instance:

   - If you use the Community edition of Visual Studio 2017, add the .pkgdef file to this folder:

     *C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\CommonExtensions*

   - If you use the Community edition of Visual Studio 2022, add the .pkgdef file to this folder:

     *C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\CommonExtensions*

1. At a developer command prompt, run this command:

   `devenv /updateconfiguration`

### Example .pkgdef file contents

```pkgdef
[$RootKey$\Help]
"NewContentAndUpdateService"="https://some.service.endpoint"
"UseOnlineHelp"=dword:00000001
"OnlineBaseUrl"="https://some.service.endpoint"
"OnlineHelpPreferenceDisabled"=dword:00000000
"DisableManageContent"=dword:00000000
"DisableFirstRunHelpSelection"=dword:00000001
```

## Use Registry Editor to change Help Viewer behavior

You can control the following types of behavior by setting registry key values in the Registry Editor.

|Task|Registry Key|Value|Data|
|----------|-----|------|----|
|Override BITS job priority|HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node (on a 64-bit machine)\Microsoft\Help\v2.3|BITSPriority|**foreground**, **high**, **normal**, or **low**|
|Point to local content store on network share|HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Help\ v2.3\Catalogs\VisualStudio15|LocationPath|*ContentStoreNetworkShare*|

## Related content

- [Help Viewer administrator guide](../help-viewer/administrator-guide.md)
- [Command-line arguments for the Help Content Manager](../help-viewer/command-line-arguments.md)
- [Microsoft Help Viewer](../help-viewer/overview.md)
