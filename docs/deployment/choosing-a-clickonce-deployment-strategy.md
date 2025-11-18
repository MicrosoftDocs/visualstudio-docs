---
title: "Choosing a ClickOnce Deployment Strategy"
description: Learn about the strategies for deploying a ClickOnce application and how to choose a strategy depending on the type of application that you are deploying.
ms.date: "01/27/2023"
ms.topic: concept-article
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "ClickOnce deployment, strategies"
  - "deploying applications, ClickOnce"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# Choose a ClickOnce deployment strategy

There are three different strategies for deploying a ClickOnce application; the strategy that you choose depends primarily on the type of application that you are deploying. The three deployment strategies are as follows:

- Install from the Web or a Network Share

- Start the application from the Web or a Network Share

- Install from a CD or DVD

    > [!NOTE]
    > In addition to selecting a deployment strategy, you will also want to select a strategy for providing application updates. For more information, see [Choose a ClickOnce update strategy](../deployment/choosing-a-clickonce-update-strategy.md).

## Install from the Web or a network share

 When you use this strategy, your application is deployed to a Web server or a network file share. When an end user wants to install the application, he or she clicks an icon on a Web page or double-clicks an icon on the file share. The application is then downloaded, installed, and started on the end user's computer. Items are added to the **Start** menu and **Add or Remove Programs** in **Control Panel**.

 Because this strategy depends on network connectivity, it works best for applications that will be deployed to users who have access to a local-area network or a high-speed Internet connection.

 If you deploy the application from the Web, you can pass arguments into the application when it is activated using a URL. For more information, see [How to: Retrieve query string information in an online ClickOnce application](../deployment/how-to-retrieve-query-string-information-in-an-online-clickonce-application.md). You cannot pass arguments into an application that is activated by using any of the other methods described in this document.

 To enable this deployment strategy in Visual Studio, click **From the Web** or **From a UNC path or file share** on the **How Installed** page of the Publish Wizard.

 [!INCLUDE[ndptecclick](../deployment/includes/dotnet-publish-tool.md)]

 This is the default deployment strategy.

## Start the application from the Web or a network share

 This strategy is like the first, except the application behaves like a Web application. When the user clicks a link on a Web page (or double-clicks an icon on the file share), the application is started. When users close the application, it is no longer available on their local computer; nothing is added to the **Start** menu or **Add or Remove Programs** in **Control Panel**.

> [!NOTE]
> Technically, the application is downloaded and installed to an application cache on the local computer, just as a Web application is downloaded to the Web cache. As with the Web cache, the files are eventually scavenged from the application cache. However, the perception of the user is that the application is being run from the Web or file share.

 This strategy works best for applications that are used infrequently—for example, an employee-benefits tool that is typically run only one time each year.

 To enable this deployment strategy in Visual Studio, click **Do not install the application** on the **Install or Run From Web** page of the Publish Wizard.

 To enable this deployment strategy, manually, change the **install** tag in the deployment manifest. (Its value can be **true** or **false**. In *Mage.exe*, use the **Online Only** option in the **Application Type** list.)

## Install from a CD or DVD

 When you use this strategy, your application is deployed to removable media such as a CD-ROM or DVD. As with the previous option, when the user chooses to install the application, it is installed and started, and items are added to the **Start** menu and **Add or Remove Programs** in **Control Panel**.

 This strategy works best for applications that will be deployed to users without persistent network connectivity or with low-bandwidth connections. Because the application is installed from removable media, no network connection is necessary for installation; however, network connectivity is still required for application updates.

 To enable this deployment strategy in Visual Studio, click **From a CD-ROM or DVD-ROM** on the **How Installed** page of the Publish Wizard.

 To enable this deployment strategy manually, change the **deploymentProvider** tag in the deployment manifest. (In Visual Studio, this property is exposed as **Installation URL** on the **Publish** page of the Project Designer. In *Mage.exe* it is **Start Location**.)

## Web browser support

 Applications that target .NET Framework 3.5 and above can be installed using any browser.

## Related content

- [ClickOnce security and deployment](../deployment/clickonce-security-and-deployment.md)
- [Choose a ClickOnce update strategy](../deployment/choosing-a-clickonce-update-strategy.md)
- [How to: Publish a ClickOnce application with the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md)
- [Securing ClickOnce applications](../deployment/securing-clickonce-applications.md)
