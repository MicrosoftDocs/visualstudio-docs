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
| RDP | *.cloudapp.net <br>Custom domain <br> (This is the default for <br>most RDP listeners) | RDP | 3389 | Desktop connection to VMs |
| Publish from VS  | *.blob.core.windows.net | http/s | | Blob domain for Blob domain for package upload for access of management API |
| Upload into Storage | *.blob.core.windows.net | | | Push data into Azure Storage |
| Web deploy | *.cloudapp.net | http/s | | |
| SQL Management | *.database.windows.net | | | |
| Service Bus Relay HTTP Mode  | *.servicebus.windows.net  | | 443 |  Listeners on Service Bus Relay over HTTP (requires 443 for Access Control)  |
| Service Bus Relay TCP Mode  | *.servicebus.windows.net  | | | |
| Service Bus Publish Subscribe | *.servicebus.windows.net  | https | | Service Bus Queue and Topic clients over TCP (in CTP) |
| Access Control  | *.accesscontrol.windows.net   | https | | Token acquisition and management for Access Control |
| AppFabric Cache  | *.cache.windows.net  | | | |
| Creation/Management of Azure resources | management.azure.com <br>management.core.windows.net   | https | 443 | Used for creating Azure Websites or other resources to support the publishing of web applications, Azure Functions, or WebJobs |
| Updated web publish tooling checks and extension recommendations  | marketplace.visualstudio.com <br/>(via FWLink 859659) <br> visualstudiogallery.msdn.microsoft.com <br/>(via FWLinks 320773, 615538) | https | 443 | Used for checking for the availability of updated publish tooling. If disabled, a potential recommended extension for web publishing may not be shown |
| Updated Azure Resource Creation Endpoint Information  | *.blob.core.windows.net <br/>(via FWLink 391739) | https | 443 | Used to update the endpoints used for the creation of Azure Resources for certain Azure Services. If disabled, the last downloaded or built in endpoint locations are used instead |
| Updated Azure Resource Creation UI Settings | www.microsoft.com <br/>(via FWLinks 722336, 855893, <br>836755, 836756) | http | 80 | Used to update the user interface settings for the creation of Azure Resource as seen when electing to create new resources via the App Service node in Server Explorer, Cloud Explorer, or Web Publish. If disabled, the last downloaded or built-in settings are used instead |
| Web Documentation Links | Docs.Microsoft.com <br/>(via FWLinks 331311, 331309, <br>865438, 832029, 839002, 834448, <br>848461, 859495, 517593, 313770, <br>274910, 847273, 847274, 847272, <br>299423, 299422, 299424, 299425, <br>204140, 204658, 313770, 248973, <br>301862, 301864, 313242, 316888, <br>320754, 320755, 320757, 320758, <br>320759, 320760, 320763, 320764, <br>320765, 320766, 320767, 320770, <br>320771, 320779, 320780, 320956, <br>320957, 320959, 320960, 320961, <br>320962, 320963, 320964, 403804, <br>615519, 615520, 615523, 615524, <br>615528, 615529, 615530, 615531, <br>615532, 615535, 615541, 615542, <br>615543, 615545) <br><br> msdn.microsoft.com <br/>(via FWLinks 208121, 246068, <br>179181, 301874, 301879, 301880) <br><br> blogs.msdn.microsoft.com <br/>(via FWLinks 859831, 859830, <br>849106, 852275, 125889, 208121, <br>615797, 226949, 301863, 317594, <br>320756, 320761, 320762, 320777, <br>320958, 615526, 615527) <br><br> www.microsoft.com <br/>(via FWLinks 256245, 245956,<br> 241526, 391939, 248304, 248305, <br>248306, 248307, 248308) <br><br> Github.com <br/>(via FWLinks 320976, 852740, <br>865095) <br><br> www.windowsazure.com <br/>(via FWLink 330318, redirects to docs.microsoft.com) <br><br>Azure.microsoft.com <br/>(via FWLinks 287054, 330099, 391940) <br><br>www.asp.net <br/>(via FWLink  245139, 248974, <br>273732, 301865, 301867, 301870, <br>301872, 320769, 320772, 320778, <br>320955, 320965, 320966, 615534, <br>615537, 615544, 615546)<br><br>docs.docker.com <br/>(via FWLink 834551) <br><br>vishaljoshi.blogspot.com <br/>(via FWLink 124618) <br><br>www.iis.net <br/>(via FWLinks 109366, 109365) <br><br>Blog.iis.net <br/>(via FWLink 178035) <br><br>Technet.microsoft.com <br/>(via FWLinks 178589, 178036) <br><br>support.microsoft.com <br/>(via FWLinks 178587, 178034) <br><br>privacy.microsoft.com <br/>(via FWLink 391941) <br><br>hosting.asp.net <br/>(via FWLinks 245143, 615536) <br><br>www.visualstudio.com <br/>(via FWLinks 320768, 615533) | https <br> http | 443 <br> 80 | Presented as links the user may click to learn more about certain web tooling features. If disabled, the links will not present the content |
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
* [Troubleshooting proxy errors in Visual Studio](troubleshooting-proxy-errors.md)
* [Visual Studio Administrator Guide](visual-studio-administrator-guide.md)
* [Install Visual Studio 2017](install-visual-studio.md)
