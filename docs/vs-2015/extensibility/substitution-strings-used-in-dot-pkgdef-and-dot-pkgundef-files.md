---
title: "Substitution Strings Used in .Pkgdef and .Pkgundef Files | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "Visual Studio shell, isolated mode%2C .pkgdef and .pkgundef files"
ms.assetid: b1755d63-d794-4fd7-864b-70a9684881c2
caps.latest.revision: 5
ms.author: gregvanl
manager: jillfra
---
# Substitution Strings Used in .Pkgdef and .Pkgundef Files
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can use the substitution strings listed below in the .pkgdef and .pkgundef files you define for your Visual Studio isolated shell application.  
  
## Substitution strings  
  
|String|Description|  
|------------|-----------------|  
|$=*RegistryEntry*$|The value of the *RegistryEntry* entry. If the registry entry string ends in a backslash (\\), then the default value of the registry subkey is used. For example, the substitution string $=HKEY_CURRENT_USER\Environment\TEMP$ is expanded to the temporary folder of the current user.|  
|$AppName$|The qualified name of the application that is passed to the AppEnv.dll entry points. The qualified name consists of the application name, an underscore, and the class identifier (CLSID) of the application automation object, which is also recorded as the value of the ThisVersionDTECLSID setting in the project .pkgdef file.|  
|$AppDataLocalFolder|The subfolder under %LOCALAPPDATA% for this application.|  
|$BaseInstallDir$|The full path of the location where Visual Studio was installed.|  
|$CommonFiles$|The value of the %CommonProgramFiles% environment variable.|  
|$MyDocuments$|The full path of the My Documents folder of the current user.|  
|$PackageFolder$|The full path of the directory that contains the package assembly files for the application.|  
|$ProgramFiles$|The value of the %ProgramFiles% environment variable.|  
|$RootFolder$|The full path of the root directory of the application.|  
|$RootKey$|The root registry key for the application. By default the root is in HKEY_CURRENT_USER\Software\\*CompanyName*\\*ProjectName*\\*VersionNumber* (when the application is running, _Config is appended to this key). It is set by the RegistryRoot value in the *SolutionName*.pkgdef file.<br /><br /> The $RootKey$ string can be used to retrieve a registry value under the application subkey. For example, the string "$=$RootKey$\AppIcon$" will return the value of the AppIcon entry under the application root subkey.<br /><br /> The parser processes the .pkgdef file sequentially, and can access a registry entry under the application subkey only if the entry has been previously defined|  
|$ShellFolder$|The full path of the location where Visual Studio was installed.|  
|$System$|The Windows\system32 folder.|  
|$WINDIR$|The Windows folder.|  
  
 If the parser does not recognize the substitution string or it cannot determine the value of a registry entry or an environment variable, then it does not perform substitution on that part of the string.
