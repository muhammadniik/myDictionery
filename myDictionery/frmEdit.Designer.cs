
namespace myDictionery
{
    partial class frmEdit
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
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFarsi = new System.Windows.Forms.TextBox();
            this.btnApplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "English Word:";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(14, 18);
            this.txtEnglish.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.ReadOnly = true;
            this.txtEnglish.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEnglish.Size = new System.Drawing.Size(221, 27);
            this.txtEnglish.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(286, 152);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(76, 34);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Farsi Word:";
            // 
            // txtFarsi
            // 
            this.txtFarsi.Location = new System.Drawing.Point(14, 53);
            this.txtFarsi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFarsi.Multiline = true;
            this.txtFarsi.Name = "txtFarsi";
            this.txtFarsi.Size = new System.Drawing.Size(221, 136);
            this.txtFarsi.TabIndex = 1;
            // 
            // btnApplay
            // 
            this.btnApplay.Location = new System.Drawing.Point(287, 110);
            this.btnApplay.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnApplay.Name = "btnApplay";
            this.btnApplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnApplay.Size = new System.Drawing.Size(75, 34);
            this.btnApplay.TabIndex = 2;
            this.btnApplay.Text = "Applay";
            this.btnApplay.UseVisualStyleBackColor = true;
            this.btnApplay.Click += new System.EventHandler(this.btnApplay_Click);
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 193);
            this.Controls.Add(this.btnApplay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtFarsi);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFarsi;
        private System.Windows.Forms.Button btnApplay;
    }
}