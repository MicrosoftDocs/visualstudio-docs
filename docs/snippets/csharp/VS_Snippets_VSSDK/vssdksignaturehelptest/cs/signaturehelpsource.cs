﻿//<Snippet1>
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Language.Intellisense;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Utilities;
using Microsoft.VisualStudio.Editor;
using Microsoft.VisualStudio.Text.Operations;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.TextManager.Interop;
using Microsoft.VisualStudio.OLE.Interop;
//</Snippet1>

//<Snippet2>
internal class TestParameter : IParameter
//</Snippet2>
{
    //<Snippet3>
    public TestParameter(string documentation, Span locus, string name, ISignature signature)
    {
        Documentation = documentation;
        Locus = locus;
        Name = name;
        Signature = signature;
    }
    //</Snippet3>

    //<Snippet4>
    public string Documentation { get; private set; }
    public Span Locus { get; private set; }
    public string Name { get; private set; }
    public ISignature Signature { get; private set; }
    public Span PrettyPrintedLocus { get; private set; }
    //</Snippet4>
}

//<Snippet5>
internal class TestSignature : ISignature
//</Snippet5>
{
    //<Snippet6>
    private ITextBuffer m_subjectBuffer;
    private IParameter m_currentParameter;
    private string m_content;
    private string m_documentation;
    private ITrackingSpan m_applicableToSpan;
    private ReadOnlyCollection<IParameter> m_parameters;
    private string m_printContent;
    //</Snippet6>

    //<Snippet7>
    internal TestSignature(ITextBuffer subjectBuffer, string content, string doc, ReadOnlyCollection<IParameter> parameters)
    {
        m_subjectBuffer = subjectBuffer;
        m_content = content;
        m_documentation = doc;
        m_parameters = parameters;
        m_subjectBuffer.Changed += new EventHandler<TextContentChangedEventArgs>(OnSubjectBufferChanged);
    }
    //</Snippet7>

    //<Snippet8>
    public event EventHandler<CurrentParameterChangedEventArgs> CurrentParameterChanged;
    //</Snippet8>

    //<Snippet9>
    public IParameter CurrentParameter
    {
        get { return m_currentParameter; }
        internal set
        {
            if (m_currentParameter != value)
            {
                IParameter prevCurrentParameter = m_currentParameter;
                m_currentParameter = value;
                this.RaiseCurrentParameterChanged(prevCurrentParameter, m_currentParameter);
            }
        }
    }
    //</Snippet9>

    //<Snippet10>
    private void RaiseCurrentParameterChanged(IParameter prevCurrentParameter, IParameter newCurrentParameter)
    {
        EventHandler<CurrentParameterChangedEventArgs> tempHandler = this.CurrentParameterChanged;
        if (tempHandler != null)
        {
            tempHandler(this, new CurrentParameterChangedEventArgs(prevCurrentParameter, newCurrentParameter));
        }
    }
    //</Snippet10>

    //<Snippet11>
    internal void ComputeCurrentParameter()
    {
        if (Parameters.Count == 0)
        {
            this.CurrentParameter = null;
            return;
        }

        //the number of commas in the string is the index of the current parameter
        string sigText = ApplicableToSpan.GetText(m_subjectBuffer.CurrentSnapshot);

        int currentIndex = 0;
        int commaCount = 0;
        while (currentIndex < sigText.Length)
        {
            int commaIndex = sigText.IndexOf(',', currentIndex);
            if (commaIndex == -1)
            {
                break;
            }
            commaCount++;
            currentIndex = commaIndex + 1;
        }

        if (commaCount < Parameters.Count)
        {
            this.CurrentParameter = Parameters[commaCount];
        }
        else
        {
            //too many commas, so use the last parameter as the current one.
            this.CurrentParameter = Parameters[Parameters.Count - 1];
        }
    }
    //</Snippet11>

    //<Snippet12>
    internal void OnSubjectBufferChanged(object sender, TextContentChangedEventArgs e)
    {
        this.ComputeCurrentParameter();
    }
    //</Snippet12>

    //<Snippet13>
    public ITrackingSpan ApplicableToSpan
    {
        get { return (m_applicableToSpan); }
        internal set { m_applicableToSpan = value; }
    }
    //</Snippet13>

    //<Snippet14>
    public string Content
    {
        get { return (m_content); }
        internal set { m_content = value; }
    }

    public string Documentation
    {
        get { return (m_documentation); }
        internal set { m_documentation = value; }
    }

    public ReadOnlyCollection<IParameter> Parameters
    {
        get { return (m_parameters); }
        internal set { m_parameters = value; }
    }

    public string PrettyPrintedContent
    {
        get { return (m_printContent); }
        internal set { m_printContent = value; }
    }
    //</Snippet14>
}

