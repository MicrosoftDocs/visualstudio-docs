---
title: "Modifying the Isolated Shell By Using the .Pkgundef File | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "Visual Studio shell, isolated mode%2C .pkgundef file"
ms.assetid: 9cee2a20-f8ac-4d9d-aef9-068fcd9f27a4
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# Modifying the Isolated Shell By Using the .Pkgundef File
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can modify the .pkgundef file to exclude specified registry entries from an isolated shell application. Typically, the first time an application is started on a computer, the Visual Studio shell copies the existing Visual Studio registry entries to the root registry key for the application. This includes any references to currently installed VSPackages.  
  
 To exclude a specific registry entry from an isolated shell application, add to the application .pkgundef file the package key followed by the entry. Keys and entries are represented just as in the .pkgdef file; that is, as [$RootKey$] or [$RootKey$\\*subkey*] and "*entry*"=*value*, where *subkey* is the subkey to affect, *entry* is the entry to remove, and *value* is either `""` or `dword:00000000`.  
  
 To exclude multiple entries from a registry key, just list the key one time, followed by a line for each entry to exclude.  
  
 To exclude a whole registry key from an isolated shell application, add the key to the application .pkgundef file but do not specify any registry entries for that key.  
  
 You can add comments to the .pkgundef file. A single-line comment must have two slashes as the first two characters.  
  
 For example, to remove the **Connect to Database** and **Connect to Serve r** commands on the **Tools** menu, you can uncomment the line:  
  
```  
[$RootKey$\Packages\{8D8529D3-625D-4496-8354-3DAD630ECC1B}]  
```  
  
 and add the line:  
  
```  
[$RootKey$\Packages\{198E76C1-34C0-424D-9957-B3EBD80265FB}]  
```  
  
 to the application's .pkgundef file.  
  
## See Also  
 [Package GUIDs of Visual Studio Features](../extensibility/package-guids-of-visual-studio-features.md)   
 [Customizing the Isolated Shell](../extensibility/customizing-the-isolated-shell.md)
