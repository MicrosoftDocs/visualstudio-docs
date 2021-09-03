---
title: "Create site column project item with project template, part 2"
titleSuffix: ""
description: Add a wizard to a site column project template to collect data from users when they use the template to create a SharePoint project containing the project item.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
helpviewer_keywords:
  - "project items [SharePoint development in Visual Studio], creating template wizards"
  - "SharePoint project items, creating template wizards"
  - "SharePoint development in Visual Studio, defining new project item types"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# Walkthrough: Create a site column project item with a project template, Part 2
  After you define a custom type of SharePoint project item and associate it with a project template in Visual Studio, you might also want to provide a wizard for the template. You can use the wizard to collect information from users when they use your template to create a new project that contains the project item. The information that you collect can be used to initialize the project item.

 In this walkthrough, you will add a wizard to the Site Column project template that is demonstrated in [Walkthrough: Creating a Site Column Project Item with a Project Template, Part 1](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-1.md). When a user creates a Site Column project, the wizard collects information about the site column (such as its base type and group) and adds this information to the *Elements.xml* file in the new project.

 This walkthrough demonstrates the following tasks:

- Creating a wizard for a custom SharePoint project item type that is associated with a project template.

- Defining a custom wizard UI that resembles the built-in wizards for SharePoint projects in Visual Studio.

- Creating two *SharePoint commands* that are used to call into the local SharePoint site while the wizard is running. SharePoint commands are methods that can be used by Visual Studio extensions to call APIs in the SharePoint server object model. For more information, see [Calling into the SharePoint Object Models](../sharepoint/calling-into-the-sharepoint-object-models.md).

- Using replaceable parameters to initialize SharePoint project files with data that you collect in the wizard.

- Creating a new .snk file in each new Site Column project instance. This file is used to sign the project output so that the SharePoint solution assembly can be deployed to the global assembly cache.

- Debugging and testing the wizard.

> [!NOTE]
> For a series of sample workflows, see [SharePoint workflow samples](/sharepoint/dev/general-development/sharepoint-workflow-samples).

## Prerequisites
 To perform this walkthrough, you must first create the SiteColumnProjectItem solution by completing [Walkthrough: Creating a Site Column Project Item with a Project Template, Part 1](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-1.md).

 You also need the following components on the development computer to complete this walkthrough:

- Supported editions of Windows, SharePoint, and Visual Studio.

- The Visual Studio SDK. This walkthrough uses the **VSIX Project** template in the SDK to create a VSIX package to deploy the project item. For more information, see [Extend the SharePoint tools in Visual Studio](../sharepoint/extending-the-sharepoint-tools-in-visual-studio.md).

  Knowledge of the following concepts is helpful, but not required, to complete the walkthrough:

- Wizards for project and item templates in Visual Studio. For more information, see [How to: Use Wizards with Project Templates](../extensibility/how-to-use-wizards-with-project-templates.md) and the <xref:Microsoft.VisualStudio.TemplateWizard.IWizard> interface.

- Site columns in SharePoint. For more information, see [Columns](/previous-versions/office/developer/sharepoint-2010/ms196085(v=office.14)).

## Understand the wizard components
 The wizard that is demonstrated in this walkthrough contains several components. The following table describes these components.

|Component|Description|
|---------------|-----------------|
|Wizard implementation|This is a class, named `SiteColumnProjectWizard`, which implements the <xref:Microsoft.VisualStudio.TemplateWizard.IWizard> interface. This interface defines the methods that Visual Studio calls when the wizard starts and finishes, and at certain times while the wizard runs.|
|Wizard UI|This is a WPF-based window, named `WizardWindow`. This window includes two user controls, named `Page1` and `Page2`. These user controls represent the two pages of the wizard.<br /><br /> In this walkthrough, the <xref:Microsoft.VisualStudio.TemplateWizard.IWizard.RunStarted%2A> method of the wizard implementation displays the wizard UI.|
|Wizard data model|This is an intermediary class, named `SiteColumnWizardModel`, which provides a layer between the wizard UI and the wizard implementation. This sample uses this class to help abstract the wizard implementation and the wizard UI from each other; this class is not a required component of all wizards.<br /><br /> In this walkthrough, the wizard implementation passes a `SiteColumnWizardModel` object to the wizard window when it displays the wizard UI. The wizard UI uses methods of this object to save the values of controls in the UI, and to perform tasks like verifying that the input site URL is valid. After the user finishes the wizard, the wizard implementation uses the `SiteColumnWizardModel` object to determine the final state of the UI.|
|Project signing manager|This is a helper class, named `ProjectSigningManager`, which is used by the wizard implementation to create a new key.snk file in each new project instance.|
|SharePoint commands|These are methods that are used by the wizard data model to call into the local SharePoint site while the wizard is running. Because SharePoint commands must target the .NET Framework 3.5, these commands are implemented in a different assembly than the rest of the wizard code.|

