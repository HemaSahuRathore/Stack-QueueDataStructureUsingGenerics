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
                Console.WriteLine("\nPlease select the Options from Below: ");
                Console.WriteLine("1.Create a Stack of 56->30->70");
                Console.Write("2.Exit  ");
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

                }
            } while (option != 2);

        }
    }
}