---
title: "Configure npm packages with package.json"
description: Specify npm package versions for your Node.js application by using a package.json file and investigate potential causes for warnings or errors. 
ms.date: "09/06/2018"
ms.topic: how-to
ms.devlang: javascript
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: javascript-typescript
dev_langs:
  - JavaScript
---
# package.json configuration

If you are developing a Node.js app with a lot of npm packages, it's not uncommon to run into warnings or errors when you build your project if one or more packages has been updated. Sometimes, a version conflict results, or a package version has been deprecated. Here are a couple of quick tips to help you configure your [package.json](https://docs.npmjs.com/files/package.json) file and understand what is going on when you see warnings or errors. This is not a complete guide to *package.json* and is focused only on npm package versioning.

The npm package versioning system has strict rules. The version format follows here:

```
[major].[minor].[patch]
```

Let's say you have a package in your app with a version of 5.2.1. The major version is 5, the minor version is 2, and the patch is 1.

* In a major version update, the package includes new features that are backwards-incompatible, that is, breaking changes.
* In a minor version update, new features have been added to the package that are backwards-compatible with earlier package versions.
* In a patch update, one or more bug fixes are included. Bug fixes are always backwards-compatible.

It's worth noting that some npm package features have dependencies. For example, to use a new feature of the TypeScript compiler package (ts-loader) with webpack, it is possible you would also need to update the webpack npm package and the webpack-cli package.

To help manage package versioning, npm supports several notations that you can use in the *package.json*. You can use these notations to control the type of package updates that you want to accept in your app.

Let's say you are using React and need to include the **react** and **react-dom** npm package. You could specify that in several ways in your *package.json* file. For example, you can specify use of the exact version of a package as follows.

  ```json
  "dependencies": {
    "react": "16.4.2",
    "react-dom": "16.4.2",
  },
  ```

Using the preceding notation, npm will always get the exact version specified, 16.4.2.

You can use a special notation to limit updates to patch updates (bug fixes). In this example:

  ```json
  "dependencies": {
    "react": "~16.4.2",
    "react-dom": "~16.4.2",
  },
  ```

you use the tilde (~) character to tell npm to only update a package when it is patched. So, npm can update react 16.4.2 to 16.4.3 (or 16.4.4, etc.), but it will not accept an update to the major or minor version. So, 16.4.2 will not get updated to 16.5.0.

You can also use the caret (^) symbol to specify that npm can update the minor version number.

  ```json
  "dependencies": {
    "react": "^16.4.2",
    "react-dom": "^16.4.2",
  },
  ```

Using this notation, npm can update react 16.4.2 to 16.5.0 (or 16.5.1, 16.6.0, etc.), but it will not accept an update to the major version. So, 16.4.2 will not get updated to 17.0.0.

When npm updates packages, it generates a *package-lock.json* file, which lists the actual npm package versions used in your app, including all nested packages. While *package.json* controls the direct dependencies for your app, it does not control nested dependencies (other npm packages required by a particular npm package). You can use the *package-lock.json* file in your development cycle if you need to make sure that other developers and testers are using the exact packages that you are using, including nested packages. For more information, see [package-lock.json](https://docs.npmjs.com/files/package-lock.json) in the npm documentation.

For Visual Studio, the *package-lock.json* file is not added to your project, but you can find it in the project folder.