## Create the projects
 To complete this walkthrough, you need to add several projects to the SiteColumnProjectItem solution that you created in [Walkthrough: Create a site column project item with a project template, Part 1](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-1.md):

- A WPF project. You will implement the <xref:Microsoft.VisualStudio.TemplateWizard.IWizard> interface and define the wizard UI in this project.

- A class library project that defines the SharePoint commands. This project must target the.NET Framework 3.5.

  Start the walkthrough by creating the projects.

#### To create the WPF project

1. In [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], open the SiteColumnProjectItem solution.

2. In **Solution Explorer**, open the shortcut menu for the **SiteColumnProjectItem** solution node, choose **Add**, and then choose **New Project**.

3. At the top of the **Add New Project** dialog box, make sure that **.NET Framework 4.5** is chosen in the list of versions of the .NET Framework.

4. Expand the **Visual C#** node or the **Visual Basic** node, and choose the **Windows** node.

5. In the list of project templates, choose **WPF User Control Library**, name the project **ProjectTemplateWizard**, and then choose the **OK** button.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] adds the **ProjectTemplateWizard** project to the solution and opens the default UserControl1.xaml file.

6. Delete the UserControl1.xaml file from the project.

#### To create the SharePoint commands project

1. In **Solution Explorer**, open the shortcut menu for the SiteColumnProjectItem solution node, choose **Add**, and then choose **New Project**.

2. At the top of the **Add New Project** dialog box, choose **.NET Framework 3.5** in the list of versions of the .NET Framework.

3. Expand the **Visual C#** node or the  **Visual Basic** node, and then choose the **Windows** node.

4. Choose the **Class Library** project template, name the project **SharePointCommands**, and then choose the **OK** button.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] adds the **SharePointCommands** project to the solution and opens the default Class1 code file.

5. Delete the Class1 code file from the project.

## Configure the projects
 Before you create the wizard, you must add some code files and assembly references to the projects.

#### To configure the wizard project

1. In **Solution Explorer**, open the shortcut menu for the **ProjectTemplateWizard** project node, and then choose **Properties**.

2. In the **Project Designer**, choose the **Application** tab for a Visual C# project or the **Compile** tab for a Visual Basic project.

3. Make sure that the target framework is set to the .NET Framework 4.5, not the .NET Framework 4.5 Client Profile.

     For more information, see [How to: Target a Version of the .NET Framework](../ide/visual-studio-multi-targeting-overview.md).

4. Open the shortcut menu for the **ProjectTemplateWizard** project, choose **Add**, and then choose **New Item**.

5. Choose the **Window (WPF)** item, name the item **WizardWindow**, and then choose the **Add** button.

6. Add two **User Control (WPF)** items to the project, and name them **Page1** and **Page2**.

7. Add four code files to the project, and give them the following names:

    - SiteColumnProjectWizard

    - SiteColumnWizardModel

    - ProjectSigningManager

    - CommandIds

8. Open the shortcut menu for the **ProjectTemplateWizard** project node, and then choose **Add Reference**.

