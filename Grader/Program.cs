// initialize variables - graded assignments 
int currentAssignments = 5;

List<int> sophiasScores = new List<int> { 93, 87, 98, 95, 100 };
List<int> nicolasScores = new List<int> { 80, 83, 82, 88, 85 };
List<int> zahirahScores = new List<int> { 84, 96, 73, 85, 79 };
List<int> jeongScores = new List<int> { 90, 92, 98, 100, 97 };

int sophiaSum = 0;
foreach (int score in sophiasScores)
{
	sophiaSum += score;
}

int nicolasSum = 0;
foreach (int score in nicolasScores)
{
	nicolasSum += score;
}

int zahirahSum = 0;
foreach (int score in zahirahScores)
{
	zahirahSum += score;
}

int jeongSum = 0;
foreach (int score in jeongScores)
{
	jeongSum += score;
}

decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
decimal jeongScore = (decimal) jeongSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");
