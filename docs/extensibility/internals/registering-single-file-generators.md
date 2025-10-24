---
title: Registering Single File Generators
description: Learn how to register a custom tool in Visual Studio to instantiate it and associate it with a particular project type.
ms.date: 10/23/2025
ms.topic: conceptual
helpviewer_keywords:
- registration, custom tools
- custom tools, defining registry settings
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Registering Single File Generators

To make a custom tool available in Visual Studio, you must register it so Visual Studio can instantiate it and associates it with a particular project type.

The registry for Visual Studio is in a private hive, *privateregistry.bin*. Open *regedit.exe* and follow these instructions to load the private registry hive for the desired installation of Visual Studio: [Editing the registry for a Visual Studio instance](../../install/tools-for-managing-visual-studio-instances.md#editing-the-registry-for-a-visual-studio-instance).

### To register a custom tool

1. Register the custom tool DLL either in the Visual Studio local registry (which loads under HKEY_LOCAL_MACHINE) or in the system registry, under HKEY_CLASSES_ROOT.

    For example, here's the registration information for the managed MSDataSetGenerator custom tool, which comes with Visual Studio:

   ```
   [HKEY_LOCAL_MACHINE\{hive}\SOFTWARE\Microsoft\VisualStudio\17.0_**_Config\CLSID\{E76D53CC-3D4F-40A2-BD4D-4F3419755476}]
   @="COM+ class: Microsoft.VSDesigner.CodeGenerator.TypedDataSourceGenerator.DataSourceGeneratorWrapper"
   "InprocServer32"="C:\\WINDOWS\\system32\\mscoree.dll"
   "ThreadingModel"="Both"
   "Class"="Microsoft.VSDesigner.CodeGenerator.TypedDataSourceGenerator.DataSourceGeneratorWrapper"
   "Assembly"="Microsoft.VSDesigner, Version=17.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a"
   ```

   The `{hive}` is the name you provided when you loaded *privateregistry.bin* in the registry editor, and the instance folder (shown here as `17.0_**_Config`) is specific to a particular installation of Visual Studio on your machine.

2. Create a registry key in the desired Visual Studio hive under Generators\\*GUID* where *GUID* is the GUID defined by the specific language's project system or service. The name of the key becomes the programmatic name of your custom tool. The custom tool key has the following values:

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
   [HKEY_LOCAL_MACHINE\{hive}\SOFTWARE\Microsoft\VisualStudio\17.0_**_Config\Generators\{164b10b9-b200-11d0-8c61-00a0c91e29d5}\MSDataSetGenerator]
   @="Microsoft VB Code Generator for XSD"
   "CLSID"="{E76D53CC-3D4F-40a2-BD4D-4F3419755476}"
   "GeneratesDesignTimeSource"=dword:00000001

   [HKEY_LOCAL_MACHINE\{hive}\SOFTWARE\Microsoft\VisualStudio\17.0_**_Config\Generators\{fae04ec1-301f-11d3-bf4b-00c04f79efbc}\MSDataSetGenerator]
   @="Microsoft C# Code Generator for XSD"
   "CLSID"="{E76D53CC-3D4F-40a2-BD4D-4F3419755476}"
   "GeneratesDesignTimeSource"=dword:00000001
   ```

## Related content
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGenerator>
- [Implementing Single-File Generators](../../extensibility/internals/implementing-single-file-generators.md)
- [Exposing Types to Visual Designers](../../extensibility/internals/exposing-types-to-visual-designers.md)
- [Introduction to the BuildManager Object](/previous-versions/8f9kffa8(v=vs.140))
