using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesInLINQ.Extensions
{
    public static class EnumerablePredicateExtenstion
    {
        public static IEnumerable<T> PredicatesAnd<T>(this IEnumerable<T> enumerable, params Predicate<T>[] predicates)
        {
            return enumerable.Where(x => predicates.All(p => p(x)));
        }

        public static IEnumerable<T> PredicatesOr<T>(this IEnumerable<T> enumerable, params Predicate<T>[] predicates)
        {
            return enumerable.Where(x => predicates.Any(p => p(x)));
        }
    }
}