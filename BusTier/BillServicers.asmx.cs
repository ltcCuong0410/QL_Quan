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
    /// Summary description for BillServicers
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BillServicers : System.Web.Services.WebService
    {

        [WebMethod]
        public int GetUnCheckBillIDByTableID(int id)
        {
            try
            {
                return BillDAO.Instance.GetUnCheckBillIDByTableID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public void InsertBill(int tableID)
        {
            try
            {
                BillDAO.Instance.InsertBill(tableID);
            }
            catch { }
        }
        [WebMethod]
        public int GetMaxBillID()
        {
            try
            {
                return BillDAO.Instance.GetMaxBillID();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public void CheckOut(int billID, int discount, int totalPrice)
        {
            try
            {
                BillDAO.Instance.CheckOut(billID, discount, totalPrice);
            }
            catch { }
        }
        [WebMethod]
        public DataTable GetListBillByDate(DateTime fromDate, DateTime toDate)
        {
            try
            {
                return BillDAO.Instance.GetListBillByDate(fromDate, toDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public bool DeleteBill(int id)
        {
            try
            {
                return BillDAO.Instance.DeleteBill(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
