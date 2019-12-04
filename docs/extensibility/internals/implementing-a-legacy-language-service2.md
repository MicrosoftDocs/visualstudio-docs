---
title: "Implementing a Legacy Language Service2 | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "language services [managed package framework], implementing"
ms.assetid: 5bcafdc5-f922-48f6-a12e-6c8507a79a05
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Implementing a Legacy Language Service
To implement a language service using the managed package framework (MPF), you must derive a class from the <xref:Microsoft.VisualStudio.Package.LanguageService> class and implement the following abstract methods and properties:

- The <xref:Microsoft.VisualStudio.Package.LanguageService.GetLanguagePreferences%2A> method

- The <xref:Microsoft.VisualStudio.Package.LanguageService.GetScanner%2A> method

- The <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method

- The <xref:Microsoft.VisualStudio.Package.LanguageService.Name%2A> property

  See the appropriate sections below for details on implementing these methods and properties.

  To support additional features, your language service may have to derive a class from one of the MPF language service classes; for example, to support additional menu commands, you must derive a class from the <xref:Microsoft.VisualStudio.Package.ViewFilter> class and override several of the command handling methods (see <xref:Microsoft.VisualStudio.Package.ViewFilter> for details). The <xref:Microsoft.VisualStudio.Package.LanguageService> class provides a number of methods that are called to create new instances of various classes and you override the appropriate creation method to provide an instance of your class. For example, you need to override the <xref:Microsoft.VisualStudio.Package.LanguageService.CreateViewFilter%2A> method in the <xref:Microsoft.VisualStudio.Package.LanguageService> class to return an instance of your own <xref:Microsoft.VisualStudio.Package.ViewFilter> class. See the "Instantiating Custom Classes" section for more details.

  Your language service can also supply its own icons, which are used in many places. For example, when an IntelliSense completion list is shown, each item in the list can have an icon associated with it, marking the item as a method, class, namespace, property, or whatever is necessary for your language. These icons are used in all IntelliSense lists, the **Navigation bar**, and in the **Error List** task window. See the "Language Service Images" section below for details.

## GetLanguagePreferences Method
 The <xref:Microsoft.VisualStudio.Package.LanguageService.GetLanguagePreferences%2A> method always returns the same instance of a <xref:Microsoft.VisualStudio.Package.LanguagePreferences> class. You can use the base <xref:Microsoft.VisualStudio.Package.LanguagePreferences> class if you do not need any additional preferences for your language service. The MPF language service classes assume the presence of at least the base <xref:Microsoft.VisualStudio.Package.LanguagePreferences> class.

### Example
 This example shows a typical implementation of the <xref:Microsoft.VisualStudio.Package.LanguageService.GetLanguagePreferences%2A> method. This example uses the base <xref:Microsoft.VisualStudio.Package.LanguagePreferences> class.

```csharp
using Microsoft.VisualStudio.Package;
using Microsoft.VisualStudio.TextManager.Interop;

namespace TestLanguagePackage
{
    public class TestLanguageService : LanguageService
    {
        private LanguagePreferences m_preferences;

        public override LanguagePreferences GetLanguagePreferences()
        {
            if (m_preferences == null)
            {
                m_preferences = new LanguagePreferences(this.Site,
                                                        typeof(TestLanguageService).GUID,
                                                        this.Name );
                m_preferences.Init();
            }
            return m_preferences;
        }
    }
}
```

## GetScanner Method
 This method returns an instance of an <xref:Microsoft.VisualStudio.Package.IScanner> object that implements a line-oriented parser or scanner used for obtaining tokens and their types and triggers. This scanner is used in the <xref:Microsoft.VisualStudio.Package.Colorizer> class for colorization although the scanner can also be used for getting token types and triggers as a prelude to a more complex parsing operation. You must supply the class that implements the <xref:Microsoft.VisualStudio.Package.IScanner> interface and you must implement all the methods on the <xref:Microsoft.VisualStudio.Package.IScanner> interface.

### Example
 This example shows a typical implementation of the <xref:Microsoft.VisualStudio.Package.LanguageService.GetScanner%2A> method. The `TestScanner` class implements the <xref:Microsoft.VisualStudio.Package.IScanner> interface (not shown).

