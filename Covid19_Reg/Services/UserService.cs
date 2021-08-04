using Covid19_Reg.Models;
namespace Covid19_Reg.Services
{
    class UserService
    {
        public static void Create(User user)
        {
            using (var db = new Covid19_RegContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
        public static bool isUserExist(string userName)
        {
            using (var db = new Covid19_RegContext())
            {
                if (db.Users.Find(userName) != null)
                {
                    return true;
                }
                else return false;
            }
        }

        public static User FindUserByNamePasswd(string userName, string passwd)
        {
            using (var db = new Covid19_RegContext())
            {
                var _user = db.Users.Find(userName);
                //注意：此处获得到_user后必须用Trim()方法
                //使用**断点**可以检测到_user的UserPasswd字段后面有空格！
                if (_user != null && _user.UserPasswd.Trim().Equals(passwd) )
                {
                    return _user;
                }
                else return null;

            }
        }
    }
}
