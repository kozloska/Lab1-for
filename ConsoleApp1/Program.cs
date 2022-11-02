namespace FirstApp
{
    public class Logic
    {
        public static string Dupl(int[] nums, int size)
        {
            string outmassage = "";
            for (int i = 1; i < size; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    outmassage += "Индексы пары: ";
                    outmassage += Convert.ToString(i - 1);
                    outmassage = outmassage + " " + "и" + " ";
                    outmassage += Convert.ToString(i);
                    break;
                }
            }
            return outmassage;
        }
        public static string Mas(int[] nums, int size)
        {
            string outmassage = Logic.Dupl(nums, size);
            if (outmassage.Length == 0)
            {
                outmassage = "Нет такой пары чисел в последовательности";
            }
            return outmassage;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество чисел в последовательности: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите последовательность: ");
            int[] nums = new int[size];
            for (int i = 0; i < size; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            string outmassage = Logic.Mas(nums, size);
            Console.Write(outmassage);
        }
    }
}