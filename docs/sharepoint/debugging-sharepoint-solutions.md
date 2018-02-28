---
title: "Debugging SharePoint Solutions | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VS.SharePointTools.Project.WebConfigModificationDialog"
  - "VS.SharePointTools.Project.DebuggingNotEnabled"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "SharePoint development in Visual Studio, debugging"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Debugging SharePoint Solutions
  You can debug SharePoint solutions by using the [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] debugger. When you start debugging, [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] deploys the project files to the SharePoint server and then opens an instance of the SharePoint site in the Web browser. The following sections explain how to debug SharePoint applications in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].  
  
-   [Enabling Debugging](#EnableDebug)  
  
-   [F5 Debugging and Deployment Process](#Deployment)  
  
-   [SharePoint Project Features](#Features)  
  
-   [Debugging Workflows](#Workflow)  
  
-   [Debugging Feature Event Receivers](#FeatureEvents)  
  
-   [Enabling Enhanced Debugging Information](#EnhancedDebug)  
  
##  <a name="EnableDebug"></a> Enabling Debugging  
 When you first debug a SharePoint solution in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], a dialog box alerts you that the web.config file is not configured to enable debugging. (The web.config file is created when you install SharePoint server. For more information, see [Working with Web.config Files](http://go.microsoft.com/fwlink/?LinkID=149266).) The dialog box gives you the option of either running the project without debugging or modifying the web.config file to enable debugging. If you choose the first option, the project runs normally. If you choose the second option, the web.config file is configured to:  
  
-   Turn on the call stack (`CallStack="true"`)  
  
-   Disable custom errors in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] (`<customErrors mode="Off" />`)  
  
-   Enable compilation debugging (`<compilation debug="true">`)  
  
 The resulting web.config file follows:  
  
```  
<?xml version="1.0" encoding="UTF-8" standalone="yes"?>  
    <configuration>  
        ...  
        <SharePoint>  
            <SafeMode MaxControls="200"  
                CallStack="true"  
                DirectFileDependencies="10"  
                TotalFileDependencies="50"  
                AllowPageLevelTrace="false">  
                ...  
            </SafeMode>  
        ...  
        </SharePoint>  
        <system.web>  
            ...  
            <customErrors mode="Off" />  
            ...  
            <compilation debug="true">  
            ...  
            </compilation>  
            ...  
        </system.web>  
        ...  
    </configuration>  
```  
  
 To reverse the changes and disable debugging, change the following [!INCLUDE[TLA2#tla_xml](../sharepoint/includes/tla2sharptla-xml-md.md)] in the web.config file:  
  
-   Turn off the call stack (`CallStack="false"`)  
  
-   Enable custom errors in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] (`<customErrors mode="On" />`)  
  
-   Disable compilation debugging (`<compilation debug="false">`)  
  
##  <a name="Deployment"></a> F5 Debugging and Deployment Process  
 When you run your SharePoint project in debug mode, the SharePoint deployment process performs the following tasks:  
  
1.  Runs the customizable pre-deployment commands.  
  
2.  Creates a Web solution package (.wsp) file by using [!INCLUDE[vstecmsbuild](../sharepoint/includes/vstecmsbuild-md.md)] commands. The .wsp file includes all of the necessary files and features. For more information, see [Solutions Overview](http://go.microsoft.com/fwlink/?LinkID=128154).  
  
3.  If the SharePoint solution is a farm solution, recycles the [!INCLUDE[TLA2#tla_iis5](../sharepoint/includes/tla2sharptla-iis5-md.md)] application pool for the specified site [!INCLUDE[TLA2#tla_url](../sharepoint/includes/tla2sharptla-url-md.md)]. This step releases files locked by the [!INCLUDE[TLA2#tla_iis5](../sharepoint/includes/tla2sharptla-iis5-md.md)] worker process.  
  
4.  If a previous version of the package already exists, retracts the previous version of the features and files in the .wsp file. This step deactivates the features, uninstalls the solution package, and then deletes the solution package on the SharePoint server.  
  
5.  Installs the current version of the features and files in the .wsp file. This step adds and installs the solution on the SharePoint server.  
  
6.  For workflows, installs the workflow assembly. You can change its location by using the *Assembly Location* property.  
  
7.  Activates the project's feature in SharePoint if the scope is Site or Web. Features in the Farm and WebApplication scopes are not activated.  
  
8.  For workflows, associates the workflow with the SharePoint library, list, or site that you selected in the **SharePoint Customization Wizard**.  
  
    > [!NOTE]  
    >  This association occurs only if you selected **Automatically associate workflow** in the wizard.  
  
9. Runs the customizable post-deployment commands.  
  
10. Attaches the [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] debugger to the [!INCLUDE[sharepointShort](../sharepoint/includes/sharepointshort-md.md)] process (w3wp.exe). If the project type lets you change the *Sandboxed Solution* property and its value is set to **true**, then the debugger attaches to a different process (SPUCWorkerProcess.exe). For more information, see [Sandboxed Solution Considerations](../sharepoint/sandboxed-solution-considerations.md).  
  
11. Starts the JavaScript debugger if the SharePoint solution is a farm solution.  
  
12. Displays the appropriate library, list, or site page in the Web browser.  
  
 [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] displays a status message in the Output window after each task is completed. If a task cannot be completed, [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] displays an error message in the Error List window.  
  
##  <a name="Features"></a> SharePoint Project Features  
 A feature is a portable and modular unit of functionality that simplifies modification of sites by using site definitions. It is also a package of [!INCLUDE[sharepointShort](../sharepoint/includes/sharepointshort-md.md)] (WSS) elements that can be activated for a specific scope and that helps users accomplish a particular goal or task. Templates are deployed as features.  
  
 When you run a project in debug mode, the deployment process creates a folder in the *feature* directory at %COMMONPROGRAMFILES%\Microsoft Shared\web server extensions\14\TEMPLATE\FEATURES. Feature names have the format *project name*_Feature*x*, such as TestProject_Feature1.  
  
 The solution's folder in the feature directory contains a *feature definition* file and a *workflow definition* file. The feature definition file (Feature.xml) describes the files in the project's Feature.The project definition file (Elements.xml) describes the project template. Elements.xml can be found in **Solution Explorer**, but Feature.xml is generated when the solution package is created. For more information about these files, see [SharePoint Project and Project Item Templates](../sharepoint/sharepoint-project-and-project-item-templates.md).  
  
##  <a name="Workflow"></a> Debugging Workflows  
 When you debug workflow projects, [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] adds the workflow template (depending on its type) to a library or to a list. You can then start the workflow template manually or by adding or updating an item. You can then use [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] to debug the workflow.  
  
> [!NOTE]  
>  If you add references to other assemblies, make sure that that those assemblies are installed in the global assembly cache ([!INCLUDE[TLA2#tla_gac](../sharepoint/includes/tla2sharptla-gac-md.md)]). Otherwise, the workflow solution will fail. For information about how to install assemblies, see [Manually start a workflow on a document or item](http://go.microsoft.com/fwlink/?LinkID=79938).  
  
 However, the deployment process does not start the workflow. You must start the workflow from the SharePoint Web site. You can also start the workflow by using a client application such as Microsoft Office Word 2010, or by using separate server-side code. Use one of the approaches specified in the **SharePoint Customization Wizard**.  
  
 For example, if you specified that the workflow can be started manually, start the workflow directly from the item in the library or list. For more information about how to start a workflow manually, see [Manually start a workflow on a document item](http://go.microsoft.com/fwlink/?LinkID=79938).  
  
##  <a name="FeatureEvents"></a> Debugging Feature Event Receivers  
 By default, when you run a [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] SharePoint application, its features are automatically activated for you on the SharePoint server. However, this causes problems when you debug feature event receivers, because when a feature is activated by [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], it runs in a different process than the debugger. This means that some debugging functionality, such as breakpoints, will not work correctly.  
  
 To disable the automatic activation of the feature in SharePoint and allow proper debugging of Feature Event Receivers, set the value of the project's **Active Deployment Configuration** property to **No Activation** before debugging. Then, after you start to debug your SharePoint application in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], manually activate the feature in SharePoint. To activate the feature, open the **Site Actions** menu in SharePoint, choose **Site Settings**, choose the **Manage Site Features** link, and then choose the **Activate** button next to the feature, to continue debugging as normal.  
  
##  <a name="EnhancedDebug"></a> Enabling Enhanced Debugging Information  
 Due to the sometimes complex interactions between the [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] process (devenv.exe), the [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] SharePoint host process (vssphost4.exe), SharePoint, and the WCF layer, diagnosing errors that occur while building, deploying, and so forth can be a challenge. To help you resolve such errors, you can enable enhanced debugging information. To do this, go to the following registry key in the Windows registry:  
  
 [HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\11.0\SharePointTools]  
  
 If the "EnableDiagnostics" **REG_DWORD** value does not already exist, create it manually. Set the "EnableDiagnostics" value to "1."  
  
 Setting this key value to 1 causes stack trace information to appear in the **Output** window whenever project system errors occur while you are running in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. To disable enhanced debugging information, set EnableDiagnostics back to 0, or delete the value.  
  
 For more information about other SharePoint registry keys, see [Debugging Extensions for the SharePoint Tools in Visual Studio](../sharepoint/debugging-extensions-for-the-sharepoint-tools-in-visual-studio.md).  
  
## See Also  
 [Troubleshooting SharePoint Solutions](../sharepoint/troubleshooting-sharepoint-solutions.md)  
  
  