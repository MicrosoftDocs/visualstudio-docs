---
title: "Managed Extensibility Framework in the Editor | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], new - using MEF for extensions"
ms.assetid: 3f59a285-6c33-4ae3-a4fb-ec1f5aa21bd1
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# Managed Extensibility Framework in the Editor
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The editor is built by using Managed Extensibility Framework (MEF) components. You can build your own MEF components to extend the editor, and your code can consume editor components as well.  
  
## Overview of the Managed Extensibility Framework  
 The MEF is a .NET library that lets you add and modify features of an application or component that follows the MEF programming model. The Visual Studio editor can both provide and consume MEF component parts.  
  
 The MEF is contained in the .NET Framework version 4 System.ComponentModel.Composition.dll assembly.  
  
 For more information about MEF, see [Managed Extensibility Framework (MEF)](https://msdn.microsoft.com/library/6c61b4ec-c6df-4651-80f1-4854f8b14dde).  
  
### Component Parts and Composition Containers  
 A component part is a class or a member of a class that can do one (or both) of the following:  
  
- Consume another component  
  
- Be consumed by another component  
  
  For example, consider a shopping application that has an order entry component that depends on product availability data provided by a warehouse inventory component. In MEF terms, the inventory part can *export* product availability data, and the order entry part can *import* the data. The order entry part and the inventory part do not have to know about each other; the *composition container* (provided by the host application) is responsible for maintaining the set of exports, and resolving the exports and imports.  
  
  The composition container, <xref:System.ComponentModel.Composition.Hosting.CompositionContainer>, is typically owned by the host. The composition container maintains a *catalog* of exported component parts.  
  
### Exporting and Importing Component Parts  
 You can export any functionality, as long as it is implemented as a public class or a public member of a class (property or method). You do not have to derive your component part from <xref:System.ComponentModel.Composition.Primitives.ComposablePart>. Instead, you must add a <xref:System.ComponentModel.Composition.ExportAttribute> attribute to the class or class member that you want to export. This attribute specifies the *contract* by which another component part can import your functionality.  
  
### The Export Contract  
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
  
### Importing a MEF Export  
 When you want to consume a MEF export, you must know the contract (typically the type) by which it was exported, and add a <xref:System.ComponentModel.Composition.ImportAttribute> attribute that has that value. By default, the import attribute takes one parameter, which is the type of the class that it modifies. The following lines of code import the <xref:Microsoft.VisualStudio.Text.Classification.IClassificationTypeRegistryService> type.  
  
```  
[Import]  
internal IClassificationTypeRegistryService ClassificationRegistry;  
```  
  
## Getting Editor Functionality from a MEF Component Part  
 If your existing code is a MEF component part, you can use MEF metadata to consume editor component parts.  
  
#### To consume editor functionality from a MEF component part  
  
1. Add references to System.Composition.ComponentModel.dll, which is in the global assembly cache (GAC), and to the editor assemblies.  
  
2. Add the relevant using statements.  
  
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
  
5. When you have compiled your assembly, put it in the ..\Common7\IDE\Components\ folder of your Visual Studio installation.  
  
## See Also  
 [Language Service and Editor Extension Points](../extensibility/language-service-and-editor-extension-points.md)
