//Dictionary

/*Dictionary<int, string[]> Dictionary = new();

Dictionary.Add(1, new string[] {"Value1", "Value2", "Value3"});
Dictionary.Add(2, new string[] {"Value4", "Value5"});

foreach(var item in Dictionary){
    Console.WriteLine("Key: {0}, Value: {1}", item.Key, string.Join(", ", item.Value));
}*/

public class MyDictionary{

    private Dictionary<int, string[]> Dictionary;

    public MyDictionary(){
        Dictionary = new Dictionary<int, string[]>();
    }

    public void Add(int key, string[] values){
        Dictionary.Add(key, values);
    }

    public void Print(){
        foreach(var item in Dictionary){
            Console.WriteLine("Key: {0}, Value:{1} ", item.Key, string.Join(" , ", item.Value));
        }
    }
}

class Program{

    static void Main(string[] args){
    
    MyDictionary myDictionary = new MyDictionary();

    myDictionary.Add(1, new string[] {"Value1", "Value2", "Value3"});
    myDictionary.Add(2, new string[] {"Value4", "Value5"});

    myDictionary.Print();

    }

}