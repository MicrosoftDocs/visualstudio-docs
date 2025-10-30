---
title: "Creating ClickOnce Applications for Others to Deploy"
description: Learn about customer hosted ClickOnce applications developed in .NET Framework 3.5 and previous versions of the .NET Framework.
ms.date: "11/04/2016"
ms.topic: install-set-up-deploy
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "preserved branding information"
  - "useManifestForTrust element"
  - "customer deployments [ClickOnce]"
  - "multiple ClickOnce deployment and branding"
  - "ClickOnce applications, previous .NET Framework versions"
  - "application manifests [ClickOnce]"
  - "<useManifestForTrust> element"
  - "manifests [ClickOnce]"
  - "trust applications, ClickOnce"
  - "ClickOnce applications, deployed by others"
  - "ClickOnce applications, previous .NET Framework"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# Create ClickOnce applications for others to deploy

Not all developers who are creating ClickOnce deployments plan to deploy the applications themselves. Many of them just package their application by using ClickOnce and then hand the files off to a customer, such as a large corporation. The customer becomes the one responsible for hosting the application on its network. This topic discusses some of the problems inherent in such deployments in versions of the .NET Framework prior to version 3.5. It then describes a new solution provided by using the new "use manifest for trust" feature in the .NET Framework 3.5. Finally, it concludes with recommended strategies for creating ClickOnce deployments for customers who are still using older versions of the .NET Framework.

## Issues involved in creating deployments for customers
 Several issues occur when you plan to supply a deployment to a customer. The first issue concerns code signing. In order to be deployed across a network, the deployment manifest and application manifest of a ClickOnce deployment must both be signed with a digital certificate. This raises the question of whether to use the developer's certificate or the customer's certificate when signing the manifests.

 The question of which certificate to use is critical, as a ClickOnce application's identity is based on the digital signature of the deployment manifest. If the developer signs the deployment manifest, it could lead to conflicts if the customer is a large company, and more than one division of the company deploys a customized version of the application.

 For example, say that Adventure Works has a finance department and a human resources department. Both departments license a ClickOnce application from Microsoft Corporation that generates reports from data stored in a SQL database. Microsoft supplies each department with a version of the application that is customized for their data. If the applications are signed with the same Authenticode certificate, a user who tries to use both applications would encounter an error, as ClickOnce would regard the second application as being identical to the first. In this case, the customer could experience unpredictable and unwanted side effects that include the loss of any data stored locally by the application.

 An additional problem related to code signing is the `deploymentProvider` element in the deployment manifest, which tells ClickOnce where to look for application updates. This element must be added to the deployment manifest prior to signing it. If this element is added afterward, the deployment manifest must be re-signed.

### Require the customer to sign the deployment manifest
 One solution to this problem of non-unique deployments is to have the developer sign the application manifest, and the customer sign the deployment manifest. While this approach works, it introduces other issues. Since an Authenticode certificate must remain a protected asset, the customer cannot just give the certificate to the developer to sign the deployment. While the customer can sign the deployment manifest themselves by using tools freely available with the .NET Framework SDK, this may require more technical knowledge than the customer is willing or able to provide. In such cases, the developer usually creates an application, Web site, or other mechanism through which the customer can submit their version of the application for signing.

### The impact of customer signing on ClickOnce application security
 Even if the developer and the customer agree that the customer should sign the application manifest, this raises other issues that surround the application's identity, especially as it applies to trusted application deployment. (For more information about this feature, see [Trusted application deployment overview](../deployment/trusted-application-deployment-overview.md).) Say that Adventure Works wants to configure its client computers so that any application provided to them by Microsoft Corporation runs with full trust. If Adventure Works signs the deployment manifest, then ClickOnce will use Adventure Work's security signature to determine the trust level of the application.

## Create customer deployments by using application manifest for trust
 ClickOnce in the .NET Framework 3.5 contains a new feature that gives developers and customers a new solution to the scenario of how the manifests should be signed. The ClickOnce application manifest supports a new element named `<useManifestForTrust>` that enables a developer to signify that the digital signature of the application manifest is what should be used for making trust decisions. The developer uses ClickOnce packaging tools—such as *Mage.exe*, *MageUI.exe*, and Visual Studio—to include this element in the application manifest, as well as to embed both their Publisher name and the name of the application in the manifest.

 When using `<useManifestForTrust>`, the deployment manifest does not have to be signed with an Authenticode certificate issued by a certification authority. Instead, it can be signed with what is known as a self-signed certificate. A self-signed certificate is generated by either the customer or the developer by using standard .NET Framework SDK tools, and then applied to the deployment manifest by using the standard ClickOnce deployment tools. For more information, see [MakeCert](/windows/desktop/SecCrypto/makecert).

 Using a self-signed certificate for the deployment manifest presents several advantages. By eliminating the need for the customer to obtain or create their own Authenticode certificate, `<useManifestForTrust>` simplifies deployment for the customer, while allowing the developer to maintain their own branding identity on the application. The result is a set of signed deployments that are more secure and have unique application identities. This eliminates the potential conflict that may occur from deploying the same application to multiple customers.

 For step-by-step information about how to create a ClickOnce deployment with `<useManifestForTrust>` enabled, see [Walkthrough: Manually deploy a ClickOnce application that does not require re-signing and that preserves branding information](../deployment/walkthrough-manually-deploying-a-clickonce-app-no-re-signing-required.md).

