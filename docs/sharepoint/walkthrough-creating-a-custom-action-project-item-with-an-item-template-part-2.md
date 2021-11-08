---
title: "Create custom action project item with item template, part 2"
titleSuffix: ""
description: In this walkthrough, add a wizard to collect information from users when they use an item template to add a Custom Action project item on a SharePoint site.
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
# Walkthrough: Create a custom action project item with an item template, part 2
  After you define a custom type of SharePoint project item and associate it with an item template in Visual Studio, you might also want to provide a wizard for the template. You can use the wizard to collect information from users when they use your template to add a new instance of the project item to a project. The information that you collect can be used to initialize the project item.

 In this walkthrough, you will add a wizard to the Custom Action project item that is demonstrated in [Walkthrough: Create a custom action project item with an item template, Part 1](../sharepoint/walkthrough-creating-a-custom-action-project-item-with-an-item-template-part-1.md). When a user adds a Custom Action project item to a SharePoint project, the wizard collects information about the custom action (such as its location and the URL to navigate to when an end user chooses it) and adds this information to the *Elements.xml* file in the new project item.

 This walkthrough demonstrates the following tasks:

- Creating a wizard for a custom SharePoint project item type that is associated with an item template.

- Defining a custom wizard UI that resembles the built-in wizards for SharePoint project items in Visual Studio.

- Using replaceable parameters to initialize SharePoint project files with data that you collect in the wizard.

- Debugging and testing the wizard.

> [!NOTE]
> You can download a sample from [Github](https://github.com/SharePoint/PnP/tree/master/Samples/Workflow.Activities) that shows how to create custom activities for a workflow.

## Prerequisites
 To perform this walkthrough, you must first create the CustomActionProjectItem solution by completing [Walkthrough: Create a custom action project item with an item template, Part 1](../sharepoint/walkthrough-creating-a-custom-action-project-item-with-an-item-template-part-1.md).

 You also need the following components on the development computer to complete this walkthrough:

- Supported editions of Windows, SharePoint, and Visual Studio.

- The Visual Studio SDK. This walkthrough uses the **VSIX Project** template in the SDK to create a VSIX package to deploy the project item. For more information, see [Extend the SharePoint tools in Visual Studio](../sharepoint/extending-the-sharepoint-tools-in-visual-studio.md).

  Knowledge of the following concepts is helpful, but not required, to complete the walkthrough:

- Wizards for project and item templates in Visual Studio. For more information, see [How to: Use Wizards with Project Templates](../extensibility/how-to-use-wizards-with-project-templates.md) and the <xref:Microsoft.VisualStudio.TemplateWizard.IWizard> interface.

- Custom actions in SharePoint. For more information, see [Custom Action](/previous-versions/office/developer/sharepoint-2010/ms458635(v=office.14)).

## Create the wizard project
 To complete this walkthrough, you must add a project to the CustomActionProjectItem solution that you created in [Walkthrough: Create a custom action project item with an item template, Part 1](../sharepoint/walkthrough-creating-a-custom-action-project-item-with-an-item-template-part-1.md). You will implement the <xref:Microsoft.VisualStudio.TemplateWizard.IWizard> interface and define the wizard UI in this project.

#### To create the wizard project

1. In Visual Studio, open the CustomActionProjectItem solution

2. In **Solution Explorer**, open the shortcut menu for the solution node, choose **Add**, and then choose **New Project**.

3. In the **New Project** dialog box, expand the **Visual C#** or **Visual Basic** nodes, and then choose the **Windows** node.

4. At the top of the **New Project** dialog box, make sure that **.NET Framework 4.5** is chosen in the list of versions of the .NET Framework.

5. Choose the **WPF User Control Library** project template, name the project **ItemTemplateWizard**, and then choose the **OK** button.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] adds the **ItemTemplateWizard** project to the solution.

6. Delete the UserControl1 item from the project.

## Configure the wizard project
 Before you create the wizard, you must add a Windows Presentation Foundation (WPF) window, a code file, and assembly references to the project.

#### To configure the wizard project

1. In **Solution Explorer**, open the shortcut menu from the **ItemTemplateWizard** project node, and then choose **Properties**.

2. In the **Project Designer**, make sure that the target framework is set to .NET Framework 4.5.

     For Visual C# projects, you can set this value on the **Application** tab. For Visual Basic projects, you can set this value on the **Compile** tab. For more information, see [How to: Target a Version of the .NET Framework](../ide/visual-studio-multi-targeting-overview.md).

3. In the **ItemTemplateWizard** project, add a **Window (WPF)** item to the project, and then name the item **WizardWindow**.

4. Add two code files that are named CustomActionWizard and Strings.

