
namespace ConnectFourApp
{
    partial class ConnectFourBoard
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connect Four";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel.Location = new System.Drawing.Point(71, 122);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1073, 854);
            this.panel.TabIndex = 1;
            // 
            // ConnectFourBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 1144);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label1);
            this.Name = "ConnectFourBoard";
            this.Text = "ConnectFour";
            this.Load += new System.EventHandler(this.ConnectFourBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
    }
}