```csharp
using Microsoft.VisualStudio.Package;
using Microsoft.VisualStudio.TextManager.Interop;

namespace TestLanguagePackage
{
    public class TestLanguageService : LanguageService
    {
        private TestScanner m_scanner;

        public override IScanner GetScanner(IVsTextLines buffer)
        {
            if (m_scanner == null)
            {
                m_scanner = new TestScanner(buffer);
            }
            return m_scanner;
        }
    }
}
    internal class TestScanner : IScanner
    {
        private IVsTextBuffer m_buffer;
        string m_source;

        public TestScanner(IVsTextBuffer buffer)
        {
            m_buffer = buffer;
        }

        bool IScanner.ScanTokenAndProvideInfoAboutIt(TokenInfo tokenInfo, ref int state)
        {
            tokenInfo.Type = TokenType.Unknown;
            tokenInfo.Color = TokenColor.Text;
            return true;
        }

        void IScanner.SetSource(string source, int offset)
        {
            m_source = source.Substring(offset);
        }
    }

```

## ParseSource Method
 Parses the source file based on a number of different reasons. This method is given a <xref:Microsoft.VisualStudio.Package.ParseRequest> object that describes what is expected from a particular parsing operation. The <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method invokes a more complex parser that determines token functionality and scope. The <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method is used in support for IntelliSense operations as well as brace matching. Even if you do not support such advanced operations, you still must return a valid <xref:Microsoft.VisualStudio.Package.AuthoringScope> object and that requires you to create a class that implements the <xref:Microsoft.VisualStudio.Package.AuthoringScope> interface and implement all methods on that interface. You can return null values from all methods but the <xref:Microsoft.VisualStudio.Package.AuthoringScope> object itself must not be a null value.

### Example
 This example shows a minimal implementation of the <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method and the <xref:Microsoft.VisualStudio.Package.AuthoringScope> class, sufficient to allow the language service to compile and function without actually supporting any of the more advanced features.

```csharp
using Microsoft.VisualStudio.Package;
using Microsoft.VisualStudio.TextManager.Interop;

namespace TestLanguagePackage
{
    public class TestLanguageService : LanguageService
    {
        public override AuthoringScope ParseSource(ParseRequest req)
        {
            return new TestAuthoringScope();
        }
    }

    internal class TestAuthoringScope : AuthoringScope
    {
        public override string GetDataTipText(int line, int col, out TextSpan span)
        {
            span = new TextSpan();
            return null;
        }

        public override Declarations GetDeclarations(IVsTextView view,
                                                     int line,
                                                     int col,
                                                     TokenInfo info,
                                                     ParseReason reason)
        {
            return null;
        }

        public override string Goto(VSConstants.VSStd97CmdID cmd, IVsTextView textView, int line, int col, out TextSpan span)
        {
            span = new TextSpan();
            return null;
        }

        public override Methods GetMethods(int line, int col, string name)
        {
            return null;
        }
}
```

## Name Property
 This property returns the name of the language service. This must be the same name given when the language service was registered. This name is used in a number of places, the most prominent of which is the <xref:Microsoft.VisualStudio.Package.LanguagePreferences> class where the name is used to access the registry. The name returned by this property must not be localized as it is used in the registry for registry entry and key names.

### Example
 This example shows one possible implementation of the <xref:Microsoft.VisualStudio.Package.LanguageService.Name%2A> property. Note that the name here is hard-coded: the actual name should be obtained from a resource file so it can be used in registering a language service (see [Registering a Legacy Language Service](../../extensibility/internals/registering-a-legacy-language-service1.md)).

```csharp
using Microsoft.VisualStudio.Package;
using Microsoft.VisualStudio.TextManager.Interop;

namespace TestLanguagePackage
{
    public class TestLanguageService : LanguageService
    {
        public override string Name
        {
            get { return "Test Language"; }
        }
    }
}
```

## Instantiating Custom Classes
 The following methods in the specified classes can be overridden to provide instances of your own versions of each class.

### In the LanguageService Class

