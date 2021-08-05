---
title: "JavaScript and TypeScript"
description: "Information on the support for JavaScript in Visual Studio for Mac"
author: heiligerdankgesang
ms.author: dominicn
ms.date: 05/03/2018
ms.technology: vs-ide-general
ms.assetid: 61432695-5B12-4257-B250-48D37EED106D
---

# JavaScript and TypeScript support

Visual Studio for Mac provides support for JavaScript and TypeScript through syntax highlighting, code formatting, and IntelliSense.

![typescript editor support](/visualstudio/mac/media/tsjseditor-2019.gif)

For more information on writing JavaScript, see to the [Writing JavaScript Code](/scripting/javascript/writing-javascript-code) guides.

## Adding a JavaScript file

JavaScript files are most often added to ASP.NET Core projects through the **New File** dialog. To add a javascript file, right-click on your project and go to **Add > New File**:

![adding new files to the project](media/javascript-image1.png)

From the **New File** dialog, select **Web > Empty JS file** or **Web > TypeScript file**. Give it a name and then choose **New**:

![creating a new typescript file from the template](media/javascript-image2.png)

## IntelliSense

Visual Studio for Mac uses the [JavaScript Language Service](/visualstudio/ide/javascript-intellisense) to provide IntelliSense, allowing you to have intelligent code completion, parameter info, and member lists when writing code.

JavaScript intellisense in Visual Studio for Mac can be based on type inference, JSDoc, or TypeScript declaration.

- **Type inference** – The type of an object is figured out by the surrounding code context. For more information, see Visual Studio's section on [IntelliSense based on type inference](/visualstudio/ide/javascript-intellisense#intellisense-based-on-type-inference).
- **JSDoc** – There are times when type inference doesn't provide the correct type information. In these cases, the type information can be provided explicitly by [JSDoc](https://jsdoc.app/about-getting-started.html) annotations. For more information, see Visual Studio's section on [IntelliSense based on JSDoc](/visualstudio/ide/javascript-intellisense#intellisense-based-on-jsdoc)
- **TypeScript declaration files** – `.d.ts` files are used to provide values for JavaScript IntelliSense. Types declared in that file can be used as types on JSDoc comments. For more information, see Visual Studio's section on [IntelliSense based on TypeScript declaration files](/visualstudio/ide/javascript-intellisense#intellisense-based-on-typescript-declaration-files)

    ![adding a typescript definition file](media/javascript-image3.png)

## See also

- [JavaScript IntelliSense (Visual Studio on Windows)](/visualstudio/ide/javascript-intellisense)
