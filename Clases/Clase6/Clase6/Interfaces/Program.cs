using System.Diagnostics.Contracts;

public interface I2DmedidasCalculable
{
    double Area();
    double Perimetro();
}

public interface I3DmedidasCalculable
{
    double Volumen();
}


//CLASE ABSTRACTA: definimos la clase, y cuando se creen otras clases, se van a llevar los métodos obligatoriamente.

public abstract class FiguraGeometria
{
    public abstract double Area();
    public abstract double Perimetro();
}

//CIRCULO
public class Circulo : FiguraGeometria,I2DmedidasCalculable
{
    double radio;
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public override double Area()
    {
        return Math.PI * Math.Pow(this.radio, 2);
        //throw new NotImplementedException();
    }

    public override double Perimetro()
    {
        return 2 * Math.PI * this.radio;
        //throw new NotImplementedException();
    }
}

//RECTANGULO
public class Rectangulo : FiguraGeometria, I2DmedidasCalculable
{
    double base_r, altura_r;

    public Rectangulo(double base_r, double altura_r)
    {
        this.base_r = base_r;
        this.altura_r = altura_r;
    }

    public override double Area()
    {
        return this.base_r * this.altura_r;
    }

    public override double Perimetro()
    {
        return 2 * this.base_r * 2 * this.altura_r;
    }
}


//CUBO
public class Cubo : FiguraGeometria, I2DmedidasCalculable, I3DmedidasCalculable
{
    double lado;
    public Cubo(double lado)
    {
        this.lado = lado;
    }

    public override double Area()
    {
        return 6 * Math.Pow(lado, 2);
    }

    public override double Perimetro()
    {
        return 12 * lado;
    }

    public double Volumen()
    {
        return Math.Pow(lado, 3);
    }
}



public class Program
{
    static void Main(string[] args)
    {
        //interfaces
        Cubo cubo = new(1);
        Rectangulo rectangulo = new Rectangulo(2, 2);
        Circulo circulo = new(2);

        Console.WriteLine("Volumen Cubo:" + cubo.Volumen() +
            "\nPerimetro rectangulo:" + rectangulo.Perimetro() +
            "\nArea Circulo:" + circulo.Area());
    }
}
