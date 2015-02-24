package geometry3D;


public class SquarePyramid extends SpaceShape {
	private double width;
	private double height;
	
	public SquarePyramid(Vertex3D v1, double width, double height) {
		super(v1);
		this.setWidth(width);
		this.setHeight(height);
	}
	
	public double getWidth() {
		return width;
	}

	public void setWidth(double width) {
		this.width = width;
	}

	public double getHeight() {
		return height;
	}

	public void setHeight(double height) {
		this.height = height;
	}

	@Override
	public String toString() {
		return String.format("SquarePyramid(%s, width = %.2f, height = %.2f)", this.vertices.get(0), 
				this.width, this.height);
	}
	
	@Override
	public double getArea() {
		return this.width*this.width + 2*this.width*Math.sqrt(this.width*this.width/4 + this.height * this.height);
	}
	
	@Override
	public double getVolume() {
		return this.width*this.width*this.height/3;
	}
}
