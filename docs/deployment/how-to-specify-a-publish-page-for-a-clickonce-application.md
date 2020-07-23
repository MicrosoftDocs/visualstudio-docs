---
title: How to - Specify a Publish Page for a ClickOnce Application | Microsoft Docs
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - deploying applications [ClickOnce], specifying publish page
  - Publish Page property
  - publishing, ClickOnce
  - ClickOnce deployment, specifying publish page
ms.assetid: 9d70eebb-bdee-4b42-8e7e-7a07e199bdf7
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload: 
  - multiple
---
# How to: Specify a publish page for a ClickOnce application
When publishing a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application, a default Web page (publish.htm) is generated and published along with the application. This page contains the name of the application, a link to install the application and/or any prerequisites, and a link to a Help topic describing [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)]. The **Publish Page** property for your project allows you to specify a name for the Web page for your [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application.

 Once the publish page has been specified, the next time you publish, it will be copied to the publish location; it will not be overwritten if you publish again. If you wish to customize the appearance of the page, you can do so without worrying about losing your changes. For more information, see [How to: Customize the ClickOnce default Web page](../deployment/how-to-customize-the-default-web-page-for-a-clickonce-application.md).

 The **Publish Page** property can be set in the **Publish Options** dialog box, accessible from the **Publish** pane of the **Project Designer**.

### To specify a custom Web page for a ClickOnce application

1. With a project selected in **Solution Explorer**, on the **Project** menu click **Properties**.

2. Select the **Publish** pane.

3. Click the **Options** button to open the **Publish Options** dialog box.

4. Click **Deployment**.

5. In the **Publish Options** dialog box, make sure that the **Open deployment web page after publish** check box is selected (it should be selected by default).

6. In the **Deployment web page** box, enter the name for your Web page, and then click **OK**.

### To prevent the publish page from launching each time you publish

1. With a project selected in **Solution Explorer**, on the **Project** menu click **Properties**.

2. Select the **Publish** pane.

3. Click the **Options** button to open the **Publish Options** dialog box.

4. Click **Deployment**.

5. In the **Publish Options** dialog box, clear the **Open deployment web page after publish** check box.

## See also
- [Publish ClickOnce applications](../deployment/publishing-clickonce-applications.md)
- [How to: Publish a ClickOnce application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md)
- [How to: Customize the ClickOnce default Web page](../deployment/how-to-customize-the-default-web-page-for-a-clickonce-application.md)