
package sogutucu;


public class Eyleyici {
    
 
    public Eyleyici()
    {}
        
        public void SogutucuyuAc (boolean sayac)
        {
            System.out.println("Sogutucu acik mi kontrol ediliyor...");
                try {
                            Thread.sleep(1000);
                    } catch (InterruptedException e) {
                            e.printStackTrace();
                    }
                if(sayac)
                {
                    System.out.println("Sogutucu zaten acik, isleminizi kontrol ediniz!");
                }
                else
                {
                    System.out.println("Sogutucu aciliyor...");
                    try {
                            Thread.sleep(1000);
                    } catch (InterruptedException e) {
                            e.printStackTrace();
                    }
                     System.out.println("Sogutucu acildi.");
                }
        }
        
        public void SogutucuyuKapat(boolean sayac)
        {
            System.out.println("Sogutucu kapali mi kontrol ediliyor...");
                try {
                            Thread.sleep(1000);
                    } catch (InterruptedException e) {
                            e.printStackTrace();
                    }
                if(!sayac)
                {
                    System.out.println("Sogutucu zaten kapali, isleminizi kontrol ediniz!");
                }
                else
                {
                    System.out.println("Sogutucu kapatiliyor...");
                    try {
                            Thread.sleep(1000);
                    } catch (InterruptedException e) {
                            e.printStackTrace();
                    }
                     System.out.println("Sogutucu kapatildi.");
                }
            
        }
        
    }

   

