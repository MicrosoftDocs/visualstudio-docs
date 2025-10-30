---
title: "Choosing a ClickOnce Update Strategy"
description: Discover how a ClickOnce application supports automatic updates and review update strategy options, including checking on startup or through a user interface.
ms.date: "01/27/2023"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "application updates, ClickOnce"
  - "updates, ClickOnce"
  - "ClickOnce deployment, update strategies"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# Choose a ClickOnce update strategy

ClickOnce can provide automatic application updates. A ClickOnce application periodically reads its deployment manifest file to see whether updates to the application are available. If available, the new version of the application is downloaded and run. For efficiency, only those files that have changed are downloaded.

 When designing a ClickOnce application, you have to determine which strategy the application will use to check for available updates. There are three basic strategies that you can use: checking for updates on application startup, checking for updates after application startup (running in a background thread), or providing a user interface for updates.

 In addition, you can determine how often the application will check for updates, and you can make updates required.

> [!NOTE]
> Application updates require network connectivity. If a network connection is not present, the application will run without checking for updates, regardless of the update strategy that you choose.

> [!NOTE]
> In .NET Framework 2.0 and .NET Framework 3.0, any time your application checks for updates, before or after startup, or by using the \<xref:System.Deployment.Application> APIs, you must set `deploymentProvider` in the deployment manifest. The `deploymentProvider` element corresponds in Visual Studio to the **Update location** field on the **Updates** dialog box of the **Publish** tab. This rule is relaxed in .NET Framework 3.5. For more information, see [Deploying ClickOnce Applications For Testing and Production Servers without Resigning](../deployment/deploying-clickonce-applications-for-testing-and-production-without-resigning.md).

## Check for updates after application startup

 By using this strategy, the application will attempt to locate and read the deployment manifest file in the background while the application is running. If an update is available, the next time that the user runs the application, they will be prompted to download and install the update.

 This strategy works best for low-bandwidth network connections or for larger applications that might require lengthy downloads.

 To enable this update strategy, click **After the application starts** in the **Choose when the application should check for updates** section of the **Application Updates** dialog box. Then specify an update interval in the section **Specify how frequently the application should check for updates**.

 This is the same as changing the **Update** element in the deployment manifest as follows:

```xml
<!-- When to check for updates -->
<subscription>
   <update>
      <expiration maximumAge="6" unit="hours" />
   </update>
</subscription>
```

## Check for updates before application startup

 The default strategy is to try to locate and read the deployment manifest file before the application starts. By using this strategy, the application will attempt to locate and read the deployment manifest file every time that the user starts the application. If an update is not available, the existing version of the application will be started. If a required update is available, it will be downloaded and started. If an update is available but not required, the user is given a choice whether to upgrade or start the existing version.

 This strategy works best for high-bandwidth network connections; the delay in starting the application may be unacceptably long over low-bandwidth connections.

 To enable this update strategy, click **Before the application starts** in the **Choose when the application should check for updates** section of the **Application Updates** dialog box.

 This is the same as changing the **Update** element in the deployment manifest as follows:

```xml
<!-- When to check for updates -->
<subscription>
   <update>
      <beforeApplicationStartup />
   </update>
</subscription>
```
> [!NOTE]
> For .NET Core 3.1 and .NET 5 and newer applications, checking updates before the application starts is the only update option supported.

## Make updates required

 There may be occasions when you want to require users to run an updated version of your application. For example, you might make a change to an external resource such as a Web service that would prevent the earlier version of your application from working correctly. In this case, you would want to mark your update as required and prevent users from running the earlier version.

> [!NOTE]
> Although you can require updates by using the other update strategies, checking **Before the application starts** is the only way to guarantee that an older version cannot be run. When the mandatory update is detected on startup, the user must either accept the update or close the application.

 To mark an update as required, click **Specify a minimum required version for this application** in the **Application Updates** dialog box, and then specify the publish version (**Major**, **Minor**, **Build**, **Revision**), which specifies the lowest version number of the application that can be installed.

 This is the same as setting the **minimumRequiredVersion** attribute of the **Deployment** element in the deployment manifest; for example:

```xml
<deployment install="true" minimumRequiredVersion="1.0.0.0">
```

## Specify update intervals

 You can also specify how often the application checks for updates. To do this, specify that the application check for updates after startup as described in "Checking for Updates After Application Startup" earlier in this topic.

 To specify the update interval, set the **Specify how frequently the application should check for updates** properties in the **Application Updates** dialog box.

 This is the same as setting the **maximumAge** and **unit** attributes of the **Update** element in the deployment manifest.

 For example, you may want to check each time the application runs, or one time a week, or one time a month. If a network connection is not present at the specified time, the update check is performed the next time that the application runs.

 [!INCLUDE[ndptecclick](../deployment/includes/dotnet-feature-unsupported.md)]

## Provide a user interface for updates

 When using this strategy, the application developer provides a user interface that enables the user to choose when or how often the application will check for updates. For example, you might provide a "Check for Updates Now" command, or an "Update Settings" dialog box that has choices for different update intervals. The ClickOnce deployment APIs provide a framework for programming your own update user interface. For more information, see the <xref:System.Deployment.Application> namespace.

 [!INCLUDE[ndptecclick](../deployment/includes/dotnet-support-application-deployment-api.md)]

 If your application uses deployment APIs to control its own update logic, you should block update checking as described in "Blocking Update Checking" in the following section.

 This strategy works best when you need different update strategies for different users.

## Block update checking

 It is also possible to prevent your application from ever checking for updates. For example, you might have a simple application that will never be updated, but you want to take advantage of the ease of installation provide by ClickOnce deployment.

 You should also block update checking if your application uses deployment APIs to perform its own updates; see "Provide a user interface for updates" earlier in this topic.

 To block update checking, clear the **The application should check for updates** check box in the Application Updates Dialog Box.

 You can also block update checking by removing the `<Subscription>` tag from the deployment manifest.

## Permission elevation and updates

 If a new version of a ClickOnce application requires a higher level of trust to run than the previous version, ClickOnce will prompt the user, asking them if they want the application to be granted this higher level of trust. If the user declines to grant the higher trust level, the update will not install. ClickOnce will prompt the user to install the application again when it is next restarted. If the user declines to grant the higher level of trust at this point, and the update is not marked as required, the old version of the application will run. However, if the update is required, the application will not run again until the user accepts the higher trust level.

 No prompting for trust levels will occur if you use Trusted Application Deployment. For more information, see [Trusted application deployment overview](../deployment/trusted-application-deployment-overview.md).

## Related content

- <xref:System.Deployment.Application>
- [ClickOnce security and deployment](../deployment/clickonce-security-and-deployment.md)
- [Choose a ClickOnce deployment strategy](../deployment/choosing-a-clickonce-deployment-strategy.md)
- [Secure ClickOnce applications](../deployment/securing-clickonce-applications.md)
- [How ClickOnce performs application updates](../deployment/how-clickonce-performs-application-updates.md)
- [How to: Manage updates for a ClickOnce application](../deployment/how-to-manage-updates-for-a-clickonce-application.md)
