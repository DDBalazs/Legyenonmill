namespace milliomos
{
    internal class Kerdes
    {
        public string kerd;
        public string Aop;
        public string Bop;
        public string Cop;
        public string Dop;
        public string helyes;

        public Kerdes(string sor)
        {
            var dbok = sor.Split(";");
            this.kerd = dbok[0];
            this.Aop = dbok[1];
            this.Bop = dbok[2];
            this.Cop = dbok[3];
            this.Dop = dbok[4];
            this.helyes = dbok[5];
        }

    }
}