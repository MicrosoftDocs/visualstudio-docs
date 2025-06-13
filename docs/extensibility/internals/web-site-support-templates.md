---
title: Web Site Support Templates
description: Learn about web site support templates. Visual Studio web site project and item templates provide reusable and customizable web site project and item stubs.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- we site projects, templates
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Web Site Support Templates

Visual Studio Web site project and item templates provide reusable and customizable Web site project and item stubs that accelerate the development process by removing the need to create new Web site projects and items from scratch. For more information on Visual Studio templates, see [Creating Project and Item Templates](../../ide/creating-project-and-item-templates.md).

## Project Template Folder
 Web project templates are typically installed on [*Visual Studio Installation Path*]\Common7\IDE\ProjectTemplates\Web\\, each in a subfolder that is named after the web programming language.

## Project File
 The Visual Studio integrated development environment (IDE) requires a project file extension as a way to map a template to the correct project type. Because Web projects do not have a project file, the dummy project file extension .webproj is registered to map the template to the project type.

 Optionally, a language name string can be added to the template, to enable the Web project system to set the language default in the **Add New Item** dialog box for items based on the template. The string must be the first line of the file. It must match both the name registered under AddItemLanguageName in the IntelliSense engine registration, and the name registered under Project Subtype(VsTemplate). For more information, see [Web Site Support Attributes](../../extensibility/internals/web-site-support-attributes.md).

 If the string is not present, the Web project system attempts to determine the default language based on the Language attribute and file extensions of the pages added to the Web project by the Project Template.

## Project Templates
 Web site project templates are used to build new Web sites in response to the **New Web Site** command on the **File** menu. Three Web site project types are currently supported:

- Empty Web site projects

- Web site projects

- Web service projects

### Empty Web Site Projects
 These files create a new empty Web site in response to the **Empty Web Site** command, which is available after choosing **File** > **New Web Site**:

- EmptyWeb.vstemplate

     The template file that guides the creation of the new empty Web site.

- EmptyWeb.webproj

     This file is an artifact of the project template system. It satisfies the project file reference in the EmptyWeb.vstemplate file.

### Web Site Projects
 These files create a new Web site in response to the **ASP.NET Web Site** command, which is available after choosing **File** > **New Web Site**:

- Default.aspx

     The default home page for the new Web site. The Language attribute specifies the codebehind language, and the CodeFile attribute specifies the dependent file that contains the codebehind code associated with this page.

- Default.aspx.*extension*

     The dependent file that contains the codebehind code for the default home page. The codebehind language determines the *extension* of this file.

- web.config

     The root web.site configuration file.

- WebApplication.vstemplate

     The template file that determines the content of the Web site solution and forces the creation of the App_Data folder.

- WebApplication.webproj

     This file is an artifact of the project template system. It satisfies the project file reference in the WebApplication.vstemplate file.

### Web Service Projects
 These files create a new Web site in response to the **ASP.NET Web Service** command, which is available after choosing **File** > **New Web Site**:

- Service.asmx

     The HTML page for the new Web service. The Language attribute specifies the codebehind language, and the CodeBehind attribute specifies the dependent file that contains the codebehind code associated with this service.

- Service. *extension*

     The dependent file that implements the service class. The codebehind language determines the *extension* of this file.

- web.config

- The root web.site configuration file.

- WebService.vstemplate

     The template file that determines the content of the Web site solution and forces the creation of the App_Data and App_Code folders. The service.*extension* file is copied to the App_Code folder.

- WebService.webproj

     This file is an artifact of the project template system. It satisfies the project file reference in the WebService.vstemplate file.

## Project Item Template Folder
 Web project-item templates are typically installed in [*Visual Studio Installation Path*]\Common7\IDE\ItemTemplates\Web\\, each in a subfolder that is named after its web programming language.

## Project Item Templates
 Web site project item templates are used to add new Web pages to a Web site in response to the **Add Existing Item** command. These kinds of Web pages are currently supported:

- New class

- New HTML page

- New Web Form

- New master page

### New Class
 This template creates a new source file that defines an empty class in response to the **Add New Class** command.

- Class. *extension*

     The source file that implements the empty class. The codebehind language determines the *extension* of this file.

- Class.vstemplate

     The template file that creates the source file and determines its contents.

### New HTML Page
 This template creates a new Web page in response to the **Add New HTML Page** command.

- HTMLPage.htm

     The starting content of the Web page. This Web page typically has no associated codebehind dependent file. To create a smart page with an associated codebehind file, use the Web Form template instead.

- HTMLPage.vstemplate

     The template file that creates the Web page and determines its contents.

### New WebForm
 This template creates a new smart Web page in response to the **Add New Web Form** command.

 To create a dependent codebehind source file, select **Place code in separate file**. Otherwise, a single Web page is created that has an empty scripting block and no \<% Page %> directives to hook up a dependent file.

 To create a content page for a selected master page, select **Select master page**.

- WebForm.aspx

     The starting content of the Web page. This Web page has no associated codebehind dependent file.

- WebForm_cb.aspx

     The starting content of the Web page. This Web page has an associated codebehind dependent file.

- Codebehind. *extension*

     The dependent file that implements the webform class. The codebehind language determines the *extension* of this file.

- ContentPage.aspx

     The starting content of the Web page as a content page. This Web page has no associated codebehind dependent file.

- ContentPage_cb.aspx

     The starting content of the Web page as a content page. This Web page has an associated codebehind dependent file.

- WebForm.vstemplate

     The template file that determines the contents of the new web page and its dependent file, if any.

### New Master Page
 This template creates a new master page in response to the **Add New Master Page** command.

 To create a dependent codebehind source file, select **Place code in separate file**. Otherwise a single Web page is created that has an empty scripting block and no \<% Page %> directives to hook up a dependent file.

- MasterPage.master

     The starting content of the master page. This master page has no associated codebehind dependent file.

- MasterPage_cb.master

     The starting content of the master page. This master page has an associated codebehind dependent file.

- Codebehind.*extension*

     The dependent file that implements the master page class. The codebehind language determines the *extension* of this file.

- MasterPage.vstemplate

     The template file that determines the contents of the new master page and its dependent file, if any.

## See also
- [Web Site Support](../../extensibility/internals/web-site-support.md)
