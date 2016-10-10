---
title: "User Permissions and Visual Studio"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 70485ed7-6342-41bf-8250-7a6826e21b98
caps.latest.revision: 14
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# User Permissions and Visual Studio
For reasons of security you should run Visual Studio as a normal user whenever possible.  
  
> [!WARNING]
>  You should also make sure not to compile, launch, or debug any Visual Studio solution that does not come from a trusted person or a trusted location.  
  
 You can do nearly everything in the Visual Studio IDE as a normal user, but, you need administrator permissions to complete the following tasks:  
  
|Area|Task|For more information|  
|----------|----------|--------------------------|  
|Installation|Installing Visual Studio.|[Installing Visual Studio 2015](../VS_Installing/Installing-Visual-Studio-2015.md)|  
||Upgrading from a trial edition of Visual Studio.|[How to: Upgrade from a Trial Edition of Visual Studio](../VS_Installing/How-to--Upgrade-from-a-Trial-Edition-of-Visual-Studio.md)|  
||Installing, updating, or removing local Help content.|[Install and Manage Local Content](../VS_IDE/Install-and-Manage-Local-Content.md)|  
|Application types|Developing solutions for SharePoint 2010.|[Requirements for Developing SharePoint Solutions](../Topic/Requirements%20for%20Developing%20SharePoint%20Solutions.md)|  
||Acquiring a developer license for Windows Store.|[Get a developer license (Windows Store apps)](http://go.microsoft.com/fwlink/?LinkID=241313)|  
|Toolbox|Adding classic COM controls to the **Toolbox**.|[Using the Toolbox](../VS_IDE/Using-the-Toolbox.md)|  
|Add-ins|Installing and using add-ins that were written by using classic COM in the IDE.|[Creating Add-ins and Wizards](../Topic/Creating%20Add-ins%20and%20Wizards.md)|  
|Building|Using post-build events that register a component.|[Understanding Custom Build Steps and Build Events](../Topic/Understanding%20Custom%20Build%20Steps%20and%20Build%20Events.md)|  
||Including a registration step when you build C++ projects.|[Understanding Custom Build Steps and Build Events](../Topic/Understanding%20Custom%20Build%20Steps%20and%20Build%20Events.md)|  
|Debugging|Debugging applications that run with elevated permissions.|[Debugger Settings and Preparation](../VS_debugger/Debugger-Settings-and-Preparation.md)|  
||Debugging applications that a run under a different user account, such as ASP.NET websites.|[Debugging ASP.NET and AJAX Applications](../VS_debugger/Debugging-ASP.NET-and-AJAX-Applications.md)|  
||Debugging in Zone for XAML Browser Applications (XBAP).|[WPF Host (PresentationHost.exe)](../Topic/WPF%20Host%20\(PresentationHost.exe\).md)|  
||Using the emulator to debug cloud service projects for Microsoft Azure.|[Debugging a Cloud Service in Visual Studio](http://go.microsoft.com/fwlink/?LinkId=266725)|  
||Configuring a firewall for remote debugging.|[Set Up the Remote Tools on the Device](../Topic/Set%20Up%20the%20Remote%20Tools%20on%20the%20Device.md)|  
|Performance tools|Profiling an application.|[Beginners Guide to Performance Profiling](../VS_IDE/Beginners-Guide-to-Performance-Profiling.md)|  
|Deployment|Deploying a web application to Internet Information Services (IIS) on a local computer.|[Deploying an ASP.NET Web Application to a Hosting Provider using Visual Studio or Visual Web Developer: Deploying to IIS as a Test Environment](http://go.microsoft.com/fwlink/?LinkId=266478)|  
|Providing feedback to Microsoft|Changing how you participate in the Visual Studio Customer Experience Program.|[How to: Send Feedback](../VS_not_in_toc/How-to--Send-Feedback-About-Visual-Studio.md)|  
  
## Running Visual Studio as an Administrator  
 You can launch Visual Studio with administrative permissions each time you start the IDE, or you can modify the application shortcut to always run with administrative permissions. For more information, see Windows Help.  
  
#### To run Visual Studio with administrative permissions on Windows 8, Windows 8.1, Windows Server 2012, or Windows Server 2012 R2  
  
1.  On the **Start** screen, type **Visual Studio**. You should see the version or versions of Visual Studio you have installed.  
  
2.  Select the version of Visual Studio you want to start, and then bring up the shortcut menu (it appears at the bottom of the screen). Choose **Run as administrator**.  
  
     When Visual Studio starts, **(Administrator)** appears after the product name in the title bar.  
  
#### To run Visual Studio with administrative permissions on Windows 7 or Windows Server 2008 R2  
  
1.  On the **Start** menu, choose **All Programs**.  
  
2.  In the **Microsoft Visual Studio** *Version* folder select  **Visual Studio** *Version* open the shortcut menu, and then choose **Run as administrator**.  
  
     When Visual Studio starts, **(Administrator)** appears after the product name in the title bar.  
  
## See Also  
 [Porting, Migrating, and Upgrading Visual Studio Projects](../VS_Porting/Porting--Migrating--and-Upgrading-Visual-Studio-Projects.md)   
 [Installing Visual Studio 2015](../VS_Installing/Installing-Visual-Studio-2015.md)