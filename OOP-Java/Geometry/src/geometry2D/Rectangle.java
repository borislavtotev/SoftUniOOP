package geometry2D;
import interfaces.AreaMeasurable;
import interfaces.PerimeterMeasurable;


public class Rectangle extends PlaneShape implements PerimeterMeasurable, AreaMeasurable {
	private double width;
	private double height;
	
	public Rectangle(Vertex2D v1, double width, double height) {
		super(v1);
		this.setHeight(height);
		this.setWidth(width);
	}
	
	public double getHeight() {
		return height;
	}

	public void setHeight(double height) {
		this.height = height;
	}

	public double getWidth() {
		return width;
	}

	public void setWidth(double width) {
		this.width = width;
	}
	
	@Override
	public String toString() {
		return String.format("Rectangle(%s, width = %.2f, height = %.2f)", this.vertices.get(0), 
				this.width, this.height);
	}
	
	@Override
	public double getArea() {
		return this.width * this.height;
	}

	@Override
	public double getPerimeter() {
		return 2*(this.width + this.height);
	}
}
