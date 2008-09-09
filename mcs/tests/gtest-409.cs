using System;

//
// Parser conditional expression tests
//

public class ConditionalParsing
{
	class T
	{
		public T (string path, bool mode)
			: this (path, mode, (mode == true ? 1 : 2), 1, int.MaxValue)
		{
		}
		
		public T (string s, bool m, int i, int i2, int i3)
		{
		}
	}
	
	struct S
	{
	}
	
	void Test_1 (bool a)
	{
		int? b = a ? 3 : 4;
	}
	
	void Test_2 ()
	{
		string mp = "";
		int a = 1;
		int _provider = mp.Length == a ? _provider = 4 : 5;
	}
	
	T? Test_3<T> (Func<T, T, T> result, T t) where T : struct
	{
		return new T? (result (t, t));
	}
	
	void Test_4 (bool x, bool y)
	{
		int s = x ? (y ? 2 : 4) : (y ? 5 : 7);
	}
	
	void Test_5 (bool a, IDisposable fs)
	{
		using (a ? fs : null) {
			Console.WriteLine ("");
		}
	}
	
	void Test_6 (bool a)
	{
		char[] escaped_text_chars =
			a != false ?
			new char [] {'&', '<', '>', '\r', '\n'} :
			new char [] {'&', '<', '>'};
	}
	
	void Test_7 (object o)
	{
		object a = (S?[]) o;
	}

	public static void Main ()
	{
	}
}

