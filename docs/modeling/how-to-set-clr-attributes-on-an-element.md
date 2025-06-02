---
title: "Set CLR attributes on an element by using DSL Explorer"
description: Learn how to add any attribute that inherits from System.Attribute. Custom attributes can be added to domain elements, shapes, connectors, and diagrams.
ms.date: 06/24/2022
ms.topic: how-to
f1_keywords:
  - "vs.dsltools.EditAttributesDialog"
helpviewer_keywords:
  - "Domain-Specific Language, custom attributes"
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---

# Set CLR attributes on an element

Custom attributes are special attributes that can be added to domain elements, shapes, connectors, and diagrams. You can add any attribute that inherits from the `System.Attribute` class.

## Add a custom attribute

1. In the **DSL Explorer**, select the element to which you want to add a custom attribute.

2. In the **Properties** window, next to the **Custom Attributes** property, select the Browse (**...**) icon.

   The **Edit Attributes** dialog box opens.

3. In the **Name** column, select **\<add attribute>** and type the name of your attribute. Press **ENTER**.

4. The line under the attribute name shows parentheses. On this line type a parameter type for the attribute, for example, `string`. Press **ENTER**.

5. In the **Name Property** column, type an appropriate name, for example, `MyString`.

6. Select **OK**.

   The **Custom Attributes** property now displays the attribute in the following format:

   `[` *AttributeName* `(` *ParameterName* `=` *Type* `)]`

## Related content

- [Domain-Specific Language Tools Glossary](/previous-versions/bb126564(v=vs.100))
