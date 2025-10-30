---
title: Generate and configure your app from models
description: Learn what a model represents and how you can generate or configure parts of your application from a model.
ms.date: 11/04/2016
ms.topic: article
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Generate and configure your app from models

You can generate or configure parts of your application from a model.

 The model represents the requirements more directly than the code. By deriving the application's behavior directly from the model, you can respond to changed requirements much more quickly and reliably than by updating the code. Although some initial work is required to set up the derivation, this investment is returned if you expect changes in requirements, or if you plan to make several variants of the product.

## Generating the Code of your Application from a Model
 The easiest way to generate code is by using text templates. You can generate code in the same Visual Studio solution in which you keep the model. For more information, see:

- [Design-Time Code Generation by using T4 Text Templates](../modeling/design-time-code-generation-by-using-t4-text-templates.md)

- [Generating Code from a Domain-Specific Language](../modeling/generating-code-from-a-domain-specific-language.md)

  This method is easy to apply incrementally. Start with an application that works only for a specific case, and choose a few parts of it that you want to vary from the model. Rename the source files of these parts so that they become text template (.tt) files. At this point, the source .cs files will automatically be generated from the template files, so the application will work as it did before.

  Then you can take one part of the code and replace it with a text template expression, which reads the model and generates that part of the source file. At least one value of the model should generate the original source so that again you can run the application and it will work as before. After you test different model values, you can move on to insert template expressions in another part of the code.

  This incremental method means that code generation is usually a low-risk approach. The resulting applications usually perform almost as well as a hand-written version.

  However, if you start with an existing application, you might find that a lot of refactoring is required to separate the different behaviors that are governed by the model so that they can be independently varied. We recommend that you assess this aspect of the application when you estimate the cost of your project.

## Configuring your Application from a Model
 If you want to vary your application's behavior at run time, you cannot use code generation, which generates source code before the application is compiled. Instead, you can design your application to read the model, and to vary its behavior accordingly. For more information, see:

- [How to: Open a Model from File in Program Code](../modeling/how-to-open-a-model-from-file-in-program-code.md)

  This method can also be applied incrementally, but there is more work at the beginning. You need to write the code that will read the model, and set up a framework that allows its values to be accessible to the variable parts. Making the variable parts generic is more expensive than code generation.

  A generic application usually performs less well than its specific counterparts. If performance is crucial, your project plan should include an assessment of this risk.

## Developing a Derived Application
 You might find the following general guidelines useful.

- **Start specific, then generalize.** Write a specific version of your application first. This version should work in one set of conditions. When you are satisfied that it is working correctly, you can make some of it derive from a model. Extend the derived parts gradually.

     For example, design a website that has a specific set of web pages before you design a web application that presents pages that are defined in a model.

- **Model the variant aspects.** Identify the aspects that will vary, either between one deployment and another, or over time as requirements change. These are the aspects that should be derived from a model.

     For example, if the set of web pages and links between them changes, but the style and format of the pages is always the same, then the model should describe the links, but does not have to describe the format of the pages.

- **Separate concerns.** If the variable aspects can be divided into independent areas, use separate models for each area. Using ModelBus, you can define operations that affect both models, and constraints between them.

     For example, use one model to define navigation between the web pages and a different model to define the layout of the pages.

- **Model the requirement, not the solution.** Design the model so that it describes the user requirements. By contrast, do not design the notation according to the variable aspects of the implementation.

     For example, the web navigation model should represent web pages and hyperlinks between them. The web navigation model should not represent fragments of HTML or classes in your application.

- **Generate or interpret?** If the requirements for a particular deployment will rarely change, generate program code from the model. If the requirements might frequently change, or might co-exist in more than one variant in the same deployment, write the application so that it can read and interpret a model.

     For example, if you use your website model to develop a series of different and separately-installed websites, then you should generate the code of the site from the model. But it you use your model to control a site that changes every day, then it is better to write a web server that reads the model and presents the site accordingly.

- **UML or DSL?** Consider creating your modeling notation by using stereotypes to extend UML. Define a DSL if there is no UML diagram that fits the purpose. But avoid breaking the standard semantics of UML.

     For example, a UML class diagram is a collection of boxes and arrows; with this notation you can in theory define anything. But we do not recommend that you use the class diagram except where you are in fact describing a set of types. For example, you could adapt class diagrams to describe different types of web pages.

## Related content

- [Generating Code from a Domain-Specific Language](../modeling/generating-code-from-a-domain-specific-language.md)
- [How to: Open a Model from File in Program Code](../modeling/how-to-open-a-model-from-file-in-program-code.md)
- [Design-Time Code Generation by using T4 Text Templates](../modeling/design-time-code-generation-by-using-t4-text-templates.md)
