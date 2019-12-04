---
title: "Create site column project item with project template, part 1"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint project items, defining your own types"
  - "project items [SharePoint development in Visual Studio], defining your own types"
  - "SharePoint projects, creating custom templates"
  - "SharePoint development in Visual Studio, defining new project item types"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Walkthrough: Create a site column project item with a project template, Part 1
  SharePoint projects are containers for one or more SharePoint project items. You can extend the SharePoint project system in Visual Studio by creating your own SharePoint project item types and then associating them with a project template. In this walkthrough, you will define a project item type for creating a site column, and then you will create a project template that can be used to create a new project that contains a site column project item.

 This walkthrough demonstrates the following tasks:

- Creating a Visual Studio extension that defines a new type of SharePoint project item for a site column. The project item type includes a simple custom property that appears in the **Properties** window.

- Creating a [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] project template for the project item.

- Building a [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] Extension (VSIX) package to deploy the project template and the extension assembly.

- Debugging and testing the project item.

  This is a stand-alone walkthrough. After you complete this walkthrough, you can enhance the project item by adding a wizard to the project template. For more information, see [Walkthrough: Create a site column project item with a project template, Part 2](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-2.md).

> [!NOTE]
> For a series of sample workflows, see [SharePoint workflow samples](/sharepoint/dev/general-development/sharepoint-workflow-samples).

## Prerequisites
 You need the following components on the development computer to complete this walkthrough:

- Supported editions of Microsoft Windows, SharePoint and [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

- The [!include[vssdk_current_long](../sharepoint/includes/vssdk-current-long-md.md)]. This walkthrough uses the **VSIX Project** template in the SDK to create a VSIX package to deploy the project item. For more information, see [Extend the SharePoint Tools in Visual Studio](../sharepoint/extending-the-sharepoint-tools-in-visual-studio.md).

  Knowledge of the following concept is helpful, but not required, to complete the walkthrough:

- Site columns in SharePoint. For more information, see [Columns](/previous-versions/office/developer/sharepoint-2010/ms196085(v=office.14)).

- Project templates in Visual Studio. For more information, see [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md).

## Create the projects
 To complete this walkthrough, you need to create three projects:

- A VSIX project. This project creates the VSIX package to deploy the site column project item and the project template.

- A project template project. This project creates a project template that can be used to create a new SharePoint project that contains the site column project item.

- A class library project. This project that implements a Visual Studio extension that defines the behavior of the site column project item.

  Start the walkthrough by creating the projects.

#### To create the VSIX project

1. Start [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

2. On the menu bar, choose **File** > **New** > **Project**.

3. At the top of the **New Project** dialog box, make sure that **.NET Framework 4.5** is chosen in the list of versions of the .NET Framework.

4. Expand the **Visual Basic** or **Visual C#** nodes, and then choose the **Extensibility** node.

    > [!NOTE]
    > The **Extensibility** node is available only if you install the Visual Studio SDK. For more information, see the prerequisites section earlier in this topic.

5. In the list of project templates, choose **VSIX Project**.

6. In the **Name** box, enter **SiteColumnProjectItem**, and then choose the **OK** button.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] adds the **SiteColumnProjectItem** project to **Solution Explorer**.

#### To create the project template project

1. In **Solution Explorer**, open the shortcut menu for the solution node, choose **Add**, and then choose **New Project**.

2. At the top of the **New Project** dialog box, make sure that **.NET Framework 4.5** is chosen in the list of versions of the .NET Framework.

3. Expand the **Visual C#** or **Visual Basic** node, and then choose the **Extensibility** node.

4. In the list of project templates, choose the **C# Project Template** or **Visual Basic Project Template** template.

5. In the **Name** box, enter **SiteColumnProjectTemplate**, and then choose the **OK** button.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] adds the **SiteColumnProjectTemplate** project to the solution.

6. Delete the Class1 code file from the project.

7. If you created a Visual Basic project, also delete the following files from the project:

    - *MyApplication.Designer.vb*

    - MyApplication.myapp

    - *Resources.Designer.vb*

    - *Resources.resx*

    - *Settings.Designer.vb*

    - Settings.settings

#### To create the extension project

1. In **Solution Explorer**, open the shortcut menu for the solution node, choose **Add**, and then choose **New Project**.

2. At the top of the **New Project** dialog box, make sure that **.NET Framework 4.5** is chosen in the list of versions of the .NET Framework.

3. Expand the **Visual C#** or **Visual Basic** nodes, choose the **Windows** node, and then choose the **Class Library** template.

