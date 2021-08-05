---
title: MSI and VSIX Deployment of a DSL
description: Learn how you can install a domain-specific language (DSL) on your own computer or on other computers. 
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
author: mgoertz-msft
ms.author: mgoertz
manager: jmartens
ms.technology: vs-ide-modeling
ms.workload:
- multiple
---
# MSI and VSIX Deployment of a DSL
You can install a domain-specific language on your own computer or on other computers. Visual Studio must already be installed on the target computer.

## <a name="which"></a> Choosing between VSIX and MSI Deployment
 There are two methods of deploying a domain-specific language:

|Method|Benefits|
|-|-|
|VSX (Visual Studio Extension)|Very easy to deploy: Copy and execute the **.vsix** file from the DslPackage project.<br /><br /> For more information see [Installing and Uninstalling a DSL by using the VSX](#Installing).|
|MSI (installer file)|-   Allows the user to open Visual Studio by double-clicking a DSL file.<br />-   Associates an icon with the DSL file type in the target computer.<br />-   Associates an XSD (XML schema) with the DSL file type. This avoids warnings when the file is loaded into Visual Studio.<br /><br /> You must add a setup project to your solution to create an MSI.<br /><br /> For more information, see [Deploying a DSL by using an MSI file](#msi).|

## <a name="Installing"></a> Install and Uninstall a DSL by using the VSX

When your DSL is installed by this method, the user can open a DSL file from within Visual Studio, but the file cannot be opened from Windows Explorer.

### To install a DSL by using the VSX

1. Locate the **.vsix** file that was built by your DSL Package project:

   1. In **Solution Explorer**, right-click the **DslPackage** project, and then click **Open Folder in File Explorer**.

   2. Locate the file **bin\\\*\\**_YourProject_**.DslPackage.vsix**

2. Copy the **.vsix** file to the target computer on which you want to install the DSL. This can be your own computer or another one.

   - The target computer must have one of the editions of [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)] that supports DSLs at run time. For more information, see [Supported Visual Studio Editions for Visualization & Modeling SDK](../modeling/supported-visual-studio-editions-for-visualization-amp-modeling-sdk.md).

   - The target computer must have one of the editions of Visual Studio specified in **DslPackage\source.extensions.manifest**.

3. On the target computer, double-click the **.vsix** file.

    **Visual Studio Extension Installer** opens and installs the extension.

4. Start or restart [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)].

5. To test the DSL, use Visual Studio to create a new file that has the extension that you defined for your DSL.

### To uninstall a DSL that was installed by using VSX

1. On the **Tools** menu, choose **Extensions and Updates**.

2. Expand **Installed Extensions**.

3. Select the extension in which the DSL is defined, and then click **Uninstall**.

   Rarely, a faulty extension fails to load and creates a report in the error window, but does not appear in Extension Manager. In that case, you can remove the extension by deleting the file from:

   *LocalAppData* **\Microsoft\VisualStudio\10.0\Extensions**

## <a name="msi"></a> Deploying a DSL in an MSI
 By defining an MSI (Windows Installer) file for your DSL, you can allow users to open DSL files from Windows Explorer. You can also associate an icon and short description with your file name extension. In addition, the MSI can install an XSD that can be used to validate DSL files. If you want, you can add other components into the MSI that will be installed at the same time.

 For more information about MSI files and other deployment options, see [Deploying Applications, Services, and Components](../deployment/deploying-applications-services-and-components.md).

 To build an MSI, you add a Setup project to your Visual Studio solution. The easiest method of creating a Setup project is to use the CreateMsiSetupProject.tt template, which you can download from the [VMSDK site](https://code.msdn.microsoft.com/Visualization-and-Modeling-313535db).

### To Deploy a DSL in an MSI

1. Set `InstalledByMsi` in the extension manifest. This prevents the VSX from being installed and uninstalled except by the MSI. This is important if you will include other components in the MSI.

   1. Open DslPackage\source.extension.tt

   2. Insert the following line before `<SupportedProducts>`:

       ```xml
       <InstalledByMsi>true</InstalledByMsi>
       ```

2. Create or edit an icon that will represent your DSL in Windows Explorer. For example, edit **DslPackage\Resources\File.ico**

3. Make sure that the following attributes of your DSL are correct:

   - In DSL Explorer click the root node, and in Properties window, review:

       - Description

       - Version

   - Click the **Editor** node and in the Properties window, click **Icon**. Set the value to reference an icon file in **DslPackage\Resources**, such as **File.ico**

   - On the **Build** menu, open **Configuration Manager**, and select the configuration that you want to build, such as **Release** or **Debug**.

4. Go to [Visualization and Modeling SDK home page](https://code.msdn.microsoft.com/Visualization-and-Modeling-313535db), and from the **Downloads** tab, download **CreateMsiSetupProject.tt**.

5. Add **CreateMsiSetupProject.tt** to your Dsl project.

    Visual Studio will create a file named **CreateMsiSetupProject.vdproj**.

6. In Windows Explorer, copy Dsl\\*.vdproj to a new folder named Setup.

    (If you want, you can now exclude CreateMsiSetupProject.tt from your Dsl project.)

7. In **Solution Explorer**, add **Setup\\\*.vdproj** as an existing project.

8. On the **Project** menu, click **Project Dependencies**.

    In the **Project Dependencies** dialog box, select the setup project.

    Select the box next to **DslPackage**.

9. Rebuild the solution.

10. In Windows Explorer, locate the built MSI file in your Setup project.

     Copy the MSI file to a computer on which you want to install your DSL. Double-click the MSI file. The installer runs.

11. In the target computer, create a new file that has the file extension of your DSL. Verify that:

    - In Windows Explorer list view, the file appears with the icon and description that you defined.

    - When you double-click the file, Visual Studio starts, and opens the DSL file in your DSL editor.

    If you prefer, you can create the Setup project manually, instead of using the text template. For a walkthrough that includes this procedure see Chapter 5 of the [Visualization and Modeling SDK Lab](https://code.msdn.microsoft.com/DSLToolsLab/Release/ProjectReleases.aspx?ReleaseId=4207).

### To uninstall a DSL that was installed from an MSI

1. In Windows, open the **Programs and Features** control panel.

2. Uninstall the DSL.

3. Restart Visual Studio.
