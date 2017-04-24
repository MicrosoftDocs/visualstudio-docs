---
title: "Command-line parameter examples for Visual Studio installation | Microsoft Docs"
ms.custom: ""
ms.date: "04/05/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-ide-install"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 837F31AA-F121-46e9-9996-F8BCE768E579
author: "timsneath"
ms.author: "tims"
manager: "ghogen"
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
To illustrate how to [use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md),
here are several examples that you can customize to match your needs.

In each example, `vs_enterprise.exe`, `vs_professional.exe` and `vs_community.exe` represent the respective edition of the Visual Studio bootstrapper,
which is the small (approximately 1MB) file that initiates the download process. If you are using a different edition, substitute the appropriate bootstrapper name.

> [!NOTE]
> All commands require administrative elevation, and a User Account Control prompt will be displayed if the process is not started from an elevated prompt.

> [!NOTE]
>  You can use the `^` character at the end of a command line to concatenate multiple lines into a single command. Alternatively, you can simply place these lines together onto a single row. In PowerShell, the equivalent is the backtick (`` ` ``) character. 

* Install a minimal instance of Visual Studio, with no interactive prompts but progress displayed:
```cmd
vs_enterprise.exe --installPath C:\minVS ^
   --add Microsoft.VisualStudio.Workload.CoreEditor ^
   --passive --norestart
```

* Install a desktop instance of Visual Studio silently, with the French language pack, returning only when the product is installed.
```cmd
vs_enterprise.exe --installPath C:\desktopVS ^
   --addProductLang fr-FR ^
   --add Microsoft.VisualStudio.Workload.ManagedDesktop ^
   --quiet --wait
```

  > [!NOTE]
  >  The `--wait` parameter is designed for use in a batch file. In a batch file, execution of the next command will not continue until the installation has completed. The `%ERRORLEVEL%` environment variable will contain the return value of the command, as documented in the [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md) page.

* Download the .NET desktop and .NET web workloads along with all recommended components and the GitHub extension. Only include the English language pack:
```cmd
vs_community.exe --layout C:\VS2017 ^
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

* Start an interactive installation of all workloads and components that are available in the Visual Studio 2017 Enterprise edition:
```cmd
vs_enterprise.exe --all --includeRecommended --includeOptional
```

* Install a second, named instance of Visual Studio 2017 Professional on a machine with Visual Studio 2017 Community edition already installed, with support for Node.js development:
```cmd
vs_professional.exe --installPath C:\VSforNode ^
   --add Microsoft.VisualStudio.Workload.Node --nickname VSforNode
```

* Remove the Profiling Tools component from the default installed Visual Studio instance:
```cmd
vs_enterprise.exe modify ^
   --installPath "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise" ^
   --remove Microsoft.VisualStudio.Component.DiagnosticTools ^
   --passive
```

## See also

 * [Visual Studio Administrator Guide](visual-studio-administrator-guide.md)
 * [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
 * [Create an offline installation of Visual Studio 2017](create-an-offline-installation-of-visual-studio.md)
