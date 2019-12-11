---
title: "How to: Create and Run an Unattended Installation | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-install"
ms.topic: conceptual
helpviewer_keywords:
  - "installing Visual Studio, unattended"
  - "unattended installation, Visual Studio"
ms.assetid: 3867b5dc-ed34-4ee2-be32-a42e7e320517
caps.latest.revision: 44
author: TerryGLee
ms.author: tglee
manager: jillfra
---
# How to: Create and Run an Unattended Installation of Visual Studio
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can run the installation application for [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] as an unattended (that is, customized silent) installation over an intranet instead of from media such as DVDs. This topic describes how to prepare [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] for this type of installation from a network share.

## Creating a Network Image
 First, create a network image of the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] media.

#### To create a network image

1. Create a folder on the server (for example, *Drive*:\IDEinstall\\).

2. Download the installer from [My.VisualStudio.com](https://my.visualstudio.com/downloads?q=visual%20studio%20enterprise%202015), and then run *Product*.exe /Layout *Drive*:\IDEinstall\

3. Share the IDEinstall folder on the network, and then set the appropriate security settings.

     The network path of the installation application for [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] resembles \\\\*ServerName*\IDEinstall\\*Product*.exe.

    > [!NOTE]
    > Installation may fail if any path and file name combination exceeds 260 characters. The maximum length of a path in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] is 221 characters.  The local path name should not exceed 70 characters, and the network path name should not exceed 39 characters.

     Installation may also fail if the folder names in the path include embedded spaces (for example, "\\\\*ServerName*\IDE install" or \\\\*ServerName*\Visual Studio\\).

## Deploying Visual Studio in unattended mode
 To deploy [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] in unattended mode, you must modify the AdminDeployment.xml file. To do this, you must first create the AdminDeployment.xml file by using the `/CreateAdminFile` *\<file location>* command-line parameter. Then, you can use this file to either push a deployment of Visual Studio to your network or pull it into an installation if you put that file in the *Drive*:\IDEinstall\packages directory. The AdminDeployment.xml file is not unique to an operating system, architecture, edition of Visual Studio, or operating-system language.

> [!CAUTION]
> Sometimes, items listed as selected in the AdminDeployment.xml file do not get installed. To resolve this issue, place the items marked “Selected="yes"” at the **end** of the AdminDeployment.xml file.
>
> If you don’t want to install the optional dependencies of an item, then you must select the parent first and then deselect the optional dependencies after the parent, as shown in the following screenshot:
>
> ![Installation items at the end of the AdminDeployment.xml file](../install/media/vs2015-install-endoffileadmindeploy.PNG "vs2015_Install_EndOfFileAdminDeploy")
>
> Another way to do this is to simply omit the optional children of a parent—in other words, do not include any “Selected=”no”” items—but you still must place all the “Selected=”yes”” items at the end of the AdminDeployment.xml file.

> [!IMPORTANT]
> During installation, the computer may automatically restart one or more times. After it restarts, you must log back in with the same user account with which you were logged on to perform the installation before the computer restarted. You can avoid automatic restarts by installing the prerequisite components before you run an unattended installation. For more information, see the section entitled "Avoid Restart During Setup" in the [Visual Studio Administrator Guide](../install/visual-studio-administrator-guide.md).

 The AdminDeployment file schema contains the following elements:

|Element|Attribute|Values|Description|
|-------------|---------------|------------|-----------------|
|BundleCustomizations|TargetDir|*Path*|Behaves the same as overriding the path in the user interface of the installation application. This element is ignored if Visual Studio is already installed.|
|BundleCustomizations|NoWeb|yes&#124;default|If the value of this element is yes, the installation application never attempts to go to the web during the setup action.|
|SelectableItemCustomization|Hidden|Yes&#124;No|If the value of this element is Yes, hides a Selectable item in the customization tree.|
|SelectableItemCustomization|Selected|Yes&#124;No|Selects or clears a selectable item in the customization tree.|
|BundleCustomizations|Feed|Path|Location of the feed that the user wants to use.  This feed is used for subsequent modify operations on the machine (“Default” by default).|
|BundleCustomizations|SuppressRefreshPrompt|yes&#124;default|Will prevent the user from being prompted to refresh setup if there is a newer one available.|
|BundleCustomizations|NoRefresh|yes&#124;default|Won’t refresh Setup if there is a newer one available.|
|BundleCustomizations|NoCacheOnlyMode|yes&#124;default|Prevents pre-population of the package cache.|

> [!WARNING]
> The installation application will respect the Selected state of a SelectableItem even if it is hidden. For example, if you want to always install a selectable item, you can mark it as hidden and selected.

#### To create an unattended installation of Visual Studio

1. In *Drive*:\IDEinstall\AdminDeployment.xml file, change the value of the NoWeb attribute of the BundleCustomizations element from "default" to "yes" as the following example shows:

     Change `<BundleCustomizations TargetDir="default" NoWeb="default"/>` to `<BundleCustomizations TargetDir="default" NoWeb="yes"/>`

2. Change the SelectableItemCustomization attribute as needed for optional components, and then save the file.

## Running Unattended Setup
 You can run unattended setup either by automatically running the installation application for Visual Studio on client computers or by allowing users to run the application themselves using settings that you define.

#### To run an unattended installation on a client computer

