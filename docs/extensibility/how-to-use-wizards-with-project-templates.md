---
title: 'Use Wizards with Project Templates'
description: Use the IWizard interface in the Visual Studio SDK, which enables you to run custom code when a user creates a project from a template.
ms.date: 3/16/2019
ms.topic: how-to
helpviewer_keywords:
- project templates [Visual Studio], wizards
- Visual Studio templates, wizards
- wizards [Visual Studio], project templates
- templates [Visual Studio], wizards
- IWizard interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Use wizards with project templates

Visual Studio provides the <xref:Microsoft.VisualStudio.TemplateWizard.IWizard> interface that, when implemented, enables you to run custom code when a user creates a project from a template.

Project template customization can be used to display custom UI that collects user input to customize the template, add additional files to the template, or any other action allowed on a project.

The <xref:Microsoft.VisualStudio.TemplateWizard.IWizard> interface methods are called at various times while the project is being created, starting as soon as a user clicks **OK** on the **New Project** dialog box. Each method of the interface is named to describe the point at which it is called. For example, Visual Studio calls <xref:Microsoft.VisualStudio.TemplateWizard.IWizard.RunStarted%2A> immediately when it starts to create the project, making it a good location to write custom code to collect user input.

## Create a project template project with a VSIX project

You start creating a custom template with the project template project, which is part of the Visual Studio SDK. In this procedure, we'll use a C# project template project, but there is also a Visual Basic project template project. Then you add a VSIX project to the solution that contains the project template project.

1. Create a C# project template project (in Visual Studio, select **File** > **New** > **Project** and search for "project template"). Name it **MyProjectTemplate**.

   > [!NOTE]
   > You may be asked to install the Visual Studio SDK. For more information, see [Installing the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).

2. Add a new VSIX project in the same solution as the project template project (in **Solution Explorer**, select the solution node, right-click, and select **Add** > **New Project** and search for "vsix"). Name it **MyProjectWizard.**

3. Set the VSIX project as the startup project. In **Solution Explorer**, select the VSIX project node, right-click, and select **Set as Startup Project**.

4. Add the template project as an asset of the VSIX project. In **Solution Explorer**, under the VSIX project node, find the *source.extension.vsixmanifest* file. Double-click it to open it in the manifest editor.

5. In the manifest editor, select the **Assets** tab on the left side of the window.

6. In the **Assets** tab, select **New**. In the **Add New Asset** window, for the Type field, select **Microsoft.VisualStudio.ProjectTemplate**. In the **Source** field, select **A project in current solution**. In the **Project** field, select **MyProjectTemplate**. Then click **OK**.

7. Build the solution and start debugging. A second instance of Visual Studio appears. (This may take a few minutes.)

8. In the second instance of Visual Studio, try to create a new project with your new template (**File** > **New** > **Project**, search for "myproject"). The new project should appear with a class named **Class1**. You have now created a custom project template! Stop debugging now.

## Create a custom template wizard

This procedure shows how to create a custom wizard that opens a Windows Form before the project is created. The form allows users to add a custom parameter value that is added to the source code during project creation.

1. Set up the VSIX project to allow it to create an assembly.

2. In **Solution Explorer**, select the VSIX project node. Below **Solution Explorer**, you should see the **Properties** window. If you do not, select **View** > **Properties Window**, or press **F4**. In the **Properties** window, select the following fields to `true`:

   - **Include Assembly in VSIX Container**

   - **Include Debug Symbols in Local VSIX Deployment**

   - **Include Debug Symbols in VSIX Container**

3. Add the assembly as an asset to the VSIX project. Open the *source.extension.vsixmanifest* file and select the **Assets** tab. In the **Add New Asset** window, for **Type** select **Microsoft.VisualStudio.Assembly**, for **Source** select **A project in current solution**, and for **Project** select **MyProjectWizard**.

4. Add the following references to the VSIX project. (In **Solution Explorer**, under the VSIX project node, select **References**, right-click, and select **Add Reference**.) In the **Add Reference** dialog,  in the **Framework** tab, find the **System.Windows Forms** assembly and select it. Also find and select the **System** and **System.Drawing** assemblies. Now select the **Extensions** tab. Find the **EnvDTE** assembly and select it. Also find the **Microsoft.VisualStudio.TemplateWizardInterface** assembly and select it. Click **OK**.

