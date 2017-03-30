---
title: "Command-line parameter examples for Visual Studio installation | Microsoft Docs"
ms.custom: ""
ms.date: "03/28/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-ide-install"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords:
  - "command-line parameters"
  - "examples"
ms.assetid: 837F31AA-F121-46e9-9996-F8BCE768E579
author: "timsneath"
ms.author: "tims"
translation.priority.ht:
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt:
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Command-line parameter examples for Visual Studio 2017 installation
To illustrate [usage of the command-line parameters for installing Visual Studio](use-command-line-parameters-to-install-visual-studio.md), 
here are a number of examples that you can tailor and repurpose to match your needs. 

In each example, `vs_enterprise.exe`, `vs_professional.exe` and `vs_community.exe` represent the respective edition of the Visual Studio bootstrapper,
which is the small (approx. 1MB) file that initiates the download process. If you are using a different edition, substitute the appropriate bootstrapper name.

   >[!NOTE]
   All commands require administrative elevation, and a User Account Control prompt will be displayed as appropriate if the process is not started from an elevated prompt. 

1. Install a minimal instance of Visual Studio, with no interactive prompts but progress displayed:
```
vs_enterprise.exe --installPath C:\minVS ^
   --add Microsoft.VisualStudio.Workload.CoreEditor ^
   --passive --norestart
```

2. Install a desktop instance of Visual Studio silently, with the French language pack, returning only when the product is installed. 
```
vs_enterprise.exe --installPath C:\desktopVS ^
   --addProductLang fr-FR ^
   --add Microsoft.VisualStudio.Workload.ManagedDesktop ^
   --quiet --wait
```

   >[!NOTE]
   >The `--wait` parameter is designed for use in a batch file. In a batch file,execution of the next command will not continue until the installation has completed. 
   >
   > The `%ERRORLEVEL%` environment variable will contain the return value of the command as documented in the [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md) page.

3. Download the .NET desktop and .NET web workloads along with all recommended components and the GitHub extension. Only include the English language pack:
```
vs_community.exe --layout C:\VS2017 
   --lang en-US ^
   --add Microsoft.VisualStudio.Workload.CoreEditor ^
   --add Microsoft.VisualStudio.Workload.NetWeb ^
   --add Microsoft.VisualStudio.Workload.ManagedDesktop ^
   --add Microsoft.Net.ComponentGroup.TargetingPacks.Common ^
   --add Microsoft.ComponentGroup.Blend ^
   --add Microsoft.VisualStudio.Component.EntityFramework ^
   --add Microsoft.VisualStudio.Component.DiagnosticTools ^
   --add Microsoft.VisualStudio.Component.DockerTools ^
   --add Microsoft.VisualStudio.Component.CloudExplorer ^
   --add Microsoft.VisualStudio.Component.Wcf.Tooling ^
   --add Component.GitHub.VisualStudio
```

   >[!NOTE]
   The Enterprise edition contains additional recommended components beyond those included here. See [Visual Studio Enterprise 2017 component directory](workload-component-id-vs-enterprise.md) for a listing of all recommended components available in Visual Studio Enterprise. 

4. Start an interactive install of all workloads and components available in the Enterprise edition:
```
vs_enterprise.exe --all --includeRecommended --includeOptional
```

5. Install a second, named instance of Visual Studio 2017 Professional on a machine with Visual Studio 2017 Community edition already installed, with support for Node.js development:
```
vs_professional.exe --installPath C:\VSforNode ^
   --add Microsoft.VisualStudio.Workload.Node --nickname VSforNode
``` 

6. Remove the Profiling Tools component from the default installed Visual Studio instance:
```
vs_enterprise.exe modify ^
   --installPath "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise" ^
   --remove Microsoft.VisualStudio.Component.DiagnosticTools ^
   --passive
```

   >[!NOTE]
   You can use the `^` character at the end of a command line to flow across to another line without the Windows command prompt interpreting the contents of the line so far. Alternatively, you can simply concatenate these lines together onto a single row. 

## See also

 * [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
 * [Create an offline installation of Visual Studio 2017](create-an-offline-installation-of-visual-studio.md)