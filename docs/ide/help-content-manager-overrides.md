---
title: "Help Content Manager Overrides | Microsoft Docs"
ms.custom: ""
ms.date: "11/01/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-help-viewer"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 95fe6396-276b-4ee5-b03d-faacec42765f
caps.latest.revision: 9
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Help Content Manager Overrides
You can change the default behavior of the Help Viewer and Help-related features in the Visual Studio IDE. Some options are specified by creating a [.pkgdef](https://blogs.msdn.microsoft.com/visualstudio/2009/12/18/whats-a-pkgdef-and-why/) file to set various registry key values. Others are set directly in the registry.

## How to control Help Viewer behavior by using a .pkgdef file

1. Create a .pkgdef file with the first line as `[$RootKey$\Help]`.

2. Add any or all of the registry key values described in the table below on separate lines, for example `“UseOnlineHelp”=dword:00000001`.

3. Copy the file to %ProgramFiles(x86)%\Microsoft Visual Studio\2017\\<edition\>\Common7\IDE\CommonExtensions.

4. Run `devenv /updateconfiguration` in a Developer Command Prompt.

### Registry key values
|Registry Key Value|Type|Data|Description|  
|------------------|----|----|-----------|  
|NewContentAndUpdateService|string|\<http URL for service endpoint\>|Define a unique service endpoint|
|UseOnlineHelp|dword|`0` to specify local Help, `1` to specify online Help|Define online or offline Help default|
|OnlineBaseUrl|string|\<http URL for service endpoint\>|Define a unique F1 endpoint|
|OnlineHelpPreferenceDisabled|dword|`0` to enable or `1` to disable online Help preference option|Disable online Help preference option|
|DisableManageContent|dword|`0` to enable or `1` to disable the **Manage Content** tab in Help Viewer|Disable the Manage Content tab|
|DisableFirstRunHelpSelection|dword|`0` to enable or `1` to disable help features that are configured the first time that Visual Studio starts|Disable installation of content at first launch of Visual Studio|

### Example .pkgdef file contents
```
[$RootKey$\Help]
“NewContentAndUpdateService”=”https://some.service.endpoint”
“UseOnlineHelp”=dword:00000001
“OnlineBaseUrl”=”https://some.service.endpoint”
“OnlineHelpPreferenceDisabled”=dword:00000000
“DisableManageContent”=dword:00000000
“DisableFirstRunHelpSelection”=dword:00000001
```

## Using Registry Editor to change Help Viewer behavior
The following two behaviors can be controlled by setting registry key values in the Registry Editor.  
  
|Task|Registry Key|Value|Data|  
|----------|-----|------|----|
|Override BITS job priority|HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node (on a 64-bit machine)\Microsoft\Help\v2.3|BITSPriority|**foreground**, **high**, **normal**, or **low**|
|Point to local content store on network share|HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Help\v2.3\Catalogs\VisualStudio15|LocationPath|"*ContentStoreNetworkShare*"|
  
## See also
[Help Viewer Administrator Guide](../ide/help-viewer-administrator-guide.md)  
[Command-Line Arguments for the Help Content Manager](../ide/command-line-arguments-for-the-help-content-manager.md)  
[Microsoft Help Viewer](../ide/microsoft-help-viewer.md)  
[Modifying the isolated shell by using the .pkgdef file](../extensibility/shell/modifying-the-isolated-shell-by-using-the-dot-pkgdef-file.md)