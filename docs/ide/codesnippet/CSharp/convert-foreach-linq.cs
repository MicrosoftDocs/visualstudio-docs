using System.Collections.Generic;
public class Class1
{
    public void MyMethod()
    {
        var greetings = new List<string>()
            { "hi", "yo", "hello", "howdy" };
        IEnumerable<string> enumerable()
        {
            foreach (var greet in greetings)
            {
                if (greet.Length < 3)
                {
                    yield return greet;
                }
            }
            yield break;
        }
    }
}