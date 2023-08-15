using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BusTier
{
    /// <summary>
    /// Summary description for AccountServicers
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AccountServicers : System.Web.Services.WebService
    {

       /* [WebMethod]
        public bool CheckLogin(Account account)
        {
            if (account.UserName == "")
                return false;
            if (account.Password == "")
                return false;

            try
            {
                return AccountDAO.Instance.CheckLogin(account);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/
        [WebMethod]
        public DataTable GetAllAcount()
        {
            try
            {
                return AccountDAO.Instance.GetAllAcount();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /* [WebMethod]
         public Account GetAccountByUserName(string userName)
        {
            DataTable table;
            try
            {
                table = AccountDAO.Instance.GetAccountByUserName(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return new Account(table.Rows[0]);
        }*/
        [WebMethod]
        public bool Insert(string userName, string displayName, int type)
        {
            try
            {
                return AccountDAO.Instance.Insert(userName, displayName, type);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public bool Delete(string userName)
        {
            try
            {
                return AccountDAO.Instance.Delete(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public bool ResetPassword(string userName)
        {
            try
            {
                return AccountDAO.Instance.ResetPassword(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public bool UpdateInformation(string userName, string displayName, string password, string newPass)
        {
            try
            {
                return AccountDAO.Instance.UpdateInformation(userName, displayName, password, newPass);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      /*  [WebMethod]
        public List<Account> SearchAccountByUserName(string userName)
        {
            List<Account> listAccount = new List<Account>();
            DataTable table;
            try
            {
                table = AccountDAO.Instance.SearchAccountByUserName(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            foreach (DataRow row in table.Rows)
            {
                Account account = new Account(row);
                listAccount.Add(account);
            }
            return listAccount;
        }*/
    }
}
