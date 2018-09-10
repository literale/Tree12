namespace Tree1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.tbDelete = new System.Windows.Forms.TextBox();
            this.BtnSortAr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(1167, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(86, 648);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(1000, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(161, 45);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Создать дерево";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(1000, 76);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(161, 45);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Найти узел";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1000, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 45);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавит узел";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1000, 291);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 45);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить узел";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(1001, 611);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(161, 45);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.Text = "Завершить";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(1001, 401);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(161, 45);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "Сортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(1000, 137);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(160, 26);
            this.tbFind.TabIndex = 7;
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(1000, 242);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(160, 26);
            this.tbAdd.TabIndex = 8;
            // 
            // tbDelete
            // 
            this.tbDelete.Location = new System.Drawing.Point(1001, 354);
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(160, 26);
            this.tbDelete.TabIndex = 9;
            // 
            // BtnSortAr
            // 
            this.BtnSortAr.Location = new System.Drawing.Point(12, 601);
            this.BtnSortAr.Name = "BtnSortAr";
            this.BtnSortAr.Size = new System.Drawing.Size(177, 57);
            this.BtnSortAr.TabIndex = 10;
            this.BtnSortAr.Text = "Сортировать последовательность";
            this.BtnSortAr.UseVisualStyleBackColor = true;
            this.BtnSortAr.Click += new System.EventHandler(this.BtnSortAr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1269, 668);
            this.Controls.Add(this.BtnSortAr);
            this.Controls.Add(this.tbDelete);
            this.Controls.Add(this.tbAdd);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.TextBox tbDelete;
        private System.Windows.Forms.Button BtnSortAr;
    }
}

