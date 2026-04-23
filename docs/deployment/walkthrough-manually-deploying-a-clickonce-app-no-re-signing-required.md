---
title: "Manually deploy ClickOnce app & keep branding"
description: Learn how to create ClickOnce applications to be deployed by customers without generating a new deployment manifest and that can use the customer branding.
ms.date: "11/04/2016"
ms.topic: install-set-up-deploy
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "branding"
  - "preserved branding information"
  - "ClickOnce deployment, manually"
  - "multiple ClickOnce deployment and branding"
  - "ClickOnce deployment, SDK tools"
  - "customer deployments"
  - "manual ClickOnce deployments"
  - "manifests [ClickOnce]"
  - "ClickOnce applications, deployed by others"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# Walkthrough: Manually deploy a ClickOnce application that does not require re-signing and that preserves branding information

When you create a ClickOnce application and then give it to a customer to publish and deploy, the customer has traditionally had to update the deployment manifest and re-sign it. While that is still the preferred method in most cases, the .NET Framework 3.5 enables you to create ClickOnce deployments that can be deployed by customers without having to regenerate a new deployment manifest. For more information, see [Deploy ClickOnce applications for testing and production servers without resigning](../deployment/deploying-clickonce-applications-for-testing-and-production-without-resigning.md).

 When you create a ClickOnce application and then give it to a customer to publish and deploy, the application can use the customer's branding or can preserve your branding. For example, if the application is a single proprietary application, you might want to preserve your branding. If the application is highly customized for each customer, you might want to use the customer's branding. The .NET Framework 3.5 enables you to preserve your branding, publisher information and security signature when you give an application to an organization to deploy. For more information, see [Create ClickOnce applications for others to deploy](../deployment/creating-clickonce-applications-for-others-to-deploy.md).

> [!NOTE]
> In this walkthrough you create deployments manually by using either the command-line tool *Mage.exe* or the graphical tool *MageUI.exe*. For more information about manual deployments, see [Walkthrough: Manually deploy a ClickOnce application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md).

 [!INCLUDE[ndptecclick](../deployment/includes/dotnet-dotnetmage-exe.md)]

## Prerequisites
 To perform the steps in this walkthrough you need the following:

- A Windows Forms application that you are ready to deploy. This application will be referred to as *WindowsFormsApp1*.

- Visual Studio or the Windows SDK.

### To deploy a ClickOnce application with multiple deployment and branding support using Mage.exe

1. Open a Visual Studio command prompt or a Windows SDK command prompt, and change to the directory in which you will store your ClickOnce files.

2. Create a directory named after the current version of your deployment. If this is the first time that you are deploying the application, you will likely choose **1.0.0.0**.

   > [!NOTE]
   > The version of your deployment may be distinct from the version of your application files.

3. Create a subdirectory named **bin** and copy all of your application files here, including executable files, assemblies, resources, and data files.

4. Generate the application manifest with a call to Mage.exe.

   ```cmd
   mage -New Application -ToFile 1.0.0.0\WindowsFormsApp1.exe.manifest -Name "Windows Forms App 1" -Version 1.0.0.0 -FromDirectory 1.0.0.0\bin -UseManifestForTrust true -Publisher "A. Datum Corporation"
   ```

5. Sign the application manifest with your digital certificate.

   ```cmd
   mage -Sign WindowsFormsApp1.exe.manifest -CertFile mycert.pfx
   ```

6. Generate the deployment manifest with a call to *Mage.exe*. By default, *Mage.exe* will mark your ClickOnce deployment as an installed application, so that it can be run both online and offline. To make the application available only when the user is online, use the `-i` argument with a value of `f`. Since this application will take advantage of the multiple deployment feature, exclude the `-providerUrl` argument to *Mage.exe*. (In versions of the .NET Framework prior to version 3.5, excluding `-providerUrl` for an offline application will result in an error.)

   ```cmd
   mage -New Deployment -ToFile WindowsFormsApp1.application -Name "Windows Forms App 1" -Version 1.0.0.0 -AppManifest 1.0.0.0\WindowsFormsApp1.manifest
   ```

7. Do not sign the deployment manifest.

8. Provide all of the files to the customer, who will deploy the application on his network.

9. At this point, the customer must sign the deployment manifest with his own self-generated certificate. For example, if the customer works for a company named Adventure Works, he can generate a self-signed certificate using the *MakeCert.exe* tool. Next, use the *Pvk2pfx.exe* tool to combine the files created by *MakeCert.exe* into a PFX file that can be passed to *Mage.exe*.

    ```cmd
    makecert -r -pe -n "CN=Adventure Works" -sv MyCert.pvk MyCert.cer
    pvk2pfx.exe -pvk MyCert.pvk -spc MyCert.cer -pfx MyCert.pfx
    ```

