import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Arrays;
import java.util.List;

public class OneLevShopExamples {
	public static void main(String[] args) throws ParseException, Exception {
		SimpleDateFormat myFormat = new SimpleDateFormat("dd MM yyyy");
		
		FoodProduct food1 = new FoodProduct(
											"beer", 
											1.15,
											1.2,
											AgeRestriction.Adult,
											myFormat.parse("5 03 2015"));
		
		//System.out.println(food1.getPrice());
		
		FoodProduct cigars = new FoodProduct("420 Blaze it fgt", 6.90, 1400, AgeRestriction.Adult, myFormat.parse("5 03 2018"));
		Customer pecata = new Customer("Pecata", 17, 30.00);
		
		try {
			PurchaseManager.processPurchase(cigars, pecata);			
		} catch (Exception e) {
			System.out.println(e.getMessage());
		}

		Customer gopeto = new Customer("Gopeto", 18, 0.44);
		
		try {
			PurchaseManager.processPurchase(cigars, gopeto);			
		} catch (Exception e) {
			System.out.println(e.getMessage());
		}
		
		List<Product> myProducts = Arrays.asList(
				food1, 
				cigars,
				new Computer("Dell Inspiron", 1260, 12, AgeRestriction.None),
				new Appliance("Phone", 123, 2, AgeRestriction.None),
				new FoodProduct("Vodka", 6.7, 4, AgeRestriction.Adult, myFormat.parse("2 03 2015")),
				new FoodProduct("Rakia", 7.57, 3, AgeRestriction.Adult, myFormat.parse("2 02 2015")),
				new FoodProduct("Brendi", 4.57, 7, AgeRestriction.Adult, myFormat.parse("23 11 2015")),
				new FoodProduct("Boza", 0.89, 123, AgeRestriction.Teenager, myFormat.parse("01 03 2015"))
				);
		
		FoodProduct expiredProduct = (FoodProduct) myProducts.stream()
			.filter(product -> product instanceof Expirable)
			.sorted((p1, p2) -> {
				long time1 = ((FoodProduct)p1).getExpirationDate().getTime();
				long time2 = ((FoodProduct)p2).getExpirationDate().getTime();
				if (time1 < time2) {
					return -1;
				} else if (time1 == time2) {
					return 0;
				} else {
					return 1;
				}
			})
			.findFirst()
			.get();
		
		System.out.println("The product with soonest expiration date is:" + expiredProduct);
		
		System.out.println("The products for adults:");
		myProducts.stream()
			.filter(p -> p.getRestriction() == AgeRestriction.Adult)
			.sorted((p1, p2) -> {
				if (p1.getPrice() > p2.getPrice()) {
					return 1;
				} else if (p1.getPrice() == p2.getPrice()) {
					return 0;
				} else {
					return -1;
				}
			}
			).forEach(System.out::println);;
	}
}
