namespace Lab1_task2
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
            this.label4 = new System.Windows.Forms.Label();
            this.Kurs = new System.Windows.Forms.TextBox();
            this.Agree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(79, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Write kurs (1-4)";
            // 
            // Kurs
            // 
            this.Kurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kurs.Location = new System.Drawing.Point(73, 117);
            this.Kurs.Name = "Kurs";
            this.Kurs.Size = new System.Drawing.Size(138, 26);
            this.Kurs.TabIndex = 16;
            // 
            // Agree
            // 
            this.Agree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Agree.Location = new System.Drawing.Point(83, 179);
            this.Agree.Name = "Agree";
            this.Agree.Size = new System.Drawing.Size(113, 32);
            this.Agree.TabIndex = 17;
            this.Agree.Text = "Ok";
            this.Agree.UseVisualStyleBackColor = true;
            this.Agree.Click += new System.EventHandler(this.Agree_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Agree);
            this.Controls.Add(this.Kurs);
            this.Controls.Add(this.label4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Kurs;
        private System.Windows.Forms.Button Agree;
    }
}