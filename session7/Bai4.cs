using System.Security.Cryptography.X509Certificates;

class Bai4{
    public static List<int> uniqueNumber(List<int>numbers){
        List<int> result = new List<int>();
        result.Add(numbers.ElementAt(0));
        for(int i=1; i<numbers.Count; i++){
            //C1
            if(result.Contains(i)==false){ //kiem tra co nam trong list 
                result.Add(i);
            //C2: so sanh voi so dang truoc
            if(numbers[i]!=numbers[i-1]){
                result.Add(numbers[i]);
            }

        }
        
    }
        return result;
    }
}
