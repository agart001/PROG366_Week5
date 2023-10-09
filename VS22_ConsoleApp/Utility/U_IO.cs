using System.Collections.ObjectModel;
using System.IO;

namespace VS22_ConsoleApp.Utility
{
    
    public static class U_IO
    {
        

        public static ICollection<string> ReadFile(string file)
        {
            string path = $"{Directory.GetCurrentDirectory()}\\{file}";
            

            ICollection<string> contents = new Collection<string>();
            using(StreamReader reader = new StreamReader(path))
            {
                var line = reader.ReadLine();

                while(line != null)
                {
                    contents.Add(line);

                    line = reader.ReadLine();
                }

                reader.Dispose();
                reader.Close();
            }

            return contents;
        }


        public static void WriteFile(ICollection<string> contents, string outputfile)
        {
            ClearFile(outputfile);

            FileStream stream = new FileStream($"{Directory.GetCurrentDirectory()}\\{outputfile}", FileMode.Create, FileAccess.Write);

            using(StreamWriter writer = new StreamWriter(stream))
            {
                int index = 0;

                while(index < contents.Count())
                {
                    writer.WriteLine(contents.ElementAt(index));
                    index++;
                }

                writer.Dispose();
                writer.Close();

                stream.Dispose();
                stream.Close();
            }
        }


        public static void ClearFile(string file)
        {
            // Build the path for the output file based on the provided IFile object.
            string path = $"{Directory.GetCurrentDirectory()}\\{file}";

            // Check if the output file exists; if not, no action is taken.
            if (File.Exists(path) == false) 
            {
                return;
            }

            // Delete the output file.
            File.Delete(path);
        }

    }

}