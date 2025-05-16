---
title: "Securing ClickOnce Applications"
description: Learn about the implications of code access security constraints in the .NET Framework that can limit access to code for your ClickOnce applications.
ms.date: "02/17/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "Windows applications, ClickOnce security"
  - "ClickOnce deployment, security"
  - "deploying applications, ClickOnce security"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# Secure ClickOnce applications

ClickOnce applications are subject to code access security constraints in the .NET Framework to help limit the access that code has to protected resources and operations. For that reason, it is important that you understand the implications of code access security to write your ClickOnce applications accordingly. Your applications can use Full Trust or use partial zones, such as the Internet and Intranet zones, to limit access.

 Additionally, ClickOnce uses certificates to verify the authenticity of the application's publisher, and to sign the application and deployment manifests to prove that the files haven't been tampered with. Signing is an optional step, which makes it easier to change the application files after the manifests are generated. However, without signed manifests, it is difficult to ensure that the application installer isn't tampered in man-in-the-middle security attacks. For this reason, we recommend that you sign your application and deployment manifests to help secure your applications.

## Zones
 Applications that are deployed using ClickOnce technology are restricted to a set of permissions and actions that are defined by the security zone. Security zones are defined in the browser, and are based on the location of the application. The following table lists the default permissions based on the deployment location:

|Deployment Location|Security Zone|
|-------------------------|-------------------|
|Run from Web|Internet Zone|
|Install from Web|Internet Zone|
|Install from network file share|Local Intranet Zone|
|Install from CD-ROM|Full Trust|

 The default permissions are based on the location from which the original version of the application was deployed; updates to the application will inherit those permissions. If the application is configured to check for updates from a Web or network location and a newer version is available, the original installation can receive permissions for the Internet or Intranet zone instead of full-trust permissions. To prevent users from being prompted, a system administrator can specify a ClickOnce deployment policy that defines a specific application publisher as a trusted source. For computers on which this policy is deployed, permissions will be granted automatically and the user won't be prompted. For more information, see [Trusted Application Deployment Overview](../deployment/trusted-application-deployment-overview.md). To configure trusted application deployment, the certificate can be installed to the machine or enterprise level. For more information, see [How to: Add a Trusted Publisher to a Client Computer for ClickOnce Applications](../deployment/how-to-add-a-trusted-publisher-to-a-client-computer-for-clickonce-applications.md).

 [!INCLUDE[ndptecclick](../deployment/includes/dotnet-feature-unsupported.md)]

## Code access security policies
 Permissions for an application are determined by the settings in the [\<trustInfo> Element](../deployment/trustinfo-element-clickonce-application.md) element of the application manifest. Visual Studio automatically generates this information based on the settings on the project's **Security** property page. A ClickOnce application is granted only the specific permissions that it requests. For example, where file access requires full-trust permissions, if the application requests file-access permission, it will only be granted file-access permission, not full-trust permissions. When developing your ClickOnce application, you should make sure that you request only the specific permissions that the application needs. In most cases, you can use the Internet or Local Intranet zones to limit your application to partial trust. For more information, see [How to: Set a security zone for a ClickOnce application](../deployment/how-to-enable-clickonce-security-settings.md#set-a-security-zone-for-a-clickonce-application). If your application requires custom permissions, you can create a custom zone. For more information, see [How to: Set custom permissions for a ClickOnce application](../deployment/how-to-enable-clickonce-security-settings.md#set-custom-permissions-for-a-clickonce-application).

 [!INCLUDE[ndptecclick](../deployment/includes/code-access-security.md)]

 Including a permission that isn't part of the default permission set for the zone from which the application is deployed will cause the end user to be prompted to grant permission at install or update time. To prevent users from being prompted, a system administrator can specify a ClickOnce deployment policy that defines a specific application publisher as a trusted source. On computers where this policy is deployed, permissions will automatically be granted and the user won't be prompted.

 As a developer, it is your responsibility to make sure that your application will run with the appropriate permissions. If the application requests permissions outside of a zone during run time, a security exception may appear. Visual Studio enables you to debug your application in the target security zone and provides help in developing secure applications. For more information, see [Debug ClickOnce apps that use System.Deployment.Application](../deployment/debugging-clickonce-applications-that-use-system-deployment-application.md).

 For more information about code access security and ClickOnce, see [Code access security for ClickOnce applications](../deployment/code-access-security-for-clickonce-applications.md).

## Code-signing certificates
 To publish an application by using ClickOnce deployment, you can sign the application and deployment manifests for the application by using a public/private key pair. The tools for signing a manifest are available on the **Signing** page of the **Project Designer**. For more information, see [Signing Page, Project Designer](../ide/reference/signing-page-project-designer.md).

 After the manifests are signed, the publisher information based on the Authenticode signature will be displayed to the user in the permissions dialog box during installation, to show the user that the application originated from a trusted source.

 For more information about ClickOnce and certificates, see [ClickOnce and Authenticode](../deployment/clickonce-and-authenticode.md).

## ASP.NET form-based authentication
 If you want to control which deployments each user can access, you should not enable anonymous access to ClickOnce applications deployed on a Web server. Rather, you would enable users access to the deployments you have installed based on a user's identity using Windows authentication.

 ClickOnce does not support ASP.NET forms-based authentication because it uses persistent cookies; these present a security risk because they reside in the browser cache and can be hacked. Therefore, if you're deploying ClickOnce applications, any authentication scenario besides Windows authentication is unsupported.

## Pass arguments
 An additional security consideration occurs if you have to pass arguments into a ClickOnce application. ClickOnce enables developers to supply a query string to applications deployed over the Web. The query string takes the form of a series of name-value pairs at the end of the URL used to start the application:

 `http://servername.adatum.com/WindowsApp1.application?username=joeuser`

 By default, query-string arguments are disabled. To enable them, the attribute `trustUrlParameters` must be set in the application's deployment manifest. This value can be set from Visual Studio and from MageUI.exe. For detailed steps on how to enable passing query strings, see [How to: Retrieve query string information in an online ClickOnce application](../deployment/how-to-retrieve-query-string-information-in-an-online-clickonce-application.md).

 You should never pass arguments retrieved through a query string to a database or to the command line without checking the arguments to make sure that they're safe. Unsafe arguments are ones that include database or command line escape characters that could allow a malicious user to manipulate your application into executing arbitrary commands.

> [!NOTE]
> Query-string arguments are the only way to pass arguments to a ClickOnce application at startup. You can't pass arguments to a ClickOnce application from the command line.

## Deploying obfuscated assemblies
 Visual Studio includes the free [PreEmptive Protection - Dotfuscator Community](../ide/dotfuscator/index.md), which you can use to protect your ClickOnce applications through code obfuscation and active protection measures.  For details, please see [the ClickOnce section of the Dotfuscator Community User Guide](https://www.preemptive.com/dotfuscator/ce/docs/help/5.27/advanced_clickonce.html).

## Related content
- [ClickOnce security and deployment](../deployment/clickonce-security-and-deployment.md)
- [Choose a ClickOnce deployment strategy](../deployment/choosing-a-clickonce-deployment-strategy.md)
