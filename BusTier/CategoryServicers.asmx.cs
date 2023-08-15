using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BusTier
{
    /// <summary>
    /// Summary description for CategoryServicers
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CategoryServicers : System.Web.Services.WebService
    {

        [WebMethod]
        public DataTable GetAllCategory()
        {
            try
            {
                return CategoryDAO.Instance.GetAllCategory();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public bool InsertCategory(string name)
        {
            try
            {
                return CategoryDAO.Instance.InsertCategory(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public bool UpdateCategory(int id, string name)
        {
            try
            {
                return CategoryDAO.Instance.UpdateCategory(id, name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public bool DeteleCategory(int id)
        {
            try
            {
                return CategoryDAO.Instance.DeteleCategory(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
