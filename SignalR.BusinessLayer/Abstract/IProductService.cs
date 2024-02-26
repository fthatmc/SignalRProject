﻿using SignalRApi.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();

		int TProductCount();
		int TProductCountByCategoryNameHamburger();
		int TProductCountByCategoryNameDrink();
		decimal TProductPriceAcg();
		string TProductNameByMaxPrice();
		string TProductNameByMinPrice();
		decimal TProductAvgPriceByHamburger();
        decimal TProductPriceBySteakBurger();
        decimal TTotalPriceByDrinkCategory();
        decimal TTotalPriceBySaladCategory();
    }
}
