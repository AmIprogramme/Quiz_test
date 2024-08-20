using layer_ask_manager;

namespace Quiz.Use_controls
{
 
    public partial class Main_menu : UserControl
    {
        #region Variables
        private static Welcome object_welcome = new Welcome();
        #endregion

        public Main_menu()
        {
            InitializeComponent();
            
        }
        public void return_of_instance_Welcome(Welcome i)
        {
            object_welcome = i;
        }
        private void start_btn_Click(object sender, EventArgs e)
        {
            object_welcome.start_quiz();
        }
    }
}