### How application manifest for trust works at run time
 To get a better understanding of how using the application manifest for trust works at run time, consider the following example. A ClickOnce application that targets the .NET Framework 3.5 is created by Microsoft. The application manifest uses the `<useManifestForTrust>` element and is signed by Microsoft. Adventure Works signs the deployment manifest by using a self-signed certificate. Adventure Works clients are configured to trust any application signed by Microsoft.

 When a user clicks a link to the deployment manifest, ClickOnce installs the application on the user's computer. The certificate and deployment information identify the application uniquely to ClickOnce on the client computer. If the user tries to install the same application again from a different location, ClickOnce can use this identity to determine that the application already exists on the client.

 Next, ClickOnce examines the Authenticode certificate that is used to sign the application manifest, which determines the level of trust that ClickOnce will grant. Since Adventure Works has configured its clients to trust any application signed by Microsoft, this ClickOnce application is granted full trust. For more information, see [Trusted application deployment overview](../deployment/trusted-application-deployment-overview.md).

## Create customer deployments for earlier versions
 What if a developer is deploying ClickOnce applications to customers who are using older versions of the .NET Framework? The following sections summarize several recommended solutions, together with the benefits and drawbacks of each.

### Sign deployments on behalf of customer
 One possible deployment strategy is for the developer to create a mechanism to sign deployments on behalf of their customers, by using the customer's own private key. This prevents the developer from having to manage private keys or multiple deployment packages. The developer just provides the same deployment to each customer. It is up to the customer to customize it for their environment by using the signing service.

 One drawback to this method is the time and expense that are required to implement it. While such a service can be built by using the tools provided in the .NET Framework SDK, it will add more development time to the product life cycle.

 As noted earlier in this topic, another drawback is that each customer's version of the application will have the same application identity, which could lead to conflicts. If this is a concern, the developer can change the Name field that is used when generating the deployment manifest to give each application a unique name. This will create a separate identity for each version of the application, and eliminate any potential identity conflicts. This field corresponds to the `-Name` argument for Mage.exe, and to the **Name** field on the **Name** tab in MageUI.exe.

 For example, say that the developer has created an application named Application1. Instead of creating a single deployment with the Name field set to Application1, the developer can create several deployments with a customer-specific variation on this name, such as Application1-CustomerA, Application1-CustomerB, and so on.

### Deploy using a setup package
 A second possible deployment strategy is to generate a Microsoft Setup project to perform the initial deployment of the ClickOnce application. This can be provided in one of several different formats: as an MSI deployment, as a setup executable (.EXE), or as a cabinet (.cab) file together with a batch script.

 Using this technique, the developer would provide the customer a deployment that includes the application files, the application manifest, and a deployment manifest that serves as a template. The customer would run the setup program, which would prompt them for a deployment URL (the server or file share location from which users will install the ClickOnce application), as well as a digital certificate. The setup application may also choose to prompt for additional ClickOnce configuration options, such as update check interval. Once this information is gathered, the setup program would generate the real deployment manifest, sign it, and publish the ClickOnce application to the designated server location.

 There are three ways that the customer can sign the deployment manifest in this situation:

1. The customer can use a valid certificate issued by a certification authority (CA).

2. As a variation on this approach, the customer can choose to sign their deployment manifest with a self-signed certificate. The drawback to this is that it will cause the application to display the words "Unknown Publisher" when the user is asked whether to install it. However, the benefit is that it prevents smaller customers from having to spend the time and money required for a certificate issued by a certification authority.

3. Finally, the developer can include their own self-signed certificate in the setup package. This introduces the potential problems with application identity discussed earlier in this topic.

   The drawback to the setup deployment project method is the time and expense required to build a custom deployment application.

### Have customer generate deployment manifest
 A third possible deployment strategy is to hand off only the application files and application manifest to the customer. In this scenario, the customer is responsible for using the .NET Framework SDK to generate and sign the deployment manifest.

 The drawback of this method is that it requires the customer to install the .NET Framework SDK tools, and to have a developer or system administrator who is skilled at using them. Some customers may demand a solution that requires little or no technical effort on their part.

## Related content
- [Deploy ClickOnce applications for testing and production servers without resigning](../deployment/deploying-clickonce-applications-for-testing-and-production-without-resigning.md)
- [Walkthrough: Manually deploying a ClickOnce application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md)
- [Walkthrough: Manually deploying a ClickOnce application that does not require re-signing and that preserves branding information](../deployment/walkthrough-manually-deploying-a-clickonce-app-no-re-signing-required.md)
