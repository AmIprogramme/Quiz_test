namespace Quiz.Use_controls
{
    partial class Results
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
            label_for_results = new Label();
            SuspendLayout();
            // 
            // label_for_results
            // 
            label_for_results.AutoSize = true;
            label_for_results.Font = new Font("MS Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_for_results.Location = new Point(255, 35);
            label_for_results.Name = "label_for_results";
            label_for_results.Size = new Size(383, 33);
            label_for_results.TabIndex = 0;
            label_for_results.Text = "Results of the contest:";
            // 
            // Results
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            Controls.Add(label_for_results);
            Name = "Results";
            Size = new Size(920, 369);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_for_results;
    }
}
