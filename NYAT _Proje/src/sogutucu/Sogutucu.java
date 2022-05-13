
package sogutucu;

import java.util.Scanner;

public class Sogutucu {
    

    public void Basla() throws InterruptedException
    {
        
    	boolean dogrulama;

        do {
            Scanner girdi = new Scanner(System.in);
            String kullaniciAdi="";
            String sifre="";
            System.out.println("Sogutucu'ya hosgeldiniz.");
            System.out.print("Kullanici adinizi giriniz:");
            kullaniciAdi=girdi.nextLine();
            System.out.print("Sifrenizi giriniz:");
            sifre=girdi.nextLine();
            
            dogrulama=VeritabaniIslemleri.kullaniciDogrula(kullaniciAdi,sifre);
            if (dogrulama)
            {
                 Agarayuzu arayuz=new Agarayuzu();
            }
            else
            {
                System.out.println("Kullanici dogrulanamadi.");
            }
        }while(!dogrulama);
    
        
}
    }
