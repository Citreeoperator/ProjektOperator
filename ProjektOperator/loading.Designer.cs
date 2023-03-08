namespace ProjektOperator
{
    partial class loading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loading));
            this.pb_load = new System.Windows.Forms.ProgressBar();
            this.tmr_loading = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pb_load
            // 
            this.pb_load.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb_load.Location = new System.Drawing.Point(0, 453);
            this.pb_load.Name = "pb_load";
            this.pb_load.Size = new System.Drawing.Size(680, 26);
            this.pb_load.TabIndex = 0;
            this.pb_load.Visible = false;
            // 
            // tmr_loading
            // 
            this.tmr_loading.Enabled = true;
            this.tmr_loading.Tick += new System.EventHandler(this.tmr_loading_Tick);
            // 
            // loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(79)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(680, 479);
            this.Controls.Add(this.pb_load);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loading";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loading";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb_load;
        private System.Windows.Forms.Timer tmr_loading;
    }
}