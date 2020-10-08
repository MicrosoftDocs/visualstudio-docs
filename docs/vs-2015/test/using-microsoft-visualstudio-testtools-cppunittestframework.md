---
title: "Using Microsoft.VisualStudio.TestTools.CppUnitTestFramework | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-test
ms.topic: conceptual
ms.assetid: d1ac9188-d79f-407e-9f3a-80dbefa66317
caps.latest.revision: 10
ms.author: jillfra
manager: jillfra
---
# Using Microsoft.VisualStudio.TestTools.CppUnitTestFramework
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This topic lists the public members of the `Microsoft::VisualStudio::CppUnitTestFramework` namespace.

 The header files are located in the  _VisualStudio2012[x86]InstallFolder_**\VC\UnitTest\include** folder.

 The lib files are located in the  _VisualStudio2012[x86]InstallFolder_**\VC\UnitTest\lib** folder.

## <a name="BKMK_In_this_topic"></a> In this topic
 [CppUnitTest.h](#BKMK_CppUnitTest_h)

- [Create test classes and methods](#BKMK_Create_test_classes_and_methods)

- [Initialize and cleanup](#BKMK_Initialize_and_cleanup)

  - [Test methods](#BKMK_Test_methods)

  - [Test classes](#BKMK_Test_classes)

  - [Test modules](#BKMK_Test_modules)

- [Create test attributes](#BKMK_Create_test_attributes)

  - [Test method attributes](#BKMK_Test_method_attributes)

  - [Test class attributes](#BKMK_Test_class_attributes)

  - [Test module attributes](#BKMK_Test_module_attributes)

  - [Pre-defined attributes](#BKMK_Pre_defined_attributes)

    [CppUnitTestAssert.h](#BKMK_CppUnitTestAssert_h)

  - [General Asserts](#BKMK_General_Asserts)

    - [Are Equal](#BKMK_General_Are_Equal)

    - [Are Not Equal](#BKMK_General_Are_Not_Equal)

    - [Are Same](#BKMK_General_Are_Same)

    - [Are Not Same](#BKMK_General_Are_Not_Same)

    - [Is Null](#BKMK_General_Is_Null)

    - [Is Not Null](#BKMK_General_Is_Not_Null)

    - [Is True](#BKMK_General_Is_True)

    - [Is False](#BKMK_General_Is_False)

    - [Fail](#BKMK_General_Fail)

  - [Windows Runtime Asserts](#BKMK_WinRT_Asserts)

    - [Are Equal](#BKMK_WinRT_Are_Equal)

    - [Are Same](#BKMK_WinRT_Are_Same)

    - [Are Not Equal](#BKMK_WinRT_Are_Not_Equal)

    - [Are Not Same](#BKMK_WinRT_Are_Not_Same)

    - [Is Null](#BKMK_WinRT_Is_Null)

    - [Is Not Null](#BKMK_WinRT_Is_Not_Null)

  - [Exception Asserts](#BKMK_Exception_Asserts)

    - [Expect Exception](#BKMK_Expect_Exception)

      [CppUnitTestLogger.h](#BKMK_CppUnitTestLogger_h)

    - [Logger](#BKMK_Logger)

    - [Write Message](#BKMK_Write_Message)

## <a name="BKMK_CppUnitTest_h"></a> CppUnitTest.h

### <a name="BKMK_Create_test_classes_and_methods"></a> Create test classes and methods

```cpp
TEST_CLASS(className)
```

 Required for each class containing test methods. Identifies *className* as a test class. `TEST_CLASS` must be declared at namescape scope.

```cpp
TEST_METHOD(methodName)
{
    // test method body
}

```

 Defines *methodName* as a test method. `TEST_METHOD` must be declared in the scope of the method's class.

### <a name="BKMK_Initialize_and_cleanup"></a> Initialize and cleanup

#### <a name="BKMK_Test_methods"></a> Test methods

```cpp
TEST_METHOD_INITIALIZE(methodName)
{
    // method initialization code
}

```

 Defines *methodName* as a method that runs before each test method is run. `TEST_METHOD_INITIALIZE` can only be defined once in a test class and must be defined in the test class.

```cpp
TEST_METHOD_CLEANUP(methodName)
{
    // test method cleanup  code
}

```

 Defines *methodName* as a method that runs after each test method is run. `TEST_METHOD_CLEANUP` can only be defined once in a test class and must be defined in the scope of the test class.

#### <a name="BKMK_Test_classes"></a> Test classes

```cpp
TEST_CLASS_INITIALIZE(methodName)
{
    // test class initialization  code
}

```

 Defines *methodName* as a method that runs after each test class is created. `TEST_CLASS_INITIALIZE` can only be defined once in a test class and must be defined in the scope of the test class.

```cpp
TEST_CLASS_CLEANUP(methodName)
{
    // test class cleanup  code
}

```

 Defines *methodName* as a method that runs after each test class is created. `TEST_CLASS_CLEANUP` can only be defined once in a test class and must be defined in the scope of the test class.

#### <a name="BKMK_Test_modules"></a> Test modules

```cpp
TEST_MODULE_INITIALIZE(methodName)
{
    // module initialization code
}
```

 Defines the method *methodName* that runs when a module is loaded. `TEST_MODULE_INITIALIZE` can only be defined once in a test module and must be declared at namespace scope.

```cpp
TEST_MODULE_CLEANUP(methodName)
```

 Defines the method *methodName* that runs when a module is unloaded. `TEST_MODULE_CLEANUP` can only be defined once in a test module and must be declared at namespace scope.

### <a name="BKMK_Create_test_attributes"></a> Create test attributes

#### <a name="BKMK_Test_method_attributes"></a> Test method attributes

```cpp
BEGIN_TEST_METHOD_ATTRIBUTE(testMethodName)
    TEST_METHOD_ATTRIBUTE(attributeName, attributeValue)
    ...
END_TEST_METHOD_ATTRIBUTE()
```

 Adds the attributes defined with one or more `TEST_METHOD_ATTRIBUTE` macros to the test method *testClassName*.

 A `TEST_METHOD_ATTRIBUTE` macro defines an attribute with the name *attributeName* and the value *attributeValue*.

#### <a name="BKMK_Test_class_attributes"></a> Test class attributes

```cpp
BEGIN_TEST_CLASS_ATTRIBUTE(testClassName)
    TEST_CLASS_ATTRIBUTE(attributeName, attributeValue)
    ...
END_TEST_CLASS_ATTRIBUTE()
```

 Adds the attributes defined with one or more `TEST_CLASS_ATTRIBUTE` macros to the test class *testClassName*.

 A `TEST_CLASS_ATTRIBUTE` macro defines an attribute with the name *attributeName* and the value *attributeValue*.

#### <a name="BKMK_Test_module_attributes"></a> Test module attributes

```cpp
BEGIN_TEST_MODULE_ATTRIBUTE(testModuleName)
    TEST_MODULE_ATTRIBUTE(attributeName, attributeValue)
    ...
END_TEST_MODULE_ATTRIBUTE()
```

 Adds the attributes defined with one or more `TEST_MODULE_ATTRIBUTE` macros to the test module *testModuleName*.

 A `TEST_MODULE_ATTRIBUTE` macro defines an attribute with the name *attributeName* and the value *attributeValue*.

#### <a name="BKMK_Pre_defined_attributes"></a> Pre-defined attributes
 These pre-defined attribute macros can be substituted for the macros `TEST_METHOD_ATTRIBUTE`, `TEST_CLASS_ATTRIBUTE`, OR `TEST_MODULE_ATTRIBUTE` described above.

```cpp
TEST_OWNER(ownerAlias)
```

 Defines an attribute with the name `Owner` and the attribute value of *ownerAlias*.

```cpp
TEST_DESCRIPTION(description)
```

 Defines an attribute with the name `Description` and the attribute value of *description*.

```cpp
TEST_PRIORITY(priority)
```

 Defines an attribute with the name `Priority` and the attribute value of *priority*.

```cpp
TEST_WORKITEM(workitem)
```

 Defines an attribute with the name `WorkItem` and the attribute value of *workItem*.

```cpp
TEST_IGNORE()
```

 Defines an attribute with the name `Ignore` and the attribute value of `true`.

## <a name="BKMK_CppUnitTestAssert_h"></a> CppUnitTestAssert.h

### <a name="BKMK_General_Asserts"></a> General Asserts

#### <a name="BKMK_General_Are_Equal"></a> Are Equal
 Verify that two objects are equal

```cpp
template<typename T>
static void AreEqual(
    const T& expected,
    const T& actual,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

 Verify that two doubles are equal

```cpp
static void AreEqual(
    double expected,
    double actual,
    double tolerance,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

 Verify that two floats are equal

```cpp
static void AreEqual(
    float expected,
    float actual,
    float tolerance,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

 Verify that two char* strings are equal

```cpp
static void AreEqual(
    const char* expected,
    const char* actual,
    bool ignoreCase = false,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

 Verify that two w_char* strings are equal

```cpp
static void AreEqual(
    const wchar_t* expected,
    const wchar_t* actual,
    bool ignoreCase = false,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

#### <a name="BKMK_General_Are_Not_Equal"></a> Are Not Equal
 Verify that two doubles are not equal

```cpp
static void AreNotEqual(
    double notExpected,
    double actual,
    double tolerance,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

 Verify that two floats are not equal

```cpp
static void AreNotEqual(
    float notExpected,
    float actual,
    float tolerance,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

 Verify that two char* strings are not equal

```cpp
static void AreNotEqual(
    const char* notExpected,
    const char* actual,
    bool ignoreCase = false,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

 Verify that two w_char* strings are not equal

```cpp
static void AreNotEqual(
    const wchar_t* notExpected,
    const wchar_t* actual,
    bool ignoreCase = false,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

 Verify that two references are not equal based on operator==.

```cpp
template<typename T>
static void AreNotEqual(
    const T& notExpected,
    const T& actual,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

#### <a name="BKMK_General_Are_Same"></a> Are Same
 Verify that two references refer to the same object instance (identity).

```cpp
template<typename T>
static void AreSame(
    const T& expected,
    const T& actual,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

#### <a name="BKMK_General_Are_Not_Same"></a> Are Not Same
 Verify that two references do not refer to the same object instance (identity).

```cpp
template<typename T>
static void AreNotSame (
    const T& notExpected,
    const T& actual,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

#### <a name="BKMK_General_Is_Null"></a> Is Null
 Verify that a pointer is NULL.

```cpp
template<typename T>
static void IsNull(
    const T* actual,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

#### <a name="BKMK_General_Is_Not_Null"></a> Is Not Null
 Verify that a pointer is not NULL

```cpp
template<typename T>
static void IsNotNull(
    const T* actual,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

#### <a name="BKMK_General_Is_True"></a> Is True
 Verify that a condition is true

```cpp
static void IsTrue(
    bool condition,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

#### <a name="BKMK_General_Is_False"></a> Is False
 Verify that a condition is false

```cpp
static void IsFalse(
    bool condition,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

#### <a name="BKMK_General_Fail"></a> Fail
 Force the test case result to be failed

```cpp
static void Fail(
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

### <a name="BKMK_WinRT_Asserts"></a> Windows Runtime Asserts

#### <a name="BKMK_WinRT_Are_Equal"></a> Are Equal
 Verifies that two Windows Runtime pointers are equal.

```
template<typename T>
static void AreEqual(
    T^ expected,
    T^ actual,
    Platform::String^ message = nullptr,
    const __LineInfo* pLineInfo= nullptr)
```

 Verifies that two Platform::String^ strings are equal.

```
template<typename T>
static void AreEqual(
    T^ expected,
    T^ actual,
    Platform::String^ message= nullptr,
    const __LineInfo* pLineInfo= nullptr)
```

#### <a name="BKMK_WinRT_Are_Same"></a> Are Same
 Verifies that two Windows Runtime references reference the same object.

```
template<typename T>
static void AreSame(
    T% expected,
    T% actual,
    Platform::String^ message= nullptr,
    const __LineInfo* pLineInfo= nullptr)
```

#### <a name="BKMK_WinRT_Are_Not_Equal"></a> Are Not Equal
 Verifies that two Windows Runtime pointers are not equal.

```
template<typename T>
static void AreNotEqual(
    T^ notExpected,
    T^ actual,
    Platform::String^ message = nullptr,
    const __LineInfo* pLineInfo= nullptr)
```

 Verifies that two Platform::String^ strings are not equal.

```
static void AreNotEqual(
    Platform::String^ notExpected,
    Platform::String^ actual,
    bool ignoreCase = false,
    Platform::String^ message= nullptr,
    const __LineInfo* pLineInfo= nullptr)
```

#### <a name="BKMK_WinRT_Are_Not_Same"></a> Are Not Same
 Verifies that two Windows Runtime references do not reference the same object.

```
template<typename T>
static void AreNotSame(
    T% notExpected,
    T% actual,
    Platform::String^ message= nullptr,
    const __LineInfo* pLineInfo= nullptr)
```

#### <a name="BKMK_WinRT_Is_Null"></a> Is Null
 Verifies that a Windows Runtime pointer is a nullptr.

```
template<typename T>
static void IsNull(
    T^ actual,
    Platform::String^ message = nullptr,
    const __LineInfo* pLineInfo= nullptr)
```

#### <a name="BKMK_WinRT_Is_Not_Null"></a> Is Not Null
 Verifies that a Windows Runtime pointer is not a nullptr.

```
template<typename T>
static void IsNotNull(
    T^ actual,
    Platform::String^ message= nullptr,
    const __LineInfo* pLineInfo= nullptr)
```

### <a name="BKMK_Exception_Asserts"></a> Exception Asserts

#### <a name="BKMK_Expect_Exception"></a> Expect Exception
 Verify that a function raises an exception:

```
template<typename _EXPECTEDEXCEPTION, typename _FUNCTOR>
static void ExpectException(
    _FUNCTOR functor,
    const wchar_t* message= NULL,
    const __LineInfo* pLineInfo= NULL)
```

 Verify that a function raises an exception:

```
template<typename _EXPECTEDEXCEPTION, typename _RETURNTYPE>
    static void ExpectException(
    _RETURNTYPE (*func)(),
    const wchar_t* message= NULL,
    const __LineInfo* pLineInfo = NULL)
```

## <a name="BKMK_CppUnitTestLogger_h"></a> CppUnitTestLogger.h

### <a name="BKMK_Logger"></a> Logger
 The Logger class contains static methods to write to

```
class Logger
```

### <a name="BKMK_Write_Message"></a> Write Message

```
static void
Logger::WriteMessage(const wchar_t* message)
```

```
static void
Logger::WriteMessage(const char* message)
```

## Example
 This code is an example of

```
////////////////////////////////////////////////////////////
/* USAGE EXAMPLE
// The following is an example of VSCppUnit usage.
// It includes examples of attribute metadata, fixtures,
// unit tests with assertions, and custom logging.

#include <CppUnitTest.h>

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

BEGIN_TEST_MODULE_ATTRIBUTE()
    TEST_MODULE_ATTRIBUTE(L"Date", L"2010/6/12")
END_TEST_MODULE_ATTRIBUTE()

TEST_MODULE_INITIALIZE(ModuleInitialize)
{
    Logger::WriteMessage("In Module Initialize");
}

TEST_MODULE_CLEANUP(ModuleCleanup)
{
    Logger::WriteMessage("In Module Cleanup");
}

TEST_CLASS(Class1)
{

public:

    Class1()
    {
        Logger::WriteMessage("In Class1");
    }

    ~Class1()
    {
        Logger::WriteMessage("In ~Class1");
    }

    TEST_CLASS_INITIALIZE(ClassInitialize)
    {
        Logger::WriteMessage("In Class Initialize");
    }

    TEST_CLASS_CLEANUP(ClassCleanup)
    {
        Logger::WriteMessage("In Class Cleanup");
    }

    BEGIN_TEST_METHOD_ATTRIBUTE(Method1)
        TEST_OWNER(L"OwnerName")
        TEST_PRIORITY(1)
    END_TEST_METHOD_ATTRIBUTE()

    TEST_METHOD(Method1)
    {
        Logger::WriteMessage("In Method1");
        Assert::AreEqual(0, 0);
    }

    TEST_METHOD(Method2)
    {
        Assert::Fail(L"Fail");
    }
};
```

## See Also
 [Unit Test Your Code](../test/unit-test-your-code.md)
 [Unit testing native code with Test Explorer](https://msdn.microsoft.com/8a09d6d8-3613-49d8-9ffe-11375ac4736c)
 [Adding unit tests to existing C++ applications](../test/unit-testing-existing-cpp-applications-with-test-explorer.md)
