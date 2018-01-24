
---
title: "Command-line parameter examples for Visual Studio installation | Microsoft Docs"
ms.custom: ""
ms.date: "05/06/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-acquisition"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 837F31AA-F121-46e9-9996-F8BCE768E579
author: "timsneath"
ms.author: "tglee"
manager: ghogen
ms.workload:
  - "multiple"
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
```
vs_enterprise.exe --installPath C:\minVS ^
   --add Microsoft.VisualStudio.Workload.CoreEditor ^
   --passive --norestart
```

* Update a Visual Studio instance by using the command line, with no interactive prompts but progress displayed:
```
vs_enterprise.exe --update --quiet --wait
vs_enterprise.exe update --wait --passive --norestart --installPath "C:\installPathVS"
```

> [!NOTE]
> Both commands are required. The first command updates the Visual Studio Installer. The second command updates the Visual Studio instance. To avoid a User Account Control dialog, run the command prompt as an Administrator. 

* Install a desktop instance of Visual Studio silently, with the French language pack, returning only when the product is installed.
```
vs_enterprise.exe --installPath C:\desktopVS ^
   --addProductLang fr-FR ^
   --add Microsoft.VisualStudio.Workload.ManagedDesktop ^
   --includeRecommended --quiet --wait
```

> [!NOTE]
>  The `--wait` parameter is designed for use in a batch file. In a batch file, execution of the next command will not continue until the installation has completed. The `%ERRORLEVEL%` environment variable will contain the return value of the command, as documented in the [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md) page.

* Download the Visual Studio core editor (the most minimal Visual Studio configuration). Only include the English language pack:

```cmd
vs_community.exe --layout C:\VS2017
   --lang en-US ^
   --add Microsoft.VisualStudio.Workload.CoreEditor
```

* Download the .NET desktop and .NET web workloads along with all recommended components and the GitHub extension. Only include the English language pack:
```
vs_community.exe --layout C:\VS2017 ^
   --lang en-US ^
   --add Microsoft.VisualStudio.Workload.NetWeb ^
   --add Microsoft.VisualStudio.Workload.ManagedDesktop ^
   --add Component.GitHub.VisualStudio ^
   --includeRecommended
```

* Start an interactive installation of all workloads and components that are available in the Visual Studio 2017 Enterprise edition:
```
vs_enterprise.exe --all --includeRecommended --includeOptional
```

* Install a second, named instance of Visual Studio 2017 Professional on a machine with Visual Studio 2017 Community edition already installed, with support for Node.js development:
```
vs_professional.exe --installPath C:\VSforNode ^
   --add Microsoft.VisualStudio.Workload.Node --includeRecommended --nickname VSforNode
```

* Remove the Profiling Tools component from the default installed Visual Studio instance:
```
vs_enterprise.exe modify ^
   --installPath "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise" ^
   --remove Microsoft.VisualStudio.Component.DiagnosticTools ^
   --passive
```

## Get support
Sometimes, things can go wrong. If your Visual Studio installation fails, see the [Troubleshooting Visual Studio 2017 installation and upgrade issues](troubleshooting-installation-issues.md) page. If none of the troubleshooting steps help, you can contact us by live chat for installation assistance (English only). For details, see the [Visual Studio support page](https://www.visualstudio.com/vs/support/#talktous).

Here are a few more support options:
* You can report product issues to us via the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio-2017.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
* You can share a product suggestion with us on [UserVoice](https://visualstudio.uservoice.com/forums/121579).
* You can track product issues in the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/), and ask questions and find answers.
* You can also engage with us and other Visual Studio developers through our [Visual Studio conversation in the Gitter community](https://gitter.im/Microsoft/VisualStudio).  (This option requires a [GitHub](https://github.com/) account.)

## See also

 * [Visual Studio Administrator Guide](visual-studio-administrator-guide.md)
 * [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
 * [Create an offline installation of Visual Studio 2017](create-an-offline-installation-of-visual-studio.md)
