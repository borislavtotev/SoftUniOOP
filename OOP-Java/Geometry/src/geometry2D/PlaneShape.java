package geometry2D;
import interfaces.AreaMeasurable;
import interfaces.PerimeterMeasurable;
import main.Shape;

public class PlaneShape extends Shape implements PerimeterMeasurable, AreaMeasurable {

	public PlaneShape(Vertex2D... vertices) {
		super(vertices);
	}

	@Override
	public double getArea() {
		return 0;
	}

	@Override
	public double getPerimeter() {
		return 0;
	}
	
}
