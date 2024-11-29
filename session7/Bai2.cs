class Bai2{
    public static int timmax(List<int>numbers){
        int max=numbers.ElementAt(0);
        foreach(int number in numbers){
            if(number>max)
                max=number;
        }
        return max;
      
    }
}