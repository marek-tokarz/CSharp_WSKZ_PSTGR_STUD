using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;
using System.Configuration;

namespace LINQ_ConsoleApp
{
    public class SimpleLINQquerries
    {
        IList<Users> userList;
        IList mixedList = new ArrayList();
        public void ArrayQueryMethod(string letter, string[] namesOfPeople)
        {
            var LINQquery = from peopleName in namesOfPeople
                            where peopleName.Contains(letter)
                            select peopleName;

            foreach (var name in LINQquery)
            {
                Console.WriteLine(name + " ");
            }
        }

        public void GenerateUsers()
        {
            userList = new List<Users>()
            {
                new Users() { UserID = 1, UserName = "John", UserAge = 13  },
                new Users() { UserID = 2, UserName = "Henry", UserAge = 21 },
                new Users() { UserID = 3, UserName = "Jacob", UserAge = 18 },
                new Users() { UserID = 4, UserName = "Robin", UserAge = 20 },
                new Users() { UserID = 5, UserName = "Tom", UserAge = 15 }
            };
        }

        public void DisplayAge(IList<Users> ul ) {
            var ulist = from user in ul
                        where user.UserAge > 12 && user.UserAge < 20
                        select user;
            Console.WriteLine("Those are names of people that fulfill requirement: ");
            foreach (Users user in ulist)
            {
                Console.WriteLine(user.UserName);
            }
        }

        public void DisplayOfIndex(int id)
        {
            var userName = from user in userList
                           where user.UserID == id
                           select user;
            Console.WriteLine("This is a name of a user that fulfills a requirements");
            foreach(Users user in userName)
            { 
                Console.WriteLine(user.UserName);
            }

        }

        public void DisplayWithMethod(IList<Users> ul)
        {
            var ulist = from user in ul
                       where this.IsTeenager(user)
                       select user;
            Console.WriteLine("Names choosed by method: ");
            foreach (Users user in ulist)
            { 
                Console.WriteLine(user.UserName);
            }
        }

        public bool IsTeenager(Users user)
        {
            return user.UserAge > 12 && user.UserAge < 20;
        }

        public void DisplayMixedElements()
        {
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Mary");
            mixedList.Add(4);
            mixedList.Add(new Users() { UserID = 1, UserName = "Anthony", UserAge = 23 });

            var stringResult = from str in mixedList.OfType<string>()
                               select str;
            var intResult = from ii in mixedList.OfType<int>()
                            select ii;
            var userResult = from user in mixedList.OfType<Users>()
                             select user;
            Console.WriteLine("Values of different types: ");

            foreach(var s in stringResult)
            {
                Console.WriteLine(s);
            }

            foreach(var integer in intResult)
            {
                Console.WriteLine(integer);
            }

            foreach(var u in userResult)
            {
                Console.WriteLine(u.UserName);
            }
        }

        public void DisplayOrderedUserNames(IList<Users> ul)
        {
            var orderedNames = from users in ul
                               orderby users.UserName
                               select users;

            Console.WriteLine("Ordered names: ");

            foreach(var us in orderedNames)
            {
                Console.WriteLine(us.UserName);
            }
        }

        public void DisplayMultiElements(IList<Users> ul)
        {
            var multiUserResult = from users in ul
                                  orderby users.UserName, users.UserAge
                                  select users;
            Console.WriteLine("Names and age of users: ");

            foreach(var us in multiUserResult)
            {
                Console.WriteLine("Name: {0}, age: {1}",us.UserName, us.UserAge);
            }
        }

        public void DisplayGroupedElements(IList<Users> ul)
        {
            var groupedElements = from users in ul
                               group users by users.UserAge;
            Console.WriteLine("Data ordered by an age of users: ");
            foreach(var ageGroup in groupedElements)
            {
                Console.WriteLine("An age group {0}", ageGroup.Key);
                foreach(Users user in ageGroup)
                {
                    Console.WriteLine("Name of a user: {0}", user.UserName);
                }
            }
        }

        public void DisplayExcept(IList<Users> ul, int howMany)
        {
            var result = ul.Skip(howMany);
            Console.WriteLine("Elements skiped: {0}", howMany);
            foreach(var users in result)
            {
                Console.WriteLine("Elements left {0}", users.UserName);
            }
        }

        public void DisplayDistinct(IList<Users> ul)
        {
            var result = ul.Distinct();
            Console.WriteLine("Unique elements: ");
            foreach(var userDistinct in result)
            {
                Console.WriteLine("User: {0}",userDistinct.UserName);
            }
        }

        public void DisplayUserName()
        {
            this.GenerateUsers();
            this.DisplayAge(userList);
            this.DisplayOfIndex(2);
            this.DisplayWithMethod(userList);
            this.DisplayMixedElements();
            this.DisplayOrderedUserNames(userList);
            this.DisplayMultiElements(userList);
            this.DisplayGroupedElements(userList);
            this.DisplayExcept(userList, 3);
            this.DisplayDistinct(userList);
        }
    }
}
