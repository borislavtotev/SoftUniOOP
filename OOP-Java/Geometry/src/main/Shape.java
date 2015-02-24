package main;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;


public abstract class Shape {
	
	protected List<Vertex> vertices;
	
	public Shape(Vertex... vertices) {
		this.setVertices(new ArrayList<Vertex>(Arrays.asList(vertices)));
	}

	public List<Vertex> getVertices() {
		return vertices;
	}

	public void setVertices(List<Vertex> vertices) {
		this.vertices = vertices;
	}
}
