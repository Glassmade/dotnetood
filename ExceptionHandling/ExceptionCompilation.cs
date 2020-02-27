using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class ExceptionCompilation
    {

        public StreamReader streamreader;

        public ExceptionCompilation()
        {

        }

        static string insertNumber(int number)
        {
            if (number < 0)
            {
                throw new CustomNegativeNumberException("No negative numbers please");
            }

            return "Positive number inserted";
        }
       

        public void fileOpenExample(String filePath)
        {
            try
            {
                streamreader = new StreamReader(filePath);
                Console.WriteLine(streamreader.ReadToEnd() + 
                    "\nEnd of file.\n Press any key to exit");
                Console.ReadKey();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Exception message: " + e.Message);
                Console.WriteLine("Please check if the file exists {0}", filePath);
                Console.WriteLine("\n Exception StackTrace " + e.StackTrace);
                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine("Unkown Exception "+ e.Message);
                Console.ReadKey();

            }
            finally
            {
                Console.WriteLine("Cleaning up");
                Console.ReadKey();
                if (streamreader != null)
                    streamreader.Close();
            }
        }

        public void divideWithZeroExample(int divided, int divider)
        {
            
            try
            {
                Console.WriteLine(divided / divider);
            }catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }

        public void onlyPositiveIntegersPlease(int positiveInteger)
        {
            try
            {
                Console.Write(insertNumber(positiveInteger));
            }
            catch (CustomNegativeNumberException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

    }
}
