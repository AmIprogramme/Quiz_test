namespace Quiz.Use_controls
{
    partial class first_quiz
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_aswer_1 = new Button();
            btn_aswer_2 = new Button();
            btn_aswer_3 = new Button();
            btn_aswer_4 = new Button();
            txt_quiestion_generated = new TextBox();
            reload = new Button();
            GB_buttons = new GroupBox();
            GB_buttons.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(175, 33);
            label1.TabIndex = 0;
            label1.Text = "First Quiz";
            // 
            // btn_aswer_1
            // 
            btn_aswer_1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_aswer_1.Font = new Font("Segoe UI", 11F);
            btn_aswer_1.Location = new Point(66, 4);
            btn_aswer_1.Name = "btn_aswer_1";
            btn_aswer_1.Size = new Size(296, 42);
            btn_aswer_1.TabIndex = 1;
            btn_aswer_1.Text = "button1";
            btn_aswer_1.UseVisualStyleBackColor = true;
            btn_aswer_1.Click += btn_aswer_1_Click;
            // 
            // btn_aswer_2
            // 
            btn_aswer_2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_aswer_2.Font = new Font("Segoe UI", 11F);
            btn_aswer_2.Location = new Point(66, 52);
            btn_aswer_2.Name = "btn_aswer_2";
            btn_aswer_2.Size = new Size(296, 42);
            btn_aswer_2.TabIndex = 2;
            btn_aswer_2.Text = "button2";
            btn_aswer_2.UseVisualStyleBackColor = true;
            btn_aswer_2.Click += btn_aswer_2_Click;
            // 
            // btn_aswer_3
            // 
            btn_aswer_3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_aswer_3.Font = new Font("Segoe UI", 11F);
            btn_aswer_3.Location = new Point(66, 100);
            btn_aswer_3.Name = "btn_aswer_3";
            btn_aswer_3.Size = new Size(296, 42);
            btn_aswer_3.TabIndex = 3;
            btn_aswer_3.Text = "button3";
            btn_aswer_3.UseVisualStyleBackColor = true;
            btn_aswer_3.Click += btn_aswer_3_Click;
            // 
            // btn_aswer_4
            // 
            btn_aswer_4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_aswer_4.Font = new Font("Segoe UI", 11F);
            btn_aswer_4.Location = new Point(66, 148);
            btn_aswer_4.Name = "btn_aswer_4";
            btn_aswer_4.Size = new Size(296, 42);
            btn_aswer_4.TabIndex = 4;
            btn_aswer_4.Text = "button4";
            btn_aswer_4.UseVisualStyleBackColor = true;
            btn_aswer_4.Click += btn_aswer_4_Click;
            // 
            // txt_quiestion_generated
            // 
            txt_quiestion_generated.BackColor = SystemColors.InactiveCaptionText;
            txt_quiestion_generated.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_quiestion_generated.ForeColor = Color.Green;
            txt_quiestion_generated.Location = new Point(226, 29);
            txt_quiestion_generated.Multiline = true;
            txt_quiestion_generated.Name = "txt_quiestion_generated";
            txt_quiestion_generated.ReadOnly = true;
            txt_quiestion_generated.Size = new Size(471, 119);
            txt_quiestion_generated.TabIndex = 5;
            // 
            // reload
            // 
            reload.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            reload.Font = new Font("Segoe UI", 11F);
            reload.Location = new Point(759, 29);
            reload.Name = "reload";
            reload.Size = new Size(131, 42);
            reload.TabIndex = 6;
            reload.Text = "Other question";
            reload.UseVisualStyleBackColor = true;
            reload.Click += reload_Click;
            // 
            // GB_buttons
            // 
            GB_buttons.Controls.Add(btn_aswer_4);
            GB_buttons.Controls.Add(btn_aswer_3);
            GB_buttons.Controls.Add(btn_aswer_2);
            GB_buttons.Controls.Add(btn_aswer_1);
            GB_buttons.Enabled = false;
            GB_buttons.Location = new Point(256, 150);
            GB_buttons.Name = "GB_buttons";
            GB_buttons.Size = new Size(411, 199);
            GB_buttons.TabIndex = 7;
            GB_buttons.TabStop = false;
            // 
            // first_quiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            Controls.Add(GB_buttons);
            Controls.Add(reload);
            Controls.Add(txt_quiestion_generated);
            Controls.Add(label1);
            Name = "first_quiz";
            Size = new Size(920, 369);
            GB_buttons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_aswer_1;
        private Button btn_aswer_2;
        private Button btn_aswer_3;
        private Button btn_aswer_4;
        private TextBox txt_quiestion_generated;
        private Button reload;
        private GroupBox GB_buttons;
    }
}
