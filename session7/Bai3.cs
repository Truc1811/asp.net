class Bai3{
    public static List<string> findAllStartM(List<string> lstString){
        List<string> result = new List<string>(); // khoi tao
        foreach(string str in lstString){
            if(str.Contains("m")==true){
                result.Add(str); // them vao list ket qua
            }
        }
        return result;
    }
}