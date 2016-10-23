---
title: "Installing Visual Studio 2015"
ms.custom: na
ms.date: 2016-08-26
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-install
ms.tgt_pltfrm: na
ms.topic: get-started-article
ms.assetid: da049020-cfda-40d7-8ff4-7492772b620f
caps.latest.revision: 171
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Installing Visual Studio 2015
This page includes detailed information to help you with installing Visual Studio, our integrated suite of productivity tools for developers. We've also included links to get you quickly to information about [features](https://www.visualstudio.com/news/vs2015-vs.aspx), [editions](http://go.microsoft.com/fwlink/?LinkID=242142), [system requirements](https://www.visualstudio.com/products/visual-studio-2015-compatibility-vs), [downloads](http://go.microsoft.com/fwlink/?LinkId=517106), and more.  
  
 (To view installation information about previous versions of Visual Studio, click the "Other Versions" link at the top of this page. And, to view installation information about the next version of Visual Studio, see our [Installing Visual Studio '15' Preview 4](../Topic/Installing%20Visual%20Studio%20'15'%20Preview%204.md) page.)  
  
## Quick Links  
 Before we dig in to the details, here's a list of our most frequently requested links.  
  
|![Learn more about features](../VS_Installing/media/Features.png "Features")|  
|----------------------------------------------------------------------------------|  
|**Features**: To learn  more about new or updated features in Visual Studio 2015, see the release notes for [RTM](https://www.visualstudio.com/news/vs2015-vs), [Update 1](https://www.visualstudio.com/news/vs2015-update1-vs), [Update 2](https://www.visualstudio.com/news/vs2015-update2-vs), and [Update 3](https://www.visualstudio.com/news/releasenotes/vs2015-update3-vs).|  
|**SKUs**: To find out what's available in each edition of Visual Studio 2015, see our [Compare Visual Studio Offerings](http://go.microsoft.com/fwlink/?LinkID=242142) page.|  
|**System Requirements**: To view the system requirements for each edition of Visual Studio 2015, see the [Visual Studio 2015 Compatibility](https://www.visualstudio.com/products/visual-studio-2015-compatibility-vs) page.|  
|**Downloads**: To install Visual Studio, you can download the web installer from the [Visual Studio Downloads](http://go.microsoft.com/fwlink/?LinkId=517106) page, or you can download a product executable file from the  [My.VisualStudio.com](https://my.visualstudio.com/downloads?q=visual%20studio%20enterprise%202015) page (subscription required), or use the installation media from the boxed product.|  
|**Product Keys**: To locate your product key, see the [How to: Locate the Visual Studio Product Key](../VS_Installing/How-to--Locate-the-Visual-Studio-Product-Key.md) topic.|  
|**Licensing**: To find out about licensing options for both individuals or enterprise customers, see  the [Visual Studio and MSDN Licensing](https://www.microsoft.com/download/details.aspx?id=13350) white paper.|  
  
##  <a name="custom"></a> Default vs. Custom Setup  
 When you install Visual Studio 2015, you can  include or exclude components that you'd use on a daily basis. This means that a Default installation will often be smaller and install faster than a Custom installation. It also means that many components that were installed by default in previous versions now are considered Custom components that you must explicitly select in this version.  
  
 ![Visual Studio 2015 Setup Dialog](../VS_Installing/media/VS2015_Setup_screen.png "VS2015_Setup_screen")  
  
 Custom components include Visual C++, Visual F#, SQL Server Data Tools, Cross-platform mobile tools and SDKs, and third-party SDKs and extensions. You can install any of the custom components at a later time if you don't select them during the initial setup.  
  
> [!NOTE]
>  A Custom installation automatically includes the components that are in a Default installation.  
  
 The complete list of Custom components is as follows:  
  
|Feature Sets|Components|  
|------------------|----------------|  
|**Updates**|Visual Studio 2015 Update 3|  
|**Programming Languages**|Visual C++<br /><br /> Visual F#<br /><br /> Python Tools for Visual Studio|  
|**Windows and Web Development**|ClickOnce Publishing Tools<br /><br /> LightSwitch<br /><br /> Microsoft Office Developer Tools<br /><br /> Microsoft SQL Server Data Tools<br /><br /> Microsoft Web Developer Tools<br /><br /> PowerShell Tools for Visual Studio [3rd Party]<br /><br /> Silverlight Development Kit<br /><br /> Universal Windows App Development Tools<br /><br /> Windows 10 Tools and SDKs<br /><br /> Windows 8.1 and Windows Phone 8.0/8.1 Tools<br /><br /> Windows 8.1 Tools and SDKs|  
|**Cross Platform Mobile Development**|C#/.NET (Xamarin)<br /><br /> HTML/JavaScript (Apache Cordova)<br /><br /> Visual C++ Mobile Development for iOS / Android<br /><br /> Clang with Microsoft CodeGen|  
|**Common Tools and Software Development Kits**|Android Native Development Kit [3rd Party]<br /><br /> Android SDK [3rd Party]<br /><br /> Android SDK Setup APIs [3rd Party]<br /><br /> Apache Ant [3rd Party]<br /><br /> Java SE Development Kit [3rd Party]<br /><br /> Joyent Node.js [3rd Party]|  
|**Common Tools**|Git for Windows [3rd Party]<br /><br /> GitHub Extension for Visual Studio [3rd Party]<br /><br /> Visual Studio Extensibility Tools|  
  
##  <a name="installing"></a> Installing Visual Studio  
 You can install Visual Studio by using installation media (DVDs), by using your Visual Studio subscription service from the [My.VisualStudio.com](https://my.visualstudio.com/downloads?q=visual%20studio%20enterprise%202015) website, by downloading  a web installer from the [Visual Studio Downloads](http://go.microsoft.com/fwlink/?LinkId=517106) website, or by creating an offline installation layout (see the [Creating an Offline Installation of Visual Studio](../VS_Installing/Creating-an-Offline-Installation-of-Visual-Studio.md) topic for more details).  
  
> [!IMPORTANT]
>  You need administrator credentials to install Visual Studio. However, you don't need them to use Visual Studio after you install it.  
  
 Your local administrator account must have the following privileges enabled to install everything in Visual Studio.  
  
|Local Policy Object Display Name|User Right|  
|--------------------------------------|----------------|  
|Backup Files and directories|SeBackupPrivilege|  
|Debug programs|SeDebugPrivilege|  
|Manage auditing and security log|SeSecurityPrivilege|  
  
 For more information on this local administrator account requirement, see the Knowledge Base article, [SQL Server installation fails if the Setup account does not have certain user rights](https://support.microsoft.com/en-us/kb/2000257).  
  
###  <a name="BKMK_Media"></a> Using installation media  
 To install Visual Studio, in the root directory on the Visual Studio installation media, run the installation file for the edition you want:  
  
|Edition|Installation File|  
|-------------|-----------------------|  
|Visual Studio Enterprise|vs_enterprise.exe|  
|Visual Studio Professional|vs_professional.exe|  
|Visual Studio Community|vs_community.exe|  
  
###  <a name="BKMK_Website"></a> Downloading from the product website  
 Visit the [Visual Studio Downloads](http://go.microsoft.com/fwlink/?LinkId=517106) page, and select the edition of Visual Studio that you want.  
  
### Downloading from your subscription service  
 Visit  the [My.VisualStudio.com](https://my.visualstudio.com/downloads?q=visual%20studio%20enterprise%202015) page, and select the edition of Visual Studio that you want.  
  
###  <a name="BKMK_Offline"></a> Creating an offline installation  layout  
 If you do not have the Visual Studio installation media, or you do not have a Visual Studio subscription,  or you do not want to install Visual Studio by using the web installer, you can perform a "disconnected" installation by creating what is known as an offline installation layout. For more information, see the [Creating an Offline Installation of Visual Studio](../VS_Installing/Creating-an-Offline-Installation-of-Visual-Studio.md) topic.  
  
##  <a name="enterprise"></a> Deploying Visual Studio in an Enterprise  
 For information about how to deploy Visual Studio over a network, see the [Visual Studio Administrator Guide](../VS_Installing/Visual-Studio-Administrator-Guide.md).  
  
###  <a name="BKMK_Virtualized"></a> Installing Visual Studio in a virtualized environment  
 **Video Issues with Hyper-V**  
  
 If you run Windows Server 2008 R2 with Hyper-V enabled and an accelerated graphics adapter, you may experience system slowdowns.  
  
 For more information, see the following page on the Microsoft website: [Video performance may decrease when a Windows Server 2008 or Windows Server 2008 R2 based computer has the Hyper-V role enabled and an accelerated display adapter installed](http://go.microsoft.com/fwlink/?LinkID=231084).  
  
 **Emulating Devices with Hyper-V**  
  
 When you install Visual Studio 2015 on real hardware without virtualization, you can choose features that enable emulation of Windows and Android devices using Hyper-V. When you install into Hyper-V, you will not be able to emulate the Windows or Android devices. This is because the emulators are themselves virtual machines, and you cannot currently host a VM inside another VM. The workaround is to have real Windows or Android devices to which you can directly deploy and debug your application.  
  
##  <a name="optionalComponents"></a> Installing optional components  
 If you want to install components that you might not have selected during your original installation, use the following procedure.  
  
#### To install optional components  
  
1.  In **Control Panel**, on the **Programs and Features** page, choose the product edition to which you want to add one or more components, and then choose **Change**.  
  
2.  In the Setup wizard, choose **Modify**, and then choose the components that you want to install.  
  
3.  Choose **Next**, and then follow the remaining instructions.  
  
##  <a name="helpContent"></a> Installing offline Help content  
 After you install Visual Studio, you can download additional Help content so that it will be available offline.  
  
#### To install or uninstall Help content  
  
1.  On the Visual Studio menu bar, choose **Help**, **Add and Remove Help Content**.  
  
2.  On the **Manage Content** tab of the **Microsoft Help Viewer**, select the installation source for your Help content.  
  
3.  If you're looking for a specific Help collection, enter the name or a keyword in the **Search** text box, and then press **Enter**.  
  
4.  Next to the name of the Help collection you want, choose the **Add** or **Remove** link.  
  
5.  Click the **Update** button.  
  
 For more information about how to install or deploy offline Help, see the [Help Viewer Administrator Guide](../VS_IDE/Help-Viewer-Administrator-Guide.md).  
  
##  <a name="serviceReleases"></a> Checking for Service Releases and Product Updates  
 Because not all extensions are compatible, Visual Studio doesn't automatically upgrade extensions when you upgrade from previous versions. You must reinstall the extensions from the [Visual Studio Gallery](http://go.microsoft.com/fwlink/?LinkId=178891) or from the software publisher.  
  
#### To automatically check for service releases  
  
1.  On the menu bar, choose **Tools**, **Options**.  
  
2.  In the **Options** dialog box, expand **Environment**, and then select **Extensions and Updates**. Make sure the **Automatically check for updates** check box is selected, and then choose **OK**.  
  
## Registering Visual Studio  
  
1.  On the menu bar, choose **Help**, **About**.  
  
     The **About** dialog box shows the product identification number (PID). You'll need the PID and Windows Account credentials (such as a Hotmail or Outlook.com email address and password) to register the product.  
  
2.  On the menu bar, choose **Help**, **Register Product**.  
  
##  <a name="repair"></a> Repairing Visual Studio  
  
#### To repair Visual Studio  
  
1.  In **Control Panel**, on the **Programs and Features** page, choose the product edition that you want to repair, and then choose **Change**.  
  
2.  In the Setup wizard, choose **Repair**, choose **Next**, and then follow the remaining instructions.  
  
#### To repair Visual Studio in silent or passive modes (that is, to repair from source)  
  
1.  On the computer where Visual Studio is installed, open the Windows command prompt.  
  
2.  Enter the following parameters:  
  
     *DVDRoot* \\<Installation File\> </quiet&#124;/passive> [/norestart]/Repair  
  
##  <a name="troubleshooting"></a> Troubleshooting an installation  
 Use these resources to get help for setup and installation issues:  
  
-   [Visual Studio Setup and Installation](http://go.microsoft.com/fwlink/?LinkID=151190) forum. Review questions and answers from others in the Visual Studio community. If you don't find what you need, ask your own questions.  
  
-   [Microsoft Support for Visual Studio](http://go.microsoft.com/fwlink/?LinkID=251019) website. Read knowledge base (KB) articles and learn how to contact Microsoft Support for information about issues with Visual Studio installation.  
  
-   For releases of Visual Studio 2015, you can report your issue by using the Connect site at [https://connect.microsoft.com/visualstudio](https://connect.microsoft.com/visualstudio).  
  
     It’s best if your issue includes the installation logs. You can prepare your logs for the issue report by using the Microsoft Visual Studio and .NET Framework Log Collection Tool, as described in the following steps.  
  
    1.  Download the installation diagnostic tool from [http://aka.ms/vscollect](http://aka.ms/vscollect)  
  
    2.  From an elevated command prompt, run the collect.exe program.  
  
    3.  After the collect.exe program completes, fetch the vslogs.cab file from your Temp directory and upload that into the issue report.  
  
##  <a name="relatedTopics"></a> Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Installing Visual Studio Versions Side-by-Side](../VS_Installing/Installing-Visual-Studio-Versions-Side-by-Side.md)|Provides information about how to install multiple versions of Visual Studio on the same computer.|  
|[Using Command-Line Parameters to Install Visual Studio](../VS_Installing/Using-Command-Line-Parameters-to-Install-Visual-Studio.md)|Lists the command-line parameters that you can use when you install Visual Studio from a command prompt.|  
|[Uninstalling Visual Studio](../VS_Installing/Uninstalling-Visual-Studio.md)|Describes how to uninstall Visual Studio.|  
|[Visual Studio Administrator Guide](../VS_Installing/Visual-Studio-Administrator-Guide.md)|Provides information about deployment options for Visual Studio.|  
|[Installing Multiple Language Versions of Visual Studio](../VS_Installing/Installing-Multiple-Language-Versions-of-Visual-Studio.md)|Provides information about how to install different language versions of Visual Studio.|  
|[How to: Locate the Visual Studio Product Key](../VS_Installing/How-to--Locate-the-Visual-Studio-Product-Key.md)|Describes how to locate the product key for your installation of Visual Studio.|  
|[The Visual Studio Image Library](../VS_IDE/The-Visual-Studio-Image-Library.md)|Provides information about how to install graphics that you can use in Visual Studio applications.|  
|[Get Started Developing with Visual Studio](../VS_IDE/Get-Started-Developing-with-Visual-Studio.md)|Provides information and links that can help you use Visual Studio more effectively.|  
  
## See Also  
 [Signing in to Visual Studio](../VS_IDE/Signing-in-to-Visual-Studio.md)