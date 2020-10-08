---
title: "Isolated Shell Entry Point Parameters (C++) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "Shell [Visual Studio], isolated mode%2C Start entry point"
  - "Visual Studio shell, isolated mode%2C Start entry point"
ms.assetid: 18f4b18b-2173-4afa-ba0a-42fe33e61118
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# Isolated Shell Entry Point Parameters (C++)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When a Visual Studio shell-based application starts, it calls the Start entry point of the Visual Studio shell. The following settings can be overridden in the call to the Start entry point of the shell. For a description of each setting, see [.Pkgdef Files](../extensibility/modifying-the-isolated-shell-by-using-the-dot-pkgdef-file.md).  
  
- AddinsAllowed  
  
- AllowsDroppedFilesOnMainWindow  
  
- AppName  
  
- CommandLineLogo  
  
- DefaultHomePage  
  
- DefaultProjectsLocation  
  
- DefaultSearchPage  
  
- DefaultUserFilesFolderRoot  
  
- DisableOutputWindow  
  
- HideMiscellaneousFilesByDefault  
  
- HideSolutionConcept  
  
- NewProjDlgInstalledTemplatesHdr  
  
- NewProjDlgSlnTreeNodeTitle  
  
- SolutionFileCreatorIdentifier  
  
- SolutionFileExt  
  
- UserFilesSubFolderName  
  
- UserOptsFileExt  
  
  The Visual Studio Shell Isolated template creates a source file, *solutionName*.cpp, where *solutionName* is the solution name for the application. This file defines the main entry point for the application, the _tWinMain function. This function invokes the Start entry point of the shell.  
  
  You can change the behavior of the application by changing these settings when the application starts.  
  
## Parameters  
 The Start entry point of the Visual Studio shell defines five parameters. Do not change the first four parameters. The fifth parameter takes a settings override list. The Start entry point of the shell is called from the main entry point of an application.  
  
 The Start entry point of the shell has the following signature.  
  
```  
typedef int (__cdecl *STARTFCN)(LPSTR, LPWSTR, int, GUID *, WCHAR *pszSettings);  
```  
  
 If you do not want to override any application settings, leave the value of the settings override parameter as a null pointer.  
  
 To override one or more settings, pass a Unicode string that contains the settings to be overridden. The string is a semicolon-separated list of name-value pairs. Each pair contains the name of the setting to override, followed by an equal sign (=), followed by the value to apply to the setting.  
  
> [!NOTE]
> Do not include whitespace in the Unicode strings.  
  
 For boolean settings, the following strings represent the value true; all other strings represent the value false. These strings are case-insensitive.  
  
- \+  
  
- 1  
  
- -1  
  
- on  
  
- true  
  
- yes  
  
## Example  
 To disable add-ins and change the default projects location for your application, you can set the last parameter to "AddinsAllowed=false;DefaultProjectsLocation=%USERPROFILE%\temp".  
  
## See Also  
 [Customizing the Isolated Shell](../extensibility/customizing-the-isolated-shell.md)   
 [.Pkgdef Files](../extensibility/modifying-the-isolated-shell-by-using-the-dot-pkgdef-file.md)
