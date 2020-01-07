---
title: "How to: Access and Constrain the Current Selection | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "Domain-Specific Language, accessing the current selection"
ms.assetid: 2990981e-dfae-416f-b0d0-7197f1242dfa
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Access and Constrain the Current Selection
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When you write a command or gesture handler for your domain-specific language, you can determine what element the user right-clicked. You can also prevent some shapes or fields from being selected. For example, you can arrange that when the user clicks an icon decorator, the shape that contains it is selected instead. Constraining the selection in this manner reduces the number of handlers that you have to write. It also makes it easier for the user, who can click anywhere in the shape without having to avoid the decorator.

## Accessing the Current Selection from a Command Handler
 The command set class for a domain-specific language contains the command handlers for your custom commands. The <xref:Microsoft.VisualStudio.Modeling.Shell.CommandSet> class, from which the command set class for a domain-specific language derives, provides a few members for accessing the current selection.

 Depending on the command, the command handler might need the selection in the model designer, the model explorer, or the active window.

#### To access selection information

1. The <xref:Microsoft.VisualStudio.Modeling.Shell.CommandSet> class defines the following members that can be used to access the current selection.

    |Member|Description|
    |------------|-----------------|
    |<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSetLibrary.IsAnyDocumentSelectionCompartment%2A> method|Returns `true` if any of the elements selected in the model designer is a compartment shape; otherwise, `false`.|
    |<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSetLibrary.IsDiagramSelected%2A> method|Returns `true` if the diagram is selected in the model designer; otherwise, `false`.|
    |<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSetLibrary.IsSingleDocumentSelection%2A> method|Returns `true` if exactly one element is selected in the model designer; otherwise, `false`.|
    |<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSetLibrary.IsSingleSelection%2A> method|Returns `true` if exactly one element is selected in the active window; otherwise, `false`.|
    |<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSetLibrary.CurrentDocumentSelection%2A> property|Gets a read-only collection of the elements selected in the model designer.|
    |<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSetLibrary.CurrentSelection%2A> property|Gets a read-only collection of the elements selected in the active window.|
    |<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSetLibrary.SingleDocumentSelection%2A> property|Gets the primary element of the selection in the model designer.|
    |<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSetLibrary.SingleSelection%2A> property|Gets the primary element of the selection in the active window.|

2. The <xref:Microsoft.VisualStudio.Modeling.Shell.CommandSet.CurrentDocView%2A> property of the <xref:Microsoft.VisualStudio.Modeling.Shell.CommandSet> class provides access to the <xref:Microsoft.VisualStudio.Modeling.Shell.DiagramDocView> object that represents the model designer window and provides additional access the selected elements in the model designer.

3. In addition, the generated code defines an explorer tool window property and an explorer selection property in the command set class for the domain-specific language.

    - The explorer tool window property returns an instance of the explorer tool window class for the domain-specific language. The explorer tool window class derives from the <xref:Microsoft.VisualStudio.Modeling.Shell.ModelExplorerToolWindow> class and represents the model explorer for the domain-specific language.

    - The `ExplorerSelection` property returns the selected element in the model explorer window for the domain-specific language.

## Determining which window is active
 The <xref:Microsoft.VisualStudio.Modeling.Shell.IMonitorSelectionService> interface contains defines members that provide access to the current selection state in the shell. You can get an <xref:Microsoft.VisualStudio.Modeling.Shell.IMonitorSelectionService> object from either the package class or the command set class for the domain-specific language through the `MonitorSelection` property defined in the base class of each. The package class derives from the <xref:Microsoft.VisualStudio.Modeling.Shell.ModelingPackage> class, and the command set class derives from the <xref:Microsoft.VisualStudio.Modeling.Shell.CommandSet> class.

#### To determine from a command handler what type of window is active

1. The <xref:Microsoft.VisualStudio.Modeling.Shell.CommandSetLibrary.MonitorSelection%2A> property of the <xref:Microsoft.VisualStudio.Modeling.Shell.CommandSet> class returns an <xref:Microsoft.VisualStudio.Modeling.Shell.IMonitorSelectionService> object that provides access to the current selection state in the shell.

2. The <xref:Microsoft.VisualStudio.Modeling.Shell.IMonitorSelectionService.CurrentSelectionContainer%2A> property of the <xref:Microsoft.VisualStudio.Modeling.Shell.IMonitorSelectionService> interface gets the active selection container, which can be different from the active window.

3. Add the following properties to the command set class for you domain-specific language to determine what type of window is active.

    ```csharp
    // using Microsoft.VisualStudio.Modeling.Shell;

    // Returns true if the model designer is the active selection container;
    // otherwise, false.
    protected bool IsDesignerActive
    {
        get
        {
            return (this.MonitorSelection.CurrentSelectionContainer
                is DiagramDocView);
        }
    }

    // Returns true if the model explorer is the active selection container;
    // otherwise, false.
    protected bool IsExplorerActive
    {
        get
        {
            return (this.MonitorSelection.CurrentSelectionContainer
                is ModelExplorerToolWindow);
        }
    }
    ```

## Constraining the Selection
 By adding selection rules, you can control which elements are selected when the user selects an element in the model. For example, to allow the user to treat a number of elements as a single unit, you can use a selection rule.

#### To create a selection rule

1. Create a custom code file in the DSL project

2. Define a selection rule class that is derived from the <xref:Microsoft.VisualStudio.Modeling.Diagrams.DiagramSelectionRules> class.

3. Override the <xref:Microsoft.VisualStudio.Modeling.Diagrams.DiagramSelectionRules.GetCompliantSelection%2A> method of the selection rule class to apply the selection criteria.

4. Add a partial class definition for the ClassDiagram class to your custom code file.

     The `ClassDiagram` class derives from the <xref:Microsoft.VisualStudio.Modeling.Diagrams.Diagram> class and is defined in the generated code file, Diagram.cs, in the DSL project.

5. Override the <xref:Microsoft.VisualStudio.Modeling.Diagrams.Diagram.SelectionRules%2A> property of the `ClassDiagram` class to return the custom selection rule.

     The default implementation of the <xref:Microsoft.VisualStudio.Modeling.Diagrams.Diagram.SelectionRules%2A> property gets a selection rule object that does not modify the selection.

### Example
 The following code file creates a selection rule that expands the selection to include all instances of each of the domain shapes that was initially selected.

```csharp
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Diagrams;

namespace CompanyName.ProductName.GroupingDsl
{
    public class CustomSelectionRules : DiagramSelectionRules
    {
        protected Diagram diagram;
        protected IElementDirectory elementDirectory;

        public CustomSelectionRules(Diagram diagram)
        {
            if (diagram == null) throw new ArgumentNullException();

            this.diagram = diagram;
            this.elementDirectory = diagram.Store.ElementDirectory;
        }

        /// <summary>Called by the design surface to allow selection filtering.
        /// </summary>
        /// <param name="currentSelection">[in] The current selection before any
        /// ShapeElements are added or removed.</param>
        /// <param name="proposedItemsToAdd">[in/out] The proposed DiagramItems to
        /// be added to the selection.</param>
        /// <param name="proposedItemsToRemove">[in/out] The proposed DiagramItems
        /// to be removed from the selection.</param>
        /// <param name="primaryItem">[in/out] The proposed DiagramItem to become
        /// the primary DiagramItem of the selection. A null value signifies that
        /// the last DiagramItem in the resultant selection should be assumed as
        /// the primary DiagramItem.</param>
        /// <returns>true if some or all of the selection was accepted; false if
        /// the entire selection proposal was rejected. If false, appropriate
        /// feedback will be given to the user to indicate that the selection was
        /// rejected.</returns>
        public override bool GetCompliantSelection(
            SelectedShapesCollection currentSelection,
            DiagramItemCollection proposedItemsToAdd,
            DiagramItemCollection proposedItemsToRemove,
            DiagramItem primaryItem)
        {
            if (currentSelection.Count == 0 && proposedItemsToAdd.Count == 0) return true;

            HashSet<DomainClassInfo> itemsToAdd = new HashSet<DomainClassInfo>();

            foreach (DiagramItem item in proposedItemsToAdd)
            {
                if (item.Shape != null)
                    itemsToAdd.Add(item.Shape.GetDomainClass());
            }
            proposedItemsToAdd.Clear();
            foreach (DomainClassInfo classInfo in itemsToAdd)
            {
                foreach (ModelElement element
                    in this.elementDirectory.FindElements(classInfo, false))
                {
                    if (element is ShapeElement)
                    {
                        proposedItemsToAdd.Add(
                            new DiagramItem((ShapeElement)element));
                    }
                }
            }

            return true;
        }
    }

    public partial class ClassDiagram
    {
        protected CustomSelectionRules customSelectionRules = null;

        protected bool multipleSelectionMode = true;

        public override DiagramSelectionRules SelectionRules
        {
            get
            {
                if (multipleSelectionMode)
                {
                    if (customSelectionRules == null)
                    {
                        customSelectionRules = new CustomSelectionRules(this);
                    }
                    return customSelectionRules;
                }
                else
                {
                    return base.SelectionRules;
                }
            }
        }
    }
}
```

## See Also
 <xref:Microsoft.VisualStudio.Modeling.Shell.CommandSet>
 <xref:Microsoft.VisualStudio.Modeling.Shell.ModelingPackage>
 <xref:Microsoft.VisualStudio.Modeling.Shell.DiagramDocView>
 <xref:Microsoft.VisualStudio.Modeling.Shell.ModelExplorerToolWindow>
 <xref:Microsoft.VisualStudio.Modeling.Shell.IMonitorSelectionService>
 <xref:Microsoft.VisualStudio.Modeling.Diagrams.DiagramSelectionRules>
 <xref:Microsoft.VisualStudio.Modeling.Diagrams.Diagram>
