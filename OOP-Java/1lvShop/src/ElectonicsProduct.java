
public abstract class ElectonicsProduct extends Product {
	private int guaranteePeriod;
	
	public ElectonicsProduct(String name, double price, double quantity,
			AgeRestriction restriction, int guaranteePeriod) throws Exception {
		super(name, price, quantity, restriction);
		this.setGuaranteePeriod(guaranteePeriod);
	}

	public int getGuaranteePeriod() {
		return guaranteePeriod;
	}

	public void setGuaranteePeriod(int guaranteePeriod) {
		this.guaranteePeriod = guaranteePeriod;
	}	
}
