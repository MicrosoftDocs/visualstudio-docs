---
title: Install and use behind a firewall or proxy server
description: Review the domain URLs, ports, and protocols that you might want to add to an allowlist or open if your organization uses a firewall or a proxy server.
ms.date: 12/06/2024
ms.topic: conceptual
helpviewer_keywords:
- network installation, Visual Studio
- administrator guide, Visual Studio
- installing Visual Studio, administrator guide
- list of domains, locations, URLs
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: installation
#customer intent: As a developer using Visual Studio behind my organization's firewall or proxy server, I want to know which domains to add to my allowlist.
---
# Install and use Visual Studio and Azure Services behind a firewall or proxy server

If you or your organization uses security measures such as a firewall or proxy server, there are domain URLs that you might want to add to an *allowlist*. To you have the best experience when you install and use Visual Studio and Azure Services, you might want to open certain ports and protocols.

* [Install Visual Studio](#install-visual-studio): These tables include the domain URLs to add to an allowlist so that you have access to all the components and workloads that you want.

* [Use Visual Studio and Azure Services](#use-visual-studio-and-azure-services): This table includes the domain URLs to add to an allowlist and the ports and protocols to open so that you have access to all the features and services that you want.

## Install Visual Studio

### URLs to add to an allowlist

The Visual Studio Installer downloads files from various domains and their download servers. You might want to add these domain URLs to an allowlist as trusted in the UI or in your deployment scripts.

#### Microsoft domains

| Domain                                | Purpose                                     |
|---------------------------------------|---------------------------------------------|
| go.microsoft.com                      | Setup URL resolution                        |
| aka.ms                                | Setup URL resolution                        |
| download.visualstudio.microsoft.com   | Setup packages download location            |
| download.microsoft.com                | Setup packages download location            |
| download.visualstudio.com             | Setup packages download location            |
| marketplace.visualstudio.com          | Visual Studio Extensions download location  |
| \*.gallerycdn.vsassets.io             | Visual Studio Extensions download location  |
| visualstudio.microsoft.com            | Documentation location                      |
| learn.microsoft.com                   | Documentation location                      |
| msdn.microsoft.com                    | Documentation location                      |
| www\.microsoft.com                    | Documentation location                      |
| \*.windows.net                        | Sign-in location                            |
| \*.microsoftonline.com                | Sign-in location                            |
| \*.live.com                           | Sign-in location                            |
| github-releases.githubusercontent.com | Linux Development                           |
| objects.githubusercontent.com         | Windows build tools                         |
| github.com                            | Git for Windows & Windows Build Tools       |
| az837173.vo.msecnd.net                | Development with Azure Storage              |

#### Non-Microsoft domains

| Domain                            | Installs these workloads                                                                                                                    |
|-----------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------|
| archive.apache.org                | Mobile development with JavaScript (Cordova)                                                                                                |
| cocos2d-x.org                     | Game development with C++ (Cocos)                                                                                                           |
| download.epicgames.com            | Game development with C++ (Unreal Engine)                                                                                                   |
| launcher-public-service-prod06.ol.epicgames.com | Game development with C++ (Unreal Engine)                                                                                     |
| download.oracle.com               | Mobile development with JavaScript (Java SDK) <br /><br />Mobile Development with .NET (Java SDK)                                           |
| public-cdn.cloud.unity3d.com      | Game development with Unity (Unity)                                                                                                         |
| download.unity3d.com              | Game development with Unity (Unity)                                                                                                         |
| netstorage.unity3d.com            | Game development with Unity (Unity)                                                                                                         |
| dl.google.com                     | Mobile development with JavaScript (Android SDK and NDK, Emulator) <br /><br />Mobile Development with .NET (Android SDK and NDK, Emulator) |
| ib-downloads-official.s3.amazonaws.com | Game development with C++ (IncrediBuild)                                                                                               |
| www\.incredibuild.com             | Game development with C++ (IncrediBuild)                                                                                                    |
| www\.python.org                   | Python development (Python) <br /><br />Data science and analytical applications (Python)                                                   |
| developerservices2.apple.com      | .NET for iOS provisioning                                                                                                                    |
| developer.apple.com               | .NET for iOS provisioning                                                                                                                    |
| appstoreconnect.apple.com         | .NET for iOS provisioning                                                                                                                    |
| idmsa.apple.com                   | .NET for iOS provisioning                                                                                                                    |
| akamaized.net                     | Content Delivery Network (Akamai Technologies)                                                                                              |
| developer.arm.com                 | ARM Development                                                                                                                             |

## Use Visual Studio and Azure Services

### URLs to add to an allowlist and ports and protocols to open

When you use Visual Studio or Azure Services behind a firewall or proxy server, you might want to allow the following URLs and open the associated ports and protocols.

| Service or scenario    | DNS endpoint   | Protocol/Port  | Description |
|-----------------------|---------------|---------------|------------|
| URL<br>resolution  | go.microsoft.com<br><br>aka.ms | <br/>  | Used to shorten URLs, which then resolve into longer URLs  |
| Sign In | &#42;.msftauth.net<br><br>&#42;.live.com<br><br>visualstudio.microsoft.com<br><br>app.vsspsext.visualstudio.com<br><br>app.vssps.visualstudio.com<br><br>api.vstsusers.visualstudio.com<br><br>go.microsoft.com<br><br>graph.windows.net<br><br>graph.microsoft.com<br><br>login.microsoftonline.com<br><br>management.core.windows.net<br><br>management.azure.com<br><br>api.subscriptions.visualstudio.microsoft.com | 443 | Sign in or add account  for work or school and personal accounts |
| Start Page         | vsstartpage.blob.core.windows.net | 443  | Used to display Developer News shown on the start page (Visual Studio 2017 only) |
| Start Page | vsstartpagenewsfeed.azureedge.net | 443  | Used to display Developer News shown on the start page (Visual Studio 2019 onward) |
| Targeted<br> Notification <br>Service  | targetednotifications-tm.trafficmanager.net <br><br>www.research.net | 443<br><br>443  | Used to filter a global list of notifications to a list that is applicable only to specific types of machines/usage scenarios |
| Extension <br>update check  | marketplace.visualstudio.com<br><br>&#42;.windows.net <br>&#42;.microsoftonline.com <br>&#42;.live.com  | 443 | Used to provide notifications when an installed extension has an update available <br><br> Used as a sign-in location |
| AI Project <br>Integration | az861674.vo.msecnd.net  | 443<br>  | Used to configure new projects to send usage data to your registered Application Insights account |
| Code Lens  | codelensprodscus1su0.app.<br>codelens.visualstudio.com  | 443 | Used to provide information in the editor, including when a file was last updated, the timeline of changes, the work items that changes are associated with, and the authors |
| Experimental <br>feature enabling | visualstudio-devdiv-c2s.msedge.net  | 80  | Used to activate experimental new features or feature changes |
| Identity "badge" <br>(user name and avatar)<br>and <br>Roaming settings  | app.vssps.visualstudio.com <br><br>app.vsspsext.visualstudio.com<br><br>app.vssps.visualstudio.com<br><br> ns-sb2-prod-ch1-002.cloudapp.net <br><br>az700632.vo.msecnd.net<br><br>api.vstsusers.visualstudio.com/profiles/*  | 443 | Used to display the user's name and avatar in the IDE <br><br> Used to make sure that setting changes roam from one machine to another |
| Remote Settings | az700632.vo.msecnd.net  | 443 | Used to turn off extensions that are known to cause problems in Visual Studio |
| Windows Tools | developer.microsoft.com <br><br>dev.windows.com  <br><br>appdev.microsoft.com | https/443  | Used for Windows app store scenarios  |
| JSON Schema <br>Discovery <br><br>JSON Schema <br>Definition<br><br>JSON Schema <br>Support for <br>Azure Resources  | json.schemastore.org <br>schemastoreorg.azurewebsites.net<br><br>json-schema.org<br><br>schema.management.azure.com  | http/80<br>https/443<br><br>http/80<br><br>https/443  | Used to discover and download JSON schemas that the user might use when editing JSON documents <br><br>Used to obtain the meta-validation schema for JSON<br><br>Used to obtain the current schema for Azure Resource Manager deployment templates  |
| Npm package <br>discovery  | Skimdb.npmjs.com <br><br>Registry.npmjs.org <br><br>Api.npms.io  | https/443<br><br>http/80 &<br> https/443<br>https/443  | Required for searching for npm packages, and used for client-side script package installation in web projects |
| Bower package<br> icons<br><br>Bower package <br>search | Bower.io <br><br>bowercache.azurewebsites.net <br>go.microsoft.com <br>Registry.bower.io | http/80<br><br>https/443<br>http/80<br>https/443  | Provides the default bower package icon  <br><br>Enables you to search for Bower packages  |
| NuGet<br><br>NuGet package<br> discovery  | api.nuget.org <br>www.nuget.org <br>nuget.org <br>azuresearch-usnc.nuget.org <br>azuresearch-ussc.nuget.org <br>licenses.nuget.org <br>nuget.cdn.azure.cn <br>azuresearch-ea.nuget.org <br>azuresearch-sea.nuget.org <br><br>crl3.digicert.com <br>crl4.digicert.com <br>ocsp.digicert.com <br>cacerts.digicert.com  | https/443<br><br>http/80 &<br>https/443<br>  | Used to verify signed NuGet packages.<br><br>Required for searching for NuGet packages and versions  |
| GitHub repository information  | api.github.com  | https/443  | Required for getting additional information about bower packages  |
| Web Linters | Eslint.org<br><br>www.Bing.com <br><br>www.coffeelint.org  | http/80    |
| Cookiecutter<br>Explorer template<br>discovery <br><br>Cookiecutter <br>Explorer project<br> creation  | api.github.com <br>raw.githubusercontent.com <br>go.microsoft.com<br><br>pypi.org <br> pypi.python.org   | https/443<br>  | Used to discover online templates from our recommended feed and from GitHub repositories <br><br>Used to create a project from a cookiecutter template that requires a one-time on-demand installation of a cookiecutter Python package from the Python package index (PyPI)  |
| Python package <br>discovery<br><br>Python package <br>management<br><br>New <br>Python <br> project <br>templates  | pypi.org<br> <br>pypi.python.org <br>bootstrap.pypa.io<br><br>go.microsoft.com   | https/443   | Enables you to search for pip packages<br><br>Used to install pip automatically if it's missing <br><br>Used to resolve the following new Python project templates to cookiecutter template URLs:<br> - Classifier Project<br>- Clustering Project <br> - Regression Project <br> - PyGame using PyKinect <br> - Pyvot Project   |
| Office web <br>add-in <br> Manifest <br>Verification <br>Service | verificationservice.osi.office.net    | https/443    | Used to validate manifests for Office web add-ins   |
| SharePoint and <br>Office Add-ins   | sharepoint.com<br> microsoft.com/microsoft-365<br> microsoftonline.com <br> outlook.com  | https/443    | Used to publish and test SharePoint and Office Add-ins to SharePoint Online and Microsoft 365  |
| Workflow Manager <br>Test Service<br> Host   |  <br/>  | http/12292   | A firewall rule that is created automatically for testing SharePoint add-ins with workflows   |
| Automatically collected <br>reliability statistics <br>and other <br>Customer Experience <br>Improvement Programs (CEIP)<br> for Azure SDK and <br>for SQL Tools <br><br> | vortex.data.microsoft.com<br> <br>dc.services.visualstudio.com  | https/443    | Used to send reliability statistics (crash/unresponsive data) from the user to Microsoft. Actual crash/unresponsive dumps are still uploaded if Windows Error Reporting is enabled; only statistical information is suppressed; <br>Used to reveal usage patterns for the Azure Tools SDK extension to Visual Studio, and for usage patterns for the SQL tooling to Visual Studio    |
| Visual Studio <br> Customer Experience <br>Improvement Program (CEIP) <br><br>PerfWatson.exe      | vortex.data.microsoft.com<br>dc.services.visualstudio.com<br>visualstudio-devdiv-c2s.msedge.net<br>az667904.vo.msecnd.net <br>scus-breeziest-in.cloudapp.net<br>mobile.events.data.microsoft.com<br>events.data.microsoft.com<br>    | https/443     | Used to collect usage patterns and error logs <br><br>Used to track UI freeze issues    |
| Creation and<br>Management of <br>Azure resources   | management.azure.com <br>management.core.windows.net    | https/443   | Used for creating Azure Websites or other resources to support the publishing of web applications, Azure Functions, or WebJobs    |
| Updated web publish tooling <br>checks and extension <br>recommendations   | marketplace.visualstudio.com     | https/443   | Used for checking for the availability of updated publish tooling. If disabled, a potential recommended extension for web publishing might not be shown    |
| Updated Azure Resource <br>Creation Endpoint Information   | \*.blob.core.windows.net   | https/443    | Used to update the endpoints used for the creation of Azure Resources for certain Azure Services. If disabled, the last downloaded or built in endpoint locations are used instead    |
| Remote debugging and <br>Remote profiling of <br>Azure Websites    | &#42;.cloudapp.net <br> &#42;.azurewebsites.net    | 4022    | Used for attaching the remote debugger to Azure Websites. If disabled, attaching the remote debugger to Azure Websites doesn't work   |
| Active Directory <br>Graph    | graph.windows.net    | https/443    | Used to provision  new Microsoft Entra applications. Also used by the Microsoft 365 MSGraph- connected service provider    |
| Azure Functions <br>CLI Update <br>Check   | cdn.functions.azure.com<br><br>functionscdn.azureedge.net     | https/443      | Used for checking for updated versions of the Azure Functions CLI. If disabled, a cached copy (or the copy carried by the Azure Functions component) of the CLI is used instead.   |
| Cordova     | npmjs.org<br>gradle.org    | http/80 &<br/>https/443      | HTTP is used for Gradle downloads during build. HTTPS is used to include Cordova plug-ins in projects.  |
| Cloud Explorer    | 1. &#60;clusterendpoint&#62; <br>Service Fabric <br>2. &#60;management endpoint&#62;<br>General Cloud Exp <br>3. &#60;graph endpoint&#62;<br>General Cloud Exp<br>4. &#60;storage account endpoint&#62;<br>Storage Nodes <br>5. &#60;Azure portal URLs&#62;<br>General Cloud Exp <br>6. &#60;key vault endpoints&#62; <br>Azure Resource Manager VM Nodes<br>7. &#60;PublicIPAddressOfCluster&#62;<br>Service Fabric Remote debugging and ETW Traces | 1.https/19080<br>2. https/443<br>3. https/443<br>4. https/443<br>5. https/443<br>6. https/443<br>7.tcp/dynamic                                                                               | 1. Example: test12.eastus.cloudapp.com<br>2. Retrieves subscriptions and retrieves/manages Azure resources<br>3. Retrieves Azure Stack subscriptions<br>4. Manages Storage resources (example: mystorageaccount.blob.core.windows.net)<br>5. "Open in Portal" context menu option (opens a resource in the Azure portal)<br>6. Creates and uses key vaults for VM debugging (Example: myvault.vault.azure.net) <br><br>7. Dynamically allocates block of ports based on number of nodes in the cluster and the available ports. <br><br>A port block tries to get three times the number of nodes with minimum of 10 ports.<br><br>For Streaming traces, an attempt is made to get the port block from 810. If any of that port block is already used, then an attempt is made to get the next block, and so on. (If the load balancer is empty, then ports from 810 are most likely used) <br><br>Similarly for debugging, four sets of the ports blocks are reserved: <br>- connectorPort: 30398, <br>- forwarderPort: 31398, <br>- forwarderPortx86: 31399,<br>- fileUploadPort: 32398<br> |
| Cloud Services     | 1. RDP<br><br>2. core.windows.net <br><br>3. management.azure.com<br> management.core.windows.net <br><br>4. &#42;.blob.core.windows.net <br>&#42;.queue.core.windows.net<br>&#42;.table.core.windows.net <br><br>5. portal.azure.com <br><br>6. &#60;user's cloud service&#62;.cloudapp.net <br> &#60;user's VM&#62;.&#60;region&#62;.azure.com                                                                                                    | 1. rdp/3389 <br><br> 2. https/443 <br><br> 3. https/443 <br><br> 4. https/443 <br><br> 5. https/443 <br><br>6. tcp <br>a) 30398 <br>b) 30400 <br>c) 31398 <br>d) 31400 <br>e) 32398 <br>f) 32400 | 1. Remote Desktop to Cloud Services VM <br><br> 2. Storage account component of the private diagnostics configuration <br><br> 3. Azure portal <br><br> 4. Server Explorer - Azure Storage  &#42;  is customer named storage account  <br><br> 5. Links to open the portal &#47; Download the subscription certificate &#47; Publish settings file <br><br>6. port:<br> a)  Connector local port for remote debug for cloud service and VM<br> b)  Connector public port for remote debug for cloud service and VM <br> c)  Forwarder local port for remote debug for cloud service and VM <br> d) Forwarder public port for remote debug for cloud service and VM  <br> e) File uploader local port for remote debug for cloud service and VM <br> f) File uploader public port for remote debug for cloud service and VM    |
| Service Fabric   | 1. <br>learn.microsoft.com<br>aka.ms <br>go.microsoft.com <br><br>2. <br>vssftools.blob.core.windows.net <br>Vault.azure.com <br>Portal.azure.com <br><br> 3. &#42; vault.azure.net<br><br> 4. <br>app.vsaex.visualstudio.com<br>&#42; .vsspsext.visualstudio.com<br>clouds.vsrm.visualstudio.com <br>clouds.visualstudio.com<br>app.vssps.visualstudio.com <br>&#42; .visualstudio.com    | https/443      | 1. Documentation <br><br> 2. Create Cluster feature <br><br>3. The &#42; is the Azure key vault name (Example:- test11220180112110108.vault.azure.net  <br><br>  4. The &#42; is dynamic (Example: vsspsextprodch1su1.vsspsext.visualstudio.com)   |
| Snapshot <br>Debugger      | 1. go.microsoft.com <br>2. management.azure.com <br> 3. &#42;.azurewebsites.net <br> 4. &#42;.scm.azurewebsites.net<br>5. api.nuget.org/v3/index.json <br>6. Remote Service/Servers IP address/FQDN    | 1. https/443 <br>2. https/443  <br>3. http/80 <br>4. https/443 <br>5. https/443 <br>6. Concord/<br> 4022 (Visual Studio version dependent)                                                       | 1. Query .json file for app service SKU size <br>2. Various Azure RM calls <br>3. Site warmup call via  <br>4. Customer's targeted App Service Kudu endpoint <br>5. Query Site Extension version published in nuget.org <br>6. [Remote debugging](../debugger/remote-debugging.md)    |
| Azure Stream Analytics <br><br>HDInsight     | Management.azure.com       | https/443     | Used to view, submit, run, and manage ASA jobs <br><br> Used to browse HDI clusters, and to submit, diagnose, and debug HDI jobs  |
| Azure Data Lake      | &#42;.azuredatalakestore.net <br>&#42;.azuredatalakeanalytics.net    | https/443    | Used to compile, submit, view, diagnose, and debug  jobs. Used to browse ADLS files. Used to upload and download files.  |
| Packaging Service    | [account].visualstudio.com <br/> [account].\*.visualstudio.com <br/> \*.blob.core.windows.net <br/> registry.npmjs.org </br> nodejs.org <br/> dist.nuget.org <br/> nuget.org   | https/443     | The \*.npmjs.org, \*.nuget.org, and \*.nodejs.org are only required for certain build task scenarios (for example: NuGet Tool Installer, Node Tool Installer) or if you intend to use public upstream with your Feeds. The other three domains are required for core functionality of the Packaging service.   |
| Azure DevOps Services    | \*.vsassets.io <br/> static2.sharepointonline.com <br/> dev.azure.com    |  <br/> | Used to connect with Azure DevOps Services     |
| Azure Service Bus     | \*.servicebus.windows.net  | ampq/5671 and 5672, </br> sbmp/9350-9354, </br> http/80, </br> https/443   | Used to create queues, topics, and subscriptions.</br> Also used to send/receive messages to/from Service Bus queues and topics.   |
| Azure Cosmos DB    | \*.documents.azure.com    | https/443   | Used to call core document database APIs     |
| Developer Community       | sendvsfeedback2.azurewebsites.net/api      | https/443     | Used to call Developer Community Feedback Tool APIs (my issues, search, vote, comment, submit, upload, resume)    |
| Intellicode   | \*.intellicode.vsengsaas.visualstudio.com     | https/443    | Used to call Intellicode APIs      |
| Live Share     | \*.liveshare.vsengsaas.visualstudio.com    | https/443       | Used to call Live Share APIs   |
| GitHub Codespaces     | \*.online.visualstudio.com    | https/443     | Used to call GitHub Codespaces APIs    |
| JavaScript Automatic Type Acquisition    | registry.npmjs.org     | https/443     | Used to install TypeScript type definitions to provide IntelliSense for popular JavaScript libraries   |
| Visual Studio Subscriptions Licensing Service    | 1. app.vssps.visualstudio.com/apis/<br/>Licensing/ClientRights <br><br> 2. api.subscriptions.visualstudio.microsoft.com/<br/>Me/Entitlements/IDEBenefits  | https/443     | Licensing for online activation   |
| Debugger    | 1. <br>vsdebugger.blob.core.windows.net <br>vsdebugger.azureedge.net <br><br>2. <br>download.visualstudio.com/\*/<br/>onecore.msvsmon.\*.zip<br><br> 3. referencesource.microsoft.com/symbols <br><br> 4. <br>symbols.nuget.org/download/symbols<br><br> 5. visualstudio.com<br><br>6. msdl.microsoft.com/download/symbols  | https/443    | 1. <br>Used for downloading debugger bits for .NET Core debugging on Unix / macOS over SSH <br><br>2. <br>Used for downloading debugger bits for remote Windows Docker container debugging<br><br> 3. Used for .NET Framework source stepping <br><br> 4. <br>(If user opts in) Used for downloading symbols published to nuget.org symbol server.<br><br> 5. (If user opts in) Used for downloading MS symbols and binaries, might also be needed for debugging managed code in dumps   |
| GitHub Codespaces     | \*.online.visualstudio.com    | https/443     | Used to call GitHub Codespaces APIs     |
| .NET for Android App Publishing     | \*.googleapis.com <br/> play.google.com <br/>accounts.google.com    | https/443     | Used to interact with Google Play Store service to publish/upload .NET for Android Applications directly from Visual Studio   |
| Visual Studio Search Service   | data-ai.microsoft.com/search   | https/443     | Used to provide AI-enabled Visual Studio Search Service in **Ctrl**+**Q** search box     |
| Azure Container Registry    | *.azurecr.io     | https/443      | Access container registries hosted on Azure, for configuration of CICD pipelines  |
| Visual Studio for Mac Updater  | software.xamarin.com   | https/443    | Used to get the list of available updates   |
| Visual Studio for Mac Error Reporting        | nw-umwatson.events.data.microsoft.com    | https/443       | Used to collect reliability reports for crashes, unresponsiveness, and delays   |

## Troubleshoot network-related errors

Sometimes, you might run in to network- or proxy-related errors when you install or use Visual Studio behind a firewall or a proxy server. For more information about solutions for such error messages, see [Troubleshooting network-related errors](troubleshooting-network-related-errors-in-visual-studio.md).

## Get support

Microsoft offers an [installation chat](https://visualstudio.microsoft.com/vs/support/#talktous) (English only) support option for installation-related issues.

Here are a few more support options:

* Report product issues to us by using the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
* Suggest a feature, track product issues, and find answers in the [Visual Studio Developer Community](https://aka.ms/feedback/suggest?space=8).
* Use your [GitHub](https://github.com/) account to talk to us and other Visual Studio developers in the [Visual Studio conversation in the Gitter community](https://gitter.im/Microsoft/VisualStudio).

## Related content

* [Connectivity requirements for Live Share](/visualstudio/liveshare/reference/connectivity/)
* [Create and maintain a network installation of Visual Studio](create-a-network-installation-of-visual-studio.md)
* [Troubleshoot network-related errors in Visual Studio](troubleshooting-network-related-errors-in-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Configure network settings for Copilot in Visual Studio](https://docs.github.com/en/copilot/configuring-github-copilot/configuring-network-settings-for-github-copilot?tool=visualstudio#configuring-proxy-settings-for-github-copilot)
