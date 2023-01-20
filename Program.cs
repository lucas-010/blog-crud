using System;
using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"
        Server=localhost, 3306;
        Database=blog;
        User ID=root;
        Password=";

        static void Main(string[] args)
        {
            MySqlConnection connection = new MySqlConnection(CONNECTION_STRING);
            connection.Open();

            /*
            Métodos de inserção
            CreateUser(connection);
            CreateRole(connection);
            CreateTag(connection);
            */

            /*
            Métodos de leitura
            ReadUsers(connection);
            ReadRoles(connection);
            ReadTags(connection);
            */

            /*
            Métodos de atualização
            UpdateUser(connection);
            UpdateRole(connection);
            UpdateTag(connection);
            */

            /*
            Métodos de excluxão
            DeleteUser(connection);
            DeleteRole(connection);
            DeleteTag(connection);
            */

            connection.Close();
        }

        //Create
        public static void CreateUser(MySqlConnection connection)
        {
            Repository<User> repository = new Repository<User>(connection);
            User user = new User();
            repository.Create(user);
        }
        
        public static void CreateRole(MySqlConnection connection)
        {
            Repository<Role> repository = new Repository<Role>(connection);
            Role role = new Role();
            repository.Create(role);
        }

        public static void CreateTag(MySqlConnection connection)
        {
            Repository<Tag> repository = new Repository<Tag>(connection);
            Tag tag = new Tag();
            repository.Create(tag);
        }

        //Read
        public static void ReadUsers(MySqlConnection connection)
        {
            Repository<User> repository = new Repository<User>(connection);
            IEnumerable<User> items = repository.Get();
            foreach(User item in items) Console.WriteLine(item.Name);
        }

        public static void ReadRoles(MySqlConnection connection)
        {
            Repository<Role> repository = new Repository<Role>(connection);
            IEnumerable<Role> items = repository.Get();
            foreach(Role item in items) Console.WriteLine(item.Name);
        }

        public static void ReadTags(MySqlConnection connection)
        {
            Repository<Tag> repository = new Repository<Tag>(connection);
            IEnumerable<Tag> items = repository.Get();
            foreach(Tag item in items) Console.WriteLine(item.Name);
        }
    
        //Update
        public static void UpdateUser(MySqlConnection connection)
        {
            Repository<User> repository = new Repository<User>(connection);
            User user = new User();
            repository.Update(user);
        }
    
        public static void UpdateRole(MySqlConnection connection)
        {
            Repository<Role> repository = new Repository<Role>(connection);
            Role role = new Role();
            repository.Update(role);
        }

        public static void UpdateTag(MySqlConnection connection)
        {
            Repository<Tag> repository = new Repository<Tag>(connection);
            Tag tag = new Tag();
            repository.Update(tag);
        }

        //Delete
        public static void DeleteUser(MySqlConnection connection)
        {
            Repository<User> repository = new Repository<User>(connection);
            User user = new User();
            repository.Delete(user);
        }

        public static void DeleteRole(MySqlConnection connection)
        {
            Repository<Role> repository = new Repository<Role>(connection);
            Role role = new Role();
            repository.Delete(role);
        } 
    
        public static void DeleteTag(MySqlConnection connection)
        {
            Repository<Tag> repository = new Repository<Tag>(connection);
            Tag tag = new Tag();
            repository.Delete(tag);
        }
    }  
}