---
title: "Using Microsoft.VisualStudio.TestTools.UnitTesting Members in Unit Tests"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 0fa335fd-e442-448f-913f-25a19df90a93
caps.latest.revision: 6
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Using Microsoft.VisualStudio.TestTools.UnitTesting Members in Unit Tests
The Unit Testing Framework supports unit testing in Visual Studio. Use the classes and members in the <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework?qualifyHint=False> namespace when you are coding unit tests. You can use them when you have written the unit test from scratch or are refining a unit test that was generated from code you are testing.  
  
## Groups of Elements  
 To help provide a clearer overview of the Unit Testing Framework, this section organizes the elements of the UnitTesting namespace into groups of related functionality.  
  
> [!NOTE]
>  Attribute elements, whose names conclude with the string Attribute, can be used either with or without the string Attribute. For example, the following two code examples function identically:  
>   
>  `[TestClass()]`  
>   
>  `[TestClassAttribute()]`  
  
### Elements Used for Data-Driven Testing  
 Use the following elements to set up data-driven unit tests. For more information, see [How To: Create a Data-Driven Unit Test](../VS_IDE/How-To--Create-a-Data-Driven-Unit-Test.md) and [Walkthrough: Using a Configuration File to Define a Data Source](../VS_IDE/Walkthrough--Using-a-Configuration-File-to-Define-a-Data-Source.md).  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.DataAccessMethod?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.DataSourceAttribute?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.DataSourceElement?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.DataSourceElementCollection?qualifyHint=False>  
  
## Attributes Used to Establish a Calling Order  
 A code element decorated with one of the following attributes is called at the moment you specify. For more information, see [Anatomy of a Unit Test](assetId:///a03d1ee7-9999-4e7c-85df-7d9073976144).  
  
### For Assemblies  
 AssemblyInitialize and AssemblyCleanup are called right after your assembly is loaded and right before your assembly is unloaded.  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.AssemblyInitializeAttribute?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.AssemblyCleanupAttribute?qualifyHint=False>  
  
### For Classes  
 ClassInitialize and ClassCleanup are called right after your class is loaded and right before your class is unloaded.  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.ClassInitializeAttribute?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.ClassCleanupAttribute?qualifyHint=False>  
  
### For Test Methods  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.TestInitializeAttribute?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.TestCleanupAttribute?qualifyHint=False>  
  
## Attributes Used to Identify Test Classes and Methods  
 Every test class must have the TestClass attribute, and every test method must have the TestMethod attribute. For more information, see [Anatomy of a Unit Test](assetId:///a03d1ee7-9999-4e7c-85df-7d9073976144).  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.TestClassAttribute?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.TestMethodAttribute?qualifyHint=False>  
  
## Assert Classes and Related Exceptions  
 Unit tests can verify specific application behavior by their use of various kinds of Assert statements, exceptions, and attributes. For more information, see [Using the Assert Classes](../VS_IDE/Using-the-Assert-Classes.md).  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.Assert?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.CollectionAssert?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.StringAssert?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.AssertFailedException?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.AssertInconclusiveException?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.UnitTestAssertException?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.ExpectedExceptionAttribute?qualifyHint=False>  
  
## The TestContext Class  
 The following attributes and the values assigned to them appear in the Visual Studio Properties window for a particular test method. These attributes are not meant to be accessed through the code of the unit test. Instead, they affect the ways the unit test is used or run, either by you through the IDE of Visual Studio, or by the Visual Studio test engine.For example, some of these attributes appear as columns in the Test Manager window and Test Results window, which means that you can use them to group and sort tests and test results. One such attribute is TestPropertyAttribute, which you use to add arbitrary metadata to unit tests. For example, you could use it to store the name of a test pass that this test covers, by marking the unit test with `[TestProperty("TestPass", "Accessibility")]`. Or you could use it to store an indicator of the kind of test it is: `[TestProperty("TestKind", "Localization")]`. The property you create by using this attribute, and the property value you assign, are both displayed in the Visual Studio Properties window under the heading **Test specific**.  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.OwnerAttribute?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.DeploymentItemAttribute?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.DescriptionAttribute?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.HostTypeAttribute?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.IgnoreAttribute?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.PriorityAttribute?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.TestPropertyAttribute?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.WorkItemAttribute?qualifyHint=False>  
  
## Test Configuration Classes  
  
-   <xref:Microsoft.TeamFoundation.TestManagement.Client.ObjectTypes?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.TestConfigurationSection?qualifyHint=False>  
  
## Attributes Used for Generating Reports  
 The attributes in this section relate the test method that they decorate to entities in the project hierarchy of a Team Foundation Server team project.  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.CssIterationAttribute?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.CssProjectStructureAttribute?qualifyHint=False>  
  
## Classes Used with Private Accessors  
 As described in [Using Publicize to Create a Private Accessor](assetId:///2056c6a7-6672-42a7-8f53-fead33c56deb), you can generate a unit test for a private method. This generation creates a private accessor class, which instantiates an object of the PrivateObject class. The PrivateObject class is a wrapper class that uses reflection as part of the private accessor process. The PrivateType class is similar, but is used for calling private static methods instead of calling private instance methods.  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.PrivateObject?qualifyHint=False>  
  
-   <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework.PrivateType?qualifyHint=False>  
  
## See Also  
 <xref:Microsoft.VisualStudio.TestPlatform.UnitTestFramework?qualifyHint=False>