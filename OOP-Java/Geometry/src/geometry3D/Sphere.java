package geometry3D;

import interfaces.AreaMeasurable;
import interfaces.VolumeMeasurable;

public class Sphere extends SpaceShape implements AreaMeasurable, VolumeMeasurable {
	private double radius;

	public Sphere(Vertex3D v1, double radius) {
		super(v1);
		this.radius = radius;
	}

	public double getRadius() {
		return radius;
	}

	public void setRadius(double radius) {
		this.radius = radius;
	}
	
	@Override
	public String toString() {
		return String.format("Sphere(%s, radius = 	%.2f)", this.vertices.get(0), 
				this.radius);
	}
	
	@Override
	public double getArea() {
		return 4*Math.PI*this.radius*this.radius;
	}
	
	@Override
	public double getVolume() {
		return 4/3*Math.PI*this.radius*this.radius*this.radius;
	}
}
