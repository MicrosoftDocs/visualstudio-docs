---
title: "Improving the Performance of a VSTO Add-in | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Improving the Performance of a VSTO Add-in
  You can give your users a better experience by optimizing VSTO Add-ins that you create for Office applications so that they quickly start up, shut down, open items, and perform other tasks. If your VSTO Add-in is for Outlook, you can also reduce the chance that your VSTO Add-in will be disabled because of poor performance. You can increase the performance of your VSTO Add-in by implementing the following strategies:  
  
-   [Load VSTO Add-ins on demand](#Load).  
  
-   [Publish Office solutions by using Windows Installer](#Publish).  
  
-   [Bypass ribbon reflection](#Bypass).  
  
-   [Perform expensive operations in a separate execution thread](#Perform).  
  
 For more information about how to optimize an Outlook VSTO Add-in, see [Performance criteria for keeping VSTO Add-ins enabled](http://go.microsoft.com/fwlink/?LinkID=266503).  
  
##  <a name="Load"></a> Load VSTO Add-ins on demand  
 You can configure a VSTO Add-in to load only under the following circumstances:  
  
-   The first time that the user starts the application after the VSTO Add-in is installed.  
  
-   The first time that the user interacts with the VSTO Add-in after starting the application any subsequent time.  
  
 For example, your VSTO Add-in might populate a worksheet with data when the user chooses a custom button that's labeled **Get My Data**. The application must load your VSTO Add-in at least one time so that the **Get My Data** button can appear in the ribbon. However, the VSTO Add-in doesn't load again when the user starts the application the next time. The VSTO Add-in loads only when the user chooses the **Get My Data** button.  
  
#### To configure a ClickOnce solution to load VSTO Add-ins on demand  
  
1.  In **Solution Explorer**, choose the project node.  
  
2.  On the menu bar, choose **View**, **Property Pages**.  
  
3.  On the **Publish** tab, choose the **Options** button.  
  
4.  In the **Publish Options** dialog box, choose the **Office Settings** list item, choose the **Load on Demand** option, and then choose the **OK** button.  
  
#### To configure a Windows Installer solution to load VSTO Add-ins on demand  
  
1.  In the registry, set the `LoadBehavior` entry of the *Root*\Software\Microsoft\Office\\*ApplicationName*\Addins\\*Add-in ID* key to **0x10**.  
  
     For more information, see [Registry Entries for VSTO Add-ins](../vsto/registry-entries-for-vsto-add-ins.md).  
  
#### To configure a solution to load VSTO Add-ins on demand while you debug the solution  
  
1.  Create a script that sets the `LoadBehavior` entry of the *Root*\Software\Microsoft\Office\\*ApplicationName*\Addins\\*Add-in ID* key to **0x10**.  
  
     The following code shows an example of this script.  
  
    ```  
    [HKEY_CURRENT_USER\Software\Microsoft\Office\Excel\Addins\MyAddIn]  
    "Description"="MyAddIn"  
    "FriendlyName"="MyAddIn"  
    "LoadBehavior"=dword:00000010  
    "Manifest"="c:\\Temp\\MyAddIn\\bin\\Debug\\MyAddIn.vsto|vstolocal"  
  
    ```  
  
2.  Create a post-build event that updates the registry by using the script.  
  
     The following code shows an example of a command string that you might add to a post-build event.  
  
    ```  
    regedit /s "$(SolutionDir)$(SolutionName).reg"  
  
    ```  
  
     For information about how to create post-build event in a C# project, see [How to: Specify Build Events &#40;C&#35;&#41;](/visualstudio/ide/how-to-specify-build-events-csharp).  
  
     For information about how to create a post-build event in a Visual Basic project, see [How to: Specify Build Events &#40;Visual Basic&#41;](/visualstudio/ide/how-to-specify-build-events-visual-basic).  
  
##  <a name="Publish"></a> Publish Office Solutions by Using Windows Installer  
 If you publish your solution by using Windows Installer, the Visual Studio 2010 Tools for Office Runtime bypasses the following steps when the VSTO Add-in loads.  
  
-   Validating the manifest schema.  
  
-   Automatically checking for updates.  
  
-   Validating the digital signatures of the deployment manifests.  
  
    > [!NOTE]  
    >  This approach isn't necessary if you deploy your VSTO Add-in to a secure location on the users' computers.  
  
 For more information, see [Deploying an Office Solution by Using Windows Installer](../vsto/deploying-an-office-solution-by-using-windows-installer.md).  
  
##  <a name="Bypass"></a> Bypass Ribbon Reflection  
 If you build a solution by using [!INCLUDE[vs_dev11_long](../sharepoint/includes/vs-dev11-long-md.md)], ensure that your users have installed the most recent version of the Visual Studio 2010 Tools for Office Runtime when you deploy the solution. Older versions of that runtime reflected into solution assemblies to locate ribbon customizations. This process can cause the VSTO Add-in to load more slowly.  
  
 As an alternative, you can prevent any version of the Visual Studio 2010 Tools for Office Runtime from using reflection to identify ribbon customizations. To follow this strategy, override the `CreateRibbonExtensibility` method, and explicitly return ribbon objects. If your VSTO Add-in doesn't contain any ribbon customizations, return `null` inside of the method.  
  
 The following example returns a ribbon object based on the value of a field.  
  
 [!code-vb[Trin_Ribbon_Choose_Ribbon#1](../vsto/codesnippet/VisualBasic/trin_ribbon_choose_ribbon_4/ThisWorkbook.vb#1)]
 [!code-csharp[Trin_Ribbon_Choose_Ribbon#1](../vsto/codesnippet/CSharp/trin_ribbon_choose_ribbon_4/ThisWorkbook.cs#1)]  
  
##  <a name="Perform"></a> Perform Expensive Operations in a Separate Execution Thread  
 Consider performing time-consuming tasks (such as long running tasks, database connections, or other sorts of network calls) in a separate thread. For more information, see [Threading Support in Office](../vsto/threading-support-in-office.md).  
  
> [!NOTE]  
>  All code that calls into the Office object model must execute in the main thread.  
  
## See Also  
 [Demand-Loading VSTO Add-ins](http://blogs.msdn.com/b/andreww/archive/2008/07/14/demand-loading-vsto-add-ins.aspx)   
 [Delay-loading the CLR in Office Add-ins](http://blogs.msdn.com/b/andreww/archive/2008/04/19/delay-loading-the-clr-in-office-add-ins.aspx)   
 [VSTO Performance: Delay Loading and You (Stephen Peters)](http://blogs.msdn.com/b/vsto/archive/2010/01/07/vsto-performance-delay-loading-and-you.aspx)   
 [Performance Improvements Coming Soon to a Service Pack Near You (Stephen Peters)](http://blogs.msdn.com/b/vsto/archive/2010/11/30/performance-improvements-coming-soon-to-a-service-pack-near-you-stephen-peters.aspx)   
 [VSTO Performance: Ribbon Reflection (Stephen Peters)](http://blogs.msdn.com/b/vsto/archive/2010/06/03/vsto-performance-ribbon-reflection.aspx)  
  
  