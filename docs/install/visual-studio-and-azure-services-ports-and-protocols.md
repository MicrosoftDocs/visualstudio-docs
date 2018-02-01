---
title: "Ports and protocols for Visual Studio and for Azure Services | Microsoft Docs"
description: ""
ms.custom: ""
ms.date: "02/05/2018"
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

# Ports and protocols for Visual Studio and Azure Services
To make sure that you have access to everything you need when you use Visual Studio or Azure Services behind a firewall or proxy server, here are lists of the URLs you should whitelist and the ports and protocols that you should open.

  > [!NOTE]
  > For each list, the port for the HTTPS protocol is 443, and the port for the HTTP protocol is 80.

## URLs to whitelist and ports and protocols to open for Visual Studio
| Service or scenario | DNS endpoint | Protocol | Port | Description |
| --- | --- | --- | --- | --- |
| URL<br>resolution | go.microsoft.com<br><br>aka.ms | | |Used to shorten URLs, which then resolve into longer URLs
| Customer Experience <br />Improvement Program (CEIP) | vortex.data.microsoft.com <br><br/>dc.services.visualstudio.com <br><br>az667904.vo.msecnd.net <br><br>visualstudio-devdiv-c2s.msedge.net <br />  |  |  | Used to collect anonymous usage patterns and error logs |
| AI Project <br />Integration | go.microsoft.com <br /><br />az861674.vo.msecnd.net  | | | Used to configure new projects to send usage data to your registered Application Insights account |
| PerfWatson.exe | az667904.vo.msecnd.net <br><br>dc.services.visualstudio.com <br><br>scus-breeziest-in.cloudapp.net <br><br>vortex.data.microsoft.com | | | Used to track UI freeze issues |
| Code Lens | codelensprodscus1su0.app.codelens.visualstudio.com | | | Used to provide information in the editor about when a file was last updated, the timeline of changes, the work items that changes are associated with, the authors, and more|
|Experimental <br>feature enabling  | visualstudio-devdiv-c2s.msedge.net | | | Used to activate experimental new features or feature changes |
| Identity “badge” <br>(user name and avatar) | app.vssps.visualstudio.com <br><br>app.vsspsext.visualstudio.com | | | Used to display the user's name and avatar in the IDE  |
| Roaming Settings | app.vssps.visualstudio.com | | | Used to make sure that setting changes roam from one machine to another |
| Push Notifications <br> for Roaming Settings | ns-sb2-prod-ch1-002.cloudapp.net | | | Used to make sure that settings won't roam with significant delay, or not at all, when one is working on multiple machines |
| Automatically collected <br>reliability statistics <br>(“No opt stream”) | vortex.data.microsoft.com<br> <br>dc.services.visualstudio.com | | | Used to send reliability statistics (crash/hang data) from the user to Microsoft. Actual crash/hang dumps will still be uploaded if Windows Error Reporting is enabled; only statistical information will be suppressed |
| Azure SDK <br>Customer Experience <br>Improvement Program (CEIP)  | dc.services.visualstudio.com | | | Used to reveal anonymous usage patterns for the Azure Tools SDK extension to Visual Studio |
| SQL Tools <br> Customer Experience <br>Improvement Program (CEIP)  | dc.services.visualstudio.com | | | Used to reveal anonymous usage patterns for the SQL tooling to Visual Studio |
| Dynamic Configuration <br>Service for CEIP  | az667904.vo.msecnd.net | | | Used to disable specific CEIP data points that are no longer helpful for improving specific user experiences |
| Remote Settings | az700632.vo.msecnd.net | | | Used to turn off extensions that are known to cause problems in Visual Studio   |
| Start Page | go.microsoft.com <br><br>vsstartpage.blob.core.windows.net | | | Used to display Developer News shown on the start page in Visual Studio |
| Targeted<br> Notification <br>Service | targetednotifications.azurewebsites.net <br><br>www.research.net | | | Used to filter a global list of notifications to a list that is applicable only to specific types of machines/usage scenarios |
| Windows Tools | developer.microsoft.com <br><br>dev.windows.com  <br><br>appdev.microsoft.com  | | | Used for Windows app store scenarios  |
| JSON Schema <br>Discovery | json.schemastore.org <br><br>schemastoreorg.azurewebsites.net| | | Used to discover and download JSON schemas that the user might use when editing JSON documents |
| JSON Schema <br>Definition |  json-schema.org  | | | Used to obtain the meta-validation schema for JSON |
|JSON Schema <br>Support for <br>Azure Resources  | schema.management.azure.com  | | | Used to obtain the current schema for Azure Resource Manager deployment templates |
| NPM package <br>discovery  |Skimdb.npmjs.com <br><br>Registry.npmjs.org <br><br>Api.npms.io  | | | Required for searching for NPM packages, and used for client-side script package installation in web projects |
|Bower package<br> icons  |Bower.io  | | |Provides the default bower package icon  |
| Bower package search |bowercache.azurewebsites.net <br><br>go.microsoft.com <br><br>Registry.bower.io  | | |Provides the ability to search for Bower packages |
|NuGet package<br> discovery  |Api.nuget.org <br><br>www.nuget.org <br><br>Nuget.org  | | |Required for searching for NuGet packages and versions |
|GitHub repository information  |api.github.com  | | | Required for getting additional information about bower packages |
| Web Linters|Eslint.org<br><br>www.Bing.com <br><br>www.coffeelint.org  | | | |
| Python package discovery| pypi.org| | | Provides the ability to search for pip packages|
| Python package management | go.microsoft.com <br><br>pypi.python.org <br><br>bootstrap.pypa.io | | |Used to install pip automatically if it is missing |
|Python <bf>New Project <br>templates  | go.microsoft.com |
| Office web <br>add-in  <br><br> Manifest <br>Verification <br />Service | verificationservice.osi.office.net<br> <br>https:&#47;&#47;verificationservice.osi.office.net <br> /ova/addincheckingagent.svc/api<br>/addincheck?format=html |  |  | Used to validate manifests for Office web add-ins |
| SharePoint and <br>Office Add-ins | sharepoint.com |  |  | Used to publish and test SharePoint and Office Add-ins to SharePoint Online |
| Workflow Manager <br />Test Service<br> Host | |  | 12292 | A firewall rule that is created automatically for testing SharePoint Add-ins with workflows |

