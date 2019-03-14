---
title: "VCToolTask Class | Microsoft Docs"
ms.date: "03/10/2019"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
ms.assetid: 6c3f6238-b9f0-4325-b8b0-de61090bd0a2
author: mikeblome
ms.author: Michael.Blome
ms.workload:
  - "multiple"
---
# VCToolTask base class

Many tasks ultimately inherit from the <xref:Microsoft.Build.Utilities.Task> class and [ToolTask](/dotnet/api/microsoft.build.utilities.tooltask) class. This class adds several methods to the tasks that derive from them. These methods are listed in this document.

## Class

The **VCToolTask** base class supports the `protected MessageStruct` class with the following `public` members:

|Member|Type|
|---------------|-----------------|
|**Category**|**string**|
|**Code**|**string**|
|**Filename**|**string**|
|**Line**|**int**|
|**Column**|**int**|
|**Text**|**string**|
|**Clear**|**void**|
|**Swap**|*static* **void**<br/><br/>Uses *ref* parameters **MessageStruct** *lhs* and **MessageStruct** *rhs*.|

The **VCToolTask** base class also supports the **enum**:

- `CommandLineFormat.ForBuildLog` and `CommandLineFormat.ForTracking`
- `EscapeFormat.Default` (0x0) and `EscapeFormat.EscapeTrailingSlash` (0x1)

## Methods

The following tables describe the methods of the **VCToolTask** base class.

### Public

All methods as `public`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**ActiveToolSwitchesValues**|(**Dictionary\<string, ToolSwitch>**)|
|**AdditionalOptions**|(**string**)|
|**EffectiveWorkingDirectory**|(**string**)|
|**EnableErrorListRegex**|Default is `true`. (**bool**)|
|**ErrorListRegex**|(**ITaskItem[]**)|
|**ErrorListListExclusion**|(**ITaskItem[]**)|
|**GenerateCommandLine**|(**string**)<br/><br/>Use parameters **CommandLineFormat** *format* [default = CommandLineFormat.ForBuildLog] and **EscapeFormat** *escapeFormat* [default = EscapeFormat.Default].|
|**GenerateCommandLineExceptSwitches**|(**string**)<br/><br/>Use parameters **string[]** *switchesToRemove*, **CommandLineFormat** *format* [default = CommandLineFormat.ForBuildLog], and **EscapeFormat** *escapeFormat* [default = EscapeFormat.Default].|

#### Public Override

All methods as `public override`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**Cancel**|(**void**)|
|**Execute**|(**bool**)|

#### Public Virtual

All methods as `public virtual`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**AcceptableNonzeroExitCodes**|(**string[]**)|

### Protected

All methods as `protected`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**ActiveToolSwitches**|Default value is `activeToolSwitches`. (**Dictionary<string, ToolSwitch>**)|
|**AddActiveSwitchToolValue**|(**void**)<br/><br/>Use parameter **ToolSwitch** *switchToAdd*.|
|**BuildAdditionalArgs**|(**void**)<br/><br/>Use parameter **CommandLineBuilder** *cmdLine*.|
|**CancelEventName**|Default value is `cancelEventName`. (**string**)|
|**currentMS**|Default value is `new MessageStruct()`. (**MessageStruct**)|
|**errorListRegexList**|Default value is `new List<Regex>()`. (**List<Regex>**)|
|**errorListRegexListExclusion**|Default value is `new List<Regex>()`. (**List<Regex>**)|
|**GetEffectiveArgumentsValues**|(**string**)<br/><br/>Use parameter **ToolSwitch** *property*.|
|**HasSwitch**|(**bool**)<br/><br/>Use parameter **string** *propertyName*.|
|**IgnoreUnknownSwitchValues**|(**bool**)|
|**IsAcceptableReturnValue**|(**bool**)|
|**IsPropertySet**|(**bool**)<br/><br/>Use parameter **string** *propertyName*.|
|**IsSetToTrue**|(**bool**)<br/><br/>Use parameter **string** *propertyName*.|
|**IsSwitchValueSet**|(**bool**)<br/><br/>Use parameter **string** *switchValue*.|
|**IsExplicitlySetToFalse**|(**bool**)<br/><br/>Use parameter **string** *propertyName*.|
|**lastMS**|Default value is `new MessageStruct()`. (**MessageStruct**)|
|**LogPrivate**|Default value is `logPrivate`. (**TaskLoggingHelper**)|
|**ReadSwitchMap**|(**string**)<br/><br/>Use parameters **string** *propertyName*, **string[][]** *switchMap*, and **string** *value*.|
|**RemoveSwitchToolBasedOnValue**|(**void**)<br/><br/>Use parameter **string** *switchValue*.|
|**ValidateInteger**|(**bool**)<br/><br/>Use parameters **string** *switchName*, **int** *min*, **int** *max*, and **int** *value*.|
|**VerifyRequiredArgumentsArePresent**|(**bool**)<br/><br/>Use parameters **ToolSwitch** *property* and **bool** *throwOnError*.|

