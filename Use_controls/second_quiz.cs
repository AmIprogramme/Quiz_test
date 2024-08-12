using layer_ask_manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz.Use_controls
{
    public partial class second_quiz : UserControl
    {
        #region Variables and delegates
        private Answers_and_Questions? array_mix_questions = new Answers_and_Questions();
        private Mixer_questions object_for_mix = new Mixer_questions();

        private List<Answers_and_Questions> list_for_contest = new List<Answers_and_Questions>();

        private delegate void D_Write_question(String message);
        #endregion

        public second_quiz()
        {
            InitializeComponent();
        }

        #region Declare the list
        public void declare_the_list(List<Answers_and_Questions> list)
        { list_for_contest = list; }
        #endregion

        #region Start questions
        public void start_the_questions()
        {
            // This is a delegate 
            // D_Write_question dq = new D_Write_question(write_question);

            // Declare "array_mix_questions" for prepare for the test.
            array_mix_questions = object_for_mix.return_of_elements_mixed(list_for_contest);

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
            }
            else
            {
                MessageBox.Show("The Array is null");
            }
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

        #region Buttons
        private void btn_aswer_1_Click(object sender, EventArgs e)
        {
            String answer_choosen = btn_aswer_1.Text;
            //D_Write_question dq = new D_Write_question(write_question);

            if (answer_choosen == array_mix_questions!.Correct_answer)
            {
                MessageBox.Show("Correct");
                GB_buttons.Enabled = false;

                /*Thread td = new Thread(() => dq(array_mix_questions.Explanation!));
                td.Start();
                */
                Task.Run(() => write_question(array_mix_questions.Explanation!));

                remove_the_question_made_and_return_list_modified();

            }
            else
            {
                MessageBox.Show("Incorrect");
            }

        }

        private void btn_aswer_2_Click(object sender, EventArgs e)
        {
            String answer_choosen = btn_aswer_2.Text;
            //D_Write_question dq = new D_Write_question(write_question);

            if (answer_choosen == array_mix_questions!.Correct_answer)
            {
                MessageBox.Show("Correct");
                GB_buttons.Enabled = false;

                /*Thread td = new Thread(() => dq(array_mix_questions.Explanation!));
                td.Start();
                */
                Task.Run(() => write_question(array_mix_questions.Explanation!));

                remove_the_question_made_and_return_list_modified();

            }
            else
            {
                MessageBox.Show("Incorrect");
            }

        }

        private void btn_aswer_3_Click(object sender, EventArgs e)
        {
            String answer_choosen = btn_aswer_3.Text;
            //D_Write_question dq = new D_Write_question(write_question);

            if (answer_choosen == array_mix_questions!.Correct_answer)
            {
                MessageBox.Show("Correct");
                GB_buttons.Enabled = false;

                /*Thread td = new Thread(() => dq(array_mix_questions.Explanation!));
                td.Start();
                */
                Task.Run(() => write_question(array_mix_questions.Explanation!));

                remove_the_question_made_and_return_list_modified();

            }
            else
            {
                MessageBox.Show("Incorrect");
            }
        }

        private void btn_aswer_4_Click(object sender, EventArgs e)
        {
            String answer_choosen = btn_aswer_4.Text;
            //D_Write_question dq = new D_Write_question(write_question);

            if (answer_choosen == array_mix_questions!.Correct_answer)
            {
                MessageBox.Show("Correct");
                GB_buttons.Enabled = false;

                /*Thread td = new Thread(() => dq(array_mix_questions.Explanation!));
                td.Start();
                */
                Task.Run(() => write_question(array_mix_questions.Explanation!));

                remove_the_question_made_and_return_list_modified();

            }
            else
            {
                MessageBox.Show("Incorrect");
            }
        }
        #endregion

        #region Remove and return list modified
        private void remove_the_question_made_and_return_list_modified()
        {
            list_for_contest.RemoveAt(object_for_mix.Number_rm);
            object_for_mix.rest_maxvalue();
            GB_buttons.Enabled = false;

            Welcome object_welcome = new Welcome();
            object_welcome.return_of_questions_modified(list_for_contest);

            //MessageBox.Show($"The position object: {object_for_mix.Number_rm} has been removed");
        }
        #endregion


       
       

    }
}
