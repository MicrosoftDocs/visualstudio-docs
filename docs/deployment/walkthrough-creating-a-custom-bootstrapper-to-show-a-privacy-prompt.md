---
title: "Create a custom bootstrapper with a privacy prompt"
description: Learn how to configure ClickOnce applications to automatically update when assemblies with newer file versions and assembly versions become available.
ms.date: "11/04/2016"
ms.topic: how-to
dev_langs:
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "ClickOnce deployment, prerequisites"
  - "dependencies [.NET Framework], custom bootstrapper package"
  - "deploying applications [Visual Studio], custom prerequisites"
  - "Windows Installer deployment, prerequisites"
  - "prerequisites [.NET Framework], custom bootstrapper package"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# Walkthrough: Create a custom bootstrapper with a privacy prompt

You can configure ClickOnce applications to automatically update when assemblies with newer file versions and assembly versions become available. To make sure that your customers consent to this behavior, you can display a privacy prompt to them. Then, they can choose whether to grant permission to the application to update automatically. If the application is not allowed to update automatically, it does not install.

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

## Create an Update Consent dialog box
 To display a privacy prompt, create an application that asks the reader to consent to automatic updates for the application.

#### To create a consent dialog box

1. On the **File** menu, point to **New**, and then click **Project**.

2. In the **New Project** dialog box, click **Windows**, and then click **WindowsFormsApplication**.

3. For the **Name**, type **ConsentDialog**, and then click **OK**.

4. In the designer, click the form.

5. In the **Properties** window, change the **Text** property to **Update Consent Dialog**.

6. In the **Toolbox**, expand **All Windows Forms**, and drag a **Label** control to the form.

7. In the designer, click the label control.

8. In the **Properties** window, change the **Text** property under **Appearance** to the following:

    The application that you are about to install checks for the latest updates on the Web. By clicking on "I Agree", you authorize the application to check for and install updates automatically from the Internet.

9. In the **Toolbox**, drag a **Checkbox** control to the middle of the form.

10. In the **Properties** window, change the **Text** property under **Layout** to **I Agree**.

11. In the **Toolbox**, drag a **Button** control to the lower left of the form.

12. In the **Properties** window, change the **Text** property under **Layout** to **Proceed**.

13. In the **Properties** window, change the **(Name)** property under **Design** to **ProceedButton**.

14. In the **Toolbox**, drag a **Button** control to the bottom right of the form.

15. In the **Properties** window, change the **Text** property under **Layout** to **Cancel**.

16. In the **Properties** window, change the **(Name)** property under **Design** to **CancelButton**.

17. In the designer, double-click the **I Agree** checkbox to generate the CheckedChanged event handler.

18. In the Form1 code file, add the following code for the CheckedChanged event handler.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_ProTools/consentdialog/cs/form1.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_ProTools/consentdialog/vb/form1.vb" id="Snippet1":::
     ---

19. Update the class constructor to disable the **Proceed** button by default.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_ProTools/consentdialog/cs/form1.cs" id="Snippet6":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_ProTools/consentdialog/vb/form1.vb" id="Snippet6":::
     ---

20. In the Form1 code file, add the following code for a Boolean variable to track if the end user has consented to online updates.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_ProTools/consentdialog/cs/form1.cs" id="Snippet3":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_ProTools/consentdialog/vb/form1.vb" id="Snippet3":::
     ---

21. In the designer, double-click the **Proceed** button to generate the Click event handler.

22. In the Form1 code file, add the following code to the Click event handler for the **Proceed** button.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_ProTools/consentdialog/cs/form1.cs" id="Snippet2":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_ProTools/consentdialog/vb/form1.vb" id="Snippet2":::
     ---

23. In the designer, double-click the **Cancel** button to generate the Click event handler.

24. In the Form1 code file, add the following code for the Click event handler for the **Cancel** button.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_ProTools/consentdialog/cs/form1.cs" id="Snippet4":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_ProTools/consentdialog/vb/form1.vb" id="Snippet4":::
     ---

