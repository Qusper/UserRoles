using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace UserRoles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var cont = new Data.UsersDbContext())
                {
                    //Вывод данных из таблицы users
                    //Console.WriteLine("ID" + "     " + "Login" + "     " + "Password" +  "     " + "Email" + "     " + "First Name" + "     " + "Last Name" + "     "  + "Role ID");   
                    //foreach (var u in cont.users)
                    //{
                    //    Console.WriteLine(u.id + "     " + u.login + "     " + u.password + "     " + u.email + "     " + u.fname + "     " + u.lname + "     " + u.role_id);
                    //}

                    //Вывод данных из таблицы role
                    //Console.WriteLine("ID" + "     " + "Role");   //Вывод данных из таблицы users
                    //foreach (var r in cont.roles)
                    //{
                    //    Console.WriteLine(r.id + "     " + r.roles);
                    //}

                    //Добавление данных в таблицу users
                    //cont.users.Add(new Data.Tables.users { login = "test1", password = "test2", email = "test3", fname = "test4", lname = "test5", role_id = 3 });
                    //cont.SaveChanges();



                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
