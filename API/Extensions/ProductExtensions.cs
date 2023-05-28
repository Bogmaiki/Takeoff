using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Extensions
{
    public static class ProductExtensions
    {
        public static IQueryable<Product> Sort(this IQueryable<Product> query, string orderBy)
        {
            if (string.IsNullOrWhiteSpace(orderBy)) return query.OrderBy(p => p.Name);

            query = orderBy switch
            {
                "price" => query.OrderBy(p => p.Price),
                "priceDesc" => query.OrderByDescending(p => p.Price),
                _ => query.OrderBy(p => p.Name)
            };

            return query;
        }

        public static IQueryable<Product> Search(this IQueryable<Product> query, string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm)) return query;

            var lowerCaseSearchTerm = searchTerm.Trim().ToLower();

            return query.Where(p => p.Name.ToLower().Contains(lowerCaseSearchTerm));
        }

        public static IQueryable<Product> Filter(this IQueryable<Product> query, string collection, string sizes)
        {
            var collectionList = new List<string>();
            var sizeList = new List<string>();

            if (!string.IsNullOrEmpty(collection))
                collectionList.AddRange(collection.ToLower().Split(",").ToList());

            if (!string.IsNullOrEmpty(sizes))
            {
                var sizeStrings = sizes.ToLower().Split(",").ToList();
                foreach (var sizeString in sizeStrings)
                {
                    if (float.TryParse(sizeString, out float size))
                        sizeList.Add(size.ToString());
                }
            }

            query = query.Where(p => !collectionList.Any() || collectionList.Contains(p.Collection.ToLower()));
            query = query.Where(p => !sizeList.Any() || p.Sizes.Any(s => sizeList.Contains(s.Value)));

            return query;
        }
    }
}
