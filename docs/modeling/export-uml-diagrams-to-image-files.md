---
title: "Export UML diagrams to image files | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: b29ce2a5-0ee3-4ab7-9aa3-13ca9c6b37a2
caps.latest.revision: 8
author: "alexhomer1"
ms.author: "ahomer"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Export UML diagrams to image files
You can export a UML document from [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] to an image that is under program control. For example, you might want to do this as part of automatic document generation.  
  
 If you want to export a document to an image manually, you can copy and paste the shapes from a diagram into other programs such as Word. You can also print documents to XPS format. For more information, see [Export diagrams as images](../modeling/export-diagrams-as-images.md).  
  
## Saving an Image  
 The following code defines a shortcut menu command, also known as a context menu command, that saves an image to a file.  
  
> [!NOTE]
>  To make this code work as a menu command, you must incorporate it into a MEF component. For more information, see [Define a menu command on a modeling diagram](../modeling/define-a-menu-command-on-a-modeling-diagram.md).  
  
 The code first uses <xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation.IShape.GetObject%2A> to get the <xref:Microsoft.VisualStudio.Modeling.Diagrams.Diagram> of the underlying implementation. This type has a method <xref:Microsoft.VisualStudio.Modeling.Diagrams.Diagram.CreateBitmap%2A>.  
  
```  
namespace SaveToImage  
{  
  using System.ComponentModel.Composition; // for [Import], [Export]  
  using System.Drawing; // for Bitmap  
  using System.Drawing.Imaging; // for ImageFormat  
  using System.Linq; // for collection extensions  
  using System.Windows.Forms; // for SaveFileDialog  
  using Microsoft.VisualStudio.Modeling.Diagrams;  
    // for Diagram  
  using Microsoft.VisualStudio.Modeling.ExtensionEnablement;  
    // for IGestureExtension, ICommandExtension, ILinkedUndoContext  
  using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation;  
    // for IDiagramContext  
  using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml;  
    // for designer extension attributes  
  
  /// <summary>  
  /// Called when the user clicks the menu item.  
  /// </summary>  
  // Context menu command applicable to any UML diagram   
  [Export(typeof(ICommandExtension))]  
  [ClassDesignerExtension]  
  [UseCaseDesignerExtension]  
  [SequenceDesignerExtension]  
  [ComponentDesignerExtension]  
  [ActivityDesignerExtension]  
  class CommandExtension : ICommandExtension  
  {  
    [Import]  
    IDiagramContext Context { get; set; }  
  
    public void Execute(IMenuCommand command)  
    {  
      // Get the diagram of the underlying implementation.  
      Diagram dslDiagram = Context.CurrentDiagram.GetObject<Diagram>();  
      if (dslDiagram != null)  
      {  
        string imageFileName = FileNameFromUser();  
        if (!string.IsNullOrEmpty(imageFileName))  
        {  
          Bitmap bitmap = dslDiagram.CreateBitmap(  
           dslDiagram.NestedChildShapes,  
           Diagram.CreateBitmapPreference.FavorClarityOverSmallSize);  
          bitmap.Save(imageFileName, GetImageType(imageFileName));  
        }  
      }  
    }  
  
    /// <summary>  
    /// Called when the user right-clicks the diagram.  
    /// Set Enabled and Visible to specify the menu item status.  
    /// </summary>  
    /// <param name="command"></param>  
    public void QueryStatus(IMenuCommand command)  
    {  
      command.Enabled = Context.CurrentDiagram != null   
        && Context.CurrentDiagram.ChildShapes.Count() > 0;  
    }  
  
    /// <summary>  
    /// Menu text.  
    /// </summary>  
    public string Text  
    {  
      get { return "Save To Image..."; }  
    }  
  
    /// <summary>  
    /// Ask the user for the path of an image file.  
    /// </summary>  
    /// <returns>image file path, or null</returns>  
    private string FileNameFromUser()  
    {  
      SaveFileDialog dialog = new SaveFileDialog();  
      dialog.AddExtension = true;  
      dialog.DefaultExt = "image.bmp";  
      dialog.Filter = "Bitmap ( *.bmp )|*.bmp|JPEG File ( *.jpg )|*.jpg|Enhanced Metafile (*.emf )|*.emf|Portable Network Graphic ( *.png )|*.png";  
      dialog.FilterIndex = 1;  
      dialog.Title = "Save Diagram to Image";  
      return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : null;  
    }  
  
    /// <summary>  
    /// Return the appropriate image type for a file extension.  
    /// </summary>  
    /// <param name="fileName"></param>  
    /// <returns></returns>  
    private ImageFormat GetImageType(string fileName)  
    {  
      string extension = System.IO.Path.GetExtension(fileName).ToLowerInvariant();  
      ImageFormat result = ImageFormat.Bmp;  
      switch (extension)  
      {  
        case ".jpg":  
          result = ImageFormat.Jpeg;  
          break;  
        case ".emf":  
          result = ImageFormat.Emf;  
          break;  
        case ".png":  
          result = ImageFormat.Png;  
          break;  
      }  
      return result;  
    }  
  }  
}  
```  
  
## See Also  
 [Export diagrams as images](../modeling/export-diagrams-as-images.md)   
 [Define a menu command on a modeling diagram](../modeling/define-a-menu-command-on-a-modeling-diagram.md)