- Open the **Start** menu, choose **Run**, and then enter \\\\*ServerName*\IDEinstall\vs_*Product*.exe /adminfile *PathOfTheAdmindeployment.xmlFile*<em>AdditionalParametersAsNeeded</em>

   For example, you can specify the following command line: `\\server1\IDEinstall\vs_enterprise.exe /adminfile \\server1\ IDEinstall\AdminDeployment.xml /quiet /norestart`

#### To enable clients to manually install Visual Studio with pre-defined settings

1. Copy the customized AdminDeployment.xml file to a network share that is read-only (for example, \\\\*ServerName*\IDEinstall\packages\AdminDeployment.xml).

2. Enable users to install from that share.

## Maintaining an Installation
 If you open **Control Panel** and rerun the installation application, you can modify features of Visual Studio, uninstall programming languages, and repair or uninstall Visual Studio.

> [!NOTE]
> You must have administrative credentials on the local computer to use maintenance mode.

#### To maintain an installation on a client computer

- Open **Control Panel**, and then choose **Programs and Features**.

- Choose [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], and then choose **Change**.

#### To change AdminDeployment settings on a client computer after Visual Studio has been installed

1. Update AdminDeployment.xml as needed.

2. Open the **Start** menu, and then choose **Run**.

3. Enter the following text: \\\\*ServerName*\IDEinstall\vs_*Product*.exe /AdminFile PathToAdmindeployment.xml File

    AdditionalParametersAsNeeded

    For example, you can specify the following command line: `\\server1\IDEinstall\vs_enterprise.exe /adminfile \\server1\IDEinstall\AdminDeployment.xml /quiet /norestart`

   Repair is the default parameter after Visual Studio is installed. If you repair Visual Studio with an updated /AdminFile, you will override the current Admin Deployment Settings with those that the updated AdminDeployment.xml file invokes.

## Updating an installation
 Microsoft has released several Updates to Visual Studio 2015. This section explains how to update your unattended installation image of Visual Studio 2015 so that it includes the updates.

#### To update an unattended installation of Visual Studio

1. Locate the Product.exe file in the existing network image, right-click it, and then click **Properties**.

2. Click the **Details** tab, and then make note of the **Product version** property.

    ![Example of the Properties dialog box in an unattended installation of Visual Studio](../install/media/unattended-install-properties-dialog-box.PNG "Unattended Install - Properties Dialog Box")

3. ###### If the product version is 14.0.24720.0 or 14.0.24720.1, follow these steps:
   1. Run *Product.exe* /Layout *Drive:*\IDEinstall on a machine that has Internet access. (For example, run: `vs_enterprise.exe /Layout d:\IDEinstall`.)

   2. After the /Layout is complete, copy the new image to a new location.

   3. Create and modify the AdminDeployment.xml file. To do this,  use the `/CreateAdminFile`*\<file location>* command-line parameter. (For more information, see the "Deploying Visual Studio in unattended mode" section of this article.)

   4. On the client machine, run the following  command to update the copy of Visual Studio that you previously installed: "\\\\*server1*\IDEinstall_Updated_1\\*Product.exe* /adminfile \\\server1\ IDEinstall_Updated_1\AdminDeployment.xml /quiet /norestart".

        For example, run: `\\server1\IDEinstall_Updated_1\vs_enterprise.exe /adminfile \\server1\IDEinstall_Updated_1\AdminDeployment.xml /quiet /norestart`
5. ###### For other product version values, follow these steps:
   1. Run *Product.exe* /Layout *Drive:*\IDEinstall on a machine that has Internet access. (For example, run `vs-enterprise.exe /Layout d:\IDEinstall`.)

   2. After the /Layout is complete, copy the new image to a new location. (Or, you can override the existing network image instead.)

   3. Create and then modify the AdminDeployment.xml file. To do this,  use the `/CreateAdminFile`*\<file location>* command-line parameter. (For more information, see the "Deploying Visual Studio in unattended mode" section of this article.)

   4. If you copy the image to a new location, you must run the following command on the client machine to update the copy of Visual Studio that you previously installed:  "\\\\*server1*\IDEinstall_Updated_1\\*Product.exe* /adminfile \\\server1\ IDEinstall_Updated_1\AdminDeployment.xml /quiet /norestart".

        For example, run: `\\server1\IDEinstall_Updated_1\vs_enterprise.exe /adminfile \\server1\IDEinstall_Updated_1\AdminDeployment.xml /quiet /norestart`

   5. If you override the existing network image, you can run the command as listed in the previous step, or you can do the following:
       1. Open **Control Panel**, and then choose **Programs and Features**.

       2. Choose **Visual Studio**, and then choose **Change**.

       3. After Visual Studio starts in maintenance mode, click **Modify**.

       4. The latest Update should appear on the Features page. Select the other features that you want to install, click **Next**, and then click **Update** to install both the update and the new features.

## Registering the product
 After installation is complete, you can register your copy of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] from within [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].

#### To register

1. Open the **Help** menu, and then choose **Register Product**.

2. Enter the product key.

     (For more information, see the [How to: Locate the Visual Studio Product Key](../install/how-to-locate-the-visual-studio-product-key.md) and the [How to: Automatically apply product keys when deploying Visual Studio](../install/how-to-automatically-apply-product-keys-when-deploying-visual-studio.md) topics.)

## See Also
 [Install Visual Studio](../install/install-visual-studio-2015.md)