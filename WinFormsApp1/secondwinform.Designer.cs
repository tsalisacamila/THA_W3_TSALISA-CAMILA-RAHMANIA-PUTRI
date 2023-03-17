namespace WinFormsApp1
{
    partial class Second_win_form
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
            label_pickbackground = new Label();
            radioButton_pink = new RadioButton();
            radioButton_brown = new RadioButton();
            radioButton_orange = new RadioButton();
            radioButton_blue = new RadioButton();
            radioButton_white = new RadioButton();
            label_picktext = new Label();
            radioButton_black = new RadioButton();
            radioButton_red = new RadioButton();
            radioButton_green = new RadioButton();
            cB_agree = new CheckBox();
            cB_choice = new CheckBox();
            button_magic = new Button();
            label_hi = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label_pickbackground
            // 
            label_pickbackground.AutoSize = true;
            label_pickbackground.Location = new Point(27, 34);
            label_pickbackground.Name = "label_pickbackground";
            label_pickbackground.Size = new Size(202, 15);
            label_pickbackground.TabIndex = 0;
            label_pickbackground.Text = "Pick your favorite background color :";
            label_pickbackground.Click += label_pickbackground_Click;
            // 
            // radioButton_pink
            // 
            radioButton_pink.AutoSize = true;
            radioButton_pink.Location = new Point(27, 63);
            radioButton_pink.Name = "radioButton_pink";
            radioButton_pink.Size = new Size(48, 19);
            radioButton_pink.TabIndex = 1;
            radioButton_pink.TabStop = true;
            radioButton_pink.Text = "Pink";
            radioButton_pink.UseVisualStyleBackColor = true;
            // 
            // radioButton_brown
            // 
            radioButton_brown.AutoSize = true;
            radioButton_brown.Location = new Point(95, 63);
            radioButton_brown.Name = "radioButton_brown";
            radioButton_brown.Size = new Size(59, 19);
            radioButton_brown.TabIndex = 2;
            radioButton_brown.TabStop = true;
            radioButton_brown.Text = "Brown";
            radioButton_brown.UseVisualStyleBackColor = true;
            radioButton_brown.CheckedChanged += radioButton_brown_CheckedChanged;
            // 
            // radioButton_orange
            // 
            radioButton_orange.AutoSize = true;
            radioButton_orange.Location = new Point(178, 63);
            radioButton_orange.Name = "radioButton_orange";
            radioButton_orange.Size = new Size(64, 19);
            radioButton_orange.TabIndex = 3;
            radioButton_orange.TabStop = true;
            radioButton_orange.Text = "Orange";
            radioButton_orange.UseVisualStyleBackColor = true;
            // 
            // radioButton_blue
            // 
            radioButton_blue.AutoSize = true;
            radioButton_blue.Location = new Point(266, 63);
            radioButton_blue.Name = "radioButton_blue";
            radioButton_blue.Size = new Size(48, 19);
            radioButton_blue.TabIndex = 4;
            radioButton_blue.TabStop = true;
            radioButton_blue.Text = "Blue";
            radioButton_blue.UseVisualStyleBackColor = true;
            // 
            // radioButton_white
            // 
            radioButton_white.AutoSize = true;
            radioButton_white.Location = new Point(339, 63);
            radioButton_white.Name = "radioButton_white";
            radioButton_white.Size = new Size(56, 19);
            radioButton_white.TabIndex = 5;
            radioButton_white.TabStop = true;
            radioButton_white.Text = "White";
            radioButton_white.UseVisualStyleBackColor = true;
            // 
            // label_picktext
            // 
            label_picktext.AutoSize = true;
            label_picktext.Location = new Point(27, 137);
            label_picktext.Name = "label_picktext";
            label_picktext.Size = new Size(95, 15);
            label_picktext.TabIndex = 6;
            label_picktext.Text = "Pick text colour :";
            // 
            // radioButton_black
            // 
            radioButton_black.AutoSize = true;
            radioButton_black.Location = new Point(3, 4);
            radioButton_black.Name = "radioButton_black";
            radioButton_black.Size = new Size(53, 19);
            radioButton_black.TabIndex = 7;
            radioButton_black.TabStop = true;
            radioButton_black.Text = "Black";
            radioButton_black.UseVisualStyleBackColor = true;
            // 
            // radioButton_red
            // 
            radioButton_red.AutoSize = true;
            radioButton_red.Location = new Point(75, 4);
            radioButton_red.Name = "radioButton_red";
            radioButton_red.Size = new Size(45, 19);
            radioButton_red.TabIndex = 8;
            radioButton_red.TabStop = true;
            radioButton_red.Text = "Red";
            radioButton_red.UseVisualStyleBackColor = true;
            // 
            // radioButton_green
            // 
            radioButton_green.AutoSize = true;
            radioButton_green.Location = new Point(141, 4);
            radioButton_green.Name = "radioButton_green";
            radioButton_green.Size = new Size(56, 19);
            radioButton_green.TabIndex = 9;
            radioButton_green.TabStop = true;
            radioButton_green.Text = "Green";
            radioButton_green.UseVisualStyleBackColor = true;
            radioButton_green.CheckedChanged += radioButton_green_CheckedChanged;
            // 
            // cB_agree
            // 
            cB_agree.AutoSize = true;
            cB_agree.Location = new Point(24, 222);
            cB_agree.Name = "cB_agree";
            cB_agree.Size = new Size(205, 19);
            cB_agree.TabIndex = 10;
            cB_agree.Text = "I agree to the Terms of Agreement";
            cB_agree.UseVisualStyleBackColor = true;
            cB_agree.CheckedChanged += cB_agree_CheckedChanged;
            // 
            // cB_choice
            // 
            cB_choice.AutoSize = true;
            cB_choice.Location = new Point(22, 247);
            cB_choice.Name = "cB_choice";
            cB_choice.Size = new Size(207, 19);
            cB_choice.TabIndex = 11;
            cB_choice.Text = "All the choice I pick above are true";
            cB_choice.UseVisualStyleBackColor = true;
            // 
            // button_magic
            // 
            button_magic.Enabled = false;
            button_magic.Location = new Point(278, 286);
            button_magic.Name = "button_magic";
            button_magic.Size = new Size(75, 23);
            button_magic.TabIndex = 12;
            button_magic.Text = "MAGIC";
            button_magic.UseVisualStyleBackColor = true;
            button_magic.Click += button_magic_Click;
            // 
            // label_hi
            // 
            label_hi.AutoSize = true;
            label_hi.Location = new Point(70, 9);
            label_hi.Name = "label_hi";
            label_hi.Size = new Size(227, 15);
            label_hi.TabIndex = 13;
            label_hi.Text = "Hi, my name is...and my favorite artist is...";
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton_black);
            panel1.Controls.Add(radioButton_red);
            panel1.Controls.Add(radioButton_green);
            panel1.Location = new Point(24, 155);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 61);
            panel1.TabIndex = 14;
            // 
            // Second_win_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label_hi);
            Controls.Add(button_magic);
            Controls.Add(cB_choice);
            Controls.Add(cB_agree);
            Controls.Add(label_picktext);
            Controls.Add(radioButton_white);
            Controls.Add(radioButton_blue);
            Controls.Add(radioButton_orange);
            Controls.Add(radioButton_brown);
            Controls.Add(radioButton_pink);
            Controls.Add(label_pickbackground);
            Name = "Second_win_form";
            Text = "secondwinform";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_pickbackground;
        private RadioButton radioButton_pink;
        private RadioButton radioButton_brown;
        private RadioButton radioButton_orange;
        private RadioButton radioButton_blue;
        private RadioButton radioButton_white;
        private Label label_picktext;
        private RadioButton radioButton_black;
        private RadioButton radioButton_red;
        private RadioButton radioButton_green;
        private CheckBox cB_agree;
        private CheckBox cB_choice;
        private Button button_magic;
        private Label label_hi;
        private Panel panel1;
    }
}