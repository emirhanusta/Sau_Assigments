package sogutucu;

public class Kullanici2 implements IObserver{
    @Override

    public void update(String mesaj) {
    	System.out.println("Kullanici2 ye gelen mesaj->" + mesaj);
    }
}
