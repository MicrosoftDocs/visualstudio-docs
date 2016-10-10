---
title: "Output Element (MSBuild)"
ms.custom: na
ms.date: 10/10/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
  - jsharp
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 34bc7cd1-efd3-4b57-b691-4584eeb6a0e9
caps.latest.revision: 13
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Output Element (MSBuild)
Stores task output values in items and properties.  
  
 <Project\>  
 <Target\>  
 <Task\>  
 <Output\>  
  
## Syntax  
  
```  
<Output TaskParameter="Parameter"  
    PropertyName="PropertyName"   
    Condition = "'String A' == 'String B'" />  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|`TaskParameter`|Required attribute.<br /><br /> The name of the task's output parameter.|  
|`PropertyName`|Either the `PropertyName` or `ItemName` attribute is required.<br /><br /> The property that receives the task's output parameter value. Your project can then reference the property with the `$(`*PropertyName*`)` syntax. This property name can either be a new property name or a name that is already defined in the project.<br /><br /> This attribute cannot be used if `ItemName` is also being used.|  
|`ItemName`|Either the `PropertyName` or `ItemName` attribute is required.<br /><br /> The item that receives the task's output parameter value. Your project can then reference the item with the `@(`*ItemName*`)` syntax. The item name can either be a new item name or a name that is already defined in the project.<br /><br /> This attribute cannot be used if `PropertyName` is also being used.|  
|`Condition`|Optional attribute.<br /><br /> Condition to be evaluated. For more information, see [Conditions](../VS_IDE/MSBuild-Conditions.md).|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Task](../VS_IDE/Task-Element--MSBuild-.md)|Creates and executes an instance of an MSBuild task.|  
  
## Example  
 The following code example shows the `Csc` task being executed inside of a `Target` element. The items and properties passed to the task parameters are declared outside of the scope of this example. The value from the output parameter `OutputAssembly` is stored in the `FinalAssemblyName` item, and the value from the output parameter `BuildSucceeded` is stored in the `BuildWorked` property. For more information, see [Tasks](../VS_IDE/MSBuild-Tasks.md).  
  
```  
<Target Name="Compile" DependsOnTargets="Resources">  
    <Csc  Sources="@(CSFile)"  
            TargetType="library"  
            Resources="@(CompiledResources)"  
            EmitDebugInformation="$(includeDebugInformation)"  
            References="@(Reference)"  
            DebugType="$(debuggingType)"  
            OutputAssembly="$(builtdir)\$(MSBuildProjectName).dll" >  
        <Output TaskParameter="OutputAssembly"  
                  ItemName="FinalAssemblyName" />  
        <Output TaskParameter="BuildSucceeded"  
                  PropertyName="BuildWorked" />  
    </Csc>  
</Target>  
```  
  
## See Also  
 [Project File Schema Reference](../VS_IDE/MSBuild-Project-File-Schema-Reference.md)   
 [Tasks](../VS_IDE/MSBuild-Tasks.md)