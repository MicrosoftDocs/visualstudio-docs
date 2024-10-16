---
title: "Localizing SharePoint Solutions"
description: Localize SharePoint solutions by removing hard-coded strings from the code and abstracting them into XML-based resource (.resx) files containing translated strings.
ms.date: 04/20/2023
ms.topic: overview
f1_keywords:
  - "VS.SharePointTools.Project.GlobalAndFeatureResource"
  - "VS.SharePoint.Project.AddResourceDialog"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "globalizing [SharePoint development in Visual Studio]"
  - "localizing [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, localizing"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: sharepoint-development
---
# Localize SharePoint solutions

The process of preparing your applications so that they can be used worldwide is known as localization. Localization is translating resources to a specific culture. For more information, see [Globalizing and Localizing Applications](../ide/globalizing-and-localizing-applications.md). This topic provides an overview on how to localize a SharePoint solution.

To localize a solution, you remove hard-coded strings from the code and abstract them into resource files. A Resource file is an XML-based file with a `.resx` extension. The resource file contains the translated versions of the strings used in your solution. For more information, see [Resources in Applications](/previous-versions/dotnet/netframework-4.0/f45fce5x(v=vs.100)).

> [!NOTE]
> Add only string resources to SharePoint solution resource files. Although the Resource Editor enables you to add non-string resources, non-string resources don't deploy to SharePoint.

## Resource files

 There are three kinds of resource files: default, language-neutral, and language-specific.

|Resource File Type|Description|
|------------------------|-----------------|
|Default|Also known as a fallback resource, default resource files contain strings localized for the default culture, such as English. They're used if no localized resource files for the specified language can be found. Default resources don't have separate files, they're stored in the main application assembly.|
|Language-neutral|A resource file that contains strings localized for a language, but not a specific culture. For example, "fr" for French.|
|Language-specific|A resource file that contains strings localized for a language and a culture. For example, "fr-CA" for French Canadian.|

For more information, see [Hierarchical Organization of Resources for Localization](../ide/globalizing-and-localizing-applications.md).

To specify default resource files in SharePoint projects that you develop in Visual Studio, choose **Invariant Language (Invariant Country)** in the culture list of the **Add Resource** dialog box when you add a resource file.

### Add a resource file

The commands for adding resource files are on the shortcut menu of the solution node and feature nodes in Solution Explorer.

### To add a global resource file to a SharePoint solution

1. In Visual Studio, open a SharePoint solution.

1. In **Solution Explorer**, choose a SharePoint project node, and then, on the menu bar, choose **Project** > **Add New Item**.

1. In the **Add New Item** dialog box, choose the **Global Resources File** template, and then choose the **Add** button.

   > [!NOTE]
   > The Global Resources File project item template appears only when a SharePoint project item is selected.

1. In the **Add Resource** dialog box, choose a culture for the resource file, such as English (United States).

    This step adds a global resource file to your solution in the format, `{Resource_x_}.{culture}.resx`, such as, *Resource1.en-US.resx*.

1. When the **Resource Editor** opens in Visual Studio, add resources to the resource file.

### To add a feature resource file to a SharePoint feature

1. If the SharePoint solution isn't already open in Visual Studio, open the solution.

1. In **Solution Explorer**, open the shortcut menu for the name of a feature under the **Features** node, and then choose **Add Feature Resource**.

     This step adds a resource file to the feature in the format, `{ResourceFileName}.{culture}{.resx}`, such as, *Feature1.en-US.resx*.

1. When the **Resource Editor** opens in Visual Studio, add resources to the resource file.

## Localize Visual Studio SharePoint solutions

When you localize a solution, you should consider all of the textual information that your solution displays to users. Informational messages, error messages, and UI strings must be translated and those translations placed in the resource files.

Every string in a resource file has a unique identifier. Use the same identifier for the translated string in each resource file. For example, if "String1" is the identifier for the first string in the default resource file, use the same identifier for the first string in the language-specific resource files.

There are three areas you typically localize in Visual Studio SharePoint applications: features, ASPX page markup, and code. For purposes of illustration, the following sections assume you have a SharePoint solution that you want to localize into German and Japanese. The default language is English.

### Localize features

To localize a feature, you have to replace the hard-coded title and description of the feature with an expression that references the translated title and string in the localized resources file. You make this change in the **Feature Designer** in Visual Studio.

To localize your English feature into German and Japanese, you add three Resource File project items to your project: one for English, one for German, and one for Japanese. Feature resource files can't be used to localize ASPX markup or code; separate resource files are required for them.

After you create the feature resource files, add translated strings to them. Access the localized strings with an expression in the following format:

```aspx-csharp
$Resources:String ID
```

Feature resources in Visual Studio are always named Resources. If you select a language other than Invariant Language, then a culture ID is added to the resource file name. For example, if you add an invariant language (default) feature resource file, it is called *Resources.resx*. If you add a language-specific feature resource by selecting a culture of Japanese (Japan), the file is called *Resources.ja-JP.resx*. Feature resource file names are automatically assigned and can't be changed.

The scope of feature resources is local to the feature they're added to. To create resources that can be used by any feature or element file in the solution, add a **Global Resources File** project item instead of a feature resource File. The **Global Resources File** project item is located in the **2010** folder under **SharePoint** in the **Add New Item** dialog box. Global resources files deploy to the \Resources folder of the SharePoint root folder.

#### To localize a feature

1. In **Solution Explorer**, open the shortcut menu for the **Feature1** node, and then choose **Add Feature Resource**.

1. In the **Add Resource** dialog box, choose **Invariant Language** from the list as the culture for the default language feature resource file.

1. Repeat the previous step for each localized language, choosing the languages of your choice for the localized feature resource files.

     Separate feature resource files are created: one for the default language and one for each localized language that you want to support.

1. Open each resource file in the Resource Editor, and then enter all of the string IDs and their values.

     For example, in the default feature resource file, enter a string ID of **Title** with a value of **My Feature Title**, and a second string ID of **Description** with a value of **My Feature Description**. For each localized resource file, use the same string IDs used in the default feature resource, but enter localized strings for the values.

1. After you enter all the resource values, open the shortcut menu for the feature (for instance, *Feature1.feature*), and then choose **View Designer** to open the feature in the Feature Designer.

1. To localize the **Title** and **Description** fields in the feature, use the following format to enter values in their boxes:

     `$Resources:` *String ID*

     For example, enter $Resources:**Title** in the **Feature Title** box, and $Resources:**Description** in the **Feature Description** box.

     The string IDs must match those that are used in the resource files.

1. Choose the **F5** key to build and run the application.

1. In SharePoint, open the **Site Actions** menu, choose **Site Settings**, and then, in the **Site Actions** section choose the **Manage Site Features** link.

1. In SharePoint, change the display language from the default.

     The localized feature title and description appear in the application. To display localized resources, the SharePoint server must have a language pack installed that matches the resource file's culture.

### Localize ASPX page markup

To localize ASP.NET pages, you add three Resources File project items to your project: one for English, one for German, and one for Japanese. If you don't have to localize code in addition to the markup, you can instead add Global Resources Files.

ASP.NET (.aspx) pages typically use hard-coded string values. To localize these strings, replace them with expressions that reference localized resources.

#### To localize ASPX markup

1. Add separate resource files: one for the default language and one for each localized language.

     If you're localizing only markup and not code, add a Global Resources File project item. If you're localizing code and markup, add a Resources File project item.

    1. To add a Global Resources File, in **Solution Explorer**, open the shortcut menu for a SharePoint project item, and then choose **Add** > **New Item**. Under the SharePoint **2010** node, choose the **Global Resources File** template.

    1. To add a Resources File, in **Solution Explorer**, open the shortcut menu for a SharePoint project item, and then choose **Add** > **New Item**. Choose the **Resources File** template.

    > [!NOTE]
    > Be sure to add the resource files to a SharePoint project item to enable the Deployment Type property. This property is required later in this procedure. If your solution doesn't have a SharePoint project item, you can add an Empty SharePoint Project and remove its default *Elements.xml* file.

1. Give the default language resource file a name of your choice appended with a `.resx` extension, such as MyAppResources.resx. Use the same base name for each localized resource file, but add the culture ID. For example, name a German localized resource *MyAppResources.de-DE.resx*.

1. Change the value of the **Deployment Type** property of each resource file to **AppGlobalResource** to cause them to deploy to the server's App_GlobalResources folder. The App_GlobalResources folder is located in C:\inetpub\wwwroot\wss\VirtualDirectories\\<port number\>\App_GlobalResources.

1. If you're using the resources to localize code in addition to ASPX markup, leave the value of the **Build Action** property of each file as **Embedded Resource**. If you're using the resource files only to localize markup, you can optionally change the property value of the files to **Content**. For more information, see [Localize SharePoint solutions](../sharepoint/localizing-sharepoint-solutions.md).

   > [!NOTE]
   > If you use non-global resource files, move them into the project item folder to enable the Deployment Type property and other SharePoint-specific properties.

1. Open each resource file and add localized strings, using the same string IDs in each file.

1. In the XML markup for the ASPX page or control, replace the hard-coded strings with values that use the following format:

    ```aspx-csharp
    <%$Resources:Resource File Name, String ID%>
    ```

     For example, to localize the text for a label control on an application page, you would change:

    ```aspx-csharp
    <asp:Content ID="Main" ContentPlaceHolderID="PlaceHolderMain" runat="server">
    <asp:Label ID="lbl" runat="server" Text="Label text"></asp:Label>
    </asp:Content>
    ```

     to

    ```aspx-csharp
    <asp:Content ID="Main" ContentPlaceHolderID="PlaceHolderMain" runat="server">
    <asp:Label ID="lbl" runat="server" Text="<%$Resources:MyAppResources,String1%>"></asp:Label>
    </asp:Content>
    ```

1. Choose the **F5** key to build and run the application.

1. In SharePoint, change the display language from the default.

     The localized strings appear in the application. To display localized resources, the SharePoint server must have a language pack installed that matches the resource file's culture.

### Localize code

In addition to localizing Feature strings and ASP.NET markup, you also have to localize the message strings and error strings that appear in your solution code. Localized informational and error messages are contained in satellite assemblies. Satellite assemblies contain strings that are visible to users, such as UI text and output messages like exceptions.

Visual Studio uses the standard .NET Framework hub and spoke model. The hub, or main program assembly, contains the default language resources. The spokes, or satellite assemblies, contain the language-specific resources. For more information, see [Packaging and Deploying Resources](/previous-versions/dotnet/netframework-4.0/sb6a8618(v=vs.100)). Satellite assemblies are compiled from resource (`.resx`) files. When you add language-specific resource files to your project and the solution package, Visual Studio compiles the resource files into satellite assemblies named *{Project Name}.resources.dll*.

#### To localize code

1. In **Solution Explorer**, open the shortcut menu for a project item, and then choose **Add** > **Module**.

     Choose the **Resources File** template.

    > [!NOTE]
    > Be sure to add the resource file to a SharePoint project item so that the Deployment Type property is available. This property is required later in this procedure.

1. Give the default language resource file a name of your choice appended with a `.resx` extension, such as *MyAppResources.resx*.

1. Repeat steps 1 and 2 to add separate resource files to the SharePoint project item: one for each localized language.

     Use the same base name for each localized resource file, but add the culture ID. For example, name a German localized resource *MyAppResources.de-DE.resx*.

1. Open each resource file and add localized strings. Use the same string IDs in each file.

1. Change the value of the **Deployment Type** property of each resource file to **AppGlobalResource** to cause each file to deploy to the server's App_GlobalResources folder.

1. Leave the value of the **Build Action** property of each file as **Embedded Resource**.

     Embedded resources are compiled into the project's DLL.

1. Build the project to create the resource satellite DLLs.

1. In the **Package Designer**, choose the **Advanced** tab, and then add the satellite assembly.

1. In the **Location** box, prepend a culture ID folder to the Location path, such as *de-DE\\\<Project Item Name>.resources.dll*.

1. If your solution doesn't already reference the `System.Web` assembly, add a reference to it, and add a directive in your code to <xref:System.Web>.

1. Locate all hard-coded strings in your code that are visible to users, such as UI text, errors, and message text. Replace them with a call to the <xref:System.Web.HttpContext.GetGlobalResourceObject%2A> method using the following syntax:

    ```csharp
    HttpContext.GetGlobalResourceObject("Resource File Name", "String ID")
    ```

1. Choose the **F5** key to build and run the application.

1. In SharePoint, change the display language from the default.

     The localized strings appear in the application. To display localized resources, the SharePoint server must have a language pack installed that matches the resource file's culture.

Unlocalized code uses hard-coded string values. To localize code strings, replace them with calls to <xref:System.Web.HttpContext.GetGlobalResourceObject%2A>, which is a method that references localized resources.

#### Web part code localization

 Web parts include a custom property editor feature that includes code attributes that use hard-coded strings, such as WebDisplayName, Category, and WebDescription. To replace the string values for these attributes, create a separate class that derives from the attribute's class. In those classes, set the attribute's property. The attribute property depends on the base class. For example, the WebDisplayName attribute property is DisplayNameValue and the WebDescription attribute property is DescriptionValue.

 In the derived class, reference the string ID from the resource file and the ResourceManager object to get the localized value for the string ID. Return this value to the property editor attribute.

## See also

- [How to: Use a resource file to specify localized names, properties, and permissions](../sharepoint/how-to-use-a-resource-file-to-specify-localized-names-properties-and-permissions.md)