5. Open the shortcut menu for the **ItemTemplateWizard** project,  and then choose **Add Reference**.

6. In the **Reference Manager - ItemTemplateWizard** dialog box, under the **Assemblies** node, choose the **Extensions** node.

7. Select the check boxes next to the following assemblies, and then choose the **OK** button:

    - EnvDTE

    - Microsoft.VisualStudio.Shell.11.0

    - Microsoft.VisualStudio.TemplateWizardInterface

8. In **Solution Explorer**, in the **References** folder for the ItemTemplateWizard project, choose the **EnvDTE** reference.

9. In the **Properties** window, change the value of the **Embed Interop Types** property to **False**.

## Define the default location and ID strings for custom actions
 Every custom action has a location and ID that is specified in the `GroupID` and `Location` attributes of the `CustomAction` element in the *Elements.xml* file. In this step, you define some of the valid strings for these attributes in the ItemTemplateWizard project. When you complete this walkthrough, these strings are written to the *Elements.xml* file in the Custom Action project item when users specify a location and an ID in the wizard.

 For simplicity, this sample supports only a subset of the available default locations and IDs. For a full list, see [Default Custom Action Locations and IDs](/previous-versions/office/developer/sharepoint-2010/bb802730(v=office.14)).

#### To define the default location and ID strings

1. open.

2. In the **ItemTemplateWizard** project, replace the code in the Strings code file with the following code.

     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/customactionprojectitem/itemtemplatewizard/strings.cs" id="Snippet6":::
     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/customactionprojectitem/itemtemplatewizard/strings.vb" id="Snippet6":::

## Create the wizard UI
 Add XAML to define the UI of the wizard, and add some code to bind some of the controls in the wizard to the ID strings. The wizard that you create resembles the built-in wizard for SharePoint projects in Visual Studio.

#### To create the wizard UI

1. In the **ItemTemplateWizard** project, open the shortcut menu for the **WizardWindow.xaml** file, and then choose **Open** to open the window in the designer.

2. In the XAML view, replace the current XAML with the following XAML. The XAML defines a UI that includes a heading, controls for specifying the behavior of the custom action, and navigation buttons at the bottom of the window.

    > [!NOTE]
    > Your project will have some compile errors after you add this code. These errors will go away when you add code in later steps.

     :::code language="xml" source="../sharepoint/codesnippet/Xaml/customactionprojectitem/itemtemplatewizard/wizardwindow.xaml" id="Snippet9":::

    > [!NOTE]
    > The window that's created in this XAML is derived from the <xref:Microsoft.VisualStudio.PlatformUI.DialogWindow> base class. When you add a custom WPF dialog box to Visual Studio, we recommend that you derive your dialog box from this class to have consistent styling with other dialog boxes in Visual Studio and to avoid issues that might otherwise occur with modal dialog boxes. For more information, see [Creating and Managing Modal Dialog Boxes](../extensibility/creating-and-managing-modal-dialog-boxes.md).

3. If you're developing a Visual Basic project, remove the `ItemTemplateWizard` namespace from the `WizardWindow` class name in the `x:Class` attribute of the `Window` element. This element is in the first line of the XAML. When you're done, the first line should resemble the following code:

    ```xml
    <Window x:Class="WizardWindow"
    ```

4. In the code-behind file for the WizardWindow.xaml file, replace the current code with the following code.

     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/customactionprojectitem/itemtemplatewizard/wizardwindow.xaml.vb" id="Snippet7":::
     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/customactionprojectitem/itemtemplatewizard/wizardwindow.xaml.cs" id="Snippet7":::

## Implement the wizard
 Define the functionality of the wizard by implementing the <xref:Microsoft.VisualStudio.TemplateWizard.IWizard> interface.

#### To implement the wizard

1. In the **ItemTemplateWizard** project, open the **CustomActionWizard** code file, and then replace the current code in this file with the following code:

     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/customactionprojectitem/itemtemplatewizard/customactionwizard.cs" id="Snippet8":::
     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/customactionprojectitem/itemtemplatewizard/customactionwizard.vb" id="Snippet8":::

## Checkpoint
 At this point in the walkthrough, all the code for the wizard is now in the project. Build the project to make sure that it compiles without errors.

#### To build your project

1. On the menu bar, choose **Build** > **Build Solution**.

## Associate the wizard with the item template
 Now that you have implemented the wizard, you must associate it with the **Custom Action** item template by completing three main steps:

1. Sign the wizard assembly with a strong name.

2. Get the public key token for the wizard assembly.

3. Add a reference to the wizard assembly in the .vstemplate file for the **Custom Action** item template.

#### To sign the wizard assembly with a strong name

