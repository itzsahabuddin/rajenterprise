using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajEnterpriseBusinessLogic
{
    public class StockModels
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string Company { get; set; }
        public string Weight { get; set; }
        public string Details { get; set; }
        public string MRP { get; set; }
        public string Rate { get; set; }
        public string SGST { get; set; }
        public string CGST { get; set; }
        public string IGST { get; set; }
        public string Stock { get; set; }
        public string TotalAmount { get; set; }
    }

    public class CustomerModel
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string GstNo { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public bool Diactivate { get; set; }
    }

    public class SalesModel
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string Company { get; set; }
        public string Quantity { get; set; }
        public string Weight { get; set; }
        public string Details { get; set; }
        public string MRP { get; set; }
        public string Rate { get; set; }
        public string Discount { get; set; }
        public string SGST { get; set; }
        public string CGST { get; set; }
        public string IGST { get; set; }
        public decimal Total { get; set; }
    }

    public class ProductModel
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string CompanyName { get; set; }
        public string Weight { get; set; }
        public string Details { get; set; }
    }

    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
    }

    public class Company
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
    }

    public class ProductNCmp
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string CompanyName { get; set; }
    }

    public class InvoiceModel
    {
        public int Id { get; set; }
        public List<SalesModel> Items { get; set; }
        public CustomerModel Customer { get; set; }
    }

    public class UserModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public string BusinessName { get; set; }
        public string BusinessAddress { get; set; }
        public string GST { get; set; }
        public string PAN { get; set; }

        public string Qid { get; set; }
        public string Answer { get; set; }
        public string Password { get; set; }
    }
    public class QuestionModel
    {
        public int Qid { get; set; }
        public string Question { get; set; }
    }
}