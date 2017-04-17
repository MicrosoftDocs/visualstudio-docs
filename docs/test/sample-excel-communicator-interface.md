---
title: "Sample Excel Communicator Interface | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 1dbf1090-762c-4824-82dd-2d7c2c6f00b6
caps.latest.revision: 11
ms.author: "douge"
manager: "douge"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Sample Excel Communicator Interface
The sample `IExcelUICommunication` interface is used in the `ExcelUICommunicator` object in the `ExcelAddIn` project.  
  
## IExcelUICommunication Interface  
 This interface defines the communication points between the `CodedUIExtension`, which runs in the Coded UI Test process, and the `ExcelCodedUIAddIn`, which runs in the [!INCLUDE[ofprexcel](../test/includes/ofprexcel_md.md)] process.  
  
 The `ExcelCodedUIAddinHelper` assembly has a `ExcelUICommunicator` class that derives from this interface and uses the Excel object model to process the methods.  
  
 Some methods get the requested information from Excel then create and return one of the information objects, such as the `CellInformation` object.  
  
 Other methods use a provided information object, find the corresponding control in Excel, and perform some process on the control. For example, the `ScrollIntoView` method scrolls the Worksheet so that the designated cell is visible.  
  
## CodedUIExtensibilitySample and ExcelCodedUIAddinHelper Communication  
 The `ExcelCodedUIAddinHelper` assembly runs in the Excel process and has the `UICommunicator` class that implements the `IExcelUITestCommunication` interface and gets or sets the required information directly from the Excel UI.  
  
 The `CodedUIExtensibilitySample` assembly runs in the Visual Studio Coded UI Test process. This assembly has the `Communicator` class that opens a .NET Remoting channel, and provides an `Instance` property that uses the `IExcelUICommunication` interface to use the `UICommunicator` object in the `ExcelCodedUIAddinHelper` assembly to pass requests and information objects, such as a `CellInformation` object, back and forth between the two assemblies.  
  
## See Also  
 [Extending Coded UI Tests and Action Recordings to Support Microsoft Excel](../test/extending-coded-ui-tests-and-action-recordings-to-support-microsoft-excel.md)   
 [Sample Excel Add-In for Coded UI Testing](../test/sample-excel-add-in-for-coded-ui-testing.md)   
 [Sample Coded UI Test Extension for Excel](../test/sample-coded-ui-test-extension-for-excel.md)
