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

    public partial class stocks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public stocks()
        {
            this.orders = new HashSet<orders>();
        }
    
        public int id_stock { get; set; }
        public System.TimeSpan start_time { get; set; }
        public System.TimeSpan end_time { get; set; }
        public decimal discount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orders> orders { get; set; }

        //--------------------------------------------------------------------------------------------------------------------------------------




        SmartRestaurantEntities db = new SmartRestaurantEntities();

        public List<stocks> SelectListStocks()   //вывод списка акций
        {
            var listStock = (from i in db.stocks
                             select i).ToList();
            return listStock;
        }
        public stocks EditStock(int id)    //возврат сотрудника, информацию о котором необходимо изменить
        {
            var stock = db.stocks.Single(w => w.id_stock == id);
            return stock;
        }
        public bool DeleteStock(int id)    //возврат акции, информацию о которой необходимо удалить
        {
            try
            {
                var emp = db.stocks.First(w => w.id_stock == id);
                db.stocks.Remove(emp);
                db.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        public int AddStock()    //возврат акции, информацию о которой необходимо добавить
        {
            int MaxId = db.stocks.Max(p => p.id_stock) + 1;
            return MaxId;
        }
        public int SaveStock(int id, string start, string end, int discount)   //сохранение изменений
        {
            TimeSpan newStart = TimeSpan.Parse(start);
            TimeSpan newEnd = TimeSpan.Parse(end);
            if (newStart.Hours <= 24 && newStart.Minutes <= 59 && newStart.Hours <= 24 && newStart.Minutes <= 59 /*&& newEnd.Hours - newStart.Hours > 0*/ && discount != 0)
            {
                var stock = db.stocks.FirstOrDefault(w => w.id_stock == id);
                if (stock == null)
                {
                    stock = new stocks();
                    stock.id_stock = id;
                }
                stock.start_time = newStart;
                stock.end_time = newEnd;
                stock.discount = discount;
                db.stocks.AddOrUpdate(stock);
                db.SaveChanges();

                return 4;
            }
            if (newStart.Hours >= 24 && newStart.Minutes >= 59)
            {
                return 0;
            }
            if (newStart.Hours >= 24 && newStart.Minutes >= 59)
            {
                return 1;
            }
            //if (newEnd.Hours - newStart.Hours <= 0)
            //{
            //    return 2;
            //}
            if (discount < 1)
            {
                return 3;
            }
            else return 4;
        }
        public static List<string> ComboBoxItem()
        {
            List<string> items = new List<string>();
            items.Add("ПО ВОЗРАСТАНИЮ СКИДКИ");
            items.Add("ПО УБЫВАНИЮ СКИДКИ");
            items.Add("ПО ВОЗРАСТАНИЮ ВРЕМЕНИ НАЧАЛА АКЦИИ");
            items.Add("ПО УБЫВАНИЮ ВРЕМЕНИ НАЧАЛА АКЦИИ");
            return items;

        }
        public List<stocks> OrderByStock(int item)
        {
            var stockList = new List<stocks>();
            switch (item)
            {
                case 0:
                    {
                        stockList = db.stocks.OrderBy(p => p.discount).ToList();

                    }
                    break;
                case 1:
                    {
                        stockList = db.stocks.OrderByDescending(p => p.discount).ToList();

                    }
                    break;
                case 2:
                    {
                        stockList = db.stocks.OrderBy(p => p.start_time).ToList();

                    }
                    break;
                case 3:
                    {
                        stockList = db.stocks.OrderByDescending(p => p.start_time).ToList();

                    }
                    break;

            }
            return stockList;
        }

    }
}