9. Expand the **Assemblies** node, choose the **Extensions** node, and then select the check boxes next to the following assemblies:

    - EnvDTE

    - Microsoft.VisualStudio.OLE.Interop

    - Microsoft.VisualStudio.SharePoint

    - Microsoft.VisualStudio.Shell.11.0

    - Microsoft.VisualStudio.Shell.Interop.10.0

    - Microsoft.VisualStudio.Shell.Interop.11.0

    - Microsoft.VisualStudio.TemplateWizardInterface

10. Choose the **OK** button to add the assemblies to the project.

11. In **Solution Explorer**, under the **References** folder for the **ProjectTemplateWizard** project, choose **EnvDTE**.

12. In the **Properties** window, change the value of the **Embed Interop Types** property to **False**.

13. If you're developing a Visual Basic project, import the ProjectTemplateWizard namespace into your project by using the **Project Designer**.

     For more information, see [How to: Add or Remove Imported Namespaces &#40;Visual Basic&#41;](../ide/how-to-add-or-remove-imported-namespaces-visual-basic.md).

#### To configure the SharePointcommands project

1. In **Solution Explorer**, choose the **SharePointCommands** project node.

2. On the menu bar, choose **Project**,  **Add Existing Item**.

3. In the **Add Existing Item** dialog box, browse to the folder that contains the code files for the ProjectTemplateWizard project, and then choose the **CommandIds** code file.

4. Choose the arrow next to the **Add** button, and then choose the **Add As Link** option on the menu that appears.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] adds the code file to the **SharePointCommands** project as a link. The code file is located in the **ProjectTemplateWizard** project, but the code in the file is also compiled in the **SharePointCommands** project.

5. In the **SharePointCommands** project, add another code file that's named Commands.

6. Choose the SharePointCommands project, and then, on the menu bar, choose **Project** > **Add Reference**.

7. Expand the **Assemblies** node, choose the **Extensions** node, and then select the check boxes next to the following assemblies:

    - Microsoft.SharePoint

    - Microsoft.VisualStudio.SharePoint.Commands

8. Choose the **OK** button to add the assemblies to the project.

## Create the wizard model, signing manager, and SharePoint command IDs
 Add code to the ProjectTemplateWizard project to implement the following components in the sample:

- The SharePoint command IDs. These strings identify the SharePoint commands that the wizard uses. Later in this walkthrough, you'll add code to the SharePointCommands project to implement the commands.

- The wizard data model.

