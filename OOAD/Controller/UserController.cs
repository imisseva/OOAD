using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOAD.Model;
namespace OOAD.Controller
{
    public class UserController
    {
        private readonly MeetingsEntities db = new MeetingsEntities();
        public List<User> GetUsers()
        {
            return db.User.ToList();
        }

        public User GetUserDetails(int id)
        {
            return db.User.FirstOrDefault(u => u.id == id);
        }

        public void CreateUser(string name)
        {
            var user = new User
            {
                Name = name
            };
            db.User.Add(user);
            db.SaveChanges();
        }
        public void EditUser(int id, string name)
        {
            var user = db.User.Find(id);
            if (user != null)
            {
                user.Name = name;
                db.SaveChanges();
            }
        }
        public void DeleteUser(int id)
        {
            var user = db.User.Find(id);
            if (user != null)
            {
                db.User.Remove(user);
                db.SaveChanges();
            }
        }
    }
}
