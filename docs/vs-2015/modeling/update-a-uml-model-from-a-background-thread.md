---
title: "Update a UML model from a background thread | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
ms.assetid: 42c06b0b-b681-4e19-b5f3-6116dd2a4072
caps.latest.revision: 15
author: jillre
ms.author: jillfra
manager: jillfra
---
# Update a UML model from a background thread
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

It can sometimes be useful to make changes to a model in a background thread. For example, if you are loading information from a slow external resource, you could use a background thread to supervise the updates. This allows the user to see each update as soon as it happens.

 However, you must be aware that the UML store is not thread safe. The following precautions are important:

- Every update to a model or diagram must be made in the user interface (UI) thread. The background thread must use <xref:System.Windows.Forms.Control.Invoke%2A> or `Dispatcher.`<xref:System.Windows.Threading.Dispatcher.Invoke%2A> to have the UI thread perform the actual updates.

- If you group a series of changes into a single transaction, we recommend that you prevent the user from editing the model while the transaction is in progress. Otherwise, any edits made by the user will become part of the same transaction. You can prevent the user from making changes by showing a modal dialog box. If you want, you can provide a Cancel button in the dialog box. The user can see the changes as they happen.

## Example
 This example uses a background thread to make several changes to a model. A dialog box is used to exclude the user while the thread is running. In this simple example, no Cancel button is provided in the dialog box. However, it would be easy to add that feature.

#### To run the example

1. Create a command handler in a C# project as described in [Define a menu command on a modeling diagram](../modeling/define-a-menu-command-on-a-modeling-diagram.md).

2. Make sure that the project includes references to these assemblies:

   - Microsoft.VisualStudio.ArchitectureTools.Extensibility

   - Microsoft.VisualStudio.Modeling.Sdk.[version]

   - Microsoft.VisualStudio.Modeling.Sdk.Diagrams.[version]

   - Microsoft.VisualStudio.Uml.Interfaces

   - System.ComponentModel.Composition

   - System.Windows.Forms

3. Add to the project a Windows form named **ProgressForm**. It should display a message that states that the updates are in progress. It does not have to have any other controls.

4. Add a C# file that contains the code that is shown after step 7.

5. Build and run the project.

    A new instance of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] will start in experimental mode.

6. Create or open a UML class diagram in the experimental instance of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].

7. Right-click anywhere in the UML class diagram and then click **Add Several UML Classes**.

   Several new class boxes will appear in the diagram, one after another at intervals of a half second.

```csharp
using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Threading;
using System.Windows.Forms;

using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation;
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml;
using Microsoft.VisualStudio.Modeling.ExtensionEnablement;
using Microsoft.VisualStudio.Uml.Classes;

namespace BackgroundThreadProgressUI // CHANGE TO YOUR NAMESPACE
{
  [Export(typeof(ICommandExtension))]
  [ClassDesignerExtension]
  class UmlClassAdderCommand : ICommandExtension
  {

    [Import]
    IDiagramContext context { get; set; }

    [Import]
    ILinkedUndoContext linkedUndoContext { get; set; }

    // Called when the user runs the command.
    public void Execute(IMenuCommand command)
    {
      // The form that will exclude the user.
      ProgressForm form = new ProgressForm();

      // System.ComponentModel.BackgroundWorker is a
      // convenient way to run a background thread.
      BackgroundWorker worker = new BackgroundWorker();
      worker.WorkerSupportsCancellation = true;

      worker.DoWork += delegate(object sender, DoWorkEventArgs args)
      {
        // This block will be executed in a background thread.

        IClassDiagram diagram = context.CurrentDiagram as IClassDiagram;
        IModelStore store = diagram.ModelStore;
        const int CLASSES_TO_CREATE = 15;

        // Group all the changes together.
        using (ILinkedUndoTransaction transaction = linkedUndoContext.BeginTransaction("Background Updates"))
        {
          for (int i = 1; i < CLASSES_TO_CREATE; i++)
          {
            if (worker.CancellationPending)
               return; // No commit - undo all.

            // Create model elements using the UI thread by using
            // the Invoke method on the progress form. Always
            // modify the model and diagrams from a UI thread.
            form.Invoke((MethodInvoker)(delegate
            {
              IClass newClass = store.Root.CreateClass();
              newClass.Name = string.Format("NewClass{0}", i);
              diagram.Display(newClass);
            }));

            // Sleep briefly so that we can watch the updates.
            Thread.Sleep(500);
          }

          // Commit the transaction or it will be rolled back.
          transaction.Commit();
        }
      };

      // Close the form when the thread completes.
      worker.RunWorkerCompleted += delegate(object sender, RunWorkerCompletedEventArgs args)
      {
        form.Close();
      };

      // Start the thread before showing the modal progress dialog.
      worker.RunWorkerAsync();

      // Show the form modally, parented on VS.
      // Prevents the user from making changes while in progress.
      form.ShowDialog();
    }

    public void QueryStatus(IMenuCommand command)
    {
      command.Enabled = command.Visible = true;
    }

    public string Text
    {
      get { return "Add several classes"; }
    }
  }
}
```

#### To allow the user to cancel the thread in the example

1. Add a cancel button to the progress dialog.

2. Add the following code to the progress dialog box:

     `public event MethodInvoker Cancel;`

     `private void CancelButton_Click(object sender, EventArgs e)`

     `{`

     `Cancel();`

     `}`

3. In the Execute() method, insert this line after the construction of the form:

     `form.Cancel += delegate() { worker.CancelAsync(); };`

### Other methods of accessing the UI thread
 If you do not want to create a dialog box, you can access the control that displays the diagram:

 `DiagramView uiThreadHolder = context.CurrentDiagram.GetObject<Diagram>().ActiveDiagramView;`

 You can use `uiThreadHolder.Invoke()` to perform operations in the UI thread.

## See Also
 [Define a menu command on a modeling diagram](../modeling/define-a-menu-command-on-a-modeling-diagram.md)
 [Define a gesture handler on a modeling diagram](../modeling/define-a-gesture-handler-on-a-modeling-diagram.md)
