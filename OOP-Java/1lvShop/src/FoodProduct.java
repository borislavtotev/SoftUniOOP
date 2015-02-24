import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.concurrent.TimeUnit;


public class FoodProduct extends Product implements Expirable {

	private Date expirationDate;
	
	public FoodProduct(String name, double price, double quantity, 
			AgeRestriction restriction, Date expirationDate) throws Exception {
		super(name, price, quantity, restriction);
		this.setExpirationDate(expirationDate);
	}

	@Override
	public Date getExpirationDate() {
		return this.expirationDate;
	}

	public void setExpirationDate(Date date) throws Exception {
		if (!(date instanceof Date)) {
			throw new Exception("Invalid expiration date!");
		}
		
		this.expirationDate = date;
	}
	
	@Override 
	public double getPrice() {
		if (this.expireIn15Days()) {
			return super.getPrice()*0.7;
		} else {
			return super.getPrice();
		}		
	}
	
	private boolean expireIn15Days() {
		Date now = new Date();
		long diff = this.getExpirationDate().getTime() - now.getTime();
		long days = TimeUnit.DAYS.convert(diff, TimeUnit.MILLISECONDS);
		
		if (days <= 15) {
			return true;
		} else {
			return false;
		}
	}
	
	@Override
	public String toString() {
		SimpleDateFormat dateFormat = new SimpleDateFormat("dd/MM/yyyy");
		return super.toString() + "Expiration Date: " + dateFormat.format(this.getExpirationDate());
	}
}
