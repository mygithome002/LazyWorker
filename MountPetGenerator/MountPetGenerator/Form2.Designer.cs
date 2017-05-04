namespace MountPetGenerator
{
    partial class Form2
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
            this.btnItemSetExtraSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnItemSetExtraClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnItemSetExtraSave
            // 
            this.btnItemSetExtraSave.Location = new System.Drawing.Point(264, 331);
            this.btnItemSetExtraSave.Name = "btnItemSetExtraSave";
            this.btnItemSetExtraSave.Size = new System.Drawing.Size(75, 23);
            this.btnItemSetExtraSave.TabIndex = 0;
            this.btnItemSetExtraSave.Text = "Save";
            this.btnItemSetExtraSave.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 152);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 152);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnItemSetExtraClose
            // 
            this.btnItemSetExtraClose.Location = new System.Drawing.Point(12, 331);
            this.btnItemSetExtraClose.Name = "btnItemSetExtraClose";
            this.btnItemSetExtraClose.Size = new System.Drawing.Size(75, 23);
            this.btnItemSetExtraClose.TabIndex = 4;
            this.btnItemSetExtraClose.Text = "Close";
            this.btnItemSetExtraClose.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 366);
            this.Controls.Add(this.btnItemSetExtraClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnItemSetExtraSave);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnItemSetExtraSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnItemSetExtraClose;
    }
}