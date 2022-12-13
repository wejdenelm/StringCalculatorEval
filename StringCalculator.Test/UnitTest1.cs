    using StringCalculatorEval;

    namespace StringCalculator.Test
    {
        public class StringCalculatorTest
        {

            [Theory(DisplayName = "Quand on a une chaîne (x,y)" +
                                  "Et quand on appelle Add " +
                                  "Elle renvoie l'addition de (x + y")]
            [InlineData(1, 2)]
           


        public void Testchar(int x, int y)
            {
                // Quand on a une chaîne (1,2)"

                var entrée = $"{x},{y}";

                // Et quand on appelle Add

                var résultat = AddString.Add(entrée);

                // Elle renvoie l'addition de x+y (pour 1+2 renvoi)

                Assert.Equal(x + y, résultat);

            }

        [Theory(DisplayName = "Quand on a une chaîne (x,y,z)" +
                              "Et quand on appelle Add " +
                              "Elle renvoie l'addition de (x + y+z)")]

        [InlineData(1, 2, 3)]
        
        public void TestPlus(int x, int y, int z)

        {
            //Quand on a une chaîne (x,y,z)

            var entrée = $"{x},{y},{z}";

            //Et quand on appelle Add
            var résultat = AddString.Add(entrée);

            //Elle renvoie l'addition de (x + y +  z)
            Assert.Equal(x + y + z, résultat);
        }

        [Fact]
        public void SautsDeLignesAutorisés()
        {
            // Quand on a une chaîne de nombres comprenant un saut de ligne

            var entrée = string.Join(',', new int[] { 1, 2, 3 });
            var entréeAvecSaut = AddString.Add(entrée);

            // Et quand on appelle Add
            var résultatAvecSaut = AddString.Add(entrée);

            //Elle renvoie toujours la somme des nombres

            var résultatSansSaut = AddString.Add(entrée);

            Assert.Equal(résultatSansSaut, résultatAvecSaut);
        }

        [Fact]
        public void NombresNégatifsNonAutorisés()
        {
            // Quand on a une chaîne de nombres comprenant un chiffre négatif 
            var entrée = string.Join(',', new int[] { 1, 2, -3 });

            // Et quand on appelle Add
            void Act() => AddString.Add(entrée);

            // Elle renvoie une exception et on donne la position du nombre négatif 
            var exception = Assert.Throws<ExceptionNegatif>(Act);

            Assert.Equal(-3, exception.nombreNegatif);
            Assert.Equal(-3, exception.positionNombreNegatif);
        }





    }
}