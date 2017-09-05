using Xamarin.Auth;
using System.Linq;
using System;

namespace Diary.Shared
{
	public class AccountManager
	{
		const string serviceID = "Diary";
		const string pwKey = "password";
		const string kmKey = "keymaterial";
		const string saltKey = "salt";

 		public bool CreateAndSaveAccount (string username, string password)
		{
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return false;

			//TODO
			return true;
		}

		public bool LoginToAccount (string username, string password)
		{
			if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
				return false;

			//TODO
			return true;
		}
	
		public Account GetAccount (string username)
		{
			return GetAccountFromStore (AccountStore.Create (), username);
		}

		Account GetAccountFromStore (AccountStore store, string username)
		{
			if (store == null || username == null)
				return null;

            //TODO
			return null;
		}
	}
}