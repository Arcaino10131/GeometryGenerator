using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace GeometryGenerator
{
    public class Triangle
    {
        private GeometryModel3D triangle = new GeometryModel3D();
        private MeshGeometry3D preMesh = new MeshGeometry3D();
        private Point3DCollection points = new Point3DCollection(3);
        private Int32Collection triangleIndices = new Int32Collection(3);
        private DiffuseMaterial materialF = new DiffuseMaterial(new SolidColorBrush(Color.FromRgb(0, 0, 0))), materialB = new DiffuseMaterial(new SolidColorBrush(Color.FromRgb(255, 0, 0)));

        //Constructors still have to finish one
        #region
        public Triangle()
        {
            //Setting Material
            triangle.Material = materialF; triangle.BackMaterial = materialB;
            //Setting der positions of every Vertex
            points.Add(new Point3D(0, 0, 0));
            points.Add(new Point3D(0, 5, 0));
            points.Add(new Point3D(-5, 0, 0));
            //Setting the triangle Indices
            for (int i = 0; i < 3; i++)
            {
                triangleIndices.Add(i);
            }
            //Assigning points and indices to the premesh
            preMesh.Positions = points;
            preMesh.TriangleIndices = triangleIndices;
            //Assigning the premesh as the triangles geometry
            triangle.Geometry = preMesh;
        }

        public Triangle(Point3D a, Point3D b, Point3D c)
        {
            
        }
        #endregion

        //Material Properties Finished
        #region
        public DiffuseMaterial MaterialF
        {
            get { return materialF;}
            set { materialF = value;}
        }

        public DiffuseMaterial MaterialB
        {
            get { return materialB;}
            set { materialB = value;}
        }
        #endregion

        //Functions Transform functions dont work
        #region
        

        public GeometryModel3D ToGeometryModel3D()
        {
            return triangle;
        }

        public void Translate(int x, int y,int z)
        {
            TranslateTransform3D translateTransform3D = new TranslateTransform3D(x, y, z);
            preMesh = (MeshGeometry3D)triangle.Geometry;
            Point3D[] pointArr = new Point3D[preMesh.Positions.Count];
            int counter = 0;
            foreach(Point3D point3D in preMesh.Positions)
            {
                if(counter > preMesh.Positions.Count)
                {
                    break;
                }
                pointArr[counter] = point3D;
                counter += 1;
            }
            points = new Point3DCollection(preMesh.Positions.Count);
            foreach(Point3D point3D in pointArr)
            {
                points.Add(point3D);
            }
            preMesh.Positions = points;
            triangle.Geometry = preMesh;
        }

        public void Scale(int scale)
        {
            ScaleTransform3D scaleTransform3D = new ScaleTransform3D(scale, scale, scale);
            preMesh = (MeshGeometry3D)triangle.Geometry;
            Point3D[] pointArr = new Point3D[preMesh.Positions.Count];
            int counter = 0;
            foreach (Point3D point3D in preMesh.Positions)
            {
                if (counter > preMesh.Positions.Count)
                {
                    break;
                }
                pointArr[counter] = point3D;
                counter += 1;
            }
            points = new Point3DCollection(preMesh.Positions.Count);
            foreach (Point3D point3D in pointArr)
            {
                points.Add(point3D);
            }
            preMesh.Positions = points;
            triangle.Geometry = preMesh;
        }

        public void Scale(int x, int y, int z)
        {
            ScaleTransform3D scaleTransform3D = new ScaleTransform3D(x,y,z);
            preMesh = (MeshGeometry3D)triangle.Geometry;
            Point3D[] pointArr = new Point3D[preMesh.Positions.Count];
            int counter = 0;
            foreach(Point3D point3D in preMesh.Positions)
            {
                if(counter > preMesh.Positions.Count)
                {
                    break;
                }
                pointArr[counter] = point3D;
                counter += 1;
            }
            points = new Point3DCollection(preMesh.Positions.Count);
            foreach(Point3D point3D in pointArr)
            {
                points.Add(point3D);
            }
            preMesh.Positions = points;
            triangle.Geometry = preMesh;
        }

        #endregion
    }
}