|Method|Class Returned|Description|
|------------|--------------------|-----------------|
|<xref:Microsoft.VisualStudio.Package.LanguageService.CreateCodeWindowManager%2A>|<xref:Microsoft.VisualStudio.Package.CodeWindowManager>|To support custom additions to the text view.|
|<xref:Microsoft.VisualStudio.Package.LanguageService.CreateDocumentProperties%2A>|<xref:Microsoft.VisualStudio.Package.DocumentProperties>|To support custom document properties.|
|<xref:Microsoft.VisualStudio.Package.LanguageService.CreateDropDownHelper%2A>|<xref:Microsoft.VisualStudio.Package.TypeAndMemberDropdownBars>|To support the **Navigation bar**.|
|<xref:Microsoft.VisualStudio.Package.LanguageService.CreateExpansionFunction%2A>|<xref:Microsoft.VisualStudio.Package.ExpansionFunction>|To support functions in code snippet templates.|
|<xref:Microsoft.VisualStudio.Package.LanguageService.CreateExpansionProvider%2A>|<xref:Microsoft.VisualStudio.Package.ExpansionProvider>|To support code snippets (this method is typically not overridden).|
|<xref:Microsoft.VisualStudio.Package.LanguageService.CreateParseRequest%2A>|<xref:Microsoft.VisualStudio.Package.ParseRequest>|To support customization of the <xref:Microsoft.VisualStudio.Package.ParseRequest> structure (this method is typically not overridden).|
|<xref:Microsoft.VisualStudio.Package.LanguageService.CreateSource%2A>|<xref:Microsoft.VisualStudio.Package.Source>|To support formatting source code, specifying comment characters, and customizing method signatures.|
|<xref:Microsoft.VisualStudio.Package.LanguageService.CreateViewFilter%2A>|<xref:Microsoft.VisualStudio.Package.ViewFilter>|To support additional menu commands.|
|<xref:Microsoft.VisualStudio.Package.Source.GetColorizer%2A>|<xref:Microsoft.VisualStudio.Package.Colorizer>|To support syntax highlighting (this method is typically not overridden).|
|<xref:Microsoft.VisualStudio.Package.LanguageService.GetLanguagePreferences%2A>|<xref:Microsoft.VisualStudio.Package.LanguagePreferences>|To support access to language preferences. This method must be implemented but can return an instance of the base class.|
|<xref:Microsoft.VisualStudio.Package.LanguageService.GetScanner%2A>|<xref:Microsoft.VisualStudio.Package.IScanner>|To provide a parser used for identifying types of tokens on a line. This method must be implemented and <xref:Microsoft.VisualStudio.Package.IScanner> must be derived from.|
|<xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A>|<xref:Microsoft.VisualStudio.Package.AuthoringScope>|To provide a parser used for identifying functionality and scope throughout an entire source file. This method must be implemented and must return an instance of your version of the <xref:Microsoft.VisualStudio.Package.AuthoringScope> class. If all you want to support is syntax highlighting (which requires the <xref:Microsoft.VisualStudio.Package.IScanner> parser returned from the <xref:Microsoft.VisualStudio.Package.LanguageService.GetScanner%2A> method), you can do nothing in this method other than return a version of the <xref:Microsoft.VisualStudio.Package.AuthoringScope> class whose methods all return null values.|

### In the Source Class

|Method|Class Returned|Description|
|------------|--------------------|-----------------|
|<xref:Microsoft.VisualStudio.Package.Source.CreateCompletionSet%2A>|<xref:Microsoft.VisualStudio.Package.CompletionSet>|For customizing the display of IntelliSense completion lists (this method is typically not overridden).|
|<xref:Microsoft.VisualStudio.Package.Source.CreateErrorTaskItem%2A>|<xref:Microsoft.VisualStudio.Package.DocumentTask>|For supporting markers in the Error List task list; specifically, support for features beyond opening the file and jumping to the line that caused the error.|
|<xref:Microsoft.VisualStudio.Package.Source.CreateMethodData%2A>|<xref:Microsoft.VisualStudio.Package.MethodData>|For customizing the display of IntelliSense Parameter Info ToolTips.|
|<xref:Microsoft.VisualStudio.Package.Source.GetCommentFormat%2A>|<xref:Microsoft.VisualStudio.Package.CommentInfo>|For supporting commenting code.|
|<xref:Microsoft.VisualStudio.Package.Source.CreateAuthoringSink%2A>|<xref:Microsoft.VisualStudio.Package.AuthoringSink>|For gathering information during the parse operation.|

### In the AuthoringScope Class

