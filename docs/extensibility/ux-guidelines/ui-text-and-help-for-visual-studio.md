---
title: UI Text and Help for Visual Studio
description: Learn about the UI text and terminology used in the Help information for Visual Studio. 
ms.date: 11/04/2016
ms.topic: reference
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# UI Text and Help for Visual Studio

## <a name="BKMK_UITextAndTerminology"></a> UI text and terminology
 Comprehensible text is crucial to effective UI. Software users tend to read labels first, namely those most relevant to completing the task at hand. Static text is read with less frequency. Plan for users to start their work sessions with a quick scan of the whole window, followed by a reading of the UI in this approximate order:

1. Interactive controls in the center

2. Commit buttons

3. Interactive controls found elsewhere

4. Main instructions

5. Supplemental explanations

6. Window title

7. Other static text in the main body

### Usage patterns for UI text

#### Title bar text
 Title bar text must match the command that spawned the UI.

#### Instructional text (helper text)
 In some dialogs, it is helpful to provide prominent main instructions to explain what to do in the window or in the page. This is sometimes referred to as "helper text."

##### Writing style rules for helper text

- Don't explain the obvious. Unless it is absolutely needed, do not include instructional text.

- Instructional text is always placed at the top of the dialog and should refer to the task being performed.

- Precisely explain to users what they need to do. Avoid excessive communication and redundancy.

- Review each window and eliminate duplicate words and statements.

- Keep instructional text short. If more information is necessary for certain users or scenarios, then provide a link to a detailed conceptual online topic.

- Write your text so that every word holds weight and is necessary.

- Follow existing Microsoft guidance for [User Interface Text](/windows/desktop/uxguide/text-ui) and [Style and Tone](/windows/desktop/uxguide/text-style-tone).

#### Supplemental instructions
 Supplemental instructions provide additional information that helps the user understand controls or control groupings. This could also include hint text necessary to understand what format the input control is expecting. Use supplemental instructions sparingly. Reserve them for cases where it's likely that the user won't fully understand the ramifications of the choice they are making.

 ![Screenshot showing the Internet Explorer Options button with supplemental text below it that describes the impact of changing the option settings.](../../extensibility/ux-guidelines/media/0601-b_supplementaltext1.png "0601-b_SupplementalText1")

 **Supplemental text in Visual Studio**

 ![Screenshot of the Choose Source Control dialog in Visual Studio showing supplemental text that describes each of the source control system options.](../../extensibility/ux-guidelines/media/0601-c_supplementaltext2.png "0601-c_SupplementalText2")

 **Supplemental text in Visual Studio**

#### InfoTips
 Often, the instructional text might be too lengthy to position in-place in the UI or might be useful only to new users, feeling like clutter to experienced users. In this case, the instructional/informational text should be placed as a tooltip under an InfoTip.

 InfoTips should be placed near the controls that they are related to and should use the specific InfoTip icon, which is unobtrusive yet noticeable.

 ![InfoTip in Visual Studio](../../extensibility/ux-guidelines/media/0601-d_infotip.png "0601-d_InfoTip")

 **Example of an InfoTip in Visual Studio**

##### Writing style rules for InfoTips

- Write InfoTips as complete sentences. They require specific verbs, sentence case, and ending punctuation.

- Use InfoTips to supplement your main instruction or information. If you are just using different words to restate the main idea, you don't need an InfoTip.

- Keep InfoTips short and sweet. Use small words and plain, everyday language that supports and encourages the user.

- Follow existing Microsoft guidance for [User Interface Text](/windows/desktop/uxguide/text-ui) and [Style and Tone](/windows/desktop/uxguide/text-style-tone).

#### Control labels
 Control labels should be short, concise, and follow the [Windows Desktop guidance for Controls](/windows/desktop/uxguide/controls).

 For more information about control label format and placement within the UI, refer to [Layout for Visual Studio](../../extensibility/ux-guidelines/layout-for-visual-studio.md).

#### Help links
 Help links can either be placed within instructional text or in the body of the UI. They can be links to Help or launch internal dialogs.

##### Visual style rules for Help links

- Use the correct environment colors for hyperlinks. A properly styled hyperlink will not briefly flash red when clicked. If you see this, then it is an indication that environment colors are not being used.

