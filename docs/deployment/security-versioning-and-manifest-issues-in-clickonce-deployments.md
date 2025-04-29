---
title: "Security/versioning/manifest issues (ClickOnce)"
description: Learn about issues with ClickOnce security, application versioning, and manifest syntax and semantics that can cause a ClickOnce deployment not to succeed.
ms.date: "11/04/2016"
ms.topic: "conceptual"
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
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# Security, versioning, and manifest issues in ClickOnce deployments

There are a variety of issues with ClickOnce security, application versioning, and manifest syntax and semantics that can cause a ClickOnce deployment not to succeed.

## ClickOnce and Windows User Account Control

In Windows Vista and later versions of Windows, applications by default run as a standard user, even if the current user is logged in with an account that has administrator permissions. If an application must perform an action that requires administrator permissions, it tells the operating system, which then prompts the user to enter their administrator credentials. This feature, which is named User Account Control (UAC), prevents applications from making changes that may affect the entire operating system without a user's explicit approval. Windows applications declare that they require this permission elevation by specifying the `requestedExecutionLevel` attribute in the `trustInfo` section of their application manifest.

Due to the risk of exposing applications to security elevation attacks, ClickOnce applications can't request permission elevation if UAC is enabled for the client. Any ClickOnce application that attempts to set its `requestedExecutionLevel` attribute to `requireAdministrator` or `highestAvailable` won't install on Windows Vista and later versions.

In some cases, your ClickOnce application may attempt to run with administrator permissions because of installer detection logic on Windows. In this case, you can set the `requestedExecutionLevel` attribute in the application manifest to `asInvoker`. This will cause the application itself to run without elevation. Visual Studio automatically adds this attribute to all application manifests.

If you're developing an application that requires administrator permissions for the entire lifetime of the application, you should consider deploying the application by using Windows Installer (MSI) technology instead. For more information, see [Windows Installer basics](../extensibility/internals/windows-installer-basics.md).

## Online application quotas and partial trust applications

If your ClickOnce application runs online instead of through an installation, it must fit within the quota set aside for online applications. Also, a network application that runs in partial trust, such as with a restricted set of security permissions, can't be larger than half of the quota size.

 [!INCLUDE[ndptecclick](../deployment/includes/code-access-security-partial-trust.md)]

For more information, and instructions about how to change the online application quota, see [ClickOnce cache overview](../deployment/clickonce-cache-overview.md).

## Versioning issues

You may experience problems if you assign strong names to your assembly and increment the assembly version number to reflect an application update. Any assembly compiled with a reference to a strong-named assembly must itself be recompiled, or the assembly will try to reference the older version. The assembly will try this because the assembly is using the old version value in its bind request.

For example, say that you have a strong-named assembly in its own project with version 1.0.0.0. After compiling the assembly, you add it as a reference to the project that contains your main application. If you update the assembly, increment the version to 1.0.0.1, and try to deploy it without also recompiling the application, the application won't be able to load the assembly at run time.

This error can occur only if you're editing your ClickOnce manifests manually; you shouldn't experience this error if you generate your deployment using Visual Studio.

## Specify individual .NET Framework assemblies in the manifest

Your application will fail to load if you have manually edited a ClickOnce deployment to reference an older version of a .NET Framework assembly. For example, if you added a reference to the System.Net assembly for a version of the .NET Framework prior to the version specified in the manifest, then an error would occur. In general, you shouldn't attempt to specify references to individual .NET Framework assemblies, as the version of the .NET Framework against which your application runs is specified as a dependency in the application manifest.

## Manifest parsing issues

The manifest files that are used by ClickOnce are XML files, and they must be both well-formed and valid: they must obey the XML syntax rules and only use elements and attributes defined in the relevant XML schema.

Something that can cause problems in a manifest file is selecting a name for your application that contains a special character, such as a single or double quotation mark. The application's name is part of its ClickOnce identity. ClickOnce currently doesn't parse identities that contain special characters. If your application fails to activate, make sure that you're using only alphabetical and numeric characters for the name, and attempt to deploy it again.

If you have manually edited your deployment or application manifests, you may have unintentionally corrupted them. Corrupted manifest will prevent a correct ClickOnce installation. You can debug such errors at run time by clicking **Details** on the **ClickOnce Error** dialog box, and reading the error message in the log. The log will list one of the following messages:

- A description of the syntax error, and the line number and character position where the error occurred.

- The name of an element or attribute used in violation of the manifest's schema. If you have added XML manually to your manifests, you will have to compare your additions to the manifest schemas. For more information, see [ClickOnce deployment manifest](../deployment/clickonce-deployment-manifest.md) and [ClickOnce application manifest](../deployment/clickonce-application-manifest.md).

- An ID conflict. Dependency references in deployment and application manifests must be unique in both their `name` and `publicKeyToken` attributes. If both attributes match between any two elements within a manifest, manifest parsing won't succeed.

## Precautions when manually changing manifests or applications

When you update an application manifest, you must re-sign both the application manifest and the deployment manifest. The deployment manifest contains a reference to the application manifest that includes that file's hash and its digital signature.

### Precautions with deployment provider usage

The ClickOnce deployment manifest has a `deploymentProvider` property which points to the full path of the location from where the application should be installed and serviced:

```xml
<deploymentProvider codebase="http://myserver/myapp.application" />
```

This path is set when ClickOnce creates the application and is compulsory for installed applications. The path points to the standard location where the ClickOnce installer will install the application from and search for updates. If you use the **xcopy** command to copy a ClickOnce application to a different location, but don't change the `deploymentProvider` property, ClickOnce will still refer back to the original location when it tries to download the application.

If you want to move or copy an application, you must also update the `deploymentProvider` path, so that the client actually installs from the new location. Updating this path is mostly a concern if you have installed applications. For online applications that are always launched through the original URL, setting the `deploymentProvider` is optional. If `deploymentProvider` is set, it will be honored; otherwise, the URL used to start the application will be used as the base URL to download application files.

> [!NOTE]
> Every time that you update the manifest you must also sign it again.

## Related content

[Troubleshoot ClickOnce deployments](../deployment/troubleshooting-clickonce-deployments.md)
[Secure ClickOnce applications](../deployment/securing-clickonce-applications.md)
[Choose a ClickOnce deployment strategy](../deployment/choosing-a-clickonce-deployment-strategy.md)
