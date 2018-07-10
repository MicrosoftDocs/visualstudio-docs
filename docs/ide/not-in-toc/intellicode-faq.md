---
title: IntelliCode questions and answers
ms.date: 05/22/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: conceptual
manager: douge
author: markw-t
ms.author: mwthomas
---
# Visual Studio IntelliCode FAQ

Thanks for your interest in Visual Studio IntelliCode! This short FAQ will hopefully answer some of the questions you may have.

## Q. What is Visual Studio IntelliCode?

At Build 2018, Microsoft announced Visual Studio IntelliCode, a new capability that enhances software development using AI. IntelliCode helps developers and teams code with confidence, find issues faster, and focus code reviews.

An early view of how IntelliCode showed how it enhances the software development process in the following ways:

- Delivers context-aware code completions
- Guides developers to adhere to the patterns and styles of their team
- Finds difficult-to-catch code issues
- Focuses code reviews by drawing attention to areas that really matter

Developers can find more information and sign up for news and future private previews at [https://aka.ms/intellicode](https://aka.ms/intellicode).

## Q. What does Visual Studio IntelliCode enable customers to do?

Visual Studio IntelliCode is a range of capabilities that offers new productivity enhancements through artificial intelligence (AI).

Developers can [download an experimental extension](https://go.microsoft.com/fwlink/?linkid=872707) for Visual Studio 2017 version 15.7 and later. The extension currently provides: 

- AI-Enhanced IntelliSense that predicts the most likely correct API for the developer to use, rather than just presenting an alphabetical list of members. It uses the developer's current code context and patterns to provide this dynamic list.

- Inference of code style and formatting conventions  that helps you keep your code consistent by dynamically creating an [.editorconfig file](../ide/create-portable-custom-editor-options) from your codebase to define coding styles and formats. These conventions allow Visual Studio to offer automatic style and format fixes to clean up your document.

We'll update the extension with more capabilities in the coming months.

## Q. Why does EditorConfig inference prepend a 1 to the filename? 

A known issue in Visual Studio extensibility will cause a 1. to be prepended to the .editorconfig filename  when you create it by right-clicking and choosing **Add > New Item**. Files named in this way are not recognized by the editorconfig processor in Visual Studio. This problem is fixed in Visual Studio 2017 version 15.8 Preview 4, but until then you can work around by removing the 1 in the **Add New Item** dialog.

## Q. I don't see my EditorConfig Conventions taking effect - why?
There are a couple of common reasons this problem can occur:

- In Visual Studio 2017 versions prior to 15.8 Preview 3, you will need to close and reopen all open documents to see the conventions in the EditorConfig file you create take effect. This issue is fixed in the 15.8 Preview 3 release.
- Formatting conventions never show up in the **Error List** or as “squiggles” in your code. They can, however, be fixed using the new Format Document (Ctrl+K, Ctrl+D) extension in Visual Studio 2017 version 15.8 Preview 3 or later

## Q. Format Document is not fixing my style conventions - why?
There are a couple of common reasons this problem can occur:

- You may not be using Visual Studio 2017 version 15.8 Preview 3 or higher. You’ll need this version to be able to use the extended “Format Document” command to perform additional code cleanup for the current document. 
- You may not be opted in to style fixes. The extended capability of fixing convention-based issues capability in Format Document only covers a fixed set of issues, which you can change in **Tools-Options** under **Text Editor > C# > Code Style > Formatting > General > Format Document Settings (Experiment)**. Notice that the default settings do not fix some style conventions. You can opt in to these via **Tools > options** (for example "Apply implicit/explicit type preferences" will run style rules related to the use of `var` in your code).

## Q. Which EditorConfig Conventions can Visual Studio IntelliCode infer?

At present this feature is experimental, so we do not support the full set of conventions documented in the [code style settings reference](../ide/editorconfig-code-style-settings-reference) yet.

IntelliCode can currently infer the following conventions:

Formatting conventions:

-	csharp_space_between_method_declaration_parameter_list_parentheses
-	csharp_space_between_method_declaration_empty_parameter_list_parentheses
-	csharp_space_between_method_call_name_and_opening_parenthesis
-	csharp_space_between_method_call_parameter_list_parentheses
-	csharp_space_between_method_call_empty_parameter_list_parentheses
-	csharp_space_after_keywords_in_control_flow_statements
-	csharp_space_between_parentheses
-	csharp_space_after_cast
-	csharp_space_after_colon_in_inheritance_clause
-	csharp_space_before_colon_in_inheritance_clause
-	csharp_space_around_binary_operators
-	csharp_indent_switch_labels
-	csharp_indent_case_contents
-	csharp_indent_case_contents_when_block
-	csharp_indent_labels
-	csharp_preserve_single_line_blocks
-	csharp_preserve_single_line_statements
-	csharp_new_line_before_open_brace
-	csharp_new_line_before_else
-	csharp_new_line_before_catch
-	csharp_new_line_before_finally
-	csharp_new_line_before_members_in_object_initializers
-	csharp_new_line_before_members_in_anonymous_types
-	csharp_new_line_between_query_expression_clauses

Style Conventions
-	csharp__new_line_before_catch
-	csharp_new_line_before_else
-	csharp_new_line_before_members_in_anonymous_types
-	csharp_new_line_before_members_in_object_initializers 
-	csharp_new_line_before_finally_style
-	csharp_new_line_between_query_expression_clauses
-	csharp_prefer_braces_style
-	csharp_preferred_modifier_order_style
-	csharp_prefer_simple_default_expression
-	csharp_preserve_single_line_blocks
-	csharp_space_after_cast
-	csharp_space_after_keywords_in_control_flow_statements
-	csharp_space_between_method_call_parameter_list_parentheses
-	csharp_space_between_method_declaration_parameter_list_parentheses
-	csharp_space_between_parentheses
-	csharp_style_expression_bodied_accessors
-	csharp_style_expression_bodied_constructors
-	csharp_style_expression_bodied_indexers
-	csharp_style_expression_bodied_methods
-	csharp_style_expression_bodied_operators
-	csharp_style_expression_bodied_properties
-	csharp_style_inlined_variable_declaration
-	csharp_style_pattern_local_over_anonymous_function
-	csharp_style_pattern_matching_over_as_with_null_check
-	csharp_style_var_for_built_in_types
-	csharp_style_var_when_type_is_apparent
-	dotnet_sort_system_directives_first
-	dotnet_style_explicit_tuple_names
-	dotnet_style_object_initializer
-	dotnet_style_predefined_type_for_locals_parameters_members
-	dotnet_style_predefined_type_for_member_access
-	dotnet_style_prefer_inferred_anonymous_type_member_names
-	dotnet_style_qualification_for_event
-	dotnet_style_qualification_for_field
-	dotnet_style_qualification_for_method
-	dotnet_style_qualification_for_property
-	dotnet_style_require_accessibility_modifiers

## Q. Are there other features coming to the Visual Studio IntelliCode extension? 

We're actively working on a number of capabilities that we're excited to share publicly as they become available. You can sign up for news and updates at [https://aka.ms/intellicode](https://aka.ms/intellicode) to be the first to know when we have new capabilities available. 

## Q: What makes “AI-assisted IntelliSense” powered by IntelliCode better than regular IntelliSense?

With IntelliCode, the completion list suggests the most likely correct API for a developer to use, rather than presenting a simple alphabetical list of members. It uses the developer's current code context, and patterns based on 2000 high quality, open-source projects on GitHub each with over 100 stars, to provide this dynamic list. The results form a model that predicts the most likely and most relevant API calls.

## Q: How good are the IntelliCode completion suggestions?

We’ve been using IntelliCode’s recommendations internally at Microsoft for some time, and believe the suggestions are useful. Ultimately, though, the proof will be in how useful these recommendations are to you as you code. We would love you to give the Visual Studio [IntelliCode extension](https://go.microsoft.com/fwlink/?linkid=872707) a try. Let us know how it works out for you and send us your feedback. We’ll also train our model based on what you pick in our recommendations, and we'll update the extension as the model improves.

> [!NOTE]
> None of your user-defined code is collected. See the question on [privacy](#privacy).

## Q. What's the future of IntelliCode?

We're exploring a wide range of ways to improve developer productivity using AI and other advanced techniques. At Microsoft Build 2018, we showed an early view of some of the scenarios where we think AI could assist developers, but there are so many more! We're interested in learning from developers that experiment with what we've shown, so sign up for news and updates at [https://aka.ms/intellicode](https://aka.ms/intellicode).

## Q. How much does it cost?

We have no announcements regarding pricing at present.

## Q. When will IntelliCode be released?

IntelliCode's AI-assisted IntelliSense is currently in its first experimental preview. We'll continue to update the experimental extension, and we'll add further capabilities in the future. We have no schedule for a final release, but we welcome feedback from developers so we can deliver the best possible experiences. You can sign up for news and updates at [https://aka.ms/intellicode](https://aka.ms/intellicode).

## Q. Is this experience only available in Visual Studio and for C#?

The experience was shown at Build 2018 in Visual Studio 2017 on a C# codebase. However, we look forward to expanding IntelliCode to more languages and tools in the Visual Studio family in the future.

## Q. <a name="whynointellisense"/> I can't see the IntelliCode suggestions in my C# editing experience - what's happening?

IntelliCode suggestions appear in the standard Visual Studio IntelliSense UI for C#. Extensions that override that UI prevent the IntelliCode "starred" suggestions from appearing at the top of the list. You can verify if extensions are causing this behavior by turning them off and then trying IntelliSense again.

If this doesn't solve the problem for you, please report your issue via the Visual Studio [Report a Problem](https://docs.microsoft.com/en-us/visualstudio/ide/how-to-report-a-problem-with-visual-studio-2017) feature, and mention IntelliCode in your report.

## Q. What release of Visual Studio do I need to run this extension?

The Visual Studio IntelliCode extension is supported on Visual Studio 2017 version 15.7 preview 5 and later (all SKUs). Installation of the extension halts with "This extension is not installable on any currently installed products." if you don't have the minimum required version installed.

## Q. Is this experience only available in English?

IntelliCode is a preview extension today, and we are eager to understand how useful these capabilities are for a broad set of customers. When we take IntelliCode out of preview, we'll certainly consider which locale or language to support first, and how it is packaged, based on your feedback.

## <a name="privacy"/> Q: What about privacy? Are you sending my code to the cloud? What customer data is being sent to Microsoft?

Developers are invited to experience Visual Studio IntelliCode today as an experimental preview extension. The purpose of the extension is to enable developers to test IntelliCode's capabilities and to provide feedback to the product team.

We capture some anonymized usage and error-reporting data from the extension to help improve the product. No user-defined code is sent to Microsoft, but we collect information about your use of the IntelliCode results. The data only includes open-source and .NET types and members that you selected from IntelliCode's suggested list. Developers can opt out of the [Visual Studio Experience Improvement Program](../../ide/visual-studio-experience-improvement-program.md), which turns off data collection for the IntelliCode extension too. From the menu bar, select **Help** > **Send Feedback** > **Settings**. In the **Visual Studio Experience Improvement Program** dialog, select **No, I would not like to participate** and then select **OK**.

The IntelliCode extension may periodically ask the developer to complete a survey, which again is anonymized. Users can sign up for news and a future private preview, but are not currently required to do so to use the experimental extension.

Future features may require access to a service, which will require sign-up. We'll publish more details when those features are ready for private preview.
