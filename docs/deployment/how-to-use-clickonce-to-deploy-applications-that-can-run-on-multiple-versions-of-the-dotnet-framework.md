---
title: Use ClickOnce to deploy multitarget apps
description: Learn how to deploy an application that targets multiple versions of the .NET Framework by using the ClickOnce deployment technology. 
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - ClickOnce applications, multiple .NET Framework versions
  - ClickOnce deployment, multiple .NET Framework versions
  - deploying applications [ClickOnce], multiple .NET Framework versions
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# Use ClickOnce to deploy applications that can run on multiple versions of the .NET Framework

You can deploy an application that targets multiple versions of the .NET Framework by using the ClickOnce deployment technology. This requires that you generate and update the application and deployment manifests.

> [!NOTE]
> Before you change the application to target multiple versions of the .NET Framework, you should ensure that your application runs with multiple versions of the .NET Framework. The version common language runtime is different between .NET Framework 4 versus .NET Framework 2.0, .NET Framework 3.0, and .NET Framework 3.5.

 This process requires the following steps:

1. Generate the application and deployment manifests.

2. Change the deployment manifest to list the multiple .NET Framework versions.

3. Change the *app.config* file to list the compatible .NET Framework runtime versions.

4. Change the application manifest to mark dependent assemblies as .NET Framework assemblies.

5. Sign the application manifest.

6. Update and sign the deployment manifest.

### To generate the application and deployment manifests

- Use the Publish Wizard or the Publish Page of the Project Designer to publish the application and generate the application and deployment manifest files. For more information, see [How to: Publish a ClickOnce application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md) or [Specify ClickOnce Publish properties](../deployment/how-to-specify-where-visual-studio-copies-the-files.md).

[!INCLUDE[ndptecclick](../deployment/includes/dotnet-publish-tool.md)]

### To change the deployment manifest to list the multiple .NET Framework versions

1. In the publish directory, open the deployment manifest by using the XML Editor in Visual Studio. The deployment manifest has the *.application* file name extension.

2. Replace the XML code between the `<compatibleFrameworks xmlns="urn:schemas-microsoft-com:clickonce.v2">` and `</compatibleFrameworks>` elements with XML that lists the supported .NET Framework versions for your application.

     The following table shows some of the available .NET Framework versions and the corresponding XML that you can add to the deployment manifest.

    |.NET Framework version|XML|
    |----------------------------|---------|
    |4 Client|\<framework targetVersion="4.0" profile="Client" supportedRuntime="4.0.30319" />|
    |4 Full|\<framework targetVersion="4.0" profile="Full" supportedRuntime="4.0.30319" />|
    |3.5 Client|\<framework targetVersion="3.5" profile="Client" supportedRuntime="2.0.50727" />|
    |3.5 Full|\<framework targetVersion="3.5" profile="Full" supportedRuntime="2.0.50727" />|
    |3.0|\<framework targetVersion="3.0" supportedRuntime="2.0.50727" />|

### To change the app.config file to list the compatible .NET Framework runtime versions

1. In Solution Explorer, open the *app.config* file by using the XML Editor in Visual Studio.

2. Replace (or add) the XML code between the `<startup>` and `</startup>` elements with XML that lists the supported .NET Framework runtimes for your application.

     The following table shows some of the available .NET Framework versions and the corresponding XML that you can add to the deployment manifest.

    |.NET Framework runtime version|XML|
    |------------------------------------|---------|
    |4 Client|\<supportedRuntime version="v4.0.30319" sku=".NETFramework,Version=v4.0,Profile=Client" />|
    |4 Full|\<supportedRuntime version="v4.0.30319" sku=".NETFramework,Version=v4.0" />|
    |3.5 Full|\<supportedRuntime version="v2.0.50727"/>|
    |3.5 Client|\<supportedRuntime version="v2.0.50727" sku="Client"/>|

### To change the application manifest to mark dependent assemblies as .NET Framework assemblies

1. In the publish directory, open the application manifest by using the XML Editor in Visual Studio. The deployment manifest has the *.manifest* file name extension.

2. Add `group="framework"` to the dependency XML for the sentinel assemblies (`System.Core`, `WindowsBase`, `Sentinel.v3.5Client`, and `System.Data.Entity`). For example, the XML should look like the following:

   ```xml
   <dependentAssembly dependencyType="preRequisite" allowDelayedBinding="true" group="framework">
   ```

3. Update the version number of the `<assemblyIdentity>` element for Microsoft.Windows.CommonLanguageRuntime to the version number for the .NET Framework that is the lowest common denominator. For example, if the application targets .NET Framework 3.5 and .NET Framework 4, use the 2.0.50727.0 version number and the XML should look like the following:

   ```xml
   <dependency>
     <dependentAssembly dependencyType="preRequisite" allowDelayedBinding="true">
       <assemblyIdentity name="Microsoft.Windows.CommonLanguageRuntime" version="2.0.50727.0" />
     </dependentAssembly>
   </dependency>
   ```

### To update and re-sign the application and deployment manifests

- Update and re-sign the application and deployment manifests. For more information, see [How to: Re-sign application and deployment manifests](../deployment/how-to-re-sign-application-and-deployment-manifests.md).

## Related content
- [Publish ClickOnce applications](../deployment/publishing-clickonce-applications.md)
- [\<compatibleFrameworks> element](../deployment/compatibleframeworks-element-clickonce-deployment.md)
- [\<dependency> element](../deployment/dependency-element-clickonce-application.md)
- [ClickOnce deployment manifest](../deployment/clickonce-deployment-manifest.md)
- [Configuration file schema](/dotnet/framework/configure-apps/file-schema/index)
