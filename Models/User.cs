using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exosky.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } // معرف المستخدم
        public string UserName { get; set; } // اسم المستخدم
        public string Email { get; set; } // البريد الإلكتروني
       
        public string Password { get; set; }
        public DateTime BarthDay { get; set; }
        public List<SkyMap> SavedSkyMaps { get; set; } // الخرائط المحفوظة من قبل المستخدم
    }

}
