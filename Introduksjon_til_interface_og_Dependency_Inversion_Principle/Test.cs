namespace IntroduksjonTilInterfaceOgDependencyInversionPrinciple
{
    internal class Test
    {

        // Private - endre bare i klassen
        private string _text1 { get; set; }

        private string _text2;


        // Public - kan endre på den utenfor klassen
        public string Text1 { get; private set; }

        // Nå kan du bare 
        public string Text3 { get; }
        
        public string Text2;

        private string _text;


        public string Name { get; private set; }
        
        //    var book1 = new Book();
        //    var name1 = book1.Name;

        private string _name;
        string GetName()
        {
            return _name;
        }
        //    var book1 = new Book();
        //    var name1 = book1.GetName();

    }
}
