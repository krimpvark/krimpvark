// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using TDD_Katas_project.Common.Utility;

namespace TDD_Katas_project.TheNaturalStringSortingKata
{
    /// <summary>
    ///  Natural String Sorting
    /// </summary>
    public class NaturalStringSorting
    {
        /// <summary>
        /// 
        /// </summary>
        public enum SortOrder
        {
            /// <summary>
            /// The ascending
            /// </summary>
            Ascending,
            /// <summary>
            /// The descending
            /// </summary>
            Descending
        }

        /// <summary>
        /// Sorts the string.
        /// </summary>
        /// <param name="strItems">The string items.</param>
        /// <returns></returns>
        public List<string> SortString(string[] strItems) => SortString(strItems, SortOrder.Ascending);
        /// <summary>
        /// Sorts the string.
        /// </summary>
        /// <param name="strItems">The string items.</param>
        /// <param name="order">The order.</param>
        /// <returns></returns>
        public List<string> SortString(string[] strItems, SortOrder order)
        {
            Func<string, object> Convert = str =>
                {
                    try
                    {
                        return int.Parse(str);
                    }
                    catch
                    {
                        return str;
                    }
                };

            return GetSortedList(strItems, order, Convert);

        }

        private static List<string> GetSortedList(IEnumerable<string> strItems, SortOrder order, Func<string, object> convert)
        {
            List<string> sorted;
            switch (order)
            {
                case SortOrder.Descending:
                    sorted = strItems.OrderByDescending(
                        str => Regex.Split(str.Replace(" ", ""), "([0-9]+)").Select(convert),
                        new EnumerableComparer<object>()).ToList();
                    break;
                default:
                    sorted = strItems.OrderBy(
                        str => Regex.Split(str.Replace(" ", ""), "([0-9]+)").Select(convert),
                        new EnumerableComparer<object>()).ToList();
                    break;
            }
            return sorted;
        }
    }
}