
using Avtosolon.Data.Models;
using Avtosolon.Data.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avtosolon.Data.Moks
{
    public class CarsMoks : IInfoCar
    {
        readonly ICategories _MOKCAR= new CategoryMoks();
        public IEnumerable<InfoCar> Cars
        {
            get
            {
                return new List<InfoCar>
                {
                    new InfoCar
                    {
                        Name ="Tesla Model 3",
                        Price = 450000,
                        Image="/img/597f1fdbec05c42c01000024.jpg",
                        Favourite = true,
                        SortDesc ="",
                        LongDesc ="",
                        Avaible =true,
                        Categories =_MOKCAR.Icategory.First()
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
                        Categories =_MOKCAR.Icategory.First()
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
                        Categories =_MOKCAR.Icategory.Last()
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
                        Categories =_MOKCAR.Icategory.Last()
                    }
                };
            }
        }


        public IEnumerable<InfoCar> FavouriteCars { get; set ; }

       

        public InfoCar OneCar(int carid)
        {
            throw new NotImplementedException();
        }
    }
}
