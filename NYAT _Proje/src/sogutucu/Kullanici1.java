
package sogutucu;


public class Kullanici1 implements IObserver{
   

    @Override

    public void update(String mesaj) {
    	System.out.println("Kullanici1 e gelen mesaj->" + mesaj);
    }
  }

