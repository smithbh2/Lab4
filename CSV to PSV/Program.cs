namespace CSV_to_PSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string root = FileRoot.Root;
            string csvFile = root + Path.DirectorySeparatorChar + "data.csv";
            string psvFile = root + Path.DirectorySeparatorChar + "data.psv";

            List<Person> people = new List<Person>();

            using (StreamReader sr = new StreamReader(csvFile))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    var info = line.Split(",");

                    string firstName = info[0];
                    string lastName = info[1];
                    string streetAddress = info[2];
                    string city = info[3];
                    string state = info[4];
                    string postalCode = info[5];


                    Address address = new Address(streetAddress,city, state, postalCode );

                    people.Add(new Person(firstName, lastName, address));
                }
            }

            people.Sort();

            using (StreamWriter sw = new StreamWriter(psvFile))
            {
                foreach(Person person in people)
                {
                    sw.WriteLine(person);
                }
            }
        }
    }
}