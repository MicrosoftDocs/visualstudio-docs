---
title: Advanced Settings for Services Dialog Box
description: Learn how to use the Advanced Settings for Services features to configure advanced settings for client application services.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- vb.ProjectPropertiesAdvancedServices
helpviewer_keywords:
- Advanced Settings for Services dialog box
ms.custom: "ide-ref"
author:ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
monikerRange: 'vs-2019'
---
# Advanced Settings for Services Dialog Box

Client application services provide simplified access to Microsoft Ajax login, roles, and profile services from Windows Forms and Windows Presentation Foundation (WPF) applications. You can use the **Services** page in the **Project Designer** to configure client application services. For more information about the **Services** page, see [Services Page, Project Designer](../../ide/reference/services-page-project-designer.md).

Use the **Advanced Settings for Services** dialog box of the **Services** page in the **Project Designer** to configure advanced settings for client application services. By using these settings, you can override some default application service behaviors to enable less common scenarios. For more information, see [Client Application Services](/dotnet/framework/common-client-technologies/client-application-services).

To access the **Advanced Settings for Services** dialog box, select a project node in **Solution Explorer**, and then click **Properties** on the **Project** menu. When the **Project Designer** appears, click the **Services** tab, and then click the **Advanced** button. This button will be disabled until you enable client application services.

## Task List

- [How to: Configure Client Application Services](/previous-versions/visualstudio/visual-studio-2010/bb384312\(v=vs.100\))

## UIElement List

 **Save password hash locally to enable offline login**
Specifies whether an encrypted form of the user's password will be cached locally to enable the user to log in when the application is in offline mode. This option is selected by default.

 **Require users to log on again whenever the server cookie expires**
Specifies whether previously authenticated users are automatically reauthenticated when your application accesses the roles or profile service and the server authentication cookie has expired. Select this option to deny access to the application services and require explicit reauthentication after the cookie expires. This is useful for applications deployed in public locations to make sure that users who leave the application running after use will not remain authenticated indefinitely. This option is cleared by default.

 **Role service cache timeout**
Specifies the amount of time the client role provider will use cached role values instead of accessing the roles service. Set this time interval to a small value when roles are updated frequently or to a larger value when roles are updated infrequently. The default value is one day.

The role provider accesses the cached role values or the roles service when you call the <xref:System.Web.Security.RolePrincipal.IsInRole%2A> method. To programmatically clear the cache and force this method to access the remote service, call the <xref:System.Web.ClientServices.Providers.ClientRoleProvider.ResetCache%2A> method.

 **Use custom connection string**
Specifies whether the client service providers will use a custom data store for the local cache. By default, the service providers will use the local file system for the cache. Selecting this option will automatically populate the text box with a default connection string. You can keep the default connection string to automatically generate and use a SQL Server Compact Edition database, or you can specify a connection string to an existing SQL Server database. For more information, see [How to: Configure Client Application Services](/previous-versions/visualstudio/visual-studio-2010/bb384312\(v=vs.100\)). This option is cleared by default.

## See also

- [Client Application Services](/dotnet/framework/common-client-technologies/client-application-services)
- [Services Page, Project Designer](../../ide/reference/services-page-project-designer.md)
- [How to: Configure Client Application Services](/previous-versions/visualstudio/visual-studio-2010/bb384312\(v=vs.100\))