- Underlines should only be used on hover or when the link is embedded in a paragraph.

- For more detailed information on visual and interaction styles for hyperlinks, see Buttons and hyperlinks.

##### Writing style rules for Help links

- When launching dialogs, maintain the standards for ellipses: no ellipsis for navigation, ellipses if the task requires additional UI.

     ![Help link in Visual Studio](../../extensibility/ux-guidelines/media/0601-e_helplink.png "0601-e_HelpLink")

     **An ellipsis (...) in a Help link indicates the task will require additional UI.**

- Links should not start with "Learn," as that is not the user's intent. The user wants to answer a specific question, not receive a general education.

- Phrase help links so that they ask the question that the topic will answer.

     Incorrect:
     "Learn more about Windows Azure Mobile Services pricing"

     Correct:
     "What pricing options are available for Windows Azure Mobile Services?"

- Never use *Click...* to the link text.

- Never link only the word "here." This is problematic for some screen readers, which will voice only the hyperlinked word.

     Incorrect:
     "Find information on Windows Azure Mobile Services **here**"

     Correct:
     "What pricing options are available for Windows Azure Mobile Services?"

- For more information on the correct writing style for Help links, see the [Windows Desktop guidance for Help](/windows/desktop/uxguide/winenv-help).

#### Hint text
 Hint text appears as a watermark within a control or below the control. Correct formatting will be applied by using the appropriate VSColors token, `Environment.GrayText`.

 It can appear in a number of forms.

- In place of the control label:

     ![Screenshot of a drop-down control with hint text in place of the control label that reads "Search Solution Explorer (Ctrl+;)".](../../extensibility/ux-guidelines/media/0601-f_hinttext1.png "0601-f_HintText1")

- With a verb, giving instructions:

     ![Screenshot of a text box with hint text in the control that reads "Enter your name".](../../extensibility/ux-guidelines/media/0601-g_hinttext2.png "0601-g_HintText2")

- With text indicating a required entry:

     ![Screenshot of a text box with hint text in the control that reads "\<Required\>".](../../extensibility/ux-guidelines/media/0601-h_hinttext3.png "0601-h_HintText3")

#### Watermark text
 On an empty design surface, the text should indicate what to do as well as provide links to open other related windows, if appropriate:

 ![Watermark text in Visual Studio](../../extensibility/ux-guidelines/media/0601-i_watermarktext.png "0601-i_WatermarkText")

 **Example of watermark text in Visual Studio**

### Common terminology

|Term|Explanation|Comment|
|----------|-----------------|-------------|
|Sign in / Sign out|Verbs used synonymously with the web for representing authentication into a web property. Within clients, we use this once as a top-level notion for signing in and out of IDE user connection, which represents a top-level identity that provides higher-level capabilities such as roaming and licensing that are not available with all other connections.|The IDE User is the only feature that should represent a sign in / sign out verb, as it represents the top-level IDE user.|
|Connect / Disconnect|Use in places where a feature maintains a single connection to an online service.|Server Explorer, where you can only have one active Azure connection at a time, is an example of Connect/Disconnect.|
|Add / Remove|Non-destructive. Use when adding or removing something from a list.|The TFS Connection Manager server list dialog is an example of Add/Remove.|
|Delete|Destructive. Use only when the element being removed will be permanently discarded or deleted from the disk.|"Delete" generally requires a prompt if the result is deleting a file from disk.|

## Error messages

 Errors happen. Setting limitations on what the user can do is a sensible first step in preventing avoidable error messages. However, when an error does occur, a well-written error message can go a long way toward mitigating the problem. Error messages are arguably one of the most important types of notification that the user sees, because they are synchronous and indicate a problem that needs to be solved. Poorly written error messages leave users on their own to decide the cause of the errors and any possible solutions.

 Users might stop paying attention to overused or confusing error messages, so write only necessary messages that add value to the user experience. If the message is simply a notification, then use an alternative presentation.

### Rules for creating an error message

- When constructing error messages, choose the appropriate error level for the audience. Aim for straightforward summaries that provide an action the user can take, if applicable. Don't state anything that the user does not need to know.

- Provide constructive assistance. It's easier to read and act on an error message that contains instruction.

- Don't use double negatives.

