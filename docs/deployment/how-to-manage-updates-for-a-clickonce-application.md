---
title: Manage Updates for a ClickOnce Application | Microsoft Docs
description: Learn about options to check for updates automatically or programmatically for your ClickOnce applications.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords: 
  - Microsoft.VisualStudio.Publish.ClickOnceProvider.Dialog.Update
dev_langs: 
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - ClickOnce deployment, managing applications
  - ClickOnce deployment, updates
  - updating data, ClickOnce
  - application updates
ms.assetid: a3f23f05-e7f1-4620-b23c-2d68f9643684
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
ms.workload: 
  - multiple
---
# How to: Manage updates for a ClickOnce application
[!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] applications can check for updates automatically or programmatically. As a developer, you have lots of flexibility in specifying when and how update checks are performed, whether updates are mandatory, and where the application should check for updates.

 You can configure the application to check for updates automatically before the application starts, or at set intervals after the application starts. In addition you can specify a minimum required version; that is, an update is installed if the user's version is lower than the required version.

 You can configure the application to check for updates programmatically based on an event such as a user request. The procedure "To check for updates programmatically" in this topic shows how you would write code that uses the <xref:System.Deployment.Application.ApplicationDeployment> class to check for updates based on an event.

 You can also deploy your application from one location and update it from another. See the procedure "To specify a different update location."

 For more information, see [Choosing a ClickOnce Update Strategy](../deployment/choosing-a-clickonce-update-strategy.md).

 Update behavior is managed in the **Application Updates** dialog box, available from the **Publish** page of the **Project Designer.**

### To check for updates before the application starts

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. Click the **Updates** button to open the **Application Updates** dialog box.

4. In the **Application Updates** dialog box, make sure that the **The application should check for updates** check box is selected.

5. In the **Choose when the application should check for updates** section, select **Before the application starts**. This ensures that users connected to the network always run the application with the latest updates.

### To check for updates in the background after the application starts

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. Click the **Updates** button to open the **Application Updates** dialog box.

4. In the **Application Updates** dialog box, make sure that the check box **The application should check for updates** is selected.

5. In the **Choose when the application should check for updates section**, select **After the application starts**. The application will start more quickly this way, and then it will check for updates in the background, and only notify the user when an update is available. Once installed, updates will not take effect until the application is restarted.

6. In the **Specify how frequently the application should check for updates** section, select either **Check every time the application runs** (the default) or **Check every** and enter a number and time interval.

### To specify a minimum required version for the application

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. Click the **Updates** button to open the **Application Updates** dialog box.

4. In the **Application Updates** dialog box, make sure that the **The application should check for updates** check box is selected.

5. Select the **Specify a minimum required version for this application** check box, and then enter **Major**, **Minor**, **Build**, and **Revision** numbers for the application.

### To specify a different update location

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. Click the **Updates** button to open the **Application Updates** dialog box.

4. In the **Application Updates** dialog box, make sure that the **The application should check for updates** check box is selected.

5. In the **Update location** field, enter the update location with a fully qualified URL, using the format *http://Hostname/ApplicationName*, or a UNC path using the format *\\\Server\ApplicationName*, or click the **Browse** button to browse for the update location.

### To check for updates programmatically

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. Click the **Updates** button to open the **Application Updates** dialog box.

4. In the **Application Updates** dialog box, make sure that the **The application should check for updates** check box is cleared. (Optionally, you can select this check box to check for updates programmatically and also let the ClickOnce runtime check for updates automatically.)

5. In the **Update location** field, enter the update location with a fully qualified URL, using the format *http://Hostname/ApplicationName*, or a UNC path using the format *\\\Server\ApplicationName*, or click the **Browse** button to browse for the update location. The update location is where the application will look for an updated version of itself.

6. Create a button, menu item, or other user interface item on a Windows Form that users will select to check for updates. From that item's event handler, call a method to check for and install updates. You can find an example of Visual Basic and Visual C# code for such a method in [How to: Check for application updates programmatically using the ClickOnce deployment API](../deployment/how-to-check-for-application-updates-programmatically-using-the-clickonce-deployment-api.md).

7. Build your application.

## See also
- <xref:System.Deployment.Application.ApplicationDeployment>
- [Application updates dialog box](/previous-versions/visualstudio/visual-studio-2010/axw1fa38(v=vs.100))
- [Choose a ClickOnce update strategy](../deployment/choosing-a-clickonce-update-strategy.md)
- [Publish ClickOnce applications](../deployment/publishing-clickonce-applications.md)
- [How to: Publish a ClickOnce application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md)
- [How to: Check for application updates programmatically using the ClickOnce deployment API](../deployment/how-to-check-for-application-updates-programmatically-using-the-clickonce-deployment-api.md)
