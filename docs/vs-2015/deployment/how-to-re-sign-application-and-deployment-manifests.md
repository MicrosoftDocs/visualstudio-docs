---
title: "How to: Re-sign Application and Deployment Manifests | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "Office applications, signing manifests"
  - "deploying applications [ClickOnce], signing manifests"
  - "deploying applications, signing manifests"
  - "ClickOnce deployment, signing manifests"
  - "Office development in Visual Studio, signing manifests"
ms.assetid: d53bceb9-4d3b-4c22-b909-8f370e7231fb
caps.latest.revision: 19
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# How to: Re-sign Application and Deployment Manifests
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

After you make changes to deployment properties in the application manifest for Windows Forms applications, Windows Presentation Foundation applications (xbap), or Office solutions, you must re-sign both the application and deployment manifests with a certificate. This process helps ensure that tampered files are not installed on end user computers.  
  
 Another scenario where you might re-sign the manifests is when your customers want to sign the application and deployment manifests with their own certificate.  
  
## Re-signing the Application and Deployment Manifests  
 This procedure assumes that you have already made changes to your application manifest file (.manifest). For more information, see [How to: Change Deployment Properties](https://msdn.microsoft.com/66052a3a-8127-4964-8147-2477ef5d1472).  
  
#### To re-sign the application and deployment manifests with Mage.exe  
  
1. Open a **Visual Studio Command Prompt** window.  
  
2. Change directories to the folder that contains the manifest files that you want to sign.  
  
3. Type the following command to sign the application manifest file. Replace ManifestFileName with the name of your manifest file plus the extension. Replace Certificate with the relative or fully qualified path of the certificate file and replace Password with the password for the certificate.  
  
    ```  
    mage -sign ManifestFileName.manifest -CertFile Certificate -Password Password  
    ```  
  
     For example, you could run the following command to sign an application manifest for an add-in, a Windows Form application, or a Windows Presentation Foundation browser application. Temporary certificates created by Visual Studio are not recommended for deployment into production environments.  
  
    ```  
    mage -sign WindowsFormsApplication1.exe.manifest -CertFile ..\WindowsFormsApplication1_TemporaryKey.pfx  
    mage -sign ExcelAddin1.dll.manifest -CertFile ..\ExcelAddIn1_TemporaryKey.pfx  
    mage -sign WpfBrowserApplication1.exe.manifest -CertFile ..\WpfBrowserApplication1_TemporaryKey.pfx  
    ```  
  
4. Type the following command to update and sign the deployment manifest file, replacing the placeholder names as in the previous step.  
  
    ```  
    mage -update DeploymentManifest -appmanifest ApplicationManifest -CertFile Certificate -Password Password  
    ```  
  
     For example, you could run the following command to update and sign a deployment manifest for an Excel add-in, a Windows Forms application, or a Windows Presentation Foundation browser application.  
  
    ```  
    mage -update WindowsFormsApplication1.application -appmanifest WindowsFormsApplication1.exe.manifest -CertFile ..\WindowsFormsApplication1_TemporaryKey.pfx  
    mage -update ExcelAddin1.vsto -appmanifest ExcelAddin1.dll.manifest -CertFile ..\ExcelAddIn1_TemporaryKey.pfx  
    mage -update WpfBrowserApplication1.xbap -appmanifest WpfBrowserApplication1.exe.manifest -CertFile ..\WpfBrowserApplication1_TemporaryKey.pfx  
    ```  
  
5. Optionally, copy the master deployment manifest (publish\\*appname*.application) to your version deployment directory (publish\Application Files\\*appname*_*version*).  
  
## Updating and Re-signing the Application and Deployment Manifests  
 This procedure assumes that you have already made changes to your application manifest file (.manifest), but that there are other files that were updated. When files are updated, the hash that represents the file must also be updated.  
  
#### To update and re-sign the application and deployment manifests with Mage.exe  
  
1. Open a **Visual Studio Command Prompt** window.  
  
2. Change directories to the folder that contains the manifest files that you want to sign.  
  
3. Remove the .deploy file extension from the files in the publish output folder.  
  
4. Type the following command to update the application manifest with the new hashes for the updated files and sign the application manifest file. Replace ManifestFileName with the name of your manifest file plus the extension. Replace Certificate with the relative or fully qualified path of the certificate file and replace Password with the password for the certificate.  
  
    ```  
    mage -update ManifestFileName.manifest -CertFile Certificate -Password Password  
    ```  
  
     For example, you could run the following command to sign an application manifest for an add-in, a Windows Form application, or a Windows Presentation Foundation browser application. Temporary certificates created by Visual Studio are not recommended for deployment into production environments.  
  
    ```  
    mage -update WindowsFormsApplication1.exe.manifest -CertFile ..\WindowsFormsApplication1_TemporaryKey.pfx  
    mage -update ExcelAddin1.dll.manifest -CertFile ..\ExcelAddIn1_TemporaryKey.pfx  
    mage -update WpfBrowserApplication1.exe.manifest -CertFile ..\WpfBrowserApplication1_TemporaryKey.pfx  
    ```  
  
5. Type the following command to update and sign the deployment manifest file, replacing the placeholder names as in the previous step.  
  
    ```  
    mage -update DeploymentManifest -appmanifest ApplicationManifest -CertFile Certificate -Password Password  
    ```  
  
     For example, you could run the following command to update and sign a deployment manifest for an Excel add-in, a Windows Forms application, or a Windows Presentation Foundation browser application.  
  
    ```  
    mage -update WindowsFormsApplication1.application -appmanifest WindowsFormsApplication1.exe.manifest -CertFile ..\WindowsFormsApplication1_TemporaryKey.pfx  
    mage -update ExcelAddin1.vsto -appmanifest ExcelAddin1.dll.manifest -CertFile ..\ExcelAddIn1_TemporaryKey.pfx  
    mage -update WpfBrowserApplication1.xbap -appmanifest WpfBrowserApplication1.exe.manifest -CertFile ..\WpfBrowserApplication1_TemporaryKey.pfx  
    ```  
  
6. Add the .deploy file extension back to the files, except the application and deployment manifest files.  
  
7. Optionally, copy the master deployment manifest (publish\\*appname*.application) to your version deployment directory (publish\Application Files\\*appname*_*version*).  
  
## See Also  
 [Securing ClickOnce Applications](../deployment/securing-clickonce-applications.md)   
 [Code Access Security for ClickOnce Applications](../deployment/code-access-security-for-clickonce-applications.md)   
 [ClickOnce and Authenticode](../deployment/clickonce-and-authenticode.md)   
 [Trusted Application Deployment Overview](../deployment/trusted-application-deployment-overview.md)   
 [How to: Enable ClickOnce Security Settings](../deployment/how-to-enable-clickonce-security-settings.md)   
 [How to: Set a Security Zone for a ClickOnce Application](../deployment/how-to-set-a-security-zone-for-a-clickonce-application.md)   
 [How to: Set Custom Permissions for a ClickOnce Application](../deployment/how-to-set-custom-permissions-for-a-clickonce-application.md)   
 [How to: Debug a ClickOnce Application with Restricted Permissions](../deployment/how-to-debug-a-clickonce-application-with-restricted-permissions.md)   
 [How to: Add a Trusted Publisher to a Client Computer for ClickOnce Applications](../deployment/how-to-add-a-trusted-publisher-to-a-client-computer-for-clickonce-applications.md)   
 [How to: Configure the ClickOnce Trust Prompt Behavior](../deployment/how-to-configure-the-clickonce-trust-prompt-behavior.md)
