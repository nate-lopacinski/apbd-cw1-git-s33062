
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine("avarage: "+CalculateAverage(numbers));
        
<<<<<<< HEAD
        Console.WriteLine("maximum: "+CalculateMax(numbers));
=======
        Console.WriteLine("max numb: "+CalculateMax(numbers));
>>>>>>> feature-conflict
        
    int CalculateAverage(int[] values)
    {
        return values.Sum() / values.Length;
    }
    
    int  CalculateMax(int[] values)
    {
        return values.Max();
    }
    
    }

        
}