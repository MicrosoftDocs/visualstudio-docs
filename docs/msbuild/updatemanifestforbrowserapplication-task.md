---
title: "UpdateManifestForBrowserApplication Task"
description: Learn how MSBuild runs the UpdateManifestForBrowserApplication task to add the hostInBrowser element to the application manifest.
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "UpdateManifestForBrowserApplication task [WPF MSBuild]"
  - "adding the <hostInBrowser /> element to the application manifest [WPF MSBuild]"
  - "building XBAP projects [WPF MSBuild]"
  - "UpdateManifestForBrowserApplication task [WPF MSBuild], parameters"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# UpdateManifestForBrowserApplication task

The <xref:Microsoft.Build.Tasks.Windows.UpdateManifestForBrowserApplication> task is run to add the **\<hostInBrowser />** element to the application manifest (*\<projectname>.exe.manifest*) when a XAML  Browser Application (XBAP) project is built.

## Task parameters

|Parameter|Description|
|---------------|-----------------|
|`ApplicationManifest`|Required **ITaskItem[]** parameter.<br /><br /> Specifies the path and name of the application manifest file that you want to add the `<hostInBrowser />` element to.|
|`HostInBrowser`|Required **Boolean** parameter.<br /><br /> Specifies whether to modify the application manifest to include the **\<hostInBrowser />** element. If **true**, a new **\<hostInBrowser />** element is included in the **\<entryPoint />** element. Element inclusion is cumulative: if a **\<hostInBrowser />** element already exists, it isn't removed or overwritten. Instead, an additional **\<hostInBrowser />** element is created. If **false**, the application manifest isn't modified.|

## Remarks

 XBAPs are run by using ClickOnce deployment, so they must be published with supporting deployment and application manifests. MSBuild uses the [GenerateApplicationManifest](generateapplicationmanifest-task.md) task to generate an application manifest.

 Then, to configure an application to be hosted from a browser, an additional **\<hostInBrowser />** element must be added to the application manifest, as shown in the following example:

```xml
<!--MyXBAPApplication.exe.manifest-->
<?xml version="1.0" encoding="utf-8"?>
<asmv1:assembly ... >
    <asmv1:assemblyIdentity ... />
    <application />
    <entryPoint>
      ...
      <hostInBrowser xmlns="urn:schemas-microsoft-com:asm.v3" />
    </entryPoint>
  ...
/>
```

 The <xref:Microsoft.Build.Tasks.Windows.UpdateManifestForBrowserApplication> task is run when an XBAP project is built in order to add the `<hostInBrowser />` element.

## Example

 The following example shows how to make sure that the `<hostInBrowser />` element is included in an application manifest file.

```xml
<Project>
  <UsingTask
    TaskName="Microsoft.Build.Tasks.Windows.UpdateManifestForBrowserApplication"
    AssemblyFile="C:\Program Files\Reference Assemblies\Microsoft\Framework\v3.0\PresentationBuildTasks.dll" />
  <Target Name="UpdateManifestForBrowserApplicationTask">
    <UpdateManifestForBrowserApplication
      ApplicationManifest="MyXBAPApplication.exe.manifest"
      HostInBrowser="true" />
  </Target>
</Project>
```

## See also

- [WPF MSBuild reference](../msbuild/wpf-msbuild-reference.md)
- [Task reference](../msbuild/wpf-msbuild-task-reference.md)
- [MSBuild reference](../msbuild/msbuild-reference.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
- [Build a WPF application (WPF)](/dotnet/framework/wpf/app-development/building-a-wpf-application-wpf)
- [WPF XAML browser applications overview](/dotnet/framework/wpf/app-development/wpf-xaml-browser-applications-overview)