
public class Customer {
	private String name;
	private int age;
	private double balance;
	
	public Customer(String name, int age, double balance) {
		super();
		this.name = name;
		this.age = age;
		this.balance = balance;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) throws Exception {
		if (name == null || name == "") {
			throw new Exception("The name of the customer can't be empty!"); 
		}
		
		this.name = name;
	}

	public int getAge() {
		return age;
	}

	public void setAge(int age) throws Exception {
		if (age <= 0 ) {
			throw new Exception("The age of the customer must be positive number!");
		}
		
		this.age = age;
	}

	public double getBalance() {
		return balance;
	}

	public void setBalance(double balance) {
		this.balance = balance;
	}
}
