---
title: Adding References Using NuGet Versus an Extension SDK
description: Learn about the differences between packaging software as a NuGet package or as a software development kit when referenced in a Visual Studio project.
ms.date: 08/02/2019
ms.topic: conceptual
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# NuGet versus SDK as a project reference

This article is designed to help developers choose whether to package their software as a NuGet package or as a software development kit (SDK). Specifically, it discusses differences between the two when they're referenced in a Visual Studio project.

- [NuGet](/nuget) is an open-source package-management system that simplifies the process of incorporating libraries into a project. For .NET (including .NET Core), NuGet is the Microsoft-supported mechanism for sharing code. NuGet defines how packages for .NET are created, hosted, and consumed, and provides the tools for each of those roles. In Visual Studio, you add NuGet packages to a project by using the [Package Manager](/nuget/consume-packages/install-use-packages-visual-studio) user interface.

- An [SDK](../extensibility/creating-a-software-development-kit.md) is a collection of files that Visual Studio treats as a single reference item. The Reference Manager dialog box in Visual Studio lists all SDKs that are relevant to the current project when you choose **Add Reference**. When you add an SDK to a project, you can access all of the contents of that SDK through IntelliSense, the Toolbox window, designers, the Object Browser, MSBuild, deployment, debugging, and packaging.

## Which mechanism should I use?

The following table helps you compare the referencing features of an SDK with the referencing features of NuGet.

