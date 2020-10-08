---
title: "Link a use case to documents and diagrams | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
f1_keywords:
  - "vs.teamarch.usecasediagram.artifact.properties.artifactlink"
  - "vs.teamarch.usecasediagram.artifact"
helpviewer_keywords:
  - "use case diagrams"
ms.assetid: 4c9ed205-9197-4ed5-b39d-ddfa24a0a421
caps.latest.revision: 12
author: jillre
ms.author: jillfra
manager: jillfra
---
# Link a use case to documents and diagrams
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can link a use case in a use case diagram to another diagram or document. For example, you can link the use case to the following diagrams and documents:

- A sequence diagram that shows how the goals of the use case are realized by interactions between users and the system or its major components.

- An activity diagram that shows the detailed actions of the users and the system or its major components as they perform the use case.

- A OneNote page or paragraph that describes the use case in detail.

- A Word document or PowerPoint presentation that describes the use case in detail. You can keep such documents either in the solution, or in a location accessible to your team, such as a SharePoint site.

  To link a use case to a document, you create an artifact on the use case diagram and connect the use case to the artifact. In the artifact's properties, you set the file path of the other diagram or document. When you double-click the artifact, the other diagram or document opens.

  You can connect as many artifacts to each use case as you want. You can also link artifacts to other kinds of element on a use case diagram.

### To open a document associated with an artifact

- On the use case diagram, double-click the artifact shape.

     The associated document opens.

### To link a use case to a diagram or file in the same solution

1. Draw a diagram such as a sequence diagram or activity diagram to illustrate a scenario of the use case.

2. Go back to the use case diagram.

3. Drag the diagram or file from Solution Explorer onto a blank part of the use case diagram.

4. Connect from the artifact to the use case using a **Dependency**.

### To link to a solution file such as a Word document or PowerPoint presentation

1. Add the document to the solution.

    1. Move the Word document into the same Windows folder as the solution.

    2. In Solution Explorer, right-click the solution, point to **Add**, and then click **Existing Item**.

    3. Navigate to the Word document and click **Add**.

         The Word document appears in a solution folder in Solution Explorer.

2. Drag the Word document from Solution Explorer onto a blank part of the use case diagram.

     A new Artifact appears.

3. Connect from the artifact to the use case using a **Dependency**.

### To link to a shared document, OneNote element, or web page

1. Obtain the URL of the shared element. This can be, for example, a network file path beginning '\\\\', or a web page or Sharepoint URL beginning 'http://', or a link to a OneNote section, page, or paragraph beginning 'onenote:'.

2. In the Toolbox, click **Artifact** and then click in the use case diagram.

3. With the new artifact selected, type or paste the URL into the **Hyperlink** property.

    > [!NOTE]
    > If you want to provide a file path, it is best to choose a file either in a common workspace (starting with '\\\\'), or a file within your Visual Studio solution. This ensures that the file path will remain valid on another team member's computer, or if the solution is moved. To add a document such as a Word document to your solution, right-click the solution in Solution Explorer, point to **Add** and then click **Existing Item**.

## See Also
 [UML Use Case Diagrams: Reference](../modeling/uml-use-case-diagrams-reference.md)
 [UML Use Case Diagrams: Guidelines](../modeling/uml-use-case-diagrams-guidelines.md)
 [Edit UML models and diagrams](../modeling/edit-uml-models-and-diagrams.md)
 [Create models for your app](../modeling/create-models-for-your-app.md)
