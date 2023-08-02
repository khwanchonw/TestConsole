
namespace TestConsole.MyCode
{
    public class TestArray
    {
        public TestArray() //Find Max Vote
        {
            int a = 5;
            int b = 8;
            int c = 2;
            int d = 1;
            int e = 7;

            //Method 1. using array
            int[] ar = { a, b, c, d, e };
            string[] st = { nameof(a), nameof(b), nameof(c), nameof(d), nameof(e) };
            int mx = ar.Max();
            int mi = Array.IndexOf(ar, mx);

            Console.WriteLine("Method 1: Max at {0} = {1}", st[mi], mx);

            //Method 2. using 2d array
            object[,] mixedArray = new object[,] { { nameof(a), a }, { nameof(b), b }, { nameof(c), c } };
            int im = 1;//index of number to find max
            int maxRowIndex = Enumerable.Range(im, mixedArray.GetLength(im)).Aggregate((i, j) => (int)mixedArray[i, im] > (int)mixedArray[j, im] ? i : j);

            Console.WriteLine("Method 2: Max at {0} = {1}", mixedArray[maxRowIndex, 0], mixedArray[maxRowIndex, 1]);

            //Method 3. using loop
            int[] ar3 = { a, b, c, d, e };
            string[] st3 = { nameof(a), nameof(b), nameof(c), nameof(d), nameof(e) };

            int maxindex = 0;
            int maxvalue = 0;
            for (int i = 0; i < ar3.Length; i++)
            {
                if (ar3[i] > maxvalue)
                {
                    maxvalue = ar3[i];
                    maxindex = i;
                }
            }
            Console.WriteLine("Method 3: Max at {0} = {1}", st3[maxindex], maxvalue);
        }
    }
}
