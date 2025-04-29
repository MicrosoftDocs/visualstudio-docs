---
title: "Code Access Security for ClickOnce Applications"
description: Explore code access security for ClickOnce applications and how to configure the code access security permissions in Visual Studio.
ms.date: "04/25/2025"
ms.topic: "conceptual"
f1_keywords:
  - "vb.XBAPProjectPropertiesSecurity.HowTo"
  - "vb.XBAProjectPropertiesSecurity.HowTo"
  - "vb.ProjectPropertiesSecurity.HowTo"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "deploying applications [ClickOnce], security"
  - "ClickOnce applications, caspol"
  - "security [ClickOnce], WPF browser-hosted applications"
  - "security [ClickOnce], ClickOnce applications"
  - "ClickOnce applications, code access security policies"
  - "security, ClickOnce"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# Code access security for ClickOnce applications

ClickOnce applications are based on the .NET Framework and are subject to code access security constraints. For this reason, it is important that you understand the implications of code access security and write your ClickOnce applications accordingly.

 Code access security is a mechanism in the .NET Framework that helps limit the access that code has to protected resources and operations. You should configure the code access security permissions for your ClickOnce application to use the zone appropriate for the location of the application installer. In most cases, you can choose the **Internet** zone for a limited set of permissions or the **Local Intranet** zone for a greater set of permissions.

 [!INCLUDE[ndptecclick](../deployment/includes/code-access-security.md)]

## Default ClickOnce code access security
 By default, a ClickOnce application receives Full Trust permissions when it is installed or run on a client computer.

- An application that has Full Trust permissions has unrestricted access to resources such as the file system and the registry. This potentially allows your application (and the end user's system) to be exploited by malicious code.

- When an application requires Full Trust permissions, the end user may be prompted to grant permissions to the application. This means that the application does not truly provide a ClickOnce experience, and the prompt can potentially be confusing to less experienced users.

  > [!NOTE]
  > When installing an application from removable media such as a CD-ROM, the user is not prompted. In addition, a network administrator can configure network policy so that users are not prompted when they install an application from a trusted source. For more information, see [Trusted application deployment overview](../deployment/trusted-application-deployment-overview.md).

  To restrict the permissions for a ClickOnce application, you can modify the code access security permissions for your application to request the zone that best fits the permissions that your application requires. In most cases, you can select the zone from which the application is being deployed. For example, if your application is an enterprise application, you can use the **Local Intranet** zone. If your application is an internet application, you can use the **Internet** zone.

## Configure security permissions
 You should always configure your ClickOnce application to request the appropriate zone to limit the code access security permissions. You can configure security permissions on the **Security** page of the **Project Designer**.

 The **Security** page in the **Project Designer** contains an **Enable ClickOnce Security Settings** check box. When this check box is selected, security permission requests are added to the deployment manifest for your application. At installation time, the user will be prompted to grant permissions if the requested permissions exceed the default permissions for the zone from which the application is deployed. For more information, see [How to: Enable ClickOnce security settings](../deployment/how-to-enable-clickonce-security-settings.md).

 Applications deployed from different locations are granted different levels of permissions without prompting. For example, when an application is deployed from the Internet, it receives a highly restrictive set of permissions. When installed from a local Intranet, it receives more permissions, and when installed from a CD-ROM, it receives Full Trust permissions.

 As a starting point for configuring permissions, you can select a security zone from the **Zone** list on the **Security** page. If your application will potentially be deployed from more than one zone, select the zone with the least permissions. For more information, see [How to: Set a security zone for a ClickOnce application](../deployment/how-to-set-a-security-zone-for-a-clickonce-application.md).

 The properties that can be set vary by permission set; not all permission sets have configurable properties. For more information about the full list of permissions that your application can request, see <xref:System.Security.Permissions>. For more information about how to set permissions for a custom zone, see [How to: Set custom permissions for a ClickOnce application](../deployment/how-to-set-custom-permissions-for-a-clickonce-application.md).

## Debug an application that has restricted permissions
 As a developer, you most likely run your development computer with Full Trust permissions. Therefore, you do not see the same security exceptions when you debug the application that users may see when they run it with restricted permissions.

 In order to catch these exceptions, you have to debug the application with the same permissions as the end user. Debugging with restricted permissions can be enabled on the **Security** page of the **Project Designer**.

 When you debug an application with restricted permissions, exceptions will be raised for any code security demands that have not been enabled on the **Security** page. An exception helper will appear, providing suggestions about how to modify your code to prevent the exception.

 In addition, when you write code, the IntelliSense feature in the Code Editor will disable any members that are not included in the security permissions that you have configured.

 For more information, see [How to: Debug a ClickOnce Application with Restricted Permissions](securing-clickonce-applications.md).

## Security permissions for browser-hosted applications
 Visual Studio provides the following project types for Windows Presentation Foundation (WPF) applications:

- WPF Windows Application

- WPF Web Browser Application

- WPF Custom Control Library

- WPF Service Library

  Of these project types, only WPF Web Browser Applications are hosted in a Web browser and therefore require special deployment and security settings. The default security settings for these applications are as follows:

- **Enable ClickOnce Security Settings**

- **This is a partial trust application**

- **Internet zone** (with default permission set for WPF Web Browser Applications selected)

  In the **Advanced Security Settings** dialog box, the **Debug this application with the selected permission set** check box is selected and disabled. This is because Debug In Zone cannot be turned off for browser-hosted applications.

## Related content
- [Secure ClickOnce applications](../deployment/securing-clickonce-applications.md)
- [Enable and configure ClickOnce security settings](../deployment/how-to-enable-clickonce-security-settings.md)
- [Set a security zone for a ClickOnce application](../deployment/how-to-enable-clickonce-security-settings.md#set-a-security-zone-for-a-clickonce-application)
- [Set custom permissions for a ClickOnce application](../deployment/how-to-enable-clickonce-security-settings.md#set-custom-permissions-for-a-clickonce-application)
- [Debug a ClickOnce application with restricted permissions](securing-clickonce-applications.md)
- [Trusted application deployment overview](../deployment/trusted-application-deployment-overview.md)
- [Security Page, Project Designer](../ide/reference/security-page-project-designer.md)