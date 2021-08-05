---
title: Project and item template parameters
description: Learn how to use template parameters to replace values in your template when the template is instantiated.
ms.custom: SEO-VS-2020
ms.date: 01/02/2018
ms.topic: reference
helpviewer_keywords:
- Visual Studio templates, parameters
- template parameters [Visual Studio]
- project templates, parameters
- item templates, parameters
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
---
# Template parameters

You can replace values in your template when the template is instantiated. To set up this functionality, use *template parameters*. Template parameters can be used to replace values such as class names and namespaces in the template. The template wizard that runs in the background when a user adds a new item or project replaces these parameters.

## Declare and enable template parameters

Template parameters are declared in the format $*parameter*$. For example:

- $safeprojectname$

- $guid1$

- $guid5$

### Enable parameter substitution in templates

1. In the *.vstemplate* file of the template, locate the `ProjectItem` element that corresponds to the item for which you want to enable parameter replacement.

1. Set the `ReplaceParameters` attribute of the `ProjectItem` element to `true`.

1. In the code file for the project item, include parameters where appropriate. For example, the following parameter specifies that the safe project name is used for the namespace in a file:

    ```csharp
    namespace $safeprojectname$
    ```

## Reserved template parameters

The following table lists the reserved template parameters that can be used by any template:

|Parameter|Description|
|---------------|-----------------|
|clrversion|Current version of the common language runtime (CLR).|
|ext_*|Add the `ext_` prefix to any parameter to refer to the variables of the parent template. For example, `ext_safeprojectname`.|
|guid[1-10]|A GUID used to replace the project GUID in a project file. You can specify up to 10 unique GUIDs (for example, `guid1`).|
|itemname|The name of the file in which the parameter is being used.|
|machinename|The current computer name (for example, Computer01).|
|projectname|The name provided by the user when the project was created.|
|registeredorganization|The registry key value from HKLM\Software\Microsoft\Windows NT\CurrentVersion\RegisteredOrganization.|
|rootnamespace|The root namespace of the current project. This parameter applies only to item templates.|
|safeitemname|Same as `itemname` but with all unsafe characters and spaces replaced by underscore characters.|
|safeitemrootname|Same as `safeitemname`.|
|safeprojectname|The name provided by the user when the project was created but with all unsafe characters and spaces removed.|
|time|The current time in the format DD/MM/YYYY 00:00:00.|
|specifiedsolutionname|The name of the solution. When "create solution directory" is checked, `specifiedsolutionname` has the solution name. When "create solution directory" is not checked, `specifiedsolutionname` is blank.|
|userdomain|The current user domain.|
|username|The current user name.|
|webnamespace|The name of the current website. This parameter is used in the web form template to guarantee unique class names. If the website is at the root directory of the web server, this template parameter resolves to the root directory of the web server.|
|year|The current year in the format YYYY.|

> [!NOTE]
> Template parameters are case-sensitive.

## Custom template parameters

You can specify your own template parameters and values, in addition to the default reserved template parameters that are used during parameter replacement. For more information, see [CustomParameters element (Visual Studio templates)](../extensibility/customparameters-element-visual-studio-templates.md).

## Example: Use the project name for a file name

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

## Example: Use the safe project name for the namespace name

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

In the *.vstemplate* file for the project template, include the `ReplaceParameters="true"` attribute when you reference the file:

```xml
<TemplateContent>
    <ProjectItem ReplaceParameters="true">
        Class1.cs
    </ProjectItem>
    ...
</TemplateContent>
```

## See also

- [How to: Substitute parameters in a template](how-to-substitute-parameters-in-a-template.md)
- [Customize templates](../ide/customizing-project-and-item-templates.md)
- [How to: Create project templates](../ide/how-to-create-project-templates.md)
- [Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)
