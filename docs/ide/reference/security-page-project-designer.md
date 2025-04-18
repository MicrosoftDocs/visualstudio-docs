---
title: Security Page, Project Designer
description: The Security page of the Project Designer is used to configure code access security settings for applications that are deployed by using ClickOnce deployment.
ms.date: 11/04/2016
ms.subservice: deployment
ms.topic: reference
f1_keywords:
- vb.ProjectPropertiesSecurity
- vb.XBAPProjectPropertiesSecurity
helpviewer_keywords:
- Project Designer, Security page
- Security page in Project Designer
ms.custom: "ide-ref"
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
monikerRange: 'vs-2019'
---
# Security Page, Project Designer

The **Security** page of the **Project Designer** is used to configure code access security settings for applications that are deployed by using ClickOnce deployment. For more information, see [Code Access Security for ClickOnce Applications](../../deployment/code-access-security-for-clickonce-applications.md).

To access the **Security** page, click a project node in **Solution Explorer**, and then, on the **Project** menu, click **Properties**. When the **Project Designer** appears, click the **Security** tab.

## Security Settings

 **Enable ClickOnce Security Settings**

Determines whether security settings are enabled at design time. When this option is cleared, all other options on the **Security** page are unavailable.

> [!NOTE]
> When you publish an application by using the **Publish** wizard, this option is automatically enabled.

When you select this option, you have the choice of selecting one of two radio buttons: **This is a full trust application** or **This is a partial trust application**.

By default, for WPF Web Browser Application projects, this option is selected.

By default, for all other project types, this option is cleared.

 **This is a full trust application**

If you select this option, the application requests Full Trust permissions when it is installed or run on a client computer. Avoid using Full Trust if possible, because your application will be granted unrestricted access to resources such as the file system and the registry.

By default, for WPF Web Browser Application projects, this option is set to Partial Trust.

By default, for all other project types, this option is set to Full Trust.

 **This is a partial trust application**

If you select this option, the application requests Partial Trust permissions when it is installed or run on a client computer. *Partial Trust* means that only the actions that are permitted under the requested code access security permissions will run. For more information about how to configure security permissions, see [Code Access Security for ClickOnce Applications](../../deployment/code-access-security-for-clickonce-applications.md).

You can specify the Partial Trust security settings by configuring the options in the **ClickOnce Security Permissions** area.

## ClickOnce Security Permissions

 **Zone your application will be installed from**

Specifies a default set of code-access security permissions. Choose **Internet** or **Local Intranet** for a restricted permission set, or choose **(Custom)** to configure a custom permission set. If the application requests more permissions than granted in a zone, a ClickOnce trust prompt appears for the end user to grant the additional permissions. For more information about how to configure security permissions, see [Code Access Security for ClickOnce Applications](../../deployment/code-access-security-for-clickonce-applications.md).

By default, for WPF Web Browser Application projects, this option is set to **Internet**.

 **Edit Permissions XML**

Opens the application manifest template (app.manifest) to configure the permissions for the **(Custom)** permission set.

 **Advanced**

Opens the [Advanced Security Settings Dialog Box](../../ide/reference/advanced-security-settings-dialog-box.md), which is used to configure settings for debugging the application with restricted permissions. These settings are checked during debugging, and permission exceptions indicate that your application may need more permissions than defined in a zone.

## See also

- <xref:System.Security.Permissions.WebBrowserPermission>
- <xref:System.Security.Permissions.MediaPermission>
- [Code Access Security for ClickOnce Applications](../../deployment/code-access-security-for-clickonce-applications.md)
- [How to: Enable ClickOnce Security Settings](../../deployment/how-to-enable-clickonce-security-settings.md)
- [How to: Set a Security Zone for a ClickOnce Application](../../deployment/how-to-set-a-security-zone-for-a-clickonce-application.md)
- [How to: Set Custom Permissions for a ClickOnce Application](../../deployment/how-to-set-custom-permissions-for-a-clickonce-application.md)
- [Secure ClickOnce apps](../../deployment/securing-clickonce-applications.md)
- [ClickOnce Security and Deployment](../../deployment/clickonce-security-and-deployment.md)
- [Project Properties Reference](../../ide/reference/project-properties-reference.md)
- [Advanced Security Settings Dialog Box](../../ide/reference/advanced-security-settings-dialog-box.md)
