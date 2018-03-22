---
title: "Embedding a Diagram in a Windows Form | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.topic: "article"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: 
  - "multiple"
ms.technology: vs-ide-modeling
---
# Embedding a Diagram in a Windows Form
You can embed a DSL diagram in a Windows Control, which appears in the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] window.  
  
## Embedding a Diagram  
  
#### To embed a DSL diagram in a Windows Control  
  
1.  Add a new **User Control** file to the DslPackage project.  
  
2.  Add a Panel control to the User Control. This panel will contain the DSL Diagram.  
  
     Add other controls that you require.  
  
     Set the Anchor properties of the controls.  
  
3.  In Solution Explorer, right-click the user control file and click **View Code**. Add this constructor and variable to the code:  
  
    ```csharp  
  
    internal UserControl1(MyDSLDocView docView, Control content)  
      : this()  
    {  
      panel1.Controls.Add(content);  
      this.docView = docView;  
    }  
    private MyDSLDocView docView;  
  
    ```  
  
4.  Add a new file to the DslPackage project, with the following content:  
  
    ```  
    using System.Windows.Forms;  
    namespace Company.MyDSL  
    {  
      partial class MyDSLDocView  
      {  
        private UserControl1 container;  
        public override IWin32Window Window  
        {  
          get  
          {  
            if (container == null)  
            {  
              // Put our own form inside the DSL window:  
              container = new UserControl1(this,  
                (Control)base.Window);  
            }  
            return container;  
    } } } }  
  
    ```  
  
5.  To test the DSL, press F5 and open a sample model file. The diagram appears inside the control. The toolbox and other features work normally.  
  
#### Updating the Form using Store Events  
  
1.  In the form designer, add a **ListBox** named `listBox1`. This will display a list of the elements in the model. It will be kept in synchronism with the model using *store events*. For more information, see [Event Handlers Propagate Changes Outside the Model](../modeling/event-handlers-propagate-changes-outside-the-model.md).  
  
2.  In the custom code file, override further methods to the DocView class:  
  
    ```  
  
    partial class MyDSLDocView  
    {  
     /// <summary>  
     /// Register store event listeners.  
     /// This method is called when the model and diagram    
     /// have completed loading.   
     /// </summary>  
     protected override bool LoadView()  
      {  
        bool result = base.LoadView();  
        Store store = this.DocData.Store;  
        EventManagerDirectory emd = store.EventManagerDirectory;  
        DomainClassInfo componentClass = store.DomainDataDirectory.FindDomainClass(typeof(ExampleElement));  
        emd.ElementAdded.Add(componentClass, new EventHandler<ElementAddedEventArgs>(AddElement));  
        emd.ElementDeleted.Add(componentClass, new EventHandler<ElementDeletedEventArgs>(RemoveElement));  
  
        // Do the initial parts list:  
        container.SetUpFormFromModel();  
        return result;  
      }  
     /// <summary>  
     /// Listener method called on creation of each instance of   
     /// the ExampleElement class or its subclasses.  
     /// </summary>  
     private void AddElement(object sender, ElementAddedEventArgs e)  
     {  
       container.Add(e.ModelElement as ExampleElement);  
     }  
     /// <summary>  
     /// Listener method called after deletion of each instance of   
     /// the ExampleElement class or its subclasses.  
     /// </summary>  
     private void RemoveElement(object sender, ElementDeletedEventArgs e)  
     {  
       container.Remove(e.ModelElement as ExampleElement);  
     }  
  
    ```  
  
3.  In the code behind the user control, insert methods to listen for elements added and removed:  
  
    ```  
  
          public partial class UserControl1 : UserControl { ...  
  
    private ExampleModel modelRoot;  
  
    internal void Add(ExampleElement e) { UpdatePartsList(); }  
    internal void Remove(ExampleElement e) { UpdatePartsList(); }  
  
    internal void SetUpFormFromModel()  
    {  
      modelRoot = this.docView.CurrentDiagram.ModelElement as ExampleModel;  
      UpdatePartsList();  
    }  
  
    private void UpdatePartsList()  
    {  
      StringBuilder builder = new StringBuilder();  
      listBox1.Items.Clear();  
      foreach (ExampleElement c in modelRoot.Elements)  
      {  
        listBox1.Items.Add(c.Name);  
      }  
    }  
  
    ```  
  
4.  To test the DSL, press F5 and in the experimental instance of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], open a sample model file.  
  
     Notice that the list box shows a list of the elements in the model, and that it is correct after any addition or deletion, and after Undo and Redo.  
  
## See Also  
 [Navigating and Updating a Model in Program Code](../modeling/navigating-and-updating-a-model-in-program-code.md)   
 [Writing Code to Customise a Domain-Specific Language](../modeling/writing-code-to-customise-a-domain-specific-language.md)
