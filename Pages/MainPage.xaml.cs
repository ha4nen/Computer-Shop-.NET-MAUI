namespace lab12
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            Usr_List_View.ItemsSource= App.DBTrans.GetAllUsers();
        }

        private void Add_Button_Clicked(object sender, EventArgs e)
        {
            App.DBTrans.Add(new Models.UserInfo
            {
                Name= Usr_Name.Text,
            });
            Usr_List_View.ItemsSource = App.DBTrans.GetAllUsers();

        }
    }

}
