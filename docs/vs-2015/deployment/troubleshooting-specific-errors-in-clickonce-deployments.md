---
title: "Troubleshooting Specific Errors in ClickOnce Deployments | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: troubleshooting
f1_keywords: 
  - "Microsoft.VisualStudio.Publish.ClickOnceProvider.ErrorPrompt.UncRequired"
  - "Microsoft.VisualStudio.Publish.ClickOnceProvider.ErrorPrompt.NoInstallUrl"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "deploying applications, ClickOnce"
  - "troubleshooting ClickOnce deployments"
  - "ClickOnce deployment, troubleshooting"
ms.assetid: 22dfe8f1-8271-4708-9c25-6bbb13920ac8
caps.latest.revision: 15
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Troubleshooting Specific Errors in ClickOnce Deployments
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This topic lists the following common errors that can occur when you deploy a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application, and provides steps to resolve each problem.  
  
## General Errors  
  
#### When you try to locate an .application file, nothing occurs, or XML renders in Internet Explorer, or you receive a Run or Save As dialog box  
 This error is likely caused by content types (also known as MIME types) not being registered correctly on the server or client.  
  
 First, make sure that the server is configured to associate the .application extension with content type "application/x-ms-application".  
  
 If the server is configured correctly, ensure that the [!INCLUDE[dnprdnlong](../includes/dnprdnlong-md.md)] is installed on your computer. If the [!INCLUDE[dnprdnlong](../includes/dnprdnlong-md.md)] is installed, and you are still seeing this problem, try uninstalling and reinstalling the [!INCLUDE[dnprdnlong](../includes/dnprdnlong-md.md)] to re-register the content type on the client.  
  
#### Error message says, "Unable to retrieve application. Files missing in deployment" or "Application download has been interrupted, check for network errors and try again later"  
 This message indicates that one or more files being referenced by the [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] manifests cannot be downloaded. The easiest way to debug this error is to try to download the URL that [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] says it cannot download. Here are some possible causes:  
  
- If the log file says "(403) Forbidden" or "(404) Not found," verify that the Web server is configured so that it does not block download of this file. For more information, see [Server and Client Configuration Issues in ClickOnce Deployments](../deployment/server-and-client-configuration-issues-in-clickonce-deployments.md).  
  
- If the .config file is being blocked by the server, see the section "Download error when you try to install a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application that has a .config file" later in this topic.  
  
- Determine whether this occurred because the `deploymentProvider` URL in the deployment manifest is pointing to a different location than the URL used for activation.  
  
- Ensure that all files are present on the server; the [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] log should tell you which file was not found.  
  
- See whether there are network connectivity issues; you can receive this message if your client computer went offline during the download.  
  
#### Download error when you try to install a ClickOnce application that has a .config file  
 By default, a Visual Basic Windows-based application includes an App.config file. There will be a problem when a user tries to install from a Web server that uses Windows Server 2003, because that operating system blocks the installation of .config files for security reasons. To enable the .config file to be installed, click **Use ".deploy" file extension** in the **Publish Options** dialog box.  
  
 You also must set the content types (also known as MIME types) appropriately for .application, .manifest, and .deploy files. For more information, see your Web server documentation.  
  
 For more information, see "Windows Server 2003: Locked-Down Content Types" in [Server and Client Configuration Issues in ClickOnce Deployments](../deployment/server-and-client-configuration-issues-in-clickonce-deployments.md).  
  
#### Error message: "Application is improperly formatted;" Log file contains "XML signature is invalid"  
 Ensure that you updated the manifest file and signed it again. Republish your application by using [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] or use Mage to sign the application again.  
  
#### You updated your application on the server, but the client does not download the update  
 This problem might be solved by completing one of the following tasks:  
  
- Examine the `deploymentProvider` URL in the deployment manifest. Ensure that you are updating the bits in the same location that `deploymentProvider` points to.  
  
- Verify the update interval in the deployment manifest. If this interval is set to a periodic interval, such as one time every six hours, [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] will not scan for an update until this interval has passed. You can change the manifest to scan for an update every time that the application starts. Changing the update interval is a convenient option during development time to verify updates are being installed, but it slows down application activation.  
  
- Try starting the application again on the Start menu. [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] may have detected the update in the background, but will prompt you to install the bits on the next activation.  
  
#### During update you receive an error that has the following log entry: "The reference in the deployment does not match the identity defined in the application manifest"  
 This error may occur because you have manually edited the deployment and application manifests, and have caused the description of the identity of an assembly in one manifest to become out of sync with the other. The identity of an assembly consists of its name, version, culture, and public key token. Examine the identity descriptions in your manifests, and correct any differences.  
  
#### First time activation from local disk or CD-ROM succeeds, but subsequent activation from Start Menu does not succeed  
 [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] uses the Deployment Provider URL to receive updates for the application. Verify that the location that the URL is pointing to is correct.  
  
#### Error: "Cannot start the application"  
 This error message usually indicates that there is a problem installing this application into the [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] store. Either the application has an error or the store is corrupted. The log file might tell you where the error occurred.  
  
 You should do the following:  
  
- Verify that the identity of the deployment manifest, identity of application manifest, and identity of the main application EXE are all unique.  
  
- Verify that your file paths are not longer than 100 characters. If your application contains file paths that are too long, you may exceed the limitations on the maximum path you can store. Try shortening the paths and reinstall.  
  
#### PrivatePath settings in application config file are not honored  
 To use PrivatePath (Fusion probing paths), the application must request full trust permission. Try changing the application manifest to request full trust, and then try again.  
  
#### During uninstall a message appears saying, "Failed to uninstall application"  
 This message usually indicates that the application has already been removed or the store is corrupted. After you click **OK**, the **Add/Remove Program** entry will be removed.  
  
