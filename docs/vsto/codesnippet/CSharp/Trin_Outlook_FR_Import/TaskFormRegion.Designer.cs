namespace Trin_Outlook_FR_Import
{
    partial class TaskFormRegion : Microsoft.Office.Tools.Outlook.ImportedFormRegionBase
    {
        private Microsoft.Office.Interop.Outlook.OlkTextBox olkTextBox1;
        private Microsoft.Office.Interop.Outlook.OlkLabel olkLabel1;
        private Microsoft.Office.Interop.Outlook.OlkTextBox olkTextBox2;
        private Microsoft.Office.Interop.Outlook.OlkLabel olkLabel2;
        private Microsoft.Office.Interop.Outlook.OlkLabel label1;
        private Microsoft.Office.Interop.Outlook.OlkListBox listBox1;
        private Microsoft.Office.Interop.Outlook.OlkLabel label2;
        private Microsoft.Office.Interop.Outlook.OlkComboBox comboBox1;
        private Microsoft.Office.Interop.Outlook.OlkCommandButton addDependentTask;
        private Microsoft.Office.Interop.Outlook.OlkTextBox olkTextBox3;
        private Microsoft.Office.Interop.Outlook.OlkLabel olkLabel3;

        public TaskFormRegion(Microsoft.Office.Interop.Outlook.FormRegion formRegion)
            : base(Globals.Factory, formRegion)
        {
            this.FormRegionShowing += new System.EventHandler(this.TaskFormRegion_FormRegionShowing);
            this.FormRegionClosed += new System.EventHandler(this.TaskFormRegion_FormRegionClosed);
        }

        protected override void InitializeControls()
        {
            this.olkTextBox1 = (Microsoft.Office.Interop.Outlook.OlkTextBox)GetFormRegionControl("OlkTextBox1");
            this.olkLabel1 = (Microsoft.Office.Interop.Outlook.OlkLabel)GetFormRegionControl("OlkLabel1");
            this.olkTextBox2 = (Microsoft.Office.Interop.Outlook.OlkTextBox)GetFormRegionControl("OlkTextBox2");
            this.olkLabel2 = (Microsoft.Office.Interop.Outlook.OlkLabel)GetFormRegionControl("OlkLabel2");
            this.label1 = (Microsoft.Office.Interop.Outlook.OlkLabel)GetFormRegionControl("Label1");
            this.listBox1 = (Microsoft.Office.Interop.Outlook.OlkListBox)GetFormRegionControl("ListBox1");
            this.label2 = (Microsoft.Office.Interop.Outlook.OlkLabel)GetFormRegionControl("Label2");
            this.comboBox1 = (Microsoft.Office.Interop.Outlook.OlkComboBox)GetFormRegionControl("ComboBox1");
            this.addDependentTask = (Microsoft.Office.Interop.Outlook.OlkCommandButton)GetFormRegionControl("AddDependentTask");
            this.olkTextBox3 = (Microsoft.Office.Interop.Outlook.OlkTextBox)GetFormRegionControl("OlkTextBox3");
            this.olkLabel3 = (Microsoft.Office.Interop.Outlook.OlkLabel)GetFormRegionControl("OlkLabel3");
        }

        public partial class TaskFormRegionFactory : Microsoft.Office.Tools.Outlook.IFormRegionFactory
        {
            public event Microsoft.Office.Tools.Outlook.FormRegionInitializingEventHandler FormRegionInitializing;

            private Microsoft.Office.Tools.Outlook.FormRegionManifest _Manifest;

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public TaskFormRegionFactory()
            {
                this._Manifest = Globals.Factory.CreateFormRegionManifest();
                this.InitializeManifest();
                this.FormRegionInitializing += new Microsoft.Office.Tools.Outlook.FormRegionInitializingEventHandler(this.TaskFormRegionFactory_FormRegionInitializing);
            }

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public Microsoft.Office.Tools.Outlook.FormRegionManifest Manifest
            {
                get
                {
                    return this._Manifest;
                }
            }

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            Microsoft.Office.Tools.Outlook.IFormRegion Microsoft.Office.Tools.Outlook.IFormRegionFactory.CreateFormRegion(Microsoft.Office.Interop.Outlook.FormRegion formRegion)
            {
                TaskFormRegion form = new TaskFormRegion(formRegion);
                form.Factory = this;
                return form;
            }

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            byte[] Microsoft.Office.Tools.Outlook.IFormRegionFactory.GetFormRegionStorage(object outlookItem, Microsoft.Office.Interop.Outlook.OlFormRegionMode formRegionMode, Microsoft.Office.Interop.Outlook.OlFormRegionSize formRegionSize)
            {
                System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TaskFormRegion));
                return (byte[])resources.GetObject("TaskFormRegionImport");
            }

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            bool Microsoft.Office.Tools.Outlook.IFormRegionFactory.IsDisplayedForItem(object outlookItem, Microsoft.Office.Interop.Outlook.OlFormRegionMode formRegionMode, Microsoft.Office.Interop.Outlook.OlFormRegionSize formRegionSize)
            {
                if (this.FormRegionInitializing != null)
                {
                    Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs cancelArgs = Globals.Factory.CreateFormRegionInitializingEventArgs(outlookItem, formRegionMode, formRegionSize, false);
                    this.FormRegionInitializing(this, cancelArgs);
                    return !cancelArgs.Cancel;
                }
                else
                {
                    return true;
                }
            }

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            Microsoft.Office.Tools.Outlook.FormRegionKindConstants Microsoft.Office.Tools.Outlook.IFormRegionFactory.Kind
            {
                get
                {
                    return Microsoft.Office.Tools.Outlook.FormRegionKindConstants.Ofs;
                }
            }
        }

        //public partial class TaskFormRegionFactory : Microsoft.Office.Tools.Outlook.IFormRegionFactory
        //{
        //    public event System.EventHandler<Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs> FormRegionInitializing;

        //    private Microsoft.Office.Tools.Outlook.FormRegionManifest _Manifest;

        //    public TaskFormRegionFactory()
        //    {
        //        this._Manifest = new Microsoft.Office.Tools.Outlook.FormRegionManifest();
        //        this.InitializeManifest();
        //        this.FormRegionInitializing += new System.EventHandler<Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs>(this.TaskFormRegionFactory_FormRegionInitializing);
        //    }

        //    public Microsoft.Office.Tools.Outlook.FormRegionManifest Manifest
        //    {
        //        get
        //        {
        //            return this._Manifest;
        //        }
        //    }

        //    Microsoft.Office.Tools.Outlook.IFormRegion Microsoft.Office.Tools.Outlook.IFormRegionFactory.CreateFormRegion(Microsoft.Office.Interop.Outlook.FormRegion formRegion)
        //    {
        //        TaskFormRegion form = new TaskFormRegion(formRegion);
        //        form.Factory = this;
        //        return form;
        //    }

        //    byte[] Microsoft.Office.Tools.Outlook.IFormRegionFactory.GetFormRegionStorage(object outlookItem, Microsoft.Office.Interop.Outlook.OlFormRegionMode formRegionMode, Microsoft.Office.Interop.Outlook.OlFormRegionSize formRegionSize)
        //    {
        //        System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TaskFormRegion));
        //        return (byte[])resources.GetObject("TaskFormRegion");
        //    }

        //    bool Microsoft.Office.Tools.Outlook.IFormRegionFactory.IsDisplayedForItem(object outlookItem, Microsoft.Office.Interop.Outlook.OlFormRegionMode formRegionMode, Microsoft.Office.Interop.Outlook.OlFormRegionSize formRegionSize)
        //    {
        //        if (this.FormRegionInitializing != null)
        //        {
        //            Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs cancelArgs = new Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs(outlookItem, formRegionMode, formRegionSize, false);
        //            this.FormRegionInitializing(this, cancelArgs);
        //            return !cancelArgs.Cancel;
        //        }
        //        else
        //        {
        //            return true;
        //        }
        //    }

        //    string Microsoft.Office.Tools.Outlook.IFormRegionFactory.Kind
        //    {
        //        get
        //        {
        //            return Microsoft.Office.Tools.Outlook.FormRegionKindConstants.Ofs;
        //        }
        //    }
        //}
    }

    partial class WindowFormRegionCollection
    {
        internal TaskFormRegion TaskFormRegion
        {
            get
            {
                foreach (var item in this)
                {
                    if (item.GetType() == typeof(TaskFormRegion))
                        return (TaskFormRegion)item;
                }
                return null;
            }
        }
    }

}
