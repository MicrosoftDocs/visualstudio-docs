---
title: "Security, Versioning, and Manifest Issues in ClickOnce Deployments | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "versioning, ClickOnce applications"
  - "ClickOnce applications, Windows Vista User Account Control"
  - "ClickOnce applications, versioning issues"
  - "security, ClickOnce applications"
  - "Windows 7, ClickOnce deployments"
  - "ClickOnce applications, manifest issues"
  - "User Account Control, ClickOnce applications"
  - "Windows Vista, ClickOnce deployments"
  - "manifests [ClickOnce]"
  - "ClickOnce applications, security issues"
ms.assetid: d5d0c90b-ac1a-44e2-88dc-0d0ffd881624
caps.latest.revision: 23
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Security, Versioning, and Manifest Issues in ClickOnce Deployments
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

There are a variety of issues with [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] security, application versioning, and manifest syntax and semantics that can cause a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] deployment not to succeed.  
  
## ClickOnce and Windows Vista User Account Control  
 In [!INCLUDE[windowsver](../includes/windowsver-md.md)], applications by default run as a standard user, even if the current user is logged in with an account that has administrator permissions. If an application must perform an action that requires administrator permissions, it tells the operating system, which then prompts the user to enter their administrator credentials. This feature, which is named User Account Control (UAC), prevents applications from making changes that may affect the entire operating system without a user's explicit approval. Windows applications declare that they require this permission elevation by specifying the `requestedExecutionLevel` attribute in the `trustInfo` section of their application manifest.  
  
 Due to the risk of exposing applications to security elevation attacks, [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] applications cannot request permission elevation if UAC is enabled for the client. Any [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application that attempts to set its `requestedExecutionLevel` attribute to `requireAdministrator` or `highestAvailable` will not install on [!INCLUDE[windowsver](../includes/windowsver-md.md)].  
  
 In some cases, your [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application may attempt to run with administrator permissions because of installer detection logic on [!INCLUDE[windowsver](../includes/windowsver-md.md)]. In this case, you can set the `requestedExecutionLevel` attribute in the application manifest to `asInvoker`. This will cause the application itself to run without elevation. [!INCLUDE[vs_orcas_long](../includes/vs-orcas-long-md.md)] automatically adds this attribute to all application manifests.  
  
 If you are developing an application that requires administrator permissions for the entire lifetime of the application, you should consider deploying the application by using Windows Installer (MSI) technology instead. For more information, see [Windows Installer Basics](../extensibility/internals/windows-installer-basics.md).  
  
## Online Application Quotas and Partial Trust Applications  
 If your [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application runs online instead of through an installation, it must fit within the quota set aside for online applications. Also, a network application that runs in partial trust, such as with a restricted set of security permissions, cannot be larger than half of the quota size.  
  
 For more information, and instructions about how to change the online application quota, see [ClickOnce Cache Overview](../deployment/clickonce-cache-overview.md).  
  
## Versioning Issues  
 You may experience problems if you assign strong names to your assembly and increment the assembly version number to reflect an application update. Any assembly compiled with a reference to a strong-named assembly must itself be recompiled, or the assembly will try to reference the older version. The assembly will try this because the assembly is using the old version value in its bind request.  
  
 For example, say that you have a strong-named assembly in its own project with version 1.0.0.0. After compiling the assembly, you add it as a reference to the project that contains your main application. If you update the assembly, increment the version to 1.0.0.1, and try to deploy it without also recompiling the application, the application will not be able to load the assembly at run time.  
  
 This error can occur only if you are editing your [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] manifests manually; you should not experience this error if you generate your deployment using [!INCLUDE[vsprvslong](../includes/vsprvslong-md.md)].  
  
## Specifying Individual .NET Framework Assemblies in the Manifest  
 Your application will fail to load if you have manually edited a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] deployment to reference an older version of a [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] assembly. For example, if you added a reference to the System.Net assembly for a version of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] prior to the version specified in the manifest, then an error would occur. In general, you should not attempt to specify references to individual [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] assemblies, as the version of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] against which your application runs is specified as a dependency in the application manifest.  
  
## Manifest Parsing Issues  
 The manifest files that are used by [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] are XML files, and they must be both well-formed and valid: they must obey the XML syntax rules and only use elements and attributes defined in the relevant XML schema.  
  
 Something that can cause problems in a manifest file is selecting a name for your application that contains a special character, such as a single or double quotation mark. The application's name is part of its [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] identity. [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] currently does not parse identities that contain special characters. If your application fails to activate, make sure that you are using only alphabetical and numeric characters for the name, and attempt to deploy it again.  
  
 If you have manually edited your deployment or application manifests, you may have unintentionally corrupted them. Corrupted manifest will prevent a correct [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] installation. You can debug such errors at run time by clicking **Details** on the **ClickOnce Error** dialog box, and reading the error message in the log. The log will list one of the following messages:  
  
- A description of the syntax error, and the line number and character position where the error occurred.  
  
- The name of an element or attribute used in violation of the manifest's schema. If you have added XML manually to your manifests, you will have to compare your additions to the manifest schemas. For more information, see [ClickOnce Deployment Manifest](../deployment/clickonce-deployment-manifest.md) and [ClickOnce Application Manifest](../deployment/clickonce-application-manifest.md).  
  
- An ID conflict. Dependency references in deployment and application manifests must be unique in both their `name` and `publicKeyToken` attributes. If both attributes match between any two elements within a manifest, manifest parsing will not succeed.  
  
## Precautions When Manually Changing Manifests or Applications  
 When you update an application manifest, you must re-sign both the application manifest and the deployment manifest. The deployment manifest contains a reference to the application manifest that includes that file's hash and its digital signature.  
  
### Precautions with Deployment Provider Usage  
 The [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] deployment manifest has a `deploymentProvider` property which points to the full path of the location from where the application should be installed and serviced:  
  
```  
<deploymentProvider codebase="http://myserver/myapp.application" />  
```  
  
 This path is set when [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] creates the application and is compulsory for installed applications. The path points to the standard location where the [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] installer will install the application from and search for updates. If you use the **xcopy** command to copy a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application to a different location, but do not change the `deploymentProvider` property, [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] will still refer back to the original location when it tries to download the application.  
  
 If you want to move or copy an application, you must also update the `deploymentProvider` path, so that the client actually installs from the new location. Updating this path is mostly a concern if you have installed applications. For online applications that are always launched through the original URL, setting the `deploymentProvider` is optional. If `deploymentProvider` is set, it will be honored; otherwise, the URL used to start the application will be used as the base URL to download application files.  
  
> [!NOTE]
> Every time that you update the manifest you must also sign it again.  
  
## See Also  
 [Troubleshooting ClickOnce Deployments](../deployment/troubleshooting-clickonce-deployments.md)   
 [Securing ClickOnce Applications](../deployment/securing-clickonce-applications.md)   
 [Choosing a ClickOnce Deployment Strategy](../deployment/choosing-a-clickonce-deployment-strategy.md)
