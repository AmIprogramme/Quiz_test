using Quiz.Use_controls;
using layer_ask_manager;

namespace Quiz
{
    public partial class Welcome : Form
    {

        #region Global variables

            #region Use control variables
        private Main_menu m_menu = new Main_menu();
        private first_quiz f_quiz = new first_quiz();
        private second_quiz s_quiz = new second_quiz();
        private Thrid_quiz thr_quiz = new Thrid_quiz();
        private Forth_quiz four_quiz = new Forth_quiz();
        private Results _Results = new Results();

        #endregion

            #region Other variables
        private List<Answers_and_Questions>? list_for_contest = new List<Answers_and_Questions>();
        // With this list we use it in all the quiz a establish between the main form.

        private Score_records table_of_score_achieve = new Score_records();
        // Also, the list will be follow with the table score in all moment.

        private static int position_quiz = 0;
        // This variable gonna be used at the end of any process ended the quiz.

        #endregion

        #endregion

        public Welcome()
        {
            InitializeComponent();
            install_Main_menu();
        }
        #region Function for shut, delete and update panel
        public void shut_useControl()
        {
            // Here we restoring any single variable used during our contest.
            f_quiz = new first_quiz();
            s_quiz = new second_quiz();
            thr_quiz = new Thrid_quiz();
            four_quiz = new Forth_quiz();
            _Results = new Results();
            table_of_score_achieve = new Score_records();

            position_quiz = 0; // Restoring the position for open the Use controls

            
            panel_general.Controls.Clear(); /* Clean all element in the panel and then install
                                             again the main menu*/ 
            install_Main_menu();

        }
        #endregion

        #region Function return and modificate list and score table
        public void return_of_questions_modified(List<Answers_and_Questions> returned, Score_records tsa)
        {
            /*The use of variable avoinding the static caracteristics elements, is implemented
             the use of copies and modifications. During the main form, is declared the list of 
            questions and score separated, and then during the quiz code it returns those elements
            modificated for the next quiz and repeat the process.
            */
            table_of_score_achieve = tsa; // tsa means Table of Score Achieve
            list_for_contest = returned;

            btn_next_question.Visible = true; // Finished here, the process open the button for next question.
        }
        #endregion

        #region Function Install Main Menu
        protected void install_Main_menu() 
        {
            m_menu.return_of_instance_Welcome(this);
            // It sends the instance for modificate the elements in our present form

            panel_general.Controls.Add(m_menu); // Add the element of Main_menu to the panel.

            f_quiz.Dock = DockStyle.Fill;
            f_quiz.BringToFront();
        }
        #endregion

        #region Function start quiz
        public void start_quiz()
        {
            list_for_contest = Questions_generator.Initialize();
 
            first_quiz.return_of_instance_Welcome(this);

            panel_general.Controls.Add(f_quiz);
            f_quiz.Dock = DockStyle.Fill;
            f_quiz.BringToFront();

            f_quiz.declare_the_list(list_for_contest!, table_of_score_achieve);
           
            f_quiz.start_the_questions();

        }
        #endregion

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

        #region Button for update next question
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
                    shut_useControl();
                    break;

            }

        }
        #endregion

    }
}
