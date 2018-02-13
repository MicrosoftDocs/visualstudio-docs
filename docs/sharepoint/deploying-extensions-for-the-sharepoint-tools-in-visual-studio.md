---
title: "Deploying Extensions for the SharePoint Tools in Visual Studio | Microsoft Docs"
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
helpviewer_keywords: 
  - "SharePoint development in Visual Studio, deploying extensions"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Deploying Extensions for the SharePoint Tools in Visual Studio
  To deploy a SharePoint tools extension, create a [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] extension (VSIX) package that contains the extension assembly and any other files that you want to distribute with the extension. A VSIX package is a compressed file that follows the Open Packaging Conventions (OPC) standard. VSIX packages have the .vsix extension.  
  
 After you create a VSIX package, other users can run the .vsix file to install your extension. When a user installs your extension, all of the files are installed to the %UserProfile%\AppData\Local\Microsoft\VisualStudio\11.0\Extensions folder. To deploy the extension, you can upload the VSIX package to the [Visual Studio Gallery](http://go.microsoft.com/fwlink/?LinkID=123847) Web site, or you can distribute the package to your customers by some other means, such as hosting the package on a network share or some other Web site.  
  
 For more information about creating VSIX packages and deploying them to the [Visual Studio Gallery](http://go.microsoft.com/fwlink/?LinkID=123847), see [Shipping Visual Studio Extensions](/visualstudio/extensibility/shipping-visual-studio-extensions).  
  
 You can create a VSIX package by using the **VSIX Project** template in Visual Studio, or you can create a VSIX package manually.  
  
## Using VSIX Projects to Create VSIX Packages  
 You can use the **VSIX Project** template provided by the Visual Studio SDK to create VSIX packages for SharePoint tools extensions. Using a VSIX project provides several benefits over creating a VSIX package manually:  
  
-   Visual Studio automatically generates the VSIX package when you build the project. Tasks such as adding the deployment files to the package and creating the [Content_Types].xml file for the package are done for you.  
  
-   You can configure the VSIX project to include the build output of your extension project and other files, such as project templates and item templates, in the VSIX package.  
  
 For more information about using a VSIX project, see [VSIX Project Template](/visualstudio/extensibility/vsix-project-template).  
  
### Organizing Your Projects  
 By default, VSIX projects only generate VSIX packages, not assemblies. Therefore, you typically do not implement a SharePoint tools extension in a VSIX project. You generally work with at least two projects:  
  
-   A VSIX project.  
  
-   A class library project that implements your extension.  
  
 You might also work with additional projects for certain types of extensions:  
  
-   A class library project that implements any SharePoint commands that are used by your extension. For a walkthrough that demonstrates this scenario, see [Walkthrough: Extending Server Explorer to Display Web Parts](../sharepoint/walkthrough-extending-server-explorer-to-display-web-parts.md).  
  
-   An Item Template or Project Template project that creates an item template or project template, if your extension defines a new type of SharePoint project item. For a walkthrough that demonstrates this scenario, see [Walkthrough: Creating a Custom Action Project Item with an Item Template, Part 1](../sharepoint/walkthrough-creating-a-custom-action-project-item-with-an-item-template-part-1.md).  
  
-   A class library project that implements a custom wizard for an item template or project template, if your extension includes a template. For a walkthrough that demonstrates this scenario, see [Walkthrough: Creating a Custom Action Project Item with an Item Template, Part 2](../sharepoint/walkthrough-creating-a-custom-action-project-item-with-an-item-template-part-2.md).  
  
 If you include all of the projects in the same Visual Studio solution, you can modify the source.extension.vsixmanifest file in the VSIX project to include the build output of the class library projects.  
  
### Editing the VSIX Manifest  
 You must edit the source.extension.vsixmanifest file in the VSIX project to include entries for all the items that you want to include in your extension. When you open the source.extension.vsixmanifest file from its shortcut menu, the file appears in a designer that provides a UI for editing the XML in the file. For more information, see [VSIX Manifest Designer](/visualstudio/extensibility/vsix-manifest-designer).  
  
 You must add entries to the source.extension.vsixmanifest file for the following items:  
  
-   The extension assembly.  
  
-   The assembly that implements any SharePoint commands that are used by your extension.  
  
-   Any project templates or item templates that are associated with your extension.  
  
-   A custom wizard for a template that is associated with your extension.  
  
 The following procedures describe how to add entries to the .vsixmanifest file for each of these items.  
  
##### To include the extension assembly  
  
1.  In the VSIX project, open the shortcut menu for the source.extension.vsixmanifest file, and then choose **Open**.  
  
     The file opens in the designer  
  
2.  On the **Assets** tab of the editor, choose the **New** button.  
  
     The **Add New Asset** dialog box opens.  
  
3.  In the **Type** list, choose **Microsoft.VisualStudio.MefComponent**.  
  
4.  In the **Source** list, perform one of the following steps:  
  
    -   If the extension assembly is built from a project that's in the same solution as the VSIX project, choose **A project in current solution**. In the **Project** list, choose the name of the project.  
  
    -   If the extension assembly is included as a file in your project, choose **File on filesystem**. In the **Path** list, enter the complete path to the extension assembly file, or use the **Browse** button to locate and choose the assembly file.  
  
5.  Choose the **OK** button.  
  
##### To include a SharePoint command assembly  
  
1.  In the VSIX project, open the shortcut menu for the source.extension.vsixmanifest file, and then choose the **Open** button.  
  
     The file opens in the designer.  
  
2.  In the **Assets** section of the editor, choose the **New** button.  
  
     The **Add New Asset** dialog box opens.  
  
3.  In the **Type** box, enter **SharePoint.Commands.v4**.  
  
4.  In the **Source** list, perform one of the following steps:  
  
    -   If the command assembly is built from a project that's in the same solution as the VSIX project, choose **A project in current solution**. In the **Project** list, choose the name of the project.  
  
    -   If the command assembly is included as a file in your project, choose **File on filesystem**. In the **Path** list, enter the complete path to the extension assembly file, or use the **Browse** button to locate and choose the assembly file.  
  
5.  Choose the **OK** button.  
  
##### To include a template that you create  
  
1.  In the VSIX project, open the shortcut menu for the source.extension.vsixmanifest file, and then choose the **Open** button.  
  
     The file opens in the designer.  
  
2.  In the **Assets** section of the editor, choose the **New** button.  
  
     The **Add New Asset** dialog box opens.  
  
3.  In the **Type** list, choose **Microsoft.VisualStudio.ProjectTemplate** or **Microsoft.VisualStudio.ItemTemplate**.  
  
4.  In the **Source** list, choose **A project in current solution**.  
  
5.  In the **Project** list, choose the name of the project, and then choose the **OK** button.  
  
6.  In **Solution Explorer**, open the shortcut menu for your Project Template or Item Template project, and then choose **Unload Project**.  
  
7.  Open the shortcut menu for the project node again, and then choose **Edit***YourTemplateProjectName***.csproj** or **Edit***YourTemplateProjectName***.vbproj**.  
  
8.  Locate the following `VSTemplate` element in the project file.  
  
    ```  
    <VSTemplate Include="YourTemplateName.vstemplate">  
    ```  
  
9. Replace this element with the following XML.  
  
    ```  
    <VSTemplate Include="YourTemplateName.vstemplate">  
      <OutputSubPath>SharePoint\SharePoint14</OutputSubPath>  
    </VSTemplate>  
    ```  
  
     The `OutputSubPath` element specifies additional folders in the path under which the project template is created when you build the project. The folders specified here ensure that the item template will be available only when customers open the **Add New Project** dialog box, expand the **SharePoint** node, and then choose the **2010** node.  
  
10. Save and close the file.  
  
11. In **Solution Explorer**, open the shortcut menu for the Project Template or Item Template project, and then choose **Reload Project**.  
  
##### To include a template that you create manually  
  
1.  In the VSIX project, add a new folder to the project to contain the template.  
  
2.  Under this new folder, create the following subfolders, and then add the template (.zip) file to the *Locale ID* folder.  
  
     *YourTemplateFolder*  
  
     **SharePoint**  
  
     **SharePoint14**  
  
     *Locale ID*  
  
     *YourTemplateName*.zip  
  
     For example, if you have an item template named ContosoCustomAction.zip that supports the English (United States) locale, the full path might be ItemTemplates\SharePoint\SharePoint14\1033\ContosoCustomAction.zip.  
  
3.  In **Solution Explorer**, choose the template file (*YourTemplateName*.zip).  
  
4.  In the **Properties** window, set the **Build Action** property to **Content**.  
  
5.  Open the shortcut menu for the source.extension.vsixmanifest file, and then choose **Open**.  
  
     The file opens in the designer.  
  
6.  In the **Assets** section of the editor, choose the **New** button.  
  
     The **Add New Asset** dialog box opens.  
  
7.  In the **Type** list, choose **Microsoft.VisualStudio.ItemTemplate** or **Microsoft.VisualStudio.ProjectTemplate**.  
  
8.  In the **Source** list, choose **File on filesystem**.  
  
9. In the **Path** field, enter the complete path to the assembly (for example, **ItemTemplates\SharePoint\SharePoint14\1033\ContosoCustomAction.zip**, or use the **Browse** button to locate and choose the assembly, and then choose the **OK** button.  
  
##### To include a wizard for a project template or item template  
  
1.  In the VSIX project, open the shortcut menu for the source.extension.vsixmanifest file, and then choose **Open**.  
  
     The file opens in the designer.  
  
2.  In the **Assets** section of the editor, choose the **New** button.  
  
     The **Add New Asset** dialog box opens.  
  
3.  In the **Type** list, choose **Microsoft.VisualStudio.Assembly**.  
  
4.  In the **Source** list, perform one of the following steps:  
  
    -   If the wizard assembly is built from a project that's in the same solution as the VSIX project, choose **A project in current solution**. In the **Project** list, choose the name of the project.  
  
    -   If the wizard assembly is included as a file in your project, choose **File on filesystem**. In the **Path** field, enter the complete path to the assembly file, or use the **Browse** button to locate and choose the assembly.  
  
5.  Choose the **OK** button.  
  
### Related Walkthroughs  
 The following table lists walkthroughs that demonstrate how to use a VSIX project to deploy different types of SharePoint tools extensions.  
  
|Extension type|Related walkthroughs|  
|--------------------|--------------------------|  
|An extension that includes only the extension assembly|[Walkthrough: Extending a SharePoint Project Item Type](../sharepoint/walkthrough-extending-a-sharepoint-project-item-type.md)<br /><br /> [Walkthrough: Creating a SharePoint Project Extension](../sharepoint/walkthrough-creating-a-sharepoint-project-extension.md)<br /><br /> [Walkthrough: Calling into the SharePoint Client Object Model in a Server Explorer Extension](../sharepoint/walkthrough-calling-into-the-sharepoint-client-object-model-in-a-server-explorer-extension.md)|  
|An extension that includes SharePoint commands|[Walkthrough: Creating a Custom Deployment Step for SharePoint Projects](../sharepoint/walkthrough-creating-a-custom-deployment-step-for-sharepoint-projects.md)<br /><br /> [Walkthrough: Extending Server Explorer to Display Web Parts](../sharepoint/walkthrough-extending-server-explorer-to-display-web-parts.md)<br /><br /> [Walkthrough: Creating a Site Column Project Item with a Project Template, Part 2](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-2.md)|  
|An extension that includes a Visual Studio template|[Walkthrough: Creating a Custom Action Project Item with an Item Template, Part 1](../sharepoint/walkthrough-creating-a-custom-action-project-item-with-an-item-template-part-1.md)<br /><br /> [Walkthrough: Creating a Site Column Project Item with a Project Template, Part 1](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-1.md)|  
|An extension that includes a template wizard|[Walkthrough: Creating a Custom Action Project Item with an Item Template, Part 2](../sharepoint/walkthrough-creating-a-custom-action-project-item-with-an-item-template-part-2.md)<br /><br /> [Walkthrough: Creating a Site Column Project Item with a Project Template, Part 2](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-2.md)|  
  
## Creating VSIX Packages Manually  
 If you want to manually create the VSIX package for your SharePoint tools extension, perform the following steps:  
  
1.  Create the extension.vsixmanifest file and the [Content_Types].xml file in a new folder. For more information, see [Anatomy of a VSIX Package](/visualstudio/extensibility/anatomy-of-a-vsix-package).  
  
2.  In Windows Explorer, right-click the folder that contains the two XML files, click Send To, and then click Compressed (zipped) Folder. Rename the resulting .zip file to Filename.vsix, where Filename is the name of the redistributable file that installs your package.  
  
3.  Add your extension assembly to the VSIX package. If your extension includes a SharePoint command, also add the assembly that implements the SharePoint command to the VSIX package.  
  
4.  Modify the extension.vsixmanifest file:  
  
    -   Add a `Microsoft.VisualStudio.MefComponent` element under the `Assets` element, and then set the value of the new element to the relative path of the assembly that implements your extension in the VSIX package. For more information, see [MEFComponent Element (VSX Schema)](http://msdn.microsoft.com/en-us/8a813141-8b73-44c9-b80b-ca85bbac9551).  
  
    -   If your extension includes a SharePoint command that calls into the server object model for SharePoint, add a `Microsoft.VisualStudio.Assembly` element under the `Assets` element. Set the value of the new element to the relative path of the assembly that implements the SharePoint command in the VSIX package. For more information, see [Asset Element (VSX Schema)](http://msdn.microsoft.com/en-us/9fcfc098-edc7-484b-9d4c-acd17829d737).  
  
    -   If your extension includes a project template or item template, add a `ProjectTemplate` or `ItemTemplate` element under the `Assets` element. Set the value of the new element to the relative path of the folder that contains the template in the VSIX package. For more information, see [ProjectTemplate Element (VSX Schema)](http://msdn.microsoft.com/en-us/87add64c-9dcd-495f-8815-209dab182cb1) and [ItemTemplate Element (VSX Schema)](http://msdn.microsoft.com/en-us/1d489e54-c1c5-4f96-a510-6c2640867ff0).  
  
    -   If your extension includes a custom wizard for a project template or item template, add an `Assembly` element under the `Assets` element. Set the value of the new element to the relative path of the assembly in the VSIX package, and then set the `AssemblyName` attribute to the full assembly name (including version, culture, and public key token). For more information, see [Dependency Element (VSX Schema)](http://msdn.microsoft.com/en-us/1f63f60a-98ad-48ec-8e44-4eba383d3e37).  
  
### Example  
 The following example shows the contents of an extension.vsixmanifest file for a SharePoint tools extension. The extension is implemented in an assembly that's named Contoso.ProjectExtension.dll. The extension includes a SharePoint command assembly that's named Contoso.ExtensionCommands.dll and an item template under a folder that's named **ItemTemplates** in the VSIX package. This example assumes that both of the assemblies are in the same folder as the extension.vsixmanifest file in the VSIX package.  
  
```  
<PackageManifest Version="2.0.0" xmlns="http://schemas.microsoft.com/developer/vsx-schema/2011">  
  <Metadata>  
    <Identity Id="CustomActionProjectItem.Microsoft.b99efe4d-cef3-4afd-b9af-034ca0c52743" Version="1.0" Language="en-US" Publisher="Microsoft" />  
    <DisplayName>CustomActionProjectItem</DisplayName>  
    <Description>Empty VSIX Project.</Description>  
  </Metadata>  
  <Installation>  
    <InstallationTarget Id="Microsoft.VisualStudio.Pro" Version="11.0" />  
  </Installation>  
  <Dependencies>  
    <Dependency Id="Microsoft.Framework.NDP" DisplayName="Microsoft .NET Framework" Version="4.5" />  
  </Dependencies>  
  <Assets>  
    <Asset Type="Microsoft.VisualStudio.ItemTemplate" Path="ItemTemplates" />  
    <Asset Type="Microsoft.VisualStudio.MefComponent" Path="ProjectItemDefinition.dll" />  
  </Assets>  
</PackageManifest>  
  
```  
  
## See Also  
 [Extending the SharePoint Project System](../sharepoint/extending-the-sharepoint-project-system.md)   
 [Extending the SharePoint Connections Node in Server Explorer](../sharepoint/extending-the-sharepoint-connections-node-in-server-explorer.md)   
 [Calling into the SharePoint Object Models](../sharepoint/calling-into-the-sharepoint-object-models.md)   
 [Debugging Extensions for the SharePoint Tools in Visual Studio](../sharepoint/debugging-extensions-for-the-sharepoint-tools-in-visual-studio.md)  
  
  