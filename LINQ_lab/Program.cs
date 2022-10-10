using System.Linq;
using System.Runtime.InteropServices;
using static LINQ_lab.Program;

namespace LINQ_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };
            
            int max = nums.Max();
            Console.WriteLine($"the max value is " + max);
            int min = nums.Min();
            Console.WriteLine($"the min value is " + min);

            int maxLess10k = nums.Where(k => k < 10000).Max();
            Console.WriteLine($"Max that is lower then 10k is " + maxLess10k);

            List<int> nums10to100 = nums.Where(k => k <= 100).ToList();
            string cookie = "All the values between 1-100 are: ";
            for(int i = 0; i < nums10to100.Count; i++)
            {
                cookie += nums10to100[i] + " ";
            }
            Console.WriteLine(cookie);
           
            List<int> num10to99k = nums.Where(k => k <= 99999999).ToList();
            
            string outstring = "The Values between 100000 and 999999 are ";
            for(int i = 0; i<num10to99k.Count();i++)
            {
                outstring += num10to99k[i] + " ";
            }
            Console.WriteLine(outstring);

            List<int> evenNums = nums.Where(num => num % 2 == 0).ToList();
            string getEven = "the even numbers are:";
            for(int i = 0; i<evenNums.Count; i++)
            {
                getEven += evenNums[i] + " ";
            }
            Console.WriteLine(getEven);

            List <int> reverse = nums.OrderByDescending(n => n).ToList();
            string descend = "descending numbers are: ";
          for(int i = 0; i<reverse.Count; i++)
            {
                descend += reverse[i] + " "; 
            } 
            
          Console.WriteLine(descend);

      public class Student
        {
            List<Student> students = new List<Student>();
            Student.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            }







        }
    }

 



  
  
 
  
