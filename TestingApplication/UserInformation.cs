using System;
using System.Collections.Generic;
using System.Text;

namespace TestingApplication
{
    class UserInformation
    {
        public Users _addUser;
        public List<Users> _getUser;
        public List<Users> _defaultUser;
        public List<Users> _userList;
        public List<Users> _DeleteUser;
        public List<Group> groupData;


        public UserInformation (Users Iuser)
        {
            _addUser = Iuser;
        }

       


        public UserInformation ()
        {
            _defaultUser = new List<Users>
            {
                new Users
                {
                    UpdatedBy = "Mike",
                    UpdatedOn = "11/2/2021",
                    Name = "John",
                    FatherName = "Nelson",
                    Address = "USA",
                    cell = 0909

                },
                new Users
                {
                    CreatedBy = "Ibhi",
                    CreatedOn = "10/9/2020",
                    Name = "NAS",
                    FatherName = "Alene",
                    Address = "USA",
                    cell = 999990

                }
            };
        }

        public UserInformation (List<Users> GetUser)
        {
            _userList = GetUser;
        }

        public UserInformation (List<Users> DeleteUser)
        {
            _DeleteUser = DeleteUser;
        }



        

    }
}
