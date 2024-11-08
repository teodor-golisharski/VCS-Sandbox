namespace _2._5._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string egn = Console.ReadLine()!;

            char[] arr = egn.ToCharArray();

            string y = string.Join("", arr[0], arr[1]);
            string m = string.Join("", arr[2], arr[3]);
            string d = string.Join("",arr[4], arr[5]);

            int year = int.Parse(y);
            bool flag = false;
            if (year < 24 && year >= 0)
            {
                flag = true;
                year += 2000;
            }
            else
            {
                year = int.Parse($"19" + y);
            }

            int month = int.Parse(m);
            if (flag)
            {
                month -= 40;
            }

            int day = int.Parse(d);
            int result = int.Parse(arr[0].ToString()) * 2 +
                         int.Parse(arr[1].ToString()) * 4 +
                         int.Parse(arr[2].ToString()) * 8 +
                         int.Parse(arr[3].ToString()) * 5 +
                         int.Parse(arr[4].ToString()) * 10 +
                         int.Parse(arr[5].ToString()) * 9 +
                         int.Parse(arr[6].ToString()) * 7 +
                         int.Parse(arr[7].ToString()) * 3 +
                         int.Parse(arr[8].ToString()) * 6;

            result %= 11;
            if (result == 10)
            {
                result = 0;
            }

            try
            {
                DateTime dt = new DateTime(year, month, day);
                string gender = string.Empty;

                if (int.Parse(arr[8].ToString()) %2==0)
                {
                    gender = "male";
                }
                else
                {
                    gender = "female";
                }

                if (int.Parse(arr[9].ToString()) != result)
                {
                    throw new Exception("Last digit wrong");
                }

                Console.WriteLine(dt.ToString("dd.MM.yyyy"));
                Console.WriteLine(gender);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid data!");
            }

        }
    }
}