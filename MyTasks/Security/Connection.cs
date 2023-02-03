namespace MyTasks.Security
{
	public static class Connection
	{
		private static string _server = @".\SQLEXPRESS";
		private static string _databaseName = "MyTasks";
		private static string _user = "admin";
		private static string _password = "admin";

		public static string Server
		{
			get
			{
				return _server;
			}
		}

		public static string DatabaseName
		{
			get
			{
				return _databaseName;
			}
		}

		public static string User
		{
			get
			{
				return _user;
			}
		}

		public static string Password
		{
			get
			{
				return _password;
			}
		}

	}
}
