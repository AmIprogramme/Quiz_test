namespace Quiz
{
    partial class Welcome
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
            panel_general = new Panel();
            score_btn = new Button();
            start_btn = new Button();
            label1 = new Label();
            first_radio = new RadioButton();
            gb_for_new_page = new GroupBox();
            Fifth_radio = new RadioButton();
            Forth_radio = new RadioButton();
            third_radio = new RadioButton();
            second_radio = new RadioButton();
            panel_general.SuspendLayout();
            gb_for_new_page.SuspendLayout();
            SuspendLayout();
            // 
            // panel_general
            // 
            panel_general.Anchor = AnchorStyles.Top;
            panel_general.Controls.Add(score_btn);
            panel_general.Controls.Add(start_btn);
            panel_general.Controls.Add(label1);
            panel_general.Location = new Point(12, 36);
            panel_general.Name = "panel_general";
            panel_general.Size = new Size(920, 369);
            panel_general.TabIndex = 0;
            // 
            // score_btn
            // 
            score_btn.Font = new Font("MS Gothic", 15.75F);
            score_btn.Location = new Point(521, 175);
            score_btn.Name = "score_btn";
            score_btn.Size = new Size(181, 68);
            score_btn.TabIndex = 2;
            score_btn.Text = "Score";
            score_btn.UseVisualStyleBackColor = true;
            // 
            // start_btn
            // 
            start_btn.Font = new Font("MS Gothic", 15.75F);
            start_btn.Location = new Point(201, 175);
            start_btn.Name = "start_btn";
            start_btn.Size = new Size(181, 68);
            start_btn.TabIndex = 1;
            start_btn.Text = "Start game";
            start_btn.UseVisualStyleBackColor = true;
            start_btn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(282, 15);
            label1.Name = "label1";
            label1.Size = new Size(373, 29);
            label1.TabIndex = 0;
            label1.Text = "Welcome to a Random Quiz";
            // 
            // first_radio
            // 
            first_radio.AutoSize = true;
            first_radio.Checked = true;
            first_radio.Location = new Point(40, 14);
            first_radio.Name = "first_radio";
            first_radio.Size = new Size(14, 13);
            first_radio.TabIndex = 0;
            first_radio.TabStop = true;
            first_radio.UseVisualStyleBackColor = true;
            first_radio.CheckedChanged += first_radio_CheckedChanged;
            // 
            // gb_for_new_page
            // 
            gb_for_new_page.Anchor = AnchorStyles.Bottom;
            gb_for_new_page.Controls.Add(Fifth_radio);
            gb_for_new_page.Controls.Add(Forth_radio);
            gb_for_new_page.Controls.Add(third_radio);
            gb_for_new_page.Controls.Add(second_radio);
            gb_for_new_page.Controls.Add(first_radio);
            gb_for_new_page.Location = new Point(372, 411);
            gb_for_new_page.Name = "gb_for_new_page";
            gb_for_new_page.Size = new Size(168, 33);
            gb_for_new_page.TabIndex = 1;
            gb_for_new_page.TabStop = false;
            // 
            // Fifth_radio
            // 
            Fifth_radio.AutoSize = true;
            Fifth_radio.Location = new Point(120, 14);
            Fifth_radio.Name = "Fifth_radio";
            Fifth_radio.Size = new Size(14, 13);
            Fifth_radio.TabIndex = 4;
            Fifth_radio.UseVisualStyleBackColor = true;
            // 
            // Forth_radio
            // 
            Forth_radio.AutoSize = true;
            Forth_radio.Location = new Point(100, 14);
            Forth_radio.Name = "Forth_radio";
            Forth_radio.Size = new Size(14, 13);
            Forth_radio.TabIndex = 3;
            Forth_radio.UseVisualStyleBackColor = true;
            Forth_radio.CheckedChanged += Forth_radio_CheckedChanged;
            // 
            // third_radio
            // 
            third_radio.AutoSize = true;
            third_radio.Location = new Point(80, 14);
            third_radio.Name = "third_radio";
            third_radio.Size = new Size(14, 13);
            third_radio.TabIndex = 2;
            third_radio.UseVisualStyleBackColor = true;
            third_radio.CheckedChanged += third_radio_CheckedChanged;
            // 
            // second_radio
            // 
            second_radio.AutoSize = true;
            second_radio.Location = new Point(60, 14);
            second_radio.Name = "second_radio";
            second_radio.Size = new Size(14, 13);
            second_radio.TabIndex = 1;
            second_radio.UseVisualStyleBackColor = true;
            second_radio.CheckedChanged += second_radio_CheckedChanged;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(944, 450);
            Controls.Add(gb_for_new_page);
            Controls.Add(panel_general);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Welcome";
            Text = "Form1";

            panel_general.ResumeLayout(false);
            panel_general.PerformLayout();
            gb_for_new_page.ResumeLayout(false);
            gb_for_new_page.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_general;
        private RadioButton first_radio;
        private GroupBox gb_for_new_page;
        private RadioButton Fifth_radio;
        private RadioButton Forth_radio;
        private RadioButton third_radio;
        private RadioButton second_radio;
        private Label label1;
        private Button score_btn;
        private Button start_btn;
    }
}
