---
title: "How to: Specify a Link for Technical Support | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "Support URL property"
  - "product support, specifying URL for ClickOnce applications"
  - "Web pages, ClickOnce"
  - "Web sites, creating for ClickOnce support"
  - "ClickOnce deployment, specifying support Web page address"
  - "customer support, ClickOnce applications"
  - "URLs, ClickOnce applications"
ms.assetid: 500aebee-545e-4831-a78b-b8671a008015
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Specify a link for Technical Support
When publishing a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application, the **Support URL** property identifies a Web page or file share where users can go to get information about the application. This property is optional; if provided, the URL will be displayed in the application's entry **Add or Remove Programs** dialog box.

 The **Support URL** property can be set on the **Publish** page of the **Project Designer**.

### To specify a support URL

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. Click the **Options** button to open the **Publish Options** dialog box.

4. Click **Description**.

5. In the **Support URL** field, enter a fully qualified path to a Web site, Web page, or UNC share.

## See also
- [Publish ClickOnce applications](../deployment/publishing-clickonce-applications.md)
- [How to: Publish a ClickOnce application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md)