using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace drugstore
{
    class LogPassRole
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
    class TovarPrice
    {
        public string Name { get; set; }
        public string Price { get; set; }
    }
    static class Queries
    {
        
        public static string GetLogPasRole(string text) => $"select Логин, Пароль, Роль from Пользователи where Логин = '{text}';\n";

        public static LogPassRole FindLogPassRole()
        {

            if (Jsoner.DeSerializeTable(App.Received).Rows.Count == 0) return new LogPassRole { Login = "0", Password = "0", Role = "-999" };
            else
            {
                LogPassRole logPassRole = new LogPassRole();
                logPassRole.Login = Jsoner.DeSerializeTable(App.Received).Rows[0]["Логин"].ToString();
                logPassRole.Password = Jsoner.DeSerializeTable(App.Received).Rows[0]["Пароль"].ToString();
                logPassRole.Role = Jsoner.DeSerializeTable(App.Received).Rows[0]["Роль"].ToString();
                return logPassRole;
            }
            
        }
        public static string RegisterCommand(string l, string p, string im, string f) => $"insert into Пользователи(Логин, Пароль, Имя, Фамилия, Роль) values ('{l}', '{p}', '{im}', '{f}', 3);";
        
        public static string GetTovarAndPrice() => @"select Название, Цена FROM Препараты ORDER BY random() LIMIT 1;" + '\n';

        public static TovarPrice FindTovarPrice()
        {
            if (Jsoner.DeSerializeTable(App.Received).Rows.Count == 0) return new TovarPrice { Name = "0", Price = "0" };
            else
            {
                TovarPrice tp = new TovarPrice();
                tp.Name = Jsoner.DeSerializeTable(App.Received).Rows[0]["Название"].ToString();
                tp.Price = Jsoner.DeSerializeTable(App.Received).Rows[0]["Цена"].ToString();
                return tp;
            }
        }
    }

}