25. Update the application to return an error if the end user does not consent to online updates.

     For Visual Basic developers only:

    1. In **Solution Explorer**, click **ConsentDialog**.

    2. On the **Project** menu, click **Add Module**, and then click **Add**.

    3. In the *Module1.vb* code file, add the following code.

       :::code language="vb" source="../snippets/visualbasic/VS_Snippets_ProTools/consentdialog/vb/module1.vb" id="Snippet7":::

    4. On the **Project** menu, click **ConsentDialog Properties**, and then click the **Application** tab.

    5. Uncheck **Enable application framework**.

    6. In the **Startup object** drop-down menu, select **Module1**.

       > [!NOTE]
       > Disabling the application framework disables features such as visual styles, application events, splash screen, single instance application, and more. For more information, see [Application Page, Project Designer (Visual Basic)](../ide/reference/application-page-project-designer-visual-basic.md).

       For Visual C# developers only:

       Open the *Program.cs* code file, and add the following code.

       :::code language="csharp" source="../snippets/csharp/VS_Snippets_ProTools/consentdialog/cs/program.cs" id="Snippet5":::

26. On the **Build** menu, click **BuildSolution**.

## Create the custom bootstrapper package
 To show the privacy prompt to end users, you can create a custom bootstrapper package for the Update Consent Dialog application and include it as a prerequisite in all of your ClickOnce applications.

 This procedure demonstrates how to create a custom bootstrapper package by creating the following documents:

- A *product.xml* manifest file to describe the contents of the bootstrapper.

- A *package.xml* manifest file to list the localization-specific aspects of your package, such as strings and the software license terms.

- A document for the software license terms.

#### Step 1: To create the bootstrapper directory

1. Create a directory named **UpdateConsentDialog** in the *%PROGRAMFILES%\Microsoft SDKs\Windows\v7.0A\Bootstrapper\Packages*.

    > [!NOTE]
    > You may need administrative privileges to create this folder.

2. In the *UpdateConsentDialog* directory, create a subdirectory named *en*.

    > [!NOTE]
    > Create a new directory for each locale. For example, you can add subdirectories for the fr and de locales. These directories would contain the French and German strings and language packs, if necessary.

#### Step 2: To create the product.xml manifest file

1. Create a text file called *product.xml*.

2. In the *product.xml* file, add the following XML code. Make sure that you do not overwrite the existing XML code.

    ```xml
    <Product
      xmlns="http://schemas.microsoft.com/developer/2004/01/bootstrapper"
      ProductCode="Microsoft.Sample.EULA">
      <!-- Defines the list of files to be copied on build. -->
      <PackageFiles CopyAllPackageFiles="false">
        <PackageFile Name="ConsentDialog.exe"/>
      </PackageFiles>

      <!-- Defines how to run the Setup package.-->
      <Commands >
        <Command PackageFile = "ConsentDialog.exe" Arguments=''>
          <ExitCodes>
            <ExitCode Value="0" Result="Success" />
            <ExitCode Value="-1" Result="Fail" String="AU_Unaccepted" />
            <DefaultExitCode Result="Fail"
              FormatMessageFromSystem="true" String="GeneralFailure" />
          </ExitCodes>
        </Command>
      </Commands>

    </Product>
    ```

3. Save the file to the UpdateConsentDialog bootstrapper directory.

#### Step 3: To create the package.xml manifest file and the software license terms

1. Create a text file called *package.xml*.

2. In the *package.xml* file, add the following XML code to define the locale and include the software license terms. Make sure that you do not overwrite the existing XML code.

    ```xml
    <Package
      xmlns="http://schemas.microsoft.com/developer/2004/01/bootstrapper"
      Name="DisplayName"
      Culture="Culture"
      LicenseAgreement="eula.rtf">
      <PackageFiles>
        <PackageFile Name="eula.rtf"/>
      </PackageFiles>

      <!-- Defines a localizable string table for error messages. -->
      <Strings>
        <String Name="DisplayName">Update Consent Dialog</String>
        <String Name="Culture">en</String>
        <String Name="AU_Unaccepted">The automatic update agreement is not accepted.</String>
        <String Name="GeneralFailure">A failure occurred attempting to launch the setup.</String>
      </Strings>
    </Package>
    ```

