---
title: "Setting a Background Image on a Diagram | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
ms.assetid: e334a24c-8521-4072-b50f-e59158dde145
caps.latest.revision: 4
author: jillre
ms.author: jillfra
manager: jillfra
---
# Setting a Background Image on a Diagram
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Visualization and Modeling SDK, you can set the background image for a generated designer by using custom code.

## Setting the background image

#### To set a background image for a generated designer

1. Copy the image file that you want to use as the diagram's background into the Dsl\Resources directory for the current project.

2. In **Solution Explorer**, right-click the Dsl\Resources folder, point to **Add**, and then click **Existing Item**.

3. In the **Add Existing Item** dialog box, browse to the Dsl\Resources folder.

4. In the **Files of type** list, click **Image Files**.

5. Click the image file that you copied to the directory, and then click **Add**.

6. Right-click Dsl, and click **Properties** to open the properties of the Dsl project.

7. On the **Resources** tab, click **This project does not contain a default resources file. Click here to create one.**

8. Add the image file to the resource file by dragging the picture from **Solution Explorer** into the resources window.

9. Open the File menu, and click the option to save the project properties.

10. Verify that the file Dsl\Properties\Resources.resx exists and has the file Resources.Designer.cs under it.

11. If Resources.Designer.cs is missing, click the file Resources.resx in **Solution Explorer**.

12. In the **Properties** window, set the `Custom Tool` property to `ResXFileCodeGenerator`.

13. In **Solution Explorer**, right-click the Dsl project, point to **Add**, and click **New Folder**.

14. Name the folder **Custom**.

15. Right-click the Custom folder, point to **Add**, and click **New Item**.

16. In the **Add New Item** dialog box, in the **Templates** list, click **Code File**.

17. In the **Name** box, type `BackgroundImage.cs`, and click **Add**.

18. Copy the following code to the BackgroundImage.cs file, adjusting namespace, diagram class name, and image file resource name.

     Replace "MyDiagramClass" with the name of the diagram partial class that is defined in Dsl\GeneratedCode\Diagrams.cs. You can also retrieve the correct namespace from the file Dsl\GeneratedCode\Diagrams.cs.

    ```
    using System;
    using Microsoft.VisualStudio.Modeling.Diagrams;

    // Fix the namespace:
    namespace Fabrikam.MyLanguage
    {
      // Fix the Diagram Class name - get it from GeneratedCode\Diagram.cs

      public partial class Language29Diagram
      {
        protected override void InitializeInstanceResources()
        {
          // Fix the Resources namespace and the Image resource name:
          ImageField backgroundField = new ImageField("background",
              Fabrikam.MyLanguage.Properties.Resources.MyPicture);

          backgroundField.DefaultFocusable = false;
          backgroundField.DefaultSelectable = false;
          backgroundField.DefaultVisibility = true;
          backgroundField.DefaultUnscaled = false;

          shapeFields.Add(backgroundField);

          backgroundField.AnchoringBehavior
            .SetTopAnchor(AnchoringBehavior.Edge.Top, 0.01);
          backgroundField.AnchoringBehavior
            .SetLeftAnchor(AnchoringBehavior.Edge.Left, 0.01);
          backgroundField.AnchoringBehavior
            .SetRightAnchor(AnchoringBehavior.Edge.Right, 0.01);
          backgroundField.AnchoringBehavior
            .SetBottomAnchor(AnchoringBehavior.Edge.Bottom, 0.01);

          base.InitializeInstanceResources();
        }
      }
    }
    ```

     For more information about customizing the model with program code, see [Navigating and Updating a Model in Program Code](../modeling/navigating-and-updating-a-model-in-program-code.md).

## See Also
 [Defining Shapes and Connectors](../modeling/defining-shapes-and-connectors.md)
 [Customizing Text and Image Fields](../modeling/customizing-text-and-image-fields.md)
 [Navigating and Updating a Model in Program Code](../modeling/navigating-and-updating-a-model-in-program-code.md)
 [Writing Code to Customise a Domain-Specific Language](../modeling/writing-code-to-customise-a-domain-specific-language.md)
