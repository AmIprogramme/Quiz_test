using Quiz.Use_controls;

namespace Quiz
{
    public partial class Welcome : Form
    {
        private first_quiz f_quiz = new first_quiz();
        private second_quiz s_quiz = new second_quiz();
        private Thrid_quiz thr_quiz = new Thrid_quiz();
        private Forth_quiz four_quiz = new Forth_quiz();


        public Welcome()
        {
            InitializeComponent();

            /*
            UserControl1 jpanel = new UserControl1();

            if (panel_de_prueba.Contains(jpanel) == false)
            {
                panel_de_prueba.Controls.Add(jpanel);
                jpanel.Dock = DockStyle.Fill;
                jpanel.BringToFront();
            }
            else {jpanel.BringToFront(); }
            */

        }

        public void shut_useControl()
        {
            panel_general.Controls.Remove(this);

        }

        private void RemoveControlFromPanel(Control control, Panel panel)
        {
            if (panel.Controls.Contains(control))
            {
                panel.Controls.Remove(control);
                control.Dispose(); // Libera los recursos del control
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            panel_general.Controls.Add(f_quiz);
            f_quiz.Dock = DockStyle.Fill;
            f_quiz.BringToFront();

            gb_for_new_page.Visible = true;
        }

        private void second_radio_CheckedChanged(object sender, EventArgs e)
        {
            //RemoveControlFromPanel(s_quiz, panel_general); // Remueve el control si ya existe

            panel_general.Controls.Add(s_quiz);
            s_quiz.Dock = DockStyle.Fill;
            s_quiz.BringToFront();
        }

        private void first_radio_CheckedChanged(object sender, EventArgs e)
        {
            //RemoveControlFromPanel(f_quiz, panel_general); // Remueve el control si ya existe
            panel_general.Controls.Add(f_quiz);
            f_quiz.Dock = DockStyle.Fill;
            f_quiz.BringToFront();
        }

        private void third_radio_CheckedChanged(object sender, EventArgs e)
        {

            //RemoveControlFromPanel(thr_quiz, panel_general); // Remueve el control si ya existe
            panel_general.Controls.Add(thr_quiz);
            thr_quiz.Dock = DockStyle.Fill;
            thr_quiz.BringToFront();
        }

        private void Forth_radio_CheckedChanged(object sender, EventArgs e)
        {
            //RemoveControlFromPanel(four_quiz, panel_general); // Remueve el control si ya existe
            panel_general.Controls.Add(four_quiz);
            four_quiz.Dock = DockStyle.Fill;
            four_quiz.BringToFront();
        }

        
    }
}
