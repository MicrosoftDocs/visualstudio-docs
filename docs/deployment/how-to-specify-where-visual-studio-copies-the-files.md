---
title: Specify ClickOnce Publish properties
description: Learn how to set the Publish properties for a ClickOnce application, such as the location where the application files and manifest are put, and the installation URL.
ms.date: 06/26/2024
ms.topic: how-to
dev_langs: 
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - ClickOnce deployment, specifying location
  - Publish Location property
  - ClickOnce deployment, set publish version
  - ClickOnce deployment, auto increment the publish version
  - ClickOnce deployment, set offline-or-online-install-mode
  - deploying applications [ClickOnce], specifying publish page
  - Publish Page property
  - ClickOnce deployment, specifying publish page
  - Publish.htm Web page
  - ClickOnce deployment, default Web page
  - Support URL property
  - product support, specifying URL for ClickOnce applications
  - Web pages, ClickOnce
  - Web sites, creating for ClickOnce support
  - ClickOnce deployment, specifying support Web page address
  - ClickOnce deployment, prerequisites
  - ClickOnce deployment, support URLs
  - Publish language property
  - ClickOnce deployment, changing publish language
  - Start menu resource name
  - Start menu name
  - ClickOnce deployment, Start menu name
  - ClickOnce deployment, AutoStart
  - ClickOnce deployment, installation on CD or DVD
  - deploying applications [ClickOnce], installation on CD or DVD
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---

# Specify ClickOnce Publish properties

You can configure ClickOnce Publish properties on the **Publish** page of the **Project Designer**, or by using the Publish Wizard. In this article, you learn how to specify properties such as the publishing location, the installation URL, online or offline install mode, and the publish version.

[!INCLUDE[ndptecclick](../deployment/includes/dotnet-publish-tool.md)]

## Specify a publishing location

When you publish an application by using ClickOnce, the `Publish Location` property specifies the location where the application files and manifest are put. This can be a file path or the path to an FTP server.

 You can specify the `Publish Location` property on the **Publish** page of the **Project Designer**, or by using the Publish Wizard. For more information, see [How to: Publish a ClickOnce Application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md).

> [!NOTE]
> When you install more than one version of an application by using ClickOnce, the installation moves earlier versions of the application into a folder named Archive, in the publish location that you specify. Archiving earlier versions in this manner keeps the installation directory clear of folders from the earlier version.

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. In the **Publish Location** field, enter the publishing location by using one of the following formats:

   - To publish to a file share or disk path, enter the path by using either a UNC path (*\\\Server\ApplicationName*) or a file path (*C:\Deploy\ApplicationName*).

   - To publish to an FTP server, enter the path using the format <em>ftp://ftp.microsoft.com/\<ApplicationName></em>.

     Note that text must be present in the **Publishing Location** box in order for the Browse (**...**) button to work.

## Specify the location where end users will install from

When publishing a ClickOnce application, the location where users go to download and install the application isn't necessarily the location where you initially publish the application. For example, in some organizations a developer might publish an application to a staging server, and then an administrator would move the application to a Web server.

In this case, you can use the `Installation URL` property to specify the Web server where users will go to download the application. This is necessary so that the application manifest knows where to look for updates.

The `Installation URL` property can be set on the **Publish** page of the **Project Designer**.

> [!NOTE]
> The `Installation URL` property can also be set using the **PublishWizard**. For more information, see [How to: Publish a ClickOnce application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md).

### Specify an Installation URL

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. In the Installation URL field, enter the installation location using a fully qualified URL using the format `https://www.contoso.com/ApplicationName`, or a UNC path using the format `\Server\ApplicationName`.

## Specify the ClickOnce offline or online install mode

The `Install Mode` for a ClickOnce application determines whether the application will be available offline or online. When you choose **The application is available online only**, the user must have access to the ClickOnce publishing location (either a Web page or a file share) in order to run the application. When you choose **The application is available offline as well**, the application adds entries to the **Start** menu and the **Add or Remove Programs** dialog box; the user is able to run the application when they aren't connected.

The `Install Mode` can be set on the **Publish** page of the **Project Designer**.

