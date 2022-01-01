
class Solution {
	static void Main( string[] args) {
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
	  	string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
	  	int[] scores = new int[numScores];
		for(int i = 0; i < numScores; i++){
			scores[i]= Convert.ToInt32(inputs[i]);
		} 
	  	
		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}

class Person
{
    protected string _firstName;
    protected string _lastName;
    protected int _id;
    public Person(){}
    public Person(string firstName, string lastName, int id)
    {
        _firstName = firstName;
        _lastName = lastName;
        _id = id;   
    }

    public void printPerson(){
        Console.WriteLine($"Name: {_firstName} LastName: {_lastName} ID: {_id}");
    }
}

class Student : Person
{
    private int[] _testScores;

    public Student(string fname, string lname, int sid, int[] scores)
    {
        _firstName = fname;
        _lastName = lname;
        _id = sid;
        _testScores = scores;
    }

    public char Calculate()
    {
    var sum = 0;
    foreach (var score in _testScores)
    {
        sum += score;
    }

    var avg = sum / _testScores.Length;

    var result = avg switch
    {
        >= 90 and <= 100 => 'O',
        >= 80 and <= 90 => 'E',
        >= 70 and <= 80 => 'A',
        >= 55 and <= 70 => 'P',
        >= 40 and <= 55 => 'D',
        < 40 => 'T',
        _ => 'X'
    };
    return result;
    }    
}