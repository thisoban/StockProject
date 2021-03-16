using DAL;
using DataModel;
using System;

namespace Logic
{
    public class UserLogic
    {
        private readonly UserDal daluser;

        public bool CheckUser(UserDataModel user)
        {
            bool checkCredentia= false;
            UserDataModel data = daluser.Getuser(user);

            if(user.Username == data.Username)
            {
                if(user.Passsword == data.Passsword)
                {
                    checkCredentia = true;
                }
            }
            return checkCredentia;
        }

        public bool Register(UserDataModel user)
        {
            bool registered = false;
            if (UserExist(user) == false)
            {
                //register user
            }
            return registered;
        }

        private bool UserExist(UserDataModel user)
        {
            bool exist = false;

            if (user.Email == daluser.Getuser(user).Email || user.Username == daluser.Getuser(user).Username)  
            {
                exist = true;
            }
            return exist;
        }
    }
}