package geometry2D;

import interfaces.AreaMeasurable;
import interfaces.PerimeterMeasurable;

public class Circle extends PlaneShape implements PerimeterMeasurable, AreaMeasurable {
	private double radius;
	
	public Circle(Vertex2D center, double radius) {
		super(center);
		this.setRadius(radius);
	}
	
	public double getRadius() {
		return radius;
	}

	public void setRadius(double radius) {
		this.radius = radius;
	}
	
	@Override
	public String toString() {
		return String.format("Circle(%s, radius = %.2f)", this.vertices.get(0), this.radius);
	}
	
	@Override
	public double getArea() {
		return Math.PI * this.radius * this.radius;
	}

	@Override
	public double getPerimeter() {
		return 2*(Math.PI * this.radius);
	}
}
