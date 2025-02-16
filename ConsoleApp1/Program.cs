using Day_01_G03;
using System.Threading;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listProduct = ListGenerator.ProductsList;
            var listCustomer = ListGenerator.CustomersList;
            #region 1
            var outOfStock = listProduct.Where(p => p.UnitsInStock == 0);
            var inStock = listProduct.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var filterNumbers = numbers.Where((n, i) => n.Length < i).Select(n => n);
            foreach (var number in filterNumbers) { Console.WriteLine(number); }
            #endregion
            #region 2
            var firstProductOut = listProduct.First(p => p.UnitsInStock == 0);
            var firstProductPrice = listProduct.FirstOrDefault(p => p.UnitPrice > 1000);
            int[] Arr1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var secondNumber = Arr1.Where(n => n > 5).Skip(1).FirstOrDefault(n => n > 5);
            Console.WriteLine(secondNumber);
            #endregion
            #region 3
            int[] Arr3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var countNumbers = Arr3.Where(n => n % 2 != 0).Count();
            Console.WriteLine(countNumbers);
            var customersOrders = listCustomer.Select(c => new
            {
                c.CustomerID,
                c.CustomerName,
                c.Address,
                c.Orders.Length
            });
            var categories = listProduct.GroupBy(p => p.Category)
                .Select(p => new
                {
                    Category = p.Key,
                    CategoryCount = p.Count()
                });
            int[] arr3 ={ 5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            var arr3Count = arr3.Sum();
            string[] strings = File.ReadAllLines("dictionary_english.txt");
            var sumOfChars = strings.Sum(s => s.Length);
            var lengthOfShortestWord = strings.Min(s => s.Length);
            var lengthOfBiggestWord = strings.Max(s => s.Length);
            var averageOfLengthsOfWords = strings.Average(s => s.Length);
            #endregion
            #region 4
            var sortProductByName = listProduct.OrderBy(p => p.ProductName);
            String[] Arr4 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortArr4 = Arr4.OrderBy(s => s, StringComparer.OrdinalIgnoreCase);
            var orderProduct = listProduct.OrderByDescending(p => p.UnitsInStock);
            string[] Arr5 = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            var arr5Sort = Arr5.OrderBy(s => s.Length).ThenBy(s => s);
            String[] Arr6 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var arr6Sort = Arr6.OrderBy(s => s.Length).ThenBy(s => s,StringComparer.OrdinalIgnoreCase);
            var sortProductsByCategory = listProduct.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            String[] Arr7 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortArr7 = Arr7.OrderBy(s => s.Length).ThenByDescending(s => s, StringComparer.OrdinalIgnoreCase);
            var arr5Sort2 = Arr5.Where(s => s[1] == 'i').Select(s => s);           
            #endregion
            #region 5
            var nameOfProduct = listProduct.Select(s => s.ProductName);
            String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var wordsUpper = words.Select(s => new
            {
                name = s.ToUpper()
            });
            var wordsLower = words.Select(s => new
            {
                name = s.ToLower()
            });
            var productPrice = listProduct.Select(s => new
            {
                Price = s.UnitPrice
            });
            int[] Arr8 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var filterArr8 = Arr8.Select((n, i) => n == i);
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var agg = numbersA.Zip(numbersB);
            Console.WriteLine("Pairs where a<b");
            foreach (var (a, b) in agg)
            {               
                if (a < b)
                {
                    Console.WriteLine($"{a} is less than {b}");
                }
            }
            var orders1 = listCustomer.SelectMany(p => p.Orders).Where(o => o.Total < 500);
            var orders2 = listCustomer.SelectMany(p => p.Orders).Where(o => o.OrderDate.Year < 1998);
            foreach(var i in orders2) Console.WriteLine(i);
            #endregion
        }
    }
}
