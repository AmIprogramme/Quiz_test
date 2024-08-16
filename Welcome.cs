using Quiz.Use_controls;
using layer_ask_manager;
using System.Diagnostics;

namespace Quiz
{
    public partial class Welcome : Form
    {
        private first_quiz f_quiz = new first_quiz();
        private second_quiz s_quiz = new second_quiz();
        private Thrid_quiz thr_quiz = new Thrid_quiz();
        private Forth_quiz four_quiz = new Forth_quiz();
        private Results _Results = new Results();

        private List<Answers_and_Questions>? list_for_contest = new List<Answers_and_Questions>();
        
        private Score_records table_of_score_achieve = new Score_records();

        private static int position_quiz = 0;

        public Welcome()
        {
            InitializeComponent();
        }

        public void shut_useControl()
        {
            // Remover todos los UserControl del panel_general
            foreach (Control control in panel_general.Controls)
            {
                if (control is UserControl)
                {
                    panel_general.Controls.Remove(control);
                    control.Dispose(); // Liberar recursos del UserControl
                }
            }

            // Mostrar el formulario Welcome o traerlo al frente si ya está abierto
            Welcome mainMenu = Application.OpenForms.OfType<Welcome>().FirstOrDefault()!;

            if (mainMenu == null)
            {
                mainMenu = new Welcome();
                mainMenu.Show();
            }
            else
            {
                mainMenu.BringToFront();
            }
            f_quiz = new first_quiz();
            s_quiz = new second_quiz();
            thr_quiz = new Thrid_quiz();
            four_quiz = new Forth_quiz();
            _Results = new Results();
            table_of_score_achieve = new Score_records();
        }

        public void return_of_questions_modified(List<Answers_and_Questions> returned, Score_records tsa)
        {
            table_of_score_achieve = tsa;
            list_for_contest = returned;
            btn_next_question.Visible = true;
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
            
            list_for_contest = Questions_generator.Initialize();

            //Thread.Sleep(800);
            first_quiz.return_of_instance_Welcome(this);

            panel_general.Controls.Add(f_quiz);
            f_quiz.Dock = DockStyle.Fill;
            f_quiz.BringToFront();

            f_quiz.declare_the_list(list_for_contest!, table_of_score_achieve);
            //Thread.Sleep(500);
            f_quiz.start_the_questions();
            
        }

        #region Functions for open the Usecontrol 
        private void Open_second_panel() 
        {
            second_quiz.return_of_instance_Welcome(this);
            panel_general.Controls.Add(s_quiz);
            s_quiz.Dock = DockStyle.Fill;
            s_quiz.BringToFront();

            s_quiz.declare_the_list(list_for_contest!, table_of_score_achieve);

            Thread.Sleep(500);
            s_quiz.start_the_questions();
        }

        private void Open_thrid_panel() 
        {
            Thrid_quiz.return_of_instance_Welcome(this);

            panel_general.Controls.Add(thr_quiz);
            thr_quiz.Dock = DockStyle.Fill;
            thr_quiz.BringToFront();

            thr_quiz.declare_the_list(list_for_contest!, table_of_score_achieve);

            Thread.Sleep(500);
            thr_quiz.start_the_questions();
        }

        private void Open_fourth_panel() 
        {
            Forth_quiz.return_of_instance_Welcome(this);
            panel_general.Controls.Add(four_quiz);
            four_quiz.Dock = DockStyle.Fill;
            four_quiz.BringToFront();

            four_quiz.declare_the_list(list_for_contest!, table_of_score_achieve);

            Thread.Sleep(500);
            four_quiz.start_the_questions();
        }

        private void Open_results()
        {
            panel_general.Controls.Add(_Results);
            _Results.Dock = DockStyle.Fill;
            _Results.BringToFront();

            _Results.Print_the_score(table_of_score_achieve);
        }
        #endregion

        private void btn_next_question_Click(object sender, EventArgs e)
        {
            btn_next_question.Visible = false;
            position_quiz++;
            switch (position_quiz) 
            {
                case 1:
                    Open_second_panel();
                    break;
                case 2:
                   Open_thrid_panel();
                    break;
                case 3:
                    Open_fourth_panel();
                    btn_next_question.Text = "Results";
                    break;
                case 4:
                    Open_results();
                    btn_next_question.Text = "Play again";
                    btn_next_question.Visible = true;
                    break;
                case 5:
                    position_quiz = 0;
                    //RemoveControlFromPanel(this, panel_general);
                    shut_useControl();
                    break;
          
            }

        }
    }
}
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