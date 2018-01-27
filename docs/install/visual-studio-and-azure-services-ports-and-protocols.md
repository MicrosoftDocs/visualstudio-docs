---
title: "Ports and protocols for Visual Studio and for Azure Services | Microsoft Docs"
description: ""
ms.custom: ""
ms.date: "01/30/2018"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-acquisition"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords:
  - "network installation, Visual Studio"
  - "administrator guide, Visual Studio"
  - "installing Visual Studio, administrator guide"
  - "list of domains, locations, URLs"
  - "list of ports and protocols, Visual Studio, Azure Services"
ms.assetid:
author: "TerryGLee"
ms.author: "tglee"
manager: ghogen
ms.workload:
  - "multiple"
---

# Ports and protocols for Visual Studio and Azure services
Whether you are using Azure services with Visual Studio or you are an Azure developer, here are the DNS endpoints, protocols, and output ports you'll want to know about.

| Service or scenario | DNS endpoint | Protocol | Port | Description |
| --- | --- | --- | --- | --- |
| Creation/Management of Azure resources | management.azure.com <br>management.core.windows.net   | https | 443 | Used for creating Azure Websites or other resources to support the publishing of web applications, Azure Functions, or WebJobs |
| Updated web publish tooling checks and extension recommendations  | marketplace.visualstudio.com <br/>(via FWLink 859659) <br> visualstudiogallery.msdn.microsoft.com <br/>(via FWLinks 320773, 615538) | https | 443 | Used for checking for the availability of updated publish tooling. If disabled, a potential recommended extension for web publishing may not be shown |
| Updated Azure Resource Creation Endpoint Information  | *.blob.core.windows.net <br/>(via FWLink 391739) | https | 443 | Used to update the endpoints used for the creation of Azure Resources for certain Azure Services. If disabled, the last downloaded or built in endpoint locations are used instead |
| Updated Azure Resource Creation UI Settings | www.microsoft.com <br/>(via FWLinks 722336, 855893, <br>836755, 836756) | http | 80 | Used to update the user interface settings for the creation of Azure Resource as seen when electing to create new resources via the App Service node in Server Explorer, Cloud Explorer, or Web Publish. If disabled, the last downloaded or built-in settings are used instead |
| Remote debugging and Remote profiling of Azure Websites | *.cloudapp.net <br> *.azurewebsites.net | | 4022 | Used for attaching the remote debugger to Azure Websites. If disabled, attaching the remote debugger to Azure Websites will not work |
| Active Directory Graph | graph.windows.net | https | 443 | Used for provisioning new Azure Active Directory applications. If disabled, new web projects with organizational authentication selected won't be able to create or configure the required Azure Active Directory application |
| Azure Functions CLI Update Check | functionscdn.azureedge.net <br/>(via FWLink 835724) | https | 443 | Used for checking for updated versions of the Azure Functions CLI. If disabled, a cached copy (or the copy carried by the Azure Functions component) of the CLI will be used instead |
| Xamarin | | | | |
| Cordova | | | | |
| Node | | | | |
| Cloud Explorer | 1. &#60;clusterendpoint&#62; <br>2. &#60;management endpoint&#62;<br>3. &#60;graph endpoint&#62;<br>4. &#60;storage account endpoint&#62;<br>5. &#60;Azure portal URLs&#62;<br>6. &#60;key vault endpoints&#62; <br>7. &#60;PublicIPAddressOfCluster&#62;| 1&#150;6: https <br>7: tcp| 1. 19080<br>2. 443<br>3. 443<br>4. 443<br>5. 443<br>6. 443  | 1. Example: test12.eastus.cloudapp.com<br>2. Retrieving of subscriptions and retrieving/management of Azure resources<br>3. Retrieving of Azure Stack subscriptions<br>4. Managing Storage resources (ex: mystorageaccount.blob.core.windows.net)<br>5. "Open in Portal" context menu option (opening a resource in the Azure portal)<br>6. Creating and using key vaults for VM debugging (example: myvault.vault.azure.net) <br><br>7. Dynamically allocate block of ports based on number of nodes in the cluster and the available ports. <br><br>Port block: We will try to get 3 times the number of nodes with minimum of 10 ports.<br><br>  For Streaming traces we will try to get the port block from 810. If any of the port is already used, then we will try to get the next block and so on. So if the load balancer is fairly empty, then likely use ports from 810  <br><br> Similarly for debugging 4 sets of the ports blocks are reserved: <br><br>connectorPort: 30398, <br>forwarderPort: 31398, <br>forwarderPortx86: 31399,<br>fileUploadPort: 32398<br>|
| Service Fabric | 1. <br>ocs.Microsoft.com<br>aka.ms <br>go.microsoft.com <br><br>2. <br>vssftools.blob.core.windows.net <br>Vault.azure.com <br>Portal.azure.com <br><br> 3. &#42; vault.azure.net<br><br> 4. <br>app.vsaex.visualstudio.com<br>&#42; .vsspsext.visualstudio.com<br>clouds.vsrm.visualstudio.com <br>clouds.visualstudio.com<br>app.vssps.visualstudio.com <br>&#42; .visualstudio.com | https | 443 | 1. Documentation <br><br> 2. Create Cluster feature <br><br>3. Here the &#42;  would be the azure key vault name (example:- test11220180112110108.vault.azure.net  <br><br>  4. Here the &#42; would be dynamic (example is vsspsextprodch1su1.vsspsext.visualstudio.com |
| Azure SDK | | | | |
| Snapshot Debugger | 1. go.microsoft.com (FWLink 836755) <br>2. management.azure.com <br> 3. &#42;azurewebsites.net <br> 4. &#42;scm.azurewebsites.net<br>5. api.nuget.org/v3/index.json <br>6. msvsmon | 1. https <br>2. https <br>3. http <br>4. https <br>5. https<br>6. Concord <br> | 1. 443<br> 2. 443<br>3. 80 <br>4. 443<br> 5. 443<br> 6. 4022 (Visual Studio version dependent) | 1. Query json file for app service SKU size <br>2. Various Azure RM calls <br>3. Site warmup call via http <br>4. Customer's targeted App Service Kudu endpoint <br>5. Query Site Extension version published in nuget.org <br>6. Remote debugging channel |
| Office Web Add-in  <br><br> Manifest Verification Service | verificationservice.osi.office.net<br> <br>https:&#47;&#47;verificationservice.osi.office.net <br> /ova/addincheckingagent.svc/api<br>/addincheck?format=html | https | 443 | Use to validate manifests for Office web add-ins |
| SharePoint and Office Add-ins | sharepoint.com | https | 443 | Use to publish and test SharePoint and Office Add-ins to SharePoint Online |
| Workflow Manager Test Service Host | | http | 12292 | A firewall rule that is created automatically for testing SharePoint Add-ins with workflows |

<br/>

## See also
* [Install and use Visual Studio behind a firewall or proxy server](install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md)
* [Troubleshooting network errors in Visual Studio](troubleshooting-network-errors.md)
* [Visual Studio Administrator Guide](visual-studio-administrator-guide.md)
* [Install Visual Studio 2017](install-visual-studio.md)
