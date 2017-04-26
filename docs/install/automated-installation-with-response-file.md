---
title: "Automate Visual Studio installation with a response file | Microsoft Docs"
description: "{{PLACEHOLDER}}"
ms.date: "04/14/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-ide-install"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords:
  - "{{PLACEHOLDER}}"
  - "{{PLACEHOLDER}}"
ms.assetid: 448C738E-121F-4B64-8CA8-3BC997817A14
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
# How to define settings in a response file
Admins deploying VS can also specify a response file using the ```--in <response file>``` command.

Response files are JSON files whose contents mirror the command line arguments.  In general, if a command line parameter takes no arguments (e.g. ```--quiet```, ```--passive```, etc.), the value in the response file should be true/false.  If it takes an argument (e.g. ```--installPath <dir>```), the value in the response file should be a string.  If it takes an argument and can appear on the command line more than once (e.g. ```--add <id>```), it should be an array of strings.

Command line parameters override settings from the response file, except in the case of multi-instance parameters (e.g. --add).  Multi-instance parameters are merged with settings from the response file.


### Offline layout repsonse files

If you created an offline layout, a response.json file was created in the layout.  

Admins who create a layout can modify the response.json file in the layout to control the default settings that their users will see when installing VS from the layout.  For example, if the admin wants some specific workloads and components selected to be installed by default, they can configure the response.json file to add those.  

When VS setup is run from a layout folder, it will automatically use the response file in the layout folder.  It is not required to use the ```--in``` option.

You can update the response.json file that is created in an offline layout folder to define default setting for users installing from this layout.  However, be sure to leave the existing properties that were defined when the layout was created.

The base response.json file in a layout will look similar to this but with value for the product and channel you are installing:
```
{"installChannelUri":".\\ChannelManifest.json","channelUri":"https://aka.ms/vs/15/release/channel","installCatalogUri":".\\Catalog.json","channelId":"VisualStudio.15.Release","productId":"Microsoft.VisualStudio.Product.Enterprise",
}
```

#### Example layout response file content:
This example will install Visual Studio Enterprise with all workloads and components for all localized languages.  You can use this as a template.  Just remove the workloads and components you don't want installed in your copy of the response file.<br>

