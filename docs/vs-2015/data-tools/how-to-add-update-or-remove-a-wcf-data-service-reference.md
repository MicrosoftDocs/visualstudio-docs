---
title: "How to: Add, Update, or Remove a WCF Data Service Reference | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
helpviewer_keywords: 
  - "service references [Visual Studio]"
  - "WCF Data Service reference"
  - "WCF data service references"
  - "ADO.NET service references"
  - "ADO.NET Data Service reference"
ms.assetid: 892ebf37-3af4-472e-8744-92837677d611
caps.latest.revision: 14
author: gewarren
ms.author: gewarren
manager: jillfra
---
# How to: Add, Update, or Remove a WCF Data Service Reference
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

A *service reference* enables a project to access one or more [!INCLUDE[ssAstoria](../includes/ssastoria-md.md)]. Use the **Add Service Reference** dialog box to search for [!INCLUDE[ssAstoria](../includes/ssastoria-md.md)] in the current solution, locally, on a local area network, or on the Internet.  
  
 [!INCLUDE[note_settings_general](../includes/note-settings-general-md.md)]  
  
## Adding a Service Reference  
  
#### To add a reference to an external service  
  
1. In **Solution Explorer**, right-click the name of the project that you want to add the service to, and then click **Add Service Reference**.  
  
     The **Add Service Reference** dialog box appears.  
  
2. In the **Address** box, enter the URL for the service, and then click **Go** to search for the service. If the service implements user name and password security, you may be prompted for a user name and password.  
  
    > [!NOTE]
    > You should only reference services from a trusted source. Adding references from an untrusted source may compromise security.  
  
     You can also select the URL from the **Address** list, which stores the previous 15 URLs at which valid service metadata was found.  
  
     A progress bar is displayed when the search is being performed. You can stop the search at any time by clicking **Stop**.  
  
3. In the **Services** list, expand the node for the service that you want to use and select an entity set.  
  
4. In the **Namespace** box, enter the namespace that you want to use for the reference.  
  
5. Click **OK** to add the reference to the project.  
  
     A service client (proxy) is generated, and metadata that describes the service is added to the app.config file.  
  
#### To add a reference to a service in the current solution  
  
1. In **Solution Explorer**, right-click the name of the project that you want to add the service to, and then click **Add Service Reference**.  
  
     The **Add Service Reference** dialog box appears.  
  
2. Click **Discover**.  
  
     All services (both [!INCLUDE[ssAstoria](../includes/ssastoria-md.md)] and WCF services) in the current solution are added to the **Services** list.  
  
3. In the **Services** list, expand the node for the service that you want to use and select an entity set.  
  
4. In the **Namespace** box, enter the namespace that you want to use for the reference.  
  
5. Click **OK** to add the reference to the project.  
  
     A service client (proxy) is generated, and metadata that describes the service is added to the app.config file.  
  
## Updating a Service Reference  
 The Entity Data Model for a [!INCLUDE[ssAstoria](../includes/ssastoria-md.md)] will sometimes change. When this happens, the service reference must be updated.  
  
#### To update a service reference  
  
- In **Solution Explorer**, right-click the service reference and then click **Update Service Reference**.  
  
     A progress dialog box is displayed while the reference is updated from its original location, and the service client is regenerated to reflect any changes in the metadata.  
  
## Removing a Service Reference  
 If a service reference is no longer being used, you can remove it from your solution.  
  
#### To remove a service reference  
  
- In **Solution Explorer**, right-click the service reference and then click **Delete**.  
  
     The service client will be removed from the solution, and the metadata that describes the service will be removed from the app.config file.  
  
    > [!NOTE]
    > Any code that references the service reference will have to be removed manually.  
  
## See also  
 [Windows Communication Foundation Services and WCF Data Services in Visual Studio](../data-tools/windows-communication-foundation-services-and-wcf-data-services-in-visual-studio.md)
