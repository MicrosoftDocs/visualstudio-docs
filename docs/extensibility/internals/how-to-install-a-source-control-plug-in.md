---
title: 'Install a Source Control Plug-in'
description: Install a source control plug-in in Visual Studio by integrating it with the Visual Studio Source Control Plug-in API and registering the DLL.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- installation [Visual Studio SDK], source control plug-ins
- source control plug-ins, installing
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Install a source control plug-in

Creating a source-control plug-in involves three steps:

1. Create a DLL with the functions defined in the Source Control Plug-in API reference section of this documentation.

2. Implement the Source Control Plug-in API-defined functions. When Visual Studio calls for it, make interfaces and dialog boxes available from the plug-in.

3. Register the DLL by making appropriate registry entries.

## Integration with Visual Studio
 Visual Studio supports source control plug-ins that conform to the Source Control Plug-in API.

### Register the source control plug-in
 Before a running integrated development environment (IDE) can call into the source control system, it must first find the source control plug-in DLL that exports the API.

#### To register the source control plug-in DLL

1. Add two entries under the **HKEY_LOCAL_MACHINE** key in the **SOFTWARE** subkey that specifies your company name subkey followed by your product name subkey. The pattern is **HKEY_LOCAL_MACHINE\SOFTWARE\\\<company name>\\\<product name>\\\<entry>** = *value*. The two entries are always called **SCCServerName** and **SCCServerPath**. Each is a regular string.

    For example, if your company name is Microsoft and your source control product is named SourceSafe, then this registry path would be **HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\SourceSafe**. In this subkey, the first entry, **SCCServerName**, is a user-readable string naming your product. The second entry, **SCCServerPath**, is the full path to the source control plug-in DLL that the IDE should connect to. The following provides sample registry entries:

   |Sample Registry entry|Sample value|
   |---------------------------|------------------|
   |HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\SourceSafe\SCCServerName|Microsoft Visual SourceSafe|
   |HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\SourceSafe\SCCServerPath|*c:\vss\win32\ssscc.dll*|

   > [!NOTE]
   > SCCServerPath is the full path to the SourceSafe plug-in. Your source control plug-in will use different company and product names but the same registry entry paths.

2. The following optional registry entries can be used to modify the behavior of your source control plug-in. These entries go in the same subkey as **SccServerName** and **SccServerPath**.

   - The **HideInVisualStudioregistry** entry can be used if you do not want your source control-plug-in to appear in the **Plug-in Selection** list of Visual Studio. This entry will also affect automatic switching to the source control plug-in. One possible use for this entry is if you supply a source control package that replaces your source control plug-in but you want to make it easier for the user to migrate from using the source control plug-in to the source control package. When the source control package is installed, it sets this registry entry, which hides the plug-in.

      **HideInVisualStudio** is a DWORD value and is set to *1* to hide the plug-in or *0* to show the plug-in. If the registry entry does not appear, the default behavior is to show the plug-in.

   - The **DisableSccManager** registry entry can be used to disable or hide the **Launch \<Source Control Server>** menu option that normally appears under the **File** > **Source Control** submenu. Selecting this menu option calls the [SccRunScc](../../extensibility/sccrunscc-function.md) function. Your source control plug-in may not support an external program and therefore you may want to disable or even hide the **Launch** menu option.

      **DisableSccManager** is a DWORD value and is set to *0* to enable the **Launch \<Source Control Server>** menu option, set to *1* to disable the menu option, and set to *2* to hide the menu option. If this registry entry does not appear, the default behavior is to show the menu option.

   | Sample registry entry | Sample value |
   | - |--------------|
   | HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\SourceSafe\HideInVisualStudio | 1 |
   | HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\SourceSafe\DisableSccManager | 1 |

3. Add the subkey, **SourceCodeControlProvider**, under the **HKEY_LOCAL_MACHINE** key in the **SOFTWARE** subkey.

    Under this subkey, the registry entry **ProviderRegKey** is set to a string that represents the subkey that you placed in the registry in step 1. The pattern is **HKEY_LOCAL_MACHINE\SOFTWARE\SourceCodeControlProvider\ProviderRegKey** = *SOFTWARE\\<company name\>\\<product name\>*.

    The following is sample content for this subkey.

   |Registry entry|Sample value|
   |--------------------|------------------|
   |HKEY_LOCAL_MACHINE\SOFTWARE\SourceCodeControlProvider\ProviderRegKey|SOFTWARE\Microsoft\SourceSafe|

   > [!NOTE]
   > Your source control plug-in will use the same subkey and entry names, but the value will be different.

