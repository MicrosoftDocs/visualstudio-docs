---
title: "Publish Page, Project Designer (Office Development in Visual Studio) | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VST.ProjectProperties.Publish.2007System"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "deploying applications [Office development in Visual Studio]"
  - "publishing, Office solutions"
  - "Property Pages dialog box, Publish [Office development in Visual Studio]"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Publish Page, Project Designer (Office Development in Visual Studio)
  The **Publish** page of the **Project Designer** is used to configure properties for deployment.  
  
 To access this page, select the project in **Solution Explorer**, and then, on the **Project** menu, choose *Projectname* **Properties**. If the **Publish** page is not displayed, choose the **Publish** tab.  
  
> [!NOTE]  
>  You can also set the publishing location in the **Publish Wizard**. For more information, see [How to: Publish an Office Solution by Using ClickOnce](http://msdn.microsoft.com/en-us/2b6c247e-bc04-4ce4-bb64-c4e79bb3d5b8).  
  
## UIElement List  
 **Publishing Folder Location (web site, ftp server, or file path)**  
 Required.  
  
 The publishing folder location is the directory to which Visual Studio copies the solution files such as the manifests, assemblies, and other files from the build. You must have write access to this directory.  
  
 Options include the local computer, a UNC file share, or a HTTP/HTTPS web site. The path can be local (*c:\foldername\publishfolder*), relative (*publish\\*), or a fully qualified location (*\\\servername\foldername* or http://*servername/foldername*).  
  
 By default, the publishing location is *http://localhost/projectname/* if you have IIS installed, or the publish\ directory if you do not have IIS installed.  
  
 **Installation Folder URL**  
 Optional.  
  
 The installation folder URL is the directory from which the end user will install the customization. It is also the path that the solution will use to check for updates. The path can be the same as the publishing folder location, but this is not a requirement.  
  
 Options include the local computer, a UNC file share, or a HTTP/HTTPS web site. The path can be local (*c:\foldername\publishfolder*), relative (*publish\\*), or a fully qualified location (*\\\servername\foldername* or http://*servername/foldername*). All HTTP/HTTPS locations must be created with US-ASCII characters. Unicode characters are not supported.  
  
 If the installation path is set, the customization files must be in that location for users to install the customization. The location should be set only if you know the final deployment location.  
  
 If the installation files are in a location relative to the document or Setup program, such as with the CD option, leave this box blank.  
  
 This value can be assigned later by an administrator. For more information, see [How to: Change the Installation Path of an Office Solution](http://msdn.microsoft.com/en-us/d0eaa07b-2d72-4902-899f-2f9fb165b8fd).  
  
 **Prerequisites**  
 The prerequisites can be included with the Setup program or downloaded on demand during installation.  
  
-   **Download prerequisites from the component vendor's web site**: Use this option to download these prerequisites from Microsoft.  
  
-   **Download prerequisites from the same location as my application**: Use this option to package the prerequisites in your installer. Including the prerequisite files with the Setup program increases the size of the solution.  
  
-   **Download prerequisites from the following location**: Use this option to make the prerequisites available to end users separately as another Setup program on a web page or network share.  
  
 **Updates**  
 The update interval determines how often the solution checks for updates. The default is to check every seven days.  
  
 Checking for updates every time a document-level customization or VSTO Add-in is loaded would keep it updated, but would affect startup performance.  
  
 If you are deploying by using a CD or removable drive, set this to **Never check for updates**.  
  
 **Options (Description)**  
 The publish options for the following properties can be set:  
  
-   Publish language: the locale of the Office solution.  
  
-   Publisher name: the company or developer name as it appears in **Add/Remove Programs** or **Programs and Features**.  
  
-   Product name: the name of the Office solution as it appears in **Add/Remove Programs** or **Programs and Features**.  
  
-   Support URL: the location for end users to contact technical support for the Office solution.  
  
 **Options (Office Settings)**  
 The publish options for the following properties can be set:  
  
-   Solution name: the name of the Office solution as it appears in the Office application.  
  
-   Description: the description of the Office solution as it appears in the Office application.  
  
-   VSTO Add-in Load Behavior.  
  
    -   Load at Startup: specifies that the VSTO Add-in loads when the Office application starts.  
  
    -   Load on Demand: specifies that the VSTO Add-in loads when the application requires it, such as when a user clicks a UI element that uses functionality in the VSTO Add-in.  
  
 **Publish Language**  
 This option sets the language of the Microsoft Software License Terms, and includes the language packs in the list of prerequisites. It does not affect the language of the customization. The language in the Setup program is determined by the installed languages of Visual Studio.  
  
 For more information about how to change the **Publish language**, see [How to: Change the Publish Language for a ClickOnce Application](/visualstudio/deployment/how-to-change-the-publish-language-for-a-clickonce-application).  
  
 **Publish Version**  
 Sets the version number for the customization. When the version number is changed, the application is published as an update. A new folder is created for each version during the build process to prevent overwriting the previously published version. Each part of the publish version (**Major**, **Minor**, **Build**, **Revision**) can contain up to five digits.  
  
 **Automatically increment revision with each release**  
 Optional. When selected (the default), the **Revision** part of the version number is incremented by one every time the customization is published. This causes the customization to be published as an update.  
  
 **Publish Now**  
 Publishes the application using the current settings. Equivalent to the **Finish** button in the **Publish Wizard**.  
  
## See Also  
 [Deploying an Office Solution](../vsto/deploying-an-office-solution.md)   
 [Deploying an Office Solution by Using ClickOnce](../vsto/deploying-an-office-solution-by-using-clickonce.md)   
 [Office Solution Prerequisites for Deployment](http://msdn.microsoft.com/en-us/9f672809-43a3-40a1-9057-397ce3b5126e)  
  
  