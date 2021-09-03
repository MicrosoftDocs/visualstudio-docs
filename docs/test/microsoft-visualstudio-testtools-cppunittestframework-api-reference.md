---
title: "Microsoft.VisualStudio.TestTools.CppUnitTestFramework API"
description: This article describes the CppUnitTestFramework members, which you can use to write C++ unit tests based on the Microsoft Native Unit Test Framework.
ms.custom: SEO-VS-2020
ms.date: 09/27/2019
ms.topic: reference
ms.author: corob
manager: jmartens
ms.technology: vs-ide-test
ms.workload:
  - "multiple"
author: corob-msft
---
# Microsoft.VisualStudio.TestTools.CppUnitTestFramework API reference

This topic lists the public members of the `Microsoft::VisualStudio::CppUnitTestFramework` namespace. Use these APIs to write C++ unit tests based on the Microsoft Native Unit Test Framework. There is a [Usage Example](#example) at the end of the topic.

The header and lib files are located under *\<Visual Studio installation folder>\VC\Auxiliary\VS\UnitTest*.

Header and lib paths are automatically configured in a Native Test project.

## <a name="In_this_topic"></a> In this topic

[CppUnitTest.h](#cppUnitTest_h)

- [Create test classes and methods](#create_test_classes_and_methods)

- [Initialize and cleanup](#Initialize_and_cleanup)

  - [Test methods](#test_methods)

  - [Test classes](#test_classes)

  - [Test modules](#test_modules)

- [Create test attributes](#create_test_attributes)

  - [Test method attributes](#test_method_attributes)

  - [Test class attributes](#test_class_attributes)

  - [Test module attributes](#test_module_attributes)

  - [Pre-defined attributes](#pre_defined_attributes)

    [CppUnitTestAssert.h](#cppUnitTestAssert_h)

  - [General Asserts](#general_asserts)

    - [Are Equal](#general_are_equal)

    - [Are Not Equal](#general_are_not_equal)

    - [Are Same](#general_are_same)

    - [Are Not Same](#general_are_not_same)

    - [Is Null](#general_is_null)

    - [Is Not Null](#general_is_not_null)

    - [Is True](#general_is_True)

    - [Is False](#general_is_false)

    - [Fail](#general_Fail)

  - [Windows Runtime Asserts](#winrt_asserts)

    - [Are Equal](#winrt_are_equal)

    - [Are Same](#winrt_are_same)

    - [Are Not Equal](#winrt_are_not_equal)

    - [Are Not Same](#winrt_are_not_same)

    - [Is Null](#winrt_is_null)

    - [Is Not Null](#winrt_is_not_null)

  - [Exception Asserts](#exception_asserts)

    - [Expect Exception](#expect_exception)

      [CppUnitTestLogger.h](#cppunittestlogger_h)

    - [Logger](#logger)

    - [Write Message](#write_message)

  - [Usage Example](#example)

## <a name="cppUnitTest_h"></a> CppUnitTest.h

### <a name="create_test_classes_and_methods"></a> Create test classes and methods

```cpp
TEST_CLASS(className)
```

Required for each class containing test methods. Identifies *className* as a test class. `TEST_CLASS` must be declared at namespace scope.

```cpp
TEST_METHOD(methodName)
{
    // test method body
}
```

Defines *methodName* as a test method. `TEST_METHOD` must be declared in the scope of the method's class.

### <a name="Initialize_and_cleanup"></a> Initialize and cleanup

#### <a name="test_methods"></a> Test methods

```cpp
TEST_METHOD_INITIALIZE(methodName)
{
    // method initialization code
}
```

Defines *methodName* as a method that runs before each test method is run. `TEST_METHOD_INITIALIZE` can only be defined once in a test class and must be defined in the scope of the test class.

```cpp
TEST_METHOD_CLEANUP(methodName)
{
    // test method cleanup  code
}
```

Defines *methodName* as a method that runs after each test method is run. `TEST_METHOD_CLEANUP` can only be defined once in a test class and must be defined in the scope of the test class.

#### <a name="test_classes"></a> Test classes

```cpp
TEST_CLASS_INITIALIZE(methodName)
{
    // test class initialization  code
}
```

Defines *methodName* as a method that runs before each test class is created. `TEST_CLASS_INITIALIZE` can only be defined once in a test class and must be defined in the scope of the test class.

```cpp
TEST_CLASS_CLEANUP(methodName)
{
    // test class cleanup  code
}
```

Defines *methodName* as a method that runs after each test class is created. `TEST_CLASS_CLEANUP` can only be defined once in a test class and must be defined in the scope of the test class.

#### <a name="test_modules"></a> Test modules

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

### <a name="create_test_attributes"></a> Create test attributes

#### <a name="test_method_attributes"></a> Test method attributes

```cpp
BEGIN_TEST_METHOD_ATTRIBUTE(testMethodName)
    TEST_METHOD_ATTRIBUTE(attributeName, attributeValue)
    ...
END_TEST_METHOD_ATTRIBUTE()
```

Adds the attributes defined with one or more `TEST_METHOD_ATTRIBUTE` macros to the test method *testMethodName*.

A `TEST_METHOD_ATTRIBUTE` macro defines an attribute with the name *attributeName* and the value *attributeValue*.

#### <a name="test_class_attributes"></a> Test class attributes

```cpp
BEGIN_TEST_CLASS_ATTRIBUTE(testClassName)
    TEST_CLASS_ATTRIBUTE(attributeName, attributeValue)
    ...
END_TEST_CLASS_ATTRIBUTE()
```

Adds the attributes defined with one or more `TEST_CLASS_ATTRIBUTE` macros to the test class *testClassName*.

A `TEST_CLASS_ATTRIBUTE` macro defines an attribute with the name *attributeName* and the value *attributeValue*.

#### <a name="test_module_attributes"></a> Test module attributes

```cpp
BEGIN_TEST_MODULE_ATTRIBUTE(testModuleName)
    TEST_MODULE_ATTRIBUTE(attributeName, attributeValue)
    ...
END_TEST_MODULE_ATTRIBUTE()
```

Adds the attributes defined with one or more `TEST_MODULE_ATTRIBUTE` macros to the test module *testModuleName*.

A `TEST_MODULE_ATTRIBUTE` macro defines an attribute with the name *attributeName* and the value *attributeValue*.

#### <a name="pre_defined_attributes"></a> Pre-defined attributes

These pre-defined attribute macros are provided as a convenience for common cases. They can be substituted for the macro `TEST_METHOD_ATTRIBUTE` described above.

```cpp
TEST_OWNER(ownerAlias)
```

Defines a `TEST_METHOD_ATTRIBUTE` with the name `Owner` and the attribute value of *ownerAlias*.

```cpp
TEST_DESCRIPTION(description)
```

Defines a `TEST_METHOD_ATTRIBUTE` with the name `Description` and the attribute value of *description*.

```cpp
TEST_PRIORITY(priority)
```

Defines a `TEST_METHOD_ATTRIBUTE` with the name `Priority` and the attribute value of *priority*.

```cpp
TEST_WORKITEM(workitem)
```

Defines a `TEST_METHOD_ATTRIBUTE` with the name `WorkItem` and the attribute value of *workItem*.

```cpp
TEST_IGNORE()
```

Defines a `TEST_METHOD_ATTRIBUTE` with the name `Ignore` and the attribute value of `true`.

## <a name="cppUnitTestAssert_h"></a> CppUnitTestAssert.h

### <a name="general_asserts"></a> General Asserts

#### <a name="general_are_equal"></a> Are Equal
Verify that two objects are equal

```cpp
template<typename T>
static void Assert::AreEqual(
    const T& expected,
    const T& actual,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

Verify that two doubles are equal

```cpp
static void Assert::AreEqual(
    double expected,
    double actual,
    double tolerance,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

Verify that two floats are equal

```cpp
static void Assert::AreEqual(
    float expected,
    float actual,
    float tolerance,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

Verify that two char* strings are equal

```cpp
static void Assert::AreEqual(
    const char* expected,
    const char* actual,
    bool ignoreCase = false,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

Verify that two w_char* strings are equal

```cpp
static void Assert::AreEqual(
    const wchar_t* expected,
    const wchar_t* actual,
    bool ignoreCase = false,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

#### <a name="general_are_not_equal"></a> Are Not Equal
Verify that two doubles are not equal

```cpp
static void Assert::AreNotEqual(
    double notExpected,
    double actual,
    double tolerance,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

Verify that two floats are not equal

```cpp
static void Assert::AreNotEqual(
    float notExpected,
    float actual,
    float tolerance,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

Verify that two char* strings are not equal

```cpp
static void Assert::AreNotEqual(
    const char* notExpected,
    const char* actual,
    bool ignoreCase = false,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

Verify that two w_char* strings are not equal

```cpp
static void Assert::AreNotEqual(
    const wchar_t* notExpected,
    const wchar_t* actual,
    bool ignoreCase = false,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

Verify that two references are not equal based on operator==.

```cpp
template<typename T>
static void Assert::AreNotEqual(
    const T& notExpected,
    const T& actual,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

#### <a name="general_are_same"></a> Are Same
Verify that two references refer to the same object instance (identity).

```cpp
template<typename T>
static void Assert::AreSame(
    const T& expected,
    const T& actual,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

#### <a name="general_are_not_same"></a> Are Not Same
Verify that two references do not refer to the same object instance (identity).

```cpp
template<typename T>
static void Assert::AreNotSame (
    const T& notExpected,
    const T& actual,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

#### <a name="general_is_null"></a> Is Null
Verify that a pointer is NULL.

```cpp
template<typename T>
static void Assert::IsNull(
    const T* actual,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

#### <a name="general_is_not_null"></a> Is Not Null
Verify that a pointer is not NULL

```cpp
template<typename T>
static void Assert::IsNotNull(
    const T* actual,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

#### <a name="general_is_True"></a> Is True
Verify that a condition is true

```cpp
static void Assert::IsTrue(
    bool condition,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

#### <a name="general_is_false"></a> Is False
Verify that a condition is false

```cpp
static void Assert::IsFalse(
    bool condition,
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

#### <a name="general_Fail"></a> Fail
Force the test case result to be failed

```cpp
static void Assert::Fail(
    const wchar_t* message = NULL,
    const __LineInfo* pLineInfo = NULL)
```

### <a name="winrt_asserts"></a> Windows Runtime Asserts

#### <a name="winrt_are_equal"></a> Are Equal
Verifies that two Windows Runtime pointers are equal.

```cpp
template<typename T>
static void Assert::AreEqual(
    T^ expected,
    T^ actual,
    Platform::String^ message = nullptr,
    const __LineInfo* pLineInfo= nullptr)
```

Verifies that two Platform::String^ strings are equal.

```cpp
template<typename T>
static void Assert::AreEqual(
    T^ expected,
    T^ actual,
    Platform::String^ message= nullptr,
    const __LineInfo* pLineInfo= nullptr)
```

#### <a name="winrt_are_same"></a> Are Same
Verifies that two Windows Runtime references reference the same object.

```cpp
template<typename T>
static void Assert::AreSame(
    T% expected,
    T% actual,
    Platform::String^ message= nullptr,
    const __LineInfo* pLineInfo= nullptr)
```

#### <a name="winrt_are_not_equal"></a> Are Not Equal
Verifies that two Windows Runtime pointers are not equal.

```cpp
template<typename T>
static void Assert::AreNotEqual(
    T^ notExpected,
    T^ actual,
    Platform::String^ message = nullptr,
    const __LineInfo* pLineInfo= nullptr)
```

Verifies that two Platform::String^ strings are not equal.

```cpp
static void Assert::AreNotEqual(
    Platform::String^ notExpected,
    Platform::String^ actual,
    bool ignoreCase = false,
    Platform::String^ message= nullptr,
    const __LineInfo* pLineInfo= nullptr)
```

#### <a name="winrt_are_not_same"></a> Are Not Same
Verifies that two Windows Runtime references do not reference the same object.

```cpp
template<typename T>
static void Assert::AreNotSame(
    T% notExpected,
    T% actual,
    Platform::String^ message= nullptr,
    const __LineInfo* pLineInfo= nullptr)
```

#### <a name="winrt_is_null"></a> Is Null
Verifies that a Windows Runtime pointer is a nullptr.

```cpp
template<typename T>
static void Assert::IsNull(
    T^ actual,
    Platform::String^ message = nullptr,
    const __LineInfo* pLineInfo= nullptr)
```

#### <a name="winrt_is_not_null"></a> Is Not Null
Verifies that a Windows Runtime pointer is not a nullptr.

```cpp
template<typename T>
static void Assert::IsNotNull(
    T^ actual,
    Platform::String^ message= nullptr,
    const __LineInfo* pLineInfo= nullptr)
```

### <a name="exception_asserts"></a> Exception Asserts

#### <a name="expect_exception"></a> Expect Exception
Verify that a function raises an exception:

```cpp
template<typename _EXPECTEDEXCEPTION, typename _FUNCTOR>
static void Assert::ExpectException(
    _FUNCTOR functor,
    const wchar_t* message= NULL,
    const __LineInfo* pLineInfo= NULL)
```

Verify that a function raises an exception:

```cpp
template<typename _EXPECTEDEXCEPTION, typename _RETURNTYPE>
    static void Assert::ExpectException(
    _RETURNTYPE (*func)(),
    const wchar_t* message= NULL,
    const __LineInfo* pLineInfo = NULL)
```

## <a name="cppunittestlogger_h"></a> CppUnitTestLogger.h

### <a name="logger"></a> Logger
The Logger class contains static methods to write to the **Output Window**.

### <a name="write_message"></a> Write Message
Write a string to the **Output Window**

```cpp
static void Logger::WriteMessage(const wchar_t* message)
```

```cpp
static void Logger::WriteMessage(const char* message)
```

## <a name="example"></a> Example
This code is an example of VSCppUnit usage. It includes examples of attribute metadata, fixtures, unit tests with assertions, and custom logging.

```cpp
// USAGE EXAMPLE

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

## See also

- [Unit test your code](../test/unit-test-your-code.md)
- [Write unit tests for C/C++](writing-unit-tests-for-c-cpp.md)
