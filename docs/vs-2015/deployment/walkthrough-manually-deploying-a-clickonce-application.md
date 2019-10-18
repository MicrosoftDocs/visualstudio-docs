---
title: "Walkthrough: Manually Deploying a ClickOnce Application | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "Mage.exe, manual ClickOnce deployments"
  - "MageUI.exe, manual ClickOnce deployments"
  - "deploying applications [ClickOnce], manual ClickOnce deployments"
  - "ClickOnce deployment, manually"
  - "ClickOnce deployment, SDK tools"
  - "manual ClickOnce deployments"
  - "manifests [ClickOnce]"
ms.assetid: ccee6551-a1b9-4ca2-8845-9c1cf4ac2560
caps.latest.revision: 51
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Walkthrough: Manually Deploying a ClickOnce Application
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

If you cannot use Visual Studio to deploy your [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application, or you need to use advanced deployment features, such as Trusted Application Deployment, you should use the Mage.exe command-line tool to create your [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] manifests. This walkthrough describes how to create a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] deployment by using either the command-line version (Mage.exe) or the graphical version (MageUI.exe) of the Manifest Generation and Editing Tool.  
  
## Prerequisites  
 This walkthrough has some prerequisites and options that you need to choose before building a deployment.  
  
- Install Mage.exe and MageUI.exe.  
  
     Mage.exe and MageUI.exe are part of the [!INCLUDE[winsdklong](../includes/winsdklong-md.md)]. You must either have the [!INCLUDE[winsdkshort](../includes/winsdkshort-md.md)] installed or the version of the [!INCLUDE[winsdkshort](../includes/winsdkshort-md.md)] included with Visual Studio. For more information, see [Windows SDK](http://go.microsoft.com/fwlink/?LinkId=158044) on MSDN.  
  
- Provide an application to deploy.  
  
     This walkthrough assumes that you have a Windows application that you are ready to deploy. This application will be referred to as AppToDeploy.  
  
- Determine how the deployment will be distributed.  
  
     The distribution options include: Web, file share, or CD. For more information, see [ClickOnce Security and Deployment](../deployment/clickonce-security-and-deployment.md).  
  
- Determine whether the application requires an elevated level of trust.  
  
     If your application requires Full Trust—for example, full access to the user's system—you can use the `-TrustLevel` option of Mage.exe to set this. If you want to define a custom permission set for your application, you can copy the Internet or intranet permission section from another manifest, modify it to suit your needs, and add it to the application manifest using either a text editor or MageUI.exe. For more information, see [Trusted Application Deployment Overview](../deployment/trusted-application-deployment-overview.md).  
  
- Obtain an Authenticode certificate.  
  
     You should sign your deployment with an Authenticode certificate. You can generate a test certificate by using Visual Studio, MageUI.exe, or MakeCert.exe and Pvk2Pfx.exe tools, or you can obtain a certificate from a Certificate Authority (CA). If you choose to use Trusted Application Deployment, you must also perform a one-time installation of the certificate onto all client computers. For more information, see [Trusted Application Deployment Overview](../deployment/trusted-application-deployment-overview.md).  
  
    > [!NOTE]
    > You can also sign your deployment with a CNG certificate that you can obtain from a Certificate Authority.  
  
- Make sure that the application does not have a manifest with UAC information.  
  
     You need to determine whether your application contains a manifest with User Account Control (UAC) information, such as an `<dependentAssembly>` element. To examine an application manifest, you can use the Windows Sysinternals [Sigcheck](http://go.microsoft.com/fwlink/?LinkId=158035) utility.  
  
     If your application contains a manifest with UAC details, you must re-build it without the UAC information. For a C# project in Visual Studio, open the project properties and select the Application tab. In the **Manifest** drop-down list, select **Create application without a manifest**. For a Visual Basic project in Visual Studio, open the project properties, select the Application tab, and click **View UAC Settings**. In the opened manifest file, remove all elements within the single `<asmv1:assembly>` element.  
  
- Determine whether the application requires prerequisites on the client computer.  
  
     [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] applications deployed from Visual Studio can include a prerequisite installation bootstrapper (setup.exe) with your deployment. This walkthrough creates the two manifests required for a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] deployment. You can create a prerequisite bootstrapper by using the [GenerateBootstrapper Task](../msbuild/generatebootstrapper-task.md).  
  
### To deploy an application with the Mage.exe command-line tool  
  
1. Create a directory where you will store your [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] deployment files.  
  
2. In the deployment directory you just created, create a version subdirectory. If this is the first time that you are deploying the application, name the version subdirectory **1.0.0.0**.  
  
    > [!NOTE]
    > The version of your deployment can be distinct from the version of your application.  
  
3. Copy all of your application files to the version subdirectory, including executable files, assemblies, resources, and data files. If necessary, you can create additional subdirectories that contain additional files.  
  
4. Open the [!INCLUDE[winsdkshort](../includes/winsdkshort-md.md)] or Visual Studio command prompt and change to the version subdirectory.  
  
5. Create the application manifest with a call to Mage.exe. The following statement creates an application manifest for code compiled to run on the Intel x86 processor.  
  
    ```  
    mage -New Application -Processor x86 -ToFile AppToDeploy.exe.manifest -name "My App" -Version 1.0.0.0 -FromDirectory .   
    ```  
  
    > [!NOTE]
    > Be sure to include the dot (.) after the `-FromDirectory` option, which indicates the current directory. If you do not include the dot, you must specify the path to your application files.  
  
6. Sign the application manifest with your Authenticode certificate. Replace *mycert.pfx* with the path to your certificate file. Replace *passwd* with the password for your certificate file.  
  
    ```  
    mage -Sign AppToDeploy.exe.manifest -CertFile mycert.pfx -Password passwd  
    ```  
  
     To sign  the application manifest with a CNG certificate, use the following. Replace *cngCert.pfx* with the path to your certificate file.  
  
    ```  
    mage -Sign AppToDeploy.exe.manifest -CertFile cngCert.pfx  
    ```  
  
7. Change to the root of the deployment directory.  
  
8. Generate the deployment manifest with a call to Mage.exe. By default, Mage.exe will mark your [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] deployment as an installed application, so that it can be run both online and offline. To make the application available only when the user is online, use the `-Install` option with a value of `false`. If you use the default, and users will install your application from a Web site or file share, make sure that the value of the `-ProviderUrl` option points to the location of the application manifest on the Web server or share.  
  
    ```  
    mage -New Deployment -Processor x86 -Install true -Publisher "My Co." -ProviderUrl "\\myServer\myShare\AppToDeploy.application" -AppManifest 1.0.0.0\AppToDeploy.exe.manifest -ToFile AppToDeploy.application  
    ```  
  
9. Sign the deployment manifest with your Authenticode  or CNG certificate.  
  
    ```  
    mage -Sign AppToDeploy.application -CertFile mycert.pfx -Password passwd  
    ```  
  
     or  
  
    ```  
    mage -Sign AppToDeploy.exe.manifest -CertFile cngCert.pfx  
    ```  
  
10. Copy all of the files in the deployment directory to the deployment destination or media. This may be either a folder on a Web site or FTP site, a file share, or a CD-ROM.  
  
11. Provide your users with the URL, UNC, or physical media required to install your application. If you provide a URL or a UNC, you must give your users the full path to the deployment manifest. For example, if AppToDeploy is deployed to http://webserver01/ in the AppToDeploy directory, the full URL path would be http://webserver01/AppToDeploy/AppToDeploy.application.  
  
### To deploy an application with the MageUI.exe graphical tool  
  
1. Create a directory where you will store your [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] deployment files.  
  
2. In the deployment directory you just created, create a version subdirectory. If this is the first time that you are deploying the application, name the version subdirectory **1.0.0.0**.  
  
    > [!NOTE]
    > The version of your deployment is probably distinct from the version of your application.  
  
3. Copy all of your application files to the version subdirectory, including executable files, assemblies, resources, and data files. If necessary, you can create additional subdirectories that contain additional files.  
  
4. Start the MageUI.exe graphical tool.  
  
    ```  
    MageUI.exe  
    ```  
  
5. Create a new application manifest by selecting **File**, **New**, **Application Manifest** from the menu.  
  
6. On the default **Name** tab, type the name and version number of this deployment. Also specify the **Processor** that your application is built for, such as x86.  
  
7. Select the **Files** tab and click the ellipsis (**...**) button next to the **Application directory** text box. A Browse For Folder dialog box appears.  
  
8. Select the version subdirectory containing your application files, and then click **OK**.  
  
9. If you will deploy from Internet Information Services (IIS), select the **When populating add the .deploy extension to any file that does not have it** check box.  
  
10. Click the **Populate** button to add all your application files to the file list. If your application contains more than one executable file, mark the main executable file for this deployment as the startup application by selecting **Entry Point** from the **File Type** drop-down list. (If your application contains only one executable file, MageUI.exe will mark it for you.)  
  
11. Select the **Permissions Required** tab and select the level of trust that you need your application to assert. The default is **FullTrust**, which will be suitable for most applications.  
  
12. Select **File**, **Save As** from the menu. A Signing Options dialog box appears prompting you to sign the application manifest.  
  
13. If you have a certificate stored as a file on your file system, use the **Sign with certificate file** option, and select the certificate from the file system by using the ellipsis (**...**) button. Then type your certificate password.  
  
     -or-  
  
     If your certificate is kept in a certificate store accessible from your computer, select the **Sign with stored certificate** option, and select the certificate from the provided list.  
  
14. Click **OK** to sign your application manifest. The Save As dialog box appears.  
  
15. In the Save As dialog box, specify the version directory, and then click **Save**.  
  
16. Select **File**, **New**, **Deployment Manifest** from the menu to create your deployment manifest.  
  
17. On the **Name** tab, specify a name and version number for this deployment (**1.0.0.0** in this example). Also specify the **Processor** that your application is built for, such as x86.  
  
18. Select the **Description** tab, and specify values for **Publisher** and **Product**. (**Product** is the name given to your application on the Windows Start menu when your application installs on a client computer for offline use.)  
  
19. Select the **Deployment Options** tab, and in the **Start Location** text box, specify the location of the application manifest on the Web server or share. For example, \\\myServer\myShare\AppToDeploy.application.  
  
20. If you added the .deploy extension in a previous step, also select **Use .deploy file name extension** here.  
  
21. Select the **Update Options** tab, and specify how often you would like this application to update. If your application uses <xref:System.Deployment.Application.UpdateCheckInfo> to check for updates itself, clear the **This application should check for updates** check box.  
  
22. Select the **Application Reference** tab and then click the **Select Manifest** button. An open dialog box appears.  
  
23. Select the application manifest that you created earlier and then click **Open**.  
  
24. Select **File**, **Save As** from the menu. A Signing Options dialog box appears prompting you to sign the deployment manifest.  
  
25. If you have a certificate stored as a file on your file system, use the **Sign with certificate file** option, and select the certificate from the file system by using the ellipsis (**...**) button. Then type your certificate password.  
  
     -or-  
  
     If your certificate is kept in a certificate store accessible from your computer, select the **Sign with stored certificate** option, and select the certificate from the provided list.  
  
26. Click **OK** to sign your deployment manifest. The Save As dialog box appears.  
  
27. In the **Save As** dialog box, move up one directory to the root of your deployment and then click **Save**.  
  
28. Copy all of the files in the deployment directory to the deployment destination or media. This may be either a folder on a Web site or FTP site, a file share, or a CD-ROM.  
  
29. Provide your users with the URL, UNC, or physical media required to install your application. If you provide a URL or a UNC, you must give your users the full path the deployment manifest. For example, if AppToDeploy is deployed to http://webserver01/ in the AppToDeploy directory, the full URL path would be http://webserver01/AppToDeploy/AppToDeploy.application.  
  
## Next Steps  
 When you need to deploy a new version of the application, create a new directory named after the new version—for example, 1.0.0.1—and copy the new application files into the new directory. Next, you need to follow the previous steps to create and sign a new application manifest, and update and sign the deployment manifest. Be careful to specify the same higher version in both the Mage.exe `-New` and `–Update` calls, as [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] only updates higher versions, with the left-most integer most significant. If you used MageUI.exe, you can update the deployment manifest by opening it, selecting the **Application Reference** tab, clicking the **Select Manifest** button, and then selecting the updated application manifest.  
  
## See also  
 [Mage.exe (Manifest Generation and Editing Tool)](https://msdn.microsoft.com/library/77dfe576-2962-407e-af13-82255df725a1)   
 [MageUI.exe (Manifest Generation and Editing Tool, Graphical Client)](https://msdn.microsoft.com/library/f9e130a6-8117-49c4-839c-c988f641dc14)   
 [Publishing ClickOnce Applications](../deployment/publishing-clickonce-applications.md)   
 [ClickOnce Deployment Manifest](../deployment/clickonce-deployment-manifest.md)   
 [ClickOnce Application Manifest](../deployment/clickonce-application-manifest.md)
