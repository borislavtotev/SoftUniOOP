package geometry3D;
import main.Shape;
import interfaces.AreaMeasurable;
import interfaces.VolumeMeasurable;


public class SpaceShape extends Shape implements AreaMeasurable, VolumeMeasurable {

	public SpaceShape(Vertex3D...vertices) {
		super(vertices);
	}

	@Override
	public double getArea() {
		return 0;
	}

	@Override
	public double getVolume() {
		return 0;
	}

}
