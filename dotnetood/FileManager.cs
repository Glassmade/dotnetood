using System;
using log4net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dotnetood
{
    

    public class FileManager
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger("Program.cs");


        public static void writeMessageToFile(String filePath, string message)
        {
            StreamWriter theWriter = null;
            
            try
            {
                theWriter = File.AppendText(filePath);
                theWriter.WriteLine(message);
                
            }
            catch (IOException e)
            {
                logger.Error("Error with appending file {0}", e);
            }
            finally
            {
                try
                {
                    theWriter.Flush();
                    theWriter.Close();
                }
                catch (IOException e)
                {
                    logger.Error("Error with closing the stream {0}", e);
                }

            }
        }

        public static void readMessageFromFile(String filePath)
        {
            using (StreamReader streamReader = File.OpenText(filePath))
            {
                string printedString = "";
                while ((printedString = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(printedString);
                }
            }
        }

        public static string stringMessageFromFile(String filePath)
        {
            return File.ReadAllText(filePath);
        }
        public static void deleteContentOfFile(String filePath)
        {
            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine("");
            }
        }
    }
}
