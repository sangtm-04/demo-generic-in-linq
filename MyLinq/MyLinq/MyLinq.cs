using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinq
{
    public static class MyLinq
    {
        // Extension method
        public static IEnumerable<TSource> MyWhere<TSource> (this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            // Loop toàn bộ item trong danh sách truyền vào
            foreach (var item in source)
            {
                // Callback lại hàm đã truyền vào, hàm này trả ra giá trị boolean
                // Nếu hàm callback return true, đưa item vào IENumerable kết quả
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}
