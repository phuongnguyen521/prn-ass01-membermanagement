using System;
using System.ComponentModel.DataAnnotations;

namespace BusinessObject
{
    public class MemberObject : IComparable
    {
        //ID
        public int MemberID { get; set;}
        
        //Name
        [Required]
        [DataType(DataType.Text)]
        public string MemberName
        {
            get;set;
        }

        //Password  
        public string Password { get; set; }
        
        //Email
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Wrong Email Address format")]
        public string Email { get;set; }

        //City
        [Required]
        [DataType(DataType.Text)]
        public String City
        {
            get;set;
        }
        
        //Country
        [Required]
        [DataType(DataType.Text)]
        public String Country
        {
            get;set;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is MemberObject))
            {
                throw new ArgumentException("Compared object is not of car");
            }
            MemberObject member = obj as MemberObject;
            return member.MemberName.CompareTo(MemberName);
        }
    }
}
