---
title: "How to: Sign Office solutions"
description: Learn how you can grant trust to your Microsoft Office solution by using a certificate as evidence.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "certificates [Office development in Visual Studio], Office solutions"
  - "security [Office development in Visual Studio], signing Office solutions"
  - "signing manifests [Office development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Sign Office solutions
  If you sign a solution, you can grant trust to the solution using the certificate as evidence. You can use the same certificate for multiple solutions, and all the solutions will be trusted with no additional security policy updates.

 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]

 If you manually edit application and deployment manifests by using the Manifest Generation and Editing Tool (*mage.exe* and *mageui.exe*), you must re-sign the manifests before you can use them. For more information, see [How to: Re-sign application and deployment manifests](../deployment/how-to-re-sign-application-and-deployment-manifests.md).

## Sign by using a certificate
 A certificate is a file that contains a unique key and the identity of the solution publisher. You can purchase certificates from a certificate authority, or create your own certificate and have a certificate authority sign it.

 Visual Studio signs Office solutions with a temporary certificate to enable debugging. You should not use the temporary certificate in deployed solutions as evidence.

### To sign an Office solution by using a certificate

1. On the **Project** menu, click _SolutionName_**Properties**.

2. Click the **Signing** tab.

3. Select **Sign the ClickOnce manifests**.

4. Locate the certificate by clicking **Select from Store** or **Select from File** and navigating to the certificate.

5. To verify that the correct certificate is being used, click **More Details** to view the certificate information.

## See also

- [Secure Office solutions](../vsto/securing-office-solutions.md)
- [Grant trust to Office solutions](../vsto/granting-trust-to-office-solutions.md)
- [Signing Page, Project Designer](../ide/reference/signing-page-project-designer.md)
