using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Regions
    {
        public string[] RegionName { get; set; }

        public Regions() {
                               
            ZipGroups zipgroups = new ZipGroups();
            RegionName = new[] { zipgroups.zipCodesGroup1, zipgroups.zipCodesGroup2 };
           

        }
        T[] InitializeArray<T>(int length) where T : new()
        {
            T[] array = new T[length];
            for (int i = 0; i < length; ++i)
            {
                array[i] = new T();
            }

            return array;
        }
    }
}
