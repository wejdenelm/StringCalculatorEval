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

        [Fact]
        public void SautsDeLignesAutoris�s()
        {
            // Quand on a une cha�ne de nombres comprenant un saut de ligne

            var entr�e = string.Join(',', new int[] { 1, 2, 3 });
            var entr�eAvecSaut = AddString.Add(entr�e);

            // Et quand on appelle Add
            var r�sultatAvecSaut = AddString.Add(entr�e);

            //Elle renvoie toujours la somme des nombres

            var r�sultatSansSaut = AddString.Add(entr�e);

            Assert.Equal(r�sultatSansSaut, r�sultatAvecSaut);
        }

        [Fact]
        public void NombresN�gatifsNonAutoris�s()
        {
            // Quand on a une cha�ne de nombres comprenant un chiffre n�gatif 
            var entr�e = string.Join(',', new int[] { 1, 2, -3 });

            // Et quand on appelle Add
            void Act() => AddString.Add(entr�e);

            // Elle renvoie une exception et on donne la position du nombre n�gatif 
            var exception = Assert.Throws<ExceptionNegatif>(Act);

            Assert.Equal(-3, exception.nombreNegatif);
            Assert.Equal(-3, exception.positionNombreNegatif);
        }





    }
}