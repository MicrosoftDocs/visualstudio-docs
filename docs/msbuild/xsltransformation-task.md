---
title: XslTransformation Task
description: Learn how MSBuild uses the XslTransformation task to transform an XML input using an XSLT and output to an output device or file.
ms.date: 11/04/2016
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- MSBuild, XslTransformation task
- XslTransformation task [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# XslTransformation task

Transforms an XML input by using an XSLT or compiled XSLT and outputs to an output device or a file.

## Parameters

 The following table describes the parameters of the `XslTransformation` task.

|Parameter|Description|
|---------------|-----------------|
|`OutputPaths`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the output files for the XML transformation.|
|`Parameters`|Optional `String` parameter.<br /><br /> Specifies the parameters to the XSLT Input document.  Provide the raw XML that holds each parameter as `<Parameter Name="" Value="" Namespace="" />`.|
|`UseTrustedSettings`|Optional boolean parameter.<br/><br/> If `True`, enables relaxed XSLT security settings that allow the use of the XSLT `document()` function and embedded scripts. See <xref:System.Xml.Xsl.XsltSettings.TrustedXslt*>. For associated security considerations, see [Security considerations](/dotnet/api/system.xml.xsl.xslcompiledtransform#security-considerations).|
|`XmlContent`|Optional `String` parameter.<br /><br /> Specifies the XML input as a string.|
|`XmlInputPaths`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the XML input files.|
|`XslCompiledDllPath`|Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the compiled XSLT.|
|`XslContent`|Optional `String` parameter.<br /><br /> Specifies the XSLT input as a string.|
|`XslInputPath`|Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the XSLT input file.|

## Remarks

> [!IMPORTANT]
>  XSLT style sheets can include references to other files and embedded script blocks. A malicious user can exploit this by supplying you with data or style sheets that when executed can cause your system to process until the computer runs low on resources. Do not enable scripting or the `document()` function via `UseTrustedSettings` unless the style sheet comes from a trusted source. If you cannot verify the source of the style sheet, or if the style sheet does not come from a trusted source, use the default XSLT settings.
>  
>  Also note that loading external resources, such as schemas, will allow any server hosting a schema to discover a build occurrence and its network location.

 In addition to having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example

In the following example, an XSL transform file *transform.xslt* is used to modify the xml file `$(XmlInputFileName)`. The transformed XML is written to `$(IntermediateOutputPath)output.xml`. The XSL transform takes `$(Parameter1)` as an input parameter.

```xml
    <XslTransformation XslInputPath="transform.xslt"
                       XmlInputPaths="$(XmlInputFileName)"
                       OutputPaths="$(IntermediateOutputPath)output.xml"
                       Parameters="&lt;Parameter Name='Parameter1' Value='$(Parameter1)'/&gt;"/>
```

## See also

- [XSLT Parameters](/dotnet/standard/data/xml/xslt-parameters)
- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
