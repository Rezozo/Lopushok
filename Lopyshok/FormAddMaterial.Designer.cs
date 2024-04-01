namespace Lopyshok
{
    partial class FormAddMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddMaterial));
            this.changeCostBtn = new System.Windows.Forms.Button();
            this.countTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // changeCostBtn
            // 
            this.changeCostBtn.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeCostBtn.Location = new System.Drawing.Point(106, 257);
            this.changeCostBtn.Name = "changeCostBtn";
            this.changeCostBtn.Size = new System.Drawing.Size(247, 53);
            this.changeCostBtn.TabIndex = 37;
            this.changeCostBtn.Text = "Добавить";
            this.changeCostBtn.UseVisualStyleBackColor = true;
            this.changeCostBtn.Click += new System.EventHandler(this.changeCostBtn_Click);
            // 
            // countTxt
            // 
            this.countTxt.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countTxt.Location = new System.Drawing.Point(68, 199);
            this.countTxt.MaxLength = 200;
            this.countTxt.Name = "countTxt";
            this.countTxt.Size = new System.Drawing.Size(314, 38);
            this.countTxt.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(107, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 51);
            this.label1.TabIndex = 35;
            this.label1.Text = "Добавление материала";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(62, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 33);
            this.label3.TabIndex = 38;
            this.label3.Text = "Количество";
            // 
            // typeBox
            // 
            this.typeBox.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(68, 121);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(314, 39);
            this.typeBox.TabIndex = 47;
            // 
            // FormAddMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(454, 391);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.changeCostBtn);
            this.Controls.Add(this.countTxt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Gabriola", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "FormAddMaterial";
            this.Text = "Добавление материала";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeCostBtn;
        private System.Windows.Forms.TextBox countTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typeBox;
    }
}