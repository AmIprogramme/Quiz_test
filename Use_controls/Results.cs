using layer_ask_manager;

namespace Quiz.Use_controls
{
    public partial class Results: UserControl
    {
        
        public Results()
        {
            InitializeComponent();
            
        }

        public void Print_the_score(Score_records tsa) 
        {
            String text_printed = $"Results of the contest: \n\n" +
                $"Failed attempts: {tsa.number_of_Wrong_Answers} \n" +
                $"Correct answers: {tsa.number_of_right_answers} \n" +
                $"Score: {tsa.final_score}";   
            
            label_for_results.Text = text_printed;
        }

      
    }
}
