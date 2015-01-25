using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.Expressions;
using LibraryManagementSystem.DAL.DAO;
using LibraryManagementSystem.DAL.DBGateway;

namespace LibraryManagementSystem.BLL
{
    public class MemberManager
    {
        MemberDbGateway aMemberDbGateway = new MemberDbGateway();

        public Member Search(int number)
        {
          return  aMemberDbGateway.UniqueCheker(number);
        }

        public string Save(Member aMember)
        {
            if (aMemberDbGateway.UniqueCheker(aMember.Number) == null)
            {
                aMemberDbGateway.Save(aMember);
                return "Saved";
            }
            else
            {
                return "Already exists";
            }
        }
    }
}