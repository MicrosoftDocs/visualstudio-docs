---
title: "What&#39;s New in MSBuild 12.0 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
ms.assetid: 9976a6ad-c052-4017-b848-35b5ae4a2f66
caps.latest.revision: 26
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# What&#39;s New in MSBuild 12.0
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

MSBuild is now installed as part of Visual Studio rather than as part of the .NET Framework. The current MSBuild version number is 12.0. If you want to install MSBuild separately, download the installation package from [MSBuild Download](https://go.microsoft.com/fwlink/?LinkId=309745).  
  
## Changed Path  
 MSBuild is now installed directly under *%ProgramFiles%*—for example, in C:\Program Files\MSBuild\\.  
  
## Changed Properties  
 The following MSBuild properties are changed as a result of the new version number:  
  
- `MSBuildToolsVersion` for this version of tools is 12.0.  
  
- `MSBuildToolsPath` is now %ProgramFiles%\MSBuild\12.0\bin on 32-bit operating systems, or %ProgramFiles%\MSBuild\12.0\bin\amd64 on 64-bit operating systems.  
  
- `ToolsVersion` values can be found in HKLM\SOFTWARE\Microsoft\MSBuild\ToolsVersions\12.0 for 32-bit operating systems or HKLM\SOFTWARE\Wow6432Node\Microsoft\MSBuild\ToolsVersions\12.0 for 64-bit operating systems.  
  
- The `SDK35ToolsPath` and `SDK40ToolsPath` properties point to the .NET Framework SDK that's packaged with this version of Visual Studio (for example, 8.1A for the 4.X tools).  
  
## New Properties  
  
- `MSBuildFrameworkToolsPath` is a new property that has a value of %windir%\Microsoft.NET\Framework\v4.0.30319 on 32-bit operating systems or %windir%\Microsoft.NET\Framework64\v4.0.30319 on 64-bit operating systems. This is a replacement for `MSBuildToolsPath` that can be used to point to the .NET Framework tools and utilities.  
  
- `MSBuildToolsPath` and `MSBuildFrameworkToolsPath` have 32-bit equivalents—`MSBuildToolsPath32` and `MSBuildFrameworkToolsPath32`—that always point to the 32-bit location, regardless of whether 32-bit or 64-bit MSBuild is being used.

## See Also
[MSBuild](msbuild.md)
