---
title: "Registering Interop Assembly Command Handlers | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "interop assemblies, command handlers"
  - "command handling with interop assemblies, registering"
ms.assetid: 303cd399-e29d-4ea1-8abe-5e0b59c12a0c
caps.latest.revision: 20
ms.author: gregvanl
manager: jillfra
---
# Registering Interop Assembly Command Handlers
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

A VSPackage must register with [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] so that the integrated development environment (IDE) routes its commands properly.  
  
 The registry can be updated either by manual editing or by using a Registrar (.rgs) file. For more information, see [Creating Registrar Scripts](https://msdn.microsoft.com/library/cbd5024b-8061-4a71-be65-7fee90374a35).  
  
 The Managed Package Framework (MPF) provides this functionality through the <xref:Microsoft.VisualStudio.Shell.ProvideMenuResourceAttribute> class.  
  
 [Command Table Format Reference](https://msdn.microsoft.com/09e9c6ef-9863-48de-9483-d45b7b7c798f) resources are located in unmanaged satellite UI dlls.  
  
## Command Handler Registration of a VSPackage  
 A VSPackage acting as a handler for user interface (UI)-based commands requires a registry entry named after the VSPackage `GUID`. This registry entry specifies the location of the VSPackage's UI resource file and the menu resource within that file. The registry entry itself is located under HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\\*\<Version>*\Menus, where *\<Version>* is the version of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)], for example 9.0.  
  
> [!NOTE]
> The root path of HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\\*\<Version>* can be overridden with an alternate root when the [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] shell is initialized. For more information about the root path, see [Installing VSPackages With Windows Installer](../../extensibility/internals/installing-vspackages-with-windows-installer.md).  
  
### The CTMENU Resource Registry Entry  
 The structure of the registry entry is:  
  
```  
HKEY_LOCAL_MACHINE\Software\VisualStudio\<Version>\  
  Menus\  
    <GUID> = <Resource Information>  
```  
  
 \<*GUID*> is the `GUID` of the VSPackage in the form {XXXXXX-XXXX-XXXX-XXXX-XXXXXXXXX}.  
  
 *\<Resource Information>* consists of three elements separated by commas. These elements are, in order:  
  
 \<*Path to Resource DLL*>, \<*Menu Resource ID*>, \<*Menu Version*>  
  
 The following table describes the fields of \<*Resource Information*>.  
  
|Element|Description|  
|-------------|-----------------|  
|\<*Path to Resource DLL*>|This is the full path to the resource DLL that contains the menu resource or this is left blank, indicating that the VSPackage's resource DLL is to be used (as specified in the Packages subkey where the VSPackage itself is registered).<br /><br /> It is customary to leave this field blank.|  
|\<*Menu Resource ID*>|This is the resource ID of the `CTMENU` resource that contains all of the UI elements for the VSPackage as compiled from a [.vsct](../../extensibility/internals/visual-studio-command-table-dot-vsct-files.md) file.|  
|\<*Menu Version*>|This is a number used as a version for the `CTMENU` resource. [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] uses this value to determine if it needs to remerge the contents of the `CTMENU` resource with its cache of all `CTMENU` resources. A remerge is triggered by executing the devenv setup command.<br /><br /> This value should initially be set to 1 and incremented after every change in the `CTMENU` resource and before the remerge occurs.|  
  
### Example  
 Here is an example of a couple of resource entries:  
  
```  
HKEY_LOCAL_MACHINE\Software\VisualStudio\9.0Exp\  
  Menus\  
    {019971D6-4685-11D2-B48A-0000F87572EB} = ,1, 10  
    {1b027a40-8f43-11d0-8d11-00a0c91bc942} = , 10211, 3  
```  
  
## See also  
 [How VSPackages Add User Interface Elements](../../extensibility/internals/how-vspackages-add-user-interface-elements.md)   
 [Commands and Menus That Use Interop Assemblies](../../extensibility/internals/commands-and-menus-that-use-interop-assemblies.md)
