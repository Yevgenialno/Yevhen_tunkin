namespace Task2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string input = "stress";
            char? output = first_non_repeating_letter(input);
            char? expected = 't';
            Assert.IsTrue(output == expected);
        }

        [Test]
        public void Test2()
        {
            string input = "rststseer";
            char? output = first_non_repeating_letter(input);
            char? expected = null;
            Assert.IsTrue(output == expected);
        }

        [Test]
        public void Test3()
        {
            string input = "qwert";
            char? output = first_non_repeating_letter(input);
            char? expected = 'q';
            Assert.IsTrue(output == expected);
        }

        char? first_non_repeating_letter(string s)
        {
            char? ans = null;
            for(int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                ans = c;
                for(int j = 0; j < s.Length; j++)
                {
                    if ((c == s[j]) && (i != j))
                    {
                        ans = null;
                        break;
                    }
                }
                if (ans != null)
                    return ans;
            }
            return ans;
        }
    }
}