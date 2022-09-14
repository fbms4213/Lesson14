using System.Text;

namespace Lesson14;


#nullable disable


//  static class ExtMethods
//  {
//      public static IEnumerator<int> GetEnumerator(this int i)
//      {
//          return Enumerable.Range(0, i).GetEnumerator();
//      }
//  }
//  
//  class Program
//  {
//      static void Main()
//      {
//          int x = 15;
//  
//  
//          foreach (int i in x)
//          {
//              Console.WriteLine(i);
//          }
//      }
//  }









//// Stream


// FileStream
// MemoryStream
// NetworkStream

// PipeStream
// UnmanagedMemoryStream
// BufferedStream
// CryptoStream


///// Adapter classes or Helper classes
// StreamReader, StreamWriter
// BinaryReader, BinaryWriter
// XmlReader, XmlWriter

// TextReader, TextWriter



// GZipStream
// DeflateStream



// Directory, DirectoryInfo
// File, FileInfo
// Path



class Program
{
    static void Main()
    {


        #region Write with FileStream
        // using (FileStream fs = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
        // {
        //     Console.Write("Enter some text: ");
        //     string text = Console.ReadLine();
        // 
        //     byte[] buffer = Encoding.Default.GetBytes(text);
        // 
        //     fs.Write(buffer, 0, buffer.Length);
        // 
        //     // fs.Close();
        //     // fs.Flush();
        // }
        #endregion Write with FileStream




        #region Read with FileStream

        // using (FileStream fs = new FileStream("test.txt", FileMode.Open))
        // {
        //     byte[] buffer = new byte[fs.Length];
        // 
        //     fs.Read(buffer, 0, buffer.Length);
        // 
        //     var str = Encoding.Default.GetString(buffer, 0, buffer.Length);
        // 
        //     Console.WriteLine(str);
        // }

        #endregion Read with FileStream










        #region Write with StreamWriter (Adapter)

        // using FileStream fs = new FileStream("books.txt", FileMode.OpenOrCreate);
        // using StreamWriter sw = new StreamWriter(fs); // adapter
        // 
        // // sw.WriteLine("book");
        // 
        // 
        // List<Book> books = new()
        // {
        //     new Book(1, "Joseph Albahari", "C# in a Nutshell", "Programming"),
        //     new Book(2, "Jeffrey Richter", "CLR VIA C#", "Programming"),
        //     new Book(3, "Antoine de Saint-Exupéry", "The Little Prince", "Kid")
        // };
        // 
        // 
        // books.ForEach(book => sw.WriteLine(book));


        #endregion Write with StreamWriter (Adapter)




        #region Read with StreamReader (Adapter)

        // using FileStream fs = new FileStream("books.txt", FileMode.OpenOrCreate);
        // using StreamReader sr = new StreamReader(fs);
        // 
        // 
        // Console.WriteLine(sr.ReadToEnd());


        #endregion Read with StreamReader (Adapter)









        #region Write with BinaryWriter (Adapter)

        // using FileStream fs = new FileStream("binaryDemo.bin", FileMode.OpenOrCreate, FileAccess.Write);
        // using BinaryWriter bw = new BinaryWriter(fs);
        // 
        // bw.Write("Something");
        // bw.Write(15);
        // bw.Write(true);

        #endregion Write with BinaryWriter (Adapter)



        #region Read with BinaryReader (Adapter)

        // using FileStream fs = new FileStream("binaryDemo.bin", FileMode.OpenOrCreate, FileAccess.Read);
        // using BinaryReader br = new BinaryReader(fs);
        // 
        // 
        // Console.WriteLine(br.ReadString());
        // Console.WriteLine(br.ReadInt32());
        // Console.WriteLine(br.ReadBoolean());


        #endregion Read with BinaryReader (Adapter)









        #region File and FileInfo

        // var book = new Book(1, "Joseph Albahari", "C# in a Nutshell", "Programming");
        // 
        // 
        // File.WriteAllText("book.txt", book.ToString());
        // 
        // 
        // 
        // 
        // FileInfo fileInfo = new("book.txt");
        // 
        // Console.WriteLine(fileInfo.FullName);
        // Console.WriteLine(fileInfo.Exists);
        // Console.WriteLine(fileInfo.Extension);
        // Console.WriteLine(fileInfo.DirectoryName);
        // Console.WriteLine(fileInfo.Length);

        #endregion File and FileInfo











        #region Directory and DirectoryInfo


        // Directory.CreateDirectory(@"C:\Users\t.novruzov\Desktop\folder1");
        // Directory.CreateDirectory("C:/Users/t.novruzov/Desktop/folder2");
        // Directory.CreateDirectory("C:\\Users\\t.novruzov\\Desktop\\folder3");
        // Directory.CreateDirectory($"C:\\Users\\{Environment.UserName}\\Desktop\\folder4");




        // Directory.Delete($"C:\\Users\\{Environment.UserName}\\Desktop\\folder4");



        // var root = Directory.GetDirectoryRoot($"C:\\Users\\{Environment.UserName}\\Desktop\\folder4");
        // Console.WriteLine(root);





        // foreach (var folder in Directory.GetDirectories(@$"C:/Users/{ Environment.UserName}/Desktop"))
        //     Console.WriteLine(folder);
        // 
        // 
        // foreach (var folder in Directory.GetFiles(@$"C:/Users/{ Environment.UserName}/Desktop"))
        //     Console.WriteLine(folder);





        // DirectoryInfo directoryInfo = new DirectoryInfo(".");
        // Console.WriteLine(directoryInfo);
        // Console.WriteLine(directoryInfo.Parent);
        // Console.WriteLine(directoryInfo.FullName);
        // Console.WriteLine(directoryInfo.Name);
        // Console.WriteLine(directoryInfo.Root);




        // .  -> current
        // .. -> previous
        // ../.. -> previous -> previous

        // // DirectoryInfo directoryInfo = new DirectoryInfo("..");
        // DirectoryInfo directoryInfo = new DirectoryInfo("../../..");
        // Console.WriteLine(directoryInfo.FullName);




        #endregion Directory and DirectoryInfo






        #region Path

        string filename = "example";
        string extension = ".txt";

        string fullname = filename + extension;


        // var path = Path.Combine(@"C:\Users", Environment.UserName, "Desktop", fullname);
        // Console.WriteLine(path);


        // Console.WriteLine(Environment.SpecialFolder.Desktop);



        var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fullname);
        Console.WriteLine(path);


        #endregion Path

    }
}