#region Arrays

#endregion
#region MainProgramm
void CheckIfValid()
{
   if (args.Length == 0 || args.Length > 1) { System.Console.WriteLine("There where no agruments given"); }
   for (int i = 0; i < args.Length; i++)
   {

      if (char.IsLetter(args[0][i]) == true)
      {
         System.Console.WriteLine("The argument is not valid. Please don't use letters. This Feature will be added in the furture");
      }
   }
   SegmentsCounter(args);
}


int SegmentsCounter(string[] args)
{

   int Sections = 0;
   int Teleporter = 0;
   

   for (int i = 0; i < args[0].Length;)
   {
      if (char.IsDigit(args[0][i]) == true)
      {
         string CheckIfNumberIsAhead = args[0].Substring(i, 4);
         string CheckHex = args[0].Substring(i, 2);
         if(CheckHex == "0x")
         {
            string SubstringHelper = args[0].Substring(i, 6);
            Teleporter++;
            i = Convert.ToInt32(SubstringHelper, 16);
         }
         
         else if (CheckIfNumberIsAhead.Contains("<") || CheckIfNumberIsAhead.Contains(">"))
         {
            string CheckIfNumberISBehind = args[0].Substring(i - 3, 4);
            CheckIfNumberISBehind.TrimStart('0');
            int BehindHelper = int.Parse(CheckIfNumberISBehind);
            i = BehindHelper;
            Teleporter++;
         }
         else
         {
            CheckIfNumberIsAhead.TrimStart('0');
            int intHelper = int.Parse(CheckIfNumberIsAhead);
            i = intHelper;
            Teleporter++;
         }
      }


      else if (args[0][i] == '>')
      {
         i++;
         Sections++;
      }
      else if (args[0][i] == '<')
      {
         i--;
         Sections++;
      }
      
   }
   System.Console.WriteLine("Sections: " + Sections);
   System.Console.WriteLine("Teleporter: " + Teleporter);
   return 1;
}

{

}

#endregion
CheckIfValid();
