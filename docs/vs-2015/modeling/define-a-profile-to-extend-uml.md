---
title: "Define a profile to extend UML | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "profiles, UML"
  - "stereotypes, UML"
  - "UML, profiles and stereotypes"
  - "UML - extending, defining profiles"
  - "UML, customizing"
  - "UML, profiles"
ms.assetid: 776589cb-f89d-48d5-aafa-04a4c074b0d6
caps.latest.revision: 44
author: jillre
ms.author: jillfra
manager: jillfra
---
# Define a profile to extend UML
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can define a *UML profile* to customize the standard model elements for specific purposes. A profile defines one or more *UML stereotypes*. A stereotype can be used to mark a type as representing a particular kind of object. A stereotype can also extend an element's list of properties.

 Several profiles are installed with supported editions of Visual Studio. To see which versions of Visual Studio support this feature, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport). For more information about those profiles and about how to apply stereotypes, see [Customize your model with profiles and stereotypes](../modeling/customize-your-model-with-profiles-and-stereotypes.md).

 You can define your own profiles to adapt and extend UML to your own business area or architecture. For example:

- If you frequently define Web sites, you could define your own profile that provides a «WebPage» stereotype that can be applied to classes in class diagrams. You could then use class diagrams to plan a Web site. Every «WebPage» class would have extra properties for page content, style, and so on.

- If you develop banking software, you could define a profile that provides an «Account» stereotype. You could then use class diagrams to define different types of account and show the relationships between them.

  You can distribute your own profiles to your team. Each team member can install your profile. This enables them to edit and create models that use its stereotypes.

> [!NOTE]
> If you apply the stereotypes of a profile in a model that you are editing, and then share the model with other people, they should install the same profile on their own computers. Otherwise, they will not be able to see the stereotypes that you have used.

 A profile is often part of a larger [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] extension. For example, you could define a command that translates some parts of a model to code. You could define a profile that users must apply to packages that they want to translate. You would distribute your new command together with the profile in a single [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] extension.

 You can also define localized variants of a profile. Users loading your extension see the variant that is appropriate to their own culture.

## <a name="DefineProfile"></a> How to Define a Profile

#### To define a UML Profile

1. Create a new XML file with the file name extension `.profile`.

