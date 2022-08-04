namespace HomeWork
{
    public class Document
    {

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

               

            }


        }
    }
}
