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
    using System.Linq;

    public partial class list_of_table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public list_of_table()
        {
            this.orders = new HashSet<orders>();
        }
    
        public int id_table { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orders> orders { get; set; }

        //---------------------------------------------------------------------------------------------------------------------------------------





        static SmartRestaurantEntities db = new SmartRestaurantEntities();

        public static List<int> ComboTab(employee emp)   //вывод всеx столов, которые не обслуживаются другими официантами
        {
            var table = db.orders.Where(p => p.id_employee != emp.id_employee).Select(p => (int)p.id_table).ToList();
            var selectTab = db.list_of_table.Select(p => p.id_table).ToList();
            var result = new List<int>();
            foreach (int i in selectTab) 
            {
                if (!table.Contains(i)) { result.Add(i); }
            }
            return result;
        }

    }
}
