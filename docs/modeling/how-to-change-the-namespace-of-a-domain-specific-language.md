---
title: "How to: Change the namespace of a domain-specific language"
ms.date: 10/31/2018
ms.topic: how-to
helpviewer_keywords:
  - "Domain-Specific Language, namespace"
author: JoshuaPartlow
ms.author: joshuapa
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Change the namespace of a domain-specific language

You can change the namespace of a domain-specific language. Make the change in the **DSL Explorer**, in the properties of the Dsl Package project, and in the assembly information.

## To change the namespace of a domain-specific language

1. In **DSL Explorer**, select the **Dsl** node.

2. In the **Properties** window, change the **Namespace** property.

3. Save the solution and transform the templates.

4. On the **Project** menu, choose **Dsl Properties**.

   The properties for your project appear.

5. Select the **Application** tab.

6. Change the **Default namespace** property to the new namespace name.

7. If you also want to change the name of the assembly, change the **Assembly name property.**

8. If you have changed the Assembly name, open DslPackage\Package.tt and update this line:

   `string dslAssembly = "YourDSLassembly.Dsl.dll";`

9. If you have written any custom code, make sure to change the namespace and class references in the code files.

10. Reset the Visual Studio Experimental instance.

    1. Delete **\Users\\**_{your name}_**\AppData\Local\Microsoft\VisualStudio\\\*Exp**.

    2. On the Windows **Start** menu, choose **All Programs** > **Microsoft Visual Studio 2010 SDK** > **Tools** > **Reset the Experimental Instance**.

11. On the **Build** menu, choose **Rebuild Solution**.

## See also

[Domain-specific language tools glossary](https://msdn.microsoft.com/ca5e84cb-a315-465c-be24-76aa3df276aa)