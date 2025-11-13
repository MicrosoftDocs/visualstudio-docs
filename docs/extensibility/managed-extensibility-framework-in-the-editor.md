---
title: Managed Extensibility Framework in the Editor
description: Learn about the Managed Extensibility Framework, which allows you to build your own components to extend the editor in the Visual Studio SDK.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- editors [Visual Studio SDK], new - using MEF for extensions
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Managed Extensibility Framework in the editor

The editor is built by using Managed Extensibility Framework (MEF) components. You can build your own MEF components to extend the editor, and your code can consume editor components as well.

The MEF is a .NET library that lets you add and modify features of an application or component that follows the MEF programming model. The Visual Studio editor can both provide and consume MEF component parts.

The MEF is contained in the .NET Framework version 4 *System.ComponentModel.Composition.dll* assembly.

For more information about MEF, see [Managed Extensibility Framework (MEF)](/dotnet/framework/mef/index).

## Component parts and composition containers
 A component part is a class or a member of a class that can do one (or both) of the following:

- Consume another component

- Be consumed by another component

  For example, consider a shopping application that has an order entry component that depends on product availability data provided by a warehouse inventory component. In MEF terms, the inventory part can *export* product availability data, and the order entry part can *import* the data. The order entry part and the inventory part do not have to know about each other; the *composition container* (provided by the host application) is responsible for maintaining the set of exports, and resolving the exports and imports.

  The composition container, <xref:System.ComponentModel.Composition.Hosting.CompositionContainer>, is typically owned by the host. The composition container maintains a *catalog* of exported component parts.

## Export and import component parts
 You can export any functionality, as long as it is implemented as a public class or a public member of a class (property or method). You do not have to derive your component part from <xref:System.ComponentModel.Composition.Primitives.ComposablePart>. Instead, you must add a <xref:System.ComponentModel.Composition.ExportAttribute> attribute to the class or class member that you want to export. This attribute specifies the *contract* by which another component part can import your functionality.

## The export contract
 The <xref:System.ComponentModel.Composition.ExportAttribute> defines the entity (class, interface, or structure) that is being exported. Typically, the export attribute takes a parameter that specifies the type of the export.

```
[Export(typeof(ContentTypeDefinition))]
class TestContentTypeDefinition : ContentTypeDefinition {   }
```

 By default, the <xref:System.ComponentModel.Composition.ExportAttribute> attribute defines a contract that is the type of the exporting class.

```
[Export]
[Name("Structure")]
[Order(After = "Selection", Before = "Text")]
class TestAdornmentLayerDefinition : AdornmentLayerDefinition {   }
```

 In the example, the default `[Export]` attribute is equivalent to `[Export(typeof(TestAdornmentLayerDefinition))]`.

 You can also export a property or method, as shown in the following example.

```
[Export]
[Name("Scarlet")]
[Order(After = "Selection", Before = "Text")]
public AdornmentLayerDefinition scarletLayerDefinition;
```

## Import a MEF Export
 When you want to consume a MEF export, you must know the contract (typically the type) by which it was exported, and add a <xref:System.ComponentModel.Composition.ImportAttribute> attribute that has that value. By default, the import attribute takes one parameter, which is the type of the class that it modifies. The following lines of code import the <xref:Microsoft.VisualStudio.Text.Classification.IClassificationTypeRegistryService> type.

```
[Import]
internal IClassificationTypeRegistryService ClassificationRegistry;
```
## Troubleshooting Import/Export Issues: Access the MEF Composition Error Log
You may experience issues if you try to import something that doesn't exist in the current VS install, or if you incorrectly author your import or export.  The primary way to find and address these issues is to reference the **Managed Extensibility Framework (MEF) Composition Error Log**, stored at *%localappdata%\Microsoft\VisualStudio[yourVSVersion]\ComponentModelCache\Microsoft.VisualStudio.Default.err*.

## Get editor functionality from a MEF component part
 If your existing code is a MEF component part, you can use MEF metadata to consume editor component parts.

#### To consume editor functionality from a MEF component part

1. Add references to *System.Composition.ComponentModel.dll*, which is in the global assembly cache (GAC), and to the editor assemblies.

2. Add the relevant using directives.

    ```
    using System.ComponentModel.Composition;
    using Microsoft.VisualStudio.Text;
    ```

3. Add the `[Import]` attribute to your service interface, as follows.

    ```
    [Import]
    ITextBufferFactoryService textBufferService;
    ```

4. When you have obtained the service, you can consume any one of its components.

5. When you have compiled your assembly, put it in the *..\Common7\IDE\Components\* folder of your Visual Studio installation.

## Related content
- [Language service and editor extension points](../extensibility/language-service-and-editor-extension-points.md)
