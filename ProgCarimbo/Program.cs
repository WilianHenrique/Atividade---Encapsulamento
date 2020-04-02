public class Program
{
    public static void Main()
    {

       / instância da classe carimbo /
        Carimbo C = new Carimbo("Aprovado");
        C.carregar("Preto", 2);
        C.usar();

        C.trocarCor("Azul");
        C.usar();


        C.carregar("Preto", 2);
        C.trocarTexto("Recuperação");
        C.usar();
    }
}