using GitHubAction;
using Soneta.Business;
using Soneta.Business.UI;
using Soneta.Handel;
using System;

[assembly: Worker(typeof(DokHanWorker), typeof(DokHandlowe))]

namespace GitHubAction
{
	public class DokHanWorker
	{


		// TODO -> Należy podmienić podany opis akcji na bardziej czytelny dla uzytkownika
		[Action("DokHanWorker/ToDo", Mode = ActionMode.SingleSession | ActionMode.ConfirmSave | ActionMode.Progress)]
		public MessageBoxInformation ToDo()
		{

			return new MessageBoxInformation("Czy wykonać operację ?")
			{
				Text = "Opis operacji",
				YesHandler = () => "Operacja została zakończona.",
				NoHandler = () => "Operacja przerwana"
			};


		}
	}


}
