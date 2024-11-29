class WordCount{
    public static Dictionary<string,int>wordcount(List<string> words){
        Dictionary<string,int>count=new Dictionary<string, int>();
        //C1 : duyet for theo index
        for(int i=0;i<words.Count;i++){
            if(count.ContainsKey(words[i])){
                count[words[i]]++;// tu nay xuat hien nhieu lan
            }
            else{
                count[words[i]]=1;// tu nay xh 1 lan
            }
        }
            //C2 : duyet for theo tung item
        foreach(string word in words){
            if(count.ContainsKey(word)){
                count[word]++;
            }
            else{
                count[word]=1;
            }
        }
        return count;
    }
}