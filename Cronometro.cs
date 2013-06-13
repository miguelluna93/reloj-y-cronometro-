using System;

namespace Reloj
{
	public class Cronometro
	{
				int min, seg, mseg; 

		public Cronometro ()
		{
		this.min =00;
		this.seg = 00;
		this.mseg = 00;	
		}
		
		
			public void iniciarCronometro(){
	
        Console.WriteLine("Cronometro");
        while (true)
        {
				Console.WriteLine("{0:D2}:{1:D2}:{2:D2}",min,seg,mseg);		//imprime en pantalla dos numeros 00	
					System.Threading.Thread.Sleep(16);

				
            mseg = mseg + 1;

            if (mseg == 60)
            {
                mseg = 0;
                seg = seg + 1;
                if (seg == 60)
                {
                    seg = 0;
                    min = min + 1;
                    if (min == 60)
                    {
                        min = 0;

                    }
                }
            }	
				Console.Clear();
		}
		
	}
		
	}
	
}
	

	
	