> [!NOTE]
> The `Install Mode` can also be set using the Publish wizard. For more information, see [How to: Publish a ClickOnce application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md).

### Make a ClickOnce application available online only

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. In the **Install Mode and Settings** area, click the **The application is available online only** option button.

### Make a ClickOnce application available online or offline

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. In the **Install Mode and Settings** area, click the **The application is available offline as well** option button.

     When installed, the application adds entries to the **Start** menu and to **Add or Remove Programs** in Control Panel.

## Set the ClickOnce publish version

The ClickOnce `Publish Version` property determines whether or not the application that you're publishing will be treated as an update. Each time version is incremented, the application will be published as an update.

The `Publish Version` property can be set on the **Publish** page of the **Project Designer**.

> [!NOTE]
> There is a project option that will automatically increment the `Publish Version` property each time the application is published; this option is enabled by default. For more information, see [Automatically Increment the ClickOnce Publish Version](../deployment/how-to-specify-where-visual-studio-copies-the-files.md#automatically-increment-the-clickonce-publish-version).

### Change the publish version

1. With a project selected in **Solution Explorer**, on the **Project** menu click **Properties**.

2. Click the **Publish** tab.

3. In **Publish Version** field, increment the **Major**, **Minor**, **Build**, or **Revision** version numbers.

    > [!NOTE]
    > You should never decrement a version number; doing so could cause unpredictable update behavior.

## Automatically increment the ClickOnce publish version

When publishing a ClickOnce application, changing the `Publish Version` property causes the application to be published as an update. By default, Visual Studio automatically increments the `Revision` number of the `Publish Version` each time you publish the application.

You can disable this behavior on the **Publish** page of the **Project Designer**.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Reset settings](../ide/personalizing-the-visual-studio-ide.md#reset-all-settings).

### Disable automatically incrementing the publish version

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. In the **Publish Version** section, clear the **Automatically increment revision with each release** check box.

## Specify a publish page for a ClickOnce application

When publishing a ClickOnce application, a default Web page (publish.htm) is generated and published along with the application. This page contains the name of the application, a link to install the application and/or any prerequisites, and a link to a Help topic describing ClickOnce. The **Publish Page** property for your project allows you to specify a name for the Web page for your ClickOnce application.

Once the publish page has been specified, the next time you publish, it will be copied to the publish location; it will not be overwritten if you publish again. If you wish to customize the appearance of the page, you can do so without worrying about losing your changes. For more information, see [Customize the ClickOnce default Web page](#customize-the-default-web-page-for-a-clickonce-application).

The **Publish Page** property can be set in the **Publish Options** dialog box, accessible from the **Publish** pane of the **Project Designer**.

To specify a custom Web page for a ClickOnce application:

1. With a project selected in **Solution Explorer**, on the **Project** menu click **Properties**.

2. Select the **Publish** pane.

3. Click the **Options** button to open the **Publish Options** dialog box.

4. Click **Deployment**.

5. In the **Publish Options** dialog box, make sure that the **Open deployment web page after publish** check box is selected (it should be selected by default).

6. In the **Deployment web page** box, enter the name for your Web page, and then click **OK**.

To prevent the publish page from launching each time you publish:

1. With a project selected in **Solution Explorer**, on the **Project** menu click **Properties**.

2. Select the **Publish** pane.

3. Click the **Options** button to open the **Publish Options** dialog box.

4. Click **Deployment**.

5. In the **Publish Options** dialog box, clear the **Open deployment web page after publish** check box.

## Customize the default Web page for a ClickOnce application

When publishing a ClickOnce application to the Web, a Web page is automatically generated and published along with the application. The default page contains the name of the application and links to install the application, install prerequisites, or access help on MSDN.

> [!NOTE]
> The actual links that you see on the page depend on the computer where the page is being viewed and what prerequisites you're including.

 The default name for the Web page is *Publish.htm*; you can change the name in the **Project Designer**. For more information, see [Specify a publish page for a ClickOnce application](#specify-a-publish-page-for-a-clickonce-application).

 The *Publish.htm* Web page is published only if a newer version is detected.

> [!NOTE]
> Changes that you make to your **Publish** settings will not affect the *Publish.htm* page, with one exception: if you add or remove prerequisites after initially publishing, the list of prerequisites will no longer be accurate. You'll need to edit the text for the prerequisite link to reflect the changes.

To customize the publish Web page:

1. Publish your ClickOnce application to a Web location. For more information, see [How to: Publish a ClickOnce application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md).

2. On the Web server, open the *Publish.htm* file in Visual Web Designer or another HTML editor.

3. Customize the page as desired and save it.

4. Optional. To prevent Visual Studio from overwriting your customized publish Web page, uncheck **Automatically generate deployment Web page after every publish** in the **Publish Options** dialog box.

## Specify a link for Technical Support

When publishing a ClickOnce application, the **Support URL** property identifies a Web page or file share where users can go to get information about the application. This property is optional; if provided, the URL will be displayed in the application's entry **Add or Remove Programs** dialog box.

 The **Support URL** property can be set on the **Publish** page of the **Project Designer**.

To specify a support URL:

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. Click the **Options** button to open the **Publish Options** dialog box.

4. Click **Description**.

5. In the **Support URL** field, enter a fully qualified path to a Web site, Web page, or UNC share.

## Specify a support URL for individual prerequisites in a ClickOnce deployment

A ClickOnce deployment can test for a number of prerequisites that must be available on the client computer for the ClickOnce application to run. These dependencies include the required minimum version of the .NET Framework, the version of the operating system, and any assemblies that must be preinstalled in the global assembly cache (GAC). ClickOnce, however, can't install any of these prerequisites itself; if a prerequisite isn't found, it simply halts installation and displays a dialog box explaining why the installation failed.

There are two methods for installing prerequisites. You can install them using a bootstrapper application. Alternatively, you can specify a support URL for individual prerequisites, which is displayed to users on the dialog box if the prerequisite isn't found. The page referenced by that URL can contain links to instructions for installing the required prerequisite. If an application doesn't specify a support URL for an individual prerequisite, ClickOnce displays the support URL specified in the deployment manifest for the application as a whole, if it is defined.

While Visual Studio, *Mage.exe*, and *MageUI.exe* can all be used to generate ClickOnce deployments, none of these tools directly support specifying a support URL for individual prerequisites. This document describes how to modify your deployment's application manifest and deployment manifest to include these support URLs.

[!INCLUDE[ndptecclick](../deployment/includes/dotnet-publish-tool.md)]

### Specify a support URL for an individual prerequisite

1. Open the application manifest (the *.manifest* file) for the ClickOnce application in a text editor.

2. For an operating system prerequisite, add the `supportUrl` attribute to the `dependentOS` element:

   ```xml
    <dependency>
       <dependentOS supportUrl="http://www.adatum.com/MyApplication/wrongOSFound.htm">
         <osVersionInfo>
           <os majorVersion="5" minorVersion="1" buildNumber="2600" servicePackMajor="0" servicePackMinor="0" />
         </osVersionInfo>
       </dependentOS>
     </dependency>
   ```

3. For a prerequisite for a certain version of the common language runtime, add the `supportUrl` attribute to the `dependentAssembly` entry that specifies the common language runtime dependency:

   ```xml
     <dependency>
       <dependentAssembly dependencyType="preRequisite" allowDelayedBinding="true" supportUrl=" http://www.adatum.com/MyApplication/wrongClrVersionFound.htm">
         <assemblyIdentity name="Microsoft.Windows.CommonLanguageRuntime" version="4.0.30319.0" />
       </dependentAssembly>
     </dependency>
   ```

4. For a prerequisite for an assembly that must be preinstalled in the global assembly cache, set the `supportUrl` for the `dependentAssembly` element that specifies the required assembly:

   ```xml
     <dependency>
       <dependentAssembly dependencyType="preRequisite" allowDelayedBinding="true" supportUrl=" http://www.adatum.com/MyApplication/missingSampleGACAssembly.htm">
         <assemblyIdentity name="SampleGACAssembly" version="5.0.0.0" publicKeyToken="04529dfb5da245c5" processorArchitecture="msil" language="neutral" />
       </dependentAssembly>
     </dependency>
   ```

5. Optional. For applications that target the .NET Framework 4, open the deployment manifest (the *.application* file) for the ClickOnce application in a text editor.

6. For a .NET Framework 4 prerequisite, add the `supportUrl` attribute to the `compatibleFrameworks` element:

   ```xml
   <compatibleFrameworks  xmlns="urn:schemas-microsoft-com:clickonce.v2" supportUrl="http://adatum.com/MyApplication/CompatibleFrameworks.htm">
     <framework targetVersion="4.0" profile="Client" supportedRuntime="4.0.30319" />
     <framework targetVersion="4.0" profile="Full" supportedRuntime="4.0.30319" />
   </compatibleFrameworks>
   ```

7. Once you have manually altered the application manifest, you must re-sign the application manifest using your digital certificate, then update and re-sign the deployment manifest as well. Use the *Mage.exe* or *MageUI.exe* SDK tools to accomplish this task, as regenerating these files using Visual Studio erases your manual changes. For more information on using Mage.exe to re-sign manifests, see [How to: Re-sign Application and Deployment Manifests](../deployment/how-to-re-sign-application-and-deployment-manifests.md).

### .NET Framework security

The support URL isn't displayed on the dialog box if the application is marked to run in partial trust.

 [!INCLUDE[ndptecclick](../deployment/includes/code-access-security-partial-trust.md)]

## Change the publish language for a ClickOnce application

When publishing a ClickOnce application, the user interface displayed during installation defaults to the language and culture of your development computer. If you're publishing a localized application, you'll need to specify a language and culture to match the localized version. This is determined by the `Publish language` property for your project.

The `Publish language` property can be set in the **Publish Options** dialog box, accessible from the **Publish** page of the **Project Designer**.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Reset settings](../ide/personalizing-the-visual-studio-ide.md#reset-all-settings).

To change the publish language:

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

   [!INCLUDE[ndptecclick](../deployment/includes/dotnet-publish-tool.md)]

3. Click the **Options** button to open the **Publish Options** dialog box.

4. Click **Description**.

5. In the **Publish Options** dialog box, select a language and culture from the **Publish language** drop-down list, and then click **OK**.

## Specify a Start menu name for a ClickOnce application

When a ClickOnce application is installed for both online and offline use, an entry is added to the **Start** menu and the **Add or Remove Programs** list. By default, the display name is the same as the name of the application assembly, but you can change the display name by setting **Product name** in the **Publish Options** dialog box.

 **Product name** will be displayed on the *publish.htm* page; for an installed offline application, it will be the name of the entry in the **Start** menu, and it will also be the name that shows in **Add or Remove Programs**.

 **Publisher name** will appear on the *publish.htm* page above **Product name**, and for an installed offline application, it will also be the name of the folder that contains the application's icon in the **Start** menu.

 The Start menu shortcut or app reference gets created in *%appdata%\Microsoft\Windows\Start Menu\Programs\\<publisher name\>*. The shortcut or app reference has the same name as the product name.

 You can set the **Product name** and **Publisher name** properties in the **Publish Options** dialog box, available on the **Publish** page of the **Project Designer**.

To specify a Start menu name:

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. Click the **Options** button to open the **Publish Options** dialog box.

4. Click **Description**.

5. In the **Publish Options** dialog box, enter the name to display in **Product name**.

6. Optionally, you can enter a publisher name in **Publisher name**.

## Enable AutoStart for CD installations

When deploying a ClickOnce application by means of removable media such as CD-ROM or DVD-ROM, you can enable `AutoStart` so that the ClickOnce application is automatically launched when the media is inserted.

 `AutoStart` can be enabled on the **Publish** page of the **Project Designer**.

To enable AutoStart:

1. With a project selected in **Solution Explorer**, on the **Project** menu click **Properties**.

2. Click the **Publish** tab.

3. Click the **Options** button.

     The **Publish Options** dialog box appears.

4. Click **Deployment**.

5. Select the **For CD installations, automatically start Setup when CD is inserted** check box.

     An *Autorun.inf* file will be copied to the publish location when the application is published.

## Related content

- [Publishing ClickOnce applications](../deployment/publishing-clickonce-applications.md)
- [How to: Publish a ClickOnce application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md)