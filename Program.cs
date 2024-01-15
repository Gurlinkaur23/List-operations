using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LabClass lc = new LabClass();

                // - - - - - - EXERCISE - 01 - - - - - -
                lc.SearchNumInList();
                Console.WriteLine(" - * - * - * - * - * - * - ");
                Console.WriteLine("");

                // - - - - - - EXERCISE - 02 - - - - - -
                lc.RemoveElementsFromList();
                Console.WriteLine(" - * - * - * - * - * - * - ");
                Console.WriteLine("");

                // - - - - - - EXERCISE - 03 - - - - - -
                lc.SlicingList();
                Console.WriteLine(" - * - * - * - * - * - * - ");
                Console.WriteLine("");

                // - - - - - - EXERCISE - 04 - - - - - -
                lc.SequenceOfInputNumbers();
                Console.WriteLine(" - * - * - * - * - * - * - ");

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.ReadKey();
            }
        }
    }
}