5. Add a class for the wizard implementation to the VSIX project. (In **Solution Explorer**, right-click the VSIX project node and select **Add**, then **New Item**, then **Class**.) Name the class **WizardImplementation**.

6. Replace the code in the *WizardImplementationClass.cs* file with the following code:

   ```csharp
   using System;
   using System.Collections.Generic;
   using Microsoft.VisualStudio.TemplateWizard;
   using System.Windows.Forms;
   using EnvDTE;

   namespace MyProjectWizard
   {
       public class WizardImplementation:IWizard
       {
           private UserInputForm inputForm;
           private string customMessage;

           // This method is called before opening any item that
           // has the OpenInEditor attribute.
           public void BeforeOpeningFile(ProjectItem projectItem)
           {
           }

           public void ProjectFinishedGenerating(Project project)
           {
           }

           // This method is only called for item templates,
           // not for project templates.
           public void ProjectItemFinishedGenerating(ProjectItem
               projectItem)
           {
           }

           // This method is called after the project is created.
           public void RunFinished()
           {
           }

           public void RunStarted(object automationObject,
               Dictionary<string, string> replacementsDictionary,
               WizardRunKind runKind, object[] customParams)
           {
               try
               {
                   // Display a form to the user. The form collects
                   // input for the custom message.
                   inputForm = new UserInputForm();
                   inputForm.ShowDialog();

                   customMessage = UserInputForm.CustomMessage;

                   // Add custom parameters.
                   replacementsDictionary.Add("$custommessage$",
                       customMessage);
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.ToString());
               }
           }

           // This method is only called for item templates,
           // not for project templates.
           public bool ShouldAddProjectItem(string filePath)
           {
               return true;
           }
       }
   }
   ```

    The **UserInputForm** referenced in this code will be implemented later.

    The `WizardImplementation` class contains method implementations for every member of <xref:Microsoft.VisualStudio.TemplateWizard.IWizard>. In this example, only the <xref:Microsoft.VisualStudio.TemplateWizard.IWizard.RunStarted%2A> method performs a task. All other methods either do nothing or return `true`.

    The <xref:Microsoft.VisualStudio.TemplateWizard.IWizard.RunStarted%2A> method accepts four parameters:

   - An <xref:System.Object> parameter that can be cast to the root <xref:EnvDTE._DTE> object, to enable you to customize the project.

   - A <xref:System.Collections.Generic.Dictionary%602> parameter that contains a collection of all pre-defined parameters in the template. For more information on template parameters, see [Template parameters](../ide/template-parameters.md).

   - A <xref:Microsoft.VisualStudio.TemplateWizard.WizardRunKind> parameter that contains information about what kind of template is being used.

   - An <xref:System.Object> array that contains a set of parameters passed to the wizard by Visual Studio.

     This example adds a parameter value from the user input form to the <xref:System.Collections.Generic.Dictionary%602> parameter. Every instance of the `$custommessage$` parameter in the project will be replaced with the text entered by the user.

7. Now create the **UserInputForm**. In the *WizardImplementation.cs* file, add the following code after the end of the `WizardImplementation` class.

   ```csharp
   public partial class UserInputForm : Form
       {
           private static string customMessage;
           private TextBox textBox1;
           private Button button1;

           public UserInputForm()
           {
               this.Size = new System.Drawing.Size(155, 265);

               button1 = new Button();
               button1.Location = new System.Drawing.Point(90, 25);
               button1.Size = new System.Drawing.Size(50, 25);
               button1.Click += button1_Click;
               this.Controls.Add(button1);

               textBox1 = new TextBox();
               textBox1.Location = new System.Drawing.Point(10, 25);
               textBox1.Size = new System.Drawing.Size(70, 20);
               this.Controls.Add(textBox1);
           }
           public static string CustomMessage
           {
               get
               {
                   return customMessage;
               }
               set
               {
                   customMessage = value;
               }
           }
           private void button1_Click(object sender, EventArgs e)
           {
               customMessage = textBox1.Text;
               this.Close();
           }
       }
   ```

    The user input form provides a simple form for entering a custom parameter. The form contains a text box named `textBox1` and a button named `button1`. When the button is clicked, the text from the text box is stored in the `customMessage` parameter.

## Connect the wizard to the custom template

In order for your custom project template to use your custom wizard, you need to sign the wizard assembly and add some lines to your custom project template to let it know where to find the wizard implementation when a new project is created.

