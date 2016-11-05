---
title: "UpdateManifestForBrowserApplication Task | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "UpdateManifestForBrowserApplication task [WPF MSBuild]"
  - "adding the <hostInBrowser /> element to the application manifest [WPF MSBuild]"
  - "building XBAP projects [WPF MSBuild]"
  - "UpdateManifestForBrowserApplication task [WPF MSBuild], parameters"
ms.assetid: 653339f7-654b-4d64-a26a-5c9f27036895
caps.latest.revision: 8
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# UpdateManifestForBrowserApplication Task
The <xref:Microsoft.Build.Tasks.Windows.UpdateManifestForBrowserApplication> task is run to add the **\<hostInBrowser />** element to the application manifest (*projectname*.exe.manifest) when a [!INCLUDE[TLA#tla_xbap](../msbuild/includes/tlasharptla_xbap_md.md)] project is built.  
  
## Task Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`ApplicationManifest`|Required **ITaskItem[]** parameter.<br /><br /> Specifies the path and name of the application manifest file that you want to add the `<hostInBrowser />` element to.|  
|`HostInBrowser`|Required **Boolean** parameter.<br /><br /> Specifies whether to modify the application manifest to include the **\<hostInBrowser />** element. If **true**, a new `<`**hostInBrowser />** element is included in the **\<entryPoint />** element. Note that element inclusion is cumulative: if a **\<hostInBrowser />** element already exists, it is not removed or overwritten. Instead, an additional **\<hostInBrowser />** element is created. If **false**, the application manifest is not modified.|  
  
## Remarks  
 [!INCLUDE[TLA2#tla_xbap#plural](../msbuild/includes/tla2sharptla_xbapsharpplural_md.md)] are run by using [!INCLUDE[TLA#tla_clickonce](../msbuild/includes/tlasharptla_clickonce_md.md)] deployment and, therefore, must by published with supporting deployment and application manifests. [!INCLUDE[TLA#tla_msbuild](../msbuild/includes/tlasharptla_msbuild_md.md)] uses the [GenerateApplicationManifest](http://msdn2.microsoft.com/library/6wc2ccdc.aspx) task to generate an application manifest.  
  
 Then, to configure an application to be hosted from a browser, an additional element, **\<hostInBrowser />** must be added to the application manifest, as show in the following example:  
  
```  
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
  
 The <xref:Microsoft.Build.Tasks.Windows.UpdateManifestForBrowserApplication> task is run when an [!INCLUDE[TLA2#tla_xbap](../msbuild/includes/tla2sharptla_xbap_md.md)] project is built in order to add the `<hostInBrowser />` element.  
  
## Example  
 The following example shows how to ensure that the `<hostInBrowser />` element is included in an application manifest file.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
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
  
## See Also  
 [WPF MSBuild Reference](../msbuild/wpf-msbuild-reference.md)   
 [Task Reference](../msbuild/wpf-msbuild-task-reference.md)   
 [MSBuild Reference](../msbuild/msbuild-reference.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)   
 [Building a WPF Application (WPF)](../Topic/Building%20a%20WPF%20Application%20\(WPF\).md)   
 [WPF XAML Browser Applications Overview](../Topic/WPF%20XAML%20Browser%20Applications%20Overview.md)