> [!NOTE]
> For each list, the port for the HTTPS protocol is 443, and the port for the HTTP protocol is 80.

## URLs to whitelist and ports and protocols to open for Azure Services

| Service or scenario | DNS endpoint | Protocol | Port | Description |
| --- | --- | --- | --- | --- |
| Creation and<br>Management of <br>Azure resources | management.azure.com <br>management.core.windows.net   |  |  | Used for creating Azure Websites or other resources to support the publishing of web applications, Azure Functions, or WebJobs |
| Updated web publish tooling <br />checks and extension <br />recommendations  | marketplace.visualstudio.com  <br> visualstudiogallery.msdn.microsoft.com  |  |  | Used for checking for the availability of updated publish tooling. If disabled, a potential recommended extension for web publishing may not be shown |
| Updated Azure Resource <br />Creation Endpoint Information  | *.blob.core.windows.net |  |  | Used to update the endpoints used for the creation of Azure Resources for certain Azure Services. If disabled, the last downloaded or built in endpoint locations are used instead |
| Updated Azure Resource <br />Creation UI Settings | www.microsoft.com |  |  | Used to update the user interface settings for the creation of Azure Resource as seen when electing to create new resources via the App Service node in Server Explorer, Cloud explorer, or Web Publish. If disabled, the last downloaded or built-in settings are used instead |
| Remote debugging and <br />Remote profiling of <br />Azure Websites | &#42;.cloudapp.net <br> &#42;.azurewebsites.net | | 4022 | Used for attaching the remote debugger to Azure Websites. If disabled, attaching the remote debugger to Azure Websites will not work |
| Active Directory <br>Graph | graph.windows.net |  |  | Used for provisioning new Azure Active Directory applications. If disabled, new web projects with organizational authentication selected won't be able to create or configure the required Azure Active Directory application |
| Azure Functions <br />CLI Update <br>Check | functionscdn.azureedge.net |  |  | Used for checking for updated versions of the Azure Functions CLI. If disabled, a cached copy (or the copy carried by the Azure Functions component) of the CLI will be used instead |
| Xamarin | | | | |
| Cordova | | | | |
| Node | | | | |
| Cloud explorer | 1. &#60;clusterendpoint&#62; <br>2. &#60;management endpoint&#62;<br>3. &#60;graph endpoint&#62;<br>4. &#60;storage account endpoint&#62;<br>5. &#60;Azure portal URLs&#62;<br>6. &#60;key vault endpoints&#62; <br>7. &#60;PublicIPAddressOfCluster&#62;|   <br>1. --<br>2. --<br>3. --<br>4. --<br>5. --<br>6. --<br>7: tcp| 1. 19080<br>2. -- <br>3. -- <br>4. -- <br>5. -- <br>6. -- <br>7. --   | 1. Example: test12.eastus.cloudapp.com<br>2. Retrieving of subscriptions and retrieving/management of Azure resources<br>3. Retrieving of Azure Stack subscriptions<br>4. Managing Storage resources (ex: mystorageaccount.blob.core.windows.net)<br>5. "Open in Portal" context menu option (opening a resource in the Azure portal)<br>6. Creating and using key vaults for VM debugging (Example: myvault.vault.azure.net) <br><br>7. Dynamically allocate block of ports based on number of nodes in the cluster and the available ports. <br><br>Port block: We will try to get 3 times the number of nodes with minimum of 10 ports.<br><br>  For Streaming traces we will try to get the port block from 810. If any of the port is already used, then we will try to get the next block and so on. So if the load balancer is fairly empty, then likely use ports from 810  <br><br> Similarly for debugging 4 sets of the ports blocks are reserved: <br><br>connectorPort: 30398, <br>forwarderPort: 31398, <br>forwarderPortx86: 31399,<br>fileUploadPort: 32398<br>|
| Cloud Services | 1. RDP<br><br>2. core.windows.net <br><br>3.  management.azure.com<br> management.core.windows.net <br><br>4. &#42;.blob.core.windows.net <br>&#42;.queue.core.windows.net<br>&#42;.table.core.windows.net <br><br>5. portal.azure.com <br><br>6. &#60;user's cloud service&#62;.cloudapp.net <br> &#60;user's VM&#62;.&#60;region&#62;.azure.com | 1. rdp <br><br> 2. -- <br><br> 3. -- <br><br> 4. -- <br><br> 5. -- <br><br>6. tcp | 1. 3389 <br><br> 2. -- <br><br> 3. -- <br><br>4. -- <br><br>5. -- <br><br> 6. a) 30398 <br> 6. b) 30400 <br> 6. c) 31398 <br> 6. d) 31400 <br> 6. e) 32398 <br> 6. f) 32400 | 1.  Remote Desktop to Cloud Services VM <br><br> 2.  Storage account component of the private diagnostics configuration <br><br> 3.  Azure management portal <br><br> 4. Server Explorer - Azure Storage  .&#42;  is customer named storage account  <br><br> 5.  Links to open the portal &#47; Download the subscription certificate &#47; Publish settings file <br><br>6. a)  Connector local port for remote debug for cloud service and VM<br> 6. b)  Connector public port for remote debug for cloud service and VM <br> 6. c)  Forwarder local port for remote debug for cloud service and VM <br> 6. d) Forwarder public port for remote debug for cloud service and VM  <br> 6. e) File uploader local port for remote debug for cloud service and VM <br> 6. f) File uploader public port for remote debug for cloud service and VM |
| Service Fabric | 1. <br>ocs.Microsoft.com<br>aka.ms <br>go.microsoft.com <br><br>2. <br>vssftools.blob.core.windows.net <br>Vault.azure.com <br>Portal.azure.com <br><br> 3. &#42; vault.azure.net<br><br> 4. <br>app.vsaex.visualstudio.com<br>&#42; .vsspsext.visualstudio.com<br>clouds.vsrm.visualstudio.com <br>clouds.visualstudio.com<br>app.vssps.visualstudio.com <br>&#42; .visualstudio.com |  |  | 1. Documentation <br><br> 2. Create Cluster feature <br><br>3. The &#42; is the azure key vault name (Example:- test11220180112110108.vault.azure.net  <br><br>  4. The &#42; is dynamic (Example: vsspsextprodch1su1.vsspsext.visualstudio.com |
| Azure SDK | | | | |
| Snapshot <br>Debugger | 1. go.microsoft.com <br>2. management.azure.com <br> 3. &#42;azurewebsites.net <br> 4. &#42;scm.azurewebsites.net<br>5. api.nuget.org/v3/index.json <br>6. msvsmon | 1.  <br>2.  <br>3.  <br>4.  <br>5. <br>6. Concord <br> | 1. <br> 2. <br>3.  <br>4. <br> 5. <br> 6. 4022 (Visual Studio version dependent) | 1. Query .json file for app service SKU size <br>2. Various Azure RM calls <br>3. Site warmup call via  <br>4. Customer's targeted App Service Kudu endpoint <br>5. Query Site Extension version published in nuget.org <br>6. Remote debugging channel |


<br/>

## Get support
If your Visual Studio installation fails, see the [Troubleshooting Visual Studio 2017 installation and upgrade issues](troubleshooting-installation-issues.md) page. If none of the installation troubleshooting steps help, you can contact us by live chat for installation assistance (English only). For details, see the [Visual Studio support page](https://www.visualstudio.com/vs/support/#talktous).

Here are a few more support options:
* You can report product issues to us via the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio-2017.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
* You can share a product suggestion with us on [UserVoice](https://visualstudio.uservoice.com/forums/121579).
* You can track product issues in the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/), and ask questions and find answers.
* You can also engage with us and other Visual Studio developers through our [Visual Studio conversation in the Gitter community](https://gitter.im/Microsoft/VisualStudio).  (This option requires a [GitHub](https://github.com/) account.)

## See also
* [Install and use Visual Studio behind a firewall or proxy server](install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md)
* [Troubleshooting network errors in Visual Studio](troubleshooting-network-errors.md)
* [Visual Studio Administrator Guide](visual-studio-administrator-guide.md)
* [Install Visual Studio 2017](install-visual-studio.md)
