namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var x = 10;
            var y = 20;

            var a = 10;
            var b = 20;

            var intAdd = Add(x, y);
            var decimalAdd= Add(a, b);
            var addwithBool = Add(0, 1, true);
            Console.WriteLine($" Int Add: {x} + {y} = {intAdd}/nDecimal Add: {a} + {b} = {decimalAdd}/n Bool Add: {addwithBool}");

           
        }
        public static int Add(int num1, int num2)
        {
            return  num1 + num2 ;
        }
        public static decimal Add( decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isChecked)
        {
            var addedNums = num1 + num2;
            if (isChecked && addedNums > 1)
            {
                return $"{addedNums}";
            }
            else if (isChecked && addedNums == 1)
            {
                return $"{addedNums} dollar";
            }

            else
            {
                return addedNums.ToString();
            }
            }

        


         

    }
}
