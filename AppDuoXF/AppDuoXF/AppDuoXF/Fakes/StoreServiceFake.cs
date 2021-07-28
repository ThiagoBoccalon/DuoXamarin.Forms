using AppDuoXF.Enums;
using AppDuoXF.Interfaces;
using AppDuoXF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDuoXF.Fakes
{
    public class StoreServiceFake : IStoreService
    {
        public async Task<IList<StoreItemGroup>> GetItems()
        {
            return await Task.Run(() =>
            {
                var storeItems = GetStoreItems();
                return GroupStoreItems(storeItems);
            });
        }

        private List<StoreItem> GetStoreItems()
        {
            return new List<StoreItem>
            {
                GetStoreItem(
                    "store_item_1",
                    "Double or Nothing",
                    "Double your bet of 50 crystals while maintaining 7 days of offensive.",
                    50,
                    StoreItemType.Sell,
                    "Superpowers"
                ),
                GetStoreItem(
                    "store_item_2",
                    "Offensive blocking",
                    "Blocking offensives makes the number of offensives not drop even if you are inactive for a day.",
                    200,
                    StoreItemType.Sell,
                    "Super powers"
                ),
                GetStoreItem(
                    "store_item_3",
                    "Unlimited lives",
                    "Never run out of lives with Duolingo Plus!",
                    null,
                    StoreItemType.Ads,
                    "Super powers"
                ),
                GetStoreItem(
                    "store_item_4",
                    "Refill of lives",
                    "Get your lives back so you worry less about making mistakes in a lesson.",
                    null,
                    StoreItemType.Normal,
                    "Super powers"
                ),
                GetStoreItem(
                    "store_item_5",
                    "Formal attire",
                    "Learning in style. Duo has always been an impeccable face. Now he will walk flawless too.",
                    400,
                    StoreItemType.Sell,
                    "Trajes"
                ),
                GetStoreItem(
                    "store_item_6",
                    "Golden sports attire",
                    "Learning in luxury. Duo will love feeling the 24-karat gold in his feathers.",
                    600,
                    StoreItemType.Sell,
                    "Costumes"
                ),
                GetStoreItem(
                    "store_item_7",
                    "Super Duo",
                    "Transform the humble owl Duo is into a mighty crime-fighting hero.",
                    1000,
                    StoreItemType.Sell,
                    "Costumes"
                ),
                GetStoreItem(
                    "store_item_8",
                    "Expressions and Sayings",
                    "Learn idioms in English.",
                    1000,
                    StoreItemType.Sell,
                    "Bonus Units"
                ),
                GetStoreItem(
                    "store_item_9",
                    "Loving",
                    "Do you believe in love at first sight? Learn some lines in English.",
                    1000,
                    StoreItemType.Sell,
                    "Bonus Units"
                )
            };
        }

        private static StoreItem GetStoreItem(
            string icon,
            string name,
            string description,
            int? price,
            StoreItemType type,
            string groupName)
        {
            return new StoreItem
            {
                Icon = icon,
                Name = name,
                Description = description,
                Price = price,
                Type = type,
                GroupName = groupName
            };
        }

        private List<StoreItemGroup> GroupStoreItems(List<StoreItem> storeItems)
        {
            return storeItems
                    .GroupBy(item => item.GroupName)
                    .Select(group => new StoreItemGroup(group.Key, group.ToList()))
                    .ToList();
        }
    }
}
