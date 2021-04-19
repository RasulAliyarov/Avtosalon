using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Avtosolon.Data.Models
{
    public class Zakaz
    {
        [BindNever]
        public int Id { get; set; }
        [Display(Name = "Имя")]
        [StringLength(15)]
        [Required(ErrorMessage ="Длина имени не менее 15")]
        public string Name { get; set; }
        [Display(Name = "Фамилия")]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина имени не менее 15")]
        public string Surname { get; set; }
        [Display(Name = "Адресс")]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина Адрессф не менее 20")]
        public string Address { get; set; }
        [Display(Name = "Моб.телефон")]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина Моб.телефон не менее 15")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public DateTime Date { get; set; }
        public List<ElementiZakaza> SpisokElementov { get; set; }
    }
}
