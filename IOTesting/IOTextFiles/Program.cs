using System;

namespace IOTextFiles
{
	class MainClass
	{
		

		public static void Main (string[] args)
		{
			STable _Stable = new STable ();
			IOSettings _io = new IOSettings (_Stable);

			//Console.WriteLine ( _Stable.stable [0] );

			if (_io.open () ) {  //_io.save ()) {
				Console.WriteLine ("Таблицата е прочетене успешно!");
			} else {
				Console.WriteLine ("Таблицата НЕ Е прочетена успешно!");	
			}
			Console.WriteLine ( _Stable.stable [2] );

		}
	}
}
