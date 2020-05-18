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
    using System.Windows.Forms;

    public partial class content_orders
    {
        public Nullable<int> id_order { get; set; }
        public Nullable<int> id_dish { get; set; }
        public int count_dish { get; set; }

         SREntities db = new SREntities();

        public  void SaveCont( int? id_ord)   //сохранение 
        {
            var list = new List<content_orders>();
            foreach (int i in ListOrder.Keys) 
            {
                var  content = new content_orders();
                var id= db.orders.First(p => p.id_order == id_ord);
                content.id_order = id.id_order;
                var dish= db.list_of_dishes.First(p => p.id_dish == i);
                content.id_dish = dish.id_dish;
                var count =ListOrder.FirstOrDefault(p => p.Key == i);
                content.count_dish = count.Value;
                list.Add(content);
            }
            db.content_orders.AddRange(list);
            db.SaveChanges();

        }
        public static Dictionary<int?, int> ListOrder = new Dictionary<int?, int>();
        public static void ListContOrder(int? id,int count)
        {
            if (!ListOrder.ContainsKey(id))
            {
                ListOrder.Add(id, count);
            }
            else 
            {
                ListOrder.Remove(id);
                ListOrder.Add(id, count);
            }
        }

        public  Dictionary<string,int> SelectOrdCont()
        {
            
            Dictionary<string, int> sel = new Dictionary<string, int>();
            foreach (int? i in ListOrder.Keys) 
            {
                var dish = db.list_of_dishes.First(p => p.id_dish == i);
                var count = ListOrder.First(p => p.Key == i);
                sel.Add(dish.name_dish, count.Value);

            }
            return sel;
        }

        public virtual list_of_dishes list_of_dishes { get; set; }
        public virtual orders orders { get; set; }
    }
}
