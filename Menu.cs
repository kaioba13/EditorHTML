namespace EditorHTML
{
  public static class Menu
  {
    public static void Show()
    {
      Console.Clear();


      DrawScream();
      WriteOptions();

      var option = short.Parse(Console.ReadLine());
      HandleMenuOption(option);
    }

    public static void DrawScream()
    {
      Console.Write("+");
      for (int i = 0; i <= 30; i++)
      {
        Console.Write("-");
      }
      Console.Write("+");
      Console.Write("\n");

      for (int l = 0; l <= 10; l++)
      {
        Console.Write("|");
        for (int i = 0; i <= 30; i++)
        {
          Console.Write(" ");
        }
        Console.Write("|");
        Console.Write("\n");
      }
      Console.Write("+");
      for (int i = 0; i <= 30; i++)
      {
        Console.Write("-");
      }
      Console.Write("+");
      Console.Write("\n");
    }

    public static void WriteOptions()
    {
      Console.SetCursorPosition(3, 2);
      Console.WriteLine("Editor HTML");

      Console.SetCursorPosition(3, 3);
      Console.WriteLine("============");

      Console.SetCursorPosition(3, 4);
      Console.WriteLine("Selecione uma opção abaixo");

      Console.SetCursorPosition(3, 6);
      Console.WriteLine("1 - Novo arquivo");

      Console.SetCursorPosition(3, 7);
      Console.WriteLine("2 - Abrir");

      Console.SetCursorPosition(3, 9);
      Console.WriteLine("0 - Sair");

      Console.SetCursorPosition(3, 10);
      Console.Write("Opção: ");
    }

    public static void HandleMenuOption(short option)
    {
      switch (option)
      {
        case 1: Editor.Show(); break;
        case 2: Console.WriteLine("Visualizar"); break;
        case 0:
          {
            Console.Clear();
            Environment.Exit(0);
            break;
          }
        default: Show(); break;
      }
    }
  }

}