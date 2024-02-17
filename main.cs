using System;

class Program {
  public static void Main (string[] args) {

    int m = 30;

    string[] value = new string [m];

    for (int i = 1; i <= m; i++) {

      if (i % 3 == 0 && i %  5 == 0)
      {
        value [i - 1] = ($"{i} - FooBar");
      }
      else if ( i % 3 == 0)
      {
        value [ i - 1] = ($"{i} - Foo");
      }
      else if ( i % 5 == 0)
      {
        value [i - 1] = ($"{i} - Bar");
      }
      else
      {
        value [i - 1] = i.ToString();
      }
  }

    foreach (string values in value)
    {
      Console.WriteLine(values);
    }
}
  }