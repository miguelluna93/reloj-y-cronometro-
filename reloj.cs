using System;

namespace Reloj
{
	public class reloj
	{
		public reloj ()
		{
			
		}
		
		public void HoraActual(){
		DateTime HoraActual = DateTime.Now;
			for(;;){
        Console.WriteLine(DateTime.Now);
				System.Threading.Thread.Sleep(1000);
				Console.Clear ();
									}
			}
		
	
	}
}