3. Save the file to the en subdirectory in the UpdateConsentDialog bootstrapper directory.

4. Create a document called *eula.rtf* for the software license terms.

    > [!NOTE]
    > The software license terms should include information about licensing, warranties, liabilities, and local laws. These files should be locale-specific, so make sure that the file is saved in a format that supports MBCS or UNICODE characters. Consult your legal department about the content of the software license terms.

5. Save the document to the en subdirectory in the *UpdateConsentDialog* bootstrapper directory.

6. If necessary, create a new *package.xml* manifest file and a new *eula.rtf* document for the software license terms for each locale. For example, if you created subdirectories for the fr and de locales, create separate package.xml manifest files and software license terms and save them to the fr and de subdirectories.

## Set the Update Consent Application as a prerequisite
 In Visual Studio, you can set the Update Consent application as a prerequisite.

#### To set the Update Consent Application as a prerequisite

1. In **Solution Explorer**, click the name of your application that you want to deploy.

2. On the **Project** menu, click *ProjectName* **Properties**.

3. Click the **Publish** page, and then click **Prerequisites**.

4. Select **Update Consent Dialog**.

    > [!NOTE]
    > You may have to close and reopen Visual Studio to see the Update Consent Dialog in the Prerequisites Dialog Box.

5. Click **OK**.

## Create and test the Setup program
 After you set the Update Consent application as a prerequisite, you can generate the installer and bootstrapper for your application.

#### To create and test the Setup program by not clicking I agree

1. In **Solution Explorer**, click the name of your application that you want to deploy.

2. On the **Project** menu, click *ProjectName* **Properties**.

3. Click the **Publish** page, and then click **Publish Now**.

4. If the publish output does not open automatically, navigate to the publish output.

5. Run the *Setup.exe* program.

     The Setup program shows the Update Consent Dialog software license agreement.

6. Read the software license agreement, and then click **Accept**.

     The Update Consent Dialog application appears and shows the following text: The application that you are about to install checks for the latest updates on the Web. By clicking on I Agree, you authorize the application to check for updates automatically on the Internet.

7. Close the application or click Cancel.

     The application shows an error: An error occurred while installing system components for *ApplicationName*. Setup cannot continue until all system components have been successfully installed.

8. Click Details to show the following error message: Component Update Consent Dialog has failed to install with the following error message: "The automatic update agreement is not accepted." The following components failed to install: - Update Consent Dialog

9. Click **Close**.

#### To create and test the Setup program by clicking I agree

1. In **Solution Explorer**, click the name of your application that you want to deploy.

2. On the **Project** menu, click *ProjectName* **Properties**.

3. Click the **Publish** page, and then click **Publish Now**.

4. If the publish output does not open automatically, navigate to the publish output.

5. Run the *Setup.exe* program.

     The Setup program shows the Update Consent Dialog software license agreement.

6. Read the software license agreement, and then click **Accept**.

     The Update Consent Dialog application appears and shows the following text: The application that you are about to install checks for the latest updates on the Web. By clicking on I Agree, you authorize the application to check for updates automatically on the Internet.

7. Click **I Agree**, and then click **Proceed**.

     The application starts to install.

8. If the Application Install dialog box appears, click **Install**.

## Related content
- [Application deployment prerequisites](../deployment/application-deployment-prerequisites.md)
- [Create bootstrapper packages](../deployment/creating-bootstrapper-packages.md)
- [How to: Create a product manifest](../deployment/how-to-create-a-product-manifest.md)
- [How to: Create a package manifest](../deployment/how-to-create-a-package-manifest.md)
- [Product and package schema reference](../deployment/product-and-package-schema-reference.md)