#### During installation, a message appears that says that the platform dependencies are not installed  
 You are missing a prerequisite in the GAC (global assembly cache) that the application needs in order to run.  
  
## Publishing with Visual Studio  
  
#### Publishing in Visual Studio fails  
 Ensure that you have the right to publish to the server that you are targeting. For example, if you are logged in to a terminal server computer as an ordinary user, not as an administrator, you probably will not have the rights required to publish to the local Web server.  
  
 If you are publishing with a URL, ensure that the destination computer has FrontPage Server Extensions enabled.  
  
#### Error Message: Unable to create the Web site '\<site>'. The components for communicating with FrontPage Server Extensions are not installed.  
 Ensure that you have the Microsoft Visual Studio Web Authoring Component installed on the machine that you are publishing from. For Express users, this component is not installed by default. For more information, see [http://go.microsoft.com/fwlink/?LinkId=102310](https://go.microsoft.com/fwlink/?LinkId=102310).  
  
#### Error Message: Could not find file 'Microsoft.Windows.Common-Controls, Version=6.0.0.0, Culture=*, PublicKeyToken=6595b64144ccf1df, ProcessorArchitecture=\*, Type=win32'  
 This error message appears when you attempt to publish a WPF application with visual styles enabled. To resolve this issue, see [How to: Publish a WPF Application with Visual Styles Enabled](../deployment/how-to-publish-a-wpf-application-with-visual-styles-enabled.md).  
  
## Using Mage  
  
#### You tried to sign with a certificate in your certificate store and a received blank message box  
 In the **Signing** dialog box, you must:  
  
- Select **Sign with a stored certificate**, and  
  
- Select a certificate from the list; the first certificate is not the default selection.  
  
#### Clicking the "Don't Sign" button causes an exception  
 This issue is a known bug. All [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] manifests are required to be signed. Just select one of the signing options, and then click **OK**.  
  
## Additional Errors  
 The following table shows some common error messages that a client-computer user may receive when the user installs a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application. Each error message is listed next to a description of the most probable cause for the error.  
  
|Error message|Description|  
|-------------------|-----------------|  
|Application cannot be started. Contact the application publisher.<br /><br /> Cannot start the application. Contact the application vendor for assistance.|These are generic error messages that occur when the application cannot be started, and no other specific reason can be found. Frequently this means that the application is somehow corrupted, or that the [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] store is corrupted.|  
|Cannot continue. The application is improperly formatted. Contact the application publisher for assistance.<br /><br /> Application validation did not succeed. Unable to continue.<br /><br /> Unable to retrieve application files. Files corrupt in deployment.|One of the manifest files in the deployment is syntactically not valid, or contains a hash that cannot be reconciled with the corresponding file. This error may also indicate that the manifest embedded inside an assembly is corrupted. Re-create your deployment and recompile your application, or find and fix the errors manually in your manifests.|  
|Cannot retrieve application. Authentication error.<br /><br /> Application installation did not succeed. Cannot locate applications files on the server. Contact the application publisher or your administrator for assistance.|One or more files in the deployment cannot be downloaded because you do not have permission to access them. This can be caused by a 403 Forbidden error being returned by a Web server, which may occur if one of the files in your deployment ends with an extension that makes the Web server treat it as a protected file. Also, a directory that contains one or more of the application's files might require a username and password in order to access.|  
|Cannot download the application. The application is missing required files. Contact the application vendor or your system administrator for assistance.|One or more of the files listed in the application manifest cannot be found on the server. Verify that you have uploaded all the deployment's dependent files, and try again.|  
|Application download did not succeed. Check your network connection, or contact your system administrator or network service provider.|[!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] cannot establish a network connection to the server. Examine the server's availability and the state of your network.|  
|URLDownloadToCacheFile failed with HRESULT '\<number>'. An error occurred trying to download '\<file>'.|If a user has set Internet Explorer Advanced Security option "Warn if changing between secure and not secure mode" on the deployment target computer, and if the setup URL of the ClickOnce application being installed is redirected from a non-secure to a secure site (or vice-versa), the installation will fail because the Internet Explorer warning interrupts it.<br /><br /> To resolve this, you can do one of the following:<br /><br /> -   Clear the security option.<br />-   Make sure that the setup URL is not redirected in such a way that changes security modes.<br />-   Remove the redirection completely and point to the actual setup URL.|  
|An error has occurred writing to the hard disk. There might be insufficient space available on the disk. Contact the application vendor or your system administrator for assistance.|This may indicate insufficient disk space for storing the application, but it may also indicate a more general I/O error when you are trying to save the application files to the drive.|  
|Cannot start the application. There is not enough available space on the disk.|The hard disk is full. Clear off space and try to run the application again.|  
|Too many deployed activations are attempting to load at once.|[!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] limits the number of different applications that can start at the same time. This is largely to help protect against malicious attempts to instigate denial-of-service attacks against the local [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] service; users who try to start the same application repeatedly, in rapid succession, will only end up with a single instance of the application.|  
|Shortcuts cannot be activated over the network.|Shortcuts to a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application can only be started on the local hard disk. They cannot be started by opening a URL that points to a shortcut file on a remote server.|  
|The application is too large to run online in partial trust. Contact the application vendor or your system administrator for assistance.|An application that runs in partial trust cannot be larger than half of the size of the online application quota, which by default is 250 MB.|  
  
## See Also  
 [ClickOnce Security and Deployment](../deployment/clickonce-security-and-deployment.md)   
 [Troubleshooting ClickOnce Deployments](../deployment/troubleshooting-clickonce-deployments.md)
