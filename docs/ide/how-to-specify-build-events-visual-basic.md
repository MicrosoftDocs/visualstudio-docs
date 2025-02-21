---
title: 'Specify build events (Visual Basic)'
description: Explore how to use build events in Visual Basic to run scripts, macros, or other actions as a part of the compilation process.
ms.date: 12/13/2024
ms.subservice: compile-build
ms.topic: how-to
helpviewer_keywords:
- pre-build events
- events [Visual Studio], builds
- post-build events
- build events [Visual Studio]
- builds [Visual Studio], events
author: ghogen
ms.author: ghogen
manager: mijacobs
---
# Specify build events (Visual Basic)

Build events in Visual Basic can be used to run scripts, macros, or other actions as a part of the compilation process. Pre-build events occur before compilation; post-build events occur after compilation.

:::moniker range=">=vs-2022"

## How to specify pre-build and post-build events

To view or change build events for a Visual Basic .NET Core or .NET 5 and later project, right-click the project node, and choose **Properties** (or press **Alt**+**Enter**), then go to **Compile** > **Events**. Enter the desired command line. The working directory is the output directory.

For .NET Framework projects, follow these steps:

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Compile** tab.

3. Click the **Build Events** button to open the **Build Events** dialog box.

4. Enter the command-line arguments for your pre-build or post-build action, and then click **OK**.
    
:::moniker-end

:::moniker range="<=vs-2019"
Build events are specified in the **Build Events** dialog box, available from the **Compile** page of the **Project Designer**.

## How to specify pre-build and post-build events

### To specify a build event

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Compile** tab.

3. Click the **Build Events** button to open the **Build Events** dialog box.

4. Enter the command-line arguments for your pre-build or post-build action, and then click **OK**.

:::moniker-end

> [!NOTE]
> Add a `call` statement before all post-build commands that run `.bat` files. For example, `call C:\MyFile.bat` or `call C:\MyFile.bat call C:\MyFile2.bat`.

> [!NOTE]
> If your pre-build or post-build event does not complete successfully, you can terminate the build by having your event action exit with a code other than zero (0), which indicates a successful action.

MSBuild property names may be referenced in the scripts. The property is referened as `$(PropertyName)` and is substituted with the property value when the event script is executed. For a list of commonly used values, see [MSBuild common properties](../msbuild/common-msbuild-project-properties.md). There may be other properties as well as defined in the project file, in any imported files in the project file, in environment variables, or passed on the command line using the `-p` MSBuild switch during command-line builds.

## Example: How to change manifest information using a post-build event

The following procedure shows how to set the minimum operating system version in the application manifest using an `.exe` command called from a post-build event (the `.exe.manifest` file in the project directory). The minimum operating system version is a four-part number such as 4.10.0.0. To do this, the command will change the `<dependentOS>` section of the manifest:

```xml
<dependentOS>
   <osVersionInfo>
      <os majorVersion="4" minorVersion="10" buildNumber="0" servicePackMajor="0" />
   </osVersionInfo>
</dependentOS>
```

### To create an .exe command to change the application manifest

1. Create a console application for the command. From the **File** menu, click **New**, and then click **Project**.

2. In the **New Project** dialog box, in the **Visual Basic** node, select **Windows** and then the **Console Application** template. Name the project `ChangeOSVersionVB`.

3. In *Module1.vb*, add the following line to the other `Imports` statements at the top of the file:

   ```vb
   Imports System.Xml
   ```

