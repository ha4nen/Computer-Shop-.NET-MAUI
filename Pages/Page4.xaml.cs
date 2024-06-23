using lab12.Models;

namespace lab12;

public partial class Page4 : ContentPage
{
	public Page4()
	{
		InitializeComponent();
        lbTotal.Text = Totalinfo.Price.ToString();
        Usr_List_View.ItemsSource = App.DBTrans.GetAllUsers();

    }
}