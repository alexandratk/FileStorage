using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileStorageBLL
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            //CreateMap<Receipt, ReceiptModel>()
            //    .ForMember(rm => rm.ReceiptDetailsIds, r => r.MapFrom(x => x.ReceiptDetails.Select(rd => rd.Id)))
            //    .ReverseMap();
            //CreateMap<Product, ProductModel>().ForMember(c => c.Id, cm => cm.MapFrom(x => x.Id))
            //    .ForMember(c => c.ProductCategoryId, cm => cm.MapFrom(x => x.ProductCategoryId))
            //    .ForMember(c => c.CategoryName, cm => cm.MapFrom(x => x.Category.CategoryName))
            //    .ForMember(c => c.ProductName, cm => cm.MapFrom(x => x.ProductName))
            //    .ForMember(c => c.Price, cm => cm.MapFrom(x => x.Price))
            //    .ForMember(c => c.ReceiptDetailIds, cm => cm.MapFrom(x => x.ReceiptDetails.Select(r => r.Id)))
            //    .ReverseMap();
            //CreateMap<ReceiptDetail, ReceiptDetailModel>().ReverseMap();
            //CreateMap<Customer, CustomerModel>().ForMember(c => c.Id, cm => cm.MapFrom(x => x.Id))
            //    .ForMember(c => c.Name, cm => cm.MapFrom(x => x.Person.Name))
            //    .ForMember(c => c.Surname, cm => cm.MapFrom(x => x.Person.Surname))
            //    .ForMember(c => c.BirthDate, cm => cm.MapFrom(x => x.Person.BirthDate))
            //    .ForMember(c => c.DiscountValue, cm => cm.MapFrom(x => x.DiscountValue))
            //    .ForMember(c => c.ReceiptsIds, cm => cm.MapFrom(x => x.Receipts.Select(r => r.Id)))
            //    .ReverseMap();
            //CreateMap<ProductCategory, ProductCategoryModel>().ForMember(c => c.Id, cm => cm.MapFrom(x => x.Id))
            //    .ForMember(c => c.CategoryName, cm => cm.MapFrom(x => x.CategoryName))
            //    .ForMember(c => c.ProductIds, cm => cm.MapFrom(x => x.Products.Select(r => r.Id)))
            //    .ReverseMap();
        }
    }
}
