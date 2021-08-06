---
title: Add tracking property to DSL definition
description: Learn about the tracking domain property and how you can to add a tracking property to a domain model.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
  - "tracking properties [Domain-Specific Language Tools], walkthrough"
  - "Domain-Specific Language Tools, walkthroughs"
  - "walkthroughs [Domain-Specific Language Tools]"
author: mgoertz-msft
ms.author: mgoertz
manager: jmartens
ms.technology: vs-ide-modeling
ms.workload:
  - "multiple"
---
# Add a Tracking Property to a Domain-Specific Language Definition

This walkthrough shows how to add a tracking property to a domain model.

A *tracking domain* property is a property that can be updated by the user but which has a default value that is calculated by using the values of other domain properties or elements.

For example, in the Domain-Specific Language Tools (DSL Tools), the Display Name property of a domain class has a default value that is calculated by using the name of the domain class, but a user can change the value at design time or reset it to the calculated value.

In this walkthrough, you create a domain-specific language (DSL) that has a Namespace tracking property that has a default value based on the Default Namespace property of the model. For more information about tracking properties, see [Defining Tracking Properties](/previous-versions/cc825929(v=vs.100)).

- The DSL Tools support tracking property descriptors. However, the DSL designer cannot be used to add a tracking property to a language. Therefore, you must add custom code to define and implement the tracking property.

  A tracking property has two states: tracking, and updated by the user. Tracking properties have the following features:

- When in the tracking state, the value of the tracking property is calculated, and the value is updated as other properties in the model change.

- When in the updated by user state, the value of the tracking property retains the value to which the user last set the property.

- In the **Properties** window, the **Reset** command for the tracking property is only enabled when the property is in the updated by user state. The **Reset** command sets the tracking property state to tracking.

- In the **Properties** window, when the tracking property is in the tracking state, its value is displayed in a regular font.

- In the **Properties** window, when the tracking property is in the updated by user state, its value is displayed in a bold font.

## Prerequisites

Before you can start this walkthrough, you must first install these components:

| Component | Link |
|-|-|
| Visual Studio | [http://go.microsoft.com/fwlink/?LinkID=185579](https://visualstudio.microsoft.com/) |
| [!INCLUDE[vssdk_current_short](../modeling/includes/vssdk_current_short_md.md)] | [http://go.microsoft.com/fwlink/?LinkID=185580](/azure/devops/integrate/index?view=azure-devops&viewFallbackFrom=vsts&preserve-view=true) |
| [!INCLUDE[dsl](../modeling/includes/dsl_md.md)] | [http://go.microsoft.com/fwlink/?LinkID=185581](https://code.msdn.microsoft.com/site/search?query=%22Modeling%20SDK%22&f%5B0%5D.Value=%22Modeling%20SDK%22&f%5B0%5D.Type=SearchText&ac=5) |

## Create the project

1. Create a Domain-Specific Language Designer project. Name it `TrackingPropertyDSL`.

2. In the **Domain-Specific Language Designer Wizard**, set the following options:

    1. Select the **MinimalLanguage** template.

    2. Use the default name for the domain-specific language, `TrackingPropertyDSL`.

    3. Set the extension for model files to `trackingPropertyDsl`.

    4. Use the default template icon for the model files.

    5. Set the name of the product to `Product Name`.

    6. Set the name of the company to `Company Name`.

    7. Use the default value for the root namespace for projects in the solution, `CompanyName.ProductName.TrackingPropertyDSL`.

    8. Allow the wizard to create a strong name key file for your assemblies.

    9. Review the details of the solution, and then click **Finish** to create the DSL definition project.

## Customize the Default DSL Definition
 In this section, you customize the DSL definition to contain the following items:

- A Namespace tracking property for every element of the model.

- A Boolean IsNamespaceTracking property for every element of the model. This property will indicate whether the tracking property is in the tracking state or in the updated by user state.

- A Default Namespace property for the model. This property will be used to calculate the default value of the Namespace tracking property.

- A CustomElements calculated property for the model. This property will indicate the proportion of elements that have a custom namespace.

### To add the domain properties

1. In the DSL designer, right-click the **ExampleModel** domain class, point to **Add**, and then click **DomainProperty**.

    1. Name the new property `DefaultNamespace`.

    2. In the **Properties** window for the new property, set **Default Value** to `DefaultNamespace`, and set **Type** to **String**.

2. To the **ExampleModel** domain class, add a domain property named `CustomElements`.

     In the **Properties** window for the new property, set **Kind** to **Calculated**.

3. To the **ExampleElement** domain class, add a domain property named `Namespace`.

     In the **Properties** window for the new property, set **Is Browsable** to **False**, and set **Kind** to **CustomStorage**.

4. To the **ExampleElement** domain class, add a domain property named `IsNamespaceTracking`.

     In the **Properties** window for the new property, set **Is Browsable** to **False**, set **Default Value** to `true`, and set **Type** to **Boolean**.

### To update the diagram elements and DSL details

1. In the DSL designer, right-click the **ExampleShape** geometry shape, point to **Add**, and then click **Text Decorator**.

    1. Name the new text decorator `NamespaceDecorator`.

    2. In the **Properties** window for the text decorator, set **Position** to **InnerBottomLeft**.

2. In the DSL designer, select the line that connects the **ExampleElement** class to the **ExampleShape** shape.

    1. In the **DSL Details** window, select the **Decorator Maps** tab.

    2. In the **Decorators** list, select **NamespaceDecorator**, select its check box and then on the **Display property** list, select **Namespace**.

3. In **DSL Explorer**, expand the **Domain Classes** folder, right-click the **ExampleElement** node, and then click **Add New Domain Type Descriptor**.

    1. Expand the **ExampleElement** node, and select the **Custom Type Descriptor (Domain Type Descriptor)** node.

    2. In the **Properties** window for the domain type descriptor, set **Custom Coded** to **True**.

4. In **DSL Explorer**, select the **Xml Serialization Behavior** node.

    1. In the **Properties** window, set **Custom Post Load** to **True**.

## Transform Templates

Now that you have defined the domain classes and properties for your DSL, you can verify that the DSL definition can be transformed correctly to regenerate the code for your project.

1. On the **Solution Explorer** toolbar, click **Transform All Templates**.

2. The system regenerates the code for the solution, and saves DslDefinition.dsl. For information about the XML format of definition files, see [The DslDefinition.dsl File](../modeling/the-dsldefinition-dsl-file.md).

## Create Files for Custom Code

When you transform all templates, the system generates the source code that defines your domain-specific language in the Dsl and DslPackage projects. So that you can avoid interfering with the generated text, write your custom code in files that are distinct from the generated code files.

You must provide code for maintaining the value and the state of your tracking property. To help you distinguish your custom code from the generated code, and to avoid file naming conflicts, put your custom code files in a separate subfolder.

1. In **Solution Explorer**, right-click the **DSL** project, point to **Add**, and then click **New Folder**. Name the new folder `CustomCode`.

2. Right-click the new **CustomCode** folder, point to **Add**, and then click **New Item**.

3. Select the **Code File** template, set the **Name** to `NamespaceTrackingProperty.cs`, and then click **OK**.

     The NamespaceTrackingProperty.cs file is created and opened for editing.

4. In the folder, create the following code files: `ExampleModel.cs,``HelperClasses.cs`, `Serialization.cs`, and `TypeDescriptor.cs`.

5. In the **DslPackage** project, also create a `CustomCode` folder, and add to it a `Package.cs` code file.

## Add Helper Classes to Support Tracking Properties

To the HelperClasses.cs file, add the `TrackingHelper` and `CriticalException` classes as follows. You will reference these classes later in this walkthrough.

1. Add the following code to the HelperClasses.cs file.

    ```csharp
    using System;
    using System.Collections;
    using System.Diagnostics;
    using Microsoft.VisualStudio.Modeling;

    namespace CompanyName.ProductName.TrackingPropertyDSL
    {
        internal static class TrackingHelper
        {
            /// <summary>Notify each model element in a collection that a tracked
            /// property has changed.</summary>
            /// <param name="store">The store for the model.</param>
            /// <param name="collection">The collection of model elements that
            /// contain the tracking property.</param>
            /// <param name="propertyId">The ID of the tracking property.</param>
            /// <param name="trackingPropertyId">The ID of the property that
            /// indicates whether the tracking property is tracking.</param>
            internal static void UpdateTrackingCollectionProperty(
                Store store,
                IEnumerable collection,
                Guid propertyId,
                Guid trackingPropertyId)
            {
                DomainPropertyInfo propInfo =
                    store.DomainDataDirectory.GetDomainProperty(propertyId);

                DomainPropertyInfo trackingPropInfo =
                    store.DomainDataDirectory.GetDomainProperty(trackingPropertyId);

                Debug.Assert(propInfo != null);
                Debug.Assert(trackingPropInfo != null);
                Debug.Assert(trackingPropInfo.PropertyType.Equals(typeof(bool)),
                    "Tracking property not specified as a boolean");

                foreach (ModelElement element in collection)
                {
                    // If the tracking property is currently tracking, then notify
                    // it that the tracked property has changed.
                    bool isTracking = (bool)trackingPropInfo.GetValue(element);
                    if (isTracking)
                    {
                        propInfo.NotifyValueChange(element);
                    }
                }
            }
        }

        /// <summary>Helper class to flag critical exceptions from ones that are
        /// safe to ignore.</summary>
        internal static class CriticalException
        {
            /// <summary>Gets whether an exception is critical and can not be
            /// ignored.</summary>
            /// <param name="ex">The exception to check.</param>
            /// <returns>True if the exception is critical.</returns>
            internal static bool IsCriticalException(Exception ex)
            {
                if (ex is NullReferenceException
                    || ex is StackOverflowException
                    || ex is OutOfMemoryException
                    || ex is System.Threading.ThreadAbortException)
                    return true;

                if (ex.InnerException != null)
                    return IsCriticalException(ex.InnerException);

                return false;
            }
        }
    }
    ```

## Add Custom Code for the Custom Type Descriptor

Implement the `GetCustomProperties` method for the type descriptor for the `ExampleModel` domain class.

> [!NOTE]
> The code that the DSL Tools generate for the custom type descriptor for `ExampleModel` calls `GetCustomProperties`; however, the DSL Tools do not generate code that implements the method.

Defining this method creates the tracking property descriptor for the Namespace tracking property. Also, providing attributes for the tracking property enables the **Properties** window to display the property correctly.

### To modify the type descriptor for the ExampleModel domain class

1. Add the following code to the TypeDescriptor.cs file.

    ```csharp
    using System;
    using System.ComponentModel;
    using Microsoft.VisualStudio.Modeling;
    using Microsoft.VisualStudio.Modeling.Design;

    namespace CompanyName.ProductName.TrackingPropertyDSL
    {
        // To the custom type descriptor for the ExampleElement domain class, add
        // the GetCustomProperties method.
        public partial class ExampleElementTypeDescriptor
        {
            /// <summary>Returns the property descriptors for the described
            /// ExampleElement domain class.</summary>
            /// <remarks>This method adds the tracking property descriptor.
            /// </remarks>
            private PropertyDescriptorCollection GetCustomProperties(
                Attribute[] attributes)
            {
                // Get the default property descriptors from the base class
                PropertyDescriptorCollection propertyDescriptors =
                    base.GetProperties(attributes);

                // Get a reference to the model element that is being described.
                ExampleElement source = this.ModelElement as ExampleElement;

                //Add the descriptor for the tracking property.
                if (source != null)
                {
                    DomainPropertyInfo domainProperty =
                        source.Store.DomainDataDirectory.GetDomainProperty(
                            ExampleElement.NamespaceDomainPropertyId);

                    DomainPropertyInfo trackingProperty =
                        source.Store.DomainDataDirectory.GetDomainProperty(
                            ExampleElement.IsNamespaceTrackingDomainPropertyId);

                    // Define attributes for the tracking property so that the
                    // Properties window displays the property correctly.
                    Attribute[] attr = new Attribute[] {
                        new DisplayNameAttribute("Element Namespace"),
                        new DescriptionAttribute("The namespace of the element."),
                        new CategoryAttribute("Tracking Properties"),
                    };

                    propertyDescriptors.Add(new TrackingPropertyDescriptor(
                        source, domainProperty, trackingProperty, attr));
                }

                // Return the property descriptors for this element
                return propertyDescriptors;
            }
        }
    }
    ```

## Adding Custom Code for the Package

The generated code defines a type description provider for the ExampleElement domain class; however, you must add code to instruct the DSL to use this type description provider.

1. Add the following code to the Package.cs file.

    ```csharp
    using System.ComponentModel;

    namespace CompanyName.ProductName.TrackingPropertyDSL
    {
        // Override the default Initialize method.
        internal sealed partial class TrackingPropertyDSLPackage
        {
            protected override void Initialize()
            {
                // Add the custom type descriptor for the ExampleElement type.
                TypeDescriptor.AddProvider(
                    new ExampleElementTypeDescriptionProvider(),
                    typeof(ExampleElement));

                base.Initialize();
            }
        }
    }
    ```

## Add Custom Code for the Model

Implement the `GetCustomElementsValue` method for the `ExampleModel` domain class.

> [!NOTE]
> The code that the DSL Tools generate for `ExampleModel` calls `GetCustomElementsValue`; however, the DSL Tools do not generate code that implements the method.

Defining the `GetCustomElementsValue` method provides the logic for the CustomElements calculated property of `ExampleModel`. This method counts the number of `ExampleElement` domain classes that have a Namespace tracking property that has a user-updated value, and returns a string that represents this count as a proportion of the total elements in the model.

In addition, add an `OnDefaultNamespaceChanged` method to `ExampleModel`, and override the `OnValueChanged` method of the `DefaultNamespacePropertyHandler` nested class of `ExampleModel` to call `OnDefaultNamespaceChanged`.

Because the DefaultNamespace property is used to calculate the Namespace tracking property, `ExampleModel` must notify all `ExampleElement` domain classes that the value of DefaultNamespace has changed.

### To modify the property handler for the tracked property

1. Add the following code to the ExampleModel.cs file.

    ```csharp
    using System.Linq;

    namespace CompanyName.ProductName.TrackingPropertyDSL
    {
        public partial class ExampleModel
        {
            public string GetCustomElementsValue()
            {
                if (this.Elements.Count == 0) return "0/0";

                int number = this.Elements.Count(e => !e.IsNamespaceTracking);
                return string.Format("{0}/{1}", number, this.Elements.Count);
            }

            #region Value changed handler for the tracked property

            // When a tracked property changes, it needs to notify all of the properties
            // that track it.

            /// <summary>Called by the DefaultNamespace property value handler when the
            /// DefaultNamespace property changes.</summary>
            /// <param name="oldValue">The previous value of the property.</param>
            /// <param name="newValue">The new value of the property.</param>
            protected virtual void OnDefaultNamespaceChanged(
                string oldValue, string newValue)
            {
                // Use the helper class to notify all of the elements in the model
                // that the default namespace has changed.
                TrackingHelper.UpdateTrackingCollectionProperty(
                    this.Store,
                    this.Elements,
                    ExampleElement.NamespaceDomainPropertyId,
                    ExampleElement.IsNamespaceTrackingDomainPropertyId);
            }

            // Update the change handler for the DefaultNamespace property.
            internal sealed partial class DefaultNamespacePropertyHandler
            {
                /// <summary>Called when the DefaultNamespace property changes.</summary>
                /// <param name="element">The model element that has the property that
                /// changed.</param>
                /// <param name="oldValue">The previous value of the property.</param>
                /// <param name="newValue">The new value of the property.</param>
                protected override void OnValueChanged(
                    ExampleModel element, string oldValue, string newValue)
                {
                    base.OnValueChanged(element, oldValue, newValue);

                    if (!element.Store.InUndoRedoOrRollback)
                    {
                        element.OnDefaultNamespaceChanged(oldValue, newValue);
                    }
                }
            }

            #endregion
        }
    }
    ```

## Add Custom Code for the Tracking Property

Add a `CalculateNamespace` method to the `ExampleElement` domain class.

Defining this method provides the logic for the CustomElements calculated property of `ExampleModel`. This method counts the number of `ExampleElement` domain classes that have a Namespace tracking property that is in the updated by user state, and returns a string that represents this count as a proportion of the total elements in the model.

Also, add storage for, and methods to get and set, the Namespace custom storage property of the `ExampleElement` domain class.

> [!NOTE]
> The code that the DSL Tools generate for `ExampleModel` calls the get and set methods; however, the DSL Tools do not generate code that implements the methods.

### To add the method for the custom type descriptor

1. Add the following code to the NamespaceTrackingProperty.cs file.

    ```csharp
    using System;
    using Microsoft.VisualStudio.Modeling;

    namespace CompanyName.ProductName.TrackingPropertyDSL
    {
        // To the domain class that has the tracking property, add the caluclation
        // for when the property is tracking.
        public partial class ExampleElement
        {
            /// <summary>Calculates the actual value of the property when it is
            /// tracking.</summary>
            /// <returns>The value of the tracking property when it is
            /// tracking.</returns>
            /// <remarks>Making this method virtual allows child classes to modify
            /// the calculation. This method does not need to perform validation, as
            /// its caller handles validation prior to calling this method.
            /// <para>In this case, the tracking value depends on the default namespace
            /// property of the parent model.</para></remarks>
            protected virtual string CalculateNamespace()
            {
                return this.ExampleModel.DefaultNamespace;
            }

            #region Tracking property implementation

            // Implement the Namespace domain property of the ExampleElement domain class,
            // and update the IsNamespaceTracking domain property value handler.

            /// <summary>Storage for the Namespace property.</summary>
            private string namespaceStorage;

            /// <summary>Gets the value of the Namespace property.</summary>
            /// <returns>The value of the Namespace property.</returns>
            private string GetNamespaceValue()
            {
                // Only retrieve the tracked value if the store is not in the
                // middle of a serialization transaction.
                bool loading = this.Store.TransactionManager.InTransaction
                    && this.Store.TransactionManager.CurrentTransaction.IsSerializing;

                if (!loading && this.IsNamespaceTracking)
                {
                    try
                    {
                        return this.CalculateNamespace();
                    }
                    catch (NullReferenceException)
                    {
                        return default(string);
                    }
                    catch (Exception e)
                    {
                        if (CriticalException.IsCriticalException(e))
                        {
                            throw;
                        }
                        else
                        {
                            return default(string);
                        }
                    }
                }

                return namespaceStorage;
            }

            /// <summary>Sets the value of the Namespace property.</summary>
            /// <param name="value">The new value for the property.</param>
            private void SetNamespaceValue(string value)
            {
                namespaceStorage = value;

                // Only update the state of the tracking property if the store is
                // not in the middle of a serialization transaction.
                bool loading = this.Store.TransactionManager.InTransaction
                    && this.Store.TransactionManager.CurrentTransaction.IsSerializing;

                if (!this.Store.InUndoRedoOrRollback && !loading)
                {
                    this.IsNamespaceTracking = false;
                }
            }

            // Update the default behavior of the ExampleElement.IsNamespaceTracking
            // domain property value handler.
            internal sealed partial class IsNamespaceTrackingPropertyHandler
            {
                /// <summary>Called after the IsNamespaceTracking property changes.
                /// </summary>
                /// <param name="element">The model element that has the property
                /// that changed.</param>
                /// <param name="oldValue">The previous value of the property.
                /// </param>
                /// <param name="newValue">The new value of the property.</param>
                protected override void OnValueChanged(
                    ExampleElement element, Boolean oldValue, Boolean newValue)
                {
                    base.OnValueChanged(element, oldValue, newValue);
                    if (!element.Store.InUndoRedoOrRollback && newValue)
                    {
                        DomainPropertyInfo propInfo =
                            element.Store.DomainDataDirectory.GetDomainProperty(
                                ExampleElement.NamespaceDomainPropertyId);
                        propInfo.NotifyValueChange(element);
                    }
                }

                /// <summary>Performs the reset operation for the IsNamespaceTracking
                /// property for a model element.</summary>
                /// <param name="element">The model element that has the property
                /// to reset.</param>
                internal void ResetValue(ExampleElement element)
                {
                    object calculatedValue = null;

                    try
                    {
                        calculatedValue = element.CalculateNamespace();
                    }
                    catch (NullReferenceException)
                    {
                    }
                    catch (System.Exception e)
                    {
                        if (CriticalException.IsCriticalException(e))
                        {
                            throw;
                        }
                    }

                    if ((calculatedValue != null
                        && object.Equals(element.Namespace, calculatedValue)))
                    {
                        element.isNamespaceTrackingPropertyStorage = true;
                    }
                }

                /// <summary>Method to set IsNamespaceTracking to false so that this
                /// instance of this tracking property is not storage-based.
                /// </summary>
                /// <param name="element">The element on which to reset the property
                /// value.</param>
                internal void PreResetValue(ExampleElement element)
                {
                    // Force the IsNamespaceTracking property to false so that the value
                    // of the Namespace property is retrieved from storage.
                    element.isNamespaceTrackingPropertyStorage = false;
                }
            }

            #endregion
        }
    }
    ```

## Add Custom Code to Support Serialization

Add code to support the custom post-load behavior for XML serialization.

> [!NOTE]
> The code that the DSL Tools generate calls the `OnPostLoadModel` and `OnPostLoadModelAndDiagram` methods; however, the DSL Tools do not generate code that implements these methods.

### To add code to support the custom post-load behavior

1. Add the following code to the Serialization.cs file.

    ```csharp
    using System;
    using System.Diagnostics;
    using Microsoft.VisualStudio.Modeling;

    namespace CompanyName.ProductName.TrackingPropertyDSL
    {
        #region Helper classes for maintaining state while the store is serializing.

        public abstract partial class TrackingPropertyDSLSerializationHelperBase
        {
            /// <summary>Reset the tracking state properties to their natural values
            /// based on comparing storage with calculation.</summary>
            /// <param name="store">The store that contains this model.</param>
            internal static void ResetTrackingProperties(Store store)
            {
                // Two passes required - one to set all elements to storage-based
                // then another to set some back to being tracking.
                foreach (ModelElement element in store.ElementDirectory.AllElements)
                {
                    ExampleElement myElementInstance = element as ExampleElement;
                    if (myElementInstance != null)
                    {
                        myElementInstance.PreResetIsTrackingProperties();
                        continue;
                    }
                }
                foreach (ModelElement element in store.ElementDirectory.AllElements)
                {
                    ExampleElement myElementInstance = element as ExampleElement;
                    if (myElementInstance != null)
                    {
                        myElementInstance.ResetIsTrackingProperties();
                        continue;
                    }
                }
            }
        }

        // Add the pre-reset and reset methods for the model element.
        public partial class ExampleElement
        {
            /// <summary>Calls the pre-reset method on the associated property value
            /// handler for each tracking property of this model element.</summary>
            internal virtual void PreResetIsTrackingProperties()
            {
                ExampleElement.IsNamespaceTrackingPropertyHandler.Instance.PreResetValue(this);
            }

            /// <summary>Calls the reset method on the associated property value
            /// handler for each tracking property of this model element.</summary>
            internal virtual void ResetIsTrackingProperties()
            {
                ExampleElement.IsNamespaceTrackingPropertyHandler.Instance.ResetValue(this);
            }
        }

        #endregion

        #region Custom serialization code

        // To the serialization helper for the TrackingPropertyDSL class, add post
        // load handlers to bind the tracking property to the serialization process.
        // These handlers manage the tracking states and property values when the
        // model is serialized and deserialized.
        public partial class TrackingPropertyDSLSerializationHelperBase
        {
            /// <summary>Customize model loading.</summary>
            /// <param name="serializationResult">The serialization result from the
            /// load operation.</param>
            /// <param name="partition">The partition in which the new
            /// instance was created.</param>
            /// <param name="fileName">The name of the file from which the
            /// instance was deserialized.</param>
            /// <param name="modelRoot">The root of the file that was loaded.
            /// </param>
            private void OnPostLoadModel(
                SerializationResult serializationResult,
                Partition partition,
                string fileName,
                ExampleModel modelRoot)
            {
            }

            /// <summary>Customize model and diagram loading.</summary>
            /// <param name="serializationResult">Stores serialization result from
            /// the load operation.</param>
            /// <param name="modelPartition">Partition in which the new
            /// instance will be created.</param>
            /// <param name="modelFileName">Name of the file from which the
            /// instance will be deserialized.</param>
            /// <param name="diagramPartition">Partition in which the new
            /// diagram instance will be created.</param>
            /// <param name="diagramFileName">Name of the file from which the
            /// diagram instance will be deserialized.</param>
            /// <param name="modelRoot">The root of the file that was loaded.</param>
            /// <param name="diagram">The diagram matching the modelRoot.</param>
            private void OnPostLoadModelAndDiagram(
                SerializationResult serializationResult,
                Partition modelPartition,
                string modelFileName,
                Partition diagramPartition,
                string diagramFileName,
                ExampleModel modelRoot,
                TrackingPropertyDSLDiagram diagram)
            {
                Debug.Assert(modelPartition != null);
                Debug.Assert(modelPartition.Store != null);

                // Tracking properties need to be set up according to whether the
                // serialization matches the calculated values.
                TrackingPropertyDSLSerializationHelperBase.ResetTrackingProperties(
                    modelPartition.Store);
            }
        }

        #endregion
    }
    ```

## Test the Language

The next step is to build and run the DSL designer in a new instance of [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)] so that you can verify that the tracking property is working correctly.

1. On the **Build** menu, click **Rebuild Solution**.

2. On the **Debug** menu, click **Start Debugging**.

    The experimental build of [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)] opens the **Debugging** solution, which contains an empty test file.

3. In **Solution Explorer**, double-click the Test.trackingPropertyDsl file to open it in the designer, and then click the design surface.

    Notice that in the **Properties** window for the diagram, the **Default Namespace** property is **DefaultNamespace**, and the **Custom Elements** property is **0/0**.

4. Drag an **ExampleElement** element from the **Toolbox** to the diagram surface.

5. In the **Properties** window for the element, select the **Element Namespace** property, and change the value from **DefaultNamespace** to **OtherNamespace**.

    Notice that the value of **Element Namespace** is now shown in bold.

6. In the **Properties** window, right-click **Element Namespace**, and then click **Reset**.

    The value of the property is changed to **DefaultNamespace**, and the value is shown in a regular font.

    Right-click **Element Namespace** again. The **Reset** command is now disabled because the property is currently in its tracking state.

7. Drag another **ExampleElement** from the **Toolbox** to the diagram surface, and change its **Element Namespace** to **OtherNamespace**.

8. Click the design surface.

    In the **Properties** window for the diagram, the value of **Custom Elements** is now **1/2**.

9. Change **Default Namespace** for the diagram from **DefaultNamespace** to **NewNamespace**.

     The **Namespace** of the first element tracks the **Default Namespace** property, whereas the **Namespace** of the second element retains its user-updated value of **OtherNamespace**.

10. Save the solution, and then close the experimental build.

## Next steps

If you plan to use more than one tracking property, or implement tracking properties in more than one DSL, you can create a text template to generate the common code for supporting each tracking property. For more information about text templates, see [Code Generation and T4 Text Templates](../modeling/code-generation-and-t4-text-templates.md).

## See also

- <xref:Microsoft.VisualStudio.Modeling.Design.TrackingPropertyDescriptor>
- <xref:Microsoft.VisualStudio.Modeling.Design.ElementTypeDescriptor>
- [How to Define a Domain-Specific Language](../modeling/how-to-define-a-domain-specific-language.md)
- [How to: Create a Domain-Specific Language Solution](../modeling/how-to-create-a-domain-specific-language-solution.md)