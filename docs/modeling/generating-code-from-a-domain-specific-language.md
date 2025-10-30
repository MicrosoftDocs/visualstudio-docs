---
title: Generating Code from a Domain-Specific Language
description: Learn how Domain-Specific Language Tools provides a powerful way to generate code, documents, and other artifacts from data represented in models.
ms.date: 11/04/2016
ms.topic: concept-article
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Generating Code from a Domain-Specific Language

Microsoft Domain-Specific Language Tools provides a powerful way to generate code, documents, configuration files, and other artifacts from data represented in models. Using Domain-Specific Language Tools, you can create a set of classes that represent your data, and you can write your text templates in classes whose names and properties reflect that data.

For example, Fabrikam has an XML file of customer names and e-mail addresses. Their developers create a model in which Customer is a class, with properties name and e-mail. They write several text templates to process the data, including this fragment which produces a table of all the customers as part of an HTML page:

```
<table>
<# foreach (Customer c in ContactList) {  #>
  <tr><td> <#= c.FullName #> </td>
      <td> <#= c.EmailAddress #> </td> </tr>
<# } #>  </table>
```

When the customer database is processed, the XML file is read into the model store. A *directive processor*, created by using Domain-Specific Language Tools, makes the Customer class available to the code in the text template. Many text templates can be run against the same store.

Text templates are essential to Domain-Specific Language Tools. They are used to generate the source code for the elements of the domain model as well as for the VSPackage and the controls that are used to integrate the tools with Visual Studio.

This section discusses some of the ways to create, modify, and debug text templates used in Domain-Specific Language Tools.

## In This Section

[Accessing Models from Text Templates](../modeling/accessing-models-from-text-templates.md)\
Provides basic information about referring to domain-specific language in text templates.

[Walkthrough: Debugging a Text Template that Accesses a Model](../modeling/walkthrough-debugging-a-text-template-that-accesses-a-model.md)\
Describes how to do troubleshooting and debugging on a text template that refers to a domain-specific language.

[Walkthrough: Connecting a Host to a Generated Directive Processor](../modeling/walkthrough-connecting-a-host-to-a-generated-directive-processor.md)\
Describes how to connect a custom host to a generated directive processor.

[The DslTextTransform Command](../modeling/the-dsltexttransform-command.md)\
Describes the command file that executes the TextTransform executable on the command line for text templates that reference domain-specific languages.

## Reference

[Writing a T4 Text Template](../modeling/writing-a-t4-text-template.md)\
Provides the syntax of text template directives and control blocks.

## Related content

- [Design-Time Code Generation by using T4 Text Templates](../modeling/design-time-code-generation-by-using-t4-text-templates.md)\
Explains the text template transformation process.
- [Code Generation in a Build Process](../modeling/code-generation-in-a-build-process.md)\
Read this topic if you are generating files from a DSL on a build server.
