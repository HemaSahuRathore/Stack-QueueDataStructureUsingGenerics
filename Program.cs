namespace StackNQueueUsingGenerics
{ /// <summary>
  /// UC 1 : Ability to create a Stack of 56->30->70
  /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;

            Console.WriteLine("Welcome to Stack & Queue Data Structure"); //display welcome msg
            do
            {
                Console.WriteLine("\nPlease select the Options from Below Use case to execute: ");
                Console.WriteLine("1.Create a Stack of 56->30->70");
                Console.WriteLine("2.Peak and Pop from the Stack till it is empty 56->30->70");
                Console.Write("3.Exit  ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Stack<int> stack = new Stack<int>();
                        stack.Push(56);
                        stack.Push(30);
                        stack.Push(70);
                        stack.Display();
                        break;
                    case 2:
                        Stack<int> stackObj = new Stack<int>();
                        stackObj.Push(56);
                        stackObj.Push(30);
                        stackObj.Push(70);
                        Console.WriteLine("Is stack Empty : " + stackObj.IsEmpty());
                        Console.WriteLine();
                        break;

                }
            } while (option != 3);

        }
    }
}