using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner2Web.Models
{
    public class BaseEntity : IEntity
    {
        public virtual int Id { get; set; }
        public string ApplicationUserId { get; set; }
        [Display(Name = "Created at")]
        public DateTime? CreatedAt { get; set; }
        [Display(Name = "Updated at")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public DateTime? UpdatedAt { get; set; }

        public void Update(IEntity entity)
        {
            foreach(var prop in entity.GetType().GetProperties())
            {
                var value = prop.GetValue(entity);
                if (value != null)
                    GetType().GetProperty(prop.Name).SetValue(this, prop.GetValue(entity));
            }
        }
    }
}
