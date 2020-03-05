---
title: "Using Microsoft.VisualStudio.TestTools.UnitTesting Members in Unit Tests | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-test
ms.topic: conceptual
ms.assetid: 0fa335fd-e442-448f-913f-25a19df90a93
caps.latest.revision: 8
ms.author: jillfra
manager: jillfra
---
# Using Microsoft.VisualStudio.TestTools.UnitTesting Members in Unit Tests
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]
The Unit Testing Framework supports unit testing in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. Use the classes and members in the <xref:Microsoft.VisualStudio.TestTools.UnitTesting> namespace when you are coding unit tests. You can use them when you have written the unit test from scratch or are refining a unit test that was generated from code you are testing.

## Groups of Elements
 To help provide a clearer overview of the Unit Testing Framework, this section organizes the elements of the UnitTesting namespace into groups of related functionality.

> [!NOTE]
> Attribute elements, whose names conclude with the string Attribute, can be used either with or without the string Attribute. For example, the following two code examples function identically:
>
> `[TestClass()]`
>
> `[TestClassAttribute()]`

### Elements Used for Data-Driven Testing
 Use the following elements to set up data-driven unit tests. For more information, see [How To: Create a Data-Driven Unit Test](../test/how-to-create-a-data-driven-unit-test.md) and [Walkthrough: Using a Configuration File to Define a Data Source](../test/walkthrough-using-a-configuration-file-to-define-a-data-source.md).

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.DataAccessMethod>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.DataSourceAttribute>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.DataSourceElement>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.DataSourceElementCollection>

## Attributes Used to Establish a Calling Order
 A code element decorated with one of the following attributes is called at the moment you specify. For more information, see [Anatomy of a Unit Test](https://msdn.microsoft.com/a03d1ee7-9999-4e7c-85df-7d9073976144).

### For Assemblies
 AssemblyInitialize and AssemblyCleanup are called right after your assembly is loaded and right before your assembly is unloaded.

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.AssemblyInitializeAttribute>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.AssemblyCleanupAttribute>

### For Classes
 ClassInitialize and ClassCleanup are called right after your class is loaded and right before your class is unloaded.

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute>

### For Test Methods

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute>

## Attributes Used to Identify Test Classes and Methods
 Every test class must have the TestClass attribute, and every test method must have the TestMethod attribute. For more information, see [Anatomy of a Unit Test](https://msdn.microsoft.com/a03d1ee7-9999-4e7c-85df-7d9073976144).

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute>

## Assert Classes and Related Exceptions
 Unit tests can verify specific application behavior by their use of various kinds of Assert statements, exceptions, and attributes. For more information, see [Using the Assert Classes](../test/using-the-assert-classes.md).

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.CollectionAssert>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.StringAssert>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.AssertInconclusiveException>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.ExpectedExceptionAttribute>

## The TestContext Class
 The following attributes and the values assigned to them appear in the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Properties window for a particular test method. These attributes are not meant to be accessed through the code of the unit test. Instead, they affect the ways the unit test is used or run, either by you through the IDE of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], or by the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] test engine.For example, some of these attributes appear as columns in the Test Manager window and Test Results window, which means that you can use them to group and sort tests and test results. One such attribute is TestPropertyAttribute, which you use to add arbitrary metadata to unit tests. For example, you could use it to store the name of a test pass that this test covers, by marking the unit test with `[TestProperty("TestPass", "Accessibility")]`. Or you could use it to store an indicator of the kind of test it is: `[TestProperty("TestKind", "Localization")]`. The property you create by using this attribute, and the property value you assign, are both displayed in the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Properties window under the heading **Test specific**.

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.OwnerAttribute>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.DeploymentItemAttribute>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.IgnoreAttribute>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.PriorityAttribute>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.WorkItemAttribute>

## Test Configuration Classes

- [ObjectTypes](/previous-versions/visualstudio/visual-studio-2013/dd987428(v=vs.120))

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestConfigurationSection>

## Attributes Used for Generating Reports
 The attributes in this section relate the test method that they decorate to entities in the project hierarchy of a [!INCLUDE[esprtfs](../includes/esprtfs-md.md)] team project.

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.CssIterationAttribute>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.CssProjectStructureAttribute>

## Classes Used with Private Accessors
 As described in [Using Publicize to Create a Private Accessor](https://msdn.microsoft.com/2056c6a7-6672-42a7-8f53-fead33c56deb), you can generate a unit test for a private method. This generation creates a private accessor class, which instantiates an object of the PrivateObject class. The PrivateObject class is a wrapper class that uses reflection as part of the private accessor process. The PrivateType class is similar, but is used for calling private static methods instead of calling private instance methods.

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject>

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType>

## See also

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting>