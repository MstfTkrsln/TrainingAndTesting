using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Delegates_Console
{
    class Program
    {
        /// <summary>
        ///     Kullanicilar uzerinde yapilan islemleri handle eden temel delegate
        /// </summary>
        /// <param name="user">Uzerinde islem yapilan kullanici</param>
        public delegate void UserEventHandler(User user);

        public delegate void RecordEventHandler(string mesaj);
        /// <summary>
        ///  Kullanicilar uzerinde islemlerin yapildigi siniftir
        /// </summary>
        public class UserContext
        {
            /// <summary>
            ///  SaveUserToDatabase isimli static metodu UserCreated isimli UserEventHandler'a atiyoruz. 
            /// Dogrudan metod ismi ile verdigimiz icin Implicit delegate creation yapmis olduk.
            /// </summary>
            private UserEventHandler _userCreated;

            private event RecordEventHandler Record;
            


            public void OnRecord(string mesaj)
            { 
                Record(mesaj);
            }

            public UserContext()
            {
                
                
                UserCreated += SaveUserToDatabase;
                
                // SendRegisterationSmsToUser metodu UserCreated delegete'i icine atiliyor.
                UserCreated += SendRegisterationSmsToUser;

                // NotifyManager metodu UserCreated delegete'i icine atiliyor.
                // Delegate new UserEventHandler() seklinde olusturuldugundan Explicit delegate creation yapmis olduk.
                UserCreated += new UserEventHandler(NotifyManager);

                Record += mesajYaz;
                Record += mesajBuyukYaz;
                
            }

            /// <summary>
            ///  SaveUserToDatabase isimli static metodu UserCreated isimli UserEventHandler'a atiyoruz. 
            /// Dogrudan metod ismi ile verdigimiz icin Implicit delegate creation yapmis olduk.
            /// </summary>
            public UserEventHandler UserCreated
            {
                get { return _userCreated; }
                set { _userCreated = value; }
            }

            public void CreateUser(string username, string mobilPhone)
            {
                

                //..
                User user = new User
                {
                    Username = username,
                    MobilePhone = mobilPhone
                };
                //..

                //Kullanici yaratildi event'i tetikleniyor. Kullanici yaratildiktan sonra yapilmasi gereken
                //islemler otomatik olarak yapiliyor.
                UserCreated(user);
                
        }

            /// <summary>
            /// Kullaniciyi database uzerine kaydeden metod
            /// </summary>
            /// <param name="user">Yaratilan kullanici</param>
            private static void SaveUserToDatabase(User user)
            {
                //.. Database islemleri
                Console.WriteLine(user + @" Database'e kaydedildi");
            }

            /// <summary>
            /// Kullaniciya kayit sonrasi sms gonderen metod
            /// </summary>
            /// <param name="user">Yaratilan kullanici</param>
            private void SendRegisterationSmsToUser(User user)
            {
                //..Sms gonderim islemi
                Console.WriteLine(user.MobilePhone + @" numarasina sms gonderildi.");
            }

            /// <summary>
            /// Kullanıcının kaydolduguna dair yoneticiyi bilgilendiren metod
            /// </summary>
            /// <param name="user">Yaratilan kullanici</param>
            private void NotifyManager(User user)
            {
                //.. Yoneticiyi haberdar etme islemi
                Console.WriteLine(user.Username + @" Manager'a haberdar edildi.");
            }

            static void mesajYaz(string mesaj)
            {
                Console.WriteLine(mesaj);
            }

            static void mesajBuyukYaz(string mesaj)
            {
                Console.WriteLine(mesaj.ToUpper());
            }
        }

        /// <summary>
        ///     Kullanici'ya ait bilgilerin tutuldugu siniftir.
        /// </summary>
        public class User
        {
            public string Username { get; set; }
            public string MobilePhone { get; set; }

            public override string ToString()
            {
                return Username;
            }
        }
        

        static void Main(string[] args)
        {
            UserContext context = new UserContext();
                context.CreateUser("Mustafa", "+905555555555");
           
            Console.WriteLine();
            Console.WriteLine(); 
            Console.WriteLine();

            context.OnRecord("mustafa tekeraslan");

          

            Console.ReadKey();
        }
    }
}