- Perform both an automated and a manual grammar and spelling check on any error message you write.

- For complex error messages, avoid sequential communications. Never use an F1 hookup for the error message. The message itself should be sufficient.

- Use the correct icon.

- Make questions easy to understand and use buttons that have clear choices, such as "Delete" and "Cancel."

- For warnings, be clear about what the consequence of proceeding will be. The buttons should indicate the consequence.

- For errors, describe what the user can do to fix the problem. Buttons should be actions or say "Close." Don't use an "OK" button for an error message.

- Some questions to ask yourself when constructing an error message:

  - Can the user figure out how to solve the issue with this error alone?

  - Does the user use the same vocabulary as this error?

  - Is this error ambiguous or shared in multiple situations? If so, how do you guide users to the solution they need?

#### Build errors
 Since Visual Studio is a software development tool, many of its components have a compilation, converting, or encoding step to convert the developer's work to binary form. These conversions can cause errors when the compiler cannot process improperly authored files or when compiler options weren't set correctly.

 Visual Studio users can spend an enormous number of development hours resolving build errors. This resolution time increases when errors have dependencies or when error messages are poorly written, which can make it difficult to uncover the source of the error.

 The best build errors are those that don't occur in the first place, which is why Visual Studio provides AutoComplete and IntelliSense squiggles. Schema validators and similar tools provide the same kind of feedback. These mechanisms proactively guide the user to construct well-formed code, lessening the chance of build errors.

 Visual Studio provides a tool window where users can read and navigate through the errors that occurred in their document windows. Keyboard shortcuts are provided so that the user can quickly navigate large amounts of code and go directly to the location of the problem. Visual Studio also allows each build error to be tied to a particular Help keyword/context ID so that the user can go directly to a Help topic that gives more in-depth information about the error.

 Write clear, concise build errors:

- **Use plain language** that explains the problem with little or no compiler jargon. The text of a build error should not be overly technical.

- **Outline possible causes.** For example, "Missing a colon between the property and value in the '(property) : (value)' declaration."

- Give details about potential fixes. If there is not enough room, then additional details may be put into the corresponding Help topic.

### Components of a well-written error message

#### Use the shell dialog service for error messages.
 Using the shell dialog service lets you control the appearance of the message, fonts in particular, without major changes to individual elements. Use the **IErrorInfo** mechanisms and report them using **IVsUIShell::SetErrorInfo/ReportErrorInfo**.

#### Choose an effective and appropriate notification presentation.
 Use a modal dialog with a critical warning if immediate action is required to avoid loss of data (synchronous notification). Critical icons are reserved for situations in which closing the message without reading it can lead to negative consequences. Loss of data is a critical situation that requires an alarm-level response. Overuse of the critical icon desensitizes users to its importance. If the error message is informational in nature, consider alternatives to a modal dialog (asynchronous notification).

#### Provide a clean, succinct explanation of why the problem occurred rather than a technical explanation.
 Overburdening users with technical details in the explanation will make them more likely to ignore error messages. Examples of good messaging:

- "Unable to open the requested file."

- "Unable to connect to the Internet."

#### Provide information about how to fix the problem.
 Offer the user suggestions of how to fix the problem. Be honest with the user if there are no suggestions. Provide direct links to alternative online sources, such as technical support or community support. Try to point users to specific online information pertinent to the issue. For an error ID, consider linking users to a discussion thread about that specific error. Examples of good messaging:

- "Make sure that you are connected to the Internet and try this operation again."

- "Make sure that the file exists and that you have permission to open it."

#### Write a message that is short and to the point.
 An error message can notify, explain, and offer a solution but still be ignored if it's too wordy. One solution is to use progressive disclosure with a details button. For example, give a short description/solution and then put more details under a details button. If users choose to read more information on the error, they can do so.

 The language in the message should be:

- **Domain-appropriate.** Use language the user will understand. Even though our customers are developers, they often don't have the context and terminology we have.

- **Specific.** Avoid vague wording and give specific names and locations of objects involved. For example, an error message such as "character is invalid" is not useful. Which character? "File not found." Which file?

- **Courteous.** Don't blame the user or make them feel stupid. Avoid hostile or offensive language (kill, execute, terminate, fatal, illegal). Avoid uppercase text, which is often seen as shouting and is not as readable. Don't use humor.

- **Correct.** Use correct spelling and grammar (even in alphas). Typos are unprofessional and embarrassing.

- **Contextually appropriate.** Use appropriate button text. Avoid the "OK" button and instead use "Continue" or "Yes/No."

### Error message examples

|Good|Bad|
|----------|---------|
|"The number you dialed is no longer in service. Please check the number and dial again or dial 0 for the operator."|-   "Error (449): Illegal number"<br />-   "This unhandled exception error indicates that the operation completed successfully."<br /><br /> ![Bad error message in Visual Studio](../../extensibility/ux-guidelines/media/0602-a_errordialog.png "0602-a_ErrorDialog")|

## Accessing Help

 In addition to documentation in MSDN, a Visual Studio user has several access points to assist the user while in the UI. To ensure that these access points are consistently available, feature teams need to take advantage of the Help system offered by the environment. These access points are:

- **Instructional and supplemental text in dialogs.** Static text that gives direction or explanation, either on the UI surface or available on hover over an InfoTip icon.

- **F1 Help** (editor only). Within the Visual Studio editor, a user can trust that at any time, pressing F1 will bring up a Help topic specific to the current selection. Ensure that topics associated with F1 are appropriate and informative.

- **Hyperlinks to Help topics.** A hyperlink within a dialog, tool window, or design surface that launches a topic to assist the user in learning more about a technology, capability, or information about how to accomplish a task.

- **Helper UI mechanisms, such as smart tags and building dialogs.** These mechanisms assist the user in understanding a UI element, or facilitate a task, such as smart tags or builder dialogs.

- **UI Help buttons** (deprecated). A visible indicator in the title bar that gives access to the related F1 Help topic.

### Text

#### Instructional and supplemental text in dialogs
 In dialogs that support complex tasks, there might be a need to give instructional text within the UI, often at the top of the dialog or near complex controls. See [UI text and terminology](../../extensibility/ux-guidelines/ui-text-and-help-for-visual-studio.md#BKMK_UITextAndTerminology) for details on writing style.

#### InfoTips
 Often, instructional text might be too lengthy to position in place in the UI or might be useful only to new users, feeling like clutter to experienced users. In this case, the instructional/informational text should be placed as a tooltip under an InfoTip.

 InfoTips should be placed near the controls that they are related to and should use the specific InfoTip icon, which is unobtrusive yet noticeable.

 ![InfoTip in Visual Studio](../../extensibility/ux-guidelines/media/0601-d_infotip.png "0601-d_InfoTip")

 **Example of an InfoTip in Visual Studio**

### Interactive Help mechanisms

#### F1 Help
 F1 Help is required within an editor or design surface, but not elsewhere in the Visual Studio environment.

#### Hyperlinks to Help topics
 Hyperlinks can be used to perform an action, navigate within the IDE, or launch Help in a browser. See [UI text and terminology](../../extensibility/ux-guidelines/ui-text-and-help-for-visual-studio.md#BKMK_UITextAndTerminology) for details on language and 07.10.01 Buttons and hyperlinks for visual and layout guidelines.

#### Help [?] buttons in dialog title bars (deprecated)
 For the most part, the Help [?] buttons in the title bar of dialogs are deprecated. UI topics are no longer part of our doc model, and therefore there might not be a relevant topic to link to. Essentially, the title bar button was the same thing as F1 Help, and that is no longer required in dialogs. In some instances, this can still be used as an indicator that there is more conceptual or procedural information available, although hyperlinks are more commonly used in newer UI.

##### Dialogs created through the environment
 Many shell dialogs are created through the **VBDialogBoxParam** function. This shared function was updated to assist in moving the **Help** button from the dialog to the **?** button while retaining an architecture that is backward compatible and extensible.

 Specifically, the **VBDialogBoxParam** function looks at the dialog template for a button whose ID is **IDHELP** (9) or label is **Help** or **&Help**. If a Help button is found, it is hidden and the **WS_EX_CONTEXTHELP** style is added to the dialog, which places the **?** button in the dialog's title bar.

 When the dialog is created, it pushes the dialog proc onto a stack and invokes the dialog with a pre-processing dialog proc named **DialogPreProc**. When the **?** button is clicked, it sends a **WM_SYSCOMMAND** of **SC_CONTEXTHELP** to the dialog. The **DialogPreProc** captures this command and changes it to a **WM_HELP** message, which is passed to the original dialog proc.

 Most environment-created dialogs have a Help button on the dialog. When the dialog is displayed, the Help button is auto-hidden and only the **?** button works. If the **?** button is ever removed or changed in Windows, this solution allows you to quickly move back to the original Help buttons.

 This solution makes four assumptions that could cause bugs:

- The dialog's help button is **IDHELP** (9).

- The dialog looks correct when the Help button is hidden.

- The dialog does not substitute its winproc.

- The dialog is not embedded inside of another dialog.

  If your dialog resides within msenv and doesn't use **VBDialogBoxParam**, investigate leveraging **VBDialogBoxParam** before implementing your own handler.

##### Dialogs created through other packages
 You can implement your own solution for dialogs that reside outside msenv. For a shared dialog class in your VSPackage, consider moving the button to the title bar or implementing a handler on each dialog. The following code is a skeleton of an implementation to help you get started:

```
struct DLGPROCITEM
{
    FARPROC proc; // The info used to create the dialog.
    DLGPROCITEM* procPrev;
};

DLGPROCITEM* g_dlgProcStack = NULL;

// A dialog starter/wrapper function is used to push the new
// dialog proc to the top of our dialog proc stack.

int SomeDialogStarterFunction(hinst, id, proc, etc)
{
    if (g_dlgProcStack == NULL)
    {
        g_dlgProcStack = new DLGPROCITEM;
        g_dlgProcStack->procPrev = NULL;
    }
    else
    {
        DLGPROCITEM* procItem = new DLGPROCITEM;
        g_dlgProcStack->procPrev = g_dlgProcStack;
        g_dlgProcStack = procItem;
    }
}

// Pop this dialog proc off the dialog proc stack.

DialogBoxIndirectParam...(...)
{
    DLGPROCITEM* procItem = g_dlgProcStack->procPrev;
    delete g_dlgProcStack;
    g_dlgProcStack = procItem;
}

// A wrapper dialog procedure will allow us to capture the
// SC_CONTEXTHELP button on the title bar from Windows and
// forward it as a simple WM_HELP message back to the dialog.

INT_PTR CALLBACK DialogPreProc(HWND hwndDlg, UINT uMsg,
    WPARAM wParam, LPARAM lParam)
{
    if (uMsg == WM_SYSCOMMAND && wParam == SC_CONTEXTHELP)
    {
        uMsg = WM_HELP;
        wParam = 0;
        lParam = 0;
    }
    return CallWindowProc((WNDPROC)g_dlgProcStack->proc,
        hwndDlg, uMsg, wParam, lParam);
}
```

##### Help buttons in managed code
 Overriding the window title bar Help button's default behavior is easy in managed code. Below is a complete demo application that demonstrates this behavior. In essence, you need to override your form's **WndProc** method and then fire off F1 help requests when an **SC_CONTEXTHELP** message is intercepted.

```
using System;
using System.Windows.Forms;

public class HelpForm : Form
{
    private const int SC_CONTEXTHELP = 0xF180;
    private const int WM_SYSCOMMAND = 0x0112;

    public HelpForm()
    {
        this.ClientSize = new System.Drawing.Size(300, 250);
        this.HelpButton = true;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "HelpForm";
        this.Text = "Help Form";
    }

    protected override void WndProc(ref Message m)
    {
        if (m.Msg == WM_SYSCOMMAND && SC_CONTEXTHELP == (int)m.WParam)
            ShowHelp();
        else
            base.WndProc(ref m);
    }

    private void ShowHelp()
    {
        MessageBox.Show("F1 Help goes here.");
    }

     [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.EnableRTLMirroring();
        Application.Run(new HelpForm());
    }
}
```

## See also
- [Fonts and Formatting for Visual Studio](../../extensibility/ux-guidelines/fonts-and-formatting-for-visual-studio.md)
- [Layout for Visual Studio](../../extensibility/ux-guidelines/layout-for-visual-studio.md)
- [Notifications and Progress for Visual Studio](../../extensibility/ux-guidelines/notifications-and-progress-for-visual-studio.md)
