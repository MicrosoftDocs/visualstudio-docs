---
title: Sign setup files with SignTool.exe (ClickOnce)
description: Learn how to use SignTool.exe to sign a Setup program for ClickOnce applications, which helps ensure that tampered files are not installed.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - ClickOnce applications, signtool.exe
  - deploying applications [ClickOnce], re-signing setup.exe
  - ClickOnce deployment, signtool.exe
  - ClickOnce applications, re-signing setup.exe
  - ClickOnce deployment, re-signing setup.exe
ms.assetid: 545a4005-d283-4110-9821-c78a9833c250
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
ms.workload: 
  - multiple
---
# How to: Sign setup files with SignTool.exe (ClickOnce)
You can use *SignTool.exe* to sign a Setup program (*setup.exe*). This process helps ensure that tampered files are not installed on end-user computers.

 By default, ClickOnce has signed manifests and a signed Setup program. However, if you want to change the parameters of the Setup program later, you must sign the Setup program later. If you change the parameters after the Setup program is signed, the signature becomes corrupted.

 The following procedure generates unsigned manifests and an unsigned Setup program. Then, ClickOnce signing is enabled in Visual Studio to generate signed manifests. The Setup program is left unsigned so that the customer can sign the executable with their own certificate.

### To generate an unsigned Setup program and sign later

1. On the development computer, install the certificate that you want the sign the manifests with.

2. Select the project in **Solution Explorer**.

3. On the **Project** menu, click *ProjectName* **Properties**.

4. In the **Signing** page, clear **Sign the ClickOnce manifests**.

5. In the **Publish** page, click **Prerequisites**.

6. Verify that all the prerequisites are selected, and then click **OK**.

7. In the **Publish** page, verify the publish settings and then click **Publish Now**.

     The solution publishes the unsigned application manifest, unsigned deployment manifest, version-specific files, and unsigned Setup program to the publishing folder location.

8. In the **Publish** page, click **Prerequisites**.

9. In the **Prerequisites** dialog box, clear **Create setup program to install prerequisite components**.

10. In the **Publish** page, verify the publish settings and then click **Publish Now**.

     The solution publishes the signed application manifest, signed deployment manifest, and version-specific files to the publishing folder location. The unsigned Setup program is not overwritten by the publish process.

11. At the customer site, open a command prompt.

12. Change to the directory that contains the *.exe* file.

13. Sign the *.exe* file with the following command:

    ```cmd
    signtool sign /sha1 CertificateHash Setup.exe
    signtool sign /f CertFileName Setup.exe
    ```

     For example, to sign the Setup program, use one of the following commands:

    ```cmd
    signtool sign /sha1 CCB... Setup.exe
    signtool sign /f CertFileName Setup.exe
    ```

## See also
- [How to: Re-sign application and deployment manifests](../deployment/how-to-re-sign-application-and-deployment-manifests.md)
