---
title: "Specifying the Path to Profiling Tools Command Line Tools | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 7047bf18-5779-4f6e-872c-66e2fc47c969
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Specifying the Path to Profiling Tools Command Line Tools
The path of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools command-line tools is not added to the PATH environment variable. On 32-bit computers, the tools are in a single directory. There are 32-bit and 64-bit versions of the profiling tools on 64-bit computers.  
  
## 32-bit computers  
 On 32-bit computers, the default profiler tools directory is *Drive*\Program Files\Microsoft Visual Studio 11.0\Team Tools\Performance Tools.  
  
## 64-bit computers  
 On 64-bit computers, specify the path according to the target platform of the profiled application.  
  
-   For 32-bit applications, the default profiler tools directory is:  
  
     *Drive*\Program Files (x86)\Microsoft Visual Studio 11.0\Team Tools\Performance Tools  
  
-   For 64-bit applications, the default profiler tools directory is:  
  
     *Drive*\Program Files (x86)\Microsoft Visual Studio 11.0\Team Tools\Performance Tools\x64