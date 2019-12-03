---
title: "Define a work item link handler | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "UML API"
ms.assetid: d52e0bbf-0166-4bb4-a2e3-cefed6188875
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: jillfra
---
# Define a work item link handler
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can create a Visual Studio Integration Extension that responds when the user creates or deletes a link between a UML model element and a work item. For example, when the user chooses to link a new work item to a model element, your code could initialize the fields of the work item from values in the model.

## Set up a UML Extension Solution
 This will allow you to develop handlers and then distribute them to other users. You need to set up two Visual Studio projects:

- A class library project containing the code of the link handler.

- A VSIX project, which acts as a container for installing the command. If you want, you can include other components in the same VSIX.

#### To set up the Visual Studio solution

1. Create a class library project, either adding it to an existing VSIX solution, or creating a new solution.

    1. On the **File** menu, choose **New**, **Project**.

    2. Under **Installed Templates**, expand **Visual C#** or **Visual Basic**, then in the middle column click **Class Library**.

    3. Set **Solution** to indicate whether you want to create a new solution or to add a component to a VSIX solution that you have already opened.

    4. Set the project Name and Location and click OK.

2. Unless your solution already contains one, create a VSIX project.

    1. In **Solution Explorer**, on the shortcut menu of the solution, choose **Add**, **New Project**.

    2. Under **Installed Templates**, expand **Visual C#** or **Visual Basic**, then select **Extensibility**. In the middle column, choose **VSIX Project**.

3. Set the VSIX project as the startup project of the solution.

    - In Solution Explorer, on the shortcut menu of the VSIX project choose **Set as StartUp project**.

4. In **source.extension.vsixmanifest**, under **Content**, add the class library project as a MEF Component.

    1. On the **MetaData** tab, set a name for the VSIX.

    2. On the **Install Targets** tab, set the Visual Studio versions as the targets.

    3. On the **Assets** tab, choose a **New**, and in the dialog box, set:

         **Type** = **MEF Component**

         **Source** = **A project in current solution**

         **Project** = *Your class library project*

## Defining the Work Item Link Handler
 Perform all of the following tasks in the class library project.

