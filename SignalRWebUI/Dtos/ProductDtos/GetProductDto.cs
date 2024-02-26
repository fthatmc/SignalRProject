﻿namespace SignalRWebUI.Dtos.ProductDtos
{
    public class GetProductDto
    {
        public int ProductID { get; set; }
        public int ProductName { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public bool ProductStatus { get; set; }
        public int CategoryID { get; set; }
    }
}