|Method|Class Returned|Description|
|------------|--------------------|-----------------|
|<xref:Microsoft.VisualStudio.Package.AuthoringScope.GetDeclarations%2A>|<xref:Microsoft.VisualStudio.Package.Declarations>|Provides a list of declarations such as members or types. This method must be implemented but can return a null value. If this method returns a valid object, the object must be an instance of your version of the <xref:Microsoft.VisualStudio.Package.Declarations> class.|
|<xref:Microsoft.VisualStudio.Package.AuthoringScope.GetMethods%2A>|<xref:Microsoft.VisualStudio.Package.Methods>|Provides a list of method signatures for a given context. This method must be implemented but can return a null value. If this method returns a valid object, the object must be an instance of your version of the <xref:Microsoft.VisualStudio.Package.Methods> class.|

## Language Service Images
 To provide a list of icons to be used throughout the language service, override the <xref:Microsoft.VisualStudio.Package.LanguageService.GetImageList%2A> method in the <xref:Microsoft.VisualStudio.Package.LanguageService> class and return an <xref:System.Windows.Forms.ImageList> containing the icons. The base <xref:Microsoft.VisualStudio.Package.LanguageService> class loads a default set of icons. Since you specify the exact image index in those places that need icons, how you arrange your own image list is entirely up to you.

### Images Used In IntelliSense Completion Lists
 For IntelliSense completion lists, the image index is specified for each item in the <xref:Microsoft.VisualStudio.Package.Declarations.GetGlyph%2A> method of the <xref:Microsoft.VisualStudio.Package.Declarations> class, which you must override if you want to supply an image index. The value returned from the <xref:Microsoft.VisualStudio.Package.Declarations.GetGlyph%2A> method is an index into the image list supplied to the <xref:Microsoft.VisualStudio.Package.CompletionSet> class constructor and that is the same image list returned from the <xref:Microsoft.VisualStudio.Package.LanguageService.GetImageList%2A> method in the <xref:Microsoft.VisualStudio.Package.LanguageService> class (you can change which image list to use for the <xref:Microsoft.VisualStudio.Package.CompletionSet> if you override the <xref:Microsoft.VisualStudio.Package.Source.CreateCompletionSet%2A> method in the <xref:Microsoft.VisualStudio.Package.Source> class to supply a different image list).

### Images Used in the Navigation Bar
 The **Navigation bar** displays lists of types and members and is used for quick navigation can show icons. These icons are obtained from the <xref:Microsoft.VisualStudio.Package.LanguageService.GetImageList%2A> method in the <xref:Microsoft.VisualStudio.Package.LanguageService> class and cannot be overridden specifically for the **Navigation bar**. The indices used for each item in the combo-boxes are specified when the lists representing the combo-boxes are filled in the <xref:Microsoft.VisualStudio.Package.TypeAndMemberDropdownBars.OnSynchronizeDropdowns%2A> method in the <xref:Microsoft.VisualStudio.Package.TypeAndMemberDropdownBars> class (see [Support for the Navigation Bar in a Legacy Language Service](../../extensibility/internals/support-for-the-navigation-bar-in-a-legacy-language-service.md)). These image indices are obtained somehow from the parser, typically through your version of the <xref:Microsoft.VisualStudio.Package.Declarations> class. How the indices are obtained is entirely up to you.

### Images Used in the Error List Task Window
 Whenever the <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method parser (see [Legacy Language Service Parser and Scanner](../../extensibility/internals/legacy-language-service-parser-and-scanner.md)) encounters an error and passes that error to the <xref:Microsoft.VisualStudio.Package.AuthoringSink.AddError%2A> method in the <xref:Microsoft.VisualStudio.Package.AuthoringSink> class, the error is reported in the **Error List** task window. An icon can be associated with each item that appears in the task window and that icon comes from the same image list returned from the <xref:Microsoft.VisualStudio.Package.LanguageService.GetImageList%2A> method in the <xref:Microsoft.VisualStudio.Package.LanguageService> class. The default behavior of the MPF classes is to not show an image with the error message. However, you can override this behavior by deriving a class from the <xref:Microsoft.VisualStudio.Package.Source> class and overriding the <xref:Microsoft.VisualStudio.Package.Source.CreateErrorTaskItem%2A> method. In that method, you create a new <xref:Microsoft.VisualStudio.Package.DocumentTask> object. Before returning that object, you can use the <xref:Microsoft.VisualStudio.Shell.Task.ImageIndex%2A> property on the <xref:Microsoft.VisualStudio.Package.DocumentTask> object to set the image index. This would look something like the following example. Note that `TestIconImageIndex` is an enumeration that lists all icons and is specific to this example. You may have a different way of identifying icons in your language service.

