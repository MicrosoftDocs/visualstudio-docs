---
title: "Services Page, Project Designer | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vb.ProjectPropertiesServices"
helpviewer_keywords: 
  - "Services page in Project Designer"
  - "Project Designer, Services page"
ms.assetid: 6dd9e0fa-acba-4d7d-b081-705b0fc86ff5
caps.latest.revision: 26
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
# Services Page, Project Designer
Client application services provide simplified access to [!INCLUDE[ajax_current_short](../../ide/reference/includes/ajax_current_short_md.md)] login, roles, and profile services from Windows Forms and Windows Presentation Foundation (WPF) applications. You can use the **Services** page of the **Project Designer** to enable and configure client application services for your project.  
  
 With client application services, you can use a centralized server to authenticate users, determine each user's assigned role or roles, and store per-user application settings that you can share across the network. For more information, see [Client Application Services](../Topic/Client%20Application%20Services.md).  
  
 To access the **Services** page, select a project node in **Solution Explorer**, and then click **Properties** on the **Project** menu. When the **Project Designer** appears, click the **Services** tab.  
  
> [!NOTE]
>  Client application services require the full version of the .NET Framework, and are not supported in the .NET Framework Client Profile. If the **Enable client application services** check box is disabled, verify that the **Target framework** is set to the .NET Framework 3.5 or later. To view the **Target framework** setting in C#, open the Project Designer and then click the **Application** page. To view the **Target framework** setting in Visual Basic, open the Project Designer, click the **Compile** page, and then click **Advanced Compile Options**.  
  
## Task List  
 [How to: Configure Client Application Services](../Topic/How%20to:%20Configure%20Client%20Application%20Services.md)  
  
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
 Indicates that the authentication provider will use forms authentication. This means that your application must provide a user interface for login. For more information, see [How to: Implement User Login with Client Application Services](../Topic/How%20to:%20Implement%20User%20Login%20with%20Client%20Application%20Services.md).  
  
 **Authentication service location**  
 Used only with forms authentication. Specifies the location of the authentication service.  
  
 **Optional: Credentials provider**  
 Used only with forms authentication. Indicates the <xref:System.Web.ClientServices.Providers.IClientFormsAuthenticationCredentialsProvider> implementation that the authentication service will use to display a login dialog box when your application calls the `static`<xref:System.Web.Security.Membership.ValidateUser%2A?displayProperty=fullName> method and passes empty strings or `null` for the parameters. If you leave this box blank, you must pass a valid user name and password to the <xref:System.Web.Security.Membership.ValidateUser%2A?displayProperty=fullName> method. You must specify the credentials provider as an assembly-qualified type name. For more information, see <xref:System.Type.AssemblyQualifiedName%2A?displayProperty=fullName> and [Assembly Names](../Topic/Assembly%20Names.md). In its simplest form, an assembly-qualified type name looks similar to the following example: `MyNamespace.MyLoginClass, MyAssembly`  
  
 **Roles service location**  
 Specifies the location of the roles service.  
  
 **Web settings service location**  
 Specifies the location of the profile (Web settings) service.  
  
 **Advanced**  
 Opens the [Advanced Settings for Services Dialog Box](../../ide/reference/advanced-settings-for-services-dialog-box.md), which you can use to override default behavior. For example, you can use this dialog box to specify a database for offline storage instead of using the local file system. For more information, see [Advanced Settings for Services Dialog Box](../../ide/reference/advanced-settings-for-services-dialog-box.md).  
  
## See Also  
 [Client Application Services](../Topic/Client%20Application%20Services.md)   
 [Advanced Settings for Services Dialog Box](../../ide/reference/advanced-settings-for-services-dialog-box.md)   
 [How to: Configure Client Application Services](../Topic/How%20to:%20Configure%20Client%20Application%20Services.md)   
 [Compile Page, Project Designer (Visual Basic)](../../ide/reference/compile-page-project-designer-visual-basic.md)   
 [Build Page, Project Designer (C#)](../../ide/reference/build-page-project-designer-csharp.md)   
 [Introduction to the Project Designer](http://msdn.microsoft.com/en-us/898dd854-c98d-430c-ba1b-a913ce3c73d7)