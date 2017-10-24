        public void Start()
        {
            if (this.Model != "Not specified" || this.TopSpeed != -1)
                this.IsRunning = true;
            else
                this.IsRunning = false;
        }