1. Sign the assembly. In the **Solution Explorer**, select the VSIX project, right-click, and select **Project Properties**.

2. In the **Project Properties** window, select the **Signing** tab. in the **Signing** tab, check **Sign the assembly**. In the **Choose a strong name key file** field, select **\<New>**. In the **Create Strong Name Key** window, in the **Key file name** field, type **key.snk**. Uncheck the **Protect my key file with a password** field.

3. In the **Solution Explorer**, select the VSIX project and find the **Properties** window.

4. Set the **Copy Build Output to Output Directory** field to **true**. This allows the assembly to be copied into the output directory when the solution is rebuilt. It is still contained in the `.vsix` file. You need to see the assembly in order to find out its signing key.

5. Rebuild the solution.

6. You can now find the key.snk file in the MyProjectWizard project directory (*\<your disk location>\MyProjectTemplate\MyProjectWizard\key.snk*). Copy the *key.snk* file.

7. Go to the output directory and find the assembly (*\<your disk location>\MyProjectTemplate/MyProjectWizard\bin\Debug\MyProjectWizard.dll*). Paste the *key.snk* file here. (This isn't absolutely necessary, but it will make the following steps easier.)

8. Open a command window, and change to the directory in which the assembly has been created.

9. Find the *sn.exe* signing tool. For example, on a Windows 10 64-bit operating system, a typical path would be the following:

     *C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.1 Tools*

     If you can't find the tool, try running **where /R . sn.exe** in the command window. Make a note of the path.

10. Extract the public key from the *key.snk* file. In the command window, type

     **\<location of sn.exe>\sn.exe -p key.snk outfile.key.**

     Don't forget to surround the path of *sn.exe* with quotation marks if there are spaces in the directory names!

11. Get the public key token from the outfile:

     **\<location of sn.exe>\sn.exe -t outfile.key.**

     Again, don't forget the quotation marks. You should see a line in the output like this

     **Public key token is \<token>**

     Make a note of this value.

12. Add the reference to the custom wizard to the *.vstemplate* file of the project template. In the **Solution Explorer**, find the file named *MyProjectTemplate.vstemplate*, and open it. After the end of the \<TemplateContent> section, add the following section:

    ```xml
    <WizardExtension>
        <Assembly>MyProjectWizard, Version=1.0.0.0, Culture=Neutral, PublicKeyToken=token</Assembly>
        <FullClassName>MyProjectWizard.WizardImplementation</FullClassName>
    </WizardExtension>
    ```

     Where **MyProjectWizard** is the name of the assembly, and **token** is the token you copied in the previous step.

13. Save all the files in the project and rebuild.

## Add the custom parameter to the template

In this example, the project used as the template displays the message specified in the user input form of the custom wizard.

1. In the **Solution Explorer**, go to the **MyProjectTemplate** project and open *Class1.cs*.

2. In the `Main` method of the application, add the following line of code.

   ```csharp
   Console.WriteLine("$custommessage$");
   ```

    The parameter `$custommessage$` is replaced with the text entered in the user input form when a project is created from the template.

Here is the full code file before it has been exported to a template.

```csharp
using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;

namespace $safeprojectname$
{
    public class Class1
    {
          static void Main(string[] args)
          {
               Console.WriteLine("$custommessage$");
          }
    }
}
```

## Use the custom wizard

Now you can create a project from your template and use the custom wizard.

1. Rebuild the solution and start debugging. A second instance of Visual Studio should appear.

2. Create a new MyProjectTemplate project. (**File** > **New** > **Project**).

3. In the **New Project** dialog box, search for "myproject" to locate your template, type a name, and click **OK**.

     The wizard user input form opens.

4. Type a value for the custom parameter and click the button.

     The wizard user input form closes, and a project is created from the template.

5. In **Solution Explorer**, right-click the source code file and click **View Code**.

     Notice that `$custommessage$` has been replaced with the text entered in the wizard user input form.

## Related content

- <xref:Microsoft.VisualStudio.TemplateWizard.IWizard>
- [Customize templates](../ide/customizing-project-and-item-templates.md)
- [WizardExtension element (Visual Studio templates)](../extensibility/wizardextension-element-visual-studio-templates.md)
- [NuGet packages in Visual Studio templates](/nuget/visual-studio-extensibility/visual-studio-templates)
