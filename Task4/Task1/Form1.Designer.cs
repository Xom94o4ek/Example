namespace Task1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.helpTextbox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.checkGroupTextbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkGroup = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.view_richTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpTextbox
            // 
            this.helpTextbox.Location = new System.Drawing.Point(25, 15);
            this.helpTextbox.Name = "helpTextbox";
            this.helpTextbox.Size = new System.Drawing.Size(296, 20);
            this.helpTextbox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddButton.Location = new System.Drawing.Point(337, 15);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.helpTextbox);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(534, 43);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.deleteButton.Location = new System.Drawing.Point(422, 15);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(12, 313);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(534, 169);
            this.resultTextBox.TabIndex = 8;
            this.resultTextBox.Text = "";
            // 
            // checkGroupTextbox
            // 
            this.checkGroupTextbox.Location = new System.Drawing.Point(25, 18);
            this.checkGroupTextbox.Name = "checkGroupTextbox";
            this.checkGroupTextbox.Size = new System.Drawing.Size(296, 20);
            this.checkGroupTextbox.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkGroup);
            this.groupBox2.Controls.Add(this.browseButton);
            this.groupBox2.Controls.Add(this.checkGroupTextbox);
            this.groupBox2.Location = new System.Drawing.Point(12, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 54);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // checkGroup
            // 
            this.checkGroup.BackColor = System.Drawing.SystemColors.Control;
            this.checkGroup.Location = new System.Drawing.Point(422, 15);
            this.checkGroup.Name = "checkGroup";
            this.checkGroup.Size = new System.Drawing.Size(75, 23);
            this.checkGroup.TabIndex = 5;
            this.checkGroup.Text = "Check";
            this.checkGroup.UseVisualStyleBackColor = false;
            this.checkGroup.Click += new System.EventHandler(this.checkGroup_Click);
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.SystemColors.Control;
            this.browseButton.Location = new System.Drawing.Point(337, 15);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // view_richTextBox
            // 
            this.view_richTextBox.Location = new System.Drawing.Point(12, 130);
            this.view_richTextBox.Name = "view_richTextBox";
            this.view_richTextBox.ReadOnly = true;
            this.view_richTextBox.Size = new System.Drawing.Size(534, 166);
            this.view_richTextBox.TabIndex = 12;
            this.view_richTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 494);
            this.Controls.Add(this.view_richTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox helpTextbox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.TextBox checkGroupTextbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button checkGroup;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RichTextBox view_richTextBox;

    }
}

