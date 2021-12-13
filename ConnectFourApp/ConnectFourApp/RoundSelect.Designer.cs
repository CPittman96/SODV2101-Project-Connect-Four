
namespace ConnectFourApp
{
    partial class RoundSelect
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
            this.comboBoxRoundSelect = new System.Windows.Forms.ComboBox();
            this.lblRoundSelectTitle = new System.Windows.Forms.Label();
            this.btnRoundSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxRoundSelect
            // 
            this.comboBoxRoundSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoundSelect.FormattingEnabled = true;
            this.comboBoxRoundSelect.Location = new System.Drawing.Point(62, 49);
            this.comboBoxRoundSelect.Name = "comboBoxRoundSelect";
            this.comboBoxRoundSelect.Size = new System.Drawing.Size(121, 33);
            this.comboBoxRoundSelect.TabIndex = 0;
            // 
            // lblRoundSelectTitle
            // 
            this.lblRoundSelectTitle.AutoSize = true;
            this.lblRoundSelectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundSelectTitle.Location = new System.Drawing.Point(57, 9);
            this.lblRoundSelectTitle.Name = "lblRoundSelectTitle";
            this.lblRoundSelectTitle.Size = new System.Drawing.Size(246, 25);
            this.lblRoundSelectTitle.TabIndex = 1;
            this.lblRoundSelectTitle.Text = "Select number of rounds";
            // 
            // btnRoundSelect
            // 
            this.btnRoundSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoundSelect.Location = new System.Drawing.Point(207, 49);
            this.btnRoundSelect.Name = "btnRoundSelect";
            this.btnRoundSelect.Size = new System.Drawing.Size(96, 39);
            this.btnRoundSelect.TabIndex = 2;
            this.btnRoundSelect.Text = "Start";
            this.btnRoundSelect.UseVisualStyleBackColor = true;
            this.btnRoundSelect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRoundSelect_MouseClick);
            // 
            // RoundSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 139);
            this.Controls.Add(this.btnRoundSelect);
            this.Controls.Add(this.lblRoundSelectTitle);
            this.Controls.Add(this.comboBoxRoundSelect);
            this.Name = "RoundSelect";
            this.Text = "RoundSelect";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRoundSelect;
        private System.Windows.Forms.Label lblRoundSelectTitle;
        private System.Windows.Forms.Button btnRoundSelect;
    }
}