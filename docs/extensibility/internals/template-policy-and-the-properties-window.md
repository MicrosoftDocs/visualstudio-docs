---
title: Template Policy and the Properties Window
description: Learn about using template policy to set default values for properties, hide properties, and add properties in the Properties window.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- Properties window, template policy
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Template Policy and the Properties Window

When a project is contained inside an enterprise template project, that enterprise template project can enforce policy. Template policy becomes a constraining system that can be used to set default values for properties, hide properties, add properties, and so on.

 Using template policy to control the display of information in the **Properties** window is different from implementing <xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing>. <xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing> handles object properties at the component level, while template policy can be used to constrain object properties at the solution or project level. In other words

- Implement the methods on <xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing> to determine what is displayed in the **Properties** window for specific objects

- Use template policy at the solution and project level to determine what is displayed in the **Properties** window for previously specified objects

  Using template policy to selectively constrain specific properties in the **Properties** window when a project item of a specified type is selected in **Solution Explorer** can be beneficial to all members of the development team working on a project. For example, using template policy, you can set up all the connection-string information in a database for your developers and make the connection string read-only. In that way, you can provide a simple way to assure that each developer uses the correct path for data access.

## Related content
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing>
- [Extending Properties](../../extensibility/internals/extending-properties.md)
