import java.util.Date;


public class PurchaseManager {
	public static void processPurchase(Product product, Customer customer) throws Exception {
		if (product.getQuantity() < 1) {
			throw new Exception("The product is sold out!");
		}
		
		if (product instanceof Expirable && ((Expirable) product).getExpirationDate().getTime() < new Date().getTime()) {
			throw new Exception("The product is expired!");
		}
		
		if (product.getPrice() > customer.getBalance()) {
			throw new Exception("You do not have enough money to buy this product!");
		}
		
		if (product.getRestriction() == AgeRestriction.Adult && customer.getAge() < 18) {
			throw new Exception("You are too young to buy this product!");
		} else if (product.getRestriction() == AgeRestriction.Teenager && customer.getAge() < 13) {
			throw new Exception("You are too young to buy this product!");
		}
		
		product.setQuantity(product.getQuantity()-1);
		customer.setBalance(customer.getBalance()-product.getPrice());
	}
}
