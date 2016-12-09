namespace H5Fix
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
            this.setFov = new System.Windows.Forms.Button();
            this.fovBox = new System.Windows.Forms.TextBox();
            this.FPSBox = new System.Windows.Forms.TextBox();
            this.setFPS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // setFov
            // 
            this.setFov.Location = new System.Drawing.Point(197, 12);
            this.setFov.Name = "setFov";
            this.setFov.Size = new System.Drawing.Size(75, 23);
            this.setFov.TabIndex = 0;
            this.setFov.Text = "Set FOV";
            this.setFov.UseVisualStyleBackColor = true;
            this.setFov.Click += new System.EventHandler(this.setFov_Click);
            // 
            // fovBox
            // 
            this.fovBox.Location = new System.Drawing.Point(12, 15);
            this.fovBox.Name = "fovBox";
            this.fovBox.Size = new System.Drawing.Size(179, 20);
            this.fovBox.TabIndex = 1;
            // 
            // FPSBox
            // 
            this.FPSBox.Location = new System.Drawing.Point(12, 53);
            this.FPSBox.Name = "FPSBox";
            this.FPSBox.Size = new System.Drawing.Size(179, 20);
            this.FPSBox.TabIndex = 3;
            // 
            // setFPS
            // 
            this.setFPS.Location = new System.Drawing.Point(197, 50);
            this.setFPS.Name = "setFPS";
            this.setFPS.Size = new System.Drawing.Size(75, 23);
            this.setFPS.TabIndex = 2;
            this.setFPS.Text = "Set FPS";
            this.setFPS.UseVisualStyleBackColor = true;
            this.setFPS.Click += new System.EventHandler(this.setFPS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 99);
            this.Controls.Add(this.FPSBox);
            this.Controls.Add(this.setFPS);
            this.Controls.Add(this.fovBox);
            this.Controls.Add(this.setFov);
            this.Name = "Form1";
            this.Text = "H5Fix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setFov;
        private System.Windows.Forms.TextBox fovBox;
        private System.Windows.Forms.TextBox FPSBox;
        private System.Windows.Forms.Button setFPS;
    }
}