#### Protected Override

All methods as `protected override`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**GenerateCommandLineCommands**|(**string**)|
|**GenerateFullPathToTool**|(**string**)|
|**GenerateResponseFileCommands**|(**string**)|
|**GetWorkingDirectory**|(**string**)|
|**HandleTaskExecutionErrors**|(**bool**)|
|**LogEventsFromTextOutput**|(**void**)<br/><br/>Use parameters **string** *singleLine* and **MessageImportance** *messageImportance*.|
|**ResponseFileEncoding**|Default value is `Encoding.Unicode`. (**Encoding**)|
|**StandardErrorLoggingImportance**|Default value is `MessageImportance.High`. (**MessageImportance**)|
|**StandardOutputLoggingImportance**|Default value is `MessageImportance.High`. (**MessageImportance**)|
|**ValidateParameters**|(**bool**)|

#### Protected Static

All methods as `protected static`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**EnsureTrailingSlash**|(**string**)<br/><br/>Use parameter **string** *directoryName*.|

#### Protected Virtual

All methods as `protected virtual`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**AddDefaultsToActiveSwitchList**|(**void**)|
|**AddFallbacksToActiveSwitchList**|(**void**)|
|**AlwaysAppend**|(**string**)|
|**GenerateCommandsAccordingToType**|(**void**)<br/><br/>Use parameters **CommandLineBuilder** *builder*, **ToolSwitch** *toolSwitch*, **bool** *recursive*, **CommandLineFormat** *format* [default = CommandLineFormat.ForBuildLog], and **EscapeFormat** *escapeFormat* [default = EscapeFormat.Default].|
|**GenerateCommandLineCommands**|(**string**)<br/><br/>Use parameters **CommandLineFormat** *format* and **EscapeFormat** *escapeFormat*.|
|**GenerateCommandLineCommandsExceptSwitches**|(**string**)<br/><br/>Use parameters **string[]** *switchesToRemove*, **CommandLineFormat** *format* [default = CommandLineFormat.ForBuildLog], and **EscapeFormat** *escapeFormat* [default = EscapeFormat.Default])
|**GenerateResponseFileCommands**|(**string**)<br/><br/>Use parameters **CommandLineFormat** *format* and **EscapeFormat** *escapeFormat*.|
|**GenerateResponseFileCommandsExceptSwitches**|(**string**)<br/><br/>Use parameters **string[]** *switchesToRemove*, **CommandLineFormat** *format* [default = CommandLineFormat.ForBuildLog], and **EscapeFormat** *escapeFormat* [default = EscapeFormat.Default].|
|**ParseLine**|(**MessageStruct**)<br/><br/>Use parameter **string** *inputLine*.|
|**PostProcessSwitchList**|(**void**)|
|**PrintMessage**|(**void**)<br/><br/>Use parameters **MessageStruct** *message* and **MessageImportance** *messageImportance*.|
|**SwitchOrderList**|Default value is `null`. (**ArrayList**)|
|**TranslateAdditionalOptions**|(**string**)<br/><br/>Use parameter **string** *options*.|
|**ValidateOverrides**|(**void**)|
|**ValidateRelations**|(**void**)|
|**VerifyDependenciesArePresent**|(**bool**)<br/><br/>Use parameter **ToolSwitch** *value*.|

## See also

[Task reference](../msbuild/msbuild-task-reference.md)<br/>
[Tasks](../msbuild/msbuild-tasks.md)