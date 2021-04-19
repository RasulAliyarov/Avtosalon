using Avtosolon.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avtosolon.Data
{
    public class Objects
    {
        public static void Initial(DBContent content)
        {
            if (!content.dbCategories.Any())
                content.dbCategories.AddRange(Categori.Select(c => c.Value));


            if (!content.dbInfoCar.Any())
            {
                content.AddRange
                 (   
                    
                
                    new InfoCar
                    {
                        Name ="Tesla Model 3",
                        Price = 450000,
                        Image="/img/597f1fdbec05c42c01000024.jpg",
                        Favourite = true,
                        SortDesc ="",
                        LongDesc ="",
                        Avaible =true,
                        Categories = Categori["Электромашины"]
                    },

                    new InfoCar
                    {
                        Name ="Tesla Model X",
                        Price = 500000,
                        Favourite = true,
                        Image="/img/tesla1.jpg",
                        SortDesc ="",
                        LongDesc ="",
                        Avaible =true,
                        Categories =Categori["Электромашины"]
                    },

                    new InfoCar
                    {
                        Name ="Cadilac",
                        Price = 300000,
                        Favourite = true,
                        Image="/img/Cadillac-Escalade-08.jpg",
                        SortDesc ="",
                        LongDesc ="",
                        Avaible =true,
                        Categories =Categori["Классические машины"]
                    },

                    new InfoCar
                    {
                        Name ="Mercedez S-Class",
                        Price = 450000,
                        Favourite = true,
                        Image="/img/imagemq6020201204134849.jpg",
                        SortDesc ="",
                        LongDesc ="",
                        Avaible =true,
                        Categories =Categori["Классические машины"]
                    }
              );     
            }
                content.SaveChanges();
        }
        private static Dictionary<string, Categories> category;
        public static Dictionary<string,Categories> Categori
        {
            get
            {
                var list = new Categories[]
                {
                    new Categories{CategoryName="Электромашины", CatDesc=""},
                    new Categories{CategoryName="Гибридные машины", CatDesc=""},
                    new Categories{CategoryName="Классические машины", CatDesc=""}
                };

                category = new Dictionary<string, Categories>();
                foreach(Categories el in list)
                {
                    category.Add(el.CategoryName, el);
                }

                return category;
            }


        }
        

    }
}
