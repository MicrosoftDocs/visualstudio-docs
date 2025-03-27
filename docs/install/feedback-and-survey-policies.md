If needed for reference: Privacy Controls Admin Optout.docx 

Update this page to link to the below content 

The below page will need to link in this aka: https://aka.ms/VSFeedbackPolicy (for newsletter) 

Configure Feedback Group Policies in Visual Studio 

To control feedback in Visual Studio you can now use  Group Policy Administrative Templates (ADMX/ADML files). To configure and deploy these policies, you can use Microsoft Intune or the Local Group Policy Editor directly on the client machine. 

With these policies, your organization will be able to add an extra layer of protection to prevent accidents on Visual Studio Live Share and increase productivity. 

To take advantage of these policies your team will need to be using Visual Studio 17.13+. 

Supported Policies for feedback 

We are introducing some more policies for better granularity.  

SurveysDisabled – prevents users from seeing survey links 

ProductFeedbackDisabled – prevents users from seeing all other types of feedback (this includes thumbs up/down, developer community, etc) 

 

NOTE 

Currently we have DisableFeedbackDialog. This will be retired at VS18 

The feedback policies replacing 

 

Configure policies with Microsoft Endpoint Manager (Intune) settings 

Visual Studio global policies are included in the Microsoft Endpoint Manager (Intune) settings. This makes it easier for administrators to configure their organization's devices now that the Visual Studio software policies are readily accessible in the Device Configuration Profile UI. Since Visual Studio will be keeping the policies up to date in Intune's settings catalog, administrators will be able to always access the most current Visual Studio Live Share configuration options without having to do manual imports. 

To take advantage of Visual Studio's built-in configuration policy settings in Intune, simply create a Device Configuration Profile, choose "Settings catalog", and then add the desired polices that you want configured on your devices. 

Configure policies with Local Group Policy Editor 

Step 1: Download the templates 

Head over to the Microsoft Download Center and grab the Visual Studio Group Policy Administrative Template files (ADMX/ADML). It’ll ask you where you want the files to be downloaded, please ensure the location is ‘C:\Windows\PolicyDefinitions'. 

Step 2: Test using the Local Group Policy Editor 

Open the Windows Local Group Policy Editor 

Navigate to Computer Configuration > Administrative Templates > Visual Studio > Live Share Settings 

Apply the desired policy changes to Visual Studio Live Share 

[Optional] Ensure the new group policy changes are applied to the respective product's path in the Registry Editor: Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\VisualStudio\LiveShare Screenshot that shows the Registry Editor 

Restart your Visual Studio instance to pick up the new policy changes 

Note: Depending on your organization’s policy, you might need to force a group policy update via gpupdate.exe to apply the change. 

After all desired policies are set, teams across your organization can confidently collaborate with Visual Studio Live Share. 

 
