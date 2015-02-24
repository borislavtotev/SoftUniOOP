package geometry2D;
import main.Vertex;


public class Vertex2D extends Vertex {

	public Vertex2D(double x, double y) {
		super(x,y);
	}
	
	public static double CalculateDistance(Vertex2D a, Vertex2D b) {
		double distance = Math.sqrt(Math.pow((a.getX()-b.getX()),2) + 
				Math.pow((a.getY()-b.getY()),2));
		return distance;
	}
	
	@Override
	public String toString() {
		return String.format("(%.2f, %.2f)", this.x, this.y);
	}
}
