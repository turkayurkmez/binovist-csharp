namespace functionsAndLoops
{
    public class Hangman
    {
        /*
         *      
         *           ONE JOB AT A TIME 
         *   
         * 1. Bir koleksiyon içinden rastgele kelime seç.
         * 2. Seçilen kelimeyi puzzle (****)'a çevir
         * 3. kullanıcıdan harf iste
         * 4. girilen harfi seçilen kelimede ara
         *    - varsa bulunduğu yer(ler)i göster a**a 
         *    - yoksa bir hak eksilt
         * 5. Kelimeyi tahmin edip etmeyeceğini sor
         *    - Edecekse karşılaştır.
         *    - Etmeyecekse 3. Adıma git
         */

        public string GetRandomWord(List<string> words)
        {
            return string.Empty;
        }
        public string ConvertToPuzzle(string word)
        {
            return "****";
        }
        public string GetLetterFromUser()
        {
            return "a";
        }
        public string searchLetterInPuzzle(string word, string letter, string puzzle)
        {
            return "a**a";
        }


        public bool isCorrect(string word, string puzzle) { return true; }
    }
}
