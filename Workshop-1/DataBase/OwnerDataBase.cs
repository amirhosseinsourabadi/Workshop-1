using Workshop_1.Models;

namespace Workshop_1.DataBase
{
    public static class OwnerDataBase
    {
        public static List<User> userSet = new List<User>();

        static OwnerDataBase()
        {
            userSet.Add(new User { name= "jafar gholi", idOfUserCart = {1,2,3,4 } });
            userSet.Add(new User { name = "hassan gholi", idOfUserCart = { 5, 6 } });
            userSet.Add(new User { name = "hosein gholi", idOfUserCart = { 7,8} });
            userSet.Add(new User { name = "reza gholi", idOfUserCart = { 9 } });
            userSet.Add(new User { name = "nader gholi", idOfUserCart = { 10,11 } });
            userSet.Add(new User { name = "gholi", idOfUserCart = { 12,13} });
        }
    }
}
