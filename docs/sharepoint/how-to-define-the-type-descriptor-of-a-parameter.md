---
title: "How to: Define the Type Descriptor of a Parameter | Microsoft Docs"
description: Learn how to define the type descriptor of a parameter for a method in your business data connectivity (BDC) model.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Business Data Connectivity service [SharePoint development in Visual Studio], type descriptor"
  - "BDC [SharePoint development in Visual Studio], parameter types"
  - "BDC [SharePoint development in Visual Studio], type descriptor"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], parameter types"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# How to: Define the type descriptor of a parameter
  A type descriptor contains properties that describe the data type of a parameter. A type descriptor can define a field, an entity, or a collection of entities. For more information, see [TypeDescriptor](/previous-versions/office/developer/sharepoint-2007/ms543392\(v\=office.12\)).

### To define the type descriptor of a parameter

1. In the **BDC Method Details** window, choose the type descriptor of the parameter.

2. On the menu bar, choose **View**, **Properties Window**.

3. In the **Properties** window, set the properties of the type descriptor.

     The following procedures describe how to define a type descriptor as a field, entity, or entity collection.

### To define a field

1. In the **Properties** window, set the **Name** property of the type descriptor to the name of a field in the type that represents the entity (For example: **FirstName**).

2. In the list next to the **TypeName** property, choose the appropriate data type (for example, **Int32**).

     For information about other optional parameters, see [TypeDescriptor](/previous-versions/office/developer/sharepoint-2007/ms543392\(v\=office.12\)).

### To define an entity

1. In the **Properties** window, set the **Name** property to a name that describes the entity (For example: **Contact**).

2. Set the **TypeName** property to the fully qualified name of the type that represents the entity. This type can be a class in your project, a type defined in an assembly that you reference in your solution, or a type defined in the BDC object model.

    - For a class in your project, choose the down arrow next to the **TypeName** property, choose the **Current Project** tab in the dialog box that appears, and then choose the class in your project.

         The fully qualified name includes the namespace and name of the class followed by the name of the LOB system. The following example sets the value of the **TypeName** property to a class in your project.

         `MyBDCNamespace.BdcModel1.Contact, BdcModel1`

    - For a type located in an assembly in your solution, the fully qualified name includes the name of the type, the name of the assembly, the version number, the culture, and the public key token.

         The following example sets the value of the **TypeName** property to a type defined in an assembly that you reference in your solution.

         `MyNamespace.Contact, myAssemblyName, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089`

    - For a type defined in the BDC object model, the fully qualified name includes the namespace and name of the type.

         The following example sets the value of the **TypeName** property to a type in the BDC object model.

         `Microsoft.BusinessData.Runtime.DynamicType`

3. In the **BDC Method Details** window, open the list that appears for the type descriptor, and then choose **Edit**.

     The **BDC Explorer** window opens.

4. In the **BDC Explorer**, open the shortcut menu of the type descriptor, and then choose **Add Type Descriptor**.

     A new type descriptor is added as a child to the entity type descriptor. Configure this type descriptor as a field.

5. Repeat step 4 to add a child type descriptor for each field of the entity.

### To define a collection of entities

1. In the **BDC Method Details** window, choose the type descriptor of the parameter that you want.

2. On the menu bar, choose **View**, **Properties Window**.

3. In the **Properties** window, set the **Name** property to a name that describes the entity (For example: **Contacts**).

4. Set the **IsCollection** property to **True**. This indicates that this type descriptor is a collection of entities.

5. Set the **TypeName** property to a string that contains a reference to the <xref:System.Collections.Generic.IEnumerable%601> interface, and the fully qualified name of the type that represents the entity. This type can be a class in your project, a type defined in an assembly that you reference in your solution, or a type defined in the BDC object model.

   - For a class in your project, choose the down arrow next to the **TypeName** property, choose the **Current Project** tab in the dialog box that appears, and then choose the class in your project.

      The fully qualified name includes the namespace and name of the class followed by the name of the LOB system.

      The following example sets the value of the **TypeName** property to a collection of classes in your project.

      `System.Collections.Generic.IEnumerable`1 [MyBDCNamespace.BdcModel1.Contact, BdcModel1]`

   - For a type located in an assembly in your solution, the fully qualified name includes the name of the type, the name of the assembly, the version number, the culture, and the public key token.

      The following example sets the value of the **TypeName** property to a collection of types in an assembly that you reference in your solution.

      `System.Collections.Generic.IEnumerable`1 [MyNamespace.Contact, myAssemblyName, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]`

   - For a type defined in the BDC object model, the fully qualified name includes only the namespace and name of the type.

      The following example sets the value of the **TypeName** property to a collection of types defined in the BDC object model.

      `System.Collections.Generic.IEnumerable`1 [Microsoft.BusinessData.Runtime.DynamicType]`

6. In the **BDC Method Details** window, open the list that appears for the type descriptor, and then choose **Edit**.

    The **BDC Explorer** window opens.

7. In the **BDC Explorer**, open the shortcut menu of the type descriptor, and then choose **Add Type Descriptor**.

    A new type descriptor is added as a child to the collection type descriptor. Configure this type descriptor as an entity.

## See also
- [BDC model design tools overview](../sharepoint/bdc-model-design-tools-overview.md)
- [How to: Add an entity to a model](../sharepoint/how-to-add-an-entity-to-a-model.md)
- [How to: Add a parameter to a method](../sharepoint/how-to-add-a-parameter-to-a-method.md)
- [How to: Define a method instance](../sharepoint/how-to-define-a-method-instance.md)
- [Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md)