10. The customer next uses this certificate to sign the deployment manifest.

    ```cmd
    mage -Sign WindowsFormsApp1.application -CertFile MyCert.pfx
    ```

11. The customer deploys the application to their users.

### To deploy a ClickOnce application with multiple deployment and branding support using MageUI.exe

1. Open a Visual Studio command prompt or a Windows SDK command prompt, and navigate to the directory in which you will store your ClickOnce files.

2. Create a subdirectory named **bin** and copy all of your application files here, including executable files, assemblies, resources, and data files.

3. Create a subdirectory named after the current version of your deployment. If this is the first time that you are deploying the application, you will likely choose **1.0.0.0**.

   > [!NOTE]
   > The version of your deployment may be distinct from the version of your application files.

4. Move the \\**bin** directory into the directory you created in step 2.

5. Start the graphical tool *MageUI.exe*.

   ```cmd
   MageUI.exe
   ```

6. Create a new application manifest by selecting **File**, **New**, **Application Manifest** from the menu.

7. On the default **Name** tab, enter the name and version number of this deployment. Also, supply a value for **Publisher**, which will be used as the folder name for the application's shortcut link in the Start menu when it is deployed.

8. Select the **Application Options** tab and click **Use Application Manifest for Trust Information**. This will enable third-party branding for this ClickOnce application.

9. Select the **Files** tab and click the **Browse** button next to the **Application Directory** text box.

10. Select the directory that contains your application files that you created in step 2, and click **OK** on the folder selection dialog box.

11. Click the **Populate** button to add all your application files to the file list. If your application contains more than one executable file, mark the main executable file for this deployment as the startup application by selecting **Entry Point** from the **File Type** drop-down list. (If your application only contains one executable file, *MageUI.exe* will mark it for you.)

12. Select the **Permissions Required** tab and select the level of trust you need your application to assert. The default is **Full Trust**, which will be appropriate for most applications.

13. Select **File**, **Save** from the menu, and save the application manifest. You will be prompted to sign the application manifest when you save it.

14. If you have a certificate stored as a file on your file system, use the **Sign as certificate file** option, and select the certificate from the file system using the ellipsis (**...**) button.

     -or-

     If your certificate is kept in a certificate store that can be accessed from your computer, select the **Sign with stored certificate option**, and select the certificate from the list provided.

15. Select **File**, **New**, **Deployment Manifest** from the menu to create your deployment manifest, and then on the **Name** tab, supply a name and version number (**1.0.0.0** in this example).

16. Switch to the **Update** tab, and specify how often you want this application to update. If your application uses the ClickOnce Deployment API to check for updates itself, clear the check box labeled **This application should check for updates**.

17. Switch to the **Application Reference** tab. You can pre-populate all of the values on this tab by clicking the **Select Manifest** button and selecting the application manifest you created in previous steps.

18. Choose **Save** and save the deployment manifest to disk. You will be prompted to sign the application manifest when you save it. Click **Cancel** to save the manifest without signing it.

19. Provide all of the application files to the customer.

20. At this point, the customer must sign the deployment manifest with his own self-generated certificate. For example, if the customer works for a company named Adventure Works, he can generate a self-signed certificate using the *MakeCert.exe* tool. Next, use the *Pvk2pfx.exe* tool to combine the files created by *MakeCert.exe* into a PFX file that can be passed to *MageUI.exe*.

    ```cmd
    makecert -r -pe -n "CN=Adventure Works" -sv MyCert.pvk MyCert.cer
    pvk2pfx.exe -pvk MyCert.pvk -spc MyCert.cer -pfx MyCert.pfx
    ```

21. With the certificate generated, the customer now signs the deployment manifest by opening the deployment manifest in *MageUI.exe*, and then saving it. When the signing dialog box appears, the customer selects **Sign as certificate file** option, and chooses the PFX file he has saved on disk.

22. The customer deploys the application to their users.

## Related content
- [Mage.exe (Manifest Generation and Editing Tool)](/dotnet/framework/tools/mage-exe-manifest-generation-and-editing-tool)
- [MageUI.exe (Manifest Generation and Editing Tool, Graphical Client)](/dotnet/framework/tools/mageui-exe-manifest-generation-and-editing-tool-graphical-client)
- [MakeCert](/windows/desktop/SecCrypto/makecert)
