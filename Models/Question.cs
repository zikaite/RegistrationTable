using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.Models
{
    public class Question : Entity
    {
        public int? AnswerId { get; set; }

        public List<Answer> Answers { get; set; }

        public int CreateQuestionId { get; set; }   

    }

    
}
