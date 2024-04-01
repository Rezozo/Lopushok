namespace Lopyshok
{
    partial class FormChangeCost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeCost));
            this.label1 = new System.Windows.Forms.Label();
            this.costTxt = new System.Windows.Forms.TextBox();
            this.changeCostBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(110, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 51);
            this.label1.TabIndex = 32;
            this.label1.Text = "Укажите стоимость";
            // 
            // costTxt
            // 
            this.costTxt.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costTxt.Location = new System.Drawing.Point(62, 89);
            this.costTxt.MaxLength = 200;
            this.costTxt.Name = "costTxt";
            this.costTxt.Size = new System.Drawing.Size(314, 38);
            this.costTxt.TabIndex = 33;
            // 
            // changeCostBtn
            // 
            this.changeCostBtn.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeCostBtn.Location = new System.Drawing.Point(92, 151);
            this.changeCostBtn.Name = "changeCostBtn";
            this.changeCostBtn.Size = new System.Drawing.Size(247, 53);
            this.changeCostBtn.TabIndex = 34;
            this.changeCostBtn.Text = "Изменить стоимость";
            this.changeCostBtn.UseVisualStyleBackColor = true;
            this.changeCostBtn.Click += new System.EventHandler(this.changeCostBtn_Click);
            // 
            // FormChangeCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(440, 261);
            this.Controls.Add(this.changeCostBtn);
            this.Controls.Add(this.costTxt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(458, 308);
            this.MinimumSize = new System.Drawing.Size(458, 308);
            this.Name = "FormChangeCost";
            this.Text = "Изменение стоимости";
            this.Load += new System.EventHandler(this.FormChangeCost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox costTxt;
        private System.Windows.Forms.Button changeCostBtn;
    }
}