

using LinQ_Example2;

UniversityManager uM = new UniversityManager();


uM.MaleStudents();
Console.WriteLine("\t\t\t\t\t");
uM.FemaleStudents();
Console.WriteLine("\t\t\t\t\t");
uM.SortStudent();

/*
Console.WriteLine("Insert University ID");
var x = Convert.ToInt32(Console.ReadLine());
uM.AllStudentsFromAnyUni(x);


//v1 sorting
int[] someInts = { 30, 4, 12, 6, 215 };
IEnumerable<int> sortedInts = from i in someInts orderby i select i;
IEnumerable<int> reversedInts = sortedInts.Reverse();

foreach (int i in reversedInts)
{
    Console.WriteLine(i);
}


//v2 sorting

IEnumerable<int> reverseSortedints = from i in reversedInts orderby i descending select i;

foreach (int i in reverseSortedints)
{
    Console.WriteLine(i);
}
*/

uM.StudentAndUniverSityNameCollection();


Console.ReadKey();