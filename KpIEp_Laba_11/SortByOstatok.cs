using System.Collections;

namespace KpIEp_Laba_11
{
    class SortByOstatok : IComparer
    {
        public int Compare(object x, object y)
        {
            int num1 = (int)x;
            int num2 = (int)y;

            if (num1 % 3 == 0 && num2 % 3 != 0)
            {
                return -1;
            }
            if (num1 % 3 != 0 && num2 % 3 == 0)
            {
                return 1;
            }
            if (num1 % 3 == 0 && num2 % 3 == 0 && num1 > num2)
            {
                return 1;
            }
            if (num1 % 3 == 0 && num2 % 3 == 0 && num1 < num2)
            {
                return -1;
            }
            if (num1 % 3 != 0 && num2 % 3 != 0 && num1>num2)
            {
                return 1;
            }
            if (num1 % 3 != 0 && num2 % 3 != 0 && num1 < num2)
            {
                return -1;
            }
            return 0;
            
        }
    }
}
