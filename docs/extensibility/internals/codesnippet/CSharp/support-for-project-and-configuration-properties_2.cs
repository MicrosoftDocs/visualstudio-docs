        public bool IsDirty { get; set; }
        private string myConfigProp;

        [Category("My Category")]
        [DisplayName("My Config Property")]
        [Description("My Description")]
        public string MyConfigProp
        {
            get { return myConfigProp; }
            set { myConfigProp = value; IsDirty = true; }
        }