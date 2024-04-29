public class StackElement
{
    public string Value { get; set; }
    public StackElement Next { get; set; }



} 
 
public class publicStack{
    StackElement? top = null;
    public void push(string value){
        StackElement newElement = new StackElement();
        newElement.Value = value;
        newElement.Next = top;
        top = newElement;
    }



}

 
 // stack de mai sus - sa completezi cu metoda pop si count si tot 
 // updatez stack-ul ca-n loc de string sa fie de tip generic
 
// dictionar - de definit structura; de folosit array-uri

//oop -> pb de interviu; clase + legatura intre clase pt un lift (buton, etc) ai sa mearga cu la mai multe cladiri;
// definesc clasele pt tipurile de smart pointers; -> unique_ptr, shared_ptr, weak_ptr; -> sa le definesc -> au alte denumiri in c# 
// pb  practice in interviuri de algoritmi si de structuri de date;

//iterator generic pt ambele- stack si dictionar (interfata si implementez pt ambele structuri)

// optional: cautat o metoda in care sa updatez stack-ul pt o compexitate mai buna la cautare; indiciu: waitings; -> pot sa iau referinta si elementul din mijloc





 //gresit>
 public class Stack<T>
    {
        private List<T> items;

        public Stack()
        {
            items = new List<T>();
        }

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T item = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return item;
        }

        public int Count
        {
            get { return items.Count; }
        }

        public int IndexOf(T item)
        {
            return items.IndexOf(item);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            while (true)
            {
                Console.WriteLine("Enter an element (or 'exit' to quit):");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                    break;

                stack.Push(input);
            }

            Console.WriteLine("Enter the name of an element to find its index:");
            string element = Console.ReadLine();

            int index = stack.IndexOf(element);

            if (index != -1)
                Console.WriteLine($"The index of '{element}' is {index}");
            else
                Console.WriteLine($"'{element}' was not found in the stack.");
        }
    }