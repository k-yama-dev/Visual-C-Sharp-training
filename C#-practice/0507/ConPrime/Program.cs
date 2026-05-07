Console.WriteLine("Hello, ConPrime");

for(int i=2;i<=100;i++){
    bool n = true;
    for(int j = 2;j<i;j++){
        if(i%j==0){
            n = false;;
        }
    }
    if(n){
        Console.WriteLine(i);
    }
    
}