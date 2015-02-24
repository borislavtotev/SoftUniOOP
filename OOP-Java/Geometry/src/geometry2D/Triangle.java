package geometry2D;

import interfaces.AreaMeasurable;
import interfaces.PerimeterMeasurable;

public class Triangle extends PlaneShape implements PerimeterMeasurable, AreaMeasurable {
	public Triangle(Vertex2D v1, Vertex2D v2, Vertex2D v3) {
		super(v1, v2, v3);
	}
	
	@Override
	public String toString() {
		return String.format("Triangle(%s, %s, %s)", this.vertices.get(0), 
							this.vertices.get(1), this.vertices.get(2));
	}
	
	@Override
	public double getArea() {
		double a = getSizeA();
		double b = getSizeB();
		double c = getSizeC();
		double p = (a+b+c)/2;
		return Math.sqrt(p*(p-a)*(p-b)*(p-c));
	}

	private double getSizeC() {
		return Vertex2D.CalculateDistance((Vertex2D)this.vertices.get(0), (Vertex2D)this.vertices.get(2));
	}

	private double getSizeB() {
		return Vertex2D.CalculateDistance((Vertex2D)this.vertices.get(1), (Vertex2D)this.vertices.get(2));
	}

	private double getSizeA() {
		return Vertex2D.CalculateDistance((Vertex2D)this.vertices.get(0), (Vertex2D)this.vertices.get(1));
	}

	@Override
	public double getPerimeter() {
		double a = getSizeA();
		double b = getSizeB();
		double c = getSizeC();
		return a+b+c;
	}
}