1. In **Solution Explorer**, open the shortcut menu from the **ItemTemplateWizard** project node, and then choose **Properties**.

2. On the **Signing** tab, select the **Sign the assembly** check box.

3. In the **Choose a strong name key file** list, choose **\<New...>**.

4. In the **Create Strong Name Key** dialog box, enter a name, clear the **Protect my key file with a password** check box, and then choose the **OK** button.

5. On the menu bar, choose **Build** > **Build Solution**.

#### To get the public key token for the wizard assembly

1. In a Visual Studio Command Prompt window, run the following command, replacing *PathToWizardAssembly* with the full path to the built ItemTemplateWizard.dll assembly for the ItemTemplateWizard project on your development computer.

    ```xml
    sn.exe -T PathToWizardAssembly
    ```

     The public key token for the *ItemTemplateWizard.dll* assembly is written to the Visual Studio Command Prompt window.

2. Keep the Visual Studio Command Prompt window open. You'll need the public key token to complete the next procedure.

#### To add a reference to the wizard assembly in the .vstemplate file

1. In **Solution Explorer**, expand the **ItemTemplate** project node, and then open the *ItemTemplate.vstemplate* file.

2. Near the end of the file, add the following `WizardExtension` element between the `</TemplateContent>` and `</VSTemplate>` tags. Replace the *YourToken* value of the `PublicKeyToken` attribute with the public key token that you obtained in the previous procedure.

    ```xml
    <WizardExtension>
      <Assembly>ItemTemplateWizard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=YourToken</Assembly>
      <FullClassName>ItemTemplateWizard.CustomActionWizard</FullClassName>
    </WizardExtension>
    ```

     For more information about the `WizardExtension` element, see [WizardExtension Element &#40;Visual Studio Templates&#41;](../extensibility/wizardextension-element-visual-studio-templates.md).

3. Save and close the file.

## Add replaceable parameters to the *Elements.xml* file in the item template
 Add several replaceable parameters to the *Elements.xml* file in the ItemTemplate project. These parameters are initialized in the `PopulateReplacementDictionary` method in the `CustomActionWizard` class that you defined earlier. When a user adds a Custom Action project item to a project, Visual Studio automatically replaces these parameters in the *Elements.xml* file in the new project item with the values that they specified in the wizard.

 A replaceable parameter is a token that starts and ends with the dollar sign ($) character. In addition to defining your own replaceable parameters, you can use built-in parameters that the SharePoint project system defines and initializes. For more information, see [Replaceable parameters](../sharepoint/replaceable-parameters.md).

#### To add replaceable parameters to the *Elements.xml* file

1. In the ItemTemplate project, replace the contents of the *Elements.xml* file with the following XML.

    ```xml
    <?xml version="1.0" encoding="utf-8" ?>
    <Elements Id="$guid8$" xmlns="http://schemas.microsoft.com/sharepoint/">
      <CustomAction Id="$IdValue$"
                    GroupId="$GroupIdValue$"
                    Location="$LocationValue$"
                    Sequence="1000"
                    Title="$TitleValue$"
                    Description="$DescriptionValue$" >
        <UrlAction Url="$UrlValue$"/>
      </CustomAction>
    </Elements>
    ```

     The new XML changes the values of the `Id`, `GroupId`, `Location`, `Description`, and `Url` attributes to replaceable parameters.

2. Save and close the file.

## Add the wizard to the VSIX package
 In the source.extension.vsixmanifest file in the VSIX project, add a reference to the wizard project so that it's deployed with the VSIX package that contains the project item.

#### To add the wizard to the VSIX package

1. In **Solution Explorer**, open the shortcut menu from the **source.extension.vsixmanifest** file in the CustomActionProjectItem project, and then choose **Open** to open the file in the manifest editor.

2. In the manifest editor, choose the **Assets** tab, then choose the **New** button.

     The **Add New Asset** dialog box appears.

3. In the **Type** list, choose **Microsoft.VisualStudio.Assembly**.

4. In the **Source** list, choose **A project in current solution**.

5. In the **Project** list, choose **ItemTemplateWizard**, and then choose the **OK** button.

6. On the menu bar, choose **Build** > **Build Solution**, and then make sure that the solution compiles without errors.

## Test the wizard
 You are now ready to test the wizard. First, start to debug the CustomActionProjectItem solution in the experimental instance of Visual Studio. Then test the wizard for the Custom Action project item in a SharePoint project in the experimental instance of Visual Studio. Finally, build and run the SharePoint project to verify that the custom action works as expected.

#### To start to debug the solution

1. Restart Visual Studio with administrative credentials, and then open the CustomActionProjectItem solution.

2. In the ItemTemplateWizard project, open the CustomActionWizard code file, and then add a breakpoint to the first line of code in the `RunStarted` method.

3. On the menu bar, choose **Debug** > **Exceptions**.

4. In the **Exceptions** dialog box, make sure that the **Thrown** and **User-unhandled** check boxes for **Common Language Runtime Exceptions** are cleared, and then choose the **OK** button.

5. Start debugging by choosing the **F5** key, or, on the menu bar, choosing **Debug** > **Start Debugging**.

     Visual Studio installs the extension to %UserProfile%\AppData\Local\Microsoft\VisualStudio\11.0Exp\Extensions\Contoso\Custom Action Project Item\1.0 and starts an experimental instance of Visual Studio. You'll test the project item in this instance of Visual Studio.

#### To test the wizard in Visual Studio

1. In the experimental instance of Visual Studio, on the menu bar, choose **File** > **New** > **Project**.

2. Expand the **Visual C#** or **Visual Basic** node (depending on the language that your item template supports), expand the **SharePoint** node, and then choose the **2010** node.

3. In the list of project templates, choose **SharePoint 2010 Project**, name the project **CustomActionWizardTest**, and then choose the **OK** button.

4. In the **SharePoint Customization Wizard**, enter the URL of the site that you want to use for debugging, and then choose the **Finish** button.

5. In **Solution Explorer**, open the shortcut menu for the project node, choose **Add**, and then choose **New Item**.

6. In the **Add New Item - CustomItemWizardTest** dialog box, expand the **SharePoint** node, and then expand the **2010** node.

7. In the list of project items, choose the **Custom Action** item, and then choose the **Add** button.

8. Verify that the code in the other instance of Visual Studio stops on the breakpoint that you set earlier in the `RunStarted` method.

9. Continue to debug the project by choosing the **F5** key or, on the menu bar, choosing **Debug** > **Continue**.

     The SharePoint Customization Wizard appears.

10. Under **Location**, choose the **List Edit** option button.

11. In the **Group ID** list, choose **Communications**.

12. In the **Title** box, enter **SharePoint Developer Center**.

13. In the  **Description** box, enter **Opens the SharePoint Developer Center website**.

14. In the **URL** box, enter `https://docs.microsoft.com/sharepoint/dev/`, and then choose the **Finish** button.

     Visual Studio adds an item that's named **CustomAction1** to your project and opens the *Elements.xml* file in the editor. Verify that *Elements.xml* contains the values that you specified in the wizard.

#### To test the custom action in SharePoint

1. In the experimental instance of Visual Studio, choose the **F5** key or, on the menu bar, choose **Debug** > **Start Debugging**.

     The custom action is packaged and deployed to the SharePoint site specified by the **Site URL** property of the project, and the web browser opens to the default page of this site.

    > [!NOTE]
    > If the **Script Debugging Disabled** dialog box appears, choose the **Yes** button.

2. In the Lists area of the SharePoint site, choose the **Tasks** link.

     The **Tasks - All Tasks** page appears.

3. On the **List Tools** tab of the ribbon, choose the **List** tab, and then, in the **Settings** group, choose **List Settings**.

     The **List Settings** page appears.

4. Under the **Communications** heading near the top of the page, choose the **SharePoint Developer Center** link, verify that the browser opens the website `https://docs.microsoft.com/sharepoint/dev/`, and then close the browser.

## Cleaning up the development computer
 After you finish testing the project item, remove the project item template from the experimental instance of Visual Studio.

#### To clean up the development computer

1. In the experimental instance of Visual Studio, on the menu bar, choose **Tools** > **Extensions and Updates**.

     The **Extensions and Updates** dialog box opens.

2. In the list of extensions, choose the **Custom Action Project Item** extension, and then choose the **Uninstall** button.

3. In the dialog box that appears, choose the **Yes** button to confirm that you want to uninstall the extension, and then choose the **Restart Now** button to complete the uninstallation.

4. Close both instances of Visual Studio (the experimental instance and the instance of Visual Studio in which the CustomActionProjectItem solution is open).

## See also
- [Walkthrough: Create a custom action project item with an item template, Part 1](../sharepoint/walkthrough-creating-a-custom-action-project-item-with-an-item-template-part-1.md)
- [Define custom SharePoint project item types](../sharepoint/defining-custom-sharepoint-project-item-types.md)
- [Create item templates and project templates for SharePoint project items](../sharepoint/creating-item-templates-and-project-templates-for-sharepoint-project-items.md)
- [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)
- [How to: Use Wizards with Project Templates](../extensibility/how-to-use-wizards-with-project-templates.md)
- [Default Custom Action Locations and IDs](/previous-versions/office/developer/sharepoint-2010/bb802730(v=office.14))
