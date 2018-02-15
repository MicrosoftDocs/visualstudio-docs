---
title: "Replaceable Parameters | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "SharePoint development in Visual Studio, tokens"
  - "tokens [SharePoint development in Visual Studio]"
  - "replaceable parameters [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, replaceable parameters"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Replaceable Parameters
  Replaceable parameters, or *tokens*, can be used inside project files to provide values for SharePoint solution items whose actual values are not known at design time. They are similar in function to the standard [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] template tokens. For more information, see [Template Parameters](/visualstudio/ide/template-parameters).  
  
## Token Format  
 Tokens begin and end with a dollar sign ($) character. Any tokens used are replaced with actual values when a project is packaged into a SharePoint solution package (.wsp) file at deployment time. For example, the token **$SharePoint.Package.Name$** might resolve to the string "Test SharePoint Package."  
  
## Token Rules  
 The following rules apply to tokens:  
  
-   Tokens can be specified anywhere in a line.  
  
-   Tokens cannot span multiple lines.  
  
-   The same token may be specified multiple times on the same line and in the same file.  
  
-   Different tokens may be specified on the same line.  
  
 Tokens that do not follow these rules are ignored without providing a warning or error.  
  
 The replacement of tokens by string values is done immediately after manifest transformation, thus allowing manifest templates edited by a user to use tokens.  
  
### Token Name Resolution  
 In most cases, a token resolves to a specific value regardless of where it is contained. However, if the token is related to a package or feature, the token's value depends on where it is contained. For example, if a feature is in Package A, then the token `$SharePoint.Package.Name$` resolves to the value "Package A." If the same feature is in Package B, then `$SharePoint.Package.Name$` resolves to "Package B."  
  
## Tokens List  
 The following table lists the available tokens.  
  
|Name|Description|  
|----------|-----------------|  
|$SharePoint.Project.FileName$|The name of the containing project file, such as, "NewProj.csproj".|  
|$SharePoint.Project.FileNameWithoutExtension$|The name of the containing project file without the file name extension. For example, "NewProj".|  
|$SharePoint.Project.AssemblyFullName$|The display name (strong name) of the containing project's output assembly.|  
|$SharePoint.Project.AssemblyFileName$|The name of the containing project's output assembly.|  
|$SharePoint.Project.AssemblyFileNameWithoutExtension$|The name of the containing project's output assembly, without the file name extension.|  
|$SharePoint.Project.AssemblyPublicKeyToken$|The public key token of the containing project's output assembly, converted to a string. (16-characters in "x2" hexadecimal format.)|  
|$SharePoint.Package.Name$|The name of the containing package.|  
|$SharePoint.Package.FileName$|The name of the containing package's definition file.|  
|$SharePoint.Package.FileNameWithoutExtension$|The name (without extension) of the containing package's definition file.|  
|$SharePoint.Package.Id$|The SharePoint ID for the containing package. If a feature is used in more than one package, then this value will change.|  
|$SharePoint.Feature.FileName$|The name of the definition file of the containing feature, such as Feature1.feature.|  
|$SharePoint.Feature.FileNameWithoutExtension$|The name of the feature definition file, without the file name extension.|  
|$SharePoint.Feature.DeploymentPath$|The name of the folder that contains the feature in the package. This token equates to the "Deployment Path" property in the Feature Designer. An example value is, "Project1_Feature1".|  
|$SharePoint.Feature.Id$|The SharePoint ID of the containing feature. This token, as with all feature-level tokens, can be used only by files included in a package via a feature, not added directly to a package outside of a feature.|  
|$SharePoint.ProjectItem.Name$|The name of the project item (not its file name), as obtained from **ISharePointProjectItem.Name**.|  
|$SharePoint.Type.\<GUID>.AssemblyQualifiedName$|The assembly qualified name of the type matching the [!INCLUDE[TLA2#tla_guid](../sharepoint/includes/tla2sharptla-guid-md.md)] of the token. The format of the [!INCLUDE[TLA2#tla_guid](../sharepoint/includes/tla2sharptla-guid-md.md)] is lowercase and corresponds to the Guid.ToString("D") format (that is, xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx).|  
|$SharePoint.Type.\<GUID>.FullName$|The full name of the type matching the GUID in the token. The format of the GUID is lowercase and corresponds to the Guid.ToString("D") format (that is, xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx).|  
  
## Adding Extensions to the Token Replacement File Extensions List  
 Although tokens can theoretically be used by any file that belongs to a SharePoint project item included in the package, by default, [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] searches for tokens only in package files, manifest files, and files that have the following extensions:  
  
-   [!INCLUDE[TLA2#tla_xml](../sharepoint/includes/tla2sharptla-xml-md.md)]  
  
-   ASCX  
  
-   ASPX  
  
-   Webpart  
  
-   DWP  
  
 These extensions are defined by the `<TokenReplacementFileExtensions>` element in the Microsoft.VisualStudio.SharePoint.targets file, located in the ...\\<program files\>\MSBuild\Microsoft\VisualStudio\v11.0\SharePointTools folder.  
  
 You can, however, add additional file extensions to the list. To do this, add a `<TokenReplacementFileExtensions>` element to any PropertyGroup in the SharePoint project file that is defined before the \<Import> of the SharePoint targets file.  
  
> [!NOTE]  
>  Because token replacement occurs after a project is compiled, you should not add file extensions for file types that are compiled, such as .cs, .vb or .resx. Tokens are replaced only in files that are not compiled.  
  
 For example, to add the file name extensions ".myextension" and ".yourextension" to the list of token replacement file name extensions, you would add the following to a .csproj file:  
  
```  
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  <PropertyGroup>  
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>  
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>  
.  
.  
.  
    <!-- Define the following property to add your extension to the list of token replacement file extensions.  -->  
<TokenReplacementFileExtensions>myextension;yourextension</TokenReplacementFileExtensions>  
</PropertyGroup>  
```  
  
 Alternatively, you can add the extension directly to the .targets file. However, doing this alters the extensions list for all SharePoint projects packaged on the local system, not just your own. This may be convenient when you are the sole developer on the system or if most of your projects require it. However, because it is system-specific, this approach is not very portable, and therefore, it is recommended that you add any extensions to the project file instead.  
  
## See Also  
 [Developing SharePoint Solutions](../sharepoint/developing-sharepoint-solutions.md)  
  
  