using layer_ask_manager;

namespace Quiz.Use_controls
{
    public partial class first_quiz : UserControl
    {
        #region Variables and delegates
        private Answers_and_Questions? array_mix_questions = new Answers_and_Questions();
        private Mixer_questions object_for_mix = new Mixer_questions();

        private List<Answers_and_Questions> list_for_contest = new List<Answers_and_Questions>();

        private static Welcome object_welcome = new Welcome();

        private Score_records table_of_score_achieve = new Score_records();

        private int final_score = 4;
        #endregion

        public first_quiz()
        {
            InitializeComponent();
            //start_the_questions();
        }

        #region Declare the list
        public void declare_the_list(List<Answers_and_Questions> list, Score_records tsa) 
        {
            list_for_contest = list;
            table_of_score_achieve = tsa;
            
        }
        #endregion

        #region Start questions
        public void start_the_questions()
        {
            // Declare "array_mix_questions" for prepare for the test.
            array_mix_questions = object_for_mix.return_of_elements_mixed(list_for_contest);

            bool end_start_question = true;

            do
            {
                if (array_mix_questions != null)
                {
                    btn_aswer_1.Text = array_mix_questions.Wrong_Answers![0];
                    btn_aswer_2.Text = array_mix_questions.Wrong_Answers![1];
                    btn_aswer_3.Text = array_mix_questions.Wrong_Answers![2];
                    btn_aswer_4.Text = array_mix_questions.Wrong_Answers![3];

                    /*Thread td = new Thread(() => dq(array_mix_questions.Main_question!));
                    td.Start();*/

                    Task.Run(() => write_question(array_mix_questions.Main_question!));
                    GB_buttons.Invoke(new Action(() => GB_buttons.Enabled = true));
                    end_start_question = false;
                }
                else
                {
                   MessageBox.Show("The Array is null");
                }

            } while (end_start_question);

        }
        #endregion

        #region Write questions
        private async Task write_question(String message_q)
        {
            txt_quiestion_generated.Invoke(new
                 Action(() => txt_quiestion_generated.Clear()));

            foreach (var word in message_q.ToArray())
            {
                if (txt_quiestion_generated.InvokeRequired)
                {
                    txt_quiestion_generated.Invoke(new Action(() => txt_quiestion_generated.AppendText(word.ToString())));
                    await Task.Delay(50);
                   // Thread.Sleep(50);
                }
            }

            //GB_buttons.Invoke(new Action(() => GB_buttons.Enabled = true));
        }
        #endregion

        #region Write questions syncronic
        private void write_question_syncronic(String message_q)
        {
            txt_quiestion_generated.Clear();

            foreach (var word in message_q.ToArray())
            {
                txt_quiestion_generated.AppendText(word.ToString());
                Thread.Sleep(50);
            }
        }
        #endregion

        #region Buttons
        private void btn_aswer_1_Click(object sender, EventArgs e)
        {
            String answer_choosen = btn_aswer_1.Text;
            
            if (answer_choosen == array_mix_questions!.Correct_answer)
            {
                MessageBox.Show("Correct");
                GB_buttons.Enabled = false;

                Task.Run(() => write_question(array_mix_questions.Explanation!));
                //write_question_syncronic(array_mix_questions.Explanation!);

                remove_the_question_made_and_return_list_modified();
                table_of_score_achieve.sum_for_correct_answers(1);
                table_of_score_achieve.sum_of_final_score(final_score);

            }
            else
            {
                table_of_score_achieve.sum_the_incorrect_answers(1);
                MessageBox.Show("Incorrect");

                if (final_score > 0) 
                {
                    final_score -= 1;
                }
            }
        }

        private void btn_aswer_2_Click(object sender, EventArgs e)
        {
            String answer_choosen = btn_aswer_2.Text;
            
            if (answer_choosen == array_mix_questions!.Correct_answer)
            {
                MessageBox.Show("Correct");
                GB_buttons.Enabled = false;

                Task.Run(() => write_question(array_mix_questions.Explanation!));
                //write_question_syncronic(array_mix_questions.Explanation!);

                remove_the_question_made_and_return_list_modified();
                table_of_score_achieve.sum_for_correct_answers(1);
                table_of_score_achieve.sum_of_final_score(final_score);
            }
            else
            {
                MessageBox.Show("Incorrect");
                table_of_score_achieve.sum_the_incorrect_answers(1);
                if (final_score > 0)
                { 
                    final_score -= 1; 
                }

            }

        }

        private void btn_aswer_3_Click(object sender, EventArgs e)
        {
            String answer_choosen = btn_aswer_3.Text;
            
            if (answer_choosen == array_mix_questions!.Correct_answer)
            {
                MessageBox.Show("Correct");
                GB_buttons.Enabled = false;

                Task.Run(() => write_question(array_mix_questions.Explanation!));

                //write_question_syncronic(array_mix_questions.Explanation!);
                remove_the_question_made_and_return_list_modified();

                table_of_score_achieve.sum_for_correct_answers(1);
                table_of_score_achieve.sum_of_final_score(final_score);

            }
            else
            {
                MessageBox.Show("Incorrect");
                table_of_score_achieve.sum_the_incorrect_answers(1);

                if (final_score > 0)
                { 
                final_score -= 1; }

            }
        }

        private void btn_aswer_4_Click(object sender, EventArgs e)
        {
            String answer_choosen = btn_aswer_4.Text;
            
            if (answer_choosen == array_mix_questions!.Correct_answer)
            {
                MessageBox.Show("Correct");
                GB_buttons.Enabled = false;

                Task.Run(() => write_question(array_mix_questions.Explanation!));

                //write_question_syncronic(array_mix_questions.Explanation!);

                remove_the_question_made_and_return_list_modified();
                table_of_score_achieve.sum_for_correct_answers(1);
                table_of_score_achieve.sum_of_final_score(final_score);
            }
            else
            {
                MessageBox.Show("Incorrect");
                table_of_score_achieve.sum_the_incorrect_answers(1);

                if (final_score > 0)
                { 
                    final_score -= 1; 
                }

            }
        }
        #endregion

        public static void return_of_instance_Welcome(Welcome i) 
        {
           object_welcome = i;
        }

        #region Remove and return list modified
        private void remove_the_question_made_and_return_list_modified() 
        {
            list_for_contest.RemoveAt(object_for_mix.Number_rm);
            object_for_mix.rest_maxvalue();
            GB_buttons.Enabled = false;

            object_welcome.return_of_questions_modified(list_for_contest, table_of_score_achieve);
            
            //MessageBox.Show($"The position object: {object_for_mix.Number_rm} has been removed");
        }
        #endregion

       
    }
}
