using System;
using System.Text;
using Epam_Projects.Task01;

namespace Epam_Projects
{
   class Program
   {
      static void Main(string[] args)
      {
         char[] r = Console.ReadLine().ToCharArray(); 
         MyStringBuilder a = new MyStringBuilder(r);
         MyStringBuilder b = new MyStringBuilder("ssws".ToCharArray());
         Console.WriteLine(a == b);
         Console.WriteLine(a != b);
         Console.WriteLine(a.MyAppend("Maksim".ToCharArray()));
         Console.WriteLine(a.MyCompare("saa".ToCharArray()));
         Console.WriteLine(a.Find('t'));
         Console.WriteLine(a.ConvertToCharArr());
             
         Console.WriteLine(a.MyConcat2("wdxwd".ToCharArray(), "dse3d3e".ToCharArray()));

      }
   }
}