//<Snippet15>
internal class TestSignatureHelpSource : ISignatureHelpSource
//</Snippet15>
{
    //<Snippet16>
    private ITextBuffer m_textBuffer;
    //</Snippet16>

    //<Snippet17>
    public TestSignatureHelpSource(ITextBuffer textBuffer)
    {
        m_textBuffer = textBuffer;
    }
    //</Snippet17>

    //<Snippet18>
    public void AugmentSignatureHelpSession(ISignatureHelpSession session, IList<ISignature> signatures)
    {
        ITextSnapshot snapshot = m_textBuffer.CurrentSnapshot;
        int position = session.GetTriggerPoint(m_textBuffer).GetPosition(snapshot);

        ITrackingSpan applicableToSpan = m_textBuffer.CurrentSnapshot.CreateTrackingSpan(
         new Span(position, 0), SpanTrackingMode.EdgeInclusive, 0);

        signatures.Add(CreateSignature(m_textBuffer, "add(int firstInt, int secondInt)", "Documentation for adding integers.", applicableToSpan));
        signatures.Add(CreateSignature(m_textBuffer, "add(double firstDouble, double secondDouble)", "Documentation for adding doubles.", applicableToSpan));

    }
    //</Snippet18>

    //<Snippet19>
    private TestSignature CreateSignature(ITextBuffer textBuffer, string methodSig, string methodDoc, ITrackingSpan span)
    {
        TestSignature sig = new TestSignature(textBuffer, methodSig, methodDoc, null);
        textBuffer.Changed += new EventHandler<TextContentChangedEventArgs>(sig.OnSubjectBufferChanged);

        //find the parameters in the method signature (expect methodname(one, two)
        string[] pars = methodSig.Split(new char[] { '(', ',', ')' });
        List<IParameter> paramList = new List<IParameter>();

        int locusSearchStart = 0;
        for (int i = 1; i < pars.Length; i++)
        {
            string param = pars[i].Trim();

            if (string.IsNullOrEmpty(param))
                continue;

            //find where this parameter is located in the method signature
            int locusStart = methodSig.IndexOf(param, locusSearchStart);
            if (locusStart >= 0)
            {
                Span locus = new Span(locusStart, param.Length);
                locusSearchStart = locusStart + param.Length;
                paramList.Add(new TestParameter("Documentation for the parameter.", locus, param, sig));
            }
        }

        sig.Parameters = new ReadOnlyCollection<IParameter>(paramList);
        sig.ApplicableToSpan = span;
        sig.ComputeCurrentParameter();
        return sig;
    }
    //</Snippet19>

    //<Snippet20>
    public ISignature GetBestMatch(ISignatureHelpSession session)
    {
        if (session.Signatures.Count > 0)
        {
            ITrackingSpan applicableToSpan = session.Signatures[0].ApplicableToSpan;
            string text = applicableToSpan.GetText(applicableToSpan.TextBuffer.CurrentSnapshot);

            if (text.Trim().Equals("add"))  //get only "add" 
                return session.Signatures[0];
        }
        return null;
    }
    //</Snippet20>

    //<Snippet21>
    private bool m_isDisposed;
    public void Dispose()
    {
        if (!m_isDisposed)
        {
            GC.SuppressFinalize(this);
            m_isDisposed = true;
        }
    }
    //</Snippet21>
}

