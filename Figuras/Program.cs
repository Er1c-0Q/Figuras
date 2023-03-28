public abstract class Figura
{
    public int x {get; set;}
    public int y {get; set;}
    public int largo {get; set;}
    public int ancho {get; set;}
    public string? color {get; set;}

    public Figura(int nx, int ny, int l, int a, string c)
    {
        x = nx;
        y = ny;
        largo = l;
        ancho = a;
        color = c;
    }

    public abstract void Dibujar();

    public abstract float Area();
}

class Circulo:Figura
{
    public float diametro{get;set;}

    public Circulo(int nx, int ny, int l, int a, string c, int d): base (nx,ny,l,a,c)
    {
        diametro = d;
    }

    public override void Dibujar()
    {
        System.Console.WriteLine($"Se dibuja un circulo en las cordenadas {x} y {y}");
    }

    public override float Area()
    {
        return MathF.Pow(diametro/2,2)*MathF.PI;
    }
}

class Rectangulo:Figura
{
    public Rectangulo(int nx, int ny, int l, int a, string c): base (nx,ny,l,a,c)
    {
    }

    public override void Dibujar()
    {
        System.Console.WriteLine($"Se dibuja un rectangulo en las cordenadas {x} y {y}");
    }

    public override float Area()
    {
        return (ancho*largo);
    }
}

class Triangulo:Figura
{
    public Triangulo(int nx, int ny, int l, int a, string c): base (nx,ny,l,a,c)
    {
    }

    public override void Dibujar()
    {
        System.Console.WriteLine($"Se dibuja un Triangulo en las cordenadas {x} y {y}");
    }

    public override float Area()
    {
        return (ancho*largo)/2;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Circulo circulo = new Circulo(10,5,20,10,"rojo",20);
        circulo.Dibujar();
        float areac = circulo.Area();
        System.Console.WriteLine($"El area es de {areac}");

        Rectangulo rectangulo = new Rectangulo(4,30,10,10,"rojo");
        rectangulo.Dibujar();
        float arear = rectangulo.Area();
        System.Console.WriteLine($"El area es de {arear}");

        Triangulo triangulo = new Triangulo(40,20,20,50,"rojo");
        triangulo.Dibujar();
        float areat = triangulo.Area();
        System.Console.WriteLine($"El area es de {areat}");
    }
}