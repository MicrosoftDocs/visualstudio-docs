---
title: "Tool Windows in the Registry | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "tool windows, registering"
ms.assetid: c4bb8add-7148-49e4-a377-01d059fd5524
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# Tool Windows in the Registry
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

VSPackages that provide tool windows must register with [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] as tool window providers. Tool windows created by using the Visual Studio Package template do this by default. Tool window providers have system registry keys that specify visibility attributes, such as default tool window size and location, the GUID of the window that serves as the tool window pane, and docking style.  
  
 During development, managed tool window providers register tool windows by adding attributes to the source code, and then running the RegPkg.exe utility on the resulting assembly. For more information, see [Registering a Tool Window](../extensibility/registering-a-tool-window.md).  
  
## Registering Unmanaged Tool Window Providers  
 Unmanaged tool window providers must register with [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] in the ToolWindows section of the system registry. The following .reg file fragment shows how a dynamic tool window might be registered:  
  
```  
[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\<version number>\ToolWindows\{f0e1e9a1-9860-484d-ad5d-367d79aabf55}]  
@="{01069cdd-95ce-4620-ac21-ddff6c57f012}"  
"Name"="Microsoft.Samples.VisualStudio.IDE.ToolWindow.DynamicWindowPane"  
"Float"="250, 250, 410, 430"  
"DontForceCreate"=dword:00000001  
  
[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0Exp\ToolWindows\{f0e1e9a1-9860-484d-ad5d-367d79aabf55}\Visibility]  
"{f1536ef8-92ec-443c-9ed7-fdadf150da82}"=dword:00000000  
```  
  
 In the first key in the example above, version number is the version of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], such as 7.1 or 8.0, the subkey {f0e1e9a1-9860-484d-ad5d-367d79aabf55} is the GUID of the tool window pane (DynamicWindowPane), and the default value {01069cdd-95ce-4620-ac21-ddff6c57f012} is the GUID of the VSPackage providing the tool window. For an explanation of the Float and DontForceCreate subkeys, see [Tool Window Display Configuration](../extensibility/tool-window-display-configuration.md).  
  
 The second optional key, ToolWindows\Visibility, specifies the GUIDs of commands that require the tool window to be made visible. In this case, there are no commands specified. For more information, see [Tool Window Display Configuration](../extensibility/tool-window-display-configuration.md).  
  
## See Also  
 [VSPackage Essentials](../misc/vspackage-essentials.md)
