---
title: "How to: Specify Build Events (C#) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "pre-build events"
  - "events [Visual Studio], builds"
  - "post-build events"
  - "build events [Visual Studio]"
  - "builds [Visual Studio], events"
ms.assetid: b4ce1ad9-5215-4b6f-b6a2-798b249aa335
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Specify Build Events (C#)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Use build events to specify commands that run before the build starts or after the build finishes. Build events are executed only if the build successfully reaches those points in the build process.

 When a project is built, pre-build events are added to a file that is named PreBuildEvent.bat and post-build events are added to a file that is named PostBuildEvent.bat. If you want to ensure error checking, add your own error-checking commands to the build steps.

 [!INCLUDE[note_settings_general](../includes/note-settings-general-md.md)]

## How to Specify Pre-Build and Post-Build Events

#### To specify a build event

1. In **Solution Explorer**, select the project for which you want to specify the build event.

2. On the **Project** menu, click **Properties**.

3. Select the **Build Events** tab.

4. In the **Pre-build event command line** box, specify the syntax of the build event.

    > [!NOTE]
    > Pre-build events do not run if the project is up to date and no build is triggered.

5. In the **Post-build event command line** box, specify the syntax of the build event.

    > [!NOTE]
    > Add a `call` statement before all post-build commands that run .bat files. For example, `call C:\MyFile.bat` or `call C:\MyFile.bat call C:\MyFile2.bat`.

6. In the **Run the post-build event** box, specify under what conditions to run the post-build event.

    > [!NOTE]
    > To add lengthy syntax, or to select any build macros from the [Pre-build Event/Post-build Event Command Line Dialog Box](../ide/reference/pre-build-event-post-build-event-command-line-dialog-box.md), click the Ellipsis button (**…**) to display an edit box.

     The build event syntax can include any command that is valid at a command prompt or in a .bat file. The name of a batch file should be preceded by `call` to ensure that all subsequent commands are executed.

     **Note** If your pre-build or post-build event does not complete successfully, you can terminate the build by having your event action exit with a code other than zero (0), which indicates a successful action.

## Example: How to Change Manifest Information by Using a Post-Build Event
 The following procedure shows how to set the minimum operating system version in the application manifest by using an .exe command that is called from a post-build event (the .exe.manifest file in the project directory). The minimum operating system version is a four-part number such as 4.10.0.0. To do this, the command will change the `<dependentOS>` section of the manifest:

```
<dependentOS>
   <osVersionInfo>
      <os majorVersion="4" minorVersion="10" buildNumber="0" servicePackMajor="0" />
   </osVersionInfo>
</dependentOS>
```

#### To create an .exe command to change the application manifest

1. Create a console application for the command. From the **File** menu, point to **New**, and then click **Project**.

2. In the **New Project** dialog box, expand **Visual C#**, click **Windows**, and then click the **Console Application** template. Name the project `ChangeOSVersionCS`.

3. In Program.cs, add the following line to the other `using` statements at the top of the file:

   ```
   using System.Xml;
   ```

4. In the `ChangeOSVersionCS` namespace, replace the `Program` class implementation with the following code:

   ```
   class Program
   {
      /// <summary>
      /// This function will set the minimum operating system version for a ClickOnce application.
      /// </summary>
      /// <param name="args">
      /// Command Line Arguments:
      /// 0 - Path to application manifest (.exe.manifest).
      /// 1 - Version of OS
      ///</param>
      static void Main(string[] args)
      {
         string applicationManifestPath = args[0];
         Console.WriteLine("Application Manifest Path: " + applicationManifestPath);

         // Get version name.
         Version osVersion = null;
         if (args.Length >=2 ){
            osVersion = new Version(args[1]);
         }else{
            throw new ArgumentException("OS Version not specified.");
         }
         Console.WriteLine("Desired OS Version: " + osVersion.ToString());

         XmlDocument document;
         XmlNamespaceManager namespaceManager;
         namespaceManager = new XmlNamespaceManager(new NameTable());
         namespaceManager.AddNamespace("asmv1", "urn:schemas-microsoft-com:asm.v1");
         namespaceManager.AddNamespace("asmv2", "urn:schemas-microsoft-com:asm.v2");

         document = new XmlDocument();
         document.Load(applicationManifestPath);

         string baseXPath;
         baseXPath = "/asmv1:assembly/asmv2:dependency/asmv2:dependentOS/asmv2:osVersionInfo/asmv2:os";

         // Change minimum required operating system version.
         XmlNode node;
         node = document.SelectSingleNode(baseXPath, namespaceManager);
         node.Attributes["majorVersion"].Value = osVersion.Major.ToString();
         node.Attributes["minorVersion"].Value = osVersion.Minor.ToString();
         node.Attributes["buildNumber"].Value = osVersion.Build.ToString();
         node.Attributes["servicePackMajor"].Value = osVersion.Revision.ToString();

         document.Save(applicationManifestPath);
      }
   }
   ```

    The command takes two arguments: the path of the application manifest (that is, the folder in which the build process creates the manifest, typically Projectname.publish), and the new operating system version.

5. Build the project. On the **Build** menu, click **Build Solution**.

6. Copy the .exe file to a directory such as `C:\TEMP\ChangeOSVersionVB.exe`.

   Next, invoke this command in a post-build event to modify the application manifest.

#### To invoke a post-build event to modify the application manifest

1. Create a Windows application for the project to be published. From the **File** menu, point to **New**, and then click **Project**.

2. In the **New Project** dialog box, expand **Visual C#**, click **Windows**, and then click the **Windows Forms Application** template. Name the project `CSWinApp`.

3. With the project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

4. In the Project Designer, locate the **Publish** page and set **Publishing location** to `C:\TEMP\`.

5. Publish the project by clicking **Publish Now**.

     The manifest file will be built and put in `C:\TEMP\CSWinApp_1_0_0_0\CSWinApp.exe.manifest`. To view the manifest, right-click the file, click **Open with**, select **Select the program from a list**, and then click **Notepad**.

     Search in the file for the `<osVersionInfo>` element. For example, the version might be:

    ```
    <os majorVersion="4" minorVersion="10" buildNumber="0" servicePackMajor="0" />
    ```

6. In the Project Designer, click the **Build Events** tab and click the **Edit Post-build** button.

7. In the **Post-build Event Command Line** box, type the following command:

     `C:\TEMP\ChangeOSVersionCS.exe "$(TargetPath).manifest" 5.1.2600.0`

     When you build the project, this command will change the minimum operating system version in the application manifest to 5.1.2600.0.

     Because the `$(TargetPath)` macro expresses the full path for the executable being created,  the `$(TargetPath)`.manifest will specify the application manifest created in the bin directory. Publishing will copy this manifest to the publishing location that you set earlier.

8. Publish the project again. Go to the **Publish** page and click **Publish Now**.

     View the manifest again. To view the manifest, open the publish directory, right-click the file, click **Open with**, select **Select the program from a list**, and then click **Notepad**.

     The version should now read:

    ```
    <os majorVersion="5" minorVersion="1" buildNumber="2600" servicePackMajor="0" />
    ```

## See Also
 [Build Events Page, Project Designer (C#)](../ide/reference/build-events-page-project-designer-csharp.md)
 [Pre-build Event/Post-build Event Command Line Dialog Box](../ide/reference/pre-build-event-post-build-event-command-line-dialog-box.md)
 [How to: Specify Build Events (Visual Basic)](../ide/how-to-specify-build-events-visual-basic.md)
 [Compiling and Building](../ide/compiling-and-building-in-visual-studio.md)