```batch 
{"installChannelUri":".\\ChannelManifest.json","channelUri":"https://aka.ms/vs/15/release/channel","installCatalogUri":".\\Catalog.json","channelId":"VisualStudio.15.Release","productId":"Microsoft.VisualStudio.Product.Enterprise",
    "installPath": "C:\\desktopVS",
    "quiet": false,
    "passive": false,
    "wait": false,
    "norestart": false,
    "addProductLang": [
        "cs-CZ",
        "de-DE",
        "en-US",
        "es-ES",
        "fr-FR",
        "it-IT",
        "ja-JP",
        "ko-KR",
        "pl-PL",
        "pt-BR",
        "ru-RU",
        "tr-TR",
        "zh-CN",
        "zh-TW"
        ]
    "add": [
        "Microsoft.VisualStudio.Workload.Azure",
        "Microsoft.VisualStudio.Workload.CoreEditor",
        "Microsoft.VisualStudio.Workload.Data",
        "Microsoft.VisualStudio.Workload.FeedbackClient",
        "Microsoft.VisualStudio.Workload.ManagedDesktop",
        "Microsoft.VisualStudio.Workload.ManagedGame",
        "Microsoft.VisualStudio.Workload.MSBuildTools",
        "Microsoft.VisualStudio.Workload.NativeCrossPlat",
        "Microsoft.VisualStudio.Workload.NativeDesktop",
        "Microsoft.VisualStudio.Workload.NativeGame",
        "Microsoft.VisualStudio.Workload.NativeMobile",
        "Microsoft.VisualStudio.Workload.NetCoreTools",
        "Microsoft.VisualStudio.Workload.NetCrossPlat",
        "Microsoft.VisualStudio.Workload.NetWeb",
        "Microsoft.VisualStudio.Workload.Node",
        "Microsoft.VisualStudio.Workload.Office",
        "Microsoft.VisualStudio.Workload.TestAgent",
        "Microsoft.VisualStudio.Workload.TestController",
        "Microsoft.VisualStudio.Workload.TestProfessional",
        "Microsoft.VisualStudio.Workload.Universal",
        "Microsoft.VisualStudio.Workload.VCTools",
        "Microsoft.VisualStudio.Workload.VisualStudioExtension",
        "Microsoft.VisualStudio.Workload.WebBuildTools",
        "Microsoft.VisualStudio.Workload.WebCrossPlat",
        "Component.Android.Emulator",
        "Component.Android.NDK.R11C",
        "Component.Android.NDK.R11C_3264",
        "Component.Android.NDK.R12B",
        "Component.Android.NDK.R12B_3264",
        "Component.Android.NDK.R13B",
        "Component.Android.NDK.R13B_3264",
        "Component.Android.SDK19",
        "Component.Android.SDK22",
        "Component.Android.SDK23",
        "Component.Ant",
        "Component.Cocos",
        "Component.CordovaToolset.6.3.1",
        "Component.Dotfuscator",
        "Component.GitHub.VisualStudio",
        "Component.Google.Android.Emulator.API23.V2",
        "Component.HAXM",
        "Component.Incredibuild",
        "Component.JavaJDK",
        "Component.MDD.Android",
        "Component.MDD.IOS",
        "Component.MDD.Linux",
        "Component.Redgate.ReadyRoll",
        "Component.Redgate.SQLPrompt.VsPackage",
        "Component.Redgate.SQLSearch.VSExtension",
        "Component.UnityEngine",
        "Component.Unreal",
        "Component.WebSocket",
        "Component.Xamarin",
        "Component.Xamarin.Inspector",
        "Component.Xamarin.Profiler",
        "Component.Xamarin.RemotedSimulator",
        "Microsoft.Component.Azure.DataLake.Tools",
        "Microsoft.Component.Blend.SDK.WPF",
        "Microsoft.Component.ClickOnce",
        "Microsoft.Component.HelpViewer",
        "Microsoft.Component.MSBuild",
        "Microsoft.Component.NetFX.Core.Runtime",
        "Microsoft.Component.NetFX.Native",
        "Microsoft.Component.VC.Runtime.OSSupport",
        "Microsoft.Component.VC.Runtime.UCRTSDK",
        "Microsoft.ComponentGroup.Blend",
        "Microsoft.Net.Component.3.5.DeveloperTools",
        "Microsoft.Net.Component.4.5.1.TargetingPack",
        "Microsoft.Net.Component.4.5.2.TargetingPack",
        "Microsoft.Net.Component.4.5.TargetingPack",
        "Microsoft.Net.Component.4.6.1.SDK",
        "Microsoft.Net.Component.4.6.1.TargetingPack",
        "Microsoft.Net.Component.4.6.2.SDK",
        "Microsoft.Net.Component.4.6.2.TargetingPack",
        "Microsoft.Net.Component.4.6.TargetingPack",
        "Microsoft.Net.Component.4.7.SDK",
        "Microsoft.Net.Component.4.7.TargetingPack",
        "Microsoft.Net.Component.4.TargetingPack",
        "Microsoft.Net.ComponentGroup.4.6.2.DeveloperTools",
        "Microsoft.Net.ComponentGroup.4.7.DeveloperTools",
        "Microsoft.Net.ComponentGroup.DevelopmentPrerequisites",
        "Microsoft.Net.ComponentGroup.TargetingPacks.Common",
        "Microsoft.Net.Core.Component.SDK",
        "Microsoft.NetCore.ComponentGroup.DevelopmentTools",
        "Microsoft.NetCore.ComponentGroup.Web",
        "Microsoft.VisualStudio.Component.AppInsights.Tools",
        "Microsoft.VisualStudio.Component.Azure.AuthoringTools",
        "Microsoft.VisualStudio.Component.Azure.ClientLibs",
        "Microsoft.VisualStudio.Component.Azure.Compute.Emulator",
        "Microsoft.VisualStudio.Component.Azure.MobileAppsSdk",
        "Microsoft.VisualStudio.Component.Azure.ResourceManager.Tools",
        "Microsoft.VisualStudio.Component.Azure.ServiceFabric.Tools",
        "Microsoft.VisualStudio.Component.Azure.Storage.AzCopy",
        "Microsoft.VisualStudio.Component.Azure.Storage.Emulator",
        "Microsoft.VisualStudio.Component.Azure.Waverton",
        "Microsoft.VisualStudio.Component.ClassDesigner",
        "Microsoft.VisualStudio.Component.CloudExplorer",
        "Microsoft.VisualStudio.Component.CodeClone",
        "Microsoft.VisualStudio.Component.CodeMap",
        "Microsoft.VisualStudio.Component.Common.Azure.Tools",
        "Microsoft.VisualStudio.Component.Cordova",
        "Microsoft.VisualStudio.Component.CoreBuildTools",
        "Microsoft.VisualStudio.Component.CoreEditor",
        "Microsoft.VisualStudio.Component.Debugger.JustInTime",
        "Microsoft.VisualStudio.Component.DependencyValidation.Community",
        "Microsoft.VisualStudio.Component.DependencyValidation.Enterprise",
        "Microsoft.VisualStudio.Component.DiagnosticTools",
        "Microsoft.VisualStudio.Component.DockerTools",
        "Microsoft.VisualStudio.Component.DslTools",
        "Microsoft.VisualStudio.Component.EntityFramework",
        "Microsoft.VisualStudio.Component.FSharp",
        "Microsoft.VisualStudio.Component.Git",
        "Microsoft.VisualStudio.Component.GraphDocument",
        "Microsoft.VisualStudio.Component.Graphics",
        "Microsoft.VisualStudio.Component.Graphics.Tools",
        "Microsoft.VisualStudio.Component.Graphics.Win81",
        "Microsoft.VisualStudio.Component.IISExpress",
        "Microsoft.VisualStudio.Component.IntelliTrace.FrontEnd",
        "Microsoft.VisualStudio.Component.JavaScript.Diagnostics",
        "Microsoft.VisualStudio.Component.JavaScript.TypeScript",
        "Microsoft.VisualStudio.Component.LinqToSql",
        "Microsoft.VisualStudio.Component.LiveUnitTesting",
        "Microsoft.VisualStudio.Component.ManagedDesktop.Core",
        "Microsoft.VisualStudio.Component.ManagedDesktop.Prerequisites",
        "Microsoft.VisualStudio.Component.Node.Tools",
        "Microsoft.VisualStudio.Component.NuGet",
        "Microsoft.VisualStudio.Component.Phone.Emulator",
        "Microsoft.VisualStudio.Component.Phone.Emulator.15063",
        "Microsoft.VisualStudio.Component.PortableLibrary",
        "Microsoft.VisualStudio.Component.PowerShell.Tools",
        "Microsoft.VisualStudio.Component.Roslyn.Compiler",
        "Microsoft.VisualStudio.Component.Roslyn.LanguageServices",
        "Microsoft.VisualStudio.Component.Sharepoint.Tools",
        "Microsoft.VisualStudio.Component.SQL.ADAL",
        "Microsoft.VisualStudio.Component.SQL.CLR",
        "Microsoft.VisualStudio.Component.SQL.CMDUtils",
        "Microsoft.VisualStudio.Component.SQL.DataSources",
        "Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime",
        "Microsoft.VisualStudio.Component.SQL.NCLI",
        "Microsoft.VisualStudio.Component.SQL.SSDT",
        "Microsoft.VisualStudio.Component.Static.Analysis.Tools",
        "Microsoft.VisualStudio.Component.TeamOffice",
        "Microsoft.VisualStudio.Component.TestTools.CodedUITest",
        "Microsoft.VisualStudio.Component.TestTools.Core",
        "Microsoft.VisualStudio.Component.TestTools.FeedbackClient",
        "Microsoft.VisualStudio.Component.TestTools.MicrosoftTestManager",
        "Microsoft.VisualStudio.Component.TestTools.WebLoadTest",
        "Microsoft.VisualStudio.Component.TextTemplating",
        "Microsoft.VisualStudio.Component.TypeScript.2.0",
        "Microsoft.VisualStudio.Component.TypeScript.2.1",
        "Microsoft.VisualStudio.Component.Unity",
        "Microsoft.VisualStudio.Component.UWP.Support",
        "Microsoft.VisualStudio.Component.VC.140",
        "Microsoft.VisualStudio.Component.VC.ATL",
        "Microsoft.VisualStudio.Component.VC.ATLMFC",
        "Microsoft.VisualStudio.Component.VC.ClangC2",
        "Microsoft.VisualStudio.Component.VC.CLI.Support",
        "Microsoft.VisualStudio.Component.VC.CMake.Project",
        "Microsoft.VisualStudio.Component.VC.CoreBuildTools",
        "Microsoft.VisualStudio.Component.VC.CoreIde",
        "Microsoft.VisualStudio.Component.VC.DiagnosticTools",
        "Microsoft.VisualStudio.Component.VC.Modules.x86.x64",
        "Microsoft.VisualStudio.Component.VC.Tools.ARM",
        "Microsoft.VisualStudio.Component.VC.Tools.x86.x64",
        "Microsoft.VisualStudio.Component.VisualStudioData",
        "Microsoft.VisualStudio.Component.VSSDK",
        "Microsoft.VisualStudio.Component.Wcf.Tooling",
        "Microsoft.VisualStudio.Component.Web",
        "Microsoft.VisualStudio.Component.WebDeploy",
        "Microsoft.VisualStudio.Component.Windows10SDK",
        "Microsoft.VisualStudio.Component.Windows10SDK.10240",
        "Microsoft.VisualStudio.Component.Windows10SDK.10586",
        "Microsoft.VisualStudio.Component.Windows10SDK.14393",
        "Microsoft.VisualStudio.Component.Windows10SDK.15063.Desktop",
        "Microsoft.VisualStudio.Component.Windows10SDK.15063.UWP",
        "Microsoft.VisualStudio.Component.Windows10SDK.15063.UWP.Native",
        "Microsoft.VisualStudio.Component.Windows81SDK",
        "Microsoft.VisualStudio.Component.WinXP",
        "Microsoft.VisualStudio.Component.Workflow",
        "Microsoft.VisualStudio.ComponentGroup.ArchitectureTools.Managed",
        "Microsoft.VisualStudio.ComponentGroup.ArchitectureTools.Native",
        "Microsoft.VisualStudio.ComponentGroup.Azure.CloudServices",
        "Microsoft.VisualStudio.ComponentGroup.Azure.Prerequisites",
        "Microsoft.VisualStudio.ComponentGroup.Azure.ResourceManager.Tools",
        "Microsoft.VisualStudio.ComponentGroup.NativeDesktop.Core",
        "Microsoft.VisualStudio.ComponentGroup.NativeDesktop.Win81",
        "Microsoft.VisualStudio.ComponentGroup.NativeDesktop.WinXP",
        "Microsoft.VisualStudio.ComponentGroup.TestTools.TestAgent",
        "Microsoft.VisualStudio.ComponentGroup.TestTools.TestController",
        "Microsoft.VisualStudio.ComponentGroup.UWP.Cordova",
        "Microsoft.VisualStudio.ComponentGroup.UWP.VC",
        "Microsoft.VisualStudio.ComponentGroup.UWP.Xamarin",
        "Microsoft.VisualStudio.ComponentGroup.VisualStudioExtension.Prerequisites",
        "Microsoft.VisualStudio.Web.BuildTools.ComponentGroup",
        "Microsoft.VisualStudio.Web.Mvc4.ComponentGroup"
    ]
}
```