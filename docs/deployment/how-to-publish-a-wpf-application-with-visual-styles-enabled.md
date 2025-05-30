---
title: Publish a WPF app with visual styles enabled
description: Learn how to publish a WPF application with visual styles enabled, which allows the appearance of controls to change based on the theme chosen by the user.
ms.date: 11/04/2016
ms.topic: how-to
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# Publish a WPF application with visual styles enabled

Visual styles enable the appearance of common controls to change based on the theme chosen by the user. By default, visual styles are not enabled for Windows Presentation Foundation (WPF) applications, so you must enable them manually. However, enabling visual styles for a WPF application and then publishing the solution causes an error. This topic describes how to resolve this error and the process for publishing a WPF application with visual styles enabled. For more information about visual styles, see [Visual styles overview](/windows/desktop/Controls/visual-styles-overview). For more information about the error message, see [Troubleshoot specific errors in ClickOnce deployments](/troubleshoot/developer/visualstudio/ide/troubleshoot-clickonce-deployments).

 To resolve the error and to publish the solution, you must perform the following tasks:

- [Publish the solution without visual styles enabled](#publish-the-solution-without-visual-styles-enabled).

- [Create a manifest file](#create-a-manifest-file).

- [Embed the manifest file into the executable file of the published solution](#embed-the-manifest-file-into-the-executable-file-of-the-published-solution).

- [Sign the application and deployment manifests](#sign-the-application-and-deployment-manifests).

  Then, you can move the published files to the location from which you want end users to install the application.

## Publish the solution without visual styles enabled

1. Ensure that your project does not have visual styles enabled. First, check your project's manifest file for the following XML. Then, if the XML is present, enclose the XML with a comment tag.

     By default, visual styles are not enabled.

    ```xml
    <dependency>
        <dependentAssembly>
            <assemblyIdentity type="win32" name="Microsoft.Windows.Common-Controls" version="6.0.0.0" processorArchitecture="*" publicKeyToken="6595b64144ccf1df" language="*" />
        </dependentAssembly>
    </dependency>
    ```

     The following procedures show how to open the manifest file associated with your project.

    **To open the manifest file in a Visual Basic project**

    1. On the menu bar, choose **Project**, *ProjectName* **Properties**, where *ProjectName* is the name of your WPF project.

         The property pages for your WPF project appear.

    2. On the **Application** tab, choose **View Windows Settings**.

         The app.manifest file opens in the **Code Editor**.

    **To open the manifest file in a C# project**

    1. On the menu bar, choose **Project**, *ProjectName* **Properties**, where *ProjectName* is the name of your WPF project.

         The property pages for your WPF project appear.

    2. On the **Application** tab, make a note of the name that appears in the manifest field. This is the name of the manifest that is associated with your project.

        > [!NOTE]
        > If **Embed manifest with default settings** or **Create application without manifest** appear in the manifest field, visual styles are not enabled. If the name of a manifest file appears in the manifest field, proceed to the next step in this procedure.

    3. In **Solution Explorer**, choose **Show All Files**.

         This button shows all project items, including those that have been excluded and those that are normally hidden. The manifest file appears as a project item.

2. Build and publish your solution. For more information about how to publish the solution, see [How to: Publish a ClickOnce application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md).

## Create a manifest file

1. Paste the following XML into a Notepad file.

     This XML describes the assembly that contains controls that support visual styles.

    ```xml
    <?xml version="1.0" encoding="utf-8"?>
    <asmv1:assembly manifestVersion="1.0"
        xmlns="urn:schemas-microsoft-com:asm.v1"
        xmlns:asmv1="urn:schemas-microsoft-com:asm.v1"
        xmlns:asmv2="urn:schemas-microsoft-com:asm.v2"
        xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
        <dependency>
            <dependentAssembly>
                <assemblyIdentity type="win32" name="Microsoft.Windows.Common-Controls" version="6.0.0.0" processorArchitecture="*" publicKeyToken="6595b64144ccf1df" language="*" />
            </dependentAssembly>
        </dependency>
    </asmv1:assembly>
    ```

2. In Notepad, click **File**, and then click **Save As**.

3. In the **Save As** dialog box, in the **Save as type** drop-down list, select **All Files**.

4. In the **File name** box, name the file and append *.manifest* to the end of the file name. For example: *themes.manifest*.

5. Choose the **Browse Folders** button, select any folder, and then click **Save**.

    > [!NOTE]
    > The remaining procedures assume that the name of this file is *themes.manifest* and that the file is saved to the *C:\temp* directory on your computer.

## Embed the manifest file into the executable file of the published solution

1. Open **Developer Command Prompt for Visual Studio**.

    For more information about how to open Developer Command Prompt for Visual Studio, see [Developer Command Prompt and Developer PowerShell](../ide/reference/command-prompt-powershell.md).

   > [!NOTE]
   > The remaining steps make the following assumptions about your solution:
   >
   > - The name of the solution is **MyWPFProject**.
   > - The solution is located in the following directory: `%UserProfile%\Documents\Visual Studio version\Projects\`.
   >
   > - The solution is published to the following directory: `%UserProfile%\Documents\Visual Studio version\Projects\publish`.
   > - The most recent version of the published application files is located in the following directory: `%UserProfile%\Documents\Visual Studio version\Projects\publish\Application Files\WPFApp_1_0_0_0`
   >
   > You do not have to use the name or the directory locations described above. The name and locations described above are used only to illustrate the steps required to publish your solution.

2. At the command prompt, change the path to the directory that contains the most recent version of the published application files. The following example demonstrates this step.

   ```cmd
   cd "%UserProfile%\Documents\Visual Studio version\Projects\MyWPFProject\publish\Application Files\WPFApp_1_0_0_0"
   ```

3. At the command prompt, run the following command to embed the manifest file into the executable file of the application.

   ```cmd
   mt -manifest c:\temp\themes.manifest -outputresource:MyWPFApp.exe.deploy
   ```

## Sign the application and deployment manifests

1. At the command prompt, run the following command to remove the *.deploy* extension from the executable file in the current directory.

   ```cmd
   ren MyWPFApp.exe.deploy MyWPFApp.exe
   ```

   > [!NOTE]
   > This example assumes that only one file has the *.deploy* file extension. Make sure that you rename all files in this directory that have the *.deploy* file extension.

2. At the command prompt, run the following command to sign the application manifest.

   ```cmd
   mage -u MyWPFApp.exe.manifest -cf ..\..\..\MyWPFApp_TemporaryKey.pfx
   ```

   > [!NOTE]
   > This example assumes that you sign the manifest by using the *.pfx* file of the project. If you are not signing the manifest, you can omit the `-cf` parameter that is used in this example. If you are signing the manifest with a certificate that requires a password, specify the `-password` option (`For example: mage -u MyWPFApp.exe.manifest -cf ..\..\..\MyWPFApp_TemporaryKey.pfx - password Password`).

3. At the command prompt, run the following command to add the *.deploy* extension to the name of the file that you renamed in a previous step of this procedure.

   ```
   ren MyWPFApp.exe MyWPFApp.exe.deploy
   ```

   > [!NOTE]
   > This example assumes that only one file had a *.deploy* file extension. Make sure that you rename all files in this directory that previously had the *.deploy* file name extension.

4. At the command prompt, run the following command to sign the deployment manifest.

   ```
   mage -u ..\..\MyWPFApp.application -appm MyWPFApp.exe.manifest -cf ..\..\..\MyWPFApp_TemporaryKey.pfx
   ```

   > [!NOTE]
   > This example assumes that you sign the manifest by using the *.pfx* file of the project. If you are not signing the manifest, you can omit the `-cf` parameter that is used in this example. If you are signing the manifest with a certificate that requires a password, specify the `-password` option, as in this example:`For example: mage -u MyWPFApp.exe.manifest -cf ..\..\..\MyWPFApp_TemporaryKey.pfx - password Password`.

   After you have performed these steps, you can move the published files to the location from which you want end users to install the application. If you intend to update the solution often, you can move these commands into a script and run the script each time that you publish a new version.

## Related content

- [Troubleshooting Specific Errors in ClickOnce Deployments](/troubleshoot/developer/visualstudio/ide/troubleshoot-clickonce-deployments)
- [Visual Styles Overview](/windows/desktop/Controls/visual-styles-overview)
- [Enabling Visual Styles](/windows/desktop/Controls/cookbook-overview)
- [Developer Command Prompt and Developer PowerShell](../ide/reference/command-prompt-powershell.md)
