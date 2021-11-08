---
title: C++ Classes in Class Designer
description: Learn about C++ classes and how they are supported and can have multiple inheritance relationships in Class Designer.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
f1_keywords:
- vs.classdesigner.inheritancelinelabel
helpviewer_keywords:
- Class Designer [Visual Studio], classes
ms.assetid: 75e56f8c-11ef-42a3-b7ec-3d2cf25c581b
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- cplusplus
---
# C++ classes in Class Designer

**Class Designer** supports C++ classes and visualizes native C++ classes in the same way as Visual Basic and C# class shapes, except that C++ classes can have multiple inheritance relationships. You can expand the class shape to show more fields and methods in the class or collapse it to conserve space.

> [!NOTE]
> **Class Designer** does not support unions (a special type of class in which the memory allocated is only the amount necessary for the union's largest data member).

## Simple inheritance

When you drag more than one class onto a class diagram, and the classes have a class inheritance relationship, an arrow connects them. The arrow points in the direction of the base class. For example, when the following classes are displayed in a class diagram, an arrow connects them, pointing from B to A:

```cpp
class A {};
class B : A {};
```

You can also drag only class B to the class diagram, right-click the class shape for B, and then click **Show Base Classes**. This displays its base class: A.

## Multiple inheritance

**Class Designer** supports the visualization of multiple-class inheritance relationships. *Multiple inheritance* is used when a derived class has attributes of more than one base class. Following is an example of multiple inheritance:

```cpp
class Bird {};
class Swimmer {};
class Penguin : public Bird, public Swimmer {};
```

When you drag more than one class onto the class diagram, and the classes have a multiple-class inheritance relationship, an arrow connects them. The arrow points in the direction of the base classes.

Right-clicking a class shape and then clicking **Show Base Classes** displays the base classes for the selected class.

> [!NOTE]
> The **Show Derived Classes** command is not supported for C++ code. You can display derived classes by going to **Class View**, expanding the type node, expanding the **Derived Types** subfolder, and then dragging those types onto the class diagram.

For more information about multiple-class inheritance, see [Multiple Inheritance](/previous-versions/6td5yws2(v=vs.140)) and [Multiple Base Classes](/cpp/cpp/multiple-base-classes).

## Abstract classes

**Class Designer** supports abstract classes (also named "abstract base classes"). These are classes that you never instantiate, but from which you can derive other classes. Using an example from "Multiple Inheritance" earlier in this document, you might instantiate the `Bird` class as individual objects as follows:

```cpp
int main()
{
   Bird sparrow;
   Bird crow;
   Bird eagle;
}
```

However, you might not intend to instantiate the `Swimmer` class as individual objects. You might intend only to derive other types of animal classes from it, for example, `Penguin`, `Whale`, and `Fish`. In that case, you would declare the `Swimmer` class as an abstract base class.

To declare a class as abstract, you can use the `abstract` keyword. Members marked as abstract, or included in an abstract class, are virtual and must be implemented by classes that derive from the abstract class.

```cpp
class Swimmer abstract
{
   virtual void swim();
   void dive();
};
```

You can also declare a class as abstract by including at least one pure virtual function:

```cpp
class Swimmer
{
   virtual void swim() = 0;
   void dive();
};
```

When you display these declarations in a Class Diagram, the class name `Swimmer` and its pure virtual function `swim` are in displayed in italic in an abstract class shape, together with the notation **Abstract Class**. Notice that the abstract class type shape is the same as that of a regular class, except that its border is a dotted line.

A class derived from an abstract base class must override each pure virtual function in the base class, or the derived class cannot be instantiated. So, for example, if you derive a `Fish` class from the `Swimmer` class, `Fish` must override the `swim` method:

```cpp
class Fish : public Swimmer
{
   void swim(int speed);
};

int main()
{
   Fish guppy;
}
```

When you display this code in a Class Diagram, **Class Designer** draws an inheritance line from `Fish` to `Swimmer`.

## Anonymous classes

**Class Designer** supports anonymous classes. *Anonymous class types* are classes declared without an identifier. They cannot have a constructor or destructor, cannot be passed as arguments to functions, and cannot be returned as return values from functions. You can use an anonymous class to replace a class name with a typedef name, as in the following example:

```cpp
typedef struct
{
    unsigned x;
    unsigned y;
} POINT;
```

Structures can also be anonymous. **Class Designer** displays anonymous classes and structures the same as it displays the respective type. Although you can declare and display anonymous classes and structures, **Class Designer** will not use the tag name that you specify. It will use the name that Class View generates. The class or structure appears in Class View and **Class Designer** as an element called **__unnamed**.

For more information about anonymous classes, see [Anonymous Class Types](/cpp/cpp/anonymous-class-types).

## Template classes

**Class Designer** supports the visualization of template classes. Nested declarations are supported. The following table shows some typical declarations.

| Code element | Class Designer view |
| - | - |
| `template <class T>`<br /><br /> `class A {};` | `A<T>`<br /><br /> Template Class |
| `template <class T, class U>`<br /><br /> `class A {};` | `A<T, U>`<br /><br /> Template Class |
| `template <class T, int i>`<br /><br /> `class A {};` | `A<T, i>`<br /><br /> Template Class |
| `template <class T, template <class K> class U>`<br /><br /> `class A {};` | `A<T, U>`<br /><br /> Template Class |

The following table shows some examples of partial specialization.

|Code element|Class Designer view|
|------------------| - |
|`template<class T, class U>`<br /><br /> `class A {};`|`A<T, U>`<br /><br /> Template Class|
|`template<class T>`<br /><br /> `class A<T, T> {};`|`A<T, T>`<br /><br /> Template Class|
|`template <class T>`<br /><br /> `class A<T, int> {};`|`A<T, int>`<br /><br /> Template Class|
|`template <class T1, class T2>`<br /><br /> `class A<T1*, T2*> {};`|`A<T1*, T2*>`<br /><br /> Template Class|

The following table shows some examples of inheritance in partial specialization.

|Code element|Class Designer view|
|------------------| - |
|`template <class T, class U>`<br /><br /> `class A {};`<br /><br /> `template <class TC>`<br /><br /> `class A<T, int> {};`<br /><br /> `class B : A<int, float>`<br /><br /> `{};`<br /><br /> `class C : A<int, int>`<br /><br /> `{};`|`A<T, U>`<br /><br /> Template Class<br /><br /> `B`<br /><br /> Class<br /><br /> (points to Class A)<br /><br /> `C`<br /><br /> Class<br /><br /> (points to Class A)|

The following table shows some examples of partial specialization template functions.

|Code element|Class Designer view|
|------------------| - |
|`class A`<br /><br /> `{`<br /><br /> `template <class T, class U>`<br /><br /> `void func(T a, U b);`<br /><br /> `template <class T>`<br /><br /> `void func(T a, int b);`<br /><br /> `};`|`A`<br /><br /> func\<T, U> (+ 1 overload)|
|`template <class T1>`<br /><br /> `class A {`<br /><br /> `template <class T2>`<br /><br /> `class B {};`<br /><br /> `};`<br /><br /> `template<> template<>`<br /><br /> `class A<type>::B<type> {};`|`A<T1>`<br /><br /> Template Class<br /><br /> `B<T2>`<br /><br /> Template Class<br /><br /> (B is contained within class A under **Nested Types**)|
|`template <class T>`<br /><br /> `class C {};`<br /><br /> `class A : C<int> {};`|`A`<br /><br /> Class<br /><br /> -> C\<int><br /><br /> `C<T>`<br /><br /> Template Class|

The following table shows some examples of template inheritance.

|Code element|Class Designer view|
|------------------| - |
|`template <class T>`<br /><br /> `class C {};`<br /><br /> `template<>`<br /><br /> `class C<int> {`<br /><br /> `class B {};`<br /><br /> `}`<br /><br /> `class A : C<int>::B {};`|`A`<br /><br /> Class<br /><br /> ->B<br /><br /> `C<int>`<br /><br /> Class<br /><br /> (B is contained within class C under **Nested Types**)<br /><br /> `C<T>`<br /><br /> Template Class|

The following table shows some examples of canonical specialized class connection.

|Code element|Class Designer view|
|------------------| - |
|`template <class T>`<br /><br /> `class C {};`<br /><br /> `template<>`<br /><br /> `class C<int> {};`<br /><br /> `class A : C<int> {};`<br /><br /> `class D : C<float> {};`|`A`<br /><br /> Class<br /><br /> ->C\<int><br /><br /> `C<int>`<br /><br /> Class<br /><br /> `C<T>`<br /><br /> Template Class<br /><br /> `D`<br /><br /> Class<br /><br /> ->C\<float>|
|`class B {`<br /><br /> `template <class T>`<br /><br /> `T min (const T &a, const T &b);`<br /><br /> `};`|`B`<br /><br /> min \<T>|

## See also

- [Working with C++ Code](working-with-visual-cpp-code.md)
- [Classes and Structs](/cpp/cpp/classes-and-structs-cpp)
- [Anonymous Class Types](/cpp/cpp/anonymous-class-types)
- [Multiple Inheritance](/previous-versions/6td5yws2(v=vs.140))
- [Multiple Base Classes](/cpp/cpp/multiple-base-classes)
- [Templates](/cpp/cpp/templates-cpp)