2. Add stereotype definitions according to the guidelines described in [The Structure of a Profile](#Schema).

3. Add the profile to a Visual Studio Extension (`.vsix` file). You can either create a new extension for your profile, or add the profile to an existing extension.

     See the next section, [How to Add a Profile to a Visual Studio Extension](#AddProfile).

4. Install the extension on your computer.

    1. Double-click the extension file, which has a file name extension `.vsix`.

    2. Restart Visual Studio.

5. Verify that the profile has been installed.

    1. Select the model in UML Explorer.

    2. In the Properties window, click the **Profiles** property. Your profile will appear in the menu. Set the check mark next to the profile.

    3. Select an element for which your profile defines stereotypes. In the Properties window, click the **Stereotypes** property. Your stereotypes will appear in the list. Set the check mark against one of the stereotypes.

    4. If your profile defines additional properties for this stereotype, expand the stereotype property to see them.

6. Send the extension file to other users of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] to install on their computers.

## <a name="AddProfile"></a> How to Add a Profile to a Visual Studio Extension
 To install a profile, and to allow you to send it to other users, you must add the profile to a Visual Studio extension. For more information, see [Deploying Visual Studio Extensions](https://go.microsoft.com/fwlink/?LinkId=160780).

#### To define a profile in a new Visual Studio Extension

1. Create a Visual Studio Extension project.

   > [!NOTE]
   > You must have installed [!INCLUDE[vsipsdk](../includes/vsipsdk-md.md)] to use this procedure.

   1. On the **File** menu, point to **New**, and then click **Project**.

   2. In the **New Project** dialog box, under **Installed Templates**, expand **Visual C#**, click **Extensibility**, and then click **VSIX project**. Set the project name and click **OK**.

2. Add your profile to the project.

   - In Solution Explorer, right-click the project, point to **Add**, and then click **Existing Item**. In the dialog box, locate your profile file.

3. Set the profile file's **Copy to Output** property.

   1. In Solution Explorer, right-click the profile file, and then click **Properties**.

   2. In the Properties window, set the **Copy to Output Directory** property to **Copy Always**.

4. In Solution Explorer, open `source.extension.vsixmanifest`.

    The file opens in the extension manifest editor.

5. On the **Assets** page, add a row describing the profile:

   - Click **New**. Set the fields in the **Add New Asset** dialog as follows.

   - Set **Type** to `Microsoft.VisualStudio.UmlProfile`

        This is not one of the drop-down choices. Enter this name from the keyboard.

   - Click **File on filesystem** and select the name of your profile file, for example `MyProfile.profile`

6. Build the project.

7. **To debug the profile**, press F5.

    An experimental instance of Visual Studio opens. In this instance, open a modeling project. In UML Explorer, select the root element of the model, and in the Properties window, select your profile. Then select elements inside the model and set stereotypes that you have defined for them.

8. **To extract the VSIX for deployment**

   1. In Windows Explorer, open the folder **.\bin\Debug** or **.\bin\Release** to find the **.vsix** file. This is a [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] Extension file. It can be installed on your computer and sent to other Visual Studio users.

   2. To install the extension:

       1. Double-click the `.vsix` file. The Visual Studio Extension Installer will start.

       2. Restart any instances of Visual Studio that are running.

   The following alternative procedure can be used for small extensions if you have not installed [!INCLUDE[vsipsdk](../includes/vsipsdk-md.md)].

#### To define a profile extension without using Visual Studio SDK

1. Create a Windows directory that contains the following three files:

    - *YourProfile* `.profile`

    - `extension.vsixmanifest`

    - `[Content_Types].xml` - type this name as shown here, with the square brackets

2. Edit `[Content_Types].xml` to contain the following text. Notice that it contains an entry for each file name extension.

    ```
    <?xml version="1.0" encoding="utf-8"?>
    <Types xmlns="http://schemas.openxmlformats.org/package/2006/content-types">
      <Default Extension="profile" ContentType="application/octet-stream" />
      <Default Extension="vsixmanifest" ContentType="text/xml" />
    </Types>
    ```

3. Copy an existing `extension.vsixmanifest` and edit it with an XML editor. Alter the ID, Name, and Content nodes.

    - You can find an example of `extension.vsixmanifest` in this directory:

         *drive* **:\Program Files\Microsoft Visual Studio [version]\Common7\IDE\Extensions\Microsoft\Architecture Tools\UmlProfiles**

    - The Content node should be like this:

        ```
        <Content>
          <CustomExtension Type="Microsoft.VisualStudio.UmlProfile"
          >YourProfile.Profile</CustomExtension>
        </Content>
        ```

4. Compress the three files into a zipped file.

     In Windows Explorer, select the three files, right-click, point to **Send To**, and then click **Compressed (zipped) folder**.

5. Rename the zipped file, and change its file name extension from `.zip` to `.vsix`.

6. To install the profile on any computer with appropriate editions of Visual Studio, double-click the `.vsix` file.

#### To install a UML Profile from a Visual Studio Extension

1. Double-click the `.vsix` file in Windows Explorer, or open it within Visual Studio.

2. Click **Install** in the dialog box that appears.

3. To uninstall or temporarily disable the extension, open **Extensions and Updates** from the **Tools** menu.

## <a name="Localized"></a> How to Define Localized Profiles
 You can define different profiles for different cultures or languages, and package them all into the same extension. When a user loads your extension, they will see the profile that you have defined for their culture.

 You must always provide a default profile. If you have not defined a profile for the user's culture, they will see the default profile.

#### To define a localized profile

1. Create a profile as described in the previous sections[How to Define a Profile](#DefineProfile) and [How to Add a Profile to a Visual Studio Extension](#AddProfile). This is the default profile, and will be used in any installation for which you do not provide a localized profile.

2. Add a new directory in the same directory as your default profile file.

    > [!NOTE]
    > If you are building the extension by using a Visual Studio Extension project, use Solution Explorer to add a new folder to the project.

3. Change the new directory's name to the ISO short code for the localized culture, such as `bg` for Bulgarian, or `fr` for French. You should use a neutral culture code, typically two letters, not a specific culture such as `fr-CA`. For more information about culture codes, see [CultureInfo.GetCultures method](https://go.microsoft.com/fwlink/?LinkId=160782), which provides a complete list of culture codes.

4. Add a copy of your default profile to the new directory. Do not change its file name.

     A sample [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] Extension folder, before it is built or compressed into a `.vsix` file, would contain the following folders and files:

     `extension.vsixmanifest`

     `MyProfile.profile`

     `fr\MyProfile.profile`

     `de\MyProfile.profile`

    > [!NOTE]
    > You should not insert into `extension.vsixmanifest` a reference to the localized versions of the profiles. The copied profile files must have the same name as the profile in the parent folder.

5. Edit the new copy of the profile, translating to the target language all the parts that will be visible to the user, such as the `displayName` attributes.

6. You can create additional culture folders and localized profiles for as many cultures as you want.

7. Build the Visual Studio extension, either by building the Extension Project or compressing all the files, as described in the previous sections.

## <a name="Schema"></a> The Structure of a Profile
 The XSD file for UML profiles can be found in the following sample: [Setting Stereotypes and Profiles XSD](https://go.microsoft.com/fwlink/?LinkID=213811). To help you edit profile files, install the `.xsd` file in:

 **%ProgramFiles%\Microsoft Visual Studio [version]\Xml\Schemas**

 This section uses the C# profile as an example. The complete profile definition can be seen in:

 *drive* **:\Program Files\Microsoft Visual Studio [version]\Common7\IDE\Extensions\Microsoft\Architecture Tools\UmlProfiles\CSharp.profile**

 The first parts of this path might differ in your installation.

 For more information about the .NET profile, see [Standard stereotypes for UML models](../modeling/standard-stereotypes-for-uml-models.md).

### Main sections of the UML Profile definition
 Every profile contains the following content:

```
<?xml version="1.0" encoding="utf-8"?>
<profile dslVersion="1.0.0.0"
       name="CSharpProfile" displayName="C# Profile"
       xmlns="http://schemas.microsoft.com/UML2.1.2/ProfileDefinition">
  <stereotypes>...</stereotypes>
  <metaclasses>...</metaclasses>
  <propertyTypes>...</propertyTypes>
</profile>
```

> [!NOTE]
> The attribute called `name` must not contain spaces or punctuation. The attribute `displayName`, which appears in the user interface, should be a valid XML string.

 Every profile contains three main sections. In reverse order, they are as follows:

- `<propertyTypes>` - a list of types that are used for properties defined in the stereotypes section.

- `<metaclasses>` - a list of model element types to which the stereotypes in this profile apply, such as IClass, IInterface, IOperation, IDependency.

- `<stereotypes>` - the stereotype definitions. Each definition includes the names and types of properties that are added to the target model element.

#### Property Types
 The `<propertyTypes>` section declares a list of types that are used for properties in the `<stereotypes>` section. There are two kinds of property types: external and enumeration.

 An external type declares the fully qualified name of a standard .NET type:

```
<externalType name="System.String" />
```

 An enumeration type defines a set of literal values:

```
<enumerationType name="PackageVisibility">
  <enumerationLiterals>
    <enumerationLiteral name="internal" displayName="internal"  />
    <enumerationLiteral name="protectedinternal" displayName="protected internal" />
  </enumerationLiterals>
</enumerationType>
```

#### Metaclasses
 The `<metaclasses>` section is a list of model element types to which stereotypes in this profile can be defined:

```
<metaclass
      name="Microsoft.VisualStudio.Uml.Classes.IClass" />
<metaclass
      name="Microsoft.VisualStudio.Uml.Classes.IInterface" />
<metaclass
      name="Microsoft.VisualStudio.Uml.Components.IComponent" />
```

 For the full list of model element and relationship types that you can use as metaclasses, see [Model Element Types](#Elements).

#### Stereotype definition
 The `<stereotypes>` section contains one or more stereotype definitions:

```
<stereotype name="CSharpClass" displayName="C# Class"> ...
```

 Each stereotype lists one or more model element or relationship types to which it can be applied. You can give the name of a base type, to include all its derived types. For example, if you specify `Microsoft.VisualStudio.Uml.Classes.IType`, the stereotype can be applied to `IClass`, `IInterface`, `IEnumeration`, and several other types of element.

```
<metaclasses>
  <metaclassMoniker name=
   "/CSharpProfile/Microsoft.VisualStudio.Uml.Classes.IClass" />
</metaclasses>
```

 The `name` attribute of `metaclassMoniker` is a link to an element in the `<metaClasses>` section.

> [!NOTE]
> The moniker name must begin with `/yourProfileName/`, where `yourProfileName` is defined in the `name` attribute of the profile ("CSharpProfile" in this example). The moniker ends with the name of one of the entries in the metaclasses section.

 Each stereotype can list zero or more properties that it adds to any model element to which it is applied. The `<propertyType>` contains a link to one of the types that are defined in the `<propertyTypes>` section. The link must be either an `<externalTypeMoniker>` to refer to an `<externalType>,` or an `<enumerationTypeMoniker>` to refer to an `<enumerationType>`. Again, the link begins with the name of your profile.

```
  <properties>
    <property name="IsStatic"
            displayName="Is Static" defaultValue="false">
      <propertyType>
<externalTypeMoniker
               name="/CSharpProfile/System.Boolean" />
      </propertyType>
    </property>
    <property name="PackageVisibility"
              displayName="Package Visibility"
              defaultValue="internal">
      <propertyType>
        <enumerationTypeMoniker
              name="/CSharpProfile/PackageVisibility"/>
      </propertyType>
    </property>
  </properties>
</stereotype>
```

## <a name="Elements"></a> Model Element Types
 The set of types for which you can define stereotypes is listed in [UML model element types](../modeling/uml-model-element-types.md).

## Troubleshooting
 My stereotypes do not appear my UML models.
 You have to select your profile in a package or model. The stereotypes will then appear on elements inside the package or model. For more information, see [Add stereotypes to UML model elements](../modeling/add-stereotypes-to-uml-model-elements.md).

 The following error appears when I open a UML model: **VS1707: The following profiles cannot be loaded because a serialization error occurred: MyProfile.profile**
1. Verify that the basic XML syntax of the .profile is correct.

2. Ensure that each Moniker name is in the form /profileName/nodeName. The profileName is the value of the name attribute in the root profile node. The nodeName is the value of the name attribute of a metaclass, externalType, or enumerationType.

3. Ensure the syntax is as described here, and as demonstrated in _drive_**:\Program Files\Microsoft Visual Studio [version]\Common7\IDE\Extensions\Microsoft\Architecture Tools\UmlProfiles\\**.

4. Uninstall the faulty extension. On the **Tools** menu, click **Extensions and Updates**.

   - If the extension does not appear, see the next item.

5. Rebuild the VSIX file and open it in Windows Explorer to re-install it. Restart [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].

   The extension does not appear in Extension Manager, but when you try to re-install it, the following message appears: **The extension is already installed to all applicable products.**
   1. Remove the extension file from a subfolder of *LocalAppData*\Microsoft\VisualStudio\\[version]\Extensions\

   - To see *LocalAppData*, you must set Show Hidden Files and Folders in the View tab of the Windows Explorer Folder Options.

   - *LocalAppData* is typically in C:\Users\\*userName*\AppData\Local\

6. Restart [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].

## See Also
 [Add stereotypes to UML model elements](../modeling/add-stereotypes-to-uml-model-elements.md)
 [Customize your model with profiles and stereotypes](../modeling/customize-your-model-with-profiles-and-stereotypes.md)
 [Standard stereotypes for UML models](../modeling/standard-stereotypes-for-uml-models.md)
 [Sample: Color UML Elements by Stereotype](https://go.microsoft.com/fwlink/?LinkID=213841)
 [Sample: Setting Stereotypes, Profiles XSD](https://go.microsoft.com/fwlink/?LinkID=213811)
