namespace WinFormsApp1
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
            button_onf = new Button();
            label_name = new Label();
            label_mfa = new Label();
            textBox_name = new TextBox();
            textBox_mfa = new TextBox();
            checkBox_form = new CheckBox();
            button_submit = new Button();
            SuspendLayout();
            // 
            // button_onf
            // 
            button_onf.Location = new Point(35, 371);
            button_onf.Name = "button_onf";
            button_onf.Size = new Size(147, 23);
            button_onf.TabIndex = 0;
            button_onf.TabStop = false;
            button_onf.Text = "Open Next Form";
            button_onf.UseVisualStyleBackColor = true;
            button_onf.Click += button1_Click;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(26, 44);
            label_name.Name = "label_name";
            label_name.Size = new Size(45, 15);
            label_name.TabIndex = 1;
            label_name.Text = "Name :";
            // 
            // label_mfa
            // 
            label_mfa.AutoSize = true;
            label_mfa.Location = new Point(26, 98);
            label_mfa.Name = "label_mfa";
            label_mfa.Size = new Size(106, 15);
            label_mfa.TabIndex = 2;
            label_mfa.Text = "My Favorite Artist :";
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(77, 41);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(189, 23);
            textBox_name.TabIndex = 3;
            // 
            // textBox_mfa
            // 
            textBox_mfa.Location = new Point(138, 95);
            textBox_mfa.Name = "textBox_mfa";
            textBox_mfa.Size = new Size(128, 23);
            textBox_mfa.TabIndex = 4;
            textBox_mfa.TextChanged += textBox2_TextChanged;
            // 
            // checkBox_form
            // 
            checkBox_form.AutoSize = true;
            checkBox_form.Location = new Point(35, 170);
            checkBox_form.Name = "checkBox_form";
            checkBox_form.Size = new Size(218, 19);
            checkBox_form.TabIndex = 5;
            checkBox_form.Text = "All of the content I put above is true!";
            checkBox_form.UseVisualStyleBackColor = true;
            checkBox_form.CheckedChanged += checkBox_form_CheckedChanged;
            // 
            // button_submit
            // 
            button_submit.Enabled = false;
            button_submit.Location = new Point(657, 371);
            button_submit.Name = "button_submit";
            button_submit.Size = new Size(75, 23);
            button_submit.TabIndex = 6;
            button_submit.Text = "Submit";
            button_submit.UseVisualStyleBackColor = true;
            button_submit.Click += button_submit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_submit);
            Controls.Add(checkBox_form);
            Controls.Add(textBox_mfa);
            Controls.Add(textBox_name);
            Controls.Add(label_mfa);
            Controls.Add(label_name);
            Controls.Add(button_onf);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_onf;
        private Label label_name;
        private Label label_mfa;
        private TextBox textBox_name;
        private TextBox textBox_mfa;
        private CheckBox checkBox_form;
        private Button button_submit;
    }
}