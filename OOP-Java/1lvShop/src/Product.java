
public class Product implements Buyable {
	protected String name;
	protected double price;
	protected double quantity;
	protected AgeRestriction restriction;
	
	public Product(String name, double price, double quantity, AgeRestriction restriction) throws Exception {
		super();
		this.setName(name);
		this.setPrice(price);
		this.setQuantity(quantity);
		this.setRestriction(restriction);
	}

	public String getName() {
		return name;
	}

	public void setName(String name) throws Exception {
		if (name == null || name == "") {
			throw new Exception("The name can't be empty!"); 
		}
		
		this.name = name;
	}

	public double getPrice() {
		return price;
	}

	public void setPrice(double price) throws Exception {
		if (price <= 0) {
			throw new Exception("The price must be positive number!");
		}
		
		this.price = price;
	}

	public double getQuantity() {
		return quantity;
	}

	public void setQuantity(double quantity) throws Exception {
		if (quantity < 0) {
			throw new Exception("The quantity must be positive numeber!");
		}
		
		this.quantity = quantity;
	}

	public AgeRestriction getRestriction() {
		return restriction;
	}

	public void setRestriction(AgeRestriction restriction) {
		this.restriction = restriction;
	}
	
	@Override
	public String toString() {
		return String.format("Name: %s, Price: %.2f, Quantity: %.2f, AgeRestriction: %s", this.getName(), 
				this.getPrice(), this.getQuantity(), this.getRestriction());
	}
}
