using Application.Features.Brands.Dtos;
using Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Models
{
    //class isminin model olmasının sebebi db den aldığımız bilgileri dto olarak dönmenin yanı sıra sayfalama bilgisi de döndüğümüz içindir
    public class BrandListModel:BasePageableModel
    {
        public IList<BrandListDto> Items { get; set; }
    }
}
