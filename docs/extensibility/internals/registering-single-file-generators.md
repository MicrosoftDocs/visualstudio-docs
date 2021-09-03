---
title: Registering Single File Generators | Microsoft Docs
description: Learn how to register a custom tool in Visual Studio to instantiate it and associate it with a particular project type.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- registration, custom tools
- custom tools, defining registry settings
ms.assetid: db7592c0-1273-4843-9617-6e2ddabb6ca8
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Registering Single File Generators
To make a custom tool available in [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)], you must register it so [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] can instantiate it and associates it with a particular project type.

### To register a custom tool

1. Register the custom tool DLL either in the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] local registry or in the system registry, under HKEY_CLASSES_ROOT.

    For example, here's the registration information for the managed MSDataSetGenerator custom tool, which comes with [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)]:

   ```
   [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\14.0\CLSID\{E76D53CC-3D4F-40A2-BD4D-4F3419755476}]
   @="COM+ class: Microsoft.VSDesigner.CodeGenerator.TypedDataSourceGenerator.DataSourceGeneratorWrapper"
   "InprocServer32"="C:\\WINDOWS\\system32\\mscoree.dll"
   "ThreadingModel"="Both"
   "Class"="Microsoft.VSDesigner.CodeGenerator.TypedDataSourceGenerator.DataSourceGeneratorWrapper"
   "Assembly"="Microsoft.VSDesigner, Version=14.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a"
   ```

2. Create a registry key in the desired [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] hive under Generators\\*GUID* where *GUID* is the GUID defined by the specific language's project system or service. The name of the key becomes the programmatic name of your custom tool. The custom tool key has the following values:

   - (Default)

        Optional. Provides a user-friendly description of the custom tool. This parameter is optional, but recommended.

   - CLSID

        Required. Specifies the identifier of the class library of the COM component that implements <xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGenerator>.

   - GeneratesDesignTimeSource

        Required. Indicates whether types from files produced by this custom tool are made available to visual designers. The value of this parameter needs to be (zero) 0 for types not available to visual designers or (one) 1 for types available to visual designers.

   > [!NOTE]
   > You must register the custom tool separately for each language for which you want the custom tool to be available.

    For example, the MSDataSetGenerator registers itself once for each language:

   ```
   [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\14.0\Generators\{164b10b9-b200-11d0-8c61-00a0c91e29d5}\MSDataSetGenerator]
   @="Microsoft VB Code Generator for XSD"
   "CLSID"="{E76D53CC-3D4F-40a2-BD4D-4F3419755476}"
   "GeneratesDesignTimeSource"=dword:00000001

   [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\14.0\Generators\{fae04ec1-301f-11d3-bf4b-00c04f79efbc}\MSDataSetGenerator]
   @="Microsoft C# Code Generator for XSD"
   "CLSID"="{E76D53CC-3D4F-40a2-BD4D-4F3419755476}"
   "GeneratesDesignTimeSource"=dword:00000001
   ```

## See also
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGenerator>
- [Implementing Single-File Generators](../../extensibility/internals/implementing-single-file-generators.md)
- [Exposing Types to Visual Designers](../../extensibility/internals/exposing-types-to-visual-designers.md)
- [Introduction to the BuildManager Object](/previous-versions/8f9kffa8(v=vs.140))