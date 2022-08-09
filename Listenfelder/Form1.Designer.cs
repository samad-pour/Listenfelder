namespace Listenfelder
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
            this.lst_left = new System.Windows.Forms.ListBox();
            this.lst_right = new System.Windows.Forms.ListBox();
            this.btn_to_right = new System.Windows.Forms.Button();
            this.btn_to_left = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_left
            // 
            this.lst_left.FormattingEnabled = true;
            this.lst_left.ItemHeight = 15;
            this.lst_left.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n"});
            this.lst_left.Location = new System.Drawing.Point(12, 12);
            this.lst_left.Name = "lst_left";
            this.lst_left.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_left.Size = new System.Drawing.Size(120, 94);
            this.lst_left.TabIndex = 0;
            // 
            // lst_right
            // 
            this.lst_right.FormattingEnabled = true;
            this.lst_right.ItemHeight = 15;
            this.lst_right.Items.AddRange(new object[] {
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "x",
            "y",
            "z"});
            this.lst_right.Location = new System.Drawing.Point(233, 12);
            this.lst_right.Name = "lst_right";
            this.lst_right.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_right.Size = new System.Drawing.Size(120, 94);
            this.lst_right.TabIndex = 1;
            // 
            // btn_to_right
            // 
            this.btn_to_right.Location = new System.Drawing.Point(145, 12);
            this.btn_to_right.Name = "btn_to_right";
            this.btn_to_right.Size = new System.Drawing.Size(75, 23);
            this.btn_to_right.TabIndex = 2;
            this.btn_to_right.Text = ">>";
            this.btn_to_right.UseVisualStyleBackColor = true;
            this.btn_to_right.Click += new System.EventHandler(this.btn_to_right_Click);
            // 
            // btn_to_left
            // 
            this.btn_to_left.Location = new System.Drawing.Point(145, 41);
            this.btn_to_left.Name = "btn_to_left";
            this.btn_to_left.Size = new System.Drawing.Size(75, 23);
            this.btn_to_left.TabIndex = 3;
            this.btn_to_left.Text = "<<";
            this.btn_to_left.UseVisualStyleBackColor = true;
            this.btn_to_left.Click += new System.EventHandler(this.btn_to_left_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 106);
            this.Controls.Add(this.btn_to_left);
            this.Controls.Add(this.btn_to_right);
            this.Controls.Add(this.lst_right);
            this.Controls.Add(this.lst_left);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lst_left;
        private ListBox lst_right;
        private Button btn_to_right;
        private Button btn_to_left;
    }
}