namespace Quiz.Use_controls
{
    partial class Main_menu
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
            panel_general = new Panel();
            score_btn = new Button();
            start_btn = new Button();
            label1 = new Label();
            panel_general.SuspendLayout();
            SuspendLayout();
            // 
            // panel_general
            // 
            panel_general.Anchor = AnchorStyles.Top;
            panel_general.Controls.Add(score_btn);
            panel_general.Controls.Add(start_btn);
            panel_general.Controls.Add(label1);
            panel_general.Location = new Point(8, 8);
            panel_general.Name = "panel_general";
            panel_general.Size = new Size(920, 369);
            panel_general.TabIndex = 1;
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
            start_btn.Click += start_btn_Click;
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
            // Main_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            Controls.Add(panel_general);
            Name = "Main_menu";
            Size = new Size(920, 369);
            panel_general.ResumeLayout(false);
            panel_general.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_general;
        private Button score_btn;
        private Button start_btn;
        private Label label1;
    }
}
