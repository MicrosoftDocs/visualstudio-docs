---
title: Add, update, or remove a WCF data service reference
description: Review how to add, update, or remove a Windows Communication Foundation (WCF) data service reference.
ms.date: 11/22/2021
ms.custom: SEO-VS-2020
ms.topic: how-to
helpviewer_keywords:
- service references [Visual Studio]
- WCF Data Service reference
- WCF data service references
- ADO.NET service references
- ADO.NET Data Service reference
ms.assetid: 892ebf37-3af4-472e-8744-92837677d611
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-data-tools
ms.workload:
- data-storage
---
# How to: Add, update, or remove a WCF data service reference

For .NET Framework projects, *service reference* enables a project to access one or more [!INCLUDE[ssAstoria](../data-tools/includes/ssastoria_md.md)]. Use the **Add Service Reference** dialog box to search for [!INCLUDE[ssAstoria](../data-tools/includes/ssastoria_md.md)] in the current solution, locally, on a local area network, or on the Internet.

:::moniker range=">=vs-2019"
For .NET Core projects, you can use the **Connected Services** node in **Solution Explorer** to access the **Microsoft WCF Web Service Reference Provider**, which lets you manage Windows Communication Foundation (WCF) data service references.
:::moniker-end

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

## Add a WCF service reference

### To add a reference to an external service (.NET Framework projects)

1. In **Solution Explorer**, right-click the name of the project to which you want to add the service, and then click **Add Service Reference**.

   The **Add Service Reference** dialog box appears.

1. In the **Address** box, enter the URL for the service, and then click **Go** to search for the service. If the service implements user name and password security, you may be prompted for a user name and password.

    > [!NOTE]
    > You should only reference services from a trusted source. Adding references from an untrusted source may compromise security.

     You can also select the URL from the **Address** list, which stores the previous 15 URLs at which valid service metadata was found.

     A progress bar displays when the search is being performed. You can stop the search at any time by clicking **Stop**.

1. In the **Services** list, expand the node for the service that you want to use and select an entity set.

1. In the **Namespace** box, enter the namespace that you want to use for the reference.

1. Click **OK** to add the reference to the project.

     A service client (proxy) is generated, and metadata that describes the service is added to the *app.config* file.

:::moniker range=">=vs-2019"
### To add a reference to an external service (.NET Core projects, including .NET 5 and later)

1. In **Solution Explorer**, double-click or tap the **Connected Services** node.

   The **Configure Services** tab opens.

1. Choose **Microsoft WCF Web Service Reference Provider**.

   The **Configure WCF Web Service Reference** dialog appears.

   ![Screenshot of WCF Web Service Provider dialog box](media/vs-2019/configure-wcf-web-service-reference-dialog.png)

1. In the **URI** box, enter the URL for the service, and then click **Go** to search for the service. If the service implements user name and password security, you may be prompted for a user name and password.

    > [!NOTE]
    > You should only reference services from a trusted source. Adding references from an untrusted source may compromise security.

     You can also select the URL from the **URI** list, which stores the previous 15 URLs at which valid service metadata was found.

     A progress bar displays when the search is being performed. You can stop the search at any time by clicking **Stop**.

1. In the **Services** list, expand the node for the service that you want to use and select an entity set.

1. In the **Namespace** box, enter the namespace that you want to use for the reference.

1. Click **Finish** to add the reference to the project.

     A service client (proxy) is generated, and metadata that describes the service is added to the *app.config* file.
:::moniker-end

### To add a reference to a service in the current solution (.NET Framework projects)

1. In **Solution Explorer**, right-click the name of the project to which you want to add the service, and then click **Add Service Reference**.

    The **Add Service Reference** dialog box appears.

1. Click **Discover**.

    All services (both [!INCLUDE[ssAstoria](../data-tools/includes/ssastoria_md.md)] and WCF services) in the current solution are added to the **Services** list.

1. In the **Services** list, expand the node for the service that you want to use and select an entity set.

1. In the **Namespace** box, enter the namespace that you want to use for the reference.

1. Click **OK** to add the reference to the project.

    A service client (proxy) generates, and metadata that describes the service is added to the *app.config* file.

:::moniker range=">=vs-2019"

### To add a reference to a service in the current solution (.NET Core projects)

1. In **Solution Explorer**, double-click or tap the **Connected Services** node. 

   The **Configure Services** tab opens.

1. Choose **Microsoft WCF Web Service Reference Provider**.

   The **Configure WCF Web Service Reference** dialog appears.

1. Click **Discover**.

    All services (both [!INCLUDE[ssAstoria](../data-tools/includes/ssastoria_md.md)] and WCF services) in the current solution are added to the **Services** list.

1. In the **Services** list, expand the node for the service that you want to use and select an entity set.

1. In the **Namespace** box, enter the namespace that you want to use for the reference.

1. Click **Finish** to add the reference to the project.

    A service client (proxy) generates, and metadata that describes the service is added to the *app.config* file.

:::moniker-end

## Update a service reference

The Entity Data Model for a [!INCLUDE[ssAstoria](../data-tools/includes/ssastoria_md.md)] sometimes changes. When this happens, you must update the service reference.

### To update a service reference

- In **Solution Explorer**, right-click the service reference and then click **Update Service Reference**.

     A progress dialog box displays while the reference is updated from its original location, and the service client is regenerated to reflect any changes in the metadata.

## Remove a service reference

If a service reference is no longer being used, you can remove it from your solution.

### To remove a service reference

- In **Solution Explorer**, right-click the service reference and then click **Delete**.

     The service client will be removed from the solution, and the metadata that describes the service will be removed from the *app.config* file.

    > [!NOTE]
    > Any code that references the service reference must be removed manually.

## See also

- [Windows Communication Foundation Services and WCF data services in Visual Studio](../data-tools/windows-communication-foundation-services-and-wcf-data-services-in-visual-studio.md)
