class Bai1{
    public static int tinhTongSoLon50(List<int>numbers){
        int sum =0;
        foreach(int n in numbers){
            if(n >50){
                sum += n;
            }
        }
        return sum;
    }
}
