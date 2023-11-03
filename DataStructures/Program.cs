using Bank.Models;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userDetails = new Dictionary<int, string>();
            int[] numbers = { 1, 2, 3 };
            string[] users = { "Anthony", "Tola"};

            userDetails.Add(1, "Anthony");
            userDetails.Add(2, "12");
            userDetails.Add(3, "12");
            userDetails.Add(4, "12");
            userDetails.Add(5, "12");

            //  Console.WriteLine(userDetails[1]);

            var username = userDetails.TryGetValue(1, out var details);
            if (username)
            {
              //  Console.WriteLine(details);

            }
            else
            {
              //  Console.WriteLine("User not found");
            }

            List<string> list = new List<string>();
            list.Add("Anthony");
            list.Add("Jerry");
            list.Add("Precious");


/*            foreach (var item in list)
            {
                Console.WriteLine(item);
            }*/

            List<User> listUsers = new List<User>();

            // Creating Users details
            var currentUser = new User(1, "Anthony");
            var currentUser2 = new User(2, "Jerry");
            var currentUser3 = new User(3, "John");


            // Adding Users Details to our list
            listUsers.Add(currentUser);
            listUsers.Add(currentUser2);
            listUsers.Add(currentUser3);


            // Retrive details from our list
            foreach ( var user in listUsers)
            {
                Console.WriteLine($"User Id: {user.Id}");
                Console.WriteLine($"Username: {user.Name}");
            }

            // User One
            var userComplexObject = new Dictionary<string, object>();
            BankDetails bankDetails = new BankDetails(12344567, "uba");

            userComplexObject.Add("Id", currentUser.Id);
            userComplexObject.Add("Name", currentUser.Name);
            userComplexObject.Add("BankDetails", bankDetails);

            // User Two
            var userComplexObject2 = new Dictionary<string, object>();
            BankDetails bankDetails2 = new BankDetails(12344567, "FirstBank");

            userComplexObject.Add("Id", currentUser2.Id);
            userComplexObject.Add("Name", currentUser2.Name);
            userComplexObject.Add("BankDetails", bankDetails2);

            // Create List of User Details
            var listOfUserDetails = new List<Dictionary<string, object>>();
            listOfUserDetails.Add(userComplexObject);
            listOfUserDetails.Add(userComplexObject2);



            /*
            {
              {
               "Id" : 12345
               "Name" : "Anthony Adedayo",
               "BankDetails" : {
                   "AccountNumber" : 123445678,
                   "BankName": "uba"
               },

               {
                  "Id" : 12345
                  "Name" : "Anthony Adedayo",
                  "BankDetails" : {
                       "AccountNumber" : 123445678,
                       "BankName": "uba"
               }
             }
             
             */



        }
    }
}