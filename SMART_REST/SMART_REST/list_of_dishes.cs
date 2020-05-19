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

    public partial class list_of_dishes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public list_of_dishes()
        {
            this.content_orders = new HashSet<content_orders>();
        }

        public int id_dish { get; set; }
        public string name_dish { get; set; }
        public Nullable<int> id_selection { get; set; }
        public bool availability { get; set; }
        public decimal price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<content_orders> content_orders { get; set; }
        public virtual menu menu { get; set; }





        SmartRestaurantEntities db = new SmartRestaurantEntities();

        List<dynamic> listDish;   //список блюд и разделов, в которых они находятся
        public dynamic SelectListDish()   //вывод списка блюд
        {
            listDish = (from d in db.list_of_dishes
                        join m in db.menu on d.id_selection equals m.id_selection
                        select new { d.id_dish, d.name_dish, d.id_selection, m.name_selection, d.availability, d.price }).ToList<dynamic>();
            return listDish;
        }
        public dynamic SelectListDish(int id_selection)   //вывод списка блюд из раздела
        {
            var avaList = (from p in db.list_of_dishes
                           join m in db.menu on p.id_selection equals m.id_selection
                           where p.availability == true && m.id_selection==id_selection
                           select new { p.id_dish, p.name_dish, m.id_selection, m.name_selection, p.price }).ToList<dynamic>();
            return avaList;
        }
        public dynamic EditDish(int id)    //возврат блюда, информацию о котором необходимо изменить
        {
            var dish = listDish.First(w => w.id_dish == id);
            return dish;
        }
        public static string SearchDish(int id)  
        {

            var dish = dbs.list_of_dishes.FirstOrDefault(w => w.id_dish == id).name_dish;
            return dish;
        }
        public int AddDish()    //возврат блюда, информацию о котором необходимо изменить
        {
            int MaxId = listDish.Max(p => p.id_dish) + 1;
            return MaxId;
        }
        public static list_of_dishes DynamicDish(dynamic dish)   //перевод из динамического типа в тип list_of_dish
        {
            list_of_dishes Newdish = new list_of_dishes();
            Newdish.id_dish = dish.id_dish;
            Newdish.name_dish = dish.name_dish;
            Newdish.id_selection = dish.id_selection;
            Newdish.availability = dish.availability;
            Newdish.price = dish.price;
            return Newdish;
        }
        public bool SaveDish(int id_dish, string name_dish, int? id_selection, bool availability, string price1, string price2)   //сохранение изменений
        {
            decimal rub = decimal.Parse(price1);
            decimal kop =decimal.Parse(price2) * decimal.Parse((0.01).ToString());
            var dish = db.list_of_dishes.FirstOrDefault(w => w.id_dish == id_dish);
            if ((name_dish != "") && (price != 0) && (id_selection != null))
            {
                if (dish == null)
                {
                    dish = new list_of_dishes();
                    dish.id_dish = id_dish;
                }
                dish.name_dish = name_dish;
                dish.id_selection = id_selection;
                dish.availability = availability;
                dish.price = rub+kop;
                db.list_of_dishes.AddOrUpdate(dish);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteDish(int id)    //возврат блюда, информацию о котором необходимо удалить
        {
            try
            {
                var dish = db.list_of_dishes.First(w => w.id_dish == id);
                db.list_of_dishes.Remove(dish);
                db.SaveChanges();
                return true;
            }
            catch { return false; }
        }
         static SmartRestaurantEntities dbs = new SmartRestaurantEntities();
        public  static List<dynamic> SelectListDishAva()
        {
            
            var avaList =(from p in dbs.list_of_dishes
                           join m in dbs.menu on p.id_selection equals m.id_selection
                           where p.availability == true
                           select new { p.id_dish, p.name_dish, m.id_selection, m.name_selection, p.price }).ToList<dynamic>();
            return avaList;
        }
        public static List<string> ComboBoxItem()
        {
            List<string> items = new List<string>();
            items.Add("ПО НАЗВАНИЮ");
            items.Add("ПО РАЗДЕЛУ");
            return items;

        }
        public List<dynamic> searchDish(int item, string searchString)
        {
            var dishList = new List<dynamic>();
            switch (item)
            {
                case 0:
                    {
                        dishList = db.list_of_dishes.Where(p => p.name_dish == searchString)
                             .Join(db.menu, p => p.id_selection, e => e.id_selection, (p, e) => new { p.id_dish, p.name_dish,e.name_selection,p.availability,p.price})
                             .ToList<dynamic>();

                    }
                    break;
                case 1:
                    {
                        dishList = db.menu.Where(p => p.name_selection == searchString)
                            .Join(db.list_of_dishes, e => e.id_selection, p => p.id_selection, (p, e) => new {e.id_dish, e.name_dish,p.name_selection, e.availability, e.price })
                            .ToList<dynamic>();
                    }
                    break;

            }
            return dishList;
        }

    }
}
