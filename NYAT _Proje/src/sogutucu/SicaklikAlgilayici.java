
package sogutucu;

import java.util.Random;

public class SicaklikAlgilayici implements ISicaklikAlgilayici {
    
    private int sicaklik;
    
        public SicaklikAlgilayici()
        {
            Random rastgele=new Random(); 
            sicaklik=rastgele.nextInt(51);
        }
        
        public int SicaklikGonder()
        {
            return sicaklik;
        }
}
