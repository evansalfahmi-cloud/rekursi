//contoh program rekursif

using System ; 

class reKursi {
    public int hitungFaktorial (int n){
        if (n == 0){
            return 1;
        }else {
            return n * hitungFaktorial(n-1);
        }
    }
}

class demoRekursi {
    static void Main (){
        reKursi obj = new reKursi();

        //memanggil metode hitung faktorial;
        for (int i = 0 ; i <= 10 ; i ++){
            Console.WriteLine(i + "! = "+ obj.hitungFaktorial(i));
        }
    }
}