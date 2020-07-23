---
title: Support URL for prerequisites in ClickOnce deployment
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - ClickOnce deployment, prerequisites
  - ClickOnce deployment, URLs
ms.assetid: 590742c3-a286-4160-aa75-7a441bb2207b
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload: 
  - multiple
---
# How to: Specify a support URL for individual prerequisites in a ClickOnce deployment
A [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] deployment can test for a number of prerequisites that must be available on the client computer for the [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application to run. These dependencies include the required minimum version of the .NET Framework, the version of the operating system, and any assemblies that must be preinstalled in the global assembly cache (GAC). [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)], however, cannot install any of these prerequisites itself; if a prerequisite is not found, it simply halts installation and displays a dialog box explaining why the installation failed.

 There are two methods for installing prerequisites. You can install them using a bootstrapper application. Alternatively, you can specify a support URL for individual prerequisites, which is displayed to users on the dialog box if the prerequisite is not found. The page referenced by that URL can contain links to instructions for installing the required prerequisite. If an application does not specify a support URL for an individual prerequisite, [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] displays the support URL specified in the deployment manifest for the application as a whole, if it is defined.

 While [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], *Mage.exe*, and *MageUI.exe* can all be used to generate [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] deployments, none of these tools directly support specifying a support URL for individual prerequisites. This document describes how to modify your deployment's application manifest and deployment manifest to include these support URLs.

### Specify a support URL for an individual prerequisite

1. Open the application manifest (the *.manifest* file) for the [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application in a text editor.

2. For an operating system prerequisite, add the `supportUrl` attribute to the `dependentOS` element:

   ```xml
    <dependency>
       <dependentOS supportUrl="http://www.adatum.com/MyApplication/wrongOSFound.htm">
         <osVersionInfo>
           <os majorVersion="5" minorVersion="1" buildNumber="2600" servicePackMajor="0" servicePackMinor="0" />
         </osVersionInfo>
       </dependentOS>
     </dependency>
   ```

3. For a prerequisite for a certain version of the common language runtime, add the `supportUrl` attribute to the `dependentAssembly` entry that specifies the common language runtime dependency:

   ```xml
     <dependency>
       <dependentAssembly dependencyType="preRequisite" allowDelayedBinding="true" supportUrl=" http://www.adatum.com/MyApplication/wrongClrVersionFound.htm">
         <assemblyIdentity name="Microsoft.Windows.CommonLanguageRuntime" version="4.0.30319.0" />
       </dependentAssembly>
     </dependency>
   ```

4. For a prerequisite for an assembly that must be preinstalled in the global assembly cache, set the `supportUrl` for the `dependentAssembly` element that specifies the required assembly:

   ```xml
     <dependency>
       <dependentAssembly dependencyType="preRequisite" allowDelayedBinding="true" supportUrl=" http://www.adatum.com/MyApplication/missingSampleGACAssembly.htm">
         <assemblyIdentity name="SampleGACAssembly" version="5.0.0.0" publicKeyToken="04529dfb5da245c5" processorArchitecture="msil" language="neutral" />
       </dependentAssembly>
     </dependency>
   ```

5. Optional. For applications that target the .NET Framework 4, open the deployment manifest (the *.application* file) for the [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application in a text editor.

6. For a .NET Framework 4 prerequisite, add the `supportUrl` attribute to the `compatibleFrameworks` element:

   ```xml
   <compatibleFrameworks  xmlns="urn:schemas-microsoft-com:clickonce.v2" supportUrl="http://adatum.com/MyApplication/CompatibleFrameworks.htm">
     <framework targetVersion="4.0" profile="Client" supportedRuntime="4.0.30319" />
     <framework targetVersion="4.0" profile="Full" supportedRuntime="4.0.30319" />
   </compatibleFrameworks>
   ```

7. Once you have manually altered the application manifest, you must re-sign the application manifest using your digital certificate, then update and re-sign the deployment manifest as well. Use the *Mage.exe* or *MageUI.exe* SDK tools to accomplish this task, as regenerating these files using [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] erases your manual changes. For more information on using Mage.exe to re-sign manifests, see [How to: Re-sign Application and Deployment Manifests](../deployment/how-to-re-sign-application-and-deployment-manifests.md).

## .NET Framework security
 The support URL is not displayed on the dialog box if the application is marked to run in partial trust.

## See also
- [Mage.exe (Manifest Generation and Editing Tool)](/dotnet/framework/tools/mage-exe-manifest-generation-and-editing-tool)
- [Walkthrough: Manually deploy a ClickOnce application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md)
- [\<compatibleFrameworks> element](../deployment/compatibleframeworks-element-clickonce-deployment.md)
- [ClickOnce and Authenticode](../deployment/clickonce-and-authenticode.md)
- [Application deployment prerequisites](../deployment/application-deployment-prerequisites.md)