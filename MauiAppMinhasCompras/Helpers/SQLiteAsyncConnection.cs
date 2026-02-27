
namespace MauiAppMinhasCompras.Helpers
{
    internal class SQLiteAsyncConnection
    {
        private string path;

        public SQLiteAsyncConnection(string path)
        {
            this.path = path;
        }

        internal object CreateTableAsync<T>()
        {
            throw new NotImplementedException();
        }
    }
}