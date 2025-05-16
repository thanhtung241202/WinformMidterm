using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;
using String = System.String;

namespace Phan1
{
    public class Filetxt
    {

        public String ReadFile()
        {
            string filename = @"C:\Users\Administrator\Downloads\WinformMidterm\WinformMidterm\Phan1\Data\dulieu.txt";
            StreamReader streamReader = new StreamReader(filename);
            string line = streamReader.ReadLine();
            //string temp = lin;
            return line;
        }
        
        public void WriteFile (string text)
        {
            string filename = @"C:\Users\Administrator\Downloads\WinformMidterm\WinformMidterm\Phan1\Data\dulieu.txt";
            StreamWriter streamWriter = new StreamWriter(filename);
            streamWriter.WriteLine(text);
            streamWriter.Close();
            
        }




    }
}
