//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMART_REST
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public partial class orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public orders()
        {
            this.content_orders = new HashSet<content_orders>();
        }
    
        public int id_order { get; set; }
        public Nullable<int> id_employee { get; set; }
        public Nullable<int> id_table { get; set; }
        public System.TimeSpan time_order { get; set; }
        public Nullable<int> id_stock { get; set; }
        public decimal full_price { get; set; }
        public Nullable<bool> given_out { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<content_orders> content_orders { get; set; }
        public virtual employee employee { get; set; }
        public virtual list_of_table list_of_table { get; set; }
        public virtual stocks stocks { get; set; }




        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        SmartRestaurantEntities db = new SmartRestaurantEntities();
        public int SaveOrd(int id_emp, int id_tab)
        {
            orders ord = new orders();
            ord.id_employee = db.employee.First(p => p.id_employee == id_emp).id_employee;
            ord.id_table = id_tab;
            ord.time_order = DateTime.Now.TimeOfDay;
            var stock = new List<stocks>();
            if (db.stocks.Where(p => p.start_time < p.end_time) != null) { stock = db.stocks.Where(p => p.start_time <= ord.time_order && p.end_time >= ord.time_order).ToList(); }
            if (db.stocks.Where(p => p.start_time > p.end_time) != null)
            {
                stock.AddRange(db.stocks.Where(p => (p.start_time > p.end_time) && ((p.start_time >= ord.time_order) || (p.end_time >= ord.time_order))).ToList());
            }


            if (stock.Count != 0)
            {
                var discount = stock.Min(p => p.discount);
                ord.id_stock = db.stocks.First(p => p.discount == discount).id_stock;
            }
            else { ord.id_stock = null; }
            db.orders.Add(ord);
            db.SaveChanges();
            foreach (content_orders i in ListDishesinOrd)
            {
                var content = new content_orders();
                content.id_content_order = i.id_content_order;
                content.id_order = ord.id_order;
                content.id_dish = db.list_of_dishes.First(p => p.id_dish == i.id_dish).id_dish;
                content.count_dish = i.count_dish;
                db.content_orders.Add(content);
                db.SaveChanges();

            }
            return ord.id_order;
        }
        public static List<content_orders> ListDishesinOrd = new List<content_orders>();
        decimal FullPrice(decimal discount)
        {

            var listDishOrder = infOrd.Select(p => p.count_dish * p.price).ToList();
            decimal sum = 0;
            foreach (decimal i in listDishOrder)
            {
                sum += i;
            }
            if (discount != 0)
            {
                sum *= (1 - (discount / 100));
            }
            return sum;
        }
        List<dynamic> infOrd = new List<dynamic>();
        public List<dynamic> SelectOrder(int id_order)
        {
            List<content_orders> ord = (db.content_orders.Where(p => p.id_order == id_order)).ToList();
            infOrd = (from i in ord
                      join d in db.list_of_dishes on i.id_dish equals d.id_dish
                      select new {i.id_content_order, i.id_order, d.id_dish, d.name_dish, i.count_dish, d.price }).ToList<dynamic>();

            return infOrd;
        }
        public List<int> SelectOrder(employee emp)
        {
            var ordList = db.orders.Where(p => p.id_employee == emp.id_employee && p.given_out != true).Select(p => p.id_order).ToList();
            return ordList;
        }
        public string SelectInformOrd(int? id)
        {
            decimal disc = 0;
            string time = db.orders.First(p => p.id_order == id).time_order.ToString("hh':'mm");
            var st = db.orders.First(p => p.id_order == id).id_stock;
            if (db.stocks.FirstOrDefault(p => p.id_stock == st) != null)
            {
                disc = db.stocks.FirstOrDefault(p => p.id_stock == st).discount;
            }
            var sum = FullPrice(disc);
            
            return $"В Р Е М Я   З А К А З А :                     {time}\r\nС К И Д К А :                                     {disc} % \r\nЦ Е Н А   С О   С К И Д К О Й :          {Math.Round(sum, 2, MidpointRounding.AwayFromZero)} р.";
        }
        public bool DeleteOrd(int id)    //возврат заказа, информацию о котором необходимо убрать из списка заказов
        {
            try
            {
                orders ord = db.orders.First(p => p.id_order == id);
                ord.full_price = FullPrice(ord.id_order);
                ord.given_out = true;
                db.orders.AddOrUpdate(ord);
                db.SaveChanges();
                return true;
            }
            catch { return false; }
        }

    }
}
