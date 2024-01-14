using App.Share.Consts;
using App.Shared.Attributes;
using System.ComponentModel.DataAnnotations;

namespace App.Web.ViewModels.Category
{
    public class CategoryAddEditVM : ListItemBaseVM
    {
        public int Id { get; set; }
        [AppRequired]  
        public string Name { get; set; }
        [Required]
        [AppMaxLength(DB.AppCategory.DESCRIPTION_LENGTH)]
        public string Description { get; set; }
    }
}
