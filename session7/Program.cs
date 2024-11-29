internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        #region function trong List cua Collection
        //khoi tao mot danh sach 
        List<int> numbers = new List<int>();
        string? n = Console.ReadLine();
        int formatNumber=Convert.ToInt32(n);
        for(int i=0; i< formatNumber; i++){
            Console.WriteLine($"Moi ban nhap so thu {i+1}");
            int number= Convert.ToInt32(Console.ReadLine());
            numbers.Add(number);
        }
        Console.WriteLine("Danh sach phan tu da nhap la:");
        foreach (int number in numbers){
                Console.WriteLine(number);
        }
        // cach 1 dung join
        Console.Write(String.Join(", ", numbers));
        // dung function sort de sap xep phan tu cua mang
        numbers.Sort();
        Console.WriteLine("\nDanh sach phan tu sau khi sap xep la:");
        foreach (int number in numbers){
                Console.WriteLine(number);
        }
        //Dung function Reverse sort de sap xep phan
        numbers.Reverse();
        Console.WriteLine("\nDanh sach phan tu sau khi dao nguoc la:");
       Console.Write(String.Join(",", numbers));
        #endregion

        // #region BAI 1 TINH TONG CAC SO LON HON 50 TRONG MANG
        //     //khai bao 1 list phan tu 
        //     List<int>numbers=new List<int>{20,50,31,75,65,20,100};
        //     //Ket qua cua ham tinhtonglonhon 50 se gan cho bien sum
        //     int sum=Bai1.tinhTongSoLon50(numbers);
        //     Console.WriteLine($"Tong cac so lon hon 50 la: {sum}");

        // #endregion
        #region Bai 2 : tim so lon nhat cua mang
        //giai thuat
        //b1: tim 1 so bat ky trong mang lam so lon ( so dau tien cua mang)
        //b2: duyet mang tu phan tu thu 2 va so sanh voi so dai dien
        //b3: neu so dai dien nho hon phan tu dnag xet -> gan lai
        //b4: nguoc lai -> duyet tiep

       
        int max=Bai2.timmax(numbers);
        Console.WriteLine($"So lon nhat trong mang la: {max}");

        #endregion


        #region Bai 3 tim tat ca nhung chuoi bat dau bang chu m
        List<string> lststring = new List<string>{"banna","apple","orange","mapple"};
        List<string> result=Bai3.findAllStartM(lststring);
        Console.WriteLine("Cac chuoi bat dau bang chu m la:");
        foreach(string str in result){
            Console.WriteLine(str);
        }
        #endregion
        #region 
        //Loai bo cac phan tu trung nhau
        // b1 them phan tu dau tien vao mang moi
        // b2 duyet phan tu thu 2 den het mang
        //-neu phan tu thu i co trong result
        //-neu khong -> them vao result
       
        // List<int>lstNumbers=new List<int>{1,1,2,3,1,2,3}; 
        // List<int> result2=Bai4.uniqueNumber(lstNumbers);
        // Console.WriteLine("Cac phan tu khong trung nhau la");
        // foreach(int num in result2){
        //     Console.WriteLine(num);
        // }
        #endregion
        
        #region Tim hieu ve dictionary
        Dictionary<string, string>dic =new Dictionary<string, string>();
        //Them key-value vao dic
        dic.Add("Alice", "test");
        dic["Do"]="Nam Trung";
        //Duyet dic
        foreach(KeyValuePair<string, string>pointer in dic){
            //pointer :key-value
            Console.WriteLine($"Ho: {pointer.Key}, Ten: {pointer.Value}");
        }
        // chi duyet moi key hoac value => y chang nhu list
        Console.WriteLine($"Danh sach cac key la:");
        foreach (string str in dic.Keys){
            Console.WriteLine(str);
        }

        for(int i=0; i<dic.Keys.Count; i++){
            Console.WriteLine(dic.Keys.ElementAt(i));
        }

        // UPDATE VALUE CHO NC
        dic["Alice"]="Johnson";
        Console.WriteLine("Dic sau khi Update");
        foreach(KeyValuePair<string, string> pointer in dic){
            Console.WriteLine($"Ho: {pointer.Key}, Ten: {pointer.Value}");
        }
        //XOA KEY VALUE CHO DIC
        dic.Remove("Do");
        Console.WriteLine("Dic sau khi xoa");
        foreach(KeyValuePair<string, string> pointer in dic){
            Console.WriteLine($"Ho: {pointer.Key}, Ten: {pointer.Value}");
        }
        #endregion

    }
}