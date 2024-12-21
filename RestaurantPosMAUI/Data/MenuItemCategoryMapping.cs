﻿
using SQLite;

namespace RestaurantPosMAUI.Data
{
    public class MenuItemCategoryMapping
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int MenuCategoryId { get; set; }
        public int MenuItemId { get; set; }

    }
}