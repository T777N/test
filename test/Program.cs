using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Main_progaram
{
    namespace AdminNamespace
    {
        //Admin=>id,username,email,password,Posts,Notifications
        class Admin
        {
            public int ID { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public int Count { get; set; }


            public Admin()
            {
                ID = 0;
                Username = string.Empty;
                Email = string.Empty;
                Password = string.Empty;

            }

            public Admin(int iD, string username, string email, string password, PostNamespace.Post posts, UserNamespace.Notification notifications)
            {
                ID = iD;
                Username = username;
                Email = email;
                Password = password;
                ++Count;

            }

            public void Show_admin()
            {
                Console.WriteLine();
                Console.WriteLine($" - - - - - Admin Informations - - - - - ");
                Console.WriteLine($" ID : {ID} ");
                Console.WriteLine($" Username : {Username} ");
                Console.WriteLine($" Email : {Email} ");
                Console.WriteLine($" Password : {Password} ");
                Console.WriteLine();
            }

        }


    }

    namespace UserNamespace
    {
        //User => id,name,surname,age,email,password
        class User
        {

            public int ID { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }

            public User()
            {
                ID = 0;
                Age = 0;
                Name = string.Empty;
                Surname = string.Empty;
                Email = string.Empty;
                Password = string.Empty;


            }

            public User(int iD, string name, string surname, int age, string email, string password)
            {
                ID = iD;
                Age = age;
                Name = name;
                Surname = surname;
                Email = email;
                Password = password;

            }
            public void Add(int iD, string name, string surname, int age, string email, string password)
            {
                ID = iD;
                Age = age;
                Name = name;
                Surname = surname;
                Email = email;
                Password = password;

            }

            public void Show_User()
            {
                Console.WriteLine();
                Console.WriteLine($" - - - - - User Informations - - - - - ");
                Console.WriteLine($" ID : {ID} ");
                Console.WriteLine($" Name : {Name} ");
                Console.WriteLine($" Surname : {Surname} ");
                Console.WriteLine($" Age : {Age} ");
                Console.WriteLine($" Email : {Email} ");
                Console.WriteLine($" Password : {Password} ");
                Console.WriteLine();
            }

        }
        //Notification=>id,Text,DateTime,FromUser(bu hansi user terefinden bu bildirishin geldiyidir)
        class Notification
        {
            public int ID { get; set; }
            public string Text { get; set; }
            public DateTime Datetime { get; set; }
            public Notification()
            {
                ID = 0;
                Text = string.Empty;
                Datetime = DateTime.Now;
            }

            public Notification(int iD, string text, User fromUser)
            {
                ID = iD;
                Text = text;
                Datetime = DateTime.Now;
            }

            public void Show_Notification()
            {
                Console.WriteLine();
                Console.WriteLine($" - - - - - Notification Informations - - - - - ");
                Console.WriteLine($" ID : {ID} ");
                Console.WriteLine($" Text : {Text} ");
                Console.WriteLine($" DateTime : {Datetime} ");
                Console.WriteLine();
            }

        }
    }

    namespace PostNamespace
    {
        //Post => id,Content,CreationDateTime,LikeCount,ViewCount
        class Post
        {

            public int ID { get; set; }
            public string Content { get; set; }
            public DateTime CreationDateTime { get; set; }
            public int LikeCount { get; set; }
            public int ViewCount { get; set; }

            public Post()
            {
                ID = 0;
                Content = string.Empty;
                CreationDateTime = DateTime.Now;
                LikeCount = 0;
                ViewCount = 0;
            }

            public Post(int iD, string content)
            {
                ID = iD;
                Content = content;
                CreationDateTime = DateTime.Now;
                LikeCount = 0;
                ViewCount = 0;
            }

            public void Show()
            {
                Console.WriteLine();
                Console.WriteLine($" - - - - - Post Informations - - - - - ");
                Console.WriteLine($" ID : {ID} ");
                Console.WriteLine($" Content : {Content} ");
                Console.WriteLine($" Creation Date Time : {CreationDateTime} ");
                Console.WriteLine($" Like Count : {LikeCount} ");
                Console.WriteLine($" View Count : {ViewCount} ");
                Console.WriteLine();
            }
        }


    }

    namespace Namespace
    {

        class Progaram
        {

           
            static void Start()
            {
                UserNamespace.User user1 = new UserNamespace.User(1, "Fazil1", "Eliyev1", 19, "fazil1.eliyev@gamil.com", "fazil1231");
                UserNamespace.Notification notification1 = new UserNamespace.Notification(1, " Hello World 1 ", user1);
                PostNamespace.Post post1 = new PostNamespace.Post(1, " photo 1");
                AdminNamespace.Admin admin1 = new AdminNamespace.Admin(1, "Armagedon1", "Armagedon1@Hotmail.com", "CrazyHamburger1", post1, notification1);

                UserNamespace.User user2 = new UserNamespace.User(2, "Fazil2", "Eliyev2", 19, "fazil2.eliyev@gamil.com", "fazil1232");
                UserNamespace.Notification notification2 = new UserNamespace.Notification(2, " Hello World 2 ", user1);
                PostNamespace.Post post2 = new PostNamespace.Post(2, "photo2");
                AdminNamespace.Admin admin2 = new AdminNamespace.Admin(2, "Armagedon2", "Armagedon2@Hotmail.com", "CrazyHamburger2", post1, notification1);

                UserNamespace.User user3 = new UserNamespace.User(3, "Fazil3", "Eliyev3", 19, "fazil3.eliyev@gamil.com", "fazil1233");
                UserNamespace.Notification notification3 = new UserNamespace.Notification(3, " Hello World 3 ", user1);
                PostNamespace.Post post3 = new PostNamespace.Post(3, "photo3");
                AdminNamespace.Admin admin3 = new AdminNamespace.Admin(3, "Armagedon3", "Armagedon3@Hotmail.com", "CrazyHamburger3", post1, notification1);



                AdminNamespace.Admin[] admins = new AdminNamespace.Admin[] { admin1, admin2, admin3 };
                PostNamespace.Post[] posts = new PostNamespace.Post[] { post1, post2, post3 };
                UserNamespace.User[] users = new UserNamespace.User[] { user1, user2, user3 };
                UserNamespace.Notification[] notifications = new UserNamespace.Notification[] { notification1, notification2, notification3 };
                UserNamespace.Notification[] notifications2 = new UserNamespace.Notification[3];
                int notCount = 0;


                //Users_and_Admins
                //
                void Start2()
                {

                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine($" Admin [ 1 ] ");
                    Console.WriteLine($" User [ 2 ] ");
                    Console.WriteLine();
                    Console.Write($" Enter : ");
                    string AdminOrUser = Console.ReadLine();
                    if (AdminOrUser == "1")
                    {
                        void Start3(){

                        //AdminNamespace.Admin admin2= new AdminNamespace.Admin();
                        Console.Clear();
                        Console.WriteLine();
                        Console.Write($" Enter Username : ");
                        string In_Admin_username = Console.ReadLine();
                        Console.Write($" Enter Password : ");
                        string In_Admin_password = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($" Back [ 0 ] ");
                        Console.WriteLine($" Posts [ 1 ] ");
                        Console.WriteLine($" Notvications [ 2 ] ");
                        Console.Write($" Enter : ");
                        string abc = Console.ReadLine();
                        if (abc == "1")
                        {

                        for (int i = 0; i < admins.Length; i++)
                        {
                            if (In_Admin_username == admins[i].Username && In_Admin_password == admins[i].Password)
                            {
                                Console.Clear();
                                for (int k = 0; k < admins.Length; k++)
                                {

                                    posts[k].Show();
                                }
                                break;
                            }

                        }
                                Console.WriteLine();

                                Console.WriteLine($" Back [ 0 ] ");
                                Console.Write($" Enter : ");
                                string admin_back = Console.ReadLine();
                                if (admin_back == "0")
                                {
                                    Start3();
                                }
                                else
                                {
                                    Start3();
                                }
                        }
                        else if (abc == "2")
                        {
                            if (notifications2.Length!=0)
                            {   
                                for (int i = 0; i < notCount; i++)
                                {
                                       
                                    notifications2[i].Show_Notification();
                                        
                                }
                                    Console.WriteLine();
                                    Console.WriteLine($" Back [ 0 ]");
                                    Console.Write($" Enter : ");
                                    string admin_notv_back = Console.ReadLine();
                                    if (admin_notv_back == "0")
                                    {
                                        Start3();
                                    }
                                    else
                                    {
                                        Start3();
                                    }
                            }
                            else
                            {
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine($" Empty ");
                                    Console.WriteLine();
                                    Console.WriteLine($" Back [ 0 ] ");
                                    Console.Write($" Enter : ");
                                    string Admin_empty_back = Console.ReadLine();
                                    if (Admin_empty_back == "0")
                                    {
                                        Start3();
                                    }
                                    else
                                    {
                                        Start3();
                                    }
                                
                            }
                        }
                        else if (abc == "0")
                            {
                                Start2();
                            }
                        else
                        {
                                Start3();
                        }

                        }
                        Start3();
                        
                    }
                    else if (AdminOrUser == "2")
                    {
                        //user
                        Console.Clear();
                        Console.WriteLine();
                        Console.Write($" Enter Username : ");
                        string In_USer_username = Console.ReadLine();
                        Console.Write($" Enter Password : ");
                        string In_USer_password = Console.ReadLine();
                        for (int l = 0; l < posts.Length; l++)
                        {
                            if (In_USer_username == users[l].Name && In_USer_password == users[l].Password)
                            {
                                Console.Clear();
                                for (int k = 0; k < posts.Length; k++)
                                {

                                   posts[k].Show();
                                   posts[k].ViewCount += 1;

                                   
                                }

                            }
                        }
                            Console.WriteLine();
                            Console.WriteLine($" Back [ -1 ]");
                            Console.Write($" Enter like post ID : ");
                            string backORID = Console.ReadLine();
                            int i = Convert.ToInt32(backORID);
                            if (backORID == "-1")
                            {
                                Start2();

                            }
                            else
                            {
                                
                                
                                    for (int k = 0; k < posts.Length; k++)
                                    {
                                        if (posts[k].ID == i)
                                        {
                                            posts[k].LikeCount += 1;
                                        notifications2[notCount] = notifications[k];
                                        ++notCount;
                                        Start2();
                                    break;
                                        }

                                    }
                            Start2();
                                
                            }

                    }

                    else
                    {

                        bool a = true;
                        while (a)
                        {
                            Start2();
                        }
                    }
                }
                Start2();
            }
            static void Main(string[] args)
            {
                 Start();

                

               
            }
        }
    }
}

