namespace HomeWork
{
    public class Document
    {
        //public string documentNumber;
        //public int maxNumber = 28;
        //public DateTime documentDate;

        //public string documentCode;
        //public int numberSum;

        //public Rinda[] row;

        static void Main(string[] args)
        {
            string documentNumber;
            int maxNumber = 28;
            DateTime documentDate;

            string documentCode;
            int numberSum;

            Rinda[] rows;


            var currentDay = DateTime.Now.Day;
            Console.WriteLine(DateTime.Now.AddDays(-currentDay + 1).ToString("dd.MM.yyyy"));



            rows = new Rinda[maxNumber / 3];
            for (int i = 0; i < rows.Length; i++)
            {
                rows[i] = new Rinda()
                {
                    sum = 0,
                };

                //rows = new Rinda[maxNumber / 3];
                //for (int i = 0; i < rows.Length; i++)
                //    rows[i] = new Rinda();
                //        numberSum = 0;




                //   List<Rinda> list = new List<Rinda>();
                //List Rinda list = new List Rinda();
                //List<Rinda> list2 = new List<Rinda>();
                //List<Rinda> list3 = new List<Rinda>();

                //Lists<int> list = new List<int>();
                //lists.Add(list);
                //lists.Add(list2);
                //lists.Add(list3);



                //  list.Add(new Rinda());
                //list.AddRange()



                //
                //List ts = new List();
                // while // max summa 28 +


            }

            //public static int lineSum (int[] rinda)
            //int[] lineSum = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //int arSum = lineSum[28];
            //while (arSum <= lineSum.Length)
            //{
            //    int sum = lineSum[arSum];
            //    Console.WriteLine($"arSum = {arSum} sum = {28}");
            //    arSum++;
            //}
            //    Console.WriteLine($"{lineSum[1]}");
            //    for (int i = 0; i < lineSum.Length; i++)
            //    {
            //        int sum = lineSum[1];
            //        Console.WriteLine($"i={i} sum = {sum}");
            //    }

            //foreach (var sum in lineSum)
            //{
            //    Console.WriteLine($"number is = {sum}");
            //}
            //private bool inBounds(int index, int[] array)
            //{
            //    return (index >= 0) && (index < array.Length);
            //}




        }
    }
}
