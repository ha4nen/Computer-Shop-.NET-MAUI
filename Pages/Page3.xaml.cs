using lab12.Models;
namespace lab12;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
        lbTotal.Text= Totalinfo.Price.ToString();
        Usr_List_View.ItemsSource = App.DBTrans.GetAllUsers();
        min1.IsEnabled = false;
        MIN2.IsEnabled = false;
        min3.IsEnabled = false;
    }

    private void min1_Clicked(object sender, EventArgs e)
    {
        int meminus;
        int.TryParse(lbMem.Text, out meminus);
        if (meminus == 4)
        {
            meminus = 0;
            lbMem.Text = "0";
            min1.IsEnabled = false;
            Totalinfo.Price -= 150;
            lbTotal.Text = Totalinfo.Price.ToString();
        }
        else if (meminus == 8)
        {
            meminus = 4;
            lbMem.Text = "4";
            Totalinfo.Price -= 150;
            lbTotal.Text = Totalinfo.Price.ToString();
        }
        else if (meminus == 12)
        {
            meminus = 8;
            lbMem.Text = "8";
            Totalinfo.Price -= 150;
            lbTotal.Text = Totalinfo.Price.ToString();
        }
        else if (meminus == 16)
        {
            meminus = 12;
            lbMem.Text = "12";
            plus1.IsEnabled = true;
            Totalinfo.Price -= 150;
            lbTotal.Text = Totalinfo.Price.ToString();
        }
    }

    private void plus1_Clicked(object sender, EventArgs e)
    {
        int memplus;
        int.TryParse(lbMem.Text, out memplus);
        if (memplus == 0)
        {
            memplus = 4;
            lbMem.Text = "4";
            min1.IsEnabled = true;
            Totalinfo.Price += 150;
            lbTotal.Text = Totalinfo.Price.ToString();
        }
        else if (memplus == 4)
        {
            memplus = 8;
            lbMem.Text = "8";
            Totalinfo.Price += 150;
            lbTotal.Text = Totalinfo.Price.ToString();
        }
        else if (memplus == 8)
        {
            memplus = 12;
            lbMem.Text = "12";
            Totalinfo.Price += 150;
            lbTotal.Text = Totalinfo.Price.ToString();
        }
        else if (memplus == 12)
        {
            memplus = 16;
            lbMem.Text = "16";
            plus1.IsEnabled = false;
            Totalinfo.Price += 150;
            lbTotal.Text = Totalinfo.Price.ToString();
        }
    }

    private void MIN2_Clicked(object sender, EventArgs e)
    {
        int strmin;
        int.TryParse(lbStr.Text, out strmin);
        if (strmin == 500) 
        {
            strmin = 0;
            lbStr.Text = "0";
            MIN2.IsEnabled = false;

            if(Totalinfo.StType==1)
            {
                Totalinfo.Price -= 500;
                lbTotal.Text = Totalinfo.Price.ToString();
            }
            else if (Totalinfo.StType == 2)
            {
                Totalinfo.Price -= 300;
                lbTotal.Text = Totalinfo.Price.ToString();
            }
        }
        else if (strmin == 1000)
        {
            strmin =500;
            lbStr.Text = "500";
            plus2.IsEnabled = true;

            if (Totalinfo.StType == 1)
            {
                Totalinfo.Price -= 500;
                lbTotal.Text = Totalinfo.Price.ToString();
            }
            else if (Totalinfo.StType == 2)
            {
                Totalinfo.Price -= 300;
                lbTotal.Text = Totalinfo.Price.ToString();
            }

        }
    }

    private void plus2_Clicked(object sender, EventArgs e)
    {
        int strmax;
        int.TryParse(lbStr.Text, out strmax);
        if (strmax == 0)
        {
            strmax = 500;
            lbStr.Text = "500";
            MIN2.IsEnabled = true;
            if(Totalinfo.StType == 1)
            {
                Totalinfo.Price += 500;
                lbTotal.Text = Totalinfo.Price.ToString();
            }
            else if (Totalinfo.StType == 2)
            {
                Totalinfo.Price += 300;
                lbTotal.Text = Totalinfo.Price.ToString();
            }
        }
        else if (strmax == 500)
        {
            strmax = 1000;
            lbStr.Text = "1000";
            plus2.IsEnabled = false;
            if (Totalinfo.StType == 1)
            {
                Totalinfo.Price += 500;
                lbTotal.Text = Totalinfo.Price.ToString();
            }
            else if (Totalinfo.StType == 2)
            {
                Totalinfo.Price += 300;
                lbTotal.Text = Totalinfo.Price.ToString();
            }
        }
    }

    private void min3_Clicked(object sender, EventArgs e)
    {
        int monmin;
        int.TryParse(lbMon.Text, out monmin);
        if (monmin == 17)
        {
            monmin = 0;
            lbMon.Text = "0";
            min3.IsEnabled = false;
            Totalinfo.Price -= 450;
            lbTotal.Text = Totalinfo.Price.ToString();
        }
        else if (monmin == 20)
        {
            monmin = 17;
            lbMon.Text = "17";
            Totalinfo.Price -= 450;
            lbTotal.Text = Totalinfo.Price.ToString();
        }
        else if (monmin == 23)
        {
            monmin = 20;
            lbMon.Text = "20";
            Totalinfo.Price -= 450;
            plus3.IsEnabled = true;
            lbTotal.Text = Totalinfo.Price.ToString();
        }
    }

    private void plus3_Clicked(object sender, EventArgs e)
    {
        int monmax;
        int.TryParse(lbMon.Text, out monmax);
        if (monmax == 0)
        {
            monmax = 17;
            lbMon.Text = "17";
            min3.IsEnabled = true;
            Totalinfo.Price += 450;
            lbTotal.Text = Totalinfo.Price.ToString();
        }
        else if (monmax == 17)
        {
            monmax = 20;
            lbMon.Text = "20";
            Totalinfo.Price += 450;
            lbTotal.Text = Totalinfo.Price.ToString();
        }
        else if (monmax == 20)
        {
            monmax = 23;
            lbMon.Text = "23";
            Totalinfo.Price += 450;
            plus3.IsEnabled = false;
            lbTotal.Text = Totalinfo.Price.ToString();
        }
    }
}