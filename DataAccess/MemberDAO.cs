using System;
using System.Collections.Generic;
using BusinessObject;
using System.Linq;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public class MemberDAO
    {
        //Initialize the list of members
        private static List<MemberObject> MemberList = new List<MemberObject>() {
        new MemberObject
        {
            MemberID = 2,
            MemberName = "Phuong",
            Password = "123",
            Email = "phuong@gmail.com",
            City = "Ho Chi Minh",
            Country = "Viet Nam"

        },
        new MemberObject
        {
            MemberID = 3,
            MemberName = "Huy",
            Password = "123",
            Email = "huy@mgail.com",
            City = "Da Nang",
            Country = "Viet Nam"
        },
        new MemberObject
        {
            MemberID = 4,
            MemberName = "Hanh",
            Password = "123",
            Email = "hanh@fpt.edu.vn",
            City = "London",
            Country = "England"
        },
        new MemberObject
        {
            MemberID = 5,
            MemberName = "Binh",
            Password = "123",
            Email = "binh@gmail.com",
            City = "California",
            Country = "USA",
        }
    };

        //Initialize the default member - admin
        private static MemberObject DefaultMember()
        {
            MemberObject Admin = null;
            IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json", true, true)
                                        .Build();

            string email = config["author:default:email"];
            string password = config["author:default:password"];

            Admin = new MemberObject
            {
                MemberID = 1,
                MemberName = "Admin",
                Email = email,
                Password = password,
                City = "Ho Chi Minh",
                Country = "Viet Nam"
            };
            return Admin;
        }

        //Using Singleton Pattern
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO()
        {
            MemberObject Admin = DefaultMember();
            if (Admin != null)
            {
                MemberList.Add(Admin);
            }
        }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        // get list of member
        public List<MemberObject> GetMemberList => MemberList;

        //get member by ID - LINQ
        public MemberObject GetMemberByID(int memberID)
        {
             MemberObject member = 
                MemberList.SingleOrDefault
                (temp => temp.MemberID == memberID);
            return member;
        }
        //get member by name - LINQ
        public MemberObject GetMemberByName(string memberName)
        {
            MemberObject member =
               MemberList.SingleOrDefault
               (temp => temp.MemberName.Equals(memberName));
            return member;
        }
        //get member by email - LINQ
        public MemberObject GetMemberByEmail(string email)
        {
            MemberObject member =
               MemberList.SingleOrDefault
               (temp => temp.Email.Equals(email));
            return member;
        }
        //Function Login
        public MemberObject Login(string email, string password)
        {
            MemberObject member = 
                MemberList.SingleOrDefault
                (temp => temp.Email.Equals(email) && temp.Password.Equals(password));
            return member;
        }
        //Function Add member

        public void AddMember(MemberObject member)
        {
            if (member == null)
            {
                throw new Exception("member is null");
            }

            if (GetMemberByID(member.MemberID) == null && GetMemberByEmail(member.Email) == null)
            {
                MemberList.Add(member);
            } else
            {
                throw new Exception("Member already exits or duplicated email");
            }
        }

        //Function Update member
        public void UpdateMember(MemberObject member)
        {
            if (member == null)
            {
                throw new Exception("member is null");
            }
            MemberObject temp = GetMemberByID(member.MemberID);
            if (temp != null)
            {
                var index = MemberList.IndexOf(temp);
                MemberList[index] = member;
            }
            else
            {
                throw new Exception("Member does not exit");
            }
        }

        //Function Delete member
        public void DeleteMember(int memberID)
        {
            MemberObject member = GetMemberByID(memberID);
            if (member != null)
            {
                MemberList.Remove(member);
            } else
            {
                throw new Exception("Member does not exist");
            }
        }

        //Function Search member by City
        public IEnumerable<MemberObject> SearchCity(string City)
        {
            if (City == null)
            {
                throw new Exception("City is null");
            }
            var key = City.Trim().ToLower();
            IEnumerable<MemberObject> list = null;
            if (key.Equals("All"))
            {
                list = from member in MemberList
                             select member; 
                    
            }
            var result = from member in MemberList
                         where member.City.ToLower().Contains(key)
                         select member;
            list = result;
            return list;
        }

        //Function Search member by Country
        public IEnumerable<MemberObject> SearchCountry(string Country)
        {
            if (Country == null)
            {
                throw new Exception("Country is null");
            }
            var key = Country.Trim().ToLower();
            IEnumerable<MemberObject> list = null;
            if (key.Equals("All"))
            {
                list = from member in MemberList
                       select member;
            }
            var result = from member in MemberList
                         where member.Country.ToLower().Contains(key)
                         select member;
            list = result;
            return list;
        }
        //Function Search member by ID and Name
        public IEnumerable<MemberObject> SearchIDAndName(string ID, string name)
        {
            IEnumerable<MemberObject> members = null;
            if (ID == null || ID.Equals(""))
            {
                throw new Exception("ID is empty!");
            } else if (name == null || name.Equals(""))
            {
                throw new Exception("Name is empty!");
            }
            else
            {
                int tempID = int.Parse(ID);
                var result = from temp in MemberList
                             where temp.MemberID == tempID && temp.MemberName.ToLower().Trim().Contains(name.Trim().ToLower())
                             select temp;
                members = result;
            }            
            return members;
        }
    }
}