- The project signing manager.

  For more information about these components, see [Understand the wizard components](#understand-the-wizard-components).

#### To define the SharePoint command IDs

1. In the ProjectTemplateWizard project, open the CommandIds code file, and then replace the entire contents of this file with the following code.

     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/sitecolumnprojectitem/projecttemplatewizard/commandids.cs" id="Snippet5":::
     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/sitecolumnprojectitem/projecttemplatewizard/commandids.vb" id="Snippet5":::

#### To create the wizard model

1. Open the SiteColumnWizardModel code file, and replace the entire contents of this file with the following code.

     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/sitecolumnprojectitem/projecttemplatewizard/sitecolumnwizardmodel.vb" id="Snippet6":::
     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/sitecolumnprojectitem/projecttemplatewizard/sitecolumnwizardmodel.cs" id="Snippet6":::

#### To create the project signing manager

1. Open the ProjectSigningManager code file, and then replace the entire contents of this file with the following code.

     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/sitecolumnprojectitem/projecttemplatewizard/projectsigningmanager.vb" id="Snippet8":::
     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/sitecolumnprojectitem/projecttemplatewizard/projectsigningmanager.cs" id="Snippet8":::

## Create the wizard UI
 Add XAML to define the UI of the wizard window and the two user controls that provide the UI for the wizard pages, and add code to define the behavior of the window and user controls. The wizard that you create resembles the built-in wizard for SharePoint projects in Visual Studio.

> [!NOTE]
> In the following steps, your project will have some compile errors after you add XAML or code to your project. These errors will go away when you add code in later steps.

#### To create the wizard window UI

1. In the ProjectTemplateWizard project, open the shortcut menu for the WizardWindow.xaml file, and then choose **Open** to open the window in the designer.

2. In the XAML view of the designer, replace the current XAML with the following XAML. The XAML defines a UI that includes a heading, a <xref:System.Windows.Controls.Grid> that contains the wizard pages, and navigation buttons at the bottom of the window.

     :::code language="xml" source="../sharepoint/codesnippet/Xaml/sitecolumnprojectitem/projecttemplatewizard/wizardwindow.xaml" id="Snippet10":::

    > [!NOTE]
    > The window that's created in this XAML is derived from the <xref:Microsoft.VisualStudio.PlatformUI.DialogWindow> base class. When you add a custom WPF dialog box to Visual Studio, we recommend that you derive your dialog box from this class to have consistent styling with other Visual Studio dialog boxes and to avoid modal dialog issues that might otherwise occur. For more information, see [Creating and Managing Modal Dialog Boxes](../extensibility/creating-and-managing-modal-dialog-boxes.md).

3. If you're developing a Visual Basic project, remove the `ProjectTemplateWizard` namespace from the `WizardWindow` class name in the `x:Class` attribute of the `Window` element. This element is in the first line of the XAML. When you're done, the first line should look like the following example.

    ```xml
    <Window x:Class="WizardWindow"
    ```

4. Open the code-behind file for the WizardWindow.xaml file.

5. Replace the contents of this file, except for the `using` declarations at the top of the file, with the following code.

     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/sitecolumnprojectitem/projecttemplatewizard/wizardwindow.xaml.vb" id="Snippet4":::
     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/sitecolumnprojectitem/projecttemplatewizard/wizardwindow.xaml.cs" id="Snippet4":::

#### To create the first wizard page UI

1. In the ProjectTemplateWizard project, open the shortcut menu for the Page1.xaml file, and then choose **Open** to open the user control in the designer.

2. In the XAML view of the designer, replace the current XAML with the following XAML. The XAML defines a UI that includes a text box where users can enter the URL of the local sites that they want to use for debugging. The UI also includes option buttons with which users can specify whether the project is sandboxed.

     :::code language="xml" source="../sharepoint/codesnippet/Xaml/sitecolumnprojectitem/projecttemplatewizard/page1.xaml" id="Snippet11":::

3. If you are developing a Visual Basic project, remove the `ProjectTemplateWizard` namespace from the `Page1` class name in the `x:Class` attribute of the `UserControl` element. This is in the first line of the XAML. When you are done, the first line should look like the following.

    ```xml
    <UserControl x:Class="Page1"
    ```

4. Replace the contents of the Page1.xaml file, except for the `using` declarations at the top of the file, with the following code.

     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/sitecolumnprojectitem/projecttemplatewizard/page1.xaml.vb" id="Snippet2":::
     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/sitecolumnprojectitem/projecttemplatewizard/page1.xaml.cs" id="Snippet2":::

#### To create the second wizard page UI

1. In the ProjectTemplateWizard project, open the shortcut menu for the Page2.xaml file, and then choose **Open**.

     The user control opens in the designer.

2. In the XAML view, replace the current XAML with the following XAML. The XAML defines a UI that includes a drop-down list for choosing the base type of the site column, a combo box for specifying a built-in or custom group under which to display the site column in the gallery, and a text box for specifying the name of the site column.

     :::code language="xml" source="../sharepoint/codesnippet/Xaml/sitecolumnprojectitem/projecttemplatewizard/page2.xaml" id="Snippet12":::

3. If you are developing a Visual Basic project, remove the `ProjectTemplateWizard` namespace from the `Page2` class name in the `x:Class` attribute of the `UserControl` element. This is in the first line of the XAML. When you are done, the first line should look like the following.

    ```xml
    <UserControl x:Class="Page2"
    ```

4. Replace the contents of the code-behind file for the Page2.xaml file, except for the `using` declarations at the top of the file, with the following code.

     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/sitecolumnprojectitem/projecttemplatewizard/page2.xaml.vb" id="Snippet3":::
     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/sitecolumnprojectitem/projecttemplatewizard/page2.xaml.cs" id="Snippet3":::

## Implement the wizard
 Define the main functionality of the wizard by implementing the <xref:Microsoft.VisualStudio.TemplateWizard.IWizard> interface. This interface defines the methods that Visual Studio calls when the wizard starts and finishes, and at certain times while the wizard runs.

#### To implement the wizard

1. In the ProjectTemplateWizard project, open the SiteColumnProjectWizard code file.

2. Replace the entire contents of this file with the following code.

     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/sitecolumnprojectitem/projecttemplatewizard/sitecolumnprojectwizard.vb" id="Snippet7":::
     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/sitecolumnprojectitem/projecttemplatewizard/sitecolumnprojectwizard.cs" id="Snippet7":::

## Create the SharePoint commands
 Create two custom commands that call into the SharePoint server object model. One command determines whether the site URL that the user types in the wizard is valid. The other command gets all of the field types from the specified SharePoint site so that users can select which one to use as the basis for their new site column.

#### To define the SharePoint commands

1. In the **SharePointCommands** project, open the Commands code file.

2. Replace the entire contents of this file with the following code.

     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/sitecolumnprojectitem/sharepointcommands/commands.vb" id="Snippet9":::
     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/sitecolumnprojectitem/sharepointcommands/commands.cs" id="Snippet9":::

## Checkpoint
 At this point in the walkthrough, all the code for the wizard is now in the project. Build the project to make sure that it compiles without errors.

#### To build your project

1. On the menu bar, choose **Build** > **Build Solution**.

## Removing the key.snk file from the project template
 In [Walkthrough: Create a site column project item with a project template, Part 1](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-1.md), the project template that you created contains a key.snk file that is used to sign each Site Column project instance. This key.snk file is no longer necessary because the wizard now generates a new key.snk file for each project. Remove the key.snk file from the project template and remove references to this file.

#### To remove the key.snk file from the project template

1. In **Solution Explorer**, under the **SiteColumnProjectTemplate** node, open the shortcut menu for the **key.snk** file, and then choose **Delete**.

2. In the confirmation dialog box that appears, choose the **OK** button.

3. Under the **SiteColumnProjectTemplate** node, open the SiteColumnProjectTemplate.vstemplate file, and then remove the following element from it.

    ```xml
    <ProjectItem ReplaceParameters="false" TargetFileName="key.snk">key.snk</ProjectItem>
    ```

4. Save and close the file.

5. Under the **SiteColumnProjectTemplate** node, open the ProjectTemplate.csproj or ProjectTemplate.vbproj file, and then remove the following `PropertyGroup` element from it.

    ```xml
    <PropertyGroup>
      <SignAssembly>true</SignAssembly>
      <AssemblyOriginatorKeyFile>key.snk</AssemblyOriginatorKeyFile>
    </PropertyGroup>
    ```

6. Remove the following `None` element.

    ```xml
    <None Include="key.snk" />
    ```

7. Save and close the file.

## Associating the wizard with the project template
 Now that you have implemented the wizard, you must associate the wizard with the **Site Column** project template. There are three procedures you must complete to do this:

1. Sign the wizard assembly with a strong name.

2. Get the public key token for the wizard assembly.

3. Add a reference to the wizard assembly in the .vstemplate file for the **Site Column** project template.

#### To sign the wizard assembly with a strong name

1. In **Solution Explorer**, open the shortcut menu for the **ProjectTemplateWizard** project, and then choose **Properties**.

2. On the **Signing** tab, select the **Sign the assembly** check box.

3. In the **Choose a strong name key file** list, choose **\<New...>**.

4. In the **Create Strong Name Key** dialog box, enter a name for the new key file, clear the **Protect my key file with a password** check box, and then choose the **OK** button.

5. Open the shortcut menu for the **ProjectTemplateWizard** project, and then choose **Build** to create the ProjectTemplateWizard.dll file.

#### To get the public key token for the wizard assembly

1. On the **Start Menu**, choose **All Programs**, choose **Microsoft Visual Studio**, choose **Visual Studio Tools**, and then choose **Developer Command Prompt**.

     A Visual Studio Command Prompt window opens.

2. Run the following command, replacing *PathToWizardAssembly* with the full path to the built ProjectTemplateWizard.dll assembly for the ProjectTemplateWizard project on your development computer:

    ```cmd
    sn.exe -T PathToWizardAssembly
    ```

     The public key token for the ProjectTemplateWizard.dll assembly is written to the Visual Studio Command Prompt window.

3. Keep the Visual Studio Command Prompt window open. You will need the public key token during the next procedure.

#### To add a reference to the wizard assembly in the .vstemplate file

1. In **Solution Explorer**, expand the **SiteColumnProjectTemplate** project node and open the SiteColumnProjectTemplate.vstemplate file.

2. Near the end of the file, add the following `WizardExtension` element between the `</TemplateContent>` and `</VSTemplate>` tags. Replace the *your token* value of the `PublicKeyToken` attribute with the public key token that you obtained in the previous procedure.

    ```xml
    <WizardExtension>
      <Assembly>ProjectTemplateWizard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=your token</Assembly>
      <FullClassName>ProjectTemplateWizard.SiteColumnProjectWizard</FullClassName>
    </WizardExtension>
    ```

     For more information about the `WizardExtension` element, see [WizardExtension Element &#40;Visual Studio Templates&#41;](../extensibility/wizardextension-element-visual-studio-templates.md).

3. Save and close the file.

## Add replaceable parameters to the Elements.xml file in the project template
 Add several replaceable parameters to the *Elements.xml* file in the SiteColumnProjectTemplate project. These parameters are initialized in the `RunStarted` method in the `SiteColumnProjectWizard` class that you defined earlier. When a user creates a Site Column project, Visual Studio automatically replaces these parameters in the *Elements.xml* file in the new project with the values that they specified in the wizard.

 A replaceable parameter is a token that begins and ends with the dollar sign ($) character. In addition to defining your own replaceable parameters, you can use built-in parameters that are defined and initialized by the SharePoint project system. For more information, see [Replaceable parameters](../sharepoint/replaceable-parameters.md).

#### To add replaceable parameters to the Elements.xml file

1. In the SiteColumnProjectTemplate project, replace the contents of the *Elements.xml* file with the following XML.

    ```xml
    <?xml version="1.0" encoding="utf-8"?>
    <Elements xmlns="http://schemas.microsoft.com/sharepoint/">
      <Field ID="{$guid5$}"
             Name="$fieldname$"
             DisplayName="$fieldname$"
             Type="$selectedfieldtype$"
             Group="$selectedgrouptype$">
      </Field>
    </Elements>
    ```

     The new XML changes the values of the `Name`, `DisplayName`, `Type`, and `Group` attributes to custom replaceable parameters.

2. Save and close the file.

## Add the wizard to the VSIX package
 To deploy the wizard with the VSIX package that contains the Site Column project template, add references to the wizard project and the SharePoint commands project to the source.extension.vsixmanifest file in the VSIX project.

#### To add the wizard to the VSIX package

1. In **Solution Explorer**, in the **SiteColumnProjectItem** project, open the shortcut menu for the **source.extension.vsixmanifest** file, and then choose **Open**.

     Visual Studio opens the file in the manifest editor.

2. On the **Assets** tab of the editor, choose the **New** button.

     The **Add New Asset** dialog box opens.

3. In the **Type** list, choose **Microsoft.VisualStudio.Assembly**.

4. In the **Source** list, choose **A project in current solution**.

5. In the **Project** list, choose **ProjectTemplateWizard**, and then choose the **OK** button.

6. On the **Assets** tab of the editor, choose the **New** button again.

     The **Add New Asset** dialog box opens.

7. In the **Type** list, enter **SharePoint.Commands.v4**.

8. In the **Source** list, choose **A project in current solution**.

9. In the **Project** list, choose the **SharePointCommands** project, and then choose the **OK** button.

10. On the menu bar, choose **Build** > **Build Solution**, and then make sure that the solution builds without errors.

## Test the wizard
 You are now ready to test the wizard. First, start debugging the SiteColumnProjectItem solution in the experimental instance of Visual Studio. Then, test the wizard for the Site Column project in the experimental instance of Visual Studio. Finally, build and run the project to verify that the site column works as expected.

#### To start debugging the solution

1. Restart Visual Studio with administrative credentials, and then open the SiteColumnProjectItem solution.

2. In the ProjectTemplateWizard project, open the SiteColumnProjectWizard code file, and then add a breakpoint to the first line of code in the `RunStarted` method.

3. On the menu bar, choose **Debug** > **Exceptions**.

4. In the **Exceptions** dialog box, make sure that the **Thrown** and **User-unhandled** check boxes for **Common Language Runtime Exceptions** are cleared, and then choose the **OK** button.

5. Start debugging by choosing the **F5** key or, on the menu bar, choosing **Debug** > **Start Debugging**.

     Visual Studio installs the extension to %UserProfile%\AppData\Local\Microsoft\VisualStudio\11.0Exp\Extensions\Contoso\Site Column\1.0 and starts an experimental instance of Visual Studio. You'll test the project item in this instance of Visual Studio.

#### To test the wizard in Visual Studio

1. In the experimental instance of Visual Studio, on the menu bar, choose **File** > **New** > **Project**.

2. Expand the **Visual C#** node or the **Visual Basic** node (depending on the language that your project template supports), expand the **SharePoint** node, and then choose the **2010** node.

3. In the list of project templates, choose **Site Column**, name the project **SiteColumnWizardTest**, and then choose the **OK** button.

4. Verify that the code in the other instance of Visual Studio stops on the breakpoint that you set earlier in the `RunStarted` method.

5. Continue to debug the project by choosing the **F5** key or, on the menu bar, choosing **Debug** > **Continue**.

6. In the **SharePoint Customization Wizard**, enter the URL of the site that you want to use for debugging, and then choose the **Next** button.

7. In the second page of the **SharePoint Customization Wizard**, make the following selections:

   - In the **Type** list, choose **Boolean**.

   - In the **Group** list, choose **Custom Yes/No Columns**.

   - In the **Name** box, enter **My Yes/No Column**, and then choose the **Finish** button.

     In **Solution Explorer**, a new project appears and contains a project item that's named **Field1**, and Visual Studio opens the project's *Elements.xml* file in the editor.

8. Verify that *Elements.xml* contains the values that you specified in the wizard.

#### To test the site column in SharePoint

1. In the experimental instance of Visual Studio, choose the **F5** key.

     The site column is packaged and deployed to the SharePoint site that the **Site URL** property of the project specifies. The web browser opens to the default page of this site.

    > [!NOTE]
    > If the **Script Debugging Disabled** dialog box appears, choose the **Yes** button to continue to debug the project.

2. On the **Site Actions** menu, choose **Site Settings**.

3. On the Site Settings page, under **Galleries**, choose the **Site columns** link.

4. In the list of site columns, verify that a **Custom Yes/No Columns** group contains a column that's named **My Yes/No Column**, and then close the web browser.

## Clean up the development computer
 After you finish testing the project item, remove the project template from the experimental instance of Visual Studio.

#### To clean up the development computer

1. In the experimental instance of Visual Studio, on the menu bar, choose **Tools** > **Extensions and Updates**.

     The **Extensions and Updates** dialog box opens.

2. In the list of extensions, choose **Site Column**, and then choose the **Uninstall** button.

3. In the dialog box that appears, choose the **Yes** button to confirm that you want to uninstall the extension, and then choose the **Restart Now** button to complete the uninstallation.

4. Close both the experimental instance of Visual Studio and the instance in which the CustomActionProjectItem solution is open.

     For information about how to deploy [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] extensions, see [Shipping Visual Studio Extensions](../extensibility/shipping-visual-studio-extensions.md).

## See also
- [Walkthrough: Create a site column project item with a project template, Part 1](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-1.md)
- [Define custom SharePoint project item types](../sharepoint/defining-custom-sharepoint-project-item-types.md)
- [Creating Item Templates and Project Templates for SharePoint Project Items](../sharepoint/creating-item-templates-and-project-templates-for-sharepoint-project-items.md)
- [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)
- [How to: Use Wizards with Project Templates](../extensibility/how-to-use-wizards-with-project-templates.md)
