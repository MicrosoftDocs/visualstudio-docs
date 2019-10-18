---
title: "Template Parameters | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "Visual Studio templates, parameters"
  - "template parameters [Visual Studio]"
  - "project templates, parameters"
  - "item templates, parameters"
ms.assetid: 1b567143-08c6-4d7a-b484-49f0671754fe
caps.latest.revision: 27
author: jillre
ms.author: jillfra
manager: jillfra
---
# Template Parameters
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

By using parameters in your templates, you can replace the values of key portions of the template, such as class names and namespaces, when the template is instantiated. These parameters are replaced by the template wizard that runs in the background when a user clicks **OK** in the **New Project** or **Add New Item** dialog boxes.

## Declaring and Enabling Template Parameters
 Template parameters are declared in the format $*parameter*$. For example:

- $safeprojectname$

- $guid1$

- $guid5$

#### To enable parameter substitution in templates

1. In the .vstemplate file of the template, locate the `ProjectItem` element that corresponds to the item for which you want to enable parameter replacement.

2. Set the `ReplaceParameters` attribute of the `ProjectItem` element to `true`.

3. In the code file for the project item, include parameters where appropriate. For example, the following parameter specifies that the safe project name be used for the namespace in a file:

    ```
    namespace $safeprojectname$
    ```

## Reserved Template Parameters
 The following table lists the reserved template parameters that can be used by any template.

> [!NOTE]
> Template parameters are case-sensitive.

|Parameter|Description|
|---------------|-----------------|
|`clrversion`|Current version of the common language runtime (CLR).|
|`GUID [1-10]`|A GUID used to replace the project GUID in a project file. You can specify up to 10 unique GUIDs (for example, `guid1)`.|
|`itemname`|The name provided by the user in the **Add New Item** dialog box.|
|`machinename`|The current computer name (for example, Computer01).|
|`projectname`|The name provided by the user in the **New Project** dialog box.|
|`registeredorganization`|The registry key value from HKLM\Software\Microsoft\Windows NT\CurrentVersion\RegisteredOrganization.|
|`rootnamespace`|The root namespace of the current project. This parameter applies only to item templates.|
|`safeitemname`|The name provided by the user in the **Add New Item** dialog box, with all unsafe characters and spaces removed.|
|`safeprojectname`|The name provided by the user in the **New Project** dialog box, with all unsafe characters and spaces removed.|
|`time`|The current time in the format DD/MM/YYYY 00:00:00.|
|`SpecificSolutionName`|The name of the solution. When "create solution directory" is checked, `SpecificSolutionName` has the solution name. When "create solution directory" is not checked, `SpecificSolutionName` is blank.|
|`userdomain`|The current user domain.|
|`username`|The current user name.|
|`webnamespace`|The name of the current Web site. This parameter is used in the Web form template to guarantee unique class names. If the Web site is at the root directory of the Web server, this template parameter resolves to the root directory of the Web Server.|
|`year`|The current year in the format YYYY.|

## Custom Template Parameters
 You can specify your own template parameters and values, in addition to the default reserved template parameters that are used during parameter replacement.For more information, see [CustomParameters Element (Visual Studio Templates)](../extensibility/customparameters-element-visual-studio-templates.md)

## Example: Replacing Files Names
 You can specify variable file names for project items by using a parameter with the `TargetFileName` attribute. For example, you could specify that the .exe file use the project name, specified by `$projectname$`, as the file name.

```
<TemplateContent>
    <ProjectItem
        ReplaceParameters="true"
        TargetFileName="$projectname$.exe">
            File1.exe
    </ProjectItem>
      ...
</TemplateContent>
```

## Example: Using the Project Name for the Namespace Name
 To use the project name for the namespace in a Visual C# class file, Class1.cs, use the following syntax:

```
#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace $safeprojectname$
{
    public class Class1
        {
            public Class1()
                {

                }
         }
}
```

 In the .vstemplate file for the project template, include the following XML when you reference the file Class1.cs:

```
<TemplateContent>
    <ProjectItem ReplaceParameters="true">
        Class1.cs
    </ProjectItem>
    ...
</TemplateContent>
```

## See Also
 [Customizing Templates](../ide/customizing-project-and-item-templates.md)