```csharp
using Microsoft.VisualStudio.Package;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.TextManager.Interop;

namespace TestLanguagePackage
{
    class TestSource : Source
    {
        public override DocumentTask CreateErrorTaskItem(
            TextSpan          span,
            string            filename,
            string            message,
            TaskPriority      priority,
            TaskCategory      category,
            MARKERTYPE        markerType,
            TaskErrorCategory errorCategory)
        {
            DocumentTask taskItem = base.CreateErrorTaskItem(
                                           span,
                                           filename,
                                           message,
                                           priority,
                                           category,
                                           markerType,
                                           errorCategory);
            if (errorCategory == TaskErrorCategory.Error)
            {
                taskItem.ImageIndex = TestIconImageIndex.Error;
            }
            return taskItem;
        }
    }
}
```

## The Default Image List for a Language Service
 The default image list supplied with the base MPF language service classes contains a number of icons associated with the more common language elements. The bulk of these icons are arranged in sets of six variations, corresponding to the access concepts of public, internal, friend, protected, private, and shortcut. For example, you can have different icons for a method depending on whether it is public, protected or private.

 The following enumeration specifies typical names for each icon set and specifies the associated index. For example, based on the enumeration, you can specify the image index for a protected method as `(int)IconImageIndex.Method + (int)IconImageIndex.AccessProtected`. You can change the names in this enumeration as desired.

```csharp
public enum IconImageIndex
        {
            // access types
            AccessPublic = 0,
            AccessInternal = 1,
            AccessFriend = 2,
            AccessProtected = 3,
            AccessPrivate = 4,
            AccessShortcut = 5,

            Base = 6,
            // Each of the following icon type has 6 versions,
            //corresponding to the access types
            Class = Base + 0,
            Constant = Base + 1,
            Delegate = Base + 2,
            Enumeration = Base + 3,
            EnumMember = Base + 4,
            Event = Base + 5,
            Exception = Base + 6,
            Field = Base + 7,
            Interface = Base + 8,
            Macro = Base + 9,
            Map = Base + 10,
            MapItem = Base + 11,
            Method = Base + 12,
            OverloadedMethod = Base + 13,
            Module = Base + 14,
            Namespace = Base + 15,
            Operator = Base + 16,
            Property = Base + 17,
            Struct = Base + 18,
            Template = Base + 19,
            Typedef = Base + 20,
            Type = Base + 21,
            Union = Base + 22,
            Variable = Base + 23,
            ValueType = Base + 24,
            Intrinsic = Base + 25,
            JavaMethod = Base + 26,
            JavaField = Base + 27,
            JavaClass = Base + 28,
            JavaNamespace = Base + 29,
            JavaInterface = Base + 30,
            // Miscellaneous icons with one icon for each type.
            Error = 187,
            GreyedClass = 188,
            GreyedPrivateMethod = 189,
            GreyedProtectedMethod = 190,
            GreyedPublicMethod = 191,
            BrowseResourceFile = 192,
            Reference = 193,
            Library = 194,
            VBProject = 195,
            VBWebProject = 196,
            CSProject = 197,
            CSWebProject = 198,
            VB6Project = 199,
            CPlusProject = 200,
            Form = 201,
            OpenFolder = 202,
            ClosedFolder = 203,
            Arrow = 204,
            CSClass = 205,
            Snippet = 206,
            Keyword = 207,
            Info = 208,
            CallBrowserCall = 209,
            CallBrowserCallRecursive = 210,
            XMLEditor = 211,
            VJProject = 212,
            VJClass = 213,
            ForwardedType = 214,
            CallsTo = 215,
            CallsFrom = 216,
            Warning = 217,
        }
```

## See also
- [Implementing a Legacy Language Service](../../extensibility/internals/implementing-a-legacy-language-service1.md)
- [Legacy Language Service Overview](../../extensibility/internals/legacy-language-service-overview.md)
- [Registering a Legacy Language Service](../../extensibility/internals/registering-a-legacy-language-service1.md)
- [Legacy Language Service Parser and Scanner](../../extensibility/internals/legacy-language-service-parser-and-scanner.md)