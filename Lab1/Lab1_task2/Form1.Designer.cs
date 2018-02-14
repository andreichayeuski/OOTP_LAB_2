namespace Lab1_task2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.TextBox();
            this.Generation = new System.Windows.Forms.Button();
            this.Sort_Ascending = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Sort_Descending = new System.Windows.Forms.Button();
            this.Query_First = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Query_Second = new System.Windows.Forms.Button();
            this.Query_Third = new System.Windows.Forms.Button();
            this.Collection_Original = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Collection_Sorted = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Collection_Result = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(167, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Count of elements";
            // 
            // Count
            // 
            this.Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count.Location = new System.Drawing.Point(328, 31);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(138, 26);
            this.Count.TabIndex = 1;
            // 
            // Generation
            // 
            this.Generation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generation.Location = new System.Drawing.Point(502, 28);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(102, 32);
            this.Generation.TabIndex = 2;
            this.Generation.Text = "Generate";
            this.Generation.UseVisualStyleBackColor = true;
            this.Generation.Click += new System.EventHandler(this.Generation_Click);
            // 
            // Sort_Ascending
            // 
            this.Sort_Ascending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sort_Ascending.Location = new System.Drawing.Point(303, 188);
            this.Sort_Ascending.Name = "Sort_Ascending";
            this.Sort_Ascending.Size = new System.Drawing.Size(118, 34);
            this.Sort_Ascending.TabIndex = 4;
            this.Sort_Ascending.Text = "ascending";
            this.Sort_Ascending.UseVisualStyleBackColor = true;
            this.Sort_Ascending.Click += new System.EventHandler(this.Sort_Ascending_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(167, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "sort";
            // 
            // Sort_Descending
            // 
            this.Sort_Descending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sort_Descending.Location = new System.Drawing.Point(486, 188);
            this.Sort_Descending.Name = "Sort_Descending";
            this.Sort_Descending.Size = new System.Drawing.Size(118, 34);
            this.Sort_Descending.TabIndex = 6;
            this.Sort_Descending.Text = "descending";
            this.Sort_Descending.UseVisualStyleBackColor = true;
            this.Sort_Descending.Click += new System.EventHandler(this.Sort_Descending_Click);
            // 
            // Query_First
            // 
            this.Query_First.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Query_First.Location = new System.Drawing.Point(270, 356);
            this.Query_First.Name = "Query_First";
            this.Query_First.Size = new System.Drawing.Size(92, 42);
            this.Query_First.TabIndex = 8;
            this.Query_First.Text = "query №1";
            this.Query_First.UseVisualStyleBackColor = true;
            this.Query_First.Click += new System.EventHandler(this.Query_First_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(167, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "LINQ";
            // 
            // Query_Second
            // 
            this.Query_Second.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Query_Second.Location = new System.Drawing.Point(392, 356);
            this.Query_Second.Name = "Query_Second";
            this.Query_Second.Size = new System.Drawing.Size(92, 42);
            this.Query_Second.TabIndex = 10;
            this.Query_Second.Text = "query №2";
            this.Query_Second.UseVisualStyleBackColor = true;
            this.Query_Second.Click += new System.EventHandler(this.Query_Second_Click);
            // 
            // Query_Third
            // 
            this.Query_Third.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Query_Third.Location = new System.Drawing.Point(512, 356);
            this.Query_Third.Name = "Query_Third";
            this.Query_Third.Size = new System.Drawing.Size(92, 42);
            this.Query_Third.TabIndex = 11;
            this.Query_Third.Text = "query №3";
            this.Query_Third.UseVisualStyleBackColor = true;
            this.Query_Third.Click += new System.EventHandler(this.Query_Third_Click);
            // 
            // Collection_Original
            // 
            this.Collection_Original.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Collection_Original.FormattingEnabled = true;
            this.Collection_Original.ItemHeight = 18;
            this.Collection_Original.Location = new System.Drawing.Point(328, 85);
            this.Collection_Original.Name = "Collection_Original";
            this.Collection_Original.Size = new System.Drawing.Size(242, 76);
            this.Collection_Original.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(168, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Your collection";
            // 
            // Collection_Sorted
            // 
            this.Collection_Sorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Collection_Sorted.FormattingEnabled = true;
            this.Collection_Sorted.ItemHeight = 18;
            this.Collection_Sorted.Location = new System.Drawing.Point(328, 250);
            this.Collection_Sorted.Name = "Collection_Sorted";
            this.Collection_Sorted.Size = new System.Drawing.Size(242, 76);
            this.Collection_Sorted.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(168, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sorted collection";
            // 
            // Collection_Result
            // 
            this.Collection_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Collection_Result.FormattingEnabled = true;
            this.Collection_Result.ItemHeight = 18;
            this.Collection_Result.Location = new System.Drawing.Point(328, 434);
            this.Collection_Result.Name = "Collection_Result";
            this.Collection_Result.Size = new System.Drawing.Size(242, 76);
            this.Collection_Result.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(168, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Query result";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(625, 561);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(102, 32);
            this.Exit.TabIndex = 19;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 630);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Collection_Result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Collection_Sorted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Collection_Original);
            this.Controls.Add(this.Query_Third);
            this.Controls.Add(this.Query_Second);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Query_First);
            this.Controls.Add(this.Sort_Descending);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sort_Ascending);
            this.Controls.Add(this.Generation);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.Button Generation;
        private System.Windows.Forms.Button Sort_Ascending;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Sort_Descending;
        private System.Windows.Forms.Button Query_First;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Query_Second;
        private System.Windows.Forms.Button Query_Third;
        private System.Windows.Forms.ListBox Collection_Original;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Collection_Sorted;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox Collection_Result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Exit;
    }
}

