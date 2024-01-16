namespace TerraformLauncherApp
{
    partial class Form1
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
            this.btnRunTerraform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRunTerraform
            // 
            this.btnRunTerraform.Location = new System.Drawing.Point(231, 138);
            this.btnRunTerraform.Name = "btnRunTerraform";
            this.btnRunTerraform.Size = new System.Drawing.Size(258, 74);
            this.btnRunTerraform.TabIndex = 0;
            this.btnRunTerraform.Text = "Run Terrraform";
            this.btnRunTerraform.UseVisualStyleBackColor = true;
            this.btnRunTerraform.Click += new System.EventHandler(this.btnRunTerraform_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRunTerraform);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRunTerraform;
    }
}

