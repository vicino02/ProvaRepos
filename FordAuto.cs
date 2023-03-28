using System;

public class Class1
{

	string id = "";


	public Class1()
	{

		Console.WriteLine("la tua auto risulta creata");
	
			MessageBox.Show("id validato");
			if (id=="n.vicino")
			{
				MessageBox.Show("id valido, accesso consentito");
			}
			else
			{
               MessageBox.Show("id non valido,riprova");
            }
		}


	}
}
