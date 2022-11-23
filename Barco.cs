class Barco
{
    private string nombre{get;set;}
    private int capacidad1{get;set;}
    private int capacidad2{get;set;}

    public Barco(string nombre, int capacidadS, int capacidad1){
        this.nombre=nombre;
        this.capacidad1=capacidad1;
        this.capacidad2=capacidad2;
    }

    public void ImprimirBarco(){
        Console.WriteLine("Nombre: "+nombre);
        Console.WriteLine("Capacidad de pasajeros: "+capacidad1);
        Console.WriteLine("Capacidad de carga: "+capacidad2+" kg");
    }
}
