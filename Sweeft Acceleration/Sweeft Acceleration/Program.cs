//დავალება 1 ბაქარი დათიაშვილი
//namespace PalindromeCheck
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter a string: ");// კონსოლში უნდა შევიყვანოთ სასურველი სიტყვა
//            string input2E = Console.ReadLine();

//            bool isPalindrome = sPalindrome(input);

//            Console.WriteLine(isPalindrome ? "The string is a palindrome" : "The string is not a palindrome");
//            //თუ isPalindrome არის true, ოპერატორი აბრუნებს სტრიქონს "სტრიქონი არის პალინდრომი".
//        }

//        static bool sPalindrome(string text)
//        {
//            // წაშალეთ ყველა non-alphanumeric სიმბოლო და გადაიყვანეთ პატარა lowercase
//            string stripped = new string(text.Where(char.IsLetterOrDigit).ToArray()).ToLower();

//            // შეამოწმეთ ტოლია თუ არა სტრიქონი მის reverse 
//            return stripped == new string(stripped.Reverse().ToArray());
//        }
//    }
//}

//დავალება 2


//namespace CoinChange
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter the amount: ");
//            int amount = int.Parse(Console.ReadLine());

//            int minCoins = CalculateMinCoins(amount);

//            Console.WriteLine($"Minimum number of coins required to make up {amount} tetris: {minCoins}");
//        }

//        static int CalculateMinCoins(int amount)
//        {
//            int[] coins = new int[] { 50, 20, 10, 5, 1 };
//            int minCoins = 0;

//            for (int i = 0; i < coins.Length; i++)
//            {
//                while (amount >= coins[i])
//                {
//                    amount -= coins[i];
//                    minCoins++;
//                }
//            }

//            return minCoins;
//        }
//    }
//}


//დავალება 3



//namespace SmallestPositiveInteger
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] array = new int[] { -1, 2, 3, 4, 7 };

//            int result = NotContains(array);

//            Console.WriteLine($"The smallest positive integer not in the array is: {result}");
//        }

//        static int NotContains(int[] array)
//        {
//            int min = 1;
//            while (array.Contains(min))
//            {
//                min++;
//            }
//            return min;
//        }
//    }
//}

//დავალება 4



//class Program
//{
//    static void Main(string[] args)
//    {
//        string sequence = "(()())";
//        bool isValid = IsProperly(sequence);
//        Console.WriteLine(isValid);
//    }

//    static bool IsProperly(string sequence)
//    {
//        int count = 0;
//        foreach (char c in sequence)
//        {
//            if (c == '(')
//            {
//                count++;
//            }
//            else if (c == ')')
//            {
//                count--;
//                if (count < 0)
//                {
//                    return false;
//                }
//            }
//        }
//        return count == 0;
//    }
//}

//დავალება 5



//namespace StaircaseVariants
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int stairCount = 5;
//            int variants = CountVariants(stairCount);
//            Console.WriteLine($"Number of variants to climb {stairCount} stairs: {variants}");
//        }

//        static int CountVariants(int stairCount)
//        {
//            int[] variants = new int[stairCount + 1];
//            variants[0] = 1;
//            variants[1] = 1;

//            for (int i = 2; i <= stairCount; i++)
//            {
//                variants[i] = variants[i - 1] + variants[i - 2];
//            }

//            return variants[stairCount];
//        }
//    }
//}

//დავალება 6


//CREATE TABLE Teacher (
//    TeacherId INT PRIMARY KEY,
//    FirstName VARCHAR(50),
//    LastName VARCHAR(50),
//    Gender VARCHAR(10),
//    Subject VARCHAR(50)
//);

//CREATE TABLE Pupil (
//    PupilId INT PRIMARY KEY,
//    FirstName VARCHAR(50),
//    LastName VARCHAR(50),
//    Gender VARCHAR(10),
//    Class VARCHAR(50)
//);

//CREATE TABLE TeacherPupil (
//    TeacherId INT,
//    PupilId INT,
//    CONSTRAINT PK_TeacherPupil PRIMARY KEY (TeacherId, PupilId),
//    CONSTRAINT FK_TeacherPupil_Teacher FOREIGN KEY (TeacherId) REFERENCES Teacher(TeacherId),
//    CONSTRAINT FK_TeacherPupil_Pupil FOREIGN KEY (PupilId) REFERENCES Pupil(PupilId)
//);

////შემდეგ ვაკეთებთ ჯოინს

//SELECT t.*
//FROM Teacher t
//JOIN TeacherPupil tp ON t.TeacherId = tp.TeacherId
//JOIN Pupil p ON tp.PupilId = p.PupilId
//WHERE p.FirstName = 'George' AND p.LastName = 'George';

//დავალება 7
//Create the Teacher and Pupil classes:
//using System.Collections.Generic;

//public class Teacher
//{
//    public int TeacherId { get; set; }
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public string Gender { get; set; }
//    public string Subject { get; set; }
//    public ICollection<Pupil> Pupils { get; set; }
//}

//public class Pupil
//{
//    public int PupilId { get; set; }
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public string Gender { get; set; }
//    public string Class { get; set; }
//    public ICollection<Teacher> Teachers { get; set; }
//}
////გაითვალისწინეთ ICollection-ის გამოყენება მასწავლებელსა და მოსწავლეს შორის ურთიერთობის დასადგენად ბევრი-მრავალზე.

////შექმენით DbContext კლასი და დაამატეთ DbSet თვისებები:
//public class SchoolContext : DbContext
//{
//    public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
//    {
//    }

//    public DbSet<Teacher> Teachers { get; set; }
//    public DbSet<Pupil> Pupils { get; set; }
//}
////შექმენით ფუნქცია თქვენს აპლიკაციაში, რომელიც ითხოვს მონაცემთა ბაზას და აბრუნებს ყველა მასწავლებელს, რომელიც ასწავლის სტუდენტს სახელად "გიორგი":
//public static List<Teacher> GetTeachersForGeorge()
//{
//    using (var context = new SchoolContext())
//    {
//        var teachers = context.Teachers
//            .Where(t => t.Pupils.Any(p => p.FirstName == "George" && p.LastName == "George"))
//            .ToList();

//        return teachers;
//    }
//}

//დავალება 8

//using System;
//using System.IO;
//using System.Net.Http;
//using System.Text.Json;
//using System.Threading.Tasks;

//class Program
//{
//    static async Task Main(string[] args)
//    {
//        await GenerateCountryDataFiles();
//    }

//    static async Task GenerateCountryDataFiles()
//    {
//        // Download the country data from the REST API
//        using var client = new HttpClient();
//        var response = await client.GetAsync("https://restcountries.com/v2/all");
//        var json = await response.Content.ReadAsStringAsync();
//        var countries = JsonSerializer.Deserialize<Country[]>(json);

//        // Create a text document for each country
//        foreach (var country in countries)
//        {
//            var fileName = $"{country.Name}.txt";
//            var filePath = Path.Combine(Environment.CurrentDirectory, fileName);
//            var contents = $"Region: {country.Region}\n" +
//                           $"Subregion: {country.Subregion}\n" +
//                           $"Latlng: {string.Join(",", country.Latlng)}\n" +
//                           $"Area: {country.Area}\n" +
//                           $"Population: {country.Population}\n";

//            await File.WriteAllTextAsync(filePath, contents);
//        }
//    }
//}

//class Country
//{
//    public string Name { get; set; }
//    public string Region { get; set; }
//    public string Subregion { get; set; }
//    public double[] Latlng { get; set; }
//    public double Area { get; set; }
//    public int Population { get; set; }
//}
