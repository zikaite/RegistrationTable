using RegistrationForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.DTOs
{
    public class CreateQuestion :Entity
    {  
        public List<Question> Questions { get; set; }
        
    }
}