| Feature | SDK Support | SDK Notes | NuGet Support | NuGet Notes |
| - | - | - |---------------| - |
| The mechanism references one entity and then all the files and functionality are available. | Y | You add an SDK by using the **Reference Manager** dialog box, and all the files and functionality are available during the development workflow. | Y | |
| MSBuild automatically consumes assemblies and Windows metadata (*.winmd*) files. | Y | References in the SDK are automatically passed to the compiler. | Y | |
| MSBuild automatically consumes the  .h or .lib files. | Y | The *SDKName.props* file tells Visual Studio how to set up the Visual C++ directory, and so forth, for automatic *.h* or *.lib* file consumption. | N | |
| MSBuild automatically consumes the  *.js* or *.css* files. | Y | In **Solution Explorer**, you can expand the JavaScript SDK reference node to show individual *.js* or *.css* files and then generate `<source include/>` tags by dragging those files to their source files. The SDK supports F5 and automatic package setup. | Y | |
| MSBuild automatically adds the control in the **Toolbox**. | Y | The **Toolbox** can consume SDKs and show controls in the tabs that you specify. | N | |
| The mechanism supports Visual Studio Installer for extensions (VSIX). | Y | VSIX has a special manifest and logic to create SDK packages | Y | The VSIX can be embedded in another setup program. |
| The **Object Browser** enumerates references. | Y | The **Object Browser** automatically gets the list of references in SDKs and enumerates them. | N | |
| Files and links automatically get added to  the **Reference Manager** dialog box (help links, and so forth auto populate) | Y | The **Reference Manager** dialog box automatically enumerates SDKs, along with help links and the list of SDK dependencies. | N | NuGet provides its own **Manage NuGet Packages** dialog box. |
| The mechanism supports multiple architectures. | Y | SDKs can ship multiple configurations. MSBuild consumes the appropriate files for each project configuration. | N | |
| The mechanism supports multiple configurations. | Y | SDKs can ship multiple configurations. Depending on project architecture, MSBuild consumes the appropriate files for each project architecture. | N | |
| The mechanism can specify "not to copy." | Y | Depending on whether files are dropped in the *\redist* or *\designtime* folder, you can control which files to copy into the consuming application's package. | N | You declare which files to copy in the package manifest. |
| Content appears in localized files. | Y | Localized XML documents in SDKs are automatically included  for a better design-time experience. | N | |
| MSBuild supports consuming  multiple versions of an SDK simultaneously. | Y | The SDK supports consuming multiple versions simultaneously. | N | This isn't referencing. You can't have more than one version of NuGet files in your project at a time. |
| The mechanism supports specifying applicable target frameworks, Visual Studio versions, and project types. | Y | The **Reference Manager** dialog box and the **Toolbox** show only the SDKs that apply to a project, so that users can more easily choose the appropriate SDKs. | Y (partial) | Pivot is the Target Framework. There is no filtering on user interface. At installation time, it might return an error. |
| The mechanism supports specifying registration info for native WinMDs. | Y | You can specify the correlation between the .winmd file and the .dll file in *SDKManifest.xml*. | N | |
| The mechanism supports specifying dependencies on other SDKs. | Y | The SDK only notifies the user; the user must still install them and reference them manually. | Y | NuGet pulls them automatically; the user isn't notified. |
| The mechanism integrates with  Microsoft Store concepts such as app manifest and Framework ID. | Y | The SDK must pass concepts that are specific to the Store so that packaging and F5 work correctly with SDKs that are available in theStore. | N | |
| The mechanism  integrates with the app debugging pipeline for Windows 8.x Store apps. | Y | The SDK must pass Store-specific concepts so that packaging and F5 work correctly with SDKs available in the Store. | Y | NuGet content becomes part of the project. No special F5 consideration is needed. |
| The mechanism integrates with app manifests. | Y | The SDK must pass Store-specific concepts so that packaging and F5 work correctly with SDKs available in the Store. | Y | NuGet content becomes part of the project. No special F5 consideration is needed. |
| The mechanism deploys non-reference files (for example, deploy test framework upon which to run tests of Windows 8.x Store apps). | Y | If you drop the files in the *\redist* folder, the files are automatically deployed. | Y | |
| The mechanism automatically adds the platform SDKs in Visual Studio IDE. | Y | If you drop the Windows 8 SDK or the Windows Phone SDK in a specific location with a specific layout, the SDK is automatically integrated with all the Visual Studio features. | N | |
| The mechanism supports a clean developer machine. (That is, no installation is required, and simple retrieval from source code control will work.) | N | Because you reference an SDK, you must check in your solution and the SDK separately. You can check in the SDK from the two non-registry default locations from which MSBuild iterates SDKs (for details, see [Creating a Software Development Kit](../extensibility/creating-a-software-development-kit.md)). As an alternative, if a custom location consists of the SDKs, you can specify the following code in the project file:<br /><br />`<PropertyGroup>`<br />&nbsp;&nbsp;`<SDKReferenceDirectoryRoot>`<br />&nbsp;&nbsp;`C:\MySDKs`<br />&nbsp;&nbsp;`</SDKReferenceDirectoryRoot>`<br />`</PropertyGroup>`<br /><br /> Then check the SDKs into that location. | Y | You can check out the solution, and Visual Studio immediately recognizes and acts on the files. |
| You can join a large existing community of package authors. | N/A | The community is new. | Y | |
| You can join a large existing community of package consumers. | N/A | The community is new. | Y | |
| You can join an ecosystem of partners (custom galleries, repositories, and so forth). | N/A | The available repositories include Visual Studio Marketplace, Microsoft Download Center, and Microsoft Store. | Y | |
| The mechanism integrates with continuous-integration build servers for both package creation and consumption. | Y | The SDK must pass the checked-in location (SDKReferenceDirectoryRoot property) on command line to MSBuild. | Y | |
| The mechanism supports both stable and pre-release package versions. | Y | The SDK supports adding references to multiple versions. | Y | |
| The mechanism supports auto-update for installed packages. | Y | If shipped as VSIX or part of Visual Studio automatic updates, SDK provides automatic notifications. | Y | |
| The mechanism contains a stand-alone *.exe* file for creating and consuming packages. | Y | The SDK contains *MSBuild.exe*. | Y | |
| Packages can be checked into version control. | Y | You can't check in anything outside the Documents node, which means that the Extension SDKs might not be checked in. The size of Extension SDK might be large. | Y | |
| You can use a PowerShell interface to create and consume packages. | Y (consumption), N (creation) | No tooling for creating an SDK. Consumption is executing MSBuild on the command line. | Y | |
| You can use a Symbol package for debugging support. | Y | If you drop *.pdb* files in the SDK, the files get picked up automatically. | Y | |
| The mechanism supports package manager auto-updates. | N/A | The SDK gets revised with MSBuild. | Y | |
| The mechanism supports a lightweight manifest format. | Y | *SDKManifest.xml* supports many attributes, but a small subset is usually necessary. | Y | |
| The mechanism is available for  all Visual Studio editions. | Y | The SDK supports all Visual Studio editions. | Y | NuGet supports all Visual Studio editions. |

## Related content

- [Manage references in a project](../ide/managing-references-in-a-project.md)
