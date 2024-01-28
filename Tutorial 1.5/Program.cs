﻿/* 
#Exercise
You're given a short list of four students and their five assignment grades.
Each assignment grade is expressed as an integer value, 0-100, where 100 represents 100% correct.
Final scores are calculated as an average of the five assignment scores.
Your application needs to perform basic math operations to calculate the final grades for each student.
Your application needs to output/display each student’s name and final score.

Currently, the teachers grade book shows the graded assignments for each student
as follows:

Sophia: 93, 87, 98, 95, 100

Nicolas: 80, 83, 82, 88, 85

Zahirah:   84, 96, 73, 85, 79

Jeong:  90, 92, 98, 100, 97

The teacher requires that the calculated grades for each student are displayed as follows:

Student     Grade
Sophia      94.6  A
Nicolas     83.6  B
Zahirah     83.4  B
Jeong       95.4  A
*/

// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

String sophia, nicolas, zahirah, jeong;
int sophiaSum, nicolasSum, zahirahSum, jeongSum;
decimal sophiaAverage, nicolasAverage, zahirahAverage, jeongAverage;

sophia = "Sophia";
nicolas = "Nicolas";
zahirah = "Zahirah";
jeong = "Jeong";

sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

sophiaAverage = (decimal) sophiaSum / currentAssignments;
nicolasAverage = (decimal) nicolasSum / currentAssignments;
zahirahAverage = (decimal) zahirahSum / currentAssignments;
jeongAverage = (decimal) jeongSum / currentAssignments;

Console.WriteLine("Student\t\t" + "Grade");
Console.WriteLine(sophia + "\t\t" + sophiaAverage + "\tA");
Console.WriteLine(nicolas + "\t\t" + nicolasAverage + "\tB");
Console.WriteLine(zahirah + "\t\t" + zahirahAverage + "\tB");
Console.WriteLine(jeong + "\t\t" + jeongAverage + "\tA");