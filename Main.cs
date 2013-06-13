using System;

namespace Reloj
{ 
	class Principal 
	{
		
		
		public void muestraMenu(){
			Console.WriteLine("Elige una opción");
			Console.WriteLine("1.Reloj\n2.Cronometro\n3.salir");	
		}
		
		
		
		public static void Main (string[] args)
		{
		int opcion;
			
		Principal programa = new Principal();
			
			programa.muestraMenu();
			opcion= int.Parse( Console.ReadLine() );
			switch(opcion){
				
			case 1: 	
			for(;;){
					reloj unReloj = new reloj(); //crear un objeto de la clase reloj
				    unReloj.HoraActual();
					}
				break;        
				
			case 2:
					Cronometro unCronometro = new Cronometro();
				    unCronometro.iniciarCronometro();
				break;
				
			
			default: Console.WriteLine("Opcion no valida\nIntente de nuevo");
				break;
			}

		}
		
		
	}
}
