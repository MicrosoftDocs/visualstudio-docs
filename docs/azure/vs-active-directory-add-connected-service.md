---
title: Entra ID Authentication With Connected Services
description: Connect Microsoft Entra ID (formerly Azure Active Directory) to your application with Connected Services in Visual Studio on Windows.
author: ghogen
manager: mijacobs
ms.subservice: azure-development
ms.custom: devx-track-csharp
ms.topic: how-to
ms.date: 06/27/2025
ms.author: ghogen
#customer intent: As a developer, I want to use Connected Services in Visual Studio on Windows, so I can connect Microsoft Entra ID with my application for authentication.
---

# Add Microsoft Entra ID authentication with Connected Services in Visual Studio

You can add support for Microsoft Entra ID to an ASP.NET web application with the Microsoft identity platform connected service. Microsoft Entra ID enables support for user authentication to ASP.NET Model-View-Controller (MVC) web apps or Active Directory Authentication in web API services.

Microsoft Entra ID authentication offers many advantages:

- Users can authenticate with their accounts from Microsoft Entra ID to connect to your web apps.
- You gain enhanced data security when you expose an API from a web app. 
- You don't have to manage a separate authentication system with its own account and user management.

This article and its [companion articles](#related-content) describe how to use the Visual Studio Connected Service feature for Active Directory.

## Prerequisites

To complete the procedures in this article, the following prerequisites must be satisfied:

- [!INCLUDE [prerequisites-azure-subscription](includes/prerequisites-azure-subscription.md)]

- **Visual Studio**. [Download Visual Studio now](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocs).

## Connect to Microsoft identity platform

Add Microsoft identity platform as a connected service to your application by following these steps:

1. In Visual Studio, create or open an ASP.NET MVC project, or an ASP.NET Web API project.

1. Use one of the following methods to add the Microsoft identity platform connected service:

   :::moniker range=">=vs-2022"

   - Select **Project** > **Connected Services** > **Add** > **Microsoft identity platform**.
   
   - In **Solution Explorer**, right-click the **Connected Services** node for the project, and select **Add** > **Microsoft identity platform**.

   :::moniker-end
   :::moniker range="<=vs-2019"

   - Select **Project** > **Manage Connected Services** > **Add a service dependency** > **Microsoft identity platform**.
   
   - In **Solution Explorer**, right-click the **Connected Services** node for the project, and select **Manage Connected Services > Add a service dependency** > **Microsoft identity platform**.

      :::image type="content" source="./media/vs-azure-active-directory/vs-2019/add-dependency-microsoft-identity-platform.png" border="false" alt-text="Screenshot showing the Microsoft identity platform option in Visual Studio.":::

   :::moniker-end

   If your installation is missing the .NET MSIdentity tool, the **Required components** window opens with a message to complete the install:

   :::image type="content" source="./media/vs-azure-active-directory/required-components.png" border="false" alt-text="Screenshot of the Required Components window with a message to install the .NET MSIdentity tool.":::

   As needed, follow the steps to install the .NET MSIdentity tool, and then continue with this procedure.

1. The **Microsoft identity platform** configuration screen opens.

   As needed, sign in to Azure. After you sign in, you see a list of your applications for the selected **Tenant**:

   :::image type="content" source="./media/vs-azure-active-directory/owned-applications.png" border="false" alt-text="Screenshot showing the list of owned applications.":::

   If you don't have an application, select **Create new**:
   
   1. For Microsoft Entra ID, select **Microsoft** as the tenant.
   
   1. Enter the display name for the new application.
   
   1. Select **Register**:

      :::image type="content" source="./media/vs-azure-active-directory/register-an-application.png" border="false" alt-text="Screenshot showing how to register a new application.":::

   After the new application registers, it appears in the application list.
   
1. In the application list, select the application to use, and select **Next**.

   <a name="update-service-settings"> </a>
   
1. On the **Additional settings** screen, choose your preferred settings. You can enable Microsoft Graph or allow another API project to have access. You can also configure these settings later.

   :::image type="content" source="./media/vs-azure-active-directory/additional-settings.png" border="false" alt-text="Screenshot of additional options for the application, including enable Microsoft Graph and allow API access.":::

1. Select **Next**. The **Summary of changes** screen appears for the project, including updates to dependencies to support Microsoft identity platform:

   :::image type="content" source="./media/vs-azure-active-directory/summary-of-changes.png" border="false" alt-text="Screenshot showing Summary of changes screen for the project.":::

1. Select **Finish**. The **Dependency configuration progress** screen shows the process status. When the process finishes successfully, the status shows the statement "Complete. Microsoft identity platform \<application> is configured."

1. Select **Close** to close the window.

The new connection is listed under **Service Dependencies** in the **Connected Services** screen for the project:

:::image type="content" source="./media/vs-azure-active-directory/identity-platform-service-dependency.png" border="false" alt-text="Screenshot showing the Microsoft identity platform service dependency listed as a connected service for the project.":::

You can also see the Microsoft Entra ID domain for the application connection in the [Azure portal](https://go.microsoft.com/fwlink/p/?LinkID=525040).

## Modify connected service settings

After you add Microsoft identity platform as a connected service, you can modify the settings as needed:

1. In the **Connected Services** > **Service Dependencies** screen, locate the **Microsoft identity platform** service.

1. Select **More options** (**...**) for the service, and then select **Edit dependency**.

1. Select the tenant that contains the application, select the application, and then select **Next**.

Follow the process described earlier to [modify and apply your preferred settings](#update-service-settings). Repeat the process as needed to grant project access for necessary APIs.

## Related content

- [Authentication scenarios for Microsoft Entra ID](/entra/identity-platform/authentication-vs-authorization)
- [Add sign-in with Microsoft to an ASP.NET web app](/entra/identity-platform/quickstart-web-app-sign-in)