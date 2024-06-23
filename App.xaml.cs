using lab12.DataTransactions;

namespace lab12
{
    public partial class App : Application
    {
        public static DBTrans DBTrans { get; private set;}
        public App(DBTrans dbtrans)
        {
            InitializeComponent();

            MainPage = new AppShell();
            DBTrans = dbtrans;
        }
    }
}
