﻿namespace Quiz.Use_controls
{
    partial class second_quiz
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
            label2 = new Label();
            listBox1 = new ListBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 16);
            label2.Name = "label2";
            label2.Size = new Size(191, 33);
            label2.TabIndex = 2;
            label2.Text = "Second Quiz";
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top;
            listBox1.BackColor = Color.LemonChiffon;
            listBox1.Font = new Font("MS Gothic", 14F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Items.AddRange(new object[] { "El oeoe" });
            listBox1.Location = new Point(223, 37);
            listBox1.Name = "listBox1";
            listBox1.RightToLeft = RightToLeft.Yes;
            listBox1.Size = new Size(475, 61);
            listBox1.TabIndex = 10;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button4.Font = new Font("Segoe UI", 11F);
            button4.Location = new Point(311, 289);
            button4.Name = "button4";
            button4.Size = new Size(286, 42);
            button4.TabIndex = 9;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button3.Font = new Font("Segoe UI", 11F);
            button3.Location = new Point(311, 241);
            button3.Name = "button3";
            button3.Size = new Size(286, 42);
            button3.TabIndex = 8;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button2.Font = new Font("Segoe UI", 11F);
            button2.Location = new Point(311, 193);
            button2.Name = "button2";
            button2.Size = new Size(286, 42);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(311, 145);
            button1.Name = "button1";
            button1.Size = new Size(286, 42);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // second_quiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Name = "second_quiz";
            Size = new Size(920, 369);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ListBox listBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
