---
title: "Customizing IntelliSense for RequireJS | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
ms.assetid: 2be07ef8-9c08-444b-a21a-22a4fe6386a3
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: jillfra
---
# Customizing IntelliSense for RequireJS
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Starting with Visual Studio 2013 Update 4, support for the popular RequireJS JavaScript file and modular loader is supported. RequireJS makes it easier to define dependencies between code modules and to dynamically load modules only when needed. When writing JavaScript code that uses RequireJS, IntelliSense suggestions will be provided for modules that you’ve referenced from your module definition or referenced using calls to `require()` from within your code.

 By default, Visual Studio supports a very basic configuration to support RequireJS, but it is common practice to setup your own custom configuration settings (that is, to define aliases for libraries). This topic describes the different ways that you can customize Visual Studio to work with your project’s unique setup.

 This topic describes how to:

- Customize RequireJS in ASP.NET projects

- Customize RequireJS in JSProj projects, which are used to build Apache Cordova apps, Windows Store apps, and LightSwitch HTML apps

## Customize RequireJS in ASP.NET projects
 Support for RequireJS is automatically enabled when a file named require.js is referenced by your current JavaScript file (For more information, see the Determining IntelliSense Context section in [JavaScript IntelliSense](../ide/javascript-intellisense.md)). In ASP.NET projects, referencing require.js is typically done using a /// \<reference/> directive within a _references.js file.

### Configure the data-main attribute in an ASP.NET project
 To accurately simulate how your app will work when you run it, the JavaScript editor needs to know what file to load first when setting up require.js. This is typically configured in your application HTML file using the `data-main` attribute on the script element that references require.js, as shown here.

```html
<script src="js/require.js" data-main="js/app.js"></script>
```

 In this example, the script referenced by data-main (js/app.js) is loaded immediately after require.js. The file that is loaded immediately is the best place to first configure RequireJS usage (using `require.config()`).To tell the JavaScript editor what file to use for `data-main` in your application, add a `data-main` attribute, and then modify a /// \<reference/> directive that references require.js in your application. For example, you can use this directive:

```javascript
/// <reference path="js/require.js" data-main="js/app.js" />
```

### Configure the application start page in an ASP.NET project
 When the app runs, RequireJS assumes that relative paths to files (for example, "..\\" paths) are relative to the HTML file that loaded the require.js library. As you write code in the Visual Studio editor for an ASP.NET project, this start page is unknown and you’ll need to tell the editor what start page to use when using relative file paths. To do this, add a `start-page` attribute to your /// \<reference/> directive.

```javascript
/// <reference path="js/require.js" data-main="js/app.js" start-page="/app/index.html" />
```

 The `start-page` attribute specifies the URL of the page as you would see it in a browser when running your app.

## Customize RequireJS in JSProj projects
 JSProj projects (project files ending in a .jsproj extension) are used when building apps for Apache Cordova, HTML-based Windows Store Apps, or LightSwitch HTML apps. Unlike ASP.NET projects, these projects read references to .js files from the HTML files that exist in the project. Because of this, when editing JavaScript in a JSProj project, you will see support for RequireJS is enabled if the JavaScript file currently being edited is referenced in another HTML file that also references require.js.

 The customization steps needed for ASP.NET projects are not needed in a JSProj project file. That is, script files used by the `data-main` attribute on the script tag that references require.js are loaded automatically to configure require.js. The HTML file referencing require.js is also used as the start page for the application.

## See Also
 [JavaScript IntelliSense](../ide/javascript-intellisense.md)
