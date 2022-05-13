package sogutucu;

import java.util.ArrayList;
import java.util.List;

public class Publisher implements ISubject{
	
    private List<IObserver> kullanicilar ;
 
    public Publisher(List<IObserver> kullanicilar) {
		super();
		this.kullanicilar = kullanicilar;
	}

	@Override
    public void attach(IObserver subscriber) {
        kullanicilar.add(subscriber);
    }

    @Override
    public void detach(IObserver subscriber) {
        kullanicilar.remove(subscriber);
    }

    @Override
    public void notify(String mesaj) {
        for(IObserver subscriber: kullanicilar) {
            subscriber.update(mesaj);
        }
    }
}
