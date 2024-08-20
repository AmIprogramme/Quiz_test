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
            btn_next_question = new Button();
            SuspendLayout();
            // 
            // panel_general
            // 
            panel_general.Anchor = AnchorStyles.Top;
            panel_general.Location = new Point(12, 36);
            panel_general.Name = "panel_general";
            panel_general.Size = new Size(920, 369);
            panel_general.TabIndex = 0;
            // 
            // btn_next_question
            // 
            btn_next_question.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_next_question.Font = new Font("MS Gothic", 15.75F);
            btn_next_question.Location = new Point(374, 412);
            btn_next_question.Name = "btn_next_question";
            btn_next_question.Size = new Size(181, 33);
            btn_next_question.TabIndex = 3;
            btn_next_question.Text = "Next question";
            btn_next_question.UseVisualStyleBackColor = true;
            btn_next_question.Visible = false;
            btn_next_question.Click += btn_next_question_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(944, 450);
            Controls.Add(btn_next_question);
            Controls.Add(panel_general);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Welcome";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_general;
        private Button btn_next_question;
    }
}
