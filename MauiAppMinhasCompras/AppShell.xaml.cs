using MauiAppMinhasCompras.Helpers;

namespace MauiAppMinhasCompras
{
    public partial class AppShell : Shell
    {
        static SQLiteDatabaseHelper _db;
        public AppShell()
        {
            InitializeComponent();
        }
    }
}
