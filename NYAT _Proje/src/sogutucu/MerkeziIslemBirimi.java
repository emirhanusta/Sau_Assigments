
package sogutucu;

public class MerkeziIslemBirimi {
	
	public MerkeziIslemBirimi() {}
    Eyleyici eyleyici = new Eyleyici();
   
   
    private boolean acikmi=false;
    
    
    public void AcmaIstegiGonder()
    {
        eyleyici.SogutucuyuAc(acikmi);
        acikmi=true;
    }
    
      
    public void KapamaIstegiGonder()
    {
        eyleyici.SogutucuyuKapat(acikmi);
        acikmi=false;
    }
}
