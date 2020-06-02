using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace WebService
{
    /// <summary>
    /// Summary description for ProductWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ProductWebService : System.Web.Services.WebService
    {

        Model ctx = new Model();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<ProductDT> ProductList()
        {
            return ctx.Products.Select(x => new ProductDT { BrandId = x.BrandId, CategoryId = x.CategoryId, Description = x.Description, Id = x.Id, Discount = x.Discount, ImageUrl = x.ImageUrl, Name = x.Name, Price = x.Price, Stock = x.Stock, Tax = x.Tax, CreateDate = x.CreateDate, DeleteDate = x.DeleteDate, IsDelete = x.IsDelete, UpdateDate = x.UpdateDate }).ToList();
        }
    }
}
