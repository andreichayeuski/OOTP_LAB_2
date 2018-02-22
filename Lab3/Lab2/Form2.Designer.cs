namespace Lab2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Search_button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Company_textBox = new System.Windows.Forms.TextBox();
            this.Capacity_textBox = new System.Windows.Forms.TextBox();
            this.Type_Listbox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchResult_List = new System.Windows.Forms.ListBox();
            this.Space_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(214, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write, what you will find";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Airplane company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Airplane\'s type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(26, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Count of spaces";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(26, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "      Airplane\'s load-\r\ncarrying capacity (kg)";
            // 
            // Search_button
            // 
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_button.Location = new System.Drawing.Point(218, 331);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(85, 42);
            this.Search_button.TabIndex = 5;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_button.Location = new System.Drawing.Point(362, 331);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(85, 42);
            this.Clear_button.TabIndex = 6;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Company_textBox
            // 
            this.Company_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Company_textBox.Location = new System.Drawing.Point(250, 91);
            this.Company_textBox.Name = "Company_textBox";
            this.Company_textBox.Size = new System.Drawing.Size(121, 24);
            this.Company_textBox.TabIndex = 7;
            // 
            // Capacity_textBox
            // 
            this.Capacity_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Capacity_textBox.Location = new System.Drawing.Point(250, 283);
            this.Capacity_textBox.Name = "Capacity_textBox";
            this.Capacity_textBox.Size = new System.Drawing.Size(121, 24);
            this.Capacity_textBox.TabIndex = 8;
            // 
            // Type_Listbox
            // 
            this.Type_Listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type_Listbox.FormattingEnabled = true;
            this.Type_Listbox.Location = new System.Drawing.Point(250, 153);
            this.Type_Listbox.Name = "Type_Listbox";
            this.Type_Listbox.Size = new System.Drawing.Size(121, 26);
            this.Type_Listbox.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(237, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Result of search";
            // 
            // SearchResult_List
            // 
            this.SearchResult_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchResult_List.FormattingEnabled = true;
            this.SearchResult_List.ItemHeight = 15;
            this.SearchResult_List.Location = new System.Drawing.Point(12, 446);
            this.SearchResult_List.Name = "SearchResult_List";
            this.SearchResult_List.Size = new System.Drawing.Size(583, 109);
            this.SearchResult_List.TabIndex = 44;
            // 
            // Space_textBox
            // 
            this.Space_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Space_textBox.Location = new System.Drawing.Point(250, 217);
            this.Space_textBox.Name = "Space_textBox";
            this.Space_textBox.Size = new System.Drawing.Size(121, 24);
            this.Space_textBox.TabIndex = 45;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 578);
            this.Controls.Add(this.Space_textBox);
            this.Controls.Add(this.SearchResult_List);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Type_Listbox);
            this.Controls.Add(this.Capacity_textBox);
            this.Controls.Add(this.Company_textBox);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.TextBox Company_textBox;
        private System.Windows.Forms.TextBox Capacity_textBox;
        private System.Windows.Forms.ComboBox Type_Listbox;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ListBox SearchResult_List;
        private System.Windows.Forms.TextBox Space_textBox;
    }
}