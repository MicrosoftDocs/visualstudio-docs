---
title: Web Project Essentials
description: Learn the internal details about how web projects work in Visual Studio.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- web projects, essentials
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Web Project Essentials

Web projects create Web applications. You can use a Web project to create a Web application that has smart Web pages. A smart Web page has server-side code that renders the Web page on demand.

 Using traditional programming languages, such as Visual Basic or Visual C#, you can create smart Web pages to collect and process information from a user, store it in a database, and so on.

- The code-behind model associates dependent source code files with Web pages that have the file extension .aspx or .asmx. For example, hello.aspx might have the dependent source code file hello.aspx.cs.

- The server-side code associated with a smart Web page is compiled into an executable file that is located in the Web site /bin folder.

- Additional source code files, such as helper classes that are not associated with a specific Web page, are located in the Web site /App_Code folder.

  - A Web site project (WSP) generates one executable file for each smart Web page. Additional executable files are generated from any source code files in the /App_Code folder.

  - A Web application project (WAP) produces a single executable file that combines the code for all smart Web pages, as well as all source files in the /App_Code folder.

- The solution file for a Web project is located separately from the Web site itself. By default, solution files are located at \Documents and Settings\\*YourAccount*\My Documents\\*\<Visual Studio ####>*\Projects\\*YourWebSite*.

  > [!NOTE]
  > If you want to keep the solution file with the Web site, just move it there and reopen it.

- If you open a Web site that has no solution file in Visual Studio, a new solution file is automatically generated for it.

- Web projects have no project files. Project information is stored in the solution file, the web.config file, and elsewhere.

- Adding global properties to a Web project automatically creates a storage file in the Web project solution folder.

- A smart Web page can be associated with a server-side programming language by using the Page directive or the \<script runat="server"> tag.

- In addition, Web pages can have any number of client-side scripting blocks written in any scripting language.

- A Web site project system is implemented by adding project and item templates and registration to the Visual Web Developer project.

- A WAP system is implemented as a project subtype, also called a project flavor. The Visual Web Developer project is flavored by the WAP subtype to create the WAP system. For more information on project subtypes, see [Project Subtypes](../../extensibility/internals/project-subtypes.md).

- A smart Web page combines HTML with a server-side programming language. The server-side language is called the contained language. To support a contained language, the Web project system must implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsContainedLanguage> family of interfaces.

  - To support the contained language in an editor, the HTML language service must defer displaying contained language code to a contained language service.

  - Error markers (red squigglies) should always be created in the code editor's primary buffer.

## Related content
- [Web Projects](../../extensibility/internals/web-projects.md)
