---
title: Services Page, Project Designer
description: Learn how to use the Services page of the Project Designer to enable and configure client application services for your project.
ms.date: 01/18/2018
ms.topic: reference
f1_keywords:
- vb.ProjectPropertiesServices
helpviewer_keywords:
- Services page in Project Designer
- Project Designer, Services page
ms.custom: "ide-ref"
author:ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
monikerRange: 'vs-2019'
---
# Services Page, Project Designer

Client application services provide simplified access to Microsoft Ajax login, roles, and profile services from Windows Forms and Windows Presentation Foundation (WPF) applications. You can use the **Services** page of the **Project Designer** to enable and configure client application services for your project.

With client application services, you can use a centralized server to authenticate users, determine each user's assigned role or roles, and store per-user application settings that you can share across the network. For more information, see [Client Application Services](/dotnet/framework/common-client-technologies/client-application-services).

To access the **Services** page, select a project node in **Solution Explorer**, and then click **Properties** on the **Project** menu. When the **Project Designer** appears, click the **Services** tab.

## Task List

[How to: Configure Client Application Services](/previous-versions/visualstudio/visual-studio-2010/bb384312\(v=vs.100\))

## UIElement List

 **Configuration**

This control is not editable on this page. For a description of this control, see [Compile Page, Project Designer (Visual Basic)](../../ide/reference/compile-page-project-designer-visual-basic.md) or [Build Page, Project Designer (C#)](../../ide/reference/build-page-project-designer-csharp.md).

 **Platform**

This control is not editable on this page. For a description of this control, see [Compile Page, Project Designer (Visual Basic)](../../ide/reference/compile-page-project-designer-visual-basic.md) or [Build Page, Project Designer (C#)](../../ide/reference/build-page-project-designer-csharp.md).

 **Enable client application services**

Select to enable client application services. You must specify service locations on the **Services** page to use client application services.

 **Use Windows authentication**

Indicates that the authentication provider will use Windows-based authentication, that is, the identity supplied by the Windows operating system.

 **Use Forms authentication**

Indicates that the authentication provider will use forms authentication. This means that your application must provide a user interface for login. For more information, see [How to: Implement User Login with Client Application Services](/previous-versions/visualstudio/visual-studio-2010/bb384313\(v=vs.100\)).

 **Authentication service location**

Used only with forms authentication. Specifies the location of the authentication service.

 **Optional: Credentials provider**

Used only with forms authentication. Indicates the <xref:System.Web.ClientServices.Providers.IClientFormsAuthenticationCredentialsProvider> implementation that the authentication service will use to display a login dialog box when your application calls the `static`<xref:System.Web.Security.Membership.ValidateUser%2A?displayProperty=fullName> method and passes empty strings or `null` for the parameters. If you leave this box blank, you must pass a valid user name and password to the <xref:System.Web.Security.Membership.ValidateUser%2A?displayProperty=fullName> method. You must specify the credentials provider as an assembly-qualified type name. For more information, see <xref:System.Type.AssemblyQualifiedName%2A?displayProperty=fullName> and [Assembly Names](/dotnet/framework/app-domains/assembly-names). In its simplest form, an assembly-qualified type name looks similar to the following example: `MyNamespace.MyLoginClass, MyAssembly`

 **Roles service location**

Specifies the location of the roles service.

 **Web settings service location**

Specifies the location of the profile (web settings) service.

 **Advanced**

Opens the [Advanced Settings for Services Dialog Box](../../ide/reference/advanced-settings-for-services-dialog-box.md), which you can use to override default behavior. For example, you can use this dialog box to specify a database for offline storage instead of using the local file system. For more information, see [Advanced Settings for Services Dialog Box](../../ide/reference/advanced-settings-for-services-dialog-box.md).

## See also

- [Client Application Services](/dotnet/framework/common-client-technologies/client-application-services)
- [Advanced Settings for Services Dialog Box](../../ide/reference/advanced-settings-for-services-dialog-box.md)
- [How to: Configure Client Application Services](/previous-versions/visualstudio/visual-studio-2010/bb384312\(v=vs.100\))
- [Compile Page, Project Designer (Visual Basic)](../../ide/reference/compile-page-project-designer-visual-basic.md)
- [Build Page, Project Designer (C#)](../../ide/reference/build-page-project-designer-csharp.md)
