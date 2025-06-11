---
title: Localizing Menu Commands
description: Learn how to provide localized text for menu and toolbar commands by creating localized .vsct files and localized .resx files for your VSPackage.
ms.date: 10/08/2019
ms.topic: how-to
helpviewer_keywords:
- localize
- localization
- vsct
- menu commands
- localize visual studio
- localize vsct
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Localize menu commands

You can provide localized text for menu and toolbar commands by creating localized *.vsct* files and localized *.resx* files for your VSPackage, and then updating the project files to incorporate the changes.

For information about how to localize the installation experience, see [Localize VSIX packages](../extensibility/localizing-vsix-packages.md).

## Localize command names

In VSPackages, menu commands and toolbar buttons are defined in the *.vsct* file.

1. In **Solution Explorer**, change the name of the *.vsct* file from *filename.vsct* to *filename.en-US.vsct*.

2. Make a copy of *filename.en-US.vsct* for each localized language.

    Name each copy *filename.{Locale}.vsct*, where *{Locale}* is a particular culture name. For a list of culture name values, see [Locale IDs assigned by Microsoft](/windows/uwp/publish/supported-languages).

    These *filename.Locale.vsct* files will contain the localized menu text for your package.

3. Open each *filename.Locale.vsct* file to localize the text.

   1. Modify the [ButtonText](../extensibility/buttontext-element.md) element values as appropriate for the particular language.

   2. If you will provide localized icons, modify the [Bitmap](../extensibility/bitmap-element.md) values to point to the target files.

      The following example shows English and Spanish button text for a command to open a Family Tree Explorer tool window.

      [*FamilyTree.en-US.vsct*]

   ```xml
   <Button guid="guidLocalizedPackageCmdSet" id="cmdidFamilyTree" priority="0x0100" type="Button">
     <Parent guid="guidSHLMainMenu" id="IDG_VS_WNDO_OTRWNDWS1"/>
     <Icon guid="guidImages" id="bmpPic2" />
     <Strings>
       <CommandName>cmdidFamilyTree</CommandName>
       <ButtonText>Family Tree Explorer</ButtonText>
     </Strings>
   </Button>
   ```

    [*FamilyTree.es-ES.vsct*]

   ```xml
   <Button guid="guidLocalizedPackageCmdSet" id="cmdidFamilyTree" priority="0x0100" type="Button">
     <Parent guid="guidSHLMainMenu" id="IDG_VS_WNDO_OTRWNDWS1"/>
     <Icon guid="guidImages" id="bmpPic2" />
     <Strings>
       <CommandName>cmdidFamilyTree</CommandName>
       <ButtonText>Explorar el arbol genealogico</ButtonText>
     </Strings>
   </Button>
   ```

## Localize other text resources

Text resources other than command names are defined in resource (*.resx*) files.

1. Rename *VSPackage.resx* to *VSPackage.en-US.resx*.

2. Make a copy of the *VSPackage.en-US.resx* file for each localized language.

     Name each copy *VSPackage.{Locale}.resx*, where *{Locale}* is a particular culture name.

3. Rename *Resources.resx* to *Resources.en-US.resx*.

4. Make a copy of the *Resources.en-US.resx* file for each localized language.

     Name each copy *Resources.{Locale}.resx*, where *{Locale}* is a particular culture name.

5. Open each *.resx* file to modify the string values as appropriate for the particular language and culture. The following example shows the localized resource definition for the title bar of a tool window.

     [*Resources.en-US.resx*]

    ```xml
    <data name="ToolWindowTitle" xml:space="preserve">
      <value>Family Tree Explorer</value>
    </data>
    ```

     [*Resources.es-ES.resx*]

    ```xml
    <data name="ToolWindowTitle" xml:space="preserve">
      <value>Explorador del arbol genealogico</value>
    </data>
    ```

## Incorporate localized resources into the project

You must modify the *assemblyinfo.cs* file and the project file to incorporate the localized resources.

1. From the **Properties** node in **Solution Explorer**, open *assemblyinfo.cs* or *assemblyinfo.vb* in the editor.

2. Add the following entry.

    ```csharp
    [assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]
    ```

     This sets US English as the default language.

3. Unload the project.

4. Open the project file in the editor.

5. In the root `Project` element, add a `PropertyGroup` element with a `UICulture` element that matches your default language.

    ```xml
    <PropertyGroup>
      <UICulture>en-US</UICulture>
    </PropertyGroup>
    ```

     This sets US English as the default UI culture for Windows Presentation Foundation (WPF) controls.

6. Locate the `ItemGroup` element that contains `EmbeddedResource` elements.

7. In the `EmbeddedResource` element that calls *VSPackage.en-US.resx*, replace the `ManifestResourceName` element with a `LogicalName` element that's set to `VSPackage.en-US.Resources`, as follows:

    ```xml
    <EmbeddedResource Include="VSPackage.en-US.resx">
      <MergeWithCTO>true</MergeWithCTO>
      <LogicalName>VSPackage.en-US.Resources</LogicalName>
    </EmbeddedResource>
    ```

8. For each localized language, copy the  `EmbeddedResource` element for `VsPackage.en-US`, and set the **Include** attribute and **LogicalName** element of the copy to the target locale.

9. To each localized `VSCTCompile` element, add a `ResourceName` element that points to `Menus.ctmenu`, as shown in the following example:

    ```xml
    <ItemGroup>
      <VSCTCompile Include="LocalizedPackage.es-ES.vsct">
        <ResourceName>Menus.ctmenu</ResourceName>
      </VSCTCompile>
    </ItemGroup>
    ```

10. Save the project file and reload the project.

11. Build the project.

     This creates a main assembly, and resource assemblies for each language. For information on localizing the deployment process, see [Localize VSIX packages](../extensibility/localizing-vsix-packages.md)

## Related content

- [Extend menus and commands](../extensibility/extending-menus-and-commands.md)
- [Globalize and Localize applications](../ide/globalizing-and-localizing-applications.md)
