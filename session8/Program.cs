internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        List<int> lst=new List<int>{2,7,11,8,15};
        int target = 26;
        Console.WriteLine("Tim 2 so de target la");
        if(ToSum.twosum(lst,target)==null){
            Console.WriteLine("Khong co 2 so cong duoc target");
        }
        else{
            List<int> Indexes = ToSum.twosum(lst,target);
            Console.WriteLine($"chi so 2 so co target la {string.Join(',',Indexes)}");
        }

        if (ToSum.twoSumDictionary(lst, target) == null)
        {
            Console.WriteLine("Khong co 2 so cong duoc target");
        }
        else
        {
            List<int> Indexes = ToSum.twoSumDictionary(lst, target);
            Console.WriteLine($"chi so 2 so co target la {string.Join(',', Indexes)}");
        }

        
    }
}