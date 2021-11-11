using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<MemberObject> GetMembers();
        MemberObject Login(string email, string password);

        void AddMember(MemberObject member);
        void UpdateMember(MemberObject member);
        void DeleteMember(int memberID);

        IEnumerable<MemberObject> SearchCity(string City);
        IEnumerable<MemberObject> SearchCountry(string Country);

        IEnumerable<MemberObject> SearchIDAndName(string ID, string Name);

    }
}
