---
title: "Packaging & deployment information in project items"
description: Add packaging and deployment data in SharePoint project items using feature properties, feature receivers, project output references, and safe control entities.
ms.date: "02/02/2017"
ms.topic: how-to
f1_keywords:
  - "VS.SharePointTools.Project.SafeControlEntries"
  - "VS.SharePointTools.Project.ProjectOutputReference"
  - "VS.SharePointTools.Project.FeatureProperties"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, safe controls"
  - "project output references [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, feature properties"
  - "SharePoint development in Visual Studio, project output references"
  - "SharePoint development in Visual Studio, advanced packaging tools"
  - "feature properties [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, feature receiver"
  - "feature receiver [SharePoint development in Visual Studio]"
  - "safe controls [SharePoint development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: sharepoint-development
---
# Provide packaging and deployment information in project items

  All SharePoint project items in Visual Studio have properties that you can use to provide additional data when the project is deployed to SharePoint. These properties are as follows:

- Feature Properties

- Feature Receivers

- Project Output References

- Safe Control Entries

  These properties appear in the **Properties** window.

## Feature properties
 Use the **Feature Properties** property to specify data that the feature uses. Feature properties data is a set of values (stored as key/value pairs) that is included with a feature when it deploys to SharePoint. After the feature is deployed, you can access the property values in your code.

 When you add a feature property value to a project item, the value is added as an element in the manifest of the item's feature. In a Business Data Connectivity (BDC) model project, for example, the ModelFileName feature property appears as:

```xml
<Property Key="ModelFileName" Value="BdcModel1\BdcModel1.bdcm" />
```

 After you set a Feature Property value, it is added as a FeatureProperty element in the project's *.spdata* file. For information about accessing the properties in SharePoint, see [SPFeaturePropertyCollection Class](/previous-versions/office/sharepoint-server/ms461895(v=office.15)).

 Identical feature property values from all project items are merged together in the feature manifest. However, if two different project items specify the same feature property key with non-matching values, a validation error occurs.

 To add feature properties directly to the feature file (*.feature*), call the Visual Studio SharePoint object model method <xref:Microsoft.VisualStudio.SharePoint.Features.IPropertyCollection.Add%2A>. If you use this method, be aware that the same rule about adding identical feature property values in Feature Properties also applies to properties added directly to the feature file.

## Feature receiver
 Feature receivers are code that executes when certain events occur to a project item's containing feature. For example, you can define feature receivers that execute when the feature is installed, activated, or upgraded. One way to add a feature receiver is to add it directly to a feature as described in [Walkthrough: Add feature event receivers](../sharepoint/walkthrough-add-feature-event-receivers.md). Another way is to reference a feature receiver class name and assembly in the **Feature Receiver** property.

### Direct method
 When you add a feature receiver to a feature directly, a code file is placed under the **Feature** node in Solution Explorer. When you build your SharePoint solution, the code compiles into an assembly and deploys to SharePoint. By default, the feature properties **Receiver Assembly** and **Receiver Class** reference the class name and assembly.

### Reference method
 Another way to add a feature receiver is by using the **Feature Receiver** property of a project item to reference a feature receiver assembly. The Feature Receiver property value has two subproperties: **Assembly** and **Class Name**. The assembly must use its fully-qualified, "strong" name and the class name must be the full type name. For more information, see [Strong-Named Assemblies](/previous-versions/dotnet/netframework-4.0/wd40t7ad(v=vs.100)). After deploying the solution to SharePoint, the feature uses the referenced feature receiver to handle feature events.

 At solution build time, the feature receiver property values in the feature and its projects merge together to set the ReceiverAssembly and ReceiverClass attributes of the Feature element in the feature manifest of the SharePoint solution (*.wsp*) file. Therefore, if the Assembly and Class Name property values of a project item and a feature are both specified, the project item and feature property values must match. If the values do not match, you will receive a validation error. If you want a project item to reference a feature receiver assembly other than the one its feature uses, move it to another feature.

 If you reference a feature receiver assembly that is not already on the server, you must also include the assembly file itself in the package; Visual Studio does not add it for you. When you deploy the feature, the assembly file is copied to either the system's global assembly cache (GAC) or the Bin folder in the SharePoint physical directory. For more information, see how to: [How to: Add and remove additional assemblies](../sharepoint/how-to-add-and-remove-additional-assemblies.md).

 For more information about feature receivers, see [Feature Event Receiver](/previous-versions/office/developer/sharepoint-2007/bb862634(v=office.12)) and [Feature Events](/previous-versions/office/developer/sharepoint-2010/ms469501(v=office.14)).

## Project output references
 The Project Output References property specifies a dependency, such as an assembly, that your project item needs to run. For example, suppose your solution has a BDC project and a class project. If the BDC project has a dependency on the assembly that is output by the class project, you can reference the assembly in the BDC project's Project Output References property. When the BDC project is packaged, the dependent assembly is included in the package.

 Project output references are usually assemblies, but in some cases (such as Silverlight projects) can be other file types.

 For more information, see [How to: Add a project output reference](../sharepoint/how-to-add-a-project-output-reference.md).

## Safe control entries
 SharePoint provides a security mechanism, called safe control entries, to limit the access of untrusted users to certain controls. By design, SharePoint allows untrusted users to upload and create ASPX pages on the SharePoint server. To prevent these   users from adding unsafe code to ASPX pages, SharePoint limits their access to *safe controls*. Safe controls are ASPX controls and Web parts designated as secure and that can be used by any user on your site. For more information, see [Step 4: Add your Web Part to the Safe Controls List](/previous-versions/office/developer/sharepoint-2007/ms581321(v=office.12)).

 Every SharePoint project item in Visual Studio has a property called **Safe Control Entries** that has two Boolean subproperties: **Safe** and **Safe Against Script**. The Safe property specifies whether untrusted users can access a control. The Safe Against Script property specifies whether untrusted users can view and change a control's properties.

 Safe control entries are referenced on an assembly basis. You add safe control entries to a project's assembly by entering them in the project item's **Safe Control Entries** property. However, you can also add safe control entries to a project's assembly through the **Advanced** tab in the **Package Designer** when you add an additional assembly to the package. For more information, see [How to: Mark controls as safe controls](../sharepoint/how-to-mark-controls-as-safe-controls.md) or [Registering a Web Part Assembly as a Safe Control](/previous-versions/office/developer/sharepoint2003/dd587360(v=office.11)).

### XML entries for safe controls
 When you add a safe control entry to a project item or to the project's assembly, a reference is written to the package manifest in the following format:

```xml
<Assemblies>
    <Assembly Location="<assembly name>.dll"
      DeploymentTarget="<'GlobalAssemblyCache' or 'WebApplication'">>
        <SafeControls>
            <SafeControl Assembly="<assembly name>.dll" Namespace=
              "<SharePoint project name>" Safe="<true/false>"
                TypeName="<control name>"
                SafeAgainstScript="<true/false>" />
        </SafeControls>
    </Assembly>
</Assemblies>
```

## Related content
- [Package and deploying SharePoint solutions](../sharepoint/packaging-and-deploying-sharepoint-solutions.md)
- [Use modules to include files in the solution](../sharepoint/using-modules-to-include-files-in-the-solution.md)
- [Extend SharePoint packaging and deployment](../sharepoint/extending-sharepoint-packaging-and-deployment.md)
