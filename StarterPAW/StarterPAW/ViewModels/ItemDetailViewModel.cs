﻿using System;

using StarterPAW.Models;

namespace StarterPAW.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Time;
            Item = item;
        }
    }
}
