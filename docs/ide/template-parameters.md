---
title: "Visual Studio project and item template parameters | Microsoft Docs"
ms.custom: ""
ms.date: "01/02/2018"
ms.reviewer: ""
ms.suite: ""
ms.technology: vs-ide-general
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "Visual Studio templates, parameters"
  - "template parameters [Visual Studio]"
  - "project templates, parameters"
  - "item templates, parameters"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
---
# Template parameters

By using parameters in your templates, you can replace the values of key portions of the template, such as class names and namespaces, when the template is instantiated. These parameters are replaced by the template wizard that runs in the background when a user chooses **OK** or **Add** in the **New Project** or **Add New Item** dialog boxes.

## Declaring and enabling template parameters

Template parameters are declared in the format $*parameter*$. For example:

- $safeprojectname$

- $guid1$

- $guid5$

### To enable parameter substitution in templates

1. In the .vstemplate file of the template, locate the `ProjectItem` element that corresponds to the item for which you want to enable parameter replacement.

1. Set the `ReplaceParameters` attribute of the `ProjectItem` element to `true`.

1. In the code file for the project item, include parameters where appropriate. For example, the following parameter specifies that the safe project name be used for the namespace in a file:

    ```csharp
    namespace $safeprojectname$
    ```

## Reserved template parameters

The following table lists the reserved template parameters that can be used by any template.

|Parameter|Description|
|---------------|-----------------|
|clrversion|Current version of the common language runtime (CLR).|
|guid[1-10]|A GUID used to replace the project GUID in a project file. You can specify up to 10 unique GUIDs (for example, `guid1`).|
|itemname|The name provided by the user in the **Add New Item** dialog box.|
|machinename|The current computer name (for example, Computer01).|
|projectname|The name provided by the user in the **New Project** dialog box.|
|registeredorganization|The registry key value from HKLM\Software\Microsoft\Windows NT\CurrentVersion\RegisteredOrganization.|
|rootnamespace|The root namespace of the current project. This parameter applies only to item templates.|
|safeitemname|The name provided by the user in the **Add New Item** dialog box, with all unsafe characters and spaces removed.|
|safeprojectname|The name provided by the user in the **New Project** dialog box, with all unsafe characters and spaces removed.|
|time|The current time in the format DD/MM/YYYY 00:00:00.|
|SpecificSolutionName|The name of the solution. When "create solution directory" is checked, `SpecificSolutionName` has the solution name. When "create solution directory" is not checked, `SpecificSolutionName` is blank.|
|userdomain|The current user domain.|
|username|The current user name.|
|webnamespace|The name of the current Web site. This parameter is used in the Web form template to guarantee unique class names. If the Web site is at the root directory of the Web server, this template parameter resolves to the root directory of the Web Server.|
|year|The current year in the format YYYY.|

> [!NOTE]
> Template parameters are case-sensitive.

## Custom template parameters

You can specify your own template parameters and values, in addition to the default reserved template parameters that are used during parameter replacement. For more information, see [CustomParameters element (Visual Studio templates)](../extensibility/customparameters-element-visual-studio-templates.md).

## Example: Using the project name for a file name

You can specify variable file names for project items by using a parameter in the `TargetFileName` attribute.

The following example specifies that an executable file's name uses the project name, specified by `$projectname$`.

```xml
<TemplateContent>
    <ProjectItem
        ReplaceParameters="true"
        TargetFileName="$projectname$.exe">
            File1.exe
    </ProjectItem>
      ...
</TemplateContent>
```

## Example: Using the safe project name for the namespace name

To use the safe project name for the namespace in a C# class file, use the following syntax:

```csharp
namespace $safeprojectname$
{
    public class Class1
    {
        public Class1()
        { }
    }
}
```

In the .vstemplate file for the project template, include the `ReplaceParameters="true"` attribute when you reference the file:

```xml
<TemplateContent>
    <ProjectItem ReplaceParameters="true">
        Class1.cs
    </ProjectItem>
    ...
</TemplateContent>
```

## See also

[Customizing templates](../ide/customizing-project-and-item-templates.md)  
[How to: Create project templates](../ide/how-to-create-project-templates.md)