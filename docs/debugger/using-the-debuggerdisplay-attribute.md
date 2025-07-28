---
title: Display custom info using DebuggerDisplay
description: Use an instance of DebuggerDisplayAttribute to control how an object, property, or field is displayed in the debugger variable windows.
ms.date: 04/15/2025
ms.topic: how-to
helpviewer_keywords: 
  - attributes, debugger
  - DebuggerDisplay attribute
  - DebuggerDisplayAttribute class
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Tell the debugger what to show using the DebuggerDisplay Attribute (C#, Visual Basic, F#, C++/CLI)

The <xref:System.Diagnostics.DebuggerDisplayAttribute> controls how an object, property, or field is displayed in the debugger variable windows. This attribute can be applied to types (classes, structs, enums, delegates), but is typically applied only to classes and structs. If applied to a base type, the attribute also applies to a subclass.

The `DebuggerDisplay` attribute has a single argument, which is a string to be displayed in the value column for instances of the type. This string can contain braces (`{` and `}`). Text within a pair of braces is evaluated as a field, property or method.

If a class has an overridden `ToString()` method, the debugger uses the overridden method instead of the default `{<typeName>}`. In this case you do not have to use `DebuggerDisplay`. If you use both, the `DebuggerDisplay` attribute takes precedence over the overridden `ToString()` method. The `DebuggerDisplay` attribute also takes precedence over the overridden `ToString()` method in a subclass.

Whether the debugger evaluates this implicit `ToString()` call depends on a user setting in the **Tools / Options / Debugging** dialog box.

> [!IMPORTANT]
> If the **Show raw structure of objects in variables windows** check box is selected in the **Tools / Options / Debugging** dialog box, then the `DebuggerDisplay` attribute is ignored.

> [!NOTE]
> For native code, this attribute is supported only in C++/CLI code.

The following table shows some possible uses of the `DebuggerDisplay` attribute and example outputs.

|Attribute|Output appearing in the Value column|
|---------------| - |
|`[DebuggerDisplay("x = {x} y = {y}")]`<br /><br /> Used on a type with fields `x` and `y`.|`x = 5 y = 18`|
|`[DebuggerDisplay("String value is {getString()}")]`Parameter syntax can vary between languages. Therefore, use it with care.|`String value is [5, 6, 6]`|

`DebuggerDisplay` can also accept named parameters.

|Parameters|Purpose|
|----------------|-------------|
|`Name`, `Type`|These parameters affect the **Name** and **Type** columns of the variable windows. (They can be set to strings using the same syntax as the constructor.) Overusing these parameters, or using them incorrectly, can cause confusing output.|
|`Target`, `TargetTypeName`|Specifies the target type when the attribute is used at the assembly level.|

The *autoexp.cs* file uses the DebuggerDisplay attribute at the assembly level. The *autoexp.cs* file determines the default expansions that Visual Studio uses for .NET objects. You can examine the *autoexp.cs* file for examples of how to use the DebuggerDisplay attribute, or you can modify and compile the autoexp.cs file to change the default expansions. Be sure to back up the *autoexp.cs* file before you modify it.

To build *autoexp.cs*, open up a Developer Command Prompt for VS2015, and run the following commands

```cmd
cd <directory containing autoexp.cs>
csc /t:library autoexp.cs
```

The changes to *autoexp.dll* will be picked up in the next debug session.

## Using Expressions in DebuggerDisplay

Although you can use a general expression between the braces in a DebuggerDisplay attribute, this practice is not recommended.

A general expression in DebuggerDisplay has implicit access to the `this` pointer for the current instance of the target type only. The expression has no access to aliases, locals, or pointers. If the expression references properties, attributes on those properties are not processed. For example, the C# code `[DebuggerDisplay("Object {count - 2}")]` would display `Object 6` if the field `count` was 8.

Using expressions in DebuggerDisplay can lead to the following issues:

- Evaluating expressions is the most expensive operation in the debugger and the expression is evaluated each time it is displayed. This can cause performance issues in stepping through code. For example, a complex expression that is used to display the values in a collection or list can be very slow when the number of elements is large.

- Expressions are evaluated by the expression evaluator of the language of the current stack frame and not by the evaluator of the language in which the expression was written. This can cause unpredictable results when the languages are different.

- Evaluating an expression can change the state of the application. For example, an expression that sets the value of a property mutates the property value in the executing code.

  One way to reduce the possible problems of expression evaluation is by creating a private property that performs the operation and returns a string. The DebuggerDisplay attribute can then display the value of that private property. The following example implements this pattern:

```csharp
[DebuggerDisplay("{DebuggerDisplay,nq}")]
public sealed class MyClass
{
    public int count { get; set; }
    public bool flag { get; set; }
    private string DebuggerDisplay
    {
        get
        {
            return string.Format("Object {0}", count - 2);
        }
    }
}
```

The ",nq" suffix tells the expression evaluator to remove the quotes when displaying the final value (nq = no quotes). For more information on formatters, see [Format specifiers in C#](../debugger/format-specifiers-in-csharp.md).

## Example

The following code example shows how to use `DebuggerDisplay`, together with `DebuggerBrowsable` and `DebuggerTypeProxy`. When viewed in a debugger variables window, such as the **Watch** window, it produces an expansion that looks like this:

|**Name**|**Value**|**Type**|
|--------------|---------------|--------------|
|Key|"three"|object {string}|
|Value|3|object {int}|

```csharp
[DebuggerDisplay("{value}", Name = "{key}")]
internal class KeyValuePairs
{
    private IDictionary dictionary;
    private object key;
    private object value;
    public KeyValuePairs(IDictionary dictionary, object key, object value)
    {
        this.value = value;
        this.key = key;
        this.dictionary = dictionary;
    }

    public object Key
    {
        get { return key; }
        set
        {
            object tempValue = dictionary[key];
            dictionary.Remove(key);
            key = value;
            dictionary.Add(key, tempValue);
        }
    }

    public object Value
    {
        get { return this.value; }
        set
        {
            this.value = value;
            dictionary[key] = this.value;
        }
    }
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
[DebuggerTypeProxy(typeof(HashtableDebugView))]
class MyHashtable
{
    public Hashtable hashtable;

    public MyHashtable()
    {
        hashtable = new Hashtable();
    }

    private string DebuggerDisplay { get { return "Count = " + hashtable.Count; } }

    private class HashtableDebugView
    {
        private MyHashtable myhashtable;
        public HashtableDebugView(MyHashtable myhashtable)
        {
            this.myhashtable = myhashtable;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public KeyValuePairs[] Keys
        {
            get
            {
                KeyValuePairs[] keys = new KeyValuePairs[myhashtable.hashtable.Count];

                int i = 0;
                foreach (object key in myhashtable.hashtable.Keys)
                {
                    keys[i] = new KeyValuePairs(myhashtable.hashtable, key, myhashtable.hashtable[key]);
                    i++;
                }
                return keys;
            }
        }
    }
}
```

## Related content

- [Using DebuggerTypeProxy Attribute](../debugger/using-debuggertypeproxy-attribute.md)
- [Create custom views of managed objects](../debugger/create-custom-views-of-managed-objects.md)
- [Format specifiers in C#](../debugger/format-specifiers-in-csharp.md)
- [Enhancing Debugging with the Debugger Display Attributes](/dotnet/framework/debug-trace-profile/enhancing-debugging-with-the-debugger-display-attributes)
