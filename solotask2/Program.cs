Console.WriteLine("What is your grade percentage? ");
float percentage = float.Parse(Console.ReadLine());



string gradeLetter = "F";
string gradeSign  = "";
string passFail = "FAIL!!!!!";

if (percentage >= 90){
    gradeLetter = "A"; 
}
else if (percentage >= 80){
    gradeLetter = "B";
}
else if (percentage >= 70){
    gradeLetter = "C";
}
else if (percentage >= 60){
    gradeLetter = "D";
}

if (gradeLetter != "F")
    if (percentage % 10 >= 7){
        gradeSign = "+";
    }
    else if (percentage % 10 <= 3){
        gradeSign = "-";
    }

if (percentage >= 70){
    passFail = "pass";
}

Console.WriteLine($"Your grade is {gradeLetter}{gradeSign}. You {passFail}");