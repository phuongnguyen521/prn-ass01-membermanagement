using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void AddMember(MemberObject member)
        => MemberDAO.Instance.AddMember(member);

        public void DeleteMember(int memberID)
        => MemberDAO.Instance.DeleteMember(memberID);

        public void UpdateMember(MemberObject member)
        => MemberDAO.Instance.UpdateMember(member);

        public IEnumerable<MemberObject> GetMembers()
        => MemberDAO.Instance.GetMemberList;

        public MemberObject Login(string email, string password)
        => MemberDAO.Instance.Login(email, password);

        public IEnumerable<MemberObject> SearchCity(string City)
        => MemberDAO.Instance.SearchCity(City);

        public IEnumerable<MemberObject> SearchCountry(string Country)
        => MemberDAO.Instance.SearchCountry(Country);

        public IEnumerable<MemberObject> SearchIDAndName(string ID, string Name)
        => MemberDAO.Instance.SearchIDAndName(ID, Name);
    }
}
