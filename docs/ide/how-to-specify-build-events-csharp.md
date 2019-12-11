---
title: "How to: Specify build events (C#)"
ms.date: 03/21/2019
ms.technology: vs-ide-compile
ms.topic: conceptual
helpviewer_keywords:
  - "pre-build events"
  - "events [Visual Studio], builds"
  - "post-build events"
  - "build events [Visual Studio]"
  - "builds [Visual Studio], events"
ms.assetid: b4ce1ad9-5215-4b6f-b6a2-798b249aa335
author: ghogen
ms.author: ghogen
manager: jillfra
ms.workload:
  - "dotnet"
---
# How to: Specify build events (C#)

Use build events to specify commands that run before the build starts or after the build finishes. Build events execute only if the build successfully reaches those points in the build process.

When a project is built, pre-build events are added to a file named *PreBuildEvent.bat* and post-build events are added to a file named *PostBuildEvent.bat*. If you want to ensure error checking, add your own error-checking commands to the build steps.

## Specify a build event

1. In **Solution Explorer**, select the project for which you want to specify the build event.

2. On the **Project** menu, click **Properties**.

3. Select the **Build Events** tab.

4. In the **Pre-build event command line** box, specify the syntax of the build event.

   > [!NOTE]
   > Pre-build events do not run if the project is up to date and no build is triggered.

5. In the **Post-build event command line** box, specify the syntax of the build event.

   > [!NOTE]
   > Add a `call` statement before all post-build commands that run *.bat* files. For example, `call C:\MyFile.bat` or `call C:\MyFile.bat call C:\MyFile2.bat`.

6. In the **Run the post-build event** box, specify under what conditions to run the post-build event.

   > [!NOTE]
   > To add lengthy syntax, or to select any build macros from the [Pre-build event/post-build event command line dialog box](../ide/reference/pre-build-event-post-build-event-command-line-dialog-box.md), click the ellipsis button (**...**) to display an edit box.

   The build event syntax can include any command that is valid at a command prompt or in a *.bat* file. The name of a batch file should be preceded by `call` to ensure that all subsequent commands are executed.

   > [!NOTE]
   > If your pre-build or post-build event does not complete successfully, you can terminate the build by having your event action exit with a code other than zero (0), which indicates a successful action.

## Example

The following procedure shows how to set the minimum operating system version in the application manifest by using an *.exe* command that is called from a post-build event (the *.exe.manifest* file in the project directory). The minimum operating system version is a four-part number such as 4.10.0.0. To set the minimum operating system version, the command will change the `<dependentOS>` section of the manifest:

```xml
<dependentOS>
   <osVersionInfo>
      <os majorVersion="4" minorVersion="10" buildNumber="0" servicePackMajor="0" />
   </osVersionInfo>
</dependentOS>
```

### Create an .exe command to change the application manifest

1. Create a new **Console App** project for the command. Name the project **ChangeOSVersionCS**.

2. In *Program.cs*, add the following line to the other `using` directives at the top of the file:

   ```csharp
   using System.Xml;
   ```

3. In the `ChangeOSVersionCS` namespace, replace the `Program` class implementation with the following code:

   ```csharp
   class Program
   {
      /// <summary>
      /// This function sets the minimum operating system version for a ClickOnce application.
      /// </summary>
      /// <param name="args">
      /// Command Line Arguments:
      /// 0 - Path to application manifest (.exe.manifest)
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

   The command takes two arguments: the path of the application manifest (that is, the folder in which the build process creates the manifest, typically *Projectname.publish*), and the new operating system version.

4. Build the project.

5. Copy the *.exe* file to a directory such as *C:\TEMP\ChangeOSVersionVB.exe*.

Next, invoke this command in a post-build event to modify the application manifest.

### Invoke a post-build event to modify the application manifest

1. Create a new **Windows Forms App** project and name it **CSWinApp**.

2. With the project selected in **Solution Explorer**, on the **Project** menu, choose **Properties**.

3. In the **Project Designer**, locate the **Publish** page and set **Publishing location** to *C:\TEMP*.

4. Publish the project by clicking **Publish Now**.

   The manifest file is built and saved to *C:\TEMP\CSWinApp_1_0_0_0\CSWinApp.exe.manifest*. To view the manifest, right-click the file, click **Open with**, select **Select the program from a list**, and then click **Notepad**.

   Search in the file for the `<osVersionInfo>` element. For example, the version might be:

   ```xml
   <os majorVersion="4" minorVersion="10" buildNumber="0" servicePackMajor="0" />
   ```

5. Back in the **Project Designer**, click the **Build Events** tab and then click **Edit Post-build**.

6. In the **Post-build Event Command Line** box, enter the following command:

   `C:\TEMP\ChangeOSVersionCS.exe "$(TargetPath).manifest" 5.1.2600.0`

   When you build the project, this command changes the minimum operating system version in the application manifest to 5.1.2600.0.

   Because the `$(TargetPath)` macro expresses the full path for the executable being created, `$(TargetPath).manifest` specifies the application manifest created in the *bin* directory. Publishing copies this manifest to the publishing location that you set earlier.

7. Publish the project again.

   The manifest version should now read:

   ```xml
   <os majorVersion="5" minorVersion="1" buildNumber="2600" servicePackMajor="0" />
   ```

## See also

- [Build Events page, Project Designer (C#)](../ide/reference/build-events-page-project-designer-csharp.md)
- [Pre-build event/Post-build event command line dialog box](../ide/reference/pre-build-event-post-build-event-command-line-dialog-box.md)
- [How to: Specify build events (Visual Basic)](../ide/how-to-specify-build-events-visual-basic.md)
- [Compile and build](../ide/compiling-and-building-in-visual-studio.md)
