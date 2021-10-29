namespace classes.heranca
{
    public class ponto3d : ponto
    {
        public int z;

        public ponto3d(int x, int y, int z) : base(x,y)
        {
            this.z = z;
            CalcularDistancia();
            
        
        }

        public static void calcular()
        {

        }

        public override void CalcularDistancia3() // ele tem o poder de sobrescrever o metodo da classe ponto
        {
          base.CalcularDistancia3();
        }
    }
}