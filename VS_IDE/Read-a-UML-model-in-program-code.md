---
title: "Read a UML model in program code"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 0f63105e-6079-498a-94f1-318c0f5f9621
caps.latest.revision: 23
manager: kamrani
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Read a UML model in program code
You can load a UML model and its diagrams using the UML API.  
  
##  <a name="Reading"></a> Reading a Model in Program Code  
 To access the content of a model without showing it in a Visual Studio window, use `ModelingProject.LoadReadOnly()`.  
  
 For example:  
  
```  
using Microsoft.VisualStudio.Uml.Classes;   
               // for IElement  
using Microsoft.VisualStudio.ArchitectureTools.Extensibility;   
               // for ModelingProject  
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml;  
               // for IModelStore  
...   
string projectPath = @"C:\MyProjectFolder\MyProject.modelproj";  
using (IModelingProjectReader projectReader =  
           ModelingProject.LoadReadOnly(projectPath))  
{  
   IModelStore store = projectReader.Store;  
   foreach (IClass umlClass in store.AllInstances<IClass>())  
   {   
       ...  
   }  
}  
```  
  
 If you want to read the shapes in a diagram, you must read the project and then the diagram.  
  
 For example:  
  
```  
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation;   
                             // for IDiagram  
...  
foreach (string diagramFile in projectReader. DiagramFileNames)  
{   
  IDiagram diagram = projectReader.LoadDiagram(diagramFile);  
  foreach (IShape<IElement> shape   
         in diagram.GetChildShapes<IElement>())  
  { ... }  
}  
```  
  
## Alternative methods  
 For many applications, Visual Studio Modelbus allows you to reference models and elements within them, with greater robustness and flexibility than with the methods described in this topic. It provides a standard method of making links between arbitrary elements, either in the same or different models. For more information, see [Integrate UML models with other models and tools](../VS_IDE/Integrate-UML-models-with-other-models-and-tools.md).  
  
 You can also open models and diagrams in the user interface using the Visual Studio API. For more information, see [Open a UML model by using the Visual Studio API](../VS_IDE/Open-a-UML-model-by-using-the-Visual-Studio-API.md).  
  
##  <a name="Standalone"></a> Stand-Alone Applications  
 The example in the previous section will work in Visual Studio extensions. It is possible to read a model in a stand-alone application, but you must add some references to your Visual Studio project.  
  
> [!NOTE]
>  The details of how to read a model in a stand-alone application are likely to change in future versions of the product. Some features that are accessible in the current version might not be available in future versions.  
  
#### To add references to read a model in a stand-alone application.  
  
1.  In Solution Explorer, right-click the project in which you are building the application, and then click **Properties**. In the properties editor, in the **Application** tab, set **Target Framework** to the required version of the .NET Framework.  
  
2.  Add the .NET references you need for accessing UML models, typically:  
  
    -   Microsoft.VisualStudio.Uml.Interfaces.dll  
  
    -   Microsoft.VisualStudio.ArchitectureTools.Extensibility.dll  
  
3.  In addition to the references listed in the previous sections, add the following project references from **\Program Files\Microsoft Visual Studio [version]\Common7\IDE\PrivateAssemblies**:  
  
    -   Microsoft.VisualStudio.Uml.dll  
  
    -   Microsoft.VisualStudio.TeamArchitect.ModelStore.Dsl.dll  
  
     If you want to read diagrams in your application, you might also require these references:  
  
    -   Microsoft.VisualStudio.TeamArchitect.ActivityDesigner.Dsl.dll  
  
    -   Microsoft.VisualStudio.TeamArchitect.ComponentDesigner.Dsl.dll  
  
    -   Microsoft.VisualStudio.TeamArchitect.LogicalClassDesigner.Dsl.dll  
  
    -   Microsoft.VisualStudio.TeamArchitect.SequenceDesigner.Dsl.dll  
  
    -   Microsoft.VisualStudio.TeamArchitect.UseCase.Dsl.dll  
  
## See Also  
 [Programming with the UML API](../VS_IDE/Programming-with-the-UML-API.md)   
 [Extend UML models and diagrams](../VS_IDE/Extend-UML-models-and-diagrams.md)