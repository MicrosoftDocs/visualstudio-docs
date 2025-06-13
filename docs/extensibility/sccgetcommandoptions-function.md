---
description: "This function prompts the user for advanced options for a given command."
title: SccGetCommandOptions Function
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccGetCommandOptions
helpviewer_keywords:
- SccGetCommandOptions function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccGetCommandOptions function

This function prompts the user for advanced options for a given command.

## Syntax

```cpp
SCCRTN SccGetCommandOptions(
   LPVOID pvContext,
   HWND hWnd,
   enum SCCCOMMAND iCommand,
   LPCMDOPTS* ppvOptions
);
```

### Parameters
 pvContext

[in] The source control plug-in context structure.

 hWnd

[in] A handle to the IDE window that the source control plug-in can use as a parent for any dialog boxes that it provides.

 iCommand

[in] The command for which advanced options are requested (see [Command code](../extensibility/command-code-enumerator.md) for possible values).

 ppvOptions

[in] The option structure (can also be `NULL`).

## Return value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|Success.|
|SCC_I_ADV_SUPPORT|The source control plug-in supports advanced options for the command.|
|SCC_I_OPERATIONCANCELED|The user cancelled the source control plug-in's **Options** dialog box.|
|SCC_E_OPTNOTSUPPORTED|The source control plug-in does not support this operation.|
|SCC_E_ISCHECKEDOUT|Cannot perform this operation on a file that is currently checked out.|
|SCC_E_ACCESSFAILURE|There was a problem accessing the source control system, probably due to network or contention issues. A retry is recommended.|
|SCC_E_NONSPECIFICERROR|Nonspecific failure.|

## Remarks
 The IDE calls this function for the first time with `ppvOptions`=`NULL` to determine if the source control plug-in supports the advanced options feature for the specified command. If the plug-in does support the feature for that command, the IDE calls this function again when the user requests advanced options (usually implemented as an **Advanced** button in a dialog box) and supplies a non-NULL pointer for `ppvOptions` that points to a `NULL` pointer. The plug-in stores any advanced options specified by the user in a private structure and returns a pointer to that structure in `ppvOptions`. This structure is then passed to all other Source Control Plug-in API functions that need to know about it, including subsequent calls to the `SccGetCommandOptions` function.

 An example may help clarify this situation.

 A user chooses the **Get** command and the IDE displays a **Get** dialog box. The IDE calls the `SccGetCommandOptions` function with `iCommand` set to `SCC_COMMAND_GET` and `ppvOptions` set to `NULL`. This is interpreted by the source control plug-in as the question, "Do you have any advanced options for this command?" If the plug-in returns `SCC_I_ADV_SUPPORT`, the IDE displays an **Advanced** button in its **Get** dialog box.

 The first time the user clicks the **Advanced** button, the IDE again calls the `SccGetCommandOptions` function, this time with a non-`NULL``ppvOptions` that points to a `NULL` pointer. The plug-in displays its own **Get Options** dialog box, prompts the user for information, puts that information into its own structure, and returns a pointer to that structure in `ppvOptions`.

 If the user clicks **Advanced** again in the same dialog box, the IDE calls the `SccGetCommandOptions` function again without changing `ppvOptions`, so that the structure is passed back to the plug-in. This enables the plug-in to reinitialize its dialog box to the values that the user had previously set. The plug-in modifies the structure in place before returning.

 Finally, when the user clicks **OK** in the IDE's **Get** dialog box, the IDE calls the [SccGet](../extensibility/sccget-function.md), passing the structure returned in `ppvOptions` that contains the advanced options.

> [!NOTE]
> The command `SCC_COMMAND_OPTIONS` is used when the IDE displays an **Options** dialog box that lets the user set preferences that control how the integration works. If the source control plug-in wants to supply its own preferences dialog box, it can display it from an **Advanced** button in the IDE's preferences dialog box. The plug-in is solely responsible for getting and persisting this information; the IDE does not use it or modify it.

## See also
- [Source control plug-in API functions](../extensibility/source-control-plug-in-api-functions.md)
- [Command code](../extensibility/command-code-enumerator.md)
