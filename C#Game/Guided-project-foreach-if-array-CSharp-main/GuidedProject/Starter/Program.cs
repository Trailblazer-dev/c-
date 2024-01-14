using System;

// initialize variables - graded assignments 
int currentAssignments = 5;""}

int[] sophiaScores = new int[]{90,86,87,98,100};
int[] andrewScores = new int[]{92,89,81,96,90};
int[] emmaScores= new int[] {90,85,87,98,68};
int[] loaganScores= new int[] {90,95,87,88,96};


int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

sophiaSum = 0;
//calculating the sum for sophia 
foreach(int score in sophiaScores)
{

    sophiaSum +=score;
}
sophiaScore = (decimal)sophiaSum / currentAssignments;

//calculating the sum for andrew
andrewSum = 0;
foreach (int score in andrewScores)
{
    andrewSum += score;
    
}
andrewScore = (decimal)andrewSum / currentAssignments;

//calculating the sum for emma
emmaSum = 0;
foreach (int score in emmaScores)
{
    emmaSum +=score;   
}
emmaScore = (decimal)emmaSum / currentAssignments;

//calculating the sum for logan
loganSum = 0;
foreach (int score in loaganScores)
{
    loganSum += score    
}
loganScore = (decimal)loganSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
