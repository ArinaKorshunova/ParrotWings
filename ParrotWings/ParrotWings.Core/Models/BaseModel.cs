using System;

namespace ParrotWings.Core.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime CreaionDate { get; set; }
        public DateTime ChangingDate { get; set; }
        public bool IsActive { get; set; }
    }
}