4. Add the following code in `Sub Main`:

   ```vb
   Sub Main()
      Dim applicationManifestPath As String
      applicationManifestPath = My.Application.CommandLineArgs(0)
      Console.WriteLine("Application Manifest Path: " & applicationManifestPath.ToString)

      'Get version name
      Dim osVersion As Version
      If My.Application.CommandLineArgs.Count >= 2 Then
         osVersion = New Version(My.Application.CommandLineArgs(1).ToString)
      Else
         Throw New ArgumentException("OS Version not specified.")
      End If
      Console.WriteLine("Desired OS Version: " & osVersion.ToString())

      Dim document As XmlDocument
      Dim namespaceManager As XmlNamespaceManager
      namespaceManager = New XmlNamespaceManager(New NameTable())
      With namespaceManager
         .AddNamespace("asmv1", "urn:schemas-microsoft-com:asm.v1")
         .AddNamespace("asmv2", "urn:schemas-microsoft-com:asm.v2")
      End With

      document = New XmlDocument()
      document.Load(applicationManifestPath)

      Dim baseXPath As String
      baseXPath = "/asmv1:assembly/asmv2:dependency/asmv2:dependentOS/asmv2:osVersionInfo/asmv2:os"

      'Change minimum required OS Version.
      Dim node As XmlNode
      node = document.SelectSingleNode(baseXPath, namespaceManager)
      node.Attributes("majorVersion").Value = osVersion.Major.ToString()
      node.Attributes("minorVersion").Value = osVersion.Minor.ToString()
      node.Attributes("buildNumber").Value = osVersion.Build.ToString()
      node.Attributes("servicePackMajor").Value = osVersion.Revision.ToString()

      document.Save(applicationManifestPath)
   End Sub
   ```

   The command takes two arguments. The first argument is the path to the application manifest (that is, the folder in which the build process creates the manifest, typically *\<ProjectName>.publish*). The second argument is the new operating system version.

5. On the **Build** menu, click **Build Solution**.

6. Copy the *.exe* file to a directory such as *C:\TEMP\ChangeOSVersionVB.exe*.

   Next, invoke this command in a post-build event to change the application manifest.

### To invoke a post-build event to change the application manifest

1. Create a Windows application for the project to be published. From the **File** menu, click **New**, and then click **Project**.

2. In the **New Project** dialog box, in the **Visual Basic** node, select **Windows Desktop** and then the **Windows Forms App** template. Name the project `VBWinApp`.
3. With the project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

4. In the **Project Designer**, go to the **Publish** page and set **Publishing location** to *C:\TEMP*.

5. Publish the project by clicking **Publish Now**.

     The manifest file will be built and put in *C:\TEMP\VBWinApp_1_0_0_0\VBWinApp.exe.manifest*. To view the manifest, right-click the file and click **Open with**, then click **Select the program from a list**, and then click **Notepad**.

     Search in the file for the `<osVersionInfo>` element. For example, the version might be:

    ```xml
    <os majorVersion="4" minorVersion="10" buildNumber="0" servicePackMajor="0" />
    ```

6. In the **Project Designer**, go to the **Compile** tab and click the **Build Events** button to open the **Build Events** dialog box.

7. In the **Post-build Event Command Line** box, enter the following command:

     `C:\TEMP\ChangeOSVersionVB.exe "$(TargetPath).manifest" 5.1.2600.0`

     When you build the project, this command changes the minimum operating system version in the application manifest to 5.1.2600.0.

     The `$(TargetPath)` macro expresses the full path for the executable being created. Therefore, *$(TargetPath).manifest* will specify the application manifest created in the *bin* directory. Publishing copies this manifest to the publishing location that you set earlier.

8. Publish the project again. Go to the **Publish** page and click **Publish Now**.

     View the manifest again. To view the manifest, go to the publish directory, right-click the file and click **Open with** and then **Select the program from a list**, and then click **Notepad**.

     The version should now read:

    ```xml
    <os majorVersion="5" minorVersion="1" buildNumber="2600" servicePackMajor="0" />
    ```

## Related content

- [Compile page, Project Designer (Visual Basic)](../ide/reference/compile-page-project-designer-visual-basic.md)
- [Publish page, Project Designer](../ide/reference/publish-page-project-designer.md)
- [Pre-build event/Post-build event command line dialog box](../ide/reference/pre-build-event-post-build-event-command-line-dialog-box.md)
- [How to: Specify build events (C#)](../ide/how-to-specify-build-events-csharp.md)
