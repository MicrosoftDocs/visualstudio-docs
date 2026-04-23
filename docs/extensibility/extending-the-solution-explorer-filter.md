---
title: Extending the Solution Explorer Filter
description: Learn how to extend Solution Explorer filter functionality to show or hide different files in the Visual Studio SDK.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- Solution Explorer, extending
- extensibility [Visual Studio], projects and solutions
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Extend the Solution Explorer filter

You can extend **Solution Explorer** filter functionality to show or hide different files. For example, you can create a filter that shows only C# class factory files in the **Solution Explorer**, as this walkthrough demonstrates.

### Create a Visual Studio package project

1. Create a VSIX project named `FileFilter`. Add a custom command item template named **FileFilter**. For more information, see [Create an extension with a menu command](../extensibility/creating-an-extension-with-a-menu-command.md).

2. Add a reference to `System.ComponentModel.Composition` and `Microsoft.VisualStudio.Utilities`.

3. Make the menu command appear on the **Solution Explorer** toolbar. Open the *FileFilterPackage.vsct* file.

4. Change the `<Button>` block to the following:

    ```xml
    <Button guid="guidFileFilterPackageCmdSet" id="FileFilterId" priority="0x0400" type="Button">
        <Parent guid="guidSHLMainMenu" id="IDG_VS_TOOLBAR_PROJWIN_FILTERS" />
        <Icon guid="guidImages" id="bmpPic1" />
        <Strings>
            <ButtonText>FileNameFilter</ButtonText>
        </Strings>
    </Button>
    ```

### Update the manifest file

1. In the *source.extension.vsixmanifest* file, add an asset that is a MEF component.

2. On the **Assets** tab, choose the **New** button.

3. In the **Type** field, choose **Microsoft.VisualStudio.MefComponent**.

4. In the **Source** field, choose **A project in current solution**.

5. In the **Project** field, choose **FileFilter**, and then choose the **OK** button.

### Add the filter code

1. Add some GUIDs to the *FileFilterPackageGuids.cs* file:

    ```csharp
    public const string guidFileFilterPackageCmdSetString = "00000000-0000-0000-0000-00000000"; // get your GUID from the .vsct file
    public const int FileFilterId = 0x100;
    ```

2. Add a class file to the FileFilter project named *FileNameFilter.cs*.

3. Replace the empty namespace and the empty class with the code below.

     The `Task<IReadOnlyObservableSet> GetIncludedItemsAsync(IEnumerable<IVsHierarchyItem rootItems)` method takes the collection that contains the root of the solution (`rootItems`) and returns the collection of items to be included in the filter.

     The `ShouldIncludeInFilter` method filters the items in the **Solution Explorer** hierarchy based on the condition that you specify.

    ```csharp
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using Microsoft.Internal.VisualStudio.PlatformUI;
    using Microsoft.VisualStudio.Shell;

    namespace FileFilter
    {
        // Implements ISolutionTreeFilterProvider. The SolutionTreeFilterProvider attribute declares it as a MEF component
        [SolutionTreeFilterProvider(FileFilterPackageGuids.guidFileFilterPackageCmdSetString, (uint)(FileFilterPackageGuids.FileFilterId))]
        public sealed class FileNameFilterProvider : HierarchyTreeFilterProvider
        {
            SVsServiceProvider svcProvider;
            IVsHierarchyItemCollectionProvider hierarchyCollectionProvider;

            // Constructor required for MEF composition
            [ImportingConstructor]
            public FileNameFilterProvider(SVsServiceProvider serviceProvider, IVsHierarchyItemCollectionProvider hierarchyCollectionProvider)
            {
                this.svcProvider = serviceProvider;
                this.hierarchyCollectionProvider = hierarchyCollectionProvider;
            }

            // Returns an instance of Create filter class.
            protected override HierarchyTreeFilter CreateFilter()
            {
                return new FileNameFilter(this.svcProvider, this.hierarchyCollectionProvider, FileNamePattern);
            }

            // Regex pattern for CSharp factory classes
            private const string FileNamePattern = @"\w*factory\w*(.cs$)";

            // Implementation of file filtering
            private sealed class FileNameFilter : HierarchyTreeFilter
            {
                private readonly Regex regexp;
                private readonly IServiceProvider svcProvider;
                private readonly IVsHierarchyItemCollectionProvider hierarchyCollectionProvider;

                public FileNameFilter(
                    IServiceProvider serviceProvider,
                    IVsHierarchyItemCollectionProvider hierarchyCollectionProvider,
                    string fileNamePattern)
                {
                    this.svcProvider = serviceProvider;
                    this.hierarchyCollectionProvider = hierarchyCollectionProvider;
                    this.regexp = new Regex(fileNamePattern, RegexOptions.IgnoreCase);
                }

                // Gets the items to be included from this filter provider.
                // rootItems is a collection that contains the root of your solution
                // Returns a collection of items to be included as part of the filter
                protected override async Task<IReadOnlyObservableSet> GetIncludedItemsAsync(IEnumerable<IVsHierarchyItem> rootItems)
                {
                    IVsHierarchyItem root = HierarchyUtilities.FindCommonAncestor(rootItems);
                    IReadOnlyObservableSet<IVsHierarchyItem> sourceItems;
                    sourceItems = await hierarchyCollectionProvider.GetDescendantsAsync(
                                        root.HierarchyIdentity.NestedHierarchy,
                                        CancellationToken);

                    IFilteredHierarchyItemSet includedItems = await hierarchyCollectionProvider.GetFilteredHierarchyItemsAsync(
                        sourceItems,
                        ShouldIncludeInFilter,
                        CancellationToken);
                    return includedItems;
                }

                // Returns true if filters hierarchy item name for given filter; otherwise, false</returns>
                private bool ShouldIncludeInFilter(IVsHierarchyItem hierarchyItem)
                {
                    if (hierarchyItem == null)
                    {
                        return false;
                    }
                    return this.regexp.IsMatch(hierarchyItem.Text);
                }
            }
        }
    }

    ```

4. In *FileFilter.cs*, remove the command placement and handling code from the FileFilter constructor. The result should look like this:

    ```csharp
    private FileFilter(Package package)
    {
        if (package == null)
        {
            throw new ArgumentNullException("package");
        }

        this.package = package;
    }
    ```

     Remove the `ShowMessageBox()` method as well.

5. In *FileFilterPackage.cs*, replace the code in the `Initialize()` method with the following:

    ```csharp
    protected override void Initialize()
    {
        Debug.WriteLine (string.Format(CultureInfo.CurrentCulture, "Entering Initialize() of: {0}", this.ToString()));
        base.Initialize();
    }
    ```

### Test your code

1. Build and run the project. A second instance of Visual Studio appears. This is called the experimental instance.

2. In the experimental instance of Visual Studio, open a C# project.

3. Look for the button you added on the **Solution Explorer** toolbar. It should be the fourth button from the left.

4. When you click the button, all the files should be filtered out, and you should see **All items have been filtered from view.** in the **Solution Explorer**.
