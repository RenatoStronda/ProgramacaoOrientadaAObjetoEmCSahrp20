namespace PROJ{
	
	class Program{
		
		public static void Main(string [] args){
			//CalcSE cs = new CalcSE();
			//float x = cs.somar(cs.somar(2,3),2);
           // x = x +1;
            //Qual é o estado do objeto cs ?
			//Console.WriteLine(x);
            Calculadora ca = new Calculadora("Verde");
			Calculadora ca2 = new Calculadora("Azul");
			Calculadora ca3 = new Calculadora("Azul");
			Console.WriteLine(ca.getCor()) ;
			//ca.setCor("Azul");
			Console.WriteLine(ca.getCor()) ;
            Console.WriteLine(ca.somar(2,2));
            Console.WriteLine(ca.somar(2,2));
            Console.WriteLine(ca.somar(2,2));
            //Qual é o estado do objeto ca ?
			/*
			Cadeira c1 = new Cadeira("azul");
			Cadeira c2 = new Cadeira("azul");
			Cadeira c3 = new Cadeira("azul");
			Cadeira c4 = new Cadeira("azul");
			Cadeira c5 = new Cadeira("azul");
			*/
		}

	}
	public class CalcSE{
		public float somar(float v, float v2){
		return v + v2;
		}
	}	
	public class Calculadora{
		private float v1;
		private float v2;

		private string cor;

        public Calculadora(string cor){
            this.cor = cor;
        }
		public float somar(float v1, float v2){
            this.v1 = v2;
			this.v2 = v2;           

		return this.v1 + this.v2;
		}

		public string getCor(){
			return this.cor;
		}

		public void setCor(string cor){
			this.cor = cor;
		}
	}
	public class Cadeira{
		private string cor;


		public Cadeira(string cor){
			this.cor = cor;
		}

		public string getCor(){
			return this.cor;
		}
	}
}