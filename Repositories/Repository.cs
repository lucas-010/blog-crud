using MySql.Data.MySqlClient;
using Dapper.Contrib.Extensions;

namespace Blog.Repositories
{
    public class Repository<T> where T : class
    {
        private readonly MySqlConnection _connection;
        public Repository(MySqlConnection connection) => this._connection = connection;

        public IEnumerable<T> Get() => _connection.GetAll<T>();

         public T Get(int id) => _connection.Get<T>(id);

        public void Create(T model) =>  _connection.Insert<T>(model);

        public void Update(T model) => _connection.Update<T>(model);

        public void Delete(T model) => _connection.Delete<T>(model);

        public void Delete(int id)
        {
            T model = _connection.Get<T>(id);
            _connection.Delete<T>(model);
        }
    }
}