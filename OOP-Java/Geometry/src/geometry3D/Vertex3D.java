package geometry3D;
import main.Vertex;


public class Vertex3D extends Vertex {

	private double z;
	
	public Vertex3D(double x, double y, double z) {
		super(x, y);
		this.setZ(z);
	}

	public double getZ() {
		return z;
	}

	public void setZ(double z) {
		this.z = z;
	}

	@Override
	public String toString() {
		return String.format("(%.2f, %.2f, %.2f)", this.x, this.y, this.z);
	}
	
	public static double CalculateDistance(Vertex3D a, Vertex3D b) {
		double distance = Math.sqrt(Math.pow((a.getX()-b.getX()),2) + 
				Math.pow((a.getY()-b.getY()),2) + Math.pow((a.getZ()-b.getZ()),2));
		return distance;
	}
}
