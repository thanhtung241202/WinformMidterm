using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermWindow
{
    public class Filetxt
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileContent { get; set; }
        public Filetxt(string fileName, string filePath, string fileContent)
        {
            FileName = fileName;
            FilePath = filePath;
            FileContent = fileContent;
        }
        public override string ToString()
        {
            return $"{FileName} - {FilePath}";
        }
        public String ReadFile()
        {
            try
            {
                FileContent = System.IO.File.ReadAllText(FilePath);
                return FileContent;
            }
            catch (Exception ex)
            {
                return $"Error reading file: {ex.Message}";
            }
        }
        public String WriteFile(string content)
        {
            try
            {
                System.IO.File.WriteAllText(FilePath, content);
                return "File written successfully.";
            }
            catch (Exception ex)
            {
                return $"Error writing file: {ex.Message}";
            }
        }
    }
}
