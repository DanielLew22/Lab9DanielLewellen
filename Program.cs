List <string> TO_DO =new List<string>();
List <string> Complete =new List<string>();
DateTime genTime = new DateTime();
genTime = DateTime.Now;
Console.WriteLine(genTime);
bool running = true;
while (running){
Console.Clear();
Console.WriteLine("Welcome to the SUPER TO-DO LIST!\n what would you like to do?");
Console.WriteLine("(1) look at TO-DO list\n(2) Look at completed task list\n(3) Edit TO-DO list\n(4) Leave");
int action = int.Parse(Console.ReadLine());
switch (action){
    case 1:
    if (TO_DO.Count==0){
        Console.WriteLine("Your To Do list is empty");
        Console.ReadKey();
    }
    else{
    foreach( string items in TO_DO)
    Console.WriteLine(items);
    }
    Console.ReadKey();
    break;
    case 2:
    if (Complete.Count == 0)
    Console.WriteLine("Your list is empty");
    else{
    foreach(string items in Complete)
    Console.WriteLine(items);
    }
    Console.ReadKey();
    break;
    case 3:
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("ADD new items, REMOVE items, COMPLETE tasks");
    string choice = Console.ReadLine().ToUpper();
    if (choice == "ADD")
    adding();
    else if (choice=="REMOVE")
    removing();
    else if (choice == "COMPLETE")
    completing();
    else{
        Console.WriteLine("Invalid Imput");
    }
    break;
    case 4:
    Console.WriteLine("goodbye!");
    running = false;
    break;
    default:
    Console.WriteLine("Invalid input");
    break; 
}
}
void adding(){
bool task =true;
while (task){
string newTask = "";
Console.WriteLine("What is the task you are adding?");
newTask = Console.ReadLine();
Console.WriteLine($"is this the task you are adding? ");
Console.WriteLine($"{newTask}\n <y or n>");
string? answer = Console.ReadLine();
if (answer=="y")
{
    string addtask = newTask +" " + DateTime.Now;
    TO_DO.Add(addtask);
    Console.WriteLine("your task has been added!");
    task = false;
}
}
}
void completing(){
bool ye = true;
while (ye){
Console.WriteLine("what task did you complete?");
int w =1;
foreach( string items in TO_DO)
{
    Console.WriteLine($"({w}){items}");
    w++;
}
int comple = int.Parse(Console.ReadLine());
Console.WriteLine("Is this the correct task?");
Console.WriteLine(TO_DO[comple-1]);
Console.WriteLine("<y or n>");
string? answer = Console.ReadLine();
if (answer=="y"){
    Complete.Add(TO_DO[comple-1]+" "+ DateTime.Now);
    TO_DO.RemoveAt(comple-1);
    Console.WriteLine("Cograts on completeing the task!!!");
    ye=false;
}
}
}
void removing(){
 bool ye = true;
while (ye){
Console.WriteLine("what task you want to remove?");
int w =1;
foreach( string items in TO_DO)
{
    Console.WriteLine($"({w}){items}");
    w++;
}
int comple = int.Parse(Console.ReadLine());
Console.WriteLine("Is this the correct task?");
Console.WriteLine(TO_DO[comple-1]);
Console.WriteLine("<y or n>");
string? answer = Console.ReadLine();
if (answer=="y"){
    TO_DO.RemoveAt(comple-1);
    Console.WriteLine("say goodbye to the task...");
    Console.ReadKey();
    ye=false;
}
}   
}