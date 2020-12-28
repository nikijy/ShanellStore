using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShanellStore.DataLayer.Entities.Product
{
    public class Category
    {
        public Category()
        {

        }
        [Key]
        public int CategoryId { get; set; }
        [Display(Name = "عنوان دسته بندی")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string Title { get; set; }
        [Display(Name = "حذف شده؟")]
        public bool? IsDeleted { get; set; }

        #region relations

        public virtual List<Product> Products { get; set; }

        #endregion
    }
}