4. Create a subkey named **InstalledSCCProviders** under the **SourceCodeControlProvider** subkey, and then place one entry under that subkey.

    The name of this entry is the user-readable name of the provider (the same as the value specified for the SCCServerName entry), and the value is, once again, the subkey created in step 1. The pattern is **HKEY_LOCAL_MACHINE\SOFTWARE\SourceCodeControlProvider\InstalledSCCProviders\\<display name\>** = *SOFTWARE\\<company name\>\\<product name\>*.

    For example:

   |Sample registry entry|Sample value|
   |---------------------------|------------------|
   |HKEY_LOCAL_MACHINE\SOFTWARE\SourceCodeControlProvider\InstalledSCCProviders\Microsoft Visual SourceSafe|SOFTWARE\Microsoft\SourceSafe|

   > [!NOTE]
   > There can be multiple source control plug-ins registered in this way. This is how Visual Studio finds all installed Source Control Plug-in API-based plug-ins.

## How an IDE locates the DLL
 The Visual Studio IDE has two ways of finding the source control plug-in DLL:

- Find the default source control plug-in and connect to it silently.

- Find all registered source control plug-ins, from which the user chooses one.

  To locate the DLL in the first way, the IDE looks under the **HKEY_LOCAL_MACHINE\Software\SourceCodeControlProvider** subkey for the entry **ProviderRegKey**. The value of this entry points to another subkey. The IDE then looks for an entry named **SccServerPath** in that second subkey under **HKEY_LOCAL_MACHINE**. The value of this entry points the IDE to the DLL.

> [!NOTE]
> The IDE does not load DLLs from relative paths (for example, *.\NewProvider.DLL*). A full path to the DLL must be specified (for example, *c:\Providers\NewProvider.DLL*). This strengthens the security of the IDE by preventing the loading of unauthorized or impersonated plug-in DLLs.

 To locate the DLL in the second way, the IDE looks under the **HKEY_LOCAL_MACHINE\Software\SourceCodeControlProvider\InstalledSCCProviders** subkey for all entries. Each entry has a name and a value. The IDE displays a list of these names to the user. When the user chooses a name, the IDE finds the value for the selected name that points to a subkey. The IDE looks for an entry named **SccServerPath** in that subkey under **HKEY_LOCAL_MACHINE**. The value of that entry points the IDE to the correct DLL.

 A source control plug-in needs to support both ways of finding the DLL and, consequently, sets **ProviderRegKey**, overwriting any previous setting. More importantly, it must add itself to the list of **InstalledSccProviders** so the user can have a choice of which source control plug-in to use.

> [!NOTE]
> Because the **HKEY_LOCAL_MACHINE** key is used, only one source control plug-in can be registered as the default source control plug-in on a given machine (however, Visual Studio allows users to determine which source control plug-in they want to actually use for a particular solution). During your installation process, check to see if a source control plug-in is already set; if so, ask the user whether or not to set the new source control plug-in being installed as the default. During uninstallation, do not remove other registry subkeys that are common to all source control plug-ins in **HKEY_LOCAL_MACHINE\SOFTWARE\SourceCodeControlProvider**; remove only your particular SCC subkey.

## How the IDE detects version 1.2/1.3 support
 How does Visual Studio detect whether a plug-in supports Source Control Plug-in API version 1.2 and 1.3 functionality? To declare advanced capability, the source control plug-in must implement the corresponding function:

 First, Visual Studio checks the value returned by calling the [SccGetVersion](../../extensibility/sccgetversion-function.md). It must be greater than or equal to 1.2.

 Next, Visual Studio determines whether the particular new capability is supported by examining the `lpSccCaps` argument on the [SccInitialize](../../extensibility/sccinitialize-function.md).

 If both of these conditions are met, the new functions supported in versions 1.2 and 1.3 can be called.

## Related content
- [Get started with source control plug-ins](../../extensibility/internals/getting-started-with-source-control-plug-ins.md)
