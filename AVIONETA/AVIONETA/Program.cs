// See https://aka.ms/new-console-template for more information
using AVIONETA;

Console.WriteLine("Hello, World!");
List<object> meusObjetos = new List<object>();

meusObjetos.Add(new Passaros());
meusObjetos.Add(new Plane());
meusObjetos.Add(new Pterodactilo());
meusObjetos.Add(new Ghost());
meusObjetos.Add(new Helicoptero());
meusObjetos.Add(new BeijaFlor());
meusObjetos.Add(new Já_chegou_o_disco_voador_());

Console.WriteLine("Listando os objetos e chamando seus métodos... baseado nas interfaces que eles implementam...");
foreach (object o in meusObjetos)
{
    Console.WriteLine("|  U^I^U  |  (^._.^)/  |  U^I^U  |  (^._.^)/  |  U^I^U  |  (^._.^)/  |");
    Console.WriteLine("O tipo do objeto é: " + o.GetType());
    if (o is Voador)
    {
        Console.WriteLine("O objeto é voador...");
        (o as Voador).decolar();
        (o as Voador).voar();
        (o as Voador).pousar();
    }
    if (o is IPairador)
    {
        Console.WriteLine("O objeto é pairador...");
        (o as IPairador).PararEmPlenoAr();
    }
    if (o is ISer_vivo)
    {
        (o as ISer_vivo).respirar();
        Console.WriteLine("O objeto é um ser vivo...");
        (o as ISer_vivo).comer();
        (o as ISer_vivo).beber();
        (o as ISer_vivo).reproduzir();
        (o as ISer_vivo).Dead();
        (o as ISer_vivo).NF();

    }
    if (o is Maquina)
    {
        Console.WriteLine("O objeto é uma maquina...");
        (o as Maquina).ligar();
        (o as Maquina).EmitirAlerta();
        (o as Maquina).desligar();
    }
    Console.WriteLine("+------+-------+-----+-----+-------+------+------+------+------+------+");
}
