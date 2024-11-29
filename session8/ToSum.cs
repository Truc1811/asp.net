class ToSum{
    public static List<int> twosum(List<int>lst, int target){
        for (int i = 0; i < lst.Count-1; i++){
            for (int j = i+1; j < lst.Count; j++){
                if (lst[i] + lst[j] == target){
                    return new List<int>{i, j};
                }
            }
        }
        return null;//Khong tim duoc 2 so thi tra ve null
    }


    public static List<int>twoSumDictionary(List<int>lst,int target){
        //Khai bao Dictionary de danh dau tung so trong danh sach list
        Dictionary<int, int> seenNumbers = new Dictionary<int, int>();
        for(int i=0;i<lst.Count;i++){
            int complement = target - lst[i];
            if(seenNumbers.ContainsKey(complement)){
                return new List<int>{seenNumbers[complement], i};
            }
            else{
                seenNumbers.Add(lst[i],i) ;
            }
            
    
    }
    return null;
}

}
