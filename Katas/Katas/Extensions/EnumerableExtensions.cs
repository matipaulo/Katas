﻿using System.Collections.Generic;
using System.Linq;

namespace Katas.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> OrEmptyIfNull<T>(this IEnumerable<T> source) =>
            source ?? Enumerable.Empty<T>();
    }
}
