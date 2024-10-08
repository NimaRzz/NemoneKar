using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Domain.Model.Commons;
using MainProject.Domain.Model.Cues;
using MainProject.Domain.Model.Customers;
using User = MainProject.Domain.Model.Users.User;

namespace MainProject.Domain.Model.Users
{
    public class User : BaseModel

    {
    public string UserName { get; set; }
  
    public string Email { get; set; }
   
    public string Password { get; set; }
   
    public bool IsActive { get; set; }
    
    public bool IsCustomer { get; set; }
    
    public bool IsAdmin { get; set; }
    
    public bool Remember { get; set; } = false;

  

        public virtual Customer Customer { get; set; }

        public virtual long CustomerId { get; set; }
        
       
   public virtual ICollection<Cue> Cues { get; set; }
   
    public virtual ICollection<UserInRole> UserInRoles { get; set; }
    

    }
}
