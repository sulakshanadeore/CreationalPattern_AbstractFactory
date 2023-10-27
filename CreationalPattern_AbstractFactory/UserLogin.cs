using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CreationalPattern_AbstractFactory
{
    public class UserLogin
    {
        private static UserLogin instance = null;
        private static object _lockobject=new object(); 
        public string Userid { get; set; }
        public string Password { get; set; }

      //  public  static UserLogin Usercreation { get { return instance; } private set { instance = value; } }

        private UserLogin()
        {
            
        }


        public static UserLogin CreateUserUsingMutex()
        {
            
                        if (instance!=null)
                    {
                        Console.WriteLine("User already created");
                    }
               else
                {
                    instance = new UserLogin();
                }
                return instance;
            
             
        }


            public static UserLogin CreateUser()
        {
            lock (_lockobject)
            {
                if (UserLogin.instance == null)
                {
                    instance = new UserLogin();
                }

            }
            return instance;
        }


    }
}
