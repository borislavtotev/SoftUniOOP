
public class Computer extends ElectonicsProduct {

	public Computer(String name, double price, double quantity,
			AgeRestriction restriction) throws Exception {
		super(name, price, quantity, restriction, 24);
	}
	
	@Override 
	public double getPrice() {
		if (this.getQuantity() >= 1000) {
			return super.getPrice()*0.95;
		} else {
			return super.getPrice();
		}		
	}
}
