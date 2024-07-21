namespace NoteApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            delete = new Button();
            checkedListBox1 = new CheckedListBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // delete
            // 
            delete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete.Location = new Point(12, 254);
            delete.Name = "delete";
            delete.Size = new Size(161, 44);
            delete.TabIndex = 18;
            delete.Text = "Delete Selected";
            delete.UseVisualStyleBackColor = true;
            delete.Click += DeleteAll;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(212, 203);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(535, 286);
            checkedListBox1.TabIndex = 17;
            checkedListBox1.Click += Notes;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(212, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 31);
            textBox1.TabIndex = 16;
            textBox1.Click += AddNote;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(641, 128);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(106, 52);
            button2.TabIndex = 15;
            button2.Text = "Clear List";
            button2.UseVisualStyleBackColor = false;
            button2.Click += ClearList;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(516, 128);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(106, 52);
            button1.TabIndex = 14;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Submit;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(847, 432);
            button4.Name = "button4";
            button4.Size = new Size(94, 57);
            button4.TabIndex = 20;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            button4.Click += SaveButton;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(962, 501);
            Controls.Add(button4);
            Controls.Add(delete);
            Controls.Add(checkedListBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Notes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox title;
        private Button delete;
        private CheckedListBox checkedListBox1;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Button button4;
    }
}
