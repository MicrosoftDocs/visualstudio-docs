---
title: "GenerateDeploymentManifest Task | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
f1_keywords:
  - "http://schemas.microsoft.com/developer/msbuild/2003#GenerateDeploymentManifest"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "MSBuild, GenerateDeploymentManifest task"
  - "GenerateDeploymentManifest task [MSBuild]"
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# GenerateDeploymentManifest task

Generates a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] deployment manifest. A [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] deployment manifest describes the deployment of an application by defining a unique identity for the deployment, identifying deployment traits such as install or online mode, specifying application update settings and update locations, and indicating the corresponding [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application manifest.

## Parameters

The following table describes the parameters for the `GenerateDeploymentManifest` task.

| Parameter | Description |
|--------------------------| - |
| `AssemblyName` | Optional `String` parameter.<br /><br /> Specifies the `Name` field of the assembly identity for the generated manifest. If this parameter is not specified, the name is inferred from the `EntryPoint` or `InputManifest` parameters. If the name cannot be inferred, the task throws an error. |
| `AssemblyVersion` | Optional `String` parameter.<br /><br /> Specifies the `Version` field of the assembly identity for the generated manifest. If this parameter is not specified, the task uses the value "1.0.0.0". |
| `CreateDesktopShortcut` | Optional `Boolean` parameter.<br /><br /> If true, an icon is created on the desktop during ClickOnce application installation. |
| `DeploymentUrl` | Optional `String` parameter.<br /><br /> Specifies the update location for the application. If this parameter is not specified, no update location is defined for the application. However, if the `UpdateEnabled` parameter is `true`, the update location must be specified. The specified value should be a fully qualified URL or UNC path. |
| `Description` | Optional `String` parameter.<br /><br /> Specifies an optional description for the application. |
| `DisallowUrlActivation` | Optional `Boolean` parameter.<br /><br /> Specifies whether the application should be run automatically when it is opened through a URL. If this parameter is `true`, the application can only be started from the **Start** menu. The default value of this parameter is `false`. This input applies only when the `Install` parameter value is `true`. |
| `EntryPoint` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Indicates the entry point for the generated manifest assembly. For a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] deployment manifest, this input specifies the [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application manifest.<br /><br />If the `EntryPoint` task parameter is not specified, the `<customHostSpecified>` tag is inserted as a child of the `<entryPoint>` tag, for example:<br /><br /> `<entryPoint xmlns="urn:schemas-microsoft-com:asm.v2">`<br /><br /> `<co.v1:customHostSpecified />`<br /><br /> `</entryPoint>`<br /><br /> You can add DLL dependencies to the application manifest by using the following steps:<br /><br /> 1.  Resolve the assembly references with a call to <xref:Microsoft.Build.Tasks.ResolveAssemblyReference>.<br />2.  Pass the output of the previous task and the assembly itself to <xref:Microsoft.Build.Tasks.ResolveManifestFiles>.<br />3.  Pass the dependencies by using the `Dependencies` parameter to <xref:Microsoft.Build.Tasks.GenerateApplicationManifest>. |
| `ErrorReportUrl` | Optional <xref:System.String?displayProperty=fullName> parameter.<br /><br /> Specifies the URL of the web page that is displayed in dialog boxes during ClickOnce installations. |
| `InputManifest` | Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Indicates an input XML document to serve as a base for the manifest generator. This enables structured data, such as custom manifest definitions, to be reflected in the output manifest. The root element in the XML document must be an assembly node in the asmv1 namespace. |
| `Install` | Optional `Boolean` parameter.<br /><br /> Specifies whether the application is an installed application or an online-only application. If this parameter is `true`, the application will be installed on the user's **Start** menu, and can be removed by using the **Add or Remove Programs** dialog box. If this parameter is `false`, the application is intended for online use from a web page. The default value of this parameter is `true`. |
| `MapFileExtensions` | Optional `Boolean` parameter.<br /><br /> Specifies whether the *.deploy* file name extension mapping is used. If this parameter is `true`, every program file is published with a *.deploy* file name extension. This option is useful for web server security to limit the number of file name extensions that must be unblocked to enable [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application deployment. The default value of this parameter is `false`. |
| `MaxTargetPath` | Optional `String` parameter.<br /><br /> Specifies the maximum allowed length of a file path in a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application deployment. If this parameter is specified, the length of each file path in the application is checked against this limit. Any items that exceed the limit will cause a build warning. If this input is not specified or is zero, no checking is performed. |
| `MinimumRequiredVersion` | Optional `String` parameter.<br /><br /> Specifies whether the user can skip the update. If the user has a version that is less than the minimum required, he will not have the option to skip the update. This input only applies when the value of the `Install` parameter is `true`. |
| `OutputManifest` | Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the name of the generated output manifest file. If this parameter is not specified, the name of the output file is inferred from the identity of the generated manifest. |
| `Platform` | Optional `String` parameter.<br /><br /> Specifies the target platform of the application. This parameter can have the following values:<br /><br /> -   `AnyCPU`<br />-   `x86`<br />-   `x64`<br />-   `Itanium`<br /><br /> The default value is `AnyCPU`. |
| `Product` | Optional `String` parameter.<br /><br /> Specifies the name of the application. If this parameter is not specified, the name is inferred from the identity of the generated manifest. This name is used for the shortcut name on the **Start** menu and is part of the name that appears in the **Add or Remove Programs** dialog box. |
| `Publisher` | Optional `String` parameter.<br /><br /> Specifies the publisher of the application. If this parameter is not specified, the name is inferred from the registered user, or the identity of the generated manifest. This name is used for the folder name on the **Start** menu and is part of the name that appears in the **Add or Remove Programs** dialog box. |
| `SuiteNamel` | Optional `String` parameter.<br /><br /> Specifies the name of the folder on the **Start** menu where the application is located after ClickOnce deployment. |
| `SupportUrl` | Optional `String` parameter.<br /><br /> Specifies the link that appears in the **Add or Remove Programs** dialog box for the application. The specified value should be a fully qualified URL or UNC path. |
| `TargetCulture` | Optional `String` parameter.<br /><br /> Identifies the culture of the application, and specifies the `Language` field of the assembly identity for the generated manifest. If this parameter is not specified, it is assumed that the application is culture invariant. |
| `TrustUrlParameters` | Optional `Boolean` parameter.<br /><br /> Specifies whether URL query-string parameters should be made available to the application. The default value of this parameter is `false`, which indicates that parameters will not be available to the application. |
| `UpdateEnabled` | Optional `Boolean` parameter.<br /><br /> Indicates whether the application is enabled for updates. The default value of this parameter is `false`. This parameter only applies when the value of the `Install` parameter is `true`. |
| `UpdateInterval` | Optional `Int32` parameter.<br /><br /> Specifies the update interval for the application. The default value of this parameter is zero. This parameter only applies when the values of the `Install` and `UpdateEnabled` parameters are both `true`. |
| `UpdateMode` | Optional `String` parameter.<br /><br /> Specifies whether updates should be checked in the foreground before the application is started, or in the background as the application is running. This parameter can have the following values:<br /><br /> -   `Foreground`<br />-   `Background`<br /><br /> The default value of this parameter is `Background`. This parameter only applies when the values of the `Install` and `UpdateEnabled` parameters are both `true`. |
| `UpdateUnit` | Optional `String` parameter.<br /><br /> Specifies the units for the `UpdateInterval` parameter. This parameter can have the following values:<br /><br /> -   `Hours`<br />-   `Days`<br />-   `Weeks`<br /><br /> This parameter only applies when the values of the `Install` and `UpdateEnabled` parameters are both `true`. |

## Remarks

In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.GenerateManifestBase> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of the parameters of the Task class, see [Task base class](../msbuild/task-base-class.md).

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [GenerateApplicationManifest task](../msbuild/generateapplicationmanifest-task.md)
- [SignFile task](../msbuild/signfile-task.md)
- [Task reference](../msbuild/msbuild-task-reference.md)