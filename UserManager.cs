using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    public class UserManager
    {
        static UserManager userManager;

        List<User> users = new List<User>()
        {
            new User(1,"Fatoş","12345","En sevdiğin renk?","turuncu"),
            new User(2,"Aykan","12345","En sevdiğin yemek?","Köfte"),
            new User(3,"Akın","12345","En sevdiğin marka?","Fender"),
            new User(4,"Anıl","12345","En sevdiğin şehir?","İzmir")
        };
        private UserManager()
        {

        }
        public string AddUser(User user)
        {
            try
            {
                if (!IsUserComplete(user))
                {
                    return "Kullanıcı eklenemez.";

                }
                if (!IsUserPassword(user.Password))
                {
                    return "Şifre yeteri kadar güvenli değil.";
                }
                users.Add(user);
                return user.Name + " olarak başarıyla kaydoldunuz.";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public string UpdatePassword(int userId, string password)
        {
            try
            {
                if (!IsUserPassword(password))
                {
                    return "Şifre yeteri kadar güvenli değil.";
                }
                foreach (User item in users)
                {
                    if (item.Id == userId)
                    {
                        item.Password = password;
                        return "Şifreniz başarıyla güncellendi.";
                    }
                }
                return "Kullanıcı bulunamadı.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public bool LoginControl(string userName, string password)
        {
            try
            {
                foreach (var item in users)
                {
                    if (item.Name == userName && item.Password == password)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        bool IsUserComplete(User user)
        {
            if (string.IsNullOrEmpty(user.Name) ||
                string.IsNullOrEmpty(user.Password) ||
                string.IsNullOrEmpty(user.Question) ||
                string.IsNullOrEmpty(user.Answer))
            {
                return false;
            }
            return true;

        }

        bool IsUserPassword(string userPassword)
        {
            if (string.IsNullOrEmpty(userPassword))
            {
                return false;
            }
            if (userPassword.Length < 8 || userPassword.Contains("123456"))
            {
                return false;
            }
            return true;
        }
        public int GetUserIdByUserName(string userName)
        {
            foreach (var user in users)
            {
                if (user.Name == userName)
                {
                    return user.Id;

                }
            }
            return -1;
        }
        public string GetQuestionByUserId(int userId)
        {
            foreach (var user in users)
            {
                if (user.Id == userId)
                {
                    return user.Question;
                }
            }
            return "";
        }
        public static UserManager GetInstance()
        {
            if (userManager == null)
            {
                userManager = new UserManager();
            }
            return userManager;
        }
        public string GetAnswerByUserId(int userId)
        {
            foreach (var user in users)
            {
                if (user.Id == userId)
                {
                    return user.Answer;
                }
            }
            return "";
        }
        public string GetUserNameByUserId(int userId)
        {
            foreach (var user in users)
            {
                if (user.Id == userId)
                {
                    return user.Name;
                }
            }
            return "";
        }
    }
}