4. In the **Name** box, enter **ProjectItemTypeDefinition** and then choose the **OK** button.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] adds the **ProjectItemTypeDefinition** project to the solution and opens the default Class1 code file.

5. Delete the Class1 code file from the project.

## Configure the extension project
 Add code files and assembly references to configure the extension project.

#### To configure the project

1. In the ProjectItemTypeDefinition project, add a code file that's named **SiteColumnProjectItemTypeProvider**.

2. On the menu bar, choose **Project** > **Add Reference**.

3. In the **Reference Manager - ProjectItemTypeDefinition** dialog box, expand the **Assemblies** node, choose the **Framework** node, and then select the System.ComponentModel.Composition check box.

4. Choose the **Extensions** node, select the check box next to the Microsoft.VisualStudio.SharePoint assembly, and then choose the **OK** button.

## Define the new SharePoint project item type
 Create a class that implements the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider> interface to define the behavior of the new project item type. Implement this interface whenever you want to define a new type of project item.

#### To define the new SharePoint project item type

1. In the **SiteColumnProjectItemTypeProvider** code file, replace the default code with the following code, and then save the file.

     [!code-csharp[SPExtensibility.ProjectItem.SiteColumn#1](../sharepoint/codesnippet/CSharp/sitecolumnprojectitem/projectitemtypedefinition/sitecolumnprojectitemtypeprovider.cs#1)]
     [!code-vb[SPExtensibility.ProjectItem.SiteColumn#1](../sharepoint/codesnippet/VisualBasic/sitecolumnprojectitem/projectitemtypedefinition/sitecolumnprojectitemtypeprovider.vb#1)]

## Create a Visual Studio project template
 By creating a project template, you enable other developers to create SharePoint projects that contain site column project items. A SharePoint project template includes files that are required for all projects in Visual Studio, such as *.csproj* or *.vbproj* and *.vstemplate* files, and files that are specific to SharePoint projects. For more information, see [Create item templates and project templates for SharePoint project items](../sharepoint/creating-item-templates-and-project-templates-for-sharepoint-project-items.md).

 In this procedure, you create an empty SharePoint project to generate the files that are specific to SharePoint projects. You then add these files to the SiteColumnProjectTemplate project so that they're included in the template that's generated from this project. You also configure the SiteColumnProjectTemplate project file to specify where the project template appears in the **New Project** dialog box.

#### To create the files for the project template

1. Start a second instance of [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] with administrative credentials.

2. Create a SharePoint 2010 project that's named **BaseSharePointProject**.

   > [!IMPORTANT]
   > In the **SharePoint Customization Wizard**, don't select the **Deploy as a farm solution** option button.

3. Add an Empty Element item to the project, and then name the item **Field1**.

4. Save the project, and then close the second instance of [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

5. In the instance of [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] that has the SiteColumnProjectItem solution open, in **Solution Explorer**, open the shortcut menu for the **SiteColumnProjectTemplate** project node, choose **Add**, and then choose **Existing Item**.

6. In the **Add Existing Item** dialog box, open the list of file extensions, and then choose **All Files (\*.\*)**.

7. In the directory that contains the BaseSharePointProject project, select the key.snk file, and then choose the **Add** button.

   > [!NOTE]
   > In this walkthrough, the project template that you create uses the same key.snk file to sign each project that's created by using the template. To learn how to expand this sample to create a different key.snk file for each project instance, see [Walkthrough: Create a site column project item with a project template, Part 2](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-2.md).

8. Repeat steps 5-8 to add the following files from the specified subfolders in the BaseSharePointProject directory:

   - *\Field1\Elements.xml*

   - *\Field1\SharePointProjectItem.spdata*

   - *\Features\Feature1\Feature1.feature*

   - *\Features\Feature1\Feature1.Template.xml*

   - *\Package\Package.package*

   - *\Package\Package.Template.xml*

     Add these files directly to the SiteColumnProjectTemplate project; don't recreate the Field1, Features, or Package subfolders in the project. For more information about these files, see [Create item templates and project templates for SharePoint project items](../sharepoint/creating-item-templates-and-project-templates-for-sharepoint-project-items.md).

#### To configure how developers discover the project template in the New Project dialog box

1. In **Solution Explorer**, open the shortcut menu for the **SiteColumnProjectTemplate** project node, and then choose **Unload Project**. If you are prompted to save changes to any files, choose the **Yes** button.

2. Open the shortcut menu for the **SiteColumnProjectTemplate** node again, and then choose **Edit SiteColumnProjectTemplate.csproj** or **Edit SiteColumnProjectTemplate.vbproj**.

3. In the project file, locate the following `VSTemplate` element.

    ```xml
    <VSTemplate Include="SiteColumnProjectTemplate.vstemplate">
    ```

4. Replace this element with the following XML.

    ```xml
    <VSTemplate Include="SiteColumnProjectTemplate.vstemplate">
      <OutputSubPath>SharePoint\SharePoint14</OutputSubPath>
    </VSTemplate>
    ```

     The `OutputSubPath` element specifies additional folders in the path under which the project template is created when you build the project. The folders specified here ensure that the project template will be available only when customers open the **New Project** dialog box, expand the **SharePoint** node, and then choose the **2010** node.

5. Save and close the file.

6. In **Solution Explorer**, open the shortcut menu for the **SiteColumnProjectTemplate** project, and then choose **Reload Project**.

## Edit the project template files
 In the SiteColumnProjectTemplate project, edit the following files to define the behavior of the project template:

- *AssemblyInfo.cs* or *AssemblyInfo.vb*

- *Elements.xml*

- *SharePointProjectItem.spdata*

- *Feature1.feature*

- *Package.package*

- *SiteColumnProjectTemplate.vstemplate*

- *ProjectTemplate.csproj* or *ProjectTemplate.vbproj*

  In the following procedures, you'll add replaceable parameters to some of these files. A replaceable parameter is a token that starts and ends with the dollar sign ($) character. When a user uses this project template to create a project, Visual Studio automatically replaces these parameters in the new project with specific values. For more information, see [Replaceable parameters](../sharepoint/replaceable-parameters.md).

#### To edit the AssemblyInfo.cs or AssemblyInfo.vb file

1. In the SiteColumnProjectTemplate project, open the *AssemblyInfo.cs* or *AssemblyInfo.vb* file, and then add the following statement to the top of it:

    ```vb
    Imports System.Security
    ```

    ```csharp
    using System.Security;
    ```

     When the **Sandboxed Solution** property of a SharePoint project is set to **True**, Visual Studio adds the <xref:System.Security.AllowPartiallyTrustedCallersAttribute> to the AssemblyInfo code file. However, the AssemblyInfo code file in the project template doesn't import the <xref:System.Security> namespace by default. You must add this **using** or **Imports** statement to prevent compile errors.

2. Save and close the file.

#### To edit the Elements.xml file

1. In the SiteColumnProjectTemplate project, replace the contents of the *Elements.xml* file with the following XML.

    ```xml
    <?xml version="1.0" encoding="utf-8"?>
    <Elements xmlns="http://schemas.microsoft.com/sharepoint/">
      <Field ID="{$guid5$}"
          Name="$safeprojectname$"
          DisplayName="$projectname$"
          Type="Text"
          Group="Custom Columns">
      </Field>
    </Elements>
    ```

     The new XML adds a `Field` element that defines the name of the site column, its base type, and the group in which to list the site column in the gallery. For more information about the contents of this file, see [Field Definition Schema](/previous-versions/office/developer/sharepoint-2010/ms196289(v=office.14)).

2. Save and close the file.

#### To edit the SharePointProjectItem.spdata file

1. In the SiteColumnProjectTemplate project, replace the contents of the *SharePointProjectItem.spdata* file with the following XML.

   ```xml
   <?xml version="1.0" encoding="utf-8"?>
   <ProjectItem Type="Contoso.SiteColumn" DefaultFile="Elements.xml"
                xmlns="http://schemas.microsoft.com/VisualStudio/2010/SharePointTools/SharePointProjectItemModel">
     <Files>
       <ProjectItemFile Source="Elements.xml" Target="$safeprojectname$\" Type="ElementManifest" />
     </Files>
   </ProjectItem>
   ```

    The new XML makes the following changes to the file:

   - Changes the `Type` attribute of the `ProjectItem` element to the same string that's passed to the <xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemTypeAttribute> on the project item definition (the `SiteColumnProjectItemTypeProvider` class that you created earlier in this walkthrough).

   - Removes the `SupportedTrustLevels` and `SupportedDeploymentScopes` attributes from the `ProjectItem` element. These attribute values are unnecessary because the trust levels and deployment scopes are specified in the `SiteColumnProjectItemTypeProvider` class in the ProjectItemTypeDefinition project.

     For more information about the contents of *.spdata* files, see [SharePoint project item schema reference](../sharepoint/sharepoint-project-item-schema-reference.md).

2. Save and close the file.

#### To edit the Feature1.feature file

1. In the SiteColumnProjectTemplate project, replace the contents of the *Feature1.feature* file with the following XML.

   ```xml
   <?xml version="1.0" encoding="utf-8"?>
   <feature xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="$guid4$" featureId="$guid4$"
            imageUrl="" solutionId="00000000-0000-0000-0000-000000000000" title="Site Column Feature1" version=""
            deploymentPath="$SharePoint.Project.FileNameWithoutExtension$_$SharePoint.Feature.FileNameWithoutExtension$"
            xmlns="http://schemas.microsoft.com/VisualStudio/2008/SharePointTools/FeatureModel">
     <projectItems>
       <projectItemReference itemId="$guid2$" />
     </projectItems>
   </feature>
   ```

    The new XML makes the following changes to the file:

   - Changes the values of the `Id` and `featureId` attributes of the `feature` element to `$guid4$`.

   - Changes the values of the `itemId` attribute of the `projectItemReference` element to `$guid2$`.

     For more information about *.feature* files, see [Create item templates and project templates for SharePoint project items](../sharepoint/creating-item-templates-and-project-templates-for-sharepoint-project-items.md).

2. Save and close the file.

#### To edit the Package.package file

1. In the SiteColumnProjectTemplate project, replace the contents of the *Package.package* file with the following XML.

   ```xml
   <?xml version="1.0" encoding="utf-8"?>
   <package xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0"
            Id="$guid3$" solutionId="$guid3$" resetWebServer="false" name="$safeprojectname$"
            xmlns="http://schemas.microsoft.com/VisualStudio/2008/SharePointTools/PackageModel">
     <features>
       <featureReference itemId="$guid4$" />
     </features>
   </package>
   ```

    The new XML makes the following changes to the file:

   - Changes the values of the `Id` and `solutionId` attributes of the `package` element to `$guid3$`.

   - Changes the values of the `itemId` attribute of the `featureReference` element to `$guid4$`.

     For more information about *.package* files, see [Create item templates and project templates for SharePoint project items](../sharepoint/creating-item-templates-and-project-templates-for-sharepoint-project-items.md).

2. Save and close the file.

#### To edit the sitecolumnprojecttemplate.vstemplate file

1. In the SiteColumnProjectTemplate project, replace the contents of the SiteColumnProjectTemplate.vstemplate file with one of the following sections of XML.

   - If you're creating a Visual C# project template, use the following XML.

   ```xml
   <?xml version="1.0" encoding="utf-8"?>
   <VSTemplate Version="3.0.0" xmlns="http://schemas.microsoft.com/developer/vstemplate/2005" Type="Project">
     <TemplateData>
       <Name>Site Column</Name>
       <Description>Creates a new site column in SharePoint</Description>
       <FrameworkVersion>3.5</FrameworkVersion>
       <ProjectType>CSharp</ProjectType>
       <CreateNewFolder>true</CreateNewFolder>
       <CreateInPlace>true</CreateInPlace>
       <ProvideDefaultName>true</ProvideDefaultName>
       <DefaultName>SiteColumn</DefaultName>
       <LocationField>Enabled</LocationField>
       <EnableLocationBrowseButton>true</EnableLocationBrowseButton>
       <PromptForSaveOnCreation>true</PromptForSaveOnCreation>
       <NumberOfParentCategoriesToRollUp>1</NumberOfParentCategoriesToRollUp>
       <Icon>SiteColumnProjectTemplate.ico</Icon>
       <SortOrder>1000</SortOrder>
     </TemplateData>
     <TemplateContent>
       <Project TargetFileName="SharePointProject1.csproj" File="ProjectTemplate.csproj" ReplaceParameters="true">
         <ProjectItem ReplaceParameters="true" TargetFileName="Properties\AssemblyInfo.cs">AssemblyInfo.cs</ProjectItem>
         <ProjectItem ReplaceParameters="true" TargetFileName="Features\Feature1\Feature1.feature">Feature1.feature</ProjectItem>
         <ProjectItem ReplaceParameters="true" TargetFileName="Features\Feature1\Feature1.Template.xml">Feature1.template.xml</ProjectItem>
         <ProjectItem ReplaceParameters="true" TargetFileName="Package\Package.package">Package.package</ProjectItem>
         <ProjectItem ReplaceParameters="true" TargetFileName="Package\Package.Template.xml">Package.Template.xml</ProjectItem>
         <ProjectItem ReplaceParameters="true" TargetFileName="Field1\SharePointProjectItem.spdata">SharePointProjectItem.spdata</ProjectItem>
         <ProjectItem ReplaceParameters="true" TargetFileName="Field1\Elements.xml" OpenInEditor="true">Elements.xml</ProjectItem>
         <ProjectItem ReplaceParameters="false" TargetFileName="key.snk">key.snk</ProjectItem>
       </Project>
     </TemplateContent>
   </VSTemplate>
   ```

   - If you're creating a Visual Basic project template, use the following XML.

   ```xml
   <?xml version="1.0" encoding="utf-8"?>
   <VSTemplate Version="3.0.0" xmlns="http://schemas.microsoft.com/developer/vstemplate/2005" Type="Project">
     <TemplateData>
       <Name>Site Column</Name>
       <Description>Creates a new site column in SharePoint</Description>
       <FrameworkVersion>3.5</FrameworkVersion>
       <ProjectType>VisualBasic</ProjectType>
       <CreateNewFolder>true</CreateNewFolder>
       <CreateInPlace>true</CreateInPlace>
       <ProvideDefaultName>true</ProvideDefaultName>
       <DefaultName>SiteColumn</DefaultName>
       <LocationField>Enabled</LocationField>
       <EnableLocationBrowseButton>true</EnableLocationBrowseButton>
       <PromptForSaveOnCreation>true</PromptForSaveOnCreation>
       <NumberOfParentCategoriesToRollUp>1</NumberOfParentCategoriesToRollUp>
       <Icon>SiteColumnProjectTemplate.ico</Icon>
       <SortOrder>1000</SortOrder>
     </TemplateData>
     <TemplateContent>
       <Project TargetFileName="SharePointProject1.vbproj" File="ProjectTemplate.vbproj" ReplaceParameters="true">
         <ProjectItem ReplaceParameters="true" TargetFileName="My Project\AssemblyInfo.vb">AssemblyInfo.vb</ProjectItem>
         <ProjectItem ReplaceParameters="true" TargetFileName="Features\Feature1\Feature1.feature">Feature1.feature</ProjectItem>
         <ProjectItem ReplaceParameters="true" TargetFileName="Features\Feature1\Feature1.Template.xml">Feature1.template.xml</ProjectItem>
         <ProjectItem ReplaceParameters="true" TargetFileName="Package\Package.package">Package.package</ProjectItem>
         <ProjectItem ReplaceParameters="true" TargetFileName="Package\Package.Template.xml">Package.Template.xml</ProjectItem>
         <ProjectItem ReplaceParameters="true" TargetFileName="Field1\SharePointProjectItem.spdata">SharePointProjectItem.spdata</ProjectItem>
         <ProjectItem ReplaceParameters="true" TargetFileName="Field1\Elements.xml" OpenInEditor="true">Elements.xml</ProjectItem>
         <ProjectItem ReplaceParameters="false" TargetFileName="key.snk">key.snk</ProjectItem>
       </Project>
     </TemplateContent>
   </VSTemplate>
   ```

    The new XML makes the following changes to the file:

   - Sets the `Name` element to the value **Site Column**. (This name appears in the **New Project** dialog box).

   - Adds `ProjectItem` elements for each filethat's included in each project instance.

   - Uses the namespace "<http://schemas.microsoft.com/developer/vstemplate/2005>". Other project files in this solution use the "<http://schemas.microsoft.com/developer/msbuild/2003>" namespace. Therefore, XML schema warning messages will be generated, but you can disregard them in this walkthrough.

     For more information about the contents of *.vstemplate* files, see [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md).

2. Save and close the file.

#### To edit the projecttemplate.csproj or projecttemplate.vbproj file

1. In the SiteColumnProjectTemplate project, replace the contents of the *ProjectTemplate.csproj* file or *ProjectTemplate.vbproj* file with one of the following sections of XML.

    - If you're creating a Visual C# project template, use the following XML.

    ```xml
    <?xml version="1.0" encoding="utf-8"?>
    <Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
      <PropertyGroup>
        <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
        <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
        <SchemaVersion>2.0</SchemaVersion>
        <ProjectGuid>{$guid1$}</ProjectGuid>
        <OutputType>Library</OutputType>
        <AppDesignerFolder>Properties</AppDesignerFolder>
        <RootNamespace>$safeprojectname$</RootNamespace>
        <AssemblyName>$safeprojectname$</AssemblyName>
        <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
        <FileAlignment>512</FileAlignment>
        <ProjectTypeGuids>{BB1F664B-9266-4fd6-B973-E1E44974B511};{14822709-B5A1-4724-98CA-57A101D1B079};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
      </PropertyGroup>
      <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
        <DebugSymbols>true</DebugSymbols>
        <DebugType>full</DebugType>
        <Optimize>false</Optimize>
        <OutputPath>bin\Debug\</OutputPath>
        <DefineConstants>DEBUG;TRACE</DefineConstants>
        <ErrorReport>prompt</ErrorReport>
        <WarningLevel>4</WarningLevel>
        <UseVSHostingProcess>false</UseVSHostingProcess>
      </PropertyGroup>
      <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
        <DebugType>pdbonly</DebugType>
        <Optimize>true</Optimize>
        <OutputPath>bin\Release\</OutputPath>
        <DefineConstants>TRACE</DefineConstants>
        <ErrorReport>prompt</ErrorReport>
        <WarningLevel>4</WarningLevel>
      </PropertyGroup>
      <PropertyGroup>
        <SignAssembly>true</SignAssembly>
        <AssemblyOriginatorKeyFile>key.snk</AssemblyOriginatorKeyFile>
      </PropertyGroup>
      <ItemGroup>
        <Reference Include="System" />
        <Reference Include="System.Core" />
        <Reference Include="System.Data" />
        <Reference Include="System.Data.DataSetExtensions" />
        <Reference Include="System.Web" />
        <Reference Include="System.Xml" />
        <Reference Include="System.Xml.Linq" />
        <Reference Include="Microsoft.SharePoint" />
        <Reference Include="Microsoft.SharePoint.Security" />
      </ItemGroup>
      <ItemGroup>
        <Compile Include="Properties\AssemblyInfo.cs" />
      </ItemGroup>
      <ItemGroup>
        <None Include="Field1\SharePointProjectItem.spdata">
          <SharePointProjectItemId>{$guid2$}</SharePointProjectItemId>
        </None>
        <None Include="Field1\Elements.xml" />
      </ItemGroup>
      <ItemGroup>
        <None Include="key.snk" />
        <None Include="Package\Package.package">
          <PackageId>{$guid3$}</PackageId>
        </None>
        <None Include="Package\Package.Template.xml">
          <DependentUpon>Package.package</DependentUpon>
        </None>
        <None Include="Features\Feature1\Feature1.feature">
          <FeatureId>{$guid4$}</FeatureId>
        </None>
        <None Include="Features\Feature1\Feature1.Template.xml">
          <DependentUpon>Feature1.feature</DependentUpon>
        </None>
      </ItemGroup>
      <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
      <Import Project="$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v10.0\SharePointTools\Microsoft.VisualStudio.SharePoint.targets" />
    </Project>
    ```

    1. If you're creating a Visual Basic project template, use the following XML.

    ```xml
    <?xml version="1.0" encoding="utf-8"?>
    <Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
      <PropertyGroup>
        <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
        <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
        <ProductVersion>
        </ProductVersion>
        <SchemaVersion>
        </SchemaVersion>
        <ProjectGuid>{$guid1$}</ProjectGuid>
        <OutputType>Library</OutputType>
        <RootNamespace>$safeprojectname$</RootNamespace>
        <AssemblyName>$safeprojectname$</AssemblyName>
        <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
        <FileAlignment>512</FileAlignment>
        <ProjectTypeGuids>{BB1F664B-9266-4fd6-B973-E1E44974B511};{D59BE175-2ED0-4C54-BE3D-CDAA9F3214C8};{F184B08F-C81C-45F6-A57F-5ABD9991F28F}</ProjectTypeGuids>
        <OptionExplicit>On</OptionExplicit>
        <OptionCompare>Binary</OptionCompare>
        <OptionStrict>Off</OptionStrict>
        <OptionInfer>On</OptionInfer>
      </PropertyGroup>
      <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
        <DebugSymbols>true</DebugSymbols>
        <DebugType>full</DebugType>
        <DefineDebug>true</DefineDebug>
        <DefineTrace>true</DefineTrace>
        <OutputPath>bin\Debug\</OutputPath>
        <WarningLevel>4</WarningLevel>
        <UseVSHostingProcess>false</UseVSHostingProcess>
      </PropertyGroup>
      <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
        <DebugType>pdbonly</DebugType>
        <DefineDebug>false</DefineDebug>
        <DefineTrace>true</DefineTrace>
        <Optimize>true</Optimize>
        <OutputPath>bin\Release\</OutputPath>
        <UseVSHostingProcess>false</UseVSHostingProcess>
      </PropertyGroup>
      <PropertyGroup>
        <SignAssembly>true</SignAssembly>
        <AssemblyOriginatorKeyFile>key.snk</AssemblyOriginatorKeyFile>
      </PropertyGroup>
      <ItemGroup>
        <Reference Include="System" />
        <Reference Include="System.Core" />
        <Reference Include="System.Data" />
        <Reference Include="System.Data.DataSetExtensions" />
        <Reference Include="System.Xml" />
        <Reference Include="System.Xml.Linq" />
        <Reference Include="Microsoft.SharePoint" />
        <Reference Include="Microsoft.SharePoint.Security" />
      </ItemGroup>
      <ItemGroup>
        <Import Include="Microsoft.VisualBasic" />
        <Import Include="System" />
        <Import Include="System.Collections" />
        <Import Include="System.Collections.Generic" />
        <Import Include="System.Data" />
        <Import Include="System.Diagnostics" />
        <Import Include="System.Linq" />
        <Import Include="System.Xml.Linq" />
        <Import Include="Microsoft.SharePoint" />
        <Import Include="Microsoft.SharePoint.Security" />
      </ItemGroup>
      <ItemGroup>
        <Compile Include="My Project\AssemblyInfo.vb" />
      </ItemGroup>
      <ItemGroup>
        <AppDesigner Include="My Project\" />
      </ItemGroup>
      <ItemGroup>
        <None Include="Features\Feature1\Feature1.feature">
          <FeatureId>{$guid4$}</FeatureId>
        </None>
        <None Include="Field1\SharePointProjectItem.spdata">
          <SharePointProjectItemId>{$guid2$}</SharePointProjectItemId>
        </None>
        <None Include="key.snk" />
        <None Include="Package\Package.package">
          <PackageId>{$guid3$}</PackageId>
        </None>
        <None Include="Package\Package.Template.xml">
          <DependentUpon>Package.package</DependentUpon>
        </None>
      </ItemGroup>
      <ItemGroup>
        <None Include="Features\Feature1\Feature1.Template.xml">
          <DependentUpon>Feature1.feature</DependentUpon>
        </None>
        <None Include="Field1\Elements.xml" />
      </ItemGroup>
      <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
      <Import Project="$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v10.0\SharePointTools\Microsoft.VisualStudio.SharePoint.targets" />
    </Project>
    ```

     The new XML makes the following changes to the file:

    - Uses the `TargetFrameworkVersion` element to specify the .NET Framework 3.5, not 4.5.

    - Adds `SignAssembly` and `AssemblyOriginatorKeyFile` elements to sign the project output.

    - Adds `Reference` elements for assembly references that SharePoint projects use.

    - Adds elements for each default file in the project, such as *Elements.xml* and *SharePointProjectItem.spdata*.

2. Save and close the file.

## Create a VSIX package to deploy the project template
 To deploy the extension, use the VSIX project in the **SiteColumnProjectItem** solution to create a VSIX package. First, configure the VSIX package by modifying the source.extension.vsixmanifest file that is included in the VSIX project. Then, create the VSIX package by building the solution.

#### To configure and create the VSIX package

1. In **Solution Explorer**, in the **SiteColumnProjectItem** project, open the source.extension.vsixmanifest file in the manifest editor.

     The source.extension.vsixmanifest file is the basis for the extension.vsixmanifest file that all VSIX packages require. For more information about this file, see [VSIX Extension Schema 1.0 Reference](https://msdn.microsoft.com/76e410ec-b1fb-4652-ac98-4a4c52e09a2b).

2. In the **Product Name** box, enter **Site Column**.

3. In the **Author** box, enter **Contoso**.

4. In the **Description** box, enter **A SharePoint project for creating site columns**.

5. Choose the **Assets** tab, and then choose the **New** button.

     The **Add New Asset** dialog box opens.

6. In the **Type** list, choose **Microsoft.VisualStudio.ProjectTemplate**.

    > [!NOTE]
    > This value corresponds to the `ProjectTemplate` element in the extension.vsixmanifest file. This element identifies the subfolder in the VSIX package that contains the project template. For more information, see [ProjectTemplate Element (VSX Schema)](/previous-versions/visualstudio/visual-studio-2010/dd393735\(v\=vs.100\)).

7. In the **Source** list, choose **A project in current solution**.

8. In the **Project** list, and choose **SiteColumnProjectTemplate**, and then choose the **OK** button.

9. Choose the **New** button again.

     The **Add New Asset** dialog box opens.

10. In the **Type** list, choose **Microsoft.VisualStudio.MefComponent**.

    > [!NOTE]
    > This value corresponds to the `MefComponent` element in the extension.vsixmanifest file. This element specifies the name of an extension assembly in the VSIX package. For more information, see [MEFComponent Element (VSX Schema)](/previous-versions/visualstudio/visual-studio-2010/dd393736\(v\=vs.100\)).

11. In the **Source** list, choose **A project in current solution**.

12. In the **Project** list, choose **ProjectItemTypeDefinition**, and then choose the **OK** button.

13. On the menu bar, choose **Build** > **Build Solution**, and then make sure that the project compiles without errors.

## Test the project template
 You are now ready to test the project template. First, start debugging the SiteColumnProjectItem solution in the experimental instance of Visual Studio. Then, test the **Site Column** project in the experimental instance of Visual Studio. Finally, build and run the SharePoint project to verify that the site column works as expected.

#### To start debugging the solution

1. Restart Visual Studio with administrative credentials, and then open the SiteColumnProjectItem solution.

2. In the SiteColumnProjectItemTypeProvider code file, add a breakpoint to the first line of code in the `InitializeType` method, and then choose the **F5** key to start debugging.

     Visual Studio installs the extension to %UserProfile%\AppData\Local\Microsoft\VisualStudio\10.0Exp\Extensions\Contoso\Site Column\1.0 and starts an experimental instance of Visual Studio. You will test the project item in this instance of Visual Studio.

#### To test the project in Visual Studio

1. In the experimental instance of Visual Studio, on the menu bar, choose **File** > **New** > **Project**.

2. Expand the **Visual C#** or **Visual Basic** node (depending on the language that your project template supports), expand the **SharePoint** node, and then choose the **2010** node.

3. In the list of project templates, choose the **Site Column** template.

4. In the **Name** box, enter **SiteColumnTest** and then choose the **OK** button.

     In **Solution Explorer**, a new project appears with a project item that's named **Field1**.

5. Verify that the code in the other instance of Visual Studio stops on the breakpoint that you set earlier in the `InitializeType` method, and then choose the **F5** key to continue to debug the project.

6. In **Solution Explorer**, choose the **Field1** node, and then choose the **F4** key.

     The **Properties** window opens.

7. In the properties list, verify that the property **Example Property** appears.

#### To test the site column in SharePoint

1. In **Solution Explorer**, choose the **SiteColumnTest** node.

2. In the **Properties** window, in the text box that's next to the **Site URL** property, enter **http://localhost**.

     This step specifies the local SharePoint site on the development computer that you want to use for debugging.

    > [!NOTE]
    > The **Site URL** property is empty by default because the Site Column project template doesn't provide a wizard for collecting this value when the project is created. To learn how to add a wizard that asks the developer for this value and then configures this property in the new project, see [Walkthrough: Create a site column project item with a project template, Part 2](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-2.md).

3. Choose the **F5** key.

     The site column is packaged and deployed to the SharePoint site that's specified in the **Site URL** property of the project. The web browser opens to the default page of this site.

    > [!NOTE]
    > If the **Script Debugging Disabled** dialog box appears, choose the **Yes** button to continue to debug the project.

4. On the **Site Actions** menu, choose **Site Settings**.

5. On the **Site Settings** page, under the **Galleries** list, choose the **Site columns** link.

6. In the list of site columns, verify that a **Custom Columns** group contains a column that's named **SiteColumnTest**.

7. Close the web browser.

## Clean up the development computer
 After you finish testing the project, remove the project template from the experimental instance of Visual Studio.

#### To clean up the development computer

1. In the experimental instance of Visual Studio, on the menu bar, choose **Tools** > **Extensions and Updates**.

     The **Extensions and Updates** dialog box opens.

2. In the list of extensions, choose the **Site Column** extension, and then choose the **Uninstall** button.

3. In the dialog box that appears, choose the **Yes** button to confirm that you want to uninstall the extension.

4. Choose the **Close** button to complete the uninstallation.

5. Close both instances of Visual Studio (the experimental instance and the instance of Visual Studio in which the SiteColumnProjectItem solution is open).

## Next steps
 After you complete this walkthrough, you can add a wizard to the project template. When a user creates a Site Column project, the wizard asks the user for the site URL to use for debugging and whether the new solution is sandboxed, and the wizard configures the new project with this information. The wizard also collects information about the column (such as the base type and the group in which to list the column in the site column gallery) and adds this information to the *Elements.xml* file in the new project. For more information, see [Walkthrough: Create a site column project item with a project template, Part 2](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-2.md).

## See also

- [Walkthrough: Create a site column project item with a project template, Part 2](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-2.md)
- [Define custom SharePoint project item types](../sharepoint/defining-custom-sharepoint-project-item-types.md)
- [Create item templates and project templates for SharePoint project items](../sharepoint/creating-item-templates-and-project-templates-for-sharepoint-project-items.md)
- [Save data in extensions of the SharePoint project system](../sharepoint/saving-data-in-extensions-of-the-sharepoint-project-system.md)
- [Associate custom data with SharePoint tools extensions](../sharepoint/associating-custom-data-with-sharepoint-tools-extensions.md)