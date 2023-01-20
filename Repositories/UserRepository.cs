using Blog.Models;
using MySql.Data.MySqlClient;

namespace Blog.Repositories
{
    public class UserRepository : Repository<User>
    {
        private readonly MySqlConnection _connection;
        public UserRepository(MySqlConnection connection) : base(connection) 
        {
            this._connection = connection;
        }
    }
}