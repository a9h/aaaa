namespace ELFES;

class Program
{
    static void Main(string[] args)
    {

        string filename = "/Users/woodyrobson/Projects/ELFES/ELFES/ELF.txt";

        string[] lines = File.ReadAllLines(filename);
        List<int> values = new List<int>();
        char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };



        foreach (string line in lines)
        {
            string number = "";


            int counter = 0;





            //for every character in a given line


            if(counter == 0)
            {
                foreach (char letter in line)
                {





                    //checks character in text against a array of numbers
                    foreach (char intiger in numbers)
                    {


                        if (intiger == letter && counter < 2)
                        {
                            number += Convert.ToString(letter);
                            counter++;
                        }


                    }


                }

            }
            else
            {
                foreach (char letter in line.Reverse())
                {





                    //checks character in text against a array of numbers
                    foreach (char intiger in numbers)
                    {


                        if (intiger == letter && counter < 2)
                        {
                            number += Convert.ToString(letter);
                            counter++;
                        }


                    }



                }





            }
            if (number.Length == 2)
            {
                values.Add(Convert.ToInt32(number));
            }








        }
        int totalValue = 0;

        foreach (int value in values)
        {
            totalValue += value;
        }
        
        Console.WriteLine(totalValue);
        Console.ReadKey();
    }
}

