using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A.Assignment
{
    public abstract class Phone
    {
        public abstract void insertPhone(String name, String phone);
        public abstract void removePhone(String name);
        public abstract void updatePhone(String name, String newPhone);
        public abstract void searchPhone(String name);
        public abstract void sort();
    }
}
