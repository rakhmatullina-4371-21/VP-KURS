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

    public partial class positions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public positions()
        {
            this.employee = new HashSet<employee>();
        }

        public int id_position { get; set; }
        public string position { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<employee> employee { get; set; }



        static SmartRestaurantEntities db = new SmartRestaurantEntities();
        public static List<positions> ComboPos()   //вывод всех должностей
        {
            var selectPos = (from pos in db.positions
                             select pos).ToList();
            return selectPos;
        }
        public static dynamic SelectPos(object posit)   //поиск  по названию выбранной должности
        {
            var pos = db.positions.First(p => p.position == posit.ToString());
            return pos.id_position;
        }
    }
}
