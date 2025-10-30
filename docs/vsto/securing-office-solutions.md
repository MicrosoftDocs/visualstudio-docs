---
title: "Secure Office solutions"
description: Learn how the security model for Office solutions involves several technologies, including the Visual Studio Tools for Office runtime and ClickOnce. 
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office development in Visual Studio, security"
  - "Office applications [Office development in Visual Studio], security"
  - "security [Office development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Secure Office solutions

  The security model for Office solutions involves several technologies: the  Visual Studio Tools for Office runtime , ClickOnce, the Trust Center in Microsoft Office, and the Internet Explorer restricted sites zone. The following sections describe how the different security features work:

- [Grant trust to Office solutions](#GrantingTrustToSolutions)

- [Grant trust to documents](#GrantingTrustToDocuments)

- [Grant trust when using Windows Installer](#GrantingTrustWindowsInstaller)

- [Specific security considerations for Office solutions](#Security)

- [Security during development](#SecurityDuringDeployment)

- [Visual Studio Tools for Office runtime](#VisualStudioToolsForOfficeRuntime)

  [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]

## <a name="GrantingTrustToSolutions"></a> Grant trust to Office solutions
 Granting trust to Office solutions means modifying the security policy of each end user to trust the Office solution based on the following evidence:

- The certificate used to sign the deployment manifest.

- The URL of the deployment manifest.

  For more information, see [Grant trust to Office solutions](../vsto/granting-trust-to-office-solutions.md).

## <a name="GrantingTrustToDocuments"></a> Grant trust to documents
 A document-level customization requires that the document be in a directory that is designated as a trusted location. For more information, see [Grant trust to documents](../vsto/granting-trust-to-documents.md).

## <a name="GrantingTrustWindowsInstaller"></a> Grant trust when using Windows Installer
 You can use Windows Installer to create an MSI file to install Office solutions into the Program Files directory, which requires administrator rights. For Office solutions in the Program Files directory, the Visual Studio 2010 Tools for Office runtime considers these Office solutions to be trusted and does not show the ClickOnce trust prompt.

## <a name="Security"></a> Specific security considerations for Office solutions
 The security features provided by the .NET Framework 4, the .NET Framework 4.5, and Microsoft Office can help to protect against a variety of possible security threats in Office solutions. For more information, see [Specific security considerations for Office solutions](../vsto/specific-security-considerations-for-office-solutions.md).

## <a name="SecurityDuringDeployment"></a> Security during development
 To make your development process easier, Visual Studio sets the security policy that is required to run and debug your solution on your computer every time that you build a project. In some scenarios, you might need to take additional security steps to develop the project.

### Document-level solutions
 The fully qualified path of a document must be added to the list of trusted locations in the Microsoft Office application if you are developing the following types of projects:

- Document-level solutions that are on a network file share such as *\\\servername\sharename*.

- Document-level solutions for Word that use *.doc* or *.docm* files.

  Include the subdirectories when you add the document location to the trusted locations list, or specifically include the debug and build folders. For more information, see the Microsoft Office Online Help article [Create, remove, or change a trusted location for your files](https://support.office.com/article/Create-remove-or-change-a-trusted-location-for-your-files-f5151879-25ea-4998-80a5-4208b3540a62).

### Temporary certificates
 Visual Studio creates a temporary certificate if a signing certificate does not already exist. You should use this temporary certificate only during development, and purchase an official certificate for deployment.

 The temporary certificate is generated after an Office project is first built. The next time you press **F5**, the project is rebuilt because the project is marked as changed when the certificate is added.

 There can be many temporary certificates after a while, so you should clear the temporary certificates occasionally.

## <a name="VisualStudioToolsForOfficeRuntime"></a> Visual Studio Tools for Office runtime
 The  Visual Studio Tools for Office runtime  has features to verify the identity of the publisher and the permissions that are granted to a customization. It verifies these permissions through a sequence of security checks.

### Security during customization loading
 When a document-level customization is loaded, the  Visual Studio Tools for Office runtime  always checks whether the document is in the trusted locations list. In addition, the runtime checks whether the solution requests FullTrust in the application manifest. It performs no additional security checks while the customization is loading.

### Sequence of security checks during installation
 When an Office solution is installed or updated, the  Visual Studio Tools for Office runtime  performs a set of security checks in a specific sequence to make a trust decision. A solution is installed or updated only if the runtime determines that the solution is trusted.

 You can start the installation process in one of four ways: by running the Setup program, by opening the deployment manifest, by opening the Microsoft Office application host, or by running *VSTOInstaller.exe*.

 The first security check applies only to document-level solutions. The document of a document-level solution must be in a trusted location. If the document is on a remote network file share or has a *.doc* or *.docm* file name extension, the document's location must be added to the trusted locations list. For more information, see [Grant trust to documents](../vsto/granting-trust-to-documents.md).

 ![VSTO security - installing from Microsoft Office](../vsto/media/host-install.png "VSTO security - installing from Microsoft Office")

 The next set of security checks are from the  Visual Studio Tools for Office runtime  and ClickOnce. To pass these checks, Office solutions must request FullTrust permissions, be signed with a certificate that is not listed in the Untrusted Publisher list, and be in a location that is not in the Internet Explorer restricted zone. If the certificate is in the Trusted Publisher list, then the solution is installed immediately. Otherwise, if it did not fail one of the checks, the solution continues to the final set of checks.

 ![VSTO security for installing solutions](../vsto/media/installing.png "VSTO security for installing solutions")

 If the ClickOnce trust prompt is allowed and the solution has not yet been granted trust, the runtime will allow the trust decision to be made by the end user. If the user grants trust to the solution, an entry is added to the user inclusion list. All solutions in the user inclusion list have full trust and can be installed and run.

 Starting in Visual Studio 2010, the inclusion list is bypassed if the Office solution is installed by using Windows Installer (MSI) into the Program Files directory. For more information, see [Trust Office solutions by using inclusion lists](../vsto/trusting-office-solutions-by-using-inclusion-lists.md).

 ![VSTO security - using the Setup program to install](../vsto/media/setup-vstoinstaller.png "VSTO security - using the Setup program to install")

## Related content

- [Grant trust to Office solutions](../vsto/granting-trust-to-office-solutions.md)
- [Grant trust to documents](../vsto/granting-trust-to-documents.md)
- [Trust Office solutions by using inclusion lists](../vsto/trusting-office-solutions-by-using-inclusion-lists.md)
- [How to: Configure inclusion list security](../vsto/how-to-configure-inclusion-list-security.md)
- [How to: Sign Office solutions](../vsto/how-to-sign-office-solutions.md)
- [Troubleshoot Office solution security](../vsto/troubleshooting-office-solution-security.md)
- [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md)
- [Deployment manifests for Office solutions](../vsto/deployment-manifests-for-office-solutions.md)
- [ClickOnce reference](../deployment/clickonce-reference.md)
- [Deploy an Office solution](../vsto/deploying-an-office-solution.md)
