---
title: "How to: Manually Create Web Templates | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "Visual Studio templates, Web"
  - "templates [Visual Studio], Web"
  - "Web templates [Visual Studio]"
  - "project templates [Visual Studio], Web"
ms.assetid: 731c4027-a152-48c5-bfc4-93490bf1949f
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Manually Create Web Templates
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Creating a Web template is different than creating other kinds of templates. Because Web project templates appear in the **Add New Web Site** dialog box, and Web project items are categorized by programming language, the .vstemplate file must specify the template as a Web template and identify the programming language.

> [!NOTE]
> Web templates must contain a empty .webproj file that is specified by using the `File` attribute of the `Project` element. Although Web projects do not require project files, this file is required so that a Web template functions correctly.

### To manually create a Web template

1. Create a Web project.

2. Modify or delete the files in the project, or add new files to the project.

3. Create an XML file and save it by using a .vstemplate file name extension, in the same directory as your project. Do not add it to the project in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].

4. Author the .vstemplate XML file to provide project template metadata. For more information, see the example in the following section.

5. Locate the `ProjectType` element in the .vstemplate file, and set the text value to `Web`.

6. Following the `ProjectType` element, add a `ProjectSubType` element and set the text value to the programming language of the template. The programming language can be one of the following values:

   - CSharp

   - VisualBasic

     For example:

   ```
   <TemplateData>
       ...
       <ProjectType>Web</ProjectType>
       <ProjectSubType>CSharp</ProjectSubType>
       ...
   </TemplateData>
   ```

7. Select the files in your template (this includes the .vstemplate file), right-click the selection, click **Send To**, and then click **Compressed (zipped) Folder**. The files are compressed into a .zip file.

8. Put the .zip template file in the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] project template directory. By default, this directory is \My Documents\Visual Studio *Version*\My Exported Templates\\.

## Example
 The following example shows a basic .vstemplate file for a Web project template.

```
<VSTemplate Version="2.0.0" Type="Project"
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">>
    <TemplateData>
        <Name>MyWebProjecStarterKit</Name>
        <Description>A simple Web template</Description>
        <Icon>icon.ico</Icon>
        <ProjectType>Web</ProjectType>
        <ProjectSubType>CSharp</ProjectSubType>
        <DefaultName>WebSite</DefaultName>
    </TemplateData>
    <TemplateContent>
        <Project File="WebApplication.webproj">
            <ProjectItem>icon.ico</ProjectItem>
            <ProjectItem OpenInEditor="true">Default.aspx</ProjectItem>
            <ProjectItem>Default.aspx.cs</ProjectItem>
        </Project>
    </TemplateContent>
</VSTemplate>
```

## See Also
 [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
 [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)
