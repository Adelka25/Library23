using Library.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Library
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    { //если пользователь авторизовался то выводится кнопка выход 
        public static bool isAuth;
        //хранится все об в авторизованном пользователе
        public static User AuthUser = new User();
        //соединение с базой
        public static libraryyContext db = new libraryyContext();
    }
}
