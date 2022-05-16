---
title: Help Content Manager overrides
description: Learn about Help Content Manager overrides, which change the default behavior of Help Viewer and help-related features in the Visual Studio IDE.
ms.date: 11/01/2017
ms.topic: conceptual
ms.assetid: 95fe6396-276b-4ee5-b03d-faacec42765f
author: jasonchlus
ms.author: jasonchlus
manager: jmartens
ms.technology: vs-help-viewer
ms.workload:
  - "multiple"
---
# Help Content Manager overrides

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

You can change the default behavior of Help Viewer and help-related features in the Visual Studio IDE. Some options are specified by creating a [.pkgdef](https://devblogs.microsoft.com/visualstudio/whats-a-pkgdef-and-why/) file to set various registry key values. You can set other options directly in the registry.

## Use a .pkgdef file to change Help Viewer behavior

1. Create a *.pkgdef* file with this text on the first line:

   `[$RootKey$\Help]`

2. Add any or all of the registry key values described in the table below on separate lines. For instance, you might add the following line to configure the `UseOnlineHelp` value:

   `"UseOnlineHelp"=dword:00000001`

3. Copy the file to *%ProgramFiles(x86)%\Microsoft Visual Studio\2017\\<edition\>\Common7\IDE\CommonExtensions*.

4. At a developer command prompt, run this command:

   `devenv /updateconfiguration`

### Registry key values

|Registry key value|Type|Data|Description|
|------------------|----|----|-----------|
|NewContentAndUpdateService|string|\<http URL for service endpoint\>|Define a unique service endpoint|
|UseOnlineHelp|dword|`0` to specify local Help, `1` to specify online Help|Define online or offline Help default|
|OnlineBaseUrl|string|\<http URL for service endpoint\>|Define a unique F1 endpoint|
|OnlineHelpPreferenceDisabled|dword|`0` to enable or `1` to disable online Help preference option|Disable online Help preference option|
|DisableManageContent|dword|`0` to enable or `1` to disable the **Manage Content** tab in Help Viewer|Disable the **Manage Content** tab|
|DisableFirstRunHelpSelection|dword|`0` to enable or `1` to disable help features that are configured the first time that Visual Studio starts|Disable installation of content at first launch of Visual Studio|

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
|Point to local content store on network share|HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Help\ v2.3\Catalogs\VisualStudio15|LocationPath|"*ContentStoreNetworkShare*"|

## See also

- [Help Viewer administrator guide](../help-viewer/administrator-guide.md)
- [Command-line arguments for the Help Content Manager](../help-viewer/command-line-arguments.md)
- [Microsoft Help Viewer](../help-viewer/overview.md)