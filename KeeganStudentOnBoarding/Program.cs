public class Node
{
  public Node next;
  public string StudentName;
}

public class LinkedList
{
  private Node head;

  public void print()
  {
    Node current = head;
    while (current != null)
    {
      Console.WriteLine(current.StudentName);
      current = current.next;
    }
  }

  public void Append(string data)
  {
    if (head == null)
    {
      head = new Node();

      head.StudentName = data;
      head.next = null;
    }
    else
    {
      Node toAdd = new Node();
      toAdd.StudentName = data;

      Node current = head;
      while (current.next != null)
      {
        current = current.next;
      }

      current.next = toAdd;
    }
  }
}

class Program
{
  public static LinkedList studentList;

  static void Main(string[] args)
  {
    studentList = new LinkedList();
    MainMenu();

    Console.ReadLine();
  }

  static void MainMenu()
  {
    Console.Clear();
    Console.WriteLine("Welcome to the student Enrollment portal!");
    Console.WriteLine($"Please select one function: ");
    Console.WriteLine($"1 | Add a student Name");
    Console.WriteLine($"2 | View All Students");
    Console.WriteLine($"3 | Remove a student");
    Console.WriteLine($"X | Close Application");

    ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

    switch (keyInfo.KeyChar)
    {
      case '1':
        AddStudent();
        break;
      case '2':
        ViewAllStudents();
        break;

      case 'X':
        Environment.Exit(0);
        break;

      default:
        MainMenu();
      break;
    }
  }

  static void AddStudent()
  {
    Console.Clear();
    Console.WriteLine("Add a new student!");
    Console.WriteLine("Student Name:");
    string sStudentName = Console.ReadLine();
    studentList.Append(sStudentName);
    Console.WriteLine($"{sStudentName} has been added to the system.");
    Console.WriteLine("Press any key return to the main menu");

    Console.ReadKey();
    MainMenu();
  }

  static void ViewAllStudents()
  {
    Console.Clear();
    Console.WriteLine("Here is the full student list");
    studentList.print();
    Console.WriteLine("Press any key return to the main menu");

    Console.ReadKey();
    MainMenu();
  }
}