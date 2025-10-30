---
title: "Grant trust to Office solutions"
description: To grant trust to Office solutions means to modify the security policy of each target computer to trust the solution assembly, deployment manifest, and document.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "security [Office development in Visual Studio], trust"
  - "inclusion lists [Office development in Visual Studio], about inclusion lists"
  - "trust [Office development in Visual Studio], 2007 Office system"
  - "granting trust [Office development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Grant trust to Office solutions

  Grant trust to Office solutions means modifying the security policy of each target computer to trust the solution assembly, application manifest, deployment manifest, and document. Trust can be granted to the Office solution by either you or the end user.

 You can grant full trust to the Office solution by signing the application and deployment manifests.

 End users can grant trust to the Office solution by making a trust decision in the ClickOnce trust prompt.

 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]

## <a name="Signing"></a> Trust the solution by signing the application and deployment manifests
 All application and deployment manifests for Office solutions must be signed with a certificate that identifies the publisher. Certificates provide a basis for making trust decisions.

 A temporary certificate is created for you and granted trust at build time so the solution will run while you debug it. If you publish a solution that is signed with a temporary certificate, the end user will be prompted to make a trust decision.

 If you sign the solution with a known and trusted certificate, the solution will automatically be installed without prompting the end user to make a trust decision. For more information about how to obtain a certificate for signing, see [ClickOnce and Authenticode](../deployment/clickonce-and-authenticode.md). After a certificate is obtained, the certificate must be explicitly trusted by adding it to the Trusted Publishers list. For more information, see [How to: Add a trusted publisher to a client computer for ClickOnce applications](../deployment/how-to-add-a-trusted-publisher-to-a-client-computer-for-clickonce-applications.md).

 If a developer signs the solution with a temporary certificate, an administrator can re-sign the customization with a known and trusted certificate by using the Manifest Generation and Editing Tool (*mage.exe*), which is one of the Microsoft .NET Framework tools. For more information about signing solutions, see [How to: Sign Office solutions](../vsto/how-to-sign-office-solutions.md) and [How to: Sign application and deployment manifests](../ide/how-to-sign-application-and-deployment-manifests.md).

## <a name="TrustPrompt"></a>Trust the solution by using the ClickOnce trust prompt
 ClickOnce prompts the end user to make the trust decision if there is no organization-wide policy that trusts the solution's certificate. If the end user grants trust to the solution, an inclusion list entry is created that contains a URL and a public key to store this trust decision. When a trusted customization is run later, the end user is not prompted again.

 Administrators can disable the ClickOnce trust prompt or require that the prompt occur only for solutions that are signed with an Authenticode certificate. For more information about how to change these settings for the MyComputer, LocalIntranet, Internet, TrustedSites, and UntrustedSites zones, see [How to: Configure the ClickOnce trust prompt behavior](../deployment/how-to-configure-the-clickonce-trust-prompt-behavior.md).

## Related content

- [Secure Office solutions](../vsto/securing-office-solutions.md)
- [Grant trust to documents](../vsto/granting-trust-to-documents.md)
- [Troubleshoot Office solution security](../vsto/troubleshooting-office-solution-security.md)
- [Specific security considerations for Office solutions](../vsto/specific-security-considerations-for-office-solutions.md)
