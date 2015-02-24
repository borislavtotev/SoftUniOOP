
public class Appliance extends ElectonicsProduct {

	public Appliance(String name, double price, double quantity, 
			AgeRestriction restriction) throws Exception {
		super(name, price, quantity, restriction, 6);
	}
	
	@Override 
	public double getPrice() {
		if (this.getQuantity() < 50) {
			return super.getPrice()*1.05;
		} else {
			return super.getPrice();
		}		
	}
}