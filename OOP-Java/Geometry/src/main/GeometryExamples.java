package main;
import interfaces.VolumeMeasurable;

import java.util.Arrays;
import java.util.List;

import geometry2D.Circle;
import geometry2D.PlaneShape;
import geometry2D.Rectangle;
import geometry2D.Triangle;
import geometry2D.Vertex2D;
import geometry3D.Cuboid;
import geometry3D.SpaceShape;
import geometry3D.Sphere;
import geometry3D.SquarePyramid;
import geometry3D.Vertex3D;


public class GeometryExamples {
	public static void main(String[] args) {
		Triangle t = new Triangle(
				new Vertex2D(2.3, 3.5),
				new Vertex2D(3.4, 3.6),
				new Vertex2D(4.2, 5));
		
		System.out.println(t);
		System.out.println(t.getPerimeter());
		System.out.println(t.getArea());
		
		Rectangle r = new Rectangle(
				new Vertex2D(5.7, 3.5),
				12,
				8);
		
		System.out.println(r);
		System.out.println(r.getPerimeter());
		System.out.println(r.getArea());
		
		Circle c = new Circle(
				new Vertex2D(-2, 3),
				4);
		
		System.out.println(c);
		System.out.println(c.getPerimeter());
		System.out.println(c.getArea());
		
		
		System.out.println();
		Cuboid cuboid = new Cuboid(
				 new Vertex3D(2, 3, 4),
				 3,
				 6,
				 5);
		System.out.println(cuboid);
		System.out.println(cuboid.getArea());
		System.out.println(cuboid.getVolume());
		
		Sphere s  = new Sphere(
				new Vertex3D(2,1,-2), 
				4);
		System.out.println(s);
		System.out.println(s.getArea());
		System.out.println(s.getVolume());		
		
		SquarePyramid pyramid = new SquarePyramid(
				new Vertex3D(3, 3.4, 5),
				4, 
				6);
		System.out.println(pyramid);
		System.out.println(pyramid.getArea());
		System.out.println(pyramid.getVolume());
		
		List<Shape> myShapes = Arrays.asList(t, r, c, cuboid, s, pyramid);
		
		for (Shape shape : myShapes) {
			System.out.println(shape);
		}
		
		System.out.println();
		
		System.out.println("Print all shapes with volume greater than 40:");
		myShapes.stream()
			.filter(shape -> shape instanceof VolumeMeasurable)
			.filter(shape -> ((SpaceShape) shape).getVolume()>40)
			.forEach(System.out::println);
		
		System.out.println();
		
		System.out.println("Print PlaneShapes by paremeter:");
		myShapes.stream()
			.filter(shape -> shape instanceof PlaneShape)
			.sorted((s1, s2) -> (int)(((PlaneShape)s1).getPerimeter() - (((PlaneShape)s2).getPerimeter())))
			.forEach(System.out::println);		
	}
}
