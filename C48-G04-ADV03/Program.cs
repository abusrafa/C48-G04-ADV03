namespace C48_G04_ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PrintSeparator.PrintSystemTitle();
            Console.WriteLine();

            #region Exercise 1: Student Grade Manager
            PrintSeparator.PrintSeparatorF();
            Console.WriteLine("------- Exercise 1: Student Grade Manager -------");
            PrintSeparator.PrintSeparatorF();
            Console.WriteLine();

            // 1. Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            List<int> Grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            // 2. Print the collection, Count, first and last grade  
            Console.WriteLine("All Grades: " + string.Join(", ", Grades));
            Console.WriteLine("Count: " + Grades.Count);
            Console.WriteLine("First Grade: " + Grades.First());
            Console.WriteLine("Last Grade: " + Grades.Last());

            Console.WriteLine("--------------------------------");

            // 3. Sort the grades ascending, then print
            Grades.Sort();
            Console.WriteLine("Sorted Grades: " + string.Join(", ", Grades));

            Console.WriteLine("--------------------------------");

            // 4. Get the first grade above 90
            int firstAbove90 = Grades.First(g => g > 90);
            Console.WriteLine("First grade above 90: " + firstAbove90);

            // 5. Get all grades below 75 (failing grades)
            var failingGrades = Grades.Where(g => g < 75);
            Console.WriteLine("Failing grades (< 75): " + string.Join(", ", failingGrades));

            Console.WriteLine("--------------------------------");

            // 6. Remove all failing grades (below 75)

            Grades.RemoveAll(g => g < 75);
            Console.WriteLine("Grades after removing failing grades: " + string.Join(", ", Grades));

            Console.WriteLine("--------------------------------");

            // 7. Check if any grade equals 100
            bool has100 = Grades.Any(g => g == 100);
            Console.WriteLine("Is there any grade equal to 100? " + has100);

            Console.WriteLine("--------------------------------");

            // 8. Create a List<string> where each grade becomes "Grade: X"
            List<string> formattedGrades = Grades.Select(g => $"Grade: {g}").ToList();
            Console.WriteLine("Formatted Grades:");
            foreach (string item in formattedGrades)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Exercise 2: Leaderboard

            PrintSeparator.PrintSeparatorF();
            Console.WriteLine("------- Exercise 2: Leaderboard -------");
            PrintSeparator.PrintSeparatorF();
            Console.WriteLine();

            //1.Add: 500="Ahmed", 200="Sara", 800="Ali", 350="Mona"

            SortedDictionary<int, string> Players = new()
            {
                [500] = "Ahmed",
                [200] = "Sara",
                [800] = "Ali",
                [350] = "Mona"
            };

            //2. Print all entries (they should be sorted by score automatically)

            Console.WriteLine("-----------------------------------------");
            foreach (var (score, name) in Players)
            {
                Console.WriteLine($"{score} : {name}");
            }

            //3. Access the first key and first value
            Console.WriteLine("-----------------------------------------");
            var firstEntry = Players.First();
            Console.WriteLine($"First Entry: {firstEntry.Key} : {firstEntry.Value}");

            //4. Check if score 500 exists
            Console.WriteLine("-----------------------------------------");
            bool scoreExists = Players.ContainsKey(500);
            Console.WriteLine($"Does score 500 exist? {scoreExists}");

            //5. Safely get the player with score 999
            Console.WriteLine("-----------------------------------------");
            Players.TryGetValue(999, out string playerWithScore999);
            Console.WriteLine($"Player with score 999: {playerWithScore999 ?? "Not found"}");

            //6. Remove the player with score 200 and print the updated list
            Console.WriteLine("-----------------------------------------");
            Players.Remove(200);
            Console.WriteLine("After Removing score 200:");
            foreach (var (score, name) in Players)
            {
                Console.WriteLine($"{score} : {name}");
            }

            #endregion

            #region Exercise 3: Phone Book
            PrintSeparator.PrintSeparatorF();
            Console.WriteLine("------- Exercise 3: Phone Book -------");
            PrintSeparator.PrintSeparatorF();
            Console.WriteLine();

            //1. Create a Collection  with 4 contacts (name → phone number)
            Console.WriteLine("-----------------------------------------");
            Dictionary<string, string> phoneBook = new()
            {
                ["Ali"] = "01011111111",
                ["Mohammed"] = "01122222222",
                ["Salma"] = "01233333333",
                ["Sara"] = "01544444444"
            };
            foreach (var (personName, phoneNumber) in phoneBook)
            {
                Console.WriteLine($"{personName}:{phoneNumber}");
            }

            //2. Add a new contact using [] syntax (add or update)
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("After Adding Contacts:");
            phoneBook["Ahmed"] = "01099999999"; // Add new contact
            foreach (var (personName, phoneNumber) in phoneBook)
            {
                Console.WriteLine($"{personName}:{phoneNumber}");
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("After Updating Contacts:");
            phoneBook["Sara"] = "01555555555"; // Update existing contact
            foreach (var (personName, phoneNumber) in phoneBook)
            {
                Console.WriteLine($"{personName}:{phoneNumber}");
            }

            //3. Try adding a duplicate using .Add() — catch the exception and print the error
            Console.WriteLine("-----------------------------------------");
            try
            {
                phoneBook.Add("Ali", "01000000000"); // Attempt to add duplicate
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            //4. Try adding a duplicate using .TryAdd() — print whether it succeeded
            Console.WriteLine("-----------------------------------------");
            bool tryAddResult = phoneBook.TryAdd("Saewss", "01088888888");
            Console.WriteLine($"TryAdd(\"Ali\"): Succeeded = {tryAddResult}");

            //5. Search for a contact that doesn’t exist
            Console.WriteLine("-----------------------------------------");

            string searchName = "Khaled";
            bool exists = phoneBook.ContainsKey(searchName);

            Console.WriteLine($"Does '{searchName}' exist? {exists}");

            //6.Get a contact with a fallback of "Not Found"
            Console.WriteLine("-----------------------------------------");

            string result = phoneBook.GetValueOrDefault(searchName, "Not Found");

            Console.WriteLine($"Contact Result: {result}");

            //7. Print all Keys on one line, then all Values on another line
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("All Keys:");
            Console.WriteLine(string.Join(", ", phoneBook.Keys));
            Console.WriteLine("All Values:");
            Console.WriteLine(string.Join(", ", phoneBook.Values));

            #endregion

            #region Exercise 4: Unique Email Validator

            //1. Create a HashSet<string> with a case-insensitive comparer: new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            Console.WriteLine("-----------------------------------------");
            HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            //2. Add these emails: "ahmed@test.com", "AHMED@test.com", "sara@test.com", "Sara@Test.Com"
            emails.Add("ahmed@test.com");
            emails.Add("AHMED@test.com");
            emails.Add("sara@test.com");
            emails.Add("Sara@Test.Com");

            //3.Print Count — how many are actually stored? Explain why.
            Console.WriteLine($"Count of unique emails: {emails.Count}");
            // Explanation: The HashSet is case-insensitive, so "ahmed@test.com" and "AHMED@test.com" are considered the same.

            //4 Create two sets: Set A = {1,2,3,4,5} and Set B = {4,5,6,7,8}
            HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            //5. Print the result of: UnionWith, IntersectWith, ExceptWith
            // UnionWith 
            HashSet<int> union = new(setA);
            union.UnionWith(setB);
            ConsoleHelper.PrintHashSet("A UnionWith B", union);

            // IntersectWith
            HashSet<int> intersect = new(setA);
            intersect.IntersectWith(setB);
            ConsoleHelper.PrintHashSet("A IntersectWith B", intersect);

            // ExceptWith
            HashSet<int> except = new(setA);
            except.ExceptWith(setB);
            ConsoleHelper.PrintHashSet("A ExceptWith B", except);

            //6. Use IsSubsetOf to check if {1,2} is a subset of Set A
            HashSet<int> subSet = [1, 2];
            bool isSubset = subSet.IsSubsetOf(setA);
            Console.WriteLine($"Is {{1, 2}} a subset of Set A: {isSubset}");

            #endregion
        }
    }
}
