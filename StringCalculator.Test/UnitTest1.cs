    using StringCalculatorEval;

    namespace StringCalculator.Test
    {
        public class StringCalculatorTest
        {

            [Theory(DisplayName = "Quand on a une cha�ne (x,y)" +
                                  "Et quand on appelle Add " +
                                  "Elle renvoie l'addition de (x + y")]
            [InlineData(1, 2)]


            public void Testchar(int x, int y)
            {
                // Quand on a une cha�ne (1,2)"

                var entr�e = $"{x},{y}";

                // Et quand on appelle Add

                var r�sultat = AddString.Add(entr�e);

                // Elle renvoie l'addition de x+y (pour 1+2 renvoi)

                Assert.Equal(x + y, r�sultat);

            }

        [Theory(DisplayName = "Quand on a une cha�ne (x,y,z)" +
                              "Et quand on appelle Add " +
                              "Elle renvoie l'addition de (x + y+z)")]

        [InlineData(1, 2, 3)]
        
        public void TestPlus(int x, int y, int z)

        {
            //Quand on a une cha�ne (x,y,z)

            var entr�e = $"{x},{y},{z}";

            //Et quand on appelle Add
            var r�sultat = AddString.Add(entr�e);

            //Elle renvoie l'addition de (x + y +  z)
            Assert.Equal(x + y + z, r�sultat);
        }

    }
}