//<Snippet22>
[Export(typeof(ISignatureHelpSourceProvider))]
[Name("Signature Help source")]
[Order(Before = "default")]
[ContentType("text")]
internal class TestSignatureHelpSourceProvider : ISignatureHelpSourceProvider
//</Snippet22>
{
    //<Snippet23>
    public ISignatureHelpSource TryCreateSignatureHelpSource(ITextBuffer textBuffer)
    {
        return new TestSignatureHelpSource(textBuffer);
    }
    //</Snippet23>
}

//<Snippet24>
internal sealed class TestSignatureHelpCommandHandler : IOleCommandTarget
//</Snippet24>
{
    //<Snippet25>
    IOleCommandTarget m_nextCommandHandler;
    ITextView m_textView;
    ISignatureHelpBroker m_broker;
    ISignatureHelpSession m_session;
    ITextStructureNavigator m_navigator;
    //</Snippet25>

    //<Snippet26>
    internal TestSignatureHelpCommandHandler(IVsTextView textViewAdapter, ITextView textView, ITextStructureNavigator nav, ISignatureHelpBroker broker)
    {
        this.m_textView = textView;
        this.m_broker = broker;
        this.m_navigator = nav;

        //add this to the filter chain
        textViewAdapter.AddCommandFilter(this, out m_nextCommandHandler);
    }
    //</Snippet26>

    //<Snippet27>
    public int Exec(ref Guid pguidCmdGroup, uint nCmdID, uint nCmdexecopt, IntPtr pvaIn, IntPtr pvaOut)
    {
        char typedChar = char.MinValue;

        if (pguidCmdGroup == VSConstants.VSStd2K && nCmdID == (uint)VSConstants.VSStd2KCmdID.TYPECHAR)
        {
            typedChar = (char)(ushort)Marshal.GetObjectForNativeVariant(pvaIn);
            if (typedChar.Equals('('))
            {
                //move the point back so it's in the preceding word
                SnapshotPoint point = m_textView.Caret.Position.BufferPosition - 1;
                TextExtent extent = m_navigator.GetExtentOfWord(point);
                string word = extent.Span.GetText();
                if (word.Equals("add"))
                    m_session = m_broker.TriggerSignatureHelp(m_textView);

            }
            else if (typedChar.Equals(')') && m_session != null)
            {
                m_session.Dismiss();
                m_session = null;
            }
        }
        return m_nextCommandHandler.Exec(ref pguidCmdGroup, nCmdID, nCmdexecopt, pvaIn, pvaOut);
    }
    //</Snippet27>

    //<Snippet28>
    public int QueryStatus(ref Guid pguidCmdGroup, uint cCmds, OLECMD[] prgCmds, IntPtr pCmdText)
    {
        return m_nextCommandHandler.QueryStatus(ref pguidCmdGroup, cCmds, prgCmds, pCmdText);
    }
    //</Snippet28>
}

//<Snippet29>
[Export(typeof(IVsTextViewCreationListener))]
[Name("Signature Help controller")]
[TextViewRole(PredefinedTextViewRoles.Editable)]
[ContentType("text")]
internal class TestSignatureHelpCommandProvider : IVsTextViewCreationListener
//</Snippet29>
{
    //<Snippet30>
    [Import]
    internal IVsEditorAdaptersFactoryService AdapterService;

    [Import]
    internal ITextStructureNavigatorSelectorService NavigatorService { get; set; }

    [Import]
    internal ISignatureHelpBroker SignatureHelpBroker;
    //</Snippet30>

    //<Snippet31>
    public void VsTextViewCreated(IVsTextView textViewAdapter)
    {
        ITextView textView = AdapterService.GetWpfTextView(textViewAdapter);
        if (textView == null)
            return;

        textView.Properties.GetOrCreateSingletonProperty(
             () => new TestSignatureHelpCommandHandler(textViewAdapter,
                textView,
                NavigatorService.GetTextStructureNavigator(textView.TextBuffer),
                SignatureHelpBroker));
    }
    //</Snippet31>
}