### Project References
 Add the following [!INCLUDE[TLA2#tla_net](../includes/tla2sharptla-net-md.md)] assemblies to your project references:

 `Microsoft.TeamFoundation.WorkItemTracking.Client.dll`

 `Microsoft.VisualStudio.TeamFoundation.WorkItemTracking.dll Microsoft.VisualStudio.Modeling.Sdk.[version]`

 `Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml`

 `Microsoft.VisualStudio.Uml.Interfaces`

 `System.ComponentModel.Composition`

 `System.Drawing` - used by the sample code

 If you cannot find one of these references under the **.Net** tab of the **Add Reference** dialog, use the Browse tab to find it in \Program Files\Microsoft Visual Studio [version]\Common7\IDE\PrivateAssemblies\\.

### Import the Work Item Namespace
 In your [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] project **References**, add references to the following assemblies:

- Microsoft.TeamFoundation.WorkItemTracking.Client.dll

- Microsoft.VisualStudio.TeamFoundation.WorkItemTracking.dll

  In your program code, import the following namespaces:

```
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Uml.Classes;
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml;
using Microsoft.VisualStudio.TeamFoundation.WorkItemTracking;
using System.Linq;
```

### Define the Linked Work Item Event Handler
 Add a class file to the class library project, and set its contents as follows. Change the namespace and class names to whatever you prefer.

```
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Uml.Classes;
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml;
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation;
using Microsoft.VisualStudio.TeamFoundation.WorkItemTracking;
using System.Linq;

namespace WorkItems
{
  [Export(typeof(ILinkedWorkItemExtension))]
  public class MyWorkItemExtension : ILinkedWorkItemExtension
  {
    // Called before a new work item is edited by the user.
    // Use this to initialize work item fields from the model element.
    public void OnWorkItemCreated(System.Collections.Generic.IEnumerable<IElement> elementsToBeLinked, IWorkItemDocument workItemDocument)
    {
      INamedElement namedElement =
            elementsToBeLinked.First() as INamedElement;
      if (namedElement != null)
        workItemDocument.Item.Title = namedElement.Name;

    }

    // Called when any work item is linked to a model element.
    public void OnWorkItemLinked(System.Collections.Generic.IEnumerable<IElement> elements, string serverUri, int workItemId)
    {
      foreach (IElement element in elements)
        foreach (IShape shape in element.Shapes())
          shape.Color = System.Drawing.Color.Red;
    }

    // Called when a work item is unlinked from a model element.
    public void OnWorkItemRemoved(IElement element, string serverUri, int workItemId)
    {
      foreach (IShape shape in element.Shapes())
        shape.Color = System.Drawing.Color.White;
    }
  }
}
```

## Testing the Link Handler
 For test purposes, execute your link handler in debug mode.

> [!WARNING]
> You must already be connected to TFS Source Code Control (SCC) to create or link to a work item. If you try to open a connection to a different TFS SCC, Visual Studio closes the current solution automatically. Ensure that you are already connected to the appropriate SCC before attempting to create or link to a work item. In later releases of Visual Studio, the menu commands are not available if you are not connected to an SCC.

#### To test the link handler

1. Press **F5**, or on the **Debug** menu, choose **Start Debugging**.

     An experimental instance of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] starts.

     **Troubleshooting**: If a new [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] does not start, ensure that the VSIX project is set as the Startup project of the solution.

2. In the experimental [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], open or create a modeling project, and open or create a modeling diagram.

3. Create a model element such as UML class, and set its name.

4. Right-click the element and then click **Create Work Item**.

    - If the submenu shows **Open Team Foundation Server Connection**, you will need to close the project, connect to the appropriate TFS, and restart this procedure.

    - If the submenu shows a list of work item types, click one.

         A new work item form opens.

5. Verify that the title of the work item is the same as the model element, if you have used the sample code in the previous section. This demonstrates `OnWorkItemCreated()` has worked.

6. Complete the form, save and close the work item.

7. Verify that the work item is now colored red. This demonstrates `OnWorkItemLinked()` in the sample code.

     **Troubleshooting**: If the handler methods have not run, verify that:

    - The class library project is listed as a MEF component in the **Content** list in **source.extensions.manifest** in the VSIX project.

    - The correct `Export` attribute is attached to the handler class, and the class implements `ILinkedWorkItemExtension`.

    - The parameters of all `Import` and `Export` attributes are valid.

## About the Work Item Handler Code

### Listening for New Work Items
 `OnWorkItemCreated` is called when the user chooses to create a new work item to be linked to the model elements. Your code can initialize the work item fields. The work item is then presented to the user, who can update the fields and the save the work item. The link to a model element is not created until the work item has been successfully saved.

```
public void OnWorkItemCreated(
    IEnumerable<IElement> elementsToBeLinked,
    IWorkItemDocument workItem)
{
  INamedElement namedElement =
         elementsToBeLinked.First() as INamedElement;
  if (namedElement != null)
      workItem.Item.Title = namedElement.Name;
}
```

### Listening for Link Creation
 `OnWorkItemLinked` is called just after a link is created. It is called whether the link is to a new work item or an existing item. It is called once for each work item.

```
public void OnWorkItemLinked
        (IEnumerable<IElement> elements,
         string serverUri, // TFS server
         int workItemId)
{
  foreach (IElement element in elements)
    foreach (IShape shape in element.Shapes())
         shape.Color = System.Drawing.Color.Red;
}
```

> [!NOTE]
> To make this example work, you must add a project reference to `System.Drawing.dll`, and import the namespace `Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation`. However, these additions are not required for other implementations of `OnWorkItemLinked`.

### Listening for Link Removal
 `OnWorkItemRemoved` is called once just before each work item link that is deleted. If a model element is deleted, all of its links will be removed.

```
public void OnWorkItemRemoved
         (IElement element, string serverUri, int workItemId)
{...}
```

## Updating a work item
 Using the Team Foundation namespaces, you can manipulate a work item.

 To use the following example, add these .NET assemblies to your project's References:

- Microsoft.TeamFoundation.Client.dll

- Microsoft.TeamFoundation.WorkItemTracking.Client.dll

```

using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
...
public void OnWorkItemLinked
        (IEnumerable<IElement> elements,
         string serverUri, // TFS server
         int workItemId)
{
  TfsTeamProjectCollection tfs =
        TfsTeamProjectCollectionFactory
            .GetTeamProjectCollection(new Uri(serverUri));
  WorkItemStore workItemStore = new WorkItemStore(tfs);
  WorkItem item = workItemStore.GetWorkItem(workItemId);
  item.Open();
  item.Title = "something";
  item.Save();
} 
```

## Accessing the Work Item Reference Links
 You can access the links as follows:

```
//Get:
string linkString = element.GetReference(ReferenceConstants.WorkItem);
// Set:
element.AddReference(ReferenceConstants.WorkItem, linkString, true);

```

 The format of `linkString` is:

 `string.Format(@"%{0}\{1}#{1}${2}", tfServer, projectCollection, RepositoryGuid, workItem.Id);`

 where:

- The URI for your server would be:

   `http://tfServer:8080/tfs/projectCollection`

   Case is important in `projectCollection`.

- `RepositoryGuid` can be obtained from your TFS connection:

  ```csharp
  TfsTeamProjectCollection tpc = TfsTeamProjectCollectionFactory...;
  RepositoryGuid= tpc.InstanceId;

  ```

  For more information about References, see [Attach reference strings to UML model elements](../modeling/attach-reference-strings-to-uml-model-elements.md).

## See also

- [Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemStore](/previous-versions/visualstudio/visual-studio-2013/bb179850(v=vs.120))
- [Link model elements and work items](../modeling/link-model-elements-and-work-items.md)
- [Attach reference strings to UML model elements](../modeling/attach-reference-strings-to-uml-model-elements.md)
- [Define and install a modeling extension](../modeling/define-and-install-a-modeling-extension.md)
- [Programming with the UML API](../modeling/programming-with-the-uml-api.md)
