// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
internal class Progra
{
    private static void Main(string[] args)
    {
        Barco barco1=new Barco("Tercero A",10,30000);
        barco1.ImprimirBarco();
        Gps GPS1 =new Gps("8.24.54","9.23.21","18/11/2022",30,"09:00");

        marinero marinero1=new marinero("Yender","0961166837","1303753618",25,10,"M","MARIA DE JESUS",1000);
        marinero marinero2=new marinero("David","0974935286","1706172648",19,10,"M","MARIA DE JESUS",2000);
        marinero marinero3=new marinero("Bryan","0936285438","1704997012",30,10,"M","MARIA DE JESUS",1500);
        marinero marinero4=new marinero("Salazar","0963829432","1715241434",23,10,"M","MARIA DE JESUS",1000);

        Jefe jefe1=new Jefe("pedro","09876525","131658993",38,10,"M","MARIA DE JESUS",50,100);
        Jefe jefe2=new Jefe("tifany","098765710","1316589107",30,10,"F","MARIA DE JESUS",500,150);

        Capitan capitan1=new Capitan("kevin","1316819885","0983733654",19,2,"M","El Perla Negra",4380);
        

        List<tripulante> tripulantes = new List<tripulante>();
        tripulantes.Add(marinero1);
        tripulantes.Add(marinero2);
        tripulantes.Add(marinero3);
        tripulantes.Add(marinero4);

        tripulantes.Add(jefe1);
        tripulantes.Add(jefe1);

        tripulantes.Add(capitan1);

        foreach(tripulante item in tripulantes)
        {
            Console.WriteLine("El tripulante con los datos: ");
            item.Imprimir();

            Console.WriteLine("Tiene un sueldo total de: "+item.Sueldo());         
        }
    }
}
