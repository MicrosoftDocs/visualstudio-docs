---
title: 'Create a .Vsct File'
description: Learn how to manually create a .vsct file, an XML-based Visual Studio command table configuration file.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- VSCT files, creating
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Create a .vsct file

There are several ways to create an XML-based Visual Studio command table configuration (*.vsct*) file.

- You can create a new VSPackage in the Visual Studio package template.

- You can use the XML-based command table configuration compiler, *Vsct.exe*, to generate a file from an existing *.ctc* file.

- You can use *Vsct.exe* to generate a *.vsct* file from an existing *.cto* file.

- You can manually create a new *.vsct* file.

  This article explains how to manually create a new *.vsct* file.

### To manually create a new .vsct file

1. Start Visual Studio.

2. On the **File** menu, point to **New**, and then click **File**.

3. In the **Templates** pane, click **XML File** and then click **Open**.

4. On the **View** menu, click **Properties** to display the properties of the XML file.

5. In the **Properties** window, click the **Browse** button on the **Schemas** property.

6. In the list of XSD schemas, select the *vsct.xsd* schema. If it is not in the list, click **Add** and then find the file on a local drive. Click **OK** when you are finished.

7. In the XML file, type *<CommandTable* and then press **Tab**. Close the tag by typing *>*.

    This action creates a basic *.vsct* file.

8. Fill in the elements of the XML file that you want to add, according to the [VSCT XML schema reference](../../extensibility/vsct-xml-schema-reference.md). For more information, see [Author .vsct files](../../extensibility/internals/authoring-dot-vsct-files.md).

<a name="how-to-create-a-dot-vsct-file-from-an-existing-dot-ctc-file"></a>

## Create a .vsct File from an existing .ctc file

You can create an XML-based *.vsct* file from an existing command table *.ctc* source file. By doing this, you can take advantage of the new XML-based Visual Studio command table (VSCT) compiler format.

### To create a .vsct file from a .ctc file

1. Obtain a copy of the Perl language.

2. Obtain a copy of the Perl script *ConvertCTCToVSCT.pl*, typically located in the *\<Visual Studio SDK installation path>\VisualStudioIntegration\Tools\bin* folder.

3. Obtain a copy of the *.ctc* source file that you want to convert.

4. Place the files in the same directory.

5. In the Visual Studio command prompt window, navigate to the directory.

6. Type

   ```
   perl.exe ConvertCTCtoVSCT.pl PkgCmd.ctc PkgCmd.vsct
   ```

    where *PkgCmd.ctc* is the name of the *.ctc* file and *PkgCmd.vsct* is the name of the *.vsct* file that you want to create.

    This action creates a new *.vsct* XML command table source file. You can compile the file by using *Vsct.exe*, the VSCT compiler, as you would any other *.vsct* file.

   > [!NOTE]
   > You can improve the readability of the *.vsct* file by reformatting the XML comments.

<a name="how-to-create-a-dot-vsct-file-from-an-existing-dot-cto-file"></a>

## Create a .vsct file from an existing .cto file

You can create an XML-based *.vsct* file from an existing binary *.cto* file. Doing this allows you to take advantage of the new command table compiler format. This process works even if the *.cto* file was compiled from a *.ctc* file. You can edit and compile the *.vsct* file into another .cto file.

### To create a .vsct file from a .cto file

1. Obtain copies of the *.cto* file and its corresponding *.ctsym* file.

2. Place the files into the same directory as the *vsct.exe* compiler.

3. At the Visual Studio command prompt, go to the directory that contains the *.cto* and *.ctsym* files.

4. Type

    ```
    vsct.exe <ctofilename>.cto <vsctfilename>.vsct -S<symfilename>.ctsym
    ```

     where \<ctofilename\> is the name of the *.cto* file, \<vsctfilename\> is the name of the *.vsct* file you want to create, and \<symfilename\> is the name of the *.ctsym* file.

     This process creates a new *.vsct* XML command table compiler file. You can edit and compile the file with *vsct.exe*, the vsct compiler, as you would any other *.vsct* file.

## Compile the code
 Simply adding a *.vsct* file to a project does not cause it to compile. You must incorporate it in the build process.

### To add a .vsct file to project compilation

1. Open your project file in the editor. If the project is loaded, you must unload it first.

2. Add an [ItemGroup element](../../msbuild/itemgroup-element-msbuild.md) that contains a `VSCTCompile` element, as shown in the following example.

    ```xml
    <ItemGroup>
      <VSCTCompile Include="TopLevelMenu.vsct">
        <ResourceName>Menus.ctmenu</ResourceName>
      </VSCTCompile>
    </ItemGroup>

    ```

     The `ResourceName` element should always be set to `Menus.ctmenu`.

3. If your project contains a *.resx* file, add an `EmbeddedResource` element that contains a `MergeWithCTO` element, as shown in the following example:

    ```xml
    <EmbeddedResource Include="VSPackage.resx">
      <MergeWithCTO>true</MergeWithCTO>
      <ManifestResourceName>VSPackage</ManifestResourceName>
    </EmbeddedResource>

    ```

     This markup should go inside the `ItemGroup` element that contains embedded resources.

4. Open the package file, usually named *\<ProjectName\>Package.cs* or *\<ProjectName\>Package.vb*, in the editor.

5. Add a `ProvideMenuResource` attribute to the package class, as shown in the following example.

    ```csharp
    [ProvideMenuResource("Menus.ctmenu", 1)]
    ```

     The first parameter value must match the value of the `ResourceName` attribute you defined in the project file.

## Related content
- [Author .vsct files](../../extensibility/internals/authoring-dot-vsct-files.md)
- [Visual Studio command table (.vsct) files](../../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
- [VSCT XML schema reference](../../extensibility/vsct-xml-schema-reference.md)
