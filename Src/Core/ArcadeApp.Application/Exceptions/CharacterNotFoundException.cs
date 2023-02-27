using System;
namespace ArcadeApp.Application.Exceptions
{
	public class CharacterNotFoundException:Exception
	{
		public CharacterNotFoundException(string message): base(message)
		{

		}

		public CharacterNotFoundException(Exception ex): base(ex.Message,ex)
		{

		}
	}
}

