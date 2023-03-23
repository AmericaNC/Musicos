abstract class Musico {
    public string Nombre {get;set;}
    public Musico(string Nombre) {
        this.Nombre = Nombre;
    }
    public void Saludar(){
        Console.WriteLine($"Hola, mi nombre es {Nombre}");
    }
    //Con virtual es opcional que el metodo se redefina
    //Un metodo abstacto solo se puede crear en una clase abstracta, no tiene instrucciones/implementacion.
    //Pero hace que se delegue de manera obligatoria a las clases deivadas.
    //Una clase abstracta puede usar referencias unicamnete.
    public abstract void Tocar();
}

//Las clases absatractas no crea objetos solo referencias. Son clases demasiado generales.
class Baterista:Musico {
    public string Bateria {get;set;}

    public Baterista(string Nombre, string Bateria):base(Nombre){
        this.Nombre = Nombre;
        this.Bateria = Bateria;
    }
    public override void Tocar()
    {
        Console.WriteLine($"{Nombre}  esta tocando su {Bateria}");
    }
}


class Bajista:Musico {
    public string Bajo {get;set;}

    public Bajista(string Nombre, string Bajo):base(Nombre){
        this.Nombre = Nombre;
        this.Bajo = Bajo;
    }
    public override void Tocar()
    {
        Console.WriteLine($"{Nombre}  esta tocando su {Bajo}");
    }
}


class Guitarrista:Musico {
    public string Guitarra {get;set;}

    public Guitarrista(string Nombre, string Guitarra):base(Nombre){
        this.Nombre = Nombre;
        this.Guitarra = Guitarra;
    }
    public override void Tocar()
    {
        Console.WriteLine($"{Nombre}  esta tocando su {Guitarra}");
    }
}


class Program
{
    private static void Main(string[] args)
    {
        List<Musico> GreenDay = new List<Musico>();
        GreenDay.Add(new Guitarrista("Billie Joe Armstrong", "Yamha"));
        GreenDay.Add(new Guitarrista("Mike Dimit", "Yamaha"));
        GreenDay.Add(new Bajista("Sean Hughes", "MusicMan"));
        GreenDay.Add(new Baterista("Tre Cool", "Mapex")); 
        GreenDay.Add(new Baterista("Raj Punjabi", "Pearl")); 
        GreenDay.Add(new Baterista("Al Sobrante", "Tama")); 
       
        foreach(var musico in GreenDay){
            musico.Saludar();
        } 
                  
        foreach(var musico in GreenDay){
            musico.Tocar();
        } 
    }
}