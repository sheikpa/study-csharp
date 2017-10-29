using System;

namespace probrem
{
    class RProgram501
    {
        public void call()
        {
            Random r = new Random();
            String[] a = new String[7];
            int i = 0;
            while(String.IsNullOrWhiteSpace(a[6]))
            {
                int number = r.Next(1, 10);
                a[i] = number.ToString();
                i++;
            }
            String msg = "";
            for (i = 0; i < 7; i++)
            {
                msg = msg + "a[" + i + "]=" + a[i] + " ";
            }
            Console.WriteLine(msg);
        }
    }
}
