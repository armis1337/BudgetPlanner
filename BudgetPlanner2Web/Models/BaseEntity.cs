using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BudgetPlanner2Web.Models
{
    public class BaseEntity : IEntity
    {
        public virtual int Id { get; set; }
        [JsonIgnore]
        public string ApplicationUserId { get; set; }
        [Display(Name = "Created at")]
        public DateTime? CreatedAt { get; set; }
        [Display(Name = "Updated at")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public DateTime? UpdatedAt { get; set; }

        public void Update(object obj) // turetu veikt jei tipai ir pavadinimai sutampa
        {
            foreach(var prop in obj.GetType().GetProperties())
            {
                if (prop.Name == "CreatedAt" || prop.Name == "UpdatedAt" ||
                    prop.Name == "ApplicationUserId" || prop.Name == "Id")
                    continue;

                var value = prop.GetValue(obj);
                if (value != null)
                    GetType().GetProperty(prop.Name).SetValue(this, prop.GetValue(obj));
            }
        }

        // creates object from DTO models
        public static T CreateFrom<T>(object obj) where T : IEntity
        {
            var entity = Activator.CreateInstance<T>();
            foreach (var prop in obj.GetType().GetProperties())
            {
                var value = prop.GetValue(obj);
                if (value != null)
                {
                    var property = entity.GetType().GetProperty(prop.Name);
                    if (property != null)
                        property.SetValue(entity, prop.GetValue(obj));
                }
                   
            }

            return entity;
        }
    }
}
