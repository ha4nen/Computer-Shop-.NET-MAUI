using lab12.Models;

namespace lab12;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
        Usr_List_View.ItemsSource = App.DBTrans.GetAllUsers();
    }

    private void rb1c_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if(rb1c.IsChecked)
		{
            Totalinfo.CPU = 1;
		}
        else if (rb2c.IsChecked)
        {
            Totalinfo.CPU = 2;
        }
        else if (rb3c.IsChecked)
        {
            Totalinfo.CPU = 3;
        }
        else if (rb4c.IsChecked)
        {
            Totalinfo.CPU = 4;
        }

        if(Totalinfo.CPU == 1)
        {
            Totalinfo.Price = 1500;
        }
        else if (Totalinfo.CPU == 2) 
        {
            Totalinfo.Price = 1700;
        }
        else if (Totalinfo.CPU == 3) 
        {
            Totalinfo.Price = 2000;
        }        
        else if (Totalinfo.CPU == 4) 
        {
            Totalinfo.Price = 2500;
        }
    }

    private void rb1s_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if( rb1s.IsChecked)
        {
            Totalinfo.StType = 1;
        }
        else if( rb2s.IsChecked)
        {
            Totalinfo.StType = 2;
        }
    }
}