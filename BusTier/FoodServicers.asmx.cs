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
    /// Summary description for FoodServicers
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class FoodServicers : System.Web.Services.WebService
    {

        /*  [WebMethod]
          public DataTable GetAllFood()
          {
              try
              {
                  return FoodDAO.Instance.GetAllFood();
              }
              catch (Exception ex)
              {
                  throw ex;
              }
          }
          [WebMethod]
          public DataTable GetListFoodByCategoryID(int categoryID)
          {
              try
              {
                  return FoodDAO.Instance.GetListFoodByCategoryID(categoryID);
              }
              catch (Exception ex)
              {
                  throw ex;
              }
          }
           [WebMethod]
           public List<Food> SearchFoodByName(string name)
           {
               DataTable table;
               try
               {
                   table = FoodDAO.Instance.SearchFoodByName(name);
               }
               catch (Exception ex)
               {
                   throw ex;
               }

               List<Food> lstFood = new List<Food>();
               foreach (DataRow row in table.Rows)
               {
                   Food food = new Food(row);
                   lstFood.Add(food);
               }
               return lstFood;
           }*/
        [WebMethod]
        public bool InsertFood(Food newFood)
        {
            return FoodDAO.Instance.InsertFood(newFood);
        }

        public bool UpdateFood(Food food)
        {
            return FoodDAO.Instance.UpdateFood(food);
        }

        public bool DeleteFood(int ID)
        {
            return FoodDAO.Instance.DeleteFood(ID);
        }
    }
}
