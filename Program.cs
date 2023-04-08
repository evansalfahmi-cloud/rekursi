//contoh program rekursif

using System ; 

class reKursi {
    public int hitungPangkat (int n , int e){
        if (e==0){
            return 1;
        }else {
            return n * hitungPangkat (n, e-1);
        }
    }
}

class demoRekursi {
    static void Main (){
        reKursi obj = new reKursi ();

        int bilangan = 2;

        //memanggil metode rerkursi
        for (int i = 0 ; i < 10 ; i ++){
            Console.WriteLine (bilangan + " ^ "+ i + " = " + obj.hitungPangkat(bilangan, i)); //2 pangkat i
        }
        
    }
}