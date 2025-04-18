---
title: File Properties, JavaScript
description: Learn how you can use file properties to indicate what actions the project system should perform on the files. 
ms.date: 06/21/2017
ms.subservice: javascript-typescript
ms.topic: reference
f1_keywords:
  - "javascript.project.property.expandedsdknode.fileversion"
  - "javascript.project.property.expandedsdknode.uri"
  - "javascript.project.property.expandedsdknode.filename"
  - "javascript.project.property.reference.description"
  - "javascript.project.property.reference.specificversion"
  - "javascript.project.property.reference.identity"
  - "javascript.project.property.fullpath"
  - "javascript.project.property.packageaction"
  - "javascript.project.property.reference.package"
  - "javascript.project.property.copytooutputdirectory"
  - "javascript.project.property.expandedsdknode.sdkpath"
  - "javascript.project.property.reference.filetype"
  - "javascript.project.property.reference.culture"
  - "javascript.project.property.filename"
  - "javascript.project.property.reference.resolvedpath"
  - "javascript.project.property.reference.version"
ms.custom: "ide-ref"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
---
# File Properties, JavaScript

You can use file properties to indicate what actions the project system should perform on the files. For example, you can set file properties to indicate whether a file should be added to the package as a resource file.

You can select any file in Solution Explorer and then examine its properties in the Properties window. JavaScript files have four properties: **Copy to Output Directory**, **Package Action**, **File Name**, and **File Path**.

## File Properties
This section describes properties common to JavaScript files.

### Copy to Output Directory Property
This property specifies the conditions under which the selected source file will be copied to the output directory. Select **Do not copy** if the file is never to be copied to the output directory. Select **Copy always** if the file is always to be copied to the output directory. Select **Copy if newer** if the file is to be copied only when it is newer than an existing file of the same name in the output directory.

### Package Action
The **Package Action** property indicates what Visual Studio does with a file when a build is executed. **Package Action** can have one of several values:

- **None** - The file is not included in the package manifest. An example is a text file that contains documentation, such as a Readme file.

- **Content** - The file is included in the package manifest. For example, this setting is the default value for an .htm, .js, .css, image, audio, or video file.

- **Manifest** - The file is not included in the package manifest. Instead, the file is used for input when generating the package manifest. This is the default value for the package.appxmanifest file.

- **Resource** - The file is not included in the package manifest. Instead, the contents of the file are indexed in the Package Resource Index (PRI) that goes into the package manifest. It is typically used for resource files.

The default value for **Package Action** depends on the extension of the file that you add to the solution.

### File Name Property
Displays the file name as a read-only value. To rename the file, you must right-click in Solution Explorer and select **Rename**.

### Full Path Property
Displays the full path to the file as a read-only value. To change the path of the file, you can drag-and-drop the file in Solution Explorer.

## Reference File Properties
This section describes properties common to files referenced from a UWP app built using JavaScript. When you select a reference such as a .winmd file, an SDK reference, a project-to-project reference, or an assembly reference in Solution Explorer, other properties may display in the Properties window, according to the file type.

### Culture
Displays the language associated with the reference.

### File Type
Displays the file type of the reference.

### File Version
Displays the file version of the reference.

### Identity
Displays the identity of the reference that is used in the project, which is stored in the project file.

### Package
Displays the name of the package manifest associated with the reference.

### Resolved Path
Displays the path to the reference that is used in the project.

### SDK Path
Displays the path to the referenced SDK file.

### Uri
Displays the URI that must be included in the project's HTML or JavaScript files to include the file as a source file.

### Version
Displays the version of the reference.

## See also

- [Managing Project and Solution Properties](../../ide/managing-project-and-solution